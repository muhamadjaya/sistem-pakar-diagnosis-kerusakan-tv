Public Class f_pengetahuan


    Private Sub f_pengetahuan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Db_sistempakarDataSet.tb_pengetahuan' table. You can move, or remove it, as needed.
        Me.ta_pengetahuan.Fill(Me.Db_sistempakarDataSet.tb_pengetahuan)
        'TODO: This line of code loads data into the 'Db_sistempakarDataSet.tb_solusi' table. You can move, or remove it, as needed.
        Me.ta_solusi.Fill(Me.Db_sistempakarDataSet.tb_solusi)
        'TODO: This line of code loads data into the 'Db_sistempakarDataSet.tb_jenis_kerusakan' table. You can move, or remove it, as needed.
        Me.ta_jenis_kerusakan.Fill(Me.Db_sistempakarDataSet.tb_jenis_kerusakan)
        'TODO: This line of code loads data into the 'Db_sistempakarDataSet.tb_pengetahuan' table. You can move, or remove it, as needed.
        Me.ta_pengetahuan.Fill(Me.Db_sistempakarDataSet.tb_pengetahuan)

        Call kosongkan()
        Call kd_otomatis()
    End Sub

    Private Sub kd_otomatis()
        txt_kd_pengetahuan.Text = "T" & Format(bs_pengetahuan.Count + 1, "0")
    End Sub

    Private Sub kosongkan()
        cb_kerusakan.SelectedIndex = 0
        txt_kd_kerusakan.Clear()
        txt_pertanyaan.Clear()
        txt_fakta_ya.Clear()
        txt_fakta_tidak.Clear()
        'cb_jika_ya.SelectedIndex = 0
        'cb_jika_tidak.SelectedIndex = 0
        kd_otomatis()
        cb_kerusakan.Focus()
    End Sub

    Private Sub cmd_tambah_Click(sender As Object, e As EventArgs) Handles cmd_tambah.Click
        Call kosongkan()
        gb_pengetahuan.Enabled = True
        txt_kd_kerusakan.Enabled = False
        cmd_simpan.Enabled = True
        cmd_perbarui.Enabled = False
        cmd_hapus.Enabled = False
        cmd_tambah.Enabled = False
    End Sub

    Private Sub cmd_simpan_Click(sender As Object, e As EventArgs) Handles cmd_simpan.Click
        With bs_pengetahuan
            .AddNew()
            .Current("kd_pengetahuan") = txt_kd_pengetahuan.Text
            .Current("pertanyaan") = txt_pertanyaan.Text
            .Current("fakta_ya") = txt_fakta_ya.Text
            .Current("fakta_tidak") = txt_fakta_tidak.Text
            .Current("ya") = cb_jika_ya.Text
            .Current("tidak") = cb_jika_tidak.Text
            .Current("kd_kerusakan") = cb_kerusakan.Text
            .EndEdit()
            ta_pengetahuan.Update(Db_sistempakarDataSet)
            Call kosongkan()
            Call kd_otomatis()
        End With
    End Sub

    Private Sub dgv_pengetahuan_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_pengetahuan.CellClick
        With bs_pengetahuan
            If .Count > 0 Then
                txt_kd_pengetahuan.Text = .Current("kd_pengetahuan")
                txt_pertanyaan.Text = .Current("pertanyaan")
                txt_fakta_ya.Text = .Current("fakta_ya")
                txt_fakta_tidak.Text = .Current("fakta_tidak")
                cb_jika_ya.SelectedItem = .Current("ya")
                cb_jika_tidak.SelectedItem = .Current("tidak")
                cb_kerusakan.SelectedItem = .Current("kd_kerusakan")

                cmd_simpan.Enabled = False
                cmd_perbarui.Enabled = True
                cmd_hapus.Enabled = True
                txt_kd_pengetahuan.Enabled = False
            End If
        End With
    End Sub

    Private Sub cmd_perbarui_Click(sender As Object, e As EventArgs) Handles cmd_perbarui.Click
        With bs_pengetahuan
            .Current("pertanyaan") = txt_pertanyaan.Text
            .Current("fakta_ya") = txt_fakta_ya.Text
            .Current("fakta_tidak") = txt_fakta_tidak.Text
            .Current("ya") = cb_jika_ya.Text
            .Current("tidak") = cb_jika_tidak.Text
            .Current("kd_kerusakan") = cb_kerusakan.Text
            .EndEdit()
            ta_pengetahuan.Update(Db_sistempakarDataSet)
            Call kosongkan()
        End With
    End Sub

    Private Sub cmd_hapus_Click(sender As Object, e As EventArgs) Handles cmd_hapus.Click
        If bs_pengetahuan.Count > 0 Then
            If MsgBox("Yakin Anda akan menghapus data ini ?", vbQuestion + vbYesNo, "Konfirmasi") = vbYes Then
                bs_pengetahuan.RemoveCurrent()
                bs_pengetahuan.EndEdit()
                ta_pengetahuan.Update(Db_sistempakarDataSet)
                kosongkan()
            End If
        Else
            MsgBox("Maaf data masih kosong !", vbExclamation, "Perhatian")
        End If
    End Sub

    Private Sub cmd_keluar_Click(sender As Object, e As EventArgs) Handles cmd_keluar.Click
        keluar(Me)
    End Sub

    Private Sub cmd_input_jenis_kerusakan_Click(sender As Object, e As EventArgs) Handles cmd_input_jenis_kerusakan.Click
        f_jenis_kerusakan.ShowDialog()
    End Sub

    Private Sub cmd_input_solusi_Click(sender As Object, e As EventArgs) Handles cmd_input_solusi.Click
        f_solusi.ShowDialog()
    End Sub

    Private Sub txt_cari_pengetahuan_TextChanged(sender As Object, e As EventArgs) Handles txt_cari_pengetahuan.TextChanged
        If txt_cari_pengetahuan.Text <> "" Then
            If cb_berdasarkan_pengetahuan.Text = "KODE PENGETAHUAN" Then
                ta_pengetahuan.FillBycarikd_pengetahuan(Db_sistempakarDataSet.tb_pengetahuan, "%" & txt_cari_pengetahuan.Text & "%")
            ElseIf cb_berdasarkan_pengetahuan.Text = "PERTANYAAN" Then
                ta_pengetahuan.FillBycari_pertanyaan(Db_sistempakarDataSet.tb_pengetahuan, "%" & txt_cari_pengetahuan.Text & "%")
            ElseIf cb_berdasarkan_pengetahuan.Text = "KODE KERUSAKAN" Then
                ta_pengetahuan.FillBycarikd_kerusakan(Db_sistempakarDataSet.tb_pengetahuan, "%" & txt_cari_pengetahuan.Text & "%")
            End If
        End If
    End Sub

    Private Sub cmd_refresh_Click(sender As Object, e As EventArgs) Handles cmd_refresh.Click
        ta_pengetahuan.Fill(Db_sistempakarDataSet.tb_pengetahuan)
    End Sub

    Private Sub txt_cari_jenis_kerusakan_TextChanged(sender As Object, e As EventArgs) Handles txt_cari_jenis_kerusakan.TextChanged
        If txt_cari_jenis_kerusakan.Text <> "" Then
            If cb_berdasarkan_jenis_kerusakan.Text = "KODE KERUSAKAN" Then
                ta_jenis_kerusakan.FillBycarikd_kerusakan(Db_sistempakarDataSet.tb_jenis_kerusakan, "%" & txt_cari_jenis_kerusakan.Text & "%")
            ElseIf cb_berdasarkan_jenis_kerusakan.Text = "JENIS KERUSAKAN" Then
                ta_jenis_kerusakan.FillBycari_jeniskerusakan(Db_sistempakarDataSet.tb_jenis_kerusakan, "%" & txt_cari_jenis_kerusakan.Text & "%")
            End If
        End If
    End Sub

    Private Sub cmd_refresh1_Click(sender As Object, e As EventArgs) Handles cmd_refresh1.Click
        ta_jenis_kerusakan.Fill(Db_sistempakarDataSet.tb_jenis_kerusakan)
    End Sub

    Private Sub txt_cari_solusi_TextChanged(sender As Object, e As EventArgs) Handles txt_cari_solusi.TextChanged
        If txt_cari_solusi.Text <> "" Then
            If cb_berdasarkan_solusi.Text = "KODE SOLUSI" Then
                ta_solusi.FillBycarikd_solusi(Db_sistempakarDataSet.tb_solusi, "%" & txt_cari_solusi.Text & "%")
            ElseIf cb_berdasarkan_solusi.Text = "SOLUSI" Then
                ta_solusi.FillBycarisolusi(Db_sistempakarDataSet.tb_solusi, "%" & txt_cari_solusi.Text & "%")
            End If
        End If
    End Sub

    Private Sub cmd_refresh2_Click(sender As Object, e As EventArgs) Handles cmd_refresh2.Click
        ta_solusi.Fill(Db_sistempakarDataSet.tb_solusi)
    End Sub
End Class