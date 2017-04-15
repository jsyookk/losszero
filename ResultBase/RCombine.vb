

Public Class RCombine : Inherits REntry

    Enum CBType

        PERPECT = 0
        LINKED = 1
        REMAIN_CUT = 2
        LINKED_CONTINUE = 3

    End Enum

    Private type As CBType

    Private elements As New List(Of RCombineElement)
    Private depth As Integer
    Private muniqueStr As String
    Private mMaxSteCNT As Integer = 0

    Public Sub New(type As CBType, hdm As Integer, usemeter As Double, qty As Integer)

        Me.type = type
        Me.HDM = hdm
        Me.UseMeter = usemeter
        Me.Qty = qty

    End Sub
    Public Sub New(type As CBType, hdm As Integer, usemeter As Double)

        Me.type = type
        Me.HDM = hdm
        Me.UseMeter = usemeter
        'Me.needTon = needTon
        'Me.OrignalTon = OrignalTon
        'Me.Qty = tQty

    End Sub
    Public Sub New(type As CBType, hdm As Integer, usemeter As Double, orignalTon As Double, needTon As Double, tQty As Integer)

        Me.type = type
        Me.HDM = hdm
        Me.UseMeter = usemeter
        Me.needTon = needTon
        Me.OrignalTon = orignalTon
        Me.Qty = tQty

    End Sub

    Public Sub calc()

        Dim mkgd As Double = Mkg.GetInstance().getMkg(mHdm)

        '총 개수 계산
        If type = CBType.LINKED Then

            Me.Qty = 0
            Me.needTon = 0.0
            Me.OrignalTon = 0.0
            Me.Loss = 0.0
            Me.saveMoney = 0

            For Each d As RCombineElement In elements
                If d.GetType().FullName = "Losszero.RCombineLink" Then
                    Dim rclnk As RCombineLink = CType(d, RCombineLink)
                    Qty += rclnk.getQTY()
                    saveMoney += rclnk.getSaveMoney()
                End If
            Next

            Me.needTon = Math.Round((mkgd * UseMeter * Qty) / 1000, 3)

            '원 톤수 계산
            For Each d As RCombineElement In elements

                d.getOrignalTon(OrignalTon)

            Next

            Me.Loss = CalcUtils.getTonByLoss(OrignalTon, needTon)


        ElseIf type = CBType.PERPECT Then

            Me.Loss = CalcUtils.getTonByLoss(OrignalTon, needTon)
            Me.saveMoney = CalcUtils.getSaveMoneny(Me.HDM, Me.Loss, Me.UseMeter, Me.Qty)

        ElseIf type = CBType.REMAIN_CUT Then

            Me.needTon = Math.Round((mkgd * UseMeter * Me.Qty) / 1000, 3)

            For Each d As RCombineElement In elements

                d.getOrignalTon(OrignalTon)

            Next

            Me.Loss = CalcUtils.getTonByLoss(OrignalTon, needTon)
            Me.saveMoney = CalcUtils.getSaveMoneny(Me.HDM, Me.Loss, Me.UseMeter, Me.Qty)

        End If

        'Console.WriteLine("원 톤수 :" & mOrginalTon & " 필요 톤수:" & mneedTon & "  LOSS :" & mLoss)
        'Me.display()

    End Sub

    Public Sub display()

        For Each d As RCombineElement In elements
            d.display()
        Next

    End Sub
    Public Sub clearUniqueNumber()

        For Each d As RCombineElement In elements
            d.clearUniqueNumber()
        Next

    End Sub
    Public Sub setUniqueNumber()

        Dim maxCnt As Integer
        Dim cnt As Integer = 0
        Dim idxhash As New Hashtable

        For Each d As RCombineElement In elements
            d.getSteMAXCount(maxCnt)
        Next

        muniqueStr = RandomChar.getFirstASC()
        ' uniqueSecondStr = RandomChar.getSecondASC()

        For Each d As RCombineElement In elements
            d.setUniqueNumber(muniqueStr, maxCnt, cnt, UseMeter, needTon, idxhash)
        Next

    End Sub

    Public Function getGraphDisplayCount() As Integer

        Dim displayCnt As Integer = 0

        Select Case type
            Case CBType.PERPECT
                displayCnt = displayCnt + 1
            Case CBType.LINKED
                displayCnt = displayCnt + 1
            Case CBType.REMAIN_CUT
                displayCnt = displayCnt - 1
        End Select

        For Each d As RCombineElement In elements
            d.ElementCount(Me.type, displayCnt)
        Next


        Return displayCnt

    End Function

    Public Function getList() As List(Of RCombineElement)

        Return elements

    End Function

    Public Sub add(element As RCombineElement)

        elements.Add(element)

    End Sub

    Public Sub Remove(element As RCombineElement)

        elements.Remove(element)

    End Sub
    Public Property COMBINE_TYPE() As CBType
        Get
            Return type
        End Get
        Set(value As CBType)
            type = value
        End Set

    End Property

    Public Overrides Sub accept(v As RVisitor)

        v.visit(Me)

    End Sub
    Public Overrides Function getName() As String

        Return Nothing

    End Function
    Public Overrides Sub clear()


    End Sub

    Public Overrides Function getDimen() As Integer

        Return mdimen

    End Function

    Public Function getUniqueStr() As String

        Return muniqueStr

    End Function




End Class
