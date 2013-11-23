Imports System.Collections.ObjectModel

Public Class Location : Inherits NotifyBase

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

    Private _address As String
    Public Property Address() As String
        Get
            Return _address
        End Get
        Set(ByVal value As String)
            _address = value
            Notify("Address")
        End Set
    End Property

    Private _city As String
    Public Property City() As String
        Get
            Return _city
        End Get
        Set(ByVal value As String)
            _city = value
            Notify("City")
        End Set
    End Property

    Private _state As String
    Public Property State() As String
        Get
            Return _state
        End Get
        Set(ByVal value As String)
            _state = value
            Notify("State")
        End Set
    End Property

    Private _zip As String
    Public Property Zip() As String
        Get
            Return _zip
        End Get
        Set(ByVal value As String)
            _zip = value
            Notify("Zip")
        End Set
    End Property

    Private _phones As ObservableCollection(Of Phone)
    Public Property Phones() As ObservableCollection(Of Phone)
        Get
            Return _phones
        End Get
        Set(ByVal value As ObservableCollection(Of Phone))
            _phones = value
        End Set
    End Property


End Class
