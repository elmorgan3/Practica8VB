<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormBaseAreaCirculo
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
        'TextBoxResultado
        '
        Me.TextBoxResultado.Location = New System.Drawing.Point(137, 150)
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(137, 76)
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(134, 60)
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.Text = "Radio"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(134, 134)
        '
        'Label1
        '
        Me.Label1.Size = New System.Drawing.Size(374, 23)
        Me.Label1.Text = "Area de circulo"
        '
        'LabelHora
        '
        Me.LabelHora.Location = New System.Drawing.Point(300, 218)
        Me.LabelHora.Text = "09:25:31"
        '
        'FormBaseAreaCirculo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(374, 268)
        Me.Name = "FormBaseAreaCirculo"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

End Class
