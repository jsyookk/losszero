Imports System.Windows.Forms.DataVisualization.Charting

Public Class MChartBar : Inherits MChartDeco

    Dim name As String
    Dim seriels As Series
    Dim area As New ChartArea

    Public Sub New(display As MChart, seriels As Series, name As String)

        MyBase.New(display)

        Me.name = name
        Me.seriels = seriels
        Me.seriels.Name = name
        Me.area.Name = name
        Me.seriels.ChartType = SeriesChartType.Bar

        makeColors(Me.seriels)

        getChart().ChartAreas.Add(area)
        getChart().Series.Add(seriels)
        getChart().Series(name).IsValueShownAsLabel = True
        getChart().Series(name)("PointWidth") = "0.8"
        getChart().Series(name).BorderWidth = 1
        getChart().Series(name).BorderColor = Color.White

        getChart().Series(name).ChartArea = name

        getChart().ChartAreas(name).AxisX.Interval = 1
        getChart().ChartAreas(name).AxisX.LineWidth = 0
        getChart().ChartAreas(name).AxisY.LineWidth = 0
        getChart().ChartAreas(name).AxisY.LabelStyle.Enabled = False

        getChart().ChartAreas(name).AxisX.MajorGrid.Enabled = False
        getChart().ChartAreas(name).AxisX.MajorTickMark.Enabled = False
        getChart().ChartAreas(name).AxisX.MinorGrid.Enabled = False
        getChart().ChartAreas(name).AxisX.MinorTickMark.Enabled = False

        getChart().ChartAreas(name).AxisY.MajorGrid.Enabled = False
        getChart().ChartAreas(name).AxisY.MinorGrid.Enabled = False
        getChart().ChartAreas(name).AxisY.MajorTickMark.Enabled = False
        getChart().ChartAreas(name).AxisY.MinorTickMark.Enabled = False


    End Sub
    Private Sub makeColors(seriels As Series)

        For i = 0 To seriels.Points.Count - 1
            Dim a As Integer = 240
            Dim r As Integer = CInt(Int((254 * Rnd()) + 0))
            Dim g As Integer = CInt(Int((254 * Rnd()) + 0))
            Dim b As Integer = CInt(Int((254 * Rnd()) + 0))
            seriels.Points.Item(i).Color = Color.FromArgb(a, r, g, b)
        Next

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
