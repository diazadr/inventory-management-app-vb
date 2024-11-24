<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormBarang
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.lblID = New System.Windows.Forms.Label()
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.lblMerk = New System.Windows.Forms.Label()
        Me.lblJumlahBarang = New System.Windows.Forms.Label()
        Me.lblNamaBarang = New System.Windows.Forms.Label()
        Me.btnCheck = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnHapus = New System.Windows.Forms.Button()
        Me.txtJumlahBarang = New System.Windows.Forms.TextBox()
        Me.txtNamaBarang = New System.Windows.Forms.TextBox()
        Me.cmbLokasi = New System.Windows.Forms.ComboBox()
        Me.lblLokasi = New System.Windows.Forms.Label()
        Me.txtMerk = New System.Windows.Forms.TextBox()
        Me.Title = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtID
        '
        Me.txtID.BackColor = System.Drawing.SystemColors.Control
        Me.txtID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtID.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtID.Location = New System.Drawing.Point(913, 246)
        Me.txtID.Margin = New System.Windows.Forms.Padding(4)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(393, 37)
        Me.txtID.TabIndex = 48
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblID.ForeColor = System.Drawing.Color.Black
        Me.lblID.Location = New System.Drawing.Point(868, 248)
        Me.lblID.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(37, 30)
        Me.lblID.TabIndex = 47
        Me.lblID.Text = "ID"
        '
        'btnSimpan
        '
        Me.btnSimpan.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.btnSimpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSimpan.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSimpan.ForeColor = System.Drawing.Color.White
        Me.btnSimpan.Location = New System.Drawing.Point(558, 566)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(234, 47)
        Me.btnSimpan.TabIndex = 46
        Me.btnSimpan.Text = "Simpan"
        Me.btnSimpan.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(102, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.EnableHeadersVisualStyles = False
        Me.DataGridView1.GridColor = System.Drawing.Color.White
        Me.DataGridView1.Location = New System.Drawing.Point(873, 303)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.DataGridView1.RowTemplate.Height = 28
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.DataGridView1.Size = New System.Drawing.Size(898, 310)
        Me.DataGridView1.TabIndex = 44
        '
        'lblMerk
        '
        Me.lblMerk.AutoSize = True
        Me.lblMerk.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMerk.ForeColor = System.Drawing.Color.Black
        Me.lblMerk.Location = New System.Drawing.Point(347, 429)
        Me.lblMerk.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMerk.Name = "lblMerk"
        Me.lblMerk.Size = New System.Drawing.Size(71, 30)
        Me.lblMerk.TabIndex = 43
        Me.lblMerk.Text = "Merk"
        '
        'lblJumlahBarang
        '
        Me.lblJumlahBarang.AutoSize = True
        Me.lblJumlahBarang.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJumlahBarang.ForeColor = System.Drawing.Color.Black
        Me.lblJumlahBarang.Location = New System.Drawing.Point(347, 367)
        Me.lblJumlahBarang.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblJumlahBarang.Name = "lblJumlahBarang"
        Me.lblJumlahBarang.Size = New System.Drawing.Size(192, 30)
        Me.lblJumlahBarang.TabIndex = 42
        Me.lblJumlahBarang.Text = "Jumlah Barang"
        '
        'lblNamaBarang
        '
        Me.lblNamaBarang.AutoSize = True
        Me.lblNamaBarang.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNamaBarang.ForeColor = System.Drawing.Color.Black
        Me.lblNamaBarang.Location = New System.Drawing.Point(347, 305)
        Me.lblNamaBarang.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNamaBarang.Name = "lblNamaBarang"
        Me.lblNamaBarang.Size = New System.Drawing.Size(178, 30)
        Me.lblNamaBarang.TabIndex = 41
        Me.lblNamaBarang.Text = "Nama Barang"
        '
        'btnCheck
        '
        Me.btnCheck.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.btnCheck.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCheck.ForeColor = System.Drawing.Color.White
        Me.btnCheck.Location = New System.Drawing.Point(1506, 679)
        Me.btnCheck.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCheck.Name = "btnCheck"
        Me.btnCheck.Size = New System.Drawing.Size(250, 80)
        Me.btnCheck.TabIndex = 40
        Me.btnCheck.Text = "Check"
        Me.btnCheck.UseVisualStyleBackColor = False
        '
        'btnEdit
        '
        Me.btnEdit.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.btnEdit.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEdit.ForeColor = System.Drawing.Color.White
        Me.btnEdit.Location = New System.Drawing.Point(893, 679)
        Me.btnEdit.Margin = New System.Windows.Forms.Padding(4)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(250, 80)
        Me.btnEdit.TabIndex = 39
        Me.btnEdit.Text = "Update"
        Me.btnEdit.UseVisualStyleBackColor = False
        '
        'btnHapus
        '
        Me.btnHapus.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.btnHapus.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHapus.ForeColor = System.Drawing.Color.White
        Me.btnHapus.Location = New System.Drawing.Point(1197, 679)
        Me.btnHapus.Margin = New System.Windows.Forms.Padding(4)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(250, 80)
        Me.btnHapus.TabIndex = 38
        Me.btnHapus.Text = "Hapus"
        Me.btnHapus.UseVisualStyleBackColor = False
        '
        'txtJumlahBarang
        '
        Me.txtJumlahBarang.BackColor = System.Drawing.SystemColors.Control
        Me.txtJumlahBarang.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtJumlahBarang.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtJumlahBarang.Location = New System.Drawing.Point(558, 365)
        Me.txtJumlahBarang.Margin = New System.Windows.Forms.Padding(4)
        Me.txtJumlahBarang.Name = "txtJumlahBarang"
        Me.txtJumlahBarang.Size = New System.Drawing.Size(234, 37)
        Me.txtJumlahBarang.TabIndex = 37
        '
        'txtNamaBarang
        '
        Me.txtNamaBarang.BackColor = System.Drawing.SystemColors.Control
        Me.txtNamaBarang.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNamaBarang.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNamaBarang.Location = New System.Drawing.Point(558, 303)
        Me.txtNamaBarang.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNamaBarang.Name = "txtNamaBarang"
        Me.txtNamaBarang.Size = New System.Drawing.Size(234, 37)
        Me.txtNamaBarang.TabIndex = 36
        '
        'cmbLokasi
        '
        Me.cmbLokasi.DisplayMember = "Admin"
        Me.cmbLokasi.FormattingEnabled = True
        Me.cmbLokasi.Location = New System.Drawing.Point(558, 487)
        Me.cmbLokasi.Name = "cmbLokasi"
        Me.cmbLokasi.Size = New System.Drawing.Size(234, 38)
        Me.cmbLokasi.TabIndex = 49
        Me.cmbLokasi.ValueMember = "Admin, Mahasiswa"
        '
        'lblLokasi
        '
        Me.lblLokasi.AutoSize = True
        Me.lblLokasi.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLokasi.ForeColor = System.Drawing.Color.Black
        Me.lblLokasi.Location = New System.Drawing.Point(347, 490)
        Me.lblLokasi.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblLokasi.Name = "lblLokasi"
        Me.lblLokasi.Size = New System.Drawing.Size(84, 30)
        Me.lblLokasi.TabIndex = 50
        Me.lblLokasi.Text = "Lokasi"
        '
        'txtMerk
        '
        Me.txtMerk.BackColor = System.Drawing.SystemColors.Control
        Me.txtMerk.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMerk.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMerk.Location = New System.Drawing.Point(558, 427)
        Me.txtMerk.Margin = New System.Windows.Forms.Padding(4)
        Me.txtMerk.Name = "txtMerk"
        Me.txtMerk.Size = New System.Drawing.Size(234, 37)
        Me.txtMerk.TabIndex = 51
        '
        'Title
        '
        Me.Title.AutoSize = True
        Me.Title.Font = New System.Drawing.Font("Century Gothic", 28.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Title.ForeColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.Title.Location = New System.Drawing.Point(341, 153)
        Me.Title.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Title.Name = "Title"
        Me.Title.Size = New System.Drawing.Size(583, 66)
        Me.Title.TabIndex = 52
        Me.Title.Text = "Pengelolaan Barang"
        '
        'FormBarang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(14.0!, 30.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1859, 1037)
        Me.Controls.Add(Me.Title)
        Me.Controls.Add(Me.txtMerk)
        Me.Controls.Add(Me.lblLokasi)
        Me.Controls.Add(Me.cmbLokasi)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.lblID)
        Me.Controls.Add(Me.btnSimpan)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.lblMerk)
        Me.Controls.Add(Me.lblJumlahBarang)
        Me.Controls.Add(Me.lblNamaBarang)
        Me.Controls.Add(Me.btnCheck)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnHapus)
        Me.Controls.Add(Me.txtJumlahBarang)
        Me.Controls.Add(Me.txtNamaBarang)
        Me.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FormBarang"
        Me.Text = "Barang"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtID As TextBox
    Friend WithEvents lblID As Label
    Friend WithEvents btnSimpan As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents lblMerk As Label
    Friend WithEvents lblJumlahBarang As Label
    Friend WithEvents lblNamaBarang As Label
    Friend WithEvents btnCheck As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnHapus As Button
    Friend WithEvents txtJumlahBarang As TextBox
    Friend WithEvents txtNamaBarang As TextBox
    Friend WithEvents cmbLokasi As ComboBox
    Friend WithEvents lblLokasi As Label
    Friend WithEvents txtMerk As TextBox
    Friend WithEvents Title As Label
End Class
