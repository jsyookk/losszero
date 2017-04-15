Public Class CBShapeFilter : Inherits CBFilter
    Protected Overrides Function check(ByRef ste As BaseData, ByRef otherste As BaseData) As Boolean


        If ste.shpNUM = otherste.shpNUM Then
            Return True
        Else
            Return False
        End If



    End Function



End Class
