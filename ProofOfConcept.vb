Public Class ProofOfConcept

    Public PackFerret As PackFerret

    Private Sub cmdExit_Click(sender As Object, e As EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub

    Private Sub cmdLaunch_Click(sender As Object, e As EventArgs) Handles cmdLaunch.Click
        PackFerret.CreateClient("Test", "Test", tbIP.Text, tbLogin.Text, tbPass.Text, tbService.Text)
        ' PackFerret.Run()
    End Sub

    Private Sub ProofOfConcept_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'PackFerret = New PackFerret()

    End Sub
End Class
