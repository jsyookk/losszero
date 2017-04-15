Imports System.IO
Imports System.Xml

Public Class ZXmlShape : Inherits ZXml

    Public Overrides Sub close()



    End Sub

    Public Overrides Sub createDefaultXML(path_ As String)

    End Sub

    Public Overrides Sub open(path_ As String)

        '형상정보 리스트 초기화
        Dim shplist As ShapeList = ShapeList.GetInstance()
        shplist.clear()

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

            Dim attribute = m_xmld.GetAttribute("shape")
            m_xmld.Read()
            Dim num = m_xmld.ReadElementString("number")
            Dim filename = m_xmld.ReadElementString("filename")
            Dim curve = m_xmld.ReadElementString("curve")
            Dim correct = m_xmld.ReadElementString("correct")

            '형상정보 추가
            Dim shape As New Shape()

            shape.shapeNUM = num
            shape.fileName = filename
            shape.curveCNT = curve
            shape.correct = correct

            shplist.Add(shape)

            'Console.WriteLine("Filename:" & filename & " curve:" & curve & " correct:" & correct)
            'Console.Write(vbCrLf)

        End While

        shplist.createShapeImgList()

        m_xmld.Close()

    End Sub

    Public Overrides Sub write(path_ As String)


        Dim shpList As ShapeList = ShapeList.GetInstance()
        Dim settings As XmlWriterSettings = New XmlWriterSettings()
        settings.Indent = True


        Using writer As XmlWriter = XmlWriter.Create(path_)

            writer.WriteStartDocument()
            writer.WriteStartElement("shapelist")
            Dim shape As Shape

            For i = 1 To shpList.count
                shape = shpList.getItem(i)
                writer.WriteStartElement("shape")
                writer.WriteElementString("number", shape.shapeNUM)
                writer.WriteElementString("filename", shape.fileName)
                writer.WriteElementString("curve", shape.curveCNT)
                writer.WriteElementString("correct", shape.correct)
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
            MsgBox("형상 정보 파일이 없습니다.")
            Return False
        End If


    End Function
End Class
