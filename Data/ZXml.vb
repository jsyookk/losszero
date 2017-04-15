
Public MustInherit Class ZXml

    Public MustOverride Function isFileCheck(path_ As String) As Boolean
    Public MustOverride Sub createDefaultXML(path_ As String)
    Public MustOverride Sub open(path_ As String)
    Public MustOverride Sub close()
    Public MustOverride Sub write(path_ As String)

End Class
