Public Class SceneToKongjungIdxVisitor : Inherits PVisitor

    Private sceneIdx As Integer
    Private Idxlist As New ArrayList
    Public Sub New(sceneIdx As Integer)

        Me.sceneIdx = sceneIdx

    End Sub
    Public Overrides Sub visit(p As Part)

    End Sub

    Public Overrides Sub visit(k As Kongjung)

        If Me.sceneIdx = k.getParentIDX Then
            Idxlist.Add(k.getUniqueIDX())
        End If


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
