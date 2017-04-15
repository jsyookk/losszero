Imports Losszero

Public Class SubAlog
    Implements Alog


    Private Structure tempInfo

        Public diffTon As Double
        Public baseCutNum As Integer
        Public otherbaseCutNum As Integer
        Public useMeter As Double
        Public otherbase As BaseData
        Public tQty As Integer

    End Structure

    Dim cutMaxCNT As Integer = 0
    Dim meterWhat As Alog.METER_CAT
    Dim permitLoss As Double = 0.0
    Dim basefilter As BaseChkFilter = New BaseChkFilterDefaultFactory().makeBaseTonManyFilter()
    Dim otherbasefilter As BaseChkFilter = New BaseChkFilterDefaultFactory().makeNonBaseCHKFilter()
    Dim cbfilter As CBFilter = New CBDefaultFilterFactory().makeTonSubFilter()
    Dim findcombine As Boolean = False
    Dim tempMinTon As Double = 1000
    Dim mtempInfo As tempInfo
    Dim arlist As ArrayList

    Public Sub New(meterw As Alog.METER_CAT, loss As Double, cutMax As Integer)

        Me.meterWhat = meterw
        Me.permitLoss = loss
        Me.cutMaxCNT = cutMax

    End Sub
    Public Function check(loss As Double) As Boolean Implements Alog.check

    End Function

    Private Sub startRemain(base As BaseData, tempi As tempInfo)

        Dim otherbase As BaseData = tempi.otherbase
        Dim tempBaseQty As Integer = Math.Ceiling(base.Qty / tempi.baseCutNum)
        Dim tempOtherBaseQty As Integer = Math.Ceiling(otherbase.Qty / tempi.otherbaseCutNum)
        Dim tQty As Integer
        Dim rQty As Integer


        If tempBaseQty >= tempOtherBaseQty Then
            tQty = tempBaseQty
            rQty = tempBaseQty - tempOtherBaseQty
        Else
            tQty = tempOtherBaseQty
            rQty = tempOtherBaseQty - tempBaseQty
        End If

        Dim rLen As Integer = (tempi.useMeter * 1000) - (base.Legnth * tempi.baseCutNum)

        Dim remainbase As New BaseData

        remainbase = base.Clone()
        remainbase.BaseState = BaseData.BASE_STATE.TEMP
        remainbase.Legnth = rLen
        remainbase.Qty = rQty
        remainbase.Ton = CalcUtils.getNeedTonMM(remainbase.hdm, remainbase.Legnth, remainbase.Qty)

        Dim cb As New RCombine(RCombine.CBType.REMAIN_CUT, base.hdm, tempi.useMeter, tQty)
        cb.sceneIDX = base.sceneIdx
        cb.kongjungIDX = base.kongjungIdx
        cb.partIDX = base.partIdx
        Dim ste1 As New RCombineSte(base, tempi.baseCutNum)
        Dim ste2 As New RCombineSte(otherbase, tempi.otherbaseCutNum)
        Dim remain As New RCombineRemain(remainbase.Legnth, remainbase.Qty)

        cb.add(ste1)
        cb.add(ste2)
        cb.add(remain)

        base.ProcessState = BaseData.PROCESS_STATE.PROCESSING
        otherbase.ProcessState = BaseData.PROCESS_STATE.PROCESSING

        Dim tempneddTon As Double = CalcUtils.getNeedTon(base.hdm, tempi.useMeter, tQty)
        Dim tempOrignalTon As Double = base.Ton + otherbase.Ton

        Dim remainsub As New RemainSubTon(remainbase, cutMaxCNT, permitLoss, tempneddTon, tempOrignalTon, cb, remain)
        If remainsub.find(remainbase, arlist) = True Then
            base.ProcessState = BaseData.PROCESS_STATE.COMPLETE
            otherbase.ProcessState = BaseData.PROCESS_STATE.COMPLETE
        Else
            base.ProcessState = BaseData.PROCESS_STATE.NONE
            otherbase.ProcessState = BaseData.PROCESS_STATE.NONE

        End If

    End Sub

    Public Function find(ByRef base As BaseData) As Boolean Implements Alog.find


    End Function

    Public Function find(ByRef base As BaseData, ByRef list As ArrayList) As Boolean Implements Alog.find

        arlist = list


        Dim useMeters As Double() = SteelMeter.GetInstance().getUseMeter(meterWhat, base.hdm)

        tempMinTon = 1000
        findcombine = False

        If basefilter.filtering(base) = True Then

            For Each otherbase As BaseData In list
                If otherbasefilter.filtering(otherbase) = True Then
                    If cbfilter.filtering(base, otherbase) = True Then
                        calc(cutMaxCNT, base, otherbase, useMeters)
                    End If
                End If

            Next

            If findcombine = True Then
                startRemain(base, mtempInfo)
            End If
        End If

    End Function

    Private Function calc(multiple As Integer, base As BaseData, otherbase As BaseData, usemeters() As Double) As Boolean


        Dim tempBaseQty As Integer
        Dim tempOtherBaseQty As Integer
        Dim tempTon As Double

        For i = 1 To multiple
            For j = 1 To multiple

                Dim multipleLen As Integer = (base.Legnth * i) + (otherbase.Legnth * j)

                For Each usemeter As Double In usemeters
                    Dim calcMeter As Double = usemeter * 1000
                    Dim allowLen As Double = calcMeter * permitLoss
                    Dim remainLen As Integer = calcMeter - multipleLen

                    If remainLen >= 0 And remainLen <= allowLen Then

                        tempBaseQty = Math.Ceiling(base.Qty / i)
                        tempOtherBaseQty = Math.Ceiling(otherbase.Qty / j)
                        tempTon = Math.Abs(base.Ton - otherbase.Ton)
                        tempSave(tempTon, base, otherbase, tempBaseQty, tempOtherBaseQty, i, j, usemeter)

                    End If
                Next
            Next
        Next

        Return findcombine


    End Function


    Private Sub tempSave(diffTon As Double, base As BaseData, otherbase As BaseData, tempBaseQty As Integer, tempOtherbaseQty As Integer, baseCutCNT As Integer, otherbaseCutCNT As Integer, meter As Double)

        If tempMinTon > diffTon Then

            tempMinTon = diffTon
            mtempInfo.baseCutNum = baseCutCNT
            mtempInfo.otherbaseCutNum = otherbaseCutCNT
            mtempInfo.useMeter = meter
            mtempInfo.otherbase = otherbase

            If tempBaseQty >= tempOtherbaseQty Then
                mtempInfo.tQty = tempBaseQty
            Else
                mtempInfo.tQty = tempOtherbaseQty
            End If

            findcombine = True

        End If

    End Sub


End Class
