Public Class Shape

    Private mfileName As String
    Private mshapeNum As Integer
    Private mcurveCnt As Integer
    Private mcorrect As Integer

    Public Property fileName() As String
        Get
            Return mfileName
        End Get
        Set(path_ As String)
            mfileName = path_
        End Set
    End Property

    Public Property shapeNUM() As Integer
        Get
            Return mshapeNum
        End Get
        Set(value As Integer)
            mshapeNum = value
        End Set
    End Property

    Public Property curveCNT() As Integer
        Get
            Return mcurveCnt
        End Get
        Set(value As Integer)
            mcurveCnt = value
        End Set
    End Property

    Public Property correct() As Integer
        Get
            Return mcorrect
        End Get
        Set(value As Integer)
            mcorrect = value
        End Set
    End Property


End Class
