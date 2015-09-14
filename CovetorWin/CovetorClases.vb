Imports System.Data.SqlClient

Friend Module general
    Function NombreComunidad() As String
        Dim query As String = "select top 1 * from comunidades"
        Dim result As String

        Using Conex As New SqlConnection(DatosMsSQL.Conexion)
            Dim Comando As New SqlCommand(query, Conex)
            Conex.Open()
            Dim reader As SqlDataReader = Comando.ExecuteReader()

            reader.Read()
            result = reader("nombre")
        End Using

        Return result
    End Function

    Function ListaBaseDatos() As String
        Dim query As String = "select top 1 * from comunidades"
        Dim result As String

        Using Conex As New SqlConnection(DatosMsSQL.Conexion)
            Dim Comando As New SqlCommand(query, Conex)
            Conex.Open()
            Dim reader As SqlDataReader = Comando.ExecuteReader()

            reader.Read()
            result = reader.GetString(1)
        End Using

        Return result
    End Function

    Function ListaEjercicios() As String()
        Dim query As String = "select distinct year(fecha)  as y from Gastos order by y desc"
        Dim lista As New List(Of String)
        Dim result As String()

        Using Conex As New SqlConnection(DatosMsSQL.Conexion)
            Dim Comando As New SqlCommand(query, Conex)
            Conex.Open()
            Dim reader As SqlDataReader = Comando.ExecuteReader()


            While reader.Read()
                lista.Add(reader.GetValue(0))
            End While

        End Using

        result = lista.ToArray

        Return result
    End Function

End Module

