'------------------------------------------------------------------------------
' <auto-generated>
'    This code was generated from a template.
'
'    Manual changes to this file may cause unexpected behavior in your application.
'    Manual changes to this file will be overwritten if the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Imports System
Imports System.Collections.Generic

Partial Public Class BalanceosEstilos
    Public Property BalanceoEstiloId As Long
    Public Property C_UtilizacionRequeridoEquipo As String
    Public Property CantidadOperadores As Byte
    Public Property MetaDocenasHora As String
    Public Property MetaDocenaDias As String
    Public Property MetaDocenasSemana As String
    Public Property FKEstiloId As String
    Public Property EstadoBalanceo As Boolean

    Public Overridable Property Estilos As Estilos
    Public Overridable Property OperacionesBalanceos As ICollection(Of OperacionesBalanceos) = New HashSet(Of OperacionesBalanceos)

End Class
