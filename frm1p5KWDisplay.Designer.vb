<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm1p5KWDisplay
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
        Me.lblB0_XMIT = New System.Windows.Forms.Label()
        Me.lblB1_SWR_Fault = New System.Windows.Forms.Label()
        Me.lblB2_OvrTemp = New System.Windows.Forms.Label()
        Me.lblVolts0 = New System.Windows.Forms.Label()
        Me.lblVolts1 = New System.Windows.Forms.Label()
        Me.lblVolts2 = New System.Windows.Forms.Label()
        Me.lblVolts3 = New System.Windows.Forms.Label()
        Me.lblVolts4 = New System.Windows.Forms.Label()
        Me.lblVolts5 = New System.Windows.Forms.Label()
        Me.lblVolts6 = New System.Windows.Forms.Label()
        Me.lblVolts7 = New System.Windows.Forms.Label()
        Me.thmReflectedWatts = New Thermometer.Thermometer()
        Me.thmVdd = New Thermometer.Thermometer()
        Me.thmIdd = New Thermometer.Thermometer()
        Me.thmDkRev = New Thermometer.Thermometer()
        Me.thmDkFor = New Thermometer.Thermometer()
        Me.thmTemp = New Thermometer.Thermometer()
        Me.thmALC_Level = New Thermometer.Thermometer()
        Me.thmWattsOut = New Thermometer.Thermometer()
        Me.cmdRstMaxMin = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblB0_XMIT
        '
        Me.lblB0_XMIT.AutoSize = True
        Me.lblB0_XMIT.BackColor = System.Drawing.SystemColors.Control
        Me.lblB0_XMIT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblB0_XMIT.Location = New System.Drawing.Point(40, 319)
        Me.lblB0_XMIT.MinimumSize = New System.Drawing.Size(75, 2)
        Me.lblB0_XMIT.Name = "lblB0_XMIT"
        Me.lblB0_XMIT.Size = New System.Drawing.Size(75, 15)
        Me.lblB0_XMIT.TabIndex = 8
        Me.lblB0_XMIT.Text = "TRANSMIT"
        Me.lblB0_XMIT.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblB1_SWR_Fault
        '
        Me.lblB1_SWR_Fault.BackColor = System.Drawing.SystemColors.Control
        Me.lblB1_SWR_Fault.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblB1_SWR_Fault.Location = New System.Drawing.Point(364, 318)
        Me.lblB1_SWR_Fault.MinimumSize = New System.Drawing.Size(75, 2)
        Me.lblB1_SWR_Fault.Name = "lblB1_SWR_Fault"
        Me.lblB1_SWR_Fault.Size = New System.Drawing.Size(75, 15)
        Me.lblB1_SWR_Fault.TabIndex = 9
        Me.lblB1_SWR_Fault.Text = "SWR FAULT"
        Me.lblB1_SWR_Fault.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblB2_OvrTemp
        '
        Me.lblB2_OvrTemp.AutoSize = True
        Me.lblB2_OvrTemp.BackColor = System.Drawing.SystemColors.Control
        Me.lblB2_OvrTemp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblB2_OvrTemp.Location = New System.Drawing.Point(202, 319)
        Me.lblB2_OvrTemp.MinimumSize = New System.Drawing.Size(75, 2)
        Me.lblB2_OvrTemp.Name = "lblB2_OvrTemp"
        Me.lblB2_OvrTemp.Size = New System.Drawing.Size(75, 15)
        Me.lblB2_OvrTemp.TabIndex = 10
        Me.lblB2_OvrTemp.Text = "OVER TEMP"
        Me.lblB2_OvrTemp.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblVolts0
        '
        Me.lblVolts0.AutoSize = True
        Me.lblVolts0.BackColor = System.Drawing.SystemColors.Control
        Me.lblVolts0.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblVolts0.Location = New System.Drawing.Point(40, 353)
        Me.lblVolts0.MinimumSize = New System.Drawing.Size(75, 2)
        Me.lblVolts0.Name = "lblVolts0"
        Me.lblVolts0.Size = New System.Drawing.Size(75, 15)
        Me.lblVolts0.TabIndex = 19
        Me.lblVolts0.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblVolts1
        '
        Me.lblVolts1.AutoSize = True
        Me.lblVolts1.BackColor = System.Drawing.SystemColors.Control
        Me.lblVolts1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblVolts1.Location = New System.Drawing.Point(121, 353)
        Me.lblVolts1.MinimumSize = New System.Drawing.Size(75, 2)
        Me.lblVolts1.Name = "lblVolts1"
        Me.lblVolts1.Size = New System.Drawing.Size(75, 15)
        Me.lblVolts1.TabIndex = 20
        Me.lblVolts1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblVolts2
        '
        Me.lblVolts2.AutoSize = True
        Me.lblVolts2.BackColor = System.Drawing.SystemColors.Control
        Me.lblVolts2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblVolts2.Location = New System.Drawing.Point(202, 353)
        Me.lblVolts2.MinimumSize = New System.Drawing.Size(75, 2)
        Me.lblVolts2.Name = "lblVolts2"
        Me.lblVolts2.Size = New System.Drawing.Size(75, 15)
        Me.lblVolts2.TabIndex = 21
        Me.lblVolts2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblVolts3
        '
        Me.lblVolts3.AutoSize = True
        Me.lblVolts3.BackColor = System.Drawing.SystemColors.Control
        Me.lblVolts3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblVolts3.Location = New System.Drawing.Point(283, 353)
        Me.lblVolts3.MinimumSize = New System.Drawing.Size(75, 2)
        Me.lblVolts3.Name = "lblVolts3"
        Me.lblVolts3.Size = New System.Drawing.Size(75, 15)
        Me.lblVolts3.TabIndex = 22
        Me.lblVolts3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblVolts4
        '
        Me.lblVolts4.AutoSize = True
        Me.lblVolts4.BackColor = System.Drawing.SystemColors.Control
        Me.lblVolts4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblVolts4.Location = New System.Drawing.Point(364, 353)
        Me.lblVolts4.MinimumSize = New System.Drawing.Size(75, 2)
        Me.lblVolts4.Name = "lblVolts4"
        Me.lblVolts4.Size = New System.Drawing.Size(75, 15)
        Me.lblVolts4.TabIndex = 23
        Me.lblVolts4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblVolts5
        '
        Me.lblVolts5.AutoSize = True
        Me.lblVolts5.BackColor = System.Drawing.SystemColors.Control
        Me.lblVolts5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblVolts5.Location = New System.Drawing.Point(445, 353)
        Me.lblVolts5.MinimumSize = New System.Drawing.Size(75, 2)
        Me.lblVolts5.Name = "lblVolts5"
        Me.lblVolts5.Size = New System.Drawing.Size(75, 15)
        Me.lblVolts5.TabIndex = 24
        Me.lblVolts5.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblVolts6
        '
        Me.lblVolts6.AutoSize = True
        Me.lblVolts6.BackColor = System.Drawing.SystemColors.Control
        Me.lblVolts6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblVolts6.Location = New System.Drawing.Point(526, 353)
        Me.lblVolts6.MinimumSize = New System.Drawing.Size(75, 2)
        Me.lblVolts6.Name = "lblVolts6"
        Me.lblVolts6.Size = New System.Drawing.Size(75, 15)
        Me.lblVolts6.TabIndex = 25
        Me.lblVolts6.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblVolts7
        '
        Me.lblVolts7.AutoSize = True
        Me.lblVolts7.BackColor = System.Drawing.SystemColors.Control
        Me.lblVolts7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblVolts7.Location = New System.Drawing.Point(607, 353)
        Me.lblVolts7.MinimumSize = New System.Drawing.Size(75, 2)
        Me.lblVolts7.Name = "lblVolts7"
        Me.lblVolts7.Size = New System.Drawing.Size(75, 15)
        Me.lblVolts7.TabIndex = 26
        Me.lblVolts7.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'thmReflectedWatts
        '
        Me.thmReflectedWatts.AccessibleDescription = "Thermometer amalog indicator"
        Me.thmReflectedWatts.aScaleMax = 400.0!
        Me.thmReflectedWatts.aScaleMin = 0!
        Me.thmReflectedWatts.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.thmReflectedWatts.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.thmReflectedWatts.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.thmReflectedWatts.Caption = "Watts Output Reflected"
        Me.thmReflectedWatts.CurrentValue = 0!
        Me.thmReflectedWatts.CurrentValueBackColor = System.Drawing.SystemColors.ButtonFace
        Me.thmReflectedWatts.ForeColor = System.Drawing.Color.Black
        Me.thmReflectedWatts.LblY0Value = 0!
        Me.thmReflectedWatts.LblY1Value = 100.0!
        Me.thmReflectedWatts.LblY2Value = 200.0!
        Me.thmReflectedWatts.LblY3Value = 300.0!
        Me.thmReflectedWatts.LblY4Value = 400.0!
        Me.thmReflectedWatts.Location = New System.Drawing.Point(607, 26)
        Me.thmReflectedWatts.MaxLegal = 0!
        Me.thmReflectedWatts.MaxMinReset = True
        Me.thmReflectedWatts.MaxOverMaxLegal = False
        Me.thmReflectedWatts.MaxValue = 0!
        Me.thmReflectedWatts.MaxValueBackColor = System.Drawing.Color.Gold
        Me.thmReflectedWatts.MaxValueVisible = True
        Me.thmReflectedWatts.MinLegal = 0!
        Me.thmReflectedWatts.MinUnderMinLegal = False
        Me.thmReflectedWatts.MinValue = 100.0!
        Me.thmReflectedWatts.MinValueBackColor = System.Drawing.Color.MediumAquamarine
        Me.thmReflectedWatts.MinValueVisible = False
        Me.thmReflectedWatts.Name = "thmReflectedWatts"
        Me.thmReflectedWatts.Size = New System.Drawing.Size(75, 275)
        Me.thmReflectedWatts.TabIndex = 18
        Me.thmReflectedWatts.ThermBottomBackColor = System.Drawing.Color.LimeGreen
        Me.thmReflectedWatts.ThermTopBackColor = System.Drawing.SystemColors.ButtonFace
        '
        'thmVdd
        '
        Me.thmVdd.AccessibleDescription = "Thermometer amalog indicator"
        Me.thmVdd.aScaleMax = 100.0!
        Me.thmVdd.aScaleMin = 0!
        Me.thmVdd.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.thmVdd.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.thmVdd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.thmVdd.Caption = "Vdd Volts"
        Me.thmVdd.CurrentValue = 25.0!
        Me.thmVdd.CurrentValueBackColor = System.Drawing.SystemColors.ButtonFace
        Me.thmVdd.ForeColor = System.Drawing.Color.Black
        Me.thmVdd.LblY0Value = 0!
        Me.thmVdd.LblY1Value = 25.0!
        Me.thmVdd.LblY2Value = 50.0!
        Me.thmVdd.LblY3Value = 75.0!
        Me.thmVdd.LblY4Value = 100.0!
        Me.thmVdd.Location = New System.Drawing.Point(526, 26)
        Me.thmVdd.MaxLegal = 0!
        Me.thmVdd.MaxMinReset = False
        Me.thmVdd.MaxOverMaxLegal = False
        Me.thmVdd.MaxValue = 0!
        Me.thmVdd.MaxValueBackColor = System.Drawing.Color.Gold
        Me.thmVdd.MaxValueVisible = True
        Me.thmVdd.MinLegal = 0!
        Me.thmVdd.MinUnderMinLegal = False
        Me.thmVdd.MinValue = 25.0!
        Me.thmVdd.MinValueBackColor = System.Drawing.Color.MediumAquamarine
        Me.thmVdd.MinValueVisible = False
        Me.thmVdd.Name = "thmVdd"
        Me.thmVdd.Size = New System.Drawing.Size(75, 275)
        Me.thmVdd.TabIndex = 17
        Me.thmVdd.ThermBottomBackColor = System.Drawing.Color.DarkMagenta
        Me.thmVdd.ThermTopBackColor = System.Drawing.SystemColors.ButtonFace
        '
        'thmIdd
        '
        Me.thmIdd.AccessibleDescription = "Thermometer amalog indicator"
        Me.thmIdd.aScaleMax = 100.0!
        Me.thmIdd.aScaleMin = 0!
        Me.thmIdd.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.thmIdd.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.thmIdd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.thmIdd.Caption = "Idd Amps"
        Me.thmIdd.CurrentValue = 25.0!
        Me.thmIdd.CurrentValueBackColor = System.Drawing.SystemColors.ButtonFace
        Me.thmIdd.ForeColor = System.Drawing.Color.Black
        Me.thmIdd.LblY0Value = 0!
        Me.thmIdd.LblY1Value = 25.0!
        Me.thmIdd.LblY2Value = 50.0!
        Me.thmIdd.LblY3Value = 75.0!
        Me.thmIdd.LblY4Value = 100.0!
        Me.thmIdd.Location = New System.Drawing.Point(445, 26)
        Me.thmIdd.MaxLegal = 75.0!
        Me.thmIdd.MaxMinReset = False
        Me.thmIdd.MaxOverMaxLegal = False
        Me.thmIdd.MaxValue = 0!
        Me.thmIdd.MaxValueBackColor = System.Drawing.Color.Gold
        Me.thmIdd.MaxValueVisible = True
        Me.thmIdd.MinLegal = 0!
        Me.thmIdd.MinUnderMinLegal = False
        Me.thmIdd.MinValue = 25.0!
        Me.thmIdd.MinValueBackColor = System.Drawing.Color.MediumAquamarine
        Me.thmIdd.MinValueVisible = False
        Me.thmIdd.Name = "thmIdd"
        Me.thmIdd.Size = New System.Drawing.Size(75, 275)
        Me.thmIdd.TabIndex = 16
        Me.thmIdd.ThermBottomBackColor = System.Drawing.Color.Firebrick
        Me.thmIdd.ThermTopBackColor = System.Drawing.SystemColors.ButtonFace
        '
        'thmDkRev
        '
        Me.thmDkRev.AccessibleDescription = "Thermometer amalog indicator"
        Me.thmDkRev.aScaleMax = 500.0!
        Me.thmDkRev.aScaleMin = 0!
        Me.thmDkRev.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.thmDkRev.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.thmDkRev.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.thmDkRev.Caption = "Deck Reverse Watts"
        Me.thmDkRev.CurrentValue = 100.0!
        Me.thmDkRev.CurrentValueBackColor = System.Drawing.SystemColors.ButtonFace
        Me.thmDkRev.ForeColor = System.Drawing.Color.Black
        Me.thmDkRev.LblY0Value = 0!
        Me.thmDkRev.LblY1Value = 200.0!
        Me.thmDkRev.LblY2Value = 300.0!
        Me.thmDkRev.LblY3Value = 400.0!
        Me.thmDkRev.LblY4Value = 500.0!
        Me.thmDkRev.Location = New System.Drawing.Point(364, 26)
        Me.thmDkRev.MaxLegal = 0!
        Me.thmDkRev.MaxMinReset = False
        Me.thmDkRev.MaxOverMaxLegal = True
        Me.thmDkRev.MaxValue = 0!
        Me.thmDkRev.MaxValueBackColor = System.Drawing.Color.Gold
        Me.thmDkRev.MaxValueVisible = True
        Me.thmDkRev.MinLegal = 0!
        Me.thmDkRev.MinUnderMinLegal = False
        Me.thmDkRev.MinValue = 0!
        Me.thmDkRev.MinValueBackColor = System.Drawing.Color.MediumAquamarine
        Me.thmDkRev.MinValueVisible = False
        Me.thmDkRev.Name = "thmDkRev"
        Me.thmDkRev.Size = New System.Drawing.Size(75, 275)
        Me.thmDkRev.TabIndex = 15
        Me.thmDkRev.ThermBottomBackColor = System.Drawing.Color.OrangeRed
        Me.thmDkRev.ThermTopBackColor = System.Drawing.SystemColors.ButtonFace
        '
        'thmDkFor
        '
        Me.thmDkFor.AccessibleDescription = "Thermometer amalog indicator"
        Me.thmDkFor.aScaleMax = 2200.0!
        Me.thmDkFor.aScaleMin = 0!
        Me.thmDkFor.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.thmDkFor.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.thmDkFor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.thmDkFor.Caption = "Deck Forward Watts"
        Me.thmDkFor.CurrentValue = 0!
        Me.thmDkFor.CurrentValueBackColor = System.Drawing.SystemColors.ButtonFace
        Me.thmDkFor.ForeColor = System.Drawing.Color.Black
        Me.thmDkFor.LblY0Value = 0!
        Me.thmDkFor.LblY1Value = 750.0!
        Me.thmDkFor.LblY2Value = 1500.0!
        Me.thmDkFor.LblY3Value = 2000.0!
        Me.thmDkFor.LblY4Value = 2200.0!
        Me.thmDkFor.Location = New System.Drawing.Point(283, 26)
        Me.thmDkFor.MaxLegal = 0!
        Me.thmDkFor.MaxMinReset = False
        Me.thmDkFor.MaxOverMaxLegal = False
        Me.thmDkFor.MaxValue = 0!
        Me.thmDkFor.MaxValueBackColor = System.Drawing.Color.Gold
        Me.thmDkFor.MaxValueVisible = True
        Me.thmDkFor.MinLegal = 0!
        Me.thmDkFor.MinUnderMinLegal = False
        Me.thmDkFor.MinValue = 0!
        Me.thmDkFor.MinValueBackColor = System.Drawing.Color.MediumAquamarine
        Me.thmDkFor.MinValueVisible = False
        Me.thmDkFor.Name = "thmDkFor"
        Me.thmDkFor.Size = New System.Drawing.Size(75, 275)
        Me.thmDkFor.TabIndex = 14
        Me.thmDkFor.ThermBottomBackColor = System.Drawing.Color.LimeGreen
        Me.thmDkFor.ThermTopBackColor = System.Drawing.SystemColors.ButtonFace
        '
        'thmTemp
        '
        Me.thmTemp.AccessibleDescription = "Thermometer amalog indicator"
        Me.thmTemp.aScaleMax = 60.0!
        Me.thmTemp.aScaleMin = 0!
        Me.thmTemp.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.thmTemp.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.thmTemp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.thmTemp.Caption = "Heat Sink Temp °C"
        Me.thmTemp.CurrentValue = 0!
        Me.thmTemp.CurrentValueBackColor = System.Drawing.SystemColors.ButtonFace
        Me.thmTemp.ForeColor = System.Drawing.Color.Black
        Me.thmTemp.LblY0Value = 20.0!
        Me.thmTemp.LblY1Value = 30.0!
        Me.thmTemp.LblY2Value = 40.0!
        Me.thmTemp.LblY3Value = 50.0!
        Me.thmTemp.LblY4Value = 60.0!
        Me.thmTemp.Location = New System.Drawing.Point(202, 26)
        Me.thmTemp.MaxLegal = 50.0!
        Me.thmTemp.MaxMinReset = True
        Me.thmTemp.MaxOverMaxLegal = True
        Me.thmTemp.MaxValue = 0!
        Me.thmTemp.MaxValueBackColor = System.Drawing.Color.Gold
        Me.thmTemp.MaxValueVisible = True
        Me.thmTemp.MinLegal = 0!
        Me.thmTemp.MinUnderMinLegal = False
        Me.thmTemp.MinValue = 60.0!
        Me.thmTemp.MinValueBackColor = System.Drawing.Color.MediumAquamarine
        Me.thmTemp.MinValueVisible = False
        Me.thmTemp.Name = "thmTemp"
        Me.thmTemp.Size = New System.Drawing.Size(75, 275)
        Me.thmTemp.TabIndex = 13
        Me.thmTemp.ThermBottomBackColor = System.Drawing.Color.DarkOrange
        Me.thmTemp.ThermTopBackColor = System.Drawing.SystemColors.ButtonFace
        '
        'thmALC_Level
        '
        Me.thmALC_Level.AccessibleDescription = "Thermometer amalog indicator"
        Me.thmALC_Level.aScaleMax = 1.0!
        Me.thmALC_Level.aScaleMin = -4.0!
        Me.thmALC_Level.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.thmALC_Level.BackColor = System.Drawing.SystemColors.Control
        Me.thmALC_Level.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.thmALC_Level.Caption = "ALC Level"
        Me.thmALC_Level.CurrentValue = 0!
        Me.thmALC_Level.CurrentValueBackColor = System.Drawing.SystemColors.ButtonFace
        Me.thmALC_Level.ForeColor = System.Drawing.Color.Black
        Me.thmALC_Level.LblY0Value = -3.0!
        Me.thmALC_Level.LblY1Value = -2.0!
        Me.thmALC_Level.LblY2Value = -1.0!
        Me.thmALC_Level.LblY3Value = 0!
        Me.thmALC_Level.LblY4Value = 1.0!
        Me.thmALC_Level.Location = New System.Drawing.Point(121, 26)
        Me.thmALC_Level.MaxLegal = 0!
        Me.thmALC_Level.MaxMinReset = False
        Me.thmALC_Level.MaxOverMaxLegal = False
        Me.thmALC_Level.MaxValue = 1.0!
        Me.thmALC_Level.MaxValueBackColor = System.Drawing.Color.Gold
        Me.thmALC_Level.MaxValueVisible = False
        Me.thmALC_Level.MinLegal = 0!
        Me.thmALC_Level.MinUnderMinLegal = False
        Me.thmALC_Level.MinValue = 0!
        Me.thmALC_Level.MinValueBackColor = System.Drawing.Color.MediumAquamarine
        Me.thmALC_Level.MinValueVisible = True
        Me.thmALC_Level.Name = "thmALC_Level"
        Me.thmALC_Level.Size = New System.Drawing.Size(75, 275)
        Me.thmALC_Level.TabIndex = 12
        Me.thmALC_Level.ThermBottomBackColor = System.Drawing.SystemColors.ButtonFace
        Me.thmALC_Level.ThermTopBackColor = System.Drawing.Color.LightSeaGreen
        '
        'thmWattsOut
        '
        Me.thmWattsOut.AccessibleDescription = "Thermometer amalog indicator"
        Me.thmWattsOut.aScaleMax = 1800.0!
        Me.thmWattsOut.aScaleMin = 0!
        Me.thmWattsOut.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.thmWattsOut.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.thmWattsOut.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.thmWattsOut.Caption = "Watts Output"
        Me.thmWattsOut.CurrentValue = 0!
        Me.thmWattsOut.CurrentValueBackColor = System.Drawing.SystemColors.Control
        Me.thmWattsOut.ForeColor = System.Drawing.Color.Black
        Me.thmWattsOut.LblY0Value = 0!
        Me.thmWattsOut.LblY1Value = 500.0!
        Me.thmWattsOut.LblY2Value = 1000.0!
        Me.thmWattsOut.LblY3Value = 1500.0!
        Me.thmWattsOut.LblY4Value = 1800.0!
        Me.thmWattsOut.Location = New System.Drawing.Point(40, 26)
        Me.thmWattsOut.MaxLegal = 0!
        Me.thmWattsOut.MaxMinReset = True
        Me.thmWattsOut.MaxOverMaxLegal = False
        Me.thmWattsOut.MaxValue = 0!
        Me.thmWattsOut.MaxValueBackColor = System.Drawing.Color.Gold
        Me.thmWattsOut.MaxValueVisible = True
        Me.thmWattsOut.MinLegal = 0!
        Me.thmWattsOut.MinUnderMinLegal = False
        Me.thmWattsOut.MinValue = 100.0!
        Me.thmWattsOut.MinValueBackColor = System.Drawing.Color.MediumAquamarine
        Me.thmWattsOut.MinValueVisible = False
        Me.thmWattsOut.Name = "thmWattsOut"
        Me.thmWattsOut.Size = New System.Drawing.Size(75, 275)
        Me.thmWattsOut.TabIndex = 11
        Me.thmWattsOut.ThermBottomBackColor = System.Drawing.Color.LimeGreen
        Me.thmWattsOut.ThermTopBackColor = System.Drawing.SystemColors.ButtonFace
        '
        'cmdRstMaxMin
        '
        Me.cmdRstMaxMin.Location = New System.Drawing.Point(526, 309)
        Me.cmdRstMaxMin.Name = "cmdRstMaxMin"
        Me.cmdRstMaxMin.Size = New System.Drawing.Size(75, 36)
        Me.cmdRstMaxMin.TabIndex = 27
        Me.cmdRstMaxMin.Text = "Reset Max Min"
        Me.cmdRstMaxMin.UseVisualStyleBackColor = True
        '
        'frm1p5KWDisplay
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(727, 377)
        Me.ControlBox = False
        Me.Controls.Add(Me.cmdRstMaxMin)
        Me.Controls.Add(Me.lblVolts7)
        Me.Controls.Add(Me.lblVolts6)
        Me.Controls.Add(Me.lblVolts5)
        Me.Controls.Add(Me.lblVolts4)
        Me.Controls.Add(Me.lblVolts3)
        Me.Controls.Add(Me.lblVolts2)
        Me.Controls.Add(Me.lblVolts1)
        Me.Controls.Add(Me.lblVolts0)
        Me.Controls.Add(Me.thmReflectedWatts)
        Me.Controls.Add(Me.thmVdd)
        Me.Controls.Add(Me.thmIdd)
        Me.Controls.Add(Me.thmDkRev)
        Me.Controls.Add(Me.thmDkFor)
        Me.Controls.Add(Me.thmTemp)
        Me.Controls.Add(Me.thmALC_Level)
        Me.Controls.Add(Me.lblB2_OvrTemp)
        Me.Controls.Add(Me.lblB1_SWR_Fault)
        Me.Controls.Add(Me.lblB0_XMIT)
        Me.Controls.Add(Me.thmWattsOut)
        Me.Location = New System.Drawing.Point(1800, 40)
        Me.Name = "frm1p5KWDisplay"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "GMC 1.5KW Parameters"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblB0_XMIT As Label
    Friend WithEvents lblB1_SWR_Fault As Label
    Friend WithEvents lblB2_OvrTemp As Label
    Friend WithEvents thmWattsOut As Thermometer.Thermometer
    Friend WithEvents thmALC_Level As Thermometer.Thermometer
    Friend WithEvents thmTemp As Thermometer.Thermometer
    Friend WithEvents thmDkFor As Thermometer.Thermometer
    Friend WithEvents thmDkRev As Thermometer.Thermometer
    Friend WithEvents thmIdd As Thermometer.Thermometer
    Friend WithEvents thmVdd As Thermometer.Thermometer
    Friend WithEvents thmReflectedWatts As Thermometer.Thermometer
    Friend WithEvents lblVolts0 As Label
    Friend WithEvents lblVolts1 As Label
    Friend WithEvents lblVolts2 As Label
    Friend WithEvents lblVolts3 As Label
    Friend WithEvents lblVolts4 As Label
    Friend WithEvents lblVolts5 As Label
    Friend WithEvents lblVolts6 As Label
    Friend WithEvents lblVolts7 As Label
    Friend WithEvents cmdRstMaxMin As Button
End Class
