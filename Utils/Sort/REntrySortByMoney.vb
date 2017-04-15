
Public Class REntrySortByMoney
    Implements IComparer

    Public Function Compare(x As Object, y As Object) As Integer Implements IComparer.Compare

        Dim cx As REntry = CType(x, REntry)
        Dim cy As REntry = CType(y, REntry)

        If cx.saveMoney() < cy.saveMoney Then
            Return 1
        ElseIf cx.saveMoney() > cy.saveMoney Then
            Return -1
        Else
            Return 0
        End If

    End Function
End Class