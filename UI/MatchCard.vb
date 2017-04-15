Public Class MatchCard
    Dim rc As RCombine
    Public Sub New(data As RCombine)
        ' 디자이너에서 이 호출이 필요합니다.
        InitializeComponent()

        ' InitializeComponent() 호출 뒤에 초기화 코드를 추가하세요.

        Me.rc = data

        lossLB.Text = data.Loss & "%"
        saveMoneyLB.Text = data.saveMoney & "원"
        titleLB.Text = data.hdmStr & " * " & data.UseMeter & "M" & " * " & data.needTon & "t"
        uniqueLB.Text = data.getUniqueStr

        Inputlistview_data()

    End Sub

    Private Sub Inputlistview_data()

        BunifuCustomDataGrid1.DataSource = Nothing
        BunifuCustomDataGrid1.AllowUserToAddRows = True

        Dim groupingIdx As Integer = 1

        If rc.COMBINE_TYPE = RCombine.CBType.PERPECT Then

            BunifuCards1.color = Color.Aqua

            For Each s As RCombineElement In rc.getList()

                If s.GetType().FullName() = "Losszero.RCombineSte" Then
                    Dim ste As RCombineSte = DirectCast(s, RCombineSte)
                    Dim realste As Steel = SteelList.GetInstance().getItem(ste.msteIDX)
                    Dim row As DataGridViewRow = DirectCast(BunifuCustomDataGrid1.Rows(0).Clone(), DataGridViewRow)

                    row.Cells(0).Value = groupingIdx
                    row.Cells(1).Value = ste.mUninqueIDX
                    row.Cells(2).Value = Place.GetInstance().getMyName(realste.sceneIDX)
                    row.Cells(3).Value = Place.GetInstance().getMyName(realste.kongjungIDX)
                    row.Cells(4).Value = Place.GetInstance().getMyName(realste.partIDX)
                    row.Cells(5).Value = ste.mLen
                    row.Cells(6).Value = ste.mcut
                    BunifuCustomDataGrid1.Rows.Add(row)

                End If

            Next

        ElseIf rc.COMBINE_TYPE = RCombine.CBType.REMAIN_CUT Then

            BunifuCards1.color = Color.Beige

            groupingIdx = 1

            For Each s As RCombineElement In rc.getList()

                If s.GetType().FullName() = "Losszero.RCombineSte" Then
                    Dim ste As RCombineSte = DirectCast(s, RCombineSte)
                    Dim realste As Steel = SteelList.GetInstance().getItem(ste.msteIDX)
                    Dim row As DataGridViewRow = DirectCast(BunifuCustomDataGrid1.Rows(0).Clone(), DataGridViewRow)

                    row.Cells(0).Value = groupingIdx
                    row.Cells(1).Value = ste.mUninqueIDX
                    row.Cells(2).Value = Place.GetInstance().getMyName(realste.sceneIDX)
                    row.Cells(3).Value = Place.GetInstance().getMyName(realste.kongjungIDX)
                    row.Cells(4).Value = Place.GetInstance().getMyName(realste.partIDX)
                    row.Cells(5).Value = ste.mLen
                    row.Cells(6).Value = ste.mcut

                    BunifuCustomDataGrid1.Rows.Add(row)
                ElseIf s.GetType().FullName() = "Losszero.RCombineRemain" Then
                    groupingIdx += 1

                    For Each ele As RCombineElement In s.getList()
                        If ele.GetType().FullName = "Losszero.RCombineSte" Then
                            Dim ste As RCombineSte = DirectCast(ele, RCombineSte)
                            Dim realste As Steel = SteelList.GetInstance().getItem(ste.msteIDX)
                            Dim row As DataGridViewRow = DirectCast(BunifuCustomDataGrid1.Rows(0).Clone(), DataGridViewRow)
                            row.Cells(0).Value = groupingIdx
                            row.Cells(1).Value = ste.mUninqueIDX
                            row.Cells(2).Value = Place.GetInstance().getMyName(realste.sceneIDX)
                            row.Cells(3).Value = Place.GetInstance().getMyName(realste.kongjungIDX)
                            row.Cells(4).Value = Place.GetInstance().getMyName(realste.partIDX)
                            row.Cells(5).Value = ste.mLen
                            row.Cells(6).Value = ste.mcut
                            BunifuCustomDataGrid1.Rows.Add(row)
                        End If
                    Next

                End If

            Next

        ElseIf rc.COMBINE_TYPE = RCombine.CBType.LINKED Then

            BunifuCards1.color = Color.Coral
            lossLB.Visible = False
            groupingIdx = 0

            For Each s As RCombineElement In rc.getList()

                If s.GetType().FullName() = "Losszero.RCombineLink" Then

                    groupingIdx += 1

                    For Each se As RCombineSte In s.getList()

                        Dim ste As RCombineSte = DirectCast(se, RCombineSte)
                        Dim realste As Steel = SteelList.GetInstance().getItem(ste.msteIDX)
                        Dim row As DataGridViewRow = DirectCast(BunifuCustomDataGrid1.Rows(0).Clone(), DataGridViewRow)

                        row.Cells(0).Value = groupingIdx
                        row.Cells(1).Value = ste.mUninqueIDX
                        row.Cells(2).Value = Place.GetInstance().getMyName(realste.sceneIDX)
                        row.Cells(3).Value = Place.GetInstance().getMyName(realste.kongjungIDX)
                        row.Cells(4).Value = Place.GetInstance().getMyName(realste.partIDX)
                        row.Cells(5).Value = ste.mLen
                        row.Cells(6).Value = ste.mcut

                        BunifuCustomDataGrid1.Rows.Add(row)

                    Next
                End If

            Next


        End If



    End Sub

    Private Sub graphBTN_Click(sender As Object, e As EventArgs) Handles graphBTN.Click

        If rc IsNot Nothing Then

            Dim graphviwer As New GraphViewerForm()
            graphviwer.updateGraph(rc)
            graphviwer.Show()

        End If
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

        If colIndex = 0 Then

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

    Private Sub uniqueChk_OnChange(sender As Object, e As EventArgs) Handles uniqueChk.OnChange

        If uniqueChk.Checked Then
            rc.setUniqueNumber()
            uniqueLB.Text = rc.getUniqueStr
        Else
            rc.clearUniqueNumber()
        End If


    End Sub


End Class
