Module ModShowForms

    Public Sub RecolorLabels(Optional LabelName As String = "")

        For Each lbl As Label In FrmDatabase.SplitDatabase.Panel1.Controls.OfType(Of Label)()
            If lbl.Name.Contains("Lbl") Then
                lbl.BackColor = FrmDatabase.BackColor
            End If
        Next

        If LabelName <> "" Then
            FrmDatabase.SplitDatabase.Panel1.Controls(LabelName).BackColor = Color.Maroon
        End If

    End Sub

    Public Sub ShowMainMenu()

        Dim frm As New FrmMainMenu With {
            .TopLevel = False,
            .FormBorderStyle = FormBorderStyle.None,
            .Dock = DockStyle.Fill
        }
        FrmDatabase.SplitDatabase.Panel2.Controls.Clear()
        FrmDatabase.SplitDatabase.Panel2.Controls.Add(frm)
        frm.Show()

        frm.TxtDatabasePath.Text = dbPath
        frm.TxtDatabaseName.Text = dbName

        RecolorLabels()

    End Sub

    Public Sub ShowSettings()

        Dim frm As New FrmSettings With {
            .TopLevel = False,
            .FormBorderStyle = FormBorderStyle.None,
            .Dock = DockStyle.Fill
        }
        FrmDatabase.SplitDatabase.Panel2.Controls.Clear()
        FrmDatabase.SplitDatabase.Panel2.Controls.Add(frm)
        frm.Show()

    End Sub

    Public Sub ShowTables()

        Dim frm As New FrmTables With {
            .TopLevel = False,
            .FormBorderStyle = FormBorderStyle.None,
            .Dock = DockStyle.Fill
        }
        FrmDatabase.SplitDatabase.Panel2.Controls.Clear()
        FrmDatabase.SplitDatabase.Panel2.Controls.Add(frm)
        frm.Show()

    End Sub

    Public Sub ShowQueries()

        Dim frm As New FrmQueries With {
            .TopLevel = False,
            .FormBorderStyle = FormBorderStyle.None,
            .Dock = DockStyle.Fill
        }
        FrmDatabase.SplitDatabase.Panel2.Controls.Clear()
        FrmDatabase.SplitDatabase.Panel2.Controls.Add(frm)
        frm.Show()

    End Sub

    Public Sub ShowForms()

        Dim frm As New FrmForms With {
            .TopLevel = False,
            .FormBorderStyle = FormBorderStyle.None,
            .Dock = DockStyle.Fill
        }
        FrmDatabase.SplitDatabase.Panel2.Controls.Clear()
        FrmDatabase.SplitDatabase.Panel2.Controls.Add(frm)
        frm.Show()

    End Sub

    Public Sub ShowReports()

        Dim frm As New FrmReports With {
            .TopLevel = False,
            .FormBorderStyle = FormBorderStyle.None,
            .Dock = DockStyle.Fill
        }
        FrmDatabase.SplitDatabase.Panel2.Controls.Clear()
        FrmDatabase.SplitDatabase.Panel2.Controls.Add(frm)
        frm.Show()

    End Sub
End Module
