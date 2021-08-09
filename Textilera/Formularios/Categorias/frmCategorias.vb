Public Class frmCategorias
    Private editar As Boolean = False
    Private categorias As New Categorias()
    Private db As New TextileraEntities1()

    Private Sub frmCategorias_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvCategorias.DataSource = obtenerCategorias(db)
    End Sub

    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

        Dim textBoxes As New List(Of TextBox) From {txtCategoria, txtDescripcion}
        Dim validacion = validarCamposVacios(textBoxes)

        If Not validacion(0) Then
            MsgCampoVacio(validacion(1))

        ElseIf editar = True Then
            Dim tCat = db.Categorias.FirstOrDefault(Function(x) x.CategoriaId = txtCodigo.Text)
            tCat.NombreCategoria = txtCategoria.Text
            tCat.DescripcionCategoria = txtDescripcion.Text
            tCat.EstadoCategoria = chkEstado.Checked

            db.SaveChanges()
            nuevo()
            dgvCategorias.DataSource = obtenerCategorias(db)
            MsgActualizacionExitosa()
            editar = False

        Else
            Dim tCat As New Categorias()
            tCat.NombreCategoria = txtCategoria.Text
            tCat.DescripcionCategoria = txtDescripcion.Text
            tCat.EstadoCategoria = chkEstado.Checked
            db.Categorias.Add(tCat)
            db.SaveChanges()

            dgvCategorias.DataSource = obtenerCategorias(db)

            nuevo()
            MsgRegistroExitoso()
        End If

    End Sub

    Private Sub dgvCategorias_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCategorias.CellDoubleClick
        txtCodigo.Text = dgvCategorias.CurrentRow.Cells(0).Value
        txtCategoria.Text = dgvCategorias.CurrentRow.Cells(1).Value
        txtDescripcion.Text = dgvCategorias.CurrentRow.Cells(2).Value
        chkEstado.Checked = dgvCategorias.CurrentRow.Cells(3).Value
        editar = True
    End Sub
    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        nuevo()
        editar = False
    End Sub

    Private Sub nuevo()
        txtCategoria.Clear()
        txtCodigo.Clear()
        txtDescripcion.Clear()
        chkEstado.Checked = False
        editar = False
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub
End Class