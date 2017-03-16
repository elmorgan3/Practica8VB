<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormBaseCadenaContarCaracteres
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
        Me.TextBoxSegundoCaracter = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBoxPrimerCaracter = New System.Windows.Forms.TextBox()
        Me.Label44 = New System.Windows.Forms.Label()
        Me.TextBoxResultadoCaracter = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ButtonReiniciar
        '
        '
        'LabelHora
        '
        Me.LabelHora.Text = "1:56:42"
        '
        'ButtonEjecutar
        '
        '
        'TextBoxSegundoCaracter
        '
        Me.TextBoxSegundoCaracter.Location = New System.Drawing.Point(282, 146)
        Me.TextBoxSegundoCaracter.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBoxSegundoCaracter.MaxLength = 1
        Me.TextBoxSegundoCaracter.Name = "TextBoxSegundoCaracter"
        Me.TextBoxSegundoCaracter.Size = New System.Drawing.Size(93, 22)
        Me.TextBoxSegundoCaracter.TabIndex = 18
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(278, 125)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(121, 17)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Segundo caracter" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'TextBoxPrimerCaracter
        '
        Me.TextBoxPrimerCaracter.Location = New System.Drawing.Point(141, 146)
        Me.TextBoxPrimerCaracter.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBoxPrimerCaracter.MaxLength = 1
        Me.TextBoxPrimerCaracter.Name = "TextBoxPrimerCaracter"
        Me.TextBoxPrimerCaracter.Size = New System.Drawing.Size(93, 22)
        Me.TextBoxPrimerCaracter.TabIndex = 16
        '
        'Label44
        '
        Me.Label44.AutoSize = True
        Me.Label44.Location = New System.Drawing.Point(137, 125)
        Me.Label44.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(105, 17)
        Me.Label44.TabIndex = 15
        Me.Label44.Text = "Primer caracter"
        '
        'TextBoxResultadoCaracter
        '
        Me.TextBoxResultadoCaracter.Location = New System.Drawing.Point(210, 204)
        Me.TextBoxResultadoCaracter.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBoxResultadoCaracter.Name = "TextBoxResultadoCaracter"
        Me.TextBoxResultadoCaracter.Size = New System.Drawing.Size(93, 22)
        Me.TextBoxResultadoCaracter.TabIndex = 20
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(206, 183)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(136, 17)
        Me.Label11.TabIndex = 19
        Me.Label11.Text = "Resultado caractere"
        '
        'FormBaseCadenaContarCaracteres
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.ClientSize = New System.Drawing.Size(532, 295)
        Me.Controls.Add(Me.TextBoxResultadoCaracter)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.TextBoxSegundoCaracter)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TextBoxPrimerCaracter)
        Me.Controls.Add(Me.Label44)
        Me.Name = "FormBaseCadenaContarCaracteres"
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.LabelHora, 0)
        Me.Controls.SetChildIndex(Me.ButtonEjecutar, 0)
        Me.Controls.SetChildIndex(Me.ButtonReiniciar, 0)
        Me.Controls.SetChildIndex(Me.Label44, 0)
        Me.Controls.SetChildIndex(Me.TextBoxPrimerCaracter, 0)
        Me.Controls.SetChildIndex(Me.Label7, 0)
        Me.Controls.SetChildIndex(Me.TextBoxSegundoCaracter, 0)
        Me.Controls.SetChildIndex(Me.Label11, 0)
        Me.Controls.SetChildIndex(Me.TextBoxResultadoCaracter, 0)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBoxSegundoCaracter As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBoxPrimerCaracter As TextBox
    Friend WithEvents Label44 As Label
    Friend WithEvents TextBoxResultadoCaracter As TextBox
    Friend WithEvents Label11 As Label
End Class
