<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class f_jenis_kerusakan
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
        Dim Kd_jenis_kerusakanLabel As System.Windows.Forms.Label
        Dim Jenis_kerusakanLabel As System.Windows.Forms.Label
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.cmd_keluar = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.cmd_hapus = New System.Windows.Forms.Button()
        Me.cmd_perbarui = New System.Windows.Forms.Button()
        Me.cmd_simpan = New System.Windows.Forms.Button()
        Me.cmd_tambah = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.gb_jenis_kerusakan = New System.Windows.Forms.GroupBox()
        Me.txt_kd_jenis_kerusakan = New System.Windows.Forms.TextBox()
        Me.txt_jenis_kerusakan = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.dgv_jenis_kerusakan = New System.Windows.Forms.DataGridView()
        Me.KdkerusakanDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.JeniskerusakanDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bs_jenis_kerusakan = New System.Windows.Forms.BindingSource(Me.components)
        Me.Db_sistempakarDataSet = New SISTEM_PAKAR_DIAGNOSIS_KERUSAKAN_TV.db_sistempakarDataSet()
        Me.ta_jenis_kerusakan = New SISTEM_PAKAR_DIAGNOSIS_KERUSAKAN_TV.db_sistempakarDataSetTableAdapters.tb_jenis_kerusakanTableAdapter()
        Label3 = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        Kd_jenis_kerusakanLabel = New System.Windows.Forms.Label()
        Jenis_kerusakanLabel = New System.Windows.Forms.Label()
        Me.Panel4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.gb_jenis_kerusakan.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgv_jenis_kerusakan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bs_jenis_kerusakan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Db_sistempakarDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label3.ForeColor = System.Drawing.Color.White
        Label3.Location = New System.Drawing.Point(381, 33)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(258, 24)
        Label3.TabIndex = 12
        Label3.Text = "DATA JENIS KERUSAKAN"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label2.ForeColor = System.Drawing.Color.White
        Label2.Location = New System.Drawing.Point(3, 49)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(271, 25)
        Label2.TabIndex = 11
        Label2.Text = "Diagnosis Kerusakan TV"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label1.ForeColor = System.Drawing.Color.White
        Label1.Location = New System.Drawing.Point(3, 11)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(200, 29)
        Label1.TabIndex = 7
        Label1.Text = "SISTEM PAKAR"
        '
        'Kd_jenis_kerusakanLabel
        '
        Kd_jenis_kerusakanLabel.AutoSize = True
        Kd_jenis_kerusakanLabel.Location = New System.Drawing.Point(14, 40)
        Kd_jenis_kerusakanLabel.Name = "Kd_jenis_kerusakanLabel"
        Kd_jenis_kerusakanLabel.Size = New System.Drawing.Size(119, 13)
        Kd_jenis_kerusakanLabel.TabIndex = 1
        Kd_jenis_kerusakanLabel.Text = "Kode Jenis Kerusakan :"
        '
        'Jenis_kerusakanLabel
        '
        Jenis_kerusakanLabel.AutoSize = True
        Jenis_kerusakanLabel.Location = New System.Drawing.Point(42, 69)
        Jenis_kerusakanLabel.Name = "Jenis_kerusakanLabel"
        Jenis_kerusakanLabel.Size = New System.Drawing.Size(91, 13)
        Jenis_kerusakanLabel.TabIndex = 3
        Jenis_kerusakanLabel.Text = "Jenis Kerusakan :"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 336)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(642, 22)
        Me.StatusStrip1.TabIndex = 18
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'cmd_keluar
        '
        Me.cmd_keluar.BackColor = System.Drawing.Color.Orange
        Me.cmd_keluar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_keluar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_keluar.ForeColor = System.Drawing.Color.White
        Me.cmd_keluar.Location = New System.Drawing.Point(221, 10)
        Me.cmd_keluar.Name = "cmd_keluar"
        Me.cmd_keluar.Size = New System.Drawing.Size(73, 35)
        Me.cmd_keluar.TabIndex = 4
        Me.cmd_keluar.Text = "&Keluar"
        Me.cmd_keluar.UseVisualStyleBackColor = False
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.SystemColors.Control
        Me.Panel4.Controls.Add(Me.cmd_keluar)
        Me.Panel4.Controls.Add(Me.cmd_hapus)
        Me.Panel4.Location = New System.Drawing.Point(329, 271)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(303, 54)
        Me.Panel4.TabIndex = 17
        '
        'cmd_hapus
        '
        Me.cmd_hapus.BackColor = System.Drawing.Color.Orange
        Me.cmd_hapus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_hapus.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_hapus.ForeColor = System.Drawing.Color.White
        Me.cmd_hapus.Location = New System.Drawing.Point(142, 10)
        Me.cmd_hapus.Name = "cmd_hapus"
        Me.cmd_hapus.Size = New System.Drawing.Size(73, 35)
        Me.cmd_hapus.TabIndex = 3
        Me.cmd_hapus.Text = "&Hapus"
        Me.cmd_hapus.UseVisualStyleBackColor = False
        '
        'cmd_perbarui
        '
        Me.cmd_perbarui.BackColor = System.Drawing.Color.DodgerBlue
        Me.cmd_perbarui.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_perbarui.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_perbarui.ForeColor = System.Drawing.Color.White
        Me.cmd_perbarui.Location = New System.Drawing.Point(223, 10)
        Me.cmd_perbarui.Name = "cmd_perbarui"
        Me.cmd_perbarui.Size = New System.Drawing.Size(73, 35)
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
        Me.cmd_simpan.Location = New System.Drawing.Point(144, 10)
        Me.cmd_simpan.Name = "cmd_simpan"
        Me.cmd_simpan.Size = New System.Drawing.Size(73, 35)
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
        Me.cmd_tambah.Location = New System.Drawing.Point(65, 10)
        Me.cmd_tambah.Name = "cmd_tambah"
        Me.cmd_tambah.Size = New System.Drawing.Size(73, 35)
        Me.cmd_tambah.TabIndex = 0
        Me.cmd_tambah.Text = "&Tambah"
        Me.cmd_tambah.UseVisualStyleBackColor = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.Control
        Me.Panel3.Controls.Add(Me.cmd_perbarui)
        Me.Panel3.Controls.Add(Me.cmd_simpan)
        Me.Panel3.Controls.Add(Me.cmd_tambah)
        Me.Panel3.Location = New System.Drawing.Point(10, 271)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(313, 54)
        Me.Panel3.TabIndex = 16
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Orange
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 82)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(642, 15)
        Me.Panel2.TabIndex = 10
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
        Me.Panel1.Size = New System.Drawing.Size(642, 97)
        Me.Panel1.TabIndex = 15
        '
        'gb_jenis_kerusakan
        '
        Me.gb_jenis_kerusakan.Controls.Add(Kd_jenis_kerusakanLabel)
        Me.gb_jenis_kerusakan.Controls.Add(Me.txt_kd_jenis_kerusakan)
        Me.gb_jenis_kerusakan.Controls.Add(Jenis_kerusakanLabel)
        Me.gb_jenis_kerusakan.Controls.Add(Me.txt_jenis_kerusakan)
        Me.gb_jenis_kerusakan.Enabled = False
        Me.gb_jenis_kerusakan.Location = New System.Drawing.Point(10, 108)
        Me.gb_jenis_kerusakan.Name = "gb_jenis_kerusakan"
        Me.gb_jenis_kerusakan.Size = New System.Drawing.Size(313, 157)
        Me.gb_jenis_kerusakan.TabIndex = 13
        Me.gb_jenis_kerusakan.TabStop = False
        Me.gb_jenis_kerusakan.Text = "Jenis Kerusakan"
        '
        'txt_kd_jenis_kerusakan
        '
        Me.txt_kd_jenis_kerusakan.Enabled = False
        Me.txt_kd_jenis_kerusakan.Location = New System.Drawing.Point(139, 37)
        Me.txt_kd_jenis_kerusakan.Name = "txt_kd_jenis_kerusakan"
        Me.txt_kd_jenis_kerusakan.Size = New System.Drawing.Size(140, 20)
        Me.txt_kd_jenis_kerusakan.TabIndex = 2
        '
        'txt_jenis_kerusakan
        '
        Me.txt_jenis_kerusakan.Location = New System.Drawing.Point(139, 66)
        Me.txt_jenis_kerusakan.Name = "txt_jenis_kerusakan"
        Me.txt_jenis_kerusakan.Size = New System.Drawing.Size(140, 20)
        Me.txt_jenis_kerusakan.TabIndex = 4
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.dgv_jenis_kerusakan)
        Me.GroupBox2.Location = New System.Drawing.Point(329, 108)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(303, 157)
        Me.GroupBox2.TabIndex = 14
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Data Jenis Kerusakan"
        '
        'dgv_jenis_kerusakan
        '
        Me.dgv_jenis_kerusakan.AllowUserToAddRows = False
        Me.dgv_jenis_kerusakan.AllowUserToDeleteRows = False
        Me.dgv_jenis_kerusakan.AllowUserToOrderColumns = True
        Me.dgv_jenis_kerusakan.AutoGenerateColumns = False
        Me.dgv_jenis_kerusakan.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.DodgerBlue
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_jenis_kerusakan.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv_jenis_kerusakan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_jenis_kerusakan.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.KdkerusakanDataGridViewTextBoxColumn, Me.JeniskerusakanDataGridViewTextBoxColumn})
        Me.dgv_jenis_kerusakan.DataSource = Me.bs_jenis_kerusakan
        Me.dgv_jenis_kerusakan.EnableHeadersVisualStyles = False
        Me.dgv_jenis_kerusakan.GridColor = System.Drawing.Color.Gold
        Me.dgv_jenis_kerusakan.Location = New System.Drawing.Point(12, 17)
        Me.dgv_jenis_kerusakan.Name = "dgv_jenis_kerusakan"
        Me.dgv_jenis_kerusakan.ReadOnly = True
        Me.dgv_jenis_kerusakan.Size = New System.Drawing.Size(279, 128)
        Me.dgv_jenis_kerusakan.TabIndex = 0
        '
        'KdkerusakanDataGridViewTextBoxColumn
        '
        Me.KdkerusakanDataGridViewTextBoxColumn.DataPropertyName = "kd_kerusakan"
        Me.KdkerusakanDataGridViewTextBoxColumn.HeaderText = "KODE KERUSAKAN"
        Me.KdkerusakanDataGridViewTextBoxColumn.Name = "KdkerusakanDataGridViewTextBoxColumn"
        Me.KdkerusakanDataGridViewTextBoxColumn.ReadOnly = True
        Me.KdkerusakanDataGridViewTextBoxColumn.Width = 130
        '
        'JeniskerusakanDataGridViewTextBoxColumn
        '
        Me.JeniskerusakanDataGridViewTextBoxColumn.DataPropertyName = "jenis_kerusakan"
        Me.JeniskerusakanDataGridViewTextBoxColumn.HeaderText = "JENIS KERUSAKAN"
        Me.JeniskerusakanDataGridViewTextBoxColumn.Name = "JeniskerusakanDataGridViewTextBoxColumn"
        Me.JeniskerusakanDataGridViewTextBoxColumn.ReadOnly = True
        Me.JeniskerusakanDataGridViewTextBoxColumn.Width = 130
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
        'ta_jenis_kerusakan
        '
        Me.ta_jenis_kerusakan.ClearBeforeFill = True
        '
        'f_jenis_kerusakan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(642, 358)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.gb_jenis_kerusakan)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "f_jenis_kerusakan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form Jenis Kerusakan"
        Me.Panel4.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.gb_jenis_kerusakan.ResumeLayout(False)
        Me.gb_jenis_kerusakan.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.dgv_jenis_kerusakan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bs_jenis_kerusakan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Db_sistempakarDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents cmd_keluar As System.Windows.Forms.Button
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents cmd_hapus As System.Windows.Forms.Button
    Friend WithEvents cmd_perbarui As System.Windows.Forms.Button
    Friend WithEvents cmd_simpan As System.Windows.Forms.Button
    Friend WithEvents cmd_tambah As System.Windows.Forms.Button
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents gb_jenis_kerusakan As System.Windows.Forms.GroupBox
    Friend WithEvents txt_kd_jenis_kerusakan As System.Windows.Forms.TextBox
    Friend WithEvents txt_jenis_kerusakan As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents dgv_jenis_kerusakan As System.Windows.Forms.DataGridView
    Friend WithEvents Db_sistempakarDataSet As SISTEM_PAKAR_DIAGNOSIS_KERUSAKAN_TV.db_sistempakarDataSet
    Friend WithEvents bs_jenis_kerusakan As System.Windows.Forms.BindingSource
    Friend WithEvents ta_jenis_kerusakan As SISTEM_PAKAR_DIAGNOSIS_KERUSAKAN_TV.db_sistempakarDataSetTableAdapters.tb_jenis_kerusakanTableAdapter
    Friend WithEvents KdkerusakanDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents JeniskerusakanDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
