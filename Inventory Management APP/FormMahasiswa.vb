Imports FontAwesome.Sharp
Imports MySql.Data.MySqlClient

Public Class FormMahasiswa
    Private currentBtn As IconButton
    Private leftBorderBtn As Panel
    Private currentForm As Form

    Dim Conn As MySqlConnection
    Dim MyDB As String

    Private Sub FormMahasiswa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InitializeForm()
        Timer1.Start()
        dbconn()
    End Sub

    Private Sub InitializeForm()
        leftBorderBtn = New Panel() With {.Size = New Size(7, 64)}
        panelMenu.Controls.Add(leftBorderBtn)
    End Sub

    Sub Koneksi()
        MyDB = "server=localhost;userid=root;password='';database=db_inventaris"
        Conn = New MySqlConnection(MyDB)
        If Conn.State = ConnectionState.Closed Then Conn.Open()
    End Sub

    Private Sub ActivateButton(senderBtn As Object)
        If senderBtn IsNot Nothing Then
            DisableButton()
            currentBtn = CType(senderBtn, IconButton)
            ConfigureButton(currentBtn, Color.White, Color.FromArgb(23, 55, 94), ContentAlignment.MiddleCenter, ContentAlignment.MiddleRight, TextImageRelation.ImageBeforeText)
            ConfigureLeftBorderBtn(currentBtn.Location.Y)
            ConfigureCurrentFormIcon(currentBtn.IconChar)
        End If
    End Sub

    Private Sub DisableButton()
        If currentBtn IsNot Nothing Then
            ConfigureButton(currentBtn, Color.FromArgb(0, 51, 102), Color.Gainsboro, ContentAlignment.MiddleLeft, ContentAlignment.MiddleLeft, TextImageRelation.ImageBeforeText)
        End If
    End Sub

    Private Sub Reset()
        DisableButton()
        leftBorderBtn.Visible = False
        iconTitle.IconChar = IconChar.Home
        lblTitle.Text = "Home"
    End Sub

    Private Sub CloseCurrentForm()
        If currentForm IsNot Nothing Then currentForm.Close()
    End Sub

    Private Sub OpenChildForm(childForm As Form)
        CloseCurrentForm()
        currentForm = childForm
        ConfigureChildForm(childForm)
        ShowChildForm(childForm)
    End Sub

    Private Sub ConfigureChildForm(childForm As Form)
        childForm.TopLevel = False
        childForm.FormBorderStyle = FormBorderStyle.None
        childForm.Dock = DockStyle.Fill
    End Sub

    Private Sub ShowChildForm(childForm As Form)
        panelDesktop.Controls.Add(childForm)
        panelDesktop.Tag = childForm
        childForm.BringToFront()
        childForm.Show()
        lblTitle.Text = childForm.Text
    End Sub

    Private Sub ConfigureButton(button As IconButton, backColor As Color, foreColor As Color, textAlign As ContentAlignment, imageAlign As ContentAlignment, textImageRelation As TextImageRelation)
        button.BackColor = backColor
        button.ForeColor = foreColor
        button.IconColor = foreColor
        button.TextAlign = textAlign
        button.ImageAlign = imageAlign
        button.TextImageRelation = textImageRelation
    End Sub

    Private Sub ConfigureLeftBorderBtn(locationY As Integer)
        leftBorderBtn.BackColor = Color.FromArgb(23, 55, 94)
        leftBorderBtn.Location = New Point(0, locationY)
        leftBorderBtn.Visible = True
        leftBorderBtn.BringToFront()
    End Sub

    Private Sub ConfigureCurrentFormIcon(iconChar As IconChar)
        iconTitle.IconChar = iconChar
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim HH As Integer = DateTime.Now.Hour
        Dim MM As Integer = DateTime.Now.Minute
        Dim SS As Integer = DateTime.Now.Second
        Dim TIME As String = String.Format("{0:D2}:{1:D2}:{2:D2}", HH, MM, SS)
        lblTime.Text = TIME
    End Sub

    Private Sub btnInventaris_Click(sender As Object, e As EventArgs) Handles btnInventaris.Click
        ActivateButton(sender)
        OpenChildForm(New FormInventaris)
    End Sub

    Private Sub btnDashboard_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click
        CloseCurrentForm()
        Reset()
    End Sub

    Private Sub btnPeminjaman_Click(sender As Object, e As EventArgs) Handles btnPeminjaman.Click
        ActivateButton(sender)
        OpenChildForm(New FormPeminjaman)
    End Sub

    Private Sub btnStatus_Click(sender As Object, e As EventArgs) Handles btnStatus.Click
        ActivateButton(sender)
        OpenChildForm(New FormStatus)
    End Sub

    Private Sub btnKeluar_Click(sender As Object, e As EventArgs) Handles btnKeluar.Click
        ActivateButton(sender)
        FormLogin.Show()
        Me.Hide()
    End Sub
End Class