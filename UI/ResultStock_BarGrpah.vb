Public Class ResultStock_BarGrpah

    Dim hdm As Integer = 0
    Dim ton As Double = 0.0
    Dim totalTon As Double = 0.0
    Dim diffTon As Double = 0.0

    Public Sub New(arr As ArrayList)

        ' 디자이너에서 이 호출이 필요합니다.
        InitializeComponent()
        ' InitializeComponent() 호출 뒤에 초기화 코드를 추가하세요.

        Dim list As New Hashtable()

        For Each info As StockList.stockInfo In arr
            Dim key As String = info.hdm & "," & info.meter
            list.Add(key, info.needTon)
        Next

        graphPanel.Controls.Add(GraphFactory.CreateGraph(GraphFactory.X_AXIS_TYPE.HDM_METER, GraphFactory.GRAPH_TYPE.BAR_G, list, graphPanel.Size, "").getChart())


    End Sub


End Class

