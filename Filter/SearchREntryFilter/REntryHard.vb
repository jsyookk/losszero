Imports Losszero

Public Class REntryHard : Inherits RentryFilter

    Dim hard As Integer
    Public Sub New(_hard As Integer)
        Me.hard = _hard
    End Sub
    Protected Overrides Function check(base As REntry) As Boolean
        If Me.hard = 0 Then
            Return True
        Else

            If base.Hard = hard Then
                Return True
            Else
                Return False
            End If
        End If


    End Function
End Class
