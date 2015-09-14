Public Class CovetorMDI

    Private Sub Principal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
      
    End Sub

    Private Sub Principal_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        Dim cadena As New SqlClient.SqlConnectionStringBuilder

        cadena.ConnectionString = DatosMsSQL.Conexion

        If Not cadena.IntegratedSecurity And cadena.Password = Nothing Then
            My.Forms.LoginForm.ShowDialog()
        End If

        Me.Cursor = Cursors.WaitCursor
        Me.ToolStripStatusBaseDatos.Text = "Detectando"
        While Me.ToolStripStatusBaseDatos.Text = "Detectando"
            Try
                Me.ToolStripStatusBaseDatos.Text = NombreComunidad()
            Catch ex As Exception
                Select Case My.Forms.ConexionSQL.ShowDialog
                    Case Windows.Forms.DialogResult.OK, Windows.Forms.DialogResult.Retry
                        Exit Try

                    Case Else
                        Me.Close()
                        Exit While
                End Select
            End Try
        End While
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub Principal_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim res As MsgBoxResult

        If Me.MdiChildren.Count > 0 Then
            res = MsgBox("Se va a cerrar la aplicación y hay formularios abiertos",
                         MsgBoxStyle.OkCancel)

            If res = MsgBoxResult.Cancel Then
                e.Cancel = True

            End If
        End If

    End Sub

    Private Sub AbrirVentana(ByRef formulario As Form)
        With formulario
            If .Created Then
                If .WindowState = FormWindowState.Minimized Then
                    .WindowState = FormWindowState.Normal
                End If
                .Activate()
            Else
                .MdiParent = Me
                .Show()
            End If
        End With
    End Sub

    Private Sub ConjuntosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConjuntosToolStripMenuItem.Click
     
        Me.AbrirVentana(My.Forms.Fincas)

    End Sub

    Private Sub PropietariosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PropietariosToolStripMenuItem.Click
        
        Me.AbrirVentana(My.Forms.Propietarios)
       
    End Sub

    Private Sub ProveedoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProveedoresToolStripMenuItem.Click
        Me.AbrirVentana(My.Forms.Proveedores)
    End Sub

    Private Sub CerrarTodo(sender As Object, e As EventArgs) Handles CerrarTodoToolStripMenuItem.Click

        For Each Formulario As Form In Me.MdiChildren
            Formulario.Close()
        Next

    End Sub

    Private Sub CascadaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CascadaToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub IniciarSesionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IniciarSesionToolStripMenuItem.Click
        With My.Forms.LoginForm
            .MdiParent = Me
            .Show()
        End With
    End Sub

    Private Sub AcercaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AcercaToolStripMenuItem.Click
        With My.Forms.Acerca
            .ShowDialog()
        End With
    End Sub

    Private Sub ConexionSQLToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConexionToolStripMenuItem.Click

        With My.Forms.ConexionSQL
            .ShowDialog()
        End With
    End Sub

    Private Sub ComunidadToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ComunidadToolStripMenuItem.Click
     
        Me.AbrirVentana(My.Forms.ComunidadConfig)
    End Sub

    Private Sub AguaCalienteSanitariaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AguaCalienteSanitariaToolStripMenuItem.Click
        Me.AbrirVentana(My.Forms.GestionACS)
    End Sub

    Private Sub GastosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GastosToolStripMenuItem.Click
        Me.AbrirVentana(My.Forms.GestionGastos)
    End Sub

    Private Sub PruebasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PruebasToolStripMenuItem.Click
   
    End Sub

    Private Sub ResetConfiguracionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ResetConfiguracionToolStripMenuItem.Click
        My.Settings.Reset()
    End Sub

End Class
