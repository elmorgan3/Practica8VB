Public Class FormBaseCadenaContarCaracteres
    Private Sub ButtonReiniciar_Click(sender As Object, e As EventArgs) Handles ButtonReiniciar.Click
        TextBoxPrimerCaracter.Text = ""
        TextBoxResultadoCaracter.Text = ""
        TextBoxSegundoCaracter.Text = ""
    End Sub

    Private Sub ButtonEjecutar_Click(sender As Object, e As EventArgs) Handles ButtonEjecutar.Click
        Dim numCaracteres As Integer
        numCaracteres = 0

        For c = 0 To TextBoxTexto.TextLength - 2


            If TextBoxPrimerCaracter.Text = TextBoxTexto.Text(c) And TextBoxSegundoCaracter.Text = TextBoxTexto.Text(c + 1) Then
                numCaracteres = numCaracteres + 1

            End If
        Next

        TextBoxResultadoCaracter.Text = numCaracteres
    End Sub
End Class
