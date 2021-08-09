Module mdlMaquinas
    Public Function obtenerMaquinas(db As TextileraEntities1)
        Dim tMaq = From maq In db.Maquinas
                   Select IDMaquina = maq.MaquinaId,
                          Nombre = maq.NombreMaquina,
                          Estándar = maq.Estandar,
                          Estado = maq.EstadoMaquina
        Return tMaq.ToList()
    End Function

    Public Function obtenerMaquinasHabilitadas(db As TextileraEntities1)
        Dim tMaq = From maq In db.Maquinas
                   Where maq.EstadoMaquina = True
                   Select IDMaquina = maq.MaquinaId,
                          Nombre = maq.NombreMaquina

        Return tMaq.ToList()
    End Function
End Module
