Public Class frmHome
    Dim currentInstance As Form
    Public idUsuario As Integer
    Public acceso As Integer
    Sub switchPanel(ByVal panel As Form)
        If Not currentInstance Is Nothing Then
            currentInstance.Close()
        End If

        Try
            panelContenedor.Controls.Clear()
            panel.TopLevel = False
            panelContenedor.Controls.Add(panel)
            panel.Show()
            currentInstance = panel
        Catch ex As Exception

        End Try

    End Sub

    Private Sub ControlDeEstilosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ControlDeEstilosToolStripMenuItem.Click
        switchPanel(frmCategorias)
    End Sub

    Private Sub ControlDeEstilosToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ControlDeEstilosToolStripMenuItem1.Click
        switchPanel(frmEstilos)
    End Sub

    Private Sub AsignarOperacionesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AsignarOperacionesToolStripMenuItem.Click
        switchPanel(frmOperacionesEstilos)
    End Sub

    Private Sub OperacionesToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles OperacionesToolStripMenuItem1.Click
        switchPanel(frmOperaciones)
    End Sub

    Private Sub MáquinasToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles MáquinasToolStripMenuItem1.Click
        switchPanel(frmMaquinas)
    End Sub

    Private Sub UsuariosToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles UsuariosToolStripMenuItem1.Click
        switchPanel(frmUsuarios)
    End Sub

    Private Sub ControlDeBalanceosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ControlDeBalanceosToolStripMenuItem.Click
        switchPanel(frmBalanceos)
    End Sub

    Private Sub VerBalanceosToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles VerBalanceosToolStripMenuItem1.Click
        switchPanel(frmVerBalanceos)
    End Sub

    Private Sub GenerarReporteToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles GenerarReporteToolStripMenuItem1.Click
        switchPanel(frmReporteBalanceo)
    End Sub

    Private Sub frmHome_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        frmLogin.Hide()
        If acceso = 2 Then
            UsuariosToolStripMenuItem1.Enabled = False
        End If
    End Sub

    Private Sub EditarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditarToolStripMenuItem.Click
        switchPanel(frmMiCuenta)
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        frmLogin.Show()
        Me.Close()
    End Sub

    Private Sub frmHome_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        frmLogin.Show()
    End Sub
End Class