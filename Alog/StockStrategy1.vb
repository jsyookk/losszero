Imports Losszero

Public Class StockStrategy1
    Implements AlogStrategy

    Private lossPermit As Double = 0.0
    Public Const LossThershold As Double = 0.005

    Public Sub New(losspermit_ As Double)

        Me.lossPermit = losspermit_

    End Sub

    Public Sub exec() Implements AlogStrategy.exec

        Dim temploss As Double = 0.0

        Base.GetInstance().search(New ReBarAlogVisitor(New ZangDaeAlog(Alog.METER_CAT.STOCK_METER)))
        Base.GetInstance().search(New CombineAlogVisitor(New ZumSteelAlog()))

        Do While temploss <= lossPermit

            Base.GetInstance().search(New ReBarAlogVisitor(New CutAlog(Alog.METER_CAT.STOCK_METER, temploss, 10)))
            Base.GetInstance().search(New ReBarAlogVisitor(New CutErrorAlog(Alog.METER_CAT.STOCK_METER, temploss, 10)))
            Base.GetInstance().search(New CombineAlogVisitor(New DiffQtyMinAlog(Alog.METER_CAT.STOCK_METER, temploss, 10)))
            Base.GetInstance().search(New CombineAlogVisitor(New DiffTonMinAlog(Alog.METER_CAT.STOCK_METER, temploss, 10)))
            Base.GetInstance().search(New CombineAlogVisitor(New SubAlog(Alog.METER_CAT.STOCK_METER, temploss, 10)))

            temploss = temploss + LossThershold

        Loop


        If SettingInfo.GetInstance().remainIsOK = True Then

            temploss = 0.0

            Do While temploss <= lossPermit

                Base.GetInstance().search(New CombineAlogVisitor(New LinkedStartAlog(Alog.METER_CAT.STOCK_METER, temploss, 10)))
                temploss = temploss + LossThershold
            Loop

        End If



    End Sub

    Public Function getTotalSaveMoney() As Integer Implements AlogStrategy.getTotalSaveMoney

        Dim moneyVisitor As New TotalSaveMoneyVisitor()
        RBase.GetInstance().search(moneyVisitor)

        Return moneyVisitor.getTotalSaveMoney()


    End Function


End Class
