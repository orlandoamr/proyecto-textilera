Module mdlCategorias
    Public Function obtenerCategorias(db As TextileraEntities)
        Dim tCat = From cat In db.Categorias
                   Select ID = cat.CategoriaId,
                          Categoría = cat.NombreCategoria,
                          Descripción = cat.DescripcionCategoria,
                          Estado = cat.EstadoCategoria
        Return tCat.ToList()
    End Function
    Public Function obtenerCategoriasHabilitadas(db As TextileraEntities)
        Dim tCat = From cat In db.Categorias
                   Select ID = cat.CategoriaId,
                          Categoría = cat.NombreCategoria,
                          Descripción = cat.DescripcionCategoria,
                          Estado = cat.EstadoCategoria
        Return tCat.ToList()
    End Function
End Module
