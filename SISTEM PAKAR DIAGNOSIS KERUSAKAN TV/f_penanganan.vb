Public Class f_penanganan

    Private Sub f_penanganan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Db_sistempakarDataSet.tb_solusi' table. You can move, or remove it, as needed.
        Me.ta_solusi.Fill(Me.Db_sistempakarDataSet.tb_solusi)
        'TODO: This line of code loads data into the 'Db_sistempakarDataSet.tb_temp' table. You can move, or remove it, as needed.
        Me.ta_temp.Fill(Me.Db_sistempakarDataSet.tb_temp)

    End Sub

    Private Sub cmd_keluar_Click(sender As Object, e As EventArgs) Handles cmd_keluar.Click
        'f_riwayat.txt_riwayat.Text = Chr(13) & f_riwayat.txt_riwayat.Text & txt_penanganan.Text & Chr(13) & CDate(Now).ToString
        For i = 1 To bs_temp.Count
            bs_temp.MoveFirst()
            If bs_temp.Count > 0 Then
                bs_temp.RemoveCurrent()
                bs_temp.EndEdit()
                ta_temp.Update(Db_sistempakarDataSet)
            End If
        Next
        Me.Close()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub txt_penanganan_TextChanged(sender As Object, e As EventArgs) Handles txt_penanganan.TextChanged

    End Sub
End Class