Public Class FrmMainMenu
    Private Sub BtnBrowse_Click(sender As Object, e As EventArgs) Handles BtnBrowse.Click

        Dim ofdDB As New OpenFileDialog With {
            .Filter = "Database Files (*.accdb)|*.accdb",
            .Title = "Select Database File",
            .InitialDirectory = defaultFolder
        }

        If ofdDB.ShowDialog = DialogResult.OK Then
            TxtDatabasePath.Text = ofdDB.FileName
            TxtDatabaseName.Text = ofdDB.SafeFileName
            dbPath = ofdDB.FileName
            dbName = ofdDB.SafeFileName
            ShowMainMenu()
        End If

    End Sub

    Private Sub BtnOpenInAccess_Click(sender As Object, e As EventArgs) Handles BtnOpenInAccess.Click

        Process.Start(New ProcessStartInfo(dbPath) With {.UseShellExecute = True})

    End Sub

    Private Sub BtnCloseDatabase_Click(sender As Object, e As EventArgs) Handles BtnCloseDatabase.Click

        dbPath = ""
        dbName = ""

        isConnectionOpen = False
        BtnOpenDatabase.Text = "Open Database"
        BtnOpenDatabase.Enabled = True
        BtnCloseDatabase.Enabled = False
        ShowMainMenu()

    End Sub

    Private Sub BtnSettings_Click(sender As Object, e As EventArgs) Handles BtnSettings.Click

        ShowSettings()

    End Sub

    Private Sub BtnOpenDatabase_Click(sender As Object, e As EventArgs) Handles BtnOpenDatabase.Click

        OpenConnection()
        isConnectionOpen = True
        BtnOpenDatabase.Text = "Database Open"
        BtnBrowse.Enabled = False
        BtnOpenDatabase.Enabled = False
        BtnCloseDatabase.Enabled = True
        LblSystemMessage.Visible = False

    End Sub

    Private Sub FrmMainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If isConnectionOpen Then
            BtnBrowse.Enabled = False
        Else
            BtnBrowse.Enabled = True
        End If

        LblSystemMessage.Visible = False

    End Sub
End Class