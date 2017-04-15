Public Class SceneIdxListVisitor : Inherits PVisitor

    Private Idxlist As New ArrayList
    Public Sub New()

    End Sub
    Public Overrides Sub visit(p As Part)

    End Sub

    Public Overrides Sub visit(k As Kongjung)



    End Sub

    Public Overrides Sub visit(s As Scene)

        If s.getUniqueIDX <> 0 Then
            Idxlist.Add(s.getUniqueIDX())
        End If

        Dim chdlist As ArrayList = s.getList()

        For Each entry As PEntry In chdlist
            entry.accept(Me)
        Next




    End Sub

    Public Function getKongjungIdxsList() As ArrayList

        Return Idxlist

    End Function

End Class
