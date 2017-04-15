﻿Public Class SettingLoss
    Dim setinfo As SettingInfo = SettingInfo.GetInstance()

    Private Sub SettingLoss_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        cutlossTB.Text = CStr(setinfo.barLoosPermit * 100)
        combinelossTB.Text = CStr(setinfo.CbLossPermit * 100)
        chkLossTon.Checked = setinfo.LossAsTon

    End Sub

    Private Sub BunifuImageButton1_Click(sender As Object, e As EventArgs) Handles BunifuImageButton1.Click

        setinfo.barLoosPermit = CDbl(cutlossTB.Text) / 100
        setinfo.CbLossPermit = CDbl(combinelossTB.Text) / 100
        setinfo.LossAsTon = chkLossTon.Checked

        Dim saveXml As ZSerialization = New ZXmlSerialization()
        saveXml.save(My.Application.Info.DirectoryPath & "\xml\setting.xml")

        Me.Hide()

    End Sub



End Class
