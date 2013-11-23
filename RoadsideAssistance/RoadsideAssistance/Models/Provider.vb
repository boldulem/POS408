Imports System.Collections.ObjectModel

Public Class Provider : Inherits NotifyBase

    Private _id As Integer
    Public Property ID() As Integer
        Get
            Return _id
        End Get
        Set(ByVal value As Integer)
            _id = value
            Notify("ID")
        End Set
    End Property

    Private _companyName As String
    Public Property CompanyName() As String
        Get
            Return _companyName
        End Get
        Set(ByVal value As String)
            _companyName = value
            Notify("CompanyName")
        End Set
    End Property

    Private _website As String
    Public Property Website() As String
        Get
            Return _website
        End Get
        Set(ByVal value As String)
            _website = value
            Notify("Website")
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

    Private _location As Location
    Public Property Location() As Location
        Get
            Return _location
        End Get
        Set(ByVal value As Location)
            _location = value
            Notify("Location")
        End Set
    End Property

    Private _contacts As ObservableCollection(Of Contacts)
    Public Property Contacts() As ObservableCollection(Of Contacts)
        Get
            Return _contacts
        End Get
        Set(ByVal value As ObservableCollection(Of Contacts))
            _contacts = value
        End Set
    End Property

End Class
