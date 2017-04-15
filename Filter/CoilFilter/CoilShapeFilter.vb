
Public Class CoilShapeFilter : Inherits CoilFilter

    Protected Overrides Function check(ByRef ste As Steel) As Boolean

        If coilhashtb.ContainsKey(ste.ShapeNUM) = True Then
            Return True
        Else
            Return False
        End If

    End Function

End Class
