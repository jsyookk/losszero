Imports System.Xml.Serialization
Imports System.IO
Imports System.Xml

Public Class ZXmlSerialization : Inherits ZSerialization

    Public Overrides Sub createDefaultXML(path_ As String)


        Dim objStreamWriter As New StreamWriter(path_)
        Dim setting As SettingInfo = SettingInfo.GetInstance().Clone()

        Dim x As New XmlSerializer(setting.GetType)
        x.Serialize(objStreamWriter, setting)
        objStreamWriter.Close()


    End Sub

    Public Overrides Sub load(ByVal path As String)
        Dim objStreamReader As New StreamReader(path)
        Dim setting As SettingInfo = SettingInfo.GetInstance()
        Dim x As New XmlSerializer(setting.GetType)

        setting = x.Deserialize(objStreamReader)


        Dim realsetting As SettingInfo = SettingInfo.GetInstance()

        'realsetting = setting.Clone()

        realsetting.LossPermit = setting.LossPermit
        realsetting.coilexcept = setting.coilexcept
        realsetting.StockOnly = setting.StockOnly

        realsetting.sameSceneIsOK = setting.sameSceneIsOK
        realsetting.sameKongjungIsOK = setting.sameKongjungIsOK
        realsetting.sameShapeIsOK = setting.sameShapeIsOK
        realsetting.Use10mm = setting.Use10mm
        realsetting.Use13mm = setting.Use13mm
        realsetting.Use16mm = setting.Use16mm
        realsetting.Use19mm = setting.Use19mm
        realsetting.Use22mm = setting.Use22mm
        realsetting.Use25mm = setting.Use25mm
        realsetting.Use29mm = setting.Use29mm
        realsetting.Use32mm = setting.Use32mm
        realsetting.baseTON = setting.baseTON

        realsetting.step1 = setting.step1
        realsetting.step2MAX = setting.step2MAX
        realsetting.step2MIN = setting.step2MIN
        realsetting.step3MAX = setting.step3MAX
        realsetting.step3MIN = setting.step3MIN
        realsetting.step4MAX = setting.step4MAX
        realsetting.step4MIN = setting.step4MIN
        realsetting.step5 = setting.step5

        realsetting.baseLoss = setting.baseLoss
        realsetting.basePrice = setting.basePrice
        realsetting.allowErrorLen = setting.allowErrorLen
        realsetting.zumTON = setting.zumTON
        realsetting.ZumLengths = setting.ZumLengths
        realsetting.zangDaeExcept = setting.zangDaeExcept
        realsetting.remainIsOK = setting.remainIsOK
        realsetting.LossAsTon = setting.LossAsTon

        objStreamReader.Close()

    End Sub

    Public Overrides Sub save(ByVal path As String)

        Dim objStreamWriter As New StreamWriter(path)
        Dim setting As SettingInfo = SettingInfo.GetInstance()

        Dim x As New XmlSerializer(setting.GetType)
        x.Serialize(objStreamWriter, setting)
        objStreamWriter.Close()

    End Sub

    Public Overrides Function isFileCheck(path_ As String) As Boolean

        If My.Computer.FileSystem.FileExists(path_) Then
            Return True
        Else
            MsgBox("셋팅 정보 파일이 없습니다.기본 파일을 생성합니다.")
            createDefaultXML(path_)
            Return False
        End If

    End Function


End Class
