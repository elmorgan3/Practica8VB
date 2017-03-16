Public Class FormBaseAreaCirculo

    Private Sub ButtonEjecutar_Click(sender As Object, e As EventArgs) Handles ButtonEjecutar.Click
        'Hago el calculo de la operacion
        Try
            TextBoxResultado.Text = Math.PI * CDbl(TextBox1.Text) * CDbl(TextBox1.Text)
        Catch ex As Exception
            MsgBox("Has introducido algun valor incorrecto")
        End Try
    End Sub
End Class
