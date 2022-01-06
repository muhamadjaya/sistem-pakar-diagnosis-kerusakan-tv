<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class f_user
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(f_user))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lbl_keluar = New System.Windows.Forms.Button()
        Me.lbl_ubah_sandi = New System.Windows.Forms.Button()
        Me.lbl_logout = New System.Windows.Forms.Button()
        Me.lbl_user = New System.Windows.Forms.Label()
        Me.pict_user = New System.Windows.Forms.PictureBox()
        Me.lbl_nama = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.pict_user, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.lbl_keluar)
        Me.Panel1.Controls.Add(Me.lbl_ubah_sandi)
        Me.Panel1.Controls.Add(Me.lbl_logout)
        Me.Panel1.Controls.Add(Me.lbl_user)
        Me.Panel1.Location = New System.Drawing.Point(148, 52)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(149, 165)
        Me.Panel1.TabIndex = 3
        '
        'lbl_keluar
        '
        Me.lbl_keluar.Dock = System.Windows.Forms.DockStyle.Top
        Me.lbl_keluar.FlatAppearance.BorderSize = 0
        Me.lbl_keluar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lbl_keluar.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lbl_keluar.ForeColor = System.Drawing.Color.Red
        Me.lbl_keluar.Location = New System.Drawing.Point(0, 111)
        Me.lbl_keluar.Name = "lbl_keluar"
        Me.lbl_keluar.Size = New System.Drawing.Size(149, 36)
        Me.lbl_keluar.TabIndex = 6
        Me.lbl_keluar.Text = "Keluar"
        Me.lbl_keluar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lbl_keluar.UseVisualStyleBackColor = True
        '
        'lbl_ubah_sandi
        '
        Me.lbl_ubah_sandi.Dock = System.Windows.Forms.DockStyle.Top
        Me.lbl_ubah_sandi.FlatAppearance.BorderSize = 0
        Me.lbl_ubah_sandi.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lbl_ubah_sandi.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lbl_ubah_sandi.ForeColor = System.Drawing.Color.Blue
        Me.lbl_ubah_sandi.Location = New System.Drawing.Point(0, 75)
        Me.lbl_ubah_sandi.Name = "lbl_ubah_sandi"
        Me.lbl_ubah_sandi.Size = New System.Drawing.Size(149, 36)
        Me.lbl_ubah_sandi.TabIndex = 5
        Me.lbl_ubah_sandi.Text = "Ubah Sandi"
        Me.lbl_ubah_sandi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lbl_ubah_sandi.UseVisualStyleBackColor = True
        '
        'lbl_logout
        '
        Me.lbl_logout.Dock = System.Windows.Forms.DockStyle.Top
        Me.lbl_logout.FlatAppearance.BorderSize = 0
        Me.lbl_logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lbl_logout.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lbl_logout.ForeColor = System.Drawing.Color.OrangeRed
        Me.lbl_logout.Location = New System.Drawing.Point(0, 39)
        Me.lbl_logout.Name = "lbl_logout"
        Me.lbl_logout.Size = New System.Drawing.Size(149, 36)
        Me.lbl_logout.TabIndex = 4
        Me.lbl_logout.Text = "Logout"
        Me.lbl_logout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lbl_logout.UseVisualStyleBackColor = True
        '
        'lbl_user
        '
        Me.lbl_user.AutoEllipsis = True
        Me.lbl_user.Dock = System.Windows.Forms.DockStyle.Top
        Me.lbl_user.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Italic Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_user.ForeColor = System.Drawing.Color.DodgerBlue
        Me.lbl_user.Location = New System.Drawing.Point(0, 0)
        Me.lbl_user.Name = "lbl_user"
        Me.lbl_user.Size = New System.Drawing.Size(149, 39)
        Me.lbl_user.TabIndex = 3
        Me.lbl_user.Text = "User"
        Me.lbl_user.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'pict_user
        '
        Me.pict_user.BackColor = System.Drawing.Color.White
        Me.pict_user.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pict_user.Image = CType(resources.GetObject("pict_user.Image"), System.Drawing.Image)
        Me.pict_user.Location = New System.Drawing.Point(13, 52)
        Me.pict_user.Name = "pict_user"
        Me.pict_user.Size = New System.Drawing.Size(131, 143)
        Me.pict_user.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.pict_user.TabIndex = 5
        Me.pict_user.TabStop = False
        '
        'lbl_nama
        '
        Me.lbl_nama.AutoEllipsis = True
        Me.lbl_nama.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_nama.ForeColor = System.Drawing.Color.DodgerBlue
        Me.lbl_nama.Location = New System.Drawing.Point(10, 12)
        Me.lbl_nama.Name = "lbl_nama"
        Me.lbl_nama.Size = New System.Drawing.Size(273, 23)
        Me.lbl_nama.TabIndex = 4
        Me.lbl_nama.Text = "NAMA"
        Me.lbl_nama.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'f_user
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.pict_user)
        Me.Controls.Add(Me.lbl_nama)
        Me.Name = "f_user"
        Me.Size = New System.Drawing.Size(306, 229)
        Me.Panel1.ResumeLayout(False)
        CType(Me.pict_user, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lbl_keluar As System.Windows.Forms.Button
    Friend WithEvents lbl_ubah_sandi As System.Windows.Forms.Button
    Friend WithEvents lbl_logout As System.Windows.Forms.Button
    Friend WithEvents lbl_user As System.Windows.Forms.Label
    Friend WithEvents pict_user As System.Windows.Forms.PictureBox
    Friend WithEvents lbl_nama As System.Windows.Forms.Label

End Class
