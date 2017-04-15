Imports Losszero

Public Class ResultGenerator
    Implements Publisher
    Private observers As New ArrayList()

    Public Sub add(observer As Observer) Implements Publisher.add
        observers.Add(observer)
    End Sub

    Public Sub delete(observer As Observer) Implements Publisher.delete
        observers.Remove(observer)
    End Sub

    Public Sub notifyObserver() Implements Publisher.notifyObserver

        For Each observer As Observer In observers
            observer.ob(Observer.Observer_Type.RESULT)
        Next

    End Sub

End Class

