Public Interface Alog

    Enum METER_CAT
        STOCK_METER
        STANDARD_METER
    End Enum

    Function find(ByRef base As BaseData) As Boolean
    Function find(ByRef base As BaseData, ByRef list As ArrayList) As Boolean
    Function check(ByVal loss As Double) As Boolean

End Interface
