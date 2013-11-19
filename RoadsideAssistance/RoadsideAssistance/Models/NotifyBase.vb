Imports System.ComponentModel

Public Class NotifyBase : Implements INotifyPropertyChanged

    Public Sub Notify(ByVal propName As String)

        RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propName))

    End Sub

    Public Event PropertyChanged(sender As Object, e As PropertyChangedEventArgs) Implements INotifyPropertyChanged.PropertyChanged
End Class
