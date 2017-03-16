Public Class FormBaseAreaTriangulo
    Dim primeraVez As Boolean
    Private Sub ButtonEjecutar_Click(sender As Object, e As EventArgs) Handles ButtonEjecutar.Click
        Try
            TextBoxResultado.Text = (CDbl(TextBox1.Text) * CDbl(TextBoxAltura.Text)) / 2
        Catch ex As Exception
            MsgBox("Has introducido algun valor incorrecto")
        End Try

        primeraVez = False
    End Sub

    Private Sub ButtonReiniciar_Click(sender As Object, e As EventArgs) Handles ButtonReiniciar.Click
        TextBoxAltura.Text = ""
    End Sub
End Class
