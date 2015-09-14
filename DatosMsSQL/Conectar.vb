Public Module Conectar
    Dim Builder As New SqlClient.SqlConnectionStringBuilder

    Property Conexion As String
        Get
            Return My.Settings.CadenaDeConexion
        End Get
        Set(ByVal Value As String)
            My.Settings("CadenaDeConexion") = Value
        End Set
    End Property


    Sub LLenar_Controles(ByRef Tipo As Integer, ByRef Servidor As String, ByRef Catalogo As String _
                        , ByRef Usuario As String, ByRef PassWord As String _
                        , ByRef PWD As Boolean)
        Dim cons As New SqlClient.SqlConnectionStringBuilder

        With cons
            .ConnectionString = Conexion
            Tipo = IIf(.AttachDBFilename.ToString = String.Empty, 0, 1)
            Servidor = .DataSource
            Catalogo = IIf(Tipo = 0, .InitialCatalog, .AttachDBFilename)
            Usuario = .UserID
            PassWord = .Password
            PWD = .Password <> String.Empty
        End With

    End Sub

    Function Probar_Conexion(ByRef Tipo As Integer, ByRef Servidor As String, ByRef Catalogo As String _
                         , ByRef Usuario As String, ByRef PassWord As String _
                         , ByRef PWD As Boolean _
                         , ByRef msg As String) As Boolean

        Dim CadenaBuild As New SqlClient.SqlConnectionStringBuilder

        With Builder
            .ConnectionString = Nothing
            If Tipo = 0 Then
                .DataSource = Servidor       '"mssql.pescata.es"
                .InitialCatalog = Catalogo   '"spt_pescator"
                .UserID = Usuario            '"spt_pescator"
                .Password = PassWord         '"tarazona"
            ElseIf Tipo = 1 Then
                .DataSource = Servidor
                .AttachDBFilename = Catalogo
                .IntegratedSecurity = True
            End If
        End With

        Dim con As New SqlClient.SqlConnection(Builder.ConnectionString)

        Dim ret As Boolean
        Try
            con.Open()
            msg = "La conexión se ha efectúado satisfactariamente"
        Catch ex As Exception
            msg = ex.Message
            Builder.ConnectionString = Nothing
        Finally
            ret = (con.State = ConnectionState.Open)
            con.Close()
        End Try

        Return ret
    End Function

    Sub Guardar_Conexion(ByVal PWD As Boolean)
        If String.IsNullOrEmpty(Builder.ConnectionString) Then
            Exit Sub
        End If

        If Not PWD Then
            Builder.Password = ""
        End If

        Conexion = Builder.ConnectionString
        Builder.ConnectionString = Nothing
    End Sub
End Module
