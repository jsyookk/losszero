Public Class ResultMatch_Combine
    Implements Observer
    Public Sub New(publisher As Publisher)
        publisher.add(Me)

        ' 디자이너에서 이 호출이 필요합니다.
        InitializeComponent()

        ' InitializeComponent() 호출 뒤에 초기화 코드를 추가하세요.

    End Sub
    Public Sub updateView()

        dataInput()

    End Sub
    Public Sub ob(gen As Observer.Observer_Type) Implements Observer.ob

        If gen = Observer.Observer_Type.RESULT Then

            dataInput()

        End If

    End Sub

    Private Sub dataInput()

        BunifuCustomDataGrid1.DataSource = Nothing
        BunifuCustomDataGrid1.Rows.Clear()
        BunifuCustomDataGrid1.AllowUserToAddRows = True

        Dim visitor As New TotalCombineVisitor()
        RBase.GetInstance().search(visitor)
        Dim list As ArrayList = visitor.getList()



        For Each r As RCombine In list

            Dim linkCnt As Integer = 1
            Dim uniqueStr As String = r.getUniqueStr
            Dim needTon As Double = r.needTon
            Dim saveMoney As Integer = r.saveMoney
            Dim loss As Double = r.Loss

            If r.COMBINE_TYPE = RCombine.CBType.PERPECT Then

                For Each s As RCombineElement In r.getList()

                    If s.GetType().FullName() = "Losszero.RCombineSte" Then
                        Dim ste As RCombineSte = DirectCast(s, RCombineSte)
                        Dim row As DataGridViewRow = DirectCast(BunifuCustomDataGrid1.Rows(0).Clone(), DataGridViewRow)

                        row.Cells(0).Value = uniqueStr
                        row.Cells(1).Value = uniqueStr
                        row.Cells(2).Value = needTon
                        row.Cells(3).Value = saveMoney
                        row.Cells(4).Value = loss
                        row.Cells(5).Value = linkCnt
                        row.Cells(6).Value = ste.mUninqueIDX
                        row.Cells(7).Value = "현장"
                        row.Cells(8).Value = "공정명"
                        row.Cells(9).Value = "부위"
                        row.Cells(10).Value = ste.mLen
                        row.Cells(11).Value = ste.mcut

                        row.Tag = r
                        BunifuCustomDataGrid1.Rows.Add(row)

                    End If
                Next

            ElseIf r.COMBINE_TYPE = RCombine.CBType.REMAIN_CUT Then
                For Each element As RCombineElement In r.getList()

                    If element.GetType().FullName = "Losszero.RCombineSte" Then

                        linkCnt = 1

                        Dim rste As RCombineSte = DirectCast(element, RCombineSte)
                        Dim row As DataGridViewRow = DirectCast(BunifuCustomDataGrid1.Rows(0).Clone(), DataGridViewRow)
                        row.Cells(0).Value = uniqueStr
                        row.Cells(1).Value = uniqueStr
                        row.Cells(2).Value = needTon
                        row.Cells(3).Value = saveMoney
                        row.Cells(4).Value = loss
                        row.Cells(5).Value = linkCnt
                        row.Cells(6).Value = rste.mUninqueIDX
                        row.Cells(7).Value = "현장"
                        row.Cells(8).Value = "공정명"
                        row.Cells(9).Value = "부위"
                        row.Cells(10).Value = rste.mLen
                        row.Cells(11).Value = rste.mcut
                        row.Tag = r
                        BunifuCustomDataGrid1.Rows.Add(row)

                    ElseIf element.GetType().FullName = "Losszero.RCombineRemain" Then

                        linkCnt += 1

                        For Each ele As RCombineElement In element.getList()
                            If ele.GetType().FullName = "Losszero.RCombineSte" Then
                                Dim rste As RCombineSte = DirectCast(ele, RCombineSte)
                                Dim row As DataGridViewRow = DirectCast(BunifuCustomDataGrid1.Rows(0).Clone(), DataGridViewRow)
                                row.Cells(0).Value = uniqueStr
                                row.Cells(1).Value = uniqueStr
                                row.Cells(2).Value = needTon
                                row.Cells(3).Value = saveMoney
                                row.Cells(4).Value = loss
                                row.Cells(5).Value = linkCnt
                                row.Cells(6).Value = rste.mUninqueIDX
                                row.Cells(7).Value = "현장"
                                row.Cells(8).Value = "공정명"
                                row.Cells(9).Value = "부위"
                                row.Cells(10).Value = rste.mLen
                                row.Cells(11).Value = rste.mcut
                                row.Tag = r
                                BunifuCustomDataGrid1.Rows.Add(row)
                            End If
                        Next
                    End If


                Next


            End If

        Next

    End Sub

    Private Sub BunifuCustomDataGrid1_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles BunifuCustomDataGrid1.CellFormatting

        If e.RowIndex = 0 Then
            Return
        End If

        If isRepeatCellValue(e.RowIndex, e.ColumnIndex) Then
            e.Value = String.Empty
            e.FormattingApplied = True
        End If

    End Sub

    Private Function isRepeatCellValue(ByVal rowIndex As Integer, ByVal colIndex As Integer) As Boolean

        If colIndex = 0 Or colIndex = 1 Or colIndex = 2 Or colIndex = 3 Or colIndex = 4 Then

            Dim currCell As DataGridViewCell = BunifuCustomDataGrid1.Rows(rowIndex).Cells(colIndex)
            Dim prevCell As DataGridViewCell = BunifuCustomDataGrid1.Rows(rowIndex - 1).Cells(colIndex)

            If (currCell.Value Is prevCell.Value) OrElse (currCell.Value IsNot Nothing AndAlso prevCell.Value IsNot Nothing AndAlso currCell.Value.ToString() = prevCell.Value.ToString()) Then
                Return True
            Else
                Return False
            End If

        Else
            Return False
        End If


    End Function


    Private Sub BunifuCustomDataGrid1_CellPainting(sender As Object, e As DataGridViewCellPaintingEventArgs) Handles BunifuCustomDataGrid1.CellPainting

        e.AdvancedBorderStyle.Bottom = DataGridViewAdvancedCellBorderStyle.None

        If e.RowIndex < 1 OrElse e.ColumnIndex < 0 Then
            Return
        End If

        If isRepeatCellValue(e.RowIndex, e.ColumnIndex) Then
            e.AdvancedBorderStyle.Top = DataGridViewAdvancedCellBorderStyle.None
        Else
            e.AdvancedBorderStyle.Top = DataGridViewAdvancedCellBorderStyle.Single

        End If

    End Sub

    Private Sub BunifuCustomDataGrid1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles BunifuCustomDataGrid1.CellContentClick

        Dim senderGrid = DirectCast(sender, DataGridView)



        If TypeOf senderGrid.Columns(e.ColumnIndex) Is DataGridViewButtonColumn AndAlso e.RowIndex >= 0 Then

            Dim row As DataGridViewRow = BunifuCustomDataGrid1.Rows(e.RowIndex)

            Dim graphviwer As New GraphViewerForm()

            Dim rc As RCombine = row.Tag

            If rc IsNot Nothing Then
                graphviwer.updateGraph(row.Tag)
                graphviwer.Show()
            End If
        End If

    End Sub


End Class
