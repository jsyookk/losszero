Public Class SteelDetailForm

    Public Sub New(ste As Steel)

        ' 디자이너에서 이 호출이 필요합니다.
        InitializeComponent()

        ' InitializeComponent() 호출 뒤에 초기화 코드를 추가하세요.
        sceneLB.Text = Place.GetInstance().getMyName(ste.sceneIDX)
        placeLB.Text = Place.GetInstance().getMyName(ste.kongjungIDX)
        partLB.Text = Place.GetInstance().getMyName(ste.partIDX)

        lenLB.Text = CStr(ste.Length)
        rlenLB.Text = CStr(ste.RealLength)
        etcLB.Text = CStr(ste.ETC)

        PictureBox1.Image = ShapeList.GetInstance().getShapeImg(ste.ShapeNUM)

        Dim mm As Integer

        Select Case ste.HDM
            Case 400 To 499
                mm = ste.HDM Mod 400
                hdmLB.Text = "HD" & mm
                sdLB.Text = "SD" & 400
            Case 500 To 599
                mm = ste.HDM Mod 500
                hdmLB.Text = "SHD" & mm
                sdLB.Text = "SD" & 500
            Case 600 To 699
                mm = ste.HDM Mod 600
                hdmLB.Text = "UHD" & mm
                sdLB.Text = "SD" & 600
        End Select

        kgLB.Text = CStr(ste.Ton * 1000)
        qtyLB.Text = CStr(ste.Qty)

        Dim lvItem As New ListViewItem

        lvItem.Text = ste.A
        lvItem.SubItems.Add(ste.B)
        lvItem.SubItems.Add(ste.C)
        lvItem.SubItems.Add(ste.D)
        lvItem.SubItems.Add(ste.E)
        lvItem.SubItems.Add(ste.F)
        lvItem.SubItems.Add(ste.G)
        lvItem.SubItems.Add(ste.R1)
        lvItem.SubItems.Add(ste.R2)
        lvItem.SubItems.Add(ste.R3)

        ListView1.Items.Add(lvItem)

    End Sub

    Private Sub BunifuImageButton1_Click(sender As Object, e As EventArgs) Handles BunifuImageButton1.Click

        Me.Close()

    End Sub
End Class