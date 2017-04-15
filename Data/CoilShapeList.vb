Public Class CoilShapeList


    Private Shared _thisInstance As CoilShapeList = Nothing

    Private coilshapelist As New Collection

    Private Sub New()

    End Sub

    Public Sub Add(ByRef shp_ As CoilShape)

        coilshapelist.Add(shp_)

    End Sub
    Public Sub editAllLen(len As Integer)

        For Each coil As CoilShape In coilshapelist
            coil.OneLEN = len
        Next

    End Sub
    Public Function check(shapeNum As Integer) As Boolean


        For Each coil As CoilShape In coilshapelist
            If coil.shapeNUM = shapeNum Then
                Return True
            End If

        Next

        Return False

    End Function

    Public Sub edit(idx_ As Integer, len As Integer)

        CType(coilshapelist.Item(idx_), CoilShape).OneLEN = len

    End Sub

    Public Sub remove(idx_ As Integer)

        coilshapelist.Remove(idx_)

    End Sub

    Public Function getItem(idx_ As Integer) As CoilShape

        Return coilshapelist.Item(idx_)

    End Function

    Public Function count() As Long

        Return coilshapelist.Count

    End Function

    Public Sub clear()

        coilshapelist.Clear()

    End Sub

    Public Shared ReadOnly Property GetInstance As CoilShapeList

        Get
            If _thisInstance Is Nothing Then
                _thisInstance = New CoilShapeList
            End If

            Return _thisInstance
        End Get

    End Property


End Class

