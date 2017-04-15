
Public Class Part : Inherits PEntry

    Private parentIdx As Integer
    Private idx As Integer
    Private partName As String
    Private ton As Double

    Public Sub New(key_ As Integer, name As String)


        Me.idx = key_
        Me.partName = name

    End Sub
    Public Sub New(pkey_ As Integer, key_ As Integer, name As String)

        Me.parentIdx = pkey_
        Me.idx = key_
        Me.partName = name

    End Sub
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

        If idx = childkey_ Then
            Return parentIdx
        Else
            Return 0
        End If

    End Function
    Public Overrides Function getName() As String

        Return partName

    End Function

    Public Overrides Function getName(key_ As Integer) As String

        If key_ = idx Then
            Return partName
        Else
            Return Nothing

        End If

    End Function

    Public Overrides Sub add(r As PEntry)

    End Sub


    Public Overrides Sub print()

        Console.WriteLine("   " & partName)

    End Sub

    Public Overrides Sub clear()



    End Sub

    Public Overrides Function getList() As ArrayList


    End Function

    Public Overrides Sub Addton(idx As Integer, r As Double)

        If Me.idx = idx Then
            Me.ton += r
        End If

    End Sub

    Public Overrides Function getTon() As Double

        Return Math.Round(Me.ton, 2)

    End Function

End Class
