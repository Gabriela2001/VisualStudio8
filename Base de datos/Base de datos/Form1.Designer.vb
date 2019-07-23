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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Dim No_IdentificacionLabel As System.Windows.Forms.Label
        Dim NombreLabel As System.Windows.Forms.Label
        Dim PosicionLabel As System.Windows.Forms.Label
        Dim EdadLabel As System.Windows.Forms.Label
        Dim EstaturaLabel As System.Windows.Forms.Label
        Dim PesoLabel As System.Windows.Forms.Label
        Dim NacionalidadLabel As System.Windows.Forms.Label
        Dim SueldoLabel As System.Windows.Forms.Label
        Dim FeNacimientoLabel As System.Windows.Forms.Label
        Me.FutbolDataSet = New Base_de_datos.FutbolDataSet()
        Me.JugadoresBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.JugadoresTableAdapter = New Base_de_datos.FutbolDataSetTableAdapters.JugadoresTableAdapter()
        Me.TableAdapterManager = New Base_de_datos.FutbolDataSetTableAdapters.TableAdapterManager()
        Me.JugadoresBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.JugadoresBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.No_IdentificacionTextBox = New System.Windows.Forms.TextBox()
        Me.NombreTextBox = New System.Windows.Forms.TextBox()
        Me.PosicionTextBox = New System.Windows.Forms.TextBox()
        Me.EdadTextBox = New System.Windows.Forms.TextBox()
        Me.EstaturaTextBox = New System.Windows.Forms.TextBox()
        Me.PesoTextBox = New System.Windows.Forms.TextBox()
        Me.NacionalidadTextBox = New System.Windows.Forms.TextBox()
        Me.SueldoTextBox = New System.Windows.Forms.TextBox()
        Me.FeNacimientoTextBox = New System.Windows.Forms.TextBox()
        No_IdentificacionLabel = New System.Windows.Forms.Label()
        NombreLabel = New System.Windows.Forms.Label()
        PosicionLabel = New System.Windows.Forms.Label()
        EdadLabel = New System.Windows.Forms.Label()
        EstaturaLabel = New System.Windows.Forms.Label()
        PesoLabel = New System.Windows.Forms.Label()
        NacionalidadLabel = New System.Windows.Forms.Label()
        SueldoLabel = New System.Windows.Forms.Label()
        FeNacimientoLabel = New System.Windows.Forms.Label()
        CType(Me.FutbolDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JugadoresBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JugadoresBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.JugadoresBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'FutbolDataSet
        '
        Me.FutbolDataSet.DataSetName = "FutbolDataSet"
        Me.FutbolDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'JugadoresBindingSource
        '
        Me.JugadoresBindingSource.DataMember = "Jugadores"
        Me.JugadoresBindingSource.DataSource = Me.FutbolDataSet
        '
        'JugadoresTableAdapter
        '
        Me.JugadoresTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.JugadoresTableAdapter = Me.JugadoresTableAdapter
        Me.TableAdapterManager.UpdateOrder = Base_de_datos.FutbolDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'JugadoresBindingNavigator
        '
        Me.JugadoresBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.JugadoresBindingNavigator.BindingSource = Me.JugadoresBindingSource
        Me.JugadoresBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.JugadoresBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.JugadoresBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.JugadoresBindingNavigatorSaveItem})
        Me.JugadoresBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.JugadoresBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.JugadoresBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.JugadoresBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.JugadoresBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.JugadoresBindingNavigator.Name = "JugadoresBindingNavigator"
        Me.JugadoresBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.JugadoresBindingNavigator.Size = New System.Drawing.Size(225, 25)
        Me.JugadoresBindingNavigator.TabIndex = 0
        Me.JugadoresBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Mover primero"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Mover anterior"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Posición"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Posición actual"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(37, 15)
        Me.BindingNavigatorCountItem.Text = "de {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Número total de elementos"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 6)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveNextItem.Text = "Mover siguiente"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveLastItem.Text = "Mover último"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 6)
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Agregar nuevo"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorDeleteItem.Text = "Eliminar"
        '
        'JugadoresBindingNavigatorSaveItem
        '
        Me.JugadoresBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.JugadoresBindingNavigatorSaveItem.Image = CType(resources.GetObject("JugadoresBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.JugadoresBindingNavigatorSaveItem.Name = "JugadoresBindingNavigatorSaveItem"
        Me.JugadoresBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.JugadoresBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'No_IdentificacionLabel
        '
        No_IdentificacionLabel.AutoSize = True
        No_IdentificacionLabel.Location = New System.Drawing.Point(15, 39)
        No_IdentificacionLabel.Name = "No_IdentificacionLabel"
        No_IdentificacionLabel.Size = New System.Drawing.Size(88, 13)
        No_IdentificacionLabel.TabIndex = 1
        No_IdentificacionLabel.Text = "no Identificacion:"
        '
        'No_IdentificacionTextBox
        '
        Me.No_IdentificacionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.JugadoresBindingSource, "no_Identificacion", True))
        Me.No_IdentificacionTextBox.Location = New System.Drawing.Point(109, 36)
        Me.No_IdentificacionTextBox.Name = "No_IdentificacionTextBox"
        Me.No_IdentificacionTextBox.Size = New System.Drawing.Size(100, 20)
        Me.No_IdentificacionTextBox.TabIndex = 2
        '
        'NombreLabel
        '
        NombreLabel.AutoSize = True
        NombreLabel.Location = New System.Drawing.Point(56, 65)
        NombreLabel.Name = "NombreLabel"
        NombreLabel.Size = New System.Drawing.Size(47, 13)
        NombreLabel.TabIndex = 3
        NombreLabel.Text = "Nombre:"
        '
        'NombreTextBox
        '
        Me.NombreTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.JugadoresBindingSource, "Nombre", True))
        Me.NombreTextBox.Location = New System.Drawing.Point(109, 62)
        Me.NombreTextBox.Name = "NombreTextBox"
        Me.NombreTextBox.Size = New System.Drawing.Size(100, 20)
        Me.NombreTextBox.TabIndex = 4
        '
        'PosicionLabel
        '
        PosicionLabel.AutoSize = True
        PosicionLabel.Location = New System.Drawing.Point(53, 91)
        PosicionLabel.Name = "PosicionLabel"
        PosicionLabel.Size = New System.Drawing.Size(50, 13)
        PosicionLabel.TabIndex = 5
        PosicionLabel.Text = "Posicion:"
        '
        'PosicionTextBox
        '
        Me.PosicionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.JugadoresBindingSource, "Posicion", True))
        Me.PosicionTextBox.Location = New System.Drawing.Point(109, 88)
        Me.PosicionTextBox.Name = "PosicionTextBox"
        Me.PosicionTextBox.Size = New System.Drawing.Size(100, 20)
        Me.PosicionTextBox.TabIndex = 6
        '
        'EdadLabel
        '
        EdadLabel.AutoSize = True
        EdadLabel.Location = New System.Drawing.Point(68, 117)
        EdadLabel.Name = "EdadLabel"
        EdadLabel.Size = New System.Drawing.Size(35, 13)
        EdadLabel.TabIndex = 7
        EdadLabel.Text = "Edad:"
        '
        'EdadTextBox
        '
        Me.EdadTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.JugadoresBindingSource, "Edad", True))
        Me.EdadTextBox.Location = New System.Drawing.Point(109, 114)
        Me.EdadTextBox.Name = "EdadTextBox"
        Me.EdadTextBox.Size = New System.Drawing.Size(100, 20)
        Me.EdadTextBox.TabIndex = 8
        '
        'EstaturaLabel
        '
        EstaturaLabel.AutoSize = True
        EstaturaLabel.Location = New System.Drawing.Point(54, 143)
        EstaturaLabel.Name = "EstaturaLabel"
        EstaturaLabel.Size = New System.Drawing.Size(49, 13)
        EstaturaLabel.TabIndex = 9
        EstaturaLabel.Text = "Estatura:"
        '
        'EstaturaTextBox
        '
        Me.EstaturaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.JugadoresBindingSource, "Estatura", True))
        Me.EstaturaTextBox.Location = New System.Drawing.Point(109, 140)
        Me.EstaturaTextBox.Name = "EstaturaTextBox"
        Me.EstaturaTextBox.Size = New System.Drawing.Size(100, 20)
        Me.EstaturaTextBox.TabIndex = 10
        '
        'PesoLabel
        '
        PesoLabel.AutoSize = True
        PesoLabel.Location = New System.Drawing.Point(69, 169)
        PesoLabel.Name = "PesoLabel"
        PesoLabel.Size = New System.Drawing.Size(34, 13)
        PesoLabel.TabIndex = 11
        PesoLabel.Text = "Peso:"
        '
        'PesoTextBox
        '
        Me.PesoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.JugadoresBindingSource, "Peso", True))
        Me.PesoTextBox.Location = New System.Drawing.Point(109, 166)
        Me.PesoTextBox.Name = "PesoTextBox"
        Me.PesoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.PesoTextBox.TabIndex = 12
        '
        'NacionalidadLabel
        '
        NacionalidadLabel.AutoSize = True
        NacionalidadLabel.Location = New System.Drawing.Point(31, 195)
        NacionalidadLabel.Name = "NacionalidadLabel"
        NacionalidadLabel.Size = New System.Drawing.Size(72, 13)
        NacionalidadLabel.TabIndex = 13
        NacionalidadLabel.Text = "Nacionalidad:"
        '
        'NacionalidadTextBox
        '
        Me.NacionalidadTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.JugadoresBindingSource, "Nacionalidad", True))
        Me.NacionalidadTextBox.Location = New System.Drawing.Point(109, 192)
        Me.NacionalidadTextBox.Name = "NacionalidadTextBox"
        Me.NacionalidadTextBox.Size = New System.Drawing.Size(100, 20)
        Me.NacionalidadTextBox.TabIndex = 14
        '
        'SueldoLabel
        '
        SueldoLabel.AutoSize = True
        SueldoLabel.Location = New System.Drawing.Point(60, 221)
        SueldoLabel.Name = "SueldoLabel"
        SueldoLabel.Size = New System.Drawing.Size(43, 13)
        SueldoLabel.TabIndex = 15
        SueldoLabel.Text = "Sueldo:"
        '
        'SueldoTextBox
        '
        Me.SueldoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.JugadoresBindingSource, "Sueldo", True))
        Me.SueldoTextBox.Location = New System.Drawing.Point(109, 218)
        Me.SueldoTextBox.Name = "SueldoTextBox"
        Me.SueldoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.SueldoTextBox.TabIndex = 16
        '
        'FeNacimientoLabel
        '
        FeNacimientoLabel.AutoSize = True
        FeNacimientoLabel.Location = New System.Drawing.Point(25, 247)
        FeNacimientoLabel.Name = "FeNacimientoLabel"
        FeNacimientoLabel.Size = New System.Drawing.Size(78, 13)
        FeNacimientoLabel.TabIndex = 17
        FeNacimientoLabel.Text = "Fe Nacimiento:"
        '
        'FeNacimientoTextBox
        '
        Me.FeNacimientoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.JugadoresBindingSource, "FeNacimiento", True))
        Me.FeNacimientoTextBox.Location = New System.Drawing.Point(109, 244)
        Me.FeNacimientoTextBox.Name = "FeNacimientoTextBox"
        Me.FeNacimientoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.FeNacimientoTextBox.TabIndex = 18
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(225, 283)
        Me.Controls.Add(FeNacimientoLabel)
        Me.Controls.Add(Me.FeNacimientoTextBox)
        Me.Controls.Add(SueldoLabel)
        Me.Controls.Add(Me.SueldoTextBox)
        Me.Controls.Add(NacionalidadLabel)
        Me.Controls.Add(Me.NacionalidadTextBox)
        Me.Controls.Add(PesoLabel)
        Me.Controls.Add(Me.PesoTextBox)
        Me.Controls.Add(EstaturaLabel)
        Me.Controls.Add(Me.EstaturaTextBox)
        Me.Controls.Add(EdadLabel)
        Me.Controls.Add(Me.EdadTextBox)
        Me.Controls.Add(PosicionLabel)
        Me.Controls.Add(Me.PosicionTextBox)
        Me.Controls.Add(NombreLabel)
        Me.Controls.Add(Me.NombreTextBox)
        Me.Controls.Add(No_IdentificacionLabel)
        Me.Controls.Add(Me.No_IdentificacionTextBox)
        Me.Controls.Add(Me.JugadoresBindingNavigator)
        Me.Name = "Form1"
        Me.Text = " "
        CType(Me.FutbolDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JugadoresBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JugadoresBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.JugadoresBindingNavigator.ResumeLayout(False)
        Me.JugadoresBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents FutbolDataSet As FutbolDataSet
    Friend WithEvents JugadoresBindingSource As BindingSource
    Friend WithEvents JugadoresTableAdapter As FutbolDataSetTableAdapters.JugadoresTableAdapter
    Friend WithEvents TableAdapterManager As FutbolDataSetTableAdapters.TableAdapterManager
    Friend WithEvents JugadoresBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents JugadoresBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents No_IdentificacionTextBox As TextBox
    Friend WithEvents NombreTextBox As TextBox
    Friend WithEvents PosicionTextBox As TextBox
    Friend WithEvents EdadTextBox As TextBox
    Friend WithEvents EstaturaTextBox As TextBox
    Friend WithEvents PesoTextBox As TextBox
    Friend WithEvents NacionalidadTextBox As TextBox
    Friend WithEvents SueldoTextBox As TextBox
    Friend WithEvents FeNacimientoTextBox As TextBox
End Class
