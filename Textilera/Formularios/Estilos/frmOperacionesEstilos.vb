Public Class frmOperacionesEstilos
    Private db As New TextileraEntities()
    Private Sub frmOperacionesEstilos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvOperaciones.DataSource = obtenerOperacionesHabilitadas(db)
    End Sub

    Private Sub dgvOperaciones_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvOperaciones.CellDoubleClick
        txtIdOperacion.Text = dgvOperaciones.CurrentRow.Cells(0).Value
        txtNombre.Text = dgvOperaciones.CurrentRow.Cells(1).Value
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim textBoxes As New List(Of TextBox) From {txtIdOperacion, txtNombre, txtNumero, txtSah}
        Dim val = validarCamposVacios(textBoxes)

        If Not val("estado") = "ok" Then
            MsgCampoVacio(val("campo"))
        Else
            Dim rowId As Integer = dgvEstilo.Rows.Add()
            Dim row As DataGridViewRow = dgvEstilo.Rows(rowId)
            row.Cells("IDOperacion").Value = txtIdOperacion.Text
            row.Cells("Numero").Value = txtNumero.Text
            row.Cells("Nombre").Value = txtNombre.Text
            row.Cells("SAH").Value = txtSah.Text
        End If
    End Sub

    Private Sub txtEstiloId_TextChanged(sender As Object, e As EventArgs) Handles txtEstiloId.TextChanged

    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        frmBuscarEstilo.Show()
    End Sub
End Class