Public Class EachTonVisitor : Inherits RVisitor

    Enum TYPE_TON
        ZZANG_DAE
        CUTTING
        ZUM
        ERROR_
        COMBINE
        TOTAL
    End Enum
    Private hash As New Hashtable
    Public Sub New()

        hash.Add(TYPE_TON.ZZANG_DAE, 0)
        hash.Add(TYPE_TON.CUTTING, 0)
        hash.Add(TYPE_TON.ZUM, 0)
        hash.Add(TYPE_TON.COMBINE, 0)
        hash.Add(TYPE_TON.ERROR_, 0)
        hash.Add(TYPE_TON.TOTAL, 0)
    End Sub
    Public Overrides Sub visit(b As RHdm)

        Dim list As ArrayList = b.getList()

        For Each entry As REntry In list
            entry.accept(Me)
        Next

    End Sub

    Public Overrides Sub visit(b As RRebar)

        Dim ton As Double = 0


        Select Case b.type
            Case RRebar.BAR_TYPE.ANGKA_ZANGDAE, RRebar.BAR_TYPE.ZANGDAE
                ton = hash.Item(TYPE_TON.ZZANG_DAE)
                ton += b.needTon
                hash(TYPE_TON.ZZANG_DAE) = ton
            Case RRebar.BAR_TYPE.NORMARL
                ton = hash.Item(TYPE_TON.CUTTING)
                ton += b.needTon
                hash(TYPE_TON.CUTTING) = ton
            Case RRebar.BAR_TYPE.ZUM_STEEL
                ton = hash.Item(TYPE_TON.ZUM)
                ton += b.needTon
                hash(TYPE_TON.ZUM) = ton
            Case RRebar.BAR_TYPE.ERROR_NORMAL
                ton = hash.Item(TYPE_TON.ERROR_)
                ton += b.needTon
                hash(TYPE_TON.ERROR_) = ton
        End Select

        ton = hash.Item(TYPE_TON.TOTAL)
        ton += b.needTon
        hash(TYPE_TON.TOTAL) = ton


    End Sub

    Public Overrides Sub visit(b As RCombine)

        Dim ton As Double = hash.Item(TYPE_TON.COMBINE)
        ton += b.needTon
        hash(TYPE_TON.COMBINE) = ton

        ton = hash.Item(TYPE_TON.TOTAL)
        ton += b.needTon
        hash(TYPE_TON.TOTAL) = ton

    End Sub

    Public Function getEachTotalTon() As Hashtable

        Return hash

    End Function

End Class
