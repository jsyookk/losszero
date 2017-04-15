Imports Losszero

Public Class CutAlog
    Implements Alog

    Dim findbar As Boolean = False
    Dim tempMin As Integer = 0
    Dim cutMaxCNT As Integer = 0

    Dim useMeter As Double = 0.0
    Dim cntNUM As Integer = 0
    Dim filter As BaseChkFilter = New BaseChkFilterDefaultFactory().makeBaseCHKFilter()
    Dim meterWhat As Alog.METER_CAT
    Dim permitLoss As Double = 0.0


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
            If calc(base.Legnth, useMeters) = True Then
                Dim ste As Steel = SteelList.GetInstance().getItem((base.steIndex))

                Dim rb As RRebar = New RRebar()

                rb.sceneIDX = ste.sceneIDX
                rb.kongjungIDX = ste.kongjungIDX
                rb.partIDX = ste.partIDX
                rb.HDM = base.hdm

                rb.num = ste.Num
                rb.len = base.Legnth
                rb.displayLEN = base.DisplayLegnth
                rb.steIDX = base.steIndex
                rb.Qty = Math.Ceiling(base.Qty / cntNUM)
                rb.UseMeter = useMeter
                rb.cutting = cntNUM
                rb.OQty = base.Qty
                rb.shpNUM = base.shpNUM
                rb.OrignalTon = base.getTon()
                rb.needTon = CalcUtils.getNeedTon(rb.HDM, rb.UseMeter, rb.Qty)

                If SettingInfo.GetInstance().LossAsTon = True Then
                    rb.Loss = CalcUtils.getTonByLoss(rb.OrignalTon, rb.needTon)
                Else
                    rb.Loss = CalcUtils.GetLenByLoss(rb.meter, rb.len * rb.cutting)
                End If

                If check(rb.loss) = True Then

                    rb.type = RRebar.BAR_TYPE.NORMARL
                    rb.saveMoney = CalcUtils.getSaveMoneny(rb.HDM, rb.Loss, rb.UseMeter, rb.Qty)
                    base.ProcessState = BaseData.PROCESS_STATE.COMPLETE
                    RBase.GetInstance().addResult(rb)
                End If

            End If
        End If



    End Function
    Private Function calc(len As Integer, meters As Double()) As Boolean

        tempMin = 10000
        findbar = False

        Dim cutting As Integer = 1

        Do While cutting <= cutMaxCNT
            Dim cutlen As Integer = len * cutting

            For Each meter As Double In meters

                Dim meterPer As Double = meter * 1000
                Dim allowLen As Double = meterPer * permitLoss
                Dim remainLen As Double = meterPer - cutlen

                If remainLen >= 0 And remainLen <= allowLen Then
                    If remainLen < tempMin Then
                        tempMin = remainLen
                        useMeter = meter
                        cntNUM = cutting
                        findbar = True
                    End If
                End If
            Next

            cutting += 1
        Loop

        Return findbar



    End Function

    Public Function find(ByRef base As BaseData, ByRef list As ArrayList) As Boolean Implements Alog.find



    End Function


End Class
