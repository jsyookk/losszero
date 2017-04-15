

Public Class RCombineRemain : Inherits RCombineElement

    Public mLen As Integer
    Public mQty As Integer

    Private elements As New List(Of RCombineElement)

    Public Sub New(len_ As Integer, qty_ As Integer)

        mLen = len_
        mQty = qty_

    End Sub


    Public Overrides Sub add(element As RCombineElement)

        elements.Add(element)

    End Sub

    Public Overrides Sub display()

        Console.WriteLine(New String("남은 것:" & mLen & ":" & mQty))

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
