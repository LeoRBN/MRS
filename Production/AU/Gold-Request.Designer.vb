<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Gold_Request
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Gold_Request))
        Me.returnBtn = New System.Windows.Forms.Button()
        Me.newREQ = New System.Windows.Forms.Button()
        Me.dgvGold = New System.Windows.Forms.DataGridView()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.g_online = New System.Windows.Forms.Button()
        Me.g_avail = New System.Windows.Forms.Button()
        Me.g_return = New System.Windows.Forms.Button()
        Me.g_new = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ROWcount = New System.Windows.Forms.Button()
        Me.RET = New System.Windows.Forms.CheckBox()
        Me.g_clear = New System.Windows.Forms.Button()
        Me.date0pnl = New System.Windows.Forms.Panel()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.to_g = New System.Windows.Forms.DateTimePicker()
        Me.fr_g = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.g_dateF = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.g_machine = New System.Windows.Forms.ComboBox()
        Me.g_search = New System.Windows.Forms.Button()
        Me.g_spool = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.g_package = New System.Windows.Forms.ComboBox()
        Me.g_limitrow = New System.Windows.Forms.ComboBox()
        Me.Label117 = New System.Windows.Forms.Label()
        Me._refresh = New System.Windows.Forms.LinkLabel()
        Me.auMENU = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.RETURNToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewTransactionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ManualPDF = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.AuNotifier = New System.IO.FileSystemWatcher()
        Me.AuAlert = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.Xfile = New System.Windows.Forms.Timer(Me.components)
        Me.AutoRefresh = New System.Windows.Forms.Timer(Me.components)
        CType(Me.dgvGold, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.date0pnl.SuspendLayout()
        Me.auMENU.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.AuNotifier, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'returnBtn
        '
        Me.returnBtn.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.returnBtn.BackColor = System.Drawing.Color.Yellow
        Me.returnBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.returnBtn.Font = New System.Drawing.Font("Segoe UI Black", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.returnBtn.ForeColor = System.Drawing.Color.Black
        Me.returnBtn.Location = New System.Drawing.Point(17, 78)
        Me.returnBtn.Name = "returnBtn"
        Me.returnBtn.Size = New System.Drawing.Size(132, 63)
        Me.returnBtn.TabIndex = 54
        Me.returnBtn.Text = "RETURN"
        Me.returnBtn.UseVisualStyleBackColor = False
        '
        'newREQ
        '
        Me.newREQ.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.newREQ.BackColor = System.Drawing.Color.Blue
        Me.newREQ.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.newREQ.Font = New System.Drawing.Font("Segoe UI Black", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.newREQ.ForeColor = System.Drawing.Color.White
        Me.newREQ.Location = New System.Drawing.Point(17, 5)
        Me.newREQ.Name = "newREQ"
        Me.newREQ.Size = New System.Drawing.Size(132, 63)
        Me.newREQ.TabIndex = 51
        Me.newREQ.Text = "SEND REQUEST"
        Me.newREQ.UseVisualStyleBackColor = False
        '
        'dgvGold
        '
        Me.dgvGold.AllowUserToAddRows = False
        Me.dgvGold.AllowUserToDeleteRows = False
        Me.dgvGold.AllowUserToResizeRows = False
        Me.dgvGold.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvGold.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvGold.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvGold.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvGold.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvGold.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvGold.Location = New System.Drawing.Point(166, 140)
        Me.dgvGold.Margin = New System.Windows.Forms.Padding(2)
        Me.dgvGold.MultiSelect = False
        Me.dgvGold.Name = "dgvGold"
        Me.dgvGold.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvGold.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvGold.RowHeadersVisible = False
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvGold.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvGold.RowTemplate.Height = 24
        Me.dgvGold.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvGold.Size = New System.Drawing.Size(944, 465)
        Me.dgvGold.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Gold
        Me.Label3.Location = New System.Drawing.Point(57, 261)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 19)
        Me.Label3.TabIndex = 53
        Me.Label3.Text = "ON-LINE"
        '
        'g_online
        '
        Me.g_online.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.g_online.BackColor = System.Drawing.Color.Green
        Me.g_online.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.g_online.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.g_online.ForeColor = System.Drawing.Color.White
        Me.g_online.Location = New System.Drawing.Point(30, 203)
        Me.g_online.Name = "g_online"
        Me.g_online.Size = New System.Drawing.Size(106, 55)
        Me.g_online.TabIndex = 46
        Me.g_online.Text = "0"
        Me.g_online.UseVisualStyleBackColor = False
        '
        'g_avail
        '
        Me.g_avail.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.g_avail.BackColor = System.Drawing.Color.Lime
        Me.g_avail.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.g_avail.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.g_avail.ForeColor = System.Drawing.Color.Black
        Me.g_avail.Location = New System.Drawing.Point(30, 388)
        Me.g_avail.Name = "g_avail"
        Me.g_avail.Size = New System.Drawing.Size(106, 55)
        Me.g_avail.TabIndex = 47
        Me.g_avail.Text = "0"
        Me.g_avail.UseVisualStyleBackColor = False
        '
        'g_return
        '
        Me.g_return.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.g_return.BackColor = System.Drawing.Color.Orange
        Me.g_return.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.g_return.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.g_return.ForeColor = System.Drawing.Color.Black
        Me.g_return.Location = New System.Drawing.Point(30, 480)
        Me.g_return.Name = "g_return"
        Me.g_return.Size = New System.Drawing.Size(106, 55)
        Me.g_return.TabIndex = 48
        Me.g_return.Text = "0"
        Me.g_return.UseVisualStyleBackColor = False
        '
        'g_new
        '
        Me.g_new.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.g_new.BackColor = System.Drawing.Color.Blue
        Me.g_new.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.g_new.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.g_new.ForeColor = System.Drawing.Color.White
        Me.g_new.Location = New System.Drawing.Point(30, 297)
        Me.g_new.Name = "g_new"
        Me.g_new.Size = New System.Drawing.Size(106, 55)
        Me.g_new.TabIndex = 49
        Me.g_new.Text = "0"
        Me.g_new.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Gold
        Me.Label2.Location = New System.Drawing.Point(41, 355)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 19)
        Me.Label2.TabIndex = 52
        Me.Label2.Text = "NEW REQUEST"
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Gold
        Me.Label5.Location = New System.Drawing.Point(51, 446)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 20)
        Me.Label5.TabIndex = 50
        Me.Label5.Text = "AVAILABLE"
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gold
        Me.Label1.Location = New System.Drawing.Point(46, 538)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 67)
        Me.Label1.TabIndex = 51
        Me.Label1.Text = "FOR RETURN"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.ROWcount)
        Me.GroupBox1.Controls.Add(Me.RET)
        Me.GroupBox1.Controls.Add(Me.g_clear)
        Me.GroupBox1.Controls.Add(Me.date0pnl)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.g_dateF)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.g_machine)
        Me.GroupBox1.Controls.Add(Me.g_search)
        Me.GroupBox1.Controls.Add(Me.g_spool)
        Me.GroupBox1.Controls.Add(Me.Label19)
        Me.GroupBox1.Controls.Add(Me.Label27)
        Me.GroupBox1.Controls.Add(Me.g_package)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(166, 50)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(944, 90)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "FILTER"
        '
        'ROWcount
        '
        Me.ROWcount.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.ROWcount.BackColor = System.Drawing.Color.White
        Me.ROWcount.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ROWcount.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ROWcount.ForeColor = System.Drawing.Color.Black
        Me.ROWcount.Location = New System.Drawing.Point(20, 28)
        Me.ROWcount.Name = "ROWcount"
        Me.ROWcount.Size = New System.Drawing.Size(106, 48)
        Me.ROWcount.TabIndex = 52
        Me.ROWcount.Text = "0"
        Me.ROWcount.UseVisualStyleBackColor = False
        '
        'RET
        '
        Me.RET.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.RET.AutoSize = True
        Me.RET.Checked = True
        Me.RET.CheckState = System.Windows.Forms.CheckState.Checked
        Me.RET.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RET.Location = New System.Drawing.Point(836, 13)
        Me.RET.Name = "RET"
        Me.RET.Size = New System.Drawing.Size(67, 17)
        Me.RET.TabIndex = 51
        Me.RET.Text = "ONLINE"
        Me.RET.UseVisualStyleBackColor = True
        '
        'g_clear
        '
        Me.g_clear.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.g_clear.BackColor = System.Drawing.Color.Red
        Me.g_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.g_clear.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.g_clear.ForeColor = System.Drawing.Color.Black
        Me.g_clear.Location = New System.Drawing.Point(819, 60)
        Me.g_clear.Name = "g_clear"
        Me.g_clear.Size = New System.Drawing.Size(104, 24)
        Me.g_clear.TabIndex = 50
        Me.g_clear.Text = "CLEAR"
        Me.g_clear.UseVisualStyleBackColor = False
        '
        'date0pnl
        '
        Me.date0pnl.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.date0pnl.Controls.Add(Me.Label11)
        Me.date0pnl.Controls.Add(Me.Label10)
        Me.date0pnl.Controls.Add(Me.to_g)
        Me.date0pnl.Controls.Add(Me.fr_g)
        Me.date0pnl.Enabled = False
        Me.date0pnl.Location = New System.Drawing.Point(652, 21)
        Me.date0pnl.Name = "date0pnl"
        Me.date0pnl.Size = New System.Drawing.Size(157, 59)
        Me.date0pnl.TabIndex = 49
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI Semibold", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(13, 38)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(16, 12)
        Me.Label11.TabIndex = 24
        Me.Label11.Text = "To:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI Semibold", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(1, 8)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(28, 12)
        Me.Label10.TabIndex = 23
        Me.Label10.Text = "From:"
        '
        'to_g
        '
        Me.to_g.CustomFormat = "dd-MMM-yyyy"
        Me.to_g.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.to_g.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.to_g.Location = New System.Drawing.Point(39, 33)
        Me.to_g.Name = "to_g"
        Me.to_g.Size = New System.Drawing.Size(108, 22)
        Me.to_g.TabIndex = 22
        '
        'fr_g
        '
        Me.fr_g.CustomFormat = "dd-MMM-yyyy"
        Me.fr_g.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fr_g.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.fr_g.Location = New System.Drawing.Point(39, 4)
        Me.fr_g.Name = "fr_g"
        Me.fr_g.Size = New System.Drawing.Size(108, 22)
        Me.fr_g.TabIndex = 21
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Semibold", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(401, 58)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(26, 12)
        Me.Label6.TabIndex = 48
        Me.Label6.Text = "DATE"
        '
        'g_dateF
        '
        Me.g_dateF.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.g_dateF.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.g_dateF.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.g_dateF.FormattingEnabled = True
        Me.g_dateF.Items.AddRange(New Object() {"DATE_REQUESTED", "DATE_RETURNED"})
        Me.g_dateF.Location = New System.Drawing.Point(453, 54)
        Me.g_dateF.Name = "g_dateF"
        Me.g_dateF.Size = New System.Drawing.Size(185, 21)
        Me.g_dateF.TabIndex = 47
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(141, 58)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 12)
        Me.Label4.TabIndex = 46
        Me.Label4.Text = "MACHINE NO"
        '
        'g_machine
        '
        Me.g_machine.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.g_machine.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.g_machine.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.g_machine.DropDownHeight = 200
        Me.g_machine.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.g_machine.FormattingEnabled = True
        Me.g_machine.IntegralHeight = False
        Me.g_machine.Location = New System.Drawing.Point(208, 54)
        Me.g_machine.Name = "g_machine"
        Me.g_machine.Size = New System.Drawing.Size(170, 21)
        Me.g_machine.TabIndex = 45
        '
        'g_search
        '
        Me.g_search.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.g_search.BackColor = System.Drawing.Color.Lime
        Me.g_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.g_search.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.g_search.ForeColor = System.Drawing.Color.Black
        Me.g_search.Location = New System.Drawing.Point(819, 33)
        Me.g_search.Name = "g_search"
        Me.g_search.Size = New System.Drawing.Size(104, 24)
        Me.g_search.TabIndex = 44
        Me.g_search.Text = "SEARCH"
        Me.g_search.UseVisualStyleBackColor = False
        '
        'g_spool
        '
        Me.g_spool.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.g_spool.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.g_spool.Location = New System.Drawing.Point(453, 27)
        Me.g_spool.Name = "g_spool"
        Me.g_spool.Size = New System.Drawing.Size(185, 22)
        Me.g_spool.TabIndex = 43
        Me.g_spool.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label19
        '
        Me.Label19.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Segoe UI Semibold", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(398, 31)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(49, 12)
        Me.Label19.TabIndex = 42
        Me.Label19.Text = "SPOOL NO"
        '
        'Label27
        '
        Me.Label27.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Segoe UI Semibold", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(141, 31)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(44, 12)
        Me.Label27.TabIndex = 41
        Me.Label27.Text = "PACKAGE"
        '
        'g_package
        '
        Me.g_package.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.g_package.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.g_package.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.g_package.FormattingEnabled = True
        Me.g_package.Location = New System.Drawing.Point(208, 27)
        Me.g_package.Name = "g_package"
        Me.g_package.Size = New System.Drawing.Size(170, 21)
        Me.g_package.TabIndex = 40
        '
        'g_limitrow
        '
        Me.g_limitrow.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.g_limitrow.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.g_limitrow.FormattingEnabled = True
        Me.g_limitrow.Items.AddRange(New Object() {"50", "100", "200", "300", "500", "1000", "ALL"})
        Me.g_limitrow.Location = New System.Drawing.Point(879, 15)
        Me.g_limitrow.Name = "g_limitrow"
        Me.g_limitrow.Size = New System.Drawing.Size(53, 21)
        Me.g_limitrow.TabIndex = 57
        Me.g_limitrow.Text = "50"
        '
        'Label117
        '
        Me.Label117.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label117.AutoSize = True
        Me.Label117.Font = New System.Drawing.Font("Segoe UI Semibold", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label117.ForeColor = System.Drawing.Color.White
        Me.Label117.Location = New System.Drawing.Point(850, 19)
        Me.Label117.Name = "Label117"
        Me.Label117.Size = New System.Drawing.Size(28, 12)
        Me.Label117.TabIndex = 56
        Me.Label117.Text = "Limit :"
        '
        '_refresh
        '
        Me._refresh.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me._refresh.AutoSize = True
        Me._refresh.LinkColor = System.Drawing.Color.Magenta
        Me._refresh.Location = New System.Drawing.Point(784, 18)
        Me._refresh.Name = "_refresh"
        Me._refresh.Size = New System.Drawing.Size(44, 13)
        Me._refresh.TabIndex = 58
        Me._refresh.TabStop = True
        Me._refresh.Text = "Refresh"
        '
        'auMENU
        '
        Me.auMENU.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RETURNToolStripMenuItem, Me.ViewTransactionToolStripMenuItem})
        Me.auMENU.Name = "auMENU"
        Me.auMENU.Size = New System.Drawing.Size(163, 48)
        '
        'RETURNToolStripMenuItem
        '
        Me.RETURNToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.RETURNToolStripMenuItem.Name = "RETURNToolStripMenuItem"
        Me.RETURNToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.RETURNToolStripMenuItem.Text = "RETURN"
        '
        'ViewTransactionToolStripMenuItem
        '
        Me.ViewTransactionToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ViewTransactionToolStripMenuItem.Name = "ViewTransactionToolStripMenuItem"
        Me.ViewTransactionToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.ViewTransactionToolStripMenuItem.Text = "View Transaction"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TableLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 10)
        Me.TableLayoutPanel1.Controls.Add(Me.g_return, 0, 9)
        Me.TableLayoutPanel1.Controls.Add(Me.Label5, 0, 8)
        Me.TableLayoutPanel1.Controls.Add(Me.g_avail, 0, 7)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 0, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.g_new, 0, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.g_online, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.returnBtn, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.newREQ, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 11
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.23141!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.73554!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 1.652893!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.52066!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.140496!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.39669!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.140496!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.90083!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.305785!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.90083!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.90909!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(166, 605)
        Me.TableLayoutPanel1.TabIndex = 55
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel1.Controls.Add(Me._refresh)
        Me.Panel1.Controls.Add(Me.g_limitrow)
        Me.Panel1.Controls.Add(Me.Label117)
        Me.Panel1.Controls.Add(Me.ManualPDF)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(166, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(944, 50)
        Me.Panel1.TabIndex = 56
        '
        'ManualPDF
        '
        Me.ManualPDF.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.ManualPDF.Font = New System.Drawing.Font("Segoe UI", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ManualPDF.ForeColor = System.Drawing.Color.Black
        Me.ManualPDF.Location = New System.Drawing.Point(659, 15)
        Me.ManualPDF.Margin = New System.Windows.Forms.Padding(2)
        Me.ManualPDF.Name = "ManualPDF"
        Me.ManualPDF.Size = New System.Drawing.Size(100, 21)
        Me.ManualPDF.TabIndex = 53
        Me.ManualPDF.Text = "USER MANUAL"
        Me.ManualPDF.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI Black", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Gold
        Me.Label7.Location = New System.Drawing.Point(22, 9)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(312, 32)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "GOLDWIRE MONITORING"
        '
        'AuNotifier
        '
        Me.AuNotifier.EnableRaisingEvents = True
        Me.AuNotifier.Filter = "*.txt*"
        Me.AuNotifier.SynchronizingObject = Me
        '
        'AuAlert
        '
        Me.AuAlert.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.AuAlert.Icon = CType(resources.GetObject("AuAlert.Icon"), System.Drawing.Icon)
        Me.AuAlert.Text = "NotifyIcon1"
        Me.AuAlert.Visible = True
        '
        'Xfile
        '
        Me.Xfile.Interval = 3000
        '
        'AutoRefresh
        '
        '
        'Gold_Request
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1110, 605)
        Me.Controls.Add(Me.dgvGold)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Gold_Request"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "GOLD REQUEST MONITORING"
        CType(Me.dgvGold, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.date0pnl.ResumeLayout(False)
        Me.date0pnl.PerformLayout()
        Me.auMENU.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.AuNotifier, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents returnBtn As Button
    Friend WithEvents newREQ As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents dgvGold As DataGridView
    Friend WithEvents g_online As Button
    Friend WithEvents g_avail As Button
    Friend WithEvents g_return As Button
    Friend WithEvents g_new As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents g_dateF As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents g_machine As ComboBox
    Friend WithEvents g_search As Button
    Friend WithEvents g_spool As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents g_clear As Button
    Friend WithEvents date0pnl As Panel
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents to_g As DateTimePicker
    Friend WithEvents fr_g As DateTimePicker
    Friend WithEvents RET As CheckBox
    Friend WithEvents g_package As ComboBox
    Friend WithEvents auMENU As ContextMenuStrip
    Friend WithEvents ViewTransactionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents RETURNToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents g_limitrow As ComboBox
    Friend WithEvents Label117 As Label
    Friend WithEvents _refresh As LinkLabel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents ROWcount As Button
    Friend WithEvents ManualPDF As Button
    Friend WithEvents AuNotifier As IO.FileSystemWatcher
    Friend WithEvents AuAlert As NotifyIcon
    Friend WithEvents Xfile As Timer
    Friend WithEvents AutoRefresh As Timer
End Class
