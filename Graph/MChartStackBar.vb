Imports System.Windows.Forms.DataVisualization.Charting

Public Class MChartStackBar : Inherits MChartDeco

    Private legendName As String
    Private name As String
    Private area As New ChartArea
    '  Private legends As New ArrayList
    Private serlesArr As ArrayList


    Sub New(display As MChart, serielsArr As ArrayList, name As String)

        MyBase.New(display)

        Me.name = name
        Me.area.Name = name
        Me.serlesArr = serielsArr

        getChart().ChartAreas.Add(area)
        getChart().ChartAreas(name).BackColor = Color.WhiteSmoke
        getChart().ChartAreas(name).BorderWidth = 0
        getChart().ChartAreas(name).Area3DStyle.Enable3D = True
        getChart().ChartAreas(name).Area3DStyle.Inclination = 10
        getChart().ChartAreas(name).Area3DStyle.Rotation = 10
        getChart().ChartAreas(name).AxisX.LabelStyle.Enabled = False


        Dim nameIdx As Integer = 1
        Dim serialName As String

        For Each serial As Series In serielsArr

            serialName = serial.Name & name & nameIdx
            serial.ChartType = SeriesChartType.StackedBar
            serial.Name = serialName

            getChart().Series.Add(serial)
            ' getChart().Series(serialName).IsVisibleInLegend = True
            getChart().Series(serialName).Label = "#VALY"

            '    getChart().Series(serialName)("PieLabelStyle") = "Indise"
            getChart().Series(serialName)("PieLabelColor") = "Red"
            '  getChart().Series(serialName).IsValueShownAsLabel = True
            getChart().Series(serialName).SmartLabelStyle.CalloutStyle = LabelCalloutStyle.None
            getChart().Series(serialName).SmartLabelStyle.Enabled = True
            getChart().Series(serialName).ChartArea = name

            nameIdx = nameIdx + 1

        Next



    End Sub

    Public Overrides Sub layout(x As Single, y As Single, width As Single, height As Single, serialh As Single)

        getChart().ChartAreas(name).Position.Auto = False

        getChart().ChartAreas(name).Position.Width = width
        getChart().ChartAreas(name).Position.Height = height
        getChart().ChartAreas(name).Position.X = x
        getChart().ChartAreas(name).Position.Y = y

        'legendPosition(x, y, width, height, serialh)

    End Sub
    Public Overrides Sub legendPosition(x As Single, y As Single, width As Single, height As Single, serialh As Single)

        'Dim legendHeight As Integer = Math.Floor(height / 2)

        getChart().Legends(legendName).Position.Auto = False
        getChart().Legends(legendName).Position = New ElementPosition(x, y, width, height)

        'For Each serial As Series In serlesArr

        '    If serial.Legend IsNot String.Empty Then

        '        Dim legendHeight As Integer = CInt(height / 2)

        '        getChart().Legends(serial.Legend).Position.Auto = False
        '        getChart().Legends(serial.Legend).Position = New ElementPosition(x, y - legendHeight, width, legendHeight)
        '        '            getChart().Legends(serial.Legend).Position = New ElementPosition(5, y, 100 - width - 8, CInt(height / 2))

        '    End If

        'Next

    End Sub
    Public Overrides Sub layout(x As Single, y As Single, width As Single, height As Single)

        getChart().ChartAreas(name).Position.Width = width
        getChart().ChartAreas(name).Position.Height = height
        getChart().ChartAreas(name).Position.X = x
        getChart().ChartAreas(name).Position.Y = y

        AutolegendPosition(x, y, width, height)

    End Sub

    Private Sub AutolegendPosition(x As Single, y As Single, width As Single, height As Single)

        Dim legendHeight As Single = Math.Round(height * 0.35, 1)

        getChart().Legends(legendName).Position.Auto = False
        getChart().Legends(legendName).Position = New ElementPosition(x, y - legendHeight, width, legendHeight)

        'For Each serial As Series In serlesArr

        '    If serial.Legend IsNot String.Empty Then

        '        Dim legendHeight As Integer = CInt(height / 2)

        '        getChart().Legends(serial.Legend).Position.Auto = False
        '        getChart().Legends(serial.Legend).Position = New ElementPosition(x, y - legendHeight, width, legendHeight)
        '        '            getChart().Legends(serial.Legend).Position = New ElementPosition(5, y, 100 - width - 8, CInt(height / 2))

        '    End If

        'Next

    End Sub


    Public Overrides Sub makeLegend()



    End Sub

    Public Overrides Sub setTitle(title_ As String)


    End Sub

    Public Overrides Function getChart() As Chart

        Return ch.getChart()

    End Function


    Public Overrides Sub addLegend(legend As Legend)

        legendName = legend.Name
        getChart().Legends.Add(legend)

    End Sub

    Public Overrides Sub setTitle(title_ As String, x_ As Single, y_ As Single, w_ As Single, h_ As Single)
        Throw New NotImplementedException()
    End Sub
End Class
