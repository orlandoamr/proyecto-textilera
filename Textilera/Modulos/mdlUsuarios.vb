Module mdlUsuarios
    Public Function obtenerUsuarios(db As TextileraEntities)
        Dim tUs = From us In db.Usuarios
                  Join rol In db.Roles On rol.RolId Equals us.FKRolId
                  Select IDUsuario = us.UsuarioId,
                          Nombre = us.Nombre,
                          Apellido = us.Apellido,
                          Correo = us.CorreoElectronico,
                          Usuario = us.Usuario,
                          Contraseña = us.Contrasenia,
                          Rol = rol.RolDescripcion,
                          Estado = us.EstadoUsuario
        Return tUs.ToList()
    End Function

    Public Function obtenerRoles(db As TextileraEntities)
        Dim tRo = From ro In db.Roles
                  Select IDRol = ro.RolId,
                         DescripcionRol = ro.RolDescripcion

        Return tRo.ToList()
    End Function
End Module
