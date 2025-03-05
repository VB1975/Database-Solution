Public Class FrmForms
    Private Sub BtnMainMenu_Click(sender As Object, e As EventArgs) Handles BtnMainMenu.Click

        ShowMainMenu()

    End Sub

    Private Sub FrmForms_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        LoadFormNames(dbPath)

    End Sub
End Class