Imports System.Collections.ObjectModel

Public Class DataManager

    Public Sub AddServiceCall(ByVal aServiceCall As ServiceCall)
        Using ctx As New RoadsideEntities
            Try
                Dim scData As ServiceCalls = New ServiceCalls
                Dim locData As Locations = New Locations
                Dim personData As People = New People
                Dim callLocData As Locations = New Locations
                Dim custData As Customers = New Customers
                Dim phoneData As Phones
                Dim statusData As Statuses
                Dim providerData As Providers

                Dim results = ctx.ServiceCalls.FirstOrDefault(Function(x) x.Id = aServiceCall.ID)

                If results Is Nothing Then
                    scData.Contract = aServiceCall.Contract
                    scData.Description = aServiceCall.Description
                    scData.Equipment = aServiceCall.Equipment
                    scData.Issue = aServiceCall.Issue
                    scData.TimeOf = aServiceCall.TimeOf

                    locData.Latitude = aServiceCall.CallLocation.Latitude
                    locData.Longitude = aServiceCall.CallLocation.Longitude
                    locData.Address = aServiceCall.CallLocation.Address
                    locData.City = aServiceCall.CallLocation.City
                    locData.State = aServiceCall.CallLocation.State
                    locData.Zip = aServiceCall.CallLocation.Zip
                    scData.Locations = locData

                    locData = New Locations

                    locData.Address = aServiceCall.Customer.Location.Address
                    locData.City = aServiceCall.Customer.Location.City
                    locData.State = aServiceCall.Customer.Location.State
                    locData.Zip = aServiceCall.Customer.Location.Zip

                    For Each aPhone As Phone In aServiceCall.Customer.Location.Phones
                        phoneData = New Phones
                        phoneData.Type = aPhone.Type
                        phoneData.Number = aPhone.Number

                        locData.Phones.Add(phoneData)
                    Next

                    personData.FirstName = aServiceCall.Customer.FirstName
                    personData.LastName = aServiceCall.Customer.LastName
                    personData.Email = aServiceCall.Customer.Email

                    custData.People = personData
                    custData.Locations = locData

                    scData.Customers = custData

                    For Each aStatus As Status In aServiceCall.Statuses
                        statusData = New Statuses
                        statusData.TimeOf = aStatus.TimeOf
                        statusData.Status = aStatus.Status
                        statusData.Comments = aStatus.Comments

                        providerData = New Providers
                        providerData.CompanyName = aStatus.Provider.CompanyName
                        providerData.Email = aStatus.Provider.Email
                        providerData.Website = aStatus.Provider.Website

                        locData = New Locations

                        locData.Address = aStatus.Provider.Location.Address
                        locData.City = aStatus.Provider.Location.City
                        locData.State = aStatus.Provider.Location.State
                        locData.Zip = aStatus.Provider.Location.Zip
                        providerData.Locations = locData
                        statusData.Providers = providerData

                        scData.Statuses.Add(statusData)
                    Next

                    ctx.ServiceCalls.Add(scData)
                    ctx.SaveChanges()
                    aServiceCall.ID = scData.Id
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End Using
    End Sub

    Public Function GetServiceCalls() As ObservableCollection(Of ServiceCall)
        Dim aCustLoc As Location
        Dim aPhone As Phone
        Dim aCust As Customer
        Dim aCallLoc As CallLocation
        Dim aProvLoc As Location
        Dim aProv As Provider
        Dim aStatus As Status
        Dim aStatuses As ObservableCollection(Of Status) = New ObservableCollection(Of Status)
        Dim aServiceCall As ServiceCall

        Dim aServiceCalls As ObservableCollection(Of ServiceCall) = New ObservableCollection(Of ServiceCall)
        Using ctx As New RoadsideEntities()
            Try
                For Each scData As ServiceCalls In ctx.ServiceCalls
                    aCustLoc = New Location
                    aCust = New Customer
                    aCallLoc = New CallLocation
                    aServiceCall = New ServiceCall

                    For Each dbPhone As Phones In scData.Customers.Locations.Phones
                        aPhone = New Phone
                        aPhone.ID = dbPhone.Id
                        aPhone.Number = dbPhone.Number
                        aPhone.Type = dbPhone.Type

                        aCustLoc.Phones.Add(aPhone)
                    Next
                    aCustLoc.Address = scData.Customers.Locations.Address
                    aCustLoc.City = scData.Customers.Locations.City
                    aCustLoc.State = scData.Customers.Locations.State
                    aCustLoc.Zip = scData.Customers.Locations.Zip

                    aCust.Location = aCustLoc

                    aCust.ID = scData.Customers.People.Id
                    aCust.CustomerID = scData.Customers.Id
                    aCust.FirstName = scData.Customers.People.FirstName
                    aCust.LastName = scData.Customers.People.LastName
                    aCust.Email = scData.Customers.People.Email

                    aCallLoc.Latitude = scData.Locations.Latitude
                    aCallLoc.Longitude = scData.Locations.Longitude
                    aCallLoc.Address = scData.Locations.Address
                    aCallLoc.City = scData.Locations.City
                    aCallLoc.State = scData.Locations.State
                    aCallLoc.Zip = scData.Locations.Zip

                    For Each dbStatus As Statuses In scData.Statuses
                        aStatus = New Status
                        aProv = New Provider
                        aProvLoc = New Location

                        aProvLoc.Address = dbStatus.Providers.Locations.Address
                        aProvLoc.City = dbStatus.Providers.Locations.City
                        aProvLoc.State = dbStatus.Providers.Locations.State
                        aProvLoc.Zip = dbStatus.Providers.Locations.Zip

                        aProv.Location = aProvLoc

                        aProv.ID = dbStatus.Providers.Id
                        aProv.CompanyName = dbStatus.Providers.CompanyName
                        aProv.Email = dbStatus.Providers.Email
                        aProv.Website = dbStatus.Providers.Website

                        aStatus.ID = dbStatus.Id
                        aStatus.Comments = dbStatus.Comments
                        aStatus.ServiceCallID = dbStatus.ServiceCall_Id
                        aStatus.Status = dbStatus.Status
                        aStatus.TimeOf = dbStatus.TimeOf
                        aStatus.Provider = aProv

                        aStatuses.Add(aStatus)
                    Next

                    aServiceCall.ID = scData.Id
                    aServiceCall.Contract = scData.Contract
                    aServiceCall.Description = scData.Description
                    aServiceCall.Equipment = scData.Equipment
                    aServiceCall.Issue = scData.Issue
                    aServiceCall.TimeOf = scData.TimeOf

                    aServiceCall.Customer = aCust
                    aServiceCall.CallLocation = aCallLoc
                    aServiceCall.Statuses = aStatuses

                    aServiceCalls.Add(aServiceCall)
                Next
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End Using

        Return aServiceCalls
    End Function

End Class
