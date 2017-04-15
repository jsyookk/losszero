
Public MustInherit Class RentryFilter

    Protected nextf As RentryFilter = Nothing
    Protected Shared result As Boolean

    Public Function setNext(nextf As RentryFilter) As RentryFilter
        Me.nextf = nextf
        Return nextf
    End Function

    Public Function filtering(data As REntry) As Boolean

        If check(data) = True Then
            If nextf Is Nothing Then
                result = True
            Else
                nextf.filtering(data)
            End If
        Else
            result = False
        End If

        Return result

    End Function

    Protected MustOverride Function check(base As REntry) As Boolean





End Class

