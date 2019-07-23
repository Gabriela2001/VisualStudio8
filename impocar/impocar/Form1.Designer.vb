<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Clientes = New System.Windows.Forms.TextBox()
        Me.Marcas = New System.Windows.Forms.TextBox()
        Me.Modelos = New System.Windows.Forms.TextBox()
        Me.Vendedores = New System.Windows.Forms.TextBox()
        Me.Precios = New System.Windows.Forms.TextBox()
        Me.Fechas = New System.Windows.Forms.TextBox()
        Me.Tipopagos = New System.Windows.Forms.TextBox()
        Me.Codigoautos = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Totales = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Maiandra GD", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(45, 116)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Cliente"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Maiandra GD", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(45, 162)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Modelo"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Maiandra GD", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(45, 139)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Marca"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Maiandra GD", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(45, 183)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 16)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Vendedor"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Maiandra GD", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(45, 205)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 16)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Precio"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(45, 231)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(97, 16)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Fecha_venta"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(45, 254)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(102, 16)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Tipo de pago"
        '
        'Clientes
        '
        Me.Clientes.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Clientes.ForeColor = System.Drawing.SystemColors.Window
        Me.Clientes.Location = New System.Drawing.Point(177, 114)
        Me.Clientes.Name = "Clientes"
        Me.Clientes.Size = New System.Drawing.Size(100, 20)
        Me.Clientes.TabIndex = 9
        '
        'Marcas
        '
        Me.Marcas.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Marcas.ForeColor = System.Drawing.SystemColors.Window
        Me.Marcas.Location = New System.Drawing.Point(177, 137)
        Me.Marcas.Name = "Marcas"
        Me.Marcas.Size = New System.Drawing.Size(100, 20)
        Me.Marcas.TabIndex = 10
        '
        'Modelos
        '
        Me.Modelos.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Modelos.ForeColor = System.Drawing.SystemColors.Window
        Me.Modelos.Location = New System.Drawing.Point(177, 159)
        Me.Modelos.Name = "Modelos"
        Me.Modelos.Size = New System.Drawing.Size(100, 20)
        Me.Modelos.TabIndex = 11
        '
        'Vendedores
        '
        Me.Vendedores.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Vendedores.ForeColor = System.Drawing.SystemColors.Window
        Me.Vendedores.Location = New System.Drawing.Point(177, 181)
        Me.Vendedores.Name = "Vendedores"
        Me.Vendedores.Size = New System.Drawing.Size(100, 20)
        Me.Vendedores.TabIndex = 12
        '
        'Precios
        '
        Me.Precios.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Precios.ForeColor = System.Drawing.SystemColors.Window
        Me.Precios.Location = New System.Drawing.Point(177, 203)
        Me.Precios.Name = "Precios"
        Me.Precios.Size = New System.Drawing.Size(100, 20)
        Me.Precios.TabIndex = 13
        '
        'Fechas
        '
        Me.Fechas.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Fechas.ForeColor = System.Drawing.SystemColors.Window
        Me.Fechas.Location = New System.Drawing.Point(177, 229)
        Me.Fechas.Name = "Fechas"
        Me.Fechas.Size = New System.Drawing.Size(100, 20)
        Me.Fechas.TabIndex = 14
        '
        'Tipopagos
        '
        Me.Tipopagos.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Tipopagos.ForeColor = System.Drawing.SystemColors.Window
        Me.Tipopagos.Location = New System.Drawing.Point(177, 252)
        Me.Tipopagos.Name = "Tipopagos"
        Me.Tipopagos.Size = New System.Drawing.Size(100, 20)
        Me.Tipopagos.TabIndex = 15
        '
        'Codigoautos
        '
        Me.Codigoautos.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Codigoautos.ForeColor = System.Drawing.SystemColors.Window
        Me.Codigoautos.Location = New System.Drawing.Point(177, 274)
        Me.Codigoautos.Name = "Codigoautos"
        Me.Codigoautos.Size = New System.Drawing.Size(100, 20)
        Me.Codigoautos.TabIndex = 18
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(45, 277)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(74, 16)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "Cod_auto"
        '
        'Totales
        '
        Me.Totales.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Totales.ForeColor = System.Drawing.SystemColors.Window
        Me.Totales.Location = New System.Drawing.Point(177, 297)
        Me.Totales.Name = "Totales"
        Me.Totales.Size = New System.Drawing.Size(100, 20)
        Me.Totales.TabIndex = 20
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(45, 298)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(44, 16)
        Me.Label10.TabIndex = 19
        Me.Label10.Text = "Total"
        '
        'Label16
        '
        Me.Label16.Image = Global.impocar.My.Resources.Resources.unnamed2
        Me.Label16.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Label16.Location = New System.Drawing.Point(15, 9)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(293, 103)
        Me.Label16.TabIndex = 23
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(100, 345)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(109, 24)
        Me.Button1.TabIndex = 24
        Me.Button1.Text = "Enviar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(320, 388)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Totales)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Codigoautos)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Tipopagos)
        Me.Controls.Add(Me.Fechas)
        Me.Controls.Add(Me.Precios)
        Me.Controls.Add(Me.Vendedores)
        Me.Controls.Add(Me.Modelos)
        Me.Controls.Add(Me.Marcas)
        Me.Controls.Add(Me.Clientes)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.DoubleBuffered = True
        Me.Name = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Clientes As TextBox
    Friend WithEvents Marcas As TextBox
    Friend WithEvents Modelos As TextBox
    Friend WithEvents Vendedores As TextBox
    Friend WithEvents Precios As TextBox
    Friend WithEvents Fechas As TextBox
    Friend WithEvents Tipopagos As TextBox
    Friend WithEvents Codigoautos As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Totales As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Button1 As Button
End Class
