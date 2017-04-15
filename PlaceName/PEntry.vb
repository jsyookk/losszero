
Public MustInherit Class PEntry : Implements PElement

    Public MustOverride Sub print()
    Public MustOverride Sub add(r As PEntry)
    Public MustOverride Function getUniqueIDX() As Integer
    Public MustOverride Function getParentIDX(childkey_ As Integer) As Integer
    Public MustOverride Function getParentIDX() As Integer
    Public MustOverride Function getName() As String
    Public MustOverride Function getName(key_ As Integer) As String
    Public MustOverride Function getList() As ArrayList
    Public MustOverride Sub accept(v As PVisitor) Implements PElement.accept
    Public MustOverride Sub Addton(idx As Integer, r As Double)
    Public MustOverride Function getTon() As Double
    Public MustOverride Sub clear()
End Class
