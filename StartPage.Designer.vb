<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class StartPage
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(StartPage))
        Me.kitting = New System.Windows.Forms.Button()
        Me.DmRequest = New System.Windows.Forms.Button()
        Me.AuRequest = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MENUToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UserManualToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddUserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UpdateLogToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.SwitchAccessToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UpdateLogToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.CheckForUpdateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.switch = New System.Windows.Forms.PictureBox()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.version = New System.Windows.Forms.Label()
        Me.appName = New System.Windows.Forms.Label()
        Me.SoftwareUpdate = New System.Windows.Forms.Timer(Me.components)
        Me.MenuStrip1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.switch, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'kitting
        '
        Me.kitting.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.kitting.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.kitting.Image = Global.B800_Material_Request_System.My.Resources.Resources.Folder
        Me.kitting.Location = New System.Drawing.Point(48, 40)
        Me.kitting.Margin = New System.Windows.Forms.Padding(2)
        Me.kitting.Name = "kitting"
        Me.kitting.Size = New System.Drawing.Size(142, 74)
        Me.kitting.TabIndex = 5
        Me.kitting.Text = "KITTING"
        Me.kitting.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.kitting.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.kitting.UseVisualStyleBackColor = True
        '
        'DmRequest
        '
        Me.DmRequest.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DmRequest.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DmRequest.Image = Global.B800_Material_Request_System.My.Resources.Resources.CEDefault
        Me.DmRequest.Location = New System.Drawing.Point(194, 40)
        Me.DmRequest.Margin = New System.Windows.Forms.Padding(2)
        Me.DmRequest.Name = "DmRequest"
        Me.DmRequest.Size = New System.Drawing.Size(142, 74)
        Me.DmRequest.TabIndex = 6
        Me.DmRequest.Text = "MATERIAL REQUEST"
        Me.DmRequest.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.DmRequest.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.DmRequest.UseVisualStyleBackColor = True
        '
        'AuRequest
        '
        Me.AuRequest.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AuRequest.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AuRequest.Image = Global.B800_Material_Request_System.My.Resources.Resources.Webalys_Kameleon_pics_Gold_Cart
        Me.AuRequest.Location = New System.Drawing.Point(340, 40)
        Me.AuRequest.Margin = New System.Windows.Forms.Padding(2)
        Me.AuRequest.Name = "AuRequest"
        Me.AuRequest.Size = New System.Drawing.Size(142, 74)
        Me.AuRequest.TabIndex = 8
        Me.AuRequest.Text = "AU REQUEST"
        Me.AuRequest.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.AuRequest.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.AuRequest.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Transparent
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MENUToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(533, 24)
        Me.MenuStrip1.TabIndex = 9
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MENUToolStripMenuItem
        '
        Me.MENUToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UserManualToolStripMenuItem, Me.AddUserToolStripMenuItem, Me.UpdateLogToolStripMenuItem1, Me.ToolStripSeparator1, Me.SwitchAccessToolStripMenuItem, Me.UpdateLogToolStripMenuItem, Me.ToolStripSeparator2, Me.CheckForUpdateToolStripMenuItem})
        Me.MENUToolStripMenuItem.Image = CType(resources.GetObject("MENUToolStripMenuItem.Image"), System.Drawing.Image)
        Me.MENUToolStripMenuItem.Name = "MENUToolStripMenuItem"
        Me.MENUToolStripMenuItem.Size = New System.Drawing.Size(69, 20)
        Me.MENUToolStripMenuItem.Text = "MENU"
        '
        'UserManualToolStripMenuItem
        '
        Me.UserManualToolStripMenuItem.Image = CType(resources.GetObject("UserManualToolStripMenuItem.Image"), System.Drawing.Image)
        Me.UserManualToolStripMenuItem.Name = "UserManualToolStripMenuItem"
        Me.UserManualToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.UserManualToolStripMenuItem.Text = "User Manual"
        '
        'AddUserToolStripMenuItem
        '
        Me.AddUserToolStripMenuItem.Enabled = False
        Me.AddUserToolStripMenuItem.Image = CType(resources.GetObject("AddUserToolStripMenuItem.Image"), System.Drawing.Image)
        Me.AddUserToolStripMenuItem.Name = "AddUserToolStripMenuItem"
        Me.AddUserToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.AddUserToolStripMenuItem.Text = "Add user"
        '
        'UpdateLogToolStripMenuItem1
        '
        Me.UpdateLogToolStripMenuItem1.Image = CType(resources.GetObject("UpdateLogToolStripMenuItem1.Image"), System.Drawing.Image)
        Me.UpdateLogToolStripMenuItem1.Name = "UpdateLogToolStripMenuItem1"
        Me.UpdateLogToolStripMenuItem1.Size = New System.Drawing.Size(180, 22)
        Me.UpdateLogToolStripMenuItem1.Text = "Update log"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(177, 6)
        '
        'SwitchAccessToolStripMenuItem
        '
        Me.SwitchAccessToolStripMenuItem.Image = CType(resources.GetObject("SwitchAccessToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SwitchAccessToolStripMenuItem.Name = "SwitchAccessToolStripMenuItem"
        Me.SwitchAccessToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.SwitchAccessToolStripMenuItem.Text = "MRS Setting"
        '
        'UpdateLogToolStripMenuItem
        '
        Me.UpdateLogToolStripMenuItem.Enabled = False
        Me.UpdateLogToolStripMenuItem.Image = CType(resources.GetObject("UpdateLogToolStripMenuItem.Image"), System.Drawing.Image)
        Me.UpdateLogToolStripMenuItem.Name = "UpdateLogToolStripMenuItem"
        Me.UpdateLogToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.UpdateLogToolStripMenuItem.Text = "UPDATE MATRIX"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(177, 6)
        '
        'CheckForUpdateToolStripMenuItem
        '
        Me.CheckForUpdateToolStripMenuItem.Image = CType(resources.GetObject("CheckForUpdateToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CheckForUpdateToolStripMenuItem.Name = "CheckForUpdateToolStripMenuItem"
        Me.CheckForUpdateToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.CheckForUpdateToolStripMenuItem.Text = "Check for Update"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel1.ColumnCount = 5
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.791209!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.47253!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.47253!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.47253!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.791209!))
        Me.TableLayoutPanel1.Controls.Add(Me.kitting, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.AuRequest, 3, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.DmRequest, 2, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 153)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(533, 155)
        Me.TableLayoutPanel1.TabIndex = 10
        '
        'switch
        '
        Me.switch.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.switch.BackColor = System.Drawing.Color.Transparent
        Me.switch.Image = CType(resources.GetObject("switch.Image"), System.Drawing.Image)
        Me.switch.Location = New System.Drawing.Point(454, 0)
        Me.switch.Name = "switch"
        Me.switch.Size = New System.Drawing.Size(72, 51)
        Me.switch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.switch.TabIndex = 11
        Me.switch.TabStop = False
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel2.ColumnCount = 1
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.version, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.appName, 0, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(0, 24)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 2
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(533, 129)
        Me.TableLayoutPanel2.TabIndex = 12
        '
        'version
        '
        Me.version.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.version.AutoSize = True
        Me.version.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.version.Location = New System.Drawing.Point(3, 109)
        Me.version.Name = "version"
        Me.version.Size = New System.Drawing.Size(527, 13)
        Me.version.TabIndex = 1
        Me.version.Text = "v5.0.0.0"
        Me.version.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'appName
        '
        Me.appName.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.appName.AutoSize = True
        Me.appName.Font = New System.Drawing.Font("Dubai", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.appName.Location = New System.Drawing.Point(3, 0)
        Me.appName.Name = "appName"
        Me.appName.Size = New System.Drawing.Size(527, 109)
        Me.appName.TabIndex = 0
        Me.appName.Text = "B800 Material Request System"
        Me.appName.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'SoftwareUpdate
        '
        Me.SoftwareUpdate.Interval = 3600000
        '
        'StartPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(533, 308)
        Me.Controls.Add(Me.switch)
        Me.Controls.Add(Me.TableLayoutPanel2)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "StartPage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "B800 Material Request System"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.switch, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents kitting As Button
    Friend WithEvents DmRequest As Button
    Friend WithEvents AuRequest As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MENUToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UserManualToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddUserToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents UpdateLogToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents CheckForUpdateToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents UpdateLogToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents switch As PictureBox
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents version As Label
    Friend WithEvents appName As Label
    Friend WithEvents SwitchAccessToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SoftwareUpdate As Timer
End Class
