Public Class Fincas

    Private Sub Fincas_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Fincas_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Try
            Me.Cursor = Cursors.WaitCursor
            Me.PropietariosTableAdapter.Fill(Me.DataSetTablas.Propietarios)
            Me.ModelosTableAdapter.Fill(Me.DataSetTablas.Modelos)
            Me.FincasTableAdapter.Fill(Me.DataSetTablas.Fincas)
        Catch ex As Exception

        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub FincasBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Try
            Me.Cursor = Cursors.WaitCursor
            Me.FincasTableAdapter.Update(Me.DataSetTablas.Fincas)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Guardar Datos")
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub ModelosBindingSource_CurrentChanged(sender As Object, e As EventArgs) Handles ModelosBindingSource.CurrentChanged
        Me.Totales()

    End Sub

    Private Sub BindingNavigatorGuardar_Click(sender As Object, e As EventArgs) Handles BindingNavigatorGuardar.Click

        Try
            Me.Totales()
            Me.Cursor = Cursors.WaitCursor
            Me.FincasBindingSource.EndEdit()
            Me.FincasTableAdapter.Update(Me.DataSetTablas.Fincas)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Guardar Datos")
        Finally
            Me.Cursor = Cursors.Default
        End Try

    End Sub

    Private Sub Totales()
        Dim o As BindingSource = Me.ModelosBindingSource
        Dim filtro As String = String.Format("Modelo = {0}", o.Current.row.Id)
        Dim Result As Object

        Result = Me.DataSetTablas.Fincas.Compute("Sum(Metros)", filtro)
        Me.SumModTextbox.Text = String.Format("{0:N2} m²", Result)
        Result = Me.DataSetTablas.Fincas.Compute("Count(Metros)", filtro)
        Me.NumModTextBox.Text = String.Format("{0:N0} Fincas", Result)

        Result = Me.DataSetTablas.Fincas.Compute("Sum(Metros)", "")
        Me.SumComTextbox.Text = String.Format("{0:N2} m²", Result)
        Result = Me.DataSetTablas.Fincas.Compute("Count(Metros)", "")
        Me.NumComTextbox.Text = String.Format("{0:N0} Fincas", Result)
    End Sub

End Class