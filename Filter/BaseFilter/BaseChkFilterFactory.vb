Public Interface BaseChkFilterFactory

    Function makeBaseCHKFilter() As BaseChkFilter
    Function makeRemainBaseCHKFilter() As BaseChkFilter
    Function makeLinkedBaseCHKFilter() As BaseChkFilter
    Function makeBaseNomatchCHKFilter() As BaseChkFilter
    Function makeNonBaseCHKFilter() As BaseChkFilter
    Function makeZangDaeCHKFilter() As BaseChkFilter
    Function makeBaseTonManyFilter() As BaseChkFilter

    Function makeZumChkFilter() As BaseChkFilter

End Interface
