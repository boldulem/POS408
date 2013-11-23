Public Class Customer : Inherits Person

    Private _customerID As Integer
    Public Property CustomerID() As Integer
        Get
            Return _customerID
        End Get
        Set(ByVal value As Integer)
            _customerID = value
            Notify("CustomerID")
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


End Class
