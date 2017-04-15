Public Class SteelMeter
    Private Shared _thisInstance As SteelMeter = Nothing

    Private Shared ReadOnly stockMeter As New Dictionary(Of Integer, Double())
    Private Shared ReadOnly standardMeter As New Dictionary(Of Integer, Double())
    Private standardM As Double() = {8, 9, 10, 11, 12}
    Private standardweekSDM As Double() = {8}

    Private Sub New()

        init()

    End Sub

    Public Sub init()

        For Each hdm As Integer In Base.GetInstance()._HDMLIST

            Dim lenarr As New ArrayList

            For Each st As Stock In StockList.GetInstance().getList()

                If st.group = hdm Then
                    lenarr.Add(st.len)
                End If

            Next

            Dim lens As Double() = CType(lenarr.ToArray(GetType(Double)), Double())
            stockMeter.Add(hdm, lens)
        Next

        For Each hdm As Integer In Base.GetInstance()._HDMLIST

            Select Case hdm
                Case 410, 413, 510, 513
                    standardMeter.Add(hdm, standardweekSDM)
                Case Else
                    standardMeter.Add(hdm, standardM)
            End Select
            Dim lens As Double() = standardMeter.Item(hdm)

        Next


    End Sub

    Public Sub initStockMeter()

        stockMeter.Clear()

        For Each hdm As Integer In Base.GetInstance()._HDMLIST

            Dim lenarr As New ArrayList

            For Each st As Stock In StockList.GetInstance().getList()

                If st.group = hdm Then
                    lenarr.Add(st.len)
                End If

            Next

            Dim lens As Double() = CType(lenarr.ToArray(GetType(Double)), Double())
            stockMeter.Add(hdm, lens)
        Next

    End Sub

    Public Function getStockMeter(hdm_ As Integer) As Double()

        Dim arrlen As Double()

        If stockMeter.ContainsKey(hdm_) Then

            arrlen = stockMeter.Item(hdm_)
            Return arrlen

        End If

        Return Nothing

    End Function

    Public Function getStandardMeter(hdm_ As Integer) As Double()

        Dim arrlen As Double()

        If standardMeter.ContainsKey(hdm_) Then

            arrlen = standardMeter.Item(hdm_)
            Return arrlen

        End If

        Return Nothing

    End Function
    Public Function getUseMeter(what As Alog.METER_CAT, hdm As Integer) As Double()

        Dim meters() As Double = Nothing

        If what = Alog.METER_CAT.STANDARD_METER Then
            meters = getStandardMeter(hdm)
        ElseIf what = Alog.METER_CAT.STOCK_METER Then
            meters = getStockMeter(hdm)
        End If

        Return meters

    End Function
    Public Shared ReadOnly Property GetInstance As SteelMeter

        Get
            If _thisInstance Is Nothing Then
                _thisInstance = New SteelMeter
            End If

            Return _thisInstance
        End Get

    End Property


End Class
