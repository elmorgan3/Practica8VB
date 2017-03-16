<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormBaseCadenaInvertir
    Inherits Herencia.FormBaseCadena

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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBoxTextoInvertido = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'ButtonReiniciar
        '
        '
        'Label1
        '
        Me.Label1.Text = "Invertir cadena"
        '
        'LabelHora
        '
        Me.LabelHora.Text = "1:41:06"
        '
        'ButtonEjecutar
        '
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(153, 139)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(101, 17)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Texto invertido"
        '
        'TextBoxTextoInvertido
        '
        Me.TextBoxTextoInvertido.Location = New System.Drawing.Point(156, 159)
        Me.TextBoxTextoInvertido.Name = "TextBoxTextoInvertido"
        Me.TextBoxTextoInvertido.Size = New System.Drawing.Size(207, 22)
        Me.TextBoxTextoInvertido.TabIndex = 11
        '
        'FormBaseCadenaInvertir
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.ClientSize = New System.Drawing.Size(532, 295)
        Me.Controls.Add(Me.TextBoxTextoInvertido)
        Me.Controls.Add(Me.Label3)
        Me.Name = "FormBaseCadenaInvertir"
        Me.Controls.SetChildIndex(Me.ButtonReiniciar, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.LabelHora, 0)
        Me.Controls.SetChildIndex(Me.ButtonEjecutar, 0)
        Me.Controls.SetChildIndex(Me.Label3, 0)
        Me.Controls.SetChildIndex(Me.TextBoxTextoInvertido, 0)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents TextBoxTextoInvertido As TextBox
End Class
