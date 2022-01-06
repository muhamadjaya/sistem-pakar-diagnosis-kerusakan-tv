<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class f_solusi
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
        Dim Kd_solusiLabel As System.Windows.Forms.Label
        Dim solusiLabel As System.Windows.Forms.Label
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgv_solusi = New System.Windows.Forms.DataGridView()
        Me.KdsolusiDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SolusiDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bs_solusi = New System.Windows.Forms.BindingSource(Me.components)
        Me.Db_sistempakarDataSet = New SISTEM_PAKAR_DIAGNOSIS_KERUSAKAN_TV.db_sistempakarDataSet()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txt_kd_solusi = New System.Windows.Forms.TextBox()
        Me.txt_solusi = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.gb_solusi = New System.Windows.Forms.GroupBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.cmd_perbarui = New System.Windows.Forms.Button()
        Me.cmd_simpan = New System.Windows.Forms.Button()
        Me.cmd_tambah = New System.Windows.Forms.Button()
        Me.cmd_hapus = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.cmd_keluar = New System.Windows.Forms.Button()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ta_solusi = New SISTEM_PAKAR_DIAGNOSIS_KERUSAKAN_TV.db_sistempakarDataSetTableAdapters.tb_solusiTableAdapter()
        Label3 = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        Kd_solusiLabel = New System.Windows.Forms.Label()
        solusiLabel = New System.Windows.Forms.Label()
        CType(Me.dgv_solusi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bs_solusi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Db_sistempakarDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.gb_solusi.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label3.ForeColor = System.Drawing.Color.White
        Label3.Location = New System.Drawing.Point(488, 33)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(143, 24)
        Label3.TabIndex = 12
        Label3.Text = "DATA SOLUSI"
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
        'Kd_solusiLabel
        '
        Kd_solusiLabel.AutoSize = True
        Kd_solusiLabel.Location = New System.Drawing.Point(64, 40)
        Kd_solusiLabel.Name = "Kd_solusiLabel"
        Kd_solusiLabel.Size = New System.Drawing.Size(69, 13)
        Kd_solusiLabel.TabIndex = 1
        Kd_solusiLabel.Text = "Kode Solusi :"
        '
        'solusiLabel
        '
        solusiLabel.AutoSize = True
        solusiLabel.Location = New System.Drawing.Point(92, 69)
        solusiLabel.Name = "solusiLabel"
        solusiLabel.Size = New System.Drawing.Size(41, 13)
        solusiLabel.TabIndex = 3
        solusiLabel.Text = "Solusi :"
        '
        'dgv_solusi
        '
        Me.dgv_solusi.AllowUserToAddRows = False
        Me.dgv_solusi.AllowUserToDeleteRows = False
        Me.dgv_solusi.AllowUserToOrderColumns = True
        Me.dgv_solusi.AutoGenerateColumns = False
        Me.dgv_solusi.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.DodgerBlue
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_solusi.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv_solusi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_solusi.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.KdsolusiDataGridViewTextBoxColumn, Me.SolusiDataGridViewTextBoxColumn})
        Me.dgv_solusi.DataSource = Me.bs_solusi
        Me.dgv_solusi.EnableHeadersVisualStyles = False
        Me.dgv_solusi.GridColor = System.Drawing.Color.Gold
        Me.dgv_solusi.Location = New System.Drawing.Point(12, 17)
        Me.dgv_solusi.Name = "dgv_solusi"
        Me.dgv_solusi.ReadOnly = True
        Me.dgv_solusi.Size = New System.Drawing.Size(279, 128)
        Me.dgv_solusi.TabIndex = 0
        '
        'KdsolusiDataGridViewTextBoxColumn
        '
        Me.KdsolusiDataGridViewTextBoxColumn.DataPropertyName = "kd_solusi"
        Me.KdsolusiDataGridViewTextBoxColumn.HeaderText = "KODE SOLUSI"
        Me.KdsolusiDataGridViewTextBoxColumn.Name = "KdsolusiDataGridViewTextBoxColumn"
        Me.KdsolusiDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SolusiDataGridViewTextBoxColumn
        '
        Me.SolusiDataGridViewTextBoxColumn.DataPropertyName = "solusi"
        Me.SolusiDataGridViewTextBoxColumn.HeaderText = "SOLUSI"
        Me.SolusiDataGridViewTextBoxColumn.Name = "SolusiDataGridViewTextBoxColumn"
        Me.SolusiDataGridViewTextBoxColumn.ReadOnly = True
        '
        'bs_solusi
        '
        Me.bs_solusi.DataMember = "tb_solusi"
        Me.bs_solusi.DataSource = Me.Db_sistempakarDataSet
        '
        'Db_sistempakarDataSet
        '
        Me.Db_sistempakarDataSet.DataSetName = "db_sistempakarDataSet"
        Me.Db_sistempakarDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.dgv_solusi)
        Me.GroupBox2.Location = New System.Drawing.Point(329, 108)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(303, 157)
        Me.GroupBox2.TabIndex = 20
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Data Solusi"
        '
        'txt_kd_solusi
        '
        Me.txt_kd_solusi.Enabled = False
        Me.txt_kd_solusi.Location = New System.Drawing.Point(139, 37)
        Me.txt_kd_solusi.Name = "txt_kd_solusi"
        Me.txt_kd_solusi.Size = New System.Drawing.Size(140, 20)
        Me.txt_kd_solusi.TabIndex = 2
        '
        'txt_solusi
        '
        Me.txt_solusi.Location = New System.Drawing.Point(139, 66)
        Me.txt_solusi.Name = "txt_solusi"
        Me.txt_solusi.Size = New System.Drawing.Size(140, 20)
        Me.txt_solusi.TabIndex = 4
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
        Me.Panel1.TabIndex = 21
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
        'gb_solusi
        '
        Me.gb_solusi.Controls.Add(Kd_solusiLabel)
        Me.gb_solusi.Controls.Add(Me.txt_kd_solusi)
        Me.gb_solusi.Controls.Add(solusiLabel)
        Me.gb_solusi.Controls.Add(Me.txt_solusi)
        Me.gb_solusi.Enabled = False
        Me.gb_solusi.Location = New System.Drawing.Point(10, 108)
        Me.gb_solusi.Name = "gb_solusi"
        Me.gb_solusi.Size = New System.Drawing.Size(313, 157)
        Me.gb_solusi.TabIndex = 19
        Me.gb_solusi.TabStop = False
        Me.gb_solusi.Text = "Solusi"
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
        Me.Panel3.TabIndex = 22
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
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.SystemColors.Control
        Me.Panel4.Controls.Add(Me.cmd_keluar)
        Me.Panel4.Controls.Add(Me.cmd_hapus)
        Me.Panel4.Location = New System.Drawing.Point(329, 271)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(303, 54)
        Me.Panel4.TabIndex = 23
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
        'StatusStrip1
        '
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 336)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(642, 22)
        Me.StatusStrip1.TabIndex = 24
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ta_solusi
        '
        Me.ta_solusi.ClearBeforeFill = True
        '
        'f_solusi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(642, 358)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.gb_solusi)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Name = "f_solusi"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form Solusi"
        CType(Me.dgv_solusi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bs_solusi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Db_sistempakarDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.gb_solusi.ResumeLayout(False)
        Me.gb_solusi.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgv_solusi As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_kd_solusi As System.Windows.Forms.TextBox
    Friend WithEvents txt_solusi As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents gb_solusi As System.Windows.Forms.GroupBox
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents cmd_perbarui As System.Windows.Forms.Button
    Friend WithEvents cmd_simpan As System.Windows.Forms.Button
    Friend WithEvents cmd_tambah As System.Windows.Forms.Button
    Friend WithEvents cmd_hapus As System.Windows.Forms.Button
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents cmd_keluar As System.Windows.Forms.Button
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents Db_sistempakarDataSet As SISTEM_PAKAR_DIAGNOSIS_KERUSAKAN_TV.db_sistempakarDataSet
    Friend WithEvents bs_solusi As System.Windows.Forms.BindingSource
    Friend WithEvents ta_solusi As SISTEM_PAKAR_DIAGNOSIS_KERUSAKAN_TV.db_sistempakarDataSetTableAdapters.tb_solusiTableAdapter
    Friend WithEvents KdsolusiDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SolusiDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
