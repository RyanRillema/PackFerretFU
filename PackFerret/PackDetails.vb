Public Class PackDetails

    Public sName As String
    Public sIdentifier As String
    Public sIP As String
    Public sLogin As String
    Public sPass As String
    Public sService As String
    Public sExeString As String

    Public Sub Setup(sSetName As String, sSetIdentifier As String, sSetIp As String, sSetLogin As String, sSetPass As String, sSetService As String)

        sName = sSetName
        sSetIdentifier = sSetIdentifier
        sIP = sSetIp
        sLogin = sSetLogin
        sPass = sSetPass
        sService = sSetService

    End Sub

    Public Function CreateExe() As String
        sExeString = "kclient: -h?" & sIP & "?-R?-v?""" & sService & """?-V?790 -u " & sLogin & " -X " & sPass

        Return sExeString

    End Function

End Class
