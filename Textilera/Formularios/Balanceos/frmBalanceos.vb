Public Class frmBalanceos
    Private db As New TextileraEntities1()

    Private cantOperadores As Double = 0.00
    Private utilizacionRequerida As Double = 0.00
    Private MetaDocenasHora As Double = 0.00
    Private MetaDocenasDia As Double = 0.00
    Private MetaDocenasSemana As Double = 0.00
    Private factorSah As Double = 0.00
    Private Sub frmBalanceos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtEstiloId.Text = ""
        dgvBalanceos.Columns(0).ReadOnly = True
        dgvBalanceos.Columns(1).ReadOnly = True
        dgvBalanceos.Columns(2).ReadOnly = True
        dgvBalanceos.Columns(3).ReadOnly = True
        dgvBalanceos.Columns(4).ReadOnly = True
        dgvBalanceos.Columns(5).ReadOnly = True
        dgvBalanceos.Columns(7).ReadOnly = True
        dgvBalanceos.Columns(9).ReadOnly = True
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
                row.Cells("IDOperacion").Value = fila("ID")
                row.Cells("NombreOperacion").Value = fila("Nombre")
                row.Cells("NumOperadores").Value = 1
                row.Cells("EstandarHora").Value = fila("Sah")
                row.Cells("EstandarMin").Value = fila("Sah") * 60
                row.Cells("CicloSeg").Value = (fila("Sah") * 60) * 60
                row.Cells("DocenasOperador").Value = (1 / fila("sah"))
                factorSah += fila("Sah")

                cantOperadores += 1
            Next
            factorSah = (1 / factorSah)
            recorrerGrid()
            recorrerGrid2()


        End If
    End Sub

    Public Sub actulizarValores()

        utilizacionRequerida = 95
        cantOperadores = cantOperadores
        MetaDocenasHora = cantOperadores * factorSah * (0.95)
        MetaDocenasDia = (MetaDocenasHora) * 11
        MetaDocenasSemana = Val(MetaDocenasHora) * 44

        txtUtilizacion.Text = utilizacionRequerida
        txtOperadores.Text = cantOperadores
        txtDocenasHora.Text = MetaDocenasHora
        txtDocenasMinuto.Text = MetaDocenasDia
        txtDocenasSemana.Text = MetaDocenasSemana
    End Sub

    Public Sub recorrerGrid()
        cantOperadores = 0
        For Each row As DataGridViewRow In dgvBalanceos.Rows
            If Not row.Cells("NumOperadores").Value.ToString = "" Then
                cantOperadores += row.Cells("NumOperadores").Value
            End If

        Next
        actulizarValores()
    End Sub
    Public Sub recorrerGrid2()
        For Each row As DataGridViewRow In dgvBalanceos.Rows
            Dim utilizacion As Double = Format((MetaDocenasHora / (row.Cells("NumOperadores").Value * row.Cells("DocenasOperador").Value)) * 100, "0.00")
            row.Cells("UtilizacionOperador").Value = utilizacion & " %"
        Next
    End Sub
    Public Function recorrerGrid3()
        Dim res As Boolean = True
        For Each row As DataGridViewRow In dgvBalanceos.Rows
            If row.Cells("NumOperadores").Value.ToString = "" Or Not IsNumeric(row.Cells("NumOperadores").Value) Then
                res = False
            End If

        Next

        Return res
    End Function


    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        frmBuscarEstilo.Show()
    End Sub

    Private Sub dgvBalanceos_DoubleClick(sender As Object, e As EventArgs) Handles dgvBalanceos.DoubleClick
        Dim id As Integer = dgvBalanceos.CurrentCell.RowIndex
        Dim actual = dgvBalanceos.CurrentRow.Cells(7).Value
        Dim cantidad = InputBox("Cantidad de operadores:")
        If cantidad.Length = 0 Or Not IsNumeric(cantidad) Then
            cantidad = 1
        End If
        cantOperadores = cantOperadores - actual
        dgvBalanceos.CurrentRow.Cells(7).Value = cantidad
        recorrerGrid()
        recorrerGrid2()
        Dim pareja = InputBox("Pareja de balanceo")
        dgvBalanceos.CurrentRow.Cells(8).Value = pareja
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If txtEstiloId.Text = "" Then
            MsgCampoVacio("estilo id")
        ElseIf dgvBalanceos.Rows.Count = 0 Then
            MessageBox.Show("El estilo no tiene operaciones para balancear")
        ElseIf Not recorrerGrid3() Then
            MessageBox.Show("Revise la cantidad de operadores e intente de nuevo")
        Else
            Dim tBal As New BalanceosEstilos()
            tBal.CantidadOperadores = cantOperadores

            tBal.FKEstiloId = txtEstiloId.Text
            tBal.MetaDocenasHora = Format(MetaDocenasHora, "0.00")
            tBal.MetaDocenaDias = Format(MetaDocenasDia, "0.00")
            tBal.MetaDocenasSemana = Format(MetaDocenasSemana, "0.00")
            tBal.UtilizacionRequeridoEquipo = utilizacionRequerida
            tBal.EstadoBalanceo = chkEstado.Checked
            db.BalanceosEstilos.Add(tBal)
            db.SaveChanges()

            Dim idBal As Long = tBal.BalanceoEstiloId

            For Each fila As DataGridViewRow In dgvBalanceos.Rows
                Dim tOp As New OperacionesBalanceos()
                tOp.CantidadOperadores = fila.Cells("NumOperadores").Value
                tOp.UtilizacionOperador = fila.Cells("UtilizacionOperador").Value
                Top.FKOperacionId = Val(fila.Cells("IDOperacion").Value)
                Top.MetaDocenasOperador = Format(fila.Cells("DocenasOperador").Value, "0.00")
                Top.TiempoEstandarMinutos = fila.Cells("EstandarMin").Value
                tOp.TiempoEstandarSegundos = Format(fila.Cells("CicloSeg").Value, "0.00")
                tOp.ParejaBalanceo = fila.Cells("ParejaBalanceo").Value
                Top.FKBalanceoId = idBal
                db.OperacionesBalanceos.Add(Top)
                db.SaveChanges()
                Top = Nothing
            Next

            nuevo()
            MsgRegistroExitoso()
        End If

    End Sub

    Private Sub nuevo()
        txtDocenasHora.Clear()
        txtDocenasMinuto.Clear()
        txtDocenasSemana.Clear()
        txtUtilizacion.Clear()
        txtOperadores.Clear()
        dgvBalanceos.Rows.Clear()
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        nuevo()
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub
End Class