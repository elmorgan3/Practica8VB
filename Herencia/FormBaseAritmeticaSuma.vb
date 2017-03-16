Public Class FormBaseAritmeticaSuma
    Private Sub ButtonEjecutar_Click(sender As Object, e As EventArgs) Handles ButtonEjecutar.Click
        Try
            TextBoxResultado.Text = CDbl(TextBox1.Text) + CDbl(TextBox2.Text)
        Catch ex As Exception
            MsgBox("Has introducido algun valor incorrecto")
        End Try
    End Sub
End Class
