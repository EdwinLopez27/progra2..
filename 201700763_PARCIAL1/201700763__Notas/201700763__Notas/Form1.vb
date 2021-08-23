Public Class Form1
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            For Each ctrl As Control In Controls
                If TypeOf ctrl Is TextBox Then
                    CType(ctrl, TextBox).Enabled = True
                    mat.Enabled = False
                    mat.Text = "EQV"
                    mat.Enabled = True
                End If
            Next
        End If
    End Sub
    Private Sub Salir_Click(sender As Object, e As EventArgs) Handles Salir.Click
        If MsgBox("¿Desea salir de la aplicación?", vbQuestion + vbYesNo, "Pregunta") = vbYes Then
            End
        End If
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub limpiar_Click(sender As Object, e As EventArgs) Handles limpiar.Click
        nom.Text = ""
        ing.Text = ""
        fra.Text = ""
        len.Text = ""
        cis.Text = ""
        cn.Text = ""
        com.Text = ""
        ps.Text = ""
        filo.Text = ""
        mat.Text = ""
        fi.Text = ""

        CheckBox1.Checked = False
        CheckBox2.Checked = False
        CheckBox3.Checked = False
        CheckBox4.Checked = False
        CheckBox5.Checked = False
        CheckBox6.Checked = False
        CheckBox7.Checked = False
        CheckBox8.Checked = False
        CheckBox9.Checked = False
        CheckBox10.Checked = False
    End Sub

    Private Sub Calcular_Click(sender As Object, e As EventArgs) Handles Calcular.Click


        promedio.Text = (Val(nom.Text) + Val(ing.Text) + Val(fra.Text) + Val(len.Text) + Val(cis.Text) + Val(cn.Text) + Val(com.Text) + Val(ps.Text) + Val(filo.Text) + Val(mat.Text) + Val(fi.Text)) / 10

        If promedio.Text < 61 Or promedio.Text > 70 Then
            TextBox1.Text = ("Bajo rendimiento" + promedio.ToString)
        End If

        If promedio.Text < 71 Or promedio.Text > 80 Then
            TextBox1.Text = ("Buen rendimiento" + promedio.ToString)
        End If

        If promedio.Text < 81 Or promedio.Text > 90 Then
            TextBox1.Text = ("Muy buen rendimiento" + promedio.ToString)
        End If

        If promedio.Text < 91 Or promedio.Text > 100 Then
            Form2.Show()
            Me.Close()
            TextBox1.Text = ("Excelente rendimiento" + promedio.ToString)
        End If



    End Sub


    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked Then
            For Each ctrl As Control In Controls
                If TypeOf ctrl Is TextBox Then
                    CType(ctrl, TextBox).Enabled = True
                    ing.Enabled = False
                    ing.Text = "EQV"
                    ing.Enabled = True
                End If
            Next
        End If
    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged
        If CheckBox3.Checked Then
            For Each ctrl As Control In Controls
                If TypeOf ctrl Is TextBox Then
                    CType(ctrl, TextBox).Enabled = True
                    fra.Enabled = False
                    fra.Text = "EQV"
                    fra.Enabled = True
                End If
            Next
        End If



    End Sub

    Private Sub CheckBox4_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox4.CheckedChanged
        If CheckBox4.Checked Then
            For Each ctrl As Control In Controls
                If TypeOf ctrl Is TextBox Then
                    CType(ctrl, TextBox).Enabled = True
                    fi.Enabled = False
                    fi.Text = "EQV"
                    fi.Enabled = True
                End If
            Next
        End If
    End Sub

    Private Sub CheckBox5_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox5.CheckedChanged
        If CheckBox5.Checked Then
            For Each ctrl As Control In Controls
                If TypeOf ctrl Is TextBox Then
                    CType(ctrl, TextBox).Enabled = True
                    len.Enabled = False
                    len.Text = "EQV"
                    len.Enabled = True
                End If
            Next
        End If
    End Sub

    Private Sub CheckBox6_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox6.CheckedChanged
        If CheckBox6.Checked Then
            For Each ctrl As Control In Controls
                If TypeOf ctrl Is TextBox Then
                    CType(ctrl, TextBox).Enabled = True
                    cn.Enabled = False
                    cn.Text = "EQV"
                    cn.Enabled = True
                End If
            Next
        End If
    End Sub

    Private Sub CheckBox7_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox7.CheckedChanged
        If CheckBox7.Checked Then
            For Each ctrl As Control In Controls
                If TypeOf ctrl Is TextBox Then
                    CType(ctrl, TextBox).Enabled = True
                    cis.Enabled = False
                    cis.Text = "EQV"
                    cis.Enabled = True
                End If
            Next
        End If
    End Sub

    Private Sub CheckBox8_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox8.CheckedChanged
        If CheckBox8.Checked Then
            For Each ctrl As Control In Controls
                If TypeOf ctrl Is TextBox Then
                    CType(ctrl, TextBox).Enabled = True
                    com.Enabled = False
                    com.Text = "EQV"
                    com.Enabled = True
                End If
            Next
        End If
    End Sub

    Private Sub CheckBox9_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox9.CheckedChanged
        If CheckBox9.Checked Then
            For Each ctrl As Control In Controls
                If TypeOf ctrl Is TextBox Then
                    CType(ctrl, TextBox).Enabled = True
                    ps.Enabled = False
                    ps.Text = "EQV"
                    ps.Enabled = True
                End If
            Next
        End If
    End Sub

    Private Sub CheckBox10_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox10.CheckedChanged
        If CheckBox10.Checked Then
            For Each ctrl As Control In Controls
                If TypeOf ctrl Is TextBox Then
                    CType(ctrl, TextBox).Enabled = True
                    filo.Enabled = False
                    filo.Text = "EQV"
                    filo.Enabled = True
                End If
            Next
        End If
    End Sub
End Class
