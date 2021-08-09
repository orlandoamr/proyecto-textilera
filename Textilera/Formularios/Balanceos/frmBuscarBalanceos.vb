Public Class frmBuscarBalanceos
    Private db As New TextileraEntities1()
    Private Sub frmBuscarBalanceos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvEstilos.DataSource = obtenerBalanceos2(db)
    End Sub

    Private Sub dgvEstilos_DoubleClick(sender As Object, e As EventArgs) Handles dgvEstilos.DoubleClick
        frmVerBalanceos.txtEstiloId.Text = dgvEstilos.CurrentRow.Cells(0).Value
        frmReporteBalanceo.txtEstiloId.Text = dgvEstilos.CurrentRow.Cells(0).Value
        Me.Close()
    End Sub
End Class