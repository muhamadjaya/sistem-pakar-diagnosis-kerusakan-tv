Public Class f_user_login

    Private Sub f_user_login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Db_sistempakarDataSet.tb_user' table. You can move, or remove it, as needed.
        Me.ta_user.Fill(Me.Db_sistempakarDataSet.tb_user)

    End Sub

    Private Sub cmd_login_Click(sender As Object, e As EventArgs) Handles cmd_login.Click
        If txt_user_name.Text <> "" And txt_sandi.Text <> "" Then
            With bs_user
                .MoveFirst()
                For i = 1 To bs_user.Count
                    If txt_user_name.Text = .Current("user_id") And txt_sandi.Text = .Current("password") And cb_level.Text = .Current("jabatan") Then
                        f_menu_utama.id_user = .Current("kd_user")
                        f_menu_utama.user = .Current("nama_user")
                        f_menu_utama.status = .Current("jabatan")

                        f_menu_utama.setter.lbl_nama.Text = .Current("nama_user")
                        f_menu_utama.setter.lbl_user.Text = .Current("user_id")
                        f_menu_utama.mn_user.Text = .Current("nama_user")

                        f_menu_utama.txt_user.Text = UCase(.Current("nama_user"))
                        f_menu_utama.txt_jabatan.Text = UCase(.Current("jabatan"))
                        f_menu_utama.luser.Text = UCase(.Current("nama_user"))
                        Me.Close()
                        Exit Sub
                    Else
                        .MoveNext()
                    End If
                Next
                MsgBox("Maaf User Name atau Sandi tidak valid !", vbCritical, "Perhatian")
                Exit Sub
            End With
        Else
            MsgBox("Maaf data masih kosong !", vbExclamation, "Perhatian")
            Exit Sub
        End If
    End Sub


    Private Sub cmd_keluar_Click(sender As Object, e As EventArgs) Handles cmd_keluar.Click
        If MsgBox("Yakin Anda akan keluar ?", vbQuestion + vbYesNo, "Konfirmasi") = vbYes Then
            End
        End If
    End Sub
End Class