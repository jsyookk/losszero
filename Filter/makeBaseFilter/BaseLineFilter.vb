

Public Class BaseLineFilter : Inherits BaseFilter

    Protected Overrides Function check(ste As Steel) As Boolean

        If ste.ShapeNUM = 1 Then
            ste.Line = True
        Else
            ste.Line = False
        End If

        Return True

    End Function
End Class
