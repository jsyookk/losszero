Public Class HomeControl

    Private Sub LoadBTN_Click(sender As Object, e As EventArgs) Handles LoadBTN.Click

        Dim openfileDlg As New OpenFileDialog()

        openfileDlg.Filter = "DBF File(*.dbf*)|*.db*"
        openfileDlg.Multiselect = True
        openfileDlg.Title = "현장 파일을 선택해주세요."

        Dim dr As DialogResult = openfileDlg.ShowDialog()

        If dr = System.Windows.Forms.DialogResult.OK Then
            '초기화
            ' initTree()

            'excel 파일을 불러와 Load한다.
            Dim readble As Readable = New DbfRead(openfileDlg.FileNames)
            'Dim gen As Generator = New ExcelRead(OpenFileDialog1.filenames)
            readble.open()
            readble.close()

            Me.TreeView1.Nodes.Clear()

            Dim treeviewV As New TreeViewSimpleVisitor(Me.TreeView1)
            Place.GetInstance().search(treeviewV)

            Me.TreeView1.ExpandAll()

            makeGraph()

        End If


    End Sub

    Private Sub optimalBTN_Click(sender As Object, e As EventArgs) Handles optimalBTN.Click

        FrameWork.GetInstance().setStatus(FrameWork.STATUS.PROCESS_OPTIMAL)

    End Sub

    Private Sub clearGraph(p As Panel)

        For Each control As Control In p.Controls
            control.Dispose()
        Next

    End Sub
    Private Sub makeGraph()

        Dim nofilter As BaseFilter = New BaseNoFilter()
        Dim stelist As SteelList = SteelList.GetInstance()

        For i = 1 To stelist.count

            Dim ste As Steel = stelist.getItem(i)
            nofilter.filtering(ste)

        Next

        Dim hash400visitor As New HdmLoadTotalTonVisitor(400)
        Base.GetInstance().search(hash400visitor)
        Dim list400 As Hashtable = hash400visitor.getHashTb()

        Dim hash500visitor As New HdmLoadTotalTonVisitor(500)
        Base.GetInstance().search(hash500visitor)
        Dim list500 As Hashtable = hash500visitor.getHashTb()

        Dim hash600visitor As New HdmLoadTotalTonVisitor(600)
        Base.GetInstance().search(hash600visitor)
        Dim list600 As Hashtable = hash600visitor.getHashTb()

        clearGraph(gp400)
        clearGraph(gp500)
        clearGraph(gp600)

        gp400.Controls.Add(GraphFactory.CreateGraph(GraphFactory.X_AXIS_TYPE.HDM, GraphFactory.GRAPH_TYPE.PIE_G, list400, gp400.Size, "HD").getChart())
        gp500.Controls.Add(GraphFactory.CreateGraph(GraphFactory.X_AXIS_TYPE.HDM, GraphFactory.GRAPH_TYPE.PIE_G, list500, gp500.Size, "SHD").getChart())
        gp600.Controls.Add(GraphFactory.CreateGraph(GraphFactory.X_AXIS_TYPE.HDM, GraphFactory.GRAPH_TYPE.PIE_G, list600, gp600.Size, "UHD").getChart())

    End Sub

End Class
