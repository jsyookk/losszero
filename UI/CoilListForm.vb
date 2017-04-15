Public Class CoilListForm
    Dim coilshpList As CoilShapeList = CoilShapeList.GetInstance()
    Dim shpIdx As Integer
    Private Sub BunifuImageButton1_Click(sender As Object, e As EventArgs) Handles BunifuImageButton1.Click

        Dim zxmlcoil As ZXml = New ZXmlCoilShpae()
        zxmlcoil.write(My.Application.Info.DirectoryPath & "\xml\coilshapeList.xml")

        Me.Close()


    End Sub
    Public Sub reload()

        coilShpListview.Clear()

        oneSideLenTB.Text = ""


        Dim imglist As New ImageList()
        imglist.ImageSize = New Size(220, 70)

        Dim i As Integer = 1

        For i = 1 To coilshpList.count
            Dim coil As CoilShape = coilshpList.getItem(i)
            Dim item As New ListViewItem(coil.shapeNUM)
            Dim img As Image = ShapeList.GetInstance().getShapeImg(coil.shapeNUM)

            imglist.Images.Add(img)
            coilShpListview.Items.Add(item)
            coilShpListview.Items(i - 1).Tag = i
            coilShpListview.Items(i - 1).ImageIndex = i - 1
        Next

        coilShpListview.LargeImageList = imglist
        coilShpListview.View = View.LargeIcon

    End Sub
    Private Sub CoilListForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        reload()

    End Sub

    Private Sub coilShpListview_SelectedIndexChanged(sender As Object, e As EventArgs) Handles coilShpListview.SelectedIndexChanged

        Dim index As Integer
        Dim shp As CoilShape

        If coilShpListview.SelectedItems.Count > 0 Then

            index = coilShpListview.SelectedItems(0).Index
            shp = coilshpList.getItem(index + 1)
            shpIdx = coilShpListview.SelectedItems(0).Tag


            oneSideLenTB.Text = shp.OneLEN
            PictureBox1.BackgroundImage = ShapeList.GetInstance().getShapeImg(shp.shapeNUM)


        End If

    End Sub

    Private Sub editBTN_Click(sender As Object, e As EventArgs) Handles editBTN.Click

        If oneSideLenTB.Text = "" Then
            MessageBox.Show("선택된 형상이 없습니다.")
        Else

            If allChkBox.Checked = True Then
                coilshpList.editAllLen(CInt(oneSideLenTB.Text))
            Else
                Dim len As Integer = CInt(oneSideLenTB.Text)
                coilshpList.edit(shpIdx, len)
            End If
            reload()
        End If


    End Sub

    Private Sub delBTN_Click(sender As Object, e As EventArgs) Handles delBTN.Click

        If shpIdx = 0 Then
            MessageBox.Show("삭제할 형상을 선택해주세요.")
        Else
            coilshpList.remove(shpIdx)
            reload()
        End If



    End Sub

    Private Sub addBTN_Click(sender As Object, e As EventArgs) Handles addBTN.Click

        Dim coilAdd As CoilAddForm = New CoilAddForm()
        coilAdd.ShowDialog()

    End Sub

    Private Sub frm_closeing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        Me.Hide()
        e.Cancel = True

    End Sub

End Class