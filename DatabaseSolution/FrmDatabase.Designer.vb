<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDatabase
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmDatabase))
        Me.SplitDatabase = New System.Windows.Forms.SplitContainer()
        Me.BtnExit = New System.Windows.Forms.Button()
        Me.BtnReports = New System.Windows.Forms.Button()
        Me.BtnForms = New System.Windows.Forms.Button()
        Me.BtnQueries = New System.Windows.Forms.Button()
        Me.BtnTables = New System.Windows.Forms.Button()
        Me.BtnHome = New System.Windows.Forms.Button()
        Me.LblTables = New System.Windows.Forms.Label()
        Me.LblQueries = New System.Windows.Forms.Label()
        Me.LblForms = New System.Windows.Forms.Label()
        Me.LblReports = New System.Windows.Forms.Label()
        CType(Me.SplitDatabase, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitDatabase.Panel1.SuspendLayout()
        Me.SplitDatabase.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitDatabase
        '
        Me.SplitDatabase.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.SplitDatabase.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitDatabase.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitDatabase.IsSplitterFixed = True
        Me.SplitDatabase.Location = New System.Drawing.Point(0, 0)
        Me.SplitDatabase.Name = "SplitDatabase"
        '
        'SplitDatabase.Panel1
        '
        Me.SplitDatabase.Panel1.Controls.Add(Me.BtnExit)
        Me.SplitDatabase.Panel1.Controls.Add(Me.BtnReports)
        Me.SplitDatabase.Panel1.Controls.Add(Me.BtnForms)
        Me.SplitDatabase.Panel1.Controls.Add(Me.BtnQueries)
        Me.SplitDatabase.Panel1.Controls.Add(Me.BtnTables)
        Me.SplitDatabase.Panel1.Controls.Add(Me.BtnHome)
        Me.SplitDatabase.Panel1.Controls.Add(Me.LblTables)
        Me.SplitDatabase.Panel1.Controls.Add(Me.LblQueries)
        Me.SplitDatabase.Panel1.Controls.Add(Me.LblForms)
        Me.SplitDatabase.Panel1.Controls.Add(Me.LblReports)
        Me.SplitDatabase.Panel1MinSize = 175
        Me.SplitDatabase.Size = New System.Drawing.Size(1306, 785)
        Me.SplitDatabase.SplitterDistance = 175
        Me.SplitDatabase.SplitterWidth = 1
        Me.SplitDatabase.TabIndex = 1
        '
        'BtnExit
        '
        Me.BtnExit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnExit.Image = CType(resources.GetObject("BtnExit.Image"), System.Drawing.Image)
        Me.BtnExit.Location = New System.Drawing.Point(88, 12)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(69, 69)
        Me.BtnExit.TabIndex = 5
        Me.BtnExit.UseVisualStyleBackColor = True
        '
        'BtnReports
        '
        Me.BtnReports.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnReports.Image = CType(resources.GetObject("BtnReports.Image"), System.Drawing.Image)
        Me.BtnReports.Location = New System.Drawing.Point(13, 592)
        Me.BtnReports.Name = "BtnReports"
        Me.BtnReports.Size = New System.Drawing.Size(144, 131)
        Me.BtnReports.TabIndex = 4
        Me.BtnReports.Text = "Reports"
        Me.BtnReports.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnReports.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.BtnReports.UseVisualStyleBackColor = True
        '
        'BtnForms
        '
        Me.BtnForms.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnForms.Image = CType(resources.GetObject("BtnForms.Image"), System.Drawing.Image)
        Me.BtnForms.Location = New System.Drawing.Point(13, 434)
        Me.BtnForms.Name = "BtnForms"
        Me.BtnForms.Size = New System.Drawing.Size(144, 131)
        Me.BtnForms.TabIndex = 3
        Me.BtnForms.Text = "Forms"
        Me.BtnForms.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnForms.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.BtnForms.UseVisualStyleBackColor = True
        '
        'BtnQueries
        '
        Me.BtnQueries.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnQueries.Image = CType(resources.GetObject("BtnQueries.Image"), System.Drawing.Image)
        Me.BtnQueries.Location = New System.Drawing.Point(13, 276)
        Me.BtnQueries.Name = "BtnQueries"
        Me.BtnQueries.Size = New System.Drawing.Size(144, 131)
        Me.BtnQueries.TabIndex = 2
        Me.BtnQueries.Text = "Queries"
        Me.BtnQueries.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnQueries.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.BtnQueries.UseVisualStyleBackColor = True
        '
        'BtnTables
        '
        Me.BtnTables.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnTables.Image = CType(resources.GetObject("BtnTables.Image"), System.Drawing.Image)
        Me.BtnTables.Location = New System.Drawing.Point(13, 118)
        Me.BtnTables.Name = "BtnTables"
        Me.BtnTables.Size = New System.Drawing.Size(144, 131)
        Me.BtnTables.TabIndex = 1
        Me.BtnTables.Text = "Tables"
        Me.BtnTables.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnTables.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.BtnTables.UseVisualStyleBackColor = True
        '
        'BtnHome
        '
        Me.BtnHome.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnHome.Image = CType(resources.GetObject("BtnHome.Image"), System.Drawing.Image)
        Me.BtnHome.Location = New System.Drawing.Point(13, 12)
        Me.BtnHome.Name = "BtnHome"
        Me.BtnHome.Size = New System.Drawing.Size(69, 69)
        Me.BtnHome.TabIndex = 0
        Me.BtnHome.UseVisualStyleBackColor = True
        '
        'LblTables
        '
        Me.LblTables.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LblTables.Location = New System.Drawing.Point(-24, 107)
        Me.LblTables.Name = "LblTables"
        Me.LblTables.Size = New System.Drawing.Size(214, 154)
        Me.LblTables.TabIndex = 6
        '
        'LblQueries
        '
        Me.LblQueries.Location = New System.Drawing.Point(-24, 264)
        Me.LblQueries.Name = "LblQueries"
        Me.LblQueries.Size = New System.Drawing.Size(214, 154)
        Me.LblQueries.TabIndex = 7
        '
        'LblForms
        '
        Me.LblForms.Location = New System.Drawing.Point(-24, 423)
        Me.LblForms.Name = "LblForms"
        Me.LblForms.Size = New System.Drawing.Size(214, 154)
        Me.LblForms.TabIndex = 8
        '
        'LblReports
        '
        Me.LblReports.Location = New System.Drawing.Point(-24, 579)
        Me.LblReports.Name = "LblReports"
        Me.LblReports.Size = New System.Drawing.Size(214, 154)
        Me.LblReports.TabIndex = 9
        '
        'FrmDatabase
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1306, 785)
        Me.Controls.Add(Me.SplitDatabase)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "FrmDatabase"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Database"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.SplitDatabase.Panel1.ResumeLayout(False)
        CType(Me.SplitDatabase, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitDatabase.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SplitDatabase As SplitContainer
    Friend WithEvents BtnExit As Button
    Friend WithEvents BtnReports As Button
    Friend WithEvents BtnForms As Button
    Friend WithEvents BtnQueries As Button
    Friend WithEvents BtnTables As Button
    Friend WithEvents BtnHome As Button
    Friend WithEvents LblTables As Label
    Friend WithEvents LblQueries As Label
    Friend WithEvents LblForms As Label
    Friend WithEvents LblReports As Label
End Class
