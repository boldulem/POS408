Imports System.Collections.ObjectModel

Public Class DataManager

    Public Sub AddCustomer(ByVal _customer As Customer)

    End Sub

    Public Sub AddContact(ByVal _contact As Contact)

    End Sub

    Public Sub AddLocation(ByVal _location As Location)

    End Sub

    Public Sub AddPerson(ByVal _person As Person)

    End Sub

    Public Sub AddPhone(ByVal _phone As Phone)

    End Sub

    Public Sub AddProvider(ByVal _provider As Provider)

    End Sub

    Public Sub AddServiceCall(ByVal _serviceCall As ServiceCall)

    End Sub

    Public Sub AddStatus(ByVal _status As Status)

    End Sub

    Public Function GetCustomers() As ObservableCollection(Of Customer)
        Dim _customers As ObservableCollection(Of Customer) = New ObservableCollection(Of Customer)

        Return _customers
    End Function

    Public Function GetContacts() As ObservableCollection(Of Contact)
        Dim _contacts As ObservableCollection(Of Contact) = New ObservableCollection(Of Contact)

        Return _contacts
    End Function

    Public Function GetLocations() As ObservableCollection(Of Location)
        Dim _locations As ObservableCollection(Of Location) = New ObservableCollection(Of Location)

        Return _locations
    End Function

    Public Function GetProviders() As ObservableCollection(Of Provider)
        Dim _providers As ObservableCollection(Of Provider) = New ObservableCollection(Of Provider)

        Return _Providers
    End Function

    Public Function GetServiceCalls() As ObservableCollection(Of ServiceCall)
        Dim _serviceCalls As ObservableCollection(Of ServiceCall) = New ObservableCollection(Of ServiceCall)

        Return _serviceCalls
    End Function

    Public Function GetStatuses() As ObservableCollection(Of Status)
        Dim _statuses As ObservableCollection(Of Status) = New ObservableCollection(Of Status)

        Return _statuses
    End Function

End Class
