Module ErrorDefs

    Public ReportError As MccDaq.ErrorReporting
    Public HandleError As MccDaq.ErrorHandling
    Public GeneralError As Boolean

    Public Sub DisplayError(ByVal ErrCode As MccDaq.ErrorInfo)

        MsgBox("Cannot run sample program. Error reported: " & _
            ErrCode.Message, MsgBoxStyle.Critical, _
            "Unexpected Universal Library Error")
        GeneralError = True

    End Sub

End Module
