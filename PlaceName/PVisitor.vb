Public MustInherit Class PVisitor

    Public Sub New()

    End Sub
    Public MustOverride Sub visit(s As Scene)
    Public MustOverride Sub visit(k As Kongjung)
    Public MustOverride Sub visit(p As Part)

End Class
