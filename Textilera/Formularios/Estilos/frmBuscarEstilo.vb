Public Class frmBuscarEstilo
    Private db As New TextileraEntities()
    Private Sub frmBuscarEstilo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvEstilos.DataSource = obtenerEstilosHabilitados(db)
    End Sub

    Private Sub dgvEstilos_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvEstilos.CellDoubleClick
        frmOperacionesEstilos.txtEstiloId.Text = dgvEstilos.CurrentRow.Cells(0).Value
        frmBalanceos.txtEstiloId.Text = dgvEstilos.CurrentRow.Cells(0).Value
        Me.Close()
    End Sub
End Class