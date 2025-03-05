Imports System.Data.OleDb

Public Class FrmTables

    Private Sub BtnMainMenu_Click(sender As Object, e As EventArgs) Handles BtnMainMenu.Click

        ShowMainMenu()

    End Sub

    Private Sub FrmTables_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        LoadTableNames(dbPath)

    End Sub

    Private Sub LstTables_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LstTables.SelectedIndexChanged

        ds.Tables.Clear()
        LoadTableData(LstTables.SelectedItem.ToString)

    End Sub
End Class