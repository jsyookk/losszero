Imports Losszero

Public Class CBDefaultFilterFactory : Implements CBFilterFactory

    Public Function makeDefault() As CBFilter Implements CBFilterFactory.makeDefault

        Dim NoFilter As CBFilter = New CBNofilter()
        Dim diffFilter As CBFilter = New CBDifferentFilter()
        Dim sceneFilter As CBFilter = New CBSceneFilter()
        Dim kongjungfilter As CBFilter = New CBKongjungFilter()
        Dim shapefilter As CBFilter = New CBShapeFilter()

        NoFilter.setNext(diffFilter)

        If SettingInfo.GetInstance().sameShapeIsOK = True Then

            diffFilter.setNext(shapefilter)

            If SettingInfo.GetInstance().sameKongjungIsOK = True Then
                shapefilter.setNext(kongjungfilter)
            ElseIf SettingInfo.GetInstance().sameSceneIsOK = True Then
                shapefilter.setNext(sceneFilter)
            End If
        Else
            If SettingInfo.GetInstance().sameKongjungIsOK = True Then
                diffFilter.setNext(kongjungfilter)
            ElseIf SettingInfo.GetInstance().sameSceneIsOK Then
                diffFilter.setNext(sceneFilter)
            End If

        End If


        Return NoFilter

    End Function

    Public Function makeTonSubFilter() As CBFilter Implements CBFilterFactory.makeTonSubFilter

        Dim NoFilter As CBFilter = New CBNofilter()
        Dim diffFilter As CBFilter = New CBDifferentFilter()
        Dim sceneFilter As CBFilter = New CBSceneFilter()
        Dim kongjungfilter As CBFilter = New CBKongjungFilter()
        Dim shapefilter As CBFilter = New CBShapeFilter()
        Dim tonfilter As CBFilter = New CBMoreTonFilter()

        NoFilter.setNext(diffFilter).setNext(tonfilter)

        If SettingInfo.GetInstance().sameShapeIsOK = True Then

            tonfilter.setNext(shapefilter)

            If SettingInfo.GetInstance().sameKongjungIsOK = True Then
                shapefilter.setNext(kongjungfilter)
            ElseIf SettingInfo.GetInstance().sameSceneIsOK = True Then
                shapefilter.setNext(sceneFilter)
            End If
        Else
            If SettingInfo.GetInstance().sameKongjungIsOK = True Then
                tonfilter.setNext(kongjungfilter)
            ElseIf SettingInfo.GetInstance().sameSceneIsOK Then
                tonfilter.setNext(sceneFilter)
            End If

        End If

        Return NoFilter

    End Function
End Class
