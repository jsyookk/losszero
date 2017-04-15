
Public Class AlogFacade

    Public isDone As Boolean = False
    Public Sub alogExec()

        isDone = False

        Dim permitloss As Double = SettingInfo.GetInstance().LossPermit

        DataMgrFacade.resultClear()
        DataMgrFacade.prevFiltering()

        If SettingInfo.GetInstance().StockOnly = True Then

            Dim alog1 As New StockStrategy1(permitloss)
            alog1.exec()
            Dim grade1 As Long = alog1.getTotalSaveMoney()

            'DataMgrFacade.resultClear()
            'DataMgrFacade.prevFiltering()

            'Dim alog2 As New StockStrategy2(barloss, cbloss)
            'alog2.exec()
            'Dim grade2 As Long = alog2.getTotalSaveMoney()


            'DataMgrFacade.resultClear()
            'DataMgrFacade.prevFiltering()

            'If grade1 > grade2 Then
            '    Dim ralog1 As New StockStrategy1(barloss, cbloss)
            '    ralog1.exec()
            'Else
            '    Dim ralog2 As New StockStrategy2(barloss, cbloss)
            '    ralog2.exec()
            'End If

        Else

            Dim alog1 As New StandardStrategy1(permitloss)
            alog1.exec()
            Dim grade1 As Long = alog1.getTotalSaveMoney()


            'DataMgrFacade.resultClear()
            'DataMgrFacade.prevFiltering()

            'Dim alog2 As New StandardStrategy2(barloss, cbloss)
            'alog2.exec()
            'Dim grade2 As Long = alog2.getTotalSaveMoney()

            'If grade1 > grade2 Then
            '    Dim ralog1 As New StandardStrategy1(barloss, cbloss)
            '    ralog1.exec()
            'Else
            '    Dim ralog2 As New StandardStrategy2(barloss, cbloss)
            '    ralog2.exec()
            'End If

        End If

        'Console.WriteLine("쓰레드 종료")
        isDone = True

    End Sub



End Class
