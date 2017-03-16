<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormBaseAritmetica
    Inherits Herencia.FormBase

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
        Me.ButtonReiniciar = New System.Windows.Forms.Button()
        Me.ButtonCerrar = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBoxResultado = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label1.Size = New System.Drawing.Size(528, 28)
        '
        'LabelHora
        '
        Me.LabelHora.Location = New System.Drawing.Point(460, 268)
        Me.LabelHora.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.LabelHora.Size = New System.Drawing.Size(64, 17)
        Me.LabelHora.Text = "12:14:05"
        '
        'ButtonReiniciar
        '
        Me.ButtonReiniciar.Location = New System.Drawing.Point(124, 252)
        Me.ButtonReiniciar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ButtonReiniciar.Name = "ButtonReiniciar"
        Me.ButtonReiniciar.Size = New System.Drawing.Size(100, 28)
        Me.ButtonReiniciar.TabIndex = 3
        Me.ButtonReiniciar.Text = "Reiniciar"
        Me.ButtonReiniciar.UseVisualStyleBackColor = True
        '
        'ButtonCerrar
        '
        Me.ButtonCerrar.Location = New System.Drawing.Point(252, 252)
        Me.ButtonCerrar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ButtonCerrar.Name = "ButtonCerrar"
        Me.ButtonCerrar.Size = New System.Drawing.Size(100, 28)
        Me.ButtonCerrar.TabIndex = 4
        Me.ButtonCerrar.Text = "Cerrar"
        Me.ButtonCerrar.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(69, 92)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(132, 22)
        Me.TextBox1.TabIndex = 5
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(317, 92)
        Me.TextBox2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(132, 22)
        Me.TextBox2.TabIndex = 6
        '
        'TextBoxResultado
        '
        Me.TextBoxResultado.Location = New System.Drawing.Point(195, 158)
        Me.TextBoxResultado.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TextBoxResultado.Name = "TextBoxResultado"
        Me.TextBoxResultado.Size = New System.Drawing.Size(132, 22)
        Me.TextBoxResultado.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(65, 69)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 17)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Primer numero"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(313, 69)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(117, 17)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Segundo numero"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(192, 137)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 17)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Resultado"
        '
        'FormBaseAritmetica
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.ClientSize = New System.Drawing.Size(528, 295)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBoxResultado)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.ButtonCerrar)
        Me.Controls.Add(Me.ButtonReiniciar)
        Me.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.Name = "FormBaseAritmetica"
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.LabelHora, 0)
        Me.Controls.SetChildIndex(Me.ButtonEjecutar, 0)
        Me.Controls.SetChildIndex(Me.ButtonReiniciar, 0)
        Me.Controls.SetChildIndex(Me.ButtonCerrar, 0)
        Me.Controls.SetChildIndex(Me.TextBox1, 0)
        Me.Controls.SetChildIndex(Me.TextBox2, 0)
        Me.Controls.SetChildIndex(Me.TextBoxResultado, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.Label3, 0)
        Me.Controls.SetChildIndex(Me.Label4, 0)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ButtonReiniciar As System.Windows.Forms.Button
    Friend WithEvents ButtonCerrar As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxResultado As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label

End Class
