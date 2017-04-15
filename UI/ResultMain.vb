Imports Losszero

Public Class ResultMain

    Enum PAGE_NUMBER
        COMMON_PAGE = 101
        MONEY_PAGE = 102
        NOMATCH_PAGE = 103
        RESULT_PAGE = 104
        DBF_PAGE = 105
        STOCK_PAGE = 106

    End Enum


    Private publisher As Publisher
    Private Shared pages As New Dictionary(Of Integer, UserControl)

    Public Sub New(publisher As Publisher)

        ' 디자이너에서 이 호출이 필요합니다.

        InitializeComponent()

        Dim rcom As New ResultControl(publisher)
        Dim rnomatch As New ResultNomatch(publisher)
        Dim rmoney As New ResultMoney()
        Dim rmatch As New ResultMatch(publisher)
        Dim rdbf As New ResultDBF()
        Dim rstock As New ResultStock(publisher)

        pages.Add(PAGE_NUMBER.COMMON_PAGE, rcom)
        pages.Add(PAGE_NUMBER.MONEY_PAGE, rmoney)
        pages.Add(PAGE_NUMBER.NOMATCH_PAGE, rnomatch)
        pages.Add(PAGE_NUMBER.RESULT_PAGE, rmatch)
        pages.Add(PAGE_NUMBER.DBF_PAGE, rdbf)
        pages.Add(PAGE_NUMBER.STOCK_PAGE, rstock)

        mainPanel.Controls.Add(rcom)
        mainPanel.Controls.Add(rnomatch)
        mainPanel.Controls.Add(rmoney)
        mainPanel.Controls.Add(rmatch)
        mainPanel.Controls.Add(rdbf)
        mainPanel.Controls.Add(rstock)

        displayControl(PAGE_NUMBER.COMMON_PAGE)

        ' InitializeComponent() 호출 뒤에 초기화 코드를 추가하세요.

    End Sub

    Public Shared Sub displayControl(idx As Integer)
        Dim pair As KeyValuePair(Of Integer, UserControl)

        For Each pair In pages
            Dim uc As UserControl

            If pair.Key = idx Then

                uc = pages.Item(idx)
                uc.Dock = DockStyle.Fill
                uc.Enabled = True
                uc.Visible = True
                uc.BringToFront()

            Else
                uc = pages.Item(pair.Key)
                uc.Dock = DockStyle.None
                uc.Enabled = False
                uc.Visible = False
            End If
        Next

    End Sub


End Class
