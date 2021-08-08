Public Class frmBalanceos
    Private db As New TextileraEntities()
    Private Sub frmBalanceos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtEstiloId.Text = ""
        'dgvBalanceos.Rows("NumOperacion").ReadOnly = False
    End Sub

    Private Sub txtEstiloId_TextChanged(sender As Object, e As EventArgs) Handles txtEstiloId.TextChanged
        If txtEstiloId.Text = "" Then
            dgvBalanceos.Rows.Clear()

        Else
            dgvBalanceos.Rows.Clear()
            Dim op As New DataTable()
            op = obtenerOperacionesEstilo(db, txtEstiloId.Text)

            For Each fila In op.Rows
                Dim rowId As Integer = dgvBalanceos.Rows.Add()
                Dim row As DataGridViewRow = dgvBalanceos.Rows(rowId)
                row.Cells("Numero").Value = fila("#")
                row.Cells("NombreOperacion").Value = fila("Nombre")
                row.Cells("EstandarHora").Value = fila("Sah")

            Next
        End If
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        frmBuscarEstilo.Show()
    End Sub
End Class