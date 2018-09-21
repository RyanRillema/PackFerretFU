Public Class FerretConst

    Public sSavePath As String
    Public iTotalPacks As Integer
    Public sVersion As String

    Public Sub New()

        'Set default const
        sSavePath = "C:/PackFerret"
        iTotalPacks = 20
        sVersion = "0.1.1"

    End Sub

    Public Function getFormattedVersion() As String
        Dim sFormattedString As String

        sFormattedString = "V " & sVersion

        Return sFormattedString
    End Function

End Class
