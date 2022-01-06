<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class f_penanganan
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
        Me.cmd_keluar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txt_penanganan = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Db_sistempakarDataSet = New SISTEM_PAKAR_DIAGNOSIS_KERUSAKAN_TV.db_sistempakarDataSet()
        Me.bs_temp = New System.Windows.Forms.BindingSource(Me.components)
        Me.ta_temp = New SISTEM_PAKAR_DIAGNOSIS_KERUSAKAN_TV.db_sistempakarDataSetTableAdapters.tb_tempTableAdapter()
        Me.bs_solusi = New System.Windows.Forms.BindingSource(Me.components)
        Me.ta_solusi = New SISTEM_PAKAR_DIAGNOSIS_KERUSAKAN_TV.db_sistempakarDataSetTableAdapters.tb_solusiTableAdapter()
        Me.GroupBox1.SuspendLayout()
        CType(Me.Db_sistempakarDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bs_temp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bs_solusi, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmd_keluar
        '
        Me.cmd_keluar.BackColor = System.Drawing.Color.DodgerBlue
        Me.cmd_keluar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_keluar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.cmd_keluar.ForeColor = System.Drawing.Color.White
        Me.cmd_keluar.Location = New System.Drawing.Point(138, 388)
        Me.cmd_keluar.Name = "cmd_keluar"
        Me.cmd_keluar.Size = New System.Drawing.Size(99, 39)
        Me.cmd_keluar.TabIndex = 4
        Me.cmd_keluar.Text = "&Keluar"
        Me.cmd_keluar.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txt_penanganan)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.cmd_keluar)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(369, 444)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        '
        'txt_penanganan
        '
        Me.txt_penanganan.Location = New System.Drawing.Point(10, 55)
        Me.txt_penanganan.Multiline = True
        Me.txt_penanganan.Name = "txt_penanganan"
        Me.txt_penanganan.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txt_penanganan.Size = New System.Drawing.Size(349, 315)
        Me.txt_penanganan.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(7, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 16)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Oleh Karena :"
        '
        'Db_sistempakarDataSet
        '
        Me.Db_sistempakarDataSet.DataSetName = "db_sistempakarDataSet"
        Me.Db_sistempakarDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'f_penanganan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(391, 472)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "f_penanganan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form Penanganan"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.Db_sistempakarDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bs_temp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bs_solusi, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmd_keluar As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_penanganan As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Db_sistempakarDataSet As SISTEM_PAKAR_DIAGNOSIS_KERUSAKAN_TV.db_sistempakarDataSet
    Friend WithEvents bs_temp As System.Windows.Forms.BindingSource
    Friend WithEvents ta_temp As SISTEM_PAKAR_DIAGNOSIS_KERUSAKAN_TV.db_sistempakarDataSetTableAdapters.tb_tempTableAdapter
    Friend WithEvents bs_solusi As System.Windows.Forms.BindingSource
    Friend WithEvents ta_solusi As SISTEM_PAKAR_DIAGNOSIS_KERUSAKAN_TV.db_sistempakarDataSetTableAdapters.tb_solusiTableAdapter
End Class
