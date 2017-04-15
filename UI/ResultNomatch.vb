Imports Losszero

Public Class ResultNomatch
    Implements Observer


    Dim coil As ResultNoMatch_coil
    Dim nomat As ResultNoMatch_non
    Dim nobase As ResultNoMatch_nobase


    Dim totalNomatchTon As Double
    Dim coilTon As Double
    Dim nomatchTon As Double
    Dim nobaseTon As Double

    Public Sub New(publisher As Publisher)
        InitializeComponent()

        publisher.add(Me)

        coil = New ResultNoMatch_coil(publisher)
        nomat = New ResultNoMatch_non(publisher)
        nobase = New ResultNoMatch_nobase(publisher)

        lstPanel.Controls.Add(coil)
        lstPanel.Controls.Add(nomat)
        lstPanel.Controls.Add(nobase)


        coil.Visible = True
        nomat.Visible = False
        nobase.Visible = False


        ' 디자이너에서 이 호출이 필요합니다.

        ' InitializeComponent() 호출 뒤에 초기화 코드를 추가하세요.
    End Sub

    Public Sub ob(gen As Observer.Observer_Type) Implements Observer.ob


        Dim nomatchTotalv As New NoMatchTotalTonVisitor()
        Dim coiltonv As New CoilTonVisitor()
        Dim nomatchtonv As New NoMatchTonVisitor()
        Dim nobasetonv As New NoBaseTonVisitor()

        Base.GetInstance().search(nomatchTotalv)
        Base.GetInstance().search(nomatchtonv)
        Base.GetInstance().search(coiltonv)
        Base.GetInstance().search(nobasetonv)

        totalNomatchTon = Math.Round(nomatchTotalv.getTotalLoadTon(), 3)
        coilTon = Math.Round(coiltonv.getTon(), 3)
        nomatchTon = Math.Round(nomatchtonv.getTon(), 3)
        nobaseTon = Math.Round(nobasetonv.getTon(), 3)

        totalNomatchLB.Text = CStr(totalNomatchTon & " t")
        coilTonLB.Text = CStr(coilTon) & " t"
        nomatchTonLB.Text = CStr(nomatchTon) & " t"
        noBaseTonLB.Text = CStr(nobaseTon) & " t"

        Try
            coilProgressBar.Value = CInt((coilTon / totalNomatchTon) * 100)
            nomatchProgressBar.Value = CInt((nomatchTon / totalNomatchTon) * 100)
            nobaseProgressBar.Value = CInt((nobaseTon / totalNomatchTon) * 100)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try




    End Sub

    Private Sub BunifuImageButton1_Click_1(sender As Object, e As EventArgs) Handles BunifuImageButton1.Click
        ResultMain.displayControl(ResultMain.PAGE_NUMBER.COMMON_PAGE)
    End Sub

    Private Sub tab2_Click(sender As Object, e As EventArgs) Handles tab2.Click
        BunifuSeparator1.Width = tab2.Width
        BunifuSeparator1.Left = tab2.Left

        coil.Visible = False
        nomat.Visible = True
        nobase.Visible = False

    End Sub

    Private Sub tab1_Click(sender As Object, e As EventArgs) Handles tab1.Click
        BunifuSeparator1.Width = tab1.Width
        BunifuSeparator1.Left = tab1.Left

        coil.Visible = True
        nomat.Visible = False
        nobase.Visible = False
    End Sub
    Private Sub tab3_Click(sender As Object, e As EventArgs) Handles tab3.Click
        BunifuSeparator1.Width = tab3.Width
        BunifuSeparator1.Left = tab3.Left

        coil.Visible = False
        nomat.Visible = False
        nobase.Visible = True

    End Sub


End Class
