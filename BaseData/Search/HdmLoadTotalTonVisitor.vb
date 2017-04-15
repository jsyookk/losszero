
Public Class HdmLoadTotalTonVisitor : Inherits Visitor

    Private Hdm As Integer = 0
    Private hashtb As New Hashtable()

    Public Sub New(hdm_ As Integer)

        Me.Hdm = hdm_

    End Sub

    Public Overrides Sub visit(b As Hdm)
        Dim list As ArrayList = b.getList()

        For Each entry As Entry In list
            entry.accept(Me)
        Next
    End Sub

    Public Overrides Sub visit(ByRef b As BaseData)

        If b.hdm Mod Hdm >= 0 And b.hdm Mod Hdm <= 100 Then
            Dim key As String = b.hdm
            If hashtb.ContainsKey(key) Then
                Dim t As Double = hashtb.Item(key)
                t = t + b.Ton
                hashtb(key) = t
            Else
                hashtb.Add(key, b.Ton)
            End If
        End If


    End Sub

    Public Function getHashTb() As Hashtable

        Return hashtb

    End Function

End Class
