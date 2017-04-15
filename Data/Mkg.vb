Public Class Mkg

    Const mkg10 As Double = 0.56
    Const mkg13 As Double = 0.995
    Const mkg16 As Double = 1.56
    Const mkg19 As Double = 2.25
    Const mkg22 As Double = 3.04
    Const mkg25 As Double = 3.98
    Const mkg29 As Double = 5.04
    Const mkg32 As Double = 6.23
    Const mkg35 As Double = 7.51
    Const mkg38 As Double = 8.95
    Const mkg41 As Double = 10.5
    Const mkg51 As Double = 15.9

    Private Shared _thisInstance As Mkg = Nothing
    Private mkgTable As New Hashtable()


    Private Sub New()

        dataInput()

    End Sub

    Private Sub dataInput()


        mkgTable.Add(310, mkg10)
        mkgTable.Add(313, mkg13)
        mkgTable.Add(316, mkg16)
        mkgTable.Add(319, mkg19)
        mkgTable.Add(322, mkg22)
        mkgTable.Add(325, mkg25)
        mkgTable.Add(329, mkg29)
        mkgTable.Add(332, mkg32)
        mkgTable.Add(335, mkg35)
        mkgTable.Add(338, mkg38)
        mkgTable.Add(341, mkg41)
        mkgTable.Add(351, mkg51)

        mkgTable.Add(410, mkg10)
        mkgTable.Add(413, mkg13)
        mkgTable.Add(416, mkg16)
        mkgTable.Add(419, mkg19)
        mkgTable.Add(422, mkg22)
        mkgTable.Add(425, mkg25)
        mkgTable.Add(429, mkg29)
        mkgTable.Add(432, mkg32)
        mkgTable.Add(435, mkg35)
        mkgTable.Add(438, mkg38)
        mkgTable.Add(441, mkg41)
        mkgTable.Add(451, mkg51)

        mkgTable.Add(510, mkg10)
        mkgTable.Add(513, mkg13)
        mkgTable.Add(516, mkg16)
        mkgTable.Add(519, mkg19)
        mkgTable.Add(522, mkg22)
        mkgTable.Add(525, mkg25)
        mkgTable.Add(529, mkg29)
        mkgTable.Add(532, mkg32)
        mkgTable.Add(535, mkg35)
        mkgTable.Add(538, mkg38)
        mkgTable.Add(541, mkg41)
        mkgTable.Add(551, mkg51)

        mkgTable.Add(610, mkg10)
        mkgTable.Add(613, mkg13)
        mkgTable.Add(616, mkg16)
        mkgTable.Add(619, mkg19)
        mkgTable.Add(622, mkg22)
        mkgTable.Add(625, mkg25)
        mkgTable.Add(629, mkg29)
        mkgTable.Add(632, mkg32)
        mkgTable.Add(635, mkg35)
        mkgTable.Add(638, mkg38)
        mkgTable.Add(641, mkg41)
        mkgTable.Add(651, mkg51)


    End Sub

    Public Function getMkg(key As Integer) As Double

        Return mkgTable.Item(key)

    End Function

    Public Shared ReadOnly Property GetInstance As Mkg

        Get
            If _thisInstance Is Nothing Then
                _thisInstance = New Mkg
            End If

            Return _thisInstance
        End Get

    End Property

End Class
