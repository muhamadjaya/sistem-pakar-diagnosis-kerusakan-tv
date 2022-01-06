Public Class f_menu_utama
    Public id_user, user, status As String
    Public setter As New f_user
    Public tool As New ToolStripControlHost(setter)

    Private Sub aktif_menu(aktif As Boolean)
        datamaster.Enabled = aktif
        cmd_diagnosis.Enabled = aktif
        cmd_pengetahuan.Enabled = aktif
    End Sub

    Private Sub f_menu_utama_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        If user = "" And id_user = "" Then
            f_user_login.Visible = False
            f_user_login.ShowDialog()
        Else
            If status = "PENGGUNA" Then
                aktif_menu(False)
                tssistem.Text = "KONSULTASI"

            Else
                aktif_menu(True)
            End If
        End If
    End Sub

    Private Sub f_menu_utama_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mn_user.DropDownItems.Add(tool)

        With setter
            .lbl_nama.RightToLeft = Windows.Forms.RightToLeft.No
            .lbl_user.RightToLeft = Windows.Forms.RightToLeft.No
            .lbl_logout.RightToLeft = Windows.Forms.RightToLeft.No
            .lbl_ubah_sandi.RightToLeft = Windows.Forms.RightToLeft.No
            .lbl_keluar.RightToLeft = Windows.Forms.RightToLeft.No
        End With
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        txt_jam.Text = TimeString
        ltanggal.Text = CDate(Now).ToShortDateString
        lwaktu.Text = TimeString
    End Sub

    Private Sub KELUARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KELUARToolStripMenuItem.Click
        End
    End Sub

    Private Sub DIAGNOSISKERUSAKANToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DIAGNOSISKERUSAKANToolStripMenuItem.Click
        f_pilih_kerusakan.ShowDialog()
    End Sub

    Private Sub DATAPENGETAHUANToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DATAPENGETAHUANToolStripMenuItem.Click
        f_pengetahuan.ShowDialog()
    End Sub

    Private Sub DATAKERUSAKANToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DATAKERUSAKANToolStripMenuItem.Click
        f_jenis_kerusakan.ShowDialog()
    End Sub

    Private Sub DATASOLUSIToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DATASOLUSIToolStripMenuItem.Click
        f_solusi.ShowDialog()
    End Sub

    Private Sub DATAUSERToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DATAUSERToolStripMenuItem.Click
        f_in_user.ShowDialog()
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        If MsgBox("Yakin Anda akan logout ?", vbQuestion + vbYesNo, "Konfirmasi") = vbYes Then
            user = ""
            id_user = ""
            txt_user.Text = ""
            txt_jabatan.Text = ""
            luser.Text = ""
            f_user_login.ShowDialog()
        End If
    End Sub

    Private Sub cmd_logout_Click(sender As Object, e As EventArgs) Handles cmd_logout.Click
        If MsgBox("Yakin Anda akan logout ?", vbQuestion + vbYesNo, "Konfirmasi") = vbYes Then
            user = ""
            id_user = ""
            txt_user.Text = ""
            txt_jabatan.Text = ""
            luser.Text = ""
            f_user_login.ShowDialog()
        End If
    End Sub

    Private Sub UBAHSANDIToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UBAHSANDIToolStripMenuItem.Click
        f_ubah_sandi.ShowDialog()
    End Sub

    Private Sub RIWAYATDIAGNOSISToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RIWAYATDIAGNOSISToolStripMenuItem.Click
        f_riwayat.ShowDialog()
    End Sub

    Private Sub SistemToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles tssistem.Click

    End Sub
End Class
