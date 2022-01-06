<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class f_in_user
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
        Dim Kd_karyawanLabel As System.Windows.Forms.Label
        Dim KaryawanLabel As System.Windows.Forms.Label
        Dim CpLabel As System.Windows.Forms.Label
        Dim JabatanLabel As System.Windows.Forms.Label
        Dim User_nameLabel As System.Windows.Forms.Label
        Dim SandiLabel As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.cmd_simpan = New System.Windows.Forms.Button()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.cmd_keluar = New System.Windows.Forms.Button()
        Me.cmd_hapus = New System.Windows.Forms.Button()
        Me.cmd_tambah = New System.Windows.Forms.Button()
        Me.cb_jabatan = New System.Windows.Forms.ComboBox()
        Me.txt_kd_user = New System.Windows.Forms.TextBox()
        Me.txt_nama_user = New System.Windows.Forms.TextBox()
        Me.txt_cp = New System.Windows.Forms.TextBox()
        Me.txt_user_id = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.cmd_perbarui = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txt_password = New System.Windows.Forms.TextBox()
        Me.gb_in_user = New System.Windows.Forms.GroupBox()
        Me.dgv_user = New System.Windows.Forms.DataGridView()
        Me.KduserDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NamauserDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.JabatanDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CpDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UseridDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PasswordDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bs_user = New System.Windows.Forms.BindingSource(Me.components)
        Me.Db_sistempakarDataSet = New SISTEM_PAKAR_DIAGNOSIS_KERUSAKAN_TV.db_sistempakarDataSet()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ta_user = New SISTEM_PAKAR_DIAGNOSIS_KERUSAKAN_TV.db_sistempakarDataSetTableAdapters.tb_userTableAdapter()
        Kd_karyawanLabel = New System.Windows.Forms.Label()
        KaryawanLabel = New System.Windows.Forms.Label()
        CpLabel = New System.Windows.Forms.Label()
        JabatanLabel = New System.Windows.Forms.Label()
        User_nameLabel = New System.Windows.Forms.Label()
        SandiLabel = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        Me.Panel4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.gb_in_user.SuspendLayout()
        CType(Me.dgv_user, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bs_user, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Db_sistempakarDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Kd_karyawanLabel
        '
        Kd_karyawanLabel.AutoSize = True
        Kd_karyawanLabel.BackColor = System.Drawing.Color.White
        Kd_karyawanLabel.Location = New System.Drawing.Point(53, 32)
        Kd_karyawanLabel.Name = "Kd_karyawanLabel"
        Kd_karyawanLabel.Size = New System.Drawing.Size(63, 13)
        Kd_karyawanLabel.TabIndex = 1
        Kd_karyawanLabel.Text = "Kode User :"
        '
        'KaryawanLabel
        '
        KaryawanLabel.AutoSize = True
        KaryawanLabel.BackColor = System.Drawing.Color.White
        KaryawanLabel.Location = New System.Drawing.Point(30, 60)
        KaryawanLabel.Name = "KaryawanLabel"
        KaryawanLabel.Size = New System.Drawing.Size(86, 13)
        KaryawanLabel.TabIndex = 3
        KaryawanLabel.Text = "Nama Lengkap :"
        '
        'CpLabel
        '
        CpLabel.AutoSize = True
        CpLabel.BackColor = System.Drawing.Color.White
        CpLabel.Location = New System.Drawing.Point(30, 88)
        CpLabel.Name = "CpLabel"
        CpLabel.Size = New System.Drawing.Size(86, 13)
        CpLabel.TabIndex = 9
        CpLabel.Text = "Contact Person :"
        '
        'JabatanLabel
        '
        JabatanLabel.AutoSize = True
        JabatanLabel.BackColor = System.Drawing.Color.White
        JabatanLabel.Location = New System.Drawing.Point(65, 116)
        JabatanLabel.Name = "JabatanLabel"
        JabatanLabel.Size = New System.Drawing.Size(51, 13)
        JabatanLabel.TabIndex = 11
        JabatanLabel.Text = "Jabatan :"
        '
        'User_nameLabel
        '
        User_nameLabel.AutoSize = True
        User_nameLabel.BackColor = System.Drawing.Color.White
        User_nameLabel.Location = New System.Drawing.Point(67, 145)
        User_nameLabel.Name = "User_nameLabel"
        User_nameLabel.Size = New System.Drawing.Size(49, 13)
        User_nameLabel.TabIndex = 13
        User_nameLabel.Text = "User ID :"
        '
        'SandiLabel
        '
        SandiLabel.AutoSize = True
        SandiLabel.BackColor = System.Drawing.Color.White
        SandiLabel.Location = New System.Drawing.Point(57, 174)
        SandiLabel.Name = "SandiLabel"
        SandiLabel.Size = New System.Drawing.Size(59, 13)
        SandiLabel.TabIndex = 15
        SandiLabel.Text = "Password :"
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.BackColor = System.Drawing.Color.Transparent
        Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label3.ForeColor = System.Drawing.Color.White
        Label3.Location = New System.Drawing.Point(600, 33)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(126, 24)
        Label3.TabIndex = 21
        Label3.Text = "DATA USER"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.BackColor = System.Drawing.Color.Transparent
        Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label2.ForeColor = System.Drawing.Color.White
        Label2.Location = New System.Drawing.Point(12, 51)
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
        Label1.Location = New System.Drawing.Point(12, 10)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(200, 29)
        Label1.TabIndex = 19
        Label1.Text = "SISTEM PAKAR"
        '
        'cmd_simpan
        '
        Me.cmd_simpan.BackColor = System.Drawing.Color.DodgerBlue
        Me.cmd_simpan.Enabled = False
        Me.cmd_simpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_simpan.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_simpan.ForeColor = System.Drawing.Color.White
        Me.cmd_simpan.Location = New System.Drawing.Point(150, 11)
        Me.cmd_simpan.Name = "cmd_simpan"
        Me.cmd_simpan.Size = New System.Drawing.Size(75, 35)
        Me.cmd_simpan.TabIndex = 1
        Me.cmd_simpan.Text = "&Simpan"
        Me.cmd_simpan.UseVisualStyleBackColor = False
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 405)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(742, 22)
        Me.StatusStrip1.TabIndex = 34
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.SystemColors.Control
        Me.Panel4.Controls.Add(Me.cmd_keluar)
        Me.Panel4.Controls.Add(Me.cmd_hapus)
        Me.Panel4.Location = New System.Drawing.Point(344, 336)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(388, 57)
        Me.Panel4.TabIndex = 36
        '
        'cmd_keluar
        '
        Me.cmd_keluar.BackColor = System.Drawing.Color.Orange
        Me.cmd_keluar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_keluar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_keluar.ForeColor = System.Drawing.Color.White
        Me.cmd_keluar.Location = New System.Drawing.Point(296, 11)
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
        Me.cmd_hapus.Location = New System.Drawing.Point(215, 11)
        Me.cmd_hapus.Name = "cmd_hapus"
        Me.cmd_hapus.Size = New System.Drawing.Size(75, 35)
        Me.cmd_hapus.TabIndex = 3
        Me.cmd_hapus.Text = "&Hapus"
        Me.cmd_hapus.UseVisualStyleBackColor = False
        '
        'cmd_tambah
        '
        Me.cmd_tambah.BackColor = System.Drawing.Color.DodgerBlue
        Me.cmd_tambah.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_tambah.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_tambah.ForeColor = System.Drawing.Color.White
        Me.cmd_tambah.Location = New System.Drawing.Point(69, 11)
        Me.cmd_tambah.Name = "cmd_tambah"
        Me.cmd_tambah.Size = New System.Drawing.Size(75, 35)
        Me.cmd_tambah.TabIndex = 0
        Me.cmd_tambah.Text = "&Tambah"
        Me.cmd_tambah.UseVisualStyleBackColor = False
        '
        'cb_jabatan
        '
        Me.cb_jabatan.BackColor = System.Drawing.Color.White
        Me.cb_jabatan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_jabatan.FormattingEnabled = True
        Me.cb_jabatan.Items.AddRange(New Object() {"PENGGUNA", "PAKAR", "ADMIN"})
        Me.cb_jabatan.Location = New System.Drawing.Point(122, 113)
        Me.cb_jabatan.Name = "cb_jabatan"
        Me.cb_jabatan.Size = New System.Drawing.Size(165, 21)
        Me.cb_jabatan.TabIndex = 18
        '
        'txt_kd_user
        '
        Me.txt_kd_user.Enabled = False
        Me.txt_kd_user.Location = New System.Drawing.Point(122, 29)
        Me.txt_kd_user.Name = "txt_kd_user"
        Me.txt_kd_user.Size = New System.Drawing.Size(165, 20)
        Me.txt_kd_user.TabIndex = 2
        '
        'txt_nama_user
        '
        Me.txt_nama_user.Location = New System.Drawing.Point(122, 57)
        Me.txt_nama_user.Name = "txt_nama_user"
        Me.txt_nama_user.Size = New System.Drawing.Size(165, 20)
        Me.txt_nama_user.TabIndex = 4
        '
        'txt_cp
        '
        Me.txt_cp.Location = New System.Drawing.Point(122, 85)
        Me.txt_cp.MaxLength = 12
        Me.txt_cp.Name = "txt_cp"
        Me.txt_cp.Size = New System.Drawing.Size(165, 20)
        Me.txt_cp.TabIndex = 8
        '
        'txt_user_id
        '
        Me.txt_user_id.Location = New System.Drawing.Point(122, 142)
        Me.txt_user_id.Name = "txt_user_id"
        Me.txt_user_id.Size = New System.Drawing.Size(165, 20)
        Me.txt_user_id.TabIndex = 14
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.Control
        Me.Panel3.Controls.Add(Me.cmd_perbarui)
        Me.Panel3.Controls.Add(Me.cmd_simpan)
        Me.Panel3.Controls.Add(Me.cmd_tambah)
        Me.Panel3.Location = New System.Drawing.Point(12, 336)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(326, 57)
        Me.Panel3.TabIndex = 35
        '
        'cmd_perbarui
        '
        Me.cmd_perbarui.BackColor = System.Drawing.Color.DodgerBlue
        Me.cmd_perbarui.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_perbarui.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_perbarui.ForeColor = System.Drawing.Color.White
        Me.cmd_perbarui.Location = New System.Drawing.Point(231, 11)
        Me.cmd_perbarui.Name = "cmd_perbarui"
        Me.cmd_perbarui.Size = New System.Drawing.Size(75, 35)
        Me.cmd_perbarui.TabIndex = 2
        Me.cmd_perbarui.Text = "&Perbarui"
        Me.cmd_perbarui.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Gold
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 85)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(742, 13)
        Me.Panel2.TabIndex = 0
        '
        'txt_password
        '
        Me.txt_password.Location = New System.Drawing.Point(122, 171)
        Me.txt_password.Name = "txt_password"
        Me.txt_password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_password.Size = New System.Drawing.Size(165, 20)
        Me.txt_password.TabIndex = 16
        '
        'gb_in_user
        '
        Me.gb_in_user.Controls.Add(Me.cb_jabatan)
        Me.gb_in_user.Controls.Add(Kd_karyawanLabel)
        Me.gb_in_user.Controls.Add(Me.txt_kd_user)
        Me.gb_in_user.Controls.Add(KaryawanLabel)
        Me.gb_in_user.Controls.Add(Me.txt_nama_user)
        Me.gb_in_user.Controls.Add(Me.txt_cp)
        Me.gb_in_user.Controls.Add(CpLabel)
        Me.gb_in_user.Controls.Add(JabatanLabel)
        Me.gb_in_user.Controls.Add(User_nameLabel)
        Me.gb_in_user.Controls.Add(Me.txt_user_id)
        Me.gb_in_user.Controls.Add(SandiLabel)
        Me.gb_in_user.Controls.Add(Me.txt_password)
        Me.gb_in_user.Enabled = False
        Me.gb_in_user.Location = New System.Drawing.Point(12, 108)
        Me.gb_in_user.Name = "gb_in_user"
        Me.gb_in_user.Size = New System.Drawing.Size(326, 222)
        Me.gb_in_user.TabIndex = 31
        Me.gb_in_user.TabStop = False
        Me.gb_in_user.Text = "Input User Baru"
        '
        'dgv_user
        '
        Me.dgv_user.AllowUserToAddRows = False
        Me.dgv_user.AllowUserToDeleteRows = False
        Me.dgv_user.AutoGenerateColumns = False
        Me.dgv_user.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_user.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgv_user.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_user.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.KduserDataGridViewTextBoxColumn, Me.NamauserDataGridViewTextBoxColumn, Me.JabatanDataGridViewTextBoxColumn, Me.CpDataGridViewTextBoxColumn, Me.UseridDataGridViewTextBoxColumn, Me.PasswordDataGridViewTextBoxColumn})
        Me.dgv_user.DataSource = Me.bs_user
        Me.dgv_user.EnableHeadersVisualStyles = False
        Me.dgv_user.GridColor = System.Drawing.Color.Gold
        Me.dgv_user.Location = New System.Drawing.Point(15, 21)
        Me.dgv_user.Name = "dgv_user"
        Me.dgv_user.ReadOnly = True
        Me.dgv_user.Size = New System.Drawing.Size(356, 165)
        Me.dgv_user.TabIndex = 0
        '
        'KduserDataGridViewTextBoxColumn
        '
        Me.KduserDataGridViewTextBoxColumn.DataPropertyName = "kd_user"
        Me.KduserDataGridViewTextBoxColumn.HeaderText = "KODE USER"
        Me.KduserDataGridViewTextBoxColumn.Name = "KduserDataGridViewTextBoxColumn"
        Me.KduserDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NamauserDataGridViewTextBoxColumn
        '
        Me.NamauserDataGridViewTextBoxColumn.DataPropertyName = "nama_user"
        Me.NamauserDataGridViewTextBoxColumn.HeaderText = "NAMA USER"
        Me.NamauserDataGridViewTextBoxColumn.Name = "NamauserDataGridViewTextBoxColumn"
        Me.NamauserDataGridViewTextBoxColumn.ReadOnly = True
        '
        'JabatanDataGridViewTextBoxColumn
        '
        Me.JabatanDataGridViewTextBoxColumn.DataPropertyName = "jabatan"
        Me.JabatanDataGridViewTextBoxColumn.HeaderText = "JABATAN"
        Me.JabatanDataGridViewTextBoxColumn.Name = "JabatanDataGridViewTextBoxColumn"
        Me.JabatanDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CpDataGridViewTextBoxColumn
        '
        Me.CpDataGridViewTextBoxColumn.DataPropertyName = "cp"
        Me.CpDataGridViewTextBoxColumn.HeaderText = "CONTACT PERSON"
        Me.CpDataGridViewTextBoxColumn.Name = "CpDataGridViewTextBoxColumn"
        Me.CpDataGridViewTextBoxColumn.ReadOnly = True
        Me.CpDataGridViewTextBoxColumn.Width = 140
        '
        'UseridDataGridViewTextBoxColumn
        '
        Me.UseridDataGridViewTextBoxColumn.DataPropertyName = "user_id"
        Me.UseridDataGridViewTextBoxColumn.HeaderText = "USER ID"
        Me.UseridDataGridViewTextBoxColumn.Name = "UseridDataGridViewTextBoxColumn"
        Me.UseridDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PasswordDataGridViewTextBoxColumn
        '
        Me.PasswordDataGridViewTextBoxColumn.DataPropertyName = "password"
        Me.PasswordDataGridViewTextBoxColumn.HeaderText = "PASSWORD"
        Me.PasswordDataGridViewTextBoxColumn.Name = "PasswordDataGridViewTextBoxColumn"
        Me.PasswordDataGridViewTextBoxColumn.ReadOnly = True
        '
        'bs_user
        '
        Me.bs_user.DataMember = "tb_user"
        Me.bs_user.DataSource = Me.Db_sistempakarDataSet
        '
        'Db_sistempakarDataSet
        '
        Me.Db_sistempakarDataSet.DataSetName = "db_sistempakarDataSet"
        Me.Db_sistempakarDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.dgv_user)
        Me.GroupBox3.Location = New System.Drawing.Point(344, 109)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(388, 221)
        Me.GroupBox3.TabIndex = 32
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Data User"
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
        Me.Panel1.Size = New System.Drawing.Size(742, 98)
        Me.Panel1.TabIndex = 33
        '
        'ta_user
        '
        Me.ta_user.ClearBeforeFill = True
        '
        'f_in_user
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(742, 427)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.gb_in_user)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "f_in_user"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form User Baru"
        Me.Panel4.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.gb_in_user.ResumeLayout(False)
        Me.gb_in_user.PerformLayout()
        CType(Me.dgv_user, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bs_user, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Db_sistempakarDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmd_simpan As System.Windows.Forms.Button
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents cmd_keluar As System.Windows.Forms.Button
    Friend WithEvents cmd_hapus As System.Windows.Forms.Button
    Friend WithEvents cmd_tambah As System.Windows.Forms.Button
    Friend WithEvents cb_jabatan As System.Windows.Forms.ComboBox
    Friend WithEvents txt_kd_user As System.Windows.Forms.TextBox
    Friend WithEvents txt_nama_user As System.Windows.Forms.TextBox
    Friend WithEvents txt_cp As System.Windows.Forms.TextBox
    Friend WithEvents txt_user_id As System.Windows.Forms.TextBox
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents cmd_perbarui As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents txt_password As System.Windows.Forms.TextBox
    Friend WithEvents gb_in_user As System.Windows.Forms.GroupBox
    Friend WithEvents dgv_user As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Db_sistempakarDataSet As SISTEM_PAKAR_DIAGNOSIS_KERUSAKAN_TV.db_sistempakarDataSet
    Friend WithEvents bs_user As System.Windows.Forms.BindingSource
    Friend WithEvents ta_user As SISTEM_PAKAR_DIAGNOSIS_KERUSAKAN_TV.db_sistempakarDataSetTableAdapters.tb_userTableAdapter
    Friend WithEvents KduserDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NamauserDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents JabatanDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CpDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UseridDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PasswordDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
