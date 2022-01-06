Public Class f_diagnosis

    Private Sub f_diagnosis_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Db_sistempakarDataSet.tb_solusi' table. You can move, or remove it, as needed.
        Me.ta_solusi.Fill(Me.Db_sistempakarDataSet.tb_solusi)
        'TODO: This line of code loads data into the 'Db_sistempakarDataSet.tb_temp' table. You can move, or remove it, as needed.
        Me.ta_temp.Fill(Me.Db_sistempakarDataSet.tb_temp)
        'TODO: This line of code loads data into the 'Db_sistempakarDataSet.tb_pengetahuan' table. You can move, or remove it, as needed.
        Me.ta_pengetahuan.Fill(Me.Db_sistempakarDataSet.tb_pengetahuan)

        bs_pengetahuan.RemoveFilter()
        Call Form_Load()

    End Sub


    Private Sub Form_Load()
        On Error Resume Next

        bs_temp.RemoveFilter()
        For i = 1 To bs_temp.Count
            bs_temp.MoveFirst()
            If bs_temp.Count > 0 Then
                bs_temp.RemoveCurrent()
                bs_temp.EndEdit()
                ta_temp.Update(Db_sistempakarDataSet)
            End If
        Next


        With bs_pengetahuan
            .MoveFirst()
            If f_pilih_kerusakan.cb_kerusakan.SelectedValue = "R1" Then
                ta_pengetahuan.FillBykd(Db_sistempakarDataSet.tb_pengetahuan, "T1")
                lbl_diagnosis.Text = bs_pengetahuan.Current("pertanyaan")
            ElseIf f_pilih_kerusakan.cb_kerusakan.SelectedValue = "R2" Then
                ta_pengetahuan.FillBykd(Db_sistempakarDataSet.tb_pengetahuan, "T10")
                lbl_diagnosis.Text = bs_pengetahuan.Current("pertanyaan")
            ElseIf f_pilih_kerusakan.cb_kerusakan.SelectedValue = "R3" Then
                ta_pengetahuan.FillBykd(Db_sistempakarDataSet.tb_pengetahuan, "T21")
                lbl_diagnosis.Text = bs_pengetahuan.Current("pertanyaan")
            ElseIf f_pilih_kerusakan.cb_kerusakan.SelectedValue = "R4" Then
                ta_pengetahuan.FillBykd(Db_sistempakarDataSet.tb_pengetahuan, "T38")
                lbl_diagnosis.Text = bs_pengetahuan.Current("pertanyaan")
            ElseIf f_pilih_kerusakan.cb_kerusakan.SelectedValue = "R5" Then
                ta_pengetahuan.FillBykd(Db_sistempakarDataSet.tb_pengetahuan, "T33")
                lbl_diagnosis.Text = bs_pengetahuan.Current("pertanyaan")
            ElseIf f_pilih_kerusakan.cb_kerusakan.SelectedValue = "R6" Then
                ta_pengetahuan.FillBykd(Db_sistempakarDataSet.tb_pengetahuan, "T52")
                lbl_diagnosis.Text = bs_pengetahuan.Current("pertanyaan")
            End If
        End With

    End Sub

    Private Sub cmd_ya_Click(sender As Object, e As EventArgs) Handles cmd_ya.Click
        On Error Resume Next

        With bs_temp
            .AddNew()
            .Current("kd_temp") = bs_pengetahuan.Current("kd_pengetahuan").ToString
            .Current("fakta") = bs_pengetahuan.Current("fakta_ya").ToString
            .EndEdit()
            ta_temp.Update(Db_sistempakarDataSet)
        End With

        Dim jwb As String
        jwb = bs_pengetahuan.Current("ya")
        If Microsoft.VisualBasic.Left(jwb, 1) = "T" Then
            bs_pengetahuan.MoveFirst()
            ta_pengetahuan.FillBykd(Db_sistempakarDataSet.tb_pengetahuan, jwb)
            lbl_diagnosis.Text = ""
            lbl_diagnosis.Text = lbl_diagnosis.Text & bs_pengetahuan.Current("pertanyaan")
        Else
            bs_solusi.MoveFirst()
            ta_solusi.FillBykd(Db_sistempakarDataSet.tb_solusi, jwb)
            f_hasil_diagnosis.lbl_hasil.Text = f_hasil_diagnosis.lbl_hasil.Text & bs_solusi.Current("solusi").ToString
            f_hasil_diagnosis.ShowDialog()
        End If
    End Sub

    Private Sub cmd_tidak_Click(sender As Object, e As EventArgs) Handles cmd_tidak.Click
        On Error Resume Next

        With bs_temp
            .AddNew()
            .Current("kd_temp") = bs_pengetahuan.Current("kd_pengetahuan").ToString
            .Current("fakta") = bs_pengetahuan.Current("fakta_tidak").ToString
            .EndEdit()
            ta_temp.Update(Db_sistempakarDataSet)
        End With

        Dim jwb As String
        jwb = bs_pengetahuan.Current("tidak")
        If Microsoft.VisualBasic.Left(jwb, 1) = "T" Then
            bs_pengetahuan.MoveFirst()
            ta_pengetahuan.FillBykd(Db_sistempakarDataSet.tb_pengetahuan, jwb)
            lbl_diagnosis.Text = ""
            lbl_diagnosis.Text = lbl_diagnosis.Text & bs_pengetahuan.Current("pertanyaan")
        Else
            bs_solusi.MoveFirst()
            ta_solusi.FillBykd(Db_sistempakarDataSet.tb_solusi, jwb)
            f_hasil_diagnosis.lbl_hasil.Text = f_hasil_diagnosis.lbl_hasil.Text & bs_solusi.Current("solusi").ToString
            f_hasil_diagnosis.ShowDialog()
        End If
    End Sub

    Private Sub cmd_selesai_Click(sender As Object, e As EventArgs) Handles cmd_selesai.Click
        For i = 1 To bs_temp.Count
            bs_temp.MoveFirst()
            If bs_temp.Count > 0 Then
                bs_temp.RemoveCurrent()
                bs_temp.EndEdit()
                'ta_temp.Update(Db_sistempakarDataSet)
            End If
        Next
        Me.Close()
    End Sub
End Class