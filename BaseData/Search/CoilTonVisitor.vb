Public Class CoilTonVisitor : Inherits Visitor
    Private totalTon As Double = 0.0
    Public Overrides Sub visit(b As Hdm)

        Dim list As ArrayList = b.getList()

        For Each entry As Entry In list
            entry.accept(Me)
        Next

    End Sub

    Public Overrides Sub visit(ByRef b As BaseData)

        If b.CoilState = BaseData.COIL_STATE.COIL Then
            totalTon += b.Ton
        End If

    End Sub

    Public Function getTon() As Double

        Return Math.Round(totalTon, 2)


    End Function

End Class
