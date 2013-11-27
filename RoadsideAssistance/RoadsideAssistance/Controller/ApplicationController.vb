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

    Private _typeList As ObservableCollection(Of String)
    Public Property TypeList() As ObservableCollection(Of String)
        Get
            Return _typeList
        End Get
        Set(ByVal value As ObservableCollection(Of String))
            _typeList = value
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

    Private _statusList As ObservableCollection(Of String)
    Public Property StatusList() As ObservableCollection(Of String)
        Get
            Return _statusList
        End Get
        Set(ByVal value As ObservableCollection(Of String))
            _statusList = value
            Notify("StatusList")
        End Set
    End Property


    Private _serviceCalls As ObservableCollection(Of ServiceCall)
    Public Property ServiceCalls() As ObservableCollection(Of ServiceCall)
        Get
            Return _serviceCalls
        End Get
        Set(ByVal value As ObservableCollection(Of ServiceCall))
            _serviceCalls = value
        End Set
    End Property

    Public Sub New()
        'Create objects
        ProviderList = New ObservableCollection(Of Provider)
        StatusList = New ObservableCollection(Of String)
        TypeList = New ObservableCollection(Of String)
        ServiceCalls = New ObservableCollection(Of ServiceCall)

        SrvCall = New ServiceCall()

        'Populate static lists
        InitializeProviderList()
        InitializeStatusList()
        InitializeTypeList()
    End Sub

    Public Sub InitializeProviderList()
        ProviderList.Add(New Provider With {.ID = 0, .CompanyName = "Provider1", .Website = "site1", .Email = "@email1", .Location = New Location With {.ID = 0, .Address = "123 overthere", .City = "city1", .State = "S1", .Zip = 12345}})
        ProviderList.Add(New Provider With {.ID = 0, .CompanyName = "Provider2", .Website = "site2", .Email = "@email2", .Location = New Location With {.ID = 0, .Address = "223 overthere", .City = "city2", .State = "S2", .Zip = 12345}})
        ProviderList.Add(New Provider With {.ID = 0, .CompanyName = "Provider3", .Website = "site3", .Email = "@email3", .Location = New Location With {.ID = 0, .Address = "323 overthere", .City = "city3", .State = "S3", .Zip = 12345}})
    End Sub

    Public Sub InitializeStatusList()
        StatusList.Add("Travelling")
        StatusList.Add("Arrived")
        StatusList.Add("Repairing")
        StatusList.Add("NotReached")
        StatusList.Add("NotRepairable")
        StatusList.Add("Completed")
    End Sub

    Public Sub InitializeTypeList()
        TypeList.Add("Cell")
        TypeList.Add("Land")
        TypeList.Add("Vehicle")
        TypeList.Add("Other")
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
