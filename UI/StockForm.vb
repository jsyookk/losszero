Public Class StockForm

    Enum STOCK_GROUP
        MM410
        MM413
        MM416
        MM419
        MM422
        MM425
        MM429
        MM432
        MM435
        MM510
        MM513
        MM516
        MM519
        MM522
        MM525
        MM529
        MM532
        MM535
        MM610
        MM613
        MM616
        MM619
        MM622
        MM625
        MM629
        MM632
        MM635
    End Enum


    Dim stkIdx As Integer
    Dim stocklist As StockList = StockList.GetInstance()
    Public Sub dataLoad()
        ListView1.Clear()

        ' InitializeComponent() 호출 뒤에 초기화 코드를 추가하세요.
        With ListView1
            .View = View.Details
            .FullRowSelect = True
            .GridLines = True
            .LabelEdit = False
            .Columns.Add("길이(M)")
            .Columns.Add("톤수(t)")
            .Groups.Add("410", "SD400 * 10mm")
            .Groups.Add("413", "SD400 * 13mm")
            .Groups.Add("416", "SD400 * 16mm")
            .Groups.Add("419", "SD400 * 19mm")
            .Groups.Add("422", "SD400 * 22mm")
            .Groups.Add("425", "SD400 * 25mm")
            .Groups.Add("429", "SD400 * 29mm")
            .Groups.Add("432", "SD400 * 32mm")
            .Groups.Add("435", "SD400 * 35mm")
            .Groups.Add("510", "SD500 * 10mm")
            .Groups.Add("513", "SD500 * 13mm")
            .Groups.Add("516", "SD500 * 16mm")
            .Groups.Add("519", "SD500 * 19mm")
            .Groups.Add("522", "SD500 * 22mm")
            .Groups.Add("525", "SD500 * 25mm")
            .Groups.Add("529", "SD500 * 29mm")
            .Groups.Add("532", "SD500 * 32mm")
            .Groups.Add("535", "SD500 * 35mm")
            .Groups.Add("610", "SD600 * 10mm")
            .Groups.Add("613", "SD600 * 13mm")
            .Groups.Add("616", "SD600 * 16mm")
            .Groups.Add("619", "SD600 * 19mm")
            .Groups.Add("622", "SD600 * 22mm")
            .Groups.Add("625", "SD600 * 25mm")
            .Groups.Add("629", "SD600 * 29mm")
            .Groups.Add("632", "SD600 * 32mm")
            .Groups.Add("635", "SD600 * 35mm")

            Dim index As Integer = 0
            For i = 1 To stocklist.count
                Dim stk As Stock = stocklist.getItem(i)

                .Items.Add(stk.len).SubItems.Add(stk.ton)
                .Items(index).Tag = i

                Select Case stk.group
                    Case 410
                        .Items(index).Group = .Groups(STOCK_GROUP.MM410)
                    Case 413
                        .Items(index).Group = .Groups(STOCK_GROUP.MM413)
                    Case 416
                        .Items(index).Group = .Groups(STOCK_GROUP.MM416)
                    Case 419
                        .Items(index).Group = .Groups(STOCK_GROUP.MM419)
                    Case 422
                        .Items(index).Group = .Groups(STOCK_GROUP.MM422)
                    Case 425
                        .Items(index).Group = .Groups(STOCK_GROUP.MM425)
                    Case 429
                        .Items(index).Group = .Groups(STOCK_GROUP.MM429)
                    Case 432
                        .Items(index).Group = .Groups(STOCK_GROUP.MM432)
                    Case 435
                        .Items(index).Group = .Groups(STOCK_GROUP.MM435)
                    Case 510
                        .Items(index).Group = .Groups(STOCK_GROUP.MM510)
                    Case 513
                        .Items(index).Group = .Groups(STOCK_GROUP.MM513)
                    Case 516
                        .Items(index).Group = .Groups(STOCK_GROUP.MM516)
                    Case 519
                        .Items(index).Group = .Groups(STOCK_GROUP.MM519)
                    Case 522
                        .Items(index).Group = .Groups(STOCK_GROUP.MM522)
                    Case 525
                        .Items(index).Group = .Groups(STOCK_GROUP.MM525)
                    Case 532
                        .Items(index).Group = .Groups(STOCK_GROUP.MM532)
                    Case 535
                        .Items(index).Group = .Groups(STOCK_GROUP.MM535)
                    Case 610
                        .Items(index).Group = .Groups(STOCK_GROUP.MM610)
                    Case 613
                        .Items(index).Group = .Groups(STOCK_GROUP.MM613)
                    Case 616
                        .Items(index).Group = .Groups(STOCK_GROUP.MM616)
                    Case 619
                        .Items(index).Group = .Groups(STOCK_GROUP.MM619)
                    Case 622
                        .Items(index).Group = .Groups(STOCK_GROUP.MM622)
                    Case 625
                        .Items(index).Group = .Groups(STOCK_GROUP.MM625)
                    Case 629
                        .Items(index).Group = .Groups(STOCK_GROUP.MM629)
                    Case 632
                        .Items(index).Group = .Groups(STOCK_GROUP.MM632)
                    Case 635
                        .Items(index).Group = .Groups(STOCK_GROUP.MM635)


                End Select

                index += 1

            Next


        End With

    End Sub


    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged

        If ListView1.SelectedItems.Count > 0 Then
            lenTB.Text = ListView1.SelectedItems(0).Text
            tonTB.Text = ListView1.SelectedItems(0).SubItems(1).Text

            stkIdx = CInt(ListView1.SelectedItems(0).Tag)
        End If

    End Sub

    Private Sub editBTN_Click(sender As Object, e As EventArgs) Handles editBTN.Click

        If stkIdx = 0 Then
            MessageBox.Show("리스트에서 수정할 곳을 선택해주세요.")
        Else
            stocklist.edit(stkIdx, CDbl(lenTB.Text), CDbl(tonTB.Text))
            dataLoad()
        End If



    End Sub

    Private Sub addBTN_Click(sender As Object, e As EventArgs) Handles addBTN.Click

        Dim stockadd As StockAddForm = New StockAddForm()
        stockadd.ShowDialog()

    End Sub

    Private Sub BunifuImageButton1_Click(sender As Object, e As EventArgs) Handles BunifuImageButton1.Click


        Dim zxmlstock As ZXml = New ZXmlStock()
        zxmlstock.write(My.Application.Info.DirectoryPath & "\xml\stock.xml")

        'stock Meter relead
        SteelMeter.GetInstance().initStockMeter()

        Me.Close()

    End Sub

    Private Sub StockForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        dataLoad()

    End Sub

    Private Sub frm_closeing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing

        Me.Hide()
        e.Cancel = True

    End Sub

    Private Sub delBTN_Click_1(sender As Object, e As EventArgs) Handles delBTN.Click


        If stkIdx = 0 Then
            MessageBox.Show("리스트에서 삭제할 곳을 선택해주세요.")
        Else
            stocklist.remove(stkIdx)
            dataLoad()

        End If

    End Sub
End Class