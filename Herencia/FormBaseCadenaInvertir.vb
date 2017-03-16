Public Class FormBaseCadenaInvertir
    Private Sub ButtonReiniciar_Click(sender As Object, e As EventArgs) Handles ButtonReiniciar.Click
        TextBoxTextoInvertido.Text = ""
    End Sub

    Private Sub ButtonEjecutar_Click(sender As Object, e As EventArgs) Handles ButtonEjecutar.Click
        TextBoxTextoInvertido.Text = StrReverse(TextBoxTexto.Text)
    End Sub
End Class
