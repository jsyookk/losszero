Imports System.Windows.Forms.DataVisualization.Charting

Public Class MChartPie : Inherits MChartDeco

    Private name As String
    Private seriels As Series
    Private area As New ChartArea


    Sub New(display As MChart, seriels As Series, name As String)

        MyBase.New(display)
        Me.seriels = seriels
        Me.seriels.ChartType = SeriesChartType.Pie
        Me.name = name
        Me.seriels.Name = name
        Me.area.Name = name

        getChart().Series.Add(seriels)
        getChart().Series(name).IsVisibleInLegend = True
        getChart().Series(name).Label = "#PERCENT{P0}"
        getChart().Series(name).LegendText = "#VALX"
        getChart().Series(name)("PieLabelStyle") = "Indise"
        getChart().Series(name)("PieLabelColor") = "Red"
        getChart().Series(name).IsValueShownAsLabel = True
        getChart().Series(name).SmartLabelStyle.CalloutStyle = LabelCalloutStyle.Box
        getChart().Series(name).SmartLabelStyle.Enabled = True

        getChart().ChartAreas.Add(area)
        getChart().Series(name).ChartArea = name
        getChart().ChartAreas(name).BackColor = Color.Transparent
        getChart().ChartAreas(name).ShadowColor = Color.Transparent
        getChart().ChartAreas(name).BorderWidth = 0
        getChart().ChartAreas(name).Area3DStyle.Enable3D = True
        getChart().ChartAreas(name).Area3DStyle.Inclination = 20
        getChart().ChartAreas(name).Area3DStyle.Rotation = 0


    End Sub


    Public Overrides Sub setTitle(title_ As String)


    End Sub


    Public Overrides Function getChart() As Chart

        Return ch.getChart()

    End Function

    Public Overrides Sub layout(x As Single, y As Single, width As Single, height As Single)

        getChart().ChartAreas(name).Position.Width = width
        getChart().ChartAreas(name).Position.Height = height
        getChart().ChartAreas(name).Position.X = x
        getChart().ChartAreas(name).Position.Y = y

    End Sub

    Public Overrides Sub makeLegend()

        getChart().Legends.Add("Legend")
        getChart().Legends("Legend").Enabled = True
        getChart().Legends("Legend").Docking = Docking.Left
        getChart().Legends("Legend").BackColor = Color.Transparent
        getChart().Legends("Legend").Alignment = System.Drawing.StringAlignment.Near
        getChart().Legends("Legend").LegendStyle = LegendStyle.Column
        getChart().Legends("Legend").Font = New Font("Verdana", 8, FontStyle.Bold)

        getChart().Series(name).Legend = "Legend"

        Dim cell1 As LegendCellColumn = New LegendCellColumn()
        cell1.ColumnType = LegendCellColumnType.SeriesSymbol
        cell1.HeaderBackColor = Color.WhiteSmoke
        getChart().Legends("Legend").CellColumns.Add(cell1)

        Dim cell2 As LegendCellColumn = New LegendCellColumn()
        cell2.ColumnType = LegendCellColumnType.Text
        cell2.HeaderText = "강종"
        cell2.Text = "#LEGENDTEXT"
        cell2.HeaderBackColor = Color.WhiteSmoke
        getChart().Legends("Legend").CellColumns.Add(cell2)

        Dim cell3 As LegendCellColumn = New LegendCellColumn()
        cell3.ColumnType = LegendCellColumnType.Text
        cell3.HeaderText = "톤 수"
        cell3.Text = "#VALY{N2}"
        cell3.HeaderBackColor = Color.WhiteSmoke
        getChart().Legends("Legend").CellColumns.Add(cell3)


    End Sub

    Public Overrides Sub addLegend(legend As Legend)

    End Sub

    Public Overrides Sub layout(x As Single, y As Single, width As Single, height As Single, serialh As Single)
        Throw New NotImplementedException()
    End Sub

    Public Overrides Sub legendPosition(x As Single, y As Single, width As Single, height As Single, serialh As Single)
        Throw New NotImplementedException()
    End Sub

    Public Overrides Sub setTitle(title_ As String, x_ As Single, y_ As Single, w_ As Single, h_ As Single)
        Throw New NotImplementedException()
    End Sub
End Class
