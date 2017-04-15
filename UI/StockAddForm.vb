Public Class StockAddForm

    Private Sub BunifuImageButton1_Click(sender As Object, e As EventArgs) Handles BunifuImageButton1.Click
        Me.Hide()
    End Sub

    Private Sub addBTN_Click(sender As Object, e As EventArgs) Handles addBTN.Click

        Dim newStock As Stock = New Stock()
        Dim stklist As StockList = StockList.GetInstance()

        Select Case sdDropMnu.selectedIndex
            Case 0
                newStock.sd = 400
            Case 1
                newStock.sd = 500
            Case 2
                newStock.sd = 600

        End Select


        Select Case mmDropMnu.selectedIndex
            Case 0
                newStock.dimen = 10
            Case 1
                newStock.dimen = 13
            Case 2
                newStock.dimen = 16
            Case 3
                newStock.dimen = 19
            Case 4
                newStock.dimen = 22
            Case 5
                newStock.dimen = 25
            Case 6
                newStock.dimen = 29
            Case 7
                newStock.dimen = 32
            Case 8
                newStock.dimen = 35
        End Select

        If meterLB.Text = "" Then
            MessageBox.Show("길이를 입력해 주세요.")
        ElseIf tonTB.Text = "" Then
            MessageBox.Show("톤 수를 입력해 주세요.")
        Else
            newStock.len = CDbl(meterLB.Text)
            newStock.ton = CDbl(tonTB.Text)
            newStock.group = newStock.sd + newStock.dimen

            If stklist.check(newStock.sd, newStock.dimen, newStock.len) Then
                MessageBox.Show("이미 같은 강종의 미터가 있습니다.")
            Else
                stklist.Add(newStock)
                InputDataControl.frmStock.dataLoad()
            End If

        End If




    End Sub
End Class