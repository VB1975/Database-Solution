Imports System.Data.OleDb

Public Class FrmQueries

    Private Sub BtnMainMenu_Click(sender As Object, e As EventArgs) Handles BtnMainMenu.Click

        ShowMainMenu()

    End Sub

    Private Sub FrmQueries_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        LoadQueryNames(dbPath)

    End Sub

    Private Sub LstQueries_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LstQueries.SelectedIndexChanged

        ds.Tables.Clear()
        LoadQueryData(LstQueries.SelectedItem)
        DisplayQuerySQL(LstQueries.SelectedItem)

    End Sub
End Class