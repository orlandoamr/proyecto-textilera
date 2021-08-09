Public Class frmLogin
    Private db As New TextileraEntities1()
    Private Sub btnIniciar_Click(sender As Object, e As EventArgs) Handles btnIniciar.Click
        Dim textBoxes As New List(Of TextBox) From {txtUsuario, txtContrasenia}
        Dim validar = validarCamposVacios(textBoxes)

        If Not validar(0) Then
            MsgCampoVacio(validar(1))
        Else
            Dim pass As String = obtenerHash256(txtContrasenia.Text)
            Dim user As String = txtUsuario.Text
            Dim tUs = db.Usuarios.FirstOrDefault(Function(x) x.Usuario = user And x.Contrasenia = pass)
            If tUs Is Nothing Then
                MsgBox("Usuario o Contraseña incorrectos")
                txtContrasenia.Clear()
                txtUsuario.Clear()
            Else
                frmHome.acceso = tUs.FKRolId
                frmMiCuenta.txtNombre.Text = tUs.Nombre
                frmMiCuenta.txtApellido.Text = tUs.Apellido
                frmMiCuenta.txtCorreo.Text = tUs.CorreoElectronico
                frmMiCuenta.txtUsuario.Text = tUs.Usuario
                frmMiCuenta.txtContrasenia.Text = tUs.Contrasenia
                frmMiCuenta.txtCodigo.Text = tUs.UsuarioId
                frmHome.lbNombre.Text = tUs.Nombre & " " & tUs.Apellido
                frmHome.Show()
                txtContrasenia.Clear()
                txtUsuario.Clear()
            End If
        End If

    End Sub
End Class