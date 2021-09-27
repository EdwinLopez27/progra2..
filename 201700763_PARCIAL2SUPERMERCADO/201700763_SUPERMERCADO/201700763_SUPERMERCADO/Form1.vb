Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub LIMPIARENTRADASToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LIMPIARENTRADASToolStripMenuItem.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""


    End Sub

    Private Sub LIMPIARVECTORESToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LIMPIARVECTORESToolStripMenuItem.Click
        TextBox7.Text = ""
        TextBox8.Text = ""
        TextBox9.Text = ""
        ListBox1.Items.Clear()
        ListBox2.Items.Clear()

    End Sub

    Private Sub PROCESARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PROCESARToolStripMenuItem.Click
        ListBox1.Items.Add(TextBox1.Text)
        ListBox1.Items.Add(TextBox2.Text)
        ListBox1.Items.Add(TextBox3.Text)
        ListBox2.Items.Add(TextBox4.Text)
        ListBox2.Items.Add(TextBox5.Text)
        ListBox2.Items.Add(TextBox6.Text)
        ListBox2.Items.Add(TextBox7.Text)
        ListBox2.Items.Add(TextBox8.Text)

        If TextBox7.Text >= 5 Then
            TextBox8.Text = Val(TextBox5.Text * TextBox7.Text * 0.05)
            TextBox6.Text = Val(TextBox5.Text * TextBox7.Text - TextBox8.Text)
        End If

        If TextBox7.Text < 5 Then
            TextBox8.Text = Val(0)
            TextBox6.Text = Val(TextBox5.Text * TextBox7.Text)
        End If

        If CheckBox2.Checked Then
            TextBox9.Text = Val(TextBox5.Text * TextBox7.Text * 0.08)
            TextBox6.Text = Val(TextBox5.Text * TextBox7.Text) + Val(TextBox8.Text)
        End If

    End Sub

    Private Sub SALIRToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SALIRToolStripMenuItem.Click
        If MsgBox("¿Desea salir del programa?", vbQuestion + vbYesNo, "Pregunta") = vbYes Then
            End
        End If
    End Sub

    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs) Handles TextBox6.TextChanged

    End Sub
End Class
