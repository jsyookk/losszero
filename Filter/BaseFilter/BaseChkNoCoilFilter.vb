

Public Class BaseChkNoCoilFilter : Inherits BaseChkFilter

    Protected Overrides Function check(base As BaseData) As Boolean

        If base.CoilState = BaseData.COIL_STATE.NONE Then
            Return True
        Else
            Return False
        End If

    End Function
End Class
