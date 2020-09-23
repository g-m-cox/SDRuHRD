Public Class frmSDRuHRD
    Public boolSDRUnoCommPtSet As Boolean
    Public boolHRDCommPtSet As Boolean
    Public HKCUProgramKey As String = "Software\AF5LA\SDRUnoHDR"

    Private Sub frmSDRuHRD_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim Deflt As Object
        Dim objRet As Object


        For Each portName In My.Computer.Ports.SerialPortNames
            Me.cboHRDCommPort.Items.Add(portName)
            Me.cboSDRUnoCommPort.Items.Add(portName)
        Next
        Deflt = Nothing
        objRet = GetReg_HKCU_Value(HKCUProgramKey, "SDRUnoCommPort", Deflt)
        If objRet Is Nothing Then
            boolSDRUnoCommPtSet = False
        Else
            Me.cboSDRUnoCommPort.Text = objRet.ToString
            boolSDRUnoCommPtSet = True
        End If

        Deflt = Nothing
        objRet = GetReg_HKCU_Value(HKCUProgramKey, "HRDCommPort", Deflt)
        If objRet Is Nothing Then
            boolHRDCommPtSet = False
        Else
            Me.cboHRDCommPort.Text = objRet.ToString
            boolHRDCommPtSet = True
        End If
        If boolSDRUnoCommPtSet And boolHRDCommPtSet Then
            Me.NextCommTimer.Enabled = True
        End If



    End Sub

    Private Sub NextCommTimer_Tick(sender As Object, e As EventArgs) Handles NextCommTimer.Tick
        SyncRadios()
    End Sub

    Private Sub cboHRDCommPort_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboHRDCommPort.SelectedIndexChanged
        Dim Deflt As Object
        Dim objRet As Object
        strHRDPortName = Me.cboHRDCommPort.SelectedItem
        Deflt = strHRDPortName
        objRet = GetReg_HKCU_Value(HKCUProgramKey, "HRDCommPort", Deflt)
        boolHRDCommPtSet = True
        If boolSDRUnoCommPtSet And boolHRDCommPtSet Then
            NextCommTimer.Enabled = True
        End If
    End Sub

    Private Sub cboSDRUnoCommPort_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboSDRUnoCommPort.SelectedIndexChanged
        Dim Deflt As Object
        Dim objRet As Object
        strSDRunoPortName = cboSDRUnoCommPort.SelectedItem
        Deflt = strSDRunoPortName
        objRet = GetReg_HKCU_Value(HKCUProgramKey, "SDRUnoCommPort", Deflt)
        boolSDRUnoCommPtSet = True
        If boolSDRUnoCommPtSet And boolHRDCommPtSet Then
            NextCommTimer.Enabled = True
        End If

    End Sub
End Class
