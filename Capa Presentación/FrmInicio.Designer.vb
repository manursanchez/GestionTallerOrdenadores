<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmInicio
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.BtnEntradas = New System.Windows.Forms.Button()
        Me.FileSystemWatcher1 = New System.IO.FileSystemWatcher()
        Me.BtnSalidas = New System.Windows.Forms.Button()
        Me.BtnRecuperaEntrada = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.BtnCambiaEntrada = New System.Windows.Forms.Button()
        Me.BtnListado = New System.Windows.Forms.Button()
        CType(Me.FileSystemWatcher1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnEntradas
        '
        Me.BtnEntradas.Location = New System.Drawing.Point(13, 32)
        Me.BtnEntradas.Name = "BtnEntradas"
        Me.BtnEntradas.Size = New System.Drawing.Size(103, 66)
        Me.BtnEntradas.TabIndex = 0
        Me.BtnEntradas.Text = "Entradas"
        Me.BtnEntradas.UseVisualStyleBackColor = True
        '
        'FileSystemWatcher1
        '
        Me.FileSystemWatcher1.EnableRaisingEvents = True
        Me.FileSystemWatcher1.SynchronizingObject = Me
        '
        'BtnSalidas
        '
        Me.BtnSalidas.Location = New System.Drawing.Point(377, 32)
        Me.BtnSalidas.Name = "BtnSalidas"
        Me.BtnSalidas.Size = New System.Drawing.Size(103, 66)
        Me.BtnSalidas.TabIndex = 1
        Me.BtnSalidas.Text = "Salidas"
        Me.BtnSalidas.UseVisualStyleBackColor = True
        '
        'BtnRecuperaEntrada
        '
        Me.BtnRecuperaEntrada.Location = New System.Drawing.Point(132, 32)
        Me.BtnRecuperaEntrada.Name = "BtnRecuperaEntrada"
        Me.BtnRecuperaEntrada.Size = New System.Drawing.Size(103, 66)
        Me.BtnRecuperaEntrada.TabIndex = 2
        Me.BtnRecuperaEntrada.Text = "Consulta de entradas"
        Me.BtnRecuperaEntrada.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(624, 32)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(103, 66)
        Me.Button5.TabIndex = 4
        Me.Button5.Text = "Salir de la aplicación"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'BtnCambiaEntrada
        '
        Me.BtnCambiaEntrada.Location = New System.Drawing.Point(254, 32)
        Me.BtnCambiaEntrada.Name = "BtnCambiaEntrada"
        Me.BtnCambiaEntrada.Size = New System.Drawing.Size(103, 66)
        Me.BtnCambiaEntrada.TabIndex = 5
        Me.BtnCambiaEntrada.Text = "Modificar entradas"
        Me.BtnCambiaEntrada.UseVisualStyleBackColor = True
        '
        'BtnListado
        '
        Me.BtnListado.Location = New System.Drawing.Point(500, 32)
        Me.BtnListado.Name = "BtnListado"
        Me.BtnListado.Size = New System.Drawing.Size(103, 66)
        Me.BtnListado.TabIndex = 6
        Me.BtnListado.Text = "Listados"
        Me.BtnListado.UseVisualStyleBackColor = True
        '
        'FrmInicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(738, 125)
        Me.Controls.Add(Me.BtnListado)
        Me.Controls.Add(Me.BtnCambiaEntrada)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.BtnRecuperaEntrada)
        Me.Controls.Add(Me.BtnSalidas)
        Me.Controls.Add(Me.BtnEntradas)
        Me.Name = "FrmInicio"
        Me.Text = "Gestión de taller"
        CType(Me.FileSystemWatcher1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BtnEntradas As Button
    Friend WithEvents FileSystemWatcher1 As IO.FileSystemWatcher
    Friend WithEvents Button5 As Button
    Friend WithEvents BtnRecuperaEntrada As Button
    Friend WithEvents BtnSalidas As Button
    Friend WithEvents BtnListado As Button
    Friend WithEvents BtnCambiaEntrada As Button
End Class
