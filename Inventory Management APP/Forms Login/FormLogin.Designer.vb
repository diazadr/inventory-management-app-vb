<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormLogin
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
        Me.lblTitle4 = New System.Windows.Forms.Label()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.btnMasuk = New System.Windows.Forms.Button()
        Me.lblTitle5 = New System.Windows.Forms.Label()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.lblDaftar = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblTitle3 = New System.Windows.Forms.Label()
        Me.lblTitle2 = New System.Windows.Forms.Label()
        Me.lblTitle1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TitleBar.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
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
        Me.TitleBar.TabIndex = 9
        '
        'btnExit
        '
        Me.btnExit.BackgroundImage = Global.Inventory_Management_APP.My.Resources.Resources.x_18_5121
        Me.btnExit.FlatAppearance.BorderSize = 0
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExit.Location = New System.Drawing.Point(1054, 12)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(20, 20)
        Me.btnExit.TabIndex = 3
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnMinimize
        '
        Me.btnMinimize.BackgroundImage = Global.Inventory_Management_APP.My.Resources.Resources.minimize_8_5123
        Me.btnMinimize.FlatAppearance.BorderSize = 0
        Me.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMinimize.ForeColor = System.Drawing.Color.Transparent
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
        Me.lblLogin.Font = New System.Drawing.Font("Century Gothic", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLogin.ForeColor = System.Drawing.Color.Black
        Me.lblLogin.Location = New System.Drawing.Point(693, 136)
        Me.lblLogin.Name = "lblLogin"
        Me.lblLogin.Size = New System.Drawing.Size(99, 38)
        Me.lblLogin.TabIndex = 2
        Me.lblLogin.Text = "Login"
        '
        'lblTitle4
        '
        Me.lblTitle4.AutoSize = True
        Me.lblTitle4.BackColor = System.Drawing.Color.Transparent
        Me.lblTitle4.Font = New System.Drawing.Font("Century Gothic", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle4.ForeColor = System.Drawing.Color.Black
        Me.lblTitle4.Location = New System.Drawing.Point(696, 184)
        Me.lblTitle4.Name = "lblTitle4"
        Me.lblTitle4.Size = New System.Drawing.Size(368, 19)
        Me.lblTitle4.TabIndex = 10
        Me.lblTitle4.Text = "Sebelum masuk silahkan login terlebih dahulu"
        '
        'txtUsername
        '
        Me.txtUsername.Location = New System.Drawing.Point(700, 262)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(299, 26)
        Me.txtUsername.TabIndex = 11
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(700, 335)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(299, 26)
        Me.txtPassword.TabIndex = 12
        '
        'btnMasuk
        '
        Me.btnMasuk.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.btnMasuk.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMasuk.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMasuk.ForeColor = System.Drawing.Color.White
        Me.btnMasuk.Location = New System.Drawing.Point(700, 395)
        Me.btnMasuk.Name = "btnMasuk"
        Me.btnMasuk.Size = New System.Drawing.Size(299, 47)
        Me.btnMasuk.TabIndex = 13
        Me.btnMasuk.Text = "Masuk"
        Me.btnMasuk.UseVisualStyleBackColor = False
        '
        'lblTitle5
        '
        Me.lblTitle5.AutoSize = True
        Me.lblTitle5.BackColor = System.Drawing.Color.Transparent
        Me.lblTitle5.Font = New System.Drawing.Font("Century Gothic", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle5.ForeColor = System.Drawing.Color.Black
        Me.lblTitle5.Location = New System.Drawing.Point(696, 474)
        Me.lblTitle5.Name = "lblTitle5"
        Me.lblTitle5.Size = New System.Drawing.Size(209, 19)
        Me.lblTitle5.TabIndex = 14
        Me.lblTitle5.Text = "Tidak mempunyai akun ?"
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.BackColor = System.Drawing.Color.Transparent
        Me.lblUsername.Font = New System.Drawing.Font("Century Gothic", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsername.ForeColor = System.Drawing.Color.Black
        Me.lblUsername.Location = New System.Drawing.Point(696, 229)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(87, 19)
        Me.lblUsername.TabIndex = 15
        Me.lblUsername.Text = "Username"
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.BackColor = System.Drawing.Color.Transparent
        Me.lblPassword.Font = New System.Drawing.Font("Century Gothic", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPassword.ForeColor = System.Drawing.Color.Black
        Me.lblPassword.Location = New System.Drawing.Point(696, 301)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(80, 19)
        Me.lblPassword.TabIndex = 16
        Me.lblPassword.Text = "Password"
        '
        'lblDaftar
        '
        Me.lblDaftar.AutoSize = True
        Me.lblDaftar.BackColor = System.Drawing.Color.Transparent
        Me.lblDaftar.Font = New System.Drawing.Font("Century Gothic", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDaftar.ForeColor = System.Drawing.Color.Black
        Me.lblDaftar.Location = New System.Drawing.Point(902, 474)
        Me.lblDaftar.Name = "lblDaftar"
        Me.lblDaftar.Size = New System.Drawing.Size(55, 19)
        Me.lblDaftar.TabIndex = 17
        Me.lblDaftar.Text = "Daftar"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(631, 655)
        Me.Panel1.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.BackgroundImage = Global.Inventory_Management_APP.My.Resources.Resources.NIK_25001
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel2.Controls.Add(Me.lblTitle3)
        Me.Panel2.Controls.Add(Me.lblTitle2)
        Me.Panel2.Controls.Add(Me.lblTitle1)
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(631, 655)
        Me.Panel2.TabIndex = 2
        '
        'lblTitle3
        '
        Me.lblTitle3.AutoSize = True
        Me.lblTitle3.BackColor = System.Drawing.Color.Transparent
        Me.lblTitle3.Font = New System.Drawing.Font("Century Gothic", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle3.ForeColor = System.Drawing.Color.White
        Me.lblTitle3.Location = New System.Drawing.Point(31, 348)
        Me.lblTitle3.Name = "lblTitle3"
        Me.lblTitle3.Size = New System.Drawing.Size(177, 38)
        Me.lblTitle3.TabIndex = 2
        Me.lblTitle3.Text = "BANDUNG"
        '
        'lblTitle2
        '
        Me.lblTitle2.AutoSize = True
        Me.lblTitle2.BackColor = System.Drawing.Color.Transparent
        Me.lblTitle2.Font = New System.Drawing.Font("Century Gothic", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle2.ForeColor = System.Drawing.Color.White
        Me.lblTitle2.Location = New System.Drawing.Point(31, 310)
        Me.lblTitle2.Name = "lblTitle2"
        Me.lblTitle2.Size = New System.Drawing.Size(405, 38)
        Me.lblTitle2.TabIndex = 1
        Me.lblTitle2.Text = "POLITEKNIK MANUFAKTUR"
        '
        'lblTitle1
        '
        Me.lblTitle1.AutoSize = True
        Me.lblTitle1.BackColor = System.Drawing.Color.Transparent
        Me.lblTitle1.Font = New System.Drawing.Font("Century Gothic", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle1.ForeColor = System.Drawing.Color.White
        Me.lblTitle1.Location = New System.Drawing.Point(31, 272)
        Me.lblTitle1.Name = "lblTitle1"
        Me.lblTitle1.Size = New System.Drawing.Size(273, 38)
        Me.lblTitle1.TabIndex = 0
        Me.lblTitle1.Text = "Sistem Inventaris"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(31, 118)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(574, 38)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "POLITEKNIK MANUFAKTUR BANDUNG"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(31, 80)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(273, 38)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Sistem Inventaris"
        '
        'FormLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1097, 655)
        Me.Controls.Add(Me.lblDaftar)
        Me.Controls.Add(Me.lblPassword)
        Me.Controls.Add(Me.lblUsername)
        Me.Controls.Add(Me.lblTitle5)
        Me.Controls.Add(Me.btnMasuk)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.lblTitle4)
        Me.Controls.Add(Me.lblLogin)
        Me.Controls.Add(Me.TitleBar)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormLogin"
        Me.Text = "FormLogin"
        Me.TitleBar.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TitleBar As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lblTitle2 As Label
    Friend WithEvents lblTitle1 As Label
    Friend WithEvents lblLogin As Label
    Friend WithEvents lblTitle4 As Label
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents btnMasuk As Button
    Friend WithEvents lblTitle5 As Label
    Friend WithEvents btnExit As Button
    Friend WithEvents btnMinimize As Button
    Friend WithEvents lblUsername As Label
    Friend WithEvents lblPassword As Label
    Friend WithEvents lblTitle3 As Label
    Friend WithEvents lblDaftar As Label
End Class
