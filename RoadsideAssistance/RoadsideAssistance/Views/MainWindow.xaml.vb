Public Class MainWindow

    Public _appControl As ApplicationController

    Public Sub New()
        _appControl = New ApplicationController()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.DataContext = _appControl
    End Sub

    Private Sub Button_Click(sender As Object, e As RoutedEventArgs)
        Me.Close()
    End Sub

    Private Sub Button_Click_1(sender As Object, e As RoutedEventArgs)
        MessageBox.Show("Save button.")
    End Sub
End Class
