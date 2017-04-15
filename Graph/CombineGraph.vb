Imports System.Windows.Forms.DataVisualization.Charting


Public MustInherit Class CombineGraph

    Protected Const startXpos As Integer = 5
    ' Protected Const startYpos As Integer = 5
    Protected Const titleHeight As Integer = 2
    Protected Const graphWidth As Integer = 90
    Public MustOverride Function getGraph() As MChart


    Public Shared Function GrpahFactory(rc_ As RCombine, size_ As Size) As MChart

        Select Case rc_.COMBINE_TYPE
            Case RCombine.CBType.PERPECT
                Return New PerfactTypeGraph(rc_, size_).getGraph()
            Case RCombine.CBType.LINKED
                Return New LinkedTypeGraph(rc_, size_).getGraph()
            Case RCombine.CBType.REMAIN_CUT
                Return New RemainTypeGraph(rc_, size_).getGraph()
        End Select

        Return Nothing

    End Function

    Public Class PerfactTypeGraph : Inherits CombineGraph

        Private base As MChart
        Public ypos As Single = 0

        Public Sub New(rc As RCombine, size_ As Size)

            Dim graphH As Single
            Dim serialH As Single
            Dim tH As Single

            Dim meter As Double = 0
            meter = rc.UseMeter * 1000

            Dim cnt As Integer = rc.getGraphDisplayCount()
            Dim eachGraphH As Single = Math.Round((100 / cnt), 1)
            graphH = Math.Round(eachGraphH * 0.5, 1)
            serialH = Math.Round(eachGraphH * 0.5, 1)

            ypos = ypos + graphH

            base = New BasicMChart(New Chart(), size_.Width, size_.Height)
            Dim title As String = "(" & rc.getUniqueStr & ") " & rc.hdmStr & " • " & rc.UseMeter & "M" & " • " & rc.needTon & "t" & " • " & rc.Loss & "%"
            base.setTitle(title)

            Dim rootseriel As MSeriel = New MSerielRoot(rc.getList())
            rootseriel.addLossSeriel(meter)

            Dim rootchart As MChart = New MChartStackBar(base, rootseriel.getSeriels(), "root")
            rootchart.addLegend(rootseriel.getLegend())
            rootchart.layout(startXpos, ypos, graphWidth, graphH)

            ypos = ypos + graphH

            For Each childelement As RCombineElement In rc.getList

                If childelement.GetType().FullName = "Losszero.RCombineRemainSteel" Then

                    Dim rcr As RCombineRemainSteel = CType(childelement, RCombineRemainSteel)
                    Dim mremain As MSeriel = New MSerielRemainSte(rcr)
                    Dim mr As MChart = New MChartStackBar(base, mremain.getSeriels(), "remain")
                    mr.addLegend(mremain.getLegend())
                    mr.layout(startXpos, ypos, graphWidth, graphH)

                    ypos = ypos + graphH

                End If

            Next

        End Sub


        Public Overrides Function getGraph() As MChart

            Return base

        End Function


    End Class

    Public Class LinkedTypeGraph : Inherits CombineGraph


        Private base As MChart
        Public ypos As Single = 0

        Public Sub New(rc As RCombine, size_ As Size)
            Dim meter As Double = 0

            Dim cnt As Integer = rc.getGraphDisplayCount()
            Dim sy As Single
            Dim graphH As Single
            Dim emptyH As Single
            Dim tH As Single

            Dim eachGraphH As Single = Math.Round((100 / cnt), 1)

            graphH = Math.Round((eachGraphH * 0.9), 1)
            emptyH = Math.Round((eachGraphH * 0.1), 1)
            tH = emptyH

            sy = sy + graphH + tH
            'sy = sy + titleHeight + serialH
            ' eachH = serialH


            meter = rc.UseMeter * 1000

            base = New BasicMChart(New Chart(), size_.Width, size_.Height)
            Dim title As String = "(" & rc.getUniqueStr & ") " & rc.hdmStr & " • " & rc.UseMeter & "M" & " • " & rc.needTon & "t"
            base.setTitle(title, 10, emptyH, 80, emptyH)
            'base.setTitle(title)


            ypos = ypos + sy

            For Each childelement As RCombineElement In rc.getList

                If childelement.GetType().FullName = "Losszero.RCombineLink" Then

                    Dim names As String = "rlnk" & ypos
                    Dim rcr As RCombineLink = CType(childelement, RCombineLink)
                    Dim rlinkseriel As MSeriel = New MSerielRoot(rcr.getList())
                    rlinkseriel.addLossSeriel(meter)

                    Dim rlnkchart As MChart = New MChartStackBar(base, rlinkseriel.getSeriels(), names)
                    rlnkchart.addLegend(rlinkseriel.getLegend())
                    rlnkchart.layout(startXpos, ypos, graphWidth, graphH)

                    ypos = ypos + graphH + emptyH

                End If

                If childelement.GetType().FullName = "Losszero.RCombineRemainSteel" Then

                    Dim rcr As RCombineRemainSteel = CType(childelement, RCombineRemainSteel)
                    Dim mremain As MSeriel = New MSerielRemainSte(rcr)
                    Dim mr As MChart = New MChartStackBar(base, mremain.getSeriels(), "remain")
                    mr.addLegend(mremain.getLegend())
                    mr.layout(startXpos, ypos, graphWidth, graphH)

                    ypos = ypos + graphH + +emptyH

                End If

            Next



        End Sub
        Public Overrides Function getGraph() As MChart

            Return base

        End Function



    End Class

    Public Class RemainTypeGraph : Inherits CombineGraph

        Private base As MChart
        Public ypos As Single = 0

        Public Sub New(rc As RCombine, size_ As Size)
            Dim meter As Double = 0

            Dim cnt As Integer = rc.getGraphDisplayCount()
            Dim sy As Single
            Dim graphH As Single
            Dim emptyH As Single
            Dim tH As Single

            Dim eachGraphH As Single = Math.Round((100 / cnt), 1)
            graphH = Math.Round(eachGraphH * 0.9, 1)
            emptyH = Math.Round(eachGraphH * 0.1, 1)
            tH = emptyH
            sy = sy + graphH + tH

            ypos = ypos + sy

            meter = rc.UseMeter * 1000

            base = New BasicMChart(New Chart(), size_.Width, size_.Height)
            Dim title As String = "(" & rc.getUniqueStr & ") " & rc.hdmStr & " • " & rc.UseMeter & "M" & " • " & rc.needTon & "t" & " • " & rc.Loss & "%"
            base.setTitle(title)

            Dim rootseriel As MSeriel = New MSerielRoot(rc.getList())
            rootseriel.addLossSeriel(meter)

            Dim rootchart As MChart = New MChartStackBar(base, rootseriel.getSeriels(), "root")
            rootchart.addLegend(rootseriel.getLegend())
            rootchart.layout(startXpos, ypos, graphWidth, graphH)

            ypos = ypos + graphH + emptyH

            For Each childelement As RCombineElement In rc.getList

                If childelement.GetType().FullName = "Losszero.RCombineRemain" Then

                    Dim rcr As RCombineRemain = CType(childelement, RCombineRemain)
                    Dim mremainSeriel As MSeriel = New MSerielRemain(rcr)
                    Dim mr As MChart = New MChartStackBar(base, mremainSeriel.getSeriels(), "remain")
                    mr.addLegend(mremainSeriel.getLegend())
                    mr.layout(startXpos, ypos, graphWidth, graphH)

                    ypos = ypos + graphH + emptyH


                    Dim rLen As Integer = rcr.mLen
                    Dim steChildIdx As Integer = 0

                    For Each steelment As RCombineElement In rcr.getList
                        If steelment.GetType().FullName = "Losszero.RCombineSte" Then

                            Dim charName As String = "ste" & steChildIdx
                            Dim rcste As RCombineSte = CType(steelment, RCombineSte)
                            Dim steSeriel As MSeriel = New MSerielSteel(rcste)
                            steSeriel.addLossSeriel(rLen)

                            Dim smr As MChart = New MChartStackBar(base, steSeriel.getSeriels(), charName)
                            smr.addLegend(steSeriel.getLegend())
                            smr.layout(startXpos, ypos, graphWidth, graphH)

                            steChildIdx = steChildIdx + 1
                            ypos = ypos + graphH + emptyH


                        ElseIf steelment.GetType().FullName = "Losszero.RCombineRemain" Then
                            Dim rs As RCombineRemain = CType(steelment, RCombineRemain)
                            Dim rsSeriel As MSeriel = New MSerielRemain(rs)
                            Dim rsm As MChart = New MChartStackBar(base, rsSeriel.getSeriels(), "remainb")
                            rsm.addLegend(rsSeriel.getLegend())
                            rsm.layout(startXpos, ypos, graphWidth, graphH)

                            ypos = ypos + graphH + emptyH

                        End If


                    Next

                End If

            Next

        End Sub
        Public Overrides Function getGraph() As MChart

            Return base

        End Function



    End Class


End Class
