Public Class ResultMatch_CombineCards
    Implements Observer
    Public Sub New(publisher As Publisher)
        publisher.add(Me)

        ' 디자이너에서 이 호출이 필요합니다.
        InitializeComponent()

        ' InitializeComponent() 호출 뒤에 초기화 코드를 추가하세요.
        FlowLayoutPanel1.AutoScroll = True

    End Sub
    Public Sub New()

        ' 디자이너에서 이 호출이 필요합니다.
        InitializeComponent()
        FlowLayoutPanel1.AutoScroll = True
        ' InitializeComponent() 호출 뒤에 초기화 코드를 추가하세요.

    End Sub
    Public Sub updateView()

        dataInput()

    End Sub
    Public Sub ob(gen As Observer.Observer_Type) Implements Observer.ob

        If gen = Observer.Observer_Type.RESULT Then

            dataInput()

            ResultMain.displayControl(ResultMain.PAGE_NUMBER.COMMON_PAGE)

        End If

    End Sub

    Private Sub dataInput()

        Dim visitor As New TotalCombineVisitor()
        RBase.GetInstance().search(visitor)
        Dim list As ArrayList = visitor.getList()

        list.Sort(New RCombineSortByMoney())

        FlowLayoutPanel1.Controls.Clear()

        For Each r As RCombine In list
            Dim uc As UserControl = New MatchCard(r)
            FlowLayoutPanel1.Controls.Add(uc)
        Next

    End Sub

End Class
