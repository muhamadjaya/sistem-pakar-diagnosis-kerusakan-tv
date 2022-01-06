Public Class f_ubah_sandi

    Private Sub f_ubah_sandi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Db_sistempakarDataSet.tb_user' table. You can move, or remove it, as needed.
        Me.ta_user.Fill(Me.Db_sistempakarDataSet.tb_user)

        Call kosongkan()
    End Sub

    Private Sub kosongkan()
        txt_user_name.Clear()
        txt_sandi_lama.Clear()
        txt_sandi_baru.Clear()
        txt_konfirmasi_sandi.Clear()
        txt_user_name.Focus()
    End Sub

    Private Sub cmd_simpan_Click(sender As Object, e As EventArgs) Handles cmd_simpan.Click
        If txt_user_name.Text <> "" And txt_sandi_lama.Text <> "" Then
            With bs_user
                .MoveFirst()
                For i = 1 To .Count
                    If txt_user_name.Text = .Current("user_name") And txt_sandi_lama.Text = .Current("sandi") Then
                        With bs_user
                            .Current("sandi") = txt_sandi_baru.Text
                            .EndEdit()
                        End With
                        ta_user.Update(Db_sistempakarDataSet)
                        MsgBox("Sandi berhasil di ubah !", vbInformation, "Informasi")
                        Call kosongkan()
                        Exit Sub
                    Else
                        .MoveNext()
                    End If
                Next i
                MsgBox("Maaf User Name atau sandi lama yang Anda masukkan tidak valid !", vbCritical, "Perhatian")
            End With
        End If
    End Sub

    Private Sub cmd_keluar_Click(sender As Object, e As EventArgs) Handles cmd_keluar.Click
        If MsgBox("Yakin Anda akan keluar ?", vbQuestion + vbYesNo, "Konfirmasi") = vbYes Then
            Me.Close()
        End If
    End Sub

    Private Sub txt_user_name_LostFocus(sender As Object, e As EventArgs) Handles txt_user_name.LostFocus
        If txt_user_name.Text <> "" Then
            With bs_user
                .MoveFirst()
                For i = 1 To bs_user.Count
                    If txt_user_name.Text = .Current("user_name") Then
                        ErrorProvider1.SetError(txt_user_name, "")
                        Exit Sub
                    Else
                        .MoveNext()
                    End If
                Next i
                ErrorProvider1.SetError(txt_user_name, "Maaf User Name Tidak Valid !")
            End With
        End If
    End Sub

    Private Sub txt_konfirmasi_sandi_LostFocus(sender As Object, e As EventArgs) Handles txt_konfirmasi_sandi.LostFocus
        If txt_sandi_baru.Text <> txt_konfirmasi_sandi.Text Then
            ErrorProvider1.SetError(txt_konfirmasi_sandi, "Maaf Ulangi Sandi Baru Tidak Valid !")
            txt_konfirmasi_sandi.Focus()
            Exit Sub
        Else
            ErrorProvider1.SetError(txt_konfirmasi_sandi, "")
        End If
    End Sub

End Class