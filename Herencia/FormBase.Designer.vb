<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormBase
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LabelHora = New System.Windows.Forms.Label()
        Me.ButtonEjecutar = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(399, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Label1"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelHora
        '
        Me.LabelHora.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelHora.AutoSize = True
        Me.LabelHora.Location = New System.Drawing.Point(348, 218)
        Me.LabelHora.Name = "LabelHora"
        Me.LabelHora.Size = New System.Drawing.Size(39, 13)
        Me.LabelHora.TabIndex = 1
        Me.LabelHora.Text = "Label2"
        Me.LabelHora.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'ButtonEjecutar
        '
        Me.ButtonEjecutar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ButtonEjecutar.Location = New System.Drawing.Point(12, 205)
        Me.ButtonEjecutar.Name = "ButtonEjecutar"
        Me.ButtonEjecutar.Size = New System.Drawing.Size(75, 23)
        Me.ButtonEjecutar.TabIndex = 2
        Me.ButtonEjecutar.Text = "Ejecutar"
        Me.ButtonEjecutar.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'FormBase
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(399, 240)
        Me.Controls.Add(Me.ButtonEjecutar)
        Me.Controls.Add(Me.LabelHora)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormBase"
        Me.Text = "Form1Base"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Timer1 As Timer
    Protected WithEvents Label1 As System.Windows.Forms.Label
    Protected WithEvents LabelHora As System.Windows.Forms.Label
    Protected WithEvents ButtonEjecutar As System.Windows.Forms.Button
End Class
