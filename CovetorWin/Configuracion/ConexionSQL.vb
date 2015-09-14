Public Class ConexionSQL
    Dim CadenaBuild As New SqlClient.SqlConnectionStringBuilder
    Dim TipoConex As Integer = 999
    Dim _probado As Boolean

    Private Property Probado As Boolean
        Get
            Return _probado
        End Get
        Set(value As Boolean)
            Me.ToolStripStatusEstado.Text = IIf(value, "Conexión Probada", "Falta comprobar la Conexión")
            _probado = value
        End Set
    End Property

    Private Property CadenaText As String
        Get
            With Me.CadenaBuild
                .ConnectionString = Nothing
                Select Case TipoConex
                    Case 0
                        .DataSource = Trim(Me.ServidorTextBox.Text)
                        .UserID = Trim(UsuarioTextBox.Text)
                        .Password = Trim(Me.PassWordTextBox.Text)
                        .IntegratedSecurity = False
                        .PersistSecurityInfo = False
                        .InitialCatalog = Trim(Me.BaseDatosComboBox.Text)
                    Case 1
                        .DataSource = Trim(Me.ServidorTextBox.Text)
                        .IntegratedSecurity = True
                        .PersistSecurityInfo = False
                        .AttachDBFilename = Trim(Me.BaseDatosComboBox.Text)

                End Select
            End With
            Return Me.CadenaBuild.ConnectionString
        End Get
        Set(value As String)
            Me.CadenaBuild.ConnectionString = value
        End Set
    End Property

    Private Sub ConexionSQL_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim res As MsgBoxResult

        If CovetorMDI.MdiChildren.Length > 0 Then
            res = MsgBox("Para poder configurar los parametros de conexión a la  base de datos " &
                            "es necesario que esten todos los procesos cerrados." & vbCr & vbCr &
                            "Se van a cerrar todos los formularios, con la consiguiente pérdida de los datos no guardados",
                          MsgBoxStyle.OkCancel + MsgBoxStyle.Exclamation,
                          "Configurar Conexión")
            If res = MsgBoxResult.Ok Then
                For Each F As Form In CovetorMDI.MdiChildren
                    F.Close()
                Next
            Else
                Me.Close()
            End If
        End If

        Me.CadenaBuild.ConnectionString = My.Settings.CovetorConexion

        With Me.TipoSVRComboBox
            .SelectedIndex = -1
            .SelectedIndex = IIf(Me.CadenaBuild.IntegratedSecurity, 1, 0)
            TipoConex = .SelectedIndex
        End With

        Me.Probado = False
    End Sub

    Private Sub LLenarControles()
        With Me.ServidorTextBox
            Select Case Me.TipoConex
                Case 0
                    .Text = CadenaBuild.DataSource
                    .Enabled = True
                Case 1
                    .Text = "(LocalDB)\MSSQLLocalDB"
                    .Enabled = False
            End Select

        End With

        With Me.UsuarioTextBox
            .Text = Me.CadenaBuild.UserID
            .Enabled = (TipoConex = 0)
        End With

        With Me.PassWordTextBox
            .Text = Me.CadenaBuild.Password
            .Enabled = Me.UsuarioTextBox.Enabled
        End With

        With Me.PasswordCheckBox
            .Checked = Me.CadenaBuild.Password IsNot String.Empty
            .Enabled = Me.PassWordTextBox.Enabled
        End With

        With Me.BaseDatosComboBox
            Select Case TipoConex
                Case 0
                    .DropDownStyle = ComboBoxStyle.DropDown
                    .Text = Me.CadenaBuild.InitialCatalog
                Case 1
                    .DropDownStyle = ComboBoxStyle.Simple
                    .Text = Me.CadenaBuild.AttachDBFilename
            End Select
        End With

        With ArchivoBtn

            .Visible = (TipoConex = 1)

        End With


    End Sub

    Private Sub TipoSVRComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TipoSVRComboBox.SelectedIndexChanged
        Dim o As ComboBox = sender
        If o.SelectedIndex >= 0 Then
            Me.TipoConex = o.SelectedIndex
            Me.LLenarControles()
        End If

        End Sub

    Private Sub BaseDatosComboBox_DropDown(sender As Object, e As EventArgs) Handles BaseDatosComboBox.DropDown
        Dim msg As String = Me.ToolStripStatusEstado.Text
        MsgBox("Se necesita conexión con el servidor de datos")
 
        Me.Cursor = Cursors.WaitCursor

        Me.llenarComboBox(sender)
        Me.ToolStripStatusEstado.Text = msg
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub llenarComboBox(ByVal CB As ComboBox)
        Dim Cadena As String = "Data Source=162.222.225.88;Integrated Security=False; User ID=cdt_mat;Password=tarazona;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False"
        Dim query As String = "select  * from sys.databases order by name"
        Me.ToolStripStatusEstado.Text = "Consultando la lista de bases de datos del servidor"
        With Me.CadenaBuild
            .ConnectionString = String.Empty
            .DataSource = Me.ServidorTextBox.Text
            .Password = Me.PassWordTextBox.Text
            .UserID = UsuarioTextBox.Text
            .IntegratedSecurity = False
            .PersistSecurityInfo = False
            Cadena = .ConnectionString
        End With


        CB.Items.Clear()

        Try
            Using Conex As New SqlClient.SqlConnection(Cadena)
                Dim Comando As New SqlClient.SqlCommand()
                Comando.Connection = Conex
                Comando.CommandText = query

                Conex.Open()

                Dim reader As SqlClient.SqlDataReader = Comando.ExecuteReader()
                While reader.Read()
                    CB.Items.Add(reader("name"))
                End While
                reader.Close()
            End Using
        Catch ex As Exception
            MsgBox(ex.Message, , "Error Base de Datos")
        Finally

        End Try

    End Sub

    Private Sub ArchivoBtn_Click(sender As Object, e As EventArgs) Handles ArchivoBtn.Click
        Dim res As Windows.Forms.DialogResult

        res = Me.OpenFileDialog.ShowDialog()
        If res = Windows.Forms.DialogResult.OK Then
            Me.BaseDatosComboBox.Text = Me.OpenFileDialog.FileName
        End If

    End Sub

    Private Sub ProbarBtn_Click(sender As Object, e As EventArgs) Handles ProbarBtn.Click
        Me.Cursor = Cursors.WaitCursor
        Me.ToolStripStatusEstado.Text = "Probando la coenxión con el servidor"
        Try
            Using conex As New SqlClient.SqlConnection(Me.CadenaText)
                conex.Open()
                Probado = True
                MsgBox("La conexión con el servidor es Correcta" _
                       , MsgBoxStyle.Information _
                       , "Conexión Base de Datos")
            End Using

        Catch ex As Exception
            MsgBox(ex.Message _
                   , MsgBoxStyle.Critical _
                   , "Error de conexión")
            Probado = False
        Finally

        End Try
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub GuardarBtn_Click(sender As Object, e As EventArgs) Handles GuardarBtn.Click
        Dim o As Button = sender

        Dim ret As MsgBoxResult

        If Not probado Then
            ret = MsgBox("La conexión con el servidor no se ha probado" & vbLf & vbLf & _
                            "¿Se guarda la cadena de conexión generada?", _
                         MsgBoxStyle.YesNo + MsgBoxStyle.Critical, _
                         "Guardar Cadena de Conexión")
        End If

        If Probado Or ret = MsgBoxResult.Yes Then
            Me.ToolStripStatusEstado.Text = "Guardando los datos"
            DatosMsSQL.Conexion = Me.CadenaText
            If Not Me.PasswordCheckBox.Checked Then
                Me.PassWordTextBox.Text = String.Empty
            End If

            My.Settings.CovetorConexion = Me.CadenaText

        End If

        Me.DialogResult = IIf(Probado, DialogResult.OK, DialogResult.Retry)

        Me.Close()
    End Sub

    Private Sub TextBox_TextChanged(sender As Object, e As EventArgs)
        Dim o As TextBox = sender
        If o.Modified Then
            Me.Probado = Not o.Modified
        End If

    End Sub

    Private Sub TipoSVRComboBox_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles TipoSVRComboBox.SelectionChangeCommitted
        Dim o As ComboBox = sender

        Me.Probado = False

    End Sub
End Class