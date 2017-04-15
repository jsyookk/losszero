Public Class SteelSortByNumber
    Implements IComparer

    Public Function Compare(x As Object, y As Object) As Integer Implements IComparer.Compare

        Dim cx As BaseData = CType(x, BaseData)
        Dim cy As BaseData = CType(y, BaseData)

        If cx.NUM() > cy.NUM Then
            Return 1
        ElseIf cx.NUM() < cy.NUM Then
            Return -1
        Else
            Return 0
        End If

    End Function
End Class

