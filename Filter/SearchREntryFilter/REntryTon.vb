Imports Losszero

Public Class REntryTon : Inherits RentryFilter

    Dim ton As Double = 0
    Public Sub New(_ton As Double)

        Me.ton = _ton
    End Sub
    Protected Overrides Function check(base As REntry) As Boolean

        If Me.ton = 0 Then
            Return True
        Else
            If base.needTon >= Me.ton Then
                Return True
            Else
                Return False
            End If
        End If

    End Function
End Class
