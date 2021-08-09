Public Class frmMiCuenta

    Private db As New TextileraEntities1()
    Private Sub frmMiCuenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim textBoxes As New List(Of TextBox) From {txtNombre, txtApellido, txtCorreo, txtUsuario, txtContrasenia}
        Dim validar = validarCamposVacios(textBoxes)

        If Not validar(0) Then
            MsgCampoVacio(validar(1))

        ElseIf Not ValidEmail(txtCorreo.Text) Then
            MessageBox.Show("El correo electrónico es inválido")

        ElseIf txtUsuario.Text.Length < 4 Then
            MessageBox.Show("El usuario debe tener mínimo 4 caracteres")

        ElseIf txtContrasenia.Text.Length < 6 Then
            MessageBox.Show("La contraseña debe tener mínimo 6 caracteres")
        Else

            Dim tUs = db.Usuarios.FirstOrDefault(Function(x) x.UsuarioId = txtCodigo.Text)
            tUs.Nombre = txtNombre.Text
            tUs.Apellido = txtApellido.Text
            tUs.CorreoElectronico = txtCorreo.Text
            tUs.Usuario = txtUsuario.Text
            tUs.Contrasenia = obtenerHash256(txtContrasenia.Text)
            db.SaveChanges()

            MsgActualizacionExitosa()

        End If
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub
End Class