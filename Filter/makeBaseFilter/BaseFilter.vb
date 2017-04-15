Public MustInherit Class BaseFilter

    Protected setting As SettingInfo = SettingInfo.GetInstance
    Protected nextf As BaseFilter = Nothing
    Private base As Base = Base.GetInstance()

    Public Function setNext(nextf As BaseFilter) As BaseFilter
        Me.nextf = nextf
        Return nextf
    End Function

    Public Sub filtering(ste As Steel)

        If check(ste) Then
            If nextf IsNot Nothing Then
                nextf.filtering(ste)
            Else
                done(ste)
            End If
        Else
            fail(ste)
        End If

    End Sub

    Protected MustOverride Function check(ste As Steel) As Boolean

    Protected Sub done(ste As Steel)

        ste.baseFilter = True
        base.createBase(ste)

    End Sub

    Protected Sub fail(ste As Steel)

        ste.baseFilter = False
        base.createBase(ste)

    End Sub

End Class
