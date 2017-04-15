Imports Losszero

Public Class ReBarAlogVisitor : Inherits Visitor
    Private ralog As Alog
    Public Sub New(alog As Alog)
        Me.ralog = alog

    End Sub
    Public Overrides Sub visit(b As Hdm)

        For Each entry As Entry In b.getList()
            entry.accept(Me)
        Next

    End Sub

    Public Overrides Sub visit(ByRef b As BaseData)

        ralog.find(b)

    End Sub


End Class
