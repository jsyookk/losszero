Public Class TotalHdmMeterTonVisitor : Inherits RVisitor

    Private hashtb As New Hashtable()

    Public Overrides Sub visit(b As RHdm)

        Dim list As ArrayList = b.getList()

        For Each entry As REntry In list
            entry.accept(Me)
        Next

    End Sub

    Public Overrides Sub visit(b As RRebar)


        Dim key As String = b.HDM & "," & b.UseMeter

        If hashtb.ContainsKey(key) Then
            Dim t As Double = hashtb.Item(key)
            t = t + b.needTon
            hashtb(key) = t
        Else
            hashtb.Add(key, b.needTon)
        End If


    End Sub

    Public Overrides Sub visit(b As RCombine)

        Dim key As String = b.HDM & "," & b.UseMeter

        If hashtb.ContainsKey(key) Then
            Dim t As Double = hashtb.Item(key)
            t = t + b.needTon
            hashtb(key) = t
        Else
            hashtb.Add(key, b.needTon)
        End If


    End Sub

    Public Function getHashTb() As Hashtable

        Return hashtb

    End Function

End Class
