Public Class f_solusi

    Private Sub f_solusi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Db_sistempakarDataSet.tb_solusi' table. You can move, or remove it, as needed.
        Me.ta_solusi.Fill(Me.Db_sistempakarDataSet.tb_solusi)

        Call kosongkan()
        Call kd_otomatis()
    End Sub

    Private Sub kd_otomatis()
        txt_kd_solusi.Text = "S" & Format(bs_solusi.Count + 1, "00")
    End Sub

    Private Sub kosongkan()
        txt_kd_solusi.Clear()
        txt_solusi.Clear()
        kd_otomatis()
    End Sub

    Private Sub cmd_tambah_Click(sender As Object, e As EventArgs) Handles cmd_tambah.Click
        kosongkan()
        gb_solusi.Enabled = True
        'txt_kd_solusi.Enabled = True
        cmd_simpan.Enabled = True
        cmd_perbarui.Enabled = False
        cmd_hapus.Enabled = False
        cmd_tambah.Enabled = False
    End Sub

    Private Sub cmd_simpan_Click(sender As Object, e As EventArgs) Handles cmd_simpan.Click
        With bs_solusi
            .AddNew()
            .Current("kd__solusi") = txt_kd_solusi.Text
            .Current("solusi") = txt_solusi.Text
            .EndEdit()
            ta_solusi.Update(Db_sistempakarDataSet)
            Call kosongkan()
            Call kd_otomatis()
        End With
    End Sub

    Private Sub dgv_solusi_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_solusi.CellClick
        With bs_solusi
            If .Count > 0 Then
                txt_kd_solusi.Text = .Current("kd_solusi")
                txt_solusi.Text = .Current("solusi")

                cmd_simpan.Enabled = False
                txt_kd_solusi.Enabled = False
                cmd_perbarui.Enabled = True
                cmd_hapus.Enabled = True
            End If
        End With
    End Sub

    Private Sub cmd_perbarui_Click(sender As Object, e As EventArgs) Handles cmd_perbarui.Click
        With bs_solusi
            .Current("solusi") = txt_solusi.Text
            .EndEdit()
            ta_solusi.Update(Db_sistempakarDataSet)
            kosongkan()
        End With
    End Sub

    Private Sub cmd_hapus_Click(sender As Object, e As EventArgs) Handles cmd_hapus.Click
        With bs_solusi
            If .Count > 0 Then
                If MsgBox("Yakin Anda akan menghapus data ini ?", vbQuestion + vbYesNo, "Konfirmasi") = vbYes Then
                    bs_solusi.RemoveCurrent()
                    bs_solusi.EndEdit()
                    ta_solusi.Update(Db_sistempakarDataSet)
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