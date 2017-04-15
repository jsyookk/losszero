Public Class RCombineSortByMoney
    Implements IComparer

    Public Function Compare(x As Object, y As Object) As Integer Implements IComparer.Compare

        Dim cx As RCombine = CType(x, RCombine)
        Dim cy As RCombine = CType(y, RCombine)

        If cx.saveMoney() < cy.saveMoney Then
            Return 1
        ElseIf cx.saveMoney() > cy.saveMoney Then
            Return -1
        Else
            Return 0
            End If

        End Function
    End Class

