<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmReports
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmReports))
        Me.BtnMainMenu = New System.Windows.Forms.Button()
        Me.LstReports = New System.Windows.Forms.ListBox()
        Me.LblReports = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'BtnMainMenu
        '
        Me.BtnMainMenu.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnMainMenu.AutoSize = True
        Me.BtnMainMenu.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BtnMainMenu.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnMainMenu.Image = CType(resources.GetObject("BtnMainMenu.Image"), System.Drawing.Image)
        Me.BtnMainMenu.Location = New System.Drawing.Point(1063, 579)
        Me.BtnMainMenu.Name = "BtnMainMenu"
        Me.BtnMainMenu.Size = New System.Drawing.Size(70, 70)
        Me.BtnMainMenu.TabIndex = 8
        Me.BtnMainMenu.UseVisualStyleBackColor = True
        '
        'LstReports
        '
        Me.LstReports.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LstReports.BackColor = System.Drawing.SystemColors.Info
        Me.LstReports.ColumnWidth = 250
        Me.LstReports.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LstReports.FormattingEnabled = True
        Me.LstReports.ItemHeight = 20
        Me.LstReports.Location = New System.Drawing.Point(12, 36)
        Me.LstReports.MultiColumn = True
        Me.LstReports.Name = "LstReports"
        Me.LstReports.Size = New System.Drawing.Size(1121, 204)
        Me.LstReports.Sorted = True
        Me.LstReports.TabIndex = 18
        '
        'LblReports
        '
        Me.LblReports.AutoSize = True
        Me.LblReports.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblReports.ForeColor = System.Drawing.Color.White
        Me.LblReports.Location = New System.Drawing.Point(12, 9)
        Me.LblReports.Name = "LblReports"
        Me.LblReports.Size = New System.Drawing.Size(75, 24)
        Me.LblReports.TabIndex = 17
        Me.LblReports.Text = "Reports"
        '
        'FrmReports
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1145, 661)
        Me.Controls.Add(Me.LstReports)
        Me.Controls.Add(Me.LblReports)
        Me.Controls.Add(Me.BtnMainMenu)
        Me.Name = "FrmReports"
        Me.Text = "FrmReports"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnMainMenu As Button
    Friend WithEvents LstReports As ListBox
    Friend WithEvents LblReports As Label
End Class
