Imports Losszero

Public Class StockStrategy1
    Implements AlogStrategy

    Private barPermitLoss As Double = 0.0
    Private cbPermitLoss As Double = 0.0
    Public Const LossThershold As Double = 0.005

    Public Sub New(barloss As Double, cbloss As Double)

        Me.barPermitLoss = barloss
        Me.cbPermitLoss = cbloss

    End Sub

    Public Sub exec() Implements AlogStrategy.exec

        Dim tempBarloss As Double = 0.0
        Dim tempCbloss As Double = 0.0

        Base.GetInstance().search(New CombineAlogVisitor(New ZumSteelAlog()))

        Do While tempBarloss <= barPermitLoss

            Base.GetInstance().search(New ReBarAlogVisitor(New ZangDaeAlog(Alog.METER_CAT.STOCK_METER, tempBarloss)))
            Base.GetInstance().search(New ReBarAlogVisitor(New CutAlog(Alog.METER_CAT.STOCK_METER, tempBarloss, 10)))
            Base.GetInstance().search(New ReBarAlogVisitor(New CutErrorAlog(Alog.METER_CAT.STOCK_METER, tempBarloss, 10)))

            tempBarloss = tempBarloss + LossThershold

        Loop


        Do While tempCbloss <= cbPermitLoss


            Base.GetInstance().search(New CombineAlogVisitor(New DiffQtyMinAlog(Alog.METER_CAT.STOCK_METER, tempCbloss, 10)))
            Base.GetInstance().search(New CombineAlogVisitor(New DiffTonMinAlog(Alog.METER_CAT.STOCK_METER, tempCbloss, 10)))
            Base.GetInstance().search(New CombineAlogVisitor(New SubAlog(Alog.METER_CAT.STOCK_METER, tempCbloss, 10)))
            tempCbloss = tempCbloss + LossThershold

        Loop

        If SettingInfo.GetInstance().remainIsOK = True Then

            tempCbloss = 0.0

            Do While tempCbloss <= cbPermitLoss

                Base.GetInstance().search(New CombineAlogVisitor(New LinkedStartAlog(Alog.METER_CAT.STOCK_METER, tempCbloss, 10)))
                tempCbloss = tempCbloss + LossThershold
            Loop

        End If



    End Sub

    Public Function getTotalSaveMoney() As Integer Implements AlogStrategy.getTotalSaveMoney

        Dim moneyVisitor As New TotalSaveMoneyVisitor()
        RBase.GetInstance().search(moneyVisitor)

        Return moneyVisitor.getTotalSaveMoney()


    End Function


End Class
