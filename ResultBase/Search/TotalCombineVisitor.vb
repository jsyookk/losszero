Public Class TotalCombineVisitor : Inherits RVisitor

    Private arr As New ArrayList()

    Public Overrides Sub visit(b As RHdm)

        Dim list As ArrayList = b.getList()

        For Each entry As REntry In list
            entry.accept(Me)
        Next

    End Sub

    Public Overrides Sub visit(b As RRebar)

    End Sub

    Public Overrides Sub visit(b As RCombine)

        arr.Add(b)

    End Sub

    Public Function getList() As ArrayList

        Return arr

    End Function

End Class
