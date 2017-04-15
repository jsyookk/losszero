Imports System.Data.OleDb
Imports System.IO
Imports Losszero

Public Class DbfRead : Implements Readable

    Enum DBF_COLUMN_NUM

        PACKCODE = 0
        PACKDATE
        PACKTITLE
        BARLISTCOD
        DONG
        FLOOR
        ITEM
        BARTITLE
        PART
        MEMBSIZE
        LENG
        QTY
        UNIT
        AKG
        WGT
        TYBM
        A
        B
        C
        D
        E
        F
        G
        R1
        R2
        R3
        SUBITEM
        REMARK
        MAX_COUNT

    End Enum


    Private folderName As String
    Private filelist() As String
    Private fileNames() As String
    Private newFileNames As New ArrayList
    Private fileRenames() As String = {"A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P"}


    Public Sub New(filenames_ As String())

        Me.fileNames = filenames_

        Dim i As Integer = 0
        Dim renameFile As String = Nothing

        For Each filename As String In filenames_

            Me.folderName = Path.GetDirectoryName(filename)

            renameFile = Me.folderName & "\" & fileRenames(i) + ".dbf"
            My.Computer.FileSystem.CopyFile(filename, renameFile)

            newFileNames.Add(fileRenames(i))
            Me.fileNames(i) = Path.GetFileName(filename).Substring(0, Path.GetFileName(filename).Length - 4)
            Console.WriteLine(Me.fileNames(i))

            i = i + 1

        Next

    End Sub

    Public Sub close() Implements Readable.close


    End Sub

    Public Sub open() Implements Readable.open

        Dim steelL As SteelList = SteelList.GetInstance
        FrameWork.GetInstance().setStatus(FrameWork.STATUS.FILELOAD_DBF)


        Dim ConnectionString As String
        ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;" &
            "Data Source=" & Me.folderName & ";Extended Properties=dBase IV"

        Dim dBaseConnection As New OleDbConnection(ConnectionString)

        Dim sceneIdx As Integer = 0
        Dim sceneNum As Integer = 200
        Dim prevkongjungNum As Integer = 0
        Dim currkongjungNum As Integer = 0
        Dim partNum As Integer = 100
        Dim currkongjung As Kongjung = Nothing
        Dim prevPartStr As String = Nothing

        Try
            dBaseConnection.Open()

            For Each dbfname As String In newFileNames

                Dim strCommand As String = "SELECT * FROM " & dbfname
                Console.WriteLine(strCommand)
                Dim adap As New OleDbDataAdapter(strCommand, dBaseConnection)

                Dim dt As New DataTable()
                adap.Fill(dt)

                'Dim scene_ As New Scene(sceneNum, dbfname)
                Dim scene_ As New Scene(sceneNum, fileNames(sceneIdx))


                For Each row As DataRow In dt.Rows

                    Dim ste As New Steel

                    ste.sceneIDX = sceneNum

                    For i = 0 To DBF_COLUMN_NUM.MAX_COUNT - 1

                        If Not IsDBNull(row(i)) Then

                            Select Case i
                                Case DBF_COLUMN_NUM.PACKCODE

                                    ste.packCodeSTR = row(i)
                                    ste.Num = CInt(Right(ste.packCodeSTR, 3))

                                Case DBF_COLUMN_NUM.BARLISTCOD

                                    Dim kongjungStr As String = row(i)
                                    currkongjungNum = CInt(kongjungStr.Replace("-", "").Trim())

                                    ste.barlistCodeSTR = kongjungStr
                                    ste.barlistCode = currkongjungNum
                                    ste.kongjungIDX = currkongjungNum

                                    If prevkongjungNum <> currkongjungNum Then
                                        Dim kongjungName As String = row(DBF_COLUMN_NUM.BARTITLE)

                                        If scene_.check(currkongjungNum) = False Then

                                            Dim kongjung As New Kongjung(sceneNum, currkongjungNum, kongjungName)
                                            scene_.add(kongjung)
                                            currkongjung = kongjung
                                        Else
                                            currkongjung = scene_.getChildKongjong(currkongjungNum)
                                        End If


                                    End If

                                    prevkongjungNum = currkongjungNum

                                Case DBF_COLUMN_NUM.PART

                                    Dim sign As String = row(DBF_COLUMN_NUM.PART)

                                    If sign IsNot Nothing Then
                                        ste.Sign = sign
                                    End If


                                Case DBF_COLUMN_NUM.MEMBSIZE
                                    ste.Norm = row(i)
                                Case DBF_COLUMN_NUM.LENG
                                    ste.Length = row(i)
                                Case DBF_COLUMN_NUM.QTY
                                    ste.Qty = row(i)
                                Case DBF_COLUMN_NUM.WGT
                                    ste.Ton = row(i)
                                Case DBF_COLUMN_NUM.TYBM
                                    ste.ShapeNUM = row(i)
                                Case DBF_COLUMN_NUM.UNIT

                                Case DBF_COLUMN_NUM.AKG

                                Case DBF_COLUMN_NUM.A
                                    ste.A = row(i)
                                Case DBF_COLUMN_NUM.B
                                    ste.B = row(i)
                                Case DBF_COLUMN_NUM.C
                                    ste.C = row(i)
                                Case DBF_COLUMN_NUM.D
                                    ste.D = row(i)
                                Case DBF_COLUMN_NUM.E
                                    ste.E = row(i)
                                Case DBF_COLUMN_NUM.F
                                    ste.F = row(i)
                                Case DBF_COLUMN_NUM.G
                                    ste.G = row(i)
                                Case DBF_COLUMN_NUM.R1
                                    ste.R1 = row(i)
                                Case DBF_COLUMN_NUM.R2
                                    ste.R2 = row(i)
                                Case DBF_COLUMN_NUM.R3
                                    ste.R3 = row(i)
                                Case DBF_COLUMN_NUM.SUBITEM

                                    If Not IsDBNull(row(DBF_COLUMN_NUM.SUBITEM)) Then
                                        Dim partStr As String = row(DBF_COLUMN_NUM.SUBITEM)

                                        If currkongjung.checkByPartName(partStr) = False Then
                                            partNum = partNum + 1
                                            Dim part As New Part(currkongjungNum, partNum, partStr)
                                            currkongjung.add(part)
                                            currkongjung.Addton(partNum, ste.Ton)
                                            ste.partIDX = partNum
                                        Else
                                            ste.partIDX = partNum
                                            currkongjung.Addton(partNum, ste.Ton)
                                        End If
                                    End If


                                Case DBF_COLUMN_NUM.REMARK
                                    ste.ETC = row(i)
                            End Select

                        End If

                    Next


                    ste.bendCalc()
                    steelL.Add(ste)

                Next

                sceneIdx += 1
                sceneNum += 1

                Place.GetInstance().add(Place.CLASS_ENUM.SCENE, scene_)

            Next


        Catch ex As Exception
            MessageBox.Show(ex.Message)
            dBaseConnection.Close()
        End Try

        FrameWork.GetInstance.setStatus(FrameWork.STATUS.FILELOAD_COMPLETE)
        dBaseConnection.Close()
        deleteTempFile()

        Place.GetInstance().print()

    End Sub

    Private Sub deleteTempFile()

        For Each filename As String In newFileNames

            Dim path As String = folderName & "\" & filename & ".dbf"

            My.Computer.FileSystem.DeleteFile(path)

        Next


    End Sub

    Public Sub print() Implements Readable.print


    End Sub



End Class
