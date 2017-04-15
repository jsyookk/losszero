Imports Losszero

Public Class LinkedPerfact : Implements DetailStrategy

    Private Structure tempInfo

        Public diffQty As Integer
        Public baseCutNum As Integer
        Public otherbaseCutNum As Integer
        Public useMeter As Double
        Public otherbase As BaseData
        Public tQty As Integer
        Public baseQty As Integer
        Public otherbaseQty As Integer

    End Structure

    Private otherbaseFilter As BaseChkFilter = New BaseChkFilterDefaultFactory().makeBaseCHKFilter()
    Private useMeter As Double
    Private useMetermm As Double
    Private cbFilter As CBFilter
    Private permitLoss As Double
    Private rc As RCombine
    Private maxCNT As Integer
    Private tempMinTon As Double = 10000
    Dim mtempInfo As tempInfo
    Private findCombine As Boolean = False
    Private Shared result As Boolean = False


    Public Sub New(meter As Double, rc As RCombine, cb As CBFilter, loss As Double, cutmax As Integer)

        Me.useMeter = meter
        Me.useMetermm = useMeter * 1000
        Me.cbFilter = cb
        Me.permitLoss = loss
        Me.rc = rc
        Me.maxCNT = cutmax

        result = False

    End Sub
    Public Function QtyCheck(base As BaseData) As Boolean

        If base.Qty <= 0 Then

            rc.calc()
            Dim loss As Double = rc.Loss

            If checkLoss(loss) = True Then

                If rc.saveMoney >= 10000 Then
                    RBase.GetInstance().addResult(rc)
                    Return True
                Else
                    Return False
                End If

            Else
                Return False
            End If
        End If

    End Function
    Public Function escapeCondition(base As BaseData) As Boolean

        rc.calc()
        Dim loss As Double = rc.Loss

        If base.Ton > rc.needTon Then
            Return False
        End If

        If checkLoss(loss) = True Then

            If rc.saveMoney >= 10000 Then
                If base.Qty > 0 Then
                    Dim remain As New RCombineRemainSteel(base, base.Qty)
                    rc.add(remain)
                End If

                RBase.GetInstance().addResult(rc)
                Return True
            Else
                Return False
            End If

        Else
            Return False
        End If

        'Dim lnkcnt As Integer = 0

        'For Each rlnk As RCombineElement In rc.getList()
        '    If rlnk.GetType().FullName = "Losszero.RCombineLink" Then
        '        lnkcnt += 1
        '    End If
        'Next

        'If lnkcnt >= 2 Then
        '    Dim loss As Double = rc.Loss

        '    If checkLoss(loss) = True Then

        '        If base.Qty > 0 Then
        '            Dim remain As New RCombineRemainSteel(base, base.Qty)
        '            rc.add(remain)
        '        End If

        '        RBase.GetInstance().addResult(rc)
        '        Return True
        '    Else
        '        Return False
        '    End If
        'Else
        '    Return False
        'End If

    End Function
    Private Function createNewBase(base As BaseData, tempi As tempInfo) As BaseData

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

        Dim partlossLen As Integer = (tempi.useMeter * 1000) - ((base.Legnth * tempi.baseCutNum) + (otherbase.Legnth * tempi.otherbaseCutNum))


        Dim link As New RCombineLink(newbase.hdm, tempi.useMeter, useQty, partlossLen)
        link.add(New RCombineSte(base, tempi.baseCutNum))
        link.add(New RCombineSte(otherbase, tempi.otherbaseCutNum))
        rc.add(link)

        newbase.Qty = newbaseQty
        newbase.Ton = CalcUtils.getNeedTonMM(newbase.hdm, newbase.Legnth, newbase.Qty)

        base.ProcessState = BaseData.PROCESS_STATE.PROCESSING
        otherbase.ProcessState = BaseData.PROCESS_STATE.PROCESSING
        newbase.BaseState = BaseData.BASE_STATE.TEMP

        Return newbase

    End Function
    Private Function checkLoss(loss As Double) As Boolean

        Dim ploss As Double = SettingInfo.GetInstance().LossPermit

        If loss <= (ploss * 100) Then
            Return True
        Else
            Return False
        End If

    End Function
    Private Function calc(base As BaseData, otherbase As BaseData)

        Dim tempBaseQty As Integer
        Dim tempOtherBaseQty As Integer
        Dim tempTon As Integer

        For i = 1 To maxCNT
            For j = 1 To maxCNT

                Dim multipleLen As Integer = (base.Legnth * i) + (otherbase.Legnth * j)
                Dim allowLen As Double = useMetermm * permitLoss
                Dim remainLen As Integer = useMetermm - multipleLen

                If remainLen >= 0 And remainLen <= allowLen Then

                    tempBaseQty = Math.Ceiling(base.Qty / i)
                    tempOtherBaseQty = Math.Ceiling(otherbase.Qty / j)
                    tempTon = Math.Abs(base.Ton - otherbase.Ton)
                    tempSave(tempTon, base, otherbase, tempBaseQty, tempOtherBaseQty, i, j, useMeter)

                End If
            Next
        Next

        Return findcombine


    End Function
    Private Sub tempSave(tempQty As Integer, base As BaseData, otherbase As BaseData, tempBaseQty As Integer, tempOtherbaseQty As Integer, baseCutCNT As Integer, otherbaseCutCNT As Integer, meter As Double)

        If tempMinTon > tempQty Then

            tempMinTon = tempQty
            mtempInfo.baseCutNum = baseCutCNT
            mtempInfo.otherbaseCutNum = otherbaseCutCNT
            mtempInfo.useMeter = meter
            mtempInfo.otherbase = otherbase
            mtempInfo.baseQty = tempBaseQty
            mtempInfo.otherbaseQty = tempOtherbaseQty

            If tempBaseQty >= tempOtherbaseQty Then
                mtempInfo.tQty = tempBaseQty
            Else
                mtempInfo.tQty = tempOtherbaseQty
            End If

            findCombine = True

        End If

    End Sub

    Public Function find(base As BaseData, ByRef list As ArrayList) As Boolean Implements DetailStrategy.find

        tempMinTon = 1000
        findCombine = False

        If result = True Then
            Return True
        End If

        If QtyCheck(base) = True Then
            For Each d As BaseData In list

                If d.ProcessState = BaseData.PROCESS_STATE.PROCESSING Then
                    d.ProcessState = BaseData.PROCESS_STATE.COMPLETE
                End If

            Next

            result = True
            Return True
        End If


        If base.BaseState = BaseData.BASE_STATE.TEMP Then

            For Each otherbase As BaseData In list
                If otherbaseFilter.filtering(otherbase) = True Then
                    If cbFilter.filtering(base, otherbase) = True Then
                        calc(base, otherbase)
                    End If
                End If
            Next

            If findCombine = True Then
                Dim newbase As BaseData = createNewBase(base, mtempInfo)
                Me.find(newbase, list)
            Else
                '  Dim newbase As BaseData = createNewBase(base, mtempInfo)
                If escapeCondition(base) = True Then

                    For Each d As BaseData In list

                        If d.ProcessState = BaseData.PROCESS_STATE.PROCESSING Then
                            d.ProcessState = BaseData.PROCESS_STATE.COMPLETE
                        End If

                    Next

                    result = True
                    Return True
                Else
                    For Each d As BaseData In list

                        If d.ProcessState = BaseData.PROCESS_STATE.PROCESSING Then
                            d.ProcessState = BaseData.PROCESS_STATE.NONE
                        End If
                    Next
                    result = False
                    Return False

                End If
            End If
        End If

        Return result

    End Function

    Public Sub complete() Implements DetailStrategy.complete

    End Sub
    Public Function totalSaveMoney() As Integer Implements DetailStrategy.totalSaveMoney


    End Function

End Class
