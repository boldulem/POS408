Public Class Phone : Inherits NotifyBase

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

    Private _number As Int64
    Public Property Number() As Int64
        Get
            Return _number
        End Get
        Set(ByVal value As Int64)
            _number = value
            Notify("Number")
        End Set
    End Property

    '(Mobile	Land	FAX)
    Private _type As String
    Public Property Type() As String
        Get
            Return _type
        End Get
        Set(ByVal value As String)
            _type = value
            Notify("Type")
        End Set
    End Property

End Class
