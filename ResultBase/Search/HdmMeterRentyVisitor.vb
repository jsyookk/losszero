Imports Losszero

Public Class HdmMeterRentyVisitor : Inherits RVisitor

    Dim hdm As Integer
    Dim meter As Double
    Dim arr As New ArrayList


    Public Sub New(hdm As Integer, meter As Double)

        Me.hdm = hdm
        Me.meter = meter

    End Sub

    Public Overrides Sub visit(b As RHdm)

        Dim list As ArrayList = b.getList()

        For Each entry As REntry In list
            entry.accept(Me)
        Next


    End Sub

    Public Overrides Sub visit(b As RRebar)

        If b.HDM = Me.hdm And b.UseMeter = Me.meter Then

            arr.Add(b)


        End If


    End Sub

    Public Overrides Sub visit(b As RCombine)

        If b.HDM = Me.hdm And b.UseMeter = Me.meter Then


            arr.Add(b)


        End If

    End Sub

    Public Function getList() As ArrayList

        Return arr


    End Function
End Class
