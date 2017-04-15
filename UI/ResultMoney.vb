Public Class ResultMoney
    Implements Observer

    Public Sub New(publisher As Publisher)
        publisher.add(Me)

        ' 디자이너에서 이 호출이 필요합니다.
        InitializeComponent()

        ' InitializeComponent() 호출 뒤에 초기화 코드를 추가하세요.

    End Sub
    Public Sub New()

        ' 디자이너에서 이 호출이 필요합니다.
        InitializeComponent()

        ' InitializeComponent() 호출 뒤에 초기화 코드를 추가하세요.

    End Sub

    Public Sub ob(gen As Observer.Observer_Type) Implements Observer.ob

        If gen = Observer.Observer_Type.RESULT Then


        End If

    End Sub

    Private Sub BunifuImageButton1_Click(sender As Object, e As EventArgs) Handles BunifuImageButton1.Click
        ResultMain.displayControl(ResultMain.PAGE_NUMBER.COMMON_PAGE)
    End Sub


End Class
