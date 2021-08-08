Module mdlOperaciones
    Public Function obtenerOperaciones(db As TextileraEntities)
        Dim tOp = From op In db.Operaciones
                  Join maq In db.Maquinas On maq.MaquinaId Equals op.FKMaquinaId
                  Select ID = op.OperacionId,
                          Nombre = op.NombreOperacion,
                          IdMaquina = maq.MaquinaId,
                          Máquina = maq.NombreMaquina,
                          Estado = op.EstadoOperacion
        Return tOp.ToList()
    End Function
    Public Function obtenerOperacionesHabilitadas(db As TextileraEntities)
        Dim tOp = From op In db.Operaciones
                  Join maq In db.Maquinas On maq.MaquinaId Equals op.FKMaquinaId
                  Where op.EstadoOperacion = True
                  Select ID = op.OperacionId,
                          Nombre = op.NombreOperacion,
                          Máquina = maq.NombreMaquina,
                          Estado = op.EstadoOperacion
        Return tOp.ToList()
    End Function

    Public Function obtenerOperacionesEstilo(db As TextileraEntities, id As String)
        Dim dtb As New DataTable()
        dtb.Columns.Add("ID")
        dtb.Columns.Add("#")
        dtb.Columns.Add("Nombre")
        dtb.Columns.Add("SAH")
        Dim tOp = From es In db.Estilos
                  Join dt In db.DetalleEstilosOperaciones On es.EstiloId Equals dt.EstiloId
                  Join op In db.Operaciones On dt.OperacionId Equals op.OperacionId
                  Where es.EstiloId = id
                  Select IdOperacion = op.OperacionId,
                          NumeroOperacion = dt.NumeroOperacion,
                          NombreOperacion = op.NombreOperacion,
                          Sah = dt.SAH
        For Each row In tOp
            dtb.Rows.Add(row.IdOperacion, row.NumeroOperacion, row.NombreOperacion, row.Sah)
        Next
        Return dtb
        '.ToList()
    End Function
End Module
