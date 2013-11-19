Imports System.Collections.ObjectModel

Public Class Person

    Private _id As Integer
    Public Property id() As Integer
        Get
            Return _id
        End Get
        Set(ByVal value As Integer)
            _id = value
        End Set
    End Property

    Private _firstName As String
    Public Property FirstName() As String
        Get
            Return _firstName
        End Get
        Set(ByVal value As String)
            _firstName = value
        End Set
    End Property

    Private _lastName As String
    Public Property LastName() As String
        Get
            Return _lastName
        End Get
        Set(ByVal value As String)
            _lastName = value
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

    Private _phones As ObservableCollection(Of Phone)
    Public Property Phones() As ObservableCollection(Of Phone)
        Get
            Return _phones
        End Get
        Set(ByVal value As ObservableCollection(Of Phone))
            _phones = value
        End Set
    End Property

    Public Sub New()

    End Sub

End Class
