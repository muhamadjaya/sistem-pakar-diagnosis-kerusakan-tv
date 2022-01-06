<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class f_pengetahuan
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
        Me.components = New System.ComponentModel.Container()
        Dim Label3 As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim Kd_karyawanLabel As System.Windows.Forms.Label
        Dim KaryawanLabel As System.Windows.Forms.Label
        Dim AlamatLabel As System.Windows.Forms.Label
        Dim JkLabel As System.Windows.Forms.Label
        Dim CpLabel As System.Windows.Forms.Label
        Dim JabatanLabel As System.Windows.Forms.Label
        Dim User_nameLabel As System.Windows.Forms.Label
        Dim SandiLabel As System.Windows.Forms.Label
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.txt_kd_pengetahuan = New System.Windows.Forms.TextBox()
        Me.txt_fakta_ya = New System.Windows.Forms.TextBox()
        Me.txt_pertanyaan = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.cmd_perbarui = New System.Windows.Forms.Button()
        Me.cmd_simpan = New System.Windows.Forms.Button()
        Me.cmd_tambah = New System.Windows.Forms.Button()
        Me.gb_pengetahuan = New System.Windows.Forms.GroupBox()
        Me.txt_kd_kerusakan = New System.Windows.Forms.TextBox()
        Me.bs_jenis_kerusakan = New System.Windows.Forms.BindingSource(Me.components)
        Me.Db_sistempakarDataSet = New SISTEM_PAKAR_DIAGNOSIS_KERUSAKAN_TV.db_sistempakarDataSet()
        Me.txt_fakta_tidak = New System.Windows.Forms.TextBox()
        Me.cb_jika_tidak = New System.Windows.Forms.ComboBox()
        Me.cb_jika_ya = New System.Windows.Forms.ComboBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.cmd_keluar = New System.Windows.Forms.Button()
        Me.cmd_hapus = New System.Windows.Forms.Button()
        Me.cb_kerusakan = New System.Windows.Forms.ComboBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.dgv_pengetahuan = New System.Windows.Forms.DataGridView()
        Me.KdpengetahuanDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PertanyaanDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FaktayaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FaktatidakDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.YaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TidakDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KdkerusakanDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bs_pengetahuan = New System.Windows.Forms.BindingSource(Me.components)
        Me.cmd_refresh = New System.Windows.Forms.Button()
        Me.txt_cari_pengetahuan = New System.Windows.Forms.TextBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.cb_berdasarkan_pengetahuan = New System.Windows.Forms.ComboBox()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmd_input_jenis_kerusakan = New System.Windows.Forms.Button()
        Me.cmd_refresh1 = New System.Windows.Forms.Button()
        Me.txt_cari_jenis_kerusakan = New System.Windows.Forms.TextBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.cb_berdasarkan_jenis_kerusakan = New System.Windows.Forms.ComboBox()
        Me.dgv_jenis_kerusakan = New System.Windows.Forms.DataGridView()
        Me.KdkerusakanDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.JeniskerusakanDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cmd_input_solusi = New System.Windows.Forms.Button()
        Me.cmd_refresh2 = New System.Windows.Forms.Button()
        Me.txt_cari_solusi = New System.Windows.Forms.TextBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.cb_berdasarkan_solusi = New System.Windows.Forms.ComboBox()
        Me.dgv_solusi = New System.Windows.Forms.DataGridView()
        Me.KdsolusiDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SolusiDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bs_solusi = New System.Windows.Forms.BindingSource(Me.components)
        Me.ta_jenis_kerusakan = New SISTEM_PAKAR_DIAGNOSIS_KERUSAKAN_TV.db_sistempakarDataSetTableAdapters.tb_jenis_kerusakanTableAdapter()
        Me.ta_solusi = New SISTEM_PAKAR_DIAGNOSIS_KERUSAKAN_TV.db_sistempakarDataSetTableAdapters.tb_solusiTableAdapter()
        Me.ta_pengetahuan = New SISTEM_PAKAR_DIAGNOSIS_KERUSAKAN_TV.db_sistempakarDataSetTableAdapters.tb_pengetahuanTableAdapter()
        Me.TableAdapterManager = New SISTEM_PAKAR_DIAGNOSIS_KERUSAKAN_TV.db_sistempakarDataSetTableAdapters.TableAdapterManager()
        Label3 = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        Kd_karyawanLabel = New System.Windows.Forms.Label()
        KaryawanLabel = New System.Windows.Forms.Label()
        AlamatLabel = New System.Windows.Forms.Label()
        JkLabel = New System.Windows.Forms.Label()
        CpLabel = New System.Windows.Forms.Label()
        JabatanLabel = New System.Windows.Forms.Label()
        User_nameLabel = New System.Windows.Forms.Label()
        SandiLabel = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.gb_pengetahuan.SuspendLayout()
        CType(Me.bs_jenis_kerusakan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Db_sistempakarDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dgv_pengetahuan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bs_pengetahuan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.dgv_jenis_kerusakan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        CType(Me.dgv_solusi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bs_solusi, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.BackColor = System.Drawing.Color.Transparent
        Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label3.ForeColor = System.Drawing.Color.White
        Label3.Location = New System.Drawing.Point(718, 17)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(291, 24)
        Label3.TabIndex = 21
        Label3.Text = "DATA BASIS PENGETAHUAN"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.BackColor = System.Drawing.Color.Transparent
        Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label2.ForeColor = System.Drawing.Color.White
        Label2.Location = New System.Drawing.Point(12, 33)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(271, 25)
        Label2.TabIndex = 20
        Label2.Text = "Diagnosis Kerusakan TV"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.BackColor = System.Drawing.Color.Transparent
        Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label1.ForeColor = System.Drawing.Color.White
        Label1.Location = New System.Drawing.Point(12, 4)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(200, 29)
        Label1.TabIndex = 19
        Label1.Text = "SISTEM PAKAR"
        '
        'Kd_karyawanLabel
        '
        Kd_karyawanLabel.AutoSize = True
        Kd_karyawanLabel.BackColor = System.Drawing.Color.White
        Kd_karyawanLabel.Location = New System.Drawing.Point(10, 77)
        Kd_karyawanLabel.Name = "Kd_karyawanLabel"
        Kd_karyawanLabel.Size = New System.Drawing.Size(105, 13)
        Kd_karyawanLabel.TabIndex = 1
        Kd_karyawanLabel.Text = "Kode Pengetahuan :"
        '
        'KaryawanLabel
        '
        KaryawanLabel.AutoSize = True
        KaryawanLabel.BackColor = System.Drawing.Color.White
        KaryawanLabel.Location = New System.Drawing.Point(51, 103)
        KaryawanLabel.Name = "KaryawanLabel"
        KaryawanLabel.Size = New System.Drawing.Size(64, 13)
        KaryawanLabel.TabIndex = 3
        KaryawanLabel.Text = "Kerusakan :"
        '
        'AlamatLabel
        '
        AlamatLabel.AutoSize = True
        AlamatLabel.BackColor = System.Drawing.Color.White
        AlamatLabel.Location = New System.Drawing.Point(40, 263)
        AlamatLabel.Name = "AlamatLabel"
        AlamatLabel.Size = New System.Drawing.Size(75, 13)
        AlamatLabel.TabIndex = 5
        AlamatLabel.Text = "Fakta TIDAK :"
        '
        'JkLabel
        '
        JkLabel.AutoSize = True
        JkLabel.BackColor = System.Drawing.Color.White
        JkLabel.Location = New System.Drawing.Point(23, 131)
        JkLabel.Name = "JkLabel"
        JkLabel.Size = New System.Drawing.Size(92, 13)
        JkLabel.TabIndex = 7
        JkLabel.Text = "Kode Kerusakan :"
        '
        'CpLabel
        '
        CpLabel.AutoSize = True
        CpLabel.BackColor = System.Drawing.Color.White
        CpLabel.Location = New System.Drawing.Point(48, 157)
        CpLabel.Name = "CpLabel"
        CpLabel.Size = New System.Drawing.Size(67, 13)
        CpLabel.TabIndex = 9
        CpLabel.Text = "Pertanyaan :"
        '
        'JabatanLabel
        '
        JabatanLabel.AutoSize = True
        JabatanLabel.BackColor = System.Drawing.Color.White
        JabatanLabel.Location = New System.Drawing.Point(58, 237)
        JabatanLabel.Name = "JabatanLabel"
        JabatanLabel.Size = New System.Drawing.Size(57, 13)
        JabatanLabel.TabIndex = 11
        JabatanLabel.Text = "Fakta YA :"
        '
        'User_nameLabel
        '
        User_nameLabel.AutoSize = True
        User_nameLabel.BackColor = System.Drawing.Color.White
        User_nameLabel.Location = New System.Drawing.Point(66, 289)
        User_nameLabel.Name = "User_nameLabel"
        User_nameLabel.Size = New System.Drawing.Size(49, 13)
        User_nameLabel.TabIndex = 13
        User_nameLabel.Text = "Jika YA :"
        '
        'SandiLabel
        '
        SandiLabel.AutoSize = True
        SandiLabel.BackColor = System.Drawing.Color.White
        SandiLabel.Location = New System.Drawing.Point(48, 316)
        SandiLabel.Name = "SandiLabel"
        SandiLabel.Size = New System.Drawing.Size(67, 13)
        SandiLabel.TabIndex = 15
        SandiLabel.Text = "Jika TIDAK :"
        '
        'txt_kd_pengetahuan
        '
        Me.txt_kd_pengetahuan.Enabled = False
        Me.txt_kd_pengetahuan.Location = New System.Drawing.Point(122, 74)
        Me.txt_kd_pengetahuan.Name = "txt_kd_pengetahuan"
        Me.txt_kd_pengetahuan.Size = New System.Drawing.Size(149, 20)
        Me.txt_kd_pengetahuan.TabIndex = 2
        '
        'txt_fakta_ya
        '
        Me.txt_fakta_ya.Location = New System.Drawing.Point(122, 234)
        Me.txt_fakta_ya.Name = "txt_fakta_ya"
        Me.txt_fakta_ya.Size = New System.Drawing.Size(280, 20)
        Me.txt_fakta_ya.TabIndex = 10
        '
        'txt_pertanyaan
        '
        Me.txt_pertanyaan.Location = New System.Drawing.Point(122, 154)
        Me.txt_pertanyaan.Multiline = True
        Me.txt_pertanyaan.Name = "txt_pertanyaan"
        Me.txt_pertanyaan.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txt_pertanyaan.Size = New System.Drawing.Size(280, 74)
        Me.txt_pertanyaan.TabIndex = 8
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DodgerBlue
        Me.Panel1.Controls.Add(Label3)
        Me.Panel1.Controls.Add(Label2)
        Me.Panel1.Controls.Add(Label1)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1020, 75)
        Me.Panel1.TabIndex = 33
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Gold
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 62)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1020, 13)
        Me.Panel2.TabIndex = 0
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.Control
        Me.Panel3.Controls.Add(Me.cmd_perbarui)
        Me.Panel3.Controls.Add(Me.cmd_simpan)
        Me.Panel3.Controls.Add(Me.cmd_tambah)
        Me.Panel3.Location = New System.Drawing.Point(13, 19)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(233, 46)
        Me.Panel3.TabIndex = 35
        '
        'cmd_perbarui
        '
        Me.cmd_perbarui.BackColor = System.Drawing.Color.DodgerBlue
        Me.cmd_perbarui.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_perbarui.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_perbarui.ForeColor = System.Drawing.Color.White
        Me.cmd_perbarui.Location = New System.Drawing.Point(155, 6)
        Me.cmd_perbarui.Name = "cmd_perbarui"
        Me.cmd_perbarui.Size = New System.Drawing.Size(75, 35)
        Me.cmd_perbarui.TabIndex = 2
        Me.cmd_perbarui.Text = "&Perbarui"
        Me.cmd_perbarui.UseVisualStyleBackColor = False
        '
        'cmd_simpan
        '
        Me.cmd_simpan.BackColor = System.Drawing.Color.DodgerBlue
        Me.cmd_simpan.Enabled = False
        Me.cmd_simpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_simpan.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_simpan.ForeColor = System.Drawing.Color.White
        Me.cmd_simpan.Location = New System.Drawing.Point(79, 6)
        Me.cmd_simpan.Name = "cmd_simpan"
        Me.cmd_simpan.Size = New System.Drawing.Size(75, 35)
        Me.cmd_simpan.TabIndex = 1
        Me.cmd_simpan.Text = "&Simpan"
        Me.cmd_simpan.UseVisualStyleBackColor = False
        '
        'cmd_tambah
        '
        Me.cmd_tambah.BackColor = System.Drawing.Color.DodgerBlue
        Me.cmd_tambah.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_tambah.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_tambah.ForeColor = System.Drawing.Color.White
        Me.cmd_tambah.Location = New System.Drawing.Point(3, 6)
        Me.cmd_tambah.Name = "cmd_tambah"
        Me.cmd_tambah.Size = New System.Drawing.Size(75, 35)
        Me.cmd_tambah.TabIndex = 0
        Me.cmd_tambah.Text = "&Tambah"
        Me.cmd_tambah.UseVisualStyleBackColor = False
        '
        'gb_pengetahuan
        '
        Me.gb_pengetahuan.Controls.Add(Me.txt_kd_kerusakan)
        Me.gb_pengetahuan.Controls.Add(Me.txt_fakta_tidak)
        Me.gb_pengetahuan.Controls.Add(Me.cb_jika_tidak)
        Me.gb_pengetahuan.Controls.Add(Me.Panel3)
        Me.gb_pengetahuan.Controls.Add(Me.cb_jika_ya)
        Me.gb_pengetahuan.Controls.Add(Me.Panel4)
        Me.gb_pengetahuan.Controls.Add(Me.cb_kerusakan)
        Me.gb_pengetahuan.Controls.Add(Me.GroupBox3)
        Me.gb_pengetahuan.Controls.Add(Kd_karyawanLabel)
        Me.gb_pengetahuan.Controls.Add(Me.txt_kd_pengetahuan)
        Me.gb_pengetahuan.Controls.Add(KaryawanLabel)
        Me.gb_pengetahuan.Controls.Add(AlamatLabel)
        Me.gb_pengetahuan.Controls.Add(JkLabel)
        Me.gb_pengetahuan.Controls.Add(Me.txt_fakta_ya)
        Me.gb_pengetahuan.Controls.Add(CpLabel)
        Me.gb_pengetahuan.Controls.Add(JabatanLabel)
        Me.gb_pengetahuan.Controls.Add(Me.txt_pertanyaan)
        Me.gb_pengetahuan.Controls.Add(User_nameLabel)
        Me.gb_pengetahuan.Controls.Add(SandiLabel)
        Me.gb_pengetahuan.Location = New System.Drawing.Point(12, 78)
        Me.gb_pengetahuan.Name = "gb_pengetahuan"
        Me.gb_pengetahuan.Size = New System.Drawing.Size(430, 607)
        Me.gb_pengetahuan.TabIndex = 31
        Me.gb_pengetahuan.TabStop = False
        Me.gb_pengetahuan.Text = "Basis Pengetahuan"
        '
        'txt_kd_kerusakan
        '
        Me.txt_kd_kerusakan.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bs_jenis_kerusakan, "kd_kerusakan", True))
        Me.txt_kd_kerusakan.Location = New System.Drawing.Point(121, 128)
        Me.txt_kd_kerusakan.Name = "txt_kd_kerusakan"
        Me.txt_kd_kerusakan.Size = New System.Drawing.Size(150, 20)
        Me.txt_kd_kerusakan.TabIndex = 37
        '
        'bs_jenis_kerusakan
        '
        Me.bs_jenis_kerusakan.DataMember = "tb_jenis_kerusakan"
        Me.bs_jenis_kerusakan.DataSource = Me.Db_sistempakarDataSet
        '
        'Db_sistempakarDataSet
        '
        Me.Db_sistempakarDataSet.DataSetName = "db_sistempakarDataSet"
        Me.Db_sistempakarDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'txt_fakta_tidak
        '
        Me.txt_fakta_tidak.Location = New System.Drawing.Point(121, 260)
        Me.txt_fakta_tidak.Name = "txt_fakta_tidak"
        Me.txt_fakta_tidak.Size = New System.Drawing.Size(280, 20)
        Me.txt_fakta_tidak.TabIndex = 12
        '
        'cb_jika_tidak
        '
        Me.cb_jika_tidak.BackColor = System.Drawing.Color.White
        Me.cb_jika_tidak.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_jika_tidak.FormattingEnabled = True
        Me.cb_jika_tidak.Location = New System.Drawing.Point(121, 313)
        Me.cb_jika_tidak.Name = "cb_jika_tidak"
        Me.cb_jika_tidak.Size = New System.Drawing.Size(150, 21)
        Me.cb_jika_tidak.TabIndex = 16
        '
        'cb_jika_ya
        '
        Me.cb_jika_ya.BackColor = System.Drawing.Color.White
        Me.cb_jika_ya.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_jika_ya.FormattingEnabled = True
        Me.cb_jika_ya.Location = New System.Drawing.Point(121, 286)
        Me.cb_jika_ya.Name = "cb_jika_ya"
        Me.cb_jika_ya.Size = New System.Drawing.Size(150, 21)
        Me.cb_jika_ya.TabIndex = 14
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.SystemColors.Control
        Me.Panel4.Controls.Add(Me.cmd_keluar)
        Me.Panel4.Controls.Add(Me.cmd_hapus)
        Me.Panel4.Location = New System.Drawing.Point(251, 19)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(158, 46)
        Me.Panel4.TabIndex = 36
        '
        'cmd_keluar
        '
        Me.cmd_keluar.BackColor = System.Drawing.Color.Orange
        Me.cmd_keluar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_keluar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_keluar.ForeColor = System.Drawing.Color.White
        Me.cmd_keluar.Location = New System.Drawing.Point(79, 6)
        Me.cmd_keluar.Name = "cmd_keluar"
        Me.cmd_keluar.Size = New System.Drawing.Size(75, 35)
        Me.cmd_keluar.TabIndex = 4
        Me.cmd_keluar.Text = "&Keluar"
        Me.cmd_keluar.UseVisualStyleBackColor = False
        '
        'cmd_hapus
        '
        Me.cmd_hapus.BackColor = System.Drawing.Color.Orange
        Me.cmd_hapus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_hapus.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_hapus.ForeColor = System.Drawing.Color.White
        Me.cmd_hapus.Location = New System.Drawing.Point(3, 6)
        Me.cmd_hapus.Name = "cmd_hapus"
        Me.cmd_hapus.Size = New System.Drawing.Size(75, 35)
        Me.cmd_hapus.TabIndex = 3
        Me.cmd_hapus.Text = "&Hapus"
        Me.cmd_hapus.UseVisualStyleBackColor = False
        '
        'cb_kerusakan
        '
        Me.cb_kerusakan.BackColor = System.Drawing.Color.White
        Me.cb_kerusakan.DataSource = Me.bs_jenis_kerusakan
        Me.cb_kerusakan.DisplayMember = "jenis_kerusakan"
        Me.cb_kerusakan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_kerusakan.FormattingEnabled = True
        Me.cb_kerusakan.Location = New System.Drawing.Point(121, 100)
        Me.cb_kerusakan.Name = "cb_kerusakan"
        Me.cb_kerusakan.Size = New System.Drawing.Size(280, 21)
        Me.cb_kerusakan.TabIndex = 4
        Me.cb_kerusakan.ValueMember = "kd_kerusakan"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.dgv_pengetahuan)
        Me.GroupBox3.Controls.Add(Me.cmd_refresh)
        Me.GroupBox3.Controls.Add(Me.txt_cari_pengetahuan)
        Me.GroupBox3.Controls.Add(Me.GroupBox5)
        Me.GroupBox3.Location = New System.Drawing.Point(13, 346)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(397, 241)
        Me.GroupBox3.TabIndex = 32
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Data Basis Pengetahuan"
        '
        'dgv_pengetahuan
        '
        Me.dgv_pengetahuan.AllowUserToAddRows = False
        Me.dgv_pengetahuan.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Window
        Me.dgv_pengetahuan.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv_pengetahuan.AutoGenerateColumns = False
        Me.dgv_pengetahuan.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.RoyalBlue
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_pengetahuan.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgv_pengetahuan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_pengetahuan.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.KdpengetahuanDataGridViewTextBoxColumn, Me.PertanyaanDataGridViewTextBoxColumn, Me.FaktayaDataGridViewTextBoxColumn, Me.FaktatidakDataGridViewTextBoxColumn, Me.YaDataGridViewTextBoxColumn, Me.TidakDataGridViewTextBoxColumn, Me.KdkerusakanDataGridViewTextBoxColumn})
        Me.dgv_pengetahuan.DataSource = Me.bs_pengetahuan
        Me.dgv_pengetahuan.EnableHeadersVisualStyles = False
        Me.dgv_pengetahuan.GridColor = System.Drawing.Color.Gold
        Me.dgv_pengetahuan.Location = New System.Drawing.Point(13, 70)
        Me.dgv_pengetahuan.Name = "dgv_pengetahuan"
        Me.dgv_pengetahuan.ReadOnly = True
        Me.dgv_pengetahuan.Size = New System.Drawing.Size(376, 164)
        Me.dgv_pengetahuan.TabIndex = 50
        '
        'KdpengetahuanDataGridViewTextBoxColumn
        '
        Me.KdpengetahuanDataGridViewTextBoxColumn.DataPropertyName = "kd_pengetahuan"
        Me.KdpengetahuanDataGridViewTextBoxColumn.HeaderText = "KODE PENGETAHUAN"
        Me.KdpengetahuanDataGridViewTextBoxColumn.Name = "KdpengetahuanDataGridViewTextBoxColumn"
        Me.KdpengetahuanDataGridViewTextBoxColumn.ReadOnly = True
        Me.KdpengetahuanDataGridViewTextBoxColumn.Width = 150
        '
        'PertanyaanDataGridViewTextBoxColumn
        '
        Me.PertanyaanDataGridViewTextBoxColumn.DataPropertyName = "pertanyaan"
        Me.PertanyaanDataGridViewTextBoxColumn.HeaderText = "PERTANYAAN"
        Me.PertanyaanDataGridViewTextBoxColumn.Name = "PertanyaanDataGridViewTextBoxColumn"
        Me.PertanyaanDataGridViewTextBoxColumn.ReadOnly = True
        Me.PertanyaanDataGridViewTextBoxColumn.Width = 190
        '
        'FaktayaDataGridViewTextBoxColumn
        '
        Me.FaktayaDataGridViewTextBoxColumn.DataPropertyName = "fakta_ya"
        Me.FaktayaDataGridViewTextBoxColumn.HeaderText = "FAKTA YA"
        Me.FaktayaDataGridViewTextBoxColumn.Name = "FaktayaDataGridViewTextBoxColumn"
        Me.FaktayaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FaktatidakDataGridViewTextBoxColumn
        '
        Me.FaktatidakDataGridViewTextBoxColumn.DataPropertyName = "fakta_tidak"
        Me.FaktatidakDataGridViewTextBoxColumn.HeaderText = "FAKTA TIDAK"
        Me.FaktatidakDataGridViewTextBoxColumn.Name = "FaktatidakDataGridViewTextBoxColumn"
        Me.FaktatidakDataGridViewTextBoxColumn.ReadOnly = True
        '
        'YaDataGridViewTextBoxColumn
        '
        Me.YaDataGridViewTextBoxColumn.DataPropertyName = "ya"
        Me.YaDataGridViewTextBoxColumn.HeaderText = "YA"
        Me.YaDataGridViewTextBoxColumn.Name = "YaDataGridViewTextBoxColumn"
        Me.YaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TidakDataGridViewTextBoxColumn
        '
        Me.TidakDataGridViewTextBoxColumn.DataPropertyName = "tidak"
        Me.TidakDataGridViewTextBoxColumn.HeaderText = "TIDAK"
        Me.TidakDataGridViewTextBoxColumn.Name = "TidakDataGridViewTextBoxColumn"
        Me.TidakDataGridViewTextBoxColumn.ReadOnly = True
        '
        'KdkerusakanDataGridViewTextBoxColumn
        '
        Me.KdkerusakanDataGridViewTextBoxColumn.DataPropertyName = "kd_kerusakan"
        Me.KdkerusakanDataGridViewTextBoxColumn.HeaderText = "KODE KERUSAKAN"
        Me.KdkerusakanDataGridViewTextBoxColumn.Name = "KdkerusakanDataGridViewTextBoxColumn"
        Me.KdkerusakanDataGridViewTextBoxColumn.ReadOnly = True
        Me.KdkerusakanDataGridViewTextBoxColumn.Width = 140
        '
        'bs_pengetahuan
        '
        Me.bs_pengetahuan.DataMember = "tb_pengetahuan"
        Me.bs_pengetahuan.DataSource = Me.Db_sistempakarDataSet
        '
        'cmd_refresh
        '
        Me.cmd_refresh.Location = New System.Drawing.Point(333, 34)
        Me.cmd_refresh.Name = "cmd_refresh"
        Me.cmd_refresh.Size = New System.Drawing.Size(58, 25)
        Me.cmd_refresh.TabIndex = 49
        Me.cmd_refresh.Text = "Refresh"
        Me.cmd_refresh.UseVisualStyleBackColor = True
        '
        'txt_cari_pengetahuan
        '
        Me.txt_cari_pengetahuan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_cari_pengetahuan.Location = New System.Drawing.Point(174, 37)
        Me.txt_cari_pengetahuan.Name = "txt_cari_pengetahuan"
        Me.txt_cari_pengetahuan.Size = New System.Drawing.Size(151, 20)
        Me.txt_cari_pengetahuan.TabIndex = 48
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.cb_berdasarkan_pengetahuan)
        Me.GroupBox5.Location = New System.Drawing.Point(13, 19)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(155, 46)
        Me.GroupBox5.TabIndex = 47
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Berdasarkan"
        '
        'cb_berdasarkan_pengetahuan
        '
        Me.cb_berdasarkan_pengetahuan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_berdasarkan_pengetahuan.FormattingEnabled = True
        Me.cb_berdasarkan_pengetahuan.Items.AddRange(New Object() {"KODE PENGETAHUAN", "PERTANYAAN", "KODE KERUSAKAN"})
        Me.cb_berdasarkan_pengetahuan.Location = New System.Drawing.Point(11, 18)
        Me.cb_berdasarkan_pengetahuan.Name = "cb_berdasarkan_pengetahuan"
        Me.cb_berdasarkan_pengetahuan.Size = New System.Drawing.Size(132, 21)
        Me.cb_berdasarkan_pengetahuan.TabIndex = 37
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 690)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1020, 22)
        Me.StatusStrip1.TabIndex = 34
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmd_input_jenis_kerusakan)
        Me.GroupBox1.Controls.Add(Me.cmd_refresh1)
        Me.GroupBox1.Controls.Add(Me.txt_cari_jenis_kerusakan)
        Me.GroupBox1.Controls.Add(Me.GroupBox4)
        Me.GroupBox1.Controls.Add(Me.dgv_jenis_kerusakan)
        Me.GroupBox1.Location = New System.Drawing.Point(441, 77)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(566, 303)
        Me.GroupBox1.TabIndex = 37
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Data Jenis Kerusakan"
        '
        'cmd_input_jenis_kerusakan
        '
        Me.cmd_input_jenis_kerusakan.BackColor = System.Drawing.Color.DodgerBlue
        Me.cmd_input_jenis_kerusakan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_input_jenis_kerusakan.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_input_jenis_kerusakan.ForeColor = System.Drawing.Color.White
        Me.cmd_input_jenis_kerusakan.Location = New System.Drawing.Point(407, 25)
        Me.cmd_input_jenis_kerusakan.Name = "cmd_input_jenis_kerusakan"
        Me.cmd_input_jenis_kerusakan.Size = New System.Drawing.Size(145, 35)
        Me.cmd_input_jenis_kerusakan.TabIndex = 3
        Me.cmd_input_jenis_kerusakan.Text = "Input Jenis Kerusakan"
        Me.cmd_input_jenis_kerusakan.UseVisualStyleBackColor = False
        '
        'cmd_refresh1
        '
        Me.cmd_refresh1.Location = New System.Drawing.Point(343, 30)
        Me.cmd_refresh1.Name = "cmd_refresh1"
        Me.cmd_refresh1.Size = New System.Drawing.Size(58, 25)
        Me.cmd_refresh1.TabIndex = 46
        Me.cmd_refresh1.Text = "Refresh"
        Me.cmd_refresh1.UseVisualStyleBackColor = True
        '
        'txt_cari_jenis_kerusakan
        '
        Me.txt_cari_jenis_kerusakan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_cari_jenis_kerusakan.Location = New System.Drawing.Point(186, 34)
        Me.txt_cari_jenis_kerusakan.Name = "txt_cari_jenis_kerusakan"
        Me.txt_cari_jenis_kerusakan.Size = New System.Drawing.Size(151, 20)
        Me.txt_cari_jenis_kerusakan.TabIndex = 45
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.cb_berdasarkan_jenis_kerusakan)
        Me.GroupBox4.Location = New System.Drawing.Point(19, 15)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(161, 46)
        Me.GroupBox4.TabIndex = 44
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Berdasarkan"
        '
        'cb_berdasarkan_jenis_kerusakan
        '
        Me.cb_berdasarkan_jenis_kerusakan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_berdasarkan_jenis_kerusakan.FormattingEnabled = True
        Me.cb_berdasarkan_jenis_kerusakan.Items.AddRange(New Object() {"KODE KERUSAKAN", "JENIS KERUSAKAN"})
        Me.cb_berdasarkan_jenis_kerusakan.Location = New System.Drawing.Point(11, 18)
        Me.cb_berdasarkan_jenis_kerusakan.Name = "cb_berdasarkan_jenis_kerusakan"
        Me.cb_berdasarkan_jenis_kerusakan.Size = New System.Drawing.Size(140, 21)
        Me.cb_berdasarkan_jenis_kerusakan.TabIndex = 37
        '
        'dgv_jenis_kerusakan
        '
        Me.dgv_jenis_kerusakan.AllowUserToAddRows = False
        Me.dgv_jenis_kerusakan.AllowUserToDeleteRows = False
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Window
        Me.dgv_jenis_kerusakan.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle3
        Me.dgv_jenis_kerusakan.AutoGenerateColumns = False
        Me.dgv_jenis_kerusakan.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.RoyalBlue
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_jenis_kerusakan.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgv_jenis_kerusakan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_jenis_kerusakan.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.KdkerusakanDataGridViewTextBoxColumn1, Me.JeniskerusakanDataGridViewTextBoxColumn})
        Me.dgv_jenis_kerusakan.DataSource = Me.bs_jenis_kerusakan
        Me.dgv_jenis_kerusakan.EnableHeadersVisualStyles = False
        Me.dgv_jenis_kerusakan.GridColor = System.Drawing.Color.Gold
        Me.dgv_jenis_kerusakan.Location = New System.Drawing.Point(19, 66)
        Me.dgv_jenis_kerusakan.Name = "dgv_jenis_kerusakan"
        Me.dgv_jenis_kerusakan.ReadOnly = True
        Me.dgv_jenis_kerusakan.Size = New System.Drawing.Size(533, 215)
        Me.dgv_jenis_kerusakan.TabIndex = 43
        '
        'KdkerusakanDataGridViewTextBoxColumn1
        '
        Me.KdkerusakanDataGridViewTextBoxColumn1.DataPropertyName = "kd_kerusakan"
        Me.KdkerusakanDataGridViewTextBoxColumn1.HeaderText = "KODE KERUSAKAN"
        Me.KdkerusakanDataGridViewTextBoxColumn1.Name = "KdkerusakanDataGridViewTextBoxColumn1"
        Me.KdkerusakanDataGridViewTextBoxColumn1.ReadOnly = True
        Me.KdkerusakanDataGridViewTextBoxColumn1.Width = 190
        '
        'JeniskerusakanDataGridViewTextBoxColumn
        '
        Me.JeniskerusakanDataGridViewTextBoxColumn.DataPropertyName = "jenis_kerusakan"
        Me.JeniskerusakanDataGridViewTextBoxColumn.HeaderText = "JENIS KERUSAKAN"
        Me.JeniskerusakanDataGridViewTextBoxColumn.Name = "JeniskerusakanDataGridViewTextBoxColumn"
        Me.JeniskerusakanDataGridViewTextBoxColumn.ReadOnly = True
        Me.JeniskerusakanDataGridViewTextBoxColumn.Width = 300
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cmd_input_solusi)
        Me.GroupBox2.Controls.Add(Me.cmd_refresh2)
        Me.GroupBox2.Controls.Add(Me.txt_cari_solusi)
        Me.GroupBox2.Controls.Add(Me.GroupBox6)
        Me.GroupBox2.Controls.Add(Me.dgv_solusi)
        Me.GroupBox2.Location = New System.Drawing.Point(441, 394)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(566, 287)
        Me.GroupBox2.TabIndex = 47
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Data Solusi"
        '
        'cmd_input_solusi
        '
        Me.cmd_input_solusi.BackColor = System.Drawing.Color.DodgerBlue
        Me.cmd_input_solusi.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_input_solusi.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_input_solusi.ForeColor = System.Drawing.Color.White
        Me.cmd_input_solusi.Location = New System.Drawing.Point(407, 25)
        Me.cmd_input_solusi.Name = "cmd_input_solusi"
        Me.cmd_input_solusi.Size = New System.Drawing.Size(145, 35)
        Me.cmd_input_solusi.TabIndex = 47
        Me.cmd_input_solusi.Text = "Input Solusi"
        Me.cmd_input_solusi.UseVisualStyleBackColor = False
        '
        'cmd_refresh2
        '
        Me.cmd_refresh2.Location = New System.Drawing.Point(343, 30)
        Me.cmd_refresh2.Name = "cmd_refresh2"
        Me.cmd_refresh2.Size = New System.Drawing.Size(58, 25)
        Me.cmd_refresh2.TabIndex = 46
        Me.cmd_refresh2.Text = "Refresh"
        Me.cmd_refresh2.UseVisualStyleBackColor = True
        '
        'txt_cari_solusi
        '
        Me.txt_cari_solusi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_cari_solusi.Location = New System.Drawing.Point(186, 34)
        Me.txt_cari_solusi.Name = "txt_cari_solusi"
        Me.txt_cari_solusi.Size = New System.Drawing.Size(151, 20)
        Me.txt_cari_solusi.TabIndex = 45
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.cb_berdasarkan_solusi)
        Me.GroupBox6.Location = New System.Drawing.Point(19, 15)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(161, 46)
        Me.GroupBox6.TabIndex = 44
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Berdasarkan"
        '
        'cb_berdasarkan_solusi
        '
        Me.cb_berdasarkan_solusi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_berdasarkan_solusi.FormattingEnabled = True
        Me.cb_berdasarkan_solusi.Items.AddRange(New Object() {"KODE SOLUSI", "SOLUSI"})
        Me.cb_berdasarkan_solusi.Location = New System.Drawing.Point(11, 18)
        Me.cb_berdasarkan_solusi.Name = "cb_berdasarkan_solusi"
        Me.cb_berdasarkan_solusi.Size = New System.Drawing.Size(140, 21)
        Me.cb_berdasarkan_solusi.TabIndex = 37
        '
        'dgv_solusi
        '
        Me.dgv_solusi.AllowUserToAddRows = False
        Me.dgv_solusi.AllowUserToDeleteRows = False
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Window
        Me.dgv_solusi.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle5
        Me.dgv_solusi.AutoGenerateColumns = False
        Me.dgv_solusi.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.RoyalBlue
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_solusi.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.dgv_solusi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_solusi.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.KdsolusiDataGridViewTextBoxColumn, Me.SolusiDataGridViewTextBoxColumn})
        Me.dgv_solusi.DataSource = Me.bs_solusi
        Me.dgv_solusi.EnableHeadersVisualStyles = False
        Me.dgv_solusi.GridColor = System.Drawing.Color.Gold
        Me.dgv_solusi.Location = New System.Drawing.Point(19, 66)
        Me.dgv_solusi.Name = "dgv_solusi"
        Me.dgv_solusi.ReadOnly = True
        Me.dgv_solusi.Size = New System.Drawing.Size(533, 198)
        Me.dgv_solusi.TabIndex = 43
        '
        'KdsolusiDataGridViewTextBoxColumn
        '
        Me.KdsolusiDataGridViewTextBoxColumn.DataPropertyName = "kd_solusi"
        Me.KdsolusiDataGridViewTextBoxColumn.HeaderText = "KODE SOLUSI"
        Me.KdsolusiDataGridViewTextBoxColumn.Name = "KdsolusiDataGridViewTextBoxColumn"
        Me.KdsolusiDataGridViewTextBoxColumn.ReadOnly = True
        Me.KdsolusiDataGridViewTextBoxColumn.Width = 190
        '
        'SolusiDataGridViewTextBoxColumn
        '
        Me.SolusiDataGridViewTextBoxColumn.DataPropertyName = "solusi"
        Me.SolusiDataGridViewTextBoxColumn.HeaderText = "SOLUSI"
        Me.SolusiDataGridViewTextBoxColumn.Name = "SolusiDataGridViewTextBoxColumn"
        Me.SolusiDataGridViewTextBoxColumn.ReadOnly = True
        Me.SolusiDataGridViewTextBoxColumn.Width = 300
        '
        'bs_solusi
        '
        Me.bs_solusi.DataMember = "tb_solusi"
        Me.bs_solusi.DataSource = Me.Db_sistempakarDataSet
        '
        'ta_jenis_kerusakan
        '
        Me.ta_jenis_kerusakan.ClearBeforeFill = True
        '
        'ta_solusi
        '
        Me.ta_solusi.ClearBeforeFill = True
        '
        'ta_pengetahuan
        '
        Me.ta_pengetahuan.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tb_jenis_kerusakanTableAdapter = Me.ta_jenis_kerusakan
        Me.TableAdapterManager.tb_pengetahuanTableAdapter = Me.ta_pengetahuan
        Me.TableAdapterManager.tb_solusiTableAdapter = Me.ta_solusi
        Me.TableAdapterManager.tb_tempTableAdapter = Nothing
        Me.TableAdapterManager.tb_userTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = SISTEM_PAKAR_DIAGNOSIS_KERUSAKAN_TV.db_sistempakarDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'f_pengetahuan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1020, 712)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.gb_pengetahuan)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Name = "f_pengetahuan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form Basis Pengetahuan"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.gb_pengetahuan.ResumeLayout(False)
        Me.gb_pengetahuan.PerformLayout()
        CType(Me.bs_jenis_kerusakan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Db_sistempakarDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.dgv_pengetahuan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bs_pengetahuan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.dgv_jenis_kerusakan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        CType(Me.dgv_solusi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bs_solusi, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txt_kd_pengetahuan As System.Windows.Forms.TextBox
    Friend WithEvents txt_fakta_ya As System.Windows.Forms.TextBox
    Friend WithEvents txt_pertanyaan As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents cmd_perbarui As System.Windows.Forms.Button
    Friend WithEvents cmd_simpan As System.Windows.Forms.Button
    Friend WithEvents cmd_tambah As System.Windows.Forms.Button
    Friend WithEvents gb_pengetahuan As System.Windows.Forms.GroupBox
    Friend WithEvents cb_kerusakan As System.Windows.Forms.ComboBox
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents cmd_keluar As System.Windows.Forms.Button
    Friend WithEvents cmd_hapus As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents cb_jika_tidak As System.Windows.Forms.ComboBox
    Friend WithEvents cb_jika_ya As System.Windows.Forms.ComboBox
    Friend WithEvents txt_fakta_tidak As System.Windows.Forms.TextBox
    Friend WithEvents cmd_refresh As System.Windows.Forms.Button
    Friend WithEvents txt_cari_pengetahuan As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents cb_berdasarkan_pengetahuan As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cmd_refresh1 As System.Windows.Forms.Button
    Friend WithEvents txt_cari_jenis_kerusakan As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents cb_berdasarkan_jenis_kerusakan As System.Windows.Forms.ComboBox
    Friend WithEvents dgv_jenis_kerusakan As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents cmd_refresh2 As System.Windows.Forms.Button
    Friend WithEvents txt_cari_solusi As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents cb_berdasarkan_solusi As System.Windows.Forms.ComboBox
    Friend WithEvents dgv_solusi As System.Windows.Forms.DataGridView
    Friend WithEvents dgv_pengetahuan As System.Windows.Forms.DataGridView
    Friend WithEvents Db_sistempakarDataSet As SISTEM_PAKAR_DIAGNOSIS_KERUSAKAN_TV.db_sistempakarDataSet
    Friend WithEvents KdpertanyaanDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents bs_jenis_kerusakan As System.Windows.Forms.BindingSource
    Friend WithEvents ta_jenis_kerusakan As SISTEM_PAKAR_DIAGNOSIS_KERUSAKAN_TV.db_sistempakarDataSetTableAdapters.tb_jenis_kerusakanTableAdapter
    Friend WithEvents bs_solusi As System.Windows.Forms.BindingSource
    Friend WithEvents ta_solusi As SISTEM_PAKAR_DIAGNOSIS_KERUSAKAN_TV.db_sistempakarDataSetTableAdapters.tb_solusiTableAdapter
    Friend WithEvents bs_pengetahuan As System.Windows.Forms.BindingSource
    Friend WithEvents ta_pengetahuan As SISTEM_PAKAR_DIAGNOSIS_KERUSAKAN_TV.db_sistempakarDataSetTableAdapters.tb_pengetahuanTableAdapter
    Friend WithEvents KdpengetahuanDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PertanyaanDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FaktayaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FaktatidakDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents YaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TidakDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents KdkerusakanDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cmd_input_jenis_kerusakan As System.Windows.Forms.Button
    Friend WithEvents cmd_input_solusi As System.Windows.Forms.Button
    Friend WithEvents txt_kd_kerusakan As System.Windows.Forms.TextBox
    Friend WithEvents TableAdapterManager As SISTEM_PAKAR_DIAGNOSIS_KERUSAKAN_TV.db_sistempakarDataSetTableAdapters.TableAdapterManager
    Friend WithEvents KdkerusakanDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents JeniskerusakanDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents KdsolusiDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SolusiDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
