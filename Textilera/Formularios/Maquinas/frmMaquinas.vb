Public Class frmMaquinas
    Private db As New TextileraEntities()
    Private editar As Boolean = False
    Private Sub frmMaquinas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvMaquinas.DataSource = obtenerMaquinas(db)
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim textBoxes As New List(Of TextBox) From {txtCodigo, txtMaquina, txtEstandar}
        Dim val = validarCamposVacios(textBoxes)

        If Not val("estado") = "ok" Then
            MsgCampoVacio(val("campo"))

        ElseIf editar = True Then
            Dim tMaq = db.Maquinas.FirstOrDefault(Function(x) x.MaquinaId = txtCodigo.Text)
            tMaq.NombreMaquina = txtMaquina.Text
            tMaq.Estandar = txtEstandar.Text
            tMaq.EstadoMaquina = chkEstado.Checked

            db.SaveChanges()
            dgvMaquinas.DataSource = obtenerMaquinas(db)
            nuevo()
            MsgActualizacionExitosa()
            editar = False

        Else
            Dim tMaq As New Maquinas()
            tMaq.NombreMaquina = txtMaquina.Text
            tMaq.Estandar = txtEstandar.Text
            tMaq.EstadoMaquina = chkEstado.Checked
            db.Maquinas.Add(tMaq)
            db.SaveChanges()

            dgvMaquinas.DataSource = obtenerMaquinas(db)

            nuevo()
            MsgRegistroExitoso()
        End If
    End Sub

    Private Sub nuevo()
        txtCodigo.Clear()
        txtEstandar.Clear()
        txtMaquina.Clear()
        chkEstado.Checked = False
        editar = False
    End Sub

    Private Sub dgvMaquinas_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvMaquinas.CellDoubleClick
        txtCodigo.Text = dgvMaquinas.CurrentRow.Cells(0).Value
        txtMaquina.Text = dgvMaquinas.CurrentRow.Cells(1).Value
        txtEstandar.Text = dgvMaquinas.CurrentRow.Cells(2).Value
        chkEstado.Checked = dgvMaquinas.CurrentRow.Cells(3).Value
        editar = True
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        nuevo()
        editar = False
    End Sub
End Class