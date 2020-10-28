Public Class frmSDRuHRD
    Public boolSDRUnoCommPtSet As Boolean
    Public boolHRDCommPtSet As Boolean
    Public HKCUProgramKey As String = "Software\AF5LA\SDRuHDR"
    Public SDRunoValueName As String = "SDRUnoCommPort"
    Public HRDValueName As String = "HRDCommPort"

    Private Sub frmSDRuHRD_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim Deflt As Object
        Dim objRet As Object

        For Each portName In My.Computer.Ports.SerialPortNames
            Me.cboHRDCommPort.Items.Add(portName)
            Me.cboSDRUnoCommPort.Items.Add(portName)
        Next

        intHRDWrtDelay = 50
        'Deflt = intHRDWrtDelay
        'objRet = GetReg_HKCU_Value(HKCUProgramKey, "HRDWrtDelay", Deflt)
        'If objRet Is Nothing Then
        'Else
        '    intHRDWrtDelay = objRet
        'End If

        Deflt = Nothing
        objRet = GetReg_HKCU_Value(HKCUProgramKey, SDRunoValueName, Deflt)
        If objRet Is Nothing Then
            boolSDRUnoCommPtSet = False
        Else
            Me.cboSDRUnoCommPort.Text = objRet.ToString
            boolSDRUnoCommPtSet = True
        End If

        Deflt = Nothing
        objRet = GetReg_HKCU_Value(HKCUProgramKey, HRDValueName, Deflt)
        If objRet Is Nothing Then
            boolHRDCommPtSet = False
        Else
            Me.cboHRDCommPort.Text = objRet.ToString
            boolHRDCommPtSet = True
        End If

        If boolSDRUnoCommPtSet And boolHRDCommPtSet Then
            'All ports set, lets run!
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
        objRet = GetReg_HKCU_Value(HKCUProgramKey, HRDValueName, Deflt)
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
        objRet = GetReg_HKCU_Value(HKCUProgramKey, SDRunoValueName, Deflt)
        boolSDRUnoCommPtSet = True
        If boolSDRUnoCommPtSet And boolHRDCommPtSet Then
            NextCommTimer.Enabled = True
        End If

    End Sub

    Private Sub HelpToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HelpToolStripMenuItem.Click

    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        Dim Result As MsgBoxResult
        Dim strMsg As String
        Dim strPrompt As String
        strPrompt = "SDRUno <> HRD"
        strMsg = "SDRuHRD.exe Version " & Application.ProductVersion
        Result = MsgBox(strMsg, MsgBoxStyle.OkOnly, strPrompt)
    End Sub

    Private Sub InstructionsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InstructionsToolStripMenuItem.Click
        Dim strPath As String
        Dim strDblQuote As String
        Dim intRet As Integer
        strDblQuote = ControlChars.Quote
        strPath = Application.StartupPath
        strPath = strPath & "\Instructions.pdf"
        Debug.Print(strPath)
        strPath = strDblQuote & strPath & strDblQuote
        strPath = "cmd /c " & strPath
        Debug.Print(strPath)
        intRet = Shell(strPath, AppWinStyle.Hide)
    End Sub
End Class
