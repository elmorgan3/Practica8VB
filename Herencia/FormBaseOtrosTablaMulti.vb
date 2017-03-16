Public Class FormBaseOtrosTablaMulti

    Private Sub ButtonReiniciar_Click(sender As Object, e As EventArgs) Handles ButtonReiniciar.Click
        TextBoxHasta.Text = ""

    End Sub

    Private Sub ButtonEjecutar_Click(sender As Object, e As EventArgs) Handles ButtonEjecutar.Click
        Dim num As Integer
        Dim c As Integer

        For c = 1 To TextBoxHasta.Text
            num = c * CInt(TextBoxNumero.Text)

            TextBoxTexto.Text = TextBoxTexto.Text + " " + CStr(num)
            ListBoxResultadoMultiplicar.Items.Add(num)
        Next
    End Sub
End Class
