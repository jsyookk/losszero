
Public Class TreeViewSimpleVisitor : Inherits PVisitor

    Dim treeview As TreeView
    Dim rootNode As New TreeNode
    Dim sceneNode As TreeNode
    Dim kongjungNode As TreeNode
    Public Sub New(ByRef tree As TreeView)

        treeview = tree
        rootNode.Text = "현장 리스트"
        treeview.Nodes.Add(rootNode)

    End Sub
    Public Overrides Sub visit(p As Part)

        If p.getParentIDX = kongjungNode.Tag Then

            Dim partNode As New TreeNode()

            partNode.Text = p.getName + "[" & p.getTon & "]"
            partNode.Tag = p.getUniqueIDX

            kongjungNode.Nodes.Add(partNode)

        End If


    End Sub

    Public Overrides Sub visit(k As Kongjung)

        If k.getParentIDX = sceneNode.Tag Then

            kongjungNode = New TreeNode()
            kongjungNode.Tag = k.getUniqueIDX
            kongjungNode.Name = "kongjung"
            'kongjungNode.Text = k.getName + "[" & k.getTon & "]"
            kongjungNode.Text = k.getName
            sceneNode.Nodes.Add(kongjungNode)

            For Each entry As PEntry In k.getList()
                entry.accept(Me)
            Next

        End If

    End Sub

    Public Overrides Sub visit(s As Scene)

        sceneNode = New TreeNode()

        'sceneNode.Text = s.getName + "[" & s.getTon & "]"
        sceneNode.Text = s.getName
        sceneNode.Tag = s.getUniqueIDX
        rootNode.Nodes.Add(sceneNode)

        For Each entry As PEntry In s.getList()
            entry.accept(Me)
        Next


    End Sub

    Public Function getTree() As TreeView

        Return treeview

    End Function


End Class
