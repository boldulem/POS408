'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated from a template.
'
'     Manual changes to this file may cause unexpected behavior in your application.
'     Manual changes to this file will be overwritten if the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Imports System
Imports System.Collections.Generic

Partial Public Class Customers
    Public Property PersonId As Integer
    Public Property LocationId As Integer
    Public Property Id As Integer

    Public Overridable Property Locations As Locations
    Public Overridable Property People As People
    Public Overridable Property ServiceCalls As ICollection(Of ServiceCalls) = New HashSet(Of ServiceCalls)

End Class