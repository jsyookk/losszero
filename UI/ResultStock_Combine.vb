Public Class ResultStock_Combine

    Public Sub updateData(list As ArrayList)

        list.Sort(New REntrySortByMoney())

        FlowLayoutPanel1.Controls.Clear()

        For Each r As REntry In list

            If r.GetType().FullName = "Losszero.RCombine" Then

                Dim uc As UserControl = New MatchCard(r)
                FlowLayoutPanel1.Controls.Add(uc)

            End If

        Next

    End Sub

End Class
