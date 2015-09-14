<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GestionGastos
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
        Dim ModeloLabel As System.Windows.Forms.Label
        Dim ConceptoLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim FacturaLabel As System.Windows.Forms.Label
        Dim ImporteLabel As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GestionGastos))
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.FincasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ModelosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSetTablas = New DatosMsSQL.DataSetTablas()
        Me.DestinoComboBox = New System.Windows.Forms.ComboBox()
        Me.GastosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DestinosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProveedoresBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FincasTableAdapter = New DatosMsSQL.DataSetTablasTableAdapters.FincasTableAdapter()
        Me.ProveedorComboBox = New System.Windows.Forms.ComboBox()
        Me.GastosDataGridView = New System.Windows.Forms.DataGridView()
        Me.FechaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FacturaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ConceptoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ImporteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Grupo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Finca = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Modelo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProveedoresTableAdapter = New DatosMsSQL.DataSetTablasTableAdapters.ProveedoresTableAdapter()
        Me.FechaDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.ConceptoTextBox = New System.Windows.Forms.TextBox()
        Me.GruposBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GruposComboBox = New System.Windows.Forms.ComboBox()
        Me.GruposTableAdapter = New DatosMsSQL.DataSetTablasTableAdapters.GruposTableAdapter()
        Me.FacturaTextBox = New System.Windows.Forms.TextBox()
        Me.ImporteTextBox = New System.Windows.Forms.TextBox()
        Me.BindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.EjercicioComboBox = New System.Windows.Forms.ToolStripComboBox()
        Me.PresentarGastos = New System.Windows.Forms.ToolStripDropDownButton()
        Me.ProveedorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DestinoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TodosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorGuardar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.FincasListBox = New System.Windows.Forms.ListBox()
        Me.ModelosComboBox = New System.Windows.Forms.ComboBox()
        Me.ModelosTableAdapter = New DatosMsSQL.DataSetTablasTableAdapters.ModelosTableAdapter()
        Me.GastosPlusTableAdapter = New DatosMsSQL.DataSetTablasTableAdapters.GastosPlusTableAdapter()
        Me.ImporteSumTextBox = New System.Windows.Forms.TextBox()
        ModeloLabel = New System.Windows.Forms.Label()
        ConceptoLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        FacturaLabel = New System.Windows.Forms.Label()
        ImporteLabel = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        CType(Me.FincasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ModelosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetTablas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GastosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DestinosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProveedoresBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GastosDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GruposBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'ModeloLabel
        '
        ModeloLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        ModeloLabel.AutoSize = True
        ModeloLabel.Location = New System.Drawing.Point(558, 71)
        ModeloLabel.Name = "ModeloLabel"
        ModeloLabel.Size = New System.Drawing.Size(46, 13)
        ModeloLabel.TabIndex = 7
        ModeloLabel.Text = "Destino:"
        '
        'ConceptoLabel
        '
        ConceptoLabel.AutoSize = True
        ConceptoLabel.Location = New System.Drawing.Point(12, 67)
        ConceptoLabel.Name = "ConceptoLabel"
        ConceptoLabel.Size = New System.Drawing.Size(56, 13)
        ConceptoLabel.TabIndex = 13
        ConceptoLabel.Text = "Concepto:"
        '
        'Label1
        '
        Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(564, 98)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(39, 13)
        Label1.TabIndex = 15
        Label1.Text = "Grupo:"
        '
        'FacturaLabel
        '
        FacturaLabel.AutoSize = True
        FacturaLabel.Location = New System.Drawing.Point(357, 98)
        FacturaLabel.Name = "FacturaLabel"
        FacturaLabel.Size = New System.Drawing.Size(46, 13)
        FacturaLabel.TabIndex = 15
        FacturaLabel.Text = "Factura:"
        '
        'ImporteLabel
        '
        ImporteLabel.AutoSize = True
        ImporteLabel.Location = New System.Drawing.Point(358, 125)
        ImporteLabel.Name = "ImporteLabel"
        ImporteLabel.Size = New System.Drawing.Size(45, 13)
        ImporteLabel.TabIndex = 16
        ImporteLabel.Text = "Importe:"
        '
        'Label2
        '
        Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Label2.AutoSize = True
        Label2.Location = New System.Drawing.Point(558, 124)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(45, 13)
        Label2.TabIndex = 24
        Label2.Text = "Modelo:"
        '
        'StatusStrip
        '
        Me.StatusStrip.Location = New System.Drawing.Point(0, 398)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Size = New System.Drawing.Size(723, 22)
        Me.StatusStrip.TabIndex = 3
        Me.StatusStrip.Text = "StatusStrip"
        '
        'FincasBindingSource
        '
        Me.FincasBindingSource.DataMember = "FK_Fincas_Modelos"
        Me.FincasBindingSource.DataSource = Me.ModelosBindingSource
        Me.FincasBindingSource.Sort = "Identificacion"
        '
        'ModelosBindingSource
        '
        Me.ModelosBindingSource.DataMember = "Modelos"
        Me.ModelosBindingSource.DataSource = Me.DataSetTablas
        '
        'DataSetTablas
        '
        Me.DataSetTablas.DataSetName = "DataSetTablas"
        Me.DataSetTablas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DestinoComboBox
        '
        Me.DestinoComboBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DestinoComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.GastosBindingSource, "TipoDestino", True))
        Me.DestinoComboBox.DataSource = Me.DestinosBindingSource
        Me.DestinoComboBox.DisplayMember = "Destino"
        Me.DestinoComboBox.DropDownHeight = 200
        Me.DestinoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.DestinoComboBox.FormattingEnabled = True
        Me.DestinoComboBox.IntegralHeight = False
        Me.DestinoComboBox.Location = New System.Drawing.Point(609, 67)
        Me.DestinoComboBox.Name = "DestinoComboBox"
        Me.DestinoComboBox.Size = New System.Drawing.Size(101, 21)
        Me.DestinoComboBox.TabIndex = 8
        Me.DestinoComboBox.ValueMember = "Valor"
        '
        'GastosBindingSource
        '
        Me.GastosBindingSource.DataMember = "GastosPlus"
        Me.GastosBindingSource.DataSource = Me.DataSetTablas
        Me.GastosBindingSource.Sort = "Fecha DESC"
        '
        'DestinosBindingSource
        '
        Me.DestinosBindingSource.DataMember = "Destinos"
        Me.DestinosBindingSource.DataSource = GetType(DatosMsSQL.DataSetTablas)
        '
        'ProveedoresBindingSource
        '
        Me.ProveedoresBindingSource.DataMember = "Proveedores"
        Me.ProveedoresBindingSource.DataSource = Me.DataSetTablas
        '
        'FincasTableAdapter
        '
        Me.FincasTableAdapter.ClearBeforeFill = True
        '
        'ProveedorComboBox
        '
        Me.ProveedorComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.GastosBindingSource, "ProveedorID", True))
        Me.ProveedorComboBox.DataSource = Me.ProveedoresBindingSource
        Me.ProveedorComboBox.DisplayMember = "RazonSocial"
        Me.ProveedorComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ProveedorComboBox.FormattingEnabled = True
        Me.ProveedorComboBox.Location = New System.Drawing.Point(12, 38)
        Me.ProveedorComboBox.Name = "ProveedorComboBox"
        Me.ProveedorComboBox.Size = New System.Drawing.Size(247, 21)
        Me.ProveedorComboBox.TabIndex = 11
        Me.ProveedorComboBox.ValueMember = "ID"
        '
        'GastosDataGridView
        '
        Me.GastosDataGridView.AllowUserToAddRows = False
        Me.GastosDataGridView.AllowUserToDeleteRows = False
        Me.GastosDataGridView.AllowUserToOrderColumns = True
        Me.GastosDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GastosDataGridView.AutoGenerateColumns = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.GastosDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.GastosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GastosDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.FechaDataGridViewTextBoxColumn, Me.FacturaDataGridViewTextBoxColumn, Me.ConceptoDataGridViewTextBoxColumn, Me.ImporteDataGridViewTextBoxColumn, Me.Grupo, Me.Finca, Me.Modelo})
        Me.GastosDataGridView.DataSource = Me.GastosBindingSource
        Me.GastosDataGridView.Location = New System.Drawing.Point(12, 148)
        Me.GastosDataGridView.MultiSelect = False
        Me.GastosDataGridView.Name = "GastosDataGridView"
        Me.GastosDataGridView.ReadOnly = True
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Gray
        Me.GastosDataGridView.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.GastosDataGridView.Size = New System.Drawing.Size(592, 238)
        Me.GastosDataGridView.TabIndex = 12
        '
        'FechaDataGridViewTextBoxColumn
        '
        Me.FechaDataGridViewTextBoxColumn.DataPropertyName = "Fecha"
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Gray
        Me.FechaDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle2
        Me.FechaDataGridViewTextBoxColumn.HeaderText = "Fecha"
        Me.FechaDataGridViewTextBoxColumn.Name = "FechaDataGridViewTextBoxColumn"
        Me.FechaDataGridViewTextBoxColumn.ReadOnly = True
        Me.FechaDataGridViewTextBoxColumn.Width = 74
        '
        'FacturaDataGridViewTextBoxColumn
        '
        Me.FacturaDataGridViewTextBoxColumn.DataPropertyName = "Factura"
        Me.FacturaDataGridViewTextBoxColumn.HeaderText = "Factura"
        Me.FacturaDataGridViewTextBoxColumn.Name = "FacturaDataGridViewTextBoxColumn"
        Me.FacturaDataGridViewTextBoxColumn.ReadOnly = True
        Me.FacturaDataGridViewTextBoxColumn.Width = 60
        '
        'ConceptoDataGridViewTextBoxColumn
        '
        Me.ConceptoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ConceptoDataGridViewTextBoxColumn.DataPropertyName = "Concepto"
        Me.ConceptoDataGridViewTextBoxColumn.HeaderText = "Concepto"
        Me.ConceptoDataGridViewTextBoxColumn.Name = "ConceptoDataGridViewTextBoxColumn"
        Me.ConceptoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ImporteDataGridViewTextBoxColumn
        '
        Me.ImporteDataGridViewTextBoxColumn.DataPropertyName = "Importe"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Format = "C2"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.ImporteDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle3
        Me.ImporteDataGridViewTextBoxColumn.HeaderText = "Importe"
        Me.ImporteDataGridViewTextBoxColumn.Name = "ImporteDataGridViewTextBoxColumn"
        Me.ImporteDataGridViewTextBoxColumn.ReadOnly = True
        Me.ImporteDataGridViewTextBoxColumn.Width = 60
        '
        'Grupo
        '
        Me.Grupo.DataPropertyName = "Grupo"
        Me.Grupo.HeaderText = "Grupo"
        Me.Grupo.Name = "Grupo"
        Me.Grupo.ReadOnly = True
        Me.Grupo.Width = 80
        '
        'Finca
        '
        Me.Finca.DataPropertyName = "Finca"
        Me.Finca.HeaderText = "Finca"
        Me.Finca.Name = "Finca"
        Me.Finca.ReadOnly = True
        Me.Finca.Width = 80
        '
        'Modelo
        '
        Me.Modelo.DataPropertyName = "Modelo"
        Me.Modelo.HeaderText = "Modelo"
        Me.Modelo.Name = "Modelo"
        Me.Modelo.ReadOnly = True
        Me.Modelo.Width = 80
        '
        'ProveedoresTableAdapter
        '
        Me.ProveedoresTableAdapter.ClearBeforeFill = True
        '
        'FechaDateTimePicker
        '
        Me.FechaDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.GastosBindingSource, "Fecha", True))
        Me.FechaDateTimePicker.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.FechaDateTimePicker.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FechaDateTimePicker.Location = New System.Drawing.Point(265, 38)
        Me.FechaDateTimePicker.Name = "FechaDateTimePicker"
        Me.FechaDateTimePicker.Size = New System.Drawing.Size(245, 20)
        Me.FechaDateTimePicker.TabIndex = 13
        '
        'ConceptoTextBox
        '
        Me.ConceptoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GastosBindingSource, "Concepto", True))
        Me.ConceptoTextBox.Location = New System.Drawing.Point(11, 83)
        Me.ConceptoTextBox.Multiline = True
        Me.ConceptoTextBox.Name = "ConceptoTextBox"
        Me.ConceptoTextBox.Size = New System.Drawing.Size(247, 58)
        Me.ConceptoTextBox.TabIndex = 14
        '
        'GruposBindingSource
        '
        Me.GruposBindingSource.DataMember = "Grupos"
        Me.GruposBindingSource.DataSource = Me.DataSetTablas
        '
        'GruposComboBox
        '
        Me.GruposComboBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GruposComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.GastosBindingSource, "GrupoID", True))
        Me.GruposComboBox.DataSource = Me.GruposBindingSource
        Me.GruposComboBox.DisplayMember = "Nombre"
        Me.GruposComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.GruposComboBox.FormattingEnabled = True
        Me.GruposComboBox.Location = New System.Drawing.Point(609, 94)
        Me.GruposComboBox.Name = "GruposComboBox"
        Me.GruposComboBox.Size = New System.Drawing.Size(101, 21)
        Me.GruposComboBox.TabIndex = 14
        Me.GruposComboBox.ValueMember = "ID"
        '
        'GruposTableAdapter
        '
        Me.GruposTableAdapter.ClearBeforeFill = True
        '
        'FacturaTextBox
        '
        Me.FacturaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GastosBindingSource, "Factura", True))
        Me.FacturaTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FacturaTextBox.Location = New System.Drawing.Point(409, 94)
        Me.FacturaTextBox.Name = "FacturaTextBox"
        Me.FacturaTextBox.Size = New System.Drawing.Size(100, 21)
        Me.FacturaTextBox.TabIndex = 16
        '
        'ImporteTextBox
        '
        Me.ImporteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GastosBindingSource, "Importe", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "C2"))
        Me.ImporteTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ImporteTextBox.Location = New System.Drawing.Point(409, 121)
        Me.ImporteTextBox.Name = "ImporteTextBox"
        Me.ImporteTextBox.Size = New System.Drawing.Size(100, 21)
        Me.ImporteTextBox.TabIndex = 17
        Me.ImporteTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'BindingNavigator
        '
        Me.BindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.BindingNavigator.BindingSource = Me.GastosBindingSource
        Me.BindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.BindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.BindingNavigator.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.BindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EjercicioComboBox, Me.PresentarGastos, Me.ToolStripSeparator2, Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.BindingNavigatorGuardar, Me.ToolStripSeparator1})
        Me.BindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.BindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.BindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.BindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.BindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.BindingNavigator.Name = "BindingNavigator"
        Me.BindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.BindingNavigator.Size = New System.Drawing.Size(723, 31)
        Me.BindingNavigator.TabIndex = 18
        Me.BindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(28, 28)
        Me.BindingNavigatorAddNewItem.Text = "Agregar nuevo"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(37, 28)
        Me.BindingNavigatorCountItem.Text = "de {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Número total de elementos"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(28, 28)
        Me.BindingNavigatorDeleteItem.Text = "Eliminar"
        '
        'EjercicioComboBox
        '
        Me.EjercicioComboBox.AutoToolTip = True
        Me.EjercicioComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Standard
        Me.EjercicioComboBox.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.EjercicioComboBox.Name = "EjercicioComboBox"
        Me.EjercicioComboBox.Size = New System.Drawing.Size(75, 31)
        Me.EjercicioComboBox.Text = "0000"
        Me.EjercicioComboBox.ToolTipText = "Ejercicio"
        '
        'PresentarGastos
        '
        Me.PresentarGastos.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.PresentarGastos.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProveedorToolStripMenuItem, Me.DestinoToolStripMenuItem, Me.TodosToolStripMenuItem})
        Me.PresentarGastos.Image = Global.CovetorWin.My.Resources.Resources.OpenToolStripButton_Image
        Me.PresentarGastos.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.PresentarGastos.Name = "PresentarGastos"
        Me.PresentarGastos.Size = New System.Drawing.Size(37, 28)
        Me.PresentarGastos.Text = "Presentar Datos"
        Me.PresentarGastos.ToolTipText = "Presentar gastos según tipo"
        '
        'ProveedorToolStripMenuItem
        '
        Me.ProveedorToolStripMenuItem.Name = "ProveedorToolStripMenuItem"
        Me.ProveedorToolStripMenuItem.Size = New System.Drawing.Size(128, 22)
        Me.ProveedorToolStripMenuItem.Text = "Proveedor"
        '
        'DestinoToolStripMenuItem
        '
        Me.DestinoToolStripMenuItem.Name = "DestinoToolStripMenuItem"
        Me.DestinoToolStripMenuItem.Size = New System.Drawing.Size(128, 22)
        Me.DestinoToolStripMenuItem.Text = "Destino"
        '
        'TodosToolStripMenuItem
        '
        Me.TodosToolStripMenuItem.Name = "TodosToolStripMenuItem"
        Me.TodosToolStripMenuItem.Size = New System.Drawing.Size(128, 22)
        Me.TodosToolStripMenuItem.Text = "Todos"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 31)
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(28, 28)
        Me.BindingNavigatorMoveFirstItem.Text = "Mover primero"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(28, 28)
        Me.BindingNavigatorMovePreviousItem.Text = "Mover anterior"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 31)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Posición"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(40, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Posición actual"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 31)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(28, 28)
        Me.BindingNavigatorMoveNextItem.Text = "Mover siguiente"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(28, 28)
        Me.BindingNavigatorMoveLastItem.Text = "Mover último"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 31)
        '
        'BindingNavigatorGuardar
        '
        Me.BindingNavigatorGuardar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorGuardar.Image = Global.CovetorWin.My.Resources.Resources.Disquete
        Me.BindingNavigatorGuardar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BindingNavigatorGuardar.Name = "BindingNavigatorGuardar"
        Me.BindingNavigatorGuardar.Size = New System.Drawing.Size(28, 28)
        Me.BindingNavigatorGuardar.Text = "Guardar "
        Me.BindingNavigatorGuardar.ToolTipText = "Guardar Datos"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 31)
        '
        'FincasListBox
        '
        Me.FincasListBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FincasListBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.GastosBindingSource, "FincaID", True))
        Me.FincasListBox.DataSource = Me.FincasBindingSource
        Me.FincasListBox.DisplayMember = "Identificacion"
        Me.FincasListBox.FormattingEnabled = True
        Me.FincasListBox.Location = New System.Drawing.Point(610, 148)
        Me.FincasListBox.Name = "FincasListBox"
        Me.FincasListBox.Size = New System.Drawing.Size(101, 238)
        Me.FincasListBox.TabIndex = 19
        Me.FincasListBox.ValueMember = "ID"
        '
        'ModelosComboBox
        '
        Me.ModelosComboBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ModelosComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.GastosBindingSource, "ModeloID", True))
        Me.ModelosComboBox.DataSource = Me.ModelosBindingSource
        Me.ModelosComboBox.DisplayMember = "Modelo"
        Me.ModelosComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ModelosComboBox.FormattingEnabled = True
        Me.ModelosComboBox.Location = New System.Drawing.Point(609, 121)
        Me.ModelosComboBox.Name = "ModelosComboBox"
        Me.ModelosComboBox.Size = New System.Drawing.Size(101, 21)
        Me.ModelosComboBox.TabIndex = 23
        Me.ModelosComboBox.ValueMember = "ID"
        '
        'ModelosTableAdapter
        '
        Me.ModelosTableAdapter.ClearBeforeFill = True
        '
        'GastosPlusTableAdapter
        '
        Me.GastosPlusTableAdapter.ClearBeforeFill = True
        '
        'ImporteSumTextBox
        '
        Me.ImporteSumTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ImporteSumTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ImporteSumTextBox.ForeColor = System.Drawing.Color.Maroon
        Me.ImporteSumTextBox.Location = New System.Drawing.Point(610, 38)
        Me.ImporteSumTextBox.Name = "ImporteSumTextBox"
        Me.ImporteSumTextBox.Size = New System.Drawing.Size(100, 23)
        Me.ImporteSumTextBox.TabIndex = 25
        Me.ImporteSumTextBox.Text = "Importe"
        Me.ImporteSumTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GestionGastos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(723, 420)
        Me.Controls.Add(Me.ImporteSumTextBox)
        Me.Controls.Add(Label2)
        Me.Controls.Add(Me.ModelosComboBox)
        Me.Controls.Add(Me.FincasListBox)
        Me.Controls.Add(Me.BindingNavigator)
        Me.Controls.Add(ImporteLabel)
        Me.Controls.Add(Me.ImporteTextBox)
        Me.Controls.Add(FacturaLabel)
        Me.Controls.Add(Me.FacturaTextBox)
        Me.Controls.Add(Label1)
        Me.Controls.Add(Me.GruposComboBox)
        Me.Controls.Add(ConceptoLabel)
        Me.Controls.Add(Me.ConceptoTextBox)
        Me.Controls.Add(Me.FechaDateTimePicker)
        Me.Controls.Add(Me.GastosDataGridView)
        Me.Controls.Add(Me.ProveedorComboBox)
        Me.Controls.Add(ModeloLabel)
        Me.Controls.Add(Me.DestinoComboBox)
        Me.Controls.Add(Me.StatusStrip)
        Me.Name = "GestionGastos"
        Me.Text = "GestionGastos"
        CType(Me.FincasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ModelosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetTablas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GastosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DestinosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProveedoresBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GastosDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GruposBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator.ResumeLayout(False)
        Me.BindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents FincasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents FincasTableAdapter As DatosMsSQL.DataSetTablasTableAdapters.FincasTableAdapter
    Friend WithEvents DataSetTablas As DatosMsSQL.DataSetTablas
    Friend WithEvents DestinoComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents DestinosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents GastosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProveedoresBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProveedorComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents GastosDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents ProveedoresTableAdapter As DatosMsSQL.DataSetTablasTableAdapters.ProveedoresTableAdapter
    Friend WithEvents FechaDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents ConceptoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents GruposBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents GruposComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents GruposTableAdapter As DatosMsSQL.DataSetTablasTableAdapters.GruposTableAdapter
    Friend WithEvents FacturaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ImporteTextBox As System.Windows.Forms.TextBox
    Friend WithEvents BindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents FincasListBox As System.Windows.Forms.ListBox
    Friend WithEvents BindingNavigatorGuardar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ModelosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ModelosComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents ModelosTableAdapter As DatosMsSQL.DataSetTablasTableAdapters.ModelosTableAdapter
    Friend WithEvents GastosPlusTableAdapter As DatosMsSQL.DataSetTablasTableAdapters.GastosPlusTableAdapter
    Friend WithEvents FechaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FacturaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ConceptoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ImporteDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Grupo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Finca As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Modelo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EjercicioComboBox As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents PresentarGastos As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents ProveedorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DestinoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TodosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ImporteSumTextBox As System.Windows.Forms.TextBox
End Class
