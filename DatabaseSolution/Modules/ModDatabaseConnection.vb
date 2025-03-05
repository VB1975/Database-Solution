Imports System.Data.OleDb
Imports System.Text.RegularExpressions

Module ModDatabaseConnection

    Public dbProvider As String, dbSource As String
    Public conn As New OleDb.OleDbConnection
    Public ds As New DataSet
    Public da As OleDb.OleDbDataAdapter
    Public sql As String

    Public Sub OpenConnection()

        dbProvider = "PROVIDER=Microsoft.Ace.OLEDB.16.0;"
        dbSource = "Data Source="

    End Sub

    Public Sub LoadTableData(TableName As String)

        conn.ConnectionString = dbProvider & dbSource & dbPath
        conn.Open()
        sql = "SELECT * FROM " & TableName & ";"
        da = New OleDb.OleDbDataAdapter(sql, conn)
        da.Fill(ds, "TABLE")
        conn.Close()

        Dim frm As FrmTables = TryCast(FrmDatabase.SplitDatabase.Panel2.Controls.OfType(Of FrmTables)().FirstOrDefault(), FrmTables)
        If frm IsNot Nothing Then
            frm.DgvTable.DataSource = ds.Tables("TABLE")
            frm.LblTableName.Text = TableName
        End If

    End Sub

    Public Sub LoadQueryData(QueryName As String)

        Try
            conn.ConnectionString = dbProvider & dbSource & dbPath
            conn.Open()
            sql = "SELECT * FROM " & QueryName & ";"
            da = New OleDb.OleDbDataAdapter(sql, conn)
            da.Fill(ds, "QUERY")
            conn.Close()

            Dim frm As FrmQueries = TryCast(FrmDatabase.SplitDatabase.Panel2.Controls.OfType(Of FrmQueries)().FirstOrDefault(), FrmQueries)
            If frm IsNot Nothing Then
                frm.DgvQuery.DataSource = ds.Tables("QUERY")
                frm.LblQueryName.Text = QueryName
                frm.LblQueryName.Font = New Font("Microsoft Sans Serif", 14, FontStyle.Regular)
                frm.LblQueryName.BackColor = Color.FromArgb(64, 64, 64)
                frm.LblQueryName.ForeColor = Color.White
            End If

        Catch ex As Exception

            Dim frm As FrmQueries = TryCast(FrmDatabase.SplitDatabase.Panel2.Controls.OfType(Of FrmQueries)().FirstOrDefault(), FrmQueries)
            If frm IsNot Nothing Then
                frm.DgvQuery.DataSource = Nothing
                ds.Tables.Clear()
                frm.LblQueryName.Text = QueryName & " - " & ex.Message.ToString
                frm.LblQueryName.Font = New Font("Courier New", 14, FontStyle.Regular)
                frm.LblQueryName.BackColor = SystemColors.Info
                frm.LblQueryName.ForeColor = Color.DarkRed
                conn.Close()
            End If

        End Try


    End Sub
End Module
