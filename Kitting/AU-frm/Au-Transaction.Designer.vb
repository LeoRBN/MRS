<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Au_Transaction
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Au_Transaction))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.UID = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MainStatus = New System.Windows.Forms.Label()
        Me.newPnl = New System.Windows.Forms.Panel()
        Me.machine = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lotid = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.package = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.spool = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.PrepPnl = New System.Windows.Forms.Panel()
        Me.currentLength = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.kitter = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.IssuePnl = New System.Windows.Forms.Panel()
        Me.IssuedTo = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.g_send = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.retPnl = New System.Windows.Forms.Panel()
        Me.g_remarks = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.retto = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.retby = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.consumed = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.newPnl.SuspendLayout()
        Me.PrepPnl.SuspendLayout()
        Me.IssuePnl.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.retPnl.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel1.Controls.Add(Me.UID)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.MainStatus)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(409, 63)
        Me.Panel1.TabIndex = 0
        '
        'UID
        '
        Me.UID.AutoSize = True
        Me.UID.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UID.ForeColor = System.Drawing.Color.Cyan
        Me.UID.Location = New System.Drawing.Point(69, 35)
        Me.UID.Name = "UID"
        Me.UID.Size = New System.Drawing.Size(28, 15)
        Me.UID.TabIndex = 3
        Me.UID.Text = "- - -"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(35, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(23, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "ID:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(12, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 15)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Status :"
        '
        'MainStatus
        '
        Me.MainStatus.AutoSize = True
        Me.MainStatus.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainStatus.ForeColor = System.Drawing.Color.Yellow
        Me.MainStatus.Location = New System.Drawing.Point(68, 15)
        Me.MainStatus.Name = "MainStatus"
        Me.MainStatus.Size = New System.Drawing.Size(36, 21)
        Me.MainStatus.TabIndex = 0
        Me.MainStatus.Text = "- - -"
        '
        'newPnl
        '
        Me.newPnl.BackColor = System.Drawing.Color.Transparent
        Me.newPnl.Controls.Add(Me.machine)
        Me.newPnl.Controls.Add(Me.Label5)
        Me.newPnl.Controls.Add(Me.lotid)
        Me.newPnl.Controls.Add(Me.Label4)
        Me.newPnl.Controls.Add(Me.package)
        Me.newPnl.Controls.Add(Me.Label3)
        Me.newPnl.Dock = System.Windows.Forms.DockStyle.Top
        Me.newPnl.Enabled = False
        Me.newPnl.Location = New System.Drawing.Point(0, 63)
        Me.newPnl.Name = "newPnl"
        Me.newPnl.Size = New System.Drawing.Size(409, 128)
        Me.newPnl.TabIndex = 1
        '
        'machine
        '
        Me.machine.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.machine.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.machine.Location = New System.Drawing.Point(128, 61)
        Me.machine.Name = "machine"
        Me.machine.Size = New System.Drawing.Size(244, 25)
        Me.machine.TabIndex = 59
        Me.machine.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(35, 67)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(85, 13)
        Me.Label5.TabIndex = 60
        Me.Label5.Text = "MACHINE NO :"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lotid
        '
        Me.lotid.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lotid.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lotid.Location = New System.Drawing.Point(128, 97)
        Me.lotid.Name = "lotid"
        Me.lotid.Size = New System.Drawing.Size(244, 25)
        Me.lotid.TabIndex = 57
        Me.lotid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(35, 103)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 13)
        Me.Label4.TabIndex = 58
        Me.Label4.Text = "LOT ID :"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'package
        '
        Me.package.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.package.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.package.Location = New System.Drawing.Point(128, 26)
        Me.package.Name = "package"
        Me.package.Size = New System.Drawing.Size(244, 25)
        Me.package.TabIndex = 55
        Me.package.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(35, 32)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 13)
        Me.Label3.TabIndex = 56
        Me.Label3.Text = "PACKAGE :"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'spool
        '
        Me.spool.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.spool.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.spool.Location = New System.Drawing.Point(128, 10)
        Me.spool.MaxLength = 14
        Me.spool.Name = "spool"
        Me.spool.Size = New System.Drawing.Size(244, 29)
        Me.spool.TabIndex = 61
        Me.spool.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(35, 16)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(68, 13)
        Me.Label6.TabIndex = 62
        Me.Label6.Text = "SPOOL NO :"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'PrepPnl
        '
        Me.PrepPnl.BackColor = System.Drawing.Color.Transparent
        Me.PrepPnl.Controls.Add(Me.currentLength)
        Me.PrepPnl.Controls.Add(Me.Label10)
        Me.PrepPnl.Controls.Add(Me.kitter)
        Me.PrepPnl.Controls.Add(Me.Label7)
        Me.PrepPnl.Controls.Add(Me.spool)
        Me.PrepPnl.Controls.Add(Me.Label6)
        Me.PrepPnl.Dock = System.Windows.Forms.DockStyle.Top
        Me.PrepPnl.Location = New System.Drawing.Point(0, 191)
        Me.PrepPnl.Name = "PrepPnl"
        Me.PrepPnl.Size = New System.Drawing.Size(409, 115)
        Me.PrepPnl.TabIndex = 63
        '
        'currentLength
        '
        Me.currentLength.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.currentLength.Enabled = False
        Me.currentLength.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.currentLength.Location = New System.Drawing.Point(161, 47)
        Me.currentLength.Name = "currentLength"
        Me.currentLength.ReadOnly = True
        Me.currentLength.Size = New System.Drawing.Size(180, 25)
        Me.currentLength.TabIndex = 65
        Me.currentLength.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label10
        '
        Me.Label10.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label10.AutoSize = True
        Me.Label10.Enabled = False
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(36, 53)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(109, 13)
        Me.Label10.TabIndex = 66
        Me.Label10.Text = "CURRENT LENGTH :"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'kitter
        '
        Me.kitter.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.kitter.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.kitter.Location = New System.Drawing.Point(128, 82)
        Me.kitter.MaxLength = 6
        Me.kitter.Name = "kitter"
        Me.kitter.Size = New System.Drawing.Size(244, 25)
        Me.kitter.TabIndex = 63
        Me.kitter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(35, 88)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(48, 13)
        Me.Label7.TabIndex = 64
        Me.Label7.Text = "KITTER :"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'IssuePnl
        '
        Me.IssuePnl.BackColor = System.Drawing.Color.Transparent
        Me.IssuePnl.Controls.Add(Me.IssuedTo)
        Me.IssuePnl.Controls.Add(Me.Label8)
        Me.IssuePnl.Dock = System.Windows.Forms.DockStyle.Top
        Me.IssuePnl.Location = New System.Drawing.Point(0, 306)
        Me.IssuePnl.Name = "IssuePnl"
        Me.IssuePnl.Size = New System.Drawing.Size(409, 42)
        Me.IssuePnl.TabIndex = 64
        Me.IssuePnl.Visible = False
        '
        'IssuedTo
        '
        Me.IssuedTo.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.IssuedTo.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IssuedTo.Location = New System.Drawing.Point(128, 7)
        Me.IssuedTo.MaxLength = 6
        Me.IssuedTo.Name = "IssuedTo"
        Me.IssuedTo.Size = New System.Drawing.Size(244, 25)
        Me.IssuedTo.TabIndex = 63
        Me.IssuedTo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(35, 13)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(67, 13)
        Me.Label8.TabIndex = 64
        Me.Label8.Text = "ISSUED TO :"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.Controls.Add(Me.g_send)
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 503)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(409, 75)
        Me.Panel2.TabIndex = 65
        '
        'g_send
        '
        Me.g_send.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.g_send.BackColor = System.Drawing.Color.Green
        Me.g_send.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.g_send.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.g_send.ForeColor = System.Drawing.Color.White
        Me.g_send.Location = New System.Drawing.Point(173, 17)
        Me.g_send.Name = "g_send"
        Me.g_send.Size = New System.Drawing.Size(168, 40)
        Me.g_send.TabIndex = 57
        Me.g_send.Text = "SAVE"
        Me.g_send.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Button1.BackColor = System.Drawing.Color.Red
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(72, 18)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(79, 40)
        Me.Button1.TabIndex = 58
        Me.Button1.Text = "CANCEL"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'retPnl
        '
        Me.retPnl.BackColor = System.Drawing.Color.Transparent
        Me.retPnl.Controls.Add(Me.g_remarks)
        Me.retPnl.Controls.Add(Me.Label13)
        Me.retPnl.Controls.Add(Me.retto)
        Me.retPnl.Controls.Add(Me.Label9)
        Me.retPnl.Controls.Add(Me.retby)
        Me.retPnl.Controls.Add(Me.Label11)
        Me.retPnl.Controls.Add(Me.consumed)
        Me.retPnl.Controls.Add(Me.Label12)
        Me.retPnl.Dock = System.Windows.Forms.DockStyle.Top
        Me.retPnl.Location = New System.Drawing.Point(0, 348)
        Me.retPnl.Name = "retPnl"
        Me.retPnl.Size = New System.Drawing.Size(409, 149)
        Me.retPnl.TabIndex = 66
        Me.retPnl.Visible = False
        '
        'g_remarks
        '
        Me.g_remarks.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.g_remarks.Enabled = False
        Me.g_remarks.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.g_remarks.Location = New System.Drawing.Point(129, 48)
        Me.g_remarks.MaxLength = 6
        Me.g_remarks.Name = "g_remarks"
        Me.g_remarks.Size = New System.Drawing.Size(244, 25)
        Me.g_remarks.TabIndex = 65
        Me.g_remarks.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label13
        '
        Me.Label13.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label13.AutoSize = True
        Me.Label13.Enabled = False
        Me.Label13.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(36, 54)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(65, 13)
        Me.Label13.TabIndex = 66
        Me.Label13.Text = "REMARKS :"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'retto
        '
        Me.retto.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.retto.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.retto.Location = New System.Drawing.Point(128, 119)
        Me.retto.MaxLength = 6
        Me.retto.Name = "retto"
        Me.retto.Size = New System.Drawing.Size(244, 25)
        Me.retto.TabIndex = 63
        Me.retto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label9
        '
        Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(35, 125)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(80, 13)
        Me.Label9.TabIndex = 64
        Me.Label9.Text = "RECEIVED BY :"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'retby
        '
        Me.retby.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.retby.Enabled = False
        Me.retby.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.retby.Location = New System.Drawing.Point(128, 82)
        Me.retby.MaxLength = 6
        Me.retby.Name = "retby"
        Me.retby.Size = New System.Drawing.Size(244, 25)
        Me.retby.TabIndex = 63
        Me.retby.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label11
        '
        Me.Label11.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label11.AutoSize = True
        Me.Label11.Enabled = False
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(35, 88)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(87, 13)
        Me.Label11.TabIndex = 64
        Me.Label11.Text = "RETURNED BY :"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'consumed
        '
        Me.consumed.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.consumed.Enabled = False
        Me.consumed.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.consumed.Location = New System.Drawing.Point(161, 9)
        Me.consumed.MaxLength = 10
        Me.consumed.Name = "consumed"
        Me.consumed.Size = New System.Drawing.Size(180, 29)
        Me.consumed.TabIndex = 61
        Me.consumed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label12
        '
        Me.Label12.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Enabled = False
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(35, 15)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(122, 13)
        Me.Label12.TabIndex = 62
        Me.Label12.Text = "LENGTH CONSUMED :"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Au_Transaction
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.B800_Material_Request_System.My.Resources.Resources.LogIn_Form_APp
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(409, 578)
        Me.Controls.Add(Me.retPnl)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.IssuePnl)
        Me.Controls.Add(Me.PrepPnl)
        Me.Controls.Add(Me.newPnl)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Au_Transaction"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gold Transaction"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.newPnl.ResumeLayout(False)
        Me.newPnl.PerformLayout()
        Me.PrepPnl.ResumeLayout(False)
        Me.PrepPnl.PerformLayout()
        Me.IssuePnl.ResumeLayout(False)
        Me.IssuePnl.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.retPnl.ResumeLayout(False)
        Me.retPnl.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents UID As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents MainStatus As Label
    Friend WithEvents newPnl As Panel
    Friend WithEvents machine As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents lotid As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents package As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents spool As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents PrepPnl As Panel
    Friend WithEvents kitter As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents IssuePnl As Panel
    Friend WithEvents IssuedTo As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents currentLength As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents g_send As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents retPnl As Panel
    Friend WithEvents retby As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents consumed As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents retto As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents g_remarks As TextBox
    Friend WithEvents Label13 As Label
End Class
