Public Class CBPriorityFilter : Inherits CBFilter


    Protected Overrides Function check(ByRef ste As BaseData, ByRef otherste As BaseData) As Boolean


        If ste.priority = True And otherste.priority = True Then
            Return True
        Else
            Return False
        End If



    End Function

End Class
