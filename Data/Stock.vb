Public Class Stock

    Private msd As Integer
    Private mdimen As Integer
    Private mlen As Double
    Private mton As Double
    Private mgroup As Integer
    Public Function clone() As Stock

        Dim prototype As Stock = New Stock()
        prototype.sd = 400
        prototype.dimen = 13
        prototype.len = 7
        prototype.ton = 10.5
        prototype.group = prototype.sd + prototype.dimen

        Return prototype

    End Function
    Public Property sd() As Integer
        Get
            Return msd
        End Get
        Set(value_ As Integer)
            msd = value_
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

    Public Property len() As Double
        Get
            Return mlen
        End Get
        Set(value As Double)
            mlen = value
        End Set
    End Property

    Public Property ton() As Double
        Get
            Return mton
        End Get
        Set(value As Double)
            mton = value
        End Set
    End Property

    Public Property group() As Integer
        Get
            Return mgroup
        End Get
        Set(value As Integer)
            mgroup = value
        End Set
    End Property


End Class
