
Imports System.Windows.Forms.DataVisualization.Charting

Public Class MSerielRoot : Implements MSeriel
    Private arr As New ArrayList
    Private sumLen As Integer
    Private colors As New List(Of Color)

    Private legend As Legend

    Private Function makeColor() As Color

        Dim a As Integer = 240
        Dim r As Integer = CInt(Int((254 * Rnd()) + 0))
        Dim g As Integer = CInt(Int((254 * Rnd()) + 0))
        Dim b As Integer = CInt(Int((254 * Rnd()) + 0))


        Return Color.FromArgb(a, r, g, b)

    End Function


    Public Sub New(re As List(Of RCombineElement))

        makeInitLegned()

        Dim XStr As String = ""

        For Each element As RCombineElement In re

            If element.GetType().FullName = "Losszero.RCombineSte" Then

                Dim rcste As RCombineSte = CType(element, RCombineSte)
                XStr = XStr + "(No." & rcste.mUninqueIDX & ")" & rcste.mplace
                Dim cutIdx As Integer
                Dim color As Color = makeColor()

                For cutIdx = 1 To rcste.mcut

                    Dim seriel As New Series
                    seriel.Name = rcste.msteIDX & cutIdx & rcste.mUninqueIDX
                    seriel.Color = Color.FromArgb(240, color)
                    seriel.Points.AddY(rcste.mLen)
                    seriel.IsVisibleInLegend = False

                    If cutIdx = 1 Then

                        Dim legen As Legend = makeLegend(rcste, seriel.Color)
                        seriel.Legend = legen.Name
                        seriel.IsVisibleInLegend = False

                    End If

                    arr.Add(seriel)
                    sumLen = sumLen + rcste.mLen

                Next

            End If

        Next



    End Sub

    Public Sub addLossSeriel(len As Double) Implements MSeriel.addLossSeriel

        Dim rseriel As New Series
        Dim remainLen As Integer

        remainLen = len - sumLen

        rseriel.IsVisibleInLegend = False
        rseriel.Color = Color.FromArgb(240, Color.DimGray)
        rseriel.Points.AddY(remainLen)
        arr.Add(rseriel)

    End Sub
    Private Sub makeInitLegned()

        legend = New Legend

        legend.Name = "rootLegend" & CInt(100000 * Rnd())
        legend.Enabled = True
        legend.Docking = Docking.Top
        legend.Alignment = System.Drawing.StringAlignment.Near
        legend.LegendStyle = LegendStyle.Column
        legend.Font = New Font("Verdana", 8)
        ' rootlegend.Font = New Font("Verdana", 8, FontStyle.Bold)

        Dim cell1 As LegendCellColumn = New LegendCellColumn()
        cell1.ColumnType = LegendCellColumnType.SeriesSymbol
        cell1.HeaderBackColor = Color.WhiteSmoke
        legend.CellColumns.Add(cell1)

        Dim cell2 As LegendCellColumn = New LegendCellColumn()
        cell2.ColumnType = LegendCellColumnType.Text
        cell2.HeaderText = "NUM"
        cell2.HeaderBackColor = Color.WhiteSmoke
        legend.CellColumns.Add(cell2)

        Dim cell3 As LegendCellColumn = New LegendCellColumn()
        cell3.ColumnType = LegendCellColumnType.Text
        cell3.HeaderText = "공정명"
        cell3.HeaderBackColor = Color.WhiteSmoke
        legend.CellColumns.Add(cell3)

        Dim cell4 As LegendCellColumn = New LegendCellColumn()
        cell4.ColumnType = LegendCellColumnType.Text
        cell4.HeaderText = "길이"
        cell4.HeaderBackColor = Color.WhiteSmoke
        legend.CellColumns.Add(cell4)

        Dim cell5 As LegendCellColumn = New LegendCellColumn()
        cell5.ColumnType = LegendCellColumnType.Text
        cell5.HeaderText = "수량"
        cell5.HeaderBackColor = Color.WhiteSmoke
        legend.CellColumns.Add(cell5)

    End Sub
    Private Function makeLegend(rcste As RCombineSte, color As Color) As Legend


        Dim newItem As New LegendItem()

        newItem.Color = color
        newItem.Cells.Add(LegendCellType.SeriesSymbol, "", ContentAlignment.MiddleCenter)

        If rcste.mUninqueIDX <> "" Then
            newItem.Cells.Add(LegendCellType.Text, rcste.mUninqueIDX, ContentAlignment.MiddleCenter)
        Else
            newItem.Cells.Add(LegendCellType.Text, rcste.mUninqueIDX, ContentAlignment.MiddleCenter)
        End If

        newItem.Cells.Add(LegendCellType.Text, rcste.mplace, ContentAlignment.MiddleCenter)
        newItem.Cells.Add(LegendCellType.Text, rcste.mLen, ContentAlignment.MiddleCenter)
        newItem.Cells.Add(LegendCellType.Text, rcste.mQty, ContentAlignment.MiddleCenter)
        legend.CustomItems.Add(newItem)

        Return legend

    End Function

    Public Function getSeriels() As ArrayList Implements MSeriel.getSeriels

        Return arr

    End Function
    Public Function getLegend() As Legend Implements MSeriel.getLegend

        Return legend

    End Function


End Class
