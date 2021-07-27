Public Class frmEstilos
    Private db As New TextileraEntities()
    Public idCategoria As Integer
    Private editar As Boolean = False
    Private Sub frmEstilos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvEstilos.DataSource = obtenerEstilos(db)
        dgvEstilos.Columns("IdCategoria").Visible = False
    End Sub

    Private Sub btnBuscarCategorias_Click(sender As Object, e As EventArgs) Handles btnBuscarCategorias.Click
        frmBuscarCategorias.Show()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim textBoxes As New List(Of TextBox) From {txtCategoria, txtCodigo, txtDescripcion}
        Dim val = validarCamposVacios(textBoxes)

        If Not val("estado") = "ok" Then
            MsgCampoVacio(val("campo"))

        ElseIf editar = True Then
            Dim tEs = db.Estilos.FirstOrDefault(Function(x) x.EstiloId = txtCodigo.Text)
            tEs.EstiloId = txtCodigo.Text
            tEs.DescripcionEstilo = txtDescripcion.Text
            tEs.FKCategoriaId = idCategoria
            tEs.EstadoEstilo = chkEstado.Checked

            db.SaveChanges()
            nuevo()
            MsgActualizacionExitosa()
            editar = False
            dgvEstilos.DataSource = obtenerEstilos(db)

        Else
            Dim tEs As New Estilos()
            tEs.EstiloId = txtCodigo.Text
            tEs.DescripcionEstilo = txtDescripcion.Text
            tEs.FKCategoriaId = idCategoria
            tEs.EstadoEstilo = chkEstado.Checked
            db.Estilos.Add(tEs)
            db.SaveChanges()

            dgvEstilos.DataSource = obtenerEstilos(db)

            nuevo()
            MsgRegistroExitoso()
        End If
    End Sub

    Private Sub nuevo()
        txtCategoria.Clear()
        txtCodigo.Clear()
        txtDescripcion.Clear()
        chkEstado.Checked = False
        editar = False
    End Sub
    Private Sub dgvEstilos_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvEstilos.CellDoubleClick
        idCategoria = dgvEstilos.CurrentRow.Cells(3).Value
        txtCodigo.Text = dgvEstilos.CurrentRow.Cells(0).Value
        txtDescripcion.Text = dgvEstilos.CurrentRow.Cells(1).Value
        txtCategoria.Text = dgvEstilos.CurrentRow.Cells(2).Value
        chkEstado.Checked = dgvEstilos.CurrentRow.Cells(4).Value
        editar = True
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        nuevo()
        editar = False
    End Sub
End Class