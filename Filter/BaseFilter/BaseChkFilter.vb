Public MustInherit Class BaseChkFilter

    Protected nextf As BaseChkFilter = Nothing
    Protected Shared result As Boolean

    Public Function setNext(nextf As BaseChkFilter) As BaseChkFilter
        Me.nextf = nextf
        Return nextf
    End Function

    Public Function filtering(base As BaseData) As Boolean

        If check(base) = True Then
            If nextf Is Nothing Then
                result = True
            Else
                nextf.filtering(base)
            End If
        Else
            result = False
        End If

        Return result

    End Function

    Protected MustOverride Function check(base As BaseData) As Boolean





End Class

