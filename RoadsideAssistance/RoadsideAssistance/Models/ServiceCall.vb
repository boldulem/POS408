Public Class ServiceCall : Inherits NotifyBase

    Private _id As Integer
    Public Property id() As Integer
        Get
            Return _id
        End Get
        Set(ByVal value As Integer)
            _id = value
        End Set
    End Property

    Private _timeOf As DateTime
    Public Property TimeOf() As DateTime
        Get
            Return _timeOf
        End Get
        Set(ByVal value As DateTime)
            _timeOf = value
        End Set
    End Property

    Private _equipment As String
    Public Property Equipment() As String 'truck, trailer, car, storage
        Get
            Return _equipment
        End Get
        Set(ByVal value As String)
            _equipment = value
        End Set
    End Property

    Private _contract As String
    Public Property Contract() As String
        Get
            Return _contract
        End Get
        Set(ByVal value As String)
            _contract = value
        End Set
    End Property

    Private _issue As String
    Public Property Issue() As String 'LostKey, breakdown, stolen, accident
        Get
            Return _issue
        End Get
        Set(ByVal value As String)
            _issue = value
        End Set
    End Property

    Private _description As String
    Public Property Description() As String
        Get
            Return _description
        End Get
        Set(ByVal value As String)
            _description = value
        End Set
    End Property

    Private _customer As Customer
    Public Property Customer() As Customer
        Get
            Return _customer
        End Get
        Set(ByVal value As Customer)
            _customer = value
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


    Public Sub New()

    End Sub

End Class
