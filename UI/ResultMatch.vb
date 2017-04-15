Public Class ResultMatch
    Implements Observer


    Dim resultZangdae As ResultMatch_Zangdae
    Dim resultBar As ResultMatch_Rebar
    Dim resultZum As ResultMatch_Zum
    'Dim resultCombine As ResultMatch_Combine
    Dim resultCombineCards As ResultMatch_CombineCards
    Dim resultError As ResultMatch_Error

    Dim resultTotalTon As Double = 0.0
    Dim zzangdaeTon As Double = 0.0
    Dim errTon As Double = 0.0
    Dim cutTon As Double = 0.0
    Dim zumTon As Double = 0.0
    Dim combineTon As Double = 0.0


    Public Sub New(publisher As Publisher)
        publisher.add(Me)

        ' 디자이너에서 이 호출이 필요합니다.
        InitializeComponent()

        resultZangdae = New ResultMatch_Zangdae(publisher)
        resultBar = New ResultMatch_Rebar(publisher)
        resultZum = New ResultMatch_Zum(publisher)
        resultError = New ResultMatch_Error(publisher)
        resultCombineCards = New ResultMatch_CombineCards(publisher)


        listviewPanel.Controls.Add(resultBar)
        listviewPanel.Controls.Add(resultZum)
        listviewPanel.Controls.Add(resultZangdae)
        listviewPanel.Controls.Add(resultCombineCards)
        listviewPanel.Controls.Add(resultError)

        resultBar.Visible = False
        resultZum.Visible = False
        resultZangdae.Visible = True
        resultCombineCards.Visible = False
        resultError.Visible = False


    End Sub

    Public Sub ob(gen As Observer.Observer_Type) Implements Observer.ob

        If gen = Observer.Observer_Type.RESULT Then

            Dim eachTonv As New EachTonVisitor()
            RBase.GetInstance().search(eachTonv)

            Dim hasht As Hashtable = eachTonv.getEachTotalTon()

            resultTotalTon = Math.Round(hasht(EachTonVisitor.TYPE_TON.TOTAL), 3)
            zzangdaeTon = Math.Round(hasht(EachTonVisitor.TYPE_TON.ZZANG_DAE), 3)
            cutTon = Math.Round(hasht(EachTonVisitor.TYPE_TON.CUTTING), 3)
            zumTon = Math.Round(hasht(EachTonVisitor.TYPE_TON.ZUM), 3)
            combineTon = Math.Round(hasht(EachTonVisitor.TYPE_TON.COMBINE), 3)
            errTon = Math.Round(hasht(EachTonVisitor.TYPE_TON.ERROR_), 3)

            resultTotalTonLB.Text = CStr(resultTotalTon)
            zangdaeTonLB.Text = CStr(zzangdaeTon)
            zumTonLB.Text = CStr(zumTon)
            cutTonLB.Text = CStr(cutTon)
            combineTonLB.Text = CStr(combineTon)
            errTonLB.Text = CStr(errTon)

            Try
                zzangdaeProgress.Value = CInt((zzangdaeTon / resultTotalTon) * 100)
                zumProgress.Value = CInt((zumTon / resultTotalTon) * 100)
                cutProgress.Value = CInt((cutTon / resultTotalTon) * 100)
                combineProgress.Value = CInt((combineTon / resultTotalTon) * 100)
                errProgressbar.Value = CInt((errTon / resultTotalTon) * 100)
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try



        End If

    End Sub

    Private Sub BunifuImageButton1_Click_1(sender As Object, e As EventArgs) Handles BunifuImageButton1.Click
        ResultMain.displayControl(ResultMain.PAGE_NUMBER.COMMON_PAGE)
    End Sub

    Private Sub tab1_Click(sender As Object, e As EventArgs) Handles tab1.Click

        BunifuSeparator1.Width = tab1.Width
        BunifuSeparator1.Left = tab1.Left

        resultBar.Visible = True
        resultZum.Visible = False
        resultCombineCards.Visible = False
        resultZangdae.Visible = False
        resultError.Visible = False
    End Sub

    Private Sub tab2_Click(sender As Object, e As EventArgs) Handles tab2.Click

        BunifuSeparator1.Width = tab2.Width
        BunifuSeparator1.Left = tab2.Left

        resultBar.Visible = False
        resultZum.Visible = True
        resultCombineCards.Visible = False
        resultZangdae.Visible = False
        resultError.Visible = False
    End Sub

    Private Sub tab3_Click(sender As Object, e As EventArgs) Handles tab3.Click

        BunifuSeparator1.Width = tab3.Width
        BunifuSeparator1.Left = tab3.Left

        resultBar.Visible = False
        resultZum.Visible = False
        resultCombineCards.Visible = True
        resultZangdae.Visible = False
        resultError.Visible = False
    End Sub

    Private Sub tab4_Click(sender As Object, e As EventArgs) Handles tab4.Click


        BunifuSeparator1.Width = tab4.Width
        BunifuSeparator1.Left = tab4.Left


        resultBar.Visible = False
        resultZum.Visible = False
        resultCombineCards.Visible = False
        resultZangdae.Visible = True
        resultError.Visible = False
    End Sub

    Private Sub tab5_Click(sender As Object, e As EventArgs) Handles tab5.Click


        BunifuSeparator1.Width = tab5.Width
        BunifuSeparator1.Left = tab5.Left


        resultBar.Visible = False
        resultZum.Visible = False
        resultCombineCards.Visible = False
        resultZangdae.Visible = False
        resultError.Visible = True

    End Sub






End Class
