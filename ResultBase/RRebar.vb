

Public Class RRebar : Inherits REntry

    Enum BAR_TYPE

        NORMARL
        ZANGDAE
        ANGKA_ZANGDAE
        ERROR_NORMAL
        ZUM_STEEL

    End Enum

    Private mtype As BAR_TYPE
    Private mNum As Integer
    Private mDisplayLen As Integer
    Private mLen As Integer
    Private mcut As Integer
    Private msteIDX As Long

    Private mOQty As Integer

    Private mplace As String
    Private mshpNum As Integer

    Private mErrorLen As Integer
    Private mOrignalTon As Double

    Public Sub New()


    End Sub

    Public Property type() As BAR_TYPE
        Get
            type = mtype
        End Get
        Set(value As BAR_TYPE)
            mtype = value
        End Set
    End Property
    Public Property displayLEN() As Integer
        Get
            Return mDisplayLen
        End Get
        Set(value As Integer)
            mDisplayLen = value
        End Set
    End Property

    Public Property shpNUM() As Integer
        Get
            Return mshpNum
        End Get
        Set(value As Integer)
            mshpNum = value
        End Set
    End Property


    Public Property OQty() As Integer
        Get
            Return mOQty
        End Get
        Set(value As Integer)
            mOQty = value
        End Set
    End Property

    Public Property num() As Integer
        Get
            Return mNum
        End Get
        Set(value As Integer)
            mNum = value
        End Set
    End Property

    Public Property place() As String
        Get
            Return mplace
        End Get
        Set(value As String)
            mplace = value
        End Set
    End Property

    Public Property len() As Integer
        Get
            Return mLen
        End Get
        Set(value As Integer)
            mLen = value
        End Set
    End Property

    Public Property cutting() As Integer
        Get
            Return mcut
        End Get
        Set(value As Integer)
            mcut = value
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

    Public Property meter() As Double
        Get
            Return mmeter
        End Get
        Set(value As Double)
            mmeter = value
        End Set
    End Property
    Public Property errorLEN() As Integer
        Get
            Return mErrorLen
        End Get
        Set(value As Integer)
            mErrorLen = value
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

        Return mHdm

    End Function

End Class
