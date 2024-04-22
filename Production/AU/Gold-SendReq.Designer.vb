<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Gold_SendReq
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Gold_SendReq))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.g_send = New System.Windows.Forms.Button()
        Me.g_package = New System.Windows.Forms.ComboBox()
        Me.g_machine = New System.Windows.Forms.ComboBox()
        Me.g_lotid = New System.Windows.Forms.TextBox()
        Me.g_user = New System.Windows.Forms.TextBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.UID = New System.Windows.Forms.Label()
        Me.lbl = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(397, 74)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(7, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(220, 30)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "SEND NEW REQUEST"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 102.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Button1, 0, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.g_send, 1, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.g_package, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.g_machine, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.g_lotid, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.g_user, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Label27, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label4, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.UID, 1, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.lbl, 0, 4)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 74)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 6
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.1875!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.421875!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26.5625!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(397, 249)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Button1.BackColor = System.Drawing.Color.Red
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(20, 201)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(79, 30)
        Me.Button1.TabIndex = 56
        Me.Button1.Text = "CANCEL"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'g_send
        '
        Me.g_send.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.g_send.BackColor = System.Drawing.Color.Green
        Me.g_send.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.g_send.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.g_send.ForeColor = System.Drawing.Color.White
        Me.g_send.Location = New System.Drawing.Point(160, 201)
        Me.g_send.Name = "g_send"
        Me.g_send.Size = New System.Drawing.Size(158, 30)
        Me.g_send.TabIndex = 47
        Me.g_send.Text = "SEND REQUEST"
        Me.g_send.UseVisualStyleBackColor = False
        '
        'g_package
        '
        Me.g_package.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.g_package.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.g_package.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.g_package.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.g_package.FormattingEnabled = True
        Me.g_package.Location = New System.Drawing.Point(105, 8)
        Me.g_package.Name = "g_package"
        Me.g_package.Size = New System.Drawing.Size(269, 25)
        Me.g_package.TabIndex = 48
        '
        'g_machine
        '
        Me.g_machine.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.g_machine.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.g_machine.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.g_machine.DropDownHeight = 200
        Me.g_machine.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.g_machine.FormattingEnabled = True
        Me.g_machine.IntegralHeight = False
        Me.g_machine.Location = New System.Drawing.Point(105, 49)
        Me.g_machine.MaxLength = 5
        Me.g_machine.Name = "g_machine"
        Me.g_machine.Size = New System.Drawing.Size(269, 25)
        Me.g_machine.TabIndex = 49
        '
        'g_lotid
        '
        Me.g_lotid.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.g_lotid.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.g_lotid.Location = New System.Drawing.Point(105, 90)
        Me.g_lotid.MaxLength = 15
        Me.g_lotid.Name = "g_lotid"
        Me.g_lotid.Size = New System.Drawing.Size(269, 25)
        Me.g_lotid.TabIndex = 50
        Me.g_lotid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'g_user
        '
        Me.g_user.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.g_user.Enabled = False
        Me.g_user.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.g_user.Location = New System.Drawing.Point(105, 131)
        Me.g_user.Name = "g_user"
        Me.g_user.Size = New System.Drawing.Size(269, 25)
        Me.g_user.TabIndex = 51
        Me.g_user.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
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
        Me.Label27.Size = New System.Drawing.Size(96, 41)
        Me.Label27.TabIndex = 52
        Me.Label27.Text = "PACKAGE"
        Me.Label27.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(3, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 41)
        Me.Label2.TabIndex = 53
        Me.Label2.Text = "MACHINE NO"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(3, 82)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 41)
        Me.Label3.TabIndex = 54
        Me.Label3.Text = "LOT ID"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(3, 123)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(96, 42)
        Me.Label4.TabIndex = 55
        Me.Label4.Text = "REQUEST BY"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'UID
        '
        Me.UID.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UID.AutoSize = True
        Me.UID.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UID.Location = New System.Drawing.Point(105, 165)
        Me.UID.Name = "UID"
        Me.UID.Size = New System.Drawing.Size(269, 18)
        Me.UID.TabIndex = 70
        Me.UID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.UID.Visible = False
        '
        'lbl
        '
        Me.lbl.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl.AutoSize = True
        Me.lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl.Location = New System.Drawing.Point(3, 165)
        Me.lbl.Name = "lbl"
        Me.lbl.Size = New System.Drawing.Size(96, 18)
        Me.lbl.TabIndex = 71
        Me.lbl.Text = "UID:"
        Me.lbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lbl.Visible = False
        '
        'Gold_SendReq
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.B800_Material_Request_System.My.Resources.Resources.LogIn_Form_APp
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(397, 323)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Gold_SendReq"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SEND NEW REQUEST"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents g_send As Button
    Friend WithEvents g_package As ComboBox
    Friend WithEvents g_machine As ComboBox
    Friend WithEvents g_lotid As TextBox
    Friend WithEvents g_user As TextBox
    Friend WithEvents Label27 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents UID As Label
    Friend WithEvents lbl As Label
End Class
