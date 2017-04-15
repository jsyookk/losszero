
Public Class SettingInfo

    Private use_10mm As Boolean
    Private use_13mm As Boolean
    Private use_16mm As Boolean
    Private use_19mm As Boolean
    Private use_22mm As Boolean
    Private use_25mm As Boolean
    Private use_29mm As Boolean
    Private use_32mm As Boolean
    Private mbaseTon As Double

    Private barloss_permit As Double
    Private cbloss_permit As Double
    Private onlyStock As Boolean

    Private sameShapeOK As Boolean
    Private sameSceneOK As Boolean
    Private sameKongjungOK As Boolean
    Private remainOK As Boolean

    Private mcoilexcept As Boolean

    Private mstep1 As Double

    Private mstep2min As Double
    Private mstep2max As Double

    Private mstep3min As Double
    Private mstep3max As Double

    Private mstep4min As Double
    Private mstep4max As Double

    Private mstep5 As Double

    Private mZumTon As Double

    Private mZumlengths As New ArrayList

    Private mbasePrice As Long
    Private mbaseLoss As Double
    Private mallowErrorLen As Integer

    Private mzangDaeExcept As Boolean
    Private mLossAsTon As Boolean

    Private Shared _thisInstance As SettingInfo = Nothing
    Private Sub New()

    End Sub
    Public Function Clone() As SettingInfo

        Dim prototype As SettingInfo = SettingInfo.GetInstance()

        prototype.barLoosPermit = 0.02
        prototype.CbLossPermit = 0.02

        prototype.coilexcept = True
        prototype.StockOnly = True

        prototype.sameSceneIsOK = False
        prototype.sameKongjungIsOK = True
        prototype.sameShapeIsOK = True
        prototype.Use10mm = True
        prototype.Use13mm = True
        prototype.Use16mm = True
        prototype.Use19mm = True
        prototype.Use22mm = True
        prototype.Use25mm = True
        prototype.Use29mm = True
        prototype.Use32mm = True
        prototype.baseTON = 1.1

        prototype.step1 = 75
        prototype.step2MAX = 74
        prototype.step2MIN = 20
        prototype.step3MAX = 20
        prototype.step3MIN = 10
        prototype.step4MAX = 10
        prototype.step4MIN = 1
        prototype.step5 = 1

        prototype.baseLoss = 1.34
        prototype.basePrice = 525000

        prototype.allowErrorLen = 40
        prototype.mZumTon = 8.0
        prototype.mzangDaeExcept = False
        prototype.remainOK = True
        prototype.LossAsTon = False

        Dim lenlist As New ArrayList()
        lenlist.Add(3750)
        lenlist.Add(4300)
        prototype.ZumLengths = lenlist

        Return prototype

    End Function
    Public Property LossAsTon() As Boolean
        Get
            LossAsTon = mLossAsTon
        End Get
        Set(value As Boolean)
            mLossAsTon = value
        End Set

    End Property
    Public Property remainIsOK() As Boolean
        Get
            remainIsOK = remainOK
        End Get
        Set(value As Boolean)
            remainOK = value
        End Set

    End Property
    Public Property zangDaeExcept() As Boolean
        Get
            zangDaeExcept = mzangDaeExcept
        End Get
        Set(value As Boolean)
            mzangDaeExcept = value
        End Set

    End Property

    Public Property baseTON() As Double
        Get
            baseTON = mbaseTon
        End Get
        Set(value As Double)
            mbaseTon = value
        End Set

    End Property
    Public Property zumTON() As Double
        Get
            zumTON = mZumTon
        End Get
        Set(value As Double)
            mZumTon = value
        End Set

    End Property
    Public Property allowErrorLen() As Integer
        Get
            allowErrorLen = mallowErrorLen
        End Get
        Set(value As Integer)
            mallowErrorLen = value
        End Set

    End Property
    Public Property baseLoss() As Double
        Get
            baseLoss = mbaseLoss
        End Get
        Set(value As Double)
            mbaseLoss = value
        End Set

    End Property
    Public Property basePrice() As Long
        Get
            basePrice = mbasePrice
        End Get
        Set(value As Long)
            mbasePrice = value
        End Set

    End Property

    Public Property ZumLengths() As ArrayList
        Get
            ZumLengths = mZumlengths
        End Get
        Set(value As ArrayList)
            mZumlengths = value
        End Set
    End Property

    Public Property step5() As Double
        Get
            Return mstep5
        End Get
        Set(value As Double)
            mstep5 = value
        End Set

    End Property
    Public Property step4MIN() As Double
        Get
            Return mstep4min
        End Get
        Set(value As Double)
            mstep4min = value
        End Set
    End Property

    Public Property step4MAX() As Double
        Get
            Return mstep4max
        End Get
        Set(value As Double)
            mstep4max = value
        End Set
    End Property
    Public Property step3MIN() As Double
        Get
            Return mstep3min
        End Get
        Set(value As Double)
            mstep3min = value
        End Set
    End Property

    Public Property step3MAX() As Double
        Get
            Return mstep3max
        End Get
        Set(value As Double)
            mstep3max = value
        End Set
    End Property
    Public Property step2MIN() As Double
        Get
            Return mstep2min
        End Get
        Set(value As Double)
            mstep2min = value
        End Set
    End Property

    Public Property step2MAX() As Double
        Get
            Return mstep2max
        End Get
        Set(value As Double)
            mstep2max = value
        End Set
    End Property

    Public Property step1() As Double
        Get
            Return mstep1
        End Get
        Set(value As Double)
            mstep1 = value
        End Set
    End Property


    Public Property coilexcept() As Boolean
        Get
            coilexcept = mcoilexcept
        End Get
        Set(value As Boolean)
            mcoilexcept = value
        End Set

    End Property
    Public Property sameSceneIsOK() As Boolean
        Get
            sameSceneIsOK = sameSceneOK
        End Get
        Set(value As Boolean)
            sameSceneOK = value
        End Set

    End Property

    Public Property sameKongjungIsOK() As Boolean
        Get
            sameKongjungIsOK = sameKongjungOK
        End Get
        Set(value As Boolean)
            sameKongjungOK = value
        End Set

    End Property

    Public Property sameShapeIsOK() As Boolean
        Get
            sameShapeIsOK = sameShapeOK
        End Get
        Set(value As Boolean)
            sameShapeOK = value
        End Set

    End Property

    Public Property Use10mm() As Boolean
        Get
            Use10mm = use_10mm
        End Get
        Set(value As Boolean)
            use_10mm = value
        End Set

    End Property
    Public Property Use13mm() As Boolean
        Get
            Use13mm = use_13mm
        End Get
        Set(value As Boolean)
            use_13mm = value
        End Set

    End Property
    Public Property Use16mm() As Boolean
        Get
            Use16mm = use_16mm
        End Get
        Set(value As Boolean)
            use_16mm = value
        End Set

    End Property
    Public Property Use19mm() As Boolean
        Get
            Use19mm = use_19mm
        End Get
        Set(value As Boolean)
            use_19mm = value
        End Set

    End Property
    Public Property Use22mm() As Boolean
        Get
            Use22mm = use_22mm
        End Get
        Set(value As Boolean)
            use_22mm = value
        End Set

    End Property
    Public Property Use25mm() As Boolean
        Get
            Use25mm = use_25mm
        End Get
        Set(value As Boolean)
            use_25mm = value
        End Set

    End Property
    Public Property Use29mm() As Boolean
        Get
            Use29mm = use_29mm
        End Get
        Set(value As Boolean)
            use_29mm = value
        End Set

    End Property
    Public Property Use32mm() As Boolean
        Get
            Use32mm = use_32mm
        End Get
        Set(value As Boolean)
            use_32mm = value
        End Set

    End Property
    Public Property barLoosPermit() As Double
        Get
            Return barloss_permit
        End Get
        Set(value As Double)
            barloss_permit = value
        End Set
    End Property

    Public Property CbLossPermit() As Double
        Get
            Return cbloss_permit
        End Get
        Set(value As Double)
            cbloss_permit = value
        End Set
    End Property
    Public Property StockOnly() As Boolean
        Get
            Return onlyStock
        End Get
        Set(value As Boolean)
            onlyStock = value
        End Set

    End Property

    Public Shared ReadOnly Property GetInstance As SettingInfo
        Get
            If _thisInstance Is Nothing Then
                _thisInstance = New SettingInfo
            End If

            Return _thisInstance
        End Get
    End Property


End Class
