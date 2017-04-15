Public Class SettingZum
    Dim setinfo As SettingInfo = SettingInfo.GetInstance()
    Private btns As New Dictionary(Of Integer, Control)
    Private selectIdx As Integer
    Private Sub SettingZum_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        reload_lens()

        BunifuSlider1.Value = CInt(setinfo.zumTON * 10)
        tonLB.Text = CStr(setinfo.zumTON)

        FlowLayoutPanel1.AutoScroll = True

    End Sub
    Private Sub reload_lens()

        btns.Clear()
        FlowLayoutPanel1.Controls.Clear()


        For Each len As Integer In setinfo.ZumLengths

            Dim btn As New Bunifu.Framework.UI.BunifuThinButton2()
            btn.Width = FlowLayoutPanel1.Width - 50
            btn.Height = 35
            btn.Tag = len
            btn.ActiveFillColor = Color.White
            btn.ActiveForecolor = Color.Black
            btn.ActiveLineColor = Color.White
            btn.IdleFillColor = Color.White
            btn.IdleLineColor = Color.White
            btn.IdleForecolor = Color.Gray

            btn.ButtonText = CStr(len)

            AddHandler btn.Click, AddressOf btns_click
            btns.Add(len, btn)
            FlowLayoutPanel1.Controls.Add(btn)

        Next

    End Sub
    Private Sub btns_click(sender As Object, e As EventArgs)

        Dim btn As Bunifu.Framework.UI.BunifuThinButton2 = DirectCast(sender, Bunifu.Framework.UI.BunifuThinButton2)
        displayControl(btn.Tag)

    End Sub

    Public Sub displayControl(idx As Integer)
        Dim pair As KeyValuePair(Of Integer, Control)

        For Each pair In btns
            Dim uc As Bunifu.Framework.UI.BunifuThinButton2

            If pair.Key = idx Then
                uc = DirectCast(btns.Item(idx), Bunifu.Framework.UI.BunifuThinButton2)
                uc.ForeColor = Color.Black
                uc.IdleForecolor = Color.Black
                selectIdx = idx

            Else
                uc = DirectCast(btns.Item(pair.Key), Bunifu.Framework.UI.BunifuThinButton2)
                uc.ForeColor = Color.WhiteSmoke
                uc.IdleForecolor = Color.Gray

            End If
        Next

    End Sub

    Private Sub BunifuThinButton21_Click(sender As Object, e As EventArgs) Handles BunifuThinButton21.Click

        If setinfo.ZumLengths.Contains(CInt(lenTB.Text)) = True Then
            MessageBox.Show("같은 길이가 이미 있습니다.")
        Else
            setinfo.ZumLengths.Add(CInt(lenTB.Text))
            reload_lens()
        End If



    End Sub

    Private Sub BunifuThinButton22_Click(sender As Object, e As EventArgs) Handles BunifuThinButton22.Click

        setinfo.ZumLengths.Remove(selectIdx)
        reload_lens()

    End Sub

    Private Sub BunifuSlider1_ValueChanged(sender As Object, e As EventArgs) Handles BunifuSlider1.ValueChanged

        tonLB.Text = CStr(BunifuSlider1.Value / 10)

    End Sub

    Private Sub BunifuImageButton1_Click(sender As Object, e As EventArgs)

        setinfo.zumTON = CDbl(tonLB.Text)


        Dim saveXml As ZSerialization = New ZXmlSerialization()
        saveXml.save(My.Application.Info.DirectoryPath & "\xml\setting.xml")

        Me.Hide()

    End Sub

    Private Sub lenTB_MouseClick(sender As Object, e As MouseEventArgs) Handles lenTB.MouseClick

        Me.lenTB.Text = ""

    End Sub


    Private Sub BunifuImageButton1_Click_1(sender As Object, e As EventArgs) Handles BunifuImageButton1.Click

        setinfo.zumTON = CDbl(tonLB.Text)


        Dim saveXml As ZSerialization = New ZXmlSerialization()
        saveXml.save(My.Application.Info.DirectoryPath & "\xml\setting.xml")

        Me.Hide()
    End Sub
End Class
