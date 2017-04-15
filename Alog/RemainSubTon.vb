Imports Losszero

Public Class RemainSubTon : Implements DetailStrategy

    Dim tlength As Integer
    Dim orignalTon As Double
    Dim mneedTon As Double
    Dim tTon As Double
    Dim tQty As Integer
    Dim cutMax As Integer = 10
    Dim permitLoss As Double
    Dim permitLen As Integer
    Dim tempList As New List(Of CombineBarMember)()
    Dim matchingIDXs As New ArrayList
    Dim rc As RCombine
    Dim rl As RCombineRemain
    Dim arrlist As ArrayList
    Dim based As BaseData
    Dim basefilter As BaseChkFilter = New BaseChkFilterDefaultFactory().makeNonBaseCHKFilter()
    Dim cbfilter As CBFilter = New CBDefaultFilterFactory().makeTonSubFilter()

    Public Class CombineBarMember
        Implements IComparable(Of CombineBarMember)

        Public otherbase As BaseData
        Public mNum As Integer
        Public mLen As Integer
        Public mQty As Integer
        Public mTon As Double
        Public mcut As Integer
        Public msteIDX As Long
        Public Function CompareTo(other As CombineBarMember) As Integer Implements IComparable(Of CombineBarMember).CompareTo
            If mTon = other.mTon Then
                Return 0
            Else
                If mTon < other.mTon Then
                    Return 1
                Else
                    Return -1
                End If
            End If
        End Function
    End Class

    Public Sub New(base As BaseData, cutCnt As Integer, ploss As Double, needTon As Double, oTon As Double, rc As RCombine, rl As RCombineRemain)

        Me.based = base
        Me.cutMax = cutCnt
        Me.permitLoss = ploss
        Me.permitLen = base.Legnth * permitLoss

        Me.mneedTon = needTon
        Me.orignalTon = oTon

        Me.rc = rc
        Me.rl = rl
        Me.tlength = base.Legnth
        Me.tQty = base.Qty
        Me.tTon = base.Ton


    End Sub

    Private Function calc(len As Integer, otherbase As BaseData) As Boolean

        Dim multipleLen As Integer
        Dim remainLen As Integer

        For i = 1 To cutMax
            multipleLen = otherbase.Legnth * i
            remainLen = len - multipleLen

            If remainLen >= 0 And remainLen <= permitLen Then

                otherbase.ProcessState = BaseData.PROCESS_STATE.PROCESSING

                Dim tcb As New CombineBarMember
                tcb.otherbase = otherbase
                tcb.msteIDX = otherbase.steIndex
                tcb.mQty = Math.Ceiling(otherbase.Qty / i)
                tcb.mLen = otherbase.Legnth
                tcb.mcut = i
                tcb.mTon = otherbase.Ton

                tempList.Add(tcb)
                Return True
            End If
        Next


    End Function
    Private Function check() As Boolean

        Dim tempOrignallTon As Double = Me.orignalTon
        Dim rTon As Double = Me.tTon
        Dim rQty As Integer = Me.tQty
        Dim aQty As Integer

        tempList.Sort()

        Dim tebIdx As Integer = 0

        For Each teb As CombineBarMember In tempList
            rTon = rTon - teb.mTon
            rQty = rQty - teb.mQty

            If rQty >= 0 Then
                matchingIDXs.Add(tebIdx)
            Else
                rQty = rQty + teb.mQty
            End If
            tebIdx += 1
        Next

        For Each idx As Integer In matchingIDXs

            Dim teb As CombineBarMember = tempList.Item(idx)
            aQty += teb.mQty
            tempOrignallTon += teb.mTon

        Next

        Dim tempLoss As Double = CalcUtils.getTonByLoss(tempOrignallTon, mneedTon)

        If checkLoss(tempLoss) Then

            For Each idx As Integer In matchingIDXs

                Dim teb As CombineBarMember = tempList.Item(idx)
                Dim otherbase As BaseData = teb.otherbase
                otherbase.ProcessState = BaseData.PROCESS_STATE.COMPLETE

                Dim ste As New RCombineSte(otherbase, teb.mcut)
                rl.add(ste)
            Next

            Dim remainsteel As New BaseData

            remainsteel = based.Clone()
            remainsteel.Qty = tQty - aQty

            Dim remain As New RCombineRemainSteel(remainsteel, remainsteel.Qty)
            rl.add(remain)
            rc.calc()

            RBase.GetInstance().addResult(rc)
            Return True
        Else

            For Each data As BaseData In arrlist
                If data.ProcessState = BaseData.PROCESS_STATE.PROCESSING Then
                    data.ProcessState = BaseData.PROCESS_STATE.NONE
                End If

            Next

            Return False
        End If


    End Function
    Public Function find(base As BaseData, ByRef list As ArrayList) As Boolean Implements DetailStrategy.find

        arrlist = list
        tempList.Clear()
        matchingIDXs.Clear()

        For Each otherbase As BaseData In list
            If basefilter.filtering(otherbase) = True Then
                If cbfilter.filtering(base, otherbase) = True Then
                    calc(tlength, otherbase)
                End If
            End If

        Next

        If check() = True Then
            Return True
        Else
            Return False
        End If

    End Function

    Public Function checkLoss(loss As Double) As Boolean

        Dim ploss As Double = SettingInfo.GetInstance().LossPermit

        If loss <= (ploss * 100) Then
            Return True
        Else
            Return False
        End If


    End Function

    Public Function totalSaveMoney() As Integer Implements DetailStrategy.totalSaveMoney



    End Function

    Public Sub complete() Implements DetailStrategy.complete



    End Sub
End Class
