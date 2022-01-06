<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class f_user_login
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
        Me.cmd_login = New System.Windows.Forms.Button()
        Me.txt_sandi = New System.Windows.Forms.TextBox()
        Me.txt_user_name = New System.Windows.Forms.TextBox()
        Me.PasswordLabel = New System.Windows.Forms.Label()
        Me.UsernameLabel = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cb_level = New System.Windows.Forms.ComboBox()
        Me.cmd_keluar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Db_sistempakarDataSet = New SISTEM_PAKAR_DIAGNOSIS_KERUSAKAN_TV.db_sistempakarDataSet()
        Me.bs_user = New System.Windows.Forms.BindingSource(Me.components)
        Me.ta_user = New SISTEM_PAKAR_DIAGNOSIS_KERUSAKAN_TV.db_sistempakarDataSetTableAdapters.tb_userTableAdapter()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.Db_sistempakarDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bs_user, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmd_login
        '
        Me.cmd_login.BackColor = System.Drawing.Color.DodgerBlue
        Me.cmd_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_login.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_login.ForeColor = System.Drawing.Color.White
        Me.cmd_login.Location = New System.Drawing.Point(165, 134)
        Me.cmd_login.Name = "cmd_login"
        Me.cmd_login.Size = New System.Drawing.Size(92, 32)
        Me.cmd_login.TabIndex = 8
        Me.cmd_login.Text = "&Masuk"
        Me.cmd_login.UseVisualStyleBackColor = False
        '
        'txt_sandi
        '
        Me.txt_sandi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_sandi.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_sandi.ForeColor = System.Drawing.Color.DodgerBlue
        Me.txt_sandi.Location = New System.Drawing.Point(152, 68)
        Me.txt_sandi.Name = "txt_sandi"
        Me.txt_sandi.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_sandi.Size = New System.Drawing.Size(226, 23)
        Me.txt_sandi.TabIndex = 4
        '
        'txt_user_name
        '
        Me.txt_user_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_user_name.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_user_name.ForeColor = System.Drawing.Color.DodgerBlue
        Me.txt_user_name.Location = New System.Drawing.Point(152, 39)
        Me.txt_user_name.Name = "txt_user_name"
        Me.txt_user_name.Size = New System.Drawing.Size(226, 23)
        Me.txt_user_name.TabIndex = 2
        '
        'PasswordLabel
        '
        Me.PasswordLabel.AutoSize = True
        Me.PasswordLabel.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PasswordLabel.ForeColor = System.Drawing.Color.DodgerBlue
        Me.PasswordLabel.Location = New System.Drawing.Point(68, 68)
        Me.PasswordLabel.Name = "PasswordLabel"
        Me.PasswordLabel.Size = New System.Drawing.Size(74, 17)
        Me.PasswordLabel.TabIndex = 10
        Me.PasswordLabel.Text = "&Password :"
        Me.PasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'UsernameLabel
        '
        Me.UsernameLabel.AutoSize = True
        Me.UsernameLabel.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UsernameLabel.ForeColor = System.Drawing.Color.DodgerBlue
        Me.UsernameLabel.Location = New System.Drawing.Point(59, 40)
        Me.UsernameLabel.Name = "UsernameLabel"
        Me.UsernameLabel.Size = New System.Drawing.Size(83, 17)
        Me.UsernameLabel.TabIndex = 8
        Me.UsernameLabel.Text = "&User Name :"
        Me.UsernameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(7, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(446, 34)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Sistem Pakar Diagnosis Kerusakan TV"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DodgerBlue
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(454, 43)
        Me.Panel1.TabIndex = 13
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Label2.Location = New System.Drawing.Point(94, 98)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 17)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "&Level :"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cb_level
        '
        Me.cb_level.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_level.FormattingEnabled = True
        Me.cb_level.Items.AddRange(New Object() {"PENGGUNA", "PAKAR", "ADMIN"})
        Me.cb_level.Location = New System.Drawing.Point(152, 97)
        Me.cb_level.Name = "cb_level"
        Me.cb_level.Size = New System.Drawing.Size(226, 25)
        Me.cb_level.TabIndex = 6
        '
        'cmd_keluar
        '
        Me.cmd_keluar.BackColor = System.Drawing.Color.DodgerBlue
        Me.cmd_keluar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_keluar.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_keluar.ForeColor = System.Drawing.Color.White
        Me.cmd_keluar.Location = New System.Drawing.Point(274, 134)
        Me.cmd_keluar.Name = "cmd_keluar"
        Me.cmd_keluar.Size = New System.Drawing.Size(92, 32)
        Me.cmd_keluar.TabIndex = 10
        Me.cmd_keluar.Text = "&Keluar"
        Me.cmd_keluar.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.cmd_keluar)
        Me.GroupBox1.Controls.Add(Me.cb_level)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.cmd_login)
        Me.GroupBox1.Controls.Add(Me.txt_sandi)
        Me.GroupBox1.Controls.Add(Me.txt_user_name)
        Me.GroupBox1.Controls.Add(Me.PasswordLabel)
        Me.GroupBox1.Controls.Add(Me.UsernameLabel)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.GroupBox1.ForeColor = System.Drawing.Color.DodgerBlue
        Me.GroupBox1.Location = New System.Drawing.Point(15, 47)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(427, 181)
        Me.GroupBox1.TabIndex = 17
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Sistem Login"
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
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.Color.DodgerBlue
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 236)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(454, 22)
        Me.StatusStrip1.TabIndex = 20
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'f_user_login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(454, 258)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "f_user_login"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sistem Login"
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.Db_sistempakarDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bs_user, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmd_login As System.Windows.Forms.Button
    Friend WithEvents txt_sandi As System.Windows.Forms.TextBox
    Friend WithEvents txt_user_name As System.Windows.Forms.TextBox
    Friend WithEvents PasswordLabel As System.Windows.Forms.Label
    Friend WithEvents UsernameLabel As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cb_level As System.Windows.Forms.ComboBox
    Friend WithEvents cmd_keluar As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Db_sistempakarDataSet As SISTEM_PAKAR_DIAGNOSIS_KERUSAKAN_TV.db_sistempakarDataSet
    Friend WithEvents bs_user As System.Windows.Forms.BindingSource
    Friend WithEvents ta_user As SISTEM_PAKAR_DIAGNOSIS_KERUSAKAN_TV.db_sistempakarDataSetTableAdapters.tb_userTableAdapter
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
End Class
