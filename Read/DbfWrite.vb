Imports SteelLossProgram
Imports System.Data.OleDb
Imports System.IO
Imports System.Data.SqlClient

Public Class DbfWrite : Implements Writable

    Dim conn As OleDbConnection
    Dim filepath As String
    Dim folderpath As String
    Dim filename As String

    Public Sub close() Implements Writable.close

        Try
            conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Public Sub open(path_ As String) Implements Writable.open

        filepath = path_


        Try
            'createFile(filepath)
            folderpath = Path.GetDirectoryName(path_)
            conn = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;" &
            "Data Source=" & folderpath & ";Extended Properties=dBase IV")
            filename = Path.GetFileName(path_).Substring(0, Path.GetFileName(path_).Length - 4)

            conn.Open()
            'Dim SQLCreateCommand As String
            'SQLCreateCommand = "CREATE TABLE" & filename &
            '"(CustomerID INTEGER," &
            '"LastName TEXT(50), " &
            '"FirstName TEXT(50)," &
            '"Phone TEXT(10)," &
            '"Email TEXT(50))"

            'Dim dBaseCommand As New System.Data.OleDb.OleDbCommand(SQLCreateCommand, conn)
            'dBaseCommand.ExecuteNonQuery()
            'conn.Close()

        Catch ex As Exception
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

        Dim crateTablequery As String = "CREATE TABLE " & filename &
            "( PACKCODE TEXT(20)," &
            "PACKDATE TEXT(20), " &
            "PACKTITLE TEXT(20)," &
            "BARLISTCOD TEXT(20)," &
            "DONG TEXT(20), " &
            "FLOOR TEXT(20), " &
            "ITEM TEXT(20), " &
            "BARTITLE TEXT(50), " &
            "PART TEXT(20), " &
            "MEMBSIZE TEXT(20), " &
            "LENG INTEGER," &
            "QTY INTEGER, " &
            "UNIT FLOAT, " &
            "AKG FLOAT, " &
            "WGT FLOAT, " &
            "TYBM TEXT(20)," &
            "A INTEGER," &
            "B INTEGER," &
            "C INTEGER," &
            "D INTEGER," &
            "E INTEGER," &
            "F INTEGER," &
            "G INTEGER," &
            "X INTEGER," &
            "Y INTEGER," &
            "Z INTEGER," &
            "SUBITEM TEXT(20)," &
            "REMARK TEXT(20))"

        ExecuteQuery(crateTablequery)

        Dim insertQuery As String

        Try

            For Each dta As BaseData In arr_

                Dim ste As Steel = SteelList.GetInstance().getItem(dta.steIndex)
                ' PACKCODE(0)    PACKDATE	PACKTITLE	BARLISTCOD(1)	DONG	FLOOR	ITEM	BARTITLE(2)	PART(3)	MEMBSIZE(4)	LENG(5)	QTY(6)	UNIT(7)	AKG(8)	WGT(9)	TYBM(10)	A(11)	B(12)	C(13)	D(14)	E(15)	F(16)	G(17)	X(18)	Y(19)	Z(20)	SUBITEM(21)	REMARK(22)'
                insertQuery = String.Format("Insert Into " & filename & " Values('{0}',' ',' ','{1}',' ',' ', ' ','{2}','{3}','{4}',{5},{6},{7},{8},{9},{10},{11},{12},{13},{14},{15},{16},{17},{18},{19},{20},'{21}','{22}')",
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
