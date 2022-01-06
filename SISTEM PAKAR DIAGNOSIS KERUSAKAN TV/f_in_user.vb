Public Class f_in_user

    Private Sub f_in_user_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Db_sistempakarDataSet.tb_user' table. You can move, or remove it, as needed.
        Me.ta_user.Fill(Me.Db_sistempakarDataSet.tb_user)

        Call kosongkan()
        Call kd_otomatis()
    End Sub

    Private Sub kd_otomatis()
        txt_kd_user.Text = "U" & Format(bs_user.Count + 1, "0")
    End Sub

    Private Sub kosongkan()
        txt_nama_user.Clear()
        txt_cp.Clear()
        cb_jabatan.SelectedIndex = 0
        txt_user_id.Clear()
        txt_password.Clear()
        kd_otomatis()
        txt_nama_user.Focus()
    End Sub

    Private Sub aktif_false()
        txt_nama_user.Enabled = False
        txt_cp.Enabled = False
        cb_jabatan.Enabled = False
        txt_user_id.Enabled = False
        txt_password.Enabled = False
    End Sub

    Private Sub aktif_true()
        txt_nama_user.Enabled = True
        txt_cp.Enabled = True
        cb_jabatan.Enabled = True
        txt_user_id.Enabled = True
        txt_password.Enabled = True
    End Sub

    Private Sub cmd_tambah_Click(sender As Object, e As EventArgs) Handles cmd_tambah.Click
        Call kosongkan()
        gb_in_user.Enabled = True
        cmd_simpan.Enabled = True
        cmd_perbarui.Enabled = False
        cmd_hapus.Enabled = False
        cmd_tambah.Enabled = False
    End Sub

    Private Sub cmd_simpan_Click(sender As Object, e As EventArgs) Handles cmd_simpan.Click
        If txt_nama_user.Text <> "" And txt_cp.Text <> "" And txt_user_id.Text <> "" And txt_password.Text <> "" Then
            With bs_user
                .AddNew()
                .Current("kd_user") = txt_kd_user.Text
                .Current("nama_user") = txt_nama_user.Text
                .Current("cp") = txt_cp.Text
                .Current("jabatan") = cb_jabatan.Text
                .Current("user_id") = txt_user_id.Text
                .Current("password") = txt_password.Text
                .EndEdit()
                ta_user.Update(Db_sistempakarDataSet)
                MsgBox("Data berhasil disimpan !", vbInformation, "Info")
                Call kosongkan()
                Call kd_otomatis()
            End With
        Else
            MsgBox("Maaf data belum lengkap !", vbExclamation, "Perhatian")
        End If

    End Sub

    Private Sub dgv_user_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_user.CellClick
        gb_in_user.Enabled = True
        With bs_user
            If .Count > 0 Then
                txt_kd_user.Text = .Current("kd_user")
                txt_nama_user.Text = .Current("nama_user")
                txt_cp.Text = .Current("cp")
                cb_jabatan.SelectedItem = .Current("jabatan")
                txt_user_id.Text = .Current("user_id")
                txt_password.Text = .Current("password")

                cmd_simpan.Enabled = False
                cmd_perbarui.Enabled = True
                cmd_hapus.Enabled = True
                txt_kd_user.Enabled = False
            End If
        End With
    End Sub

    Private Sub cmd_perbarui_Click(sender As Object, e As EventArgs) Handles cmd_perbarui.Click
        With bs_user
            .Current("nama_user") = txt_nama_user.Text
            .Current("cp") = txt_cp.Text
            .Current("jabatan") = cb_jabatan.Text
            .Current("user_id") = txt_user_id.Text
            .Current("password") = txt_password.Text
            .EndEdit()
            ta_user.Update(Db_sistempakarDataSet)
            Call kosongkan()
            cmd_tambah.Enabled = True
            cmd_simpan.Enabled = False
            cmd_perbarui.Enabled = False
            cmd_hapus.Enabled = False
        End With
    End Sub

    Private Sub cmd_hapus_Click(sender As Object, e As EventArgs) Handles cmd_hapus.Click
        If bs_user.Count > 0 Then
            If MsgBox("Yakin Anda akan menghapus data ini ?", vbQuestion + vbYesNo, "Konfirmasi") = vbYes Then
                bs_user.RemoveCurrent()
                bs_user.EndEdit()
                ta_user.Update(Db_sistempakarDataSet)
                kosongkan()
                cmd_tambah.Enabled = True
                cmd_simpan.Enabled = False
                cmd_perbarui.Enabled = False
                cmd_hapus.Enabled = False
            End If
        Else
            MsgBox("Maaf data masih kosong !", vbExclamation, "Perhatian")
        End If
    End Sub

    Private Sub cmd_keluar_Click(sender As Object, e As EventArgs) Handles cmd_keluar.Click
        keluar(Me)
    End Sub

    Private Sub txt_cp_TextChanged(sender As Object, e As EventArgs) Handles txt_cp.TextChanged
        If txt_cp.Text <> "" Then
            If IsNumeric(txt_cp.Text) = False Then
                MsgBox("Maaf harus diisi dengan angka !", vbExclamation, "Perhatian")
                txt_cp.Text = ""
            End If
        End If
    End Sub
End Class