Public Class BaseData : Inherits Entry

    Enum BASE_STATE

        NONE = 0
        BASE = 1
        TEMP = 2

    End Enum


    Enum COIL_STATE

        NONE = 0
        COIL = 1

    End Enum

    Enum PROCESS_STATE

        NONE = 0
        PROCESSING = 1
        COMPLETE = 2

    End Enum

    Enum RESULT_STATE

        NONE = 0
        BAR = 1
        COMBINE = 2

    End Enum

    Enum LINE_STATE
        LINE = 0
        BENT = 1
    End Enum

    Private mNum As Integer
    Private mShapeNum As Integer
    Private mPlace As Integer
    Private mPart As Integer
    Private mpriority As Boolean
    Private msteIdx As Long
    Private mhdm As Integer
    Private mLen As Double
    Private mQty As Long
    Private mQtyGroup As Integer
    Private mTon As Double
    Private mdisplayLen As Integer
    Private mHard As Integer
    Private mDimen As Integer

    Private mSceneIdx As Integer
    Private mKongjungIdx As Integer
    Private mPartIdx As Integer
    Private mCoil As COIL_STATE
    Private mbasestate As BASE_STATE

    Private mprocessstate As PROCESS_STATE
    Private mresultstate As RESULT_STATE
    Private mlinestate As LINE_STATE

    Public Property LINEState() As LINE_STATE
        Get
            Return mlinestate
        End Get
        Set(value As LINE_STATE)
            mlinestate = value
        End Set
    End Property

    Public Property CoilState() As COIL_STATE
        Get
            Return mCoil
        End Get
        Set(value As COIL_STATE)
            mCoil = value
        End Set
    End Property
    Public Property BaseState() As BASE_STATE
        Get
            Return mbasestate
        End Get
        Set(value As BASE_STATE)
            mbasestate = value
        End Set
    End Property

    Public Property ProcessState() As PROCESS_STATE
        Get
            Return mprocessstate
        End Get
        Set(value As PROCESS_STATE)
            mprocessstate = value
        End Set
    End Property
    Public Property ResultState() As RESULT_STATE
        Get
            Return mresultstate
        End Get
        Set(value As RESULT_STATE)
            mresultstate = value
        End Set
    End Property
    Public Property Dimen() As Integer
        Get
            Return mDimen
        End Get
        Set(value As Integer)
            mDimen = value
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
    Public Property NUM() As Integer
        Get
            Return mNum
        End Get
        Set(value As Integer)
            mNum = value
        End Set
    End Property

    Public Property shpNUM() As Integer
        Get
            Return mShapeNum
        End Get
        Set(value As Integer)
            mShapeNum = value
        End Set
    End Property

    Public Property sceneIdx() As Integer
        Get
            Return mSceneIdx
        End Get
        Set(value As Integer)
            mSceneIdx = value
        End Set
    End Property
    Public Property kongjungIdx() As Integer
        Get
            Return mKongjungIdx
        End Get
        Set(value As Integer)
            mKongjungIdx = value
        End Set
    End Property
    Public Property partIdx() As Integer
        Get
            Return mPartIdx
        End Get
        Set(value As Integer)
            mPartIdx = value
        End Set
    End Property
    Public Property priority() As Boolean
        Get
            Return mpriority
        End Get
        Set(value As Boolean)
            mpriority = value
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
    Public Property steIndex() As Long
        Get
            Return msteIdx
        End Get
        Set(value As Long)
            msteIdx = value
        End Set
    End Property

    Public Property hdm() As Integer
        Get
            Return mhdm
        End Get
        Set(value As Integer)
            mhdm = value

            Select Case mhdm
                Case 400 To 499
                    Hard = 400
                    Dimen = mhdm Mod 400

                Case 500 To 599
                    Hard = 500
                    Dimen = mhdm Mod 500

                Case 600 To 699
                    Hard = 600
                    Dimen = mhdm Mod 600

            End Select
        End Set
    End Property

    Public Property Legnth() As Integer
        Get
            Return mLen
        End Get
        Set(value As Integer)
            mLen = value
        End Set
    End Property

    Public Property DisplayLegnth() As Integer
        Get
            Return mdisplayLen
        End Get
        Set(value As Integer)
            mdisplayLen = value
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
    Public Property QtyGroup() As Integer
        Get
            Return mQtyGroup
        End Get
        Set(value As Integer)
            mQtyGroup = value
        End Set
    End Property

    Public Overrides Sub accept(v As Visitor)

        v.visit(Me)

    End Sub

    Public Overrides Function getCount() As Long

        Return 0

    End Function

    Public Overrides Function getTon() As Double

        Return mTon

    End Function

    Public Overrides Function getName() As String

        Return Nothing

    End Function
    Public Overrides Sub clear()

    End Sub
    Public Function Clone() As BaseData
        Return DirectCast(Me.MemberwiseClone(), BaseData)
    End Function

End Class
