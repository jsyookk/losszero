Imports Losszero


Public Class BaseFilterDefaultFactory : Implements BaseFilterFactory

    Public Function makeBaseFilter() As BaseFilter Implements BaseFilterFactory.makeBaseFilter

        Dim nofilter As BaseFilter = New BaseNoFilter()
        Dim dimenfilter As BaseFilter = New BaseDimenFilter()
        Dim nocoilfilter As BaseFilter = New BaseNoCoilFilter()
        Dim linefilter As BaseFilter = New BaseLineFilter()
        Dim tonfilter As BaseFilter = New BaseFilterTonFilter()

        '사슬 연결
        nofilter.setNext(nocoilfilter).setNext(dimenfilter).setNext(linefilter).setNext(tonfilter)

        Return nofilter

    End Function

    Public Function makeCoilFilter() As CoilFilter Implements BaseFilterFactory.makeCoilFilter

        Dim nofilter As CoilFilter = New CoilNoFilter()
        Dim shapefilter As CoilFilter = New CoilShapeFilter()
        Dim lenfilter As CoilFilter = New CoilLenFilter()
        Dim hdmfilter As CoilFilter = New CoilHdmFilter()

        nofilter.createHashTb()
        nofilter.setNext(hdmfilter).setNext(shapefilter).setNext(lenfilter)

        Return nofilter

    End Function


End Class
