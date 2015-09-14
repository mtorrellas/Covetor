Public Class Proveedores

    Private Sub Proveedores_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            Me.Cursor = Cursors.WaitCursor
            Me.ProveedoresTableAdapter.Fill(Me.DataSetTablas.Proveedores)
            Me.GastosTableAdapter.Fill(Me.DataSetTablas.Gastos)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Leyendo Datos")
        Finally
            Me.Cursor = Cursors.Default
        End Try

    End Sub

    Private Sub Proveedores_Shown(sender As Object, e As EventArgs) Handles Me.Shown

    End Sub

    Private Sub BindingNavigatorGuardar_Click(sender As Object, e As EventArgs) Handles BindingNavigatorGuardar.Click
        Try
            Me.Cursor = Cursors.WaitCursor
            Me.ProveedoresBindingSource.EndEdit()
            Me.ProveedoresTableAdapter.Update(Me.DataSetTablas.Proveedores)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Guardar Datos")
        Finally
            Me.Cursor = Cursors.Default
        End Try


    End Sub

    Private Sub ImagenPictureBox_Click(sender As Object, e As EventArgs) Handles ImagenPictureBox.Click
        Dim o As PictureBox = sender

        Dim Archivo As String

        If Me.OpenFileDialog.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Archivo = Me.OpenFileDialog.FileName
            o.Image = Drawing.Image.FromFile(Archivo)
        End If
    End Sub
End Class