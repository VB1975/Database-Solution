Public Class FrmSettings
    Private Sub BtnMainMenu_Click(sender As Object, e As EventArgs) Handles BtnMainMenu.Click

        SaveSettingsToRegistry()
        ShowMainMenu()

    End Sub

    Private Sub BtnSelectFolder_Click(sender As Object, e As EventArgs) Handles BtnSelectFolder.Click

        foldDefault.Title = "Select a folder"
        foldDefault.RootFolder = defaultFolder
        foldDefault.Multiselect = False

        If foldDefault.ShowDialog() = DialogResult.OK Then
            TxtDefaultFolder.Text = foldDefault.SelectedFolder
            defaultFolder = foldDefault.SelectedFolder
        End If

    End Sub

    Private Sub FrmSettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        TxtDefaultFolder.Text = defaultFolder

    End Sub
End Class