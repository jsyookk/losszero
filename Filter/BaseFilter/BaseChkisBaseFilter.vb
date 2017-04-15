

Public Class BaseChkisBaseFilter : Inherits BaseChkFilter

    Protected Overrides Function check(base As BaseData) As Boolean
        If base.BaseState = BaseData.BASE_STATE.BASE Then
            Return True
        Else
            Return False
        End If

    End Function

End Class
