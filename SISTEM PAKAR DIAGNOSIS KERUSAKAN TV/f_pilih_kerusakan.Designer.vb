<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class f_pilih_kerusakan
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cb_kerusakan = New System.Windows.Forms.ComboBox()
        Me.bs_jenis_kerusakan = New System.Windows.Forms.BindingSource(Me.components)
        Me.Db_sistempakarDataSet = New SISTEM_PAKAR_DIAGNOSIS_KERUSAKAN_TV.db_sistempakarDataSet()
        Me.cmd_proses = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ta_jenis_kerusakan = New SISTEM_PAKAR_DIAGNOSIS_KERUSAKAN_TV.db_sistempakarDataSetTableAdapters.tb_jenis_kerusakanTableAdapter()
        Me.bs_pengetahuan = New System.Windows.Forms.BindingSource(Me.components)
        Me.ta_pengetahuan = New SISTEM_PAKAR_DIAGNOSIS_KERUSAKAN_TV.db_sistempakarDataSetTableAdapters.tb_pengetahuanTableAdapter()
        Me.GroupBox1.SuspendLayout()
        CType(Me.bs_jenis_kerusakan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Db_sistempakarDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bs_pengetahuan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cb_kerusakan)
        Me.GroupBox1.Controls.Add(Me.cmd_proses)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(11, 7)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(500, 174)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'cb_kerusakan
        '
        Me.cb_kerusakan.DataSource = Me.bs_jenis_kerusakan
        Me.cb_kerusakan.DisplayMember = "jenis_kerusakan"
        Me.cb_kerusakan.FormattingEnabled = True
        Me.cb_kerusakan.Location = New System.Drawing.Point(78, 54)
        Me.cb_kerusakan.Name = "cb_kerusakan"
        Me.cb_kerusakan.Size = New System.Drawing.Size(341, 21)
        Me.cb_kerusakan.TabIndex = 4
        Me.cb_kerusakan.ValueMember = "kd_kerusakan"
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
        'cmd_proses
        '
        Me.cmd_proses.BackColor = System.Drawing.Color.DodgerBlue
        Me.cmd_proses.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.cmd_proses.ForeColor = System.Drawing.Color.White
        Me.cmd_proses.Location = New System.Drawing.Point(194, 116)
        Me.cmd_proses.Name = "cmd_proses"
        Me.cmd_proses.Size = New System.Drawing.Size(112, 39)
        Me.cmd_proses.TabIndex = 2
        Me.cmd_proses.Text = "&Proses"
        Me.cmd_proses.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(105, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(297, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Perkiraan kerusakan pada bagian mana ?"
        '
        'ta_jenis_kerusakan
        '
        Me.ta_jenis_kerusakan.ClearBeforeFill = True
        '
        'bs_pengetahuan
        '
        Me.bs_pengetahuan.DataMember = "tb_pengetahuan"
        Me.bs_pengetahuan.DataSource = Me.Db_sistempakarDataSet
        '
        'ta_pengetahuan
        '
        Me.ta_pengetahuan.ClearBeforeFill = True
        '
        'f_pilih_kerusakan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(525, 196)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "f_pilih_kerusakan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form Pilih Kerusakan"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.bs_jenis_kerusakan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Db_sistempakarDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bs_pengetahuan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cmd_proses As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Db_sistempakarDataSet As SISTEM_PAKAR_DIAGNOSIS_KERUSAKAN_TV.db_sistempakarDataSet
    Friend WithEvents bs_jenis_kerusakan As System.Windows.Forms.BindingSource
    Friend WithEvents ta_jenis_kerusakan As SISTEM_PAKAR_DIAGNOSIS_KERUSAKAN_TV.db_sistempakarDataSetTableAdapters.tb_jenis_kerusakanTableAdapter
    Friend WithEvents bs_pengetahuan As System.Windows.Forms.BindingSource
    Friend WithEvents ta_pengetahuan As SISTEM_PAKAR_DIAGNOSIS_KERUSAKAN_TV.db_sistempakarDataSetTableAdapters.tb_pengetahuanTableAdapter
    Friend WithEvents cb_kerusakan As System.Windows.Forms.ComboBox
End Class
