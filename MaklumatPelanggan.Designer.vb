<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMaklumatPelanggan
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
        Me.lblMaklumatPelanggan = New System.Windows.Forms.Label()
        Me.lblNama = New System.Windows.Forms.Label()
        Me.lblTelefon = New System.Windows.Forms.Label()
        Me.lblAlamat = New System.Windows.Forms.Label()
        Me.lblJantina = New System.Windows.Forms.Label()
        Me.lblNegeri = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtaddress = New System.Windows.Forms.TextBox()
        Me.rbnLelaki = New System.Windows.Forms.RadioButton()
        Me.rbnPerempuan = New System.Windows.Forms.RadioButton()
        Me.cbbNegeri = New System.Windows.Forms.ComboBox()
        Me.txtTelefon = New System.Windows.Forms.TextBox()
        Me.lblBayaran = New System.Windows.Forms.Label()
        Me.lblPerisa = New System.Windows.Forms.Label()
        Me.ckbMilo = New System.Windows.Forms.CheckBox()
        Me.ckbPisang = New System.Windows.Forms.CheckBox()
        Me.ckbStrawberi = New System.Windows.Forms.CheckBox()
        Me.ckbCoklat = New System.Windows.Forms.CheckBox()
        Me.ckbKopi = New System.Windows.Forms.CheckBox()
        Me.rbnCash = New System.Windows.Forms.RadioButton()
        Me.rbnCashless = New System.Windows.Forms.RadioButton()
        Me.bwrBlue = New System.ComponentModel.BackgroundWorker()
        Me.lblTarikh = New System.Windows.Forms.Label()
        Me.dtpTarikh = New System.Windows.Forms.DateTimePicker()
        Me.dgvData = New System.Windows.Forms.DataGridView()
        Me.btnCreate = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnRead = New System.Windows.Forms.Button()
        Me.clnBil = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clnNama = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clnNotel = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gbxBoxBayaran = New System.Windows.Forms.GroupBox()
        Me.gbxBoxJantina = New System.Windows.Forms.GroupBox()
        CType(Me.dgvData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxBoxBayaran.SuspendLayout()
        Me.gbxBoxJantina.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblMaklumatPelanggan
        '
        Me.lblMaklumatPelanggan.AutoSize = True
        Me.lblMaklumatPelanggan.Font = New System.Drawing.Font("Agency FB", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMaklumatPelanggan.Location = New System.Drawing.Point(324, 11)
        Me.lblMaklumatPelanggan.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMaklumatPelanggan.Name = "lblMaklumatPelanggan"
        Me.lblMaklumatPelanggan.Size = New System.Drawing.Size(371, 57)
        Me.lblMaklumatPelanggan.TabIndex = 1
        Me.lblMaklumatPelanggan.Text = "MAKLUMAT PELANGGAN"
        '
        'lblNama
        '
        Me.lblNama.AutoSize = True
        Me.lblNama.Location = New System.Drawing.Point(37, 119)
        Me.lblNama.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNama.Name = "lblNama"
        Me.lblNama.Size = New System.Drawing.Size(44, 16)
        Me.lblNama.TabIndex = 2
        Me.lblNama.Text = "Nama"
        '
        'lblTelefon
        '
        Me.lblTelefon.AutoSize = True
        Me.lblTelefon.Location = New System.Drawing.Point(32, 160)
        Me.lblTelefon.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTelefon.Name = "lblTelefon"
        Me.lblTelefon.Size = New System.Drawing.Size(74, 16)
        Me.lblTelefon.TabIndex = 3
        Me.lblTelefon.Text = "No.Telefon"
        '
        'lblAlamat
        '
        Me.lblAlamat.AutoSize = True
        Me.lblAlamat.Location = New System.Drawing.Point(32, 199)
        Me.lblAlamat.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblAlamat.Name = "lblAlamat"
        Me.lblAlamat.Size = New System.Drawing.Size(49, 16)
        Me.lblAlamat.TabIndex = 4
        Me.lblAlamat.Text = "Alamat"
        '
        'lblJantina
        '
        Me.lblJantina.AutoSize = True
        Me.lblJantina.Location = New System.Drawing.Point(32, 357)
        Me.lblJantina.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblJantina.Name = "lblJantina"
        Me.lblJantina.Size = New System.Drawing.Size(50, 16)
        Me.lblJantina.TabIndex = 6
        Me.lblJantina.Text = "Jantina"
        '
        'lblNegeri
        '
        Me.lblNegeri.AutoSize = True
        Me.lblNegeri.Location = New System.Drawing.Point(32, 311)
        Me.lblNegeri.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNegeri.Name = "lblNegeri"
        Me.lblNegeri.Size = New System.Drawing.Size(48, 16)
        Me.lblNegeri.TabIndex = 5
        Me.lblNegeri.Text = "Negeri"
        '
        'txtName
        '
        Me.txtName.AccessibleName = "txtBox1"
        Me.txtName.Location = New System.Drawing.Point(136, 116)
        Me.txtName.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(277, 22)
        Me.txtName.TabIndex = 7
        '
        'txtaddress
        '
        Me.txtaddress.AccessibleName = "txtBox3"
        Me.txtaddress.Location = New System.Drawing.Point(136, 196)
        Me.txtaddress.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtaddress.Multiline = True
        Me.txtaddress.Name = "txtaddress"
        Me.txtaddress.Size = New System.Drawing.Size(277, 101)
        Me.txtaddress.TabIndex = 9
        '
        'rbnLelaki
        '
        Me.rbnLelaki.AutoSize = True
        Me.rbnLelaki.Location = New System.Drawing.Point(7, 31)
        Me.rbnLelaki.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rbnLelaki.Name = "rbnLelaki"
        Me.rbnLelaki.Size = New System.Drawing.Size(64, 20)
        Me.rbnLelaki.TabIndex = 10
        Me.rbnLelaki.TabStop = True
        Me.rbnLelaki.Text = "Lelaki"
        Me.rbnLelaki.UseVisualStyleBackColor = True
        '
        'rbnPerempuan
        '
        Me.rbnPerempuan.AutoSize = True
        Me.rbnPerempuan.Location = New System.Drawing.Point(7, 58)
        Me.rbnPerempuan.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rbnPerempuan.Name = "rbnPerempuan"
        Me.rbnPerempuan.Size = New System.Drawing.Size(98, 20)
        Me.rbnPerempuan.TabIndex = 11
        Me.rbnPerempuan.TabStop = True
        Me.rbnPerempuan.Text = "Perempuan"
        Me.rbnPerempuan.UseVisualStyleBackColor = True
        '
        'cbbNegeri
        '
        Me.cbbNegeri.AccessibleName = "txtBox4"
        Me.cbbNegeri.FormattingEnabled = True
        Me.cbbNegeri.Items.AddRange(New Object() {"Perlis", "Kedah", "Pulau Pinang", "Perak", "Selangor", "Negeri Sembilan", "Melaka", "Johor", "Terengganu", "Kelatan", "Sarawak", "Sabah"})
        Me.cbbNegeri.Location = New System.Drawing.Point(136, 311)
        Me.cbbNegeri.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cbbNegeri.Name = "cbbNegeri"
        Me.cbbNegeri.Size = New System.Drawing.Size(277, 24)
        Me.cbbNegeri.TabIndex = 12
        '
        'txtTelefon
        '
        Me.txtTelefon.Location = New System.Drawing.Point(136, 160)
        Me.txtTelefon.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtTelefon.Name = "txtTelefon"
        Me.txtTelefon.Size = New System.Drawing.Size(277, 22)
        Me.txtTelefon.TabIndex = 13
        '
        'lblBayaran
        '
        Me.lblBayaran.AutoSize = True
        Me.lblBayaran.Location = New System.Drawing.Point(573, 116)
        Me.lblBayaran.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblBayaran.Name = "lblBayaran"
        Me.lblBayaran.Size = New System.Drawing.Size(111, 16)
        Me.lblBayaran.TabIndex = 14
        Me.lblBayaran.Text = "Kaedah Bayaran:"
        '
        'lblPerisa
        '
        Me.lblPerisa.AutoSize = True
        Me.lblPerisa.Location = New System.Drawing.Point(632, 226)
        Me.lblPerisa.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPerisa.Name = "lblPerisa"
        Me.lblPerisa.Size = New System.Drawing.Size(52, 16)
        Me.lblPerisa.TabIndex = 15
        Me.lblPerisa.Text = "Perisa :"
        '
        'ckbMilo
        '
        Me.ckbMilo.AutoSize = True
        Me.ckbMilo.Location = New System.Drawing.Point(721, 222)
        Me.ckbMilo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ckbMilo.Name = "ckbMilo"
        Me.ckbMilo.Size = New System.Drawing.Size(54, 20)
        Me.ckbMilo.TabIndex = 16
        Me.ckbMilo.Text = "Milo"
        Me.ckbMilo.UseVisualStyleBackColor = True
        '
        'ckbPisang
        '
        Me.ckbPisang.AutoSize = True
        Me.ckbPisang.Location = New System.Drawing.Point(721, 334)
        Me.ckbPisang.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ckbPisang.Name = "ckbPisang"
        Me.ckbPisang.Size = New System.Drawing.Size(71, 20)
        Me.ckbPisang.TabIndex = 17
        Me.ckbPisang.Text = "Pisang"
        Me.ckbPisang.UseVisualStyleBackColor = True
        '
        'ckbStrawberi
        '
        Me.ckbStrawberi.AutoSize = True
        Me.ckbStrawberi.Location = New System.Drawing.Point(721, 305)
        Me.ckbStrawberi.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ckbStrawberi.Name = "ckbStrawberi"
        Me.ckbStrawberi.Size = New System.Drawing.Size(85, 20)
        Me.ckbStrawberi.TabIndex = 18
        Me.ckbStrawberi.Text = "Strawberi"
        Me.ckbStrawberi.UseVisualStyleBackColor = True
        '
        'ckbCoklat
        '
        Me.ckbCoklat.AutoSize = True
        Me.ckbCoklat.Location = New System.Drawing.Point(721, 277)
        Me.ckbCoklat.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ckbCoklat.Name = "ckbCoklat"
        Me.ckbCoklat.Size = New System.Drawing.Size(67, 20)
        Me.ckbCoklat.TabIndex = 19
        Me.ckbCoklat.Text = "Coklat"
        Me.ckbCoklat.UseVisualStyleBackColor = True
        '
        'ckbKopi
        '
        Me.ckbKopi.AutoSize = True
        Me.ckbKopi.Location = New System.Drawing.Point(721, 249)
        Me.ckbKopi.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ckbKopi.Name = "ckbKopi"
        Me.ckbKopi.Size = New System.Drawing.Size(56, 20)
        Me.ckbKopi.TabIndex = 20
        Me.ckbKopi.Text = "Kopi"
        Me.ckbKopi.UseVisualStyleBackColor = True
        '
        'rbnCash
        '
        Me.rbnCash.AutoSize = True
        Me.rbnCash.Location = New System.Drawing.Point(32, 26)
        Me.rbnCash.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rbnCash.Name = "rbnCash"
        Me.rbnCash.Size = New System.Drawing.Size(59, 20)
        Me.rbnCash.TabIndex = 21
        Me.rbnCash.TabStop = True
        Me.rbnCash.Text = "Cash"
        Me.rbnCash.UseVisualStyleBackColor = True
        '
        'rbnCashless
        '
        Me.rbnCashless.AutoSize = True
        Me.rbnCashless.Location = New System.Drawing.Point(32, 54)
        Me.rbnCashless.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rbnCashless.Name = "rbnCashless"
        Me.rbnCashless.Size = New System.Drawing.Size(84, 20)
        Me.rbnCashless.TabIndex = 22
        Me.rbnCashless.TabStop = True
        Me.rbnCashless.Text = "Cashless"
        Me.rbnCashless.UseVisualStyleBackColor = True
        '
        'lblTarikh
        '
        Me.lblTarikh.AutoSize = True
        Me.lblTarikh.Location = New System.Drawing.Point(632, 375)
        Me.lblTarikh.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTarikh.Name = "lblTarikh"
        Me.lblTarikh.Size = New System.Drawing.Size(45, 16)
        Me.lblTarikh.TabIndex = 23
        Me.lblTarikh.Text = "Tarikh"
        '
        'dtpTarikh
        '
        Me.dtpTarikh.Location = New System.Drawing.Point(721, 375)
        Me.dtpTarikh.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dtpTarikh.Name = "dtpTarikh"
        Me.dtpTarikh.Size = New System.Drawing.Size(265, 22)
        Me.dtpTarikh.TabIndex = 24
        '
        'dgvData
        '
        Me.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvData.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.clnBil, Me.clnNama, Me.clnNotel})
        Me.dgvData.Location = New System.Drawing.Point(36, 446)
        Me.dgvData.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dgvData.Name = "dgvData"
        Me.dgvData.RowHeadersWidth = 51
        Me.dgvData.Size = New System.Drawing.Size(424, 185)
        Me.dgvData.TabIndex = 25
        '
        'btnCreate
        '
        Me.btnCreate.Location = New System.Drawing.Point(41, 638)
        Me.btnCreate.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnCreate.Name = "btnCreate"
        Me.btnCreate.Size = New System.Drawing.Size(100, 28)
        Me.btnCreate.TabIndex = 26
        Me.btnCreate.Text = "Create"
        Me.btnCreate.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(365, 638)
        Me.btnDelete.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(100, 28)
        Me.btnDelete.TabIndex = 27
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(257, 638)
        Me.btnUpdate.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(100, 28)
        Me.btnUpdate.TabIndex = 28
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnRead
        '
        Me.btnRead.Location = New System.Drawing.Point(149, 638)
        Me.btnRead.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnRead.Name = "btnRead"
        Me.btnRead.Size = New System.Drawing.Size(100, 28)
        Me.btnRead.TabIndex = 29
        Me.btnRead.Text = "Read"
        Me.btnRead.UseVisualStyleBackColor = True
        '
        'clnBil
        '
        Me.clnBil.HeaderText = "Bil"
        Me.clnBil.MinimumWidth = 6
        Me.clnBil.Name = "clnBil"
        Me.clnBil.Width = 125
        '
        'clnNama
        '
        Me.clnNama.HeaderText = "Nama"
        Me.clnNama.MinimumWidth = 6
        Me.clnNama.Name = "clnNama"
        Me.clnNama.Width = 125
        '
        'clnNotel
        '
        Me.clnNotel.HeaderText = "No_tel"
        Me.clnNotel.MinimumWidth = 6
        Me.clnNotel.Name = "clnNotel"
        Me.clnNotel.Width = 125
        '
        'gbxBoxBayaran
        '
        Me.gbxBoxBayaran.Controls.Add(Me.rbnCash)
        Me.gbxBoxBayaran.Controls.Add(Me.rbnCashless)
        Me.gbxBoxBayaran.Location = New System.Drawing.Point(691, 93)
        Me.gbxBoxBayaran.Name = "gbxBoxBayaran"
        Me.gbxBoxBayaran.Size = New System.Drawing.Size(200, 89)
        Me.gbxBoxBayaran.TabIndex = 30
        Me.gbxBoxBayaran.TabStop = False
        '
        'gbxBoxJantina
        '
        Me.gbxBoxJantina.Controls.Add(Me.rbnLelaki)
        Me.gbxBoxJantina.Controls.Add(Me.rbnPerempuan)
        Me.gbxBoxJantina.Location = New System.Drawing.Point(136, 334)
        Me.gbxBoxJantina.Name = "gbxBoxJantina"
        Me.gbxBoxJantina.Size = New System.Drawing.Size(138, 88)
        Me.gbxBoxJantina.TabIndex = 23
        Me.gbxBoxJantina.TabStop = False
        '
        'frmMaklumatPelanggan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1103, 700)
        Me.Controls.Add(Me.gbxBoxJantina)
        Me.Controls.Add(Me.gbxBoxBayaran)
        Me.Controls.Add(Me.btnRead)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnCreate)
        Me.Controls.Add(Me.dgvData)
        Me.Controls.Add(Me.dtpTarikh)
        Me.Controls.Add(Me.lblTarikh)
        Me.Controls.Add(Me.ckbKopi)
        Me.Controls.Add(Me.ckbCoklat)
        Me.Controls.Add(Me.ckbStrawberi)
        Me.Controls.Add(Me.ckbPisang)
        Me.Controls.Add(Me.ckbMilo)
        Me.Controls.Add(Me.lblPerisa)
        Me.Controls.Add(Me.lblBayaran)
        Me.Controls.Add(Me.txtTelefon)
        Me.Controls.Add(Me.cbbNegeri)
        Me.Controls.Add(Me.txtaddress)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.lblJantina)
        Me.Controls.Add(Me.lblNegeri)
        Me.Controls.Add(Me.lblAlamat)
        Me.Controls.Add(Me.lblTelefon)
        Me.Controls.Add(Me.lblNama)
        Me.Controls.Add(Me.lblMaklumatPelanggan)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frmMaklumatPelanggan"
        Me.Text = "MaklumatPelanggan"
        CType(Me.dgvData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxBoxBayaran.ResumeLayout(False)
        Me.gbxBoxBayaran.PerformLayout()
        Me.gbxBoxJantina.ResumeLayout(False)
        Me.gbxBoxJantina.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblMaklumatPelanggan As Label
    Friend WithEvents lblNama As Label
    Friend WithEvents lblTelefon As Label
    Friend WithEvents lblAlamat As Label
    Friend WithEvents lblJantina As Label
    Friend WithEvents lblNegeri As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtaddress As TextBox
    Friend WithEvents rbnLelaki As RadioButton
    Friend WithEvents rbnPerempuan As RadioButton
    Friend WithEvents cbbNegeri As ComboBox
    Friend WithEvents txtTelefon As TextBox
    Friend WithEvents lblBayaran As Label
    Friend WithEvents lblPerisa As Label
    Friend WithEvents ckbMilo As CheckBox
    Friend WithEvents ckbPisang As CheckBox
    Friend WithEvents ckbStrawberi As CheckBox
    Friend WithEvents ckbCoklat As CheckBox
    Friend WithEvents ckbKopi As CheckBox
    Friend WithEvents rbnCash As RadioButton
    Friend WithEvents rbnCashless As RadioButton
    Friend WithEvents bwrBlue As System.ComponentModel.BackgroundWorker
    Friend WithEvents lblTarikh As Label
    Friend WithEvents dtpTarikh As DateTimePicker
    Friend WithEvents dgvData As DataGridView
    Friend WithEvents btnCreate As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnRead As Button
    Friend WithEvents clnBil As DataGridViewTextBoxColumn
    Friend WithEvents clnNama As DataGridViewTextBoxColumn
    Friend WithEvents clnNotel As DataGridViewTextBoxColumn
    Friend WithEvents gbxBoxBayaran As GroupBox
    Friend WithEvents gbxBoxJantina As GroupBox
End Class
