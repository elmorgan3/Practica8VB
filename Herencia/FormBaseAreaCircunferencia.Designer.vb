<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormBaseAreaCircunferencia
    Inherits Herencia.FormBaseArea

    'Form invalida a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.Text = "Radio"
        '
        'Label1
        '
        Me.Label1.Size = New System.Drawing.Size(419, 23)
        Me.Label1.Text = "Longitud de circunferencia"
        '
        'LabelHora
        '
        Me.LabelHora.Text = "08:20:33"
        '
        'ButtonEjecutar
        '
        '
        'FormBaseAreaCircunferencia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(419, 268)
        Me.Name = "FormBaseAreaCircunferencia"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

End Class
