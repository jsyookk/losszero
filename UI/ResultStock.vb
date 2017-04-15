Public Class ResultStock
    Implements Observer

    Dim lists As New ResultStock_list()
    Dim selectarr As ArrayList
    Dim badArray As New ArrayList
    Dim waringArray As New ArrayList
    Dim goodArray As New ArrayList
    Dim noArray As New ArrayList

    Dim p As ResultMain
    Public Sub New(publisher As Publisher)
        publisher.add(Me)
        ' 디자이너에서 이 호출이 필요합니다.
        InitializeComponent()
        ' InitializeComponent() 호출 뒤에 초기화 코드를 추가하세요.
        listPanel.Controls.Add(lists)


    End Sub

    Public Sub ob(gen As Observer.Observer_Type) Implements Observer.ob

        If gen = Observer.Observer_Type.RESULT Then
            makeList()


        End If

    End Sub
    Private Sub makeList()

        Dim stockTonLevelVisitor As New TotalHdmMeterTonVisitor()
        RBase.GetInstance().search(stockTonLevelVisitor)
        Dim hasht As Hashtable = stockTonLevelVisitor.getHashTb()

        Dim badCnt As Integer = 0
        Dim waringCnt As Integer = 0
        Dim goodCnt As Integer = 0
        Dim noCnt As Integer = 0

        Dim htbKeys As List(Of String) = hasht.Keys.Cast(Of String)().ToList()

        badArray.Clear()
        goodArray.Clear()
        waringArray.Clear()
        noArray.Clear()

        For Each key As String In htbKeys
            Dim tempValue() As Double = Etc.getHdmAndMeter(key)
            Dim hdm As Integer = tempValue(0)
            Dim meter As Double = tempValue(1)
            Dim ton As Double = Math.Round(hasht.Item(key), 2)

            If ton <> 0 Then
                Dim info As StockList.stockInfo = StockList.GetInstance().compareStock(hdm, meter, ton)
                Select Case info.level
                    Case StockList.STOCK_LEVEL.BAD
                        badCnt += 1
                        badArray.Add(info)
                    Case StockList.STOCK_LEVEL.WARING
                        waringCnt += 1
                        waringArray.Add(info)
                    Case StockList.STOCK_LEVEL.GOOD
                        goodCnt += 1
                        goodArray.Add(info)
                    Case StockList.STOCK_LEVEL.NONE
                        noCnt += 1
                        noArray.Add(info)
                End Select
            End If

        Next

        goodTB.Text = CStr(goodCnt)
        badTB.Text = CStr(badCnt)
        waringTB.Text = CStr(waringCnt)
        noTB.Text = CStr(noCnt)


        'listPanel.Controls.Clear()


    End Sub

    Private Sub badTB_Click(sender As Object, e As EventArgs) Handles badTB.Click

        tabPanel.BackColor = Color.Red
        selectarr = badArray

        BunifuSeparator1.Width = gTab.Width
        BunifuSeparator1.Left = gTab.Left

        detailPanel.Controls.Clear()
        detailPanel.Controls.Add(New ResultStock_BarGrpah(selectarr))
    End Sub

    Private Sub waringTB_Click(sender As Object, e As EventArgs) Handles waringTB.Click

        tabPanel.BackColor = Color.Orange
        selectarr = waringArray

        BunifuSeparator1.Width = gTab.Width
        BunifuSeparator1.Left = gTab.Left

        detailPanel.Controls.Clear()
        detailPanel.Controls.Add(New ResultStock_BarGrpah(selectarr))
    End Sub

    Private Sub goodTB_Click(sender As Object, e As EventArgs) Handles goodTB.Click

        tabPanel.BackColor = Color.ForestGreen
        selectarr = goodArray

        BunifuSeparator1.Width = gTab.Width
        BunifuSeparator1.Left = gTab.Left

        detailPanel.Controls.Clear()
        detailPanel.Controls.Add(New ResultStock_BarGrpah(selectarr))
    End Sub

    Private Sub noTB_Click(sender As Object, e As EventArgs) Handles noTB.Click

        BunifuSeparator1.Width = gTab.Width
        BunifuSeparator1.Left = gTab.Left

        tabPanel.BackColor = Color.Gray
        selectarr = noArray

        detailPanel.Controls.Clear()
        detailPanel.Controls.Add(New ResultStock_BarGrpah(selectarr))

    End Sub

    Private Sub BunifuImageButton1_Click(sender As Object, e As EventArgs) Handles BunifuImageButton1.Click


        ResultMain.displayControl(ResultMain.PAGE_NUMBER.COMMON_PAGE)

    End Sub

    Private Sub gTab_Click(sender As Object, e As EventArgs) Handles gTab.Click

        BunifuSeparator1.Width = gTab.Width
        BunifuSeparator1.Left = gTab.Left

        detailPanel.Controls.Clear()

        If selectarr IsNot Nothing Then
            detailPanel.Controls.Add(New ResultStock_BarGrpah(selectarr))

        End If

    End Sub

    Private Sub mTab_Click(sender As Object, e As EventArgs) Handles mTab.Click

        BunifuSeparator1.Width = mTab.Width
        BunifuSeparator1.Left = mTab.Left

        detailPanel.Controls.Clear()

        If selectarr IsNot Nothing Then
            detailPanel.Controls.Add(New ResultStock_BTNS(selectarr, lists))
        End If

    End Sub


    Private Sub BunifuImageButton2_Click(sender As Object, e As EventArgs) Handles BunifuImageButton2.Click


        Dim stockTonLevelVisitor As New TotalHdmMeterTonVisitor()
        RBase.GetInstance().search(stockTonLevelVisitor)
        Dim hasht As Hashtable = stockTonLevelVisitor.getHashTb()

        Dim tGraphView As New AllStockGraphView(hasht)
        tGraphView.Show()



    End Sub




End Class
