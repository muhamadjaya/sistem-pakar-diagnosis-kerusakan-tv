<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class f_menu_utama
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
        Me.TentangToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProgramIniToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PembuatToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mn_user = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.tssistem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DIAGNOSISKERUSAKANToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.KELUARToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.datamaster = New System.Windows.Forms.ToolStripMenuItem()
        Me.DATAPENGETAHUANToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DATAKERUSAKANToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DATASOLUSIToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DATAUSERToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UTILITIESToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.USERToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UBAHSANDIToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RIWAYATDIAGNOSISToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.luser = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel3 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel4 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ltanggal = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel6 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lwaktu = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.cmd_logout = New System.Windows.Forms.Button()
        Me.cmd_pengetahuan = New System.Windows.Forms.Button()
        Me.cmd_diagnosis = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txt_jabatan = New System.Windows.Forms.TextBox()
        Me.txt_jam = New System.Windows.Forms.TextBox()
        Me.txt_user = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TentangToolStripMenuItem
        '
        Me.TentangToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProgramIniToolStripMenuItem, Me.PembuatToolStripMenuItem})
        Me.TentangToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TentangToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.TentangToolStripMenuItem.Name = "TentangToolStripMenuItem"
        Me.TentangToolStripMenuItem.Size = New System.Drawing.Size(74, 20)
        Me.TentangToolStripMenuItem.Text = "&TENTANG"
        '
        'ProgramIniToolStripMenuItem
        '
        Me.ProgramIniToolStripMenuItem.Name = "ProgramIniToolStripMenuItem"
        Me.ProgramIniToolStripMenuItem.Size = New System.Drawing.Size(154, 22)
        Me.ProgramIniToolStripMenuItem.Text = "PROGRAM INI"
        '
        'PembuatToolStripMenuItem
        '
        Me.PembuatToolStripMenuItem.Name = "PembuatToolStripMenuItem"
        Me.PembuatToolStripMenuItem.Size = New System.Drawing.Size(154, 22)
        Me.PembuatToolStripMenuItem.Text = "PEMBUAT"
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LogoutToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(68, 20)
        Me.LogoutToolStripMenuItem.Text = "&LOGOUT"
        '
        'mn_user
        '
        Me.mn_user.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.mn_user.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mn_user.ForeColor = System.Drawing.Color.White
        Me.mn_user.Name = "mn_user"
        Me.mn_user.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.mn_user.Size = New System.Drawing.Size(49, 20)
        Me.mn_user.Text = "USER"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.RoyalBlue
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tssistem, Me.datamaster, Me.UTILITIESToolStripMenuItem, Me.TentangToolStripMenuItem, Me.LogoutToolStripMenuItem, Me.mn_user, Me.RIWAYATDIAGNOSISToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.MenuStrip1.Size = New System.Drawing.Size(1128, 24)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'tssistem
        '
        Me.tssistem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DIAGNOSISKERUSAKANToolStripMenuItem, Me.ToolStripMenuItem1, Me.KELUARToolStripMenuItem})
        Me.tssistem.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tssistem.ForeColor = System.Drawing.Color.White
        Me.tssistem.Name = "tssistem"
        Me.tssistem.Size = New System.Drawing.Size(61, 20)
        Me.tssistem.Text = "&SISTEM"
        '
        'DIAGNOSISKERUSAKANToolStripMenuItem
        '
        Me.DIAGNOSISKERUSAKANToolStripMenuItem.Name = "DIAGNOSISKERUSAKANToolStripMenuItem"
        Me.DIAGNOSISKERUSAKANToolStripMenuItem.Size = New System.Drawing.Size(214, 22)
        Me.DIAGNOSISKERUSAKANToolStripMenuItem.Text = "&DIAGNOSIS KERUSAKAN"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(211, 6)
        '
        'KELUARToolStripMenuItem
        '
        Me.KELUARToolStripMenuItem.Name = "KELUARToolStripMenuItem"
        Me.KELUARToolStripMenuItem.Size = New System.Drawing.Size(214, 22)
        Me.KELUARToolStripMenuItem.Text = "&KELUAR"
        '
        'datamaster
        '
        Me.datamaster.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DATAPENGETAHUANToolStripMenuItem, Me.DATAKERUSAKANToolStripMenuItem, Me.DATASOLUSIToolStripMenuItem, Me.DATAUSERToolStripMenuItem})
        Me.datamaster.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.datamaster.ForeColor = System.Drawing.Color.White
        Me.datamaster.Name = "datamaster"
        Me.datamaster.Size = New System.Drawing.Size(101, 20)
        Me.datamaster.Text = "DATA &MASTER"
        '
        'DATAPENGETAHUANToolStripMenuItem
        '
        Me.DATAPENGETAHUANToolStripMenuItem.Name = "DATAPENGETAHUANToolStripMenuItem"
        Me.DATAPENGETAHUANToolStripMenuItem.Size = New System.Drawing.Size(196, 22)
        Me.DATAPENGETAHUANToolStripMenuItem.Text = "DATA &PENGETAHUAN"
        '
        'DATAKERUSAKANToolStripMenuItem
        '
        Me.DATAKERUSAKANToolStripMenuItem.Name = "DATAKERUSAKANToolStripMenuItem"
        Me.DATAKERUSAKANToolStripMenuItem.Size = New System.Drawing.Size(196, 22)
        Me.DATAKERUSAKANToolStripMenuItem.Text = "DATA &KERUSAKAN"
        '
        'DATASOLUSIToolStripMenuItem
        '
        Me.DATASOLUSIToolStripMenuItem.Name = "DATASOLUSIToolStripMenuItem"
        Me.DATASOLUSIToolStripMenuItem.Size = New System.Drawing.Size(196, 22)
        Me.DATASOLUSIToolStripMenuItem.Text = "DATA SO&LUSI"
        '
        'DATAUSERToolStripMenuItem
        '
        Me.DATAUSERToolStripMenuItem.Name = "DATAUSERToolStripMenuItem"
        Me.DATAUSERToolStripMenuItem.Size = New System.Drawing.Size(196, 22)
        Me.DATAUSERToolStripMenuItem.Text = "DATA US&ER"
        '
        'UTILITIESToolStripMenuItem
        '
        Me.UTILITIESToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.USERToolStripMenuItem})
        Me.UTILITIESToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.UTILITIESToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.UTILITIESToolStripMenuItem.Name = "UTILITIESToolStripMenuItem"
        Me.UTILITIESToolStripMenuItem.Size = New System.Drawing.Size(73, 20)
        Me.UTILITIESToolStripMenuItem.Text = "&UTILITIES"
        '
        'USERToolStripMenuItem
        '
        Me.USERToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UBAHSANDIToolStripMenuItem})
        Me.USERToolStripMenuItem.Name = "USERToolStripMenuItem"
        Me.USERToolStripMenuItem.Size = New System.Drawing.Size(104, 22)
        Me.USERToolStripMenuItem.Text = "USER"
        '
        'UBAHSANDIToolStripMenuItem
        '
        Me.UBAHSANDIToolStripMenuItem.Name = "UBAHSANDIToolStripMenuItem"
        Me.UBAHSANDIToolStripMenuItem.Size = New System.Drawing.Size(148, 22)
        Me.UBAHSANDIToolStripMenuItem.Text = "UBAH SANDI"
        '
        'RIWAYATDIAGNOSISToolStripMenuItem
        '
        Me.RIWAYATDIAGNOSISToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.RIWAYATDIAGNOSISToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.RIWAYATDIAGNOSISToolStripMenuItem.Name = "RIWAYATDIAGNOSISToolStripMenuItem"
        Me.RIWAYATDIAGNOSISToolStripMenuItem.Size = New System.Drawing.Size(142, 20)
        Me.RIWAYATDIAGNOSISToolStripMenuItem.Text = "RIWAYAT DIAGNOSIS"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.Color.RoyalBlue
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.luser, Me.ToolStripStatusLabel3, Me.ToolStripStatusLabel4, Me.ltanggal, Me.ToolStripStatusLabel6, Me.lwaktu})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 457)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1128, 22)
        Me.StatusStrip1.TabIndex = 8
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripStatusLabel1.ForeColor = System.Drawing.Color.White
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(43, 17)
        Me.ToolStripStatusLabel1.Text = "USER :"
        '
        'luser
        '
        Me.luser.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.luser.ForeColor = System.Drawing.Color.White
        Me.luser.Name = "luser"
        Me.luser.Size = New System.Drawing.Size(37, 17)
        Me.luser.Text = "USER"
        '
        'ToolStripStatusLabel3
        '
        Me.ToolStripStatusLabel3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripStatusLabel3.ForeColor = System.Drawing.Color.White
        Me.ToolStripStatusLabel3.Name = "ToolStripStatusLabel3"
        Me.ToolStripStatusLabel3.Size = New System.Drawing.Size(11, 17)
        Me.ToolStripStatusLabel3.Text = "|"
        '
        'ToolStripStatusLabel4
        '
        Me.ToolStripStatusLabel4.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripStatusLabel4.ForeColor = System.Drawing.Color.White
        Me.ToolStripStatusLabel4.Name = "ToolStripStatusLabel4"
        Me.ToolStripStatusLabel4.Size = New System.Drawing.Size(69, 17)
        Me.ToolStripStatusLabel4.Text = "TANGGAL :"
        '
        'ltanggal
        '
        Me.ltanggal.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ltanggal.ForeColor = System.Drawing.Color.White
        Me.ltanggal.Name = "ltanggal"
        Me.ltanggal.Size = New System.Drawing.Size(63, 17)
        Me.ltanggal.Text = "TANGGAL"
        '
        'ToolStripStatusLabel6
        '
        Me.ToolStripStatusLabel6.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripStatusLabel6.ForeColor = System.Drawing.Color.White
        Me.ToolStripStatusLabel6.Name = "ToolStripStatusLabel6"
        Me.ToolStripStatusLabel6.Size = New System.Drawing.Size(57, 17)
        Me.ToolStripStatusLabel6.Text = "WAKTU :"
        '
        'lwaktu
        '
        Me.lwaktu.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lwaktu.ForeColor = System.Drawing.Color.White
        Me.lwaktu.Name = "lwaktu"
        Me.lwaktu.Size = New System.Drawing.Size(51, 17)
        Me.lwaktu.Text = "WAKTU"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'cmd_logout
        '
        Me.cmd_logout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmd_logout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.cmd_logout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.cmd_logout.Location = New System.Drawing.Point(168, 5)
        Me.cmd_logout.Name = "cmd_logout"
        Me.cmd_logout.Size = New System.Drawing.Size(79, 76)
        Me.cmd_logout.TabIndex = 3
        Me.ToolTip1.SetToolTip(Me.cmd_logout, "Logout")
        Me.cmd_logout.UseVisualStyleBackColor = True
        '
        'cmd_pengetahuan
        '
        Me.cmd_pengetahuan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.cmd_pengetahuan.Enabled = False
        Me.cmd_pengetahuan.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.cmd_pengetahuan.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.cmd_pengetahuan.Location = New System.Drawing.Point(86, 5)
        Me.cmd_pengetahuan.Name = "cmd_pengetahuan"
        Me.cmd_pengetahuan.Size = New System.Drawing.Size(79, 76)
        Me.cmd_pengetahuan.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.cmd_pengetahuan, "Data Pengetahuan")
        Me.cmd_pengetahuan.UseVisualStyleBackColor = True
        '
        'cmd_diagnosis
        '
        Me.cmd_diagnosis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.cmd_diagnosis.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.cmd_diagnosis.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.cmd_diagnosis.Location = New System.Drawing.Point(4, 5)
        Me.cmd_diagnosis.Name = "cmd_diagnosis"
        Me.cmd_diagnosis.Size = New System.Drawing.Size(79, 76)
        Me.cmd_diagnosis.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.cmd_diagnosis, "Diagnosis Kerusakan")
        Me.cmd_diagnosis.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.RoyalBlue
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.txt_jabatan)
        Me.Panel2.Controls.Add(Me.txt_jam)
        Me.Panel2.Controls.Add(Me.txt_user)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 112)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(158, 345)
        Me.Panel2.TabIndex = 10
        '
        'txt_jabatan
        '
        Me.txt_jabatan.BackColor = System.Drawing.Color.White
        Me.txt_jabatan.Enabled = False
        Me.txt_jabatan.Font = New System.Drawing.Font("Arial Black", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_jabatan.Location = New System.Drawing.Point(0, 96)
        Me.txt_jabatan.Multiline = True
        Me.txt_jabatan.Name = "txt_jabatan"
        Me.txt_jabatan.Size = New System.Drawing.Size(157, 45)
        Me.txt_jabatan.TabIndex = 3
        Me.txt_jabatan.Text = "*"
        Me.txt_jabatan.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_jam
        '
        Me.txt_jam.BackColor = System.Drawing.Color.White
        Me.txt_jam.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.txt_jam.Enabled = False
        Me.txt_jam.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_jam.Location = New System.Drawing.Point(0, 298)
        Me.txt_jam.Multiline = True
        Me.txt_jam.Name = "txt_jam"
        Me.txt_jam.Size = New System.Drawing.Size(156, 45)
        Me.txt_jam.TabIndex = 2
        Me.txt_jam.Text = "00:00:00"
        Me.txt_jam.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_user
        '
        Me.txt_user.BackColor = System.Drawing.Color.White
        Me.txt_user.Enabled = False
        Me.txt_user.Font = New System.Drawing.Font("Arial Black", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_user.Location = New System.Drawing.Point(0, 51)
        Me.txt_user.Multiline = True
        Me.txt_user.Name = "txt_user"
        Me.txt_user.Size = New System.Drawing.Size(157, 45)
        Me.txt_user.TabIndex = 1
        Me.txt_user.Text = "*"
        Me.txt_user.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Black", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(28, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(107, 41)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "USER"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Control
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.cmd_logout)
        Me.Panel1.Controls.Add(Me.cmd_pengetahuan)
        Me.Panel1.Controls.Add(Me.cmd_diagnosis)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 24)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1128, 88)
        Me.Panel1.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(779, 4)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(264, 30)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Diagnosis Kerusakan TV"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label2.Location = New System.Drawing.Point(649, 4)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(269, 30)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Sistem Pakar"
        '
        'f_menu_utama
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1128, 479)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "f_menu_utama"
        Me.Text = "Menu Utama"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TentangToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mn_user As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents tssistem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProgramIniToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PembuatToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents luser As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel3 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel4 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ltanggal As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel6 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lwaktu As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents datamaster As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents txt_jabatan As System.Windows.Forms.TextBox
    Friend WithEvents txt_jam As System.Windows.Forms.TextBox
    Friend WithEvents txt_user As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmd_logout As System.Windows.Forms.Button
    Friend WithEvents cmd_pengetahuan As System.Windows.Forms.Button
    Friend WithEvents cmd_diagnosis As System.Windows.Forms.Button
    Friend WithEvents DIAGNOSISKERUSAKANToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents KELUARToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DATAPENGETAHUANToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DATAKERUSAKANToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DATASOLUSIToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DATAUSERToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UTILITIESToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents USERToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UBAHSANDIToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RIWAYATDIAGNOSISToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
