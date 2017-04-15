Public Class ResultStock_list

    Dim cut As New ResultStock_cut
    Dim combine As New ResultStock_Combine

    Dim list As ArrayList
    Public Sub New()

        ' 디자이너에서 이 호출이 필요합니다.
        InitializeComponent()

        ' InitializeComponent() 호출 뒤에 초기화 코드를 추가하세요.

        listmain.Controls.Add(cut)
        listmain.Controls.Add(combine)

        cut.Visible = False
        combine.Visible = False
    End Sub

    Public Sub update(hdm As Integer, meter As Double)


        Dim visitor As New HdmMeterRentyVisitor(hdm, meter)
        RBase.GetInstance().search(visitor)
        list = visitor.getList()

        Dim cutTon As Double = 0.0
        Dim combineTon As Double = 0.0
        Dim totalTon As Double = 0.0
        Dim stockTon As Double = StockList.GetInstance().getHdmMeterAsTon(hdm, meter)
        Dim diffTon As Double = 0.0


        For Each entry As REntry In list
            If entry.GetType().FullName = "Losszero.RRebar" Then
                cutTon += entry.needTon
                totalTon += entry.needTon
            ElseIf entry.GetType().FullName = "Losszero.RCombine" Then
                combineTon += entry.needTon
                totalTon += entry.needTon
            End If
        Next

        diffTon = stockTon - totalTon

        Try
            cutProgress.Value = (cutTon / totalTon) * 100
            combineProgress.Value = (combineTon / totalTon) * 100
        Catch ex As Exception

        End Try

        cutTonLB.Text = CStr(cutTon)
        cbTonLB.Text = CStr(combineTon)
        totalTonTB.Text = CStr(totalTon)
        stockTonLB.Text = CStr(stockTon)
        diffTonLB.Text = CStr(diffTon)

        cut.updateData(list)
        combine.updateData(list)

        cut.Visible = True
        combine.Visible = False

        BunifuSeparator1.Width = tab1.Width
        BunifuSeparator1.Left = tab1.Left

    End Sub

    Private Sub tab1_Click(sender As Object, e As EventArgs) Handles tab1.Click

        BunifuSeparator1.Width = tab1.Width
        BunifuSeparator1.Left = tab1.Left

        cut.Visible = True
        combine.Visible = False


    End Sub

    Private Sub tab2_Click(sender As Object, e As EventArgs) Handles tab2.Click

        BunifuSeparator1.Width = tab2.Width
        BunifuSeparator1.Left = tab2.Left

        cut.Visible = False
        combine.Visible = True


    End Sub

End Class
