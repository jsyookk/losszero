
Public Class RCombineLink : Inherits RCombineElement
    Private usemeter As Double
    Private useqty As Integer
    Private needTon As Double
    Private lossTon As Double
    Private partloss As Double
    Private orignalTon As Double
    Private elements As New List(Of RCombineElement)
    Private sMoney As Long

    Public Sub New(hdm_ As Integer, meter_ As Double, Uqty_ As Integer, partLossLen As Integer)

        partloss = 0.0

        usemeter = meter_
        useqty = Uqty_

        needTon = CalcUtils.getNeedTon(hdm_, usemeter, useqty)

        If partLossLen = 0 Then
            partloss = 0
        Else
            If SettingInfo.GetInstance().LossAsTon = True Then
                lossTon = CalcUtils.getNeedTonMM(hdm_, partLossLen, useqty)
                partloss = Math.Round((lossTon / needTon) * 100, 3)
            Else
                partloss = Math.Round(partLossLen / (usemeter * 1000) * 100, 3)
            End If

        End If

        Me.sMoney = CalcUtils.getSaveMoneny(hdm_, partloss, Me.usemeter, Uqty_)

    End Sub
    Public Function getQTY() As Integer

        Return useqty

    End Function
    Public Function getLossD() As Double

        Return partloss

    End Function

    Public Overrides Sub add(element As RCombineElement)

        elements.Add(element)

    End Sub
    Public Function getSaveMoney() As Long

        Return sMoney

    End Function
    Public Overrides Sub display()

        Console.WriteLine("필요톤수" & needTon & " 부분로스 :" & partloss)

        For Each d As RCombineElement In elements

            d.display()

        Next


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
            Case RCombine.CBType.LINKED
                cnt = cnt + 1
            Case RCombine.CBType.REMAIN_CUT
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

    Public Overrides Sub clearUniqueNumber()

        For Each d As RCombineElement In elements
            d.clearUniqueNumber()
        Next

    End Sub

    Public Overrides Sub setUniqueNumber(uniqueStr As String, maxCNT As Integer, ByRef cntNUM As Integer, usemeter As Double, needTon As Double, ByRef hash As Hashtable)

        For Each d As RCombineElement In elements
            d.setUniqueNumber(uniqueStr, maxCNT, cntNUM, usemeter, needTon, hash)
        Next

    End Sub
End Class
