Imports System.Threading
Imports System.Globalization

Public Class GestionGastos

    Dim filaTmp As DatosMsSQL.DataSetTablas.GastosPlusRow
    Enum Destinos As Integer
        Comunidad = 1
        Agrupacion = 2
        Finca = 3
        Otros = 4
    End Enum

    Private Property SumaImporte As Decimal
        Get
            Return Me.DataSetTablas.GastosPlus.Compute("Sum(Importe)", "")
        End Get
        Set(value As Decimal)

        End Set
    End Property

    Private Sub GestionGastos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.FechaDateTimePicker.Value = Today

        Me.EjercicioComboBox.Text = Year(Today).ToString
    End Sub

    Private Sub GestionGastos_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Dim x() As String = System.Enum.GetNames(GetType(Destinos))
        Dim row As DatosMsSQL.DataSetTablas.DestinosRow

        For Each d As String In x
            Dim r As DataRowView = Me.DestinosBindingSource.AddNew()
            row = r.Row
            row.Destino = d
            row.Valor = System.Enum.Parse(GetType(Destinos), d)
        Next

        Try
            Me.Cursor = Cursors.WaitCursor
            Me.ProveedoresTableAdapter.Fill(Me.DataSetTablas.Proveedores)
            Me.ModelosTableAdapter.Fill(Me.DataSetTablas.Modelos)
            Me.GruposTableAdapter.Fill(Me.DataSetTablas.Grupos)
            Me.FincasTableAdapter.Fill(Me.DataSetTablas.Fincas)

            Me.EjercicioComboBox.Items.AddRange(general.ListaEjercicios)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Descargando datos")
        Finally
            Me.Cursor = Cursors.Default
        End Try

    End Sub

    Private Sub DestinoComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DestinoComboBox.SelectedIndexChanged
        Dim o = TryCast(sender, ComboBox)
        'Dim v As Object = o.SelectedValue
        'Dim d As Destinos
        If IsDBNull(o.SelectedValue) Or IsNothing(o.SelectedValue) Then
            Return
        End If

        'd = System.Enum.Parse(GetType(Destinos), o.SelectedValue)


        Me.ModelosComboBox.Enabled = (o.SelectedValue = Destinos.Finca)
        Me.FincasListBox.Enabled = Me.ModelosComboBox.Enabled
        Me.GruposComboBox.Enabled = (o.SelectedValue = Destinos.Agrupacion)

    End Sub

    Private Sub GruposBindingSource_AddingNew(sender As Object, e As System.ComponentModel.AddingNewEventArgs) Handles GastosBindingSource.AddingNew
        Dim o = TryCast(sender, BindingSource)
        Dim el = TryCast(o.Current, DataRowView)
       
        If Not IsNothing(el) Then
         
            Me.filaTmp = el.Row
            o.EndEdit()
        End If
    End Sub

    Private Sub GastosBindingSource_BindingComplete(sender As Object, e As BindingCompleteEventArgs) Handles GastosBindingSource.BindingComplete
        Dim o = TryCast(sender, BindingSource)
        Dim el = TryCast(o.Current, DataRowView)

        Dim fila As DatosMsSQL.DataSetTablas.GastosPlusRow

        If IsNothing(el) Then
            Return
        End If

        'If Not IsNothing(el) And Not IsNothing(filaTmp) Then
        fila = el.Row

        If el.IsNew Then
            If IsNothing(Me.filaTmp) Then

            Else
                With fila
                    .Fecha = filaTmp.Fecha
                    .ProveedorID = filaTmp.ProveedorID
                    .TipoDestino = filaTmp.TipoDestino
                    .GrupoID = If(.TipoDestino = Destinos.Agrupacion, filaTmp.GrupoID, -1)
                    .Grupo = If(.TipoDestino = Destinos.Agrupacion, filaTmp.Grupo, "")
                    .FincaID = If(.TipoDestino = Destinos.Finca, filaTmp.FincaID, -1)
                    .Finca = If(.TipoDestino = Destinos.Finca, filaTmp.Finca, "")
                End With
            End If


            el.EndEdit()
            o.MovePrevious()
        End If
        'End If
    End Sub

    Private Sub BindingNavigatorGuardar_Click(sender As Object, e As EventArgs) Handles BindingNavigatorGuardar.Click
        Dim i As Integer = Me.GastosBindingSource.Position

        Try
            Me.Cursor = Cursors.WaitCursor
            Me.GastosBindingSource.EndEdit()
            Me.GastosPlusTableAdapter.Update(Me.DataSetTablas.GastosPlus)
            'Me.GastosBindingSource.Position = i
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Guardar datos")
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub EjercicioComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles EjercicioComboBox.SelectedIndexChanged
        Dim o = TryCast(sender, ToolStripComboBox)
        Dim fecha As New System.DateTime(o.Text, Today.Month, Today.Day)

        Me.DataSetTablas.GastosPlus.Clear()

        Me.FechaDateTimePicker.Value = fecha
    End Sub

    Private Sub PresentarGastos_Click(sender As Object, e As EventArgs) Handles PresentarGastos.Click

    End Sub

    Private Sub ProveedorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProveedorToolStripMenuItem.Click
        Dim o = TryCast(sender, ToolStripMenuItem)
        Dim r As MsgBoxResult

        Me.GastosBindingSource.EndEdit()

        If Me.DataSetTablas.HasChanges Then
            r = MsgBox("Hay cambios pendientes de guardar, si continuamos se perderan" & vbLf & vbLf & " ¿Continuar?",
                       MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo,
                       "Ver datos")
            If r <> MsgBoxResult.Yes Then
                Return
            End If
        End If

        If o.CheckState = CheckState.Checked Then
            Me.DataSetTablas.GastosPlus.Clear()
        Else
            Try
                Me.GastosPlusTableAdapter.FillByProveedor(DataSetTablas.GastosPlus, Me.EjercicioComboBox.Text, Me.ProveedorComboBox.SelectedValue)

            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Cargar datos")
            End Try
        End If
        Me.ImporteSumTextBox.Text = Format(Me.SumaImporte, "C2")
        'Me.ProveedorComboBox.Enabled = o.Checked
        o.Checked = Not o.Checked
    End Sub

    Private Sub DestinoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DestinoToolStripMenuItem.Click
        Dim o = TryCast(sender, ToolStripMenuItem)
        Dim r As MsgBoxResult

        Me.GastosBindingSource.EndEdit()

        If Me.DataSetTablas.HasChanges Then
            r = MsgBox("Hay cambios pendientes de guardar, si continuamos se perderan" & vbLf & vbLf & " ¿Continuar?",
                       MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo,
                       "Ver datos")
            If r <> MsgBoxResult.Yes Then
                Return
            End If
        End If

        Try
            Select Case Me.DestinoComboBox.SelectedValue
                Case Destinos.Comunidad
                    Me.GastosPlusTableAdapter.FillByDestino(Me.DataSetTablas.GastosPlus, Me.EjercicioComboBox.Text, Me.DestinoComboBox.SelectedValue)
                Case Destinos.Agrupacion
                    Me.GastosPlusTableAdapter.FillByGrupo(Me.DataSetTablas.GastosPlus, Me.EjercicioComboBox.Text, Me.DestinoComboBox.SelectedValue, Me.GruposComboBox.SelectedValue)
                Case Destinos.Finca
                    Me.GastosPlusTableAdapter.FillByFinca(Me.DataSetTablas.GastosPlus, Me.EjercicioComboBox.Text, Me.DestinoComboBox.SelectedValue, Me.FincasListBox.SelectedValue)
             
            End Select
            o.Checked = Not o.Checked
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Cargar datos")
        End Try

        Me.ImporteSumTextBox.Text = String.Format("{0:C2}", Me.SumaImporte)


    End Sub

    Private Sub TodosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TodosToolStripMenuItem.Click
        Dim o = TryCast(sender, ToolStripMenuItem)
        Dim r As MsgBoxResult

        Me.GastosBindingSource.EndEdit()

        If Me.DataSetTablas.HasChanges Then
            r = MsgBox("Hay cambios pendientes de guardar, si continuamos se perderan" & vbLf & vbLf & " ¿Continuar?",
                       MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo,
                       "Ver datos")
            If r <> MsgBoxResult.Yes Then
                Return
            End If
        End If

        If o.CheckState = CheckState.Checked Then
            Me.DataSetTablas.GastosPlus.Clear()
        Else
            Try
                Me.GastosPlusTableAdapter.FillByTodos(DataSetTablas.GastosPlus, Me.EjercicioComboBox.Text)
                Me.ImporteSumTextBox.Text = String.Format("{0:C2}", Me.SumaImporte)
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Cargar datos")
            End Try
        End If

        Me.ProveedorComboBox.Enabled = True
        Me.DestinoComboBox.Enabled = True

        For Each el As ToolStripMenuItem In Me.PresentarGastos.DropDownItems
            el.Checked = False
        Next

    End Sub
End Class