Public Class ComunidadConfig
    Dim R(2), C(1) As Integer
    Private Sub ComunidadConfig_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim tt As New ToolTip

        With tt
            tt.IsBalloon = True
            tt.SetToolTip(CancelarBTN, "Cancela los cambios hechos pendientes de guardar" & vbLf & "y recarga los datos desde la Base de Datos.")
            tt.SetToolTip(Me.AplicarBTN, "Guardar los cambios realizados.")
            tt.SetToolTip(Me.GuardarBTN, "Guardar los cambios realizados y cerrar Ventana.")
            tt.SetToolTip(Me.ComunidadTextBox, "Introducir el Nombre de la Comunidad.")

            tt.SetToolTip(ComunidadGuardarBTN, "Guarda solamente los datos de la pestaña actual")
        End With

        'Me.VinculosPlusBindingSource.Sort = "Identificacion"
        'Me.GruposBindingSource.Sort = "Nombre"


    End Sub

    Private Sub ComunidadConfig_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Me.CargarTodo()
       
    End Sub

    Private Sub GuardarBTN_Click(sender As Object, e As EventArgs) Handles GuardarBTN.Click
        
        Me.GuardarTodo()
        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub CancelarBTN_Click(sender As Object, e As EventArgs) Handles CancelarBTN.Click
        With Me.GruposDataGridView.CurrentCell
            R(0) = .RowIndex
            C(0) = .ColumnIndex
        End With

        With ModelosDataGridView.CurrentCell
            R(1) = .RowIndex
            C(1) = .ColumnIndex
        End With

        R(2) = Me.FKFincasModelosBindingSource.Position


        Me.CargarTodo()
    End Sub

    Private Sub AplicarBTN_Click(sender As Object, e As EventArgs) Handles AplicarBTN.Click

        Me.GuardarTodo()
        Me.CargarTodo()
    End Sub

    Private Sub BindingNavigatorDeshacer_Click(sender As Object, e As EventArgs) Handles BindingNavigatorDeshacer.Click
        Me.DataSetTablas.VinculosPlus.RejectChanges()
    End Sub

    Private Sub FincaComboBox_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles FincaComboBox.SelectionChangeCommitted
        Dim o As ComboBox = sender
        Dim b As BindingSource = Me.VinculosPlusBindingSource
        Dim fila As DatosMsSQL.DataSetTablas.VinculosPlusRow
        Dim V As DataGridView = Me.VinculosPlusDataGridView


        If Not IsNothing(b.Current) Then
            fila = b.Current.row
            'If fila.RowState = DataRowState.Detached Then
            fila.Finca = o.SelectedValue
            V.CurrentRow.Cells("ColumnaVinculosIdentificacion").Value = o.Text
            'fila.Identificacion = o.Text
            'fila.Metros_Finca = Nothing
            'fila.Coeficiente = Nothing

            For Each row As DataGridViewRow In Me.VinculosPlusDataGridView.Rows
                row.Cells("ColumnaMetrosFinca").Value = DBNull.Value
                row.Cells("ColumnaCoeficiente").Value = DBNull.Value
            Next

            Me.EstadoLBL.Text = "Datos Pendientes de Guardar"
            Me.EstadoLBL.ForeColor = Color.IndianRed
            'End If
            o.SelectedIndex = -1
        End If

    End Sub

    Private Sub VinculosPlusDataGridView_RowsRemoved(sender As Object, e As DataGridViewRowsRemovedEventArgs) Handles VinculosPlusDataGridView.RowsRemoved
        If Me.DataSetTablas.HasChanges Then
            For Each row As DataGridViewRow In Me.VinculosPlusDataGridView.Rows
                row.Cells("ColumnaMetrosFinca").Value = DBNull.Value
                row.Cells("ColumnaCoeficiente").Value = DBNull.Value
            Next
            Me.EstadoLBL.Text = "Datos Pendientes de Guardar"
            Me.EstadoLBL.ForeColor = Color.IndianRed
        End If
    End Sub

    Private Sub GruposToolStripGuardar_Click(sender As Object, e As EventArgs) Handles GruposBindingNavigatorGuardar.Click
        Dim C, R As Integer

        With Me.GruposDataGridView.CurrentCell
            R = .RowIndex
            C = .ColumnIndex
        End With

        Try
            Me.Cursor = Cursors.WaitCursor
            Me.GruposBindingSource.EndEdit()
            Me.VinculosPlusBindingSource.EndEdit()
            Me.VinculosPlusTableAdapter.Update(Me.DataSetTablas.VinculosPlus)
            Me.GruposTableAdapter.Update(Me.DataSetTablas.Grupos)
            Me.GruposTableAdapter.Fill(Me.DataSetTablas.Grupos)
            Me.VinculosPlusTableAdapter.Fill(Me.DataSetTablas.VinculosPlus)
            'Me.EstadoLBL.Text = "Sincronizado"
            'Me.EstadoLBL.ForeColor = Color.MediumBlue
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Guardar Grupos")
        Finally
            Me.Cursor = Cursors.Default
        End Try

        Me.GruposDataGridView.CurrentCell = Me.GruposDataGridView.Rows(R).Cells(C)
    End Sub

    Private Sub GruposToolStripDeshacer_Click(sender As Object, e As EventArgs) Handles GruposBindingNavigatorDehacer.Click
        Me.DataSetTablas.Grupos.RejectChanges()
        Me.DataSetTablas.VinculosPlus.RejectChanges()
    End Sub

    Private Sub ImagenPictureBox_Click(sender As Object, e As EventArgs) Handles ImagenPictureBox.Click
        Dim o As PictureBox = sender

        Dim Archivo As String

        If Me.OpenFileDialog.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Archivo = Me.OpenFileDialog.FileName
            o.Image = Drawing.Image.FromFile(Archivo)
        End If

    End Sub

    Private Sub ComunidadGuardarBTN_Click(sender As Object, e As EventArgs) Handles ComunidadGuardarBTN.Click

        Try
            Me.Cursor = Cursors.WaitCursor
            Me.ComunidadesBindingSource.EndEdit()
            Me.ComunidadesTableAdapter.Update(Me.DataSetTablas.Comunidades)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error Guardar Datos")
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub


    Private Sub ModelosBindingSource_CurrentItemChanged(sender As Object, e As EventArgs) Handles ModelosBindingSource.CurrentItemChanged
        Dim Suma As Object
        Dim Num As Integer
        Dim b As BindingSource = Me.ModelosBindingSource
        Dim row As DatosMsSQL.DataSetTablas.ModelosRow
        Dim filtro As String

        If Not IsNothing(b.Current) Then
            row = b.Current.row
            filtro = String.Format("Modelo = {0}", row.Id)
            Num = Me.DataSetTablas.Fincas.Compute("Count(Metros)", filtro)
            Suma = Me.DataSetTablas.Fincas.Compute("Sum(Metros)", filtro)
            Me.NumFincasTextBox.Text = String.Format("{0:N0}", Num)
            Me.SumaMetrosTextBox.Text = String.Format("{0:N2}", Suma)
        End If
    End Sub

    Private Sub PerteneciasGrupoComboBox_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles PerteneciasGrupoComboBox.SelectionChangeCommitted
        Dim o As ComboBox = sender
        Dim Pv As DataGridView = Me.PertenenciasVinculosDataGridView
        'Me.FKVinculosPlusFincasBindingSource.EndEdit()
        With Pv.CurrentRow
            .Cells("NombreGrupoDataGridViewTextBoxColumn").Value = o.Text
            .Cells("TotalM2DataGridViewTextBoxColumn").Value = DBNull.Value
            .Cells("CoeficienteDataGridViewTextBoxColumn").Value = DBNull.Value
        End With

    End Sub
    Private Sub GuardarTodo()
    
        With Me.GruposDataGridView.CurrentCell
            R(0) = .RowIndex
            C(0) = .ColumnIndex
        End With

        With ModelosDataGridView.CurrentCell
            R(1) = .RowIndex
            C(1) = .ColumnIndex
        End With
        R(1) = Me.ModelosBindingSource.Position
        R(2) = Me.FKFincasModelosBindingSource.Position

        Try
            Me.Cursor = Cursors.WaitCursor
            Me.FKVinculosPlusFincasBindingSource.EndEdit()
            Me.ComunidadesBindingSource.EndEdit()
            Me.GruposBindingSource.EndEdit()
            Me.VinculosPlusBindingSource.EndEdit()
            Me.ModelosBindingSource.EndEdit()

            Me.TableAdapterManager.UpdateAll(Me.DataSetTablas)
            MsgBox("Se han guardado todos los cambios en la configuracion", MsgBoxStyle.Information, Me.Text)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Guardar datos")
        Finally
            Me.Cursor = Cursors.Default
        End Try
        'Me.GruposDataGridView.CurrentCell = Me.GruposDataGridView.Rows(R(0)).Cells(C(0))
        'Me.ModelosDataGridView.CurrentCell = Me.ModelosDataGridView.Rows(R(1)).Cells(C(1))
    End Sub

    Private Sub CargarTodo()
        

        Try
            Me.Cursor = Cursors.WaitCursor
            Me.ComunidadesTableAdapter.Fill(Me.DataSetTablas.Comunidades)
            Me.ModelosTableAdapter.Fill(Me.DataSetTablas.Modelos)
            Me.GruposTableAdapter.Fill(Me.DataSetTablas.Grupos)
            Me.FincasTableAdapter.Fill(Me.DataSetTablas.Fincas)
            Me.VinculosPlusTableAdapter.Fill(Me.DataSetTablas.VinculosPlus)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error de descarga")
        Finally
            Me.Cursor = Cursors.Default

        End Try

        Me.FincaComboBox.SelectedIndex = -1

        Me.GruposDataGridView.CurrentCell = Me.GruposDataGridView.Rows(R(0)).Cells(C(0))
        ' Me.ModelosDataGridView.CurrentCell = Me.ModelosDataGridView.Rows(R(1)).Cells(C(1))
        Me.ModelosBindingSource.Position = R(1)
        Me.FKFincasModelosBindingSource.Position = R(2)
    End Sub
    Private Sub Posicionar()

    End Sub

End Class