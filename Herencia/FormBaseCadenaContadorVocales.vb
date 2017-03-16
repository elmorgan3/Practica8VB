Public Class FormBaseCadenaContadorVocales
    Private Sub ButtonEjecutar_Click(sender As Object, e As EventArgs) Handles ButtonEjecutar.Click
        Dim numVocales As Integer
        Dim numConsonantes As Integer

        numVocales = 0
        numConsonantes = 0
        For c = 0 To TextBoxVocales.TextLength - 1


            Select Case TextBoxVocales.Text(c)
                Case "a", "A"
                    numVocales = numVocales + 1
                Case "e", "E"
                    numVocales = numVocales + 1
                Case "i", "I"
                    numVocales = numVocales + 1
                Case "o", "O"
                    numVocales = numVocales + 1
                Case "u", "U"
                    numVocales = numVocales + 1

                Case Else
                    numConsonantes = numConsonantes + 1

            End Select
        Next
        TextBoxVocales.Text = numVocales
        TextBoxConsonante.Text = numConsonantes
    End Sub
End Class
