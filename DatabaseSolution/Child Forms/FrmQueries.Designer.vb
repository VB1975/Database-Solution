<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmQueries
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmQueries))
        Me.BtnMainMenu = New System.Windows.Forms.Button()
        Me.LblQueryName = New System.Windows.Forms.Label()
        Me.DgvQuery = New System.Windows.Forms.DataGridView()
        Me.LstQueries = New System.Windows.Forms.ListBox()
        Me.LblQueries = New System.Windows.Forms.Label()
        Me.TxtSQL = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.DgvQuery, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'LblQueryName
        '
        Me.LblQueryName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblQueryName.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblQueryName.ForeColor = System.Drawing.Color.White
        Me.LblQueryName.Location = New System.Drawing.Point(12, 334)
        Me.LblQueryName.Name = "LblQueryName"
        Me.LblQueryName.Size = New System.Drawing.Size(1121, 49)
        Me.LblQueryName.TabIndex = 14
        Me.LblQueryName.Text = "Query Data"
        Me.LblQueryName.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'DgvQuery
        '
        Me.DgvQuery.AllowUserToAddRows = False
        Me.DgvQuery.AllowUserToDeleteRows = False
        Me.DgvQuery.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DgvQuery.BackgroundColor = System.Drawing.SystemColors.InactiveCaption
        Me.DgvQuery.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvQuery.Location = New System.Drawing.Point(12, 386)
        Me.DgvQuery.Name = "DgvQuery"
        Me.DgvQuery.ReadOnly = True
        Me.DgvQuery.Size = New System.Drawing.Size(1121, 187)
        Me.DgvQuery.TabIndex = 13
        '
        'LstQueries
        '
        Me.LstQueries.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LstQueries.BackColor = System.Drawing.SystemColors.Info
        Me.LstQueries.ColumnWidth = 300
        Me.LstQueries.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LstQueries.FormattingEnabled = True
        Me.LstQueries.ItemHeight = 20
        Me.LstQueries.Location = New System.Drawing.Point(12, 36)
        Me.LstQueries.MultiColumn = True
        Me.LstQueries.Name = "LstQueries"
        Me.LstQueries.Size = New System.Drawing.Size(1121, 164)
        Me.LstQueries.Sorted = True
        Me.LstQueries.TabIndex = 16
        '
        'LblQueries
        '
        Me.LblQueries.AutoSize = True
        Me.LblQueries.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblQueries.ForeColor = System.Drawing.Color.White
        Me.LblQueries.Location = New System.Drawing.Point(12, 9)
        Me.LblQueries.Name = "LblQueries"
        Me.LblQueries.Size = New System.Drawing.Size(77, 24)
        Me.LblQueries.TabIndex = 15
        Me.LblQueries.Text = "Queries"
        '
        'TxtSQL
        '
        Me.TxtSQL.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtSQL.Location = New System.Drawing.Point(12, 240)
        Me.TxtSQL.Multiline = True
        Me.TxtSQL.Name = "TxtSQL"
        Me.TxtSQL.ReadOnly = True
        Me.TxtSQL.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TxtSQL.Size = New System.Drawing.Size(1121, 91)
        Me.TxtSQL.TabIndex = 17
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(12, 213)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 24)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "SQL"
        '
        'FrmQueries
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1145, 661)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtSQL)
        Me.Controls.Add(Me.LstQueries)
        Me.Controls.Add(Me.LblQueries)
        Me.Controls.Add(Me.LblQueryName)
        Me.Controls.Add(Me.DgvQuery)
        Me.Controls.Add(Me.BtnMainMenu)
        Me.Name = "FrmQueries"
        Me.Text = "FrmQueries"
        CType(Me.DgvQuery, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnMainMenu As Button
    Friend WithEvents LblQueryName As Label
    Friend WithEvents DgvQuery As DataGridView
    Friend WithEvents LstQueries As ListBox
    Friend WithEvents LblQueries As Label
    Friend WithEvents TxtSQL As TextBox
    Friend WithEvents Label2 As Label
End Class
