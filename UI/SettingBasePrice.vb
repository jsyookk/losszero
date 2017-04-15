Public Class SettingBasePrice

    Private Sub BunifuTrackbar1_ValueChanged(sender As Object, e As EventArgs) Handles BunifuTrackbar1.ValueChanged

        baseloss.Text = CStr(BunifuTrackbar1.Value / 10)

    End Sub

    Private Sub SettingBasePrice_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        baseloss.Text = CStr(SettingInfo.GetInstance().baseLoss)
        basePriceTB.Text = CStr(SettingInfo.GetInstance().basePrice)
        BunifuTrackbar1.Value = CInt(SettingInfo.GetInstance().baseLoss * 10)
        jangdaeCB.Checked = SettingInfo.GetInstance().zangDaeExcept

    End Sub

    Private Sub BunifuImageButton1_Click(sender As Object, e As EventArgs) Handles BunifuImageButton1.Click

        SettingInfo.GetInstance().baseLoss = CDbl(baseloss.Text)
        SettingInfo.GetInstance().basePrice = CLng(basePriceTB.Text)
        SettingInfo.GetInstance().zangDaeExcept = jangdaeCB.Checked
        BasePrice.GetInstance().inputBasePrice(CLng(basePriceTB.Text))

        Dim saveXml As ZSerialization = New ZXmlSerialization()
        saveXml.save(My.Application.Info.DirectoryPath & "\xml\setting.xml")

        Me.Hide()

    End Sub


End Class
