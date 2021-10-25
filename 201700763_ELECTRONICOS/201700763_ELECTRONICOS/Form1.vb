Public Class Form1
    Private Sub SALIRToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SALIRToolStripMenuItem.Click
        If MsgBox("¿Desea salir de la aplicación?", vbQuestion + vbYesNo, "Pregunta") = vbYes Then
            End
        End If
    End Sub

    Private Sub LIMPIARENTRADAToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LIMPIARENTRADAToolStripMenuItem.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
        TextBox7.Text = ""
        TextBox8.Text = ""
        TextBox9.Text = ""
        TextBox10.Text = ""
        TextBox11.Text = ""

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.DataGridView1.Rows.Add(TextBox1.Text, TextBox2.Text, TextBox3.Text, TextBox4.Text, TextBox5.Text, TextBox6.Text, TextBox7.Text, TextBox8.Text)
    End Sub

    Private Sub LIMPIARMATRIZToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LIMPIARMATRIZToolStripMenuItem.Click
        Column1.Name = ""
    End Sub

    Private Sub OPERARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OPERARToolStripMenuItem.Click
        TextBox9.Text = Val(TextBox6.Text * TextBox3.Text)

        TextBox10.Text = Val(TextBox5.Text * (TextBox3.Text * 0.75))

        TextBox11.Text = Val(TextBox9.Text) + Val(TextBox10.Text)

        Me.DataGridView1.Rows.Add(TextBox9.Text, TextBox10.Text, TextBox11.Text)
    End Sub

    Private Sub ESTADISTICASToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ESTADISTICASToolStripMenuItem.Click
        Me.Visible = False
        Form2.Visible = True
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub LIMPIARESTADISTICAToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LIMPIARESTADISTICAToolStripMenuItem.Click
        Me.Visible = False
        Form2.Visible = True
    End Sub
End Class
