<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormBaseCadena
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.ButtonReiniciar = New System.Windows.Forms.Button()
        Me.ButtonCerrar = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBoxTexto = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'LabelHora
        '
        Me.LabelHora.Size = New System.Drawing.Size(56, 17)
        Me.LabelHora.Text = "1:40:59"
        '
        'ButtonReiniciar
        '
        Me.ButtonReiniciar.Location = New System.Drawing.Point(123, 252)
        Me.ButtonReiniciar.Name = "ButtonReiniciar"
        Me.ButtonReiniciar.Size = New System.Drawing.Size(100, 28)
        Me.ButtonReiniciar.TabIndex = 3
        Me.ButtonReiniciar.Text = "Reiniciar"
        Me.ButtonReiniciar.UseVisualStyleBackColor = True
        '
        'ButtonCerrar
        '
        Me.ButtonCerrar.Location = New System.Drawing.Point(251, 252)
        Me.ButtonCerrar.Name = "ButtonCerrar"
        Me.ButtonCerrar.Size = New System.Drawing.Size(100, 28)
        Me.ButtonCerrar.TabIndex = 4
        Me.ButtonCerrar.Text = "Cerrar"
        Me.ButtonCerrar.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(153, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 17)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Texto"
        '
        'TextBoxTexto
        '
        Me.TextBoxTexto.Location = New System.Drawing.Point(156, 79)
        Me.TextBoxTexto.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBoxTexto.Name = "TextBoxTexto"
        Me.TextBoxTexto.Size = New System.Drawing.Size(207, 22)
        Me.TextBoxTexto.TabIndex = 9
        '
        'FormBaseCadena
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.ClientSize = New System.Drawing.Size(532, 295)
        Me.Controls.Add(Me.TextBoxTexto)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ButtonCerrar)
        Me.Controls.Add(Me.ButtonReiniciar)
        Me.Name = "FormBaseCadena"
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.LabelHora, 0)
        Me.Controls.SetChildIndex(Me.ButtonEjecutar, 0)
        Me.Controls.SetChildIndex(Me.ButtonReiniciar, 0)
        Me.Controls.SetChildIndex(Me.ButtonCerrar, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.TextBoxTexto, 0)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ButtonCerrar As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBoxTexto As TextBox
    Protected WithEvents ButtonReiniciar As Button
End Class
