Imports System.Windows.Forms.DataVisualization.Charting

Public MustInherit Class MChart

    MustOverride Sub setTitle(title_ As String)
    MustOverride Sub setTitle(title_ As String, x_ As Single, y_ As Single, w_ As Single, h_ As Single)
    MustOverride Function getChart() As Chart
    MustOverride Sub layout(x As Single, y As Single, width As Single, height As Single)
    MustOverride Sub layout(x As Single, y As Single, width As Single, height As Single, serialh As Single)
    MustOverride Sub legendPosition(x As Single, y As Single, width As Single, height As Single, serialh As Single)

    MustOverride Sub makeLegend()
    MustOverride Sub addLegend(legend As Legend)

End Class
