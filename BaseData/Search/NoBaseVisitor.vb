Public Class NoBaseVisitor : Inherits Visitor
    Private arr As New ArrayList()

    Public Overrides Sub visit(b As Hdm)

        Dim list As ArrayList = b.getList()

        For Each entry As Entry In list
            entry.accept(Me)
        Next

    End Sub

    Public Overrides Sub visit(ByRef b As BaseData)


        If b.ProcessState = BaseData.PROCESS_STATE.NONE And b.CoilState = BaseData.COIL_STATE.NONE And b.BaseState = BaseData.BASE_STATE.NONE Then
            arr.Add(b)
        End If


    End Sub

    Public Function getList() As ArrayList

        Return arr

    End Function
End Class
