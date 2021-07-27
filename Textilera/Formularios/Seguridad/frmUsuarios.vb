Public Class frmUsuarios
    Private db As New TextileraEntities()
    Private editar As Boolean = False
    Private Sub frmUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvUsuarios.DataSource = obtenerUsuarios(db)
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim textBoxes As New List(Of TextBox) From {txtNombre, txtApellido, txtCorreo, txtUsuario, txtContrasenia}
        Dim val = validarCamposVacios(textBoxes)

        If Not val("estado") = "ok" Then
            MsgCampoVacio(val("campo"))

        ElseIf (editar = True) Then
            Dim tUs = db.Usuarios.FirstOrDefault(Function(x) x.UsuarioId = txtCodigo.Text)
            tUs.Nombre = txtNombre.Text
            tUs.Apellido = txtApellido.Text
            tUs.FechaNacimiento.ToShortDateString()
            tUs.CorreoElectronico = txtCorreo.Text
            tUs.Usuario = txtUsuario.Text
            tUs.Contrasenia = txtUsuario.Text
            tUs.EstadoUsuario = chkEstado.Checked
            db.SaveChanges()

            dgvUsuarios.DataSource = obtenerUsuarios(db)

            nuevo()
            MsgActualizacionExitosa()
            editar = False

        Else
            Dim tUs As New Usuarios()
            tUs.Nombre = txtNombre.Text
            tUs.Apellido = txtApellido.Text
            tUs.FechaNacimiento.ToShortDateString()
            tUs.CorreoElectronico = txtCorreo.Text
            tUs.Usuario = txtUsuario.Text
            tUs.Contrasenia = txtUsuario.Text
            tUs.EstadoUsuario = chkEstado.Checked
            db.Usuarios.Add(tUs)
            db.SaveChanges()

            dgvUsuarios.DataSource = obtenerUsuarios(db)

            nuevo()
            MsgRegistroExitoso()
        End If
    End Sub

    Private Sub nuevo()
        txtCodigo.Clear()
        txtNombre.Clear()
        txtApellido.Clear()
        txtCorreo.Clear()
        txtUsuario.Clear()
        txtContrasenia.Clear()
        chkEstado.Checked = False
        editar = False
    End Sub
End Class