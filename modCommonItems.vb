Option Strict On
Imports Microsoft.Win32

Module modCommonItems






    Public Function GetReg_HKCU_Value(SubKey As String, ValueName As String, DefltValue As Object, Optional Ask As Boolean = False) As Object
        'SubKey like: "Software\Microsoft\TestApp\1.0"
        Dim regKey As RegistryKey
        Dim keyTop As RegistryKey = Registry.CurrentUser
        Dim strRet As String
        Dim objRet As Object

        regKey = keyTop.OpenSubKey(SubKey, True)
        If regKey Is Nothing Then
            If Ask Then
                strRet = InputBox("New Registry Value", ValueName, DefltValue.ToString)
                If strRet = "" Then
                    GetReg_HKCU_Value = Nothing
                    Return GetReg_HKCU_Value
                Else
                    DefltValue = CTypeDynamic(strRet, DefltValue.GetType)
                End If
            End If
            regKey = keyTop.CreateSubKey(SubKey)
            If DefltValue Is Nothing Then
                Return DefltValue
            End If
            regKey.SetValue(ValueName, DefltValue)
            Return DefltValue
        Else
            objRet = regKey.GetValue(ValueName)
            If (objRet Is Nothing) Or (objRet.ToString = "") Then
                If Ask Then
                    strRet = InputBox("New Registry Value", ValueName, DefltValue.ToString)
                    If strRet = "" Then
                        GetReg_HKCU_Value = Nothing
                        Return GetReg_HKCU_Value
                    Else
                        DefltValue = CTypeDynamic(strRet, DefltValue.GetType)
                    End If
                End If
                If DefltValue Is Nothing Then
                    Return DefltValue
                End If
                regKey.SetValue(ValueName, DefltValue)
                Return DefltValue
            Else
                Return objRet
            End If
        End If
        'Dim binValue As Byte() = {&HF0, &HFF, &H12, &HE0, &H43, &HAC}
        'Dim strngValue As String() = {"A", "B", "C", "D"}

        'regKey.SetValue("WindowState", 0, RegistryValueKind.DWord)

        'regKey.SetValue("CustomWindowCaption", "Client Contact Management",RegistryValueKind.String)

        'regKey.SetValue("CustomPosition", binValue, RegistryValueKind.Binary)
        'regKey.SetValue("CustomLabels", strngValue, RegistryValueKind.MultiString)



    End Function


    Public Function SetReg_HKCU_Value(SubKey As String, ValueName As String, Value As Object, ByRef ErrStr As String) As Boolean
        'SubKey like: "Software\Microsoft\TestApp\1.0"
        Dim regKey As RegistryKey
        Dim keyTop As RegistryKey = Registry.CurrentUser
        Dim strRet As String
        Dim objRet As Object
        Try
            ErrStr = ""
            regKey = keyTop.OpenSubKey(SubKey, True)
            If regKey Is Nothing Then
                regKey = keyTop.CreateSubKey(SubKey)
                regKey.SetValue(ValueName, Value)
                Return True
            Else
                regKey.SetValue(ValueName, Value)
                Return True
            End If

        Catch ex As ArgumentException
            ErrStr = "Set " & ValueName & " Failed " & ex.ToString
            Return False
        End Try

    End Function

End Module
