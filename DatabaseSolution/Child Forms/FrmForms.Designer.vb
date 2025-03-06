<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmForms
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmForms))
        Me.BtnMainMenu = New System.Windows.Forms.Button()
        Me.LstForms = New System.Windows.Forms.ListBox()
        Me.LblForms = New System.Windows.Forms.Label()
        Me.BtnOpenFormInAccess = New System.Windows.Forms.Button()
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
        'LstForms
        '
        Me.LstForms.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LstForms.BackColor = System.Drawing.SystemColors.Info
        Me.LstForms.ColumnWidth = 250
        Me.LstForms.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LstForms.FormattingEnabled = True
        Me.LstForms.ItemHeight = 20
        Me.LstForms.Location = New System.Drawing.Point(12, 36)
        Me.LstForms.MultiColumn = True
        Me.LstForms.Name = "LstForms"
        Me.LstForms.Size = New System.Drawing.Size(1121, 204)
        Me.LstForms.Sorted = True
        Me.LstForms.TabIndex = 16
        '
        'LblForms
        '
        Me.LblForms.AutoSize = True
        Me.LblForms.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblForms.ForeColor = System.Drawing.Color.White
        Me.LblForms.Location = New System.Drawing.Point(12, 9)
        Me.LblForms.Name = "LblForms"
        Me.LblForms.Size = New System.Drawing.Size(64, 24)
        Me.LblForms.TabIndex = 15
        Me.LblForms.Text = "Forms"
        '
        'BtnOpenFormInAccess
        '
        Me.BtnOpenFormInAccess.BackColor = System.Drawing.SystemColors.Control
        Me.BtnOpenFormInAccess.FlatAppearance.BorderSize = 0
        Me.BtnOpenFormInAccess.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnOpenFormInAccess.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnOpenFormInAccess.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnOpenFormInAccess.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnOpenFormInAccess.Location = New System.Drawing.Point(12, 605)
        Me.BtnOpenFormInAccess.Name = "BtnOpenFormInAccess"
        Me.BtnOpenFormInAccess.Size = New System.Drawing.Size(203, 44)
        Me.BtnOpenFormInAccess.TabIndex = 17
        Me.BtnOpenFormInAccess.Text = "Open Form In Access"
        Me.BtnOpenFormInAccess.UseVisualStyleBackColor = False
        '
        'FrmForms
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1145, 661)
        Me.Controls.Add(Me.BtnOpenFormInAccess)
        Me.Controls.Add(Me.LstForms)
        Me.Controls.Add(Me.LblForms)
        Me.Controls.Add(Me.BtnMainMenu)
        Me.Name = "FrmForms"
        Me.Text = "FrmForms"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnMainMenu As Button
    Friend WithEvents LstForms As ListBox
    Friend WithEvents LblForms As Label
    Friend WithEvents BtnOpenFormInAccess As Button
End Class
