Imports System.Data.OleDb
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports Microsoft.Office.Interop.Access

Module ModDatabaseObjects


    Public Sub LoadTableNames(DatabasePath As String)

        Dim conString As String = $"Provider=Microsoft.ACE.OLEDB.16.0;Data Source={DatabasePath};Persist Security Info=False;"
        Using conn As New OleDbConnection(conString)
            Try

                Dim frm As FrmTables = TryCast(FrmDatabase.SplitDatabase.Panel2.Controls.OfType(Of FrmTables)().FirstOrDefault(), FrmTables)
                frm.LblTables.Text = "Tables - Loading..."
                Application.DoEvents()

                conn.Open()
                ' Get the schema for tables
                Dim schemaTable As DataTable = conn.GetSchema("Tables")
                frm.LstTables.Items.Clear()

                ' Loop through tables and filter only user tables
                For Each row As DataRow In schemaTable.Rows
                    Dim tableType As String = row("TABLE_TYPE").ToString()
                    Dim tableName As String = row("TABLE_NAME").ToString()

                    ' Exclude system tables
                    If tableType = "TABLE" AndAlso Not tableName.StartsWith("MSys") AndAlso Not tableName.StartsWith("~TMP") Then
                        frm.LstTables.Items.Add(tableName)
                    End If
                Next
                frm.LblTables.Text = "Tables"
            Catch ex As Exception

                MessageBox.Show("Error: " & ex.Message)

            End Try
        End Using

    End Sub

    Public Sub LoadQueryNames(DatabasePath As String)

        Dim conString As String = $"Provider=Microsoft.ACE.OLEDB.16.0;Data Source={DatabasePath};Persist Security Info=False;"
        Using conn As New OleDbConnection(conString)
            Try

                Dim frm As FrmQueries = TryCast(FrmDatabase.SplitDatabase.Panel2.Controls.OfType(Of FrmQueries)().FirstOrDefault(), FrmQueries)
                frm.LblQueries.Text = "Queries - Loading..."
                Application.DoEvents()

                conn.Open()
                ' Get the schema for queries (views)
                Dim schemaTable As DataTable = conn.GetSchema("Views")

                frm.LstQueries.Items.Clear()

                ' Loop through queries and add them to the list
                For Each row As DataRow In schemaTable.Rows
                    Dim queryName As String = row("TABLE_NAME").ToString()
                    frm.LstQueries.Items.Add(queryName)
                Next

                frm.LblQueries.Text = "Queries"

            Catch ex As Exception

                MessageBox.Show("Error: " & ex.Message)

            End Try
        End Using

    End Sub

    Public Sub DisplayQuerySQL(queryName As String)

        Try
            Dim dbEngine As New Dao.DBEngine()
            Dim db As Dao.Database = dbEngine.OpenDatabase(dbPath)
            Dim qd As Dao.QueryDef = db.QueryDefs(queryName)

            Dim frm As FrmQueries = TryCast(FrmDatabase.SplitDatabase.Panel2.Controls.OfType(Of FrmQueries)().FirstOrDefault(), FrmQueries)
            frm.TxtSQL.Text = qd.SQL ' Display SQL in the TextBox

            db.Close()
        Catch ex As Exception
            MessageBox.Show("Error retrieving SQL: " & ex.Message)
        End Try

    End Sub

    Public Sub LoadFormNames(DatabasePath As String)

        Try
            Dim dbEngine As New Dao.DBEngine()
            Dim db As Dao.Database = dbEngine.OpenDatabase(DatabasePath)

            Dim frm As FrmForms = TryCast(FrmDatabase.SplitDatabase.Panel2.Controls.OfType(Of FrmForms)().FirstOrDefault(), FrmForms)
            frm.LblForms.Text = "Forms - Loading..."
            Application.DoEvents()

            frm.LstForms.Items.Clear()

            ' Loop through the Documents collection under "Forms"
            For Each doc As Dao.Document In db.Containers("Forms").Documents
                frm.LstForms.Items.Add(doc.Name)
            Next
            frm.LblForms.Text = "Forms"

            db.Close()
        Catch ex As Exception
            MessageBox.Show("Error retrieving forms: " & ex.Message)
        End Try

    End Sub

    Public Sub LoadReportNames(DatabasePath As String)

        Try
            Dim dbEngine As New Dao.DBEngine()
            Dim db As Dao.Database = dbEngine.OpenDatabase(DatabasePath)

            Dim frm As FrmReports = TryCast(FrmDatabase.SplitDatabase.Panel2.Controls.OfType(Of FrmReports)().FirstOrDefault(), FrmReports)
            frm.LblReports.Text = "Reports - Loading..."
            Application.DoEvents()

            frm.LstReports.Items.Clear()

            ' Loop through the Documents collection under "Forms"
            For Each doc As Dao.Document In db.Containers("Reports").Documents
                frm.LstReports.Items.Add(doc.Name)
            Next
            frm.LblReports.Text = "Reports"

            db.Close()
        Catch ex As Exception
            MessageBox.Show("Error retrieving forms: " & ex.Message)
        End Try

    End Sub
End Module
