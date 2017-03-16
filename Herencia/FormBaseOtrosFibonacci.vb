Public Class FormBaseOtrosFibonacci

    Private Sub ButtonEjecutar_Click(sender As Object, e As EventArgs) Handles ButtonEjecutar.Click
        Dim primero As Integer = 0
        Dim segundo As Integer = 1
        Dim suma As Integer
        Dim cadena As String

        cadena = CStr(primero) + " / " + CStr(segundo)
        ListBoxResultadoFibo.Items.Add(primero + segundo)
        For i = 1 To TextBoxNumero.Text - 2

            suma = primero + segundo
            cadena = cadena + " / " + CStr(suma)
            primero = segundo
            segundo = suma
            ListBoxResultadoFibo.Items.Add(suma)
        Next

        TextBoxTexto.Text = cadena
    End Sub

    Private Sub ButtonReiniciar_Click(sender As Object, e As EventArgs) Handles ButtonReiniciar.Click
        ListBoxResultadoFibo.Items.Clear()
    End Sub
End Class
