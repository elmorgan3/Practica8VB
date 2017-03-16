Public Class FormBaseArea

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles ButtonCerrar.Click
        'Hago cierro el formular con el boton de cerrar
        Me.Close()

    End Sub

    Private Sub ButtonReiniciar_Click(sender As Object, e As EventArgs) Handles ButtonReiniciar.Click
        'Pongo los textsbox vacios
        TextBox1.Text = ""
        TextBoxResultado.Text = ""
    End Sub

    
End Class
