

Public Class CoilHdmFilter : Inherits CoilFilter

    Protected Overrides Function check(ByRef ste As Steel) As Boolean

        Select Case ste.HDM
            Case 410, 413, 510, 513
                Return True

        End Select

        Return False

    End Function

End Class
