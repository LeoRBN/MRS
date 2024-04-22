<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AU_ReturnAll
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AU_ReturnAll))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.returnList = New System.Windows.Forms.CheckedListBox()
        Me.slip = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.kitter = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.g_send = New System.Windows.Forms.Button()
        Me.selectall = New System.Windows.Forms.CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(378, 53)
        Me.Panel1.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel2.Controls.Add(Me.g_send)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 458)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(378, 53)
        Me.Panel2.TabIndex = 1
        '
        'returnList
        '
        Me.returnList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.returnList.CheckOnClick = True
        Me.returnList.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.returnList.FormattingEnabled = True
        Me.returnList.Location = New System.Drawing.Point(30, 100)
        Me.returnList.Name = "returnList"
        Me.returnList.Size = New System.Drawing.Size(324, 242)
        Me.returnList.TabIndex = 2
        '
        'slip
        '
        Me.slip.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.slip.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.slip.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.slip.Location = New System.Drawing.Point(136, 367)
        Me.slip.MaxLength = 15
        Me.slip.Name = "slip"
        Me.slip.Size = New System.Drawing.Size(215, 25)
        Me.slip.TabIndex = 55
        Me.slip.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(27, 373)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 13)
        Me.Label3.TabIndex = 56
        Me.Label3.Text = "RETURN SLIP :"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'kitter
        '
        Me.kitter.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.kitter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.kitter.Enabled = False
        Me.kitter.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.kitter.Location = New System.Drawing.Point(136, 398)
        Me.kitter.MaxLength = 15
        Me.kitter.Name = "kitter"
        Me.kitter.ReadOnly = True
        Me.kitter.Size = New System.Drawing.Size(215, 25)
        Me.kitter.TabIndex = 57
        Me.kitter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(27, 404)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 13)
        Me.Label1.TabIndex = 58
        Me.Label1.Text = "RETURN BY :"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'g_send
        '
        Me.g_send.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.g_send.BackColor = System.Drawing.Color.Green
        Me.g_send.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.g_send.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.g_send.ForeColor = System.Drawing.Color.White
        Me.g_send.Location = New System.Drawing.Point(110, 11)
        Me.g_send.Name = "g_send"
        Me.g_send.Size = New System.Drawing.Size(158, 30)
        Me.g_send.TabIndex = 48
        Me.g_send.Text = "SAVE"
        Me.g_send.UseVisualStyleBackColor = False
        '
        'selectall
        '
        Me.selectall.AutoSize = True
        Me.selectall.BackColor = System.Drawing.Color.Transparent
        Me.selectall.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.selectall.Location = New System.Drawing.Point(33, 75)
        Me.selectall.Name = "selectall"
        Me.selectall.Size = New System.Drawing.Size(86, 17)
        Me.selectall.TabIndex = 59
        Me.selectall.Text = "SELECT ALL"
        Me.selectall.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Yellow
        Me.Label2.Location = New System.Drawing.Point(16, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(190, 25)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "RETURN ALL SPOOL"
        '
        'AU_ReturnAll
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.B800_Material_Request_System.My.Resources.Resources.LogIn_Form_APp
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(378, 511)
        Me.Controls.Add(Me.selectall)
        Me.Controls.Add(Me.kitter)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.slip)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.returnList)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AU_ReturnAll"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "RETURN ALL"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents returnList As CheckedListBox
    Friend WithEvents slip As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents kitter As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents g_send As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents selectall As CheckBox
End Class
