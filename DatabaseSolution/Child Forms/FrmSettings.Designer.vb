<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmSettings
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmSettings))
        Me.BtnMainMenu = New System.Windows.Forms.Button()
        Me.BtnSelectFolder = New System.Windows.Forms.Button()
        Me.TxtDefaultFolder = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.foldDefault = New WK.Libraries.BetterFolderBrowserNS.BetterFolderBrowser(Me.components)
        Me.SuspendLayout()
        '
        'BtnMainMenu
        '
        Me.BtnMainMenu.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnMainMenu.AutoSize = True
        Me.BtnMainMenu.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BtnMainMenu.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnMainMenu.Image = CType(resources.GetObject("BtnMainMenu.Image"), System.Drawing.Image)
        Me.BtnMainMenu.Location = New System.Drawing.Point(717, 366)
        Me.BtnMainMenu.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnMainMenu.Name = "BtnMainMenu"
        Me.BtnMainMenu.Size = New System.Drawing.Size(70, 70)
        Me.BtnMainMenu.TabIndex = 10
        Me.BtnMainMenu.UseVisualStyleBackColor = True
        '
        'BtnSelectFolder
        '
        Me.BtnSelectFolder.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnSelectFolder.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BtnSelectFolder.BackColor = System.Drawing.SystemColors.Control
        Me.BtnSelectFolder.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnSelectFolder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnSelectFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSelectFolder.Font = New System.Drawing.Font("Bell MT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSelectFolder.Location = New System.Drawing.Point(746, 19)
        Me.BtnSelectFolder.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnSelectFolder.Name = "BtnSelectFolder"
        Me.BtnSelectFolder.Size = New System.Drawing.Size(41, 26)
        Me.BtnSelectFolder.TabIndex = 13
        Me.BtnSelectFolder.Text = "..."
        Me.BtnSelectFolder.UseVisualStyleBackColor = False
        '
        'TxtDefaultFolder
        '
        Me.TxtDefaultFolder.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtDefaultFolder.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDefaultFolder.Location = New System.Drawing.Point(155, 18)
        Me.TxtDefaultFolder.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TxtDefaultFolder.Name = "TxtDefaultFolder"
        Me.TxtDefaultFolder.ReadOnly = True
        Me.TxtDefaultFolder.Size = New System.Drawing.Size(583, 26)
        Me.TxtDefaultFolder.TabIndex = 12
        Me.TxtDefaultFolder.WordWrap = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(18, 21)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(129, 20)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Default Folder:"
        '
        'foldDefault
        '
        Me.foldDefault.Multiselect = False
        Me.foldDefault.RootFolder = "C:\Users\fivex\Desktop"
        Me.foldDefault.Title = "Please select a folder..."
        '
        'FrmSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.BtnSelectFolder)
        Me.Controls.Add(Me.TxtDefaultFolder)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BtnMainMenu)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "FrmSettings"
        Me.Text = "FrmSettings"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnMainMenu As Button
    Friend WithEvents BtnSelectFolder As Button
    Friend WithEvents TxtDefaultFolder As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents foldDefault As WK.Libraries.BetterFolderBrowserNS.BetterFolderBrowser
End Class
