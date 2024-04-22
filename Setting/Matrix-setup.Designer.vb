<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Matrix_setup
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Matrix_setup))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.maintTab = New System.Windows.Forms.TabControl()
        Me.matrix = New System.Windows.Forms.TabPage()
        Me.machine = New System.Windows.Forms.TabPage()
        Me.user = New System.Windows.Forms.TabPage()
        Me.matrixbtn = New System.Windows.Forms.Button()
        Me.machinebtn = New System.Windows.Forms.Button()
        Me.userbtn = New System.Windows.Forms.Button()
        Me.otherbtn = New System.Windows.Forms.Button()
        Me.others = New System.Windows.Forms.TabPage()
        Me.productList = New System.Windows.Forms.ListBox()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.dgvMatrix = New System.Windows.Forms.DataGridView()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.maintTab.SuspendLayout()
        Me.matrix.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        CType(Me.dgvMatrix, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.Black
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.otherbtn, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.userbtn, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.machinebtn, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.matrixbtn, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 10
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(149, 561)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'maintTab
        '
        Me.maintTab.Controls.Add(Me.matrix)
        Me.maintTab.Controls.Add(Me.machine)
        Me.maintTab.Controls.Add(Me.user)
        Me.maintTab.Controls.Add(Me.others)
        Me.maintTab.Dock = System.Windows.Forms.DockStyle.Fill
        Me.maintTab.Location = New System.Drawing.Point(149, 0)
        Me.maintTab.Name = "maintTab"
        Me.maintTab.Padding = New System.Drawing.Point(6, 20)
        Me.maintTab.SelectedIndex = 0
        Me.maintTab.Size = New System.Drawing.Size(779, 561)
        Me.maintTab.TabIndex = 1
        '
        'matrix
        '
        Me.matrix.Controls.Add(Me.dgvMatrix)
        Me.matrix.Controls.Add(Me.TableLayoutPanel2)
        Me.matrix.Controls.Add(Me.productList)
        Me.matrix.Location = New System.Drawing.Point(4, 56)
        Me.matrix.Name = "matrix"
        Me.matrix.Padding = New System.Windows.Forms.Padding(3)
        Me.matrix.Size = New System.Drawing.Size(771, 501)
        Me.matrix.TabIndex = 0
        Me.matrix.Text = "Matrix"
        Me.matrix.UseVisualStyleBackColor = True
        '
        'machine
        '
        Me.machine.Location = New System.Drawing.Point(4, 56)
        Me.machine.Name = "machine"
        Me.machine.Padding = New System.Windows.Forms.Padding(3)
        Me.machine.Size = New System.Drawing.Size(771, 501)
        Me.machine.TabIndex = 1
        Me.machine.Text = "Machine"
        Me.machine.UseVisualStyleBackColor = True
        '
        'user
        '
        Me.user.Location = New System.Drawing.Point(4, 56)
        Me.user.Name = "user"
        Me.user.Size = New System.Drawing.Size(771, 501)
        Me.user.TabIndex = 2
        Me.user.Text = "UserAcc"
        Me.user.UseVisualStyleBackColor = True
        '
        'matrixbtn
        '
        Me.matrixbtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.matrixbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.matrixbtn.Font = New System.Drawing.Font("Segoe UI Black", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.matrixbtn.ForeColor = System.Drawing.Color.White
        Me.matrixbtn.Location = New System.Drawing.Point(3, 6)
        Me.matrixbtn.Name = "matrixbtn"
        Me.matrixbtn.Size = New System.Drawing.Size(143, 43)
        Me.matrixbtn.TabIndex = 0
        Me.matrixbtn.Text = "MATRIX"
        Me.matrixbtn.UseVisualStyleBackColor = True
        '
        'machinebtn
        '
        Me.machinebtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.machinebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.machinebtn.Font = New System.Drawing.Font("Segoe UI Black", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.machinebtn.ForeColor = System.Drawing.Color.White
        Me.machinebtn.Location = New System.Drawing.Point(3, 62)
        Me.machinebtn.Name = "machinebtn"
        Me.machinebtn.Size = New System.Drawing.Size(143, 43)
        Me.machinebtn.TabIndex = 1
        Me.machinebtn.Text = "MACHINE"
        Me.machinebtn.UseVisualStyleBackColor = True
        '
        'userbtn
        '
        Me.userbtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.userbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.userbtn.Font = New System.Drawing.Font("Segoe UI Black", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.userbtn.ForeColor = System.Drawing.Color.White
        Me.userbtn.Location = New System.Drawing.Point(3, 118)
        Me.userbtn.Name = "userbtn"
        Me.userbtn.Size = New System.Drawing.Size(143, 43)
        Me.userbtn.TabIndex = 2
        Me.userbtn.Text = "USER ACCESS"
        Me.userbtn.UseVisualStyleBackColor = True
        '
        'otherbtn
        '
        Me.otherbtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.otherbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.otherbtn.Font = New System.Drawing.Font("Segoe UI Black", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.otherbtn.ForeColor = System.Drawing.Color.White
        Me.otherbtn.Location = New System.Drawing.Point(3, 174)
        Me.otherbtn.Name = "otherbtn"
        Me.otherbtn.Size = New System.Drawing.Size(143, 43)
        Me.otherbtn.TabIndex = 3
        Me.otherbtn.Text = "OTHERS"
        Me.otherbtn.UseVisualStyleBackColor = True
        '
        'others
        '
        Me.others.Location = New System.Drawing.Point(4, 56)
        Me.others.Name = "others"
        Me.others.Size = New System.Drawing.Size(771, 501)
        Me.others.TabIndex = 3
        Me.others.Text = "Others"
        Me.others.UseVisualStyleBackColor = True
        '
        'productList
        '
        Me.productList.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.productList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.productList.Dock = System.Windows.Forms.DockStyle.Left
        Me.productList.Font = New System.Drawing.Font("Segoe UI Black", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.productList.ForeColor = System.Drawing.Color.Black
        Me.productList.FormattingEnabled = True
        Me.productList.ItemHeight = 30
        Me.productList.Items.AddRange(New Object() {"ROSALINE 1", "ROSALINE 2", "BANE", "DOPPLER", "ATLANTIS"})
        Me.productList.Location = New System.Drawing.Point(3, 3)
        Me.productList.Name = "productList"
        Me.productList.Size = New System.Drawing.Size(141, 495)
        Me.productList.TabIndex = 0
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.TableLayoutPanel2.ColumnCount = 7
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.TableLayoutPanel2.Controls.Add(Me.Button5, 6, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Button6, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Button7, 2, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Button8, 3, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(144, 442)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(624, 56)
        Me.TableLayoutPanel2.TabIndex = 1
        '
        'Button5
        '
        Me.Button5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button5.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(537, 3)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(84, 36)
        Me.Button5.TabIndex = 0
        Me.Button5.Text = "SAVE"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button6.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.Location = New System.Drawing.Point(92, 3)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(83, 36)
        Me.Button6.TabIndex = 1
        Me.Button6.Text = "ADD"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button7.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.Location = New System.Drawing.Point(181, 3)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(83, 36)
        Me.Button7.TabIndex = 2
        Me.Button7.Text = "EDIT"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button8.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button8.Location = New System.Drawing.Point(270, 3)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(83, 36)
        Me.Button8.TabIndex = 3
        Me.Button8.Text = "DELETE"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'dgvMatrix
        '
        Me.dgvMatrix.AllowUserToAddRows = False
        Me.dgvMatrix.AllowUserToDeleteRows = False
        Me.dgvMatrix.AllowUserToResizeRows = False
        Me.dgvMatrix.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvMatrix.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvMatrix.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvMatrix.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvMatrix.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvMatrix.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvMatrix.Location = New System.Drawing.Point(144, 3)
        Me.dgvMatrix.Margin = New System.Windows.Forms.Padding(2)
        Me.dgvMatrix.MultiSelect = False
        Me.dgvMatrix.Name = "dgvMatrix"
        Me.dgvMatrix.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvMatrix.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvMatrix.RowHeadersVisible = False
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvMatrix.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvMatrix.RowTemplate.Height = 24
        Me.dgvMatrix.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvMatrix.Size = New System.Drawing.Size(624, 439)
        Me.dgvMatrix.TabIndex = 8
        '
        'Matrix_setup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(928, 561)
        Me.Controls.Add(Me.maintTab)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Matrix_setup"
        Me.Text = "MATRIX SETUP"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.maintTab.ResumeLayout(False)
        Me.matrix.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        CType(Me.dgvMatrix, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents otherbtn As Button
    Friend WithEvents userbtn As Button
    Friend WithEvents machinebtn As Button
    Friend WithEvents matrixbtn As Button
    Friend WithEvents maintTab As TabControl
    Friend WithEvents matrix As TabPage
    Friend WithEvents productList As ListBox
    Friend WithEvents machine As TabPage
    Friend WithEvents user As TabPage
    Friend WithEvents others As TabPage
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents Button5 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents dgvMatrix As DataGridView
End Class
