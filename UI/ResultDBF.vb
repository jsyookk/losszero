Imports Losszero
Imports Bunifu.Framework.UI

Public Class ResultDBF
    Implements Observer

    Public Sub New(publisher As Publisher)
        InitializeComponent()
        publisher.add(Me)

        FlowLayoutPanel1.AutoScroll = True


    End Sub
    Public Sub New()

        ' 디자이너에서 이 호출이 필요합니다.
        InitializeComponent()
        FlowLayoutPanel1.AutoScroll = True
        ' InitializeComponent() 호출 뒤에 초기화 코드를 추가하세요.

    End Sub
    Private Sub clearPanel()

        FlowLayoutPanel1.Controls.Clear()

        'For Each control As Control In FlowLayoutPanel1.Controls

        '    FlowLayoutPanel1.Controls.Remove(control)
        '    control.Dispose()

        'Next




    End Sub
    Public Sub ob(gen As Observer.Observer_Type) Implements Observer.ob

        ' clearPanel()

    End Sub

    Private Sub BunifuImageButton1_Click(sender As Object, e As EventArgs) Handles BunifuImageButton1.Click
        ResultMain.displayControl(ResultMain.PAGE_NUMBER.COMMON_PAGE)

    End Sub

    Private Sub sceneBTN_Click(sender As Object, e As EventArgs) Handles sceneBTN.Click

        clearPanel()

        Dim kjlst As ArrayList
        Dim visitor As New SceneIdxListVisitor()
        Place.GetInstance().search(visitor)

        kjlst = visitor.getKongjungIdxsList()

        For Each idx As Integer In kjlst

            Dim name As String = Place.GetInstance().getMyName(idx)
            Dim btn As New Button()

            btn.Width = FlowLayoutPanel1.Width - 250
            btn.Height = 80

            btn.Text = name
            btn.Tag = idx

            AddHandler btn.Click, AddressOf Me.SceneExport

            FlowLayoutPanel1.Controls.Add(btn)
        Next

    End Sub

    Private Sub kongjungBTN_Click(sender As Object, e As EventArgs) Handles kongjungBTN.Click

        clearPanel()

        Dim kjlst As ArrayList
        Dim visitor As New KongjungIdxListVisitor()
        Place.GetInstance().search(visitor)

        kjlst = visitor.getKongjungIdxsList()

        For Each idx As Integer In kjlst

            Dim name As String = Place.GetInstance().getMyName(idx)
            Dim btn As New Button()

            btn.Width = FlowLayoutPanel1.Width - 250
            btn.Height = 80

            btn.Text = name
            btn.Tag = idx

            AddHandler btn.Click, AddressOf Me.kongjungExport

            FlowLayoutPanel1.Controls.Add(btn)
        Next

    End Sub

    Private Sub kongjungExport(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Dim btn As Button = DirectCast(sender, Button)
        Dim tagIdx As Integer = CInt(btn.Tag)



        Dim saveDlg As New SaveFileDialog()
        saveDlg.Filter = "dbf File|*.dbf"
        saveDlg.Title = "Save an dbf File."
        saveDlg.FileName = Place.GetInstance().getMyName(tagIdx) & "(최적화)"

        Dim dr As DialogResult = saveDlg.ShowDialog()

        If dr = System.Windows.Forms.DialogResult.OK Then
            Dim path As String = saveDlg.FileName

            If My.Computer.FileSystem.FileExists(path) Then
                Try
                    My.Computer.FileSystem.DeleteFile(path)
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
                'MessageBox.Show("동일한 파일이 이미 있습니다.파일명을 변경해 주세요")

            End If

            Dim kongjungvisitor As New KongjungDataVisitor(tagIdx)
            Base.GetInstance().search(kongjungvisitor)

            Dim kongjunglst As ArrayList = kongjungvisitor.getList()
            kongjunglst.Sort(New SteelSortByNumber())

            Dim dbfwr As New DbfWrite()

            dbfwr.open(path)
            dbfwr.write(kongjunglst)
            dbfwr.close()
            FrameWork.GetInstance().setStatus(FrameWork.STATUS.EXPORT_DBF_COMPLETE)

        End If

    End Sub
    Private Sub SceneExport(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Dim btn As Button = DirectCast(sender, Button)
        Dim tagIdx As Integer = CInt(btn.Tag)

        Dim saveDlg As New SaveFileDialog()
        saveDlg.Filter = "dbf File|*.dbf"
        saveDlg.Title = "Save an dbf File."
        saveDlg.FileName = Place.GetInstance().getMyName(tagIdx) & "(최적화)"

        Dim dr As DialogResult = saveDlg.ShowDialog()

        If dr = System.Windows.Forms.DialogResult.OK Then
            Dim path As String = saveDlg.FileName

            If My.Computer.FileSystem.FileExists(path) Then
                Try
                    My.Computer.FileSystem.DeleteFile(path)
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
                'MessageBox.Show("동일한 파일이 이미 있습니다.파일명을 변경해 주세요")



            End If

            Dim dbfwr As New DbfWrite()
            dbfwr.open(path)

            Dim visitor As New SceneToKongjungIdxVisitor(tagIdx)
            Place.GetInstance().search(visitor)
            Dim koungjungIdxArr As ArrayList = visitor.getKongjungIdxsList()

            For Each kidx As Integer In koungjungIdxArr
                Dim kvisitor As New KongjungDataVisitor(kidx)
                Base.GetInstance().search(kvisitor)

                Dim arr As ArrayList = kvisitor.getList()
                arr.Sort(New SteelSortByNumber())
                dbfwr.write(arr)

            Next

            dbfwr.close()
            FrameWork.GetInstance().setStatus(FrameWork.STATUS.EXPORT_DBF_COMPLETE)

        End If


    End Sub

End Class
