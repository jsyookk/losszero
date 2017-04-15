Public Class TotalZangdaeVisitor : Inherits RVisitor
    Private arr As New ArrayList()

    Public Overrides Sub visit(b As RHdm)

        Dim list As ArrayList = b.getList()

        For Each entry As REntry In list
            entry.accept(Me)
        Next

    End Sub
    Public Overrides Sub visit(b As RRebar)

        If b.type = RRebar.BAR_TYPE.ZANGDAE Or b.type = RRebar.BAR_TYPE.ANGKA_ZANGDAE Then
            arr.Add(b)
        End If


    End Sub

    Public Overrides Sub visit(b As RCombine)


    End Sub

    Public Function getlist() As ArrayList

        Return arr

    End Function


End Class
