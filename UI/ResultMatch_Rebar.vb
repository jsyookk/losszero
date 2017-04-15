Public Class ResultMatch_Rebar
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

            Dim visitor As New TotalCutBarVisitor()
            RBase.GetInstance().search(visitor)
            list = visitor.getlist()

            populateDataGridView(list)
        End If

    End Sub

    Private Sub populateDataGridView(list As ArrayList)

        BunifuCustomDataGrid1.DataSource = Nothing
        BunifuCustomDataGrid1.Rows.Clear()

        Dim oTable As New DataTable("rrebar")
        oTable.Columns.Add("  ", GetType(Image))
        oTable.Columns.Add("형상번호", GetType(Integer))
        oTable.Columns.Add("강종", GetType(Integer))
        oTable.Columns.Add("현장", GetType(String))
        oTable.Columns.Add("공사명", GetType(String))
        oTable.Columns.Add("부위", GetType(String))
        oTable.Columns.Add("길이", GetType(Integer))
        oTable.Columns.Add("L길이", GetType(Integer))
        oTable.Columns.Add("컷팅", GetType(Integer))
        oTable.Columns.Add("미터", GetType(Double))
        oTable.Columns.Add("필요톤수", GetType(Double))
        oTable.Columns.Add("로스", GetType(Double))
        oTable.Columns.Add("절약금액", GetType(Integer))
        oTable.Columns.Add("STEEL", GetType(Object))



        BunifuCustomDataGrid1.AllowUserToAddRows = True


        For Each rbar As RRebar In list

            Dim shapeImg As Image = ShapeList.GetInstance().getShapethumbnailImg(rbar.shpNUM)

            oTable.Rows.Add(shapeImg, rbar.shpNUM, rbar.HDM, Place.GetInstance().getMyName(rbar.sceneIDX), Place.GetInstance().getMyName(rbar.kongjungIDX), Place.GetInstance().getMyName(rbar.partIDX), rbar.displayLEN, rbar.len, rbar.cutting, rbar.UseMeter, rbar.needTon, rbar.Loss, rbar.saveMoney, SteelList.GetInstance().getItem(rbar.steIDX))


            'Dim row As DataGridViewRow = DirectCast(BunifuCustomDataGrid1.Rows(0).Clone(), DataGridViewRow)
            'Dim row As New DataGridViewRow
            'row.Tag = SteelList.GetInstance().getItem(rbar.steIDX)

            'row.Cells(0).Value = shapeImg
            'row.Cells(1).Value = rbar.shpNUM
            'row.Cells(2).Value = rbar.HDM
            'row.Cells(3).Value = Place.GetInstance().getMyName(rbar.sceneIDX)
            'row.Cells(4).Value = Place.GetInstance().getMyName(rbar.kongjungIDX)
            'row.Cells(5).Value = Place.GetInstance().getMyName(rbar.partIDX)
            'row.Cells(6).Value = rbar.displayLEN
            'row.Cells(7).Value = rbar.len
            'row.Cells(8).Value = rbar.cutting
            'row.Cells(9).Value = rbar.UseMeter
            'row.Cells(10).Value = rbar.needTon
            'row.Cells(11).Value = rbar.Loss
            'row.Cells(12).Value = rbar.saveMoney

            'oTable.Rows.Add(row)

            'BunifuCustomDataGrid1.Rows.Add(row)


        Next
        'dv = oTable.DefaultView
        '  dv.Sort = "Title Desc , published Asc"
        BunifuCustomDataGrid1.DataSource = oTable
        BunifuCustomDataGrid1.Columns(13).Visible = False

        BunifuCustomDataGrid1.AllowUserToAddRows = False

        BunifuCustomDataGrid1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.AllCells
        BunifuCustomDataGrid1.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells

        'BunifuCustomDataGrid1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells
        'BunifuCustomDataGrid1.Allow
        'BunifuCustomDataGrid1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None
        'BunifuCustomDataGrid1.AllowUserToOrderColumns = True
        'BunifuCustomDataGrid1.AllowUserToResizeColumns = True

    End Sub


    Private Sub BunifuCustomDataGrid1_CellDoubleClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles BunifuCustomDataGrid1.CellDoubleClick
        Dim bProcessDoubleClick As Boolean = False

        If BunifuCustomDataGrid1.CurrentRow IsNot Nothing Then
            If DirectCast(BunifuCustomDataGrid1.CurrentRow, DataGridViewRow) IsNot Nothing Then
                bProcessDoubleClick = True
            End If

        End If

        If bProcessDoubleClick Then
            Dim row As DataGridViewRow = BunifuCustomDataGrid1.CurrentRow
            Dim dsteform As New SteelDetailForm(row.Cells(13).Value)
            dsteform.Show()
            End If

    End Sub



    Private Sub BunifuImageButton2_Click(sender As Object, e As EventArgs) Handles BunifuImageButton2.Click

        Dim filter As New ListFilter(ListFilter.LIST_TYPE.RENTRY, list)

        If filter.ShowDialog() = Windows.Forms.DialogResult.OK Then

            populateDataGridView(filter.filterdList())

        End If


    End Sub


End Class
