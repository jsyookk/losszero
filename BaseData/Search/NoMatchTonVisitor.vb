Public Class NoMatchTonVisitor : Inherits Visitor
    Private totalTon As Double = 0.0

    Public Overrides Sub visit(b As Hdm)

        Dim list As ArrayList = b.getList()

        For Each entry As Entry In list
            entry.accept(Me)
        Next

    End Sub

    Public Overrides Sub visit(ByRef b As BaseData)

        If b.BaseState = BaseData.BASE_STATE.BASE And b.ProcessState = BaseData.PROCESS_STATE.NONE And b.CoilState = BaseData.COIL_STATE.NONE Then
            totalTon += b.Ton
        End If



    End Sub

    Public Function getTon() As Double

        Return Math.Round(totalTon, 2)

    End Function


End Class
