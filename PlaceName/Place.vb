Public Class Place
    Enum CLASS_ENUM

        SCENE
        KONGJUNG
        PART

    End Enum


    Private _root As New Scene()
    Private Shared _thisInstance As Place = Nothing


    Private Sub New()

    End Sub

    Public Sub search(ByRef v As PVisitor)

        _root.accept(v)

    End Sub

    Public Function getParentIdx(ckey_ As Integer) As String

        Return _root.getParentIDX(ckey_)

    End Function
    Public Function getMyName(key_ As Integer) As String

        Return _root.getName(key_)

    End Function

    Public Sub clear()

        _root.clear()

    End Sub

    Public Sub print()

        'Dim s1 As New Scene(1, "대림 현장")
        'Dim k1 As New Kongjung(2, "202동 계단")
        'Dim k2 As New Kongjung(3, "202동 지하주차장")
        'Dim p1 As New Part(4, "계단1")
        'Dim p2 As New Part(5, "계단2")
        'Dim p3 As New Part(6, "계단3")
        'Dim p4 As New Part(7, "계단4")
        'Dim p5 As New Part(8, "지하슬라브1")



        'k1.add(p1)
        'k1.add(p2)
        'k1.add(p3)
        'k1.add(p4)
        'k2.add(p5)

        's1.add(k1)
        's1.add(k2)

        '_root.add(s1)

        _root.print()

    End Sub

    Public Sub classify(key As Integer, name As String, type As CLASS_ENUM)

        Select Case type
            Case CLASS_ENUM.SCENE

        End Select


    End Sub
    Public Sub add(type As CLASS_ENUM, entry As PEntry)

        Select Case type
            Case CLASS_ENUM.SCENE
                _root.add(entry)
        End Select


    End Sub

    Public Shared ReadOnly Property GetInstance As Place

        Get
            If _thisInstance Is Nothing Then
                _thisInstance = New Place
            End If

            Return _thisInstance
        End Get

    End Property
End Class
