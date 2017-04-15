Public Class TotalTonVisitor : Inherits RVisitor

    Private totalTon As Double = 0.0

    Public Overrides Sub visit(b As RHdm)

        Dim list As ArrayList = b.getList()

        For Each entry As REntry In list
            entry.accept(Me)
        Next

    End Sub

    Public Overrides Sub visit(b As RRebar)

        totalTon += b.needTon

    End Sub

    Public Overrides Sub visit(b As RCombine)


        totalTon += b.needTon


    End Sub

    Public Function getTotalTon() As Double

        Return Math.Round(totalTon, 2)

    End Function


End Class
