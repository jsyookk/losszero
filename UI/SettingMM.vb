Public Class SettingMM
    Dim setinfo As SettingInfo = SettingInfo.GetInstance()
    Private Sub BunifuImageButton1_Click(sender As Object, e As EventArgs) Handles BunifuImageButton1.Click

        setinfo.Use10mm = sw10mm.Value
        setinfo.Use13mm = sw13mm.Value
        setinfo.Use16mm = sw16mm.Value
        setinfo.Use19mm = sw19mm.Value
        setinfo.Use22mm = sw22mm.Value
        setinfo.Use25mm = sw25mm.Value
        setinfo.Use29mm = sw29mm.Value
        setinfo.Use32mm = sw32mm.Value
        setinfo.baseTON = CDbl(ton.Text)

        Dim saveXml As ZSerialization = New ZXmlSerialization()
        saveXml.save(My.Application.Info.DirectoryPath & "\xml\setting.xml")

        Me.Hide()

    End Sub

    Private Sub SettingMM_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        sw10mm.Value = setinfo.Use10mm
        sw13mm.Value = setinfo.Use13mm
        sw16mm.Value = setinfo.Use16mm
        sw19mm.Value = setinfo.Use19mm
        sw22mm.Value = setinfo.Use22mm
        sw25mm.Value = setinfo.Use25mm
        sw29mm.Value = setinfo.Use29mm
        sw32mm.Value = setinfo.Use32mm

        BunifuSlider1.Value = CInt(setinfo.baseTON * 10)
        ton.Text = CStr(setinfo.baseTON)

    End Sub

    Private Sub BunifuSlider1_ValueChanged(sender As Object, e As EventArgs) Handles BunifuSlider1.ValueChanged

        ton.Text = CStr(BunifuSlider1.Value / 10)

    End Sub


End Class
