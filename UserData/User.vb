Public Class User


    Private muserName As String
    Private muserID As String
    Private mexpirationDate As String
    Private musergrade As Integer
    Private muserType As Integer

    Private Shared _thisInstance As User = Nothing

    Public Property ExpirateionDate() As String
        Get
            Return mexpirationDate
        End Get
        Set(value As String)
            mexpirationDate = value
        End Set

    End Property
    Public Property UserName() As String
        Get
            Return muserName
        End Get
        Set(value As String)
            muserName = value
        End Set

    End Property
    Public Property UserID() As String
        Get
            Return muserID
        End Get
        Set(value As String)
            muserID = value
        End Set

    End Property
    Public Property UserGrade() As Integer
        Get
            Return musergrade
        End Get
        Set(value As Integer)
            musergrade = value
        End Set

    End Property


    Public Property UserType() As Integer
        Get
            Return muserType
        End Get
        Set(value As Integer)
            muserType = value
        End Set

    End Property

    Public Shared ReadOnly Property GetInstance As User

        Get
            If _thisInstance Is Nothing Then
                _thisInstance = New User
            End If

            Return _thisInstance
        End Get

    End Property
End Class
