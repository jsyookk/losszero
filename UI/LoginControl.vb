Public Class LoginControl


    Private Sub LogInBTN_Click(sender As Object, e As EventArgs) Handles LogInBTN.Click

        Dim login As ServerLogin = New ServerLogin()

        If login.open(idTB.text, pwTB.text) = True Then
            If login.check() = True Then
                FrameWork.GetInstance().setStatus(FrameWork.STATUS.LOGIN_ONLINE)
                login.close()
                Me.Visible = False
            End If
        Else
            MsgBox("접속 오류 입니다.네트워크 상태를 확인해주세요.")
        End If

    End Sub

    Private Sub idTB_Click(sender As Object, e As EventArgs) Handles idTB.Click

        idTB.Text = ""

    End Sub

    Private Sub pwTB_Click(sender As Object, e As EventArgs) Handles pwTB.Click

        pwTB.Text = ""
        pwTB.PasswordChar = "*"

    End Sub

    Private Sub pwTB_KeyDown(sender As Object, e As KeyEventArgs) Handles pwTB.KeyDown

        pwTB.PasswordChar = "*"

    End Sub
End Class
