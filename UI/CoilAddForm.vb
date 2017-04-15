Public Class CoilAddForm
    Dim shplist As ShapeList = ShapeList.GetInstance()
    Dim filename As String
    Dim shpapeNum As Integer
    Dim oneSideLen As Integer




    Private Sub BunifuImageButton1_Click(sender As Object, e As EventArgs) Handles BunifuImageButton1.Click
        Me.Hide()

    End Sub

    Private Sub CoilAddForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim imglist As ImageList = shplist.getShapeImgs()

        ListView1.LargeImageList = imglist
        ListView1.View = View.LargeIcon

        Dim i As Integer

        For i = 1 To shplist.count
            Dim shp As Shape = shplist.getItem(i)
            Dim item As New ListViewItem(shp.shapeNUM)

            ListView1.Items.Add(item)
            ListView1.Items(i - 1).ImageIndex = i - 1


        Next



    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged

        Dim index As Integer
        Dim shp As Shape

        If ListView1.SelectedItems.Count > 0 Then

            index = ListView1.SelectedItems(0).Index
            shp = shplist.getItem(index + 1)

            PictureBox1.BackgroundImage = shplist.getShapeImg(shp.shapeNUM)

            shpapeNum = shp.shapeNUM
            filename = shp.fileName

        End If


    End Sub

    Private Sub addBTN_Click(sender As Object, e As EventArgs) Handles addBTN.Click

        If onesideLENTB.Text = "" Then
            MessageBox.Show("길이를 입력해 주세요.")
        Else
            oneSideLen = CInt(onesideLENTB.Text)

            Dim coil As New CoilShape()

            coil.fileName = filename
            coil.shapeNUM = shpapeNum
            coil.OneLEN = oneSideLen

            If CoilShapeList.GetInstance().check(coil.shapeNUM) Then
                MessageBox.Show("이미 같은 형상이 있습니다.")
            Else
                CoilShapeList.GetInstance().Add(coil)
                MessageBox.Show("코일 형상으로 추가되었습니다.")
                InputDataControl.frmCoil.reload()
            End If

        End If




    End Sub
End Class