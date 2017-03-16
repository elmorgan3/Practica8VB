Public Class FormBaseCadena
    Private Sub ButtonReiniciar_Click(sender As Object, e As EventArgs) Handles ButtonReiniciar.Click
        TextBoxTexto.Text = ""
    End Sub

    Private Sub ButtonCerrar_Click(sender As Object, e As EventArgs) Handles ButtonCerrar.Click
        Me.Close()
    End Sub
End Class
