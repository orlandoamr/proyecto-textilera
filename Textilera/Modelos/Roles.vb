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

Partial Public Class Roles
    Public Property RolId As Byte
    Public Property RolDescripcion As String

    Public Overridable Property Usuarios As ICollection(Of Usuarios) = New HashSet(Of Usuarios)

End Class