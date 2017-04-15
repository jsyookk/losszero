Option Explicit On
Public Class Steel

    Private mPriority As Boolean
    Private msteIDX As Long
    Private mSceneIDX As Integer
    Private mLocale As Integer
    Private mPlace As Integer
    Private mLine As Boolean
    Private mShtID As Integer
    Private mNum As Integer
    Private mPlaceStr As String
    Private mPart As String
    Private mSign As String
    Private mNorm As String
    Private mShapeNum As Integer
    Private mA As Integer
    Private mB As Integer
    Private mC As Integer
    Private mD As Integer
    Private sE As Integer
    Private mF As Integer
    Private mG As Integer
    Private mR1 As Integer
    Private mR2 As Integer
    Private mR3 As Integer
    Private mLen As Integer
    Private mCLen As Integer
    Private mRealLen As Integer
    Private mQty As Long
    Private mMkg As Double
    Private mTon As Double
    Private mHard As Integer
    Private mDiameter As Integer
    Private mhdm As Integer
    Private mCoil As Boolean
    Private mDade As Boolean
    Private mZum As Boolean
    Private mBaseFilter As Boolean
    Private mRecycle As Boolean

    Private mpackCodeStr As String
    Private mbarlistCodeStr As String
    Private mpackCode As Integer
    Private mbarlistCode As Integer
    Private mkongjougIdx As Integer
    Private mpartIdx As Integer
    Private metc As String
    Private mCustomGroup As Integer
    Private mQtyGroup As Integer



    Public Sub New()

    End Sub

    Public Property ZUM() As Boolean

        Get
            Return mZum
        End Get
        Set(value As Boolean)
            mZum = value
        End Set

    End Property
    Public Property packCodeSTR() As String

        Get
            Return mpackCodeStr
        End Get
        Set(value As String)
            mpackCodeStr = value
        End Set

    End Property
    Public Property barlistCodeSTR() As String

        Get
            Return mbarlistCodeStr
        End Get
        Set(value As String)
            mbarlistCodeStr = value
        End Set

    End Property
    Public Property packCode() As Integer

        Get
            Return mpackCode
        End Get
        Set(value As Integer)
            mpackCode = value
        End Set

    End Property
    Public Property barlistCode() As Integer

        Get
            Return mbarlistCode
        End Get
        Set(value As Integer)
            mbarlistCode = value
        End Set

    End Property
    Public Property sceneIDX() As Integer

        Get
            Return mSceneIDX
        End Get
        Set(value As Integer)
            mSceneIDX = value
        End Set

    End Property
    Public Property kongjungIDX() As Integer

        Get
            Return mkongjougIdx
        End Get
        Set(value As Integer)
            mkongjougIdx = value
        End Set

    End Property
    Public Property partIDX() As Integer

        Get
            Return mpartIdx
        End Get
        Set(value As Integer)
            mpartIdx = value
        End Set

    End Property
    Public Property CustomGroup() As Integer

        Get
            Return mCustomGroup
        End Get
        Set(value As Integer)
            mCustomGroup = value
        End Set

    End Property
    Public Property ETC() As String

        Get
            Return metc
        End Get
        Set(value As String)
            metc = value
        End Set

    End Property
    Public Property QtyGroup() As Integer

        Get
            Return mQtyGroup
        End Get
        Set(value As Integer)
            mQtyGroup = value
        End Set

    End Property
    Public Property Line() As Boolean

        Get
            Return mLine
        End Get
        Set(value As Boolean)
            mLine = value
        End Set

    End Property

    Public Property Recycle() As Boolean

        Get
            Return mRecycle
        End Get
        Set(value As Boolean)
            mRecycle = value
        End Set

    End Property

    Public Property placeStr() As String

        Get
            Return mPlaceStr
        End Get
        Set(value As String)
            mPlaceStr = value
        End Set

    End Property

    Public Property baseFilter() As Boolean

        Get
            Return mBaseFilter
        End Get
        Set(value As Boolean)
            mBaseFilter = value
        End Set

    End Property

    Public Property dade() As Boolean

        Get
            Return mDade
        End Get
        Set(value As Boolean)
            mDade = value
        End Set

    End Property

    Public Property coil() As Boolean

        Get
            Return mCoil
        End Get
        Set(value As Boolean)
            mCoil = value
        End Set

    End Property


    Public Property Priority() As Boolean
        Get
            Return mPriority
        End Get
        Set(value As Boolean)
            mPriority = value
        End Set
    End Property

    Public Property steIDX() As Long
        Get
            Return msteIDX
        End Get
        Set(value As Long)
            msteIDX = value
        End Set
    End Property
    Public Sub bendCalc()

        Dim list As Collection = ShapeList.GetInstance().getList()

        Dim ssumiLen As Integer
        Dim tempDimen As Integer

        For Each shp As Shape In list

            If shp.shapeNUM = Me.ShapeNUM Then
                Select Case Diameter
                    Case 10 : tempDimen = 20
                    Case 13 : tempDimen = 25
                    Case 16 : tempDimen = 30
                    Case 19 : tempDimen = 40
                    Case 22 : tempDimen = 45
                    Case 25 : tempDimen = 50
                    Case 29 : tempDimen = 60
                    Case 32 : tempDimen = 65
                    Case 35 : tempDimen = 70
                    Case 38 : tempDimen = 75
                    Case 41 : tempDimen = 80
                End Select

                ssumiLen = (tempDimen * shp.curveCNT) + shp.correct
                'CLength = -((tempDimen * shp.curveCNT) + shp.correct)

            End If

        Next

        If R1 = 90 Then
            ssumiLen = ssumiLen + tempDimen
        ElseIf R2 = 90 Then
            ssumiLen = ssumiLen + tempDimen
        ElseIf R3 = 90 Then
            ssumiLen = ssumiLen + tempDimen
        End If

        CLength = -(ssumiLen)

        mRealLen = mLen + CLength

    End Sub

    Public Property Locale() As Integer
        Get
            Return mLocale
        End Get
        Set(value As Integer)
            mLocale = value
        End Set
    End Property

    Public Property Place() As Integer
        Get
            Return mPlace
        End Get
        Set(value As Integer)
            mPlace = value
        End Set
    End Property

    Public Property ShtID() As Integer
        Get
            Return mShtID
        End Get
        Set(value As Integer)
            mShtID = value
        End Set
    End Property

    Public Property Num() As Integer
        Get
            Return mNum
        End Get
        Set(value As Integer)
            mNum = value
        End Set
    End Property

    Public Property Part() As String
        Get
            Return mPart
        End Get
        Set(value As String)
            mPart = value
        End Set
    End Property

    Public Property Sign() As String
        Get
            Return mSign
        End Get
        Set(value As String)
            mSign = value
        End Set
    End Property

    Public Property Norm() As String
        Get
            Return mNorm
        End Get
        Set(value As String)
            mNorm = value

            If Left(value, 1) = "H" Then
                Hard = 400
            ElseIf Left(value, 1) = "S" Then
                Hard = 500
            ElseIf Left(value, 1) = "U" Then
                Hard = 600
            Else
                'Error 잘못된 강종입니다' 
            End If

            Diameter = Right(value, 2)

            HDM = Hard + Diameter

        End Set
    End Property

    Public Property ShapeNUM() As Integer
        Get
            Return mShapeNum
        End Get
        Set(value As Integer)
            mShapeNum = value
        End Set
    End Property

    Public Property A() As Long
        Get
            Return mA
        End Get
        Set(value As Long)
            mA = value
        End Set
    End Property

    Public Property B() As Long
        Get
            Return mB
        End Get
        Set(value As Long)
            mB = value
        End Set
    End Property

    Public Property C() As Long
        Get
            Return mC
        End Get
        Set(value As Long)
            mC = value
        End Set
    End Property

    Public Property D() As Long
        Get
            Return mD
        End Get
        Set(value As Long)
            mD = value
        End Set
    End Property

    Public Property E() As Long
        Get
            Return sE
        End Get
        Set(value As Long)
            sE = value
        End Set
    End Property
    Public Property F() As Long
        Get
            Return mF
        End Get
        Set(value As Long)
            mF = value
        End Set
    End Property
    Public Property G() As Long
        Get
            Return mG
        End Get
        Set(value As Long)
            mG = value
        End Set
    End Property

    Public Property R1() As Integer
        Get
            Return mR1
        End Get
        Set(value As Integer)
            mR1 = value
        End Set
    End Property

    Public Property R2() As Integer
        Get
            Return mR2
        End Get
        Set(value As Integer)
            mR2 = value
        End Set
    End Property

    Public Property R3() As Integer
        Get
            Return mR3
        End Get
        Set(value As Integer)
            mR3 = value
        End Set
    End Property

    Public Property Length() As Integer
        Get
            Return mLen
        End Get
        Set(value As Integer)
            mLen = value
        End Set

    End Property

    Public Property CLength() As Integer
        Get
            Return mCLen
        End Get
        Set(value As Integer)
            mCLen = value
        End Set
    End Property

    Public Property RealLength() As Integer
        Get
            Return mRealLen
        End Get
        Set(value As Integer)
            mRealLen = value
        End Set
    End Property


    Public Property Qty() As Long
        Get
            Return mQty
        End Get
        Set(value As Long)
            mQty = value
        End Set
    End Property

    Public Property MKGD() As Double
        Get
            Return mMkg
        End Get
        Set(value As Double)
            mMkg = value
        End Set
    End Property

    Public Property Ton() As Double
        Get
            Return mTon
        End Get
        Set(value As Double)
            mTon = value
        End Set
    End Property

    Public Property Hard() As Integer
        Get
            Return mHard
        End Get
        Set(value As Integer)
            mHard = value
        End Set
    End Property

    Public Property Diameter() As Integer
        Get
            Return mDiameter
        End Get
        Set(value As Integer)
            mDiameter = value
        End Set
    End Property

    Public Property HDM() As Integer
        Get
            Return mhdm
        End Get
        Set(value As Integer)
            mhdm = value
        End Set
    End Property
End Class
