

Public Class RHdm : Inherits REntry

    Enum RESULT_TYPE

        BAR = 1
        COMBINE = 2

    End Enum


    Private name As String
    Private list As ArrayList = New ArrayList()

    Public Sub New(_name As String)
        Me.name = _name
    End Sub
    Public Function add(entry As REntry) As REntry

        list.Add(entry)
        Return Me

    End Function
    Public Overrides Function getName() As String

        Return name

    End Function

    Public Overrides Sub accept(v As RVisitor)

        v.visit(Me)

    End Sub

    Public Function getList() As ArrayList

        Return list

    End Function

    Public Overrides Sub clear()

        For Each entry As REntry In list
            entry.clear()
        Next

        list.Clear()

    End Sub

    Public Function getCount() As Long

        Return list.Count()

    End Function

    Public Function getNeedTon() As Double

        Dim _totalTon As Double = 0

        For Each entry As REntry In list
            _totalTon = _totalTon + entry.needTon()
        Next

        Return _totalTon

    End Function

    Public Function getLoss() As Double

        Dim _totalLoss As Double = 0
        Dim _avagreLoss As Double = 0
        Dim _cnt As Integer = list.Count()

        For Each entry As REntry In list
            _totalLoss = _totalLoss + entry.Loss()
        Next

        _avagreLoss = _totalLoss / _cnt

        Return _avagreLoss


    End Function

    Public Function getSaveMoneny() As Long

        Dim saveMoney As Long

        For Each entry As REntry In list
            saveMoney = saveMoney + entry.saveMoney()
        Next

        Return saveMoney

    End Function

    Public Overrides Function getDimen() As Integer


    End Function



End Class
