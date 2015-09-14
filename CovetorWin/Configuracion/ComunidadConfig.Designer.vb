<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ComunidadConfig
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
        Dim InicioLabel As System.Windows.Forms.Label
        Dim FinalLabel As System.Windows.Forms.Label
        Dim PoblacionLabel As System.Windows.Forms.Label
        Dim ProvinciaLabel As System.Windows.Forms.Label
        Dim DireccionLabel As System.Windows.Forms.Label
        Dim NotasLabel As System.Windows.Forms.Label
        Dim CPLabel As System.Windows.Forms.Label
        Dim Label8 As System.Windows.Forms.Label
        Dim Label9 As System.Windows.Forms.Label
        Dim MetrosLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ComunidadConfig))
        Dim DataGridViewCellStyle25 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle29 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle26 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle27 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle28 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle30 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle31 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle32 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle33 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle34 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle35 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle36 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.EstadoLBL = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ComunidadesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSetTablas = New DatosMsSQL.DataSetTablas()
        Me.GruposBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VinculosPlusBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FincasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CancelarBTN = New System.Windows.Forms.Button()
        Me.GuardarBTN = New System.Windows.Forms.Button()
        Me.GruposTableAdapter = New DatosMsSQL.DataSetTablasTableAdapters.GruposTableAdapter()
        Me.VinculosPlusTableAdapter = New DatosMsSQL.DataSetTablasTableAdapters.VinculosPlusTableAdapter()
        Me.TableAdapterManager = New DatosMsSQL.DataSetTablasTableAdapters.TableAdapterManager()
        Me.ComunidadesTableAdapter = New DatosMsSQL.DataSetTablasTableAdapters.ComunidadesTableAdapter()
        Me.ModelosTableAdapter = New DatosMsSQL.DataSetTablasTableAdapters.ModelosTableAdapter()
        Me.FincasTableAdapter = New DatosMsSQL.DataSetTablasTableAdapters.FincasTableAdapter()
        Me.GruposTabPage = New System.Windows.Forms.TabPage()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.GruposBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.GruposBindingNavigatorNuevo = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem1 = New System.Windows.Forms.ToolStripLabel()
        Me.GruposBindingNavigatorBorrar = New System.Windows.Forms.ToolStripButton()
        Me.GruposBindingNavigatorGuardar = New System.Windows.Forms.ToolStripButton()
        Me.GruposBindingNavigatorDehacer = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.VinculosBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.BindingNavigatorDeshacer = New System.Windows.Forms.ToolStripButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.FincaComboBox = New System.Windows.Forms.ComboBox()
        Me.NotasTextBox = New System.Windows.Forms.TextBox()
        Me.VinculosPlusDataGridView = New System.Windows.Forms.DataGridView()
        Me.ColumnaVinculosIdentificacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnaMetrosFinca = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnaCoeficiente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GruposDataGridView = New System.Windows.Forms.DataGridView()
        Me.ColumnGruposNombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnGruposMetros = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ComunidadTabPage = New System.Windows.Forms.TabPage()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ImagenPictureBox = New System.Windows.Forms.PictureBox()
        Me.ComunidadGuardarBTN = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.PoblacionTextBox = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.CPTextBox = New System.Windows.Forms.TextBox()
        Me.ProvinciaTextBox = New System.Windows.Forms.TextBox()
        Me.DireccionTextBox = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.PropietariosComboBox = New System.Windows.Forms.ComboBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.InicioDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.FinalDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.ComunidadTextBox = New System.Windows.Forms.TextBox()
        Me.TabControl = New System.Windows.Forms.TabControl()
        Me.ModelosTabPage = New System.Windows.Forms.TabPage()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.ModelosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SumaMetrosTextBox = New System.Windows.Forms.TextBox()
        Me.NumFincasTextBox = New System.Windows.Forms.TextBox()
        Me.ModelosDataGridView = New System.Windows.Forms.DataGridView()
        Me.ModeloDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FincasDataGridView = New System.Windows.Forms.DataGridView()
        Me.IdentificacionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MetrosDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FKFincasModelosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PerteneciasTabPage = New System.Windows.Forms.TabPage()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.PerteneciasBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem1 = New System.Windows.Forms.ToolStripButton()
        Me.FKVinculosPlusFincasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BindingNavigatorCountItem2 = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem1 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.PerteneciasGrupoComboBox = New System.Windows.Forms.ComboBox()
        Me.PerteneciasGruposBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MetrosTextBox = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.PertenenciasVinculosDataGridView = New System.Windows.Forms.DataGridView()
        Me.NombreGrupoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalM2DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CoeficienteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PerteneciasFincasListBox = New System.Windows.Forms.ListBox()
        Me.ModelosComboBox = New System.Windows.Forms.ComboBox()
        Me.OpenFileDialog = New System.Windows.Forms.OpenFileDialog()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.AplicarBTN = New System.Windows.Forms.Button()
        Me.ACSTabPage = New System.Windows.Forms.TabPage()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        InicioLabel = New System.Windows.Forms.Label()
        FinalLabel = New System.Windows.Forms.Label()
        PoblacionLabel = New System.Windows.Forms.Label()
        ProvinciaLabel = New System.Windows.Forms.Label()
        DireccionLabel = New System.Windows.Forms.Label()
        NotasLabel = New System.Windows.Forms.Label()
        CPLabel = New System.Windows.Forms.Label()
        Label8 = New System.Windows.Forms.Label()
        Label9 = New System.Windows.Forms.Label()
        MetrosLabel = New System.Windows.Forms.Label()
        Me.StatusStrip.SuspendLayout()
        CType(Me.ComunidadesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetTablas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GruposBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VinculosPlusBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FincasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GruposTabPage.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GruposBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GruposBindingNavigator.SuspendLayout()
        CType(Me.VinculosBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.VinculosBindingNavigator.SuspendLayout()
        CType(Me.VinculosPlusDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GruposDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ComunidadTabPage.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.ImagenPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl.SuspendLayout()
        Me.ModelosTabPage.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ModelosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ModelosDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FincasDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FKFincasModelosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PerteneciasTabPage.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.PerteneciasBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PerteneciasBindingNavigator.SuspendLayout()
        CType(Me.FKVinculosPlusFincasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PerteneciasGruposBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PertenenciasVinculosDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ACSTabPage.SuspendLayout()
        Me.SuspendLayout()
        '
        'InicioLabel
        '
        InicioLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        InicioLabel.AutoSize = True
        InicioLabel.Location = New System.Drawing.Point(81, 53)
        InicioLabel.Name = "InicioLabel"
        InicioLabel.Size = New System.Drawing.Size(41, 13)
        InicioLabel.TabIndex = 18
        InicioLabel.Text = "Desde:"
        '
        'FinalLabel
        '
        FinalLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        FinalLabel.AutoSize = True
        FinalLabel.Location = New System.Drawing.Point(84, 79)
        FinalLabel.Name = "FinalLabel"
        FinalLabel.Size = New System.Drawing.Size(38, 13)
        FinalLabel.TabIndex = 20
        FinalLabel.Text = "Hasta:"
        '
        'PoblacionLabel
        '
        PoblacionLabel.AutoSize = True
        PoblacionLabel.Location = New System.Drawing.Point(8, 58)
        PoblacionLabel.Name = "PoblacionLabel"
        PoblacionLabel.Size = New System.Drawing.Size(56, 13)
        PoblacionLabel.TabIndex = 8
        PoblacionLabel.Text = "poblacion:"
        '
        'ProvinciaLabel
        '
        ProvinciaLabel.AutoSize = True
        ProvinciaLabel.Location = New System.Drawing.Point(8, 84)
        ProvinciaLabel.Name = "ProvinciaLabel"
        ProvinciaLabel.Size = New System.Drawing.Size(54, 13)
        ProvinciaLabel.TabIndex = 10
        ProvinciaLabel.Text = "Provincia:"
        '
        'DireccionLabel
        '
        DireccionLabel.AutoSize = True
        DireccionLabel.Location = New System.Drawing.Point(8, 32)
        DireccionLabel.Name = "DireccionLabel"
        DireccionLabel.Size = New System.Drawing.Size(53, 13)
        DireccionLabel.TabIndex = 6
        DireccionLabel.Text = "direccion:"
        '
        'NotasLabel
        '
        NotasLabel.AutoSize = True
        NotasLabel.Location = New System.Drawing.Point(276, 13)
        NotasLabel.Name = "NotasLabel"
        NotasLabel.Size = New System.Drawing.Size(36, 13)
        NotasLabel.TabIndex = 16
        NotasLabel.Text = "notas:"
        '
        'CPLabel
        '
        CPLabel.AutoSize = True
        CPLabel.Location = New System.Drawing.Point(8, 110)
        CPLabel.Name = "CPLabel"
        CPLabel.Size = New System.Drawing.Size(24, 13)
        CPLabel.TabIndex = 12
        CPLabel.Text = "CP:"
        '
        'Label8
        '
        Label8.AutoSize = True
        Label8.Location = New System.Drawing.Point(2, 10)
        Label8.Name = "Label8"
        Label8.Size = New System.Drawing.Size(74, 13)
        Label8.TabIndex = 15
        Label8.Text = "Modelo-Finca:"
        '
        'Label9
        '
        Label9.AutoSize = True
        Label9.Location = New System.Drawing.Point(121, 11)
        Label9.Name = "Label9"
        Label9.Size = New System.Drawing.Size(60, 13)
        Label9.TabIndex = 21
        Label9.Text = "Propietario:"
        '
        'MetrosLabel
        '
        MetrosLabel.AutoSize = True
        MetrosLabel.Location = New System.Drawing.Point(341, 11)
        MetrosLabel.Name = "MetrosLabel"
        MetrosLabel.Size = New System.Drawing.Size(42, 13)
        MetrosLabel.TabIndex = 18
        MetrosLabel.Text = "Metros:"
        '
        'StatusStrip
        '
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.EstadoLBL})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 417)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Size = New System.Drawing.Size(624, 24)
        Me.StatusStrip.TabIndex = 0
        Me.StatusStrip.Text = "StatusStrip"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Margin = New System.Windows.Forms.Padding(0, 3, 30, 2)
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(45, 19)
        Me.ToolStripStatusLabel1.Text = "Estado:"
        '
        'EstadoLBL
        '
        Me.EstadoLBL.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.EstadoLBL.ForeColor = System.Drawing.Color.MediumBlue
        Me.EstadoLBL.Name = "EstadoLBL"
        Me.EstadoLBL.Size = New System.Drawing.Size(96, 19)
        Me.EstadoLBL.Text = "Sincronizado"
        '
        'ComunidadesBindingSource
        '
        Me.ComunidadesBindingSource.DataMember = "Comunidades"
        Me.ComunidadesBindingSource.DataSource = Me.DataSetTablas
        '
        'DataSetTablas
        '
        Me.DataSetTablas.DataSetName = "DataSetTablas"
        Me.DataSetTablas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GruposBindingSource
        '
        Me.GruposBindingSource.DataMember = "Grupos"
        Me.GruposBindingSource.DataSource = Me.DataSetTablas
        Me.GruposBindingSource.Sort = "Nombre"
        '
        'VinculosPlusBindingSource
        '
        Me.VinculosPlusBindingSource.DataMember = "FK_VinculosPlus_Grupos"
        Me.VinculosPlusBindingSource.DataSource = Me.GruposBindingSource
        Me.VinculosPlusBindingSource.Sort = "Identificacion"
        '
        'FincasBindingSource
        '
        Me.FincasBindingSource.DataMember = "Fincas"
        Me.FincasBindingSource.DataSource = Me.DataSetTablas
        Me.FincasBindingSource.Sort = "Identificacion"
        '
        'CancelarBTN
        '
        Me.CancelarBTN.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CancelarBTN.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.CancelarBTN.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CancelarBTN.Location = New System.Drawing.Point(426, 384)
        Me.CancelarBTN.Name = "CancelarBTN"
        Me.CancelarBTN.Size = New System.Drawing.Size(90, 30)
        Me.CancelarBTN.TabIndex = 2
        Me.CancelarBTN.Text = "Cancelar"
        Me.CancelarBTN.UseVisualStyleBackColor = True
        '
        'GuardarBTN
        '
        Me.GuardarBTN.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GuardarBTN.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GuardarBTN.Location = New System.Drawing.Point(330, 384)
        Me.GuardarBTN.Name = "GuardarBTN"
        Me.GuardarBTN.Size = New System.Drawing.Size(90, 30)
        Me.GuardarBTN.TabIndex = 3
        Me.GuardarBTN.Text = "Guardar"
        Me.GuardarBTN.UseVisualStyleBackColor = True
        '
        'GruposTableAdapter
        '
        Me.GruposTableAdapter.ClearBeforeFill = True
        '
        'VinculosPlusTableAdapter
        '
        Me.VinculosPlusTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ComunidadesTableAdapter = Me.ComunidadesTableAdapter
        Me.TableAdapterManager.FincasTableAdapter = Nothing
        Me.TableAdapterManager.GruposTableAdapter = Me.GruposTableAdapter
        Me.TableAdapterManager.ModelosTableAdapter = Me.ModelosTableAdapter
        Me.TableAdapterManager.PropietariosTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = DatosMsSQL.DataSetTablasTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.VinculosPlusTableAdapter = Me.VinculosPlusTableAdapter
        Me.TableAdapterManager.VinculosTableAdapter = Nothing
        '
        'ComunidadesTableAdapter
        '
        Me.ComunidadesTableAdapter.ClearBeforeFill = True
        '
        'ModelosTableAdapter
        '
        Me.ModelosTableAdapter.ClearBeforeFill = True
        '
        'FincasTableAdapter
        '
        Me.FincasTableAdapter.ClearBeforeFill = True
        '
        'GruposTabPage
        '
        Me.GruposTabPage.AutoScroll = True
        Me.GruposTabPage.Controls.Add(Me.PictureBox2)
        Me.GruposTabPage.Controls.Add(Me.GruposBindingNavigator)
        Me.GruposTabPage.Controls.Add(Me.VinculosBindingNavigator)
        Me.GruposTabPage.Controls.Add(Me.Label1)
        Me.GruposTabPage.Controls.Add(Me.FincaComboBox)
        Me.GruposTabPage.Controls.Add(Me.NotasTextBox)
        Me.GruposTabPage.Controls.Add(Me.VinculosPlusDataGridView)
        Me.GruposTabPage.Controls.Add(Me.GruposDataGridView)
        Me.GruposTabPage.Location = New System.Drawing.Point(4, 22)
        Me.GruposTabPage.Name = "GruposTabPage"
        Me.GruposTabPage.Padding = New System.Windows.Forms.Padding(3)
        Me.GruposTabPage.Size = New System.Drawing.Size(592, 340)
        Me.GruposTabPage.TabIndex = 1
        Me.GruposTabPage.Text = "Grupos de Fincas"
        Me.GruposTabPage.ToolTipText = "Agrupaciones de Fincas"
        Me.GruposTabPage.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox2.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.PictureBox2.Image = Global.CovetorWin.My.Resources.Resources.SalonVivienda
        Me.PictureBox2.Location = New System.Drawing.Point(511, 35)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(75, 50)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 6
        Me.PictureBox2.TabStop = False
        '
        'GruposBindingNavigator
        '
        Me.GruposBindingNavigator.AddNewItem = Me.GruposBindingNavigatorNuevo
        Me.GruposBindingNavigator.AutoSize = False
        Me.GruposBindingNavigator.BindingSource = Me.GruposBindingSource
        Me.GruposBindingNavigator.CountItem = Me.BindingNavigatorCountItem1
        Me.GruposBindingNavigator.CountItemFormat = "{0} Grupos"
        Me.GruposBindingNavigator.DeleteItem = Me.GruposBindingNavigatorBorrar
        Me.GruposBindingNavigator.Dock = System.Windows.Forms.DockStyle.None
        Me.GruposBindingNavigator.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.GruposBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GruposBindingNavigatorNuevo, Me.GruposBindingNavigatorBorrar, Me.GruposBindingNavigatorGuardar, Me.GruposBindingNavigatorDehacer, Me.BindingNavigatorSeparator5, Me.BindingNavigatorCountItem1})
        Me.GruposBindingNavigator.Location = New System.Drawing.Point(6, 3)
        Me.GruposBindingNavigator.MoveFirstItem = Nothing
        Me.GruposBindingNavigator.MoveLastItem = Nothing
        Me.GruposBindingNavigator.MoveNextItem = Nothing
        Me.GruposBindingNavigator.MovePreviousItem = Nothing
        Me.GruposBindingNavigator.Name = "GruposBindingNavigator"
        Me.GruposBindingNavigator.PositionItem = Nothing
        Me.GruposBindingNavigator.Size = New System.Drawing.Size(200, 30)
        Me.GruposBindingNavigator.TabIndex = 4
        Me.GruposBindingNavigator.Text = "GruposBindingNavigator"
        '
        'GruposBindingNavigatorNuevo
        '
        Me.GruposBindingNavigatorNuevo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.GruposBindingNavigatorNuevo.Image = CType(resources.GetObject("GruposBindingNavigatorNuevo.Image"), System.Drawing.Image)
        Me.GruposBindingNavigatorNuevo.Name = "GruposBindingNavigatorNuevo"
        Me.GruposBindingNavigatorNuevo.RightToLeftAutoMirrorImage = True
        Me.GruposBindingNavigatorNuevo.Size = New System.Drawing.Size(28, 27)
        Me.GruposBindingNavigatorNuevo.Text = "Agregar nuevo"
        '
        'BindingNavigatorCountItem1
        '
        Me.BindingNavigatorCountItem1.Name = "BindingNavigatorCountItem1"
        Me.BindingNavigatorCountItem1.Size = New System.Drawing.Size(62, 27)
        Me.BindingNavigatorCountItem1.Text = "{0} Grupos"
        Me.BindingNavigatorCountItem1.ToolTipText = "Número total de elementos"
        '
        'GruposBindingNavigatorBorrar
        '
        Me.GruposBindingNavigatorBorrar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.GruposBindingNavigatorBorrar.Image = CType(resources.GetObject("GruposBindingNavigatorBorrar.Image"), System.Drawing.Image)
        Me.GruposBindingNavigatorBorrar.Name = "GruposBindingNavigatorBorrar"
        Me.GruposBindingNavigatorBorrar.RightToLeftAutoMirrorImage = True
        Me.GruposBindingNavigatorBorrar.Size = New System.Drawing.Size(28, 27)
        Me.GruposBindingNavigatorBorrar.Text = "Eliminar"
        '
        'GruposBindingNavigatorGuardar
        '
        Me.GruposBindingNavigatorGuardar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.GruposBindingNavigatorGuardar.Image = Global.CovetorWin.My.Resources.Resources.Disquete
        Me.GruposBindingNavigatorGuardar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.GruposBindingNavigatorGuardar.Name = "GruposBindingNavigatorGuardar"
        Me.GruposBindingNavigatorGuardar.Size = New System.Drawing.Size(28, 27)
        Me.GruposBindingNavigatorGuardar.Text = "Guardar Grupos"
        '
        'GruposBindingNavigatorDehacer
        '
        Me.GruposBindingNavigatorDehacer.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.GruposBindingNavigatorDehacer.Image = Global.CovetorWin.My.Resources.Resources.Reload
        Me.GruposBindingNavigatorDehacer.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.GruposBindingNavigatorDehacer.Name = "GruposBindingNavigatorDehacer"
        Me.GruposBindingNavigatorDehacer.Size = New System.Drawing.Size(28, 27)
        Me.GruposBindingNavigatorDehacer.Text = "ToolStripButton2"
        '
        'BindingNavigatorSeparator5
        '
        Me.BindingNavigatorSeparator5.Name = "BindingNavigatorSeparator5"
        Me.BindingNavigatorSeparator5.Size = New System.Drawing.Size(6, 30)
        '
        'VinculosBindingNavigator
        '
        Me.VinculosBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.VinculosBindingNavigator.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.VinculosBindingNavigator.AutoSize = False
        Me.VinculosBindingNavigator.BindingSource = Me.VinculosPlusBindingSource
        Me.VinculosBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.VinculosBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.VinculosBindingNavigator.Dock = System.Windows.Forms.DockStyle.None
        Me.VinculosBindingNavigator.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.VinculosBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.BindingNavigatorDeshacer})
        Me.VinculosBindingNavigator.Location = New System.Drawing.Point(212, 3)
        Me.VinculosBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.VinculosBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.VinculosBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.VinculosBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.VinculosBindingNavigator.Name = "VinculosBindingNavigator"
        Me.VinculosBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.VinculosBindingNavigator.Size = New System.Drawing.Size(374, 30)
        Me.VinculosBindingNavigator.TabIndex = 4
        Me.VinculosBindingNavigator.Text = "BindingNavigator"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(28, 27)
        Me.BindingNavigatorAddNewItem.Text = "Agregar nuevo"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(37, 27)
        Me.BindingNavigatorCountItem.Text = "de {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Número total de elementos"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(28, 27)
        Me.BindingNavigatorDeleteItem.Text = "Eliminar"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(28, 27)
        Me.BindingNavigatorMoveFirstItem.Text = "Mover primero"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(28, 27)
        Me.BindingNavigatorMovePreviousItem.Text = "Mover anterior"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 30)
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
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 30)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(28, 27)
        Me.BindingNavigatorMoveNextItem.Text = "Mover siguiente"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(28, 27)
        Me.BindingNavigatorMoveLastItem.Text = "Mover último"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 30)
        '
        'BindingNavigatorDeshacer
        '
        Me.BindingNavigatorDeshacer.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeshacer.Image = Global.CovetorWin.My.Resources.Resources.Deshacer
        Me.BindingNavigatorDeshacer.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BindingNavigatorDeshacer.Name = "BindingNavigatorDeshacer"
        Me.BindingNavigatorDeshacer.Size = New System.Drawing.Size(28, 27)
        Me.BindingNavigatorDeshacer.Text = "Deshacer Cambios"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(212, 59)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Seleccionar Finca:"
        '
        'FincaComboBox
        '
        Me.FincaComboBox.DataSource = Me.FincasBindingSource
        Me.FincaComboBox.DisplayMember = "Identificacion"
        Me.FincaComboBox.DropDownHeight = 120
        Me.FincaComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.FincaComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FincaComboBox.FormattingEnabled = True
        Me.FincaComboBox.IntegralHeight = False
        Me.FincaComboBox.ItemHeight = 15
        Me.FincaComboBox.Location = New System.Drawing.Point(313, 54)
        Me.FincaComboBox.MaxDropDownItems = 6
        Me.FincaComboBox.Name = "FincaComboBox"
        Me.FincaComboBox.Size = New System.Drawing.Size(152, 23)
        Me.FincaComboBox.TabIndex = 4
        Me.FincaComboBox.ValueMember = "ID"
        '
        'NotasTextBox
        '
        Me.NotasTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GruposBindingSource, "Notas", True))
        Me.NotasTextBox.Location = New System.Drawing.Point(6, 36)
        Me.NotasTextBox.Multiline = True
        Me.NotasTextBox.Name = "NotasTextBox"
        Me.NotasTextBox.Size = New System.Drawing.Size(200, 49)
        Me.NotasTextBox.TabIndex = 3
        '
        'VinculosPlusDataGridView
        '
        Me.VinculosPlusDataGridView.AllowUserToAddRows = False
        Me.VinculosPlusDataGridView.AllowUserToDeleteRows = False
        Me.VinculosPlusDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.VinculosPlusDataGridView.AutoGenerateColumns = False
        DataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle25.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle25.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle25.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle25.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle25.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle25.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.VinculosPlusDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle25
        Me.VinculosPlusDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.VinculosPlusDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColumnaVinculosIdentificacion, Me.ColumnaMetrosFinca, Me.ColumnaCoeficiente, Me.DataGridViewTextBoxColumn10})
        Me.VinculosPlusDataGridView.DataSource = Me.VinculosPlusBindingSource
        Me.VinculosPlusDataGridView.Location = New System.Drawing.Point(212, 91)
        Me.VinculosPlusDataGridView.MultiSelect = False
        Me.VinculosPlusDataGridView.Name = "VinculosPlusDataGridView"
        Me.VinculosPlusDataGridView.ReadOnly = True
        DataGridViewCellStyle29.SelectionBackColor = System.Drawing.Color.Gray
        Me.VinculosPlusDataGridView.RowsDefaultCellStyle = DataGridViewCellStyle29
        Me.VinculosPlusDataGridView.Size = New System.Drawing.Size(374, 243)
        Me.VinculosPlusDataGridView.TabIndex = 1
        '
        'ColumnaVinculosIdentificacion
        '
        Me.ColumnaVinculosIdentificacion.DataPropertyName = "Identificacion"
        DataGridViewCellStyle26.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle26.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ColumnaVinculosIdentificacion.DefaultCellStyle = DataGridViewCellStyle26
        Me.ColumnaVinculosIdentificacion.HeaderText = "Finca"
        Me.ColumnaVinculosIdentificacion.Name = "ColumnaVinculosIdentificacion"
        Me.ColumnaVinculosIdentificacion.ReadOnly = True
        Me.ColumnaVinculosIdentificacion.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ColumnaVinculosIdentificacion.Width = 80
        '
        'ColumnaMetrosFinca
        '
        Me.ColumnaMetrosFinca.DataPropertyName = "Metros Finca"
        DataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle27.Format = "N2"
        Me.ColumnaMetrosFinca.DefaultCellStyle = DataGridViewCellStyle27
        Me.ColumnaMetrosFinca.HeaderText = "M² Finca"
        Me.ColumnaMetrosFinca.Name = "ColumnaMetrosFinca"
        Me.ColumnaMetrosFinca.ReadOnly = True
        Me.ColumnaMetrosFinca.Width = 60
        '
        'ColumnaCoeficiente
        '
        Me.ColumnaCoeficiente.DataPropertyName = "Coeficiente"
        DataGridViewCellStyle28.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle28.Format = "N8"
        DataGridViewCellStyle28.NullValue = Nothing
        Me.ColumnaCoeficiente.DefaultCellStyle = DataGridViewCellStyle28
        Me.ColumnaCoeficiente.HeaderText = "Coeficiente"
        Me.ColumnaCoeficiente.Name = "ColumnaCoeficiente"
        Me.ColumnaCoeficiente.ReadOnly = True
        Me.ColumnaCoeficiente.Width = 85
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "Propietario"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Propietario"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        '
        'GruposDataGridView
        '
        Me.GruposDataGridView.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GruposDataGridView.AutoGenerateColumns = False
        DataGridViewCellStyle30.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle30.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle30.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle30.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle30.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle30.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle30.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.GruposDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle30
        Me.GruposDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GruposDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColumnGruposNombre, Me.ColumnGruposMetros})
        Me.GruposDataGridView.DataSource = Me.GruposBindingSource
        Me.GruposDataGridView.Location = New System.Drawing.Point(6, 91)
        Me.GruposDataGridView.MultiSelect = False
        Me.GruposDataGridView.Name = "GruposDataGridView"
        Me.GruposDataGridView.Size = New System.Drawing.Size(200, 243)
        Me.GruposDataGridView.TabIndex = 0
        '
        'ColumnGruposNombre
        '
        Me.ColumnGruposNombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ColumnGruposNombre.DataPropertyName = "Nombre"
        Me.ColumnGruposNombre.HeaderText = "Nombre"
        Me.ColumnGruposNombre.Name = "ColumnGruposNombre"
        '
        'ColumnGruposMetros
        '
        Me.ColumnGruposMetros.DataPropertyName = "Metros"
        DataGridViewCellStyle31.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle31.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle31.Format = "N2"
        DataGridViewCellStyle31.SelectionBackColor = System.Drawing.Color.Gray
        Me.ColumnGruposMetros.DefaultCellStyle = DataGridViewCellStyle31
        Me.ColumnGruposMetros.HeaderText = "Metros"
        Me.ColumnGruposMetros.Name = "ColumnGruposMetros"
        Me.ColumnGruposMetros.ReadOnly = True
        Me.ColumnGruposMetros.Width = 60
        '
        'ComunidadTabPage
        '
        Me.ComunidadTabPage.AutoScroll = True
        Me.ComunidadTabPage.Controls.Add(Me.Panel1)
        Me.ComunidadTabPage.Location = New System.Drawing.Point(4, 22)
        Me.ComunidadTabPage.Name = "ComunidadTabPage"
        Me.ComunidadTabPage.Padding = New System.Windows.Forms.Padding(3)
        Me.ComunidadTabPage.Size = New System.Drawing.Size(592, 340)
        Me.ComunidadTabPage.TabIndex = 0
        Me.ComunidadTabPage.Text = "Comunidad"
        Me.ComunidadTabPage.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Panel1.Controls.Add(Me.ImagenPictureBox)
        Me.Panel1.Controls.Add(Me.ComunidadGuardarBTN)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.GroupBox2)
        Me.Panel1.Controls.Add(Me.ComunidadTextBox)
        Me.Panel1.Location = New System.Drawing.Point(8, 6)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(524, 332)
        Me.Panel1.TabIndex = 1
        '
        'ImagenPictureBox
        '
        Me.ImagenPictureBox.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.ImagenPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ImagenPictureBox.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ImagenPictureBox.DataBindings.Add(New System.Windows.Forms.Binding("Image", Me.ComunidadesBindingSource, "Imagen", True))
        Me.ImagenPictureBox.Location = New System.Drawing.Point(16, 37)
        Me.ImagenPictureBox.Name = "ImagenPictureBox"
        Me.ImagenPictureBox.Size = New System.Drawing.Size(135, 100)
        Me.ImagenPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ImagenPictureBox.TabIndex = 34
        Me.ImagenPictureBox.TabStop = False
        '
        'ComunidadGuardarBTN
        '
        Me.ComunidadGuardarBTN.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComunidadGuardarBTN.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComunidadGuardarBTN.Location = New System.Drawing.Point(435, 302)
        Me.ComunidadGuardarBTN.Name = "ComunidadGuardarBTN"
        Me.ComunidadGuardarBTN.Size = New System.Drawing.Size(75, 25)
        Me.ComunidadGuardarBTN.TabIndex = 33
        Me.ComunidadGuardarBTN.Text = "Guardar"
        Me.ComunidadGuardarBTN.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.TextBox3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.TextBox2)
        Me.GroupBox1.Controls.Add(Me.PoblacionTextBox)
        Me.GroupBox1.Controls.Add(CPLabel)
        Me.GroupBox1.Controls.Add(NotasLabel)
        Me.GroupBox1.Controls.Add(DireccionLabel)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.CPTextBox)
        Me.GroupBox1.Controls.Add(Me.ProvinciaTextBox)
        Me.GroupBox1.Controls.Add(Me.DireccionTextBox)
        Me.GroupBox1.Controls.Add(ProvinciaLabel)
        Me.GroupBox1.Controls.Add(PoblacionLabel)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 143)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(494, 159)
        Me.GroupBox1.TabIndex = 32
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Detalle de la Comunidad"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 136)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 13)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "C.C.C."
        '
        'TextBox3
        '
        Me.TextBox3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ComunidadesBindingSource, "CCC", True))
        Me.TextBox3.Location = New System.Drawing.Point(73, 133)
        Me.TextBox3.MaxLength = 30
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(200, 20)
        Me.TextBox3.TabIndex = 20
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(124, 110)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(27, 13)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "NIF:"
        '
        'TextBox2
        '
        Me.TextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ComunidadesBindingSource, "NIF", True))
        Me.TextBox2.Location = New System.Drawing.Point(157, 107)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(116, 20)
        Me.TextBox2.TabIndex = 18
        '
        'PoblacionTextBox
        '
        Me.PoblacionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ComunidadesBindingSource, "poblacion", True))
        Me.PoblacionTextBox.Location = New System.Drawing.Point(73, 55)
        Me.PoblacionTextBox.Name = "PoblacionTextBox"
        Me.PoblacionTextBox.Size = New System.Drawing.Size(200, 20)
        Me.PoblacionTextBox.TabIndex = 9
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ComunidadesBindingSource, "notas", True))
        Me.TextBox1.Location = New System.Drawing.Point(279, 29)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(209, 124)
        Me.TextBox1.TabIndex = 17
        '
        'CPTextBox
        '
        Me.CPTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ComunidadesBindingSource, "CP", True))
        Me.CPTextBox.Location = New System.Drawing.Point(73, 107)
        Me.CPTextBox.Name = "CPTextBox"
        Me.CPTextBox.Size = New System.Drawing.Size(45, 20)
        Me.CPTextBox.TabIndex = 13
        Me.CPTextBox.Text = "50500"
        '
        'ProvinciaTextBox
        '
        Me.ProvinciaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ComunidadesBindingSource, "Provincia", True))
        Me.ProvinciaTextBox.Location = New System.Drawing.Point(73, 81)
        Me.ProvinciaTextBox.Name = "ProvinciaTextBox"
        Me.ProvinciaTextBox.Size = New System.Drawing.Size(200, 20)
        Me.ProvinciaTextBox.TabIndex = 11
        '
        'DireccionTextBox
        '
        Me.DireccionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ComunidadesBindingSource, "direccion", True))
        Me.DireccionTextBox.Location = New System.Drawing.Point(73, 29)
        Me.DireccionTextBox.Name = "DireccionTextBox"
        Me.DireccionTextBox.Size = New System.Drawing.Size(200, 20)
        Me.DireccionTextBox.TabIndex = 7
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.PropietariosComboBox)
        Me.GroupBox2.Controls.Add(Me.PictureBox1)
        Me.GroupBox2.Controls.Add(Me.InicioDateTimePicker)
        Me.GroupBox2.Controls.Add(Me.FinalDateTimePicker)
        Me.GroupBox2.Controls.Add(FinalLabel)
        Me.GroupBox2.Controls.Add(InicioLabel)
        Me.GroupBox2.Location = New System.Drawing.Point(157, 37)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(353, 100)
        Me.GroupBox2.TabIndex = 31
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Presidente"
        '
        'PropietariosComboBox
        '
        Me.PropietariosComboBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PropietariosComboBox.DropDownHeight = 125
        Me.PropietariosComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.PropietariosComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PropietariosComboBox.FormattingEnabled = True
        Me.PropietariosComboBox.IntegralHeight = False
        Me.PropietariosComboBox.ItemHeight = 15
        Me.PropietariosComboBox.Location = New System.Drawing.Point(6, 18)
        Me.PropietariosComboBox.Name = "PropietariosComboBox"
        Me.PropietariosComboBox.Size = New System.Drawing.Size(341, 23)
        Me.PropietariosComboBox.TabIndex = 23
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Image = Global.CovetorWin.My.Resources.Resources.SocioNuevo
        Me.PictureBox1.InitialImage = Nothing
        Me.PictureBox1.Location = New System.Drawing.Point(6, 45)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(57, 49)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 22
        Me.PictureBox1.TabStop = False
        '
        'InicioDateTimePicker
        '
        Me.InicioDateTimePicker.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.InicioDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ComunidadesBindingSource, "inicio", True))
        Me.InicioDateTimePicker.Location = New System.Drawing.Point(128, 47)
        Me.InicioDateTimePicker.Name = "InicioDateTimePicker"
        Me.InicioDateTimePicker.Size = New System.Drawing.Size(219, 20)
        Me.InicioDateTimePicker.TabIndex = 19
        '
        'FinalDateTimePicker
        '
        Me.FinalDateTimePicker.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FinalDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ComunidadesBindingSource, "final", True))
        Me.FinalDateTimePicker.Location = New System.Drawing.Point(128, 73)
        Me.FinalDateTimePicker.Name = "FinalDateTimePicker"
        Me.FinalDateTimePicker.Size = New System.Drawing.Size(219, 20)
        Me.FinalDateTimePicker.TabIndex = 21
        '
        'ComunidadTextBox
        '
        Me.ComunidadTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComunidadTextBox.BackColor = System.Drawing.SystemColors.Window
        Me.ComunidadTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ComunidadesBindingSource, "nombre", True))
        Me.ComunidadTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComunidadTextBox.ForeColor = System.Drawing.Color.Maroon
        Me.ComunidadTextBox.Location = New System.Drawing.Point(16, 6)
        Me.ComunidadTextBox.Multiline = True
        Me.ComunidadTextBox.Name = "ComunidadTextBox"
        Me.ComunidadTextBox.Size = New System.Drawing.Size(494, 25)
        Me.ComunidadTextBox.TabIndex = 29
        Me.ComunidadTextBox.Text = "Comunidad de Vecinos"
        '
        'TabControl
        '
        Me.TabControl.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl.Controls.Add(Me.ComunidadTabPage)
        Me.TabControl.Controls.Add(Me.ModelosTabPage)
        Me.TabControl.Controls.Add(Me.PerteneciasTabPage)
        Me.TabControl.Controls.Add(Me.GruposTabPage)
        Me.TabControl.Controls.Add(Me.ACSTabPage)
        Me.TabControl.Location = New System.Drawing.Point(12, 12)
        Me.TabControl.Name = "TabControl"
        Me.TabControl.SelectedIndex = 0
        Me.TabControl.ShowToolTips = True
        Me.TabControl.Size = New System.Drawing.Size(600, 366)
        Me.TabControl.TabIndex = 1
        '
        'ModelosTabPage
        '
        Me.ModelosTabPage.AutoScroll = True
        Me.ModelosTabPage.Controls.Add(Me.Panel2)
        Me.ModelosTabPage.Controls.Add(Me.Label5)
        Me.ModelosTabPage.Location = New System.Drawing.Point(4, 22)
        Me.ModelosTabPage.Name = "ModelosTabPage"
        Me.ModelosTabPage.Padding = New System.Windows.Forms.Padding(3)
        Me.ModelosTabPage.Size = New System.Drawing.Size(592, 340)
        Me.ModelosTabPage.TabIndex = 2
        Me.ModelosTabPage.Text = "Modelos de Fincas"
        Me.ModelosTabPage.ToolTipText = "Tipos de Fincas (Vivienda, Garaje, Local . . .)"
        Me.ModelosTabPage.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.PictureBox3)
        Me.Panel2.Controls.Add(Me.TextBox4)
        Me.Panel2.Controls.Add(Me.SumaMetrosTextBox)
        Me.Panel2.Controls.Add(Me.NumFincasTextBox)
        Me.Panel2.Controls.Add(Me.ModelosDataGridView)
        Me.Panel2.Controls.Add(Me.FincasDataGridView)
        Me.Panel2.Location = New System.Drawing.Point(16, 37)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(528, 297)
        Me.Panel2.TabIndex = 3
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(386, 91)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(52, 13)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Suma M²:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(386, 22)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(71, 13)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Nº de Fincas:"
        '
        'PictureBox3
        '
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureBox3.Image = Global.CovetorWin.My.Resources.Resources.configuration_settings
        Me.PictureBox3.InitialImage = Nothing
        Me.PictureBox3.Location = New System.Drawing.Point(386, 166)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(120, 128)
        Me.PictureBox3.TabIndex = 5
        Me.PictureBox3.TabStop = False
        '
        'TextBox4
        '
        Me.TextBox4.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ModelosBindingSource, "Descripcion", True))
        Me.TextBox4.Location = New System.Drawing.Point(4, 242)
        Me.TextBox4.Multiline = True
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(361, 52)
        Me.TextBox4.TabIndex = 4
        '
        'ModelosBindingSource
        '
        Me.ModelosBindingSource.DataMember = "Modelos"
        Me.ModelosBindingSource.DataSource = Me.DataSetTablas
        Me.ModelosBindingSource.Sort = "Modelo"
        '
        'SumaMetrosTextBox
        '
        Me.SumaMetrosTextBox.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.SumaMetrosTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SumaMetrosTextBox.ForeColor = System.Drawing.SystemColors.Window
        Me.SumaMetrosTextBox.Location = New System.Drawing.Point(386, 107)
        Me.SumaMetrosTextBox.Multiline = True
        Me.SumaMetrosTextBox.Name = "SumaMetrosTextBox"
        Me.SumaMetrosTextBox.ReadOnly = True
        Me.SumaMetrosTextBox.Size = New System.Drawing.Size(120, 32)
        Me.SumaMetrosTextBox.TabIndex = 3
        Me.SumaMetrosTextBox.Text = "123456789"
        Me.SumaMetrosTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'NumFincasTextBox
        '
        Me.NumFincasTextBox.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.NumFincasTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumFincasTextBox.ForeColor = System.Drawing.SystemColors.Window
        Me.NumFincasTextBox.Location = New System.Drawing.Point(386, 41)
        Me.NumFincasTextBox.Multiline = True
        Me.NumFincasTextBox.Name = "NumFincasTextBox"
        Me.NumFincasTextBox.ReadOnly = True
        Me.NumFincasTextBox.Size = New System.Drawing.Size(120, 32)
        Me.NumFincasTextBox.TabIndex = 2
        Me.NumFincasTextBox.Text = "123456789"
        Me.NumFincasTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ModelosDataGridView
        '
        Me.ModelosDataGridView.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ModelosDataGridView.AutoGenerateColumns = False
        DataGridViewCellStyle32.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle32.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle32.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle32.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle32.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle32.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle32.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ModelosDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle32
        Me.ModelosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ModelosDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ModeloDataGridViewTextBoxColumn})
        Me.ModelosDataGridView.DataSource = Me.ModelosBindingSource
        Me.ModelosDataGridView.Location = New System.Drawing.Point(3, 3)
        Me.ModelosDataGridView.Name = "ModelosDataGridView"
        Me.ModelosDataGridView.Size = New System.Drawing.Size(144, 232)
        Me.ModelosDataGridView.TabIndex = 0
        '
        'ModeloDataGridViewTextBoxColumn
        '
        Me.ModeloDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ModeloDataGridViewTextBoxColumn.DataPropertyName = "Modelo"
        Me.ModeloDataGridViewTextBoxColumn.HeaderText = "Modelo"
        Me.ModeloDataGridViewTextBoxColumn.Name = "ModeloDataGridViewTextBoxColumn"
        '
        'FincasDataGridView
        '
        Me.FincasDataGridView.AllowUserToAddRows = False
        Me.FincasDataGridView.AllowUserToDeleteRows = False
        Me.FincasDataGridView.AutoGenerateColumns = False
        DataGridViewCellStyle33.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle33.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle33.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle33.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle33.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle33.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle33.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.FincasDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle33
        Me.FincasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.FincasDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdentificacionDataGridViewTextBoxColumn, Me.MetrosDataGridViewTextBoxColumn})
        Me.FincasDataGridView.DataSource = Me.FKFincasModelosBindingSource
        Me.FincasDataGridView.Location = New System.Drawing.Point(153, 3)
        Me.FincasDataGridView.Name = "FincasDataGridView"
        Me.FincasDataGridView.ReadOnly = True
        Me.FincasDataGridView.Size = New System.Drawing.Size(212, 232)
        Me.FincasDataGridView.TabIndex = 1
        '
        'IdentificacionDataGridViewTextBoxColumn
        '
        Me.IdentificacionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.IdentificacionDataGridViewTextBoxColumn.DataPropertyName = "Identificacion"
        Me.IdentificacionDataGridViewTextBoxColumn.HeaderText = "Finca"
        Me.IdentificacionDataGridViewTextBoxColumn.Name = "IdentificacionDataGridViewTextBoxColumn"
        Me.IdentificacionDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MetrosDataGridViewTextBoxColumn
        '
        Me.MetrosDataGridViewTextBoxColumn.DataPropertyName = "Metros"
        DataGridViewCellStyle34.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle34.Format = "N2"
        Me.MetrosDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle34
        Me.MetrosDataGridViewTextBoxColumn.HeaderText = "M²"
        Me.MetrosDataGridViewTextBoxColumn.Name = "MetrosDataGridViewTextBoxColumn"
        Me.MetrosDataGridViewTextBoxColumn.ReadOnly = True
        Me.MetrosDataGridViewTextBoxColumn.Width = 60
        '
        'FKFincasModelosBindingSource
        '
        Me.FKFincasModelosBindingSource.DataMember = "FK_Fincas_Modelos"
        Me.FKFincasModelosBindingSource.DataSource = Me.ModelosBindingSource
        Me.FKFincasModelosBindingSource.Sort = "Identificacion"
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.MediumTurquoise
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(3, 3)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(586, 31)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Modelos de Fincas"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PerteneciasTabPage
        '
        Me.PerteneciasTabPage.Controls.Add(Me.Panel3)
        Me.PerteneciasTabPage.Location = New System.Drawing.Point(4, 22)
        Me.PerteneciasTabPage.Name = "PerteneciasTabPage"
        Me.PerteneciasTabPage.Padding = New System.Windows.Forms.Padding(3)
        Me.PerteneciasTabPage.Size = New System.Drawing.Size(592, 340)
        Me.PerteneciasTabPage.TabIndex = 3
        Me.PerteneciasTabPage.Text = "Pertenencias"
        Me.PerteneciasTabPage.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.Panel3.Controls.Add(Me.PerteneciasBindingNavigator)
        Me.Panel3.Controls.Add(Me.PerteneciasGrupoComboBox)
        Me.Panel3.Controls.Add(Label9)
        Me.Panel3.Controls.Add(MetrosLabel)
        Me.Panel3.Controls.Add(Me.MetrosTextBox)
        Me.Panel3.Controls.Add(Me.TextBox5)
        Me.Panel3.Controls.Add(Me.PertenenciasVinculosDataGridView)
        Me.Panel3.Controls.Add(Label8)
        Me.Panel3.Controls.Add(Me.PerteneciasFincasListBox)
        Me.Panel3.Controls.Add(Me.ModelosComboBox)
        Me.Panel3.Location = New System.Drawing.Point(64, 6)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(452, 328)
        Me.Panel3.TabIndex = 0
        '
        'PerteneciasBindingNavigator
        '
        Me.PerteneciasBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem1
        Me.PerteneciasBindingNavigator.BindingSource = Me.FKVinculosPlusFincasBindingSource
        Me.PerteneciasBindingNavigator.CountItem = Me.BindingNavigatorCountItem2
        Me.PerteneciasBindingNavigator.CountItemFormat = "{0} Grupos"
        Me.PerteneciasBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem1
        Me.PerteneciasBindingNavigator.Dock = System.Windows.Forms.DockStyle.None
        Me.PerteneciasBindingNavigator.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.PerteneciasBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorCountItem2, Me.BindingNavigatorSeparator4, Me.BindingNavigatorAddNewItem1, Me.BindingNavigatorDeleteItem1})
        Me.PerteneciasBindingNavigator.Location = New System.Drawing.Point(124, 53)
        Me.PerteneciasBindingNavigator.MoveFirstItem = Nothing
        Me.PerteneciasBindingNavigator.MoveLastItem = Nothing
        Me.PerteneciasBindingNavigator.MoveNextItem = Nothing
        Me.PerteneciasBindingNavigator.MovePreviousItem = Nothing
        Me.PerteneciasBindingNavigator.Name = "PerteneciasBindingNavigator"
        Me.PerteneciasBindingNavigator.PositionItem = Nothing
        Me.PerteneciasBindingNavigator.Size = New System.Drawing.Size(136, 31)
        Me.PerteneciasBindingNavigator.TabIndex = 22
        Me.PerteneciasBindingNavigator.Text = "PerteneciasBindingNavigator"
        '
        'BindingNavigatorAddNewItem1
        '
        Me.BindingNavigatorAddNewItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem1.Image = CType(resources.GetObject("BindingNavigatorAddNewItem1.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem1.Name = "BindingNavigatorAddNewItem1"
        Me.BindingNavigatorAddNewItem1.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem1.Size = New System.Drawing.Size(28, 28)
        Me.BindingNavigatorAddNewItem1.Text = "Agregar nuevo"
        '
        'FKVinculosPlusFincasBindingSource
        '
        Me.FKVinculosPlusFincasBindingSource.DataMember = "FK_VinculosPlus_Fincas"
        Me.FKVinculosPlusFincasBindingSource.DataSource = Me.FKFincasModelosBindingSource
        Me.FKVinculosPlusFincasBindingSource.Sort = "Nombre Grupo"
        '
        'BindingNavigatorCountItem2
        '
        Me.BindingNavigatorCountItem2.Name = "BindingNavigatorCountItem2"
        Me.BindingNavigatorCountItem2.Size = New System.Drawing.Size(62, 28)
        Me.BindingNavigatorCountItem2.Text = "{0} Grupos"
        Me.BindingNavigatorCountItem2.ToolTipText = "Número total de elementos"
        '
        'BindingNavigatorDeleteItem1
        '
        Me.BindingNavigatorDeleteItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem1.Image = CType(resources.GetObject("BindingNavigatorDeleteItem1.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem1.Name = "BindingNavigatorDeleteItem1"
        Me.BindingNavigatorDeleteItem1.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem1.Size = New System.Drawing.Size(28, 28)
        Me.BindingNavigatorDeleteItem1.Text = "Eliminar"
        '
        'BindingNavigatorSeparator4
        '
        Me.BindingNavigatorSeparator4.Name = "BindingNavigatorSeparator4"
        Me.BindingNavigatorSeparator4.Size = New System.Drawing.Size(6, 31)
        '
        'PerteneciasGrupoComboBox
        '
        Me.PerteneciasGrupoComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.FKVinculosPlusFincasBindingSource, "Grupo", True))
        Me.PerteneciasGrupoComboBox.DataSource = Me.PerteneciasGruposBindingSource
        Me.PerteneciasGrupoComboBox.DisplayMember = "Nombre"
        Me.PerteneciasGrupoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.PerteneciasGrupoComboBox.FormattingEnabled = True
        Me.PerteneciasGrupoComboBox.Location = New System.Drawing.Point(270, 63)
        Me.PerteneciasGrupoComboBox.Name = "PerteneciasGrupoComboBox"
        Me.PerteneciasGrupoComboBox.Size = New System.Drawing.Size(175, 21)
        Me.PerteneciasGrupoComboBox.TabIndex = 17
        Me.PerteneciasGrupoComboBox.ValueMember = "ID"
        '
        'PerteneciasGruposBindingSource
        '
        Me.PerteneciasGruposBindingSource.DataMember = "Grupos"
        Me.PerteneciasGruposBindingSource.DataSource = Me.DataSetTablas
        Me.PerteneciasGruposBindingSource.Sort = "Nombre"
        '
        'MetrosTextBox
        '
        Me.MetrosTextBox.BackColor = System.Drawing.Color.NavajoWhite
        Me.MetrosTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FKFincasModelosBindingSource, "Metros", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "###0.00 m²"))
        Me.MetrosTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MetrosTextBox.Location = New System.Drawing.Point(344, 27)
        Me.MetrosTextBox.Name = "MetrosTextBox"
        Me.MetrosTextBox.ReadOnly = True
        Me.MetrosTextBox.Size = New System.Drawing.Size(100, 23)
        Me.MetrosTextBox.TabIndex = 20
        Me.MetrosTextBox.Text = " "
        Me.MetrosTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox5
        '
        Me.TextBox5.BackColor = System.Drawing.Color.Moccasin
        Me.TextBox5.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FKVinculosPlusFincasBindingSource, "Propietario", True))
        Me.TextBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox5.Location = New System.Drawing.Point(124, 27)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.ReadOnly = True
        Me.TextBox5.Size = New System.Drawing.Size(194, 23)
        Me.TextBox5.TabIndex = 19
        Me.TextBox5.Text = "Nombre del Propietario"
        '
        'PertenenciasVinculosDataGridView
        '
        Me.PertenenciasVinculosDataGridView.AllowUserToAddRows = False
        Me.PertenenciasVinculosDataGridView.AllowUserToOrderColumns = True
        Me.PertenenciasVinculosDataGridView.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PertenenciasVinculosDataGridView.AutoGenerateColumns = False
        Me.PertenenciasVinculosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PertenenciasVinculosDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NombreGrupoDataGridViewTextBoxColumn, Me.TotalM2DataGridViewTextBoxColumn, Me.CoeficienteDataGridViewTextBoxColumn})
        Me.PertenenciasVinculosDataGridView.DataSource = Me.FKVinculosPlusFincasBindingSource
        Me.PertenenciasVinculosDataGridView.Location = New System.Drawing.Point(124, 87)
        Me.PertenenciasVinculosDataGridView.Name = "PertenenciasVinculosDataGridView"
        Me.PertenenciasVinculosDataGridView.Size = New System.Drawing.Size(321, 238)
        Me.PertenenciasVinculosDataGridView.TabIndex = 16
        '
        'NombreGrupoDataGridViewTextBoxColumn
        '
        Me.NombreGrupoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.NombreGrupoDataGridViewTextBoxColumn.DataPropertyName = "Nombre Grupo"
        Me.NombreGrupoDataGridViewTextBoxColumn.HeaderText = "Nombre Grupo"
        Me.NombreGrupoDataGridViewTextBoxColumn.Name = "NombreGrupoDataGridViewTextBoxColumn"
        Me.NombreGrupoDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'TotalM2DataGridViewTextBoxColumn
        '
        Me.TotalM2DataGridViewTextBoxColumn.DataPropertyName = "Total M2"
        DataGridViewCellStyle35.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle35.Format = "#,##0.00 m²"
        DataGridViewCellStyle35.NullValue = Nothing
        Me.TotalM2DataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle35
        Me.TotalM2DataGridViewTextBoxColumn.HeaderText = "Total M²"
        Me.TotalM2DataGridViewTextBoxColumn.Name = "TotalM2DataGridViewTextBoxColumn"
        Me.TotalM2DataGridViewTextBoxColumn.Width = 80
        '
        'CoeficienteDataGridViewTextBoxColumn
        '
        Me.CoeficienteDataGridViewTextBoxColumn.DataPropertyName = "Coeficiente"
        DataGridViewCellStyle36.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle36.Format = "N6"
        Me.CoeficienteDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle36
        Me.CoeficienteDataGridViewTextBoxColumn.HeaderText = "Coeficiente"
        Me.CoeficienteDataGridViewTextBoxColumn.Name = "CoeficienteDataGridViewTextBoxColumn"
        Me.CoeficienteDataGridViewTextBoxColumn.Width = 80
        '
        'PerteneciasFincasListBox
        '
        Me.PerteneciasFincasListBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PerteneciasFincasListBox.DataSource = Me.FKFincasModelosBindingSource
        Me.PerteneciasFincasListBox.DisplayMember = "Identificacion"
        Me.PerteneciasFincasListBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PerteneciasFincasListBox.FormattingEnabled = True
        Me.PerteneciasFincasListBox.ItemHeight = 15
        Me.PerteneciasFincasListBox.Location = New System.Drawing.Point(3, 51)
        Me.PerteneciasFincasListBox.Name = "PerteneciasFincasListBox"
        Me.PerteneciasFincasListBox.Size = New System.Drawing.Size(115, 274)
        Me.PerteneciasFincasListBox.TabIndex = 14
        Me.PerteneciasFincasListBox.ValueMember = "ID"
        '
        'ModelosComboBox
        '
        Me.ModelosComboBox.BackColor = System.Drawing.SystemColors.Info
        Me.ModelosComboBox.DataSource = Me.ModelosBindingSource
        Me.ModelosComboBox.DisplayMember = "Modelo"
        Me.ModelosComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ModelosComboBox.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.ModelosComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ModelosComboBox.ForeColor = System.Drawing.SystemColors.WindowText
        Me.ModelosComboBox.FormattingEnabled = True
        Me.ModelosComboBox.Location = New System.Drawing.Point(3, 26)
        Me.ModelosComboBox.Name = "ModelosComboBox"
        Me.ModelosComboBox.Size = New System.Drawing.Size(115, 24)
        Me.ModelosComboBox.TabIndex = 13
        Me.ModelosComboBox.ValueMember = "Id"
        '
        'OpenFileDialog
        '
        Me.OpenFileDialog.Filter = "Archivos de Imagen(*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF|Todos Archivos (*.*)|*.* " & _
    ""
        '
        'Label4
        '
        Me.Label4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 384)
        Me.Label4.MinimumSize = New System.Drawing.Size(320, 30)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(320, 30)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Configuración de la Comunidad"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'AplicarBTN
        '
        Me.AplicarBTN.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AplicarBTN.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AplicarBTN.Location = New System.Drawing.Point(522, 384)
        Me.AplicarBTN.Name = "AplicarBTN"
        Me.AplicarBTN.Size = New System.Drawing.Size(90, 30)
        Me.AplicarBTN.TabIndex = 5
        Me.AplicarBTN.Text = "Aplicar"
        Me.AplicarBTN.UseVisualStyleBackColor = True
        '
        'ACSTabPage
        '
        Me.ACSTabPage.Controls.Add(Me.TextBox6)
        Me.ACSTabPage.Controls.Add(Me.Label10)
        Me.ACSTabPage.Location = New System.Drawing.Point(4, 22)
        Me.ACSTabPage.Name = "ACSTabPage"
        Me.ACSTabPage.Padding = New System.Windows.Forms.Padding(3)
        Me.ACSTabPage.Size = New System.Drawing.Size(592, 340)
        Me.ACSTabPage.TabIndex = 4
        Me.ACSTabPage.Text = "A.C.S."
        Me.ACSTabPage.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label10.Location = New System.Drawing.Point(85, 123)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(170, 59)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Porcentaje del gasto total que se repercutirá a partes iguales entre todas las fi" & _
    "ncas que hagan uso de este servicio."
        '
        'TextBox6
        '
        Me.TextBox6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TextBox6.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.TextBox6.Font = New System.Drawing.Font("Microsoft Sans Serif", 32.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox6.Location = New System.Drawing.Point(314, 123)
        Me.TextBox6.Multiline = True
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(159, 59)
        Me.TextBox6.TabIndex = 1
        Me.TextBox6.Text = "30 %"
        Me.TextBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ComunidadConfig
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(624, 441)
        Me.Controls.Add(Me.AplicarBTN)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.GuardarBTN)
        Me.Controls.Add(Me.CancelarBTN)
        Me.Controls.Add(Me.TabControl)
        Me.Controls.Add(Me.StatusStrip)
        Me.MinimumSize = New System.Drawing.Size(640, 480)
        Me.Name = "ComunidadConfig"
        Me.Text = "Configurar Comunidad"
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        CType(Me.ComunidadesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetTablas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GruposBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VinculosPlusBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FincasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GruposTabPage.ResumeLayout(False)
        Me.GruposTabPage.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GruposBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GruposBindingNavigator.ResumeLayout(False)
        Me.GruposBindingNavigator.PerformLayout()
        CType(Me.VinculosBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.VinculosBindingNavigator.ResumeLayout(False)
        Me.VinculosBindingNavigator.PerformLayout()
        CType(Me.VinculosPlusDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GruposDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ComunidadTabPage.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.ImagenPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl.ResumeLayout(False)
        Me.ModelosTabPage.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ModelosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ModelosDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FincasDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FKFincasModelosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PerteneciasTabPage.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.PerteneciasBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PerteneciasBindingNavigator.ResumeLayout(False)
        Me.PerteneciasBindingNavigator.PerformLayout()
        CType(Me.FKVinculosPlusFincasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PerteneciasGruposBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PertenenciasVinculosDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ACSTabPage.ResumeLayout(False)
        Me.ACSTabPage.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents CancelarBTN As System.Windows.Forms.Button
    Friend WithEvents GuardarBTN As System.Windows.Forms.Button
    Friend WithEvents GruposBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DataSetTablas As DatosMsSQL.DataSetTablas
    Friend WithEvents GruposTableAdapter As DatosMsSQL.DataSetTablasTableAdapters.GruposTableAdapter
    Friend WithEvents VinculosPlusBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents VinculosPlusTableAdapter As DatosMsSQL.DataSetTablasTableAdapters.VinculosPlusTableAdapter
    Friend WithEvents TableAdapterManager As DatosMsSQL.DataSetTablasTableAdapters.TableAdapterManager
    Friend WithEvents FincasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents FincasTableAdapter As DatosMsSQL.DataSetTablasTableAdapters.FincasTableAdapter
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents EstadoLBL As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ComunidadesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ComunidadesTableAdapter As DatosMsSQL.DataSetTablasTableAdapters.ComunidadesTableAdapter
    Friend WithEvents GruposTabPage As System.Windows.Forms.TabPage
    Friend WithEvents GruposBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents GruposBindingNavigatorNuevo As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents GruposBindingNavigatorBorrar As System.Windows.Forms.ToolStripButton
    Friend WithEvents GruposBindingNavigatorGuardar As System.Windows.Forms.ToolStripButton
    Friend WithEvents GruposBindingNavigatorDehacer As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents VinculosBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents BindingNavigatorDeshacer As System.Windows.Forms.ToolStripButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents FincaComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents NotasTextBox As System.Windows.Forms.TextBox
    Friend WithEvents VinculosPlusDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents GruposDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents ColumnGruposNombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColumnGruposMetros As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ComunidadTabPage As System.Windows.Forms.TabPage
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents ComunidadGuardarBTN As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents PoblacionTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents CPTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ProvinciaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DireccionTextBox As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents PropietariosComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents InicioDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents FinalDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents ComunidadTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TabControl As System.Windows.Forms.TabControl
    Friend WithEvents OpenFileDialog As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents ModelosTabPage As System.Windows.Forms.TabPage
    Friend WithEvents ImagenPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents AplicarBTN As System.Windows.Forms.Button
    Friend WithEvents ColumnaVinculosIdentificacion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColumnaMetrosFinca As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColumnaCoeficiente As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ModelosDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents ModeloDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ModelosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ModelosTableAdapter As DatosMsSQL.DataSetTablasTableAdapters.ModelosTableAdapter
    Friend WithEvents FincasDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents FKFincasModelosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents IdentificacionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MetrosDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SumaMetrosTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NumFincasTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents PerteneciasTabPage As System.Windows.Forms.TabPage
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents PerteneciasFincasListBox As System.Windows.Forms.ListBox
    Friend WithEvents ModelosComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents PertenenciasVinculosDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents NombreGrupoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TotalM2DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CoeficienteDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FKVinculosPlusFincasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PerteneciasGrupoComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents PerteneciasGruposBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MetrosTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents PerteneciasBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem2 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ACSTabPage As System.Windows.Forms.TabPage
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
End Class
