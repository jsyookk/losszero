Public Class CoilShape

    Private mfileName As String
    Private mshapeNum As Integer
    Private moneSideLen As Integer
    Public Function clone() As CoilShape

        Dim prototype As CoilShape = New CoilShape()
        prototype.fileName = "1.gif"
        prototype.shapeNUM = 1
        prototype.OneLEN = 2000

        Return prototype

    End Function

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


    Public Property OneLEN() As Integer
        Get
            Return moneSideLen
        End Get
        Set(value As Integer)
            moneSideLen = value
        End Set
    End Property



End Class
