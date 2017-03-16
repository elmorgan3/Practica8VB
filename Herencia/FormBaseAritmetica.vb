Public Class FormBaseAritmetica


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ButtonReiniciar.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBoxResultado.Text = ""
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles ButtonCerrar.Click
        Me.Close()
    End Sub
End Class
