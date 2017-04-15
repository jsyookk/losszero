Public Class ResultNoMatch_non
    Implements Observer
    Dim list As ArrayList
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
            Dim visitor As New NoMatchVisitor()
            Base.GetInstance().search(visitor)

            list = visitor.getList()
            populateDataGridView(list)

        End If

    End Sub

    Private Sub populateDataGridView(list As ArrayList)

        BunifuCustomDataGrid1.DataSource = Nothing
        BunifuCustomDataGrid1.Rows.Clear()

        Dim oTable As New DataTable("rrebar")
        oTable.Columns.Add(" ", GetType(Image))
        oTable.Columns.Add("형상번호", GetType(Integer))
        oTable.Columns.Add("강종", GetType(Integer))
        oTable.Columns.Add("현장", GetType(String))
        oTable.Columns.Add("공사명", GetType(String))
        oTable.Columns.Add("부위", GetType(String))
        oTable.Columns.Add("길이", GetType(Integer))
        oTable.Columns.Add("L'길이", GetType(Integer))
        oTable.Columns.Add("톤수", GetType(Double))
        oTable.Columns.Add("STEEL", GetType(Object))


        BunifuCustomDataGrid1.AllowUserToAddRows = True

        For Each base As BaseData In list

            Dim shapeImg As Image = ShapeList.GetInstance().getShapethumbnailImg(base.shpNUM)
            oTable.Rows.Add(shapeImg, base.shpNUM, base.hdm, Place.GetInstance().getMyName(base.sceneIdx), Place.GetInstance().getMyName(base.kongjungIdx), Place.GetInstance().getMyName(base.partIdx), base.DisplayLegnth, base.Legnth, base.Ton, SteelList.GetInstance().getItem(base.steIndex))


            'Dim row As DataGridViewRow = DirectCast(BunifuCustomDataGrid1.Rows(0).Clone(), DataGridViewRow)



            'row.Tag = SteelList.GetInstance().getItem(base.steIndex)

            'Dim shapeImg As Image = ShapeList.GetInstance().getShapethumbnailImg(base.shpNUM)
            'row.Cells(0).Value = shapeImg
            'row.Cells(1).Value = base.shpNUM
            'row.Cells(2).Value = base.hdm
            'row.Cells(3).Value = Place.GetInstance().getMyName(base.sceneIdx)
            'row.Cells(4).Value = Place.GetInstance().getMyName(base.kongjungIdx)
            'row.Cells(5).Value = Place.GetInstance().getMyName(base.partIdx)
            'row.Cells(6).Value = base.DisplayLegnth
            'row.Cells(7).Value = base.Legnth
            'row.Cells(8).Value = base.Ton
            'BunifuCustomDataGrid1.Rows.Add(row)

        Next

        BunifuCustomDataGrid1.DataSource = oTable
        BunifuCustomDataGrid1.Columns(9).Visible = False

        BunifuCustomDataGrid1.AllowUserToAddRows = False
        BunifuCustomDataGrid1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.AllCells
        BunifuCustomDataGrid1.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells


    End Sub

    Private Sub BunifuCustomDataGrid1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles BunifuCustomDataGrid1.CellDoubleClick

        Dim bProcessDoubleClick As Boolean = False

        If BunifuCustomDataGrid1.CurrentRow IsNot Nothing Then
            If DirectCast(BunifuCustomDataGrid1.CurrentRow, DataGridViewRow) IsNot Nothing Then
                bProcessDoubleClick = True
            End If

        End If

        If bProcessDoubleClick Then
            Dim row As DataGridViewRow = BunifuCustomDataGrid1.CurrentRow
            Dim dsteform As New SteelDetailForm(row.Cells(9).Value)
            dsteform.Show()
        End If

    End Sub

    Private Sub BunifuImageButton2_Click(sender As Object, e As EventArgs) Handles BunifuImageButton2.Click

        Dim filter As New ListFilter(ListFilter.LIST_TYPE.BASEDATA, list)

        If filter.ShowDialog() = Windows.Forms.DialogResult.OK Then

            populateDataGridView(filter.filterdList())

        End If
    End Sub
End Class
