Public Class ChkProcessingVisitor : Inherits Visitor

    Public Overrides Sub visit(b As Hdm)

        Dim list As ArrayList = b.getList()

        For Each entry As Entry In list
            entry.accept(Me)
        Next

    End Sub

    Public Overrides Sub visit(ByRef b As BaseData)

        If b.ProcessState = BaseData.PROCESS_STATE.PROCESSING Then
            Console.Write("에러")

        End If

    End Sub

End Class
