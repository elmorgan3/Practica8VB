<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormBaseAreaTriangulo
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
        'Label2
        '
        Me.Label2.Size = New System.Drawing.Size(31, 13)
        Me.Label2.Text = "Base"
        '
        'Label1
        '
        Me.Label1.Text = "Area de Triangulo"
        '
        'LabelHora
        '
        Me.LabelHora.Text = "04:28:38"
        '
        'TextBoxAltura
        '
        Me.TextBoxAltura.Location = New System.Drawing.Point(236, 84)
        Me.TextBoxAltura.Name = "TextBoxAltura"
        Me.TextBoxAltura.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxAltura.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(236, 65)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(34, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Altura"
        '
        'FormBaseAreaTriangulo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(419, 268)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextBoxAltura)
        Me.Name = "FormBaseAreaTriangulo"
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
