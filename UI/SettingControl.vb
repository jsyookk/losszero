Public Class SettingControl

    Dim setCom As New SettingCommon
    Dim setLoss As New SettingLoss
    Dim setmm As New SettingMM
    Dim setCombine As New SettingCombine
    Dim setPrice As New SettingBasePrice
    Dim setZum As New SettingZum

    Public Sub New()

        ' 디자이너에서 이 호출이 필요합니다.
        InitializeComponent()

        ' InitializeComponent() 호출 뒤에 초기화 코드를 추가하세요.
        Me.rightSidePanel.Controls.Add(setCom)
        Me.rightSidePanel.Controls.Add(setLoss)
        Me.rightSidePanel.Controls.Add(setmm)
        Me.rightSidePanel.Controls.Add(setCombine)
        Me.rightSidePanel.Controls.Add(setPrice)
        Me.rightSidePanel.Controls.Add(setZum)

        Dim panelsize As New Size(rightSidePanel.Width, rightSidePanel.Height)

        setCom.Visible = False
        setLoss.Visible = False
        setmm.Visible = False
        setCombine.Visible = False
        setPrice.Visible = False
        setZum.Visible = False

        setCom.Size = panelsize
        setLoss.Size = panelsize
        setmm.Size = panelsize
        setCombine.Size = panelsize
        setPrice.Size = panelsize
        rightSidePanel.Size = panelsize

    End Sub

    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton1.Click


        setCom.Visible = True
        setLoss.Visible = False
        setmm.Visible = False
        setCombine.Visible = False
        setPrice.Visible = False
        setZum.Visible = False
    End Sub

    Private Sub BunifuFlatButton2_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton2.Click
        setCom.Visible = False
        setLoss.Visible = True
        setmm.Visible = False
        setCombine.Visible = False
        setPrice.Visible = False
        setZum.Visible = False
    End Sub

    Private Sub BunifuFlatButton3_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton3.Click


        setCom.Visible = False
        setLoss.Visible = False
        setmm.Visible = True
        setCombine.Visible = False
        setPrice.Visible = False
        setZum.Visible = False
    End Sub

    Private Sub BunifuFlatButton4_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton4.Click

        setCom.Visible = False
        setLoss.Visible = False
        setmm.Visible = False
        setCombine.Visible = True
        setPrice.Visible = False
        setZum.Visible = False
    End Sub

    Private Sub BunifuFlatButton5_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton5.Click

        setCom.Visible = False
        setLoss.Visible = False
        setmm.Visible = False
        setCombine.Visible = False
        setPrice.Visible = True
        setZum.Visible = False
    End Sub

    Private Sub BunifuFlatButton6_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton6.Click

        setCom.Visible = False
        setLoss.Visible = False
        setmm.Visible = False
        setCombine.Visible = False
        setPrice.Visible = False
        setZum.Visible = True
    End Sub

End Class
