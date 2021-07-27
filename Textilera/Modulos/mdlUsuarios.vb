Module mdlUsuarios
    Public Function obtenerUsuarios(db As TextileraEntities)
        Dim tUs = From us In db.Usuarios
                  Select IDUsuario = us.UsuarioId,
                          Nombre = us.Nombre,
                          Apellido = us.Apellido,
                          FechaNacimiento = us.FechaNacimiento,
                          Correo = us.CorreoElectronico,
                          Usuario = us.Usuario,
                          Contraseña = us.Contrasenia,
                          Estado = us.EstadoUsuario
        Return tUs.ToList()
    End Function
End Module
