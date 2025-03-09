Imports System.Data.OleDb
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Module ModRecentDatabases

    Public DatabasePath As String = IO.Path.Combine(Application.StartupPath, "Databases/RecentDatabases.accdb")
    Public Provider As String = "Provider=Microsoft.ACE.OLEDB.16.0;"
    Public DataSource As String = "Data Source=" & DatabasePath & ";"
    Public connString As String = Provider & DataSource

    Public Sub AddOrUpdateDatabaseRecord()

        Try
            Using conn As New OleDbConnection(connString)
                conn.Open()

                ' Step 1: Check if the dbPath already exists
                Dim checkQuery As String = "SELECT COUNT(*) FROM RecentDatabaseT WHERE DatabasePath = ?"
                Using checkCmd As New OleDbCommand(checkQuery, conn)
                    checkCmd.Parameters.Add("?", OleDbType.VarChar, 255).Value = dbPath
                    Dim recordCount As Integer = Convert.ToInt32(checkCmd.ExecuteScalar())

                    If recordCount > 0 Then
                        ' Step 2: Update LastOpened if the record exists
                        Dim updateQuery As String = "UPDATE RecentDatabaseT SET LastOpened = ? WHERE DatabasePath = ?"
                        Using updateCmd As New OleDbCommand(updateQuery, conn)
                            updateCmd.Parameters.Add("?", OleDbType.Date).Value = DateTime.Now
                            updateCmd.Parameters.Add("?", OleDbType.VarChar, 255).Value = dbPath
                            updateCmd.ExecuteNonQuery()
                        End Using
                    Else
                        ' Step 3: Insert a new record if it doesn't exist
                        Dim insertQuery As String = "INSERT INTO RecentDatabaseT (DatabaseName, DatabasePath, LastOpened) VALUES (?, ?, ?)"
                        Using insertCmd As New OleDbCommand(insertQuery, conn)
                            insertCmd.Parameters.Add("?", OleDbType.VarChar, 255).Value = dbName
                            insertCmd.Parameters.Add("?", OleDbType.VarChar, 255).Value = dbPath
                            insertCmd.Parameters.Add("?", OleDbType.Date).Value = DateTime.Now
                            insertCmd.ExecuteNonQuery()
                        End Using
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Public Sub SaveToRecentDatabasesX()

        Dim objItem As ListViewItem
        Dim frm As FrmMainMenu = TryCast(FrmDatabase.SplitDatabase.Panel2.Controls.OfType(Of FrmMainMenu)().FirstOrDefault(), FrmMainMenu)

        objItem = frm.LvwRecentDatabases.Items.Add(dbName)
        objItem.SubItems.Add(dbPath)
        objItem.SubItems.Add(DateTime.Now.ToString("dd/MM/yyyy  HH:mm:ss"))

    End Sub
End Module
