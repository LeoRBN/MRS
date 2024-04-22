<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NewEndorseRaw
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NewEndorseRaw))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.label = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.savebtn = New System.Windows.Forms.Button()
        Me.type = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.kitter = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dgvOthers = New System.Windows.Forms.DataGridView()
        Me.tb = New System.Windows.Forms.TabControl()
        Me.newE = New System.Windows.Forms.TabPage()
        Me.updateE = New System.Windows.Forms.TabPage()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.dgvOthers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tb.SuspendLayout()
        Me.newE.SuspendLayout()
        Me.updateE.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.label)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(781, 42)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Silver
        Me.Label1.Location = New System.Drawing.Point(715, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 13)
        Me.Label1.TabIndex = 41
        Me.Label1.Text = "SCANNER"
        '
        'label
        '
        Me.label.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.label.AutoSize = True
        Me.label.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label.ForeColor = System.Drawing.Color.Yellow
        Me.label.Location = New System.Drawing.Point(12, 9)
        Me.label.Name = "label"
        Me.label.Size = New System.Drawing.Size(161, 25)
        Me.label.TabIndex = 40
        Me.label.Text = "NEW ENDORSED"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel2.Controls.Add(Me.savebtn)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 602)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(781, 50)
        Me.Panel2.TabIndex = 1
        '
        'savebtn
        '
        Me.savebtn.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.savebtn.BackColor = System.Drawing.Color.Green
        Me.savebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.savebtn.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.savebtn.ForeColor = System.Drawing.Color.White
        Me.savebtn.Location = New System.Drawing.Point(304, 4)
        Me.savebtn.Name = "savebtn"
        Me.savebtn.Size = New System.Drawing.Size(151, 40)
        Me.savebtn.TabIndex = 44
        Me.savebtn.Text = "SAVE"
        Me.savebtn.UseVisualStyleBackColor = False
        '
        'type
        '
        Me.type.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.type.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.type.FormattingEnabled = True
        Me.type.Items.AddRange(New Object() {"CAPS CONSUME", "VCSEL WAFER", "VALENCIA WAFER", "INTERPOSER/EFUSE", "BARE CAPS", "GLASS CONSUME"})
        Me.type.Location = New System.Drawing.Point(123, 25)
        Me.type.Name = "type"
        Me.type.Size = New System.Drawing.Size(191, 25)
        Me.type.TabIndex = 35
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(41, 30)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 15)
        Me.Label4.TabIndex = 36
        Me.Label4.Text = "Select Type"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(555, 30)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 15)
        Me.Label3.TabIndex = 41
        Me.Label3.Text = "Kitter:"
        '
        'kitter
        '
        Me.kitter.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.kitter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.kitter.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.kitter.Location = New System.Drawing.Point(604, 28)
        Me.kitter.MaxLength = 6
        Me.kitter.Name = "kitter"
        Me.kitter.Size = New System.Drawing.Size(110, 22)
        Me.kitter.TabIndex = 40
        Me.kitter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.kitter)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.type)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(3, 3)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(767, 61)
        Me.Panel3.TabIndex = 42
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(320, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(202, 12)
        Me.Label2.TabIndex = 42
        Me.Label2.Text = "Date format for Expiry Date of VCSEL : dd.mm.yyyy"
        Me.Label2.Visible = False
        '
        'dgvOthers
        '
        Me.dgvOthers.AllowDrop = True
        Me.dgvOthers.AllowUserToResizeRows = False
        Me.dgvOthers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvOthers.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvOthers.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvOthers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvOthers.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvOthers.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvOthers.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.dgvOthers.Location = New System.Drawing.Point(3, 64)
        Me.dgvOthers.Margin = New System.Windows.Forms.Padding(2)
        Me.dgvOthers.MultiSelect = False
        Me.dgvOthers.Name = "dgvOthers"
        Me.dgvOthers.RowHeadersVisible = False
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvOthers.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvOthers.RowTemplate.Height = 24
        Me.dgvOthers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgvOthers.Size = New System.Drawing.Size(767, 517)
        Me.dgvOthers.TabIndex = 36
        '
        'tb
        '
        Me.tb.Controls.Add(Me.newE)
        Me.tb.Controls.Add(Me.updateE)
        Me.tb.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tb.Location = New System.Drawing.Point(0, 0)
        Me.tb.Name = "tb"
        Me.tb.SelectedIndex = 0
        Me.tb.Size = New System.Drawing.Size(781, 652)
        Me.tb.TabIndex = 43
        '
        'newE
        '
        Me.newE.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.newE.Controls.Add(Me.dgvOthers)
        Me.newE.Controls.Add(Me.Panel3)
        Me.newE.Location = New System.Drawing.Point(4, 22)
        Me.newE.Name = "newE"
        Me.newE.Padding = New System.Windows.Forms.Padding(3)
        Me.newE.Size = New System.Drawing.Size(773, 584)
        Me.newE.TabIndex = 0
        Me.newE.Text = "newE"
        '
        'updateE
        '
        Me.updateE.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.updateE.Controls.Add(Me.TextBox1)
        Me.updateE.Controls.Add(Me.DataGridView1)
        Me.updateE.Location = New System.Drawing.Point(4, 22)
        Me.updateE.Name = "updateE"
        Me.updateE.Padding = New System.Windows.Forms.Padding(3)
        Me.updateE.Size = New System.Drawing.Size(773, 626)
        Me.updateE.TabIndex = 1
        Me.updateE.Text = "updateE"
        '
        'TextBox1
        '
        Me.TextBox1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TextBox1.ForeColor = System.Drawing.Color.White
        Me.TextBox1.Location = New System.Drawing.Point(3, 27)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(767, 20)
        Me.TextBox1.TabIndex = 3
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DataGridView1.Location = New System.Drawing.Point(3, 47)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(767, 576)
        Me.DataGridView1.TabIndex = 2
        '
        'NewEndorseRaw
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(781, 652)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.tb)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "NewEndorseRaw"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "NewEndorseRaw"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.dgvOthers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tb.ResumeLayout(False)
        Me.newE.ResumeLayout(False)
        Me.updateE.ResumeLayout(False)
        Me.updateE.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents type As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents label As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents kitter As TextBox
    Friend WithEvents savebtn As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents dgvOthers As DataGridView
    Friend WithEvents tb As TabControl
    Friend WithEvents newE As TabPage
    Friend WithEvents updateE As TabPage
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
