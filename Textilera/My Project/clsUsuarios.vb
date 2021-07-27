Public Class clsUsuarios  'Clase para el registro de los usuarios que usarán el sistema
    'Propiedades
    Private idUsuario As Long
    Private nombre As String
    Private apellido As String
    Private fechaNacimiento As Date
    Private correoElectronico As String
    Private usuario As String
    Private contrasenia As String
    Private estadoUsuario As Boolean

    'Getters y Setters
    Public Property _idUsuario As Long
        Get
            Return idUsuario
        End Get
        Set(value As Long)
            idUsuario = value
        End Set
    End Property
    Public Property _nombre As String
        Get
            Return nombre
        End Get
        Set(value As String)
            nombre = value
        End Set
    End Property
    Public Property _apellido As String
        Get
            Return apellido
        End Get
        Set(value As String)
            apellido = value
        End Set
    End Property
    Public Property _fechaNacimiento As Date
        Get
            Return fechaNacimiento
        End Get
        Set(value As Date)
            fechaNacimiento = value
        End Set
    End Property
    Public Property _correoElectronico As String
        Get
            Return correoElectronico
        End Get
        Set(value As String)
            correoElectronico = value
        End Set
    End Property
    Public Property _usuario As String
        Get
            Return usuario
        End Get
        Set(value As String)
            usuario = value
        End Set
    End Property
    Public Property _contrasenia As String
        Get
            Return contrasenia
        End Get
        Set(value As String)
            contrasenia = value
        End Set
    End Property
    Public Property _estadoUsuario As Boolean
        Get
            Return estadoUsuario
        End Get
        Set(value As Boolean)
            estadoUsuario = value
        End Set
    End Property


End Class
