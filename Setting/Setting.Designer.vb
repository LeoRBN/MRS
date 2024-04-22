<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Setting
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Setting))
        Me.refreshData = New System.Windows.Forms.TextBox()
        Me.softUpdate = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.accessCode = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'refreshData
        '
        Me.refreshData.BackColor = System.Drawing.Color.Black
        Me.refreshData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.refreshData.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.refreshData.ForeColor = System.Drawing.Color.White
        Me.refreshData.Location = New System.Drawing.Point(178, 24)
        Me.refreshData.MaxLength = 2
        Me.refreshData.Name = "refreshData"
        Me.refreshData.Size = New System.Drawing.Size(58, 22)
        Me.refreshData.TabIndex = 45
        Me.refreshData.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'softUpdate
        '
        Me.softUpdate.BackColor = System.Drawing.Color.Black
        Me.softUpdate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.softUpdate.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.softUpdate.ForeColor = System.Drawing.Color.White
        Me.softUpdate.Location = New System.Drawing.Point(178, 58)
        Me.softUpdate.MaxLength = 2
        Me.softUpdate.Name = "softUpdate"
        Me.softUpdate.Size = New System.Drawing.Size(58, 22)
        Me.softUpdate.TabIndex = 47
        Me.softUpdate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(9, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(118, 12)
        Me.Label1.TabIndex = 46
        Me.Label1.Text = "Auto refresh data (minutes) :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(9, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(157, 12)
        Me.Label2.TabIndex = 48
        Me.Label2.Text = "Auto Check for software update (Hrs) :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(9, 95)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 12)
        Me.Label3.TabIndex = 49
        Me.Label3.Text = "Current Access Code :"
        '
        'accessCode
        '
        Me.accessCode.BackColor = System.Drawing.Color.Black
        Me.accessCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.accessCode.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.accessCode.ForeColor = System.Drawing.Color.White
        Me.accessCode.Location = New System.Drawing.Point(178, 92)
        Me.accessCode.Name = "accessCode"
        Me.accessCode.Size = New System.Drawing.Size(77, 22)
        Me.accessCode.TabIndex = 50
        Me.accessCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(88, 145)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(97, 31)
        Me.Button1.TabIndex = 51
        Me.Button1.Text = "SAVE"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(236, 27)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(20, 12)
        Me.Label4.TabIndex = 52
        Me.Label4.Text = "min"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(236, 61)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(19, 12)
        Me.Label5.TabIndex = 53
        Me.Label5.Text = "Hrs"
        '
        'Setting
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(268, 191)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.accessCode)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.softUpdate)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.refreshData)
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Setting"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Setting"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents refreshData As TextBox
    Friend WithEvents softUpdate As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents accessCode As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
End Class
