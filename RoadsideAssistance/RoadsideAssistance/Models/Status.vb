Public Class Status : Inherits NotifyBase

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

    Private _TimeOf As DateTime
    Public Property TimeOf() As DateTime
        Get
            Return _TimeOf
        End Get
        Set(ByVal value As DateTime)
            _TimeOf = value
            Notify("TimeOf")
        End Set
    End Property

    '(Travelling	Arrived	Repairing	NotReached	NotRepairable	Completed)
    Private _status As String
    Public Property Status() As String
        Get
            Return _status
        End Get
        Set(ByVal value As String)
            _status = value
            Notify("Status")
        End Set
    End Property

    Private _comments As String
    Public Property Comments() As String
        Get
            Return _comments
        End Get
        Set(ByVal value As String)
            _comments = value
            Notify("Comments")
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

End Class
