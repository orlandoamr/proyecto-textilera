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

Partial Public Class Operaciones
    Public Property OperacionId As Long
    Public Property NombreOperacion As String
    Public Property FKMaquinaId As Long
    Public Property EstadoOperacion As Boolean

    Public Overridable Property DetalleEstilosOperaciones As ICollection(Of DetalleEstilosOperaciones) = New HashSet(Of DetalleEstilosOperaciones)
    Public Overridable Property OperacionesBalanceos As ICollection(Of OperacionesBalanceos) = New HashSet(Of OperacionesBalanceos)
    Public Overridable Property Maquinas As Maquinas

End Class
