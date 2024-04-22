<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AU_Insert
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AU_Insert))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.StatusMain = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.currLength = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.kitter = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.reservation = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.length = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.supplier = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.matcode = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.package = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.spoolno = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.g_save = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.StatusMain)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(397, 52)
        Me.Panel1.TabIndex = 0
        '
        'StatusMain
        '
        Me.StatusMain.AutoSize = True
        Me.StatusMain.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StatusMain.Location = New System.Drawing.Point(27, 12)
        Me.StatusMain.Name = "StatusMain"
        Me.StatusMain.Size = New System.Drawing.Size(147, 30)
        Me.StatusMain.TabIndex = 1
        Me.StatusMain.Text = "INSERT DATA"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.Controls.Add(Me.currLength)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.kitter)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.reservation)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.length)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.supplier)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.matcode)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.package)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.spoolno)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 52)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(397, 364)
        Me.Panel2.TabIndex = 1
        '
        'currLength
        '
        Me.currLength.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.currLength.Enabled = False
        Me.currLength.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.currLength.Location = New System.Drawing.Point(143, 242)
        Me.currLength.MaxLength = 4
        Me.currLength.Name = "currLength"
        Me.currLength.ReadOnly = True
        Me.currLength.Size = New System.Drawing.Size(225, 25)
        Me.currLength.TabIndex = 71
        Me.currLength.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label9
        '
        Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label9.AutoSize = True
        Me.Label9.Enabled = False
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(29, 248)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(106, 13)
        Me.Label9.TabIndex = 72
        Me.Label9.Text = "CURRENT LENGTH:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'kitter
        '
        Me.kitter.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.kitter.Enabled = False
        Me.kitter.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.kitter.Location = New System.Drawing.Point(143, 326)
        Me.kitter.MaxLength = 6
        Me.kitter.Name = "kitter"
        Me.kitter.Size = New System.Drawing.Size(225, 25)
        Me.kitter.TabIndex = 69
        Me.kitter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(29, 332)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(48, 13)
        Me.Label7.TabIndex = 70
        Me.Label7.Text = "KITTER :"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'reservation
        '
        Me.reservation.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.reservation.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.reservation.Location = New System.Drawing.Point(143, 283)
        Me.reservation.MaxLength = 15
        Me.reservation.Name = "reservation"
        Me.reservation.Size = New System.Drawing.Size(225, 25)
        Me.reservation.TabIndex = 67
        Me.reservation.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(29, 289)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(104, 13)
        Me.Label6.TabIndex = 68
        Me.Label6.Text = "RESERVATION NO :"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'length
        '
        Me.length.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.length.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.length.Location = New System.Drawing.Point(143, 202)
        Me.length.MaxLength = 4
        Me.length.Name = "length"
        Me.length.Size = New System.Drawing.Size(225, 25)
        Me.length.TabIndex = 65
        Me.length.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(29, 208)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(109, 13)
        Me.Label5.TabIndex = 66
        Me.Label5.Text = "RECEIVED LENGTH :"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'supplier
        '
        Me.supplier.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.supplier.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.supplier.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.supplier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.supplier.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.supplier.FormattingEnabled = True
        Me.supplier.Items.AddRange(New Object() {"TANAKA"})
        Me.supplier.Location = New System.Drawing.Point(143, 160)
        Me.supplier.Name = "supplier"
        Me.supplier.Size = New System.Drawing.Size(225, 25)
        Me.supplier.TabIndex = 63
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(29, 166)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 13)
        Me.Label4.TabIndex = 64
        Me.Label4.Text = "SUPPLIER :"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'matcode
        '
        Me.matcode.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.matcode.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.matcode.Location = New System.Drawing.Point(143, 115)
        Me.matcode.MaxLength = 15
        Me.matcode.Name = "matcode"
        Me.matcode.Size = New System.Drawing.Size(225, 25)
        Me.matcode.TabIndex = 61
        Me.matcode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(29, 121)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 13)
        Me.Label1.TabIndex = 62
        Me.Label1.Text = "MATERIAL CODE :"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'package
        '
        Me.package.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.package.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.package.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.package.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.package.FormattingEnabled = True
        Me.package.Location = New System.Drawing.Point(143, 70)
        Me.package.Name = "package"
        Me.package.Size = New System.Drawing.Size(225, 25)
        Me.package.TabIndex = 59
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(29, 76)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 60
        Me.Label2.Text = "PACKAGE :"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'spoolno
        '
        Me.spoolno.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.spoolno.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.spoolno.Location = New System.Drawing.Point(143, 30)
        Me.spoolno.MaxLength = 14
        Me.spoolno.Name = "spoolno"
        Me.spoolno.Size = New System.Drawing.Size(225, 25)
        Me.spoolno.TabIndex = 57
        Me.spoolno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(29, 36)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 13)
        Me.Label3.TabIndex = 58
        Me.Label3.Text = "SPOOL NO :"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Transparent
        Me.Panel3.Controls.Add(Me.g_save)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 416)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(397, 78)
        Me.Panel3.TabIndex = 1
        '
        'g_save
        '
        Me.g_save.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.g_save.BackColor = System.Drawing.Color.Green
        Me.g_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.g_save.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.g_save.ForeColor = System.Drawing.Color.White
        Me.g_save.Location = New System.Drawing.Point(134, 29)
        Me.g_save.Name = "g_save"
        Me.g_save.Size = New System.Drawing.Size(146, 34)
        Me.g_save.TabIndex = 48
        Me.g_save.Text = "SAVE"
        Me.g_save.UseVisualStyleBackColor = False
        '
        'AU_Insert
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.B800_Material_Request_System.My.Resources.Resources.LogIn_Form_APp
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(397, 494)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AU_Insert"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "INSERT NEW DATA"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents spoolno As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents kitter As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents reservation As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents length As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents supplier As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents matcode As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents package As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents g_save As Button
    Friend WithEvents StatusMain As Label
    Friend WithEvents currLength As TextBox
    Friend WithEvents Label9 As Label
End Class
