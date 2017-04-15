Public Class DataMgrFacade

    Public Shared Sub DataAllClear()

        SteelList.GetInstance().clear()
        Place.GetInstance().clear()
        Base.GetInstance().clear()
        'rbase 추가
        RBase.GetInstance().clear()
        RandomChar.initAsc()

    End Sub

    Public Shared Sub resultClear()

        Base.GetInstance().clear()
        RBase.GetInstance().clear()
        RandomChar.initAsc()


    End Sub

    Public Shared Sub steelClear()

        Dim stelist As SteelList = SteelList.GetInstance()

        For Each ste As Steel In stelist.getList()

            ste.coil = False
            ste.Line = False
            ste.ETC = Nothing

        Next


    End Sub

    Public Shared Sub prevFiltering()

        steelClear()
        'coil Filter

        Dim stelist As SteelList = SteelList.GetInstance()

        If SettingInfo.GetInstance().coilexcept = True Then

            Dim setting As SettingInfo = SettingInfo.GetInstance
            Dim cfilter As CoilFilter = New BaseFilterDefaultFactory().makeCoilFilter()
            For i = 1 To stelist.count

                Dim ste As Steel = stelist.getItem(i)
                cfilter.filtering(ste)

            Next
        End If



        'base filter

        Dim bfilter As BaseFilter = New BaseFilterDefaultFactory().makeBaseFilter()
        For i = 1 To stelist.count

            Dim ste As Steel = stelist.getItem(i)
            bfilter.filtering(ste)

        Next

    End Sub


End Class
