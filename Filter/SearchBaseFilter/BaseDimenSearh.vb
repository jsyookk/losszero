Public Class BaseDimenSearh : Inherits BaseChkFilter
    Dim dimen As Integer
    Public Sub New(_dimen As Integer)

        Me.dimen = _dimen

    End Sub
    Protected Overrides Function check(base As BaseData) As Boolean

        If Me.dimen = 0 Then
            Return True
        Else
            If Me.dimen = base.Dimen Then
                Return True
            Else
                Return False
            End If
        End If

    End Function

End Class
