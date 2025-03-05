<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmTables
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmTables))
        Me.BtnMainMenu = New System.Windows.Forms.Button()
        Me.DgvTable = New System.Windows.Forms.DataGridView()
        Me.LblTableName = New System.Windows.Forms.Label()
        Me.LblTables = New System.Windows.Forms.Label()
        Me.LstTables = New System.Windows.Forms.ListBox()
        CType(Me.DgvTable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnMainMenu
        '
        Me.BtnMainMenu.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnMainMenu.AutoSize = True
        Me.BtnMainMenu.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BtnMainMenu.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnMainMenu.Image = CType(resources.GetObject("BtnMainMenu.Image"), System.Drawing.Image)
        Me.BtnMainMenu.Location = New System.Drawing.Point(1063, 581)
        Me.BtnMainMenu.Name = "BtnMainMenu"
        Me.BtnMainMenu.Size = New System.Drawing.Size(70, 70)
        Me.BtnMainMenu.TabIndex = 10
        Me.BtnMainMenu.UseVisualStyleBackColor = True
        '
        'DgvTable
        '
        Me.DgvTable.AllowUserToAddRows = False
        Me.DgvTable.AllowUserToDeleteRows = False
        Me.DgvTable.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DgvTable.BackgroundColor = System.Drawing.SystemColors.InactiveCaption
        Me.DgvTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvTable.Location = New System.Drawing.Point(12, 289)
        Me.DgvTable.Name = "DgvTable"
        Me.DgvTable.ReadOnly = True
        Me.DgvTable.Size = New System.Drawing.Size(1121, 286)
        Me.DgvTable.TabIndex = 11
        '
        'LblTableName
        '
        Me.LblTableName.AutoSize = True
        Me.LblTableName.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTableName.ForeColor = System.Drawing.Color.White
        Me.LblTableName.Location = New System.Drawing.Point(12, 262)
        Me.LblTableName.Name = "LblTableName"
        Me.LblTableName.Size = New System.Drawing.Size(100, 24)
        Me.LblTableName.TabIndex = 12
        Me.LblTableName.Text = "Table Data"
        '
        'LblTables
        '
        Me.LblTables.AutoSize = True
        Me.LblTables.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTables.ForeColor = System.Drawing.Color.White
        Me.LblTables.Location = New System.Drawing.Point(12, 9)
        Me.LblTables.Name = "LblTables"
        Me.LblTables.Size = New System.Drawing.Size(67, 24)
        Me.LblTables.TabIndex = 13
        Me.LblTables.Text = "Tables"
        '
        'LstTables
        '
        Me.LstTables.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LstTables.BackColor = System.Drawing.SystemColors.Info
        Me.LstTables.ColumnWidth = 250
        Me.LstTables.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LstTables.FormattingEnabled = True
        Me.LstTables.ItemHeight = 20
        Me.LstTables.Location = New System.Drawing.Point(12, 36)
        Me.LstTables.MultiColumn = True
        Me.LstTables.Name = "LstTables"
        Me.LstTables.Size = New System.Drawing.Size(1121, 204)
        Me.LstTables.Sorted = True
        Me.LstTables.TabIndex = 14
        '
        'FrmTables
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1145, 661)
        Me.Controls.Add(Me.LstTables)
        Me.Controls.Add(Me.LblTables)
        Me.Controls.Add(Me.LblTableName)
        Me.Controls.Add(Me.DgvTable)
        Me.Controls.Add(Me.BtnMainMenu)
        Me.Name = "FrmTables"
        Me.Text = "FrmTables"
        CType(Me.DgvTable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnMainMenu As Button
    Friend WithEvents DgvTable As DataGridView
    Friend WithEvents LblTableName As Label
    Friend WithEvents LblTables As Label
    Friend WithEvents LstTables As ListBox
End Class
