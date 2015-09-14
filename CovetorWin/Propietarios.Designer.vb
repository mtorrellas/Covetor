<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Propietarios
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
        Dim NombreLabel As System.Windows.Forms.Label
        Dim ApellidosLabel As System.Windows.Forms.Label
        Dim DomiciioLabel As System.Windows.Forms.Label
        Dim CPLabel As System.Windows.Forms.Label
        Dim PoblacionLabel As System.Windows.Forms.Label
        Dim DNILabel As System.Windows.Forms.Label
        Dim TelefonoLabel As System.Windows.Forms.Label
        Dim MovilLabel As System.Windows.Forms.Label
        Dim CCCLabel As System.Windows.Forms.Label
        Dim EMailLabel As System.Windows.Forms.Label
        Dim NotasLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Propietarios))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.DataSetTablas = New DatosMsSQL.DataSetTablas()
        Me.PropietariosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PropietariosBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.PropietariosBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.PropietariosDataGridView = New System.Windows.Forms.DataGridView()
        Me.ImagenPictureBox = New System.Windows.Forms.PictureBox()
        Me.PropietarioGroupBox = New System.Windows.Forms.GroupBox()
        Me.EMailTextBox = New System.Windows.Forms.TextBox()
        Me.CCCTextBox = New System.Windows.Forms.TextBox()
        Me.MovilTextBox = New System.Windows.Forms.TextBox()
        Me.TelefonoTextBox = New System.Windows.Forms.TextBox()
        Me.DNITextBox = New System.Windows.Forms.TextBox()
        Me.PoblacionTextBox = New System.Windows.Forms.TextBox()
        Me.CPTextBox = New System.Windows.Forms.TextBox()
        Me.DomiciioTextBox = New System.Windows.Forms.TextBox()
        Me.ApellidosTextBox = New System.Windows.Forms.TextBox()
        Me.NombreTextBox = New System.Windows.Forms.TextBox()
        Me.FincasDataGridView = New System.Windows.Forms.DataGridView()
        Me.FincasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.NotasTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.FincasTableAdapter = New DatosMsSQL.DataSetTablasTableAdapters.FincasTableAdapter()
        Me.PropietariosTableAdapter = New DatosMsSQL.DataSetTablasTableAdapters.PropietariosTableAdapter()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CoeficienteTextBox = New System.Windows.Forms.TextBox()
        Me.TotalMetrosTextBox = New System.Windows.Forms.TextBox()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PropietariosBindingNavigatorRecargar = New System.Windows.Forms.ToolStripButton()
        NombreLabel = New System.Windows.Forms.Label()
        ApellidosLabel = New System.Windows.Forms.Label()
        DomiciioLabel = New System.Windows.Forms.Label()
        CPLabel = New System.Windows.Forms.Label()
        PoblacionLabel = New System.Windows.Forms.Label()
        DNILabel = New System.Windows.Forms.Label()
        TelefonoLabel = New System.Windows.Forms.Label()
        MovilLabel = New System.Windows.Forms.Label()
        CCCLabel = New System.Windows.Forms.Label()
        EMailLabel = New System.Windows.Forms.Label()
        NotasLabel = New System.Windows.Forms.Label()
        CType(Me.DataSetTablas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PropietariosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PropietariosBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PropietariosBindingNavigator.SuspendLayout()
        CType(Me.PropietariosDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImagenPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PropietarioGroupBox.SuspendLayout()
        CType(Me.FincasDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FincasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NombreLabel
        '
        NombreLabel.AutoSize = True
        NombreLabel.Location = New System.Drawing.Point(6, 22)
        NombreLabel.Name = "NombreLabel"
        NombreLabel.Size = New System.Drawing.Size(47, 13)
        NombreLabel.TabIndex = 0
        NombreLabel.Text = "Nombre:"
        '
        'ApellidosLabel
        '
        ApellidosLabel.AutoSize = True
        ApellidosLabel.Location = New System.Drawing.Point(153, 22)
        ApellidosLabel.Name = "ApellidosLabel"
        ApellidosLabel.Size = New System.Drawing.Size(52, 13)
        ApellidosLabel.TabIndex = 2
        ApellidosLabel.Text = "Apellidos:"
        '
        'DomiciioLabel
        '
        DomiciioLabel.AutoSize = True
        DomiciioLabel.Location = New System.Drawing.Point(3, 48)
        DomiciioLabel.Name = "DomiciioLabel"
        DomiciioLabel.Size = New System.Drawing.Size(50, 13)
        DomiciioLabel.TabIndex = 4
        DomiciioLabel.Text = "Domiciio:"
        '
        'CPLabel
        '
        CPLabel.AutoSize = True
        CPLabel.Location = New System.Drawing.Point(29, 74)
        CPLabel.Name = "CPLabel"
        CPLabel.Size = New System.Drawing.Size(24, 13)
        CPLabel.TabIndex = 6
        CPLabel.Text = "CP:"
        '
        'PoblacionLabel
        '
        PoblacionLabel.AutoSize = True
        PoblacionLabel.Location = New System.Drawing.Point(123, 74)
        PoblacionLabel.Name = "PoblacionLabel"
        PoblacionLabel.Size = New System.Drawing.Size(57, 13)
        PoblacionLabel.TabIndex = 8
        PoblacionLabel.Text = "Poblacion:"
        '
        'DNILabel
        '
        DNILabel.AutoSize = True
        DNILabel.Location = New System.Drawing.Point(24, 100)
        DNILabel.Name = "DNILabel"
        DNILabel.Size = New System.Drawing.Size(29, 13)
        DNILabel.TabIndex = 10
        DNILabel.Text = "DNI:"
        '
        'TelefonoLabel
        '
        TelefonoLabel.AutoSize = True
        TelefonoLabel.Location = New System.Drawing.Point(1, 126)
        TelefonoLabel.Name = "TelefonoLabel"
        TelefonoLabel.Size = New System.Drawing.Size(52, 13)
        TelefonoLabel.TabIndex = 12
        TelefonoLabel.Text = "Telefono:"
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
        'CCCLabel
        '
        CCCLabel.AutoSize = True
        CCCLabel.Location = New System.Drawing.Point(165, 100)
        CCCLabel.Name = "CCCLabel"
        CCCLabel.Size = New System.Drawing.Size(31, 13)
        CCCLabel.TabIndex = 16
        CCCLabel.Text = "CCC:"
        '
        'EMailLabel
        '
        EMailLabel.AutoSize = True
        EMailLabel.Location = New System.Drawing.Point(17, 152)
        EMailLabel.Name = "EMailLabel"
        EMailLabel.Size = New System.Drawing.Size(36, 13)
        EMailLabel.TabIndex = 18
        EMailLabel.Text = "EMail:"
        '
        'NotasLabel
        '
        NotasLabel.AutoSize = True
        NotasLabel.Location = New System.Drawing.Point(9, 79)
        NotasLabel.Name = "NotasLabel"
        NotasLabel.Size = New System.Drawing.Size(38, 13)
        NotasLabel.TabIndex = 6
        NotasLabel.Text = "Notas:"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 390)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(661, 22)
        Me.StatusStrip1.TabIndex = 0
        Me.StatusStrip1.Text = "StatusStrip"
        '
        'DataSetTablas
        '
        Me.DataSetTablas.DataSetName = "DataSetTablas"
        Me.DataSetTablas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PropietariosBindingSource
        '
        Me.PropietariosBindingSource.DataMember = "Propietarios"
        Me.PropietariosBindingSource.DataSource = Me.DataSetTablas
        Me.PropietariosBindingSource.Sort = "Nombre_Completo"
        '
        'PropietariosBindingNavigator
        '
        Me.PropietariosBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.PropietariosBindingNavigator.BindingSource = Me.PropietariosBindingSource
        Me.PropietariosBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.PropietariosBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.PropietariosBindingNavigator.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.PropietariosBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.PropietariosBindingNavigatorSaveItem, Me.PropietariosBindingNavigatorRecargar})
        Me.PropietariosBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.PropietariosBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.PropietariosBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.PropietariosBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.PropietariosBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.PropietariosBindingNavigator.Name = "PropietariosBindingNavigator"
        Me.PropietariosBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.PropietariosBindingNavigator.Size = New System.Drawing.Size(661, 31)
        Me.PropietariosBindingNavigator.TabIndex = 1
        Me.PropietariosBindingNavigator.Text = "BindingNavigator"
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
        'PropietariosBindingNavigatorSaveItem
        '
        Me.PropietariosBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.PropietariosBindingNavigatorSaveItem.Image = CType(resources.GetObject("PropietariosBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.PropietariosBindingNavigatorSaveItem.Name = "PropietariosBindingNavigatorSaveItem"
        Me.PropietariosBindingNavigatorSaveItem.Size = New System.Drawing.Size(28, 28)
        Me.PropietariosBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'PropietariosDataGridView
        '
        Me.PropietariosDataGridView.AllowUserToAddRows = False
        Me.PropietariosDataGridView.AllowUserToOrderColumns = True
        Me.PropietariosDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PropietariosDataGridView.AutoGenerateColumns = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.PropietariosDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.PropietariosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PropietariosDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12})
        Me.PropietariosDataGridView.DataSource = Me.PropietariosBindingSource
        Me.PropietariosDataGridView.Location = New System.Drawing.Point(12, 215)
        Me.PropietariosDataGridView.Name = "PropietariosDataGridView"
        Me.PropietariosDataGridView.Size = New System.Drawing.Size(468, 166)
        Me.PropietariosDataGridView.TabIndex = 2
        '
        'ImagenPictureBox
        '
        Me.ImagenPictureBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ImagenPictureBox.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.ImagenPictureBox.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ImagenPictureBox.DataBindings.Add(New System.Windows.Forms.Binding("Image", Me.PropietariosBindingSource, "Imagen", True))
        Me.ImagenPictureBox.Location = New System.Drawing.Point(186, 79)
        Me.ImagenPictureBox.Name = "ImagenPictureBox"
        Me.ImagenPictureBox.Size = New System.Drawing.Size(98, 130)
        Me.ImagenPictureBox.TabIndex = 4
        Me.ImagenPictureBox.TabStop = False
        '
        'PropietarioGroupBox
        '
        Me.PropietarioGroupBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PropietarioGroupBox.Controls.Add(EMailLabel)
        Me.PropietarioGroupBox.Controls.Add(Me.EMailTextBox)
        Me.PropietarioGroupBox.Controls.Add(CCCLabel)
        Me.PropietarioGroupBox.Controls.Add(Me.CCCTextBox)
        Me.PropietarioGroupBox.Controls.Add(MovilLabel)
        Me.PropietarioGroupBox.Controls.Add(Me.MovilTextBox)
        Me.PropietarioGroupBox.Controls.Add(TelefonoLabel)
        Me.PropietarioGroupBox.Controls.Add(Me.TelefonoTextBox)
        Me.PropietarioGroupBox.Controls.Add(DNILabel)
        Me.PropietarioGroupBox.Controls.Add(Me.DNITextBox)
        Me.PropietarioGroupBox.Controls.Add(PoblacionLabel)
        Me.PropietarioGroupBox.Controls.Add(Me.PoblacionTextBox)
        Me.PropietarioGroupBox.Controls.Add(CPLabel)
        Me.PropietarioGroupBox.Controls.Add(Me.CPTextBox)
        Me.PropietarioGroupBox.Controls.Add(DomiciioLabel)
        Me.PropietarioGroupBox.Controls.Add(Me.DomiciioTextBox)
        Me.PropietarioGroupBox.Controls.Add(ApellidosLabel)
        Me.PropietarioGroupBox.Controls.Add(Me.ApellidosTextBox)
        Me.PropietarioGroupBox.Controls.Add(NombreLabel)
        Me.PropietarioGroupBox.Controls.Add(Me.NombreTextBox)
        Me.PropietarioGroupBox.Location = New System.Drawing.Point(289, 34)
        Me.PropietarioGroupBox.Name = "PropietarioGroupBox"
        Me.PropietarioGroupBox.Size = New System.Drawing.Size(360, 175)
        Me.PropietarioGroupBox.TabIndex = 5
        Me.PropietarioGroupBox.TabStop = False
        Me.PropietarioGroupBox.Text = "Detalle"
        '
        'EMailTextBox
        '
        Me.EMailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PropietariosBindingSource, "EMail", True))
        Me.EMailTextBox.Location = New System.Drawing.Point(59, 149)
        Me.EMailTextBox.Name = "EMailTextBox"
        Me.EMailTextBox.Size = New System.Drawing.Size(295, 20)
        Me.EMailTextBox.TabIndex = 19
        Me.EMailTextBox.Text = "mtorrellas@live.com"
        '
        'CCCTextBox
        '
        Me.CCCTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PropietariosBindingSource, "CCC", True))
        Me.CCCTextBox.Location = New System.Drawing.Point(202, 97)
        Me.CCCTextBox.Name = "CCCTextBox"
        Me.CCCTextBox.Size = New System.Drawing.Size(152, 20)
        Me.CCCTextBox.TabIndex = 17
        Me.CCCTextBox.Text = "20851119550123456789"
        '
        'MovilTextBox
        '
        Me.MovilTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PropietariosBindingSource, "Movil", True))
        Me.MovilTextBox.Location = New System.Drawing.Point(254, 123)
        Me.MovilTextBox.Name = "MovilTextBox"
        Me.MovilTextBox.Size = New System.Drawing.Size(100, 20)
        Me.MovilTextBox.TabIndex = 15
        Me.MovilTextBox.Text = "610316131"
        '
        'TelefonoTextBox
        '
        Me.TelefonoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PropietariosBindingSource, "Telefono", True))
        Me.TelefonoTextBox.Location = New System.Drawing.Point(59, 123)
        Me.TelefonoTextBox.Name = "TelefonoTextBox"
        Me.TelefonoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.TelefonoTextBox.TabIndex = 13
        Me.TelefonoTextBox.Text = "976642728"
        '
        'DNITextBox
        '
        Me.DNITextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PropietariosBindingSource, "DNI", True))
        Me.DNITextBox.Location = New System.Drawing.Point(59, 97)
        Me.DNITextBox.Name = "DNITextBox"
        Me.DNITextBox.Size = New System.Drawing.Size(100, 20)
        Me.DNITextBox.TabIndex = 11
        Me.DNITextBox.Text = "73074210J"
        '
        'PoblacionTextBox
        '
        Me.PoblacionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PropietariosBindingSource, "Poblacion", True))
        Me.PoblacionTextBox.Location = New System.Drawing.Point(186, 71)
        Me.PoblacionTextBox.Name = "PoblacionTextBox"
        Me.PoblacionTextBox.Size = New System.Drawing.Size(168, 20)
        Me.PoblacionTextBox.TabIndex = 9
        Me.PoblacionTextBox.Text = "TARAZONA (Zaragoza)"
        '
        'CPTextBox
        '
        Me.CPTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PropietariosBindingSource, "CP", True))
        Me.CPTextBox.Location = New System.Drawing.Point(59, 71)
        Me.CPTextBox.Name = "CPTextBox"
        Me.CPTextBox.Size = New System.Drawing.Size(58, 20)
        Me.CPTextBox.TabIndex = 7
        Me.CPTextBox.Text = "50500"
        '
        'DomiciioTextBox
        '
        Me.DomiciioTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PropietariosBindingSource, "Domiciio", True))
        Me.DomiciioTextBox.Location = New System.Drawing.Point(59, 45)
        Me.DomiciioTextBox.Name = "DomiciioTextBox"
        Me.DomiciioTextBox.Size = New System.Drawing.Size(295, 20)
        Me.DomiciioTextBox.TabIndex = 5
        Me.DomiciioTextBox.Text = "Avda. de La Paz, 6-P5-3ºª"
        '
        'ApellidosTextBox
        '
        Me.ApellidosTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PropietariosBindingSource, "Apellidos", True))
        Me.ApellidosTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ApellidosTextBox.Location = New System.Drawing.Point(211, 19)
        Me.ApellidosTextBox.Name = "ApellidosTextBox"
        Me.ApellidosTextBox.Size = New System.Drawing.Size(143, 21)
        Me.ApellidosTextBox.TabIndex = 3
        Me.ApellidosTextBox.Text = "Torrellas Delgado"
        '
        'NombreTextBox
        '
        Me.NombreTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PropietariosBindingSource, "Nombre", True))
        Me.NombreTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NombreTextBox.Location = New System.Drawing.Point(59, 19)
        Me.NombreTextBox.Name = "NombreTextBox"
        Me.NombreTextBox.Size = New System.Drawing.Size(88, 21)
        Me.NombreTextBox.TabIndex = 1
        Me.NombreTextBox.Text = "Miguel Angel"
        '
        'FincasDataGridView
        '
        Me.FincasDataGridView.AllowUserToAddRows = False
        Me.FincasDataGridView.AllowUserToDeleteRows = False
        Me.FincasDataGridView.AllowUserToOrderColumns = True
        Me.FincasDataGridView.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FincasDataGridView.AutoGenerateColumns = False
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.FincasDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.FincasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.FincasDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        Me.FincasDataGridView.DataSource = Me.FincasBindingSource
        Me.FincasDataGridView.Location = New System.Drawing.Point(486, 215)
        Me.FincasDataGridView.Name = "FincasDataGridView"
        Me.FincasDataGridView.ReadOnly = True
        Me.FincasDataGridView.Size = New System.Drawing.Size(163, 134)
        Me.FincasDataGridView.TabIndex = 5
        '
        'FincasBindingSource
        '
        Me.FincasBindingSource.DataMember = "FK_Fincas_Propietarios"
        Me.FincasBindingSource.DataSource = Me.PropietariosBindingSource
        Me.FincasBindingSource.Sort = "Identificacion"
        '
        'NotasTextBox
        '
        Me.NotasTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NotasTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PropietariosBindingSource, "Notas", True))
        Me.NotasTextBox.Location = New System.Drawing.Point(12, 95)
        Me.NotasTextBox.Multiline = True
        Me.NotasTextBox.Name = "NotasTextBox"
        Me.NotasTextBox.Size = New System.Drawing.Size(168, 114)
        Me.NotasTextBox.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(0, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(283, 39)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Gestión de los Propietarios"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FincasTableAdapter
        '
        Me.FincasTableAdapter.ClearBeforeFill = True
        '
        'PropietariosTableAdapter
        '
        Me.PropietariosTableAdapter.ClearBeforeFill = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Identificacion"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Finca"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Metros"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.Format = "N2"
        DataGridViewCellStyle4.Padding = New System.Windows.Forms.Padding(0, 0, 5, 0)
        Me.DataGridViewTextBoxColumn6.DefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridViewTextBoxColumn6.HeaderText = "M²"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Width = 60
        '
        'CoeficienteTextBox
        '
        Me.CoeficienteTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CoeficienteTextBox.BackColor = System.Drawing.Color.Bisque
        Me.CoeficienteTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CoeficienteTextBox.Location = New System.Drawing.Point(486, 355)
        Me.CoeficienteTextBox.Name = "CoeficienteTextBox"
        Me.CoeficienteTextBox.Size = New System.Drawing.Size(78, 26)
        Me.CoeficienteTextBox.TabIndex = 9
        Me.CoeficienteTextBox.Text = "0,251 %"
        Me.CoeficienteTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TotalMetrosTextBox
        '
        Me.TotalMetrosTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TotalMetrosTextBox.BackColor = System.Drawing.Color.Bisque
        Me.TotalMetrosTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalMetrosTextBox.Location = New System.Drawing.Point(571, 355)
        Me.TotalMetrosTextBox.Name = "TotalMetrosTextBox"
        Me.TotalMetrosTextBox.Size = New System.Drawing.Size(78, 26)
        Me.TotalMetrosTextBox.TabIndex = 10
        Me.TotalMetrosTextBox.Text = "1.523 m²"
        Me.TotalMetrosTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Nombre_Completo"
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.DataGridViewTextBoxColumn4.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewTextBoxColumn4.HeaderText = "Propietario"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "EMail"
        Me.DataGridViewTextBoxColumn10.HeaderText = "EMail"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.Width = 120
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "Telefono"
        Me.DataGridViewTextBoxColumn11.HeaderText = "Telefono"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.Width = 70
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "Movil"
        Me.DataGridViewTextBoxColumn12.HeaderText = "Movil"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.Width = 70
        '
        'PropietariosBindingNavigatorRecargar
        '
        Me.PropietariosBindingNavigatorRecargar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.PropietariosBindingNavigatorRecargar.Image = Global.CovetorWin.My.Resources.Resources.Reload
        Me.PropietariosBindingNavigatorRecargar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.PropietariosBindingNavigatorRecargar.Name = "PropietariosBindingNavigatorRecargar"
        Me.PropietariosBindingNavigatorRecargar.Size = New System.Drawing.Size(28, 28)
        Me.PropietariosBindingNavigatorRecargar.Text = "Recargar"
        Me.PropietariosBindingNavigatorRecargar.ToolTipText = "Recargar todos los datos de sde la Base de Datos"
        '
        'Propietarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(661, 412)
        Me.Controls.Add(Me.TotalMetrosTextBox)
        Me.Controls.Add(Me.CoeficienteTextBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(NotasLabel)
        Me.Controls.Add(Me.NotasTextBox)
        Me.Controls.Add(Me.FincasDataGridView)
        Me.Controls.Add(Me.PropietarioGroupBox)
        Me.Controls.Add(Me.ImagenPictureBox)
        Me.Controls.Add(Me.PropietariosDataGridView)
        Me.Controls.Add(Me.PropietariosBindingNavigator)
        Me.Name = "Propietarios"
        Me.Text = "Propietarios"
        CType(Me.DataSetTablas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PropietariosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PropietariosBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PropietariosBindingNavigator.ResumeLayout(False)
        Me.PropietariosBindingNavigator.PerformLayout()
        CType(Me.PropietariosDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImagenPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PropietarioGroupBox.ResumeLayout(False)
        Me.PropietarioGroupBox.PerformLayout()
        CType(Me.FincasDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FincasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents DataSetTablas As DatosMsSQL.DataSetTablas
    Friend WithEvents PropietariosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PropietariosBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents PropietariosBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents PropietariosDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents ImagenPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents PropietarioGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents EMailTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CCCTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MovilTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TelefonoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DNITextBox As System.Windows.Forms.TextBox
    Friend WithEvents PoblacionTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CPTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DomiciioTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ApellidosTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NombreTextBox As System.Windows.Forms.TextBox
    Friend WithEvents FincasDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents NotasTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents FincasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents FincasTableAdapter As DatosMsSQL.DataSetTablasTableAdapters.FincasTableAdapter
    Friend WithEvents PropietariosTableAdapter As DatosMsSQL.DataSetTablasTableAdapters.PropietariosTableAdapter
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CoeficienteTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TotalMetrosTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PropietariosBindingNavigatorRecargar As System.Windows.Forms.ToolStripButton
End Class
