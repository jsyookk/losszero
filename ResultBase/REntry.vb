

Public MustInherit Class REntry : Implements RElement

    Protected msceneIdx As Integer
    Protected mkongjungIdx As Integer
    Protected mpartIdx As Integer
    Protected mHdm As Integer
    Protected mhard As Integer

    Protected mMeter As Double
    Protected mQty As Integer
    Protected mOrginalTon As Double
    Protected mneedTon As Double
    Protected mLoss As Double

    Protected mhdmStr As String
    Protected mdimen As Integer
    Protected mSaveMoney As Integer
    Public Property Hard() As Integer
        Get
            Return mhard
        End Get
        Set(value As Integer)
            mhard = value
        End Set

    End Property
    Public Property Qty() As Integer
        Get
            Return mQty
        End Get
        Set(value As Integer)
            mQty = value
        End Set

    End Property
    Public Property Loss() As Double
        Get
            Return mLoss
        End Get
        Set(value As Double)
            mLoss = value
        End Set

    End Property
    Public Property UseMeter() As Double
        Get
            Return mMeter
        End Get
        Set(value As Double)
            mMeter = value
        End Set

    End Property
    Public Property needTon() As Double
        Get
            Return mneedTon
        End Get
        Set(value As Double)
            mneedTon = value
        End Set

    End Property
    Public Property OrignalTon() As Double
        Get
            Return mOrginalTon
        End Get
        Set(value As Double)
            mOrginalTon = value
        End Set

    End Property
    Public Property saveMoney() As Integer
        Get
            Return mSaveMoney
        End Get
        Set(value As Integer)
            mSaveMoney = value
        End Set
    End Property

    Public Property HDM() As Integer
        Get
            Return mHdm
        End Get
        Set(value As Integer)
            mHdm = value

            Select Case mHdm
                Case 400 To 499
                    Hard = 400
                    dimen = mHdm Mod 400
                    mhdmStr = "HD" & dimen
                Case 500 To 599
                    Hard = 500
                    dimen = mHdm Mod 500
                    mhdmStr = "SHD" & dimen
                Case 600 To 699
                    Hard = 600
                    dimen = mHdm Mod 600
                    mhdmStr = "UHD" & dimen
            End Select

        End Set

    End Property
    Public Property hdmStr() As String
        Get
            Return mhdmStr
        End Get
        Set(value As String)
            mhdmStr = value
        End Set

    End Property
    Public Property dimen() As Integer
        Get
            Return mdimen
        End Get
        Set(value As Integer)
            mdimen = value
        End Set
    End Property

    Public Property sceneIDX() As Integer
        Get
            Return msceneIdx
        End Get
        Set(value As Integer)
            msceneIdx = value
        End Set

    End Property

    Public Property kongjungIDX() As Integer
        Get
            Return mkongjungIdx
        End Get
        Set(value As Integer)
            mkongjungIdx = value
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

    Public MustOverride Sub clear()
    Public MustOverride Function getDimen() As Integer
    Public MustOverride Function getName() As String
    Public MustOverride Sub accept(v As RVisitor) Implements RElement.accept

End Class
