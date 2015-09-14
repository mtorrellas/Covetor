Public Class Propietarios

    Private Sub Propietarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TotalMetrosTextBox.Text = String.Empty
        Me.CoeficienteTextBox.Text = String.Empty
        'Me.PropietariosBindingSource.MoveLast()
    End Sub

    Private Sub Propietarios_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Me.CargarDatos()
        Me.Totales()
    End Sub

    Private Sub PropietariosBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles PropietariosBindingNavigatorSaveItem.Click

        Try
            Me.Cursor = Cursors.WaitCursor
            Me.PropietariosBindingSource.EndEdit()
            Me.PropietariosTableAdapter.Update(Me.DataSetTablas.Propietarios)

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Guardar Datos")
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub PropietariosBindingSource_CurrentChanged(sender As Object, e As EventArgs) Handles PropietariosBindingSource.CurrentChanged
        
        Me.Totales()

    End Sub

    Private Sub PropietariosBindingNavigatorRecargar_Click(sender As Object, e As EventArgs) Handles PropietariosBindingNavigatorRecargar.Click
        Dim pos As Integer = Me.PropietariosBindingSource.Position
        CargarDatos()
        Me.PropietariosBindingSource.Position = pos
    End Sub

    Private Sub CargarDatos()
        Try
            Me.Cursor = Cursors.WaitCursor
            Me.PropietariosTableAdapter.Fill(Me.DataSetTablas.Propietarios)
            Me.FincasTableAdapter.Fill(Me.DataSetTablas.Fincas)
            'Me.PropietariosBindingSource.MoveLast()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Descarga de Datos")
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub Totales()
        Dim o As BindingSource = Me.PropietariosBindingSource
        Dim row As DatosMsSQL.DataSetTablas.PropietariosRow
        Dim Filtro As String
        Dim MetrosComunidad As Object
        Dim MetrosPropietario As Object

        If Not IsNothing(o.Current) Then
            row = o.Current.row
            Filtro = String.Format("Propietario = {0}", row.ID)
            MetrosPropietario = Me.DataSetTablas.Fincas.Compute("Sum(metros)", Filtro)
            MetrosComunidad = Me.DataSetTablas.Fincas.Compute("Sum(metros)", "")
            If MetrosComunidad IsNot DBNull.Value And MetrosPropietario IsNot DBNull.Value Then
                Me.CoeficienteTextBox.Text = String.Format("{0:N4} %", MetrosPropietario / MetrosComunidad)
                Me.TotalMetrosTextBox.Text = String.Format("{0:N2} m²", MetrosPropietario)
            Else
                Me.CoeficienteTextBox.Text = String.Empty
                Me.TotalMetrosTextBox.Text = String.Empty
            End If
        End If
    End Sub
End Class