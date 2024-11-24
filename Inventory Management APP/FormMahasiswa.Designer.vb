<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormMahasiswa
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
        Me.components = New System.ComponentModel.Container()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.panelMenu = New System.Windows.Forms.Panel()
        Me.btnKeluar = New FontAwesome.Sharp.IconButton()
        Me.btnInventaris = New FontAwesome.Sharp.IconButton()
        Me.btnStatus = New FontAwesome.Sharp.IconButton()
        Me.btnPeminjaman = New FontAwesome.Sharp.IconButton()
        Me.btnDashboard = New FontAwesome.Sharp.IconButton()
        Me.panelLogo = New System.Windows.Forms.Panel()
        Me.imgHome = New System.Windows.Forms.PictureBox()
        Me.panelTitle = New System.Windows.Forms.Panel()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.iconTitle = New FontAwesome.Sharp.IconPictureBox()
        Me.panelDesktop = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.panelMenu.SuspendLayout()
        Me.panelLogo.SuspendLayout()
        CType(Me.imgHome, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelTitle.SuspendLayout()
        CType(Me.iconTitle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelDesktop.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer1
        '
        '
        'panelMenu
        '
        Me.panelMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.panelMenu.Controls.Add(Me.btnKeluar)
        Me.panelMenu.Controls.Add(Me.btnInventaris)
        Me.panelMenu.Controls.Add(Me.btnStatus)
        Me.panelMenu.Controls.Add(Me.btnPeminjaman)
        Me.panelMenu.Controls.Add(Me.btnDashboard)
        Me.panelMenu.Controls.Add(Me.panelLogo)
        Me.panelMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.panelMenu.Location = New System.Drawing.Point(0, 0)
        Me.panelMenu.Name = "panelMenu"
        Me.panelMenu.Size = New System.Drawing.Size(220, 952)
        Me.panelMenu.TabIndex = 7
        '
        'btnKeluar
        '
        Me.btnKeluar.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnKeluar.FlatAppearance.BorderSize = 0
        Me.btnKeluar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnKeluar.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnKeluar.ForeColor = System.Drawing.Color.White
        Me.btnKeluar.IconChar = FontAwesome.Sharp.IconChar.ArrowRightFromBracket
        Me.btnKeluar.IconColor = System.Drawing.Color.White
        Me.btnKeluar.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnKeluar.IconSize = 32
        Me.btnKeluar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnKeluar.Location = New System.Drawing.Point(0, 418)
        Me.btnKeluar.Name = "btnKeluar"
        Me.btnKeluar.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.btnKeluar.Size = New System.Drawing.Size(220, 64)
        Me.btnKeluar.TabIndex = 13
        Me.btnKeluar.Text = "Keluar"
        Me.btnKeluar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnKeluar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnKeluar.UseVisualStyleBackColor = True
        '
        'btnInventaris
        '
        Me.btnInventaris.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnInventaris.FlatAppearance.BorderSize = 0
        Me.btnInventaris.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnInventaris.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInventaris.ForeColor = System.Drawing.Color.White
        Me.btnInventaris.IconChar = FontAwesome.Sharp.IconChar.Clipboard
        Me.btnInventaris.IconColor = System.Drawing.Color.White
        Me.btnInventaris.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnInventaris.IconSize = 32
        Me.btnInventaris.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnInventaris.Location = New System.Drawing.Point(0, 354)
        Me.btnInventaris.Name = "btnInventaris"
        Me.btnInventaris.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.btnInventaris.Size = New System.Drawing.Size(220, 64)
        Me.btnInventaris.TabIndex = 9
        Me.btnInventaris.Text = "Inventaris"
        Me.btnInventaris.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnInventaris.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnInventaris.UseVisualStyleBackColor = True
        '
        'btnStatus
        '
        Me.btnStatus.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnStatus.FlatAppearance.BorderSize = 0
        Me.btnStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStatus.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStatus.ForeColor = System.Drawing.Color.White
        Me.btnStatus.IconChar = FontAwesome.Sharp.IconChar.ClockFour
        Me.btnStatus.IconColor = System.Drawing.Color.White
        Me.btnStatus.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnStatus.IconSize = 32
        Me.btnStatus.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnStatus.Location = New System.Drawing.Point(0, 290)
        Me.btnStatus.Name = "btnStatus"
        Me.btnStatus.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.btnStatus.Size = New System.Drawing.Size(220, 64)
        Me.btnStatus.TabIndex = 8
        Me.btnStatus.Text = "Status"
        Me.btnStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnStatus.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnStatus.UseVisualStyleBackColor = True
        '
        'btnPeminjaman
        '
        Me.btnPeminjaman.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnPeminjaman.FlatAppearance.BorderSize = 0
        Me.btnPeminjaman.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPeminjaman.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPeminjaman.ForeColor = System.Drawing.Color.White
        Me.btnPeminjaman.IconChar = FontAwesome.Sharp.IconChar.File
        Me.btnPeminjaman.IconColor = System.Drawing.Color.White
        Me.btnPeminjaman.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnPeminjaman.IconSize = 32
        Me.btnPeminjaman.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPeminjaman.Location = New System.Drawing.Point(0, 226)
        Me.btnPeminjaman.Name = "btnPeminjaman"
        Me.btnPeminjaman.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.btnPeminjaman.Size = New System.Drawing.Size(220, 64)
        Me.btnPeminjaman.TabIndex = 6
        Me.btnPeminjaman.Text = "Peminjaman"
        Me.btnPeminjaman.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPeminjaman.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnPeminjaman.UseVisualStyleBackColor = True
        '
        'btnDashboard
        '
        Me.btnDashboard.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnDashboard.FlatAppearance.BorderSize = 0
        Me.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDashboard.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDashboard.ForeColor = System.Drawing.Color.White
        Me.btnDashboard.IconChar = FontAwesome.Sharp.IconChar.House
        Me.btnDashboard.IconColor = System.Drawing.Color.White
        Me.btnDashboard.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnDashboard.IconSize = 32
        Me.btnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDashboard.Location = New System.Drawing.Point(0, 162)
        Me.btnDashboard.Name = "btnDashboard"
        Me.btnDashboard.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.btnDashboard.Size = New System.Drawing.Size(220, 64)
        Me.btnDashboard.TabIndex = 2
        Me.btnDashboard.Text = "Dashboard"
        Me.btnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnDashboard.UseVisualStyleBackColor = True
        '
        'panelLogo
        '
        Me.panelLogo.Controls.Add(Me.imgHome)
        Me.panelLogo.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelLogo.Location = New System.Drawing.Point(0, 0)
        Me.panelLogo.Name = "panelLogo"
        Me.panelLogo.Size = New System.Drawing.Size(220, 162)
        Me.panelLogo.TabIndex = 1
        '
        'imgHome
        '
        Me.imgHome.Image = Global.Inventory_Management_APP.My.Resources.Resources.Untitled_1
        Me.imgHome.Location = New System.Drawing.Point(27, -22)
        Me.imgHome.Name = "imgHome"
        Me.imgHome.Size = New System.Drawing.Size(150, 150)
        Me.imgHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgHome.TabIndex = 0
        Me.imgHome.TabStop = False
        '
        'panelTitle
        '
        Me.panelTitle.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.panelTitle.Controls.Add(Me.lblTitle)
        Me.panelTitle.Controls.Add(Me.iconTitle)
        Me.panelTitle.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelTitle.Location = New System.Drawing.Point(220, 0)
        Me.panelTitle.Name = "panelTitle"
        Me.panelTitle.Size = New System.Drawing.Size(1200, 100)
        Me.panelTitle.TabIndex = 8
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Location = New System.Drawing.Point(103, 40)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(69, 23)
        Me.lblTitle.TabIndex = 1
        Me.lblTitle.Text = "Home"
        '
        'iconTitle
        '
        Me.iconTitle.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.iconTitle.IconChar = FontAwesome.Sharp.IconChar.House
        Me.iconTitle.IconColor = System.Drawing.Color.White
        Me.iconTitle.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.iconTitle.IconSize = 51
        Me.iconTitle.Location = New System.Drawing.Point(31, 26)
        Me.iconTitle.Name = "iconTitle"
        Me.iconTitle.Size = New System.Drawing.Size(53, 51)
        Me.iconTitle.TabIndex = 0
        Me.iconTitle.TabStop = False
        '
        'panelDesktop
        '
        Me.panelDesktop.BackColor = System.Drawing.Color.White
        Me.panelDesktop.Controls.Add(Me.Label2)
        Me.panelDesktop.Controls.Add(Me.PictureBox1)
        Me.panelDesktop.Controls.Add(Me.Label1)
        Me.panelDesktop.Controls.Add(Me.lblTime)
        Me.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelDesktop.Location = New System.Drawing.Point(0, 0)
        Me.panelDesktop.Name = "panelDesktop"
        Me.panelDesktop.Size = New System.Drawing.Size(1420, 952)
        Me.panelDesktop.TabIndex = 9
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 22.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(441, 304)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(730, 51)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Silahkan Melakukan Inventarisasi"
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox1.Image = Global.Inventory_Management_APP.My.Resources.Resources.Logo_Polman_Bandung_Original_PNG_Terbaru
        Me.PictureBox1.Location = New System.Drawing.Point(711, 379)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(200, 220)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 15
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 22.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(494, 231)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(626, 51)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Selamat Datang, Mahasiswa"
        '
        'lblTime
        '
        Me.lblTime.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblTime.AutoSize = True
        Me.lblTime.Font = New System.Drawing.Font("Century Gothic", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.ForeColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.lblTime.Location = New System.Drawing.Point(606, 624)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(425, 112)
        Me.lblTime.TabIndex = 13
        Me.lblTime.Text = "00:00:00"
        '
        'FormMahasiswa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(1420, 952)
        Me.Controls.Add(Me.panelTitle)
        Me.Controls.Add(Me.panelMenu)
        Me.Controls.Add(Me.panelDesktop)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.IsMdiContainer = True
        Me.Name = "FormMahasiswa"
        Me.Text = "FormMahasiswa"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.panelMenu.ResumeLayout(False)
        Me.panelLogo.ResumeLayout(False)
        CType(Me.imgHome, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelTitle.ResumeLayout(False)
        Me.panelTitle.PerformLayout()
        CType(Me.iconTitle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelDesktop.ResumeLayout(False)
        Me.panelDesktop.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Timer1 As Timer
    Friend WithEvents panelMenu As Panel
    Friend WithEvents btnKeluar As FontAwesome.Sharp.IconButton
    Friend WithEvents btnInventaris As FontAwesome.Sharp.IconButton
    Friend WithEvents btnStatus As FontAwesome.Sharp.IconButton
    Friend WithEvents btnPeminjaman As FontAwesome.Sharp.IconButton
    Friend WithEvents btnDashboard As FontAwesome.Sharp.IconButton
    Friend WithEvents panelLogo As Panel
    Friend WithEvents imgHome As PictureBox
    Friend WithEvents panelTitle As Panel
    Friend WithEvents lblTitle As Label
    Friend WithEvents iconTitle As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents panelDesktop As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblTime As Label
End Class
