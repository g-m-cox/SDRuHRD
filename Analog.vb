Module AnalogIO

    Public Const ANALOGINPUT As Integer = 1
    Public Const ANALOGOUTPUT As Integer = 2
    Public Const ANALOGDAQIN As Integer = 3
    Public Const ANALOGDAQOUT As Integer = 4
    Public Const PRETRIGIN As Integer = 9
    Public Const ATRIGIN As Integer = 17

    Public ATrigRes As Integer
    Public ATrigRange As Integer
    Private TestBoard As MccDaq.MccBoard
    Private ADRes, DARes As Integer
    Private ValidRanges() As MccDaq.Range

    Public Function FindAnalogChansOfType(ByVal DaqBoard As MccDaq.MccBoard, _
    ByVal AnalogType As Integer, ByRef Resolution As Integer, _
    ByRef DefaultRange As MccDaq.Range, ByRef DefaultChan As Integer, _
    ByRef DefaultTrig As MccDaq.TriggerType) As Integer

        Dim status As Short
        Dim ChansFound, IOType As Integer
        Dim curCount, curIndex As Integer
        Dim CheckOutputEvents, CheckInputEvents As Boolean
        Dim CheckPretrig, CheckATrig As Boolean
        Dim RangeFound As Boolean
        Dim ULStat As MccDaq.ErrorInfo
        Dim TestRange As MccDaq.Range, HardRange As MccDaq.Range
        Dim FunctionType As MccDaq.FunctionType

        'check supported features by trial 
        'and error with error handling disabled
        ULStat = MccDaq.MccService.ErrHandling _
        (MccDaq.ErrorReporting.DontPrint, MccDaq.ErrorHandling.DontStop)

        TestBoard = DaqBoard
        ATrigRes = 0
        DefaultRange = MccDaq.Range.NotUsed
        ULStat = New MccDaq.ErrorInfo(0)
        IOType = AnalogType And 7
        Select Case IOType
            Case ANALOGINPUT, ANALOGDAQIN
                ' Get the number of analog input channels
                ULStat = DaqBoard.BoardConfig.GetNumAdChans(ChansFound)
                If Not ULStat.Value = MccDaq.ErrorInfo.ErrorCode.NoErrors Then
                    DisplayError(ULStat)
                    FindAnalogChansOfType = ChansFound
                    Exit Function
                End If
                If ChansFound > 0 Then
                    ' Get the resolution of A/D
                    ULStat = DaqBoard.BoardConfig.GetAdResolution(ADRes)
                    If ULStat.Value = MccDaq.ErrorInfo.ErrorCode.NoErrors Then Resolution = ADRes
                    If (AnalogType And &HF00&) > 0 Then CheckInputEvents = True
                    'check ranges for a valid default
                    ULStat = DaqBoard.BoardConfig.GetRange(HardRange)
                    RangeFound = Not ((HardRange = MccDaq.Range.NotUsed) _
                        Or (HardRange = 300) Or (HardRange = 301))
                    If Not RangeFound Then
                        RangeFound = TestInputRanges(TestRange)
                    Else
                        TestRange = HardRange
                    End If
                    If RangeFound Then DefaultRange = TestRange
                    If IOType = ANALOGDAQIN Then
                        FunctionType = MccDaq.FunctionType.DaqiFunction
                        ULStat = DaqBoard.GetStatus(status, curCount, curIndex, FunctionType)
                        If Not ULStat.Value = MccDaq.ErrorInfo.ErrorCode.NoErrors Then
                            FindAnalogChansOfType = 0
                            Exit Function
                        End If
                    End If
                End If
            Case ANALOGOUTPUT, ANALOGDAQOUT
                ' Get the number of analog output channels
                ULStat = DaqBoard.BoardConfig.GetNumDaChans(ChansFound)
                If Not ULStat.Value = MccDaq.ErrorInfo.ErrorCode.NoErrors Then
                    DisplayError(ULStat)
                    FindAnalogChansOfType = ChansFound
                    Exit Function
                End If
                If ChansFound > 0 Then
                    ULStat = TestBoard.GetConfig(2, 0, 292, DARes)
                    Resolution = DARes
                    If (AnalogType And &HF00&) > 0 Then CheckOutputEvents = True
                    RangeFound = TestOutputRanges(TestRange)
                    If RangeFound Then DefaultRange = TestRange
                    If IOType = ANALOGDAQOUT Then
                        FunctionType = MccDaq.FunctionType.DaqoFunction
                        ULStat = DaqBoard.GetStatus(status, curCount, curIndex, FunctionType)
                        If Not ULStat.Value = MccDaq.ErrorInfo.ErrorCode.NoErrors Then
                            FindAnalogChansOfType = 0
                            Exit Function
                        End If
                    End If
                End If
        End Select

        CheckATrig = ((AnalogType And ATRIGIN) = ATRIGIN)
        If (ChansFound > 0) And CheckATrig Then
            ULStat = DaqBoard.SetTrigger(MccDaq.TriggerType.TrigAbove, 0, 0)
            If ULStat.Value = MccDaq.ErrorInfo.ErrorCode.NoErrors Then
                DefaultTrig = MccDaq.TriggerType.TrigAbove
                GetTrigResolution()
            Else
                ChansFound = 0
            End If
        End If

        CheckPretrig = ((AnalogType And PRETRIGIN) = PRETRIGIN)
        If (ChansFound > 0) And CheckPretrig Then
            ' if DaqSetTrigger supported, trigger type is analog
            ULStat = DaqBoard.DaqSetTrigger(MccDaq.TriggerSource.TrigImmediate, _
            MccDaq.TriggerSensitivity.AboveLevel, 0, MccDaq.ChannelType.Analog, _
            DefaultRange, 0.0, 0.1, MccDaq.TriggerEvent.Start)
            If ULStat.Value = MccDaq.ErrorInfo.ErrorCode.NoErrors Then
                DefaultTrig = MccDaq.TriggerType.TrigAbove
            Else
                ULStat = DaqBoard.SetTrigger(MccDaq.TriggerType.TrigPosEdge, 0, 0)
                If ULStat.Value = MccDaq.ErrorInfo.ErrorCode.NoErrors Then
                    DefaultTrig = MccDaq.TriggerType.TrigPosEdge
                Else
                    ChansFound = 0
                End If
            End If
        End If
        ULStat = MccDaq.MccService.ErrHandling(ReportError, HandleError)

        DefaultChan = 0

        FindAnalogChansOfType = ChansFound

    End Function

    Private Function TestInputRanges(ByRef DefaultRange As MccDaq.Range) As Boolean

        Dim dataValue As Short
        Dim ULStat As MccDaq.ErrorInfo
        Dim TestRange As MccDaq.Range
        Dim dataHRValue, Options As Integer
        Dim index As Integer = 0
        Dim ConnectionConflict As String

        ConnectionConflict = "This network device is in use by another process or user." & _
           vbCrLf & vbCrLf & "Check for other users on the network and close any applications " & _
           vbCrLf & "(such as Instacal) that may be accessing the network device."
        ValidRanges = New MccDaq.Range(49) {}
        TestInputRanges = False
        DefaultRange = MccDaq.Range.NotUsed
        Options = 0
        For Each TestRange In MccDaq.Range.GetValues(TestRange.GetType())
            If (ADRes > 16) Then
                ULStat = TestBoard.AIn32(0, TestRange, dataHRValue, Options)
            Else
                ULStat = TestBoard.AIn(0, TestRange, dataValue)
            End If
            If ULStat.Value = MccDaq.ErrorInfo.ErrorCode.NoErrors Then
                If DefaultRange = MccDaq.Range.NotUsed Then DefaultRange = TestRange
                TestInputRanges = True
                ValidRanges.SetValue(TestRange, index)
                index = index + 1
            Else
                If ULStat.Value = MccDaq.ErrorInfo.ErrorCode.NetDevInUseByAnotherProc _
                    Or ULStat.Value = MccDaq.ErrorInfo.ErrorCode.NetDevInUse Then
                    MsgBox(ConnectionConflict$, vbCritical, "Device In Use")
                    ValidRanges.SetValue(DefaultRange, index)
                    index = index + 1
                    Exit For
                End If
            End If
        Next
        Array.Resize(ValidRanges, index)

    End Function

    Private Function TestOutputRanges(ByRef DefaultRange As MccDaq.Range) As Boolean

        Dim dataValue As Short
        Dim configVal As Integer
        Dim ULStat As MccDaq.ErrorInfo
        Dim TestRange As MccDaq.Range
        Dim ConnectionConflict As String

        ConnectionConflict = "This network device is in use by another process or user." & _
           vbCrLf & vbCrLf & "Check for other users on the network and close any applications " & _
           vbCrLf & "(such as Instacal) that may be accessing the network device."

        TestOutputRanges = False
        TestRange = -5
        ULStat = TestBoard.AOut(0, TestRange, dataValue)
        If ULStat.Value = MccDaq.ErrorInfo.ErrorCode.NoErrors Then
            ULStat = TestBoard.GetConfig(2, 0, 114, configVal)
            If ULStat.Value = MccDaq.ErrorInfo.ErrorCode.NoErrors Then
                DefaultRange = configVal
                TestOutputRanges = True
            End If
        Else
            DefaultRange = MccDaq.Range.NotUsed
            For Each TestRange In MccDaq.Range.GetValues(TestRange.GetType())
                ULStat = TestBoard.AOut(0, TestRange, dataValue)
                If ULStat.Value = MccDaq.ErrorInfo.ErrorCode.NoErrors Then
                    If DefaultRange = MccDaq.Range.NotUsed Then DefaultRange = TestRange
                    TestOutputRanges = True
                    Exit For
                Else
                    If ULStat.Value = MccDaq.ErrorInfo.ErrorCode.NetDevInUseByAnotherProc Or _
                        ULStat.Value = MccDaq.ErrorInfo.ErrorCode.NetDevInUse Then
                        MsgBox(ConnectionConflict$, vbCritical, "Device In Use")
                        DefaultRange = MccDaq.Range.NotUsed
                        TestOutputRanges = False
                        Exit For
                    End If
                End If
            Next
        End If

    End Function

    Public Function GetRangeList() As System.Array

        Dim DefaultRange As MccDaq.Range
        Dim ULStat As MccDaq.ErrorInfo

        'check supported ranges by trial 
        'and error with error handling disabled
        ULStat = MccDaq.MccService.ErrHandling _
        (MccDaq.ErrorReporting.DontPrint, MccDaq.ErrorHandling.DontStop)

        TestInputRanges(DefaultRange)
        GetRangeList = ValidRanges

        ULStat = MccDaq.MccService.ErrHandling(ReportError, HandleError)

    End Function

    Private Sub GetTrigResolution()

        Dim BoardID, TrigSource As Integer
        Dim ULStat As MccDaq.ErrorInfo

        ULStat = TestBoard.GetConfig(2, 0, 209, TrigSource)
        ULStat = TestBoard.BoardConfig.GetBoardType(BoardID)
        Select Case BoardID
            Case 95, 96, 97, 98, 102
                'PCI-DAS6030, 6031, 6032, 6033, 6052
                ATrigRes = 12
                ATrigRange = 20
                If TrigSource > 0 Then ATrigRange = -1
            Case 165, 166, 167, 168
                'PCI-2511, 2513, 2515, 2517
                ATrigRes = 12
                ATrigRange = 20
                If TrigSource > 0 Then ATrigRange = -1
            Case 177, 178, 179, 180
                'USB-2523, 2527, 2533, 2537
                ATrigRes = 12
                ATrigRange = 20
                If TrigSource > 0 Then ATrigRange = -1
            Case 203, 204, 205, 213, 214, 215, 216, 217
                'USB-1616HS, 1616HS-2, 1616HS-4, 1616HS-BNC
                'USB-1602HS, 1602HS-2AO, 1604HS, 1604HS-2AO
                ATrigRes = 12
                ATrigRange = 20
                If TrigSource > 0 Then ATrigRange = -1
            Case 101, 103, 104
                'PCI-DAS6040, 6070, 6071
                ATrigRes = 8
                ATrigRange = 20
                If TrigSource > 0 Then ATrigRange = -1
            Case Else
                ATrigRes = 0
        End Select

    End Sub

    Public Function GetRangeVolts(ByVal Range As MccDaq.Range) As Single

        Dim RangeString As String = ""
        Dim RangeVolts As Single

        GetRangeInfo(Range, RangeString, RangeVolts)
        GetRangeVolts = RangeVolts

    End Function

    Private Sub GetRangeInfo(ByVal Range As MccDaq.Range, ByRef RangeString As String, ByRef RangeVolts As Single)

        Select Case Range
            Case MccDaq.Range.NotUsed
                RangeString = "NOTUSED"
                RangeVolts = 0
            Case MccDaq.Range.Bip60Volts
                RangeString = "BIP60VOLTS"
                RangeVolts = 120  '125.274
                'to do - switch to toengunits
            Case MccDaq.Range.Bip30Volts
                RangeString = "BIP30VOLTS"
                RangeVolts = 60
            Case MccDaq.Range.Bip20Volts
                RangeString = "BIP20VOLTS"
                RangeVolts = 40
            Case MccDaq.Range.Bip15Volts
                RangeString = "BIP15VOLTS"
                RangeVolts = 30
            Case MccDaq.Range.Bip10Volts
                RangeString = "BIP10VOLTS"
                RangeVolts = 20
            Case MccDaq.Range.Bip5Volts
                RangeString = "BIP5VOLTS"
                RangeVolts = 10
            Case MccDaq.Range.Bip4Volts
                RangeString = "BIP4VOLTS"
                RangeVolts = 8
            Case MccDaq.Range.Bip2Pt5Volts
                RangeString = "BIP2PT5VOLTS"
                RangeVolts = 5
            Case MccDaq.Range.Bip2Volts
                RangeString = "BIP2VOLTS"
                RangeVolts = 4
            Case MccDaq.Range.Bip1Pt25Volts
                RangeString = "BIP1PT25VOLTS"
                RangeVolts = 2.5
            Case MccDaq.Range.Bip1Volts
                RangeString = "BIP1VOLTS"
                RangeVolts = 2
            Case MccDaq.Range.BipPt625Volts
                RangeString = "BIPPT625VOLTS"
                RangeVolts = 1.25
            Case MccDaq.Range.BipPt5Volts
                RangeString = "BIPPT5VOLTS"
                RangeVolts = 1
            Case MccDaq.Range.BipPt1Volts
                RangeString = "BIPPT1VOLTS"
                RangeVolts = 0.2
            Case MccDaq.Range.BipPt05Volts
                RangeString = "BIPPT05VOLTS"
                RangeVolts = 0.1
            Case MccDaq.Range.BipPt312Volts
                RangeString = "BIPPT312VOLTS"
                RangeVolts = 0.624
            Case MccDaq.Range.BipPt25Volts
                RangeString = "BIPPT25VOLTS"
                RangeVolts = 0.5
            Case MccDaq.Range.BipPt2Volts
                RangeString = "BIPPT2VOLTS"
                RangeVolts = 0.4
            Case MccDaq.Range.BipPt156Volts
                RangeString = "BIPPT156VOLTS"
                RangeVolts = 0.3125
            Case MccDaq.Range.BipPt125Volts
                RangeString = "BIPPT125VOLTS"
                RangeVolts = 0.25
            Case MccDaq.Range.BipPt1Volts
                RangeString = "BIPPT1VOLTS"
                RangeVolts = 0.2
            Case MccDaq.Range.BipPt078Volts
                RangeString = "BIPPT078VOLTS"
                RangeVolts = 0.15625
            Case MccDaq.Range.BipPt05Volts
                RangeString = "BIPPT05VOLTS"
                RangeVolts = 0.1
            Case MccDaq.Range.BipPt01Volts
                RangeString = "BIPPT01VOLTS"
                RangeVolts = 0.02
            Case MccDaq.Range.BipPt005Volts
                RangeString = "BIPPT005VOLTS"
                RangeVolts = 0.01
            Case MccDaq.Range.Bip1Pt67Volts
                RangeString = "BIP1PT67VOLTS"
                RangeVolts = 3.34
            Case MccDaq.Range.Uni10Volts
                RangeString = "UNI10VOLTS"
                RangeVolts = 10
            Case MccDaq.Range.Uni5Volts
                RangeString = "UNI5VOLTS"
                RangeVolts = 5
            Case MccDaq.Range.Uni4Volts
                RangeString = "UNI4VOLTS"
                RangeVolts = 4.096
            Case MccDaq.Range.Uni2Pt5Volts
                RangeString = "UNI2PT5VOLTS"
                RangeVolts = 2.5
            Case MccDaq.Range.Uni2Volts
                RangeString = "UNI2VOLTS"
                RangeVolts = 2
            Case MccDaq.Range.Uni1Pt25Volts
                RangeString = "UNI1PT25VOLTS"
                RangeVolts = 1.25
            Case MccDaq.Range.Uni1Volts
                RangeString = "UNI1VOLTS"
                RangeVolts = 1
            Case MccDaq.Range.BipPt5Volts
                RangeString = "UNIPT5VOLTS"
                RangeVolts = 0.5
            Case MccDaq.Range.UniPt25Volts
                RangeString = "UNIPT25VOLTS"
                RangeVolts = 0.25
            Case MccDaq.Range.UniPt2Volts
                RangeString = "UNIPT2VOLTS"
                RangeVolts = 0.2
            Case MccDaq.Range.UniPt1Volts
                RangeString = "UNIPT1VOLTS"
                RangeVolts = 0.1
            Case MccDaq.Range.UniPt05Volts
                RangeString = "UNIPT05VOLTS"
                RangeVolts = 0.05
            Case MccDaq.Range.UniPt01Volts
                RangeString = "UNIPT01VOLTS"
                RangeVolts = 0.01
            Case MccDaq.Range.UniPt02Volts
                RangeString = "UNIPT02VOLTS"
                RangeVolts = 0.02
            Case MccDaq.Range.Uni1Pt67Volts
                RangeString = "UNI1PT67VOLTS"
                RangeVolts = 1.67
            Case MccDaq.Range.Ma4To20
                RangeString = "MA4TO20"
                RangeVolts = 16
            Case MccDaq.Range.Ma2To10
                RangeString = "MA2to10"
                RangeVolts = 8
            Case MccDaq.Range.Ma1To5
                RangeString = "MA1TO5"
                RangeVolts = 4
            Case MccDaq.Range.MaPt5To2Pt5
                RangeString = "MAPT5TO2PT5"
                RangeVolts = 2
            Case MccDaq.Range.Ma0To20
                RangeString = "MA0TO20"
                RangeVolts = 20
            Case MccDaq.Range.BipPt025Amps
                RangeString = "BIPPT025A"
                RangeVolts = 0.05
            Case MccDaq.Range.BipPt025VoltsPerVolt
                RangeString = "BIPPT025VPERV"
                RangeVolts = 0.05
        End Select

    End Sub

End Module
