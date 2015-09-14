<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Fincas
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Fincas))
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.DataSetTablas = New DatosMsSQL.DataSetTablas()
        Me.FincasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ModelosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FincasTableAdapter = New DatosMsSQL.DataSetTablasTableAdapters.FincasTableAdapter()
        Me.PropietariosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ModelosListBox = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ModelosTableAdapter = New DatosMsSQL.DataSetTablasTableAdapters.ModelosTableAdapter()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IdentificacionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MetrosDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.NumComTextbox = New System.Windows.Forms.TextBox()
        Me.SumComTextbox = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.NumModTextBox = New System.Windows.Forms.TextBox()
        Me.SumModTextbox = New System.Windows.Forms.TextBox()
        Me.PropietariosComboBox = New System.Windows.Forms.ComboBox()
        Me.BindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.PropietariosTableAdapter = New DatosMsSQL.DataSetTablasTableAdapters.PropietariosTableAdapter()
        CType(Me.DataSetTablas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FincasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ModelosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PropietariosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.BindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatusStrip
        '
        Me.StatusStrip.Location = New System.Drawing.Point(0, 339)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Size = New System.Drawing.Size(624, 22)
        Me.StatusStrip.TabIndex = 0
        Me.StatusStrip.Text = "StatusStrip"
        '
        'DataSetTablas
        '
        Me.DataSetTablas.DataSetName = "DataSetTablas"
        Me.DataSetTablas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'FincasBindingSource
        '
        Me.FincasBindingSource.DataMember = "FK_Fincas_Modelos"
        Me.FincasBindingSource.DataSource = Me.ModelosBindingSource
        Me.FincasBindingSource.Sort = "Identificacion ASC"
        '
        'ModelosBindingSource
        '
        Me.ModelosBindingSource.DataMember = "Modelos"
        Me.ModelosBindingSource.DataSource = Me.DataSetTablas
        Me.ModelosBindingSource.Sort = "Modelo"
        '
        'FincasTableAdapter
        '
        Me.FincasTableAdapter.ClearBeforeFill = True
        '
        'PropietariosBindingSource
        '
        Me.PropietariosBindingSource.DataMember = "Propietarios"
        Me.PropietariosBindingSource.DataSource = Me.DataSetTablas
        Me.PropietariosBindingSource.Sort = "Nombre_Completo"
        '
        'ModelosListBox
        '
        Me.ModelosListBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ModelosListBox.DataSource = Me.ModelosBindingSource
        Me.ModelosListBox.DisplayMember = "Modelo"
        Me.ModelosListBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ModelosListBox.FormattingEnabled = True
        Me.ModelosListBox.ItemHeight = 16
        Me.ModelosListBox.Location = New System.Drawing.Point(0, 18)
        Me.ModelosListBox.Name = "ModelosListBox"
        Me.ModelosListBox.Size = New System.Drawing.Size(137, 180)
        Me.ModelosListBox.TabIndex = 1
        Me.ModelosListBox.ValueMember = "Id"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(68, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Propietario:"
        '
        'ModelosTableAdapter
        '
        Me.ModelosTableAdapter.ClearBeforeFill = True
        '
        'DataGridView1
        '
        Me.DataGridView1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.AutoGenerateColumns = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdentificacionDataGridViewTextBoxColumn, Me.MetrosDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.FincasBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(134, 64)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(212, 201)
        Me.DataGridView1.TabIndex = 3
        '
        'IdentificacionDataGridViewTextBoxColumn
        '
        Me.IdentificacionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.IdentificacionDataGridViewTextBoxColumn.DataPropertyName = "Identificacion"
        Me.IdentificacionDataGridViewTextBoxColumn.HeaderText = "Finca"
        Me.IdentificacionDataGridViewTextBoxColumn.Name = "IdentificacionDataGridViewTextBoxColumn"
        '
        'MetrosDataGridViewTextBoxColumn
        '
        Me.MetrosDataGridViewTextBoxColumn.DataPropertyName = "Metros"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.Format = "N2"
        Me.MetrosDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle2
        Me.MetrosDataGridViewTextBoxColumn.HeaderText = "Metros"
        Me.MetrosDataGridViewTextBoxColumn.Name = "MetrosDataGridViewTextBoxColumn"
        Me.MetrosDataGridViewTextBoxColumn.Width = 60
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.TextBox1)
        Me.Panel1.Controls.Add(Me.GroupBox2)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.PropietariosComboBox)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.DataGridView1)
        Me.Panel1.Controls.Add(Me.BindingNavigator)
        Me.Panel1.Location = New System.Drawing.Point(145, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(352, 317)
        Me.Panel1.TabIndex = 4
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FincasBindingSource, "Notas", True))
        Me.TextBox1.Location = New System.Drawing.Point(3, 271)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(343, 41)
        Me.TextBox1.TabIndex = 10
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.NumComTextbox)
        Me.GroupBox2.Controls.Add(Me.SumComTextbox)
        Me.GroupBox2.Location = New System.Drawing.Point(2, 182)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(125, 83)
        Me.GroupBox2.TabIndex = 9
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Total Comunidad"
        '
        'NumComTextbox
        '
        Me.NumComTextbox.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.NumComTextbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumComTextbox.Location = New System.Drawing.Point(6, 19)
        Me.NumComTextbox.Multiline = True
        Me.NumComTextbox.Name = "NumComTextbox"
        Me.NumComTextbox.ReadOnly = True
        Me.NumComTextbox.Size = New System.Drawing.Size(113, 26)
        Me.NumComTextbox.TabIndex = 5
        Me.NumComTextbox.Text = "123456"
        Me.NumComTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'SumComTextbox
        '
        Me.SumComTextbox.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.SumComTextbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SumComTextbox.Location = New System.Drawing.Point(6, 51)
        Me.SumComTextbox.Multiline = True
        Me.SumComTextbox.Name = "SumComTextbox"
        Me.SumComTextbox.ReadOnly = True
        Me.SumComTextbox.Size = New System.Drawing.Size(113, 25)
        Me.SumComTextbox.TabIndex = 6
        Me.SumComTextbox.Text = "123456"
        Me.SumComTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.NumModTextBox)
        Me.GroupBox1.Controls.Add(Me.SumModTextbox)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 79)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(125, 83)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Total Modelo"
        '
        'NumModTextBox
        '
        Me.NumModTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.NumModTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumModTextBox.Location = New System.Drawing.Point(6, 19)
        Me.NumModTextBox.Multiline = True
        Me.NumModTextBox.Name = "NumModTextBox"
        Me.NumModTextBox.ReadOnly = True
        Me.NumModTextBox.Size = New System.Drawing.Size(113, 26)
        Me.NumModTextBox.TabIndex = 5
        Me.NumModTextBox.Text = "123456"
        Me.NumModTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'SumModTextbox
        '
        Me.SumModTextbox.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.SumModTextbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SumModTextbox.Location = New System.Drawing.Point(6, 51)
        Me.SumModTextbox.Multiline = True
        Me.SumModTextbox.Name = "SumModTextbox"
        Me.SumModTextbox.ReadOnly = True
        Me.SumModTextbox.Size = New System.Drawing.Size(113, 25)
        Me.SumModTextbox.TabIndex = 6
        Me.SumModTextbox.Text = "123456"
        Me.SumModTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PropietariosComboBox
        '
        Me.PropietariosComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.FincasBindingSource, "Propietario", True))
        Me.PropietariosComboBox.DataSource = Me.PropietariosBindingSource
        Me.PropietariosComboBox.DisplayMember = "Nombre_Completo"
        Me.PropietariosComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PropietariosComboBox.FormattingEnabled = True
        Me.PropietariosComboBox.Location = New System.Drawing.Point(134, 34)
        Me.PropietariosComboBox.Name = "PropietariosComboBox"
        Me.PropietariosComboBox.Size = New System.Drawing.Size(212, 24)
        Me.PropietariosComboBox.TabIndex = 4
        Me.PropietariosComboBox.ValueMember = "ID"
        '
        'BindingNavigator
        '
        Me.BindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.BindingNavigator.BindingSource = Me.FincasBindingSource
        Me.BindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.BindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.BindingNavigator.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.BindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.BindingNavigatorGuardar, Me.BindingNavigatorDeshacer})
        Me.BindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.BindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.BindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.BindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.BindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.BindingNavigator.Name = "BindingNavigator"
        Me.BindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.BindingNavigator.Size = New System.Drawing.Size(350, 31)
        Me.BindingNavigator.TabIndex = 4
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
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(34, 23)
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
        Me.BindingNavigatorGuardar.Text = "Guardar"
        Me.BindingNavigatorGuardar.ToolTipText = "Guardar Cambios"
        '
        'BindingNavigatorDeshacer
        '
        Me.BindingNavigatorDeshacer.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeshacer.Image = Global.CovetorWin.My.Resources.Resources.Deshacer
        Me.BindingNavigatorDeshacer.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BindingNavigatorDeshacer.Name = "BindingNavigatorDeshacer"
        Me.BindingNavigatorDeshacer.Size = New System.Drawing.Size(28, 28)
        Me.BindingNavigatorDeshacer.Text = "Deshacer"
        Me.BindingNavigatorDeshacer.ToolTipText = "Deshacer Cambios"
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PictureBox1.Image = Global.CovetorWin.My.Resources.Resources.Piso
        Me.PictureBox1.Location = New System.Drawing.Point(0, 204)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(137, 111)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Controls.Add(Me.ModelosListBox)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Location = New System.Drawing.Point(3, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(139, 317)
        Me.Panel2.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label2.Font = New System.Drawing.Font("Microsoft Tai Le", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(0, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(137, 18)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Modelos"
        '
        'Panel3
        '
        Me.Panel3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.Panel3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Panel3.Controls.Add(Me.Panel1)
        Me.Panel3.Controls.Add(Me.Panel2)
        Me.Panel3.Location = New System.Drawing.Point(62, 12)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(503, 324)
        Me.Panel3.TabIndex = 6
        '
        'PropietariosTableAdapter
        '
        Me.PropietariosTableAdapter.ClearBeforeFill = True
        '
        'Fincas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(624, 361)
        Me.Controls.Add(Me.StatusStrip)
        Me.Controls.Add(Me.Panel3)
        Me.MinimumSize = New System.Drawing.Size(640, 400)
        Me.Name = "Fincas"
        Me.Text = "Fincas"
        CType(Me.DataSetTablas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FincasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ModelosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PropietariosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.BindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator.ResumeLayout(False)
        Me.BindingNavigator.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents DataSetTablas As DatosMsSQL.DataSetTablas
    Friend WithEvents FincasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents FincasTableAdapter As DatosMsSQL.DataSetTablasTableAdapters.FincasTableAdapter
    Friend WithEvents ModelosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PropietariosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ModelosListBox As System.Windows.Forms.ListBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ModelosTableAdapter As DatosMsSQL.DataSetTablasTableAdapters.ModelosTableAdapter
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
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
    Friend WithEvents BindingNavigatorGuardar As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorDeshacer As System.Windows.Forms.ToolStripButton
    Friend WithEvents PropietariosComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents SumModTextbox As System.Windows.Forms.TextBox
    Friend WithEvents NumModTextBox As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents NumComTextbox As System.Windows.Forms.TextBox
    Friend WithEvents SumComTextbox As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents IdentificacionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MetrosDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents PropietariosTableAdapter As DatosMsSQL.DataSetTablasTableAdapters.PropietariosTableAdapter
End Class
