Public Class frm1p5KWDisplay

    Public lblBitNum As System.Windows.Forms.Label()
    Public lblBitVal As System.Windows.Forms.Label()
    Public lblVolts As System.Windows.Forms.Label()
    Public lblBitValBackClr As Color()
    Public sngMultiplier As Single()
    Public sngOffset As Single()

    Private sngWattsOutAvg As Single
    Private sngWattsRevAvg As Single
    Private sngALCAvg As Single
    Private strSubkey As String = "Software\AF5LA\GMC1p5KWDisplay"





    Public Sub UpdAnalogControls(ByVal ADData() As UInt16)
        Dim i As Integer
        Dim sngVolts As Single
        Dim sngScaledVal As Single
        Dim sngMult As Single
        Dim sngOffSt As Single

        For i = 0 To 7
            'lblADData(i).Text = ADData(i).ToString("D")
            sngVolts = ConvertADDataToVolts(ADData(i))
            lblVolts(i).Text = sngVolts.ToString("F3")
            sngMult = sngMultiplier(i)
            sngOffSt = sngOffset(i)
            Select Case i
                Case 0 'Watts out
                    sngScaledVal = CalcPwrFromBridgeVolts(sngVolts)
                    sngScaledVal = ((sngScaledVal * sngMult) + sngOffSt)
                    If sngWattsOutAvg < sngScaledVal Then
                        sngWattsOutAvg = sngScaledVal
                    Else
                        sngWattsOutAvg = (3 * sngWattsOutAvg + sngScaledVal) / 4
                    End If
                    Me.thmWattsOut.CurrentValue = CSng(sngWattsOutAvg.ToString("F0"))
                Case 1 'ALC
                    sngScaledVal = (sngVolts * sngMult) + sngOffSt
                    If sngALCAvg > sngScaledVal Then
                        sngALCAvg = sngScaledVal
                    Else
                        sngALCAvg = (3 * sngALCAvg + sngScaledVal) / 4
                    End If
                    Me.thmALC_Level.CurrentValue = CSng(sngALCAvg.ToString("F2"))
                Case 2 'Heat sink temp
                    sngScaledVal = (sngVolts * sngMult) + sngOffSt
                    Me.thmTemp.CurrentValue = CSng(sngScaledVal.ToString("F0"))
                Case 3
                    'Power is proportional to Volts squared
                    sngScaledVal = ((sngVolts ^ 2) * sngMult) + sngOffSt
                    Me.thmDkFor.CurrentValue = CSng(sngScaledVal).ToString("F0")
                Case 4
                    'Power is proportional to Volts squared
                    sngScaledVal = ((sngVolts ^ 2) * sngMult) + sngOffSt
                    Me.thmDkRev.CurrentValue = CSng(sngScaledVal.ToString("F0"))
                Case 5
                    Me.thmIdd.CurrentValue = CSng(((sngVolts * sngMult) + sngOffSt).ToString("F0"))
                Case 6
                    Me.thmVdd.CurrentValue = CSng(((sngVolts * sngMult) + sngOffSt).ToString("F0"))
                Case 7
                    'Debug.Print(sngVolts.ToString)
                    sngScaledVal = CalcPwrFromBridgeVolts(sngVolts)
                    sngScaledVal = ((sngScaledVal * sngMult) + sngOffSt)
                    If sngWattsRevAvg < sngScaledVal Then
                        sngWattsRevAvg = sngScaledVal
                    Else
                        sngWattsRevAvg = (3 * sngWattsRevAvg + sngScaledVal) / 4
                    End If
                    Me.thmReflectedWatts.CurrentValue = CSng(sngWattsRevAvg.ToString("F0"))
                    'Me.thmReflectedWatts.CurrentValue = CSng(((sngVolts * sngMult) + sngOffSt).ToString("F0"))
            End Select
        Next i
    End Sub

    Public Sub UpdDigitalControls(ByVal DataValue As UShort)
        Dim I As Short
        Dim NumBits As Integer = 3
        'Dim ULStat As MccDaq.ErrorInfo
        'Dim DataValue As UInt16

        For I = 0 To NumBits - 1
            If (Convert.ToInt32(DataValue) And CInt((2 ^ I))) <> 0 Then
                'lblBitVal(I).Text = "1"
                lblBitVal(I).BackColor = lblBitValBackClr(I)
            Else
                'lblBitVal(I).Text = "0"
                lblBitVal(I).BackColor = Color.FromName("ControlLightLight")
            End If
        Next I

    End Sub

    Private Sub frm1p5KWDisplay_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim frmMyForm As Windows.Forms.Form
        Dim strErrStr As String = ""
        Dim mbrMBRET As MsgBoxResult

        InitUL()

        frmMyForm = sender
        If Not regSetFrmLocation(strSubkey, frmMyForm, strErrStr) Then
            mbrMBRET = MsgBox("Location Set failed " & vbCrLf & strErrStr)
        End If

    End Sub

    Private Sub InitUL()

        Dim i As Integer
        Dim sngRegVal As Single

        lblBitVal = New System.Windows.Forms.Label(3) {}
        Me.lblBitVal.SetValue(Me.lblB0_XMIT, 0)
        Me.lblBitVal.SetValue(Me.lblB1_SWR_Fault, 1)
        Me.lblBitVal.SetValue(Me.lblB2_OvrTemp, 2)
        'Me.lblBitVal.SetValue(Me._lblBitVal_3, 3)
        'Me.lblBitVal.SetValue(Me._lblBitVal_4, 4)
        'Me.lblBitVal.SetValue(Me._lblBitVal_5, 5)
        'Me.lblBitVal.SetValue(Me._lblBitVal_6, 6)
        'Me.lblBitVal.SetValue(Me._lblBitVal_7, 7)

        lblBitValBackClr = New Color(3) {}
        Me.lblBitValBackClr.SetValue(Color.LightGreen, 0)
        Me.lblBitValBackClr.SetValue(Color.Red, 1)
        Me.lblBitValBackClr.SetValue(Color.Red, 2)

        lblVolts = New System.Windows.Forms.Label(8) {}
        Me.lblVolts.SetValue(Me.lblVolts0, 0)
        Me.lblVolts.SetValue(Me.lblVolts1, 1)
        Me.lblVolts.SetValue(Me.lblVolts2, 2)
        Me.lblVolts.SetValue(Me.lblVolts3, 3)
        Me.lblVolts.SetValue(Me.lblVolts4, 4)
        Me.lblVolts.SetValue(Me.lblVolts5, 5)
        Me.lblVolts.SetValue(Me.lblVolts6, 6)
        Me.lblVolts.SetValue(Me.lblVolts7, 7)

        sngMultiplier = New Single(8) {}
        Me.sngMultiplier.SetValue(CSng(480), 0)
        Me.sngMultiplier.SetValue(CSng(1), 1)
        Me.sngMultiplier.SetValue(CSng(-8.16), 2)
        Me.sngMultiplier.SetValue(CSng(-300), 3)
        Me.sngMultiplier.SetValue(CSng(-100), 4)
        Me.sngMultiplier.SetValue(CSng(10), 5)
        Me.sngMultiplier.SetValue(CSng(10), 6)
        Me.sngMultiplier.SetValue(CSng(0), 7)


        sngOffset = New Single(8) {}
        Me.sngOffset.SetValue(CSng(-70), 0)
        Me.sngOffset.SetValue(CSng(0), 1)
        Me.sngOffset.SetValue(CSng(60), 2)
        Me.sngOffset.SetValue(CSng(0), 3)
        Me.sngOffset.SetValue(CSng(0), 4)
        Me.sngOffset.SetValue(CSng(0), 5)
        Me.sngOffset.SetValue(CSng(0), 6)
        Me.sngOffset.SetValue(CSng(0), 7)



        For i = 0 To 7
            sngRegVal = CSng(modCommonItems.GetReg_HKCU_Value(strSubkey & "\AnaScaling", "Multiplier" & CStr(i), Me.sngMultiplier(i)))
            Me.sngMultiplier.SetValue(sngRegVal, i)

            sngRegVal = CSng(modCommonItems.GetReg_HKCU_Value(strSubkey & "\AnaScaling", "Offset" & CStr(i), Me.sngOffset(i)))
            Me.sngOffset.SetValue(sngRegVal, i)

        Next i


    End Sub

    Private Function ConvertADDataToVolts(BipIn As UInt16) As Single
        'BipIn is 12 bit value from AD convertor, 
        '0 (&X000) = -10 Volts, 
        '2047 (&X7FF) = 0 Volts And 
        '4095 (&XFFF) = +10 volts
        ConvertADDataToVolts = BipIn * (20 / 4096) - 10
    End Function

    Private Function CalcPwrFromBridgeVolts(VoltsIn As Single) As Single
        ' =(6.4* (((5*G10)/2)^2)) + 9
        CalcPwrFromBridgeVolts = (((5 * VoltsIn) / 2) ^ 2)


    End Function

    Private Sub frm1p5KWDisplay_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

        Dim frmMyForm As Windows.Forms.Form
        Dim strErrStr As String = ""
        Dim mbrMBRET As MsgBoxResult

        frmMyForm = sender
        If Not regSaveFrmLocation(strSubkey, frmMyForm, strErrStr) Then
            mbrMBRET = MsgBox("Location Save failed " & vbCrLf & strErrStr)
        End If
    End Sub

    Private Sub lblB1_SWR_Fault_Click(sender As Object, e As EventArgs) Handles lblB1_SWR_Fault.Click
        'Momentary pulse the bit Bit 03 Binary (XXXX1XXX)
        frmAnaIn.boolPulseSWRBit = True
    End Sub

    Private Sub cmdRstMaxMin_Click(sender As Object, e As EventArgs) Handles cmdRstMaxMin.Click

        Me.thmWattsOut.MaxMinReset = True

        Me.thmALC_Level.MaxMinReset = True

        Me.thmTemp.MaxMinReset = True

        Me.thmDkFor.MaxMinReset = True

        Me.thmDkRev.MaxMinReset = True

        Me.thmIdd.MaxMinReset = True

        Me.thmVdd.MaxMinReset = True

        Me.thmReflectedWatts.MaxMinReset = True

    End Sub

    Private Sub frm1p5KWDisplay_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        frmAnaIn.Activate()
    End Sub
End Class