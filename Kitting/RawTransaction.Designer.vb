<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RawTransaction
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RawTransaction))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.RequestID = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.r_bin = New System.Windows.Forms.Label()
        Me.r_qty = New System.Windows.Forms.Label()
        Me.r_supplier = New System.Windows.Forms.Label()
        Me.r_matcode = New System.Windows.Forms.Label()
        Me.r_type = New System.Windows.Forms.Label()
        Me.r_product = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.MainStatus = New System.Windows.Forms.Label()
        Me.MatOutPnl = New System.Windows.Forms.GroupBox()
        Me.preppnl = New System.Windows.Forms.GroupBox()
        Me.rdkitter = New System.Windows.Forms.TextBox()
        Me.rdreqby = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.del = New System.Windows.Forms.Button()
        Me.dgvMatOut = New System.Windows.Forms.DataGridView()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.qty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.addmatid = New System.Windows.Forms.Button()
        Me.matid = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.rdmachine = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.rdremarks = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.rdtype = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.rdreason = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.rdsupplier = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.rddiscription = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.rd_process = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.rdtranslot = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.r_recieved = New System.Windows.Forms.Button()
        Me.r_withdrawn = New System.Windows.Forms.Button()
        Me.r_available = New System.Windows.Forms.Button()
        Me.r_edit = New System.Windows.Forms.Button()
        Me.r_cancel = New System.Windows.Forms.Button()
        Me.isspnl = New System.Windows.Forms.GroupBox()
        Me.issuedby = New System.Windows.Forms.TextBox()
        Me.issuedto = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.n2pnl = New System.Windows.Forms.GroupBox()
        Me.n2Location = New System.Windows.Forms.ComboBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.MatOutPnl.SuspendLayout()
        Me.preppnl.SuspendLayout()
        CType(Me.dgvMatOut, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.isspnl.SuspendLayout()
        Me.n2pnl.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.RequestID)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.TableLayoutPanel1)
        Me.Panel1.Controls.Add(Me.MainStatus)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(866, 92)
        Me.Panel1.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(35, 25)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(57, 12)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Request ID :"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'RequestID
        '
        Me.RequestID.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RequestID.AutoSize = True
        Me.RequestID.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RequestID.ForeColor = System.Drawing.Color.White
        Me.RequestID.Location = New System.Drawing.Point(101, 25)
        Me.RequestID.Name = "RequestID"
        Me.RequestID.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.RequestID.Size = New System.Drawing.Size(13, 12)
        Me.RequestID.TabIndex = 9
        Me.RequestID.Text = "- -"
        Me.RequestID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(12, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 18)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "STATUS :"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 6
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.02005!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.02005!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.02005!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.02005!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.02005!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.899748!))
        Me.TableLayoutPanel1.Controls.Add(Me.Label13, 5, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label12, 4, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label11, 3, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label10, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label9, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.r_bin, 5, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.r_qty, 4, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.r_supplier, 3, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.r_matcode, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.r_type, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.r_product, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 0, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 40)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(866, 52)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'Label13
        '
        Me.Label13.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(783, 36)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(80, 16)
        Me.Label13.TabIndex = 12
        Me.Label13.Text = "UoM"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label12
        '
        Me.Label12.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(627, 36)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(150, 16)
        Me.Label12.TabIndex = 11
        Me.Label12.Text = "Quantity"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label11
        '
        Me.Label11.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(471, 36)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(150, 16)
        Me.Label11.TabIndex = 10
        Me.Label11.Text = "Supplier"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label10
        '
        Me.Label10.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(315, 36)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(150, 16)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "Matcode"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label9
        '
        Me.Label9.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(159, 36)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(150, 16)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Type"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'r_bin
        '
        Me.r_bin.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.r_bin.AutoSize = True
        Me.r_bin.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.r_bin.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.r_bin.Location = New System.Drawing.Point(783, 0)
        Me.r_bin.Name = "r_bin"
        Me.r_bin.Size = New System.Drawing.Size(80, 36)
        Me.r_bin.TabIndex = 7
        Me.r_bin.Text = "- -"
        Me.r_bin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'r_qty
        '
        Me.r_qty.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.r_qty.AutoSize = True
        Me.r_qty.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.r_qty.ForeColor = System.Drawing.Color.Cyan
        Me.r_qty.Location = New System.Drawing.Point(627, 0)
        Me.r_qty.Name = "r_qty"
        Me.r_qty.Size = New System.Drawing.Size(150, 36)
        Me.r_qty.TabIndex = 6
        Me.r_qty.Text = "- -"
        Me.r_qty.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'r_supplier
        '
        Me.r_supplier.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.r_supplier.AutoSize = True
        Me.r_supplier.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.r_supplier.ForeColor = System.Drawing.Color.Cyan
        Me.r_supplier.Location = New System.Drawing.Point(471, 0)
        Me.r_supplier.Name = "r_supplier"
        Me.r_supplier.Size = New System.Drawing.Size(150, 36)
        Me.r_supplier.TabIndex = 5
        Me.r_supplier.Text = "- -"
        Me.r_supplier.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'r_matcode
        '
        Me.r_matcode.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.r_matcode.AutoSize = True
        Me.r_matcode.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.r_matcode.ForeColor = System.Drawing.Color.Cyan
        Me.r_matcode.Location = New System.Drawing.Point(315, 0)
        Me.r_matcode.Name = "r_matcode"
        Me.r_matcode.Size = New System.Drawing.Size(150, 36)
        Me.r_matcode.TabIndex = 4
        Me.r_matcode.Text = "- -"
        Me.r_matcode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'r_type
        '
        Me.r_type.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.r_type.AutoSize = True
        Me.r_type.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.r_type.ForeColor = System.Drawing.Color.Cyan
        Me.r_type.Location = New System.Drawing.Point(159, 0)
        Me.r_type.Name = "r_type"
        Me.r_type.Size = New System.Drawing.Size(150, 36)
        Me.r_type.TabIndex = 3
        Me.r_type.Text = "- -"
        Me.r_type.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'r_product
        '
        Me.r_product.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.r_product.AutoSize = True
        Me.r_product.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.r_product.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.r_product.Location = New System.Drawing.Point(3, 0)
        Me.r_product.Name = "r_product"
        Me.r_product.Size = New System.Drawing.Size(150, 36)
        Me.r_product.TabIndex = 2
        Me.r_product.Text = "- -"
        Me.r_product.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(3, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(150, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Product"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MainStatus
        '
        Me.MainStatus.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MainStatus.AutoSize = True
        Me.MainStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainStatus.ForeColor = System.Drawing.Color.Yellow
        Me.MainStatus.Location = New System.Drawing.Point(100, 5)
        Me.MainStatus.Name = "MainStatus"
        Me.MainStatus.Size = New System.Drawing.Size(72, 18)
        Me.MainStatus.TabIndex = 0
        Me.MainStatus.Text = "STATUS"
        '
        'MatOutPnl
        '
        Me.MatOutPnl.Controls.Add(Me.preppnl)
        Me.MatOutPnl.Controls.Add(Me.del)
        Me.MatOutPnl.Controls.Add(Me.dgvMatOut)
        Me.MatOutPnl.Controls.Add(Me.Panel3)
        Me.MatOutPnl.Location = New System.Drawing.Point(379, 92)
        Me.MatOutPnl.Name = "MatOutPnl"
        Me.MatOutPnl.Size = New System.Drawing.Size(487, 319)
        Me.MatOutPnl.TabIndex = 1
        Me.MatOutPnl.TabStop = False
        Me.MatOutPnl.Text = "Material Out"
        '
        'preppnl
        '
        Me.preppnl.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.preppnl.Controls.Add(Me.rdkitter)
        Me.preppnl.Controls.Add(Me.rdreqby)
        Me.preppnl.Controls.Add(Me.Label18)
        Me.preppnl.Controls.Add(Me.Label19)
        Me.preppnl.Enabled = False
        Me.preppnl.Font = New System.Drawing.Font("Segoe UI", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.preppnl.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.preppnl.Location = New System.Drawing.Point(26, 272)
        Me.preppnl.Name = "preppnl"
        Me.preppnl.Size = New System.Drawing.Size(379, 39)
        Me.preppnl.TabIndex = 48
        Me.preppnl.TabStop = False
        Me.preppnl.Text = "Preparation"
        '
        'rdkitter
        '
        Me.rdkitter.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdkitter.Location = New System.Drawing.Point(251, 11)
        Me.rdkitter.MaxLength = 6
        Me.rdkitter.Name = "rdkitter"
        Me.rdkitter.Size = New System.Drawing.Size(104, 22)
        Me.rdkitter.TabIndex = 45
        Me.rdkitter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'rdreqby
        '
        Me.rdreqby.Enabled = False
        Me.rdreqby.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdreqby.Location = New System.Drawing.Point(80, 11)
        Me.rdreqby.MaxLength = 6
        Me.rdreqby.Name = "rdreqby"
        Me.rdreqby.Size = New System.Drawing.Size(104, 22)
        Me.rdreqby.TabIndex = 47
        Me.rdreqby.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Segoe UI Semibold", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Black
        Me.Label18.Location = New System.Drawing.Point(190, 15)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(55, 12)
        Me.Label18.TabIndex = 44
        Me.Label18.Text = "Prepared by:"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Enabled = False
        Me.Label19.Font = New System.Drawing.Font("Segoe UI Semibold", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.Black
        Me.Label19.Location = New System.Drawing.Point(24, 15)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(52, 12)
        Me.Label19.TabIndex = 46
        Me.Label19.Text = "Request by:"
        '
        'del
        '
        Me.del.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.del.BackColor = System.Drawing.Color.Transparent
        Me.del.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.del.Font = New System.Drawing.Font("Segoe UI", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.del.ForeColor = System.Drawing.SystemColors.Desktop
        Me.del.Image = CType(resources.GetObject("del.Image"), System.Drawing.Image)
        Me.del.Location = New System.Drawing.Point(407, 66)
        Me.del.Name = "del"
        Me.del.Size = New System.Drawing.Size(39, 37)
        Me.del.TabIndex = 43
        Me.del.UseVisualStyleBackColor = False
        '
        'dgvMatOut
        '
        Me.dgvMatOut.AllowDrop = True
        Me.dgvMatOut.AllowUserToAddRows = False
        Me.dgvMatOut.AllowUserToDeleteRows = False
        Me.dgvMatOut.AllowUserToResizeRows = False
        Me.dgvMatOut.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvMatOut.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvMatOut.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvMatOut.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMatOut.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.qty})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvMatOut.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvMatOut.Location = New System.Drawing.Point(26, 66)
        Me.dgvMatOut.Margin = New System.Windows.Forms.Padding(2)
        Me.dgvMatOut.MultiSelect = False
        Me.dgvMatOut.Name = "dgvMatOut"
        Me.dgvMatOut.RowHeadersVisible = False
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvMatOut.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvMatOut.RowTemplate.Height = 24
        Me.dgvMatOut.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvMatOut.Size = New System.Drawing.Size(379, 190)
        Me.dgvMatOut.TabIndex = 6
        '
        'ID
        '
        Me.ID.HeaderText = "Material ID"
        Me.ID.Name = "ID"
        '
        'qty
        '
        Me.qty.HeaderText = "Quantity"
        Me.qty.Name = "qty"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.RadioButton2)
        Me.Panel3.Controls.Add(Me.RadioButton1)
        Me.Panel3.Controls.Add(Me.addmatid)
        Me.Panel3.Controls.Add(Me.matid)
        Me.Panel3.Controls.Add(Me.Label17)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(3, 16)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(481, 45)
        Me.Panel3.TabIndex = 7
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton2.Location = New System.Drawing.Point(23, 23)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(63, 16)
        Me.RadioButton2.TabIndex = 44
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Container"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton1.Location = New System.Drawing.Point(23, 5)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(70, 16)
        Me.RadioButton1.TabIndex = 43
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Batch/Slice"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'addmatid
        '
        Me.addmatid.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.addmatid.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.addmatid.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.addmatid.Font = New System.Drawing.Font("Segoe UI", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addmatid.Location = New System.Drawing.Point(343, 17)
        Me.addmatid.Name = "addmatid"
        Me.addmatid.Size = New System.Drawing.Size(59, 22)
        Me.addmatid.TabIndex = 42
        Me.addmatid.Text = "ADD"
        Me.addmatid.UseVisualStyleBackColor = False
        '
        'matid
        '
        Me.matid.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.matid.Location = New System.Drawing.Point(110, 17)
        Me.matid.Name = "matid"
        Me.matid.Size = New System.Drawing.Size(227, 22)
        Me.matid.TabIndex = 32
        Me.matid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Segoe UI Semibold", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(195, 2)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(64, 12)
        Me.Label17.TabIndex = 31
        Me.Label17.Text = "Input Batch No"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.rdmachine)
        Me.GroupBox3.Controls.Add(Me.Label16)
        Me.GroupBox3.Controls.Add(Me.rdremarks)
        Me.GroupBox3.Controls.Add(Me.Label15)
        Me.GroupBox3.Controls.Add(Me.rdtype)
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Controls.Add(Me.rdreason)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.rdsupplier)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.rddiscription)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.rd_process)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.rdtranslot)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Left
        Me.GroupBox3.Enabled = False
        Me.GroupBox3.Location = New System.Drawing.Point(0, 92)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(379, 407)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Request Details"
        '
        'rdmachine
        '
        Me.rdmachine.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdmachine.Location = New System.Drawing.Point(129, 251)
        Me.rdmachine.Name = "rdmachine"
        Me.rdmachine.Size = New System.Drawing.Size(195, 22)
        Me.rdmachine.TabIndex = 44
        Me.rdmachine.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Segoe UI Semibold", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(45, 255)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(39, 12)
        Me.Label16.TabIndex = 43
        Me.Label16.Text = "Machine"
        '
        'rdremarks
        '
        Me.rdremarks.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdremarks.Location = New System.Drawing.Point(129, 329)
        Me.rdremarks.Multiline = True
        Me.rdremarks.Name = "rdremarks"
        Me.rdremarks.Size = New System.Drawing.Size(195, 33)
        Me.rdremarks.TabIndex = 42
        Me.rdremarks.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Segoe UI Semibold", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(45, 333)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(41, 12)
        Me.Label15.TabIndex = 41
        Me.Label15.Text = "Remarks"
        '
        'rdtype
        '
        Me.rdtype.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdtype.Location = New System.Drawing.Point(129, 68)
        Me.rdtype.Name = "rdtype"
        Me.rdtype.Size = New System.Drawing.Size(195, 22)
        Me.rdtype.TabIndex = 40
        Me.rdtype.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Segoe UI Semibold", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(45, 72)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(25, 12)
        Me.Label14.TabIndex = 39
        Me.Label14.Text = "Type"
        '
        'rdreason
        '
        Me.rdreason.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdreason.Location = New System.Drawing.Point(129, 290)
        Me.rdreason.Name = "rdreason"
        Me.rdreason.Size = New System.Drawing.Size(195, 22)
        Me.rdreason.TabIndex = 38
        Me.rdreason.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI Semibold", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(45, 294)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(35, 12)
        Me.Label8.TabIndex = 37
        Me.Label8.Text = "Reason"
        '
        'rdsupplier
        '
        Me.rdsupplier.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdsupplier.Location = New System.Drawing.Point(129, 211)
        Me.rdsupplier.Name = "rdsupplier"
        Me.rdsupplier.Size = New System.Drawing.Size(195, 22)
        Me.rdsupplier.TabIndex = 36
        Me.rdsupplier.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI Semibold", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(45, 215)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(37, 12)
        Me.Label7.TabIndex = 35
        Me.Label7.Text = "Supplier"
        '
        'rddiscription
        '
        Me.rddiscription.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rddiscription.Location = New System.Drawing.Point(129, 147)
        Me.rddiscription.Multiline = True
        Me.rddiscription.Name = "rddiscription"
        Me.rddiscription.Size = New System.Drawing.Size(195, 48)
        Me.rddiscription.TabIndex = 34
        Me.rddiscription.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Semibold", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(45, 151)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(81, 12)
        Me.Label6.TabIndex = 33
        Me.Label6.Text = "Material Discription"
        '
        'rd_process
        '
        Me.rd_process.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rd_process.Location = New System.Drawing.Point(129, 106)
        Me.rd_process.Name = "rd_process"
        Me.rd_process.Size = New System.Drawing.Size(195, 22)
        Me.rd_process.TabIndex = 32
        Me.rd_process.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(45, 110)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(35, 12)
        Me.Label5.TabIndex = 31
        Me.Label5.Text = "Process"
        '
        'rdtranslot
        '
        Me.rdtranslot.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdtranslot.Location = New System.Drawing.Point(129, 27)
        Me.rdtranslot.Name = "rdtranslot"
        Me.rdtranslot.Size = New System.Drawing.Size(195, 22)
        Me.rdtranslot.TabIndex = 30
        Me.rdtranslot.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(45, 31)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 12)
        Me.Label4.TabIndex = 29
        Me.Label4.Text = "Transaction Lot"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel2.Controls.Add(Me.TableLayoutPanel2)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 499)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(866, 61)
        Me.Panel2.TabIndex = 3
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 5
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.r_recieved, 4, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.r_withdrawn, 3, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.r_available, 2, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.r_edit, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.r_cancel, 0, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(866, 61)
        Me.TableLayoutPanel2.TabIndex = 0
        '
        'r_recieved
        '
        Me.r_recieved.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.r_recieved.BackColor = System.Drawing.Color.Transparent
        Me.r_recieved.Enabled = False
        Me.r_recieved.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.r_recieved.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.r_recieved.ForeColor = System.Drawing.Color.White
        Me.r_recieved.Location = New System.Drawing.Point(701, 10)
        Me.r_recieved.Name = "r_recieved"
        Me.r_recieved.Size = New System.Drawing.Size(155, 40)
        Me.r_recieved.TabIndex = 41
        Me.r_recieved.Text = "RECIEVED"
        Me.r_recieved.UseVisualStyleBackColor = False
        '
        'r_withdrawn
        '
        Me.r_withdrawn.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.r_withdrawn.BackColor = System.Drawing.Color.Transparent
        Me.r_withdrawn.Enabled = False
        Me.r_withdrawn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.r_withdrawn.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.r_withdrawn.ForeColor = System.Drawing.Color.White
        Me.r_withdrawn.Location = New System.Drawing.Point(530, 10)
        Me.r_withdrawn.Name = "r_withdrawn"
        Me.r_withdrawn.Size = New System.Drawing.Size(151, 40)
        Me.r_withdrawn.TabIndex = 42
        Me.r_withdrawn.Text = "WITHDRAWN"
        Me.r_withdrawn.UseVisualStyleBackColor = False
        '
        'r_available
        '
        Me.r_available.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.r_available.BackColor = System.Drawing.Color.Transparent
        Me.r_available.Enabled = False
        Me.r_available.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.r_available.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.r_available.ForeColor = System.Drawing.Color.White
        Me.r_available.Location = New System.Drawing.Point(357, 10)
        Me.r_available.Name = "r_available"
        Me.r_available.Size = New System.Drawing.Size(151, 40)
        Me.r_available.TabIndex = 43
        Me.r_available.Text = "AVAILABLE"
        Me.r_available.UseVisualStyleBackColor = False
        '
        'r_edit
        '
        Me.r_edit.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.r_edit.BackColor = System.Drawing.Color.Blue
        Me.r_edit.Enabled = False
        Me.r_edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.r_edit.Font = New System.Drawing.Font("Segoe UI", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.r_edit.ForeColor = System.Drawing.Color.White
        Me.r_edit.Location = New System.Drawing.Point(176, 20)
        Me.r_edit.Name = "r_edit"
        Me.r_edit.Size = New System.Drawing.Size(48, 21)
        Me.r_edit.TabIndex = 44
        Me.r_edit.Text = "Edit"
        Me.r_edit.UseVisualStyleBackColor = False
        '
        'r_cancel
        '
        Me.r_cancel.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.r_cancel.BackColor = System.Drawing.Color.Red
        Me.r_cancel.Enabled = False
        Me.r_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.r_cancel.Font = New System.Drawing.Font("Segoe UI", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.r_cancel.ForeColor = System.Drawing.Color.White
        Me.r_cancel.Location = New System.Drawing.Point(72, 20)
        Me.r_cancel.Name = "r_cancel"
        Me.r_cancel.Size = New System.Drawing.Size(98, 21)
        Me.r_cancel.TabIndex = 45
        Me.r_cancel.Text = "Cancel Transaction"
        Me.r_cancel.UseVisualStyleBackColor = False
        '
        'isspnl
        '
        Me.isspnl.Controls.Add(Me.issuedby)
        Me.isspnl.Controls.Add(Me.issuedto)
        Me.isspnl.Controls.Add(Me.Label20)
        Me.isspnl.Controls.Add(Me.Label21)
        Me.isspnl.Enabled = False
        Me.isspnl.Font = New System.Drawing.Font("Segoe UI", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.isspnl.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.isspnl.Location = New System.Drawing.Point(405, 410)
        Me.isspnl.Name = "isspnl"
        Me.isspnl.Size = New System.Drawing.Size(379, 39)
        Me.isspnl.TabIndex = 49
        Me.isspnl.TabStop = False
        Me.isspnl.Text = "Issuance"
        '
        'issuedby
        '
        Me.issuedby.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.issuedby.Location = New System.Drawing.Point(251, 11)
        Me.issuedby.MaxLength = 6
        Me.issuedby.Name = "issuedby"
        Me.issuedby.Size = New System.Drawing.Size(104, 22)
        Me.issuedby.TabIndex = 45
        Me.issuedby.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'issuedto
        '
        Me.issuedto.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.issuedto.Location = New System.Drawing.Point(80, 11)
        Me.issuedto.MaxLength = 6
        Me.issuedto.Name = "issuedto"
        Me.issuedto.Size = New System.Drawing.Size(104, 22)
        Me.issuedto.TabIndex = 47
        Me.issuedto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Segoe UI Semibold", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.Black
        Me.Label20.Location = New System.Drawing.Point(200, 15)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(45, 12)
        Me.Label20.TabIndex = 44
        Me.Label20.Text = "Issued by:"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Enabled = False
        Me.Label21.Font = New System.Drawing.Font("Segoe UI Semibold", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.Black
        Me.Label21.Location = New System.Drawing.Point(31, 15)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(43, 12)
        Me.Label21.TabIndex = 46
        Me.Label21.Text = "Issued to:"
        '
        'n2pnl
        '
        Me.n2pnl.Controls.Add(Me.n2Location)
        Me.n2pnl.Controls.Add(Me.Label23)
        Me.n2pnl.Font = New System.Drawing.Font("Segoe UI", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.n2pnl.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.n2pnl.Location = New System.Drawing.Point(405, 454)
        Me.n2pnl.Name = "n2pnl"
        Me.n2pnl.Size = New System.Drawing.Size(379, 39)
        Me.n2pnl.TabIndex = 50
        Me.n2pnl.TabStop = False
        Me.n2pnl.Text = "N2 LOCATION"
        Me.n2pnl.Visible = False
        '
        'n2Location
        '
        Me.n2Location.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.n2Location.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.n2Location.FormattingEnabled = True
        Me.n2Location.Location = New System.Drawing.Point(80, 11)
        Me.n2Location.Name = "n2Location"
        Me.n2Location.Size = New System.Drawing.Size(275, 21)
        Me.n2Location.TabIndex = 47
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Enabled = False
        Me.Label23.Font = New System.Drawing.Font("Segoe UI Semibold", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.Black
        Me.Label23.Location = New System.Drawing.Point(49, 15)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(21, 12)
        Me.Label23.TabIndex = 46
        Me.Label23.Text = "N2 :"
        '
        'RawTransaction
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(866, 560)
        Me.Controls.Add(Me.n2pnl)
        Me.Controls.Add(Me.isspnl)
        Me.Controls.Add(Me.MatOutPnl)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "RawTransaction"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Raw Transaction"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.MatOutPnl.ResumeLayout(False)
        Me.preppnl.ResumeLayout(False)
        Me.preppnl.PerformLayout()
        CType(Me.dgvMatOut, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.isspnl.ResumeLayout(False)
        Me.isspnl.PerformLayout()
        Me.n2pnl.ResumeLayout(False)
        Me.n2pnl.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents r_bin As Label
    Friend WithEvents r_qty As Label
    Friend WithEvents r_supplier As Label
    Friend WithEvents r_matcode As Label
    Friend WithEvents r_type As Label
    Friend WithEvents r_product As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents MainStatus As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents RequestID As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents MatOutPnl As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents dgvMatOut As DataGridView
    Friend WithEvents r_recieved As Button
    Friend WithEvents rdremarks As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents rdtype As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents rdreason As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents rdsupplier As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents rddiscription As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents rd_process As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents rdtranslot As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents rdmachine As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents addmatid As Button
    Friend WithEvents matid As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents del As Button
    Friend WithEvents ID As DataGridViewTextBoxColumn
    Friend WithEvents qty As DataGridViewTextBoxColumn
    Friend WithEvents rdreqby As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents rdkitter As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents r_cancel As Button
    Friend WithEvents r_withdrawn As Button
    Friend WithEvents r_available As Button
    Friend WithEvents r_edit As Button
    Friend WithEvents isspnl As GroupBox
    Friend WithEvents issuedby As TextBox
    Friend WithEvents issuedto As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents preppnl As GroupBox
    Friend WithEvents n2pnl As GroupBox
    Friend WithEvents n2Location As ComboBox
    Friend WithEvents Label23 As Label
End Class
