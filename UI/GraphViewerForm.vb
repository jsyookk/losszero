Imports System.Windows.Forms.DataVisualization.Charting
Public Class GraphViewerForm

    Protected Const GRAPH_EACH_HEIGHT_SIZE = 350

    Dim rc As RCombine
    Dim chart As Chart

    Public Sub updateGraph(com As RCombine)

        Me.rc = com

        treeClear()
        makeNodes()
        makeGraph()

    End Sub

    Private Sub makeGraph()

        For Each con As Control In graphArea.Controls
            graphArea.Controls.Remove(con)
        Next

        Dim cnt As Integer = rc.getGraphDisplayCount()
        Dim size As New Size(graphArea.Width, GRAPH_EACH_HEIGHT_SIZE * cnt)
        '    graphArea.Height = (GRAPH_EACH_HEIGHT_SIZE * cnt)

        'If cnt > 25 Then
        '    size.Height = size.Height + (50 * cnt)
        'ElseIf cnt > 22 Then
        '    size.Height = size.Height + (40 * cnt)
        'ElseIf cnt > 17 Then
        '    size.Height = size.Height + (30 * cnt)
        'ElseIf cnt > 15 Then
        '    size.Height = size.Height + (20 * cnt)
        'End If

        chart = CombineGraph.GrpahFactory(rc, size).getChart()
        Me.AutoScroll = True
        graphArea.AutoScroll = True
        graphArea.Controls.Add(chart)


    End Sub

    Private Sub treeClear()

        If Me.TreeView1 IsNot Nothing Then

            Dim myTreeNodeCollection As TreeNodeCollection = Me.TreeView1.Nodes
            Dim myTreeNodeArray(Me.TreeView1.Nodes.Count - 1) As TreeNode
            Me.TreeView1.Nodes.CopyTo(myTreeNodeArray, 0)
            Me.TreeView1.Nodes.Clear()

        End If
    End Sub

    Private Function makeNodes() As TreeNode

        Dim rootNode As New TreeNode
        rootNode = CombineNodeFactory.NodeFactory(rc, rootNode)
        Me.TreeView1.Nodes.Add(rootNode)
        Me.TreeView1.ExpandAll()

        Return rootNode

    End Function

    Private Sub BunifuImageButton1_Click(sender As Object, e As EventArgs) Handles BunifuImageButton1.Click

        Me.Close()

    End Sub

    Private Sub TreeView1_NodeMouseDoubleClick(sender As Object, e As TreeNodeMouseClickEventArgs) Handles TreeView1.NodeMouseDoubleClick

        Dim name As String = e.Node.Name

        If e.Node.Name.Equals("STEEL") Then

            Dim dsteform As New SteelDetailForm(SteelList.GetInstance().getItem(CInt(e.Node.Tag)))
            dsteform.Show()
        End If

    End Sub

    Private Sub BunifuImageButton2_Click(sender As Object, e As EventArgs) Handles BunifuImageButton2.Click


        If chart Is Nothing Then
            MsgBox("출력할 그래프가 선택되지 않았습니다.")
        Else
            Dim print_ As Print = New PrintChart(chart)
            'Dim print As PrintDisplay = New PrintPanelBitmap(graphArea)
            print_.display()
        End If


    End Sub
End Class