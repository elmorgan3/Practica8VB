<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormBaseArea
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
        Me.TextBoxResultado = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Size = New System.Drawing.Size(396, 23)
        '
        'LabelHora
        '
        Me.LabelHora.Location = New System.Drawing.Point(345, 218)
        Me.LabelHora.Size = New System.Drawing.Size(49, 13)
        Me.LabelHora.Text = "08:47:32"
        '
        'ButtonEjecutar
        '
        '
        'ButtonReiniciar
        '
        Me.ButtonReiniciar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ButtonReiniciar.Location = New System.Drawing.Point(94, 205)
        Me.ButtonReiniciar.Name = "ButtonReiniciar"
        Me.ButtonReiniciar.Size = New System.Drawing.Size(75, 23)
        Me.ButtonReiniciar.TabIndex = 3
        Me.ButtonReiniciar.Text = "Reiniciar"
        Me.ButtonReiniciar.UseVisualStyleBackColor = True
        '
        'ButtonCerrar
        '
        Me.ButtonCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ButtonCerrar.Location = New System.Drawing.Point(196, 205)
        Me.ButtonCerrar.Name = "ButtonCerrar"
        Me.ButtonCerrar.Size = New System.Drawing.Size(75, 23)
        Me.ButtonCerrar.TabIndex = 4
        Me.ButtonCerrar.Text = "Cerrar"
        Me.ButtonCerrar.UseVisualStyleBackColor = True
        '
        'TextBoxResultado
        '
        Me.TextBoxResultado.Location = New System.Drawing.Point(144, 156)
        Me.TextBoxResultado.Name = "TextBoxResultado"
        Me.TextBoxResultado.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxResultado.TabIndex = 5
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(80, 84)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(77, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Label2"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(141, 140)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Resultado"
        '
        'FormBaseArea
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(396, 240)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.TextBoxResultado)
        Me.Controls.Add(Me.ButtonCerrar)
        Me.Controls.Add(Me.ButtonReiniciar)
        Me.Name = "FormBaseArea"
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.LabelHora, 0)
        Me.Controls.SetChildIndex(Me.ButtonEjecutar, 0)
        Me.Controls.SetChildIndex(Me.ButtonReiniciar, 0)
        Me.Controls.SetChildIndex(Me.ButtonCerrar, 0)
        Me.Controls.SetChildIndex(Me.TextBoxResultado, 0)
        Me.Controls.SetChildIndex(Me.TextBox1, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.Label3, 0)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Protected WithEvents ButtonReiniciar As System.Windows.Forms.Button
    Protected WithEvents ButtonCerrar As System.Windows.Forms.Button
    Protected WithEvents TextBoxResultado As System.Windows.Forms.TextBox
    Protected WithEvents TextBox1 As System.Windows.Forms.TextBox
    Protected WithEvents Label2 As System.Windows.Forms.Label
    Protected WithEvents Label3 As System.Windows.Forms.Label

End Class
