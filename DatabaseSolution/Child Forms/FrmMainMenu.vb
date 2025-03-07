Public Class FrmMainMenu

    Private Sub EnableButtons()

        If dbPath = "" Then
            BtnOpenDatabase.Enabled = False
            BtnCloseDatabase.Enabled = False
            BtnOpenInAccess.Enabled = False
        Else
            BtnOpenInAccess.Enabled = True
            If isConnectionOpen Then
                BtnOpenDatabase.Enabled = False
                BtnCloseDatabase.Enabled = True
            Else
                BtnOpenDatabase.Enabled = True
                BtnCloseDatabase.Enabled = False
            End If
        End If

    End Sub

    Private Sub BtnBrowse_Click(sender As Object, e As EventArgs) Handles BtnBrowse.Click

        If LvwRecentDatabases.Items.Count > 0 Then
            LvwRecentDatabases.SelectedItems.Clear()
        End If

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
            LblSystemMessage.Visible = False
            EnableButtons()
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
        EnableButtons()
        BtnOpenDatabase.Enabled = True
        BtnCloseDatabase.Enabled = False

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
        SaveToRecentDatabases()
        LoadRecentDatabases()

    End Sub

    Private Sub FrmMainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If isConnectionOpen Then
            BtnBrowse.Enabled = False
        Else
            BtnBrowse.Enabled = True
        End If

        LblSystemMessage.Visible = False
        EnableButtons()
        LoadRecentDatabases()

    End Sub


    Private Sub LvwRecentDatabases_DoubleClick(sender As Object, e As EventArgs) Handles LvwRecentDatabases.DoubleClick

        If LvwRecentDatabases.SelectedItems.Count > 0 Then
            If Not isConnectionOpen Then
                TxtDatabaseName.Text = LvwRecentDatabases.SelectedItems(0).SubItems(1).Text
                TxtDatabasePath.Text = LvwRecentDatabases.SelectedItems(0).SubItems(2).Text
                dbPath = TxtDatabasePath.Text
                dbName = TxtDatabaseName.Text
            End If
        End If

        LblSystemMessage.Visible = False
        EnableButtons()

    End Sub
End Class