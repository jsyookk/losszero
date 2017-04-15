Public NotInheritable Class SteelList

    Private steIDX As Long
    Private steelList As New Collection

    Public Sub Add(ByRef ste_ As Steel)

        steIDX = steIDX + 1

        ste_.steIDX = steIDX

        steelList.Add(ste_)

    End Sub

    Public Sub remove(idx_ As Integer)

        steelList.Remove(idx_)

    End Sub

    Public Function getItem(idx_ As Integer) As Steel

        Return steelList.Item(idx_)

    End Function

    Public Function count() As Long

        Return steelList.Count

    End Function

    Public Sub clear()

        steIDX = 0

        steelList.Clear()

    End Sub
    Public Function getList() As Collection

        Return steelList

    End Function


    Private Sub New()

    End Sub

    Public Shared ReadOnly Property GetInstance As SteelList
        Get
            Static Instance As SteelList = New SteelList
            Return Instance
        End Get
    End Property

End Class
