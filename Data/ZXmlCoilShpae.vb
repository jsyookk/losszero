Imports System.IO
Imports System.Xml

Public Class ZXmlCoilShpae : Inherits ZXml

    Public Overrides Sub close()

    End Sub

    Public Overrides Sub createDefaultXML(path_ As String)

        Dim coilproto As CoilShape = New CoilShape().clone()

        Using writer As XmlWriter = XmlWriter.Create(path_)

            writer.WriteStartDocument()
            writer.WriteStartElement("coilshapeList")

            writer.WriteStartElement("shape")
            writer.WriteElementString("number", coilproto.shapeNUM)
            writer.WriteElementString("filename", coilproto.fileName)
            writer.WriteElementString("len", coilproto.OneLEN)
            writer.WriteEndElement()
            writer.WriteEndDocument()

        End Using


    End Sub

    Public Overrides Sub open(path_ As String)

        '형상정보 리스트 초기화
        Dim cshplist As CoilShapeList = CoilShapeList.GetInstance()
        cshplist.clear()

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
            Dim len = m_xmld.ReadElementString("len")


            '형상정보 추가
            Dim shape As New CoilShape()

            shape.shapeNUM = num
            shape.fileName = filename
            shape.OneLEN = len

            cshplist.Add(shape)

        End While

        m_xmld.Close()

    End Sub

    Public Overrides Sub write(path_ As String)

        Dim cshplist As CoilShapeList = CoilShapeList.GetInstance()

        Using writer As XmlWriter = XmlWriter.Create(path_)

            writer.WriteStartDocument()
            writer.WriteStartElement("coilshapeList")
            Dim shape As CoilShape

            For i = 1 To cshplist.count
                shape = cshplist.getItem(i)
                writer.WriteStartElement("shape")
                writer.WriteElementString("number", shape.shapeNUM)
                writer.WriteElementString("filename", shape.fileName)
                writer.WriteElementString("len", shape.OneLEN)

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
            MsgBox("코일 형상 정보 파일이 없습니다.기본 파일을 생성합니다.")
            createDefaultXML(path_)
            Return False
        End If

    End Function

End Class
