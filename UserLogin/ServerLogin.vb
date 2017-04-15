Imports Newtonsoft.Json
Imports System.Net
Imports System.IO

Public Class ServerLogin : Inherits Login

    Dim responseFromServer As String
    Dim response As WebResponse


    Public Overrides Sub close()

        response.Close()

    End Sub

    Public Overrides Function check() As Boolean

        Dim json_r As New JSON_Result
        json_r = JsonConvert.DeserializeObject(Of JSON_Result)(responseFromServer)

        If json_r.responseCode = 0 Then
            If json_r.mresponse.mdtos.Count > 0 Then

                Dim user As User = User.GetInstance()
                user.UserID = json_r.responseValue.loginId
                user.UserName = json_r.responseValue.userName
                user.UserGrade = json_r.responseValue.mdtos.First.authorityId
                user.ExpirateionDate = json_r.responseValue.mdtos.First.expirationDate
                MsgBox("환영합니다. " & user.UserName & "님." & vbCrLf & "만료날짜는 " & user.ExpirateionDate & " 입니다.")
                Return True
            Else
                MsgBox("유효 사용기간이 지났습니다.문의 바랍니다.")
            End If
        Else
            MsgBox(json_r.mresponseMessage)
            Return False
        End If

        Return False

    End Function


    Public Overrides Function open(id_ As String, pw_ As String) As Boolean

        Dim request As WebRequest =
              WebRequest.Create("http://Losszero.net:8080/api/v1/userLoginCheck?loginId=" & id_ & "&" & "password=" & pw_)
        ' If required by the server, set the credentials.
        request.Credentials = CredentialCache.DefaultCredentials
        ' Get the response.
        Try
            response = request.GetResponse()
            Console.WriteLine(CType(response, HttpWebResponse).StatusDescription)
            ' Get the stream containing content returned by the server.
            Dim dataStream As Stream = response.GetResponseStream()
            ' Open the stream using a StreamReader for easy access.
            Dim reader As New StreamReader(dataStream)
            ' Read the content.
            responseFromServer = reader.ReadToEnd()
            ' Display the content.
            ' Console.WriteLine(responseFromServer)
            ' Clean up the streams and the response.
            reader.Close()
        Catch e As WebException
            MsgBox(e.Message)
            Return False
        Finally

        End Try

        Return True

    End Function
End Class
