Public Class BaseFilterTonFilter : Inherits BaseFilter

    Protected Overrides Function check(ste As Steel) As Boolean

        If ste.Ton >= setting.baseTON Then
            Return True
        Else
            Return False
        End If

    End Function


End Class
