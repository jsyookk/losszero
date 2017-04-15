Public Class HashTableSort
    Public Shared Function SortKeyInt(ByRef hs_ As Hashtable) As List(Of Integer)

        Dim keys As New List(Of Integer)
        Dim sortr As SortedList = New SortedList(hs_)

        For Each data As DictionaryEntry In sortr
            keys.Add(data.Key)
        Next

        Return keys

    End Function
    Public Shared Function Sort(ByRef hs_ As Hashtable) As List(Of String)

        Dim keys As New List(Of String)
        Dim sortr As SortedList = New SortedList(hs_)

        For Each data As DictionaryEntry In sortr
            keys.Add(data.Key)
        Next

        Return keys

    End Function

    Public Shared Function ReverserSort(ByRef hs_ As Hashtable) As List(Of String)

        Dim keys As New List(Of String)
        Dim sortr As SortedList = New SortedList(hs_, New ListReverser())

        For Each data As DictionaryEntry In sortr
            keys.Add(data.Key)
        Next

        Return keys

    End Function

    Public Class ListReverser
        Implements IComparer(Of String)

        Public Function Compare(ByVal x As String, ByVal y As String) As Integer Implements System.Collections.Generic.IComparer(Of String).Compare
            If x = y Then Return 0

            Return y.CompareTo(x)
        End Function

    End Class



End Class
