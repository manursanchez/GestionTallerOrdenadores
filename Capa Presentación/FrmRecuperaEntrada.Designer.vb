<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmRecuperaEntrada
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
        Me.BtnConsulta = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'BtnConsulta
        '
        Me.BtnConsulta.Location = New System.Drawing.Point(326, 141)
        Me.BtnConsulta.Name = "BtnConsulta"
        Me.BtnConsulta.Size = New System.Drawing.Size(196, 74)
        Me.BtnConsulta.TabIndex = 0
        Me.BtnConsulta.Text = "Pulsa aquí para buscar"
        Me.BtnConsulta.UseVisualStyleBackColor = True
        '
        'FrmRecuperaEntrada
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.BtnConsulta)
        Me.Name = "FrmRecuperaEntrada"
        Me.Text = "Consulta de entrada"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BtnConsulta As Button
End Class
