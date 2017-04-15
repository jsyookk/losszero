Public Class ResultStock_cut

    Public Sub updateData(list As ArrayList)

        populateDataGridView(list)

    End Sub


    Private Sub populateDataGridView(list As ArrayList)

        BunifuCustomDataGrid1.DataSource = Nothing
        BunifuCustomDataGrid1.Rows.Clear()
        BunifuCustomDataGrid1.AllowUserToAddRows = True
        'BunifuCustomDataGrid1.Columns(0).Width = ShapeList.GetInstance().getShapethumbnailImgSize.Width

        For Each rent As REntry In list

            If rent.GetType.FullName = "Losszero.RRebar" Then
                Dim rbar As RRebar = DirectCast(rent, RRebar)
                Dim row As DataGridViewRow = DirectCast(BunifuCustomDataGrid1.Rows(0).Clone(), DataGridViewRow)
                row.Tag = SteelList.GetInstance().getItem(rbar.steIDX)
                Dim shapeImg As Image = ShapeList.GetInstance().getShapethumbnailImg(rbar.shpNUM)

                row.Cells(0).Value = shapeImg
                row.Cells(1).Value = rbar.shpNUM
                row.Cells(2).Value = rbar.HDM
                row.Cells(3).Value = Place.GetInstance().getMyName(rbar.sceneIDX)
                    row.Cells(4).Value = Place.GetInstance().getMyName(rbar.kongjungIDX)
                    row.Cells(5).Value = Place.GetInstance().getMyName(rbar.partIDX)
                    row.Cells(6).Value = rbar.displayLEN
                    row.Cells(7).Value = rbar.len
                    row.Cells(8).Value = rbar.cutting
                    row.Cells(9).Value = rbar.UseMeter
                    row.Cells(10).Value = rbar.needTon
                    row.Cells(11).Value = rbar.Loss
                    row.Cells(12).Value = rbar.saveMoney

                    BunifuCustomDataGrid1.Rows.Add(row)

            End If

        Next

        BunifuCustomDataGrid1.AllowUserToAddRows = False
        BunifuCustomDataGrid1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        'BunifuCustomDataGrid1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None
        'BunifuCustomDataGrid1.AllowUserToOrderColumns = True
        'BunifuCustomDataGrid1.AllowUserToResizeColumns = True

    End Sub

    Private Sub BunifuCustomDataGrid1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles BunifuCustomDataGrid1.CellDoubleClick

        Dim bProcessDoubleClick As Boolean = False

        If BunifuCustomDataGrid1.CurrentRow IsNot Nothing Then
            If DirectCast(BunifuCustomDataGrid1.CurrentRow, DataGridViewRow) IsNot Nothing Then
                bProcessDoubleClick = True
            End If

        End If

        If bProcessDoubleClick Then

            Dim dsteform As New SteelDetailForm(BunifuCustomDataGrid1.CurrentRow.Tag)
            dsteform.Show()
        End If




    End Sub

End Class
