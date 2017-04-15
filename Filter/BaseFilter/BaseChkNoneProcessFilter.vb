

Public Class BaseChkNoneProcessFilter : Inherits BaseChkFilter
    Protected Overrides Function check(base As BaseData) As Boolean

        If base.ProcessState = BaseData.PROCESS_STATE.NONE Then
            Return True
        Else
            Return False
        End If

    End Function


End Class
