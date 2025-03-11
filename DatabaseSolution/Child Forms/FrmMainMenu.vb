Imports System.Data.OleDb

Public Class FrmMainMenu

    Private Sub LoadRecentDatabases()

        ' Query to retrieve data
        Dim query As String = "SELECT DatabaseID, DatabaseName, DatabasePath, LastOpened FROM RecentDatabaseQ"

        ' Create a temporary list to store items (to update UI in one step)
        Dim items As New List(Of ListViewItem)()

        Try
            ' Open connection
            Using conn As New OleDbConnection(connString)
                Using cmd As New OleDbCommand(query, conn)
                    conn.Open()
                    Using reader As OleDbDataReader = cmd.ExecuteReader()
                        ' Loop through query results
                        While reader.Read()
                            ' Create a new ListView item
                            Dim item As New ListViewItem(reader("DatabaseID").ToString())
                            item.SubItems.Add(reader("DatabaseName").ToString())
                            item.SubItems.Add(reader("DatabasePath").ToString())
                            item.SubItems.Add(Convert.ToDateTime(reader("LastOpened")).ToString("yyyy-MM-dd HH:mm:ss"))

                            ' Add to temporary list (not the UI yet)
                            items.Add(item)
                        End While
                    End Using
                End Using
                conn.Close()
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading recent databases: " & ex.Message)
            Exit Sub
        End Try

        ' Update UI on the main thread
        If Me.InvokeRequired Then
            Me.Invoke(Sub()
                          LvwRecentDatabases.Items.Clear()
                          LvwRecentDatabases.Items.AddRange(items.ToArray())
                      End Sub)
        Else
            LvwRecentDatabases.Items.Clear()
            LvwRecentDatabases.Items.AddRange(items.ToArray())
        End If

    End Sub


    Private Sub EnableButtons()

        If dbPath = "" Then
            BtnOpenDatabase.Enabled = False
            BtnCloseDatabase.Enabled = False
            BtnBrowse.Enabled = True
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

        TxtDatabaseName.Clear()
        TxtDatabasePath.Clear()
        dbPath = ""
        dbName = ""

        isConnectionOpen = False
        BtnOpenDatabase.Text = "Open Database"
        EnableButtons()

    End Sub

    Private Sub BtnSettings_Click(sender As Object, e As EventArgs) Handles BtnSettings.Click

        ShowSettings()

    End Sub

    Private Sub OpenDatabase()

        OpenConnection()
        isConnectionOpen = True
        BtnOpenDatabase.Text = "Database Open"
        BtnBrowse.Enabled = False
        BtnOpenDatabase.Enabled = False
        BtnCloseDatabase.Enabled = True
        LblSystemMessage.Visible = False
        AddOrUpdateDatabaseRecord()
        LoadRecentDatabases()

    End Sub

    Private Sub BtnOpenDatabase_Click(sender As Object, e As EventArgs) Handles BtnOpenDatabase.Click

        OpenDatabase()

    End Sub

    Private Sub FrmMainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If isConnectionOpen Then
            BtnBrowse.Enabled = False
        Else
            BtnBrowse.Enabled = True
        End If

        LblSystemMessage.Visible = False
        EnableButtons()

    End Sub

    Private Sub SelectDatabase(sender As Object, e As EventArgs) Handles LvwRecentDatabases.DoubleClick, MnuItemSelectDatabase.Click

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

    Private Async Sub FrmMainMenu_Shown(sender As Object, e As EventArgs) Handles Me.Shown

        Await Task.Run(Sub() LoadRecentDatabases())

    End Sub

    Private Sub MnuItemOpenDatabase_Click(sender As Object, e As EventArgs) Handles MnuItemOpenDatabase.Click

        SelectDatabase(sender, e)
        OpenDatabase()

    End Sub

    Private Sub MnuItemOpenInAccess_Click(sender As Object, e As EventArgs) Handles MnuItemOpenInAccess.Click

        Process.Start(New ProcessStartInfo(LvwRecentDatabases.SelectedItems(0).SubItems(2).Text) With {.UseShellExecute = True})

    End Sub

    Private Sub MnuItemRemoveFromList_Click(sender As Object, e As EventArgs) Handles MnuItemRemoveFromList.Click

        dbPath = LvwRecentDatabases.SelectedItems(0).SubItems(2).Text
        DeleteRecentDatabaseEntry()
        dbPath = ""
        LoadRecentDatabases()

    End Sub
End Class