Option Strict On

Module modSDRuHRD1
    Public strSDRunoPortName As String
    Public strHRDPortName As String

    'Sudo comm ports baud rate is ignored...
    'I suspect that the code just copies the send port bytes to
    'the receive port bytes, they never are serialized so baud doesn't matter
    Public intSDRUnoBaudRate As Integer = 57600
    Public intHRDBaudRate As Integer = 57600

    Public MyThread As System.Threading.Thread

    Public strExMsg As String
    Public strFreq As String
    Public strMode As String
    Public intHRDWrtDelay As Integer




    Public Sub SyncRadios()
        Dim strStatus As String
        Dim strOldStatus As String
        Dim intLength As Integer

        Try
            If Not OpenPorts() Then
                Return
            End If

            'Get SDRUno status string
            strStatus = ""
            strStatus = GetStatusStr(frmSDRuHRD.SerialPortSDRUno)
            If (Len(strStatus) <> 37) Then
                frmSDRuHRD.txtSDRuLastRcvd.Text = strStatus
                frmSDRuHRD.txtErrMsg.Text = "Invalid reply from SdrUno Comm Port = " & strStatus
                Return
            Else
                frmSDRuHRD.txtErrMsg.Text = ""
            End If
            strOldStatus = frmSDRuHRD.txtSDRuLastRcvd.Text
            'Check to see if SdrUno's status changed
            If strStatus <> strOldStatus Then
                'Update HRD to SDRUno's new status
                'Get the frequency and Mode:
                strFreq = Mid(strStatus, 3, 11)
                strMode = Mid(strStatus, 30, 1)

                If WriteNewStatus(frmSDRuHRD.SerialPortHRD, "FA" & strFreq, strExMsg) Then
                    'HRD needs time to complete
                    MyThread.Sleep(intHRDWrtDelay)
                Else
                    frmSDRuHRD.txtErrMsg.Text = "Failed to write Frequency to HRD " & strExMsg
                    Return
                End If


                If WriteNewStatus(frmSDRuHRD.SerialPortHRD, "MD" & strMode, strExMsg) Then
                    frmSDRuHRD.txtSDRuLastRcvd.Text = strStatus
                    MyThread.Sleep(intHRDWrtDelay) 'HRD needs time to complete
                Else
                    frmSDRuHRD.txtErrMsg.Text = "Failed to write Mode to HRD " & strExMsg
                    Return
                End If

                frmSDRuHRD.txtSDRuLastRcvd.Text = strStatus
                frmSDRuHRD.txtErrMsg.Text = ""
                'Update HRDLastReceived to reflect the new change:
                For i = 1 To 20 'Read until HRD reports new Freq and Mode values
                    strStatus = GetStatusStr(frmSDRuHRD.SerialPortHRD)
                    If (Len(strStatus) <> 37) Then
                        frmSDRuHRD.txtErrMsg.Text = "Invalid reply from HRD Comm Port = " & strStatus
                    Else
                        frmSDRuHRD.txtErrMsg.Text = ""
                        If Mid(strStatus, 3, 11) = strFreq And Mid(strStatus, 30, 1) = strMode Then
                            'HRD new status is up to date
                            Debug.Print("HRD For-Next loop count = " & i.ToString)
                            Exit For
                        End If
                    End If
                    MyThread.Sleep(intHRDWrtDelay)
                Next
                If (Len(strStatus) <> 37) Then
                    frmSDRuHRD.txtErrMsg.Text = "Invalid reply from HRD Comm Port = " & strStatus
                Else
                    frmSDRuHRD.txtErrMsg.Text = ""
                    frmSDRuHRD.txtHRDLastRcvd.Text = strStatus
                End If
                Return
            End If


            'Get HRD status string
            strStatus = ""
            strStatus = GetStatusStr(frmSDRuHRD.SerialPortHRD)
            intLength = Len(strStatus)
            If intLength <> 37 Then
                If intLength = 39 Then
                    'Returns two spaces in front of the status.
                    'Happens evry time when SDRUno frequency changes HRD frequency
                    Return
                End If
                frmSDRuHRD.txtErrMsg.Text = "Invalid reply from HRD Comm Port = " & strStatus
                Return
            Else
                frmSDRuHRD.txtErrMsg.Text = ""
            End If
            strOldStatus = frmSDRuHRD.txtHRDLastRcvd.Text
            'Check to see if HRD's status changed
            If strStatus <> strOldStatus Then
                'Update SDRUno to HRD new status
                'Get the frequency and Mode:
                strFreq = Mid(strStatus, 3, 11)
                strMode = Mid(strStatus, 30, 1)

                If WriteNewStatus(frmSDRuHRD.SerialPortSDRUno, "FA" & strFreq, strExMsg) Then
                    MyThread.Sleep(intHRDWrtDelay)
                Else
                    frmSDRuHRD.txtErrMsg.Text = "Failed to write Frequency to SDRUno " & strExMsg
                    Return
                End If


                If WriteNewStatus(frmSDRuHRD.SerialPortSDRUno, "MD" & strMode, strExMsg) Then
                    frmSDRuHRD.txtHRDLastRcvd.Text = strStatus
                    Return
                Else
                    frmSDRuHRD.txtErrMsg.Text = "Failed to write Mode to SDRUno " & strExMsg
                    Return
                End If

                frmSDRuHRD.txtHRDLastRcvd.Text = strStatus
                frmSDRuHRD.txtErrMsg.Text = ""
            End If
        Catch ex As ArgumentException
            frmSDRuHRD.txtErrMsg.Text = "SyncRadios() Error = " & ex.Message
            Return
        End Try



    End Sub
    Private Function WriteNewStatus(SrlPt As System.IO.Ports.SerialPort, NewStatus As String, ByRef exMsg As String) As Boolean
        Try
            SrlPt.WriteLine(NewStatus)
            MyThread.Sleep(100)
            Return True
        Catch ex As ArgumentException
            exMsg = ex.Message
            Return False
        End Try


        Return True

    End Function

    Private Function GetStatusStr(SrlPt As System.IO.Ports.SerialPort) As String

        SrlPt.NewLine = ";"
        SrlPt.WriteLine("IF")
        MyThread.Sleep(200)
        Try
            GetStatusStr = SrlPt.ReadLine
        Catch ex As Exception
            GetStatusStr = "Error : " & ex.Message
        End Try


    End Function

    Private Function OpenPorts() As Boolean
        If frmSDRuHRD.SerialPortSDRUno.IsOpen = False Then
            If Not OpenSDRUnoPort() Then
                frmSDRuHRD.boolSDRUnoCommPtSet = False
                frmSDRuHRD.NextCommTimer.Enabled = False
                Return False
            Else
                frmSDRuHRD.boolSDRUnoCommPtSet = True
            End If
        End If

        If frmSDRuHRD.SerialPortHRD.IsOpen = False Then
            If Not OpenHRDPort() Then
                frmSDRuHRD.boolHRDCommPtSet = False
                frmSDRuHRD.NextCommTimer.Enabled = False
                Return False
            Else
                frmSDRuHRD.boolHRDCommPtSet = True
            End If
        End If
        Return True
    End Function

    Private Function OpenHRDPort() As Boolean
        Dim ErrStr As String = ""
        Dim Value As Object = ""
        frmSDRuHRD.SerialPortHRD.PortName = strHRDPortName
        frmSDRuHRD.SerialPortHRD.BaudRate = intHRDBaudRate
        Try
            frmSDRuHRD.SerialPortHRD.Open()
        Catch ex As UnauthorizedAccessException
            frmSDRuHRD.txtErrMsg.Text = "HRD Serial Port Error " & ex.Message
            If Not SetReg_HKCU_Value(frmSDRuHRD.HKCUProgramKey, frmSDRuHRD.HRDValueName, Value, ErrStr) Then
                frmSDRuHRD.txtErrMsg.Text = frmSDRuHRD.txtErrMsg.Text & vbCrLf & "SetReg_HKCU_Value Error=" & ErrStr
            End If
            Return False
        Catch ex As ArgumentException
            frmSDRuHRD.txtErrMsg.Text = "HRD Serial Port Error " & ex.Message
            If Not SetReg_HKCU_Value(frmSDRuHRD.HKCUProgramKey, frmSDRuHRD.HRDValueName, Value, ErrStr) Then
                frmSDRuHRD.txtErrMsg.Text = frmSDRuHRD.txtErrMsg.Text & vbCrLf & "SetReg_HKCU_Value Error=" & ErrStr
            End If
            Return False
        End Try
        frmSDRuHRD.txtErrMsg.Text = ""
        frmSDRuHRD.cboHRDCommPort.Enabled = False
        Return True
    End Function

    Private Function OpenSDRUnoPort() As Boolean
        Dim ErrStr As String = ""
        Dim Value As Object = ""
        frmSDRuHRD.SerialPortSDRUno.PortName = strSDRunoPortName
        frmSDRuHRD.SerialPortSDRUno.BaudRate = intSDRUnoBaudRate
        Try
            frmSDRuHRD.SerialPortSDRUno.Open()
        Catch ex As UnauthorizedAccessException
            frmSDRuHRD.txtErrMsg.Text = "SDRUno Serial Port Error " & ex.Message
            If Not SetReg_HKCU_Value(frmSDRuHRD.HKCUProgramKey, frmSDRuHRD.SDRunoValueName, Value, ErrStr) Then
                frmSDRuHRD.txtErrMsg.Text = frmSDRuHRD.txtErrMsg.Text & vbCrLf & "SetReg_HKCU_Value Error=" & ErrStr
            End If
            Return False
        Catch ex As ArgumentException
            frmSDRuHRD.txtErrMsg.Text = "SDRUno Serial Port Error " & ex.Message
            If Not SetReg_HKCU_Value(frmSDRuHRD.HKCUProgramKey, frmSDRuHRD.SDRunoValueName, Value, ErrStr) Then
                frmSDRuHRD.txtErrMsg.Text = frmSDRuHRD.txtErrMsg.Text & vbCrLf & "SetReg_HKCU_Value Error=" & ErrStr
            End If
            Return False
        End Try
        frmSDRuHRD.txtErrMsg.Text = ""
        frmSDRuHRD.cboSDRUnoCommPort.Enabled = False
        Return True
    End Function

End Module
