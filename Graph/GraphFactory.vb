Imports System.Windows.Forms.DataVisualization.Charting


Public MustInherit Class GraphFactory
    Enum GRAPH_TYPE
        PIE_G
        BAR_G
        BAR_G_EACH
    End Enum

    Enum X_AXIS_TYPE
        HDM
        HDM_METER
    End Enum

    Public MustOverride Function getGraph() As MChart
    Public MustOverride Function getTotalTon() As Double
    Public MustOverride Function createSeries(x_type As X_AXIS_TYPE, data_ As Hashtable) As Series


    Public Function getHdmAndMeter(key_ As String) As Double()
        Dim values As Double() = {0, 0}

        Dim parts As String() = key_.Split(New Char() {","c}, StringSplitOptions.RemoveEmptyEntries)
        values(0) = CDbl(parts(0))
        values(1) = CDbl(parts(1))

        Return values

    End Function

    Public Shared Function CreateGraph(x_type As X_AXIS_TYPE, type_ As GRAPH_TYPE, data_ As Hashtable, size_ As Size, title_ As String) As MChart

        Select Case type_
            Case GRAPH_TYPE.PIE_G
                Return New PieGraph(x_type, data_, size_, title_).getGraph()
            Case GRAPH_TYPE.BAR_G
                Return New BarGraph(x_type, data_, size_, title_).getGraph()
            Case GRAPH_TYPE.BAR_G_EACH
                Return New BarGraphOne(x_type, data_, size_, title_).getGraph()
        End Select

        Return Nothing

    End Function
    Public Class BarGraphOne : Inherits GraphFactory
        Private bChart As MChart
        Public Sub New(x_type As X_AXIS_TYPE, data_ As Hashtable, size_ As Size, title_ As String)

            bChart = New BasicMChart(New Chart(), size_.Width, size_.Height)

            Dim barchart As MChart = New MChartBar(bChart, createSeries(x_type, data_), "barchart")
            barchart.layout(5, 5, 95, 95)

        End Sub
        Public Overrides Function createSeries(x_type As X_AXIS_TYPE, data_ As Hashtable) As Series

            Dim series As New Series

            Select Case x_type
                Case X_AXIS_TYPE.HDM_METER
                    Dim keys As List(Of String) = HashTableSort.Sort(data_)

                    For Each key As String In keys
                        Dim values As Double() = getHdmAndMeter(key)
                        Dim hdm As Double = values(0)
                        Dim meter As Double = values(1)
                        Dim ton As Double = data_.Item(key)

                        If ton <> 0 Then
                            Dim tTon As Double = Math.Round(ton, 3)
                            Dim xStr As String = hdm.ToString() & " * " & meter & "M"
                            series.Points.AddXY(xStr, ton)

                            'totalTon = totalTon + ton
                        End If
                    Next
            End Select


            Return series

        End Function

        Public Overrides Function getGraph() As MChart


            Return bChart

        End Function

        Public Overrides Function getTotalTon() As Double


        End Function


    End Class
    Public Class PieGraph : Inherits GraphFactory

        Private totalTon As Double = 0
        Private bChart As MChart

        Public Sub New(x_type As X_AXIS_TYPE, data_ As Hashtable, size_ As Size, title_ As String)

            bChart = New BasicMChart(New Chart(), size_.Width, size_.Height)
            Dim piechart As MChart = New MChartPie(bChart, createSeries(x_type, data_), "piechart")

            bChart.setTitle(title_ & " (" & getTotalTon() & ")")
            piechart.layout(15, 15, 80, 80)
            piechart.makeLegend()

        End Sub

        Public Overrides Function createSeries(x_type As X_AXIS_TYPE, data_ As Hashtable) As Series

            Dim series As New Series

            Select Case x_type
                Case X_AXIS_TYPE.HDM
                    Dim keys As List(Of String) = HashTableSort.Sort(data_)
                    For Each key As String In keys
                        Dim hdm As Double = key
                        Dim ton As Double = data_.Item(key)

                        If ton <> 0 Then
                            Dim tTon As Double = Math.Round(ton, 3)
                            Dim xStr As String = hdm.ToString()
                            series.Points.AddXY(xStr, ton)

                            totalTon = totalTon + ton
                        End If
                    Next

                Case X_AXIS_TYPE.HDM_METER
                    Dim keys As List(Of String) = HashTableSort.Sort(data_)

                    For Each key As String In keys
                        Dim values As Double() = getHdmAndMeter(key)
                        Dim hdm As Double = values(0)
                        Dim meter As Double = values(1)
                        Dim ton As Double = data_.Item(key)

                        If ton <> 0 Then
                            Dim tTon As Double = Math.Round(ton, 3)
                            Dim xStr As String = hdm.ToString() & " * " & meter
                            series.Points.AddXY(xStr, ton)

                            totalTon = totalTon + ton
                        End If
                    Next
            End Select


            Return series

        End Function

        Public Overrides Function getGraph() As MChart
            Return bChart
        End Function

        Public Overrides Function getTotalTon() As Double
            Return Math.Round(totalTon, 3)
        End Function
    End Class


    Public Class BarGraph : Inherits GraphFactory

        Private totalTon As Double = 0
        Private bChart As MChart

        Public Sub New(x_type As X_AXIS_TYPE, data_ As Hashtable, size_ As Size, title_ As String)
            bChart = New BasicMChart(New Chart(), size_.Width, size_.Height)

            Dim barchart As MChart = New MChartBar(bChart, createSeries(x_type, data_), "barchart")
            ' bChart.setTitle(title_ & " (" & getTotalTon() & ")")
            barchart.layout(15, 0, 80, 80)

        End Sub

        Public Overrides Function createSeries(x_type As X_AXIS_TYPE, data_ As Hashtable) As Series

            Dim series As New Series

            Select Case x_type
                Case X_AXIS_TYPE.HDM
                    Dim keys As List(Of String) = HashTableSort.Sort(data_)
                    For Each key As String In keys
                        Dim hdm As Double = key
                        Dim ton As Double = data_.Item(key)

                        If ton <> 0 Then
                            Dim tTon As Double = Math.Round(ton, 3)
                            Dim xStr As String = hdm.ToString()
                            series.Points.AddXY(xStr, ton)

                            totalTon = totalTon + ton
                        End If
                    Next

                Case X_AXIS_TYPE.HDM_METER
                    Dim keys As List(Of String) = HashTableSort.Sort(data_)

                    For Each key As String In keys
                        Dim values As Double() = getHdmAndMeter(key)
                        Dim hdm As Double = values(0)
                        Dim meter As Double = values(1)
                        Dim ton As Double = data_.Item(key)

                        If ton <> 0 Then
                            Dim tTon As Double = Math.Round(ton, 3)
                            Dim xStr As String = hdm.ToString() & " * " & meter & "M"
                            series.Points.AddXY(xStr, ton)

                            totalTon = totalTon + ton
                        End If
                    Next
            End Select


            Return series

        End Function

        Public Overrides Function getGraph() As MChart

            Return bChart

        End Function

        Public Overrides Function getTotalTon() As Double
            Return Math.Round(totalTon, 3)
        End Function
    End Class

End Class

