Public Class f_user

    Private Sub lbl_keluar_Click(sender As Object, e As EventArgs) Handles lbl_keluar.Click
        If MsgBox("Yakin Anda akan keluar ?", vbQuestion + vbYesNo, "Konfirmasi") = vbYes Then
            f_menu_utama.user = ""
            f_menu_utama.id_user = ""
            f_menu_utama.txt_user.Text = ""
            f_menu_utama.txt_jabatan.Text = ""
            f_menu_utama.luser.Text = ""
            End
        End If
    End Sub

    Private Sub lbl_ubah_sandi_Click(sender As Object, e As EventArgs) Handles lbl_ubah_sandi.Click
        f_ubah_sandi.ShowDialog()
    End Sub

    Private Sub lbl_logout_Click(sender As Object, e As EventArgs) Handles lbl_logout.Click
        If MsgBox("Yakin Anda akan logout ?", vbQuestion + vbYesNo, "Konfirmasi") = vbYes Then
            f_menu_utama.user = ""
            f_menu_utama.id_user = ""
            f_menu_utama.txt_user.Text = ""
            f_menu_utama.txt_jabatan.Text = ""
            f_menu_utama.luser.Text = ""
            f_user_login.ShowDialog()
        End If
    End Sub
End Class
