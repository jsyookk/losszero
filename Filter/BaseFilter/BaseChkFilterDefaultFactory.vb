

Imports Losszero

Public Class BaseChkFilterDefaultFactory : Implements BaseChkFilterFactory

    Public Function makeBaseCHKFilter() As BaseChkFilter Implements BaseChkFilterFactory.makeBaseCHKFilter

        Dim noFilter As BaseChkFilter = New BaseChkNoFilter()
        Dim basefilter As BaseChkFilter = New BaseChkisBaseFilter()
        Dim nocoilfilter As BaseChkFilter = New BaseChkNoCoilFilter()
        Dim noprcfilter As BaseChkFilter = New BaseChkNoneProcessFilter()

        noFilter.setNext(basefilter).setNext(noprcfilter).setNext(nocoilfilter)

        Return noFilter

    End Function

    Public Function makeBaseTonManyFilter() As BaseChkFilter Implements BaseChkFilterFactory.makeBaseTonManyFilter

        Dim noFilter As BaseChkFilter = New BaseChkNoFilter()
        Dim basefilter As BaseChkFilter = New BaseChkisBaseFilter()
        Dim nocoilfilter As BaseChkFilter = New BaseChkNoCoilFilter()
        Dim noprcfilter As BaseChkFilter = New BaseChkNoneProcessFilter()
        Dim tonmanyfilter As BaseChkFilter = New BaseChkTonManyFilter()

        noFilter.setNext(basefilter).setNext(noprcfilter).setNext(nocoilfilter).setNext(tonmanyfilter)

        Return noFilter

    End Function
    Public Function makeRemainBaseCHKFilter() As BaseChkFilter Implements BaseChkFilterFactory.makeRemainBaseCHKFilter

        Dim noFilter As BaseChkFilter = New BaseChkNoFilter()
        ' Dim basefilter As BaseChkFilter = New BaseChkisBaseFilter()
        Dim nocoilfilter As BaseChkFilter = New BaseChkNoCoilFilter()
        Dim noprcfilter As BaseChkFilter = New BaseChkNoneProcessFilter()

        noFilter.setNext(noprcfilter).setNext(nocoilfilter)

        Return noFilter


    End Function

    Public Function makeLinkedBaseCHKFilter() As BaseChkFilter Implements BaseChkFilterFactory.makeLinkedBaseCHKFilter

        Dim noFilter As BaseChkFilter = New BaseChkNoFilter()
        Dim basefilter As BaseChkFilter = New BaseChkisBaseFilter()
        Dim nocoilfilter As BaseChkFilter = New BaseChkNoCoilFilter()
        Dim noprcfilter As BaseChkFilter = New BaseChkNoneProcessFilter()

        noFilter.setNext(noprcfilter).setNext(nocoilfilter).setNext(basefilter)

        Return noFilter


    End Function

    Public Function makeBaseNomatchCHKFilter() As BaseChkFilter Implements BaseChkFilterFactory.makeBaseNomatchCHKFilter

        Dim noFilter As BaseChkFilter = New BaseChkNoFilter()
        Dim basefilter As BaseChkFilter = New BaseChkisBaseFilter()
        Dim nocoilfilter As BaseChkFilter = New BaseChkNoCoilFilter()
        Dim noprcfilter As BaseChkFilter = New BaseChkNoneProcessFilter()

        noFilter.setNext(noprcfilter).setNext(nocoilfilter).setNext(basefilter)

        Return noFilter

    End Function

    Public Function makeNonBaseCHKFilter() As BaseChkFilter Implements BaseChkFilterFactory.makeNonBaseCHKFilter

        Dim noFilter As BaseChkFilter = New BaseChkNoFilter()
        Dim nocoilfilter As BaseChkFilter = New BaseChkNoCoilFilter()
        Dim noprcfilter As BaseChkFilter = New BaseChkNoneProcessFilter()

        noFilter.setNext(noprcfilter).setNext(nocoilfilter)

        Return noFilter

    End Function

    Public Function makeZangDaeCHKFilter() As BaseChkFilter Implements BaseChkFilterFactory.makeZangDaeCHKFilter


        Dim noFilter As BaseChkFilter = New BaseChkNoFilter()
        Dim basefilter As BaseChkFilter = New BaseChkisBaseFilter()
        Dim nocoilfilter As BaseChkFilter = New BaseChkNoCoilFilter()
        Dim noprcfilter As BaseChkFilter = New BaseChkNoneProcessFilter()
        Dim zangdaefilter As BaseChkFilter = New BaseZangDaeFilter()

        noFilter.setNext(noprcfilter).setNext(nocoilfilter).setNext(zangdaefilter).setNext(basefilter)

        Return noFilter


    End Function

    Public Function makeZumChkFilter() As BaseChkFilter Implements BaseChkFilterFactory.makeZumChkFilter


        Dim noFilter As BaseChkFilter = New BaseChkNoFilter()
        Dim basefilter As BaseChkFilter = New BaseChkisBaseFilter()
        Dim nocoilfilter As BaseChkFilter = New BaseChkNoCoilFilter()
        Dim noprcfilter As BaseChkFilter = New BaseChkNoneProcessFilter()
        Dim lenfilter As BaseChkFilter = New BaseChkZumLenFilter()

        noFilter.setNext(noprcfilter).setNext(nocoilfilter).setNext(lenfilter)

        Return noFilter

    End Function
End Class
