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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Panel1 = New Panel()
        Label1 = New Label()
        Label2 = New Label()
        GroupBox1 = New GroupBox()
        DateTimePicker1 = New DateTimePicker()
        txtAlamat = New RichTextBox()
        txtTelp = New TextBox()
        radioPerempuan = New RadioButton()
        radioLaki = New RadioButton()
        txtNama = New TextBox()
        Label7 = New Label()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        GroupBox2 = New GroupBox()
        txtBiaya = New TextBox()
        txtLama = New TextBox()
        txtSewa = New TextBox()
        cbJenis = New ComboBox()
        Label11 = New Label()
        Label10 = New Label()
        Label9 = New Label()
        Label8 = New Label()
        GroupBox3 = New GroupBox()
        btnClose = New Button()
        btnReset = New Button()
        GroupBox4 = New GroupBox()
        txtKembalian = New TextBox()
        txtBayar = New TextBox()
        Label13 = New Label()
        Label12 = New Label()
        Panel1.SuspendLayout()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        GroupBox3.SuspendLayout()
        GroupBox4.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), Image)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(Label2)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1095, 116)
        Panel1.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.IndianRed
        Label1.Font = New Font("Sans Serif Collection", 14.2499981F, FontStyle.Bold)
        Label1.Location = New Point(410, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(352, 47)
        Label1.TabIndex = 1
        Label1.Text = "SELAMAT DATANG DI"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.IndianRed
        Label2.Font = New Font("Sans Serif Collection", 14.2499981F, FontStyle.Bold)
        Label2.Location = New Point(432, 56)
        Label2.Name = "Label2"
        Label2.Size = New Size(319, 47)
        Label2.TabIndex = 2
        Label2.Text = "HOTEL ANTARIKSA"
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = Color.Transparent
        GroupBox1.Controls.Add(DateTimePicker1)
        GroupBox1.Controls.Add(txtAlamat)
        GroupBox1.Controls.Add(txtTelp)
        GroupBox1.Controls.Add(radioPerempuan)
        GroupBox1.Controls.Add(radioLaki)
        GroupBox1.Controls.Add(txtNama)
        GroupBox1.Controls.Add(Label7)
        GroupBox1.Controls.Add(Label6)
        GroupBox1.Controls.Add(Label5)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.ForeColor = Color.Snow
        GroupBox1.Location = New Point(27, 148)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(498, 352)
        GroupBox1.TabIndex = 1
        GroupBox1.TabStop = False
        GroupBox1.Text = "[ Registration ]"
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Location = New Point(204, 306)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(267, 23)
        DateTimePicker1.TabIndex = 10
        ' 
        ' txtAlamat
        ' 
        txtAlamat.Location = New Point(204, 205)
        txtAlamat.Name = "txtAlamat"
        txtAlamat.Size = New Size(267, 75)
        txtAlamat.TabIndex = 9
        txtAlamat.Text = ""
        ' 
        ' txtTelp
        ' 
        txtTelp.Location = New Point(204, 147)
        txtTelp.Name = "txtTelp"
        txtTelp.Size = New Size(267, 23)
        txtTelp.TabIndex = 8
        ' 
        ' radioPerempuan
        ' 
        radioPerempuan.AutoSize = True
        radioPerempuan.ForeColor = Color.Snow
        radioPerempuan.Location = New Point(318, 99)
        radioPerempuan.Name = "radioPerempuan"
        radioPerempuan.Size = New Size(86, 19)
        radioPerempuan.TabIndex = 7
        radioPerempuan.TabStop = True
        radioPerempuan.Text = "Perempuan"
        radioPerempuan.UseVisualStyleBackColor = True
        ' 
        ' radioLaki
        ' 
        radioLaki.AutoSize = True
        radioLaki.ForeColor = Color.Snow
        radioLaki.Location = New Point(204, 99)
        radioLaki.Name = "radioLaki"
        radioLaki.Size = New Size(69, 19)
        radioLaki.TabIndex = 0
        radioLaki.TabStop = True
        radioLaki.Text = "Laki-laki"
        radioLaki.UseVisualStyleBackColor = True
        ' 
        ' txtNama
        ' 
        txtNama.Location = New Point(204, 44)
        txtNama.Name = "txtNama"
        txtNama.Size = New Size(267, 23)
        txtNama.TabIndex = 5
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.IndianRed
        Label7.Location = New Point(24, 314)
        Label7.Name = "Label7"
        Label7.Size = New Size(114, 15)
        Label7.TabIndex = 4
        Label7.Text = "TANGGAL BOOKING"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.IndianRed
        Label6.Location = New Point(24, 205)
        Label6.Name = "Label6"
        Label6.Size = New Size(53, 15)
        Label6.TabIndex = 3
        Label6.Text = "ALAMAT"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.IndianRed
        Label5.Location = New Point(24, 155)
        Label5.Name = "Label5"
        Label5.Size = New Size(104, 15)
        Label5.TabIndex = 2
        Label5.Text = "NOMOR TELEPON"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.IndianRed
        Label4.Location = New Point(24, 103)
        Label4.Name = "Label4"
        Label4.Size = New Size(88, 15)
        Label4.TabIndex = 1
        Label4.Text = "JENIS KELAMIN"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.IndianRed
        Label3.Location = New Point(24, 52)
        Label3.Name = "Label3"
        Label3.Size = New Size(43, 15)
        Label3.TabIndex = 0
        Label3.Text = "NAMA"
        ' 
        ' GroupBox2
        ' 
        GroupBox2.BackColor = Color.Transparent
        GroupBox2.Controls.Add(txtBiaya)
        GroupBox2.Controls.Add(txtLama)
        GroupBox2.Controls.Add(txtSewa)
        GroupBox2.Controls.Add(cbJenis)
        GroupBox2.Controls.Add(Label11)
        GroupBox2.Controls.Add(Label10)
        GroupBox2.Controls.Add(Label9)
        GroupBox2.Controls.Add(Label8)
        GroupBox2.ForeColor = Color.Snow
        GroupBox2.Location = New Point(562, 148)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(499, 249)
        GroupBox2.TabIndex = 2
        GroupBox2.TabStop = False
        GroupBox2.Text = "[ Booking Detail ]"
        ' 
        ' txtBiaya
        ' 
        txtBiaya.Location = New Point(218, 197)
        txtBiaya.Name = "txtBiaya"
        txtBiaya.Size = New Size(255, 23)
        txtBiaya.TabIndex = 7
        ' 
        ' txtLama
        ' 
        txtLama.Location = New Point(218, 147)
        txtLama.Name = "txtLama"
        txtLama.Size = New Size(255, 23)
        txtLama.TabIndex = 6
        ' 
        ' txtSewa
        ' 
        txtSewa.Location = New Point(218, 95)
        txtSewa.Name = "txtSewa"
        txtSewa.Size = New Size(255, 23)
        txtSewa.TabIndex = 5
        ' 
        ' cbJenis
        ' 
        cbJenis.FormattingEnabled = True
        cbJenis.Items.AddRange(New Object() {"First Class", "VIP", "Kelas I", "Kelas II", "Kelas III"})
        cbJenis.Location = New Point(218, 44)
        cbJenis.Name = "cbJenis"
        cbJenis.Size = New Size(255, 23)
        cbJenis.TabIndex = 4
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.BackColor = Color.IndianRed
        Label11.Location = New Point(26, 205)
        Label11.Name = "Label11"
        Label11.Size = New Size(72, 15)
        Label11.TabIndex = 3
        Label11.Text = "BIAYA SEWA"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.BackColor = Color.IndianRed
        Label10.Location = New Point(26, 155)
        Label10.Name = "Label10"
        Label10.Size = New Size(104, 15)
        Label10.TabIndex = 2
        Label10.Text = "LAMA MENGINAP"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.BackColor = Color.IndianRed
        Label9.Location = New Point(26, 103)
        Label9.Name = "Label9"
        Label9.Size = New Size(91, 15)
        Label9.TabIndex = 1
        Label9.Text = "SEWA PER HARI"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.BackColor = Color.IndianRed
        Label8.Location = New Point(26, 52)
        Label8.Name = "Label8"
        Label8.Size = New Size(79, 15)
        Label8.TabIndex = 0
        Label8.Text = "JENIS KAMAR"
        ' 
        ' GroupBox3
        ' 
        GroupBox3.BackColor = Color.Transparent
        GroupBox3.Controls.Add(btnClose)
        GroupBox3.Controls.Add(btnReset)
        GroupBox3.ForeColor = Color.Snow
        GroupBox3.Location = New Point(27, 523)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(471, 94)
        GroupBox3.TabIndex = 2
        GroupBox3.TabStop = False
        GroupBox3.Text = "[ Navigation ]"
        ' 
        ' btnClose
        ' 
        btnClose.ForeColor = SystemColors.ActiveCaptionText
        btnClose.Location = New Point(256, 22)
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(103, 48)
        btnClose.TabIndex = 1
        btnClose.Text = "&CLOSE"
        btnClose.UseVisualStyleBackColor = True
        ' 
        ' btnReset
        ' 
        btnReset.ForeColor = SystemColors.ActiveCaptionText
        btnReset.Location = New Point(109, 22)
        btnReset.Name = "btnReset"
        btnReset.Size = New Size(103, 48)
        btnReset.TabIndex = 0
        btnReset.Text = "&RESET"
        btnReset.UseVisualStyleBackColor = True
        ' 
        ' GroupBox4
        ' 
        GroupBox4.BackColor = Color.Transparent
        GroupBox4.Controls.Add(txtKembalian)
        GroupBox4.Controls.Add(txtBayar)
        GroupBox4.Controls.Add(Label13)
        GroupBox4.Controls.Add(Label12)
        GroupBox4.ForeColor = Color.Snow
        GroupBox4.Location = New Point(562, 422)
        GroupBox4.Name = "GroupBox4"
        GroupBox4.Size = New Size(499, 195)
        GroupBox4.TabIndex = 2
        GroupBox4.TabStop = False
        GroupBox4.Text = "[ Payment ]"
        ' 
        ' txtKembalian
        ' 
        txtKembalian.Location = New Point(218, 114)
        txtKembalian.Name = "txtKembalian"
        txtKembalian.Size = New Size(255, 23)
        txtKembalian.TabIndex = 9
        ' 
        ' txtBayar
        ' 
        txtBayar.Location = New Point(218, 55)
        txtBayar.Name = "txtBayar"
        txtBayar.Size = New Size(255, 23)
        txtBayar.TabIndex = 8
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.BackColor = Color.IndianRed
        Label13.Location = New Point(26, 122)
        Label13.Name = "Label13"
        Label13.Size = New Size(121, 15)
        Label13.TabIndex = 1
        Label13.Text = "JUMLAH KEMBALIAN"
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.BackColor = Color.IndianRed
        Label12.Location = New Point(26, 63)
        Label12.Name = "Label12"
        Label12.Size = New Size(91, 15)
        Label12.TabIndex = 0
        Label12.Text = "JUMLAH BAYAR"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1095, 641)
        Controls.Add(GroupBox4)
        Controls.Add(GroupBox3)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Controls.Add(Panel1)
        Name = "Form1"
        Text = "Aplikasi Pemesan Kamar Hotel"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        GroupBox3.ResumeLayout(False)
        GroupBox4.ResumeLayout(False)
        GroupBox4.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents txtAlamat As RichTextBox
    Friend WithEvents txtTelp As TextBox
    Friend WithEvents radioPerempuan As RadioButton
    Friend WithEvents radioLaki As RadioButton
    Friend WithEvents txtNama As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents txtBiaya As TextBox
    Friend WithEvents txtLama As TextBox
    Friend WithEvents txtSewa As TextBox
    Friend WithEvents cbJenis As ComboBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents btnClose As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents txtKembalian As TextBox
    Friend WithEvents txtBayar As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label

End Class
