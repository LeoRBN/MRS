<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class RawUpload
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RawUpload))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BrowseFile = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.uploadType = New System.Windows.Forms.ComboBox()
        Me.uploadBTN = New System.Windows.Forms.Button()
        Me.dgvUpload = New System.Windows.Forms.DataGridView()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.rount = New System.Windows.Forms.Label()
        Me.rlbl = New System.Windows.Forms.Label()
        Me.uploadlog = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.UploadTemplatesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LotConsumeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ValenciaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VcselToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReelMaterialToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1.SuspendLayout()
        CType(Me.dgvUpload, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.BrowseFile)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.uploadType)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 24)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(760, 47)
        Me.Panel1.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Button1.BackColor = System.Drawing.Color.Red
        Me.Button1.Enabled = False
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(438, 14)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(66, 23)
        Me.Button1.TabIndex = 46
        Me.Button1.Text = "CLEAR"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Black", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(633, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 20)
        Me.Label2.TabIndex = 45
        Me.Label2.Text = "000"
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(589, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 12)
        Me.Label1.TabIndex = 44
        Me.Label1.Text = "DataRow:"
        '
        'BrowseFile
        '
        Me.BrowseFile.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.BrowseFile.BackColor = System.Drawing.Color.DodgerBlue
        Me.BrowseFile.Enabled = False
        Me.BrowseFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BrowseFile.Font = New System.Drawing.Font("Segoe UI", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BrowseFile.ForeColor = System.Drawing.Color.White
        Me.BrowseFile.Location = New System.Drawing.Point(322, 14)
        Me.BrowseFile.Name = "BrowseFile"
        Me.BrowseFile.Size = New System.Drawing.Size(110, 23)
        Me.BrowseFile.TabIndex = 43
        Me.BrowseFile.Text = "Browse file"
        Me.BrowseFile.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BrowseFile.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(35, 21)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 12)
        Me.Label4.TabIndex = 42
        Me.Label4.Text = "SELECT TYPE"
        '
        'uploadType
        '
        Me.uploadType.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.uploadType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.uploadType.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.uploadType.FormattingEnabled = True
        Me.uploadType.Items.AddRange(New Object() {"VCSEL WAFER", "VALENCIA WAFER", "BARE CAPS / SMT MATERIAL", "INDIRECT MATERIAL", "CONSUME LOTS"})
        Me.uploadType.Location = New System.Drawing.Point(111, 15)
        Me.uploadType.Name = "uploadType"
        Me.uploadType.Size = New System.Drawing.Size(195, 23)
        Me.uploadType.TabIndex = 41
        '
        'uploadBTN
        '
        Me.uploadBTN.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.uploadBTN.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.uploadBTN.Enabled = False
        Me.uploadBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.uploadBTN.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.uploadBTN.Location = New System.Drawing.Point(591, 9)
        Me.uploadBTN.Name = "uploadBTN"
        Me.uploadBTN.Size = New System.Drawing.Size(131, 31)
        Me.uploadBTN.TabIndex = 40
        Me.uploadBTN.Text = "UPLOAD"
        Me.uploadBTN.UseVisualStyleBackColor = False
        '
        'dgvUpload
        '
        Me.dgvUpload.AllowDrop = True
        Me.dgvUpload.AllowUserToAddRows = False
        Me.dgvUpload.AllowUserToDeleteRows = False
        Me.dgvUpload.AllowUserToResizeRows = False
        Me.dgvUpload.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvUpload.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvUpload.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvUpload.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvUpload.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvUpload.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvUpload.Location = New System.Drawing.Point(0, 71)
        Me.dgvUpload.Margin = New System.Windows.Forms.Padding(2)
        Me.dgvUpload.MultiSelect = False
        Me.dgvUpload.Name = "dgvUpload"
        Me.dgvUpload.ReadOnly = True
        Me.dgvUpload.RowHeadersVisible = False
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvUpload.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvUpload.RowTemplate.Height = 24
        Me.dgvUpload.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvUpload.Size = New System.Drawing.Size(760, 474)
        Me.dgvUpload.TabIndex = 5
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel2.Controls.Add(Me.rount)
        Me.Panel2.Controls.Add(Me.rlbl)
        Me.Panel2.Controls.Add(Me.uploadlog)
        Me.Panel2.Controls.Add(Me.uploadBTN)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 496)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(760, 49)
        Me.Panel2.TabIndex = 6
        '
        'rount
        '
        Me.rount.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.rount.AutoSize = True
        Me.rount.Font = New System.Drawing.Font("Segoe UI Black", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rount.ForeColor = System.Drawing.Color.White
        Me.rount.Location = New System.Drawing.Point(79, 17)
        Me.rount.Name = "rount"
        Me.rount.Size = New System.Drawing.Size(36, 20)
        Me.rount.TabIndex = 47
        Me.rount.Text = "000"
        Me.rount.Visible = False
        '
        'rlbl
        '
        Me.rlbl.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.rlbl.AutoSize = True
        Me.rlbl.Font = New System.Drawing.Font("Segoe UI Semibold", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rlbl.ForeColor = System.Drawing.Color.White
        Me.rlbl.Location = New System.Drawing.Point(12, 21)
        Me.rlbl.Name = "rlbl"
        Me.rlbl.Size = New System.Drawing.Size(67, 12)
        Me.rlbl.TabIndex = 46
        Me.rlbl.Text = "Row Uploaded :"
        Me.rlbl.Visible = False
        '
        'uploadlog
        '
        Me.uploadlog.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.uploadlog.AutoSize = True
        Me.uploadlog.Font = New System.Drawing.Font("Segoe UI Semibold", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.uploadlog.ForeColor = System.Drawing.Color.Red
        Me.uploadlog.Location = New System.Drawing.Point(27, 19)
        Me.uploadlog.Name = "uploadlog"
        Me.uploadlog.Size = New System.Drawing.Size(0, 12)
        Me.uploadlog.TabIndex = 43
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Black
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UploadTemplatesToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(760, 24)
        Me.MenuStrip1.TabIndex = 7
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'UploadTemplatesToolStripMenuItem
        '
        Me.UploadTemplatesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LotConsumeToolStripMenuItem, Me.ValenciaToolStripMenuItem, Me.VcselToolStripMenuItem, Me.ReelMaterialToolStripMenuItem})
        Me.UploadTemplatesToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.UploadTemplatesToolStripMenuItem.Name = "UploadTemplatesToolStripMenuItem"
        Me.UploadTemplatesToolStripMenuItem.Size = New System.Drawing.Size(113, 20)
        Me.UploadTemplatesToolStripMenuItem.Text = "Upload Templates"
        '
        'LotConsumeToolStripMenuItem
        '
        Me.LotConsumeToolStripMenuItem.Name = "LotConsumeToolStripMenuItem"
        Me.LotConsumeToolStripMenuItem.Size = New System.Drawing.Size(145, 22)
        Me.LotConsumeToolStripMenuItem.Text = "Lot Consume"
        '
        'ValenciaToolStripMenuItem
        '
        Me.ValenciaToolStripMenuItem.Name = "ValenciaToolStripMenuItem"
        Me.ValenciaToolStripMenuItem.Size = New System.Drawing.Size(145, 22)
        Me.ValenciaToolStripMenuItem.Text = "Valencia"
        '
        'VcselToolStripMenuItem
        '
        Me.VcselToolStripMenuItem.Name = "VcselToolStripMenuItem"
        Me.VcselToolStripMenuItem.Size = New System.Drawing.Size(145, 22)
        Me.VcselToolStripMenuItem.Text = "Vcsel"
        '
        'ReelMaterialToolStripMenuItem
        '
        Me.ReelMaterialToolStripMenuItem.Name = "ReelMaterialToolStripMenuItem"
        Me.ReelMaterialToolStripMenuItem.Size = New System.Drawing.Size(145, 22)
        Me.ReelMaterialToolStripMenuItem.Text = "Reel Material"
        '
        'RawUpload
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(760, 545)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.dgvUpload)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "RawUpload"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Upload Raw"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgvUpload, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents dgvUpload As DataGridView
    Friend WithEvents uploadBTN As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents BrowseFile As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents uploadType As ComboBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents uploadlog As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents rount As Label
    Friend WithEvents rlbl As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents UploadTemplatesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LotConsumeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ValenciaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VcselToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReelMaterialToolStripMenuItem As ToolStripMenuItem
End Class
