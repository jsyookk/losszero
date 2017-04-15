

Public Class RCombineRemainSteel : Inherits RCombineElement


    Public mplace As String
    Public mNum As Integer
    Public mShapeNum As Integer
    Public mLen As Integer
    Public mQty As Integer
    Public mcut As Integer
    Public msteIDX As Long
    Public mDisplayLen As Integer

    Private elements As New List(Of RCombineElement)

    Public Sub New(base As BaseData, reqty As Integer)

        'mplace = NameTable.GetInstance().getPlace(base.place)
        mplace = Place.GetInstance().getMyName(base.kongjungIdx)
        mNum = base.NUM
        mShapeNum = base.shpNUM
        mLen = base.Legnth
        mQty = reqty
        msteIDX = base.steIndex
        mDisplayLen = base.DisplayLegnth

    End Sub
    Public Sub New(len As Integer, reqty As Integer)

        'mplace = NameTable.GetInstance().getPlace(base.place)
        'mplace = Place.GetInstance().getMyName(Base.kongjungIdx)
        mLen = len
        mQty = reqty
        mDisplayLen = len

    End Sub

    Public Overrides Sub add(element As RCombineElement)

        elements.Add(element)

    End Sub

    Public Overrides Sub display()


    End Sub

    Public Overrides Sub Remove(element As RCombineElement)

        elements.Remove(element)

    End Sub

    Public Overrides Function getList() As List(Of RCombineElement)

        Return elements

    End Function


    Public Overrides Sub ElementCount(type_ As RCombine.CBType, ByRef cnt As Integer)

        Select Case type_
            Case RCombine.CBType.PERPECT
                cnt = cnt + 1
            Case RCombine.CBType.LINKED
                cnt = cnt + 1
            Case RCombine.CBType.REMAIN_CUT
                cnt = cnt + 1
        End Select

        For Each d As RCombineElement In elements
            d.ElementCount(type_, cnt)
        Next

    End Sub

    Public Overrides Function getOrignalTon(ByRef oton As Double) As Double

        For Each d As RCombineElement In elements
            d.getOrignalTon(oton)
        Next

    End Function

    Public Overrides Function getOrignalTon(ByRef hash As Hashtable) As Hashtable

        For Each d As RCombineElement In elements
            d.getOrignalTon(hash)
        Next


    End Function



    Public Overrides Sub getSteMAXCount(ByRef cnt As Integer)
        For Each d As RCombineElement In elements
            d.getSteMAXCount(cnt)
        Next
    End Sub
    Public Overrides Sub setUniqueNumber(uniqueStr As String, maxCNT As Integer, ByRef cntNUM As Integer, usemeter As Double, needTon As Double, ByRef hash As Hashtable)

        For Each d As RCombineElement In elements
            d.setUniqueNumber(uniqueStr, maxCNT, cntNUM, usemeter, needTon, hash)
        Next

    End Sub


    Public Overrides Sub clearUniqueNumber()

        For Each d As RCombineElement In elements
            d.clearUniqueNumber()
        Next
    End Sub
End Class
