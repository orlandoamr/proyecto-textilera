Module mdlEstilos
    Public Function obtenerEstilos(db As TextileraEntities)
        Dim tEst = From es In db.Estilos
                   Join cat In db.Categorias On cat.CategoriaId Equals es.FKCategoriaId
                   Select IDEstilo = es.EstiloId,
                          Descripción = es.DescripcionEstilo,
                          Categoría = cat.NombreCategoria,
                          IdCategoria = es.FKCategoriaId,
                          Estado = es.EstadoEstilo
        Return tEst.ToList()
    End Function
    Public Function obtenerEstilosHabilitados(db As TextileraEntities)
        Dim tEst = From es In db.Estilos
                   Join cat In db.Categorias On cat.CategoriaId Equals es.FKCategoriaId
                   Where es.EstadoEstilo = True
                   Select IDEstilo = es.EstiloId,
                          Descripción = es.DescripcionEstilo,
                          Categoría = cat.NombreCategoria,
                          IdCategoria = es.FKCategoriaId,
                          Estado = es.EstadoEstilo
        Return tEst.ToList()
    End Function
    Public Function obtenerEstilosOperaciones(db As TextileraEntities)
        Dim tEst = From es In db.Estilos
                   Join det In db.DetalleEstilosOperaciones On det.EstiloId Equals es.EstiloId
                   Join op In db.Operaciones On det.OperacionId Equals op.OperacionId
                   Select IDOperacion = op.OperacionId,
                          NumeroOperacion = det.NumeroOperacion,
                          Nombre = op.NombreOperacion,
                          SAH = det.SAH
        Return tEst.ToList()
    End Function
End Module
