
Public Class BaseZangDaeFilter : Inherits BaseChkFilter

    Protected Overrides Function check(base As BaseData) As Boolean

        If base.shpNUM = 1 Or base.shpNUM = 2 Or base.shpNUM = 97 Then
            Return True
        Else
            Return False
        End If

    End Function


End Class
