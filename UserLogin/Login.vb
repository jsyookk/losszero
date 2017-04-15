Public MustInherit Class Login
    Public MustOverride Function open(id_ As String, pw_ As String) As Boolean
    Public MustOverride Sub close()
    Public MustOverride Function check() As Boolean
End Class
