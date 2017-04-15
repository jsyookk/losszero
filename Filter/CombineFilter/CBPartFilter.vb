Public Class CBPartFilter : Inherits CBFilter

    Protected Overrides Function check(ByRef ste As BaseData, ByRef otherste As BaseData) As Boolean

        If ste.partIdx = otherste.partIdx Then
            Return True
        Else
            Return False
        End If

    End Function

End Class
