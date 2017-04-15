Imports Losszero

Public Class ZangDaeAlog : Implements Alog

    Dim findbar As Boolean = False
    Dim useMeter As Double = 0.0
    Dim cntNUM As Integer = 0
    Dim filter As BaseChkFilter = New BaseChkFilterDefaultFactory().makeZangDaeCHKFilter()
    Dim meterWhat As Alog.METER_CAT


    Public Sub New(meterw As Alog.METER_CAT)

        Me.meterWhat = meterw

    End Sub
    Public Function check(loss As Double) As Boolean Implements Alog.check

        Dim ploss As Double = SettingInfo.GetInstance().LossPermit

        If loss <= (ploss * 100) Then
            Return True
        Else
            Return False
        End If


    End Function

    Public Function find(ByRef base As BaseData) As Boolean Implements Alog.find

        Dim useMeters As Double() = SteelMeter.GetInstance().getUseMeter(meterWhat, base.hdm)

        If filter.filtering(base) = True Then
            If calc(base.DisplayLegnth, useMeters) = True Then
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
                rb.Qty = ste.Qty
                rb.UseMeter = Me.useMeter
                rb.cutting = 0
                rb.OQty = base.Qty
                rb.shpNUM = base.shpNUM
                rb.OrignalTon = base.getTon()
                rb.needTon = CalcUtils.getNeedTon(rb.HDM, rb.UseMeter, rb.Qty)

                If SettingInfo.GetInstance().LossAsTon = True Then
                    rb.Loss = CalcUtils.getTonByLoss(rb.OrignalTon, rb.needTon)
                Else
                    rb.Loss = 0
                End If

                If check(rb.Loss) = True Then

                    If SettingInfo.GetInstance().zangDaeExcept <> True Then
                        rb.saveMoney = CalcUtils.getSaveMoneny(rb.HDM, rb.Loss, rb.UseMeter, rb.Qty)
                    End If

                    base.ProcessState = BaseData.PROCESS_STATE.COMPLETE

                    If rb.shpNUM = 1 Then
                        rb.type = RRebar.BAR_TYPE.ZANGDAE
                    ElseIf rb.shpNUM = 2 Or rb.shpNUM = 97 Then
                        rb.type = RRebar.BAR_TYPE.ANGKA_ZANGDAE
                    End If

                    RBase.GetInstance().addResult(rb)


                End If

            End If
        End If

    End Function
    Private Function calc(len As Integer, meters As Double()) As Boolean

        findbar = False

        For Each usemeter As Double In meters

            Dim calcMeter As Double = usemeter * 1000
            Dim remainLen As Integer = calcMeter - len

            If remainLen = 0 Then
                findbar = True
                Me.useMeter = usemeter
            End If

        Next

        Return findbar




    End Function

    Public Function find(ByRef base As BaseData, ByRef list As ArrayList) As Boolean Implements Alog.find



    End Function

End Class
