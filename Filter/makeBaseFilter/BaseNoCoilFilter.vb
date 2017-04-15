
Public Class BaseNoCoilFilter : Inherits BaseFilter

    Protected Overrides Function check(ste As Steel) As Boolean

        If ste.coil = False Then
            Return True
        Else
            Return False
        End If

    End Function
End Class
