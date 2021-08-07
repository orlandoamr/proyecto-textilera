Public Class frmHome
    Private Sub frmHome_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Sub switchPanel(ByVal panel As Form)

        Try
            panelContenedor.Controls.Clear()
            panel.TopLevel = False
            panelContenedor.Controls.Add(panel)
            panel.Show()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub ControlDeEstilosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ControlDeEstilosToolStripMenuItem.Click
        switchPanel(frmCategorias)
    End Sub
End Class