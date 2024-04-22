<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Gold_Return
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Gold_Return))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.changeSpool = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.mainFrame = New System.Windows.Forms.TableLayoutPanel()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.g_spool = New System.Windows.Forms.TextBox()
        Me.g_status = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.g_send = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.g_reason = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.g_consume = New System.Windows.Forms.TextBox()
        Me.g_remarks = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.g_lotno = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.g_reqby = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.g_machine = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.g_package = New System.Windows.Forms.ComboBox()
        Me.g_length = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.UID = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.mainFrame.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.changeSpool)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(397, 56)
        Me.Panel1.TabIndex = 1
        '
        'changeSpool
        '
        Me.changeSpool.Font = New System.Drawing.Font("Segoe UI Semibold", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.changeSpool.Location = New System.Drawing.Point(281, 19)
        Me.changeSpool.Name = "changeSpool"
        Me.changeSpool.Size = New System.Drawing.Size(93, 23)
        Me.changeSpool.TabIndex = 1
        Me.changeSpool.Text = "Change Spool"
        Me.changeSpool.UseVisualStyleBackColor = True
        Me.changeSpool.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(7, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(163, 30)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "RETURN FORM"
        '
        'mainFrame
        '
        Me.mainFrame.BackColor = System.Drawing.Color.Transparent
        Me.mainFrame.ColumnCount = 3
        Me.mainFrame.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 113.0!))
        Me.mainFrame.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.mainFrame.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.mainFrame.Controls.Add(Me.Label27, 0, 0)
        Me.mainFrame.Controls.Add(Me.g_spool, 1, 1)
        Me.mainFrame.Controls.Add(Me.g_status, 1, 0)
        Me.mainFrame.Controls.Add(Me.Label10, 0, 1)
        Me.mainFrame.Controls.Add(Me.g_send, 1, 11)
        Me.mainFrame.Controls.Add(Me.Button1, 0, 11)
        Me.mainFrame.Controls.Add(Me.Label12, 0, 10)
        Me.mainFrame.Controls.Add(Me.Label8, 0, 9)
        Me.mainFrame.Controls.Add(Me.g_reason, 1, 9)
        Me.mainFrame.Controls.Add(Me.Label7, 0, 8)
        Me.mainFrame.Controls.Add(Me.g_consume, 1, 8)
        Me.mainFrame.Controls.Add(Me.g_remarks, 1, 7)
        Me.mainFrame.Controls.Add(Me.Label6, 0, 7)
        Me.mainFrame.Controls.Add(Me.Label5, 0, 6)
        Me.mainFrame.Controls.Add(Me.g_lotno, 1, 6)
        Me.mainFrame.Controls.Add(Me.Label4, 0, 5)
        Me.mainFrame.Controls.Add(Me.g_reqby, 1, 5)
        Me.mainFrame.Controls.Add(Me.Label3, 0, 4)
        Me.mainFrame.Controls.Add(Me.g_machine, 1, 4)
        Me.mainFrame.Controls.Add(Me.Label2, 0, 3)
        Me.mainFrame.Controls.Add(Me.g_package, 1, 3)
        Me.mainFrame.Controls.Add(Me.g_length, 1, 2)
        Me.mainFrame.Controls.Add(Me.Label9, 0, 2)
        Me.mainFrame.Controls.Add(Me.UID, 1, 10)
        Me.mainFrame.Dock = System.Windows.Forms.DockStyle.Fill
        Me.mainFrame.Location = New System.Drawing.Point(0, 56)
        Me.mainFrame.Name = "mainFrame"
        Me.mainFrame.RowCount = 12
        Me.mainFrame.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.196484!))
        Me.mainFrame.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.01395!))
        Me.mainFrame.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.420115!))
        Me.mainFrame.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.624899!))
        Me.mainFrame.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.010544!))
        Me.mainFrame.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.44404!))
        Me.mainFrame.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.805759!))
        Me.mainFrame.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.17568!))
        Me.mainFrame.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.973565!))
        Me.mainFrame.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.33496!))
        Me.mainFrame.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15.0!))
        Me.mainFrame.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60.0!))
        Me.mainFrame.Size = New System.Drawing.Size(397, 506)
        Me.mainFrame.TabIndex = 2
        '
        'Label27
        '
        Me.Label27.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(3, 0)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(107, 39)
        Me.Label27.TabIndex = 52
        Me.Label27.Text = "STATUS"
        Me.Label27.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'g_spool
        '
        Me.g_spool.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.g_spool.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.g_spool.Location = New System.Drawing.Point(116, 48)
        Me.g_spool.MaxLength = 14
        Me.g_spool.Name = "g_spool"
        Me.g_spool.Size = New System.Drawing.Size(258, 25)
        Me.g_spool.TabIndex = 58
        Me.g_spool.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'g_status
        '
        Me.g_status.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.g_status.AutoSize = True
        Me.g_status.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.g_status.Location = New System.Drawing.Point(116, 0)
        Me.g_status.Name = "g_status"
        Me.g_status.Size = New System.Drawing.Size(258, 39)
        Me.g_status.TabIndex = 66
        Me.g_status.Text = "- - -"
        Me.g_status.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label10
        '
        Me.Label10.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(3, 39)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(107, 43)
        Me.Label10.TabIndex = 68
        Me.Label10.Text = "SPOOL NO"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'g_send
        '
        Me.g_send.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.g_send.BackColor = System.Drawing.Color.Green
        Me.g_send.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.g_send.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.g_send.ForeColor = System.Drawing.Color.White
        Me.g_send.Location = New System.Drawing.Point(161, 453)
        Me.g_send.Name = "g_send"
        Me.g_send.Size = New System.Drawing.Size(168, 40)
        Me.g_send.TabIndex = 47
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
        Me.Button1.Location = New System.Drawing.Point(31, 453)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(79, 40)
        Me.Button1.TabIndex = 56
        Me.Button1.Text = "CANCEL"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label12
        '
        Me.Label12.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(3, 425)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(107, 15)
        Me.Label12.TabIndex = 70
        Me.Label12.Text = "UID:"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label8
        '
        Me.Label8.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(3, 364)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(107, 61)
        Me.Label8.TabIndex = 62
        Me.Label8.Text = "REASON"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'g_reason
        '
        Me.g_reason.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.g_reason.Enabled = False
        Me.g_reason.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.g_reason.Location = New System.Drawing.Point(116, 367)
        Me.g_reason.Multiline = True
        Me.g_reason.Name = "g_reason"
        Me.g_reason.Size = New System.Drawing.Size(258, 55)
        Me.g_reason.TabIndex = 65
        '
        'Label7
        '
        Me.Label7.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(3, 322)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(107, 42)
        Me.Label7.TabIndex = 61
        Me.Label7.Text = "CONSUMPTION"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'g_consume
        '
        Me.g_consume.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.g_consume.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.g_consume.Enabled = False
        Me.g_consume.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.g_consume.Location = New System.Drawing.Point(116, 330)
        Me.g_consume.Name = "g_consume"
        Me.g_consume.Size = New System.Drawing.Size(258, 25)
        Me.g_consume.TabIndex = 67
        Me.g_consume.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'g_remarks
        '
        Me.g_remarks.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.g_remarks.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.g_remarks.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.g_remarks.Enabled = False
        Me.g_remarks.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.g_remarks.FormattingEnabled = True
        Me.g_remarks.Items.AddRange(New Object() {"CONSUMED", "TRANSFER SPOOL", "SCRAP", "OFF-LINE"})
        Me.g_remarks.Location = New System.Drawing.Point(116, 290)
        Me.g_remarks.Name = "g_remarks"
        Me.g_remarks.Size = New System.Drawing.Size(258, 25)
        Me.g_remarks.TabIndex = 48
        '
        'Label6
        '
        Me.Label6.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(3, 283)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(107, 39)
        Me.Label6.TabIndex = 60
        Me.Label6.Text = "REMARKS"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(3, 246)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(107, 37)
        Me.Label5.TabIndex = 59
        Me.Label5.Text = "LOT NO"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'g_lotno
        '
        Me.g_lotno.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.g_lotno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.g_lotno.Enabled = False
        Me.g_lotno.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.g_lotno.Location = New System.Drawing.Point(116, 252)
        Me.g_lotno.Name = "g_lotno"
        Me.g_lotno.Size = New System.Drawing.Size(258, 25)
        Me.g_lotno.TabIndex = 64
        Me.g_lotno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(3, 201)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(107, 45)
        Me.Label4.TabIndex = 55
        Me.Label4.Text = "REQUEST BY"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'g_reqby
        '
        Me.g_reqby.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.g_reqby.Enabled = False
        Me.g_reqby.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.g_reqby.Location = New System.Drawing.Point(116, 211)
        Me.g_reqby.Name = "g_reqby"
        Me.g_reqby.Size = New System.Drawing.Size(258, 25)
        Me.g_reqby.TabIndex = 63
        Me.g_reqby.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(3, 163)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(107, 38)
        Me.Label3.TabIndex = 54
        Me.Label3.Text = "MACHINE"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'g_machine
        '
        Me.g_machine.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.g_machine.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.g_machine.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.g_machine.DropDownHeight = 200
        Me.g_machine.Enabled = False
        Me.g_machine.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.g_machine.FormattingEnabled = True
        Me.g_machine.IntegralHeight = False
        Me.g_machine.Location = New System.Drawing.Point(116, 169)
        Me.g_machine.Name = "g_machine"
        Me.g_machine.Size = New System.Drawing.Size(258, 25)
        Me.g_machine.TabIndex = 72
        '
        'Label2
        '
        Me.Label2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(3, 122)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(107, 41)
        Me.Label2.TabIndex = 53
        Me.Label2.Text = "PACKAGE"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'g_package
        '
        Me.g_package.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.g_package.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.g_package.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.g_package.Enabled = False
        Me.g_package.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.g_package.FormattingEnabled = True
        Me.g_package.Location = New System.Drawing.Point(116, 130)
        Me.g_package.Name = "g_package"
        Me.g_package.Size = New System.Drawing.Size(258, 25)
        Me.g_package.TabIndex = 71
        '
        'g_length
        '
        Me.g_length.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.g_length.Enabled = False
        Me.g_length.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.g_length.Location = New System.Drawing.Point(116, 89)
        Me.g_length.Name = "g_length"
        Me.g_length.Size = New System.Drawing.Size(258, 25)
        Me.g_length.TabIndex = 73
        Me.g_length.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label9
        '
        Me.Label9.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.Enabled = False
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(3, 82)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(107, 40)
        Me.Label9.TabIndex = 74
        Me.Label9.Text = "CURRENT LENGTH"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'UID
        '
        Me.UID.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UID.AutoSize = True
        Me.UID.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UID.Location = New System.Drawing.Point(116, 425)
        Me.UID.Name = "UID"
        Me.UID.Size = New System.Drawing.Size(258, 15)
        Me.UID.TabIndex = 69
        Me.UID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Gold_Return
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.B800_Material_Request_System.My.Resources.Resources.LogIn_Form_APp
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(397, 562)
        Me.Controls.Add(Me.mainFrame)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Gold_Return"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "UPDATE DATA"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.mainFrame.ResumeLayout(False)
        Me.mainFrame.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents mainFrame As TableLayoutPanel
    Friend WithEvents Label27 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents g_remarks As ComboBox
    Friend WithEvents g_reqby As TextBox
    Friend WithEvents g_send As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents g_lotno As TextBox
    Friend WithEvents g_reason As TextBox
    Friend WithEvents g_status As Label
    Friend WithEvents g_consume As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents UID As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents changeSpool As Button
    Friend WithEvents g_package As ComboBox
    Friend WithEvents g_machine As ComboBox
    Friend WithEvents g_spool As TextBox
    Friend WithEvents g_length As TextBox
    Friend WithEvents Label9 As Label
End Class
