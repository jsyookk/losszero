Imports System.Text.Encoding

Public Class RandomChar

    Shared uniqueStrList As New List(Of String)
    Shared firstNumberList As New List(Of String)
    Shared secondNumberList As New List(Of String)
    Shared staticRandomGenerator As New System.Random
    Public Shared Sub InputText()

        Dim input As String
        'Dim objReader As New System.IO.StreamReader(My.Application.Info.DirectoryPath & "\xml\unique.txt", System.Text.Encoding.GetEncoding(949))
        Dim objReader As New System.IO.StreamReader(My.Application.Info.DirectoryPath & "\xml\unique.txt")


        Do While objReader.Peek() <> -1

            input = objReader.ReadLine()

            If uniqueStrList.Contains(input) <> True Then
                uniqueStrList.Add(input)
            End If

        Loop

        objReader.Close()


    End Sub
    Public Shared Sub initAsc()


        firstNumberList.Clear()
        secondNumberList.Clear()

        firstNumberList.AddRange(uniqueStrList)
        secondNumberList.AddRange(uniqueStrList)

    End Sub
    Public Shared Function getSecondASC() As String

        For i = 0 To secondNumberList.Count - 1
            Dim randomIdx As Integer = staticRandomGenerator.Next(0, secondNumberList.Count - 1)
            Dim randomStr As String = secondNumberList.Item(randomIdx)
            secondNumberList.Remove(randomStr)


            If secondNumberList.Count = 0 Then
                Console.WriteLine("더 이상 조합에 쓰일 문자가 남아있지 않습니다. ")
            End If

            Return randomStr

        Next


    End Function

    Public Shared Function getFirstASC() As String


        For i = 0 To firstNumberList.Count - 1

            Dim randomIdx As Integer = staticRandomGenerator.Next(0, firstNumberList.Count - 1)
            Dim randomStr As String = firstNumberList.Item(randomIdx)
            firstNumberList.Remove(randomStr)

            If firstNumberList.Count = 0 Then
                MessageBox.Show("더 이상 조합에 쓰일 문자가 남아있지 않습니다.")
            End If

            Return randomStr

        Next


    End Function




End Class
