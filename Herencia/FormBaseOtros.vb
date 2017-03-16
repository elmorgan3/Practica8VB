Public Class FormBaseOtros
    Private Sub ButtonCerrar_Click(sender As Object, e As EventArgs) Handles ButtonCerrar.Click
        Me.Close()
    End Sub

    Private Sub ButtonReiniciar_Click(sender As Object, e As EventArgs) Handles ButtonReiniciar.Click
        TextBoxNumero.Text = ""
        TextBoxTexto.Text = ""

    End Sub
End Class
