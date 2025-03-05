Public Class FrmReports
    Private Sub BtnMainMenu_Click(sender As Object, e As EventArgs) Handles BtnMainMenu.Click

        ShowMainMenu()

    End Sub

    Private Sub FrmReports_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        LoadReportNames(dbPath)

    End Sub
End Class