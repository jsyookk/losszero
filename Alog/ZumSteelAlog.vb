Public Class ZumSteelAlog : Implements Alog

    Dim findbar As Boolean = False
    Dim cntNUM As Integer = 0
    Dim filter As BaseChkFilter = New BaseChkFilterDefaultFactory().makeZumChkFilter
    Dim listIdx As New ArrayList

    Public Sub New()

    End Sub
    Public Function check(loss As Double) As Boolean Implements Alog.check

        'If loss <= (permitLoss * 100) Then
        '    Return True
        'Else
        '    Return False
        'End If


    End Function

    Public Function find(ByRef base As BaseData) As Boolean Implements Alog.find



    End Function
    Private Function calc(len As Integer) As Double

        Dim loneLen As Boolean = False
        Dim tempLen As Double = len * 2
        Dim useMeter As Double


        If tempLen >= 12000 Then
            useMeter = Math.Round((len / 1000) + 0.005, 1)
            cntNUM = 1
        ElseIf tempLen >= 6000 And tempLen <= 12000 Then
            cntNUM = 2
            If tempLen Mod 100 = 0 Then
                useMeter = Math.Round((tempLen / 1000), 1)
            Else
                useMeter = Math.Round((tempLen / 1000) + 0.05, 1)

            End If
        ElseIf tempLen < 6000 Then
            cntNUM = 3
            tempLen = len * 3
            If tempLen Mod 100 = 0 Then
                useMeter = Math.Round((tempLen / 1000), 1)
            Else
                useMeter = Math.Round((tempLen / 1000) + 0.05, 1)
            End If

        End If

        Return useMeter

    End Function

    Private Sub complete(base As BaseData, list As ArrayList)

        Dim useMeter As Double = calc(base.Legnth)

        Dim ste As Steel = SteelList.GetInstance().getItem(base.steIndex)
        Dim rb As RRebar = New RRebar()
        rb.type = RRebar.BAR_TYPE.ZUM_STEEL
        rb.sceneIDX = ste.sceneIDX
        rb.kongjungIDX = ste.kongjungIDX
        rb.partIDX = ste.partIDX

        rb.num = ste.Num
        rb.len = base.Legnth
        rb.displayLEN = base.DisplayLegnth
        rb.steIDX = base.steIndex
        rb.cutting = Me.cntNUM
        rb.Qty = Math.Ceiling(base.Qty / rb.cutting)
        rb.meter = useMeter
        rb.HDM = base.hdm
        rb.OQty = base.Qty

        rb.shpNUM = base.shpNUM
        rb.needTon = CalcUtils.getNeedTon(rb.HDM, rb.UseMeter, rb.Qty)

        If SettingInfo.GetInstance().LossAsTon = True Then
            rb.Loss = CalcUtils.getTonByLoss(base.Ton, rb.needTon)
        Else
            rb.Loss = CalcUtils.GetLenByLoss(rb.meter, rb.len * rb.cutting)
        End If

        rb.saveMoney = CalcUtils.getSaveMoneny(rb.HDM, rb.Loss, rb.UseMeter, rb.Qty)
        base.ProcessState = BaseData.PROCESS_STATE.COMPLETE
        RBase.GetInstance().addResult(rb)

        For Each idx As Integer In listIdx
            Dim otherbase As BaseData = list.Item(idx)
            Dim otherste As Steel = SteelList.GetInstance().getItem(otherbase.steIndex)
            Dim otherrb As RRebar = New RRebar()
            otherrb.type = RRebar.BAR_TYPE.ZUM_STEEL
            otherrb.sceneIDX = otherste.sceneIDX
            otherrb.kongjungIDX = otherste.kongjungIDX
            otherrb.partIDX = otherste.partIDX

            otherrb.num = otherste.Num
            otherrb.len = otherbase.Legnth
            otherrb.displayLEN = base.DisplayLegnth
            otherrb.steIDX = otherbase.steIndex
            otherrb.cutting = Me.cntNUM
            otherrb.Qty = Math.Ceiling(otherbase.Qty / otherrb.cutting)
            otherrb.meter = useMeter
            otherrb.HDM = otherbase.hdm
            otherrb.OQty = otherbase.Qty

            otherrb.shpNUM = base.shpNUM
            otherrb.needTon = CalcUtils.getNeedTon(otherrb.HDM, otherrb.UseMeter, otherrb.Qty)

            If SettingInfo.GetInstance().LossAsTon = True Then
                otherrb.Loss = CalcUtils.getTonByLoss(otherbase.Ton, otherrb.needTon)
            Else
                otherrb.Loss = CalcUtils.GetLenByLoss(rb.meter, rb.len * rb.cutting)
            End If

            otherrb.saveMoney = CalcUtils.getSaveMoneny(otherrb.HDM, otherrb.Loss, otherrb.UseMeter, otherrb.Qty)
            otherbase.ProcessState = BaseData.PROCESS_STATE.COMPLETE
            RBase.GetInstance().addResult(otherrb)
        Next



    End Sub
    Public Function find(ByRef base As BaseData, ByRef list As ArrayList) As Boolean Implements Alog.find

        Dim zumTon As Double = 0.0
        Dim idx As Integer = 0
        listIdx.Clear()

        If filter.filtering(base) Then
            zumTon += base.Ton
            For Each otherbase As BaseData In list
                If base.steIndex <> otherbase.steIndex Then
                    If base.Legnth = otherbase.Legnth Then
                        If filter.filtering(otherbase) = True Then
                            zumTon += otherbase.Ton
                            listIdx.Add(idx)
                        End If
                    End If

                End If
                idx += 1
            Next
        End If

        If zumTon >= SettingInfo.GetInstance().zumTON Then
            complete(base, list)
        End If


    End Function

End Class
