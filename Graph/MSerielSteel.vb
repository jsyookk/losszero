
Imports System.Windows.Forms.DataVisualization.Charting


Public Class MSerielSteel : Implements MSeriel
    Private arr As New ArrayList
    Private colors As New List(Of Color)
    Private sumLen As Integer

    Private legend As Legend

    Private place As String
    Private qty As Integer
    Private len As Integer
    Private name As String

    Private Function makeColor() As Color

        Dim a As Integer = 240
        Dim r As Integer = CInt(Int((254 * Rnd()) + 0))
        Dim g As Integer = CInt(Int((254 * Rnd()) + 0))
        Dim b As Integer = CInt(Int((254 * Rnd()) + 0))


        Return Color.FromArgb(a, r, g, b)

    End Function


    Public Sub New(re As RCombineElement)

        If re.GetType().FullName = "Losszero.RCombineSte" Then
            Dim rcste As RCombineSte = CType(re, RCombineSte)
            Dim XStr As String = "(No." & rcste.mUninqueIDX & ")" & rcste.mplace & "CUTTING :" & rcste.mcut & "LENGTH :" & rcste.mLen & "EA :" & rcste.mQty
            Dim cutIdx As Integer
            Dim color As Color = makeColor()

            For cutIdx = 1 To rcste.mcut

                Dim seriel As New Series
                seriel.Color = Color.FromArgb(240, color)
                'seriel.Points.AddXY(XStr, rcste.mLen)
                seriel.Points.AddY(rcste.mLen)
                seriel.IsVisibleInLegend = False

                sumLen = sumLen + rcste.mLen
                arr.Add(seriel)

                If cutIdx = 1 Then
                    Dim legend As Legend = makeLegend(rcste, cutIdx)
                    seriel.Legend = legend.Name
                    seriel.IsVisibleInLegend = True
                End If

            Next

        End If


    End Sub

    Public Sub addLossSeriel(len As Double) Implements MSeriel.addLossSeriel

        Dim rseriel As New Series
        Dim remainLen As Integer

        remainLen = len - sumLen

        rseriel.IsVisibleInLegend = False
        rseriel.Color = Color.FromArgb(240, Color.DimGray)
        'rseriel.Points.AddXY("REMAIN", remainLen)
        rseriel.Points.AddY(remainLen)
        arr.Add(rseriel)


    End Sub

    Public Function getSeriels() As ArrayList Implements MSeriel.getSeriels

        Return arr

    End Function


    Private Function makeLegend(rcste As RCombineSte, idx As Integer) As Legend

        legend = New Legend()

        legend.Name = rcste.msteIDX & idx
        legend.Enabled = True
        legend.Docking = Docking.Top
        legend.Alignment = System.Drawing.StringAlignment.Near
        legend.LegendStyle = LegendStyle.Table


        Dim cell1 As LegendCellColumn = New LegendCellColumn()
        cell1.ColumnType = LegendCellColumnType.SeriesSymbol
        cell1.HeaderBackColor = Color.WhiteSmoke
        legend.CellColumns.Add(cell1)

        Dim cell2 As LegendCellColumn = New LegendCellColumn()
        cell2.ColumnType = LegendCellColumnType.Text
        cell2.HeaderText = "NUM"

        If rcste.mUninqueIDX <> "" Then
            cell2.Text = rcste.mUninqueIDX
        Else
            cell2.Text = rcste.mUninqueIDX
        End If

        '  cell2.Text = rcste.mUninqueIDX
        cell2.HeaderBackColor = Color.WhiteSmoke
        legend.CellColumns.Add(cell2)


        Dim cell3 As LegendCellColumn = New LegendCellColumn()
        cell3.ColumnType = LegendCellColumnType.Text
        cell3.HeaderText = "장소"
        cell3.Text = rcste.mplace
        cell3.HeaderBackColor = Color.WhiteSmoke
        legend.CellColumns.Add(cell3)

        Dim cell4 As LegendCellColumn = New LegendCellColumn()
        cell4.ColumnType = LegendCellColumnType.Text
        cell4.HeaderText = "길이"
        cell4.Text = rcste.mLen
        cell4.HeaderBackColor = Color.WhiteSmoke
        legend.CellColumns.Add(cell4)

        Dim cell5 As LegendCellColumn = New LegendCellColumn()
        cell5.ColumnType = LegendCellColumnType.Text
        cell5.HeaderText = "수량"
        cell5.Text = rcste.mQty
        cell5.HeaderBackColor = Color.WhiteSmoke
        legend.CellColumns.Add(cell5)



        Return legend

    End Function

    Public Function getLegend() As Legend Implements MSeriel.getLegend

        Return legend

    End Function
End Class
