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

    'Private _callLocation As Location
    'Public Property CallLocation() As Location
    '    Get
    '        Return _callLocation
    '    End Get
    '    Set(ByVal value As Location)
    '        _callLocation = value
    '        Notify("CallLocation")
    '    End Set
    'End Property

    'Private _callCustomer As Customer
    'Public Property CallCustomer() As Customer
    '    Get
    '        Return _callCustomer
    '    End Get
    '    Set(ByVal value As Customer)
    '        _callCustomer = value
    '        Notify("CallCustomer")
    '    End Set
    'End Property

    Private _customerList As ObservableCollection(Of Customer)
    Public Property CustomerList() As ObservableCollection(Of Customer)
        Get
            Return _customerList
        End Get
        Set(ByVal value As ObservableCollection(Of Customer))
            _customerList = value
            Notify("CustomerList")
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

    Private _statuses As ObservableCollection(Of Status)
    Public Property Statuses() As ObservableCollection(Of Status)
        Get
            Return _statuses
        End Get
        Set(ByVal value As ObservableCollection(Of Status))
            _statuses = value
            Notify("Statuses")
        End Set
    End Property

    Public Sub New()
        CustomerList = New ObservableCollection(Of Customer)
        ProviderList = New ObservableCollection(Of Provider)
        InitializeProviders()
        InitializeCustomers()
        InitializeContacts()
        NewServiceCall()
    End Sub

    Public Sub NewServiceCall()
        SrvCall = New ServiceCall()
        SrvCall.Customer = New Customer()
        SrvCall.CallLocation = New CallLocation()
        SrvCall.Statuses = New ObservableCollection(Of Status)
    End Sub

    Public Sub InitializeProviders()
        ProviderList.Add(New Provider With {.ID = 0, .CompanyName = "Provider1", .Website = "site1", .Email = "@email1", .Location = New Location With {.ID = 0, .Address = "123 overthere", .City = "city1", .State = "state1", .Zip = 12345}})
    End Sub

    Public Sub InitializeCustomers()
        CustomerList.Add(New Customer With {.ID = 0, .FirstName = "First1", .LastName = "Last1", .Location = New Location With {.ID = 0, .Address = "CustAddr1", .City = "CustCity1", .State = "CustST", .Zip = "CustZip1"}})
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
