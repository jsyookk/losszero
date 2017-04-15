Public Class SettingCombine
    Dim setinfo As SettingInfo = SettingInfo.GetInstance()
    Private Sub SettingCombine_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        swScene.Value = setinfo.sameSceneIsOK
        swKongjung.Value = setinfo.sameKongjungIsOK
        swShape.Value = setinfo.sameShapeIsOK
        kireSW.Value = setinfo.remainIsOK

    End Sub

    Private Sub BunifuImageButton1_Click(sender As Object, e As EventArgs) Handles BunifuImageButton1.Click

        setinfo.remainIsOK = kireSW.Value
        setinfo.sameSceneIsOK = swScene.Value
        setinfo.sameKongjungIsOK = swKongjung.Value
        setinfo.sameShapeIsOK = swShape.Value

        Dim saveXml As ZSerialization = New ZXmlSerialization()
        saveXml.save(My.Application.Info.DirectoryPath & "\xml\setting.xml")

        Me.Hide()

    End Sub

    Private Sub swScene_OnValueChange(sender As Object, e As EventArgs) Handles swScene.OnValueChange

        If swScene.Value = True Then
            swKongjung.Value = False
            swKongjung.Refresh()
        End If

    End Sub

    Private Sub swKongjung_OnValueChange(sender As Object, e As EventArgs) Handles swKongjung.OnValueChange

        If swKongjung.Value = True Then
            swScene.Value = False
            swScene.Refresh()
        End If


    End Sub
End Class
