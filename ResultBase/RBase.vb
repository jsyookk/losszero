Public Class RBase

    Private Shared _thisInstance As RBase = Nothing
    Private _root As RHdm = New RHdm("root")

    Private _hd400 As RHdm = New RHdm("hd400")
    Private _hdm410 As RHdm = New RHdm("hdm410")
    Private _hdm413 As RHdm = New RHdm("hdm413")
    Private _hdm416 As RHdm = New RHdm("hdm416")
    Private _hdm419 As RHdm = New RHdm("hdm419")
    Private _hdm422 As RHdm = New RHdm("hdm422")
    Private _hdm425 As RHdm = New RHdm("hdm425")
    Private _hdm429 As RHdm = New RHdm("hdm429")
    Private _hdm432 As RHdm = New RHdm("hdm432")

    Private _hd500 As RHdm = New RHdm("hd500")
    Private _hdm510 As RHdm = New RHdm("hdm510")
    Private _hdm513 As RHdm = New RHdm("hdm513")
    Private _hdm516 As RHdm = New RHdm("hdm516")
    Private _hdm519 As RHdm = New RHdm("hdm519")
    Private _hdm522 As RHdm = New RHdm("hdm522")
    Private _hdm525 As RHdm = New RHdm("hdm525")
    Private _hdm529 As RHdm = New RHdm("hdm529")
    Private _hdm532 As RHdm = New RHdm("hdm532")

    Private _hd600 As RHdm = New RHdm("hd600")
    Private _hdm610 As RHdm = New RHdm("hdm610")
    Private _hdm613 As RHdm = New RHdm("hdm613")
    Private _hdm616 As RHdm = New RHdm("hdm616")
    Private _hdm619 As RHdm = New RHdm("hdm619")
    Private _hdm622 As RHdm = New RHdm("hdm622")
    Private _hdm625 As RHdm = New RHdm("hdm625")
    Private _hdm629 As RHdm = New RHdm("hdm629")
    Private _hdm632 As RHdm = New RHdm("hdm632")

    Private Sub New()

        createTree()


    End Sub

    Private Sub createTree()

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

    Public Sub search(ByRef v As RVisitor)

        _root.accept(v)

    End Sub

    Public Sub clear()

        _root.clear()
        createTree()

    End Sub

    Public Sub addResult(ByRef result As REntry)

        Select Case result.HDM

            Case 410
                _hdm410.add(result)
            Case 413
                _hdm413.add(result)
            Case 416
                _hdm416.add(result)
            Case 419
                _hdm419.add(result)
            Case 422
                _hdm422.add(result)
            Case 425
                _hdm425.add(result)
            Case 429
                _hdm429.add(result)
            Case 432
                _hdm432.add(result)

            Case 510
                _hdm510.add(result)
            Case 513
                _hdm513.add(result)
            Case 516
                _hdm516.add(result)
            Case 519
                _hdm519.add(result)
            Case 522
                _hdm522.add(result)
            Case 525
                _hdm525.add(result)
            Case 529
                _hdm529.add(result)
            Case 532
                _hdm532.add(result)

            Case 610
                _hdm610.add(result)
            Case 613
                _hdm613.add(result)
            Case 616
                _hdm616.add(result)
            Case 619
                _hdm619.add(result)
            Case 622
                _hdm622.add(result)
            Case 625
                _hdm625.add(result)
            Case 629
                _hdm629.add(result)
            Case 632
                _hdm632.add(result)

        End Select

    End Sub

    Public Shared ReadOnly Property GetInstance As RBase

        Get
            If _thisInstance Is Nothing Then
                _thisInstance = New RBase
            End If

            Return _thisInstance
        End Get

    End Property

End Class
