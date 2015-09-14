Public Class LoginForm
    Dim cadena As New SqlClient.SqlConnectionStringBuilder

    ' TODO: inserte el código para realizar autenticación personalizada usando el nombre de usuario y la contraseña proporcionada 
    ' (Consulte http://go.microsoft.com/fwlink/?LinkId=35339).  
    ' El objeto principal personalizado se puede adjuntar al objeto principal del subproceso actual como se indica a continuación: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' donde CustomPrincipal es la implementación de IPrincipal utilizada para realizar la autenticación. 
    ' Posteriormente, My.User devolverá la información de identidad encapsulada en el objeto CustomPrincipal
    ' como el nombre de usuario, nombre para mostrar, etc.

    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles Me.Load

    End Sub

    Private Sub LoginForm_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Me.cadena.ConnectionString = DatosMsSQL.Conexion
        Me.UsernameTextBox.Text = Me.cadena.UserID
    End Sub

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click

        With Me.cadena
            .UserID = Me.UsernameTextBox.Text
            .Password = Me.PasswordTextBox.Text
            DatosMsSQL.Conexion = Me.cadena.ConnectionString
        End With

        DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub
    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

End Class
