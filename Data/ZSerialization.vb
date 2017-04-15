Public MustInherit Class ZSerialization

    Public MustOverride Sub createDefaultXML(path_ As String)
    Public MustOverride Function isFileCheck(path_ As String) As Boolean
    Public MustOverride Sub load(ByVal path As String)
    Public MustOverride Sub save(ByVal path As String)

End Class
