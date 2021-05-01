<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAnaIn
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.tmrCheckStatus = New System.Windows.Forms.Timer(Me.components)
        Me.lblInstruction = New System.Windows.Forms.Label()
        Me.txtHighChan = New System.Windows.Forms.TextBox()
        Me.cmdQuit = New System.Windows.Forms.Button()
        Me.cmdStartBgnd = New System.Windows.Forms.Button()
        Me.cmdStopConvert = New System.Windows.Forms.Button()
        Me.lblMesureChannels0to = New System.Windows.Forms.Label()
        Me.lblShowCount = New System.Windows.Forms.Label()
        Me.lblCount = New System.Windows.Forms.Label()
        Me.lblShowIndex = New System.Windows.Forms.Label()
        Me.lblIndex = New System.Windows.Forms.Label()
        Me.lblShowStat = New System.Windows.Forms.Label()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me._lblADData_7 = New System.Windows.Forms.Label()
        Me.lblChan7 = New System.Windows.Forms.Label()
        Me._lblADData_3 = New System.Windows.Forms.Label()
        Me.lblChan3 = New System.Windows.Forms.Label()
        Me._lblADData_6 = New System.Windows.Forms.Label()
        Me.lblChan6 = New System.Windows.Forms.Label()
        Me._lblADData_2 = New System.Windows.Forms.Label()
        Me.lblChan2 = New System.Windows.Forms.Label()
        Me._lblADData_5 = New System.Windows.Forms.Label()
        Me.lblChan5 = New System.Windows.Forms.Label()
        Me._lblADData_1 = New System.Windows.Forms.Label()
        Me.lblChan1 = New System.Windows.Forms.Label()
        Me._lblADData_4 = New System.Windows.Forms.Label()
        Me.lblChan4 = New System.Windows.Forms.Label()
        Me._lblADData_0 = New System.Windows.Forms.Label()
        Me.lblChan0 = New System.Windows.Forms.Label()
        Me.blAuxPort = New System.Windows.Forms.Label()
        Me.lblAuxPortValue = New System.Windows.Forms.Label()
        Me.lblErrInfo = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'tmrCheckStatus
        '
        '
        'lblInstruction
        '
        Me.lblInstruction.BackColor = System.Drawing.SystemColors.Window
        Me.lblInstruction.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblInstruction.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInstruction.ForeColor = System.Drawing.Color.Red
        Me.lblInstruction.Location = New System.Drawing.Point(40, 9)
        Me.lblInstruction.Name = "lblInstruction"
        Me.lblInstruction.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblInstruction.Size = New System.Drawing.Size(273, 60)
        Me.lblInstruction.TabIndex = 57
        Me.lblInstruction.Text = "Board 0 must have analog inputs that support paced acquisition."
        Me.lblInstruction.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txtHighChan
        '
        Me.txtHighChan.AcceptsReturn = True
        Me.txtHighChan.BackColor = System.Drawing.SystemColors.Window
        Me.txtHighChan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtHighChan.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtHighChan.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHighChan.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtHighChan.Location = New System.Drawing.Point(211, 104)
        Me.txtHighChan.MaxLength = 0
        Me.txtHighChan.Name = "txtHighChan"
        Me.txtHighChan.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtHighChan.Size = New System.Drawing.Size(25, 20)
        Me.txtHighChan.TabIndex = 56
        Me.txtHighChan.Text = "7"
        Me.txtHighChan.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cmdQuit
        '
        Me.cmdQuit.BackColor = System.Drawing.SystemColors.Control
        Me.cmdQuit.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdQuit.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdQuit.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdQuit.Location = New System.Drawing.Point(274, 262)
        Me.cmdQuit.Name = "cmdQuit"
        Me.cmdQuit.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdQuit.Size = New System.Drawing.Size(65, 26)
        Me.cmdQuit.TabIndex = 48
        Me.cmdQuit.Text = "Quit"
        Me.cmdQuit.UseVisualStyleBackColor = False
        '
        'cmdStartBgnd
        '
        Me.cmdStartBgnd.BackColor = System.Drawing.SystemColors.Control
        Me.cmdStartBgnd.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdStartBgnd.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdStartBgnd.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdStartBgnd.Location = New System.Drawing.Point(85, 72)
        Me.cmdStartBgnd.Name = "cmdStartBgnd"
        Me.cmdStartBgnd.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdStartBgnd.Size = New System.Drawing.Size(180, 27)
        Me.cmdStartBgnd.TabIndex = 47
        Me.cmdStartBgnd.Text = "Start Background Operation"
        Me.cmdStartBgnd.UseVisualStyleBackColor = False
        '
        'cmdStopConvert
        '
        Me.cmdStopConvert.BackColor = System.Drawing.SystemColors.Control
        Me.cmdStopConvert.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdStopConvert.Enabled = False
        Me.cmdStopConvert.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdStopConvert.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdStopConvert.Location = New System.Drawing.Point(85, 72)
        Me.cmdStopConvert.Name = "cmdStopConvert"
        Me.cmdStopConvert.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdStopConvert.Size = New System.Drawing.Size(180, 27)
        Me.cmdStopConvert.TabIndex = 46
        Me.cmdStopConvert.Text = "Stop Background Operation"
        Me.cmdStopConvert.UseVisualStyleBackColor = False
        Me.cmdStopConvert.Visible = False
        '
        'lblMesureChannels0to
        '
        Me.lblMesureChannels0to.BackColor = System.Drawing.SystemColors.Window
        Me.lblMesureChannels0to.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblMesureChannels0to.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMesureChannels0to.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblMesureChannels0to.Location = New System.Drawing.Point(71, 106)
        Me.lblMesureChannels0to.Name = "lblMesureChannels0to"
        Me.lblMesureChannels0to.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblMesureChannels0to.Size = New System.Drawing.Size(137, 17)
        Me.lblMesureChannels0to.TabIndex = 55
        Me.lblMesureChannels0to.Text = "Measure Channels 0 to"
        Me.lblMesureChannels0to.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblShowCount
        '
        Me.lblShowCount.BackColor = System.Drawing.SystemColors.Window
        Me.lblShowCount.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblShowCount.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblShowCount.ForeColor = System.Drawing.Color.Blue
        Me.lblShowCount.Location = New System.Drawing.Point(200, 262)
        Me.lblShowCount.Name = "lblShowCount"
        Me.lblShowCount.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblShowCount.Size = New System.Drawing.Size(58, 14)
        Me.lblShowCount.TabIndex = 54
        '
        'lblCount
        '
        Me.lblCount.BackColor = System.Drawing.SystemColors.Window
        Me.lblCount.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblCount.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCount.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblCount.Location = New System.Drawing.Point(85, 262)
        Me.lblCount.Name = "lblCount"
        Me.lblCount.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblCount.Size = New System.Drawing.Size(103, 14)
        Me.lblCount.TabIndex = 52
        Me.lblCount.Text = "Current Count:"
        Me.lblCount.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblShowIndex
        '
        Me.lblShowIndex.BackColor = System.Drawing.SystemColors.Window
        Me.lblShowIndex.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblShowIndex.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblShowIndex.ForeColor = System.Drawing.Color.Blue
        Me.lblShowIndex.Location = New System.Drawing.Point(200, 243)
        Me.lblShowIndex.Name = "lblShowIndex"
        Me.lblShowIndex.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblShowIndex.Size = New System.Drawing.Size(52, 14)
        Me.lblShowIndex.TabIndex = 53
        '
        'lblIndex
        '
        Me.lblIndex.BackColor = System.Drawing.SystemColors.Window
        Me.lblIndex.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblIndex.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIndex.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblIndex.Location = New System.Drawing.Point(85, 243)
        Me.lblIndex.Name = "lblIndex"
        Me.lblIndex.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblIndex.Size = New System.Drawing.Size(103, 14)
        Me.lblIndex.TabIndex = 51
        Me.lblIndex.Text = "Current Index:"
        Me.lblIndex.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblShowStat
        '
        Me.lblShowStat.BackColor = System.Drawing.SystemColors.Window
        Me.lblShowStat.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblShowStat.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblShowStat.ForeColor = System.Drawing.Color.Blue
        Me.lblShowStat.Location = New System.Drawing.Point(242, 216)
        Me.lblShowStat.Name = "lblShowStat"
        Me.lblShowStat.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblShowStat.Size = New System.Drawing.Size(65, 17)
        Me.lblShowStat.TabIndex = 50
        '
        'lblStatus
        '
        Me.lblStatus.BackColor = System.Drawing.SystemColors.Window
        Me.lblStatus.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblStatus.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblStatus.Location = New System.Drawing.Point(10, 216)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblStatus.Size = New System.Drawing.Size(217, 17)
        Me.lblStatus.TabIndex = 49
        Me.lblStatus.Text = "Status of Background Operation:"
        Me.lblStatus.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        '_lblADData_7
        '
        Me._lblADData_7.BackColor = System.Drawing.SystemColors.Window
        Me._lblADData_7.Cursor = System.Windows.Forms.Cursors.Default
        Me._lblADData_7.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lblADData_7.ForeColor = System.Drawing.Color.Blue
        Me._lblADData_7.Location = New System.Drawing.Point(266, 190)
        Me._lblADData_7.Name = "_lblADData_7"
        Me._lblADData_7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblADData_7.Size = New System.Drawing.Size(65, 17)
        Me._lblADData_7.TabIndex = 45
        '
        'lblChan7
        '
        Me.lblChan7.BackColor = System.Drawing.SystemColors.Window
        Me.lblChan7.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblChan7.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChan7.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblChan7.Location = New System.Drawing.Point(194, 190)
        Me.lblChan7.Name = "lblChan7"
        Me.lblChan7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblChan7.Size = New System.Drawing.Size(65, 17)
        Me.lblChan7.TabIndex = 37
        Me.lblChan7.Text = "Channel 7:"
        '
        '_lblADData_3
        '
        Me._lblADData_3.BackColor = System.Drawing.SystemColors.Window
        Me._lblADData_3.Cursor = System.Windows.Forms.Cursors.Default
        Me._lblADData_3.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lblADData_3.ForeColor = System.Drawing.Color.Blue
        Me._lblADData_3.Location = New System.Drawing.Point(98, 190)
        Me._lblADData_3.Name = "_lblADData_3"
        Me._lblADData_3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblADData_3.Size = New System.Drawing.Size(65, 17)
        Me._lblADData_3.TabIndex = 41
        '
        'lblChan3
        '
        Me.lblChan3.BackColor = System.Drawing.SystemColors.Window
        Me.lblChan3.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblChan3.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChan3.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblChan3.Location = New System.Drawing.Point(26, 190)
        Me.lblChan3.Name = "lblChan3"
        Me.lblChan3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblChan3.Size = New System.Drawing.Size(65, 17)
        Me.lblChan3.TabIndex = 33
        Me.lblChan3.Text = "Channel 3:"
        '
        '_lblADData_6
        '
        Me._lblADData_6.BackColor = System.Drawing.SystemColors.Window
        Me._lblADData_6.Cursor = System.Windows.Forms.Cursors.Default
        Me._lblADData_6.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lblADData_6.ForeColor = System.Drawing.Color.Blue
        Me._lblADData_6.Location = New System.Drawing.Point(266, 171)
        Me._lblADData_6.Name = "_lblADData_6"
        Me._lblADData_6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblADData_6.Size = New System.Drawing.Size(65, 17)
        Me._lblADData_6.TabIndex = 44
        '
        'lblChan6
        '
        Me.lblChan6.BackColor = System.Drawing.SystemColors.Window
        Me.lblChan6.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblChan6.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChan6.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblChan6.Location = New System.Drawing.Point(194, 171)
        Me.lblChan6.Name = "lblChan6"
        Me.lblChan6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblChan6.Size = New System.Drawing.Size(65, 17)
        Me.lblChan6.TabIndex = 36
        Me.lblChan6.Text = "Channel 6:"
        '
        '_lblADData_2
        '
        Me._lblADData_2.BackColor = System.Drawing.SystemColors.Window
        Me._lblADData_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._lblADData_2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lblADData_2.ForeColor = System.Drawing.Color.Blue
        Me._lblADData_2.Location = New System.Drawing.Point(98, 171)
        Me._lblADData_2.Name = "_lblADData_2"
        Me._lblADData_2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblADData_2.Size = New System.Drawing.Size(65, 17)
        Me._lblADData_2.TabIndex = 40
        '
        'lblChan2
        '
        Me.lblChan2.BackColor = System.Drawing.SystemColors.Window
        Me.lblChan2.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblChan2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChan2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblChan2.Location = New System.Drawing.Point(26, 171)
        Me.lblChan2.Name = "lblChan2"
        Me.lblChan2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblChan2.Size = New System.Drawing.Size(65, 17)
        Me.lblChan2.TabIndex = 32
        Me.lblChan2.Text = "Channel 2:"
        '
        '_lblADData_5
        '
        Me._lblADData_5.BackColor = System.Drawing.SystemColors.Window
        Me._lblADData_5.Cursor = System.Windows.Forms.Cursors.Default
        Me._lblADData_5.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lblADData_5.ForeColor = System.Drawing.Color.Blue
        Me._lblADData_5.Location = New System.Drawing.Point(266, 152)
        Me._lblADData_5.Name = "_lblADData_5"
        Me._lblADData_5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblADData_5.Size = New System.Drawing.Size(65, 17)
        Me._lblADData_5.TabIndex = 43
        '
        'lblChan5
        '
        Me.lblChan5.BackColor = System.Drawing.SystemColors.Window
        Me.lblChan5.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblChan5.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChan5.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblChan5.Location = New System.Drawing.Point(194, 152)
        Me.lblChan5.Name = "lblChan5"
        Me.lblChan5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblChan5.Size = New System.Drawing.Size(65, 17)
        Me.lblChan5.TabIndex = 35
        Me.lblChan5.Text = "Channel 5:"
        '
        '_lblADData_1
        '
        Me._lblADData_1.BackColor = System.Drawing.SystemColors.Window
        Me._lblADData_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._lblADData_1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lblADData_1.ForeColor = System.Drawing.Color.Blue
        Me._lblADData_1.Location = New System.Drawing.Point(98, 152)
        Me._lblADData_1.Name = "_lblADData_1"
        Me._lblADData_1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblADData_1.Size = New System.Drawing.Size(65, 17)
        Me._lblADData_1.TabIndex = 39
        '
        'lblChan1
        '
        Me.lblChan1.BackColor = System.Drawing.SystemColors.Window
        Me.lblChan1.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblChan1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChan1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblChan1.Location = New System.Drawing.Point(26, 152)
        Me.lblChan1.Name = "lblChan1"
        Me.lblChan1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblChan1.Size = New System.Drawing.Size(65, 17)
        Me.lblChan1.TabIndex = 31
        Me.lblChan1.Text = "Channel 1:"
        '
        '_lblADData_4
        '
        Me._lblADData_4.BackColor = System.Drawing.SystemColors.Window
        Me._lblADData_4.Cursor = System.Windows.Forms.Cursors.Default
        Me._lblADData_4.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lblADData_4.ForeColor = System.Drawing.Color.Blue
        Me._lblADData_4.Location = New System.Drawing.Point(266, 133)
        Me._lblADData_4.Name = "_lblADData_4"
        Me._lblADData_4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblADData_4.Size = New System.Drawing.Size(65, 17)
        Me._lblADData_4.TabIndex = 42
        '
        'lblChan4
        '
        Me.lblChan4.BackColor = System.Drawing.SystemColors.Window
        Me.lblChan4.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblChan4.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChan4.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblChan4.Location = New System.Drawing.Point(194, 133)
        Me.lblChan4.Name = "lblChan4"
        Me.lblChan4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblChan4.Size = New System.Drawing.Size(65, 17)
        Me.lblChan4.TabIndex = 34
        Me.lblChan4.Text = "Channel 4:"
        '
        '_lblADData_0
        '
        Me._lblADData_0.BackColor = System.Drawing.SystemColors.Window
        Me._lblADData_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._lblADData_0.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lblADData_0.ForeColor = System.Drawing.Color.Blue
        Me._lblADData_0.Location = New System.Drawing.Point(98, 133)
        Me._lblADData_0.Name = "_lblADData_0"
        Me._lblADData_0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblADData_0.Size = New System.Drawing.Size(65, 17)
        Me._lblADData_0.TabIndex = 38
        '
        'lblChan0
        '
        Me.lblChan0.BackColor = System.Drawing.SystemColors.Window
        Me.lblChan0.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblChan0.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChan0.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblChan0.Location = New System.Drawing.Point(26, 133)
        Me.lblChan0.Name = "lblChan0"
        Me.lblChan0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblChan0.Size = New System.Drawing.Size(65, 17)
        Me.lblChan0.TabIndex = 30
        Me.lblChan0.Text = "Channel 0:"
        '
        'blAuxPort
        '
        Me.blAuxPort.AutoSize = True
        Me.blAuxPort.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.blAuxPort.Location = New System.Drawing.Point(26, 330)
        Me.blAuxPort.Name = "blAuxPort"
        Me.blAuxPort.Size = New System.Drawing.Size(94, 13)
        Me.blAuxPort.TabIndex = 58
        Me.blAuxPort.Text = "Digital Aux Port In:"
        Me.blAuxPort.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblAuxPortValue
        '
        Me.lblAuxPortValue.AutoSize = True
        Me.lblAuxPortValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblAuxPortValue.Location = New System.Drawing.Point(122, 330)
        Me.lblAuxPortValue.MinimumSize = New System.Drawing.Size(20, 2)
        Me.lblAuxPortValue.Name = "lblAuxPortValue"
        Me.lblAuxPortValue.Size = New System.Drawing.Size(20, 15)
        Me.lblAuxPortValue.TabIndex = 59
        Me.lblAuxPortValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblErrInfo
        '
        Me.lblErrInfo.AutoSize = True
        Me.lblErrInfo.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblErrInfo.Location = New System.Drawing.Point(26, 291)
        Me.lblErrInfo.MinimumSize = New System.Drawing.Size(300, 28)
        Me.lblErrInfo.Name = "lblErrInfo"
        Me.lblErrInfo.Size = New System.Drawing.Size(300, 28)
        Me.lblErrInfo.TabIndex = 60
        Me.lblErrInfo.Text = "Err Info"
        '
        'frmAnaIn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(353, 349)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblErrInfo)
        Me.Controls.Add(Me.lblAuxPortValue)
        Me.Controls.Add(Me.blAuxPort)
        Me.Controls.Add(Me.lblInstruction)
        Me.Controls.Add(Me.txtHighChan)
        Me.Controls.Add(Me.cmdQuit)
        Me.Controls.Add(Me.cmdStartBgnd)
        Me.Controls.Add(Me.cmdStopConvert)
        Me.Controls.Add(Me.lblMesureChannels0to)
        Me.Controls.Add(Me.lblShowCount)
        Me.Controls.Add(Me.lblCount)
        Me.Controls.Add(Me.lblShowIndex)
        Me.Controls.Add(Me.lblIndex)
        Me.Controls.Add(Me.lblShowStat)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me._lblADData_7)
        Me.Controls.Add(Me.lblChan7)
        Me.Controls.Add(Me._lblADData_3)
        Me.Controls.Add(Me.lblChan3)
        Me.Controls.Add(Me._lblADData_6)
        Me.Controls.Add(Me.lblChan6)
        Me.Controls.Add(Me._lblADData_2)
        Me.Controls.Add(Me.lblChan2)
        Me.Controls.Add(Me._lblADData_5)
        Me.Controls.Add(Me.lblChan5)
        Me.Controls.Add(Me._lblADData_1)
        Me.Controls.Add(Me.lblChan1)
        Me.Controls.Add(Me._lblADData_4)
        Me.Controls.Add(Me.lblChan4)
        Me.Controls.Add(Me._lblADData_0)
        Me.Controls.Add(Me.lblChan0)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAnaIn"
        Me.Text = "Analog and Digital In"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Public WithEvents tmrCheckStatus As Timer
    Public WithEvents lblInstruction As Label
    Public WithEvents txtHighChan As TextBox
    Public WithEvents cmdQuit As Button
    Public WithEvents cmdStartBgnd As Button
    Public WithEvents cmdStopConvert As Button
    Public WithEvents lblMesureChannels0to As Label
    Public WithEvents lblShowCount As Label
    Public WithEvents lblCount As Label
    Public WithEvents lblShowIndex As Label
    Public WithEvents lblIndex As Label
    Public WithEvents lblShowStat As Label
    Public WithEvents lblStatus As Label
    Public WithEvents _lblADData_7 As Label
    Public WithEvents lblChan7 As Label
    Public WithEvents _lblADData_3 As Label
    Public WithEvents lblChan3 As Label
    Public WithEvents _lblADData_6 As Label
    Public WithEvents lblChan6 As Label
    Public WithEvents _lblADData_2 As Label
    Public WithEvents lblChan2 As Label
    Public WithEvents _lblADData_5 As Label
    Public WithEvents lblChan5 As Label
    Public WithEvents _lblADData_1 As Label
    Public WithEvents lblChan1 As Label
    Public WithEvents _lblADData_4 As Label
    Public WithEvents lblChan4 As Label
    Public WithEvents _lblADData_0 As Label
    Public WithEvents lblChan0 As Label
    Friend WithEvents blAuxPort As Label
    Friend WithEvents lblAuxPortValue As Label
    Friend WithEvents lblErrInfo As Label
End Class
