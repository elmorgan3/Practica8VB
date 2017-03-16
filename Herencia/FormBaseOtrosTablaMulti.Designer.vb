<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormBaseOtrosTablaMulti
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
        Me.TextBoxHasta = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ListBoxResultadoMultiplicar = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'ButtonReiniciar
        '
        '
        'TextBoxTexto
        '
        Me.TextBoxTexto.Location = New System.Drawing.Point(12, 120)
        Me.TextBoxTexto.Size = New System.Drawing.Size(120, 20)
        '
        'TextBoxNumero
        '
        Me.TextBoxNumero.Location = New System.Drawing.Point(12, 70)
        Me.TextBoxNumero.Size = New System.Drawing.Size(120, 20)
        '
        'Label1
        '
        Me.Label1.Text = "Tabla de multiplicar"
        '
        'LabelHora
        '
        Me.LabelHora.Text = "08:01:49"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 13)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Numero multiplicar"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 101)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 13)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Resultado"
        '
        'TextBoxHasta
        '
        Me.TextBoxHasta.Location = New System.Drawing.Point(188, 70)
        Me.TextBoxHasta.Name = "TextBoxHasta"
        Me.TextBoxHasta.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxHasta.TabIndex = 13
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(185, 51)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 13)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Hasta a"
        '
        'ListBoxResultadoMultiplicar
        '
        Me.ListBoxResultadoMultiplicar.FormattingEnabled = True
        Me.ListBoxResultadoMultiplicar.Location = New System.Drawing.Point(188, 101)
        Me.ListBoxResultadoMultiplicar.Margin = New System.Windows.Forms.Padding(2)
        Me.ListBoxResultadoMultiplicar.Name = "ListBoxResultadoMultiplicar"
        Me.ListBoxResultadoMultiplicar.Size = New System.Drawing.Size(100, 69)
        Me.ListBoxResultadoMultiplicar.TabIndex = 20
        '
        'FormBaseOtrosTablaMulti
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(399, 240)
        Me.Controls.Add(Me.ListBoxResultadoMultiplicar)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextBoxHasta)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Name = "FormBaseOtrosTablaMulti"
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.Label3, 0)
        Me.Controls.SetChildIndex(Me.TextBoxHasta, 0)
        Me.Controls.SetChildIndex(Me.Label4, 0)
        Me.Controls.SetChildIndex(Me.ListBoxResultadoMultiplicar, 0)
        Me.Controls.SetChildIndex(Me.ButtonReiniciar, 0)
        Me.Controls.SetChildIndex(Me.TextBoxNumero, 0)
        Me.Controls.SetChildIndex(Me.TextBoxTexto, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.LabelHora, 0)
        Me.Controls.SetChildIndex(Me.ButtonEjecutar, 0)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextBoxHasta As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ListBoxResultadoMultiplicar As System.Windows.Forms.ListBox

End Class
