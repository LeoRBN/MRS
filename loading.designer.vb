<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class loading
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(loading))
        Me.LoadingMsg = New System.Windows.Forms.Label()
        Me.AppName = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.CopyRight = New System.Windows.Forms.Label()
        Me.notifier = New System.IO.FileSystemWatcher()
        Me.notif_icon = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.Version = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        CType(Me.notifier, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'LoadingMsg
        '
        Me.LoadingMsg.AutoSize = True
        Me.LoadingMsg.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LoadingMsg.Location = New System.Drawing.Point(3, 67)
        Me.LoadingMsg.Name = "LoadingMsg"
        Me.LoadingMsg.Size = New System.Drawing.Size(61, 13)
        Me.LoadingMsg.TabIndex = 0
        Me.LoadingMsg.Text = "Loading...."
        '
        'AppName
        '
        Me.AppName.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.AppName.AutoSize = True
        Me.AppName.Font = New System.Drawing.Font("Segoe UI Black", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AppName.Location = New System.Drawing.Point(3, 18)
        Me.AppName.Name = "AppName"
        Me.AppName.Size = New System.Drawing.Size(89, 20)
        Me.AppName.TabIndex = 1
        Me.AppName.Text = "Loading...."
        '
        'Timer1
        '
        Me.Timer1.Interval = 500
        '
        'CopyRight
        '
        Me.CopyRight.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.CopyRight.AutoSize = True
        Me.CopyRight.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CopyRight.Location = New System.Drawing.Point(3, 46)
        Me.CopyRight.Name = "CopyRight"
        Me.CopyRight.Size = New System.Drawing.Size(60, 13)
        Me.CopyRight.TabIndex = 2
        Me.CopyRight.Text = "Loading...."
        '
        'notifier
        '
        Me.notifier.EnableRaisingEvents = True
        Me.notifier.Filter = "*.txt*"
        Me.notifier.SynchronizingObject = Me
        '
        'notif_icon
        '
        Me.notif_icon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.notif_icon.BalloonTipTitle = "NEW MATERIAL REQUEST"
        Me.notif_icon.Text = "NEW REQUEST"
        Me.notif_icon.Visible = True
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 1
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.AppName, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.CopyRight, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.LoadingMsg, 0, 2)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(94, 0)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 3
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(271, 97)
        Me.TableLayoutPanel2.TabIndex = 5
        '
        'Version
        '
        Me.Version.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Version.AutoSize = True
        Me.Version.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Version.Location = New System.Drawing.Point(24, 65)
        Me.Version.Name = "Version"
        Me.Version.Size = New System.Drawing.Size(44, 15)
        Me.Version.TabIndex = 5
        Me.Version.Text = "5.0.0.0"
        Me.Version.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(94, 66)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Version)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(94, 97)
        Me.Panel1.TabIndex = 7
        '
        'loading
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(365, 97)
        Me.ControlBox = False
        Me.Controls.Add(Me.TableLayoutPanel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "loading"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.notifier, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LoadingMsg As Label
    Friend WithEvents AppName As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents CopyRight As Label
    Friend WithEvents notifier As IO.FileSystemWatcher
    Friend WithEvents notif_icon As NotifyIcon
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents Version As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel1 As Panel
End Class
