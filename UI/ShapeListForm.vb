Public Class ShapeListForm
    Dim shplist As ShapeList = ShapeList.GetInstance()
    Dim curIdx As Integer = 0
    Private Sub ShapeListForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim imglist As ImageList = ShapeList.GetInstance().getShapeImgs()

        Dim i As Integer = 1

        For i = 1 To shplist.count
            Dim shp As Shape = shplist.getItem(i)
            Dim item As New ListViewItem(shp.shapeNUM)
            shapelistview.Items.Add(item)
            shapelistview.Items(i - 1).ImageIndex = i - 1

        Next

        shapelistview.LargeImageList = imglist
        shapelistview.View = View.LargeIcon

    End Sub

    Private Sub shapelistview_SelectedIndexChanged(sender As Object, e As EventArgs) Handles shapelistview.SelectedIndexChanged

        Dim idx As Integer
        Dim shp As Shape

        If shapelistview.SelectedItems.Count > 0 Then

            idx = shapelistview.SelectedItems(0).Index
            shp = shplist.getItem(idx + 1)

            curIdx = idx + 1

            tbShapeNum.Text = CStr(shp.shapeNUM)
            tbCurveCNT.Text = CStr(shp.curveCNT)
            tbCorret.Text = CStr(shp.correct)
            ' sumnail.BackgroundImage = Image.FromFile(My.Application.Info.DirectoryPath & "\shape\" & shp.fileName)
            sumnail.BackgroundImage = shplist.getShapeImg(shp.shapeNUM)
        End If
    End Sub

    Private Sub BunifuImageButton1_Click(sender As Object, e As EventArgs) Handles BunifuImageButton1.Click

        Dim zxmlShape As ZXml = New ZXmlShape()
        zxmlShape.write(My.Application.Info.DirectoryPath & "\shape\shapeList.xml")

        Me.Close()

    End Sub



    Private Sub BunifuThinButton21_Click(sender As Object, e As EventArgs) Handles BunifuThinButton21.Click

        If tbCurveCNT.Text = "" Or tbCorret.Text = "" Then
            MessageBox.Show("값이 비어있습니다.")
        Else
            shplist.edit(curIdx, CInt(tbCurveCNT.Text), CInt(tbCorret.Text))
            MessageBox.Show("수정 되었습니다.")
        End If



    End Sub

    Private Sub frm_closeing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        Me.Hide()
        e.Cancel = True

    End Sub
End Class