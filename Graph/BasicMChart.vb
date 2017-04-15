Imports System.Windows.Forms.DataVisualization.Charting

Public Class BasicMChart : Inherits MChart

    Private chart As Chart
    Private title As Title


    Public Sub New(chart As Chart, width As Integer, height As Integer)

        Me.chart = chart
        Me.chart.Width = width
        Me.chart.Height = height

    End Sub

    Public Overrides Sub setTitle(title_ As String)

        title = New Title(title_, Docking.Top, New Font("Verdana", 12), Color.Black)
        chart.Titles.Add(title)


    End Sub
    Public Overrides Sub setTitle(title_ As String, x_ As Single, y_ As Single, w_ As Single, h_ As Single)

        title = New Title(title_, Docking.Top, New Font("Verdana", 12), Color.Black)
        title.Name = "title"
        chart.Titles.Add(title)
        chart.Titles("title").Position.X = x_
        chart.Titles("title").Position.Y = y_
        chart.Titles("title").Position.Width = w_
        chart.Titles("title").Position.Height = h_

    End Sub


    Public Overrides Function getChart() As Chart

        Return chart

    End Function

    Public Overrides Sub layout(x As Single, y As Single, width As Single, height As Single)


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
End Class
