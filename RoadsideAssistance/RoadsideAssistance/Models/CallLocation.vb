Public Class CallLocation : Inherits Location

    Private _latitude As Double
    Public Property Latitude() As Double
        Get
            Return _latitude
        End Get
        Set(ByVal value As Double)
            _latitude = value
            Notify("Latitude")
        End Set
    End Property

    Private _longitude As Double
    Public Property Longitude() As Double
        Get
            Return _longitude
        End Get
        Set(ByVal value As Double)
            _longitude = value
            Notify("Logitude")
        End Set
    End Property

    Public Sub New()

    End Sub

End Class
