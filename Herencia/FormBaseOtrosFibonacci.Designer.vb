<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormBaseOtrosFibonacci
    Inherits Herencia.FormBaseOtros

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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ListBoxResultadoFibo = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'ButtonReiniciar
        '
        '
        'TextBoxTexto
        '
        Me.TextBoxTexto.Location = New System.Drawing.Point(12, 123)
        '
        'TextBoxNumero
        '
        Me.TextBoxNumero.Location = New System.Drawing.Point(12, 73)
        '
        'Label1
        '
        Me.Label1.Text = "Fibonacci"
        '
        'LabelHora
        '
        Me.LabelHora.Text = "07:45:33"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 13)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Hasta que numero"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 104)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 13)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Resultado"
        '
        'ListBoxResultadoFibo
        '
        Me.ListBoxResultadoFibo.FormattingEnabled = True
        Me.ListBoxResultadoFibo.Location = New System.Drawing.Point(234, 54)
        Me.ListBoxResultadoFibo.Name = "ListBoxResultadoFibo"
        Me.ListBoxResultadoFibo.Size = New System.Drawing.Size(120, 95)
        Me.ListBoxResultadoFibo.TabIndex = 13
        '
        'FormBaseOtrasFibonacci
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(399, 240)
        Me.Controls.Add(Me.ListBoxResultadoFibo)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Name = "FormBaseOtrasFibonacci"
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.LabelHora, 0)
        Me.Controls.SetChildIndex(Me.ButtonEjecutar, 0)
        Me.Controls.SetChildIndex(Me.ButtonReiniciar, 0)
        Me.Controls.SetChildIndex(Me.TextBoxNumero, 0)
        Me.Controls.SetChildIndex(Me.TextBoxTexto, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.Label3, 0)
        Me.Controls.SetChildIndex(Me.ListBoxResultadoFibo, 0)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ListBoxResultadoFibo As System.Windows.Forms.ListBox

End Class
