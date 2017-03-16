<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormBaseOtros
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
        Me.ButtonCerrar = New System.Windows.Forms.Button()
        Me.ButtonReiniciar = New System.Windows.Forms.Button()
        Me.TextBoxTexto = New System.Windows.Forms.TextBox()
        Me.TextBoxNumero = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'LabelHora
        '
        Me.LabelHora.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelHora.Size = New System.Drawing.Size(49, 13)
        Me.LabelHora.Text = "07:56:41"
        '
        'ButtonCerrar
        '
        Me.ButtonCerrar.Location = New System.Drawing.Point(188, 205)
        Me.ButtonCerrar.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonCerrar.Name = "ButtonCerrar"
        Me.ButtonCerrar.Size = New System.Drawing.Size(75, 23)
        Me.ButtonCerrar.TabIndex = 6
        Me.ButtonCerrar.Text = "Cerrar"
        Me.ButtonCerrar.UseVisualStyleBackColor = True
        '
        'ButtonReiniciar
        '
        Me.ButtonReiniciar.Location = New System.Drawing.Point(92, 205)
        Me.ButtonReiniciar.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonReiniciar.Name = "ButtonReiniciar"
        Me.ButtonReiniciar.Size = New System.Drawing.Size(75, 23)
        Me.ButtonReiniciar.TabIndex = 5
        Me.ButtonReiniciar.Text = "Reiniciar"
        Me.ButtonReiniciar.UseVisualStyleBackColor = True
        '
        'TextBoxTexto
        '
        Me.TextBoxTexto.Location = New System.Drawing.Point(112, 122)
        Me.TextBoxTexto.Name = "TextBoxTexto"
        Me.TextBoxTexto.Size = New System.Drawing.Size(163, 20)
        Me.TextBoxTexto.TabIndex = 10
        '
        'TextBoxNumero
        '
        Me.TextBoxNumero.Location = New System.Drawing.Point(112, 72)
        Me.TextBoxNumero.MaxLength = 9
        Me.TextBoxNumero.Name = "TextBoxNumero"
        Me.TextBoxNumero.Size = New System.Drawing.Size(163, 20)
        Me.TextBoxNumero.TabIndex = 9
        '
        'FormBaseOtros
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(399, 240)
        Me.Controls.Add(Me.TextBoxTexto)
        Me.Controls.Add(Me.TextBoxNumero)
        Me.Controls.Add(Me.ButtonCerrar)
        Me.Controls.Add(Me.ButtonReiniciar)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "FormBaseOtros"
        Me.Controls.SetChildIndex(Me.ButtonReiniciar, 0)
        Me.Controls.SetChildIndex(Me.ButtonCerrar, 0)
        Me.Controls.SetChildIndex(Me.TextBoxNumero, 0)
        Me.Controls.SetChildIndex(Me.TextBoxTexto, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.LabelHora, 0)
        Me.Controls.SetChildIndex(Me.ButtonEjecutar, 0)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ButtonCerrar As Button
    Protected WithEvents ButtonReiniciar As Button
    Protected WithEvents TextBoxTexto As TextBox
    Protected WithEvents TextBoxNumero As TextBox
End Class
