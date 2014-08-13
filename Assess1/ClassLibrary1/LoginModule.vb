' Developer:    Enrique Johannes Buck
' Date:         16/3/2014

'Login Module which contains reusable variables, to be used across the entire application.
Module LoginModule

    Public _Cn As New SqlClient.SqlConnection("")
    Public _UserName As String = ""
    Public _PassWord As String = ""
    Public _AccessLevel As String = ""

End Module
