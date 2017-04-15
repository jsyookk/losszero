Public Class JSON_Result

    Public mresponseCode As Integer
    Public mresponseMessage As String
    Public mresponse As New response
    Public Property responseCode() As Integer
        Get
            Return mresponseCode
        End Get
        Set(value As Integer)
            mresponseCode = value
        End Set

    End Property

    Public Property responseMessage() As String
        Get
            Return mresponseMessage
        End Get
        Set(value As String)
            mresponseMessage = value
        End Set

    End Property

    Public Property responseValue() As response
        Get
            Return mresponse
        End Get
        Set(value As response)
            mresponse = value
        End Set

    End Property

    Class response

        Public mloginId As String
        Public mpassword As String
        Public muserId As String
        Public muserName As String
        Public muserType As String
        Public mdtos As New List(Of authorityDto)

        Public Property authorityDtos() As List(Of authorityDto)
            Get
                Return mdtos
            End Get
            Set(value As List(Of authorityDto))
                mdtos = value
            End Set

        End Property

        Public Property loginId() As String
            Get
                Return mloginId
            End Get
            Set(value As String)
                mloginId = value
            End Set

        End Property
        Public Property password() As String
            Get
                Return mpassword
            End Get
            Set(value As String)
                mpassword = value
            End Set

        End Property

        Public Property userName() As String
            Get
                Return muserName
            End Get
            Set(value As String)
                muserName = value
            End Set

        End Property

        Public Property userType() As String
            Get
                Return muserType
            End Get
            Set(value As String)
                muserType = value
            End Set

        End Property

        Public Property userId() As String
            Get
                Return muserId
            End Get
            Set(value As String)
                muserId = value
            End Set

        End Property

        Class authorityDto
            Public mauthorityDescription As String
            Public mauthorityId As String
            Public mauthorityName As String
            Public mauthorityType As String
            Public mexpirationDate As String

            Public Property authorityDescription() As String
                Get
                    Return mauthorityDescription
                End Get
                Set(value As String)
                    mauthorityDescription = value
                End Set

            End Property

            Public Property authorityId() As String
                Get
                    Return mauthorityId
                End Get
                Set(value As String)
                    mauthorityId = value
                End Set

            End Property

            Public Property authorityName() As String
                Get
                    Return mauthorityName
                End Get
                Set(value As String)
                    mauthorityName = value
                End Set

            End Property

            Public Property authorityType() As String
                Get
                    Return mauthorityType
                End Get
                Set(value As String)
                    mauthorityType = value
                End Set

            End Property

            Public Property expirationDate() As String
                Get
                    Return mexpirationDate
                End Get
                Set(value As String)
                    mexpirationDate = value
                End Set

            End Property

        End Class

    End Class

End Class
