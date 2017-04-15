
Public Class CBDifferentFilter : Inherits CBFilter

    Protected Overrides Function check(ByRef ste As BaseData, ByRef otherste As BaseData) As Boolean

        If ste.steIndex <> otherste.steIndex Then
            Return True
        Else
            Return False
        End If
    End Function


End Class
