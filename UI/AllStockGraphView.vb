Public Class AllStockGraphView

    Private list As Hashtable
    Public Sub New(list As Hashtable)

        ' 디자이너에서 이 호출이 필요합니다.
        InitializeComponent()

        ' InitializeComponent() 호출 뒤에 초기화 코드를 추가하세요.
        Me.list = list

        gPanel.Controls.Add(GraphFactory.CreateGraph(GraphFactory.X_AXIS_TYPE.HDM_METER, GraphFactory.GRAPH_TYPE.BAR_G, list, gPanel.Size, "전체 필요 톤 수").getChart())


    End Sub
    Private Sub BunifuImageButton1_Click(sender As Object, e As EventArgs) Handles BunifuImageButton1.Click
        Me.Dispose()

    End Sub
End Class