Public MustInherit Class CombineNodeFactory

    Public MustOverride Function getNode() As TreeNode

    Public Shared Function NodeFactory(rc_ As RCombine, node_ As TreeNode) As TreeNode

        Select Case rc_.COMBINE_TYPE
            Case RCombine.CBType.PERPECT
                Return New PerfactTypeNode(rc_, node_).getNode()
            Case RCombine.CBType.LINKED
                Return New LinkedTypeNode(rc_, node_).getNode()
            Case RCombine.CBType.REMAIN_CUT
                Return New RemainTypeNode(rc_, node_).getNode()
        End Select

        Return Nothing

    End Function

    Public Class RemainTypeNode : Inherits CombineNodeFactory
        Private node As TreeNode

        Public Sub New(rc_ As RCombine, node_ As TreeNode)

            Dim rootStr As String = rc_.hdmStr & " * " & rc_.UseMeter & "M" & " * " & rc_.Qty & "EA" & "(" & rc_.needTon & "t)"
            node_.Text = rootStr

            For Each element As RCombineElement In rc_.getList()

                If element.GetType().FullName = "Losszero.RCombineSte" Then
                    Dim rcste As RCombineSte = CType(element, RCombineSte)
                    Dim childNode As New TreeNode
                    Dim childNodeStr As String = rcste.mUninqueIDX & "(" & rcste.mQty & "EA) " & rcste.mplace
                    childNode.Text = childNodeStr
                    childNode.Name = "STEEL"
                    childNode.Tag = rcste.msteIDX
                    childNode.ImageIndex = 1
                    node_.Nodes.Add(childNode)

                ElseIf element.GetType().FullName = "Losszero.RCombineRemain" Then
                    Dim rcr As RCombineRemain = CType(element, RCombineRemain)
                    Dim childNode1 As New TreeNode
                    Dim childNodeStr1 As String = rcr.mLen & "*" & rcr.mQty & "EA"
                    childNode1.ImageIndex = 4
                    childNode1.Text = childNodeStr1

                    For Each childelement As RCombineElement In rcr.getList

                        If childelement.GetType().FullName = "Losszero.RCombineSte" Then

                            Dim rcste As RCombineSte = CType(childelement, RCombineSte)
                            Dim childNode2 As New TreeNode
                            Dim childNode2Str As String = rcste.mUninqueIDX & "(" & Math.Ceiling(rcste.mQty / rcste.mcut) & "EA) " & rcste.mplace
                            childNode2.Text = childNode2Str
                            childNode2.Name = "STEEL"
                            childNode2.Tag = rcste.msteIDX
                            childNode2.ImageIndex = 1
                            childNode1.Nodes.Add(childNode2)

                        ElseIf childelement.GetType().FullName = "Losszero.RCombineRemain" Then
                            Dim rcrr As RCombineRemain = CType(childelement, RCombineRemain)
                            Dim childNode2 As New TreeNode
                            Dim childNodeStr2 As String = "(짜투리)" & rcrr.mLen & "-" & rcrr.mQty & "EA"
                            childNode2.ImageIndex = 3
                            childNode2.Text = childNodeStr2
                            childNode1.Nodes.Add(childNode2)
                        End If

                    Next

                    node_.Nodes.Add(childNode1)

                End If

            Next


            node = node_


        End Sub
        Public Overrides Function getNode() As TreeNode

            Return node

        End Function

    End Class

    Public Class LinkedTypeNode : Inherits CombineNodeFactory
        Private node As TreeNode

        Public Sub New(rc_ As RCombine, node_ As TreeNode)

            Dim rootStr As String = rc_.hdmStr & " * " & rc_.UseMeter & "M" & " * " & rc_.Qty & "EA" & "(" & rc_.needTon & "t)"
            node_.Text = rootStr

            For Each element As RCombineElement In rc_.getList()

                If element.GetType().FullName = "Losszero.RCombineLink" Then

                    Dim rlink As RCombineLink = CType(element, RCombineLink)

                    Dim childNode As New TreeNode
                    childNode.Text = rlink.getQTY & "EA" & " * " & rlink.getLossD & "%"
                    childNode.ImageIndex = 2

                    For Each childelement As RCombineElement In rlink.getList

                        If childelement.GetType().FullName = "Losszero.RCombineSte" Then

                            Dim rcste As RCombineSte = CType(childelement, RCombineSte)
                            Dim childNode2 As New TreeNode
                            Dim childNode2Str As String = rcste.mUninqueIDX & " " & rcste.mplace & " -" & rcste.mQty & "EA"

                            childNode2.Text = childNode2Str
                            childNode2.Name = "STEEL"
                            childNode2.Tag = rcste.msteIDX
                            childNode2.ImageIndex = 1

                            childNode.Nodes.Add(childNode2)

                        End If
                    Next

                    node_.Nodes.Add(childNode)

                ElseIf element.GetType().FullName = "Losszero.RCombineRemainSteel" Then

                    Dim rcr As RCombineRemainSteel = CType(element, RCombineRemainSteel)
                    Dim childNode1 As New TreeNode
                    Dim childNodeStr1 As String = "(R)(" & rcr.mLen & ")" & "(" & rcr.mQty & "EA) " & rcr.mplace
                    childNode1.ImageIndex = 3
                    childNode1.Text = childNodeStr1
                    node_.Nodes.Add(childNode1)
                End If

            Next

            node = node_


        End Sub
        Public Overrides Function getNode() As TreeNode




            Return node

        End Function

    End Class

    Public Class PerfactTypeNode : Inherits CombineNodeFactory
        Private node As TreeNode

        Public Sub New(rc_ As RCombine, node_ As TreeNode)

            Dim rootStr As String = rc_.hdmStr & " * " & rc_.UseMeter & "M" & " * " & rc_.Qty & "EA" & "(" & rc_.needTon & "t)"
            node_.Text = rootStr

            For Each element As RCombineElement In rc_.getList()

                If element.GetType().FullName = "Losszero.RCombineSte" Then
                    Dim rcste As RCombineSte = CType(element, RCombineSte)
                    Dim childNode As New TreeNode
                    Dim childNodeStr As String = rcste.mUninqueIDX & " " & rcste.mplace & " -" & rcste.mQty & "EA"
                    childNode.Text = childNodeStr
                    childNode.Name = "STEEL"
                    childNode.Tag = rcste.msteIDX
                    childNode.ImageIndex = 1
                    node_.Nodes.Add(childNode)

                ElseIf element.GetType().FullName = "Losszero.RCombineRemainSteel" Then
                    Dim rcr As RCombineRemainSteel = CType(element, RCombineRemainSteel)
                    Dim childNode1 As New TreeNode
                    Dim childNodeStr1 As String = "(R)" & rcr.mLen & "-" & rcr.mQty & "EA"
                    childNode1.ImageIndex = 3
                    childNode1.Text = childNodeStr1
                    node_.Nodes.Add(childNode1)

                End If

            Next

            node = node_

        End Sub
        Public Overrides Function getNode() As TreeNode

            Return node

        End Function

    End Class

End Class