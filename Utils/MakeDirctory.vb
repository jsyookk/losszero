Imports System.IO

Public Class MakeDirctory

    Public Shared Function MakeDir(ByVal strpath As String) As Boolean

        System.IO.Directory.CreateDirectory(strpath)

    End Function


End Class
