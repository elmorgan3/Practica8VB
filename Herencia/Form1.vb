Public Class Form1
    'En este formulario sirve para acceder a todos los posibles formularios
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ButtonTriangulo.Click
        FormBaseAreaTriangulo.ShowDialog()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles ButtonCirculo.Click
        FormBaseAreaCirculo.ShowDialog()

    End Sub

    Private Sub ButtonCircunferencia_Click(sender As Object, e As EventArgs) Handles ButtonCircunferencia.Click
        FormBaseAreaCircunferencia.ShowDialog()

    End Sub

    Private Sub ButtonRectangulo_Click(sender As Object, e As EventArgs) Handles ButtonRectangulo.Click
        FormBaseAreaRectangulo.ShowDialog()

    End Sub

    Private Sub ButtonSuma_Click(sender As Object, e As EventArgs) Handles ButtonSuma.Click
        FormBaseAritmeticaSuma.ShowDialog()
    End Sub

    Private Sub ButtonResta_Click(sender As Object, e As EventArgs) Handles ButtonResta.Click
        FormBaseAritmeticaResta.ShowDialog()
    End Sub

    Private Sub ButtonDivision_Click(sender As Object, e As EventArgs) Handles ButtonDivision.Click
        FormBaseAritmeticaDivision.ShowDialog()
    End Sub

    Private Sub ButtonMultiplicacion_Click(sender As Object, e As EventArgs) Handles ButtonMultiplicacion.Click
        FormBaseAritmeticaMultiplicacion.ShowDialog()
    End Sub

    Private Sub ButtonInvertir_Click(sender As Object, e As EventArgs) Handles ButtonInvertir.Click
        FormBaseCadenaInvertir.ShowDialog()
    End Sub

    Private Sub ButtonContarVocales_Click(sender As Object, e As EventArgs) Handles ButtonContarVocales.Click
        FormBaseCadenaContadorVocales.ShowDialog()
    End Sub

    Private Sub ButtonContador_Click(sender As Object, e As EventArgs) Handles ButtonContador.Click
        FormBaseCadenaContarCaracteres.ShowDialog()
    End Sub

    Private Sub ButtonEscribirNumero_Click(sender As Object, e As EventArgs) Handles ButtonEscribirNumero.Click
        FormBaseOtrosEscribirNumero.ShowDialog()
    End Sub

    Private Sub ButtonFibonacci_Click(sender As Object, e As EventArgs) Handles ButtonFibonacci.Click
        FormBaseOtrosFibonacci.ShowDialog()
    End Sub

    Private Sub ButtonMultiplicar_Click(sender As Object, e As EventArgs) Handles ButtonMultiplicar.Click
        FormBaseOtrosTablaMulti.ShowDialog()
    End Sub
End Class
