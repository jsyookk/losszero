Public Class Base
    Public _HDMLIST() As Integer = New Integer() {410, 413, 416, 419, 422, 425, 429, 432, 510, 513, 516, 519, 522, 525, 529, 532, 610, 613, 616, 619, 622, 625, 629, 632}

    Private Shared _thisInstance As Base = Nothing

    Private _root As Hdm = New Hdm("root")
    Private _hd400 As Hdm = New Hdm("hd400")
    Private _hdm410 As Hdm = New Hdm("hdm410")
    Private _hdm413 As Hdm = New Hdm("hdm413")
    Private _hdm416 As Hdm = New Hdm("hdm416")
    Private _hdm419 As Hdm = New Hdm("hdm419")
    Private _hdm422 As Hdm = New Hdm("hdm422")
    Private _hdm425 As Hdm = New Hdm("hdm425")
    Private _hdm429 As Hdm = New Hdm("hdm429")
    Private _hdm432 As Hdm = New Hdm("hdm432")

    Private _hd500 As Hdm = New Hdm("hd500")
    Private _hdm510 As Hdm = New Hdm("hdm510")
    Private _hdm513 As Hdm = New Hdm("hdm513")
    Private _hdm516 As Hdm = New Hdm("hdm516")
    Private _hdm519 As Hdm = New Hdm("hdm519")
    Private _hdm522 As Hdm = New Hdm("hdm522")
    Private _hdm525 As Hdm = New Hdm("hdm525")
    Private _hdm529 As Hdm = New Hdm("hdm529")
    Private _hdm532 As Hdm = New Hdm("hdm532")

    Private _hd600 As Hdm = New Hdm("hd600")
    Private _hdm610 As Hdm = New Hdm("hdm610")
    Private _hdm613 As Hdm = New Hdm("hdm613")
    Private _hdm616 As Hdm = New Hdm("hdm616")
    Private _hdm619 As Hdm = New Hdm("hdm619")
    Private _hdm622 As Hdm = New Hdm("hdm622")
    Private _hdm625 As Hdm = New Hdm("hdm625")
    Private _hdm629 As Hdm = New Hdm("hdm629")
    Private _hdm632 As Hdm = New Hdm("hdm632")

    Private Sub New()

        _root.add(_hd400)
        _root.add(_hd500)
        _root.add(_hd600)

        _hd400.add(_hdm410)
        _hd400.add(_hdm413)
        _hd400.add(_hdm416)
        _hd400.add(_hdm419)
        _hd400.add(_hdm422)
        _hd400.add(_hdm425)
        _hd400.add(_hdm429)
        _hd400.add(_hdm432)

        _hd500.add(_hdm510)
        _hd500.add(_hdm513)
        _hd500.add(_hdm516)
        _hd500.add(_hdm519)
        _hd500.add(_hdm522)
        _hd500.add(_hdm525)
        _hd500.add(_hdm529)
        _hd500.add(_hdm532)

        _hd600.add(_hdm610)
        _hd600.add(_hdm613)
        _hd600.add(_hdm616)
        _hd600.add(_hdm619)
        _hd600.add(_hdm622)
        _hd600.add(_hdm625)
        _hd600.add(_hdm629)
        _hd600.add(_hdm632)


    End Sub

    Public Sub search(ByRef v As Visitor)

        _root.accept(v)

    End Sub

    Public Sub clear()

        ' _root.clear()

        _hdm410.clear()
        _hdm413.clear()
        _hdm416.clear()
        _hdm419.clear()
        _hdm422.clear()
        _hdm425.clear()
        _hdm429.clear()
        _hdm432.clear()

        _hdm510.clear()
        _hdm513.clear()
        _hdm516.clear()
        _hdm519.clear()
        _hdm522.clear()
        _hdm525.clear()
        _hdm529.clear()
        _hdm532.clear()

        _hdm610.clear()
        _hdm613.clear()
        _hdm616.clear()
        _hdm619.clear()
        _hdm622.clear()
        _hdm625.clear()
        _hdm629.clear()
        _hdm632.clear()



    End Sub

    Public Sub createBase(ByRef ste As Steel)

        Dim base As BaseData = New BaseData()

        base.sceneIdx = ste.sceneIDX
        base.kongjungIdx = ste.kongjungIDX
        base.partIdx = ste.partIDX

        base.shpNUM = ste.ShapeNUM
        base.steIndex = ste.steIDX
        base.hdm = ste.HDM
        base.Legnth = ste.RealLength
        base.DisplayLegnth = ste.Length
        base.Qty = ste.Qty
        base.Ton = ste.Ton
        base.NUM = ste.Num
        base.QtyGroup = ste.QtyGroup

        'state
        base.ProcessState = BaseData.PROCESS_STATE.NONE

        If ste.baseFilter = True Then
            base.BaseState = BaseData.BASE_STATE.BASE
        Else
            base.BaseState = BaseData.BASE_STATE.NONE
        End If

        If ste.coil = True Then
            base.CoilState = BaseData.COIL_STATE.COIL
        Else
            base.CoilState = BaseData.COIL_STATE.NONE
        End If

        If ste.Line = True Then
            base.LINEState = BaseData.LINE_STATE.LINE
        Else
            base.LINEState = BaseData.LINE_STATE.BENT
        End If

        Select Case base.hdm
            Case 410
                _hdm410.add(base)
            Case 413
                _hdm413.add(base)
            Case 416
                _hdm416.add(base)
            Case 419
                _hdm419.add(base)
            Case 422
                _hdm422.add(base)
            Case 425
                _hdm425.add(base)
            Case 429
                _hdm429.add(base)
            Case 432
                _hdm432.add(base)

            Case 510
                _hdm510.add(base)
            Case 513
                _hdm513.add(base)
            Case 516
                _hdm516.add(base)
            Case 519
                _hdm519.add(base)
            Case 522
                _hdm522.add(base)
            Case 525
                _hdm525.add(base)
            Case 529
                _hdm529.add(base)
            Case 532
                _hdm532.add(base)

            Case 610
                _hdm610.add(base)
            Case 613
                _hdm613.add(base)
            Case 616
                _hdm616.add(base)
            Case 619
                _hdm619.add(base)
            Case 622
                _hdm622.add(base)
            Case 625
                _hdm625.add(base)
            Case 629
                _hdm629.add(base)
            Case 632
                _hdm632.add(base)

        End Select


    End Sub

    Public Shared ReadOnly Property GetInstance As Base

        Get
            If _thisInstance Is Nothing Then
                _thisInstance = New Base
            End If

            Return _thisInstance
        End Get

    End Property

End Class
