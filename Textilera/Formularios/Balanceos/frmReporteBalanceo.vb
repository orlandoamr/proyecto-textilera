Public Class frmReporteBalanceo
    Private Sub frmReporteBalanceo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataSet1.EnforceConstraints = False
    End Sub

    Private Sub btnBuscarCategorias_Click(sender As Object, e As EventArgs) Handles btnBuscarCategorias.Click
        frmBuscarBalanceos.Show()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        'TODO: This line of code loads data into the 'DataSet1.Balanceos' table. You can move, or remove it, as needed.
        If txtEstiloId.Text = "" Then
            MsgCampoVacio("balanceo")

        Else
            Me.BalanceosTableAdapter.Fill(Me.DataSet1.Balanceos, Val(txtEstiloId.Text))
            Me.ReportViewer1.RefreshReport()
        End If

    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub
End Class