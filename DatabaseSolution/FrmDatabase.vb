Imports System.Diagnostics

Public Class FrmDatabase

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click

        Application.Exit()

    End Sub

    Private Sub BtnHome_Click(sender As Object, e As EventArgs) Handles BtnHome.Click

        Dim URL As String = "https://www.599cd.com"
        Process.Start(New ProcessStartInfo(URL) With {.UseShellExecute = True})

    End Sub

    Private Sub ConnectionClosedMsg()

        MessageBox.Show("You must open the database first.", "Database Not Open", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

    End Sub

    Private Sub BtnTables_Click(sender As Object, e As EventArgs) Handles BtnTables.Click

        If Not isConnectionOpen Then
            Dim frm As FrmMainMenu = TryCast(SplitDatabase.Panel2.Controls.OfType(Of FrmMainMenu)().FirstOrDefault(), FrmMainMenu)
            frm.LblSystemMessage.Visible = True
        Else
            RecolorLabels("LblTables")
            ShowTables()
        End If

    End Sub

    Private Sub BtnQueries_Click(sender As Object, e As EventArgs) Handles BtnQueries.Click

        If Not isConnectionOpen Then
            Dim frm As FrmMainMenu = TryCast(SplitDatabase.Panel2.Controls.OfType(Of FrmMainMenu)().FirstOrDefault(), FrmMainMenu)
            frm.LblSystemMessage.Visible = True
        Else
            RecolorLabels("LblQueries")
            ShowQueries()
        End If

    End Sub

    Private Sub BtnForms_Click(sender As Object, e As EventArgs) Handles BtnForms.Click

        If Not isConnectionOpen Then
            Dim frm As FrmMainMenu = TryCast(SplitDatabase.Panel2.Controls.OfType(Of FrmMainMenu)().FirstOrDefault(), FrmMainMenu)
            frm.LblSystemMessage.Visible = True
        Else
            RecolorLabels("LblForms")
            ShowForms()
        End If

    End Sub

    Private Sub BtnReports_Click(sender As Object, e As EventArgs) Handles BtnReports.Click

        If Not isConnectionOpen Then
            Dim frm As FrmMainMenu = TryCast(SplitDatabase.Panel2.Controls.OfType(Of FrmMainMenu)().FirstOrDefault(), FrmMainMenu)
            frm.LblSystemMessage.Visible = True
        Else
            RecolorLabels("LblReports")
            ShowReports()
        End If

    End Sub

    Private Sub FrmDatabase_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        LoadSettingsFromRegistry()
        ShowMainMenu()

    End Sub
End Class