Public Class MainWindow

    Public _appControl As ApplicationController

    Public Sub New()
        _appControl = New ApplicationController()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
 
        Me.DataContext = _appControl
        'Populate lists
        ProviderColumn.ItemsSource = _appControl.ProviderList
        StatusColumn.ItemsSource = _appControl.StatusList
        TypeColumn.ItemsSource = _appControl.TypeList
    End Sub

    Private Sub Button_Click(sender As Object, e As RoutedEventArgs)
        Me.Close()
    End Sub

    Private Sub Button_Click_1(sender As Object, e As RoutedEventArgs)
        _appControl.ServiceCalls.Add(_appControl.SrvCall)
        MessageBox.Show("Save button.")
    End Sub

    Private Sub Button_Click_2(sender As Object, e As RoutedEventArgs)
        Dim idx As Integer = _appControl.ServiceCalls.IndexOf(_appControl.SrvCall)
        If (idx < _appControl.ServiceCalls.Count - 1) Then
            _appControl.SrvCall = _appControl.ServiceCalls(idx + 1)
        End If
    End Sub

    Private Sub Button_Click_3(sender As Object, e As RoutedEventArgs)
        Dim idx As Integer = _appControl.ServiceCalls.IndexOf(_appControl.SrvCall)
        If (idx > 0) Then
            _appControl.SrvCall = _appControl.ServiceCalls(idx - 1)
        End If
    End Sub

    Private Sub Button_Click_4(sender As Object, e As RoutedEventArgs)
        _appControl.SrvCall = New ServiceCall()
    End Sub
End Class
