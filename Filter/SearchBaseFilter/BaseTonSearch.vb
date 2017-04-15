Public Class BaseTonSearch : Inherits BaseChkFilter
    Dim ton As Double = 0
    Public Sub New(_ton As Double)

        Me.ton = _ton
    End Sub
    Protected Overrides Function check(base As BaseData) As Boolean

        If Me.ton = 0 Then
            Return True
        Else
            If base.Ton >= Me.ton Then
                Return True
            Else
                Return False
            End If
        End If

    End Function

End Class
