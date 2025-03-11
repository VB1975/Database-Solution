<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmMainMenu
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMainMenu))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtDatabasePath = New System.Windows.Forms.TextBox()
        Me.TxtDatabaseName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnBrowse = New System.Windows.Forms.Button()
        Me.BtnOpenDatabase = New System.Windows.Forms.Button()
        Me.BtnCloseDatabase = New System.Windows.Forms.Button()
        Me.BtnOpenInAccess = New System.Windows.Forms.Button()
        Me.BtnSettings = New System.Windows.Forms.Button()
        Me.LblSystemMessage = New System.Windows.Forms.Label()
        Me.LvwRecentDatabases = New System.Windows.Forms.ListView()
        Me.ColDatabaseID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColDatabaseName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColDatabasePath = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColLastOpened = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label3 = New System.Windows.Forms.Label()
        Me.MnuRecentDatabases = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.MnuItemSelectDatabase = New System.Windows.Forms.ToolStripMenuItem()
        Me.MnuItemOpenDatabase = New System.Windows.Forms.ToolStripMenuItem()
        Me.MnuItemOpenInAccess = New System.Windows.Forms.ToolStripMenuItem()
        Me.MnuItemRemoveFromList = New System.Windows.Forms.ToolStripMenuItem()
        Me.MnuRecentDatabases.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(12, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(134, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Database Path:"
        '
        'TxtDatabasePath
        '
        Me.TxtDatabasePath.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtDatabasePath.Location = New System.Drawing.Point(161, 12)
        Me.TxtDatabasePath.Multiline = True
        Me.TxtDatabasePath.Name = "TxtDatabasePath"
        Me.TxtDatabasePath.ReadOnly = True
        Me.TxtDatabasePath.Size = New System.Drawing.Size(1119, 30)
        Me.TxtDatabasePath.TabIndex = 4
        '
        'TxtDatabaseName
        '
        Me.TxtDatabaseName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtDatabaseName.Location = New System.Drawing.Point(161, 54)
        Me.TxtDatabaseName.Multiline = True
        Me.TxtDatabaseName.Name = "TxtDatabaseName"
        Me.TxtDatabaseName.ReadOnly = True
        Me.TxtDatabaseName.Size = New System.Drawing.Size(1119, 30)
        Me.TxtDatabaseName.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(12, 58)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(143, 20)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Database Name:"
        '
        'BtnBrowse
        '
        Me.BtnBrowse.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnBrowse.BackColor = System.Drawing.SystemColors.Control
        Me.BtnBrowse.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnBrowse.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnBrowse.Font = New System.Drawing.Font("Bell MT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBrowse.Image = CType(resources.GetObject("BtnBrowse.Image"), System.Drawing.Image)
        Me.BtnBrowse.Location = New System.Drawing.Point(1286, 12)
        Me.BtnBrowse.Name = "BtnBrowse"
        Me.BtnBrowse.Size = New System.Drawing.Size(41, 30)
        Me.BtnBrowse.TabIndex = 7
        Me.BtnBrowse.UseVisualStyleBackColor = False
        '
        'BtnOpenDatabase
        '
        Me.BtnOpenDatabase.BackColor = System.Drawing.SystemColors.Control
        Me.BtnOpenDatabase.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnOpenDatabase.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnOpenDatabase.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnOpenDatabase.Font = New System.Drawing.Font("Modern No. 20", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnOpenDatabase.Location = New System.Drawing.Point(161, 110)
        Me.BtnOpenDatabase.Name = "BtnOpenDatabase"
        Me.BtnOpenDatabase.Size = New System.Drawing.Size(580, 54)
        Me.BtnOpenDatabase.TabIndex = 8
        Me.BtnOpenDatabase.Text = "Open Database"
        Me.BtnOpenDatabase.UseVisualStyleBackColor = False
        '
        'BtnCloseDatabase
        '
        Me.BtnCloseDatabase.BackColor = System.Drawing.SystemColors.Control
        Me.BtnCloseDatabase.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnCloseDatabase.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnCloseDatabase.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCloseDatabase.Font = New System.Drawing.Font("Modern No. 20", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCloseDatabase.Location = New System.Drawing.Point(161, 185)
        Me.BtnCloseDatabase.Name = "BtnCloseDatabase"
        Me.BtnCloseDatabase.Size = New System.Drawing.Size(580, 54)
        Me.BtnCloseDatabase.TabIndex = 9
        Me.BtnCloseDatabase.Text = "Close Database"
        Me.BtnCloseDatabase.UseVisualStyleBackColor = False
        '
        'BtnOpenInAccess
        '
        Me.BtnOpenInAccess.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnOpenInAccess.BackColor = System.Drawing.SystemColors.Control
        Me.BtnOpenInAccess.FlatAppearance.BorderSize = 0
        Me.BtnOpenInAccess.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnOpenInAccess.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnOpenInAccess.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnOpenInAccess.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnOpenInAccess.ForeColor = System.Drawing.Color.Maroon
        Me.BtnOpenInAccess.Image = CType(resources.GetObject("BtnOpenInAccess.Image"), System.Drawing.Image)
        Me.BtnOpenInAccess.Location = New System.Drawing.Point(1286, 55)
        Me.BtnOpenInAccess.Name = "BtnOpenInAccess"
        Me.BtnOpenInAccess.Size = New System.Drawing.Size(41, 29)
        Me.BtnOpenInAccess.TabIndex = 10
        Me.BtnOpenInAccess.UseVisualStyleBackColor = False
        '
        'BtnSettings
        '
        Me.BtnSettings.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnSettings.AutoSize = True
        Me.BtnSettings.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BtnSettings.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSettings.Image = CType(resources.GetObject("BtnSettings.Image"), System.Drawing.Image)
        Me.BtnSettings.Location = New System.Drawing.Point(1257, 696)
        Me.BtnSettings.Name = "BtnSettings"
        Me.BtnSettings.Size = New System.Drawing.Size(70, 70)
        Me.BtnSettings.TabIndex = 11
        Me.BtnSettings.UseVisualStyleBackColor = True
        '
        'LblSystemMessage
        '
        Me.LblSystemMessage.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblSystemMessage.BackColor = System.Drawing.Color.White
        Me.LblSystemMessage.Font = New System.Drawing.Font("Courier New", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSystemMessage.ForeColor = System.Drawing.Color.DarkRed
        Me.LblSystemMessage.Location = New System.Drawing.Point(761, 110)
        Me.LblSystemMessage.Name = "LblSystemMessage"
        Me.LblSystemMessage.Size = New System.Drawing.Size(566, 129)
        Me.LblSystemMessage.TabIndex = 12
        Me.LblSystemMessage.Text = "You must open the database first."
        Me.LblSystemMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.LblSystemMessage.Visible = False
        '
        'LvwRecentDatabases
        '
        Me.LvwRecentDatabases.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LvwRecentDatabases.BackColor = System.Drawing.Color.Gray
        Me.LvwRecentDatabases.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColDatabaseID, Me.ColDatabaseName, Me.ColDatabasePath, Me.ColLastOpened})
        Me.LvwRecentDatabases.ContextMenuStrip = Me.MnuRecentDatabases
        Me.LvwRecentDatabases.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LvwRecentDatabases.ForeColor = System.Drawing.Color.White
        Me.LvwRecentDatabases.FullRowSelect = True
        Me.LvwRecentDatabases.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.LvwRecentDatabases.HideSelection = False
        Me.LvwRecentDatabases.Location = New System.Drawing.Point(161, 287)
        Me.LvwRecentDatabases.MultiSelect = False
        Me.LvwRecentDatabases.Name = "LvwRecentDatabases"
        Me.LvwRecentDatabases.Size = New System.Drawing.Size(1166, 403)
        Me.LvwRecentDatabases.TabIndex = 13
        Me.LvwRecentDatabases.UseCompatibleStateImageBehavior = False
        Me.LvwRecentDatabases.View = System.Windows.Forms.View.Details
        '
        'ColDatabaseID
        '
        Me.ColDatabaseID.Text = "ID"
        Me.ColDatabaseID.Width = 0
        '
        'ColDatabaseName
        '
        Me.ColDatabaseName.Text = "Database Name"
        Me.ColDatabaseName.Width = 500
        '
        'ColDatabasePath
        '
        Me.ColDatabasePath.Text = "Database Path"
        Me.ColDatabasePath.Width = 800
        '
        'ColLastOpened
        '
        Me.ColLastOpened.Text = "Last Opened"
        Me.ColLastOpened.Width = 200
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(157, 264)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(159, 20)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Recent Databases"
        '
        'MnuRecentDatabases
        '
        Me.MnuRecentDatabases.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MnuItemSelectDatabase, Me.MnuItemOpenDatabase, Me.MnuItemOpenInAccess, Me.MnuItemRemoveFromList})
        Me.MnuRecentDatabases.Name = "MnuRecentDatabases"
        Me.MnuRecentDatabases.Size = New System.Drawing.Size(181, 114)
        '
        'MnuItemSelectDatabase
        '
        Me.MnuItemSelectDatabase.Name = "MnuItemSelectDatabase"
        Me.MnuItemSelectDatabase.Size = New System.Drawing.Size(169, 22)
        Me.MnuItemSelectDatabase.Text = "Select Database"
        '
        'MnuItemOpenDatabase
        '
        Me.MnuItemOpenDatabase.Name = "MnuItemOpenDatabase"
        Me.MnuItemOpenDatabase.Size = New System.Drawing.Size(180, 22)
        Me.MnuItemOpenDatabase.Text = "Open Database"
        '
        'MnuItemOpenInAccess
        '
        Me.MnuItemOpenInAccess.Name = "MnuItemOpenInAccess"
        Me.MnuItemOpenInAccess.Size = New System.Drawing.Size(180, 22)
        Me.MnuItemOpenInAccess.Text = "Open In Access"
        '
        'MnuItemRemoveFromList
        '
        Me.MnuItemRemoveFromList.Name = "MnuItemRemoveFromList"
        Me.MnuItemRemoveFromList.Size = New System.Drawing.Size(180, 22)
        Me.MnuItemRemoveFromList.Text = "Remove From List"
        '
        'FrmMainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1339, 778)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.LvwRecentDatabases)
        Me.Controls.Add(Me.LblSystemMessage)
        Me.Controls.Add(Me.BtnSettings)
        Me.Controls.Add(Me.BtnOpenInAccess)
        Me.Controls.Add(Me.BtnCloseDatabase)
        Me.Controls.Add(Me.BtnOpenDatabase)
        Me.Controls.Add(Me.BtnBrowse)
        Me.Controls.Add(Me.TxtDatabaseName)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtDatabasePath)
        Me.Controls.Add(Me.Label2)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "FrmMainMenu"
        Me.Text = "Main Menu"
        Me.MnuRecentDatabases.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents TxtDatabasePath As TextBox
    Friend WithEvents TxtDatabaseName As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnBrowse As Button
    Friend WithEvents BtnOpenDatabase As Button
    Friend WithEvents BtnCloseDatabase As Button
    Friend WithEvents BtnOpenInAccess As Button
    Friend WithEvents BtnSettings As Button
    Friend WithEvents LblSystemMessage As Label
    Friend WithEvents LvwRecentDatabases As ListView
    Friend WithEvents ColDatabaseName As ColumnHeader
    Friend WithEvents ColDatabasePath As ColumnHeader
    Friend WithEvents ColLastOpened As ColumnHeader
    Friend WithEvents Label3 As Label
    Friend WithEvents ColDatabaseID As ColumnHeader
    Friend WithEvents MnuRecentDatabases As ContextMenuStrip
    Friend WithEvents MnuItemSelectDatabase As ToolStripMenuItem
    Friend WithEvents MnuItemOpenDatabase As ToolStripMenuItem
    Friend WithEvents MnuItemOpenInAccess As ToolStripMenuItem
    Friend WithEvents MnuItemRemoveFromList As ToolStripMenuItem
End Class
