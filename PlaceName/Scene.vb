
Public Class Scene : Inherits PEntry

    Private sceneName As String
    Private Idx As Integer
    Private list As New ArrayList
    Public Sub New()

    End Sub
    Public Sub New(key_ As Integer, name As String)

        Me.Idx = key_
        Me.sceneName = name

    End Sub

    Public Overrides Function getUniqueIDX() As Integer

        Return Idx

    End Function
    Public Overrides Sub accept(v As PVisitor)

        v.visit(Me)

    End Sub

    Public Overrides Function getName() As String

        Return sceneName

    End Function

    Public Overrides Function getName(key_ As Integer) As String

        If key_ = Idx Then
            Return sceneName
        Else
            For Each entry As PEntry In list
                Dim name As String = entry.getName(key_)

                If String.IsNullOrEmpty(name) = False Then
                    Return name
                End If
            Next
        End If


    End Function

    Public Overrides Sub add(r As PEntry)

        list.Add(r)

    End Sub




    Public Overrides Sub print()

        Console.WriteLine(" " & sceneName)

        For Each entry As PEntry In list

            entry.print()

        Next

    End Sub

    Public Overrides Sub clear()

        list.Clear()

        For Each entry As PEntry In list

            entry.clear()

        Next


    End Sub
    Public Function getChildKongjong(ByVal childKey_ As Integer) As Kongjung

        Dim childkongjung As Kongjung = Nothing

        For Each entry As PEntry In list

            If entry.getUniqueIDX() = childKey_ Then
                childkongjung = entry
            End If

        Next

        Return childkongjung

    End Function

    Public Function check(ByVal childKey_ As Integer) As Boolean

        Dim result As Boolean = False

        For Each entry As PEntry In list

            If entry.getUniqueIDX() = childKey_ Then
                result = True
            End If

        Next

        Return result

    End Function

    Public Overrides Function getParentIDX(childkey_ As Integer) As Integer

        If childkey_ = Idx Then
            Return 0
        Else
            For Each entry As PEntry In list
                Dim pidx As Integer = entry.getParentIDX(childkey_)

                If pidx <> 0 Then
                    Return pidx
                End If
            Next
        End If


    End Function

    Public Overrides Function getParentIDX() As Integer

        Return 0

    End Function

    Public Overrides Function getList() As ArrayList

        Return list

    End Function

    Public Overrides Sub Addton(idx As Integer, r As Double)


    End Sub

    Public Overrides Function getTon() As Double

        Dim ton As Double = 0.0

        For Each entry As PEntry In list

            ton += entry.getTon()
        Next

        Return ton

    End Function
End Class
