Public Class ResultMatch_Error
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

            Dim visitor As New TotalErrorVisitor()
            RBase.GetInstance().search(visitor)

            list = visitor.getlist()

            populateDataGridView(list)
        End If

    End Sub

    Private Sub populateDataGridView(list As ArrayList)

        BunifuCustomDataGrid1.DataSource = Nothing
        BunifuCustomDataGrid1.Rows.Clear()
        BunifuCustomDataGrid1.AllowUserToAddRows = True


        Dim oTable As New DataTable("rrebar")
        oTable.Columns.Add(" ", GetType(Image))
        oTable.Columns.Add("형상번호", GetType(Integer))
        oTable.Columns.Add("강종", GetType(Integer))
        oTable.Columns.Add("현장", GetType(String))
        oTable.Columns.Add("공사명", GetType(String))
        oTable.Columns.Add("부위", GetType(String))
        oTable.Columns.Add("길이", GetType(Integer))
        oTable.Columns.Add("오차", GetType(Integer))
        oTable.Columns.Add("L길이", GetType(Integer))
        oTable.Columns.Add("컷팅", GetType(Integer))
        oTable.Columns.Add("미터", GetType(Double))
        oTable.Columns.Add("필요톤수", GetType(Double))
        oTable.Columns.Add("로스", GetType(Double))
        oTable.Columns.Add("절약금액", GetType(Integer))
        oTable.Columns.Add("STEEL", GetType(Object))

        For Each rbar As RRebar In list

            Dim shapeImg As Image = ShapeList.GetInstance().getShapethumbnailImg(rbar.shpNUM)

            oTable.Rows.Add(shapeImg, rbar.shpNUM, rbar.HDM, Place.GetInstance().getMyName(rbar.sceneIDX), Place.GetInstance().getMyName(rbar.kongjungIDX), Place.GetInstance().getMyName(rbar.partIDX), rbar.displayLEN, rbar.errorLEN, rbar.len, rbar.cutting, rbar.UseMeter, rbar.needTon, rbar.Loss, rbar.saveMoney, SteelList.GetInstance().getItem(rbar.steIDX))

        Next

        BunifuCustomDataGrid1.DataSource = oTable
        BunifuCustomDataGrid1.Columns(14).Visible = False

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
            Dim dsteform As New SteelDetailForm(row.Cells(14).Value)
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
