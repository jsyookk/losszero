Public Class BasePrice


    Private Shared _thisInstance As BasePrice = Nothing

    Private basePrice As Long
    Private priceTable As New Hashtable()


    Private Sub New()


    End Sub
    Public Sub inputBasePrice(price_ As Long)

        basePrice = price_

        priceTable.Clear()

        'SD300 
        priceTable.Add(310, basePrice)
        priceTable.Add(313, basePrice - 10000)
        priceTable.Add(316, basePrice - 15000)
        priceTable.Add(319, basePrice - 15000)
        priceTable.Add(322, basePrice - 15000)
        priceTable.Add(325, basePrice - 15000)
        priceTable.Add(329, basePrice - 15000)
        priceTable.Add(332, basePrice - 15000)
        priceTable.Add(335, basePrice + 51000)
        priceTable.Add(338, basePrice + 71000)
        priceTable.Add(341, basePrice + 91000)
        priceTable.Add(351, basePrice + 131000)

        'SD400 
        priceTable.Add(410, basePrice)
        priceTable.Add(413, basePrice - 10000)
        priceTable.Add(416, basePrice - 15000)
        priceTable.Add(419, basePrice - 15000)
        priceTable.Add(422, basePrice - 15000)
        priceTable.Add(425, basePrice - 15000)
        priceTable.Add(429, basePrice - 15000)
        priceTable.Add(432, basePrice - 15000)
        priceTable.Add(435, basePrice + 51000)
        priceTable.Add(438, basePrice + 71000)
        priceTable.Add(441, basePrice + 91000)
        priceTable.Add(451, basePrice + 131000)

        'SD500 
        priceTable.Add(510, basePrice + 30000)
        priceTable.Add(513, basePrice + 20000)
        priceTable.Add(516, basePrice + 15000)
        priceTable.Add(519, basePrice + 15000)
        priceTable.Add(522, basePrice + 15000)
        priceTable.Add(525, basePrice + 15000)
        priceTable.Add(529, basePrice + 15000)
        priceTable.Add(532, basePrice + 15000)
        priceTable.Add(535, basePrice + 81000)
        priceTable.Add(538, basePrice + 101000)
        priceTable.Add(541, basePrice + 121000)
        priceTable.Add(551, basePrice + 161000)

        'SD600 

        priceTable.Add(616, basePrice + 35000)
        priceTable.Add(619, basePrice + 35000)
        priceTable.Add(622, basePrice + 35000)
        priceTable.Add(625, basePrice + 35000)
        priceTable.Add(629, basePrice + 35000)
        priceTable.Add(632, basePrice + 35000)
        priceTable.Add(635, basePrice + 101000)
        priceTable.Add(638, basePrice + 121000)
        priceTable.Add(641, basePrice + 141000)
        priceTable.Add(651, basePrice + 181000)


    End Sub

    Public Function getPrice(key As Integer) As Long

        Return priceTable.Item(key)

    End Function

    Public Function getMkgPrice(key As Integer) As Long

        Dim price As Long
        price = priceTable.Item(key) * Mkg.GetInstance().getMkg(key)
        Return price

    End Function

    Public Shared ReadOnly Property GetInstance As BasePrice

        Get
            If _thisInstance Is Nothing Then
                _thisInstance = New BasePrice
            End If

            Return _thisInstance
        End Get

    End Property
End Class
