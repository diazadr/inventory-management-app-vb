<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.panelMenu = New System.Windows.Forms.Panel()
        Me.btnKeluar = New FontAwesome.Sharp.IconButton()
        Me.btnUser = New FontAwesome.Sharp.IconButton()
        Me.btnPelaporan = New FontAwesome.Sharp.IconButton()
        Me.btnNotifikasi = New FontAwesome.Sharp.IconButton()
        Me.btnInventaris = New FontAwesome.Sharp.IconButton()
        Me.btnStatus = New FontAwesome.Sharp.IconButton()
        Me.btnPemeliharaan = New FontAwesome.Sharp.IconButton()
        Me.btnPeminjaman = New FontAwesome.Sharp.IconButton()
        Me.btnLokasi = New FontAwesome.Sharp.IconButton()
        Me.btnBarang = New FontAwesome.Sharp.IconButton()
        Me.btnDashboard = New FontAwesome.Sharp.IconButton()
        Me.panelLogo = New System.Windows.Forms.Panel()
        Me.imgHome = New System.Windows.Forms.PictureBox()
        Me.panelTitle = New System.Windows.Forms.Panel()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.iconTitle = New FontAwesome.Sharp.IconPictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.IconPictureBox1 = New FontAwesome.Sharp.IconPictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.IconPictureBox2 = New FontAwesome.Sharp.IconPictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.IconPictureBox3 = New FontAwesome.Sharp.IconPictureBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.panelDesktop = New System.Windows.Forms.Panel()
        Me.panelMenu.SuspendLayout()
        Me.panelLogo.SuspendLayout()
        CType(Me.imgHome, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelTitle.SuspendLayout()
        CType(Me.iconTitle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.IconPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        CType(Me.IconPictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        CType(Me.IconPictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelDesktop.SuspendLayout()
        Me.SuspendLayout()
        '
        'panelMenu
        '
        Me.panelMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.panelMenu.Controls.Add(Me.btnKeluar)
        Me.panelMenu.Controls.Add(Me.btnUser)
        Me.panelMenu.Controls.Add(Me.btnPelaporan)
        Me.panelMenu.Controls.Add(Me.btnNotifikasi)
        Me.panelMenu.Controls.Add(Me.btnInventaris)
        Me.panelMenu.Controls.Add(Me.btnStatus)
        Me.panelMenu.Controls.Add(Me.btnPemeliharaan)
        Me.panelMenu.Controls.Add(Me.btnPeminjaman)
        Me.panelMenu.Controls.Add(Me.btnLokasi)
        Me.panelMenu.Controls.Add(Me.btnBarang)
        Me.panelMenu.Controls.Add(Me.btnDashboard)
        Me.panelMenu.Controls.Add(Me.panelLogo)
        Me.panelMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.panelMenu.Location = New System.Drawing.Point(0, 0)
        Me.panelMenu.Name = "panelMenu"
        Me.panelMenu.Size = New System.Drawing.Size(220, 952)
        Me.panelMenu.TabIndex = 1
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
        Me.btnKeluar.Location = New System.Drawing.Point(0, 802)
        Me.btnKeluar.Name = "btnKeluar"
        Me.btnKeluar.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.btnKeluar.Size = New System.Drawing.Size(220, 64)
        Me.btnKeluar.TabIndex = 13
        Me.btnKeluar.Text = "Keluar"
        Me.btnKeluar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnKeluar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnKeluar.UseVisualStyleBackColor = True
        '
        'btnUser
        '
        Me.btnUser.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnUser.FlatAppearance.BorderSize = 0
        Me.btnUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUser.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUser.ForeColor = System.Drawing.Color.White
        Me.btnUser.IconChar = FontAwesome.Sharp.IconChar.Users
        Me.btnUser.IconColor = System.Drawing.Color.White
        Me.btnUser.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnUser.IconSize = 32
        Me.btnUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUser.Location = New System.Drawing.Point(0, 738)
        Me.btnUser.Name = "btnUser"
        Me.btnUser.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.btnUser.Size = New System.Drawing.Size(220, 64)
        Me.btnUser.TabIndex = 12
        Me.btnUser.Text = "User"
        Me.btnUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnUser.UseVisualStyleBackColor = True
        '
        'btnPelaporan
        '
        Me.btnPelaporan.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnPelaporan.FlatAppearance.BorderSize = 0
        Me.btnPelaporan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPelaporan.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPelaporan.ForeColor = System.Drawing.Color.White
        Me.btnPelaporan.IconChar = FontAwesome.Sharp.IconChar.FileImport
        Me.btnPelaporan.IconColor = System.Drawing.Color.White
        Me.btnPelaporan.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnPelaporan.IconSize = 32
        Me.btnPelaporan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPelaporan.Location = New System.Drawing.Point(0, 674)
        Me.btnPelaporan.Name = "btnPelaporan"
        Me.btnPelaporan.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.btnPelaporan.Size = New System.Drawing.Size(220, 64)
        Me.btnPelaporan.TabIndex = 11
        Me.btnPelaporan.Text = "Pelaporan"
        Me.btnPelaporan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPelaporan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnPelaporan.UseVisualStyleBackColor = True
        '
        'btnNotifikasi
        '
        Me.btnNotifikasi.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnNotifikasi.FlatAppearance.BorderSize = 0
        Me.btnNotifikasi.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNotifikasi.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNotifikasi.ForeColor = System.Drawing.Color.White
        Me.btnNotifikasi.IconChar = FontAwesome.Sharp.IconChar.Bell
        Me.btnNotifikasi.IconColor = System.Drawing.Color.White
        Me.btnNotifikasi.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnNotifikasi.IconSize = 32
        Me.btnNotifikasi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNotifikasi.Location = New System.Drawing.Point(0, 610)
        Me.btnNotifikasi.Name = "btnNotifikasi"
        Me.btnNotifikasi.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.btnNotifikasi.Size = New System.Drawing.Size(220, 64)
        Me.btnNotifikasi.TabIndex = 10
        Me.btnNotifikasi.Text = "Notifikasi"
        Me.btnNotifikasi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNotifikasi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnNotifikasi.UseVisualStyleBackColor = True
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
        Me.btnInventaris.Location = New System.Drawing.Point(0, 546)
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
        Me.btnStatus.Location = New System.Drawing.Point(0, 482)
        Me.btnStatus.Name = "btnStatus"
        Me.btnStatus.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.btnStatus.Size = New System.Drawing.Size(220, 64)
        Me.btnStatus.TabIndex = 8
        Me.btnStatus.Text = "Status"
        Me.btnStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnStatus.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnStatus.UseVisualStyleBackColor = True
        '
        'btnPemeliharaan
        '
        Me.btnPemeliharaan.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnPemeliharaan.FlatAppearance.BorderSize = 0
        Me.btnPemeliharaan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPemeliharaan.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPemeliharaan.ForeColor = System.Drawing.Color.White
        Me.btnPemeliharaan.IconChar = FontAwesome.Sharp.IconChar.Screwdriver
        Me.btnPemeliharaan.IconColor = System.Drawing.Color.White
        Me.btnPemeliharaan.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnPemeliharaan.IconSize = 32
        Me.btnPemeliharaan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPemeliharaan.Location = New System.Drawing.Point(0, 418)
        Me.btnPemeliharaan.Name = "btnPemeliharaan"
        Me.btnPemeliharaan.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.btnPemeliharaan.Size = New System.Drawing.Size(220, 64)
        Me.btnPemeliharaan.TabIndex = 7
        Me.btnPemeliharaan.Text = "Pemeliharaan"
        Me.btnPemeliharaan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPemeliharaan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnPemeliharaan.UseVisualStyleBackColor = True
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
        Me.btnPeminjaman.Location = New System.Drawing.Point(0, 354)
        Me.btnPeminjaman.Name = "btnPeminjaman"
        Me.btnPeminjaman.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.btnPeminjaman.Size = New System.Drawing.Size(220, 64)
        Me.btnPeminjaman.TabIndex = 6
        Me.btnPeminjaman.Text = "Peminjaman"
        Me.btnPeminjaman.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPeminjaman.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnPeminjaman.UseVisualStyleBackColor = True
        '
        'btnLokasi
        '
        Me.btnLokasi.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnLokasi.FlatAppearance.BorderSize = 0
        Me.btnLokasi.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLokasi.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLokasi.ForeColor = System.Drawing.Color.White
        Me.btnLokasi.IconChar = FontAwesome.Sharp.IconChar.HouseCircleCheck
        Me.btnLokasi.IconColor = System.Drawing.Color.White
        Me.btnLokasi.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnLokasi.IconSize = 32
        Me.btnLokasi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLokasi.Location = New System.Drawing.Point(0, 290)
        Me.btnLokasi.Name = "btnLokasi"
        Me.btnLokasi.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.btnLokasi.Size = New System.Drawing.Size(220, 64)
        Me.btnLokasi.TabIndex = 4
        Me.btnLokasi.Text = "Lokasi"
        Me.btnLokasi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLokasi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnLokasi.UseVisualStyleBackColor = True
        '
        'btnBarang
        '
        Me.btnBarang.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnBarang.FlatAppearance.BorderSize = 0
        Me.btnBarang.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBarang.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBarang.ForeColor = System.Drawing.Color.White
        Me.btnBarang.IconChar = FontAwesome.Sharp.IconChar.DesktopAlt
        Me.btnBarang.IconColor = System.Drawing.Color.White
        Me.btnBarang.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnBarang.IconSize = 32
        Me.btnBarang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBarang.Location = New System.Drawing.Point(0, 226)
        Me.btnBarang.Name = "btnBarang"
        Me.btnBarang.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.btnBarang.Size = New System.Drawing.Size(220, 64)
        Me.btnBarang.TabIndex = 3
        Me.btnBarang.Text = "Barang"
        Me.btnBarang.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBarang.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnBarang.UseVisualStyleBackColor = True
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
        Me.panelTitle.TabIndex = 2
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
        'Timer1
        '
        '
        'Panel2
        '
        Me.Panel2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.IconPictureBox1)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Location = New System.Drawing.Point(282, 146)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(208, 208)
        Me.Panel2.TabIndex = 9
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(82, 166)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(36, 25)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "00"
        '
        'IconPictureBox1
        '
        Me.IconPictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.IconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.DesktopAlt
        Me.IconPictureBox1.IconColor = System.Drawing.Color.White
        Me.IconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconPictureBox1.IconSize = 109
        Me.IconPictureBox1.Location = New System.Drawing.Point(48, 40)
        Me.IconPictureBox1.Name = "IconPictureBox1"
        Me.IconPictureBox1.Size = New System.Drawing.Size(109, 110)
        Me.IconPictureBox1.TabIndex = 1
        Me.IconPictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(57, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 25)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Barang"
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox1.Image = Global.Inventory_Management_APP.My.Resources.Resources.Logo_Polman_Bandung_Original_PNG_Terbaru
        Me.PictureBox1.Location = New System.Drawing.Point(281, 478)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(200, 220)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(497, 525)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(911, 85)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Selamat Datang, Admin !"
        '
        'lblTime
        '
        Me.lblTime.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblTime.AutoSize = True
        Me.lblTime.Font = New System.Drawing.Font("Century Gothic", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.ForeColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.lblTime.Location = New System.Drawing.Point(504, 610)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(174, 47)
        Me.lblTime.TabIndex = 13
        Me.lblTime.Text = "00:00:00"
        '
        'Panel4
        '
        Me.Panel4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.Panel4.Controls.Add(Me.Label4)
        Me.Panel4.Controls.Add(Me.IconPictureBox2)
        Me.Panel4.Controls.Add(Me.Label5)
        Me.Panel4.Location = New System.Drawing.Point(650, 146)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(208, 208)
        Me.Panel4.TabIndex = 11
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(92, 166)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(36, 25)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "00"
        '
        'IconPictureBox2
        '
        Me.IconPictureBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.IconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.Screwdriver
        Me.IconPictureBox2.IconColor = System.Drawing.Color.White
        Me.IconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconPictureBox2.IconSize = 109
        Me.IconPictureBox2.Location = New System.Drawing.Point(52, 40)
        Me.IconPictureBox2.Name = "IconPictureBox2"
        Me.IconPictureBox2.Size = New System.Drawing.Size(109, 110)
        Me.IconPictureBox2.TabIndex = 1
        Me.IconPictureBox2.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(22, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(163, 25)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Pemeliharaan"
        '
        'Panel5
        '
        Me.Panel5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.Panel5.Controls.Add(Me.Label6)
        Me.Panel5.Controls.Add(Me.IconPictureBox3)
        Me.Panel5.Controls.Add(Me.Label7)
        Me.Panel5.Location = New System.Drawing.Point(1023, 146)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(208, 208)
        Me.Panel5.TabIndex = 10
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(85, 166)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(36, 25)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "00"
        '
        'IconPictureBox3
        '
        Me.IconPictureBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.IconPictureBox3.IconChar = FontAwesome.Sharp.IconChar.File
        Me.IconPictureBox3.IconColor = System.Drawing.Color.White
        Me.IconPictureBox3.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconPictureBox3.IconSize = 109
        Me.IconPictureBox3.Location = New System.Drawing.Point(49, 40)
        Me.IconPictureBox3.Name = "IconPictureBox3"
        Me.IconPictureBox3.Size = New System.Drawing.Size(109, 110)
        Me.IconPictureBox3.TabIndex = 1
        Me.IconPictureBox3.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(31, 9)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(147, 25)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Peminjaman"
        '
        'panelDesktop
        '
        Me.panelDesktop.BackColor = System.Drawing.Color.White
        Me.panelDesktop.Controls.Add(Me.lblTime)
        Me.panelDesktop.Controls.Add(Me.Label1)
        Me.panelDesktop.Controls.Add(Me.PictureBox1)
        Me.panelDesktop.Controls.Add(Me.Panel5)
        Me.panelDesktop.Controls.Add(Me.Panel4)
        Me.panelDesktop.Controls.Add(Me.Panel2)
        Me.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelDesktop.Location = New System.Drawing.Point(0, 0)
        Me.panelDesktop.Name = "panelDesktop"
        Me.panelDesktop.Size = New System.Drawing.Size(1420, 952)
        Me.panelDesktop.TabIndex = 0
        '
        'Form1
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
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.panelMenu.ResumeLayout(False)
        Me.panelLogo.ResumeLayout(False)
        CType(Me.imgHome, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelTitle.ResumeLayout(False)
        Me.panelTitle.PerformLayout()
        CType(Me.iconTitle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.IconPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.IconPictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        CType(Me.IconPictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelDesktop.ResumeLayout(False)
        Me.panelDesktop.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents panelMenu As Panel
    Friend WithEvents btnDashboard As FontAwesome.Sharp.IconButton
    Friend WithEvents panelLogo As Panel
    Friend WithEvents btnLokasi As FontAwesome.Sharp.IconButton
    Friend WithEvents btnBarang As FontAwesome.Sharp.IconButton
    Friend WithEvents btnPeminjaman As FontAwesome.Sharp.IconButton
    Friend WithEvents panelTitle As Panel
    Friend WithEvents iconTitle As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents lblTitle As Label
    Friend WithEvents imgHome As PictureBox
    Friend WithEvents btnPemeliharaan As FontAwesome.Sharp.IconButton
    Friend WithEvents btnUser As FontAwesome.Sharp.IconButton
    Friend WithEvents btnPelaporan As FontAwesome.Sharp.IconButton
    Friend WithEvents btnNotifikasi As FontAwesome.Sharp.IconButton
    Friend WithEvents btnInventaris As FontAwesome.Sharp.IconButton
    Friend WithEvents btnStatus As FontAwesome.Sharp.IconButton
    Friend WithEvents btnKeluar As FontAwesome.Sharp.IconButton
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents IconPictureBox1 As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblTime As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents IconPictureBox2 As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents IconPictureBox3 As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents Label7 As Label
    Friend WithEvents panelDesktop As Panel
End Class
