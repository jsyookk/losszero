Imports System.IO
Imports System.Xml

Public Class ZXmlSetting : Inherits ZXml

    Public Overrides Sub close()

    End Sub

    Public Overrides Sub createDefaultXML(path_ As String)

        Dim setting As SettingInfo = SettingInfo.GetInstance().Clone()

        Using writer As XmlWriter = XmlWriter.Create(path_)
            writer.WriteStartDocument()

            writer.WriteStartElement("settingInfo")
            ' writer.WriteStartElement("dadeLength")

            For Each value As Double In setting.ZumLengths
                writer.WriteElementString("anyType", value)

            Next

            writer.WriteElementString("step5", setting.step5)
            writer.WriteElementString("step4MIN", setting.step4MIN)
            writer.WriteElementString("step4MAX", setting.step4MAX)
            writer.WriteElementString("step3MIN", setting.step3MIN)
            writer.WriteElementString("step3MAX", setting.step3MAX)
            writer.WriteElementString("step2MIN", setting.step2MIN)
            writer.WriteElementString("step2MAX", setting.step2MAX)
            writer.WriteElementString("step1", setting.step1)

            writer.WriteElementString("coilexcept", setting.coilexcept)
            writer.WriteElementString("zangdaexcept", setting.zangDaeExcept)

            writer.WriteElementString("sameSceneIsOK", setting.sameSceneIsOK)
            writer.WriteElementString("sameKongjungIsOK", setting.sameKongjungIsOK)
            writer.WriteElementString("sameShapeIsOK", setting.sameShapeIsOK)

            writer.WriteElementString("Use10mm", setting.Use10mm)
            writer.WriteElementString("Use13mm", setting.Use13mm)
            writer.WriteElementString("Use16mm", setting.Use16mm)
            writer.WriteElementString("Use19mm", setting.Use19mm)
            writer.WriteElementString("Use22mm", setting.Use22mm)
            writer.WriteElementString("Use25mm", setting.Use25mm)
            writer.WriteElementString("Use29mm", setting.Use29mm)
            writer.WriteElementString("Use32mm", setting.Use32mm)

            writer.WriteElementString("LossPermit", setting.LossPermit)
            writer.WriteElementString("StockOnly", setting.StockOnly)

            writer.WriteElementString("RemainOK", setting.remainIsOK)
            writer.WriteElementString("lossAsTon", setting.LossAsTon)

            writer.WriteEndElement()
            writer.WriteEndDocument()

        End Using

    End Sub

    Public Overrides Sub open(path_ As String)

        Dim setting As SettingInfo = SettingInfo.GetInstance()
        Dim zumLens As New ArrayList()


        Dim m_xmld As XmlTextReader
        m_xmld = New XmlTextReader(path_)
        m_xmld.WhitespaceHandling = WhitespaceHandling.None
        m_xmld.Read()

        m_xmld.Read()

        While Not m_xmld.EOF
            m_xmld.Read()

            If Not m_xmld.IsStartElement() Then
                Exit While
            End If

            Dim attribute = m_xmld.GetAttribute("settingInfo")
            m_xmld.Read()


            If m_xmld.LocalName.CompareTo("anyType") = 0 Then

                While m_xmld.LocalName = "anyType"

                    zumLens.Add(m_xmld.ReadElementString("anyType"))
                    m_xmld.Read()

                End While

            End If


            ' m_xmld.ReadEndElement()

            setting.ZumLengths = zumLens

            setting.step5 = m_xmld.ReadElementString("step5")
            setting.step4MIN = m_xmld.ReadElementString("step4MIN")
            setting.step4MAX = m_xmld.ReadElementString("step4MAX")
            setting.step3MIN = m_xmld.ReadElementString("step3MIN")
            setting.step3MAX = m_xmld.ReadElementString("step3MAX")
            setting.step2MIN = m_xmld.ReadElementString("step2MIN")
            setting.step2MAX = m_xmld.ReadElementString("step2MAX")
            setting.step1 = m_xmld.ReadElementString("step1")

            setting.coilexcept = m_xmld.ReadElementString("coilexcept")
            setting.zangDaeExcept = m_xmld.ReadElementString("zangdaeexcept")
            setting.sameSceneIsOK = m_xmld.ReadElementString("sameSceneIsOK")
            setting.sameKongjungIsOK = m_xmld.ReadElementString("sameKongjungIsOK")
            setting.sameShapeIsOK = m_xmld.ReadElementString("sameShapeIsOK")


            setting.Use10mm = m_xmld.ReadElementString("Use10mm")
            setting.Use13mm = m_xmld.ReadElementString("Use13mm")
            setting.Use16mm = m_xmld.ReadElementString("Use16mm")
            setting.Use19mm = m_xmld.ReadElementString("Use19mm")
            setting.Use22mm = m_xmld.ReadElementString("Use22mm")
            setting.Use25mm = m_xmld.ReadElementString("Use25mm")
            setting.Use29mm = m_xmld.ReadElementString("Use29mm")
            setting.Use32mm = m_xmld.ReadElementString("Use32mm")
            setting.baseTON = m_xmld.ReadElementString("baseTon")

            setting.remainIsOK = m_xmld.ReadElementString("RemainOK")
            setting.LossPermit = m_xmld.ReadElementString("LossPermit")
            setting.StockOnly = m_xmld.ReadElementString("StockOnly")
            setting.LossAsTon = m_xmld.ReadElementString("lossAsTon")

        End While

        m_xmld.Close()

    End Sub

    Public Overrides Sub write(path_ As String)

        Dim setting As SettingInfo = SettingInfo.GetInstance()

        Using writer As XmlWriter = XmlWriter.Create(path_)


            writer.WriteStartDocument()

            writer.WriteStartElement("settingInfo")
            For Each value As Double In setting.ZumLengths
                writer.WriteElementString("anyType", value)
            Next

            writer.WriteElementString("step5", setting.step5)
            writer.WriteElementString("step4MIN", setting.step4MIN)
            writer.WriteElementString("step4MAX", setting.step4MAX)
            writer.WriteElementString("step3MIN", setting.step3MIN)
            writer.WriteElementString("step3MAX", setting.step3MAX)
            writer.WriteElementString("step2MIN", setting.step2MIN)
            writer.WriteElementString("step2MAX", setting.step2MAX)
            writer.WriteElementString("step1", setting.step1)

            writer.WriteElementString("coilexcept", setting.coilexcept)
            writer.WriteElementString("zangdaeexcept", setting.zangDaeExcept)

            writer.WriteElementString("sameSceneIsOK", setting.sameSceneIsOK)
            writer.WriteElementString("sameKongjungIsOK", setting.sameKongjungIsOK)
            writer.WriteElementString("sameShapeIsOK", setting.sameShapeIsOK)

            writer.WriteElementString("Use10mm", setting.Use10mm)
            writer.WriteElementString("Use13mm", setting.Use13mm)
            writer.WriteElementString("Use16mm", setting.Use16mm)
            writer.WriteElementString("Use19mm", setting.Use19mm)
            writer.WriteElementString("Use22mm", setting.Use22mm)
            writer.WriteElementString("Use25mm", setting.Use25mm)
            writer.WriteElementString("Use29mm", setting.Use29mm)
            writer.WriteElementString("Use32mm", setting.Use32mm)
            writer.WriteElementString("baseTon", setting.baseTON)

            writer.WriteElementString("LossPermit", setting.LossPermit)
            writer.WriteElementString("RemainOK", setting.remainIsOK)

            writer.WriteElementString("StockOnly", setting.StockOnly)
            writer.WriteElementString("LossAsTon", setting.LossAsTon)

            writer.WriteEndElement()
            writer.WriteEndDocument()

        End Using


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
