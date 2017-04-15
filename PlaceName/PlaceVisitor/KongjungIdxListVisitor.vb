Public Class KongjungIdxListVisitor : Inherits PVisitor

    Private Idxlist As New ArrayList
    Public Sub New()

    End Sub
    Public Overrides Sub visit(p As Part)

    End Sub

    Public Overrides Sub visit(k As Kongjung)

        Idxlist.Add(k.getUniqueIDX())

    End Sub

    Public Overrides Sub visit(s As Scene)

        Dim chdlist As ArrayList = s.getList()

        For Each entry As PEntry In chdlist
            entry.accept(Me)
        Next

    End Sub

    Public Function getKongjungIdxsList() As ArrayList

        Return Idxlist

    End Function


End Class
