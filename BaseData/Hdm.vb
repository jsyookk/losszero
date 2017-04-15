
Public Class Hdm : Inherits Entry

    Private name As String
    Private list As ArrayList = New ArrayList()

    Public Sub New(_name As String)
        Me.name = _name
    End Sub
    Public Function add(entry As Entry) As Entry

        list.Add(entry)
        Return Me

    End Function


    Public Overrides Function getName() As String

        Return name

    End Function

    Public Overrides Sub accept(v As Visitor)
        v.visit(Me)
    End Sub

    Public Function getList() As ArrayList

        Return list

    End Function

    Public Overrides Sub clear()

        list.Clear()

        For Each entry As Entry In list
            list.Clear()
        Next

    End Sub

    Public Overrides Function getCount() As Long

        Return list.Count()

    End Function

    Public Overrides Function getTon() As Double

        Dim _totalTon As Double = 0

        For Each entry As Entry In list
            _totalTon = _totalTon + entry.getTon()
        Next

        Return _totalTon

    End Function

End Class
