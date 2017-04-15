

Public Class BaseDimenFilter : Inherits BaseFilter

    Protected Overrides Function check(ste As Steel) As Boolean

        Select Case ste.Diameter
            Case 10
                If setting.Use10mm Then
                    Return True
                Else
                    Return False
                End If

            Case 13
                If setting.Use13mm Then
                    Return True
                Else
                    Return False
                End If
            Case 16
                If setting.Use16mm Then
                    Return True
                Else
                    Return False
                End If
            Case 19
                If setting.Use19mm Then
                    Return True
                Else
                    Return False
                End If
            Case 22
                If setting.Use22mm Then
                    Return True
                Else
                    Return False
                End If
            Case 25
                If setting.Use25mm Then
                    Return True
                Else
                    Return False
                End If
            Case 29
                If setting.Use29mm Then
                    Return True
                Else
                    Return False
                End If
            Case 32
                If setting.Use32mm Then
                    Return True
                Else
                    Return False
                End If

        End Select

        Return False

    End Function


End Class
