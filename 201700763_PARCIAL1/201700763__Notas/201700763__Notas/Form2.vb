Public Class Form2
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)
        Dim form As New Form1
        form.MdiParent = Me
        form.Show()
    End Sub
End Class