Public Class Contact : Inherits Person

    Private _title As String
    Public Property Title() As String
        Get
            Return _title
        End Get
        Set(ByVal value As String)
            _title = value
        End Set
    End Property

    Private _provider As Provider
    Public Property NewProperty() As Provider
        Get
            Return _provider
        End Get
        Set(ByVal value As Provider)
            _provider = value
        End Set
    End Property

    Public Sub New()

    End Sub

End Class
