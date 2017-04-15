Imports System.Windows.Forms.DataVisualization.Charting


Public Class MSerielRemainSte : Implements MSeriel

    Private legend As Legend

    Private arr As New ArrayList
    Private colors As New List(Of Color)

    Private Function makeColor() As Color

        Dim a As Integer = 240
        Dim r As Integer = CInt(Int((254 * Rnd()) + 0))
        Dim g As Integer = CInt(Int((254 * Rnd()) + 0))
        Dim b As Integer = CInt(Int((254 * Rnd()) + 0))


        Return Color.FromArgb(a, r, g, b)

    End Function

    Public Sub New(re As RCombineElement)

        If re.GetType().FullName = "Losszero.RCombineRemainSteel" Then

            Dim rcste As RCombineRemainSteel = CType(re, RCombineRemainSteel)
            Dim XStr As String = "LENGTH :" & rcste.mLen & "EA :" & rcste.mQty
            Dim color As Color = makeColor()

            Dim seriel As New Series
            seriel.Name = rcste.msteIDX & rcste.mcut
            seriel.Color = Color.DarkGray
            'seriel.Points.AddXY(XStr, rcste.mLen)
            seriel.Points.AddY(rcste.mLen)
            seriel.IsVisibleInLegend = False

            arr.Add(seriel)

            Dim legend As Legend = makeLegend(rcste)
            seriel.Legend = legend.Name
            seriel.IsVisibleInLegend = True

        End If


    End Sub

    Private Function makeLegend(rcste As RCombineRemainSteel) As Legend

        legend = New Legend()

        legend.Name = "remainsteel" & CInt(100000 * Rnd())
        legend.Enabled = True
        legend.Docking = Docking.Top
        legend.Alignment = StringAlignment.Near
        legend.LegendStyle = LegendStyle.Table
        ' legend.Font = New Font("Verdana", 8, FontStyle.Bold)

        Dim cell1 As LegendCellColumn = New LegendCellColumn()
        cell1.ColumnType = LegendCellColumnType.SeriesSymbol
        cell1.HeaderBackColor = Color.WhiteSmoke
        legend.CellColumns.Add(cell1)

        Dim cell2 As LegendCellColumn = New LegendCellColumn()
        cell2.ColumnType = LegendCellColumnType.Text
        cell2.HeaderText = "길이"
        cell2.Text = rcste.mLen
        cell2.HeaderBackColor = Color.WhiteSmoke
        legend.CellColumns.Add(cell2)


        Dim cell3 As LegendCellColumn = New LegendCellColumn()
        cell3.ColumnType = LegendCellColumnType.Text
        cell3.HeaderText = "수량"
        cell3.Text = rcste.mQty
        cell3.HeaderBackColor = Color.WhiteSmoke
        legend.CellColumns.Add(cell3)

        Return legend

    End Function
    Public Sub addLossSeriel(len As Double) Implements MSeriel.addLossSeriel

    End Sub



    Public Function getLegend() As Legend Implements MSeriel.getLegend

        Return legend

    End Function

    Public Function getSeriels() As ArrayList Implements MSeriel.getSeriels
        Return arr
    End Function


End Class
