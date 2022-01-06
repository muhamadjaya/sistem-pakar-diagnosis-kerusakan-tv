Public Class f_jenis_kerusakan

    Private Sub f_jenis_kerusakan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Db_sistempakarDataSet.tb_jenis_kerusakan' table. You can move, or remove it, as needed.
        Me.ta_jenis_kerusakan.Fill(Me.Db_sistempakarDataSet.tb_jenis_kerusakan)

        Call kosongkan()
        Call kd_otomatis()
    End Sub

    Private Sub kd_otomatis()
        txt_kd_jenis_kerusakan.Text = "R" & Format(bs_jenis_kerusakan.Count + 1, "00")
    End Sub

    Private Sub kosongkan()
        txt_kd_jenis_kerusakan.Clear()
        txt_jenis_kerusakan.Clear()
        kd_otomatis()
    End Sub

    Private Sub cmd_tambah_Click(sender As Object, e As EventArgs) Handles cmd_tambah.Click
        kosongkan()
        gb_jenis_kerusakan.Enabled = True
        'txt_kd_jenis_kerusakan.Enabled = True
        cmd_simpan.Enabled = True
        cmd_perbarui.Enabled = False
        cmd_hapus.Enabled = False
        cmd_tambah.Enabled = False
    End Sub

    Private Sub cmd_simpan_Click(sender As Object, e As EventArgs) Handles cmd_simpan.Click
        With bs_jenis_kerusakan
            .AddNew()
            .Current("kd_kerusakan") = txt_kd_jenis_kerusakan.Text
            .Current("jenis_kerusakan") = txt_jenis_kerusakan.Text
            .EndEdit()
            ta_jenis_kerusakan.Update(Db_sistempakarDataSet)
            Call kosongkan()
            Call kd_otomatis()
        End With
    End Sub

    Private Sub dgv_jenis_kerusakan_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_jenis_kerusakan.CellClick
        With bs_jenis_kerusakan
            If .Count > 0 Then
                txt_kd_jenis_kerusakan.Text = .Current("kd_kerusakan")
                txt_jenis_kerusakan.Text = .Current("jenis_kerusakan")

                cmd_simpan.Enabled = False
                txt_kd_jenis_kerusakan.Enabled = False
                cmd_perbarui.Enabled = True
                cmd_hapus.Enabled = True
            End If
        End With
    End Sub

    Private Sub cmd_perbarui_Click(sender As Object, e As EventArgs) Handles cmd_perbarui.Click
        With bs_jenis_kerusakan
            .Current("jenis_kerusakan") = txt_jenis_kerusakan.Text
            .EndEdit()
            ta_jenis_kerusakan.Update(Db_sistempakarDataSet)
            kosongkan()
        End With
    End Sub

    Private Sub cmd_hapus_Click(sender As Object, e As EventArgs) Handles cmd_hapus.Click
        With bs_jenis_kerusakan
            If .Count > 0 Then
                If MsgBox("Yakin Anda akan menghapus data ini ?", vbQuestion + vbYesNo, "Konfirmasi") = vbYes Then
                    bs_jenis_kerusakan.RemoveCurrent()
                    bs_jenis_kerusakan.EndEdit()
                    ta_jenis_kerusakan.Update(Db_sistempakarDataSet)
                    kosongkan()
                End If
            Else
                MsgBox("Maaf data masih kosong !", vbExclamation, "Perhatian")
            End If
        End With
    End Sub

    Private Sub cmd_keluar_Click(sender As Object, e As EventArgs) Handles cmd_keluar.Click
        keluar(Me)
    End Sub
End Class