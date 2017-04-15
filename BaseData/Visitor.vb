Public MustInherit Class Visitor

    Protected alog As Alog
    Public Sub New()

    End Sub
    Public Sub New(alog_ As Alog)

        Me.alog = alog_

    End Sub

    Public MustOverride Sub visit(ByRef b As BaseData)
    Public MustOverride Sub visit(b As Hdm)

End Class
