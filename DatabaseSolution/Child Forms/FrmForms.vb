Imports System.ComponentModel
Imports System.Runtime.InteropServices
Imports Microsoft.Office.Interop.Access

Public Class FrmForms

    Private accessApp As Object

    Private Sub BtnMainMenu_Click(sender As Object, e As EventArgs) Handles BtnMainMenu.Click

        ShowMainMenu()

    End Sub

    Private Sub FrmForms_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        LoadFormNames(dbPath)
        EnableButtons()

    End Sub

    Private Sub EnableButtons()

        If LstForms.SelectedIndex > 0 Then
            BtnOpenFormInAccess.Enabled = True
        Else
            BtnOpenFormInAccess.Enabled = False
        End If

    End Sub

    Private Sub BtnOpenFormInAccess_Click(sender As Object, e As EventArgs) Handles BtnOpenFormInAccess.Click

        Dim currentDbPath As String = ""
        Dim dbAlreadyOpen As Boolean = False

        Try
            ' Try to get an existing instance of Access
            accessApp = Marshal.GetActiveObject("Access.Application")

            ' Ensure a database is open
            If accessApp IsNot Nothing AndAlso accessApp.Forms.Count > 0 Then
                Try
                    currentDbPath = accessApp.CurrentDb().Name.ToLower()
                Catch ex As Exception
                    currentDbPath = ""
                End Try
            End If

            ' If the correct database is already open, just maximize and show it
            If currentDbPath = dbPath.ToLower() Then
                dbAlreadyOpen = True
                accessApp.DoCmd.RunCommand(AcCommand.acCmdAppMaximize)
                accessApp.Visible = True
            Else
                ' If a different database is open, prevent reopening it in another instance
                If currentDbPath <> "" Then accessApp.CloseCurrentDatabase()

                ' Open the correct database
                accessApp.OpenCurrentDatabase(dbPath)
            End If

        Catch ex As COMException
            ' No Access instance found, create a new one
            accessApp = New Application()
            accessApp.OpenCurrentDatabase(dbPath)
        End Try

        ' Ensure Access is visible and maximized
        accessApp.Visible = True
        accessApp.DoCmd.RunCommand(AcCommand.acCmdAppMaximize)

        ' Open the form if it exists
        Try
            accessApp.DoCmd.OpenForm(LstForms.SelectedItem.ToString())
        Catch ex As Exception
            MessageBox.Show("The selected form does not exist in this database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

            ' If a new instance was created due to a different database, close it
            If Not dbAlreadyOpen Then
                accessApp.Quit(AcQuitOption.acQuitSaveAll)
                accessApp = Nothing
            End If
        End Try
    End Sub

    Private Sub FrmForms_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing

        ' Close Access when the VB.NET form is closed
        If accessApp IsNot Nothing Then
            accessApp.Quit()
            System.Runtime.InteropServices.Marshal.ReleaseComObject(accessApp)
        End If

    End Sub

    Private Sub LstForms_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LstForms.SelectedIndexChanged

        EnableButtons()

    End Sub
End Class