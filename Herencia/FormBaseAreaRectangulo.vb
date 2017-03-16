Public Class FormBaseAreaRectangulo

    Private Sub ButtonReiniciar_Click(sender As Object, e As EventArgs) Handles ButtonReiniciar.Click
        'Reinicio el textbox
        TextBoxAltura.Text = ""
    End Sub

    Private Sub ButtonEjecutar_Click(sender As Object, e As EventArgs) Handles ButtonEjecutar.Click
        'Hago el calculo de la operacion
        Try
            TextBoxResultado.Text = CDbl(TextBox1.Text) * CDbl(TextBoxAltura.Text)
        Catch ex As Exception
            MsgBox("Has introducido algun valor incorrecto")
        End Try
    End Sub
End Class
