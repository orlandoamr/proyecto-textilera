Public Class frmUsuarios
    Private db As New TextileraEntities()
    Private editar As Boolean = False
    Private Sub frmUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvUsuarios.DataSource = obtenerUsuarios(db)
        cmbRoles.DataSource = obtenerRoles(db)
        cmbRoles.DisplayMember = "DescripcionRol"
        cmbRoles.ValueMember = "IDRol"
        cmbRoles.SelectedIndex = 0
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

    Private Sub dgvUsuarios_DoubleClick(sender As Object, e As EventArgs) Handles dgvUsuarios.DoubleClick
        txtCodigo.Text = dgvUsuarios.CurrentRow.Cells(0).Value
        chkEstado.Checked = dgvUsuarios.CurrentRow.Cells(7).Value

        editar = True
    End Sub

    Private Sub btnGuardar_Click_1(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim textBoxes As New List(Of TextBox) From {txtNombre, txtApellido, txtCorreo, txtUsuario, txtContrasenia}
        Dim validar = validarCamposVacios(textBoxes)

        If Not validar(0) And editar = False Then
            MsgCampoVacio(validar(1))

        ElseIf Not ValidEmail(txtCorreo.Text) And editar = False Then
            MessageBox.Show("El correo electrónico es inválido")

        ElseIf txtUsuario.Text.Length < 4 And editar = False Then
            MessageBox.Show("El usuario debe tener mínimo 4 caracteres")

        ElseIf txtContrasenia.Text.Length < 6 And editar = False Then
            MessageBox.Show("La contraseña debe tener mínimo 6 caracteres")
        Else
            If editar = True Then
                Dim tUs = db.Usuarios.FirstOrDefault(Function(x) x.UsuarioId = txtCodigo.Text)
                tUs.EstadoUsuario = chkEstado.Checked
                db.SaveChanges()

                dgvUsuarios.DataSource = obtenerUsuarios(db)

                nuevo()
                MsgActualizacionExitosa()
            Else
                Dim tUs As New Usuarios()
                tUs.Nombre = txtNombre.Text
                tUs.Apellido = txtApellido.Text
                tUs.CorreoElectronico = txtCorreo.Text
                tUs.Usuario = txtUsuario.Text
                tUs.Contrasenia = obtenerHash256(txtContrasenia.Text)
                tUs.EstadoUsuario = chkEstado.Checked
                tUs.FKRolId = cmbRoles.SelectedValue
                db.Usuarios.Add(tUs)
                db.SaveChanges()

                dgvUsuarios.DataSource = obtenerUsuarios(db)
                nuevo()
                MsgRegistroExitoso()
            End If


        End If
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        nuevo()
    End Sub
End Class