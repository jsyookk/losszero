Public Class CalcUtils

    Public Shared Function GetNeedTon(ByVal hdm As Integer, ByVal meter As Double, ByVal qty As Integer) As Double

        Dim mkgd As Double = Mkg.GetInstance().getMkg(hdm)
        Return Math.Round((mkgd * meter * qty) / 1000, 3)

    End Function
    Public Shared Function GetNeedTonMM(ByVal hdm As Integer, ByVal metermm As Double, ByVal qty As Integer) As Double

        Dim mkgd As Double = Mkg.GetInstance().getMkg(hdm)
        Return Math.Round((mkgd * metermm * qty) / 1000000, 3)

    End Function

    Public Shared Function GetTonByLoss(oringalTon As Double, needTon As Double)

        Dim diffTon As Double = needTon - oringalTon
        Dim loss As Double = 0.0

        If diffTon <= 0.0 Then
            loss = 0
        Else
            loss = Math.Round((diffTon / oringalTon) * 100, 3)
        End If

        Return Math.Round(loss, 3)
    End Function

    Public Shared Function GetLenByLoss(meter As Double, len As Double)


        Dim metermm As Double = meter * 1000
        Dim remainLen As Integer = metermm - len

        Dim loss As Double = (remainLen / metermm) * 100

        Return Math.Round(loss, 3)

    End Function

    Public Shared Function GetSaveMoneny(hdm As Integer, loss As Double, usemeter As Double, qty As Integer) As Long

        If loss > SettingInfo.GetInstance().baseLoss Then
            Return 0
        Else
            Dim mkgPrice As Long = BasePrice.GetInstance().getMkgPrice(hdm)
            Dim baseMoney As Long
            Dim saveMoney As Long
            Dim diffMoney As Long
            Dim baseByLength As Long
            Dim lossByLength As Long
            Try
                baseByLength = (usemeter * 1000) * (SettingInfo.GetInstance().baseLoss / 100)
                lossByLength = (usemeter * 1000) * (loss / 100)
                baseMoney = (mkgPrice * baseByLength) / 1000000
                saveMoney = (mkgPrice * lossByLength) / 1000000
            Catch ex As Exception

            End Try



            diffMoney = (baseMoney - saveMoney) * qty
            Return diffMoney
        End If

    End Function


End Class
