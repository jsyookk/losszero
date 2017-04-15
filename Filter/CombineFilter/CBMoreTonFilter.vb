Imports Losszero

Public Class CBMoreTonFilter : Inherits CBFilter

    Protected Overrides Function check(ByRef ste As BaseData, ByRef otherste As BaseData) As Boolean
        If ste.Ton > otherste.Ton Then
            Return True
        Else
            Return False
        End If

    End Function


End Class
