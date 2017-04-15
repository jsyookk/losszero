
Public Class RCombineSte : Inherits RCombineElement

    Public mgroup As Integer
    Public mplace As String
    Public mNum As Integer
    Public mShapeNum As Integer
    Public mLen As Integer
    Public mQty As Integer
    Public mcut As Integer
    Public msteIDX As Long
    Public mDisplayLen As Integer
    Public mOrignalTon As Double
    Public mUninqueIDX As String
    Public mRealSte As Boolean = False
    Public mMaxCNT As Integer = 0
    Public mUniqueNum As Integer

    Private elements As New List(Of RCombineElement)

    Public Sub New(base As BaseData, cut_ As Integer)

        'mplace = NameTable.GetInstance().getPlace(base.place)
        mplace = Place.GetInstance().getMyName(base.kongjungIdx)
        mNum = base.NUM
        mShapeNum = base.shpNUM
        mLen = base.Legnth
        mQty = base.Qty
        mcut = cut_
        msteIDX = base.steIndex
        mDisplayLen = base.DisplayLegnth

        If base.BaseState <> BaseData.BASE_STATE.TEMP Then
            mOrignalTon = base.getTon()
            mRealSte = True
        End If

    End Sub

    Public Overrides Sub add(element As RCombineElement)

        elements.Add(element)

    End Sub

    Public Overrides Sub Remove(element As RCombineElement)

        elements.Remove(element)

    End Sub

    Public Overrides Sub display()

        Console.WriteLine(Me.mLen & " * " & Me.mcut)

        For Each d As RCombineElement In elements

            d.display()

        Next

    End Sub

    Public Overrides Function getList() As List(Of RCombineElement)

        Return elements

    End Function


    Public Overrides Sub ElementCount(type_ As RCombine.CBType, ByRef cnt As Integer)

        Select Case type_
            Case RCombine.CBType.PERPECT

            Case RCombine.CBType.LINKED

            Case RCombine.CBType.REMAIN_CUT
                cnt = cnt + 1
        End Select

        For Each d As RCombineElement In elements
            d.ElementCount(type_, cnt)
        Next

    End Sub

    Public Overrides Function getOrignalTon(ByRef oton As Double) As Double

        oton = oton + mOrignalTon

        For Each d As RCombineElement In elements
            d.getOrignalTon(oton)
        Next


    End Function

    Public Overrides Function getOrignalTon(ByRef hash As Hashtable) As Hashtable

        Dim ste As Steel = SteelList.GetInstance().getItem(Me.msteIDX)

        If hash.ContainsKey(ste.steIDX) <> True Then
            hash.Add(ste.steIDX, Me.mOrignalTon)
        End If


        For Each d As RCombineElement In elements
            d.getOrignalTon(hash)
        Next


    End Function

    Public Overrides Sub getSteMAXCount(ByRef cnt As Integer)

        If mRealSte = True Then
            cnt += 1
        End If

        For Each d As RCombineElement In elements
            d.getSteMAXCount(cnt)
        Next

    End Sub
    Public Overrides Sub setUniqueNumber(uniqueStr As String, maxCNT As Integer, ByRef cntNUM As Integer, usemeter As Double, needTon As Double, ByRef hash As Hashtable)

        mMaxCNT = maxCNT

        If mRealSte = True Then
            cntNUM += 1

            Dim ste As Steel = SteelList.GetInstance().getItem(msteIDX)

            If cntNUM = 1 Then
                ste.ETC = "(" & uniqueStr & ")" & usemeter & "M-" & needTon & "t " & " No." & cntNUM & "(" & maxCNT & ")"
            Else
                ste.ETC = "(" & uniqueStr & ")" & "No." & cntNUM & "(" & maxCNT & ")"
            End If

            hash.Add(Me.msteIDX, cntNUM)
            mUninqueIDX = "(" & uniqueStr & ")" & "No." & cntNUM

        Else
            Dim num As Integer

            If hash.ContainsKey(msteIDX) = True Then
                num = hash.Item(msteIDX)
                mUninqueIDX = "(" & uniqueStr & ")" & "No." & num
            End If
        End If



    End Sub


    Public Overrides Sub clearUniqueNumber()

        Dim ste As Steel = SteelList.GetInstance().getItem(msteIDX)
        ste.ETC = ""

    End Sub
End Class
