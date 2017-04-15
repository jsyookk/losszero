Public MustInherit Class CoilFilter

    Protected coilsetting As CoilShapeList = CoilShapeList.GetInstance()
    Protected Shared coilhashtb As New Hashtable

    Protected nextf As CoilFilter = Nothing

    Public Sub createHashTb()

        coilhashtb.Clear()

        For i = 1 To coilsetting.count

            Dim coil As CoilShape = coilsetting.getItem(i)

            If coilhashtb.ContainsKey(coil.shapeNUM) = False Then
                coilhashtb.Add(coil.shapeNUM, coil.OneLEN)
            End If

        Next

    End Sub

    Public Function setNext(nextf As CoilFilter) As CoilFilter
        Me.nextf = nextf
        Return nextf
    End Function

    Public Sub filtering(ByRef ste As Steel)

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

    Protected MustOverride Function check(ByRef ste As Steel) As Boolean

    Protected Sub done(ByRef ste As Steel)

        ste.coil = True

    End Sub

    Protected Sub fail(ByRef ste As Steel)

        ste.coil = False

    End Sub

End Class

