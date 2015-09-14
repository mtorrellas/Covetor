Public NotInheritable Class Acerca

    Private Sub Acerca_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Establezca el título del formulario.
        Dim ApplicationTitle As String
        If My.Application.Info.Title <> "" Then
            ApplicationTitle = My.Application.Info.Title
        Else
            ApplicationTitle = System.IO.Path.GetFileNameWithoutExtension(My.Application.Info.AssemblyName)
        End If
        Me.Text = String.Format("Acerca de {0}", ApplicationTitle)
        ' Inicialice todo el texto mostrado en el cuadro Acerca de.
        ' TODO: personalice la información del ensamblado de la aplicación en el panel "Aplicación" del 
        '    cuadro de diálogo propiedades del proyecto (bajo el menú "Proyecto").
        Me.LabelProductName.Text = My.Application.Info.ProductName
        Me.LabelVersion.Text = String.Format("Versión: {0}", My.Application.Info.Version.ToString)
        'Me.LabelCopyright.Text = My.Application.Info.Copyright 
        Me.LabelCopyright.Text = String.Format(My.Application.Info.Copyright, Now.Year)
        Me.LabelCompanyName.Text = My.Application.Info.CompanyName
        Me.TextBoxDescription.Text = My.Application.Info.Description
        'Me.TextBoxDescription.Text = Application.LocalUserAppDataPath

        Me.AutorTextBox.Text = String.Format("Autor: {0}" & vbCrLf & _
                                             "Telefono: {1}", My.Settings.Autor, "610 316131")

        'Me.AutorTextBox.Text = My.
    End Sub

    Private Sub OKButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OKButton.Click
        Me.Close()
    End Sub

    Private Sub LabelCopyright_Click(sender As Object, e As EventArgs) Handles LabelCopyright.Click

    End Sub
End Class
