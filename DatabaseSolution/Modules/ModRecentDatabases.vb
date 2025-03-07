Imports System.Data.OleDb

Module ModRecentDatabases

    Private DatabasePath As String = AppDomain.CurrentDomain.BaseDirectory & "Databases/RecentDatabases.accdb"
    Private Provider As String = "Provider=Microsoft.ACE.OLEDB.16.0;"
    Private DataSource As String = "Data Source=" & DatabasePath & ";"
    Private connString As String = Provider & DataSource

    Public Sub SaveToRecentDatabases()

        Dim query As String = "INSERT INTO RecentDatabaseT (DatabaseName, DatabasePath, LastOpened) VALUES (?, ?, ?)"

        Using conn As New OleDbConnection(connString)
            Using cmd As New OleDbCommand(query, conn)

                ' Define parameters with explicit data types
                cmd.Parameters.Add("?", OleDbType.VarChar, 255).Value = dbName  ' Short Text
                cmd.Parameters.Add("?", OleDbType.VarChar, 255).Value = dbPath  ' Short Text
                cmd.Parameters.Add("?", OleDbType.Date).Value = DateTime.Now    ' Date/Time

                conn.Open()
                cmd.ExecuteNonQuery()
            End Using
        End Using

    End Sub

    Public Sub LoadRecentDatabases()

        ' Query to retrieve data
        Dim query As String = "SELECT DatabaseID, DatabaseName, DatabasePath, LastOpened FROM RecentDatabaseQ"
        Dim frm As FrmMainMenu = TryCast(FrmDatabase.SplitDatabase.Panel2.Controls.OfType(Of FrmMainMenu)().FirstOrDefault(), FrmMainMenu)

        ' Open connection
        Using conn As New OleDbConnection(connString)
            Using cmd As New OleDbCommand(query, conn)
                conn.Open()
                Using reader As OleDbDataReader = cmd.ExecuteReader()
                    ' Clear existing items in the ListView
                    frm.LvwRecentDatabases.Items.Clear()

                    ' Loop through query results
                    While reader.Read()
                        ' Create a new ListView item
                        Dim item As New ListViewItem(reader("DatabaseID").ToString()) ' First column

                        ' Add sub-items (remaining columns)
                        item.SubItems.Add(reader("DatabaseName").ToString())
                        item.SubItems.Add(reader("DatabasePath").ToString())
                        item.SubItems.Add(Convert.ToDateTime(reader("LastOpened")).ToString("yyyy-MM-dd HH:mm:ss")) ' Format date

                        ' Add the item to ListView
                        frm.LvwRecentDatabases.Items.Add(item)
                    End While
                End Using
            End Using
        End Using

    End Sub

    Public Sub SaveToRecentDatabasesX()

        Dim objItem As ListViewItem
        Dim frm As FrmMainMenu = TryCast(FrmDatabase.SplitDatabase.Panel2.Controls.OfType(Of FrmMainMenu)().FirstOrDefault(), FrmMainMenu)

        objItem = frm.LvwRecentDatabases.Items.Add(dbName)
        objItem.SubItems.Add(dbPath)
        objItem.SubItems.Add(DateTime.Now.ToString("dd/MM/yyyy  HH:mm:ss"))

    End Sub
End Module
