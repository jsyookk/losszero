Imports Losszero

Public Class Main


    Private resultPublish As New ResultGenerator()

    Private login As New LoginControl
    Private home As New HomeControl
    Private setting As New SettingControl
    Private data As New InputDataControl
    Private result As New ResultMain(resultPublish)
    Public Sub New()

        ' 디자이너에서 이 호출이 필요합니다.
        InitializeComponent()

        ' InitializeComponent() 호출 뒤에 초기화 코드를 추가하세요.

        mainPanel.Controls.Add(home)
        mainPanel.Controls.Add(login)
        mainPanel.Controls.Add(setting)
        mainPanel.Controls.Add(result)
        mainPanel.Controls.Add(data)

        home.Visible = False
        setting.Visible = False
        login.Visible = True
        result.Visible = False
        data.Visible = False

        showProgress(False)

        Bunifu.Framework.License.Authenticate("anybodyjs@gmail.com", "e682d296c2392a63ddf17375474a12c5")


    End Sub
    Private Sub exitBTN_Click(sender As Object, e As EventArgs) Handles exitBTN.Click

        Application.Exit()

    End Sub

    Public Sub login_complete()

        nameLB.Text = User.GetInstance().UserName
        DateLB.Text = User.GetInstance().ExpirateionDate

    End Sub

    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton1.Click

        If FrameWork.GetInstance().isLoginComplete = True Then

            home.Visible = True
            setting.Visible = False
            result.Visible = False
            data.Visible = False
        End If

    End Sub

    Private Sub BunifuFlatButton2_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton2.Click

        If FrameWork.GetInstance().isLoginComplete = True Then

            setting.Visible = True
            home.Visible = False
            result.Visible = False
            data.Visible = False
        End If

    End Sub

    Private Sub BunifuFlatButton3_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton3.Click

        If FrameWork.GetInstance().isLoginComplete = True Then

            setting.Visible = False
            home.Visible = False
            result.Visible = True
            data.Visible = False
        End If


    End Sub
    Public Sub showProgress(value As Boolean)


        If value Then
            BunifuCircleProgressbar1.Visible = True
        Else
            BunifuCircleProgressbar1.Visible = False
        End If


    End Sub

    Private Sub form_load(sender As Object, e As EventArgs) Handles MyBase.Load

        FrameWork.GetInstance().registerMessageControl(Me.mainStatusLB)
        'FrameWork.GetInstance().setStatus(FrameWork.STATUS.LOGIN_ONLINE)
        FrameWork.GetInstance().setStatus(FrameWork.STATUS.LOGIN_OFFLINE)
        FrameWork.GetInstance().registerResultPublish(resultPublish)


    End Sub

    Private Sub menuChangeBTN_Click(sender As Object, e As EventArgs) Handles menuChangeBTN.Click


        'expand
        If sidePanel.Width = 50 Then

            sidePanel.Visible = False
            sidePanel.Width = 260
            menuAni.ShowSync(sidePanel)
            userAni.ShowSync(userPanel)
            'mini
        Else
            userAni.Hide(userPanel)
            sidePanel.Visible = False
            sidePanel.Width = 50
            menuAni.ShowSync(sidePanel)

        End If

    End Sub

    Private Sub BunifuFlatButton4_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton4.Click


        If FrameWork.GetInstance().isLoginComplete = True Then

            setting.Visible = False
            home.Visible = False
            result.Visible = False
            data.Visible = True
        End If

    End Sub
End Class