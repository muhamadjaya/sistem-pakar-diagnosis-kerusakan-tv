Public Class f_pilih_kerusakan


    Private Sub cmd_proses_Click(sender As Object, e As EventArgs) Handles cmd_proses.Click
        f_diagnosis.ShowDialog()
    End Sub

    Private Sub f_pilih_kerusakan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Db_sistempakarDataSet.tb_pengetahuan' table. You can move, or remove it, as needed.
        Me.ta_pengetahuan.Fill(Me.Db_sistempakarDataSet.tb_pengetahuan)
        'TODO: This line of code loads data into the 'Db_sistempakarDataSet.tb_jenis_kerusakan' table. You can move, or remove it, as needed.
        Me.ta_jenis_kerusakan.Fill(Me.Db_sistempakarDataSet.tb_jenis_kerusakan)

    End Sub

End Class