<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormBaseCadenaContadorVocales
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
        Me.TextBoxConsonante = New System.Windows.Forms.TextBox()
        Me.TextBoxVocales = New System.Windows.Forms.TextBox()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Text = "Contador de vocales y consonantes"
        '
        'LabelHora
        '
        Me.LabelHora.Text = "1:45:06"
        '
        'ButtonEjecutar
        '
        '
        'TextBoxConsonante
        '
        Me.TextBoxConsonante.Location = New System.Drawing.Point(263, 146)
        Me.TextBoxConsonante.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBoxConsonante.Name = "TextBoxConsonante"
        Me.TextBoxConsonante.Size = New System.Drawing.Size(100, 22)
        Me.TextBoxConsonante.TabIndex = 13
        '
        'TextBoxVocales
        '
        Me.TextBoxVocales.Location = New System.Drawing.Point(156, 146)
        Me.TextBoxVocales.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBoxVocales.Name = "TextBoxVocales"
        Me.TextBoxVocales.Size = New System.Drawing.Size(93, 22)
        Me.TextBoxVocales.TabIndex = 12
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.Location = New System.Drawing.Point(260, 125)
        Me.Label39.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(91, 17)
        Me.Label39.TabIndex = 11
        Me.Label39.Text = "Consonantes"
        '
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.Location = New System.Drawing.Point(153, 125)
        Me.Label40.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(58, 17)
        Me.Label40.TabIndex = 10
        Me.Label40.Text = "Vocales"
        '
        'FormBaseCadenaContadorVocales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.ClientSize = New System.Drawing.Size(532, 295)
        Me.Controls.Add(Me.TextBoxConsonante)
        Me.Controls.Add(Me.TextBoxVocales)
        Me.Controls.Add(Me.Label39)
        Me.Controls.Add(Me.Label40)
        Me.Name = "FormBaseCadenaContadorVocales"
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.LabelHora, 0)
        Me.Controls.SetChildIndex(Me.ButtonEjecutar, 0)
        Me.Controls.SetChildIndex(Me.ButtonReiniciar, 0)
        Me.Controls.SetChildIndex(Me.Label40, 0)
        Me.Controls.SetChildIndex(Me.Label39, 0)
        Me.Controls.SetChildIndex(Me.TextBoxVocales, 0)
        Me.Controls.SetChildIndex(Me.TextBoxConsonante, 0)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBoxConsonante As TextBox
    Friend WithEvents TextBoxVocales As TextBox
    Friend WithEvents Label39 As Label
    Friend WithEvents Label40 As Label
End Class
