﻿Public Class CBTonManyFilter : Inherits CBFilter

    Protected Overrides Function check(ByRef ste As BaseData, ByRef otherste As BaseData) As Boolean

        If ste.Ton >= 0.5 And otherste.Ton >= (ste.Ton - 0.1) Then
            Return True
        Else
            Return False
        End If

    End Function

End Class

