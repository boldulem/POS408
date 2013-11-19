Public Class Status : Inherits NotifyBase

    Private _id As Integer
    Public Property id() As Integer
        Get
            Return _id
        End Get
        Set(ByVal value As Integer)
            _id = value
        End Set
    End Property

    Private _time As DateTime
    Public Property Time() As DateTime
        Get
            Return _time
        End Get
        Set(ByVal value As DateTime)
            _time = value
        End Set
    End Property

    Private _status As String
    Public Property Status() As String 'Travelling, Arrived, Repairing, NotReached, NotRepairable, Completed
        Get
            Return _status
        End Get
        Set(ByVal value As String)
            _status = value
        End Set
    End Property

    Private _comments As String
    Public Property Comments() As String
        Get
            Return _comments
        End Get
        Set(ByVal value As String)
            _comments = value
        End Set
    End Property

    Private _call As ServiceCall
    Public Property ServiceCall() As ServiceCall
        Get
            Return _call
        End Get
        Set(ByVal value As ServiceCall)
            _call = value
        End Set
    End Property

    Private _provider As Provider
    Public Property Provider() As Provider
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
