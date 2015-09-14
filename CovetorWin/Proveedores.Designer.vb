<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Proveedores
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
        Dim NotasLabel As System.Windows.Forms.Label
        Dim EMailLabel As System.Windows.Forms.Label
        Dim CCCLabel As System.Windows.Forms.Label
        Dim MovilLabel As System.Windows.Forms.Label
        Dim TelefonoLabel As System.Windows.Forms.Label
        Dim NIFLabel As System.Windows.Forms.Label
        Dim PoblacionLabel As System.Windows.Forms.Label
        Dim CPLabel As System.Windows.Forms.Label
        Dim DomiciioLabel As System.Windows.Forms.Label
        Dim ApellidosLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Proveedores))
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.NotasTextBox = New System.Windows.Forms.TextBox()
        Me.PropietarioGroupBox = New System.Windows.Forms.GroupBox()
        Me.EMailTextBox = New System.Windows.Forms.TextBox()
        Me.ProveedoresBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSetTablas = New DatosMsSQL.DataSetTablas()
        Me.CCCTextBox = New System.Windows.Forms.TextBox()
        Me.MovilTextBox = New System.Windows.Forms.TextBox()
        Me.TelefonoTextBox = New System.Windows.Forms.TextBox()
        Me.NIFTextBox = New System.Windows.Forms.TextBox()
        Me.PoblacionTextBox = New System.Windows.Forms.TextBox()
        Me.CPTextBox = New System.Windows.Forms.TextBox()
        Me.DomiciioTextBox = New System.Windows.Forms.TextBox()
        Me.RazonSocialTextBox = New System.Windows.Forms.TextBox()
        Me.ImagenPictureBox = New System.Windows.Forms.PictureBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.RazonSocialDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EMailDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TelefonoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MovilDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.FechaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FacturaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ImporteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GastosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProveedoresBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorGuardar = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeshacer = New System.Windows.Forms.ToolStripButton()
        Me.ProveedoresTableAdapter = New DatosMsSQL.DataSetTablasTableAdapters.ProveedoresTableAdapter()
        Me.GastosTableAdapter = New DatosMsSQL.DataSetTablasTableAdapters.GastosTableAdapter()
        Me.OpenFileDialog = New System.Windows.Forms.OpenFileDialog()
        NotasLabel = New System.Windows.Forms.Label()
        EMailLabel = New System.Windows.Forms.Label()
        CCCLabel = New System.Windows.Forms.Label()
        MovilLabel = New System.Windows.Forms.Label()
        TelefonoLabel = New System.Windows.Forms.Label()
        NIFLabel = New System.Windows.Forms.Label()
        PoblacionLabel = New System.Windows.Forms.Label()
        CPLabel = New System.Windows.Forms.Label()
        DomiciioLabel = New System.Windows.Forms.Label()
        ApellidosLabel = New System.Windows.Forms.Label()
        Me.PropietarioGroupBox.SuspendLayout()
        CType(Me.ProveedoresBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetTablas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImagenPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GastosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProveedoresBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ProveedoresBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'NotasLabel
        '
        NotasLabel.AutoSize = True
        NotasLabel.Location = New System.Drawing.Point(12, 81)
        NotasLabel.Name = "NotasLabel"
        NotasLabel.Size = New System.Drawing.Size(38, 13)
        NotasLabel.TabIndex = 11
        NotasLabel.Text = "Notas:"
        '
        'EMailLabel
        '
        EMailLabel.AutoSize = True
        EMailLabel.Location = New System.Drawing.Point(43, 152)
        EMailLabel.Name = "EMailLabel"
        EMailLabel.Size = New System.Drawing.Size(36, 13)
        EMailLabel.TabIndex = 18
        EMailLabel.Text = "EMail:"
        '
        'CCCLabel
        '
        CCCLabel.AutoSize = True
        CCCLabel.Location = New System.Drawing.Point(165, 100)
        CCCLabel.Name = "CCCLabel"
        CCCLabel.Size = New System.Drawing.Size(31, 13)
        CCCLabel.TabIndex = 16
        CCCLabel.Text = "CCC:"
        '
        'MovilLabel
        '
        MovilLabel.AutoSize = True
        MovilLabel.Location = New System.Drawing.Point(213, 126)
        MovilLabel.Name = "MovilLabel"
        MovilLabel.Size = New System.Drawing.Size(35, 13)
        MovilLabel.TabIndex = 14
        MovilLabel.Text = "Movil:"
        '
        'TelefonoLabel
        '
        TelefonoLabel.AutoSize = True
        TelefonoLabel.Location = New System.Drawing.Point(27, 126)
        TelefonoLabel.Name = "TelefonoLabel"
        TelefonoLabel.Size = New System.Drawing.Size(52, 13)
        TelefonoLabel.TabIndex = 12
        TelefonoLabel.Text = "Telefono:"
        '
        'NIFLabel
        '
        NIFLabel.AutoSize = True
        NIFLabel.Location = New System.Drawing.Point(43, 100)
        NIFLabel.Name = "NIFLabel"
        NIFLabel.Size = New System.Drawing.Size(36, 13)
        NIFLabel.TabIndex = 10
        NIFLabel.Text = "N.I.F.:"
        '
        'PoblacionLabel
        '
        PoblacionLabel.AutoSize = True
        PoblacionLabel.Location = New System.Drawing.Point(139, 74)
        PoblacionLabel.Name = "PoblacionLabel"
        PoblacionLabel.Size = New System.Drawing.Size(57, 13)
        PoblacionLabel.TabIndex = 8
        PoblacionLabel.Text = "Poblacion:"
        '
        'CPLabel
        '
        CPLabel.AutoSize = True
        CPLabel.Location = New System.Drawing.Point(55, 74)
        CPLabel.Name = "CPLabel"
        CPLabel.Size = New System.Drawing.Size(24, 13)
        CPLabel.TabIndex = 6
        CPLabel.Text = "CP:"
        '
        'DomiciioLabel
        '
        DomiciioLabel.AutoSize = True
        DomiciioLabel.Location = New System.Drawing.Point(29, 48)
        DomiciioLabel.Name = "DomiciioLabel"
        DomiciioLabel.Size = New System.Drawing.Size(50, 13)
        DomiciioLabel.TabIndex = 4
        DomiciioLabel.Text = "Domiciio:"
        '
        'ApellidosLabel
        '
        ApellidosLabel.AutoSize = True
        ApellidosLabel.Location = New System.Drawing.Point(6, 24)
        ApellidosLabel.Name = "ApellidosLabel"
        ApellidosLabel.Size = New System.Drawing.Size(73, 13)
        ApellidosLabel.TabIndex = 2
        ApellidosLabel.Text = "Razón Social:"
        '
        'StatusStrip
        '
        Me.StatusStrip.Location = New System.Drawing.Point(0, 379)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Size = New System.Drawing.Size(661, 22)
        Me.StatusStrip.TabIndex = 0
        Me.StatusStrip.Text = "StatusStrip"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(271, 39)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Gestión de Proveedores"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'NotasTextBox
        '
        Me.NotasTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProveedoresBindingSource, "Notas", True))
        Me.NotasTextBox.Location = New System.Drawing.Point(12, 97)
        Me.NotasTextBox.Multiline = True
        Me.NotasTextBox.Name = "NotasTextBox"
        Me.NotasTextBox.Size = New System.Drawing.Size(168, 114)
        Me.NotasTextBox.TabIndex = 12
        '
        'PropietarioGroupBox
        '
        Me.PropietarioGroupBox.Controls.Add(EMailLabel)
        Me.PropietarioGroupBox.Controls.Add(Me.EMailTextBox)
        Me.PropietarioGroupBox.Controls.Add(CCCLabel)
        Me.PropietarioGroupBox.Controls.Add(Me.CCCTextBox)
        Me.PropietarioGroupBox.Controls.Add(MovilLabel)
        Me.PropietarioGroupBox.Controls.Add(Me.MovilTextBox)
        Me.PropietarioGroupBox.Controls.Add(TelefonoLabel)
        Me.PropietarioGroupBox.Controls.Add(Me.TelefonoTextBox)
        Me.PropietarioGroupBox.Controls.Add(NIFLabel)
        Me.PropietarioGroupBox.Controls.Add(Me.NIFTextBox)
        Me.PropietarioGroupBox.Controls.Add(PoblacionLabel)
        Me.PropietarioGroupBox.Controls.Add(Me.PoblacionTextBox)
        Me.PropietarioGroupBox.Controls.Add(CPLabel)
        Me.PropietarioGroupBox.Controls.Add(Me.CPTextBox)
        Me.PropietarioGroupBox.Controls.Add(DomiciioLabel)
        Me.PropietarioGroupBox.Controls.Add(Me.DomiciioTextBox)
        Me.PropietarioGroupBox.Controls.Add(ApellidosLabel)
        Me.PropietarioGroupBox.Controls.Add(Me.RazonSocialTextBox)
        Me.PropietarioGroupBox.Location = New System.Drawing.Point(289, 36)
        Me.PropietarioGroupBox.Name = "PropietarioGroupBox"
        Me.PropietarioGroupBox.Size = New System.Drawing.Size(360, 175)
        Me.PropietarioGroupBox.TabIndex = 10
        Me.PropietarioGroupBox.TabStop = False
        Me.PropietarioGroupBox.Text = "Detalle"
        '
        'EMailTextBox
        '
        Me.EMailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProveedoresBindingSource, "EMail", True))
        Me.EMailTextBox.Location = New System.Drawing.Point(85, 149)
        Me.EMailTextBox.Name = "EMailTextBox"
        Me.EMailTextBox.Size = New System.Drawing.Size(269, 20)
        Me.EMailTextBox.TabIndex = 19
        Me.EMailTextBox.Text = "mtorrellas@live.com"
        '
        'ProveedoresBindingSource
        '
        Me.ProveedoresBindingSource.DataMember = "Proveedores"
        Me.ProveedoresBindingSource.DataSource = Me.DataSetTablas
        Me.ProveedoresBindingSource.Sort = "RazonSocial"
        '
        'DataSetTablas
        '
        Me.DataSetTablas.DataSetName = "DataSetTablas"
        Me.DataSetTablas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CCCTextBox
        '
        Me.CCCTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProveedoresBindingSource, "CCC", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "#### #### ## ##########"))
        Me.CCCTextBox.Location = New System.Drawing.Point(202, 97)
        Me.CCCTextBox.Name = "CCCTextBox"
        Me.CCCTextBox.Size = New System.Drawing.Size(152, 20)
        Me.CCCTextBox.TabIndex = 17
        Me.CCCTextBox.Text = "20851119550123456789"
        '
        'MovilTextBox
        '
        Me.MovilTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProveedoresBindingSource, "Movil", True))
        Me.MovilTextBox.Location = New System.Drawing.Point(280, 123)
        Me.MovilTextBox.Name = "MovilTextBox"
        Me.MovilTextBox.Size = New System.Drawing.Size(74, 20)
        Me.MovilTextBox.TabIndex = 15
        Me.MovilTextBox.Text = "610316131"
        '
        'TelefonoTextBox
        '
        Me.TelefonoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProveedoresBindingSource, "Telefono", True))
        Me.TelefonoTextBox.Location = New System.Drawing.Point(85, 123)
        Me.TelefonoTextBox.Name = "TelefonoTextBox"
        Me.TelefonoTextBox.Size = New System.Drawing.Size(74, 20)
        Me.TelefonoTextBox.TabIndex = 13
        Me.TelefonoTextBox.Text = "976642728"
        '
        'NIFTextBox
        '
        Me.NIFTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProveedoresBindingSource, "NIF", True))
        Me.NIFTextBox.Location = New System.Drawing.Point(85, 97)
        Me.NIFTextBox.Name = "NIFTextBox"
        Me.NIFTextBox.Size = New System.Drawing.Size(74, 20)
        Me.NIFTextBox.TabIndex = 11
        Me.NIFTextBox.Text = "73074210J"
        '
        'PoblacionTextBox
        '
        Me.PoblacionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProveedoresBindingSource, "Poblacion", True))
        Me.PoblacionTextBox.Location = New System.Drawing.Point(202, 71)
        Me.PoblacionTextBox.Name = "PoblacionTextBox"
        Me.PoblacionTextBox.Size = New System.Drawing.Size(152, 20)
        Me.PoblacionTextBox.TabIndex = 9
        Me.PoblacionTextBox.Text = "TARAZONA (Zaragoza)"
        '
        'CPTextBox
        '
        Me.CPTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProveedoresBindingSource, "CP", True))
        Me.CPTextBox.Location = New System.Drawing.Point(85, 71)
        Me.CPTextBox.Name = "CPTextBox"
        Me.CPTextBox.Size = New System.Drawing.Size(46, 20)
        Me.CPTextBox.TabIndex = 7
        Me.CPTextBox.Text = "50500"
        '
        'DomiciioTextBox
        '
        Me.DomiciioTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProveedoresBindingSource, "Domiciio", True))
        Me.DomiciioTextBox.Location = New System.Drawing.Point(85, 45)
        Me.DomiciioTextBox.Name = "DomiciioTextBox"
        Me.DomiciioTextBox.Size = New System.Drawing.Size(269, 20)
        Me.DomiciioTextBox.TabIndex = 5
        Me.DomiciioTextBox.Text = "Avda. de La Paz, 6-P5-3ºª"
        '
        'RazonSocialTextBox
        '
        Me.RazonSocialTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProveedoresBindingSource, "RazonSocial", True))
        Me.RazonSocialTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RazonSocialTextBox.Location = New System.Drawing.Point(85, 19)
        Me.RazonSocialTextBox.Name = "RazonSocialTextBox"
        Me.RazonSocialTextBox.Size = New System.Drawing.Size(269, 21)
        Me.RazonSocialTextBox.TabIndex = 3
        Me.RazonSocialTextBox.Text = "Razon Social del Proveedor"
        '
        'ImagenPictureBox
        '
        Me.ImagenPictureBox.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.ImagenPictureBox.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ImagenPictureBox.DataBindings.Add(New System.Windows.Forms.Binding("Image", Me.ProveedoresBindingSource, "Imagen", True))
        Me.ImagenPictureBox.Location = New System.Drawing.Point(186, 81)
        Me.ImagenPictureBox.Name = "ImagenPictureBox"
        Me.ImagenPictureBox.Size = New System.Drawing.Size(98, 130)
        Me.ImagenPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ImagenPictureBox.TabIndex = 9
        Me.ImagenPictureBox.TabStop = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.RazonSocialDataGridViewTextBoxColumn, Me.EMailDataGridViewTextBoxColumn, Me.TelefonoDataGridViewTextBoxColumn, Me.MovilDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.ProveedoresBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(12, 218)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(436, 158)
        Me.DataGridView1.TabIndex = 14
        '
        'RazonSocialDataGridViewTextBoxColumn
        '
        Me.RazonSocialDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.RazonSocialDataGridViewTextBoxColumn.DataPropertyName = "RazonSocial"
        Me.RazonSocialDataGridViewTextBoxColumn.HeaderText = "RazonSocial"
        Me.RazonSocialDataGridViewTextBoxColumn.Name = "RazonSocialDataGridViewTextBoxColumn"
        '
        'EMailDataGridViewTextBoxColumn
        '
        Me.EMailDataGridViewTextBoxColumn.DataPropertyName = "EMail"
        Me.EMailDataGridViewTextBoxColumn.HeaderText = "EMail"
        Me.EMailDataGridViewTextBoxColumn.Name = "EMailDataGridViewTextBoxColumn"
        Me.EMailDataGridViewTextBoxColumn.Width = 120
        '
        'TelefonoDataGridViewTextBoxColumn
        '
        Me.TelefonoDataGridViewTextBoxColumn.DataPropertyName = "Telefono"
        Me.TelefonoDataGridViewTextBoxColumn.HeaderText = "Telefono"
        Me.TelefonoDataGridViewTextBoxColumn.Name = "TelefonoDataGridViewTextBoxColumn"
        Me.TelefonoDataGridViewTextBoxColumn.Width = 70
        '
        'MovilDataGridViewTextBoxColumn
        '
        Me.MovilDataGridViewTextBoxColumn.DataPropertyName = "Movil"
        Me.MovilDataGridViewTextBoxColumn.HeaderText = "Movil"
        Me.MovilDataGridViewTextBoxColumn.Name = "MovilDataGridViewTextBoxColumn"
        Me.MovilDataGridViewTextBoxColumn.Width = 70
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.AllowUserToDeleteRows = False
        Me.DataGridView2.AllowUserToOrderColumns = True
        Me.DataGridView2.AutoGenerateColumns = False
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.FechaDataGridViewTextBoxColumn, Me.FacturaDataGridViewTextBoxColumn, Me.ImporteDataGridViewTextBoxColumn})
        Me.DataGridView2.DataSource = Me.GastosBindingSource
        Me.DataGridView2.Location = New System.Drawing.Point(457, 218)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.ReadOnly = True
        Me.DataGridView2.Size = New System.Drawing.Size(192, 158)
        Me.DataGridView2.TabIndex = 15
        '
        'FechaDataGridViewTextBoxColumn
        '
        Me.FechaDataGridViewTextBoxColumn.DataPropertyName = "Fecha"
        Me.FechaDataGridViewTextBoxColumn.HeaderText = "Fecha"
        Me.FechaDataGridViewTextBoxColumn.Name = "FechaDataGridViewTextBoxColumn"
        Me.FechaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FacturaDataGridViewTextBoxColumn
        '
        Me.FacturaDataGridViewTextBoxColumn.DataPropertyName = "Factura"
        Me.FacturaDataGridViewTextBoxColumn.HeaderText = "Factura"
        Me.FacturaDataGridViewTextBoxColumn.Name = "FacturaDataGridViewTextBoxColumn"
        Me.FacturaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ImporteDataGridViewTextBoxColumn
        '
        Me.ImporteDataGridViewTextBoxColumn.DataPropertyName = "Importe"
        Me.ImporteDataGridViewTextBoxColumn.HeaderText = "Importe"
        Me.ImporteDataGridViewTextBoxColumn.Name = "ImporteDataGridViewTextBoxColumn"
        Me.ImporteDataGridViewTextBoxColumn.ReadOnly = True
        '
        'GastosBindingSource
        '
        Me.GastosBindingSource.DataMember = "FK_Gastos_Proveedores"
        Me.GastosBindingSource.DataSource = Me.ProveedoresBindingSource
        Me.GastosBindingSource.Sort = "Fecha"
        '
        'ProveedoresBindingNavigator
        '
        Me.ProveedoresBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.ProveedoresBindingNavigator.BindingSource = Me.ProveedoresBindingSource
        Me.ProveedoresBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.ProveedoresBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.ProveedoresBindingNavigator.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.ProveedoresBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.BindingNavigatorGuardar, Me.BindingNavigatorDeshacer})
        Me.ProveedoresBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.ProveedoresBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.ProveedoresBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.ProveedoresBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.ProveedoresBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.ProveedoresBindingNavigator.Name = "ProveedoresBindingNavigator"
        Me.ProveedoresBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.ProveedoresBindingNavigator.Size = New System.Drawing.Size(661, 31)
        Me.ProveedoresBindingNavigator.TabIndex = 16
        Me.ProveedoresBindingNavigator.Text = "BindingNavigator1"
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
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
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
        Me.BindingNavigatorGuardar.Text = "ToolStripButton1"
        '
        'BindingNavigatorDeshacer
        '
        Me.BindingNavigatorDeshacer.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeshacer.Image = Global.CovetorWin.My.Resources.Resources.Deshacer
        Me.BindingNavigatorDeshacer.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BindingNavigatorDeshacer.Name = "BindingNavigatorDeshacer"
        Me.BindingNavigatorDeshacer.Size = New System.Drawing.Size(28, 28)
        Me.BindingNavigatorDeshacer.Text = "Dehacer"
        Me.BindingNavigatorDeshacer.ToolTipText = "Dehacer cambios"
        '
        'ProveedoresTableAdapter
        '
        Me.ProveedoresTableAdapter.ClearBeforeFill = True
        '
        'GastosTableAdapter
        '
        Me.GastosTableAdapter.ClearBeforeFill = True
        '
        'OpenFileDialog
        '
        Me.OpenFileDialog.FileName = "OpenFileDialog"
        Me.OpenFileDialog.Filter = "Archivos de Imagen(*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF|Todos Archivos (*.*)|*.* " & _
    ""
        '
        'Proveedores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(661, 401)
        Me.Controls.Add(Me.ProveedoresBindingNavigator)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(NotasLabel)
        Me.Controls.Add(Me.NotasTextBox)
        Me.Controls.Add(Me.PropietarioGroupBox)
        Me.Controls.Add(Me.ImagenPictureBox)
        Me.Controls.Add(Me.StatusStrip)
        Me.Name = "Proveedores"
        Me.Text = "Proveedores"
        Me.PropietarioGroupBox.ResumeLayout(False)
        Me.PropietarioGroupBox.PerformLayout()
        CType(Me.ProveedoresBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetTablas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImagenPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GastosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProveedoresBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ProveedoresBindingNavigator.ResumeLayout(False)
        Me.ProveedoresBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents NotasTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PropietarioGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents EMailTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CCCTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MovilTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TelefonoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NIFTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PoblacionTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CPTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DomiciioTextBox As System.Windows.Forms.TextBox
    Friend WithEvents RazonSocialTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ImagenPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents DataSetTablas As DatosMsSQL.DataSetTablas
    Friend WithEvents ProveedoresBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents RazonSocialDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EMailDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TelefonoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MovilDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FacturaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ImporteDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GastosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProveedoresBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents BindingNavigatorGuardar As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorDeshacer As System.Windows.Forms.ToolStripButton
    Friend WithEvents ProveedoresTableAdapter As DatosMsSQL.DataSetTablasTableAdapters.ProveedoresTableAdapter
    Friend WithEvents GastosTableAdapter As DatosMsSQL.DataSetTablasTableAdapters.GastosTableAdapter
    Friend WithEvents OpenFileDialog As System.Windows.Forms.OpenFileDialog
End Class
