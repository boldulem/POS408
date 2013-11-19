Public Class Phone : Inherits NotifyBase
    Private _id As Integer
    Public Property id() As Integer
        Get
            Return _id
        End Get
        Set(ByVal value As Integer)
            _id = value
        End Set
    End Property

    Private _number As Int64
    Public Property Number() As Int64
        Get
            Return _number
        End Get
        Set(ByVal value As Int64)
            _number = value
        End Set
    End Property

    Private _type As String
    Public Property Type() As String 'Mobile, Land, FAX
        Get
            Return _type
        End Get
        Set(ByVal value As String)
            _type = value
        End Set
    End Property


    Public Sub New()

    End Sub

End Class
