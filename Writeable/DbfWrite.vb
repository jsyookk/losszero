Imports System.Data.OleDb
Imports System.IO
Imports System.Data.SqlClient

Public Class DbfWrite : Implements Writable

    Dim conn As OleDbConnection
    Dim filepath As String
    Dim folderpath As String
    Dim filename As String
    Dim tempFilepath As String

    Public Sub close() Implements Writable.close

        Try
            conn.Close()
            My.Computer.FileSystem.CopyFile(tempFilepath, filepath)
            My.Computer.FileSystem.DeleteFile(tempFilepath)

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Public Sub open(path_ As String) Implements Writable.open

        filepath = path_
        filename = Path.GetFileName(path_).Substring(0, Path.GetFileName(path_).Length - 4)
        folderpath = Path.GetDirectoryName(filepath)
        tempFilepath = folderpath & "\TEMP.dbf"

        If My.Computer.FileSystem.FileExists(tempFilepath) Then
            Try
                My.Computer.FileSystem.DeleteFile(tempFilepath)
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If

        'createFile(tempFilepath)

        Try
            conn = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;" &
            "Data Source=" & folderpath & ";Extended Properties=dBase IV")
            conn.Open()

            Dim crateTablequery As String = "CREATE TABLE TEMP" &
                "( PACKCODE TEXT(30)," &
                "PACKDATE TEXT(50), " &
                "PACKTITLE TEXT(50)," &
                "BARLISTCOD TEXT(30)," &
                "DONG TEXT(20), " &
                "FLOOR TEXT(20), " &
                "ITEM TEXT(20), " &
                "BARTITLE TEXT(100), " &
                "PART TEXT(50), " &
                "MEMBSIZE TEXT(20), " &
                "LENG Int," &
                "QTY Int, " &
                "UNIT FLOAT, " &
                "AKG FLOAT, " &
                "WGT FLOAT, " &
                "TYBM TEXT(10)," &
                "A Int," &
                "B Int," &
                "C Int," &
                "D Int," &
                "E Int," &
                "F Int," &
                "G Int," &
                "X Int," &
                "Y Int," &
                "Z Int," &
                "SUBITEM TEXT(50)," &
                "REMARK TEXT(30))"

            ExecuteQuery(crateTablequery)

        Catch ex As Exception
            My.Computer.FileSystem.DeleteFile(tempFilepath)
            MessageBox.Show(ex.Message)
        End Try


    End Sub
    Private Sub createFile(path_ As String)

        Dim fs As FileStream = File.Create(path_)
        fs.Close()

    End Sub
    Public Sub ExecuteQuery(query_ As String)

        Dim result As Integer = 0

        Try
            Dim command As OleDbCommand = New OleDbCommand(query_, conn)
            'command.Connection = conn

            result = command.ExecuteNonQuery()

        Catch ex As Exception

            If conn.State = ConnectionState.Closed Or conn.State = ConnectionState.Broken Then
                MessageBox.Show("연결 오류")
            End If

            MessageBox.Show(ex.Message)

        End Try


    End Sub


    Public Sub write(arr_ As ArrayList) Implements Writable.write

        'Dim query As String = "CREATE TABLE test (PACKCODE C(15),PACKDATE C(15),PACKTITLE C(20),BARLISTCOD C(15),DONG C(10),FLOOR C(10)," _
        '     & "ITEM C(10),BARTITLE C(50),PART C(5),MEMBSIZE C(10),LENG N(10),QTY N(10),UNIT F(5,2),AKG F(5,2),WGT F(5,2),TYBM N(10)," _
        '     & "A N(10),B N(10),C N(10),D N(10),E N(10),F N(10),G N(10),X N(10),Y N(10),Z N(10),SUBITEM C(15),REMARK C(15))"


        Dim insertQuery As String

        Try

            For Each dta As BaseData In arr_

                Dim ste As Steel = SteelList.GetInstance().getItem(dta.steIndex)
                ' PACKCODE(0)    PACKDATE	PACKTITLE	BARLISTCOD(1)	DONG	FLOOR	ITEM	BARTITLE(2)	PART(3)	MEMBSIZE(4)	LENG(5)	QTY(6)	UNIT(7)	AKG(8)	WGT(9)	TYBM(10)	A(11)	B(12)	C(13)	D(14)	E(15)	F(16)	G(17)	X(18)	Y(19)	Z(20)	SUBITEM(21)	REMARK(22)'
                insertQuery = String.Format("Insert Into TEMP Values('{0}',' ',' ','{1}',' ',' ', ' ','{2}','{3}','{4}',{5},{6},{7},{8},{9},{10},{11},{12},{13},{14},{15},{16},{17},{18},{19},{20},'{21}','{22}')",
                                            ste.packCodeSTR,
                                            ste.barlistCodeSTR,
                                            Place.GetInstance().getMyName(ste.kongjungIDX),
                                            ste.Sign,
                                            ste.Norm,
                                            ste.Length,
                                            ste.Qty,
                                            Mkg.GetInstance().getMkg(ste.HDM),
                                            0.00,
                                            ste.Ton,
                                            ste.ShapeNUM,
                                            ste.A,
                                            ste.B,
                                            ste.C,
                                            ste.D,
                                            ste.E,
                                            ste.F,
                                            ste.G,
                                            ste.R1,
                                            ste.R2,
                                            ste.R3,
                                           Place.GetInstance().getMyName(ste.partIDX),
                                            ste.ETC)

                ExecuteQuery(insertQuery)

            Next

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

End Class
