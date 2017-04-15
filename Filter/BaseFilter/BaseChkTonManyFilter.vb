Imports Losszero

Public Class BaseChkTonManyFilter : Inherits BaseChkFilter

    Protected Overrides Function check(base As BaseData) As Boolean

        If base.Ton > 1.0 Then
            Return True
        Else
            Return False
        End If

    End Function
End Class
