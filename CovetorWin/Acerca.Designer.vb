<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Acerca
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

    Friend WithEvents TabletLayoutPrincipal As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents LogoPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents LabelProductName As System.Windows.Forms.Label
    Friend WithEvents LabelVersion As System.Windows.Forms.Label
    Friend WithEvents LabelCompanyName As System.Windows.Forms.Label
    Friend WithEvents TextBoxDescription As System.Windows.Forms.TextBox
    Friend WithEvents OKButton As System.Windows.Forms.Button
    Friend WithEvents LabelCopyright As System.Windows.Forms.Label

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Acerca))
        Me.TabletLayoutPrincipal = New System.Windows.Forms.TableLayoutPanel()
        Me.LogoPictureBox = New System.Windows.Forms.PictureBox()
        Me.LabelProductName = New System.Windows.Forms.Label()
        Me.LabelVersion = New System.Windows.Forms.Label()
        Me.LabelCopyright = New System.Windows.Forms.Label()
        Me.LabelCompanyName = New System.Windows.Forms.Label()
        Me.TextBoxDescription = New System.Windows.Forms.TextBox()
        Me.OKButton = New System.Windows.Forms.Button()
        Me.AutorTextBox = New System.Windows.Forms.TextBox()
        Me.TabletLayoutPrincipal.SuspendLayout()
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabletLayoutPrincipal
        '
        Me.TabletLayoutPrincipal.ColumnCount = 2
        Me.TabletLayoutPrincipal.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.0!))
        Me.TabletLayoutPrincipal.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67.0!))
        Me.TabletLayoutPrincipal.Controls.Add(Me.LogoPictureBox, 0, 0)
        Me.TabletLayoutPrincipal.Controls.Add(Me.LabelProductName, 1, 0)
        Me.TabletLayoutPrincipal.Controls.Add(Me.LabelVersion, 1, 1)
        Me.TabletLayoutPrincipal.Controls.Add(Me.LabelCopyright, 1, 2)
        Me.TabletLayoutPrincipal.Controls.Add(Me.LabelCompanyName, 1, 3)
        Me.TabletLayoutPrincipal.Controls.Add(Me.TextBoxDescription, 1, 4)
        Me.TabletLayoutPrincipal.Controls.Add(Me.OKButton, 1, 6)
        Me.TabletLayoutPrincipal.Controls.Add(Me.AutorTextBox, 1, 5)
        Me.TabletLayoutPrincipal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabletLayoutPrincipal.Location = New System.Drawing.Point(11, 11)
        Me.TabletLayoutPrincipal.Name = "TabletLayoutPrincipal"
        Me.TabletLayoutPrincipal.RowCount = 7
        Me.TabletLayoutPrincipal.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TabletLayoutPrincipal.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TabletLayoutPrincipal.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TabletLayoutPrincipal.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TabletLayoutPrincipal.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TabletLayoutPrincipal.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TabletLayoutPrincipal.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TabletLayoutPrincipal.Size = New System.Drawing.Size(486, 308)
        Me.TabletLayoutPrincipal.TabIndex = 0
        '
        'LogoPictureBox
        '
        Me.LogoPictureBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LogoPictureBox.Image = CType(resources.GetObject("LogoPictureBox.Image"), System.Drawing.Image)
        Me.LogoPictureBox.Location = New System.Drawing.Point(3, 3)
        Me.LogoPictureBox.Name = "LogoPictureBox"
        Me.TabletLayoutPrincipal.SetRowSpan(Me.LogoPictureBox, 7)
        Me.LogoPictureBox.Size = New System.Drawing.Size(154, 302)
        Me.LogoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.LogoPictureBox.TabIndex = 0
        Me.LogoPictureBox.TabStop = False
        '
        'LabelProductName
        '
        Me.LabelProductName.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabelProductName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelProductName.Location = New System.Drawing.Point(168, 0)
        Me.LabelProductName.Margin = New System.Windows.Forms.Padding(8, 0, 3, 0)
        Me.LabelProductName.MaximumSize = New System.Drawing.Size(0, 21)
        Me.LabelProductName.Name = "LabelProductName"
        Me.LabelProductName.Size = New System.Drawing.Size(315, 21)
        Me.LabelProductName.TabIndex = 0
        Me.LabelProductName.Text = "Nombre de producto"
        Me.LabelProductName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LabelVersion
        '
        Me.LabelVersion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabelVersion.Location = New System.Drawing.Point(168, 30)
        Me.LabelVersion.Margin = New System.Windows.Forms.Padding(8, 0, 3, 0)
        Me.LabelVersion.MaximumSize = New System.Drawing.Size(0, 21)
        Me.LabelVersion.Name = "LabelVersion"
        Me.LabelVersion.Size = New System.Drawing.Size(315, 21)
        Me.LabelVersion.TabIndex = 0
        Me.LabelVersion.Text = "Versión"
        Me.LabelVersion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LabelCopyright
        '
        Me.LabelCopyright.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabelCopyright.Location = New System.Drawing.Point(168, 60)
        Me.LabelCopyright.Margin = New System.Windows.Forms.Padding(8, 0, 3, 0)
        Me.LabelCopyright.MaximumSize = New System.Drawing.Size(0, 21)
        Me.LabelCopyright.Name = "LabelCopyright"
        Me.LabelCopyright.Size = New System.Drawing.Size(315, 21)
        Me.LabelCopyright.TabIndex = 0
        Me.LabelCopyright.Text = "Copyright"
        Me.LabelCopyright.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LabelCompanyName
        '
        Me.LabelCompanyName.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabelCompanyName.Location = New System.Drawing.Point(168, 90)
        Me.LabelCompanyName.Margin = New System.Windows.Forms.Padding(8, 0, 3, 0)
        Me.LabelCompanyName.MaximumSize = New System.Drawing.Size(0, 21)
        Me.LabelCompanyName.Name = "LabelCompanyName"
        Me.LabelCompanyName.Size = New System.Drawing.Size(315, 21)
        Me.LabelCompanyName.TabIndex = 0
        Me.LabelCompanyName.Text = "Nombre de la compañía"
        Me.LabelCompanyName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TextBoxDescription
        '
        Me.TextBoxDescription.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBoxDescription.Location = New System.Drawing.Point(168, 123)
        Me.TextBoxDescription.Margin = New System.Windows.Forms.Padding(8, 3, 3, 3)
        Me.TextBoxDescription.Multiline = True
        Me.TextBoxDescription.Name = "TextBoxDescription"
        Me.TextBoxDescription.ReadOnly = True
        Me.TextBoxDescription.Size = New System.Drawing.Size(315, 71)
        Me.TextBoxDescription.TabIndex = 0
        Me.TextBoxDescription.TabStop = False
        Me.TextBoxDescription.Text = resources.GetString("TextBoxDescription.Text")
        '
        'OKButton
        '
        Me.OKButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.OKButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.OKButton.Location = New System.Drawing.Point(384, 277)
        Me.OKButton.Name = "OKButton"
        Me.OKButton.Size = New System.Drawing.Size(99, 28)
        Me.OKButton.TabIndex = 0
        Me.OKButton.Text = "&Aceptar"
        '
        'AutorTextBox
        '
        Me.AutorTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AutorTextBox.Location = New System.Drawing.Point(168, 200)
        Me.AutorTextBox.Margin = New System.Windows.Forms.Padding(8, 3, 3, 3)
        Me.AutorTextBox.Multiline = True
        Me.AutorTextBox.Name = "AutorTextBox"
        Me.AutorTextBox.ReadOnly = True
        Me.AutorTextBox.Size = New System.Drawing.Size(315, 71)
        Me.AutorTextBox.TabIndex = 1
        Me.AutorTextBox.TabStop = False
        Me.AutorTextBox.Text = "Servidor de Datos:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(Datos del servidor de datos de la comunidad)"
        Me.AutorTextBox.WordWrap = False
        '
        'Acerca
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.OKButton
        Me.ClientSize = New System.Drawing.Size(508, 330)
        Me.Controls.Add(Me.TabletLayoutPrincipal)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Acerca"
        Me.Padding = New System.Windows.Forms.Padding(11)
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Acerca"
        Me.TabletLayoutPrincipal.ResumeLayout(False)
        Me.TabletLayoutPrincipal.PerformLayout()
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents AutorTextBox As System.Windows.Forms.TextBox

End Class
