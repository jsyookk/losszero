Public Class ResultStock_BTNS

    Public Const BTNS_HEIGTH As Integer = 150

    Dim listc As ResultStock_list
    Public Sub New(arr As ArrayList, pcontrol As ResultStock_list)

        ' 디자이너에서 이 호출이 필요합니다.
        InitializeComponent()
        ' InitializeComponent() 호출 뒤에 초기화 코드를 추가하세요.

        listc = pcontrol



        For Each info As StockList.stockInfo In arr

            Dim key As String = info.hdm & "," & info.meter
            Dim btn As New Button()
            btn.Width = FlowLayoutPanel1.Width - 10
            btn.BackColor = Color.White
            btn.Text = info.hdm & " * " & info.meter & "M (" & info.needTon & "t)"
            btn.Tag = key
            btn.FlatStyle = FlatStyle.Popup
            FlowLayoutPanel1.Controls.Add(btn)

            AddHandler btn.Click, AddressOf btn_click

        Next


    End Sub


    Private Sub btn_click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Dim btn As Button = DirectCast(sender, Button)

        Dim tempValue() As Double = Etc.getHdmAndMeter(btn.Tag)
        Dim hdm As Integer = tempValue(0)
        Dim meter As Double = tempValue(1)

        listc.update(hdm, meter)

    End Sub
End Class
