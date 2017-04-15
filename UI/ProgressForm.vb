Public Class ProgressForm
    Public Sub New()

        ' 디자이너에서 이 호출이 필요합니다.
        InitializeComponent()

        ' InitializeComponent() 호출 뒤에 초기화 코드를 추가하세요.
        Me.StartPosition = FormStartPosition.CenterScreen


    End Sub

    'Delegate Sub DelegateUpdate(ByVal progress As Integer)
    'Delegate Sub DelegateClose(ByRef dialog As Form)

    Public Sub closeFromBackground()

        If Me.InvokeRequired Then
            Me.Invoke(New MethodInvoker(AddressOf closeFromBackground))
        Else
            Me.Close()
        End If

    End Sub


End Class