<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IDM_Req
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(IDM_Req))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.SendReq = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.reqpnl = New System.Windows.Forms.Panel()
        Me.Uom = New System.Windows.Forms.TextBox()
        Me.subMC = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.reqBy = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.remarks = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.itemdata = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.stock = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Supplier = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.discription = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.process = New System.Windows.Forms.ComboBox()
        Me.kitterpnl = New System.Windows.Forms.Panel()
        Me.Uom2 = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.kitter = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.mcList = New System.Windows.Forms.CheckedListBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.UID = New System.Windows.Forms.Label()
        Me.mainStatus = New System.Windows.Forms.Label()
        Me.TYPE = New System.Windows.Forms.Label()
        Me.matCode = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.reqQty = New System.Windows.Forms.TextBox()
        Me.issQty = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.reqpnl.SuspendLayout()
        Me.itemdata.SuspendLayout()
        Me.kitterpnl.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel1.Controls.Add(Me.SendReq)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 453)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(383, 51)
        Me.Panel1.TabIndex = 1
        '
        'SendReq
        '
        Me.SendReq.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.SendReq.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.SendReq.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SendReq.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SendReq.Location = New System.Drawing.Point(109, 10)
        Me.SendReq.Name = "SendReq"
        Me.SendReq.Size = New System.Drawing.Size(186, 31)
        Me.SendReq.TabIndex = 41
        Me.SendReq.Text = "SEND REQUEST"
        Me.SendReq.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.reqpnl)
        Me.Panel2.Controls.Add(Me.itemdata)
        Me.Panel2.Controls.Add(Me.process)
        Me.Panel2.Controls.Add(Me.kitterpnl)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.mcList)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 53)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(383, 400)
        Me.Panel2.TabIndex = 2
        '
        'reqpnl
        '
        Me.reqpnl.Controls.Add(Me.reqQty)
        Me.reqpnl.Controls.Add(Me.Uom)
        Me.reqpnl.Controls.Add(Me.subMC)
        Me.reqpnl.Controls.Add(Me.Label10)
        Me.reqpnl.Controls.Add(Me.Label8)
        Me.reqpnl.Controls.Add(Me.reqBy)
        Me.reqpnl.Controls.Add(Me.Label7)
        Me.reqpnl.Controls.Add(Me.remarks)
        Me.reqpnl.Controls.Add(Me.Label2)
        Me.reqpnl.Location = New System.Drawing.Point(5, 104)
        Me.reqpnl.Name = "reqpnl"
        Me.reqpnl.Size = New System.Drawing.Size(377, 198)
        Me.reqpnl.TabIndex = 31
        '
        'Uom
        '
        Me.Uom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Uom.Enabled = False
        Me.Uom.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Uom.Location = New System.Drawing.Point(295, 65)
        Me.Uom.Name = "Uom"
        Me.Uom.Size = New System.Drawing.Size(73, 23)
        Me.Uom.TabIndex = 11
        Me.Uom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'subMC
        '
        Me.subMC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.subMC.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.subMC.ForeColor = System.Drawing.Color.Red
        Me.subMC.Location = New System.Drawing.Point(83, 22)
        Me.subMC.Name = "subMC"
        Me.subMC.Size = New System.Drawing.Size(284, 23)
        Me.subMC.TabIndex = 12
        Me.subMC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(2, 68)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(58, 13)
        Me.Label10.TabIndex = 20
        Me.Label10.Text = "QUANTITY"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Enabled = False
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(2, 25)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(56, 13)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "MACHINE"
        '
        'reqBy
        '
        Me.reqBy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.reqBy.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.reqBy.Location = New System.Drawing.Point(84, 163)
        Me.reqBy.MaxLength = 6
        Me.reqBy.Name = "reqBy"
        Me.reqBy.Size = New System.Drawing.Size(284, 23)
        Me.reqBy.TabIndex = 16
        Me.reqBy.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(2, 167)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(68, 13)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "REQUEST BY"
        '
        'remarks
        '
        Me.remarks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.remarks.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.remarks.Location = New System.Drawing.Point(84, 97)
        Me.remarks.Multiline = True
        Me.remarks.Name = "remarks"
        Me.remarks.Size = New System.Drawing.Size(284, 56)
        Me.remarks.TabIndex = 14
        Me.remarks.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(2, 97)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 13)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "REMARKS"
        '
        'itemdata
        '
        Me.itemdata.Controls.Add(Me.Label6)
        Me.itemdata.Controls.Add(Me.stock)
        Me.itemdata.Controls.Add(Me.Label5)
        Me.itemdata.Controls.Add(Me.Supplier)
        Me.itemdata.Controls.Add(Me.Label4)
        Me.itemdata.Controls.Add(Me.discription)
        Me.itemdata.Controls.Add(Me.Label3)
        Me.itemdata.Location = New System.Drawing.Point(3, 6)
        Me.itemdata.Name = "itemdata"
        Me.itemdata.Size = New System.Drawing.Size(378, 93)
        Me.itemdata.TabIndex = 30
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Enabled = False
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(237, 98)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(32, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "UoM"
        Me.Label6.Visible = False
        '
        'stock
        '
        Me.stock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.stock.Enabled = False
        Me.stock.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.stock.Location = New System.Drawing.Point(84, 94)
        Me.stock.Name = "stock"
        Me.stock.Size = New System.Drawing.Size(147, 23)
        Me.stock.TabIndex = 9
        Me.stock.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.stock.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Enabled = False
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(2, 98)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(62, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "STOCK QTY"
        Me.Label5.Visible = False
        '
        'Supplier
        '
        Me.Supplier.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Supplier.Enabled = False
        Me.Supplier.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Supplier.Location = New System.Drawing.Point(84, 64)
        Me.Supplier.Name = "Supplier"
        Me.Supplier.Size = New System.Drawing.Size(284, 23)
        Me.Supplier.TabIndex = 7
        Me.Supplier.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Enabled = False
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(2, 68)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "SUPPLIER"
        '
        'discription
        '
        Me.discription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.discription.Enabled = False
        Me.discription.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.discription.Location = New System.Drawing.Point(84, 8)
        Me.discription.Multiline = True
        Me.discription.Name = "discription"
        Me.discription.Size = New System.Drawing.Size(284, 48)
        Me.discription.TabIndex = 5
        Me.discription.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Enabled = False
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(2, 12)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "DESCRIPTION"
        '
        'process
        '
        Me.process.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.process.Enabled = False
        Me.process.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.process.FormattingEnabled = True
        Me.process.Location = New System.Drawing.Point(87, 106)
        Me.process.Name = "process"
        Me.process.Size = New System.Drawing.Size(284, 23)
        Me.process.TabIndex = 17
        Me.process.Visible = False
        '
        'kitterpnl
        '
        Me.kitterpnl.Controls.Add(Me.issQty)
        Me.kitterpnl.Controls.Add(Me.Uom2)
        Me.kitterpnl.Controls.Add(Me.Label12)
        Me.kitterpnl.Controls.Add(Me.kitter)
        Me.kitterpnl.Controls.Add(Me.Label11)
        Me.kitterpnl.Location = New System.Drawing.Point(5, 304)
        Me.kitterpnl.Name = "kitterpnl"
        Me.kitterpnl.Size = New System.Drawing.Size(377, 74)
        Me.kitterpnl.TabIndex = 28
        Me.kitterpnl.Visible = False
        '
        'Uom2
        '
        Me.Uom2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Uom2.Enabled = False
        Me.Uom2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Uom2.Location = New System.Drawing.Point(295, 48)
        Me.Uom2.Name = "Uom2"
        Me.Uom2.Size = New System.Drawing.Size(73, 23)
        Me.Uom2.TabIndex = 28
        Me.Uom2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(2, 51)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(58, 13)
        Me.Label12.TabIndex = 25
        Me.Label12.Text = "QUANTITY"
        '
        'kitter
        '
        Me.kitter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.kitter.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.kitter.Location = New System.Drawing.Point(84, 19)
        Me.kitter.MaxLength = 6
        Me.kitter.Name = "kitter"
        Me.kitter.Size = New System.Drawing.Size(284, 23)
        Me.kitter.TabIndex = 24
        Me.kitter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(2, 23)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(41, 13)
        Me.Label11.TabIndex = 23
        Me.Label11.Text = "KITTER"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Enabled = False
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(5, 110)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(54, 13)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "PROCESS"
        Me.Label9.Visible = False
        '
        'mcList
        '
        Me.mcList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.mcList.CheckOnClick = True
        Me.mcList.Enabled = False
        Me.mcList.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mcList.FormattingEnabled = True
        Me.mcList.Location = New System.Drawing.Point(87, 135)
        Me.mcList.MultiColumn = True
        Me.mcList.Name = "mcList"
        Me.mcList.Size = New System.Drawing.Size(284, 87)
        Me.mcList.TabIndex = 18
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel3.Controls.Add(Me.UID)
        Me.Panel3.Controls.Add(Me.mainStatus)
        Me.Panel3.Controls.Add(Me.TYPE)
        Me.Panel3.Controls.Add(Me.matCode)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(383, 53)
        Me.Panel3.TabIndex = 3
        '
        'UID
        '
        Me.UID.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.UID.AutoSize = True
        Me.UID.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UID.ForeColor = System.Drawing.Color.Cyan
        Me.UID.Location = New System.Drawing.Point(295, 28)
        Me.UID.Name = "UID"
        Me.UID.Size = New System.Drawing.Size(85, 13)
        Me.UID.TabIndex = 8
        Me.UID.Text = "<Dont Delete>"
        Me.UID.Visible = False
        '
        'mainStatus
        '
        Me.mainStatus.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.mainStatus.AutoSize = True
        Me.mainStatus.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mainStatus.ForeColor = System.Drawing.Color.Cyan
        Me.mainStatus.Location = New System.Drawing.Point(295, 9)
        Me.mainStatus.Name = "mainStatus"
        Me.mainStatus.Size = New System.Drawing.Size(85, 13)
        Me.mainStatus.TabIndex = 7
        Me.mainStatus.Text = "<Dont Delete>"
        Me.mainStatus.Visible = False
        '
        'TYPE
        '
        Me.TYPE.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.TYPE.AutoSize = True
        Me.TYPE.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TYPE.ForeColor = System.Drawing.Color.Cyan
        Me.TYPE.Location = New System.Drawing.Point(91, 32)
        Me.TYPE.Name = "TYPE"
        Me.TYPE.Size = New System.Drawing.Size(28, 13)
        Me.TYPE.TabIndex = 6
        Me.TYPE.Text = "- - - "
        '
        'matCode
        '
        Me.matCode.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.matCode.AutoSize = True
        Me.matCode.Font = New System.Drawing.Font("Segoe UI Black", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.matCode.ForeColor = System.Drawing.Color.Yellow
        Me.matCode.Location = New System.Drawing.Point(89, 2)
        Me.matCode.Name = "matCode"
        Me.matCode.Size = New System.Drawing.Size(52, 30)
        Me.matCode.TabIndex = 4
        Me.matCode.Text = "- - -"
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(12, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "MATCODE :"
        '
        'reqQty
        '
        Me.reqQty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.reqQty.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.reqQty.Location = New System.Drawing.Point(82, 65)
        Me.reqQty.Name = "reqQty"
        Me.reqQty.Size = New System.Drawing.Size(208, 23)
        Me.reqQty.TabIndex = 28
        Me.reqQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'issQty
        '
        Me.issQty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.issQty.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.issQty.Location = New System.Drawing.Point(83, 48)
        Me.issQty.Name = "issQty"
        Me.issQty.Size = New System.Drawing.Size(208, 23)
        Me.issQty.TabIndex = 29
        Me.issQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'IDM_Req
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(383, 504)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "IDM_Req"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "IDM_Req"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.reqpnl.ResumeLayout(False)
        Me.reqpnl.PerformLayout()
        Me.itemdata.ResumeLayout(False)
        Me.itemdata.PerformLayout()
        Me.kitterpnl.ResumeLayout(False)
        Me.kitterpnl.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label9 As Label
    Friend WithEvents reqBy As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents remarks As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Uom As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents stock As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Supplier As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents discription As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents matCode As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents SendReq As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents mcList As CheckedListBox
    Friend WithEvents process As ComboBox
    Friend WithEvents kitterpnl As Panel
    Friend WithEvents Label12 As Label
    Friend WithEvents kitter As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents TYPE As Label
    Friend WithEvents reqpnl As Panel
    Friend WithEvents itemdata As Panel
    Friend WithEvents subMC As TextBox
    Friend WithEvents mainStatus As Label
    Friend WithEvents UID As Label
    Friend WithEvents Uom2 As TextBox
    Friend WithEvents reqQty As TextBox
    Friend WithEvents issQty As TextBox
End Class
