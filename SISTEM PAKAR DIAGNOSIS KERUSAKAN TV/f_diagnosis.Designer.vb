<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class f_diagnosis
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
        Me.lbl_diagnosis = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmd_tidak = New System.Windows.Forms.Button()
        Me.cmd_ya = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cmd_selesai = New System.Windows.Forms.Button()
        Me.Db_sistempakarDataSet = New SISTEM_PAKAR_DIAGNOSIS_KERUSAKAN_TV.db_sistempakarDataSet()
        Me.bs_pengetahuan = New System.Windows.Forms.BindingSource(Me.components)
        Me.ta_pengetahuan = New SISTEM_PAKAR_DIAGNOSIS_KERUSAKAN_TV.db_sistempakarDataSetTableAdapters.tb_pengetahuanTableAdapter()
        Me.bs_temp = New System.Windows.Forms.BindingSource(Me.components)
        Me.ta_temp = New SISTEM_PAKAR_DIAGNOSIS_KERUSAKAN_TV.db_sistempakarDataSetTableAdapters.tb_tempTableAdapter()
        Me.bs_solusi = New System.Windows.Forms.BindingSource(Me.components)
        Me.ta_solusi = New SISTEM_PAKAR_DIAGNOSIS_KERUSAKAN_TV.db_sistempakarDataSetTableAdapters.tb_solusiTableAdapter()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.Db_sistempakarDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bs_pengetahuan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bs_temp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bs_solusi, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_diagnosis
        '
        Me.lbl_diagnosis.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_diagnosis.ForeColor = System.Drawing.Color.DodgerBlue
        Me.lbl_diagnosis.Location = New System.Drawing.Point(6, 20)
        Me.lbl_diagnosis.Name = "lbl_diagnosis"
        Me.lbl_diagnosis.Size = New System.Drawing.Size(750, 23)
        Me.lbl_diagnosis.TabIndex = 0
        Me.lbl_diagnosis.Text = "Label1"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmd_tidak)
        Me.GroupBox1.Controls.Add(Me.cmd_ya)
        Me.GroupBox1.Controls.Add(Me.lbl_diagnosis)
        Me.GroupBox1.Location = New System.Drawing.Point(11, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(763, 131)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'cmd_tidak
        '
        Me.cmd_tidak.BackColor = System.Drawing.Color.DodgerBlue
        Me.cmd_tidak.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_tidak.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.cmd_tidak.ForeColor = System.Drawing.Color.White
        Me.cmd_tidak.Location = New System.Drawing.Point(130, 78)
        Me.cmd_tidak.Name = "cmd_tidak"
        Me.cmd_tidak.Size = New System.Drawing.Size(99, 39)
        Me.cmd_tidak.TabIndex = 4
        Me.cmd_tidak.Text = "&Tidak"
        Me.cmd_tidak.UseVisualStyleBackColor = False
        '
        'cmd_ya
        '
        Me.cmd_ya.BackColor = System.Drawing.Color.DodgerBlue
        Me.cmd_ya.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_ya.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.cmd_ya.ForeColor = System.Drawing.Color.White
        Me.cmd_ya.Location = New System.Drawing.Point(6, 78)
        Me.cmd_ya.Name = "cmd_ya"
        Me.cmd_ya.Size = New System.Drawing.Size(99, 39)
        Me.cmd_ya.TabIndex = 3
        Me.cmd_ya.Text = "&Ya"
        Me.cmd_ya.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cmd_selesai)
        Me.GroupBox2.Location = New System.Drawing.Point(11, 134)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(763, 68)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        '
        'cmd_selesai
        '
        Me.cmd_selesai.BackColor = System.Drawing.Color.DodgerBlue
        Me.cmd_selesai.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue
        Me.cmd_selesai.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_selesai.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.cmd_selesai.ForeColor = System.Drawing.Color.White
        Me.cmd_selesai.Location = New System.Drawing.Point(657, 17)
        Me.cmd_selesai.Name = "cmd_selesai"
        Me.cmd_selesai.Size = New System.Drawing.Size(99, 39)
        Me.cmd_selesai.TabIndex = 5
        Me.cmd_selesai.Text = "&Selesai"
        Me.cmd_selesai.UseVisualStyleBackColor = False
        '
        'Db_sistempakarDataSet
        '
        Me.Db_sistempakarDataSet.DataSetName = "db_sistempakarDataSet"
        Me.Db_sistempakarDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'bs_temp
        '
        Me.bs_temp.DataMember = "tb_temp"
        Me.bs_temp.DataSource = Me.Db_sistempakarDataSet
        '
        'ta_temp
        '
        Me.ta_temp.ClearBeforeFill = True
        '
        'bs_solusi
        '
        Me.bs_solusi.DataMember = "tb_solusi"
        Me.bs_solusi.DataSource = Me.Db_sistempakarDataSet
        '
        'ta_solusi
        '
        Me.ta_solusi.ClearBeforeFill = True
        '
        'f_diagnosis
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(786, 211)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "f_diagnosis"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form Diagnosis"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.Db_sistempakarDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bs_pengetahuan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bs_temp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bs_solusi, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lbl_diagnosis As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cmd_tidak As System.Windows.Forms.Button
    Friend WithEvents cmd_ya As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents cmd_selesai As System.Windows.Forms.Button
    Friend WithEvents Db_sistempakarDataSet As SISTEM_PAKAR_DIAGNOSIS_KERUSAKAN_TV.db_sistempakarDataSet
    Friend WithEvents bs_pengetahuan As System.Windows.Forms.BindingSource
    Friend WithEvents ta_pengetahuan As SISTEM_PAKAR_DIAGNOSIS_KERUSAKAN_TV.db_sistempakarDataSetTableAdapters.tb_pengetahuanTableAdapter
    Friend WithEvents bs_temp As System.Windows.Forms.BindingSource
    Friend WithEvents ta_temp As SISTEM_PAKAR_DIAGNOSIS_KERUSAKAN_TV.db_sistempakarDataSetTableAdapters.tb_tempTableAdapter
    Friend WithEvents bs_solusi As System.Windows.Forms.BindingSource
    Friend WithEvents ta_solusi As SISTEM_PAKAR_DIAGNOSIS_KERUSAKAN_TV.db_sistempakarDataSetTableAdapters.tb_solusiTableAdapter
End Class
