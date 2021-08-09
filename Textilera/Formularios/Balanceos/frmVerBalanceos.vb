Public Class frmVerBalanceos
    Private db As New TextileraEntities1()
    Private Sub txtEstiloId_TextChanged(sender As Object, e As EventArgs) Handles txtEstiloId.TextChanged
        If txtEstiloId.Text = "" Then
            dgvEstilos.DataSource = Nothing
        Else
            dgvEstilos.DataSource = obtenerBalanceos(db, Val(txtEstiloId.Text))
        End If
    End Sub

    Private Sub btnBuscarCategorias_Click(sender As Object, e As EventArgs) Handles btnBuscarCategorias.Click
        frmBuscarBalanceos.Show()
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        txtEstiloId.Clear()
        dgvEstilos.DataSource = Nothing
    End Sub
End Class