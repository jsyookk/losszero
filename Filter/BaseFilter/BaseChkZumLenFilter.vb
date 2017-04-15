Public Class BaseChkZumLenFilter : Inherits BaseChkFilter

    Protected Overrides Function check(base As BaseData) As Boolean

        Dim len As Integer = base.Legnth
        Dim lens As ArrayList = SettingInfo.GetInstance().ZumLengths

        If lens.Contains(len) = True Then
            Return True
        Else
            Return False
        End If

    End Function

End Class
