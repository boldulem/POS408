Public Class Contact : Inherits Person

    Private _contactID As Integer
    Public Property ContactID() As Integer
        Get
            Return _contactID
        End Get
        Set(ByVal value As Integer)
            _contactID = value
            Notify("ContactID")
        End Set
    End Property

    Private _title As String
    Public Property Title() As String
        Get
            Return _title
        End Get
        Set(ByVal value As String)
            _title = value '
            Notify("Title")
        End Set
    End Property

End Class
