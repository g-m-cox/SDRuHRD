Option Strict Off
Option Explicit On

Friend Class frmAnaIn

    Inherits System.Windows.Forms.Form

    ' Create a new MccBoard object for Board 0
    Private DaqBoard As MccDaq.MccBoard = New MccDaq.MccBoard(0)
    Private Direction As MccDaq.DigitalPortDirection
    Private PortNum As MccDaq.DigitalPortType = MccDaq.DigitalPortType.AuxPort

    Public boolPulseSWRBit As Boolean

    Private Range As MccDaq.Range
    Private ADResolution, NumAIChans As Integer
    Private HighChan, LowChan, MaxChan As Integer

    Const NumPoints As Integer = 31744  ' Number of data points to collect
    '                                     For some devices, this number must be a
    '                                     multiple of the packet size. 31744 is a
    '                                     multiple of the most common packet sizes,
    '                                     so it satifies this requirement for most devices.

    Dim ADData() As UInt16              ' dimension an array to hold the input values

    Dim ADData32() As System.UInt32     ' dimension an array to hold the high resolution input values

    ' define a variable to contain the handle for memory allocated by Windows through
    ' MccDaq.MccService.WinBufAlloc() or MccDaq.MccService.WinBufAlloc32()
    Dim MemHandle As IntPtr

    Dim strSubkey As String = "Software\AF5LA\GMC1p5KWDisplay"
    Public lblADData As System.Windows.Forms.Label()


    Public Function boolPulseSWRReset() As Boolean
        Dim ULStat As MccDaq.ErrorInfo
        Dim DataValue As UInt16
        'DataValue = Convert.ToUInt16(8)
        'intPulseSWRResetState = 0

        If boolPulseSWRBit Then
            Direction = MccDaq.DigitalPortDirection.DigitalOut
            ULStat = DaqBoard.DConfigPort(PortNum, Direction)
            If ULStat.Value = MccDaq.ErrorInfo.ErrorCode.NoErrors Then


                'Set the SWR reset bit high
                DataValue = 8
                ULStat = DaqBoard.DOut(PortNum, DataValue)
                If ULStat.Value = MccDaq.ErrorInfo.ErrorCode.NoErrors Then
                    System.Threading.Thread.Sleep(100)
                    'reset the bit
                    DataValue = 0
                    ULStat = DaqBoard.DOut(PortNum, DataValue)
                    If ULStat.Value = MccDaq.ErrorInfo.ErrorCode.NoErrors Then
                        'Clear  the flag
                        boolPulseSWRBit = False
                        'Reset the direction
                        Direction = MccDaq.DigitalPortDirection.DigitalIn
                        ULStat = DaqBoard.DConfigPort(PortNum, Direction)
                    End If
                End If

                If ULStat.Value = MccDaq.ErrorInfo.ErrorCode.NoErrors Then
                    Return True
                Else
                    boolPulseSWRBit = False
                    Return False
                End If
            Else
                Return False
            End If
        Else
                Return True
        End If

    End Function


    Private Sub frmAnaIn_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim DefaultTrig As Long
        Dim frmMyForm As Windows.Forms.Form
        Dim strErrStr As String = ""
        Dim mbrMBRET As MsgBoxResult

        InitUL()

        frmMyForm = sender
        If Not regSetFrmLocation(strSubkey, frmMyForm, strErrStr) Then
            mbrMBRET = MsgBox("Location Set failed " & vbCrLf & strErrStr)
        End If




        ' determine the number of analog channels and their capabilities
        Dim ChannelType As Integer = ANALOGINPUT
        NumAIChans = FindAnalogChansOfType(DaqBoard, ChannelType,
            ADResolution, Range, LowChan, DefaultTrig)

        If (NumAIChans = 0) Then
            lblInstruction.Text = "Board " & DaqBoard.BoardNum.ToString() &
            " does not have analog input channels."
            cmdStartBgnd.Enabled = False
            txtHighChan.Enabled = False
        Else
            ' Check the resolution of the A/D data and allocate memory accordingly
            If ADResolution > 16 Then
                ' set aside memory to hold high resolution data
                ReDim ADData32(NumPoints)
                MemHandle = MccDaq.MccService.WinBufAlloc32Ex(NumPoints)
            Else
                ' set aside memory to hold 16-bit data
                ReDim ADData(NumPoints)
                MemHandle = MccDaq.MccService.WinBufAllocEx(NumPoints)
            End If
            If MemHandle = 0 Then Stop
            If (NumAIChans > 8) Then NumAIChans = 8 'limit to 8 for display
            MaxChan = LowChan + NumAIChans - 1
            lblInstruction.Text = "Board " & DaqBoard.BoardNum.ToString() &
                " collecting analog data on up to " & NumAIChans.ToString() &
                " channels using AInScan with Range set to " & Range.ToString() & "."
        End If


    End Sub
    Private Sub cmdStartBgnd_Click(ByVal eventSender As System.Object,
        ByVal eventArgs As System.EventArgs) Handles cmdStartBgnd.Click


        Dim CurIndex As Integer
        Dim CurCount As Integer
        Dim Status As Short
        Dim ULStat As MccDaq.ErrorInfo
        Dim Options As MccDaq.ScanOptions
        Dim Rate As Integer
        Dim Count As Integer
        Dim ValidChan As Boolean
        Dim MBRet As DialogResult

        cmdStartBgnd.Enabled = False
        cmdStartBgnd.Visible = False
        cmdStopConvert.Enabled = True
        cmdStopConvert.Visible = True
        cmdQuit.Enabled = False

        ' Collect the values by calling MccDaq.MccBoard.AInScan
        '  Parameters:
        '    LowChan    :the first channel of the scan
        '    HighChan   :the last channel of the scan
        '    Count      :the total number of A/D samples to collect
        '    Rate       :sample rate
        '    Range      :the range for the board
        '    MemHandle  :Handle for Windows buffer to store data in
        '    Options    :data collection options

        ValidChan = Integer.TryParse(txtHighChan.Text, HighChan)
        If ValidChan Then
            If (HighChan > MaxChan) Then HighChan = MaxChan
            txtHighChan.Text = Format(HighChan, "0")
        End If

        Count = NumPoints     ' total number of data points to collect

        ' per channel sampling rate ((samples per second) per channel)
        'Rate = 1000 / ((HighChan - LowChan) + 1)
        Rate = 200 / ((HighChan - LowChan) + 1)

        Options = MccDaq.ScanOptions.Background Or MccDaq.ScanOptions.Continuous

        ULStat = DaqBoard.AInScan(LowChan, HighChan, Count, Rate, Range, MemHandle, Options)

        If ULStat.Value <> MccDaq.ErrorInfo.ErrorCode.NoErrors Then Stop

        ULStat = DaqBoard.GetStatus(Status, CurCount, CurIndex, MccDaq.FunctionType.AiFunction)
        If ULStat.Value <> MccDaq.ErrorInfo.ErrorCode.NoErrors Then
            If ULStat.Value <> MccDaq.ErrorInfo.ErrorCode.NoErrors Then
                MBRet = MessageBox.Show("Error occured in cmdStartBgnd_click" & vbCrLf & ULStat.Message, "Error")
                Stop
            End If

            Stop
        End If

        If Status = MccDaq.MccBoard.Running Then
            lblShowStat.Text = "Running"
            'lblShowCount.Text = CurCount.ToString("D")
            'lblShowIndex.Text = CurIndex.ToString("D")
        End If
        tmrCheckStatus.Enabled = True


    End Sub

    Private Sub tmrCheckStatus_Tick(ByVal eventSender As System.Object,
    ByVal eventArgs As System.EventArgs) Handles tmrCheckStatus.Tick

        Dim j As Integer
        Dim i As Integer
        Dim FirstPoint, NumChans As Integer
        Dim ULStat As MccDaq.ErrorInfo
        Dim CurIndex As Integer
        Dim CurCount As Integer
        Dim Status As Short
        Dim MBRet As DialogResult

        Dim DataValue As UInt16
        Dim PortNum As MccDaq.DigitalPortType = MccDaq.DigitalPortType.AuxPort



        tmrCheckStatus.Stop()


        ' Check the status of the background data collection

        ' Parameters:
        '   Status      :current status of the background data collection
        '   CurCount    :current number of samples collected
        '   CurIndex    :index to the data buffer pointing to the start of the
        '                most recently collected scan
        '   FunctionType: A/D operation (MccDaq.FunctionType.AiFunction)

        'Disable error handling!!!
        'ULStat = MccDaq.MccService.ErrHandling _
        '(MccDaq.ErrorReporting.DontPrint, MccDaq.ErrorHandling.DontStop)

        Try
            ULStat = DaqBoard.GetStatus(Status, CurCount, CurIndex, MccDaq.FunctionType.AiFunction)
        Catch ex As Exception
            lblErrInfo.Text = "DaqBoard.GetStatus Threw Error" & vbCrLf & ex.Message
            tmrCheckStatus.Start()
            Exit Sub
        End Try

        If ULStat.Value <> MccDaq.ErrorInfo.ErrorCode.NoErrors Then
            'If ULStat.Value <> MccDaq.ErrorInfo.ErrorCode.Overrun Then
            lblErrInfo.Text = "DaqBoard.GetStatus Error" & vbCrLf & ULStat.Message
            'Stop
            'End If
        End If


        lblShowCount.Text = CurCount.ToString("D")
        lblShowIndex.Text = CurIndex.ToString("D")

        ' Check the background operation.
        ' transfer the data from the memory buffer set up by Windows to an
        ' array for use by Visual Basic
        ' The background operation must be explicitly stopped

        ULStat = DaqBoard.GetStatus(Status, CurCount, CurIndex, MccDaq.FunctionType.AiFunction)
        If ULStat.Value <> MccDaq.ErrorInfo.ErrorCode.NoErrors Then
            If ULStat.Value <> MccDaq.ErrorInfo.ErrorCode.NoErrors Then
                MBRet = MessageBox.Show("Error occured in CheckBackground" & vbCrLf & ULStat.Message, "Error")
                Stop
            End If
        End If



        If Status = MccDaq.MccBoard.Running Then lblShowStat.Text = "Running"
        lblShowCount.Text = CurCount.ToString("D")
        lblShowIndex.Text = CurIndex.ToString("D")
        NumChans = (HighChan - LowChan) + 1
        If CurIndex > HighChan Then
            If MemHandle = 0 Then Stop
            FirstPoint = CurIndex 'start of latest channel scan in MemHandle buffer

            'If ADResolution > 16 Then
            '    ULStat = MccDaq.MccService.WinBufToArray32(MemHandle, ADData32, FirstPoint, NumChans)
            '    If ULStat.Value <> MccDaq.ErrorInfo.ErrorCode.NoErrors Then Stop

            '    For i = 0 To HighChan
            '        lblADData(i).Text = ADData32(i).ToString("D")
            '    Next i
            'Else
            ULStat = MccDaq.MccService.WinBufToArray(MemHandle, ADData, FirstPoint, NumChans)
            If ULStat.Value <> MccDaq.ErrorInfo.ErrorCode.NoErrors Then
                If ULStat.Value <> MccDaq.ErrorInfo.ErrorCode.NoErrors Then
                    MBRet = MessageBox.Show("Error occured in StopBackground" & vbCrLf & ULStat.Message, "Error")
                    Stop
                End If
            End If

            For i = 0 To HighChan
                lblADData(i).Text = ADData(i).ToString("D")
            Next i

            'End If

            For j = HighChan + 1 To 7
                lblADData(j).Text = ""
            Next j

        End If

        'Stop background while we do the digital in/out
        ULStat = DaqBoard.StopBackground(MccDaq.FunctionType.AiFunction)
        If ULStat.Value <> MccDaq.ErrorInfo.ErrorCode.NoErrors Then
            MBRet = MessageBox.Show("Error occured in StopBackground" & vbCrLf & ULStat.Message, "Error")
            Stop
        End If

        'Get the Digital inputs:
        ULStat = DaqBoard.DIn(PortNum, DataValue)
        lblAuxPortValue.Text = DataValue.ToString

        frm1p5KWDisplay.UpdAnalogControls(ADData)

        frm1p5KWDisplay.UpdDigitalControls(DataValue)

        'Reset the SWR fault if set
        If boolPulseSWRReset() Then
            'lblErrInfo.Text = "Entering PulseSWRReset"
        Else
            lblErrInfo.Text = "PulseSWRReset failed"
        End If

        Dim eaEventArgs As EventArgs = EventArgs.Empty

        'tmrCheckStatus.Start()
        'Restart the background process
        cmdStartBgnd_Click(Me, eaEventArgs)

    End Sub

    Private Sub frmAnaIn_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

        Dim frmMyForm As Windows.Forms.Form
        Dim strErrStr As String = ""
        Dim mbrMBRET As MsgBoxResult

        frmMyForm = sender
        If Not regSaveFrmLocation(strSubkey, frmMyForm, strErrStr) Then
            mbrMBRET = MsgBox("Location Save failed " & vbCrLf & strErrStr)
        End If

    End Sub

    Private Sub frmAnaIn_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        frm1p5KWDisplay.Activate()
    End Sub

    Private Sub cmdStopConvert_Click(ByVal eventSender As System.Object,
    ByVal eventArgs As System.EventArgs) Handles cmdStopConvert.Click

        Dim CurIndex As Integer
        Dim CurCount As Integer
        Dim Status As Short
        Dim ULStat As MccDaq.ErrorInfo

        ULStat = DaqBoard.StopBackground(MccDaq.FunctionType.AiFunction)
        If ULStat.Value <> MccDaq.ErrorInfo.ErrorCode.NoErrors Then Stop

        cmdStartBgnd.Enabled = True : cmdStartBgnd.Visible = True
        cmdStopConvert.Enabled = False : cmdStopConvert.Visible = False
        cmdQuit.Enabled = True
        tmrCheckStatus.Enabled = False

        ULStat = DaqBoard.GetStatus(Status, CurCount, CurIndex, MccDaq.FunctionType.AiFunction)
        If ULStat.Value <> MccDaq.ErrorInfo.ErrorCode.NoErrors Then Stop

        If Status = MccDaq.MccBoard.Idle Then lblShowStat.Text = "Idle"
        lblShowCount.Text = CurCount.ToString("D")
        lblShowIndex.Text = CurIndex.ToString("D")

    End Sub

    Private Sub cmdQuit_Click(ByVal eventSender As System.Object,
    ByVal eventArgs As System.EventArgs) Handles cmdQuit.Click

        Dim ULStat As MccDaq.ErrorInfo

        ' Free up memory for use by other programs
        ULStat = MccDaq.MccService.WinBufFreeEx(MemHandle)
        'If ULStat.Value <> MccDaq.ErrorInfo.ErrorCode.NoErrors Then Stop

        frm1p5KWDisplay.Close()
        Me.Close()
        End
    End Sub


#Region "Universal Library Initialization - Expand this region to change error handling, etc."

    Private Sub InitUL()

        Dim ULStat As MccDaq.ErrorInfo

        ' declare revision level of Universal Library

        ULStat = MccDaq.MccService.DeclareRevision(MccDaq.MccService.CurrentRevNum)

        ' Initiate error handling
        '  activating error handling will trap errors like
        '  bad channel numbers and non-configured conditions.
        '  Parameters:
        '    MccDaq.ErrorReporting.PrintAll :all warnings and errors encountered will be printed
        '    MccDaq.ErrorHandling.StopAll   :if any error is encountered, the program will stop

        ReportError = MccDaq.ErrorReporting.PrintAll
        HandleError = MccDaq.ErrorHandling.StopAll
        ULStat = MccDaq.MccService.ErrHandling(ReportError, HandleError)
        If ULStat.Value <> MccDaq.ErrorInfo.ErrorCode.NoErrors Then
            Stop
        End If

        ' Note: Any change to label names requires a change to the corresponding array element below
        lblADData = (New System.Windows.Forms.Label() {Me._lblADData_0,
        Me._lblADData_1, Me._lblADData_2, Me._lblADData_3, Me._lblADData_4,
        Me._lblADData_5, Me._lblADData_6, Me._lblADData_7})

        frm1p5KWDisplay.Show()

    End Sub

#End Region

End Class

