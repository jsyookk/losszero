Imports Losszero

Public Class LinkedStartAlog : Implements Alog

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
    Dim basefilter As BaseChkFilter = New BaseChkFilterDefaultFactory().makeBaseCHKFilter()
    Dim otherbasefilter As BaseChkFilter = New BaseChkFilterDefaultFactory().makeBaseCHKFilter()
    Dim cbfilter As CBFilter = New CBDefaultFilterFactory().makeDefault()
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

    Private Sub startLinked(base As BaseData, tempi As tempInfo)

        Dim newbase As New BaseData
        Dim otherbase As BaseData = tempi.otherbase
        Dim tempBaseQty As Integer = Math.Ceiling(base.Qty / tempi.baseCutNum)
        Dim tempOtherBaseQty As Integer = Math.Ceiling(otherbase.Qty / tempi.otherbaseCutNum)
        Dim useQty As Integer
        Dim newbaseQty As Integer

        If tempBaseQty > tempOtherBaseQty Then
            useQty = tempOtherBaseQty
            newbaseQty = base.Qty - (useQty * tempi.baseCutNum)
            newbase = base.Clone()
        Else
            useQty = tempBaseQty
            newbaseQty = otherbase.Qty - (useQty * tempi.otherbaseCutNum)
            newbase = otherbase.Clone()
        End If

        newbase.Qty = newbaseQty
        newbase.Ton = CalcUtils.getNeedTonMM(newbase.hdm, newbase.Legnth, newbase.Qty)

        Dim partlossLen As Integer = (tempi.useMeter * 1000) - ((base.Legnth * tempi.baseCutNum) + (otherbase.Legnth * tempi.otherbaseCutNum))

        Dim cb As New RCombine(RCombine.CBType.LINKED, newbase.hdm, tempi.useMeter)

        cb.sceneIDX = base.sceneIdx
        cb.kongjungIDX = base.kongjungIdx
        cb.partIDX = base.partIdx

        Dim link As New RCombineLink(newbase.hdm, tempi.useMeter, useQty, partlossLen)
        link.add(New RCombineSte(base, tempi.baseCutNum))
        link.add(New RCombineSte(otherbase, tempi.otherbaseCutNum))
        cb.add(link)

        base.ProcessState = BaseData.PROCESS_STATE.PROCESSING
        otherbase.ProcessState = BaseData.PROCESS_STATE.PROCESSING
        newbase.BaseState = BaseData.BASE_STATE.TEMP

        Dim pertfactStrategy As New LinkedPerfact(tempi.useMeter, cb, Me.cbfilter, Me.permitLoss, cutMaxCNT)
        pertfactStrategy.find(newbase, arlist)



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
                startLinked(base, mtempInfo)
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
