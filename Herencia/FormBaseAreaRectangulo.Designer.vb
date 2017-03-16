<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormBaseAreaRectangulo
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
        Me.TextBoxAltura = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ButtonReiniciar
        '
        '
        'TextBoxResultado
        '
        Me.TextBoxResultado.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        '
        'TextBox1
        '
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        '
        'Label2
        '
        Me.Label2.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label2.Size = New System.Drawing.Size(40, 17)
        Me.Label2.Text = "Base"
        '
        'Label1
        '
        Me.Label1.Size = New System.Drawing.Size(559, 28)
        Me.Label1.Text = "Area de rectangulo"
        '
        'LabelHora
        '
        Me.LabelHora.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.LabelHora.Text = "11:56:53"
        '
        'ButtonEjecutar
        '
        '
        'TextBoxAltura
        '
        Me.TextBoxAltura.Location = New System.Drawing.Point(319, 103)
        Me.TextBoxAltura.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TextBoxAltura.Name = "TextBoxAltura"
        Me.TextBoxAltura.Size = New System.Drawing.Size(132, 22)
        Me.TextBoxAltura.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(319, 80)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 17)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Altura"
        '
        'FormBaseAreaRectangulo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.ClientSize = New System.Drawing.Size(559, 330)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextBoxAltura)
        Me.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.Name = "FormBaseAreaRectangulo"
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.LabelHora, 0)
        Me.Controls.SetChildIndex(Me.ButtonEjecutar, 0)
        Me.Controls.SetChildIndex(Me.ButtonReiniciar, 0)
        Me.Controls.SetChildIndex(Me.ButtonCerrar, 0)
        Me.Controls.SetChildIndex(Me.TextBoxResultado, 0)
        Me.Controls.SetChildIndex(Me.TextBox1, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.Label3, 0)
        Me.Controls.SetChildIndex(Me.TextBoxAltura, 0)
        Me.Controls.SetChildIndex(Me.Label4, 0)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Protected WithEvents TextBoxAltura As System.Windows.Forms.TextBox
    Protected WithEvents Label4 As System.Windows.Forms.Label

End Class
