Imports Losszero

Public Class ResultControl
    Implements Observer
    Public Sub New(publisher As Publisher)
        InitializeComponent()
        publisher.add(Me)
        ' 디자이너에서 이 호출이 필요합니다.


        ' InitializeComponent() 호출 뒤에 초기화 코드를 추가하세요.

    End Sub

    Public Sub ob(gen As Observer.Observer_Type) Implements Observer.ob

        If gen = Observer.Observer_Type.RESULT Then
            RBase.GetInstance().search(New MakeEtcVisitor())


            Dim moneyVisitor As New TotalSaveMoneyVisitor()
            RBase.GetInstance().search(moneyVisitor)
            totalSaveMoneyLB.Text = CStr(moneyVisitor.getTotalSaveMoney())

            Dim loadTonVisitor As New LoadTotalTonVisitor()
            Base.GetInstance().search(loadTonVisitor)
            totalTonLB.Text = CStr(loadTonVisitor.getTotalLoadTon())


            Dim MatchtonVisitor As New TotalTonVisitor()
            RBase.GetInstance().search(MatchtonVisitor)
            matchTonLB.Text = CStr(MatchtonVisitor.getTotalTon())

            Dim noMatchTonVisitor As New NoMatchTotalTonVisitor()
            Base.GetInstance().search(noMatchTonVisitor)
            noMatchTonLB.Text = CStr(noMatchTonVisitor.getTotalLoadTon())

            Dim stockTonLevelVisitor As New TotalHdmMeterTonVisitor()
            RBase.GetInstance().search(stockTonLevelVisitor)
            Dim hasht As Hashtable = stockTonLevelVisitor.getHashTb()

            Dim checkVisitor As New ChkProcessingVisitor()
            Base.GetInstance().search(checkVisitor)



            Dim badCnt As Integer = 0
            Dim waringCnt As Integer = 0
            Dim goodCnt As Integer = 0
            Dim noCnt As Integer = 0

            Dim htbKeys As List(Of String) = hasht.Keys.Cast(Of String)().ToList()

            For Each key As String In htbKeys
                Dim tempValue() As Double = Etc.getHdmAndMeter(key)
                Dim hdm As Integer = tempValue(0)
                Dim meter As Double = tempValue(1)
                Dim ton As Double = hasht.Item(key)

                If ton <> 0 Then
                    Dim info As StockList.stockInfo = StockList.GetInstance().compareStock(hdm, meter, ton)
                    Select Case info.level
                        Case StockList.STOCK_LEVEL.BAD
                            badCnt += 1
                        Case StockList.STOCK_LEVEL.WARING
                            waringCnt += 1
                        Case StockList.STOCK_LEVEL.GOOD
                            goodCnt += 1
                        Case StockList.STOCK_LEVEL.NONE
                            noCnt += 1
                    End Select
                End If

            Next

            goodTB.Text = CStr(goodCnt)
            badTB.Text = CStr(badCnt)
            waringTB.Text = CStr(waringCnt)
            noCntTB.Text = CStr(noCnt)

            ResultMain.displayControl(ResultMain.PAGE_NUMBER.COMMON_PAGE)

        End If

    End Sub

    Private Sub money_click(sender As Object, e As EventArgs) Handles Panel1.Click
        'ResultMain.displayControl(ResultMain.PAGE_NUMBER.MONEY_PAGE)
    End Sub

    Private Sub nomat_click(sender As Object, e As EventArgs) Handles Panel3.Click
        ResultMain.displayControl(ResultMain.PAGE_NUMBER.NOMATCH_PAGE)
    End Sub

    Private Sub Panel4_Click(sender As Object, e As EventArgs) Handles Panel4.Click
        ResultMain.displayControl(ResultMain.PAGE_NUMBER.RESULT_PAGE)
    End Sub

    Private Sub dbfPanel_Click(sender As Object, e As EventArgs) Handles dbfPanel.Click
        ResultMain.displayControl(ResultMain.PAGE_NUMBER.DBF_PAGE)
    End Sub

    Private Sub Panel2_Click(sender As Object, e As EventArgs) Handles Panel2.Click
        ResultMain.displayControl(ResultMain.PAGE_NUMBER.STOCK_PAGE)
    End Sub


End Class
