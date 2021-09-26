Public Class Form1
    Private Sub Honda_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Combox1.SelectedIndexChanged

    End Sub

    Private Sub ProcesosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProcesosToolStripMenuItem.Click

    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub LimpiarEntradaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LimpiarEntradaToolStripMenuItem.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
    End Sub

    Private Sub LimpiarVectorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LimpiarVectorToolStripMenuItem.Click
        Combox1.Text = ""
        ListBox1.Text = ""
    End Sub

    Private Sub ProcesosToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ProcesosToolStripMenuItem1.Click
        ListBox1.Items.Add(TextBox2.Text)
        ListBox1.Items.Add(Combox1.Text)
        ListBox1.Items.Add(TextBox6.Text)
        ListBox1.Items.Add(TextBox7.Text)
    End Sub

    Private Sub TextBox7_TextChanged(sender As Object, e As EventArgs) Handles TextBox7.TextChanged
        If Combox1.Text Then
            TextBox7.Text = Val(TextBox6.Text * 250)
        End If
        If Combox1.Text Then
            TextBox7.Text = Val(TextBox6.Text * 450)
        End If
        If Combox1.Text Then
            TextBox7.Text = Val(TextBox6.Text * 325)
        End If
        If Combox1.Text Then
            TextBox7.Text = Val(TextBox6.Text * 300)
        End If
    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles TextBox5.TextChanged

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged



        If TextBox3.Text >= 100 Then
            TextBox5.Text = Val(TextBox7.Text) - Val(TextBox7.Text * 0.05)
        End If

        If TextBox4.Text >= 100 Then
            TextBox5.Text = Val(TextBox7.Text) + Val(TextBox7.Text * 0.025)
        End If

    End Sub
End Class
