Module mdlBalanceos
    Public Function obtenerBalanceos(db As TextileraEntities1, id As Integer)
        Dim tBal = From bal In db.BalanceosEstilos
                   Join es In db.Estilos On es.EstiloId Equals bal.FKEstiloId
                   Join op In db.OperacionesBalanceos On bal.BalanceoEstiloId Equals op.FKBalanceoId
                   Join opes In db.Operaciones On op.FKOperacionId Equals opes.OperacionId
                   Join dt In db.DetalleEstilosOperaciones On op.FKOperacionId Equals dt.OperacionId And bal.FKEstiloId Equals dt.EstiloId
                   Where bal.BalanceoEstiloId = id
                   Select Operacion = opes.NombreOperacion,
                          ClicloSeg = op.TiempoEstandarSegundos,
                          EstandarMinutos = op.TiempoEstandarMinutos,
                          EstandarHora = dt.SAH,
                          DocenasOperador = op.MetaDocenasOperador,
                          CantidadOperadores = op.CantidadOperadores,
                          ParejaBalanceo = op.ParejaBalanceo,
                          PorcentajeUtilizacion = op.UtilizacionOperador

        Return tBal.ToList()
    End Function

    Public Function obtenerBalanceos2(db As TextileraEntities1)
        Dim tBal = From bal In db.BalanceosEstilos
                   Select ID = bal.BalanceoEstiloId,
                          Estilo = bal.FKEstiloId,
                          MetaDocenasHora = bal.MetaDocenasHora,
                          MetaDocenasDia = bal.MetaDocenaDias,
                          MetaDocenasSemana = bal.MetaDocenasSemana,
                          CantidadOperadores = bal.CantidadOperadores


        Return tBal.ToList()
    End Function
End Module
