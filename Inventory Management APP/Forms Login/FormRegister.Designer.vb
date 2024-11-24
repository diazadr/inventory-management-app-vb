<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormRegister
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
        Me.TitleBar = New System.Windows.Forms.Panel()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnMinimize = New System.Windows.Forms.Button()
        Me.lblLogin = New System.Windows.Forms.Label()
        Me.lblKataSandi = New System.Windows.Forms.Label()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.lblTitle3 = New System.Windows.Forms.Label()
        Me.btnDaftar = New System.Windows.Forms.Button()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.lblRegistrasi = New System.Windows.Forms.Label()
        Me.imgRegister = New System.Windows.Forms.PictureBox()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblTitle2 = New System.Windows.Forms.Label()
        Me.TitleBar.SuspendLayout()
        CType(Me.imgRegister, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TitleBar
        '
        Me.TitleBar.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.TitleBar.Controls.Add(Me.btnExit)
        Me.TitleBar.Controls.Add(Me.btnMinimize)
        Me.TitleBar.Dock = System.Windows.Forms.DockStyle.Top
        Me.TitleBar.ForeColor = System.Drawing.Color.Transparent
        Me.TitleBar.Location = New System.Drawing.Point(0, 0)
        Me.TitleBar.Name = "TitleBar"
        Me.TitleBar.Size = New System.Drawing.Size(1097, 50)
        Me.TitleBar.TabIndex = 10
        '
        'btnExit
        '
        Me.btnExit.FlatAppearance.BorderSize = 0
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExit.Image = Global.Inventory_Management_APP.My.Resources.Resources.x_18_5121
        Me.btnExit.Location = New System.Drawing.Point(1054, 12)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(20, 20)
        Me.btnExit.TabIndex = 3
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnMinimize
        '
        Me.btnMinimize.FlatAppearance.BorderSize = 0
        Me.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMinimize.ForeColor = System.Drawing.Color.Transparent
        Me.btnMinimize.Image = Global.Inventory_Management_APP.My.Resources.Resources.minimize_8_5123
        Me.btnMinimize.Location = New System.Drawing.Point(1017, 12)
        Me.btnMinimize.Name = "btnMinimize"
        Me.btnMinimize.Size = New System.Drawing.Size(20, 20)
        Me.btnMinimize.TabIndex = 2
        Me.btnMinimize.UseVisualStyleBackColor = True
        '
        'lblLogin
        '
        Me.lblLogin.AutoSize = True
        Me.lblLogin.BackColor = System.Drawing.Color.Transparent
        Me.lblLogin.Font = New System.Drawing.Font("Century Gothic", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLogin.ForeColor = System.Drawing.Color.Black
        Me.lblLogin.Location = New System.Drawing.Point(306, 518)
        Me.lblLogin.Name = "lblLogin"
        Me.lblLogin.Size = New System.Drawing.Size(51, 19)
        Me.lblLogin.TabIndex = 26
        Me.lblLogin.Text = "Login"
        '
        'lblKataSandi
        '
        Me.lblKataSandi.AutoSize = True
        Me.lblKataSandi.BackColor = System.Drawing.Color.Transparent
        Me.lblKataSandi.Font = New System.Drawing.Font("Century Gothic", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKataSandi.ForeColor = System.Drawing.Color.Black
        Me.lblKataSandi.Location = New System.Drawing.Point(80, 320)
        Me.lblKataSandi.Name = "lblKataSandi"
        Me.lblKataSandi.Size = New System.Drawing.Size(93, 19)
        Me.lblKataSandi.TabIndex = 25
        Me.lblKataSandi.Text = "Kata Sandi"
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.BackColor = System.Drawing.Color.Transparent
        Me.lblUsername.Font = New System.Drawing.Font("Century Gothic", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsername.ForeColor = System.Drawing.Color.Black
        Me.lblUsername.Location = New System.Drawing.Point(80, 249)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(87, 19)
        Me.lblUsername.TabIndex = 24
        Me.lblUsername.Text = "Username"
        '
        'lblTitle3
        '
        Me.lblTitle3.AutoSize = True
        Me.lblTitle3.BackColor = System.Drawing.Color.Transparent
        Me.lblTitle3.Font = New System.Drawing.Font("Century Gothic", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle3.ForeColor = System.Drawing.Color.Black
        Me.lblTitle3.Location = New System.Drawing.Point(92, 518)
        Me.lblTitle3.Name = "lblTitle3"
        Me.lblTitle3.Size = New System.Drawing.Size(217, 19)
        Me.lblTitle3.TabIndex = 23
        Me.lblTitle3.Text = "Sudah mempunyai akun ?"
        '
        'btnDaftar
        '
        Me.btnDaftar.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.btnDaftar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDaftar.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDaftar.ForeColor = System.Drawing.Color.White
        Me.btnDaftar.Location = New System.Drawing.Point(84, 438)
        Me.btnDaftar.Name = "btnDaftar"
        Me.btnDaftar.Size = New System.Drawing.Size(299, 47)
        Me.btnDaftar.TabIndex = 22
        Me.btnDaftar.Text = "Daftar"
        Me.btnDaftar.UseVisualStyleBackColor = False
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(84, 352)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(299, 26)
        Me.txtPassword.TabIndex = 21
        '
        'txtUsername
        '
        Me.txtUsername.Location = New System.Drawing.Point(84, 284)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(299, 26)
        Me.txtUsername.TabIndex = 20
        '
        'lblRegistrasi
        '
        Me.lblRegistrasi.AutoSize = True
        Me.lblRegistrasi.BackColor = System.Drawing.Color.Transparent
        Me.lblRegistrasi.Font = New System.Drawing.Font("Century Gothic", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRegistrasi.ForeColor = System.Drawing.Color.Black
        Me.lblRegistrasi.Location = New System.Drawing.Point(147, 112)
        Me.lblRegistrasi.Name = "lblRegistrasi"
        Me.lblRegistrasi.Size = New System.Drawing.Size(162, 38)
        Me.lblRegistrasi.TabIndex = 18
        Me.lblRegistrasi.Text = "Registrasi"
        '
        'imgRegister
        '
        Me.imgRegister.Image = Global.Inventory_Management_APP.My.Resources.Resources.rag_doll_with_blue_cap_checking_boxes
        Me.imgRegister.Location = New System.Drawing.Point(631, 237)
        Me.imgRegister.Name = "imgRegister"
        Me.imgRegister.Size = New System.Drawing.Size(300, 300)
        Me.imgRegister.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgRegister.TabIndex = 30
        Me.imgRegister.TabStop = False
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblTitle.Font = New System.Drawing.Font("Century Gothic", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.lblTitle.Location = New System.Drawing.Point(581, 112)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(380, 38)
        Me.lblTitle.TabIndex = 31
        Me.lblTitle.Text = "Inventory Management"
        '
        'lblTitle2
        '
        Me.lblTitle2.AutoSize = True
        Me.lblTitle2.BackColor = System.Drawing.Color.Transparent
        Me.lblTitle2.Font = New System.Drawing.Font("Century Gothic", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.lblTitle2.Location = New System.Drawing.Point(565, 170)
        Me.lblTitle2.Name = "lblTitle2"
        Me.lblTitle2.Size = New System.Drawing.Size(420, 38)
        Me.lblTitle2.TabIndex = 32
        Me.lblTitle2.Text = "System POLMAN Bandung"
        '
        'FormRegister
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1097, 655)
        Me.Controls.Add(Me.lblTitle2)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.lblLogin)
        Me.Controls.Add(Me.lblKataSandi)
        Me.Controls.Add(Me.lblUsername)
        Me.Controls.Add(Me.lblTitle3)
        Me.Controls.Add(Me.btnDaftar)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.lblRegistrasi)
        Me.Controls.Add(Me.TitleBar)
        Me.Controls.Add(Me.imgRegister)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormRegister"
        Me.Text = "FormRegister"
        Me.TitleBar.ResumeLayout(False)
        CType(Me.imgRegister, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TitleBar As Panel
    Friend WithEvents btnExit As Button
    Friend WithEvents btnMinimize As Button
    Friend WithEvents lblLogin As Label
    Friend WithEvents lblKataSandi As Label
    Friend WithEvents lblUsername As Label
    Friend WithEvents lblTitle3 As Label
    Friend WithEvents btnDaftar As Button
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents lblRegistrasi As Label
    Friend WithEvents imgRegister As PictureBox
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblTitle2 As Label
End Class
