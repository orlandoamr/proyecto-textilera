Public Class frmBuscarCategorias
    Private db As New TextileraEntities()
    Private Sub frmBuscarCategorias_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvCategorias.DataSource = obtenerCategorias(db)
    End Sub

    Private Sub dgvCategorias_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCategorias.CellDoubleClick
        frmEstilos.txtCategoria.Text = dgvCategorias.CurrentRow.Cells(1).Value
        frmEstilos.idCategoria = dgvCategorias.CurrentRow.Cells(0).Value
        Me.Close()
    End Sub
End Class