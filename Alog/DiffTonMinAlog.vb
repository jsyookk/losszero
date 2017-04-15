Public Class DiffTonMinAlog : Implements Alog

    Private Structure tempInfo

        Public diffTom As Double
        Public baseCutNum As Integer
        Public otherbaseCutNum As Integer
        Public useMeter As Double
        Public otherbase As BaseData
        Public tQty As Integer
        Public baseQty As Integer
        Public otherbaseQty As Integer

    End Structure

    Dim useMeter As Double = 0.0
    Dim cntNUM As Integer = 0

    Dim mtempinfo As tempInfo
    Dim cutMaxCNT As Integer = 0
    Dim basefilter As BaseChkFilter = New BaseChkFilterDefaultFactory().makeBaseCHKFilter()
    Dim cbfilter As CBFilter = New CBDefaultFilterFactory().makeDefault()

    Dim meterWhat As Alog.METER_CAT
    Dim permitLoss As Double = 0.0
    Dim tempMinTon As Double = 0.0
    Dim findCombine As Boolean = False


    Public Sub New(meterw As Alog.METER_CAT, loss As Double, cutMax As Integer)

        Me.meterWhat = meterw
        Me.permitLoss = loss
        Me.cutMaxCNT = cutMax

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

    End Function

    Public Function find(ByRef base As BaseData, ByRef list As ArrayList) As Boolean Implements Alog.find

        Dim useMeters As Double() = SteelMeter.GetInstance().getUseMeter(meterWhat, base.hdm)

        findCombine = False
        tempMinTon = 1000

        If basefilter.filtering(base) = True Then
            For Each otherbase As BaseData In list
                If basefilter.filtering(otherbase) = True Then
                    If cbfilter.filtering(base, otherbase) = True Then
                        If calc(cutMaxCNT, useMeters, base, otherbase) = True Then

                        End If
                    End If
                End If

            Next

            If findCombine Then
                tempCheck(base, mtempinfo)
            End If

        End If

        Return findCombine


    End Function

    Private Sub tempCheck(ByRef base As BaseData, tempinfo As tempInfo)

        Dim otherbase As BaseData = tempinfo.otherbase
        Dim tQty As Integer = mtempinfo.tQty
        Dim rQty As Integer
        Dim remainLen As Integer

        Dim needTon As Double = CalcUtils.getNeedTon(base.hdm, mtempinfo.useMeter, mtempinfo.tQty)
        Dim orignalTon As Double = base.Ton + otherbase.Ton

        Dim loss As Double = CalcUtils.getTonByLoss(orignalTon, needTon)

        If tempinfo.baseQty >= tempinfo.otherbaseQty Then
            tQty = tempinfo.baseQty
            rQty = tempinfo.baseQty - tempinfo.otherbaseQty
            remainLen = (tempinfo.useMeter * 1000) - (otherbase.Legnth * tempinfo.otherbaseCutNum)
        Else
            tQty = tempinfo.otherbaseQty
            rQty = tempinfo.otherbaseQty - tempinfo.baseQty
            remainLen = (tempinfo.useMeter * 1000) - (base.Legnth * tempinfo.baseCutNum)
        End If


        If check(loss) = True Then

            Dim cb As New RCombine(RCombine.CBType.PERPECT, base.hdm, tempinfo.useMeter, orignalTon, needTon, tQty)

            '현장/공정/파트 정보
            Dim stelement1 As New RCombineSte(base, tempinfo.baseCutNum)
            Dim stelement2 As New RCombineSte(otherbase, tempinfo.otherbaseCutNum)
            Dim remain As New RCombineRemain(remainLen, rQty)

            cb.add(stelement1)
            cb.add(stelement2)

            If rQty > 0 Then
                cb.add(remain)
            End If

            cb.calc()

            If cb.saveMoney >= 5000 Then

                base.ProcessState = BaseData.PROCESS_STATE.COMPLETE
                otherbase.ProcessState = BaseData.PROCESS_STATE.COMPLETE

                '  cb.display()
                RBase.GetInstance().addResult(cb)
            End If


        End If

    End Sub

    Private Function calc(maxCNT As Integer, usemeters() As Double, base As BaseData, otherbase As BaseData) As Boolean

        Dim tempBaseQty As Integer
        Dim tempOtherBaseQty As Integer
        Dim tempDiffTon As Double


        For i = 1 To maxCNT
            For j = 1 To maxCNT
                Dim multipleLen As Integer = (base.Legnth * i) + (otherbase.Legnth * j)

                For Each usemeter As Double In usemeters
                    Dim calcMeter As Double = usemeter * 1000
                    Dim allowLen As Double = calcMeter * permitLoss
                    Dim remainLen As Integer = calcMeter - multipleLen

                    If remainLen >= 0 And remainLen <= allowLen Then
                        tempBaseQty = Math.Ceiling(base.Qty / i)
                        tempOtherBaseQty = Math.Ceiling(otherbase.Qty / j)
                        tempDiffTon = Math.Abs(base.Ton - otherbase.Ton)
                        tempSave(tempDiffTon, base, otherbase, tempBaseQty, tempOtherBaseQty, i, j, usemeter)
                    End If

                Next
            Next
        Next

        Return findCombine

    End Function

    Private Sub tempSave(diffTon As Integer, base As BaseData, otherbase As BaseData, tempBaseQty As Integer, tempOtherbaseQty As Integer, baseCutCNT As Integer, otherbaseCutCNT As Integer, meter As Double)

        If tempMinTon > diffTon Then

            tempMinTon = diffTon
            mtempinfo.baseCutNum = baseCutCNT
            mtempinfo.otherbaseCutNum = otherbaseCutCNT
            mtempinfo.useMeter = meter
            mtempinfo.otherbase = otherbase
            mtempinfo.baseQty = tempBaseQty
            mtempinfo.otherbaseQty = tempOtherbaseQty

            If tempBaseQty >= tempOtherbaseQty Then
                mtempinfo.tQty = tempBaseQty
            Else
                mtempinfo.tQty = tempOtherbaseQty
            End If

            findCombine = True

        End If

    End Sub


End Class
