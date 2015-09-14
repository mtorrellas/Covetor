<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ConexionSQL
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
        Me.TipoSVRComboBox = New System.Windows.Forms.ComboBox()
        Me.ServidorTextBox = New System.Windows.Forms.TextBox()
        Me.UsuarioTextBox = New System.Windows.Forms.TextBox()
        Me.PassWordTextBox = New System.Windows.Forms.TextBox()
        Me.BaseDatosComboBox = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.PasswordCheckBox = New System.Windows.Forms.CheckBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.OpenFileDialog = New System.Windows.Forms.OpenFileDialog()
        Me.ArchivoBtn = New System.Windows.Forms.Button()
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusEstado = New System.Windows.Forms.ToolStripStatusLabel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ProbarBtn = New System.Windows.Forms.Button()
        Me.GuardarBtn = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.StatusStrip.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label1.Location = New System.Drawing.Point(7, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(294, 26)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Conexión a la Base de Datos"
        '
        'TipoSVRComboBox
        '
        Me.TipoSVRComboBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TipoSVRComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.TipoSVRComboBox.FormattingEnabled = True
        Me.TipoSVRComboBox.Items.AddRange(New Object() {"Servidor Remoto", "Base de Datos Local"})
        Me.TipoSVRComboBox.Location = New System.Drawing.Point(101, 34)
        Me.TipoSVRComboBox.Name = "TipoSVRComboBox"
        Me.TipoSVRComboBox.Size = New System.Drawing.Size(176, 21)
        Me.TipoSVRComboBox.TabIndex = 1
        '
        'ServidorTextBox
        '
        Me.ServidorTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ServidorTextBox.Location = New System.Drawing.Point(101, 62)
        Me.ServidorTextBox.Name = "ServidorTextBox"
        Me.ServidorTextBox.Size = New System.Drawing.Size(176, 20)
        Me.ServidorTextBox.TabIndex = 2
        '
        'UsuarioTextBox
        '
        Me.UsuarioTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UsuarioTextBox.Location = New System.Drawing.Point(101, 88)
        Me.UsuarioTextBox.Name = "UsuarioTextBox"
        Me.UsuarioTextBox.Size = New System.Drawing.Size(176, 20)
        Me.UsuarioTextBox.TabIndex = 3
        '
        'PassWordTextBox
        '
        Me.PassWordTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PassWordTextBox.Location = New System.Drawing.Point(101, 114)
        Me.PassWordTextBox.Name = "PassWordTextBox"
        Me.PassWordTextBox.Size = New System.Drawing.Size(176, 20)
        Me.PassWordTextBox.TabIndex = 4
        '
        'BaseDatosComboBox
        '
        Me.BaseDatosComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.BaseDatosComboBox.FormattingEnabled = True
        Me.BaseDatosComboBox.Location = New System.Drawing.Point(12, 264)
        Me.BaseDatosComboBox.Name = "BaseDatosComboBox"
        Me.BaseDatosComboBox.Size = New System.Drawing.Size(399, 21)
        Me.BaseDatosComboBox.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(22, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Tipo Servidor:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.PasswordCheckBox)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.TipoSVRComboBox)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.ServidorTextBox)
        Me.GroupBox1.Controls.Add(Me.UsuarioTextBox)
        Me.GroupBox1.Controls.Add(Me.PassWordTextBox)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 63)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(289, 170)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos de Acceso"
        '
        'PasswordCheckBox
        '
        Me.PasswordCheckBox.AutoSize = True
        Me.PasswordCheckBox.Location = New System.Drawing.Point(101, 141)
        Me.PasswordCheckBox.Name = "PasswordCheckBox"
        Me.PasswordCheckBox.Size = New System.Drawing.Size(121, 17)
        Me.PasswordCheckBox.TabIndex = 10
        Me.PasswordCheckBox.Text = "Guardar Contraseña"
        Me.PasswordCheckBox.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(31, 117)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Contraseña:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(49, 91)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Usuario:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 65)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(89, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Nombre Servidor:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(13, 248)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Base de Datos:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'OpenFileDialog
        '
        Me.OpenFileDialog.FileName = "OpenFileDialog"
        Me.OpenFileDialog.Filter = "Archivo [*.mdf]|*.mdf"
        Me.OpenFileDialog.Title = "Selecionar Base de Datos"
        '
        'ArchivoBtn
        '
        Me.ArchivoBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ArchivoBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ArchivoBtn.Image = Global.CovetorWIN.My.Resources.Resources.AbrirToolStripButton_Image
        Me.ArchivoBtn.Location = New System.Drawing.Point(417, 263)
        Me.ArchivoBtn.Name = "ArchivoBtn"
        Me.ArchivoBtn.Size = New System.Drawing.Size(28, 21)
        Me.ArchivoBtn.TabIndex = 11
        Me.ArchivoBtn.Text = "..."
        Me.ArchivoBtn.UseVisualStyleBackColor = True
        '
        'StatusStrip
        '
        Me.StatusStrip.GripMargin = New System.Windows.Forms.Padding(20)
        Me.StatusStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.ToolStripStatusEstado})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 303)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Size = New System.Drawing.Size(458, 22)
        Me.StatusStrip.TabIndex = 12
        Me.StatusStrip.Text = "StatusStrip"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(45, 17)
        Me.ToolStripStatusLabel1.Text = "Estado:"
        '
        'ToolStripStatusEstado
        '
        Me.ToolStripStatusEstado.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ToolStripStatusEstado.Name = "ToolStripStatusEstado"
        Me.ToolStripStatusEstado.Size = New System.Drawing.Size(128, 17)
        Me.ToolStripStatusEstado.Text = "ToolStripStatusEstado"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.CovetorWIN.My.Resources.Resources.configuration_settings
        Me.PictureBox1.Location = New System.Drawing.Point(317, 13)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(128, 128)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 13
        Me.PictureBox1.TabStop = False
        '
        'ProbarBtn
        '
        Me.ProbarBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProbarBtn.Location = New System.Drawing.Point(308, 147)
        Me.ProbarBtn.Name = "ProbarBtn"
        Me.ProbarBtn.Size = New System.Drawing.Size(137, 40)
        Me.ProbarBtn.TabIndex = 14
        Me.ProbarBtn.Text = "Probar Conexión"
        Me.ProbarBtn.UseVisualStyleBackColor = True
        '
        'GuardarBtn
        '
        Me.GuardarBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GuardarBtn.Location = New System.Drawing.Point(308, 193)
        Me.GuardarBtn.Name = "GuardarBtn"
        Me.GuardarBtn.Size = New System.Drawing.Size(137, 40)
        Me.GuardarBtn.TabIndex = 15
        Me.GuardarBtn.Text = "Guardar Conexión"
        Me.GuardarBtn.UseVisualStyleBackColor = True
        '
        'ConexionSQL
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(458, 325)
        Me.Controls.Add(Me.GuardarBtn)
        Me.Controls.Add(Me.ProbarBtn)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.StatusStrip)
        Me.Controls.Add(Me.ArchivoBtn)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BaseDatosComboBox)
        Me.MaximumSize = New System.Drawing.Size(474, 364)
        Me.MinimumSize = New System.Drawing.Size(474, 364)
        Me.Name = "ConexionSQL"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "ConexionSQL"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TipoSVRComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents ServidorTextBox As System.Windows.Forms.TextBox
    Friend WithEvents UsuarioTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PassWordTextBox As System.Windows.Forms.TextBox
    Friend WithEvents BaseDatosComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents OpenFileDialog As System.Windows.Forms.OpenFileDialog
    Friend WithEvents ArchivoBtn As System.Windows.Forms.Button
    Friend WithEvents PasswordCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents StatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents ProbarBtn As System.Windows.Forms.Button
    Friend WithEvents ToolStripStatusEstado As System.Windows.Forms.ToolStripStatusLabel

    Friend WithEvents GuardarBtn As System.Windows.Forms.Button
End Class
