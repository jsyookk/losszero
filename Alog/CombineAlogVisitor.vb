Public Class CombineAlogVisitor : Inherits Visitor
    Private ralog As Alog
    Private list As ArrayList
    Public Sub New(alog As Alog)
        Me.ralog = alog

    End Sub
    Public Overrides Sub visit(b As Hdm)

        list = b.getList()

        For Each entry As Entry In b.getList()
                entry.accept(Me)
            Next

        End Sub

    Public Overrides Sub visit(ByRef b As BaseData)

        ralog.find(b, list)

    End Sub

End Class

