Public Class SettingCommon
    Dim setinfo As SettingInfo = SettingInfo.GetInstance()
    Private Sub BunifuImageButton1_Click(sender As Object, e As EventArgs) Handles BunifuImageButton1.Click

        setinfo.StockOnly = swStock.Value
        setinfo.coilexcept = swCoil.Value
        setinfo.allowErrorLen = CInt(tbError.Text)

        Dim saveXml As ZSerialization = New ZXmlSerialization()
        saveXml.save(My.Application.Info.DirectoryPath & "\xml\setting.xml")

        Me.Hide()

    End Sub

    Private Sub SettingCommon_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        swStock.Value = setinfo.StockOnly
        swCoil.Value = setinfo.coilexcept
        tbError.Text = CStr(setinfo.allowErrorLen)


    End Sub


End Class
