﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormBaseAritmeticaDivision
    Inherits Herencia.FormBaseAritmetica

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
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Text = "Division"
        '
        'LabelHora
        '
        Me.LabelHora.Size = New System.Drawing.Size(56, 17)
        Me.LabelHora.Text = "1:09:57"
        '
        'ButtonEjecutar
        '
        '
        'FormBaseAritmeticaDivision
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.ClientSize = New System.Drawing.Size(528, 295)
        Me.Name = "FormBaseAritmeticaDivision"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

End Class
