Imports System.Collections.ObjectModel

Public Class ServiceCall : Inherits NotifyBase

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

    Private _provider As Provider
    Public Property Provider() As Provider
        Get
            Return _provider
        End Get
        Set(ByVal value As Provider)
            _provider = value
            Notify("Provider")
        End Set
    End Property

    Private _timeOf As DateTime
    Public Property TimeOf() As DateTime
        Get
            Return _timeOf
        End Get
        Set(ByVal value As DateTime)
            _timeOf = value
            Notify("TimeOf")
        End Set
    End Property

    Private _customer As Customer
    Public Property Customer() As Customer
        Get
            Return _customer
        End Get
        Set(ByVal value As Customer)
            _customer = value
            Notify("Customer")
        End Set
    End Property

    Private _contract As String
    Public Property Contract() As String
        Get
            Return _contract
        End Get
        Set(ByVal value As String)
            _contract = value
            Notify("Contract")
        End Set
    End Property

    '(truck	trailer	car	storage)
    Private _equipment As String
    Public Property Equipment() As String
        Get
            Return _equipment
        End Get
        Set(ByVal value As String)
            _equipment = value
            Notify("Equipment")
        End Set
    End Property

    '(LostKey	Breakdown	Accident	Stolen)
    Private _issue As String
    Public Property Issue() As String
        Get
            Return _issue
        End Get
        Set(ByVal value As String)
            _issue = value
            Notify("Issue")
        End Set
    End Property

    Private _description As String
    Public Property Description() As String
        Get
            Return _description
        End Get
        Set(ByVal value As String)
            _description = value
            Notify("Description")
        End Set
    End Property

    Private _callLocation As CallLocation
    Public Property CallLocation() As CallLocation
        Get
            Return _callLocation
        End Get
        Set(ByVal value As CallLocation)
            _callLocation = value
            Notify("CallLocation")
        End Set
    End Property

    Private _statuses As ObservableCollection(Of Status)
    Public Property Statuses() As ObservableCollection(Of Status)
        Get
            Return _statuses
        End Get
        Set(ByVal value As ObservableCollection(Of Status))
            _statuses = value
            Notify("Statuses")
        End Set
    End Property


End Class
