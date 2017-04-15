Public Class KongjungDataVisitor : Inherits Visitor
    Dim hdmlist As ArrayList
    Dim list As New ArrayList
    Dim kongjungIdx As Integer
    Dim cnt As Integer = 0

    Public Sub New(idx_ As Integer)

        Me.kongjungIdx = idx_

    End Sub
    Public Overrides Sub visit(b As Hdm)


        For Each entry As Entry In b.getList()
            entry.accept(Me)
        Next

    End Sub

    Public Overrides Sub visit(ByRef b As BaseData)

        If b.kongjungIdx = Me.kongjungIdx Then
            list.Add(b)
            cnt = cnt + 1
        End If

    End Sub
    Public Function getMaxCnt() As Integer
        Return cnt
    End Function
    Public Function getList() As ArrayList

        Return list

    End Function


End Class
