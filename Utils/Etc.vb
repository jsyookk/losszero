Public Class Etc
    Public Shared Function getHdmAndMeter(key_ As String) As Double()
        Dim values As Double() = {0, 0}

        Dim parts As String() = key_.Split(New Char() {","c}, StringSplitOptions.RemoveEmptyEntries)
        values(0) = CDbl(parts(0))
        values(1) = CDbl(parts(1))

        Return values

    End Function

End Class
