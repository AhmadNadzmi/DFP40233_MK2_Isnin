<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MaklumatPelanggan
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
        Me.lblTele = New System.Windows.Forms.Label()
        Me.lblAlamat = New System.Windows.Forms.Label()
        Me.lblJantina = New System.Windows.Forms.Label()
        Me.lblNegeri = New System.Windows.Forms.Label()
        Me.txtBoxName = New System.Windows.Forms.TextBox()
        Me.txtBoxaddress = New System.Windows.Forms.TextBox()
        Me.rbnLelaki = New System.Windows.Forms.RadioButton()
        Me.rbnPerempuan = New System.Windows.Forms.RadioButton()
        Me.cbNegeri = New System.Windows.Forms.ComboBox()
        Me.txtBoxTele = New System.Windows.Forms.TextBox()
        Me.lblBayaran = New System.Windows.Forms.Label()
        Me.lblPerisa = New System.Windows.Forms.Label()
        Me.ckbMilo = New System.Windows.Forms.CheckBox()
        Me.ckbPisang = New System.Windows.Forms.CheckBox()
        Me.ckbStrawberi = New System.Windows.Forms.CheckBox()
        Me.ckbCoklat = New System.Windows.Forms.CheckBox()
        Me.ckbKopi = New System.Windows.Forms.CheckBox()
        Me.rbnCash = New System.Windows.Forms.RadioButton()
        Me.rbnCashless = New System.Windows.Forms.RadioButton()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.lblTarikh = New System.Windows.Forms.Label()
        Me.dtpTarikh = New System.Windows.Forms.DateTimePicker()
        Me.dgv1 = New System.Windows.Forms.DataGridView()
        Me.Bil = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nama = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.No_tel = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnCreate = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnRead = New System.Windows.Forms.Button()
        CType(Me.dgv1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblMaklumatPelanggan
        '
        Me.lblMaklumatPelanggan.AutoSize = True
        Me.lblMaklumatPelanggan.Font = New System.Drawing.Font("Agency FB", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMaklumatPelanggan.Location = New System.Drawing.Point(243, 9)
        Me.lblMaklumatPelanggan.Name = "lblMaklumatPelanggan"
        Me.lblMaklumatPelanggan.Size = New System.Drawing.Size(299, 44)
        Me.lblMaklumatPelanggan.TabIndex = 1
        Me.lblMaklumatPelanggan.Text = "MAKLUMAT PELANGGAN"
        '
        'lblNama
        '
        Me.lblNama.AutoSize = True
        Me.lblNama.Location = New System.Drawing.Point(28, 97)
        Me.lblNama.Name = "lblNama"
        Me.lblNama.Size = New System.Drawing.Size(35, 13)
        Me.lblNama.TabIndex = 2
        Me.lblNama.Text = "Nama"
        '
        'lblTele
        '
        Me.lblTele.AutoSize = True
        Me.lblTele.Location = New System.Drawing.Point(24, 130)
        Me.lblTele.Name = "lblTele"
        Me.lblTele.Size = New System.Drawing.Size(60, 13)
        Me.lblTele.TabIndex = 3
        Me.lblTele.Text = "No.Telefon"
        '
        'lblAlamat
        '
        Me.lblAlamat.AutoSize = True
        Me.lblAlamat.Location = New System.Drawing.Point(24, 162)
        Me.lblAlamat.Name = "lblAlamat"
        Me.lblAlamat.Size = New System.Drawing.Size(39, 13)
        Me.lblAlamat.TabIndex = 4
        Me.lblAlamat.Text = "Alamat"
        '
        'lblJantina
        '
        Me.lblJantina.AutoSize = True
        Me.lblJantina.Location = New System.Drawing.Point(24, 290)
        Me.lblJantina.Name = "lblJantina"
        Me.lblJantina.Size = New System.Drawing.Size(41, 13)
        Me.lblJantina.TabIndex = 6
        Me.lblJantina.Text = "Jantina"
        '
        'lblNegeri
        '
        Me.lblNegeri.AutoSize = True
        Me.lblNegeri.Location = New System.Drawing.Point(24, 253)
        Me.lblNegeri.Name = "lblNegeri"
        Me.lblNegeri.Size = New System.Drawing.Size(38, 13)
        Me.lblNegeri.TabIndex = 5
        Me.lblNegeri.Text = "Negeri"
        '
        'txtBoxName
        '
        Me.txtBoxName.AccessibleName = "txtBox1"
        Me.txtBoxName.Location = New System.Drawing.Point(102, 94)
        Me.txtBoxName.Name = "txtBoxName"
        Me.txtBoxName.Size = New System.Drawing.Size(209, 20)
        Me.txtBoxName.TabIndex = 7
        '
        'txtBoxaddress
        '
        Me.txtBoxaddress.AccessibleName = "txtBox3"
        Me.txtBoxaddress.Location = New System.Drawing.Point(102, 159)
        Me.txtBoxaddress.Multiline = True
        Me.txtBoxaddress.Name = "txtBoxaddress"
        Me.txtBoxaddress.Size = New System.Drawing.Size(209, 83)
        Me.txtBoxaddress.TabIndex = 9
        '
        'rbnLelaki
        '
        Me.rbnLelaki.AutoSize = True
        Me.rbnLelaki.Location = New System.Drawing.Point(102, 290)
        Me.rbnLelaki.Name = "rbnLelaki"
        Me.rbnLelaki.Size = New System.Drawing.Size(53, 17)
        Me.rbnLelaki.TabIndex = 10
        Me.rbnLelaki.TabStop = True
        Me.rbnLelaki.Text = "Lelaki"
        Me.rbnLelaki.UseVisualStyleBackColor = True
        '
        'rbnPerempuan
        '
        Me.rbnPerempuan.AutoSize = True
        Me.rbnPerempuan.Location = New System.Drawing.Point(102, 313)
        Me.rbnPerempuan.Name = "rbnPerempuan"
        Me.rbnPerempuan.Size = New System.Drawing.Size(79, 17)
        Me.rbnPerempuan.TabIndex = 11
        Me.rbnPerempuan.TabStop = True
        Me.rbnPerempuan.Text = "Perempuan"
        Me.rbnPerempuan.UseVisualStyleBackColor = True
        '
        'cbNegeri
        '
        Me.cbNegeri.AccessibleName = "txtBox4"
        Me.cbNegeri.FormattingEnabled = True
        Me.cbNegeri.Items.AddRange(New Object() {"Perlis", "Kedah", "Pulau Pinang", "Perak", "Selangor", "Negeri Sembilan", "Melaka", "Johor", "Terengganu", "Kelatan", "Sarawak", "Sabah"})
        Me.cbNegeri.Location = New System.Drawing.Point(102, 253)
        Me.cbNegeri.Name = "cbNegeri"
        Me.cbNegeri.Size = New System.Drawing.Size(209, 21)
        Me.cbNegeri.TabIndex = 12
        '
        'txtBoxTele
        '
        Me.txtBoxTele.Location = New System.Drawing.Point(102, 130)
        Me.txtBoxTele.Name = "txtBoxTele"
        Me.txtBoxTele.Size = New System.Drawing.Size(209, 20)
        Me.txtBoxTele.TabIndex = 13
        '
        'lblBayaran
        '
        Me.lblBayaran.AutoSize = True
        Me.lblBayaran.Location = New System.Drawing.Point(430, 94)
        Me.lblBayaran.Name = "lblBayaran"
        Me.lblBayaran.Size = New System.Drawing.Size(89, 13)
        Me.lblBayaran.TabIndex = 14
        Me.lblBayaran.Text = "Kaedah Bayaran:"
        '
        'lblPerisa
        '
        Me.lblPerisa.AutoSize = True
        Me.lblPerisa.Location = New System.Drawing.Point(474, 184)
        Me.lblPerisa.Name = "lblPerisa"
        Me.lblPerisa.Size = New System.Drawing.Size(42, 13)
        Me.lblPerisa.TabIndex = 15
        Me.lblPerisa.Text = "Perisa :"
        '
        'ckbMilo
        '
        Me.ckbMilo.AutoSize = True
        Me.ckbMilo.Location = New System.Drawing.Point(541, 180)
        Me.ckbMilo.Name = "ckbMilo"
        Me.ckbMilo.Size = New System.Drawing.Size(45, 17)
        Me.ckbMilo.TabIndex = 16
        Me.ckbMilo.Text = "Milo"
        Me.ckbMilo.UseVisualStyleBackColor = True
        '
        'ckbPisang
        '
        Me.ckbPisang.AutoSize = True
        Me.ckbPisang.Location = New System.Drawing.Point(541, 271)
        Me.ckbPisang.Name = "ckbPisang"
        Me.ckbPisang.Size = New System.Drawing.Size(58, 17)
        Me.ckbPisang.TabIndex = 17
        Me.ckbPisang.Text = "Pisang"
        Me.ckbPisang.UseVisualStyleBackColor = True
        '
        'ckbStrawberi
        '
        Me.ckbStrawberi.AutoSize = True
        Me.ckbStrawberi.Location = New System.Drawing.Point(541, 248)
        Me.ckbStrawberi.Name = "ckbStrawberi"
        Me.ckbStrawberi.Size = New System.Drawing.Size(70, 17)
        Me.ckbStrawberi.TabIndex = 18
        Me.ckbStrawberi.Text = "Strawberi"
        Me.ckbStrawberi.UseVisualStyleBackColor = True
        '
        'ckbCoklat
        '
        Me.ckbCoklat.AutoSize = True
        Me.ckbCoklat.Location = New System.Drawing.Point(541, 225)
        Me.ckbCoklat.Name = "ckbCoklat"
        Me.ckbCoklat.Size = New System.Drawing.Size(56, 17)
        Me.ckbCoklat.TabIndex = 19
        Me.ckbCoklat.Text = "Coklat"
        Me.ckbCoklat.UseVisualStyleBackColor = True
        '
        'ckbKopi
        '
        Me.ckbKopi.AutoSize = True
        Me.ckbKopi.Location = New System.Drawing.Point(541, 202)
        Me.ckbKopi.Name = "ckbKopi"
        Me.ckbKopi.Size = New System.Drawing.Size(47, 17)
        Me.ckbKopi.TabIndex = 20
        Me.ckbKopi.Text = "Kopi"
        Me.ckbKopi.UseVisualStyleBackColor = True
        '
        'rbnCash
        '
        Me.rbnCash.AutoSize = True
        Me.rbnCash.Location = New System.Drawing.Point(541, 94)
        Me.rbnCash.Name = "rbnCash"
        Me.rbnCash.Size = New System.Drawing.Size(49, 17)
        Me.rbnCash.TabIndex = 21
        Me.rbnCash.TabStop = True
        Me.rbnCash.Text = "Cash"
        Me.rbnCash.UseVisualStyleBackColor = True
        '
        'rbnCashless
        '
        Me.rbnCashless.AutoSize = True
        Me.rbnCashless.Location = New System.Drawing.Point(541, 117)
        Me.rbnCashless.Name = "rbnCashless"
        Me.rbnCashless.Size = New System.Drawing.Size(67, 17)
        Me.rbnCashless.TabIndex = 22
        Me.rbnCashless.TabStop = True
        Me.rbnCashless.Text = "Cashless"
        Me.rbnCashless.UseVisualStyleBackColor = True
        '
        'lblTarikh
        '
        Me.lblTarikh.AutoSize = True
        Me.lblTarikh.Location = New System.Drawing.Point(474, 305)
        Me.lblTarikh.Name = "lblTarikh"
        Me.lblTarikh.Size = New System.Drawing.Size(37, 13)
        Me.lblTarikh.TabIndex = 23
        Me.lblTarikh.Text = "Tarikh"
        '
        'dtpTarikh
        '
        Me.dtpTarikh.Location = New System.Drawing.Point(541, 305)
        Me.dtpTarikh.Name = "dtpTarikh"
        Me.dtpTarikh.Size = New System.Drawing.Size(200, 20)
        Me.dtpTarikh.TabIndex = 24
        '
        'dgv1
        '
        Me.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Bil, Me.Nama, Me.No_tel})
        Me.dgv1.Location = New System.Drawing.Point(27, 362)
        Me.dgv1.Name = "dgv1"
        Me.dgv1.RowHeadersWidth = 51
        Me.dgv1.Size = New System.Drawing.Size(318, 150)
        Me.dgv1.TabIndex = 25
        '
        'Bil
        '
        Me.Bil.HeaderText = "Bil"
        Me.Bil.MinimumWidth = 6
        Me.Bil.Name = "Bil"
        Me.Bil.Width = 125
        '
        'Nama
        '
        Me.Nama.HeaderText = "Nama"
        Me.Nama.MinimumWidth = 6
        Me.Nama.Name = "Nama"
        Me.Nama.Width = 125
        '
        'No_tel
        '
        Me.No_tel.HeaderText = "No_tel"
        Me.No_tel.MinimumWidth = 6
        Me.No_tel.Name = "No_tel"
        Me.No_tel.Width = 125
        '
        'btnCreate
        '
        Me.btnCreate.Location = New System.Drawing.Point(31, 518)
        Me.btnCreate.Name = "btnCreate"
        Me.btnCreate.Size = New System.Drawing.Size(75, 23)
        Me.btnCreate.TabIndex = 26
        Me.btnCreate.Text = "Create"
        Me.btnCreate.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(274, 518)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 23)
        Me.btnDelete.TabIndex = 27
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(193, 518)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(75, 23)
        Me.btnUpdate.TabIndex = 28
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnRead
        '
        Me.btnRead.Location = New System.Drawing.Point(112, 518)
        Me.btnRead.Name = "btnRead"
        Me.btnRead.Size = New System.Drawing.Size(75, 23)
        Me.btnRead.TabIndex = 29
        Me.btnRead.Text = "Read"
        Me.btnRead.UseVisualStyleBackColor = True
        '
        'MaklumatPelanggan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(827, 569)
        Me.Controls.Add(Me.btnRead)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnCreate)
        Me.Controls.Add(Me.dgv1)
        Me.Controls.Add(Me.dtpTarikh)
        Me.Controls.Add(Me.lblTarikh)
        Me.Controls.Add(Me.rbnCashless)
        Me.Controls.Add(Me.rbnCash)
        Me.Controls.Add(Me.ckbKopi)
        Me.Controls.Add(Me.ckbCoklat)
        Me.Controls.Add(Me.ckbStrawberi)
        Me.Controls.Add(Me.ckbPisang)
        Me.Controls.Add(Me.ckbMilo)
        Me.Controls.Add(Me.lblPerisa)
        Me.Controls.Add(Me.lblBayaran)
        Me.Controls.Add(Me.txtBoxTele)
        Me.Controls.Add(Me.cbNegeri)
        Me.Controls.Add(Me.rbnPerempuan)
        Me.Controls.Add(Me.rbnLelaki)
        Me.Controls.Add(Me.txtBoxaddress)
        Me.Controls.Add(Me.txtBoxName)
        Me.Controls.Add(Me.lblJantina)
        Me.Controls.Add(Me.lblNegeri)
        Me.Controls.Add(Me.lblAlamat)
        Me.Controls.Add(Me.lblTele)
        Me.Controls.Add(Me.lblNama)
        Me.Controls.Add(Me.lblMaklumatPelanggan)
        Me.Name = "MaklumatPelanggan"
        Me.Text = "MaklumatPelanggan"
        CType(Me.dgv1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblMaklumatPelanggan As Label
    Friend WithEvents lblNama As Label
    Friend WithEvents lblTele As Label
    Friend WithEvents lblAlamat As Label
    Friend WithEvents lblJantina As Label
    Friend WithEvents lblNegeri As Label
    Friend WithEvents txtBoxName As TextBox
    Friend WithEvents txtBoxaddress As TextBox
    Friend WithEvents rbnLelaki As RadioButton
    Friend WithEvents rbnPerempuan As RadioButton
    Friend WithEvents cbNegeri As ComboBox
    Friend WithEvents txtBoxTele As TextBox
    Friend WithEvents lblBayaran As Label
    Friend WithEvents lblPerisa As Label
    Friend WithEvents ckbMilo As CheckBox
    Friend WithEvents ckbPisang As CheckBox
    Friend WithEvents ckbStrawberi As CheckBox
    Friend WithEvents ckbCoklat As CheckBox
    Friend WithEvents ckbKopi As CheckBox
    Friend WithEvents rbnCash As RadioButton
    Friend WithEvents rbnCashless As RadioButton
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents lblTarikh As Label
    Friend WithEvents dtpTarikh As DateTimePicker
    Friend WithEvents dgv1 As DataGridView
    Friend WithEvents Bil As DataGridViewTextBoxColumn
    Friend WithEvents Nama As DataGridViewTextBoxColumn
    Friend WithEvents No_tel As DataGridViewTextBoxColumn
    Friend WithEvents btnCreate As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnRead As Button
End Class
