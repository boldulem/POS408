Imports System.Collections.ObjectModel

Public Class DataManager

    Public Sub AddCustomer(ByVal _customer As Customer)
        Try 'Saves to db
            Dim ctx As RoadsideEntities = New RoadsideEntities()
            Dim customerData As Customers = New Customers()

            customerData.LocationId = _customer.Location.ID
            customerData.PersonId = _customer.CustomerID

            ctx.Customers.Add(customerData)
            ctx.SaveChanges()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Public Sub AddContact(ByVal _contact As Contact)
        Try
            Dim ctx As RoadsideEntities = New RoadsideEntities
            Dim contactData As Contacts = New Contacts

            contactData.ProviderId = _contact.ID
            contactData.PersonId = _contact.ContactID
            contactData.Title = _contact.Title

            ctx.Contacts.Add(contactData)
            ctx.SaveChanges()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Public Sub AddLocation(ByVal _location As Location)
        Try
            Dim ctx As RoadsideEntities = New RoadsideEntities
            Dim locData As Locations = New Locations

            locData.Address = _location.Address
            locData.City = _location.City
            locData.State = _location.State
            locData.Zip = _location.Zip

            ctx.Locations.Add(locData)
            ctx.SaveChanges()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Public Sub AddPerson(ByVal _person As Person)
        Try
            Dim ctx As RoadsideEntities = New RoadsideEntities
            Dim peopleData As People = New People

            peopleData.Email = _person.Email
            peopleData.FirstName = _person.FirstName
            peopleData.LastName = _person.LastName

            ctx.People.Add(peopleData)
            ctx.SaveChanges()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Public Sub AddPhone(ByVal _phone As Phone)
        Try
            Dim ctx As RoadsideEntities = New RoadsideEntities
            Dim phoneData As Phones = New Phones

            phoneData.Number = _phone.Number
            phoneData.Type = _phone.Type

            ctx.Phones.Add(phoneData)
            ctx.SaveChanges()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Public Sub AddProvider(ByVal _provider As Provider)
        Try
            Dim ctx As RoadsideEntities = New RoadsideEntities
            Dim providerData As Providers = New Providers

            providerData.LocationID = _provider.Location.ID
            providerData.CompanyName = _provider.CompanyName
            providerData.Contacts = _provider.Contacts
            providerData.Email = _provider.Email
            providerData.Website = _provider.Website

            ctx.Providers.Add(providerData)
            ctx.SaveChanges()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Public Sub AddServiceCall(ByVal _serviceCall As ServiceCall)
        Try
            Dim ctx As RoadsideEntities = New RoadsideEntities
            Dim scData As ServiceCalls = New ServiceCalls

            scData.LocationID = _serviceCall.CallLocation.ID
            scData.CustomerID = _serviceCall.Customer.ID
            scData.Contract = _serviceCall.Contract
            scData.Description = _serviceCall.Description
            scData.Equipment = _serviceCall.Equipment
            scData.Issue = _serviceCall.Issue
            scData.TimeOf = _serviceCall.TimeOf

            ctx.ServiceCalls.Add(scData)
            ctx.SaveChanges()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Public Sub AddStatus(ByVal _status As Status)
        Try
            Dim ctx As RoadsideEntities = New RoadsideEntities
            Dim statusData As Statuses = New Statuses()

            statusData.ServiceCall_Id = _status.ServiceCallID
            statusData.ProviderID = _status.Provider.ID
            statusData.Comments = _status.Comments
            statusData.Status = _status.Status
            statusData.TimeOf = _status.TimeOf
            ctx.Statuses.Add(statusData)
            ctx.SaveChanges()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
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
