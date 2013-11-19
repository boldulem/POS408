Public Class Customer : Inherits Person
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
