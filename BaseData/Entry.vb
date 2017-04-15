
Public MustInherit Class Entry : Implements Element

    Public MustOverride Function getCount() As Long
    Public MustOverride Function getTon() As Double
    Public MustOverride Function getName() As String
    Public MustOverride Sub clear()
    Public MustOverride Sub accept(v As Visitor) Implements Element.accept

End Class
