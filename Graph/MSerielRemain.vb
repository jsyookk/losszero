
Imports System.Windows.Forms.DataVisualization.Charting

Public Class MSerielRemain : Implements MSeriel
    Private arr As New ArrayList
    Private legend As Legend

    Public Sub New(re As RCombineElement)

        If re.GetType().FullName = "Losszero.RCombineRemain" Then

            Dim rcr As RCombineRemain = CType(re, RCombineRemain)

            Dim rseriel As New Series
            rseriel.Name = rcr.mLen & rcr.mQty
            ' rseriel.IsVisibleInLegend = False
            rseriel.Points.AddXY("(R) " & rcr.mQty & "QTY", rcr.mLen)
            rseriel.IsVisibleInLegend = True
            arr.Add(rseriel)

            Dim legend As Legend = makeLegend(rcr)
            rseriel.Legend = legend.Name

        End If


    End Sub
    Private Function makeLegend(rcr As RCombineRemain)

        legend = New Legend()

        legend.Name = "remain" & CInt(100000 * Rnd())
        legend.Enabled = True
        legend.Docking = Docking.Bottom
        legend.Alignment = System.Drawing.StringAlignment.Near
        legend.LegendStyle = LegendStyle.Table
        '  legend.Font = New Font("Verdana", 8, FontStyle.Bold)

        Dim cell1 As LegendCellColumn = New LegendCellColumn()
        cell1.ColumnType = LegendCellColumnType.SeriesSymbol
        cell1.HeaderBackColor = Color.WhiteSmoke
        legend.CellColumns.Add(cell1)


        Dim cell2 As LegendCellColumn = New LegendCellColumn()
        cell2.ColumnType = LegendCellColumnType.Text
        cell2.HeaderText = "길이"
        cell2.Text = rcr.mLen
        cell2.HeaderBackColor = Color.WhiteSmoke
        legend.CellColumns.Add(cell2)

        Dim cell3 As LegendCellColumn = New LegendCellColumn()
        cell3.ColumnType = LegendCellColumnType.Text
        cell3.HeaderText = "수량"
        cell3.Text = rcr.mQty
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
