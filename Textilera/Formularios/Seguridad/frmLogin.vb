Public Class frmLogin
    Private db As New TextileraEntities()
    Private Sub btnIniciar_Click(sender As Object, e As EventArgs) Handles btnIniciar.Click
        Dim textBoxes As New List(Of TextBox) From {txtUsuario, txtContrasenia}
        Dim val = validarCamposVacios(textBoxes)

        If Not val("estado") = "ok" Then
            MsgCampoVacio(val("campo"))
        Else
            Dim pass As String = obtenerHash256(txtContrasenia.Text)
            Dim user As String = txtUsuario.Text
            Dim tUs = db.Usuarios.FirstOrDefault(Function(x) x.Usuario = user And x.Contrasenia = pass)

            If tUs Is Nothing Then
                MsgBox("Usuario o Contraseña incorrectos")
                txtContrasenia.Clear()
                txtUsuario.Clear()
            Else
                MsgBox("Bienvenido!")
            End If
        End If

    End Sub
End Class