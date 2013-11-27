Imports System.Collections.ObjectModel

'Purpose of this component is to provide validation for the between the gui and the datamanager
'It needs the variable and contructor to that initializes them.
Public Class ApplicationController : Inherits NotifyBase

    Private _srvCall As ServiceCall
    Public Property SrvCall() As ServiceCall
        Get
            Return _srvCall
        End Get
        Set(ByVal value As ServiceCall)
            _srvCall = value
            Notify("SrvCall")
        End Set
    End Property

    Private _providerList As ObservableCollection(Of Provider)
    Public Property ProviderList() As ObservableCollection(Of Provider)
        Get
            Return _providerList
        End Get
        Set(ByVal value As ObservableCollection(Of Provider))
            _providerList = value
            Notify("ProviderList")
        End Set
    End Property

    Public Sub New()
        ProviderList = New ObservableCollection(Of Provider)
        InitializeProviders()
        InitializeContacts()
        NewServiceCall()
    End Sub

    Public Sub NewServiceCall()
        SrvCall = New ServiceCall()
        SrvCall.Customer = New Customer()
        SrvCall.Customer.Location = New Location()
        SrvCall.Customer.Location.Phones = New ObservableCollection(Of Phone)
        SrvCall.CallLocation = New CallLocation()
        SrvCall.Statuses = New ObservableCollection(Of Status)
    End Sub

    Public Sub InitializeProviders()
        ProviderList.Add(New Provider With {.ID = 0, .CompanyName = "Provider1", .Website = "site1", .Email = "@email1", .Location = New Location With {.ID = 0, .Address = "123 overthere", .City = "city1", .State = "S1", .Zip = 12345}})
        ProviderList.Add(New Provider With {.ID = 0, .CompanyName = "Provider2", .Website = "site2", .Email = "@email2", .Location = New Location With {.ID = 0, .Address = "223 overthere", .City = "city2", .State = "S2", .Zip = 12345}})
        ProviderList.Add(New Provider With {.ID = 0, .CompanyName = "Provider3", .Website = "site3", .Email = "@email3", .Location = New Location With {.ID = 0, .Address = "323 overthere", .City = "city3", .State = "S3", .Zip = 12345}})
    End Sub

    Public Sub InitializeContacts()

    End Sub

    Public Sub SaveProvider()

    End Sub

    Public Sub SaveServiceCall()

    End Sub

    Public Sub SaveStatus()

    End Sub

    Public Sub SaveCustomer()

    End Sub

    Public Sub SaveContact()

    End Sub

End Class
