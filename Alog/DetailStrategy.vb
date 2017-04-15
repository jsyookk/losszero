Public Interface DetailStrategy
    Function find(base As BaseData, ByRef list As ArrayList) As Boolean
    Function totalSaveMoney() As Integer
    Sub complete()


End Interface
