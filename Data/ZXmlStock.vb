Imports System.IO
Imports System.Xml

Public Class ZXmlStock : Inherits ZXml

    Public Overrides Sub close()


    End Sub

    Public Overrides Sub createDefaultXML(path_ As String)

        Dim stkList As StockList = StockList.GetInstance()
        Dim settings As XmlWriterSettings = New XmlWriterSettings()
        settings.Indent = True


        Using writer As XmlWriter = XmlWriter.Create(path_)

            writer.WriteStartDocument()
            writer.WriteStartElement("stocklist")
            Dim stock As Stock = New Stock().clone()


            writer.WriteStartElement("stock")
            writer.WriteElementString("sd", stock.sd)
            writer.WriteElementString("dimen", stock.dimen)
            writer.WriteElementString("meter", stock.len)
            writer.WriteElementString("ton", stock.ton)
            writer.WriteEndElement()

            writer.WriteEndElement()
            writer.WriteEndDocument()

        End Using


    End Sub

    Public Overrides Sub open(path_ As String)

        Dim stkList As StockList = StockList.GetInstance()
        stkList.clear()
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

            Dim attribute = m_xmld.GetAttribute("stock")
            m_xmld.Read()
            Dim sd = m_xmld.ReadElementString("sd")
            Dim dimen = m_xmld.ReadElementString("dimen")
            Dim meter = m_xmld.ReadElementString("meter")
            Dim ton = m_xmld.ReadElementString("ton")

            '형상정보 추가
            Dim stock As New Stock()

            stock.sd = sd
            stock.dimen = dimen
            stock.len = meter
            stock.ton = ton
            stock.group = stock.sd + stock.dimen

            stkList.Add(stock)

            'Console.WriteLine("sd:" & sd & " dimen:" & dimen & " len:" & meter & " ton :" & ton)
            'Console.Write(vbCrLf)

        End While

        m_xmld.Close()

    End Sub

    Public Overrides Sub write(path_ As String)

        Dim stkList As StockList = StockList.GetInstance()
        Dim settings As XmlWriterSettings = New XmlWriterSettings()
        settings.Indent = True


        Using writer As XmlWriter = XmlWriter.Create(path_)

            writer.WriteStartDocument()
            writer.WriteStartElement("stocklist")
            Dim stock As Stock

            For i = 1 To stkList.count
                stock = stkList.getItem(i)
                writer.WriteStartElement("stock")
                writer.WriteElementString("sd", stock.sd)
                writer.WriteElementString("dimen", stock.dimen)
                writer.WriteElementString("meter", stock.len)
                writer.WriteElementString("ton", stock.ton)
                writer.WriteEndElement()
            Next i

            writer.WriteEndElement()
            writer.WriteEndDocument()

        End Using

    End Sub

    Public Overrides Function isFileCheck(path_ As String) As Boolean

        If My.Computer.FileSystem.FileExists(path_) Then
            Return True
        Else
            System.IO.Directory.CreateDirectory(My.Application.Info.DirectoryPath & "\xml")
            MsgBox("재고 정보 파일이 없습니다.기본 파일을 생성합니다.")
            createDefaultXML(path_)
            Return False
        End If

    End Function


End Class
