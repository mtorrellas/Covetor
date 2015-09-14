<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CovetorMDI
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CovetorMDI))
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusBaseDatos = New System.Windows.Forms.ToolStripStatusLabel()
        Me.MenuPrincipal = New System.Windows.Forms.MenuStrip()
        Me.ArchivosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConjuntosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PropietariosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InquilinosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProveedoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.ModelosDeFincasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GestionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AguaCalienteSanitariaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GastosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConfiguracionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConexionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IniciarSesionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ComunidadToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.ResetConfiguracionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VentanasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.CerrarTodoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CascadaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.PruebasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AcercaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Prim11ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip.SuspendLayout()
        Me.MenuPrincipal.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatusStrip
        '
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.ToolStripStatusBaseDatos})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 539)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Size = New System.Drawing.Size(784, 22)
        Me.StatusStrip.TabIndex = 0
        Me.StatusStrip.Text = "Estado"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(76, 17)
        Me.ToolStripStatusLabel1.Text = "Comunidad: "
        '
        'ToolStripStatusBaseDatos
        '
        Me.ToolStripStatusBaseDatos.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ToolStripStatusBaseDatos.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ToolStripStatusBaseDatos.Name = "ToolStripStatusBaseDatos"
        Me.ToolStripStatusBaseDatos.Size = New System.Drawing.Size(146, 17)
        Me.ToolStripStatusBaseDatos.Text = "Nombre de la comunidad"
        '
        'MenuPrincipal
        '
        Me.MenuPrincipal.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.MenuPrincipal.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArchivosToolStripMenuItem, Me.GestionToolStripMenuItem, Me.ConsultasToolStripMenuItem, Me.ConfiguracionToolStripMenuItem, Me.VentanasToolStripMenuItem, Me.AcercaToolStripMenuItem})
        Me.MenuPrincipal.Location = New System.Drawing.Point(0, 0)
        Me.MenuPrincipal.MdiWindowListItem = Me.VentanasToolStripMenuItem
        Me.MenuPrincipal.Name = "MenuPrincipal"
        Me.MenuPrincipal.Size = New System.Drawing.Size(784, 27)
        Me.MenuPrincipal.TabIndex = 2
        Me.MenuPrincipal.Text = "MenuPrincipal"
        '
        'ArchivosToolStripMenuItem
        '
        Me.ArchivosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ConjuntosToolStripMenuItem, Me.PropietariosToolStripMenuItem, Me.InquilinosToolStripMenuItem, Me.ProveedoresToolStripMenuItem, Me.ToolStripSeparator4, Me.ModelosDeFincasToolStripMenuItem})
        Me.ArchivosToolStripMenuItem.Name = "ArchivosToolStripMenuItem"
        Me.ArchivosToolStripMenuItem.Size = New System.Drawing.Size(73, 23)
        Me.ArchivosToolStripMenuItem.Text = "Archivos"
        '
        'ConjuntosToolStripMenuItem
        '
        Me.ConjuntosToolStripMenuItem.Name = "ConjuntosToolStripMenuItem"
        Me.ConjuntosToolStripMenuItem.Size = New System.Drawing.Size(191, 24)
        Me.ConjuntosToolStripMenuItem.Text = "Fincas"
        '
        'PropietariosToolStripMenuItem
        '
        Me.PropietariosToolStripMenuItem.Name = "PropietariosToolStripMenuItem"
        Me.PropietariosToolStripMenuItem.Size = New System.Drawing.Size(191, 24)
        Me.PropietariosToolStripMenuItem.Text = "Propietarios"
        '
        'InquilinosToolStripMenuItem
        '
        Me.InquilinosToolStripMenuItem.Name = "InquilinosToolStripMenuItem"
        Me.InquilinosToolStripMenuItem.Size = New System.Drawing.Size(191, 24)
        Me.InquilinosToolStripMenuItem.Text = "Inquilinos"
        '
        'ProveedoresToolStripMenuItem
        '
        Me.ProveedoresToolStripMenuItem.Name = "ProveedoresToolStripMenuItem"
        Me.ProveedoresToolStripMenuItem.Size = New System.Drawing.Size(191, 24)
        Me.ProveedoresToolStripMenuItem.Text = "Proveedores"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(188, 6)
        '
        'ModelosDeFincasToolStripMenuItem
        '
        Me.ModelosDeFincasToolStripMenuItem.Name = "ModelosDeFincasToolStripMenuItem"
        Me.ModelosDeFincasToolStripMenuItem.Size = New System.Drawing.Size(191, 24)
        Me.ModelosDeFincasToolStripMenuItem.Text = "Modelos de Fincas"
        '
        'GestionToolStripMenuItem
        '
        Me.GestionToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AguaCalienteSanitariaToolStripMenuItem, Me.GastosToolStripMenuItem})
        Me.GestionToolStripMenuItem.Name = "GestionToolStripMenuItem"
        Me.GestionToolStripMenuItem.Size = New System.Drawing.Size(68, 23)
        Me.GestionToolStripMenuItem.Text = "Gestion"
        '
        'AguaCalienteSanitariaToolStripMenuItem
        '
        Me.AguaCalienteSanitariaToolStripMenuItem.Name = "AguaCalienteSanitariaToolStripMenuItem"
        Me.AguaCalienteSanitariaToolStripMenuItem.Size = New System.Drawing.Size(167, 24)
        Me.AguaCalienteSanitariaToolStripMenuItem.Text = "Lecturas A.C.S."
        '
        'GastosToolStripMenuItem
        '
        Me.GastosToolStripMenuItem.Name = "GastosToolStripMenuItem"
        Me.GastosToolStripMenuItem.Size = New System.Drawing.Size(167, 24)
        Me.GastosToolStripMenuItem.Text = "Gastos"
        '
        'ConsultasToolStripMenuItem
        '
        Me.ConsultasToolStripMenuItem.Name = "ConsultasToolStripMenuItem"
        Me.ConsultasToolStripMenuItem.Size = New System.Drawing.Size(81, 23)
        Me.ConsultasToolStripMenuItem.Text = "Consultas"
        '
        'ConfiguracionToolStripMenuItem
        '
        Me.ConfiguracionToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ConexionToolStripMenuItem, Me.IniciarSesionToolStripMenuItem, Me.ComunidadToolStripMenuItem, Me.ToolStripSeparator5, Me.ResetConfiguracionToolStripMenuItem})
        Me.ConfiguracionToolStripMenuItem.Name = "ConfiguracionToolStripMenuItem"
        Me.ConfiguracionToolStripMenuItem.Size = New System.Drawing.Size(106, 23)
        Me.ConfiguracionToolStripMenuItem.Text = "Configuracion"
        '
        'ConexionToolStripMenuItem
        '
        Me.ConexionToolStripMenuItem.Name = "ConexionToolStripMenuItem"
        Me.ConexionToolStripMenuItem.Size = New System.Drawing.Size(200, 24)
        Me.ConexionToolStripMenuItem.Text = "Conexion"
        '
        'IniciarSesionToolStripMenuItem
        '
        Me.IniciarSesionToolStripMenuItem.Name = "IniciarSesionToolStripMenuItem"
        Me.IniciarSesionToolStripMenuItem.Size = New System.Drawing.Size(200, 24)
        Me.IniciarSesionToolStripMenuItem.Text = "Iniciar Sesion"
        '
        'ComunidadToolStripMenuItem
        '
        Me.ComunidadToolStripMenuItem.Name = "ComunidadToolStripMenuItem"
        Me.ComunidadToolStripMenuItem.Size = New System.Drawing.Size(200, 24)
        Me.ComunidadToolStripMenuItem.Text = "Comunidad"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(197, 6)
        '
        'ResetConfiguracionToolStripMenuItem
        '
        Me.ResetConfiguracionToolStripMenuItem.Name = "ResetConfiguracionToolStripMenuItem"
        Me.ResetConfiguracionToolStripMenuItem.Size = New System.Drawing.Size(200, 24)
        Me.ResetConfiguracionToolStripMenuItem.Text = "Reset Configuracion"
        '
        'VentanasToolStripMenuItem
        '
        Me.VentanasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator1, Me.CerrarTodoToolStripMenuItem, Me.CascadaToolStripMenuItem, Me.ToolStripSeparator3, Me.PruebasToolStripMenuItem})
        Me.VentanasToolStripMenuItem.Name = "VentanasToolStripMenuItem"
        Me.VentanasToolStripMenuItem.Size = New System.Drawing.Size(78, 23)
        Me.VentanasToolStripMenuItem.Text = "Ventanas"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(148, 6)
        '
        'CerrarTodoToolStripMenuItem
        '
        Me.CerrarTodoToolStripMenuItem.Name = "CerrarTodoToolStripMenuItem"
        Me.CerrarTodoToolStripMenuItem.Size = New System.Drawing.Size(151, 24)
        Me.CerrarTodoToolStripMenuItem.Text = "Cerrar Todo"
        '
        'CascadaToolStripMenuItem
        '
        Me.CascadaToolStripMenuItem.Name = "CascadaToolStripMenuItem"
        Me.CascadaToolStripMenuItem.Size = New System.Drawing.Size(151, 24)
        Me.CascadaToolStripMenuItem.Text = "Cascada"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(148, 6)
        '
        'PruebasToolStripMenuItem
        '
        Me.PruebasToolStripMenuItem.Name = "PruebasToolStripMenuItem"
        Me.PruebasToolStripMenuItem.Size = New System.Drawing.Size(151, 24)
        Me.PruebasToolStripMenuItem.Text = "&Pruebas"
        '
        'AcercaToolStripMenuItem
        '
        Me.AcercaToolStripMenuItem.Name = "AcercaToolStripMenuItem"
        Me.AcercaToolStripMenuItem.Size = New System.Drawing.Size(61, 23)
        Me.AcercaToolStripMenuItem.Text = "Acerca"
        '
        'Prim11ToolStripMenuItem
        '
        Me.Prim11ToolStripMenuItem.Name = "Prim11ToolStripMenuItem"
        Me.Prim11ToolStripMenuItem.Size = New System.Drawing.Size(119, 22)
        Me.Prim11ToolStripMenuItem.Text = "Prim 1-1"
        '
        'CovetorMDI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = Global.CovetorWin.My.MySettings.Default.SizeMDI
        Me.Controls.Add(Me.StatusStrip)
        Me.Controls.Add(Me.MenuPrincipal)
        Me.DataBindings.Add(New System.Windows.Forms.Binding("Location", Global.CovetorWin.My.MySettings.Default, "PosicionMDI", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.DataBindings.Add(New System.Windows.Forms.Binding("ClientSize", Global.CovetorWin.My.MySettings.Default, "SizeMDI", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.DoubleBuffered = True
        Me.IsMdiContainer = True
        Me.Location = Global.CovetorWin.My.MySettings.Default.PosicionMDI
        Me.MainMenuStrip = Me.MenuPrincipal
        Me.MinimumSize = New System.Drawing.Size(800, 600)
        Me.Name = "CovetorMDI"
        Me.Text = "Covetor"
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        Me.MenuPrincipal.ResumeLayout(False)
        Me.MenuPrincipal.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents MenuPrincipal As System.Windows.Forms.MenuStrip
    Friend WithEvents ArchivosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConjuntosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PropietariosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InquilinosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GestionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConfiguracionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConexionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VentanasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AcercaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents CerrarTodoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CascadaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IniciarSesionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusBaseDatos As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents AguaCalienteSanitariaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConsultasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ComunidadToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PruebasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ResetConfiguracionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ModelosDeFincasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ProveedoresToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GastosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Prim11ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
