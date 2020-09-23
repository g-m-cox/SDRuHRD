<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSDRuHRD
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.SerialPortSDRUno = New System.IO.Ports.SerialPort(Me.components)
        Me.SerialPortHRD = New System.IO.Ports.SerialPort(Me.components)
        Me.cboSDRUnoCommPort = New System.Windows.Forms.ComboBox()
        Me.cboHRDCommPort = New System.Windows.Forms.ComboBox()
        Me.lblSDRuCommPort = New System.Windows.Forms.Label()
        Me.lblHRDCommPort = New System.Windows.Forms.Label()
        Me.txtSDRuLastRcvd = New System.Windows.Forms.TextBox()
        Me.lblSDRuLastRcvd = New System.Windows.Forms.Label()
        Me.txtHRDLastRcvd = New System.Windows.Forms.TextBox()
        Me.lblHRDLastRcvd = New System.Windows.Forms.Label()
        Me.NextCommTimer = New System.Windows.Forms.Timer(Me.components)
        Me.txtErrMsg = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'cboSDRUnoCommPort
        '
        Me.cboSDRUnoCommPort.FormattingEnabled = True
        Me.cboSDRUnoCommPort.Location = New System.Drawing.Point(210, 22)
        Me.cboSDRUnoCommPort.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cboSDRUnoCommPort.Name = "cboSDRUnoCommPort"
        Me.cboSDRUnoCommPort.Size = New System.Drawing.Size(98, 24)
        Me.cboSDRUnoCommPort.TabIndex = 0
        '
        'cboHRDCommPort
        '
        Me.cboHRDCommPort.FormattingEnabled = True
        Me.cboHRDCommPort.Location = New System.Drawing.Point(210, 104)
        Me.cboHRDCommPort.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cboHRDCommPort.Name = "cboHRDCommPort"
        Me.cboHRDCommPort.Size = New System.Drawing.Size(98, 24)
        Me.cboHRDCommPort.TabIndex = 1
        '
        'lblSDRuCommPort
        '
        Me.lblSDRuCommPort.AutoSize = True
        Me.lblSDRuCommPort.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSDRuCommPort.Location = New System.Drawing.Point(35, 22)
        Me.lblSDRuCommPort.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblSDRuCommPort.Name = "lblSDRuCommPort"
        Me.lblSDRuCommPort.Size = New System.Drawing.Size(165, 20)
        Me.lblSDRuCommPort.TabIndex = 2
        Me.lblSDRuCommPort.Text = "SDRUno Comm Port"
        '
        'lblHRDCommPort
        '
        Me.lblHRDCommPort.AutoSize = True
        Me.lblHRDCommPort.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHRDCommPort.Location = New System.Drawing.Point(63, 108)
        Me.lblHRDCommPort.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblHRDCommPort.Name = "lblHRDCommPort"
        Me.lblHRDCommPort.Size = New System.Drawing.Size(137, 20)
        Me.lblHRDCommPort.TabIndex = 3
        Me.lblHRDCommPort.Text = "HRD Comm Port"
        '
        'txtSDRuLastRcvd
        '
        Me.txtSDRuLastRcvd.Font = New System.Drawing.Font("Courier New", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSDRuLastRcvd.Location = New System.Drawing.Point(210, 62)
        Me.txtSDRuLastRcvd.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txtSDRuLastRcvd.MaxLength = 3200
        Me.txtSDRuLastRcvd.Name = "txtSDRuLastRcvd"
        Me.txtSDRuLastRcvd.ReadOnly = True
        Me.txtSDRuLastRcvd.Size = New System.Drawing.Size(466, 22)
        Me.txtSDRuLastRcvd.TabIndex = 4
        '
        'lblSDRuLastRcvd
        '
        Me.lblSDRuLastRcvd.AutoSize = True
        Me.lblSDRuLastRcvd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSDRuLastRcvd.Location = New System.Drawing.Point(44, 58)
        Me.lblSDRuLastRcvd.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblSDRuLastRcvd.Name = "lblSDRuLastRcvd"
        Me.lblSDRuLastRcvd.Size = New System.Drawing.Size(156, 20)
        Me.lblSDRuLastRcvd.TabIndex = 5
        Me.lblSDRuLastRcvd.Text = "SDRUno Last Rcvd"
        '
        'txtHRDLastRcvd
        '
        Me.txtHRDLastRcvd.Font = New System.Drawing.Font("Courier New", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHRDLastRcvd.ForeColor = System.Drawing.Color.YellowGreen
        Me.txtHRDLastRcvd.Location = New System.Drawing.Point(210, 145)
        Me.txtHRDLastRcvd.Margin = New System.Windows.Forms.Padding(4)
        Me.txtHRDLastRcvd.Name = "txtHRDLastRcvd"
        Me.txtHRDLastRcvd.ReadOnly = True
        Me.txtHRDLastRcvd.Size = New System.Drawing.Size(466, 22)
        Me.txtHRDLastRcvd.TabIndex = 6
        '
        'lblHRDLastRcvd
        '
        Me.lblHRDLastRcvd.AutoSize = True
        Me.lblHRDLastRcvd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHRDLastRcvd.Location = New System.Drawing.Point(73, 144)
        Me.lblHRDLastRcvd.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblHRDLastRcvd.Name = "lblHRDLastRcvd"
        Me.lblHRDLastRcvd.Size = New System.Drawing.Size(128, 20)
        Me.lblHRDLastRcvd.TabIndex = 7
        Me.lblHRDLastRcvd.Text = "HRD Last Rcvd"
        '
        'NextCommTimer
        '
        Me.NextCommTimer.Interval = 1000
        '
        'txtErrMsg
        '
        Me.txtErrMsg.Location = New System.Drawing.Point(39, 199)
        Me.txtErrMsg.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtErrMsg.Multiline = True
        Me.txtErrMsg.Name = "txtErrMsg"
        Me.txtErrMsg.ReadOnly = True
        Me.txtErrMsg.Size = New System.Drawing.Size(637, 79)
        Me.txtErrMsg.TabIndex = 8
        '
        'frmSDRuHRD
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(731, 348)
        Me.Controls.Add(Me.txtErrMsg)
        Me.Controls.Add(Me.lblHRDLastRcvd)
        Me.Controls.Add(Me.txtHRDLastRcvd)
        Me.Controls.Add(Me.lblSDRuLastRcvd)
        Me.Controls.Add(Me.txtSDRuLastRcvd)
        Me.Controls.Add(Me.lblHRDCommPort)
        Me.Controls.Add(Me.lblSDRuCommPort)
        Me.Controls.Add(Me.cboHRDCommPort)
        Me.Controls.Add(Me.cboSDRUnoCommPort)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "frmSDRuHRD"
        Me.Text = "SDRUno <> HRD Sync"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SerialPortSDRUno As IO.Ports.SerialPort
    Friend WithEvents SerialPortHRD As IO.Ports.SerialPort
    Friend WithEvents cboSDRUnoCommPort As ComboBox
    Friend WithEvents cboHRDCommPort As ComboBox
    Friend WithEvents lblSDRuCommPort As Label
    Friend WithEvents lblHRDCommPort As Label
    Friend WithEvents txtSDRuLastRcvd As TextBox
    Friend WithEvents lblSDRuLastRcvd As Label
    Friend WithEvents txtHRDLastRcvd As TextBox
    Friend WithEvents lblHRDLastRcvd As Label
    Friend WithEvents NextCommTimer As Timer
    Friend WithEvents txtErrMsg As TextBox
End Class
