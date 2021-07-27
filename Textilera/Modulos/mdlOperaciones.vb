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
End Module
