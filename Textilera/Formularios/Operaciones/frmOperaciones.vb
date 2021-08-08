Public Class frmOperaciones
    Private db As New TextileraEntities()
    Private editar As Boolean = False
    Private idMaquina As Long
    Private Sub frmOperaciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvOperaciones.DataSource = obtenerOperaciones(db)
        dgvOperaciones.Columns("IDMaquina").Visible = False

        cmbMaquinas.DataSource = obtenerMaquinasHabilitadas(db)
        cmbMaquinas.DisplayMember = "Nombre"
        cmbMaquinas.ValueMember = "IDMaquina"
        cmbMaquinas.SelectedIndex = 0
    End Sub

    Private Sub nuevo()
        txtCodigo.Clear()
        txtNombre.Clear()
        cmbMaquinas.SelectedIndex = -1
        chkEstado.Checked = False
        editar = False
    End Sub

    Private Sub dgvOperaciones_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvOperaciones.CellDoubleClick
        txtCodigo.Text = dgvOperaciones.CurrentRow.Cells(0).Value
        txtNombre.Text = dgvOperaciones.CurrentRow.Cells(1).Value
        idMaquina = dgvOperaciones.CurrentRow.Cells(2).Value
        chkEstado.Checked = dgvOperaciones.CurrentRow.Cells(4).Value
        editar = True
    End Sub

    Private Sub btnGuardar_Click_1(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If txtNombre.Text = "" Then
            MsgCampoVacio("nombre")

        ElseIf (editar = True) Then
            Dim tOp = db.Operaciones.FirstOrDefault(Function(x) x.OperacionId = txtCodigo.Text)
            tOp.NombreOperacion = txtNombre.Text
            tOp.FKMaquinaId = cmbMaquinas.SelectedValue
            tOp.EstadoOperacion = chkEstado.Checked
            db.SaveChanges()

            nuevo()
            MsgActualizacionExitosa()

            dgvOperaciones.DataSource = obtenerOperaciones(db)

        Else
            Dim tOp As New Operaciones()
            tOp.NombreOperacion = txtNombre.Text
            tOp.FKMaquinaId = cmbMaquinas.SelectedValue
            tOp.EstadoOperacion = chkEstado.Checked
            db.Operaciones.Add(tOp)
            db.SaveChanges()

            nuevo()
            MsgRegistroExitoso()

            dgvOperaciones.DataSource = obtenerOperaciones(db)
        End If
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        nuevo()
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub
End Class