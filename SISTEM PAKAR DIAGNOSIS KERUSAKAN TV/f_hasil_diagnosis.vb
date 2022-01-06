Public Class f_hasil_diagnosis

   
    Private Sub cmd_alasan_Click(sender As Object, e As EventArgs) Handles cmd_alasan.Click
        f_penanganan.txt_penanganan.Text = ""
        With bs_temp
            .MoveFirst()
            For i = 1 To .Count
                If .Count > 0 Then
                    f_penanganan.txt_penanganan.Text = f_penanganan.txt_penanganan.Text & bs_temp.Current("fakta") & vbCrLf
                    .MoveNext()
                End If
            Next

            f_penanganan.txt_penanganan.Text = f_penanganan.txt_penanganan.Text & vbCrLf & vbCrLf & "Maka Hasil Diagnosis : " & vbCrLf & bs_solusi.Current("solusi")
            f_penanganan.ShowDialog()
        End With

    End Sub

    Private Sub f_hasil_diagnosis_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Db_sistempakarDataSet.tb_solusi' table. You can move, or remove it, as needed.
        Me.ta_solusi.Fill(Me.Db_sistempakarDataSet.tb_solusi)
        'TODO: This line of code loads data into the 'Db_sistempakarDataSet.tb_temp' table. You can move, or remove it, as needed.
        Me.ta_temp.Fill(Me.Db_sistempakarDataSet.tb_temp)

    End Sub

    Private Sub cmd_selesai_Click(sender As Object, e As EventArgs) Handles cmd_selesai.Click
        For i = 1 To bs_temp.Count
            bs_temp.MoveFirst()
            If bs_temp.Count > 0 Then
                bs_temp.RemoveCurrent()
                bs_temp.EndEdit()
                ta_temp.Update(Db_sistempakarDataSet)
            End If
        Next
        Me.Close()
        f_diagnosis.Close()
    End Sub
End Class