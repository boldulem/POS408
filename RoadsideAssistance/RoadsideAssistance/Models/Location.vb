Imports System.Collections.ObjectModel

Public Class Location : Inherits NotifyBase

    Private _id As Integer
    Public Property id() As Integer
        Get
            Return _id
        End Get
        Set(ByVal value As Integer)
            _id = value
        End Set
    End Property

    Private _address As String
    Public Property Address() As String
        Get
            Return _address
        End Get
        Set(ByVal value As String)
            _address = value
        End Set
    End Property

    Private _city As String
    Public Property City() As String
        Get
            Return _city
        End Get
        Set(ByVal value As String)
            _city = value
        End Set
    End Property

    Private _state As String
    Public Property State() As String
        Get
            Return _state
        End Get
        Set(ByVal value As String)
            _state = value
        End Set
    End Property

    Private _zip As String
    Public Property Zip() As String
        Get
            Return _zip
        End Get
        Set(ByVal value As String)
            _zip = value
        End Set
    End Property

    Private _phoneID As ObservableCollection(Of Phone)
    Public Property PhoneID() As ObservableCollection(Of Phone)
        Get
            Return _phoneID
        End Get
        Set(ByVal value As ObservableCollection(Of Phone))
            _phoneID = value
        End Set
    End Property

    Public Sub New()

    End Sub

End Class
