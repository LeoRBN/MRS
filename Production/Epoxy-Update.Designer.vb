<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Epoxy_Update
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Epoxy_Update))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.mainStatus = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.e_close = New System.Windows.Forms.Button()
        Me.e_save = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.e_reqBy = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.e_dateReq = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.e_process = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.e_type = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.e_retBy = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.e_updateBy = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.e_matcode = New System.Windows.Forms.Label()
        Me.e_machine = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.e_package = New System.Windows.Forms.Label()
        Me.e_batch = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.offpnl = New System.Windows.Forms.Panel()
        Me.e_remarks = New System.Windows.Forms.ComboBox()
        Me.e_reasonCode = New System.Windows.Forms.ComboBox()
        Me.requestID = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.retPnl = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.offpnl.SuspendLayout()
        Me.retPnl.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.mainStatus)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(402, 45)
        Me.Panel1.TabIndex = 0
        '
        'Label10
        '
        Me.Label10.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(7, 15)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(59, 17)
        Me.Label10.TabIndex = 4
        Me.Label10.Text = "STATUS :"
        '
        'mainStatus
        '
        Me.mainStatus.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.mainStatus.AutoSize = True
        Me.mainStatus.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mainStatus.ForeColor = System.Drawing.Color.Yellow
        Me.mainStatus.Location = New System.Drawing.Point(67, 7)
        Me.mainStatus.Name = "mainStatus"
        Me.mainStatus.Size = New System.Drawing.Size(143, 30)
        Me.mainStatus.TabIndex = 3
        Me.mainStatus.Text = "FOR RETURN"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel2.Controls.Add(Me.TableLayoutPanel2)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 513)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(402, 51)
        Me.Panel2.TabIndex = 1
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.e_close, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.e_save, 0, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(402, 51)
        Me.TableLayoutPanel2.TabIndex = 0
        '
        'e_close
        '
        Me.e_close.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.e_close.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.e_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.e_close.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.e_close.ForeColor = System.Drawing.Color.White
        Me.e_close.Location = New System.Drawing.Point(224, 10)
        Me.e_close.Margin = New System.Windows.Forms.Padding(0)
        Me.e_close.Name = "e_close"
        Me.e_close.Size = New System.Drawing.Size(154, 30)
        Me.e_close.TabIndex = 65
        Me.e_close.Text = "CLOSE"
        Me.e_close.UseVisualStyleBackColor = False
        '
        'e_save
        '
        Me.e_save.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.e_save.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.e_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.e_save.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.e_save.ForeColor = System.Drawing.Color.White
        Me.e_save.Location = New System.Drawing.Point(23, 10)
        Me.e_save.Margin = New System.Windows.Forms.Padding(0)
        Me.e_save.Name = "e_save"
        Me.e_save.Size = New System.Drawing.Size(154, 30)
        Me.e_save.TabIndex = 64
        Me.e_save.Text = "SAVE"
        Me.e_save.UseVisualStyleBackColor = False
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.e_reqBy)
        Me.Panel3.Controls.Add(Me.Label11)
        Me.Panel3.Controls.Add(Me.e_dateReq)
        Me.Panel3.Controls.Add(Me.Label8)
        Me.Panel3.Controls.Add(Me.e_process)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.e_type)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Enabled = False
        Me.Panel3.Location = New System.Drawing.Point(2, 140)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(400, 158)
        Me.Panel3.TabIndex = 24
        '
        'e_reqBy
        '
        Me.e_reqBy.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.e_reqBy.Location = New System.Drawing.Point(132, 127)
        Me.e_reqBy.Name = "e_reqBy"
        Me.e_reqBy.Size = New System.Drawing.Size(244, 25)
        Me.e_reqBy.TabIndex = 12
        Me.e_reqBy.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(15, 130)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(76, 17)
        Me.Label11.TabIndex = 11
        Me.Label11.Text = "Request By"
        '
        'e_dateReq
        '
        Me.e_dateReq.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.e_dateReq.Location = New System.Drawing.Point(132, 87)
        Me.e_dateReq.Name = "e_dateReq"
        Me.e_dateReq.Size = New System.Drawing.Size(244, 25)
        Me.e_dateReq.TabIndex = 10
        Me.e_dateReq.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(15, 90)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(104, 17)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "Date Requested"
        '
        'e_process
        '
        Me.e_process.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.e_process.Location = New System.Drawing.Point(132, 46)
        Me.e_process.Name = "e_process"
        Me.e_process.Size = New System.Drawing.Size(244, 25)
        Me.e_process.TabIndex = 8
        Me.e_process.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(15, 49)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 17)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Process"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'e_type
        '
        Me.e_type.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.e_type.Location = New System.Drawing.Point(132, 9)
        Me.e_type.Name = "e_type"
        Me.e_type.Size = New System.Drawing.Size(244, 25)
        Me.e_type.TabIndex = 6
        Me.e_type.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(15, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 17)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Material"
        '
        'e_retBy
        '
        Me.e_retBy.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.e_retBy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.e_retBy.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.e_retBy.Location = New System.Drawing.Point(132, 3)
        Me.e_retBy.MaxLength = 6
        Me.e_retBy.Name = "e_retBy"
        Me.e_retBy.Size = New System.Drawing.Size(245, 25)
        Me.e_retBy.TabIndex = 20
        Me.e_retBy.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label15
        '
        Me.Label15.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Black
        Me.Label15.Location = New System.Drawing.Point(14, 6)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(68, 17)
        Me.Label15.TabIndex = 19
        Me.Label15.Text = "Return By"
        '
        'e_updateBy
        '
        Me.e_updateBy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.e_updateBy.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.e_updateBy.Location = New System.Drawing.Point(132, 90)
        Me.e_updateBy.MaxLength = 6
        Me.e_updateBy.Name = "e_updateBy"
        Me.e_updateBy.Size = New System.Drawing.Size(244, 25)
        Me.e_updateBy.TabIndex = 18
        Me.e_updateBy.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(14, 93)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(79, 17)
        Me.Label14.TabIndex = 17
        Me.Label14.Text = "Updated By"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.LightYellow
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Label18, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Label17, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Label9, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.e_matcode, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.e_machine, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.e_package, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.e_batch, 1, 2)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 45)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 4
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(402, 89)
        Me.TableLayoutPanel1.TabIndex = 25
        '
        'Label18
        '
        Me.Label18.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Segoe UI", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Black
        Me.Label18.Location = New System.Drawing.Point(281, 76)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(41, 12)
        Me.Label18.TabIndex = 32
        Me.Label18.Text = "Batch No"
        '
        'Label17
        '
        Me.Label17.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Segoe UI", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Black
        Me.Label17.Location = New System.Drawing.Point(80, 76)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(40, 12)
        Me.Label17.TabIndex = 31
        Me.Label17.Text = "Matcode"
        '
        'Label9
        '
        Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(282, 31)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(39, 12)
        Me.Label9.TabIndex = 30
        Me.Label9.Text = "Machine"
        '
        'e_matcode
        '
        Me.e_matcode.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.e_matcode.AutoSize = True
        Me.e_matcode.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.e_matcode.ForeColor = System.Drawing.Color.Blue
        Me.e_matcode.Location = New System.Drawing.Point(57, 54)
        Me.e_matcode.Margin = New System.Windows.Forms.Padding(0)
        Me.e_matcode.Name = "e_matcode"
        Me.e_matcode.Size = New System.Drawing.Size(86, 21)
        Me.e_matcode.TabIndex = 29
        Me.e_matcode.Text = "5HY20069"
        Me.e_matcode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'e_machine
        '
        Me.e_machine.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.e_machine.AutoSize = True
        Me.e_machine.BackColor = System.Drawing.Color.Transparent
        Me.e_machine.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.e_machine.ForeColor = System.Drawing.Color.Blue
        Me.e_machine.Location = New System.Drawing.Point(272, 10)
        Me.e_machine.Margin = New System.Windows.Forms.Padding(0)
        Me.e_machine.Name = "e_machine"
        Me.e_machine.Size = New System.Drawing.Size(59, 21)
        Me.e_machine.TabIndex = 27
        Me.e_machine.Text = "BCA19"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(83, 31)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 12)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "Product"
        '
        'e_package
        '
        Me.e_package.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.e_package.AutoSize = True
        Me.e_package.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.e_package.ForeColor = System.Drawing.Color.Blue
        Me.e_package.Location = New System.Drawing.Point(60, 10)
        Me.e_package.Margin = New System.Windows.Forms.Padding(0)
        Me.e_package.Name = "e_package"
        Me.e_package.Size = New System.Drawing.Size(81, 21)
        Me.e_package.TabIndex = 0
        Me.e_package.Text = "DOPPLER"
        Me.e_package.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'e_batch
        '
        Me.e_batch.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.e_batch.AutoSize = True
        Me.e_batch.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.e_batch.ForeColor = System.Drawing.Color.Blue
        Me.e_batch.Location = New System.Drawing.Point(251, 54)
        Me.e_batch.Margin = New System.Windows.Forms.Padding(0)
        Me.e_batch.Name = "e_batch"
        Me.e_batch.Size = New System.Drawing.Size(101, 21)
        Me.e_batch.TabIndex = 28
        Me.e_batch.Text = "8B43252354"
        Me.e_batch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(15, 11)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(87, 17)
        Me.Label12.TabIndex = 23
        Me.Label12.Text = "Reason Code"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(15, 51)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(60, 17)
        Me.Label13.TabIndex = 24
        Me.Label13.Text = "Remarks"
        '
        'offpnl
        '
        Me.offpnl.Controls.Add(Me.e_remarks)
        Me.offpnl.Controls.Add(Me.e_reasonCode)
        Me.offpnl.Controls.Add(Me.Label13)
        Me.offpnl.Controls.Add(Me.Label12)
        Me.offpnl.Controls.Add(Me.e_updateBy)
        Me.offpnl.Controls.Add(Me.Label14)
        Me.offpnl.Location = New System.Drawing.Point(2, 312)
        Me.offpnl.Name = "offpnl"
        Me.offpnl.Size = New System.Drawing.Size(400, 121)
        Me.offpnl.TabIndex = 25
        '
        'e_remarks
        '
        Me.e_remarks.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.e_remarks.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.e_remarks.Enabled = False
        Me.e_remarks.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.e_remarks.FormattingEnabled = True
        Me.e_remarks.Location = New System.Drawing.Point(132, 48)
        Me.e_remarks.Name = "e_remarks"
        Me.e_remarks.Size = New System.Drawing.Size(244, 25)
        Me.e_remarks.TabIndex = 26
        '
        'e_reasonCode
        '
        Me.e_reasonCode.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.e_reasonCode.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.e_reasonCode.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.e_reasonCode.FormattingEnabled = True
        Me.e_reasonCode.Location = New System.Drawing.Point(132, 8)
        Me.e_reasonCode.Name = "e_reasonCode"
        Me.e_reasonCode.Size = New System.Drawing.Size(244, 25)
        Me.e_reasonCode.TabIndex = 25
        '
        'requestID
        '
        Me.requestID.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.requestID.AutoSize = True
        Me.requestID.Font = New System.Drawing.Font("Segoe UI", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.requestID.ForeColor = System.Drawing.Color.Black
        Me.requestID.Location = New System.Drawing.Point(78, 500)
        Me.requestID.Name = "requestID"
        Me.requestID.Size = New System.Drawing.Size(18, 11)
        Me.requestID.TabIndex = 27
        Me.requestID.Text = "- - -"
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(21, 500)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 11)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "Request ID :"
        '
        'retPnl
        '
        Me.retPnl.Controls.Add(Me.e_retBy)
        Me.retPnl.Controls.Add(Me.Label15)
        Me.retPnl.Location = New System.Drawing.Point(2, 456)
        Me.retPnl.Name = "retPnl"
        Me.retPnl.Size = New System.Drawing.Size(400, 31)
        Me.retPnl.TabIndex = 28
        '
        'Epoxy_Update
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(402, 564)
        Me.Controls.Add(Me.offpnl)
        Me.Controls.Add(Me.retPnl)
        Me.Controls.Add(Me.requestID)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Epoxy_Update"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "UPDATE EPOXY"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.offpnl.ResumeLayout(False)
        Me.offpnl.PerformLayout()
        Me.retPnl.ResumeLayout(False)
        Me.retPnl.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents e_retBy As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents e_updateBy As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents e_reqBy As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents e_dateReq As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents e_process As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents e_type As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents mainStatus As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Label18 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents e_matcode As Label
    Friend WithEvents e_machine As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents e_package As Label
    Friend WithEvents e_batch As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents offpnl As Panel
    Friend WithEvents e_save As Button
    Friend WithEvents e_close As Button
    Friend WithEvents requestID As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents retPnl As Panel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents e_remarks As ComboBox
    Friend WithEvents e_reasonCode As ComboBox
End Class
