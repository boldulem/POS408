Imports System.Collections.ObjectModel

Public Class Provider : Inherits NotifyBase

    Private _id As Integer
    Public Property id() As Integer
        Get
            Return _id
        End Get
        Set(ByVal value As Integer)
            _id = value
        End Set
    End Property

    Private _companyName As String
    Public Property CompanyName() As String
        Get
            Return _companyName
        End Get
        Set(ByVal value As String)
            _companyName = value
        End Set
    End Property

    Private newPropertyValue As String
    Public Property NewProperty() As String
        Get
            Return newPropertyValue
        End Get
        Set(ByVal value As String)
            newPropertyValue = value
        End Set
    End Property

    Private _email As String
    Public Property Email() As String
        Get
            Return _email
        End Get
        Set(ByVal value As String)
            _email = value
        End Set
    End Property

    Private _website As String
    Public Property Website() As String
        Get
            Return _website
        End Get
        Set(ByVal value As String)
            _website = value
        End Set
    End Property

    Private _location As Location
    Public Property Location() As Location
        Get
            Return _location
        End Get
        Set(ByVal value As Location)
            _location = value
        End Set
    End Property

    Private _contacts As ObservableCollection(Of Person)
    Public Property Contacts() As ObservableCollection(Of Person)
        Get
            Return _contacts
        End Get
        Set(ByVal value As ObservableCollection(Of Person))
            _contacts = value
        End Set
    End Property

    Public Sub New()

    End Sub
End Class
