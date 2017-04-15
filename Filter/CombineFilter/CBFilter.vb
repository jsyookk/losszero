Public MustInherit Class CBFilter

    Protected nextf As CBFilter = Nothing
    Protected Shared result As Boolean = False


    Public Function setNext(nextf As CBFilter) As CBFilter
        Me.nextf = nextf
        Return nextf
    End Function

    Public Function filtering(ByRef ste As BaseData, ByRef otherste As BaseData) As Boolean

        If check(ste, otherste) Then
            If nextf IsNot Nothing Then
                nextf.filtering(ste, otherste)
            Else
                result = True
            End If
        Else
            result = False
        End If

        Return result

    End Function

    Protected MustOverride Function check(ByRef ste As BaseData, ByRef otherste As BaseData) As Boolean


End Class
