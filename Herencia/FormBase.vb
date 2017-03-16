Public Class FormBase
    Protected contador As Integer = 0
    'este es el formulario es la base principal de todos
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'Hago el timer 
        Dim tiempo As Date = Format(Now(), "hh:mm:ss")
        'Esto son dos maneras de hacer que te den solo la hora:minutos y segundos
        Format(Now(), "hh:mm:ss")
        Date.Now.ToLongTimeString()

        LabelHora.Text = tiempo
    End Sub

    Private Sub ButtonEjecutar_Click(sender As Object, e As EventArgs) Handles ButtonEjecutar.Click
        'Hago un contador para saber cuantas veces se ha ejecutado este formulario, que se heredara en todos los formularios
        contador = contador + 1
    End Sub

    Private Sub Form1base_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.Closing
        'Cuando se cierra el formulario, digo cuantas veces de ha ejecutado
        MsgBox("Este formulario se ha ejecutado " + CStr(contador))
    End Sub
End Class