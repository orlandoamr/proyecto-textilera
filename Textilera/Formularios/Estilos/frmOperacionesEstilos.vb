Public Class frmOperacionesEstilos
    Private db As New TextileraEntities1()
    Private numeroOperacion As Integer = 1
    Private Sub frmOperacionesEstilos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvOperaciones.DataSource = obtenerOperacionesHabilitadas(db)
    End Sub

    Private Sub dgvOperaciones_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvOperaciones.CellDoubleClick
        txtIdOperacion.Text = dgvOperaciones.CurrentRow.Cells(0).Value
        txtNombre.Text = dgvOperaciones.CurrentRow.Cells(1).Value
        actualizarNumero()
    End Sub



    Private Sub txtEstiloId_TextChanged(sender As Object, e As EventArgs) Handles txtEstiloId.TextChanged
        If txtEstiloId.Text = "" Then

        Else
            dgvEstilo.Rows.Clear()
            Dim op As New DataTable()
            op = obtenerOperacionesEstilo(db, txtEstiloId.Text)

            For Each fila In op.Rows
                Dim rowId As Integer = dgvEstilo.Rows.Add()
                Dim row As DataGridViewRow = dgvEstilo.Rows(rowId)
                row.Cells("IDOperacion").Value = fila("ID")
                row.Cells("Numero").Value = fila("#")
                row.Cells("Nombre").Value = fila("Nombre")
                row.Cells("SAH").Value = fila("Sah")
            Next

            numeroOperacion = op.Rows.Count() + 1
        End If

    End Sub
    Private Sub btnBuscarCategorias_Click(sender As Object, e As EventArgs) Handles btnBuscarCategorias.Click
        frmBuscarEstilo.Show()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim textBoxes As New List(Of TextBox) From {txtEstiloId, txtIdOperacion, txtNombre, txtNumero, txtSah}
        Dim validar = validarCamposVacios(textBoxes)

        If Not validar(0) Then
            MsgCampoVacio(validar(1))
        Else
            Dim operacion As Boolean = True
            Dim numero As Boolean = True

            For Each fila As DataGridViewRow In dgvEstilo.Rows
                If fila.Cells("IDOperacion").Value = Val(txtIdOperacion.Text) Then
                    operacion = False
                ElseIf fila.Cells("Numero").Value = Val(txtNumero.Text) Then
                    numero = False
                End If
            Next

            If Not operacion Then
                MessageBox.Show("Ya se ha agregado esta operación al estilo")
            ElseIf Not numero Then
                MessageBox.Show("Ya existe este número de operación")
            Else
                Dim rowId As Integer = dgvEstilo.Rows.Add()
                Dim row As DataGridViewRow = dgvEstilo.Rows(rowId)
                row.Cells("IDOperacion").Value = txtIdOperacion.Text
                row.Cells("Numero").Value = txtNumero.Text
                row.Cells("Nombre").Value = txtNombre.Text
                row.Cells("SAH").Value = txtSah.Text
                numeroOperacion += 1
                txtIdOperacion.Clear()
                txtNombre.Clear()
                txtNumero.Clear()
                txtSah.Clear()
            End If

        End If
    End Sub

    Private Sub btnDel_Click(sender As Object, e As EventArgs) Handles btnDel.Click
        If dgvEstilo.SelectedRows.Count = 0 Then
            MessageBox.Show("Seleccione una operacion del estilo")
        Else
            Dim id = dgvEstilo.CurrentCell.RowIndex
            dgvEstilo.Rows.RemoveAt(id)
            numeroOperacion -= 1
        End If
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If dgvEstilo.Rows.Count = 0 Then
            MessageBox.Show("Ingrese al menos una operación al estilo")
        Else
            db.eliminarDetalle(txtEstiloId.Text)

            For Each fila As DataGridViewRow In dgvEstilo.Rows
                Dim dt As New DetalleEstilosOperaciones()
                dt.OperacionId = fila.Cells("IDOperacion").Value
                dt.NumeroOperacion = fila.Cells("Numero").Value
                dt.SAH = fila.Cells("SAH").Value
                dt.EstiloId = txtEstiloId.Text
                db.DetalleEstilosOperaciones.Add(dt)
                db.SaveChanges()
                dt = Nothing
            Next
            MsgRegistroExitoso()
            nuevo()
        End If
    End Sub

    Private Sub actualizarNumero()
        txtNumero.Text = numeroOperacion
    End Sub

    Public Sub nuevo()
        txtEstiloId.Clear()
        txtIdOperacion.Clear()
        txtNombre.Clear()
        txtNumero.Clear()
        txtSah.Clear()
        dgvEstilo.Rows.Clear()
        numeroOperacion = 0
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        nuevo()
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub
End Class