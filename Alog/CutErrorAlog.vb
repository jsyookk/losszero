Imports Losszero

Public Class CutErrorAlog
    Implements Alog

    Dim findbar As Boolean = False
    Dim tempMin As Integer = 0
    Dim cutMaxCNT As Integer = 0

    Dim errLen As Integer = 0
    Dim useMeter As Double = 0.0
    Dim cntNUM As Integer = 0
    Dim filter As BaseChkFilter = New BaseChkFilterDefaultFactory().makeBaseCHKFilter()
    Dim meterWhat As Alog.METER_CAT
    Dim permitLoss As Double = 0.0
    Dim allowErrorLen As Integer = SettingInfo.GetInstance().allowErrorLen

    Public Sub New(meterw As Alog.METER_CAT, loss As Double, cutMax As Integer)

        Me.meterWhat = meterw
        Me.permitLoss = loss
        Me.cutMaxCNT = cutMax

    End Sub

    Public Function check(loss As Double) As Boolean Implements Alog.check


        Dim ploss As Double = SettingInfo.GetInstance().barLoosPermit

        If loss <= (ploss * 100) Then
            Return True
        Else
            Return False
        End If


    End Function

    Public Function find(ByRef base As BaseData) As Boolean Implements Alog.find


        Dim useMeters As Double() = SteelMeter.GetInstance().getUseMeter(meterWhat, base.hdm)

        If filter.filtering(base) = True Then
            Dim minusLen As Integer = isAllowErrorRange(base.Legnth)

            If minusLen <> 0 Then
                If calc(minusLen, cutMaxCNT, base.Legnth, useMeters) = True Then
                    Dim ste As Steel = SteelList.GetInstance.getItem(base.steIndex)
                    Dim rb As RRebar = New RRebar()
                    rb.place = Place.GetInstance().getMyName(ste.kongjungIDX)

                    rb.sceneIDX = ste.sceneIDX
                    rb.kongjungIDX = ste.kongjungIDX
                    rb.partIDX = ste.partIDX

                    rb.num = ste.Num
                    rb.len = base.Legnth - errLen
                    rb.displayLEN = base.DisplayLegnth
                    rb.steIDX = base.steIndex
                    rb.Qty = Math.Ceiling(base.Qty / cntNUM)
                    rb.UseMeter = useMeter
                    rb.HDM = base.hdm
                    rb.needTon = CalcUtils.getNeedTon(rb.HDM, rb.UseMeter, rb.Qty)

                    rb.cutting = cntNUM
                    rb.OQty = base.Qty
                    rb.shpNUM = base.shpNUM
                    rb.errorLEN = errLen
                    rb.type = RRebar.BAR_TYPE.ERROR_NORMAL
                    rb.OrignalTon = base.getTon()


                    '톤 수 기준 로스
                    Dim temploss As Double = 0.0

                    If SettingInfo.GetInstance().LossAsTon = True Then
                        temploss = CalcUtils.getTonByLoss(rb.OrignalTon, rb.needTon)
                    Else
                        temploss = CalcUtils.getLenByLoss(rb.meter, rb.len * rb.cutting)
                    End If


                    If check(temploss) = True Then
                        base.ProcessState = BaseData.PROCESS_STATE.COMPLETE
                        rb.Loss = temploss
                        rb.saveMoney = CalcUtils.getSaveMoneny(rb.HDM, rb.Loss, rb.UseMeter, rb.Qty)
                        RBase.GetInstance().addResult(rb)
                    End If
                End If
            End If


        End If

    End Function
    Private Function isAllowErrorRange(ByVal len As Integer) As Integer

        Dim modLen As Integer = Math.Truncate(len / 100) * 100
        Dim errLen As Integer = len Mod modLen

        If errLen <> 0 And errLen <= allowErrorLen Then
            Return errLen
        Else
            Return 0
        End If

    End Function
    Private Function apply(_len As Integer, _m As Double, _cut As Integer, _error As Integer) As Integer

        If _len < tempMin Then

            tempMin = _len
            cntNUM = _cut
            useMeter = _m
            errLen = _error
            findbar = True

        End If

        Return 0

    End Function
    Private Function calc(minusLen As Integer, _multiple As Integer, Len As Integer, meter As Double()) As Boolean

        tempMin = 10000
        findbar = False


        Dim cutNum As Integer = 1

        Do While cutNum <= _multiple

            Dim multipleLen As Integer = (Len - minusLen) * cutNum
            For Each usemeter As Double In meter

                Dim calcMeter As Double = usemeter * 1000
                Dim allowLen As Double = calcMeter * Me.permitLoss
                Dim remainLen As Integer = calcMeter - multipleLen

                If remainLen >= 0 And remainLen <= allowLen Then
                    apply(remainLen, usemeter, cutNum, minusLen)
                End If

            Next
            cutNum = cutNum + 1
        Loop

        Return findbar

    End Function
    Public Function find(ByRef base As BaseData, ByRef list As ArrayList) As Boolean Implements Alog.find

    End Function
End Class
