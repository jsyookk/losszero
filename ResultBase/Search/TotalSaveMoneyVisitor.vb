Imports Losszero

Public Class TotalSaveMoneyVisitor : Inherits RVisitor
    Private saveMoney As Long
    Public Overrides Sub visit(b As RHdm)
        Dim list As ArrayList = b.getList()

        For Each entry As REntry In list
            entry.accept(Me)
        Next
    End Sub

    Public Overrides Sub visit(b As RRebar)

        saveMoney += b.saveMoney

    End Sub

    Public Overrides Sub visit(b As RCombine)

        saveMoney += b.saveMoney

    End Sub

    Public Function getTotalSaveMoney() As Long

        Return saveMoney

    End Function
End Class
