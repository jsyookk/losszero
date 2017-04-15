Public NotInheritable Class ShapeList

    Private Shared _thisInstance As ShapeList = Nothing
    Dim imglist As New ImageList()
    Dim thumbnailImgList As New ImageList()
    Dim imghashmap As New Hashtable
    Private shapelist As New Collection
    Dim errImg As Image
    Dim sumerrImage As Image

    Private Sub New()

    End Sub
    Public Sub createShapeImgList()

        imglist.ImageSize = New Size(220, 70)
        thumbnailImgList.ImageSize = New Size(198, 63)
        errImg = Image.FromFile(My.Application.Info.DirectoryPath & "\shape\" & "0.gif")


        Dim idx As Integer = 0


        For Each shape As Shape In shapelist
            imglist.Images.Add(Image.FromFile(My.Application.Info.DirectoryPath & "\shape\" & shape.fileName))
            imghashmap.Add(shape.shapeNUM, idx)
            thumbnailImgList.Images.Add(imglist.Images.Item(idx))
            idx += 1
        Next

    End Sub
    Public Function getShapeImg(key As Integer) As Image

        If imghashmap.ContainsKey(key) Then
            Dim idx As Integer = imghashmap.Item(key)
            Return thumbnailImgList.Images.Item(idx)
        Else
            Return errImg
        End If

    End Function
    Public Function getShapethumbnailImg(key As Integer) As Image



        If imghashmap.ContainsKey(key) Then
            Dim idx As Integer = imghashmap.Item(key)
            Return thumbnailImgList.Images.Item(idx)
        Else
            Return errImg
        End If



    End Function
    Public Function getShapethumbnailImgSize() As Size

        Return thumbnailImgList.Images.Item(1).Size

    End Function
    Public Function getShapeImgs() As ImageList

        Return imglist

    End Function

    Public Function getList() As Collection

        Return shapelist

    End Function

    Public Sub Add(ByRef shp_ As Shape)

        shapelist.Add(shp_)

    End Sub

    Public Sub remove(idx_ As Integer)

        shapelist.Remove(idx_)

    End Sub

    Public Function getItem(idx_ As Integer) As Shape

        Return shapelist.Item(idx_)

    End Function

    Public Function count() As Long

        Return shapelist.Count

    End Function

    Public Sub clear()

        shapelist.Clear()

    End Sub

    Public Sub edit(idx_ As Integer, curveCNT As Integer, correct As Integer)

        CType(shapelist.Item(idx_), Shape).curveCNT = curveCNT
        CType(shapelist.Item(idx_), Shape).correct = correct

    End Sub

    Public Shared ReadOnly Property GetInstance As ShapeList

        Get
            If _thisInstance Is Nothing Then
                _thisInstance = New ShapeList
            End If

            Return _thisInstance
        End Get

    End Property
End Class

