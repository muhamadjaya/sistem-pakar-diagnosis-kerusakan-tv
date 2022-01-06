<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class f_ubah_sandi
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(f_ubah_sandi))
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.cmd_simpan = New System.Windows.Forms.Button()
        Me.cmd_keluar = New System.Windows.Forms.Button()
        Me.txt_konfirmasi_sandi = New System.Windows.Forms.TextBox()
        Me.txt_sandi_baru = New System.Windows.Forms.TextBox()
        Me.txt_sandi_lama = New System.Windows.Forms.TextBox()
        Me.txt_user_name = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Label6 = New System.Windows.Forms.Label()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.Db_sistempakarDataSet = New SISTEM_PAKAR_DIAGNOSIS_KERUSAKAN_TV.db_sistempakarDataSet()
        Me.bs_user = New System.Windows.Forms.BindingSource(Me.components)
        Me.ta_user = New SISTEM_PAKAR_DIAGNOSIS_KERUSAKAN_TV.db_sistempakarDataSetTableAdapters.tb_userTableAdapter()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Db_sistempakarDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bs_user, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.cmd_simpan)
        Me.GroupBox3.Controls.Add(Me.cmd_keluar)
        Me.GroupBox3.Location = New System.Drawing.Point(6, 165)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(312, 60)
        Me.GroupBox3.TabIndex = 18
        Me.GroupBox3.TabStop = False
        '
        'cmd_simpan
        '
        Me.cmd_simpan.BackgroundImage = CType(resources.GetObject("cmd_simpan.BackgroundImage"), System.Drawing.Image)
        Me.cmd_simpan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmd_simpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_simpan.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_simpan.ForeColor = System.Drawing.Color.White
        Me.cmd_simpan.Location = New System.Drawing.Point(134, 15)
        Me.cmd_simpan.Name = "cmd_simpan"
        Me.cmd_simpan.Size = New System.Drawing.Size(81, 35)
        Me.cmd_simpan.TabIndex = 8
        Me.cmd_simpan.Text = "&SIMPAN"
        Me.cmd_simpan.UseVisualStyleBackColor = True
        '
        'cmd_keluar
        '
        Me.cmd_keluar.BackgroundImage = CType(resources.GetObject("cmd_keluar.BackgroundImage"), System.Drawing.Image)
        Me.cmd_keluar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmd_keluar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_keluar.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_keluar.ForeColor = System.Drawing.Color.White
        Me.cmd_keluar.Location = New System.Drawing.Point(220, 15)
        Me.cmd_keluar.Name = "cmd_keluar"
        Me.cmd_keluar.Size = New System.Drawing.Size(81, 35)
        Me.cmd_keluar.TabIndex = 9
        Me.cmd_keluar.Text = "&KELUAR"
        Me.cmd_keluar.UseVisualStyleBackColor = True
        '
        'txt_konfirmasi_sandi
        '
        Me.txt_konfirmasi_sandi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_konfirmasi_sandi.Location = New System.Drawing.Point(131, 88)
        Me.txt_konfirmasi_sandi.Name = "txt_konfirmasi_sandi"
        Me.txt_konfirmasi_sandi.Size = New System.Drawing.Size(157, 20)
        Me.txt_konfirmasi_sandi.TabIndex = 7
        '
        'txt_sandi_baru
        '
        Me.txt_sandi_baru.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_sandi_baru.Location = New System.Drawing.Point(131, 64)
        Me.txt_sandi_baru.Name = "txt_sandi_baru"
        Me.txt_sandi_baru.Size = New System.Drawing.Size(157, 20)
        Me.txt_sandi_baru.TabIndex = 6
        '
        'txt_sandi_lama
        '
        Me.txt_sandi_lama.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_sandi_lama.Location = New System.Drawing.Point(131, 40)
        Me.txt_sandi_lama.Name = "txt_sandi_lama"
        Me.txt_sandi_lama.Size = New System.Drawing.Size(157, 20)
        Me.txt_sandi_lama.TabIndex = 5
        '
        'txt_user_name
        '
        Me.txt_user_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_user_name.Location = New System.Drawing.Point(131, 16)
        Me.txt_user_name.Name = "txt_user_name"
        Me.txt_user_name.Size = New System.Drawing.Size(157, 20)
        Me.txt_user_name.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(30, 90)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(98, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Ulangi Sandi Baru :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(30, 66)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Sandi Baru :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(30, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Sandi Lama :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(30, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "User Name :"
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.RoyalBlue
        Me.Label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label5.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(3, 3)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(315, 42)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "UBAH SANDI"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txt_konfirmasi_sandi)
        Me.GroupBox2.Controls.Add(Me.txt_sandi_baru)
        Me.GroupBox2.Controls.Add(Me.txt_sandi_lama)
        Me.GroupBox2.Controls.Add(Me.txt_user_name)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Location = New System.Drawing.Point(5, 48)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(313, 123)
        Me.GroupBox2.TabIndex = 17
        Me.GroupBox2.TabStop = False
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.White
        Me.Label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label6.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(4, 10)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(314, 42)
        Me.Label6.TabIndex = 20
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'StatusStrip1
        '
        Me.StatusStrip1.AutoSize = False
        Me.StatusStrip1.BackColor = System.Drawing.Color.RoyalBlue
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 230)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(323, 10)
        Me.StatusStrip1.TabIndex = 19
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'Db_sistempakarDataSet
        '
        Me.Db_sistempakarDataSet.DataSetName = "db_sistempakarDataSet"
        Me.Db_sistempakarDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'bs_user
        '
        Me.bs_user.DataMember = "tb_user"
        Me.bs_user.DataSource = Me.Db_sistempakarDataSet
        '
        'ta_user
        '
        Me.ta_user.ClearBeforeFill = True
        '
        'f_ubah_sandi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(323, 240)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.StatusStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "f_ubah_sandi"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form Ubah Sandi"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Db_sistempakarDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bs_user, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents cmd_simpan As System.Windows.Forms.Button
    Friend WithEvents cmd_keluar As System.Windows.Forms.Button
    Friend WithEvents txt_konfirmasi_sandi As System.Windows.Forms.TextBox
    Friend WithEvents txt_sandi_baru As System.Windows.Forms.TextBox
    Friend WithEvents txt_sandi_lama As System.Windows.Forms.TextBox
    Friend WithEvents txt_user_name As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents Db_sistempakarDataSet As SISTEM_PAKAR_DIAGNOSIS_KERUSAKAN_TV.db_sistempakarDataSet
    Friend WithEvents bs_user As System.Windows.Forms.BindingSource
    Friend WithEvents ta_user As SISTEM_PAKAR_DIAGNOSIS_KERUSAKAN_TV.db_sistempakarDataSetTableAdapters.tb_userTableAdapter
End Class
