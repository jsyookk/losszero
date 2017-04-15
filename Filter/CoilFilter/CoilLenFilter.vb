
Public Class CoilLenFilter : Inherits CoilFilter

    Protected Overrides Function check(ByRef ste As Steel) As Boolean
        Dim onesideLen As Integer
        onesideLen = coilhashtb.Item(ste.ShapeNUM)

        If ste.A > 0 And ste.A > onesideLen Then
            Return False
        ElseIf ste.B > 0 And ste.B > onesideLen Then
            Return False
        ElseIf ste.C > 0 And ste.C > onesideLen Then
            Return False
        ElseIf ste.D > 0 And ste.D > onesideLen Then
            Return False
        ElseIf ste.E > 0 And ste.E > onesideLen Then
            Return False
        ElseIf ste.F > 0 And ste.F > onesideLen Then
            Return False
        ElseIf ste.G > 0 And ste.G > onesideLen Then
            Return False
        Else
            Return True
        End If

    End Function


End Class
