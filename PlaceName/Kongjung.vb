
Public Class Kongjung : Inherits PEntry
    Private parentIdx As Integer
    Private idx As Integer
    Private kongjungName As String
    Private list As New ArrayList

    Public Sub New(key_ As Integer, name As String)

        Me.idx = key_
        Me.kongjungName = name

    End Sub
    Public Sub New(pkey_ As Integer, key_ As Integer, name As String)

        Me.parentIdx = pkey_
        Me.idx = key_
        Me.kongjungName = name

    End Sub
    Public Function checkByPartName(part_ As String) As Boolean

        Dim result As Boolean = False

        For Each entry As PEntry In list
            Dim tempName As String = entry.getName()

            If tempName.CompareTo(part_) = 0 Then
                result = True
            End If

        Next

        Return result

    End Function

    Public Overrides Sub accept(v As PVisitor)
        v.visit(Me)
    End Sub
    Public Overrides Function getUniqueIDX() As Integer
        Return idx
    End Function
    Public Overrides Function getParentIDX() As Integer

        Return parentIdx

    End Function
    Public Overrides Function getParentIDX(childkey_ As Integer) As Integer

        If childkey_ = idx Then
            Return parentIdx
        Else
            For Each entry As PEntry In list
                Dim pidx As Integer = entry.getParentIDX(childkey_)

                If pidx <> 0 Then
                    Return pidx
                End If
            Next
        End If

    End Function
    Public Overrides Function getName() As String

        Return kongjungName

    End Function

    Public Overrides Function getName(key_ As Integer) As String

        If key_ = idx Then
            Return kongjungName
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

        Console.WriteLine("  " & kongjungName)

        For Each entry As PEntry In list

            entry.print()

        Next

    End Sub

    Public Overrides Sub clear()

        list.Clear()

    End Sub

    Public Overrides Function getList() As ArrayList

        Return list

    End Function

    Public Overrides Sub Addton(idx As Integer, r As Double)

        For Each entry As PEntry In list

            entry.Addton(idx, r)

        Next

    End Sub

    Public Overrides Function getTon() As Double

        Dim ton As Double = 0.0

        For Each entry As PEntry In list

            ton += entry.getTon()
        Next

        Return ton

    End Function
End Class
