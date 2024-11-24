<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPemeliharaan
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
        Me.cmbBarang = New System.Windows.Forms.ComboBox()
        Me.dateJadwal = New System.Windows.Forms.DateTimePicker()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.lblID = New System.Windows.Forms.Label()
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.lblJadwal = New System.Windows.Forms.Label()
        Me.lblNamaBarang = New System.Windows.Forms.Label()
        Me.btnCheck = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnHapus = New System.Windows.Forms.Button()
        Me.lblPerbaikan = New System.Windows.Forms.Label()
        Me.txtPerbaikan = New System.Windows.Forms.TextBox()
        Me.Title = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmbBarang
        '
        Me.cmbBarang.FormattingEnabled = True
        Me.cmbBarang.Location = New System.Drawing.Point(656, 311)
        Me.cmbBarang.Name = "cmbBarang"
        Me.cmbBarang.Size = New System.Drawing.Size(235, 28)
        Me.cmbBarang.TabIndex = 82
        '
        'dateJadwal
        '
        Me.dateJadwal.Location = New System.Drawing.Point(656, 365)
        Me.dateJadwal.Name = "dateJadwal"
        Me.dateJadwal.Size = New System.Drawing.Size(235, 26)
        Me.dateJadwal.TabIndex = 81
        '
        'txtID
        '
        Me.txtID.BackColor = System.Drawing.SystemColors.Control
        Me.txtID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtID.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtID.Location = New System.Drawing.Point(1008, 258)
        Me.txtID.Margin = New System.Windows.Forms.Padding(4)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(393, 37)
        Me.txtID.TabIndex = 79
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblID.ForeColor = System.Drawing.Color.Black
        Me.lblID.Location = New System.Drawing.Point(963, 260)
        Me.lblID.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(37, 30)
        Me.lblID.TabIndex = 78
        Me.lblID.Text = "ID"
        '
        'btnSimpan
        '
        Me.btnSimpan.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.btnSimpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSimpan.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSimpan.ForeColor = System.Drawing.Color.White
        Me.btnSimpan.Location = New System.Drawing.Point(656, 494)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(235, 47)
        Me.btnSimpan.TabIndex = 77
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
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(102, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.EnableHeadersVisualStyles = False
        Me.DataGridView1.GridColor = System.Drawing.Color.White
        Me.DataGridView1.Location = New System.Drawing.Point(968, 311)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.DataGridView1.TabIndex = 76
        '
        'lblJadwal
        '
        Me.lblJadwal.AutoSize = True
        Me.lblJadwal.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJadwal.ForeColor = System.Drawing.Color.Black
        Me.lblJadwal.Location = New System.Drawing.Point(352, 361)
        Me.lblJadwal.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblJadwal.Name = "lblJadwal"
        Me.lblJadwal.Size = New System.Drawing.Size(273, 30)
        Me.lblJadwal.TabIndex = 74
        Me.lblJadwal.Text = "Jadwal Pemeliharaan"
        '
        'lblNamaBarang
        '
        Me.lblNamaBarang.AutoSize = True
        Me.lblNamaBarang.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNamaBarang.ForeColor = System.Drawing.Color.Black
        Me.lblNamaBarang.Location = New System.Drawing.Point(352, 305)
        Me.lblNamaBarang.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNamaBarang.Name = "lblNamaBarang"
        Me.lblNamaBarang.Size = New System.Drawing.Size(178, 30)
        Me.lblNamaBarang.TabIndex = 73
        Me.lblNamaBarang.Text = "Nama Barang"
        '
        'btnCheck
        '
        Me.btnCheck.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.btnCheck.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCheck.ForeColor = System.Drawing.Color.White
        Me.btnCheck.Location = New System.Drawing.Point(1597, 693)
        Me.btnCheck.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCheck.Name = "btnCheck"
        Me.btnCheck.Size = New System.Drawing.Size(250, 80)
        Me.btnCheck.TabIndex = 72
        Me.btnCheck.Text = "Check"
        Me.btnCheck.UseVisualStyleBackColor = False
        '
        'btnEdit
        '
        Me.btnEdit.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.btnEdit.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEdit.ForeColor = System.Drawing.Color.White
        Me.btnEdit.Location = New System.Drawing.Point(986, 693)
        Me.btnEdit.Margin = New System.Windows.Forms.Padding(4)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(250, 80)
        Me.btnEdit.TabIndex = 71
        Me.btnEdit.Text = "Update"
        Me.btnEdit.UseVisualStyleBackColor = False
        '
        'btnHapus
        '
        Me.btnHapus.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.btnHapus.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHapus.ForeColor = System.Drawing.Color.White
        Me.btnHapus.Location = New System.Drawing.Point(1291, 693)
        Me.btnHapus.Margin = New System.Windows.Forms.Padding(4)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(250, 80)
        Me.btnHapus.TabIndex = 70
        Me.btnHapus.Text = "Hapus"
        Me.btnHapus.UseVisualStyleBackColor = False
        '
        'lblPerbaikan
        '
        Me.lblPerbaikan.AutoSize = True
        Me.lblPerbaikan.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPerbaikan.ForeColor = System.Drawing.Color.Black
        Me.lblPerbaikan.Location = New System.Drawing.Point(352, 419)
        Me.lblPerbaikan.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPerbaikan.Name = "lblPerbaikan"
        Me.lblPerbaikan.Size = New System.Drawing.Size(222, 30)
        Me.lblPerbaikan.TabIndex = 83
        Me.lblPerbaikan.Text = "Perbaikan Barang"
        '
        'txtPerbaikan
        '
        Me.txtPerbaikan.BackColor = System.Drawing.SystemColors.Control
        Me.txtPerbaikan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPerbaikan.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPerbaikan.Location = New System.Drawing.Point(656, 417)
        Me.txtPerbaikan.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPerbaikan.Name = "txtPerbaikan"
        Me.txtPerbaikan.Size = New System.Drawing.Size(235, 37)
        Me.txtPerbaikan.TabIndex = 84
        '
        'Title
        '
        Me.Title.AutoSize = True
        Me.Title.Font = New System.Drawing.Font("Century Gothic", 28.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Title.ForeColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.Title.Location = New System.Drawing.Point(341, 153)
        Me.Title.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Title.Name = "Title"
        Me.Title.Size = New System.Drawing.Size(618, 66)
        Me.Title.TabIndex = 85
        Me.Title.Text = "Pemeliharaan Barang"
        '
        'FormPemeliharaan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1924, 1037)
        Me.Controls.Add(Me.Title)
        Me.Controls.Add(Me.txtPerbaikan)
        Me.Controls.Add(Me.lblPerbaikan)
        Me.Controls.Add(Me.cmbBarang)
        Me.Controls.Add(Me.dateJadwal)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.lblID)
        Me.Controls.Add(Me.btnSimpan)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.lblJadwal)
        Me.Controls.Add(Me.lblNamaBarang)
        Me.Controls.Add(Me.btnCheck)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnHapus)
        Me.Name = "FormPemeliharaan"
        Me.Text = "Pemeliharaan"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmbBarang As ComboBox
    Friend WithEvents dateJadwal As DateTimePicker
    Friend WithEvents txtID As TextBox
    Friend WithEvents lblID As Label
    Friend WithEvents btnSimpan As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents lblJadwal As Label
    Friend WithEvents lblNamaBarang As Label
    Friend WithEvents btnCheck As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnHapus As Button
    Friend WithEvents lblPerbaikan As Label
    Friend WithEvents txtPerbaikan As TextBox
    Friend WithEvents Title As Label
End Class
