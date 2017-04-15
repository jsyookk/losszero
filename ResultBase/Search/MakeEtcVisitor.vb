Imports Losszero

Public Class MakeEtcVisitor : Inherits RVisitor

    Public Overrides Sub visit(b As RHdm)

        Dim list As ArrayList = b.getList()

        For Each entry As REntry In list
            entry.accept(Me)
        Next

    End Sub

    Public Overrides Sub visit(b As RRebar)

        Dim ste As Steel = SteelList.GetInstance().getItem(b.steIDX)
        Dim tempStr As String = Nothing

        If b.type = RRebar.BAR_TYPE.ANGKA_ZANGDAE Then
            tempStr = "앙카장대"
        ElseIf b.type = RRebar.BAR_TYPE.ZANGDAE Then
            tempStr = "장대"
        ElseIf b.type = RRebar.BAR_TYPE.ERROR_NORMAL Then
            tempStr = "오차 감안"
        ElseIf b.type = RRebar.BAR_TYPE.NORMARL Then
            tempStr = "컷팅"
        ElseIf b.type = RRebar.BAR_TYPE.ZUM_STEEL Then
            tempStr = "점철"
        End If

        ste.ETC = tempStr & "(" & b.UseMeter & "M)"

    End Sub

    Public Overrides Sub visit(b As RCombine)

        b.setUniqueNumber()

    End Sub


End Class
