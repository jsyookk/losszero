Public NotInheritable Class StockList

    Enum STOCK_LEVEL
        NONE
        BAD
        WARING
        GOOD
    End Enum
    Structure stockInfo
        Public level As STOCK_LEVEL
        Public hdm As Integer
        Public meter As Double
        Public stockTon As Double
        Public diffTon As Double
        Public needTon As Double
    End Structure

    Private Shared _thisInstance As StockList = Nothing

    Private stocklist As New Collection

    Private Sub New()

    End Sub

    Public Function getList() As Collection

        Return stocklist

    End Function

    Public Sub Add(ByRef stk_ As Stock)

        stocklist.Add(stk_)

    End Sub

    Public Sub remove(idx_ As Integer)

        stocklist.Remove(idx_)

    End Sub

    Public Function compareStock(_hdm As Integer, meter_ As Double, ton_ As Double) As stockInfo

        Dim setting As SettingInfo = SettingInfo.GetInstance()
        Dim stkInfo As stockInfo

        For i = 1 To stocklist.Count
            Dim stk As Stock = Me.getItem(i)

            If stk.group = _hdm And stk.len = meter_ Then

                Dim diffton As Double = Math.Round(stk.ton - ton_, 3)

                Select Case diffton
                    Case Is < setting.step5
                        stkInfo.level = STOCK_LEVEL.BAD
                        stkInfo.hdm = _hdm
                        stkInfo.meter = meter_
                        stkInfo.stockTon = stk.ton
                        stkInfo.diffTon = diffton
                        stkInfo.needTon = ton_
                        Return stkInfo
                    Case setting.step4MIN To setting.step4MAX
                        stkInfo.level = STOCK_LEVEL.WARING
                        stkInfo.hdm = _hdm
                        stkInfo.meter = meter_
                        stkInfo.stockTon = stk.ton
                        stkInfo.diffTon = diffton
                        stkInfo.needTon = ton_
                        Return stkInfo
                    Case setting.step3MIN To setting.step3MAX
                        stkInfo.level = STOCK_LEVEL.WARING
                        stkInfo.hdm = _hdm
                        stkInfo.meter = meter_
                        stkInfo.stockTon = stk.ton
                        stkInfo.diffTon = diffton
                        stkInfo.needTon = ton_
                        Return stkInfo
                    Case setting.step2MIN To setting.step2MAX
                        stkInfo.level = STOCK_LEVEL.GOOD
                        stkInfo.hdm = _hdm
                        stkInfo.meter = meter_
                        stkInfo.stockTon = stk.ton
                        stkInfo.diffTon = diffton
                        stkInfo.needTon = ton_
                        Return stkInfo
                    Case Is > setting.step1
                        stkInfo.level = STOCK_LEVEL.GOOD
                        stkInfo.hdm = _hdm
                        stkInfo.meter = meter_
                        stkInfo.stockTon = stk.ton
                        stkInfo.diffTon = diffton
                        stkInfo.needTon = ton_
                        Return stkInfo
                End Select

            End If

        Next

        stkInfo.level = STOCK_LEVEL.NONE
        stkInfo.hdm = _hdm
        stkInfo.meter = meter_
        stkInfo.stockTon = 0
        stkInfo.diffTon = 0
        stkInfo.needTon = ton_

        Return stkInfo

        Return stkInfo

    End Function

    Public Sub edit(idx_ As Integer, meter As Double, ton As Double)

        CType(stocklist.Item(idx_), Stock).len = meter
        CType(stocklist.Item(idx_), Stock).ton = ton

    End Sub

    Public Function getItem(idx_ As Integer) As Stock

        Return stocklist.Item(idx_)

    End Function
    Public Function getHdmMeterAsTon(hdm As Integer, meter As Double) As Double

        For i = 1 To stocklist.Count
            Dim stk As Stock = Me.getItem(i)

            Dim stkhdm As Integer = stk.sd + stk.dimen

            If stkhdm = hdm And stk.len = meter Then
                Return stk.ton
            End If
        Next

    End Function
    Public Function check(sd As Integer, dimen As Integer, meter As Double) As Boolean

        For i = 1 To stocklist.Count
            Dim stk As Stock = Me.getItem(i)

            If stk.sd = sd And stk.dimen = dimen And stk.len = meter Then
                Return True
            End If
        Next

        Return False

    End Function
    Public Function count() As Long

        Return stocklist.Count

    End Function

    Public Sub clear()

        stocklist.Clear()

    End Sub

    Public Shared ReadOnly Property GetInstance As StockList

        Get
            If _thisInstance Is Nothing Then
                _thisInstance = New StockList
            End If

            Return _thisInstance
        End Get

    End Property
End Class

