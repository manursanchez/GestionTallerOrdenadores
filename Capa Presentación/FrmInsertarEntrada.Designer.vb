<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmInsertarEntrada
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
        Me.components = New System.ComponentModel.Container()
        Me.RMADataSet = New RMA2021.RMADataSet()
        Me.RMABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RMATableAdapter = New RMA2021.RMADataSetTableAdapters.RMATableAdapter()
        Me.TableAdapterManager = New RMA2021.RMADataSetTableAdapters.TableAdapterManager()
        Me.btnInsertarEntrada = New System.Windows.Forms.Button()
        Me.TextFechaEntrada = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextNombre = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextDireccion = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextTelefono = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextCorreoE = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.RichTextDescripcion = New System.Windows.Forms.RichTextBox()
        Me.RichTextObservaciones = New System.Windows.Forms.RichTextBox()
        Me.btnCancelar = New System.Windows.Forms.Button()
        CType(Me.RMADataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RMABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RMADataSet
        '
        Me.RMADataSet.DataSetName = "RMADataSet"
        Me.RMADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RMABindingSource
        '
        Me.RMABindingSource.DataMember = "RMA"
        Me.RMABindingSource.DataSource = Me.RMADataSet
        '
        'RMATableAdapter
        '
        Me.RMATableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.RMA_AuxiliarTableAdapter = Nothing
        Me.TableAdapterManager.RMABAJASTableAdapter = Nothing
        Me.TableAdapterManager.RMATableAdapter = Me.RMATableAdapter
        Me.TableAdapterManager.UpdateOrder = RMA2021.RMADataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'btnInsertarEntrada
        '
        Me.btnInsertarEntrada.Location = New System.Drawing.Point(390, 278)
        Me.btnInsertarEntrada.Name = "btnInsertarEntrada"
        Me.btnInsertarEntrada.Size = New System.Drawing.Size(152, 51)
        Me.btnInsertarEntrada.TabIndex = 5
        Me.btnInsertarEntrada.Text = "Insertar Entrada"
        Me.btnInsertarEntrada.UseVisualStyleBackColor = True
        '
        'TextFechaEntrada
        '
        Me.TextFechaEntrada.Location = New System.Drawing.Point(244, 12)
        Me.TextFechaEntrada.Name = "TextFechaEntrada"
        Me.TextFechaEntrada.Size = New System.Drawing.Size(100, 20)
        Me.TextFechaEntrada.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(121, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Fecha de entrada"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(22, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Nombre del cliente"
        '
        'TextNombre
        '
        Me.TextNombre.Location = New System.Drawing.Point(123, 53)
        Me.TextNombre.Name = "TextNombre"
        Me.TextNombre.Size = New System.Drawing.Size(198, 20)
        Me.TextNombre.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(22, 99)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Dirección"
        '
        'TextDireccion
        '
        Me.TextDireccion.Location = New System.Drawing.Point(80, 92)
        Me.TextDireccion.Name = "TextDireccion"
        Me.TextDireccion.Size = New System.Drawing.Size(254, 20)
        Me.TextDireccion.TabIndex = 10
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(387, 99)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 13)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Teléfono"
        '
        'TextTelefono
        '
        Me.TextTelefono.Location = New System.Drawing.Point(442, 92)
        Me.TextTelefono.Name = "TextTelefono"
        Me.TextTelefono.Size = New System.Drawing.Size(100, 20)
        Me.TextTelefono.TabIndex = 12
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(340, 60)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(93, 13)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Correo electrónico"
        '
        'TextCorreoE
        '
        Me.TextCorreoE.Location = New System.Drawing.Point(442, 53)
        Me.TextCorreoE.Name = "TextCorreoE"
        Me.TextCorreoE.Size = New System.Drawing.Size(100, 20)
        Me.TextCorreoE.TabIndex = 14
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(22, 141)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(126, 13)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Descripción del problema"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(22, 273)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(78, 13)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "Observaciones"
        '
        'RichTextDescripcion
        '
        Me.RichTextDescripcion.Location = New System.Drawing.Point(25, 168)
        Me.RichTextDescripcion.Name = "RichTextDescripcion"
        Me.RichTextDescripcion.Size = New System.Drawing.Size(517, 96)
        Me.RichTextDescripcion.TabIndex = 20
        Me.RichTextDescripcion.Text = ""
        '
        'RichTextObservaciones
        '
        Me.RichTextObservaciones.Location = New System.Drawing.Point(25, 294)
        Me.RichTextObservaciones.Name = "RichTextObservaciones"
        Me.RichTextObservaciones.Size = New System.Drawing.Size(309, 87)
        Me.RichTextObservaciones.TabIndex = 21
        Me.RichTextObservaciones.Text = ""
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(390, 335)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(152, 51)
        Me.btnCancelar.TabIndex = 22
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'FrmInsertarEntrada
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(568, 393)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.RichTextObservaciones)
        Me.Controls.Add(Me.RichTextDescripcion)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TextCorreoE)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextTelefono)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextDireccion)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextNombre)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextFechaEntrada)
        Me.Controls.Add(Me.btnInsertarEntrada)
        Me.Name = "FrmInsertarEntrada"
        Me.Text = "Entradas"
        CType(Me.RMADataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RMABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RMADataSet As RMADataSet
    Friend WithEvents RMABindingSource As BindingSource
    Friend WithEvents RMATableAdapter As RMADataSetTableAdapters.RMATableAdapter
    Friend WithEvents TableAdapterManager As RMADataSetTableAdapters.TableAdapterManager
    Friend WithEvents btnInsertarEntrada As Button
    Friend WithEvents TextFechaEntrada As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextNombre As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextDireccion As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TextTelefono As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TextCorreoE As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents RichTextDescripcion As RichTextBox
    Friend WithEvents RichTextObservaciones As RichTextBox
    Friend WithEvents btnCancelar As Button
End Class
