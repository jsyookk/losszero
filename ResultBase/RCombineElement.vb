Public MustInherit Class RCombineElement

    Protected depth As Integer = 0

    Public MustOverride Sub add(element As RCombineElement)
    Public MustOverride Sub Remove(element As RCombineElement)
    Public MustOverride Function getOrignalTon(ByRef oton As Double) As Double
    Public MustOverride Function getOrignalTon(ByRef hash As Hashtable) As Hashtable
    Public MustOverride Sub ElementCount(type_ As RCombine.CBType, ByRef cnt As Integer)
    Public MustOverride Sub getSteMAXCount(ByRef cnt As Integer)
    Public MustOverride Sub display()
    Public MustOverride Function getList() As List(Of RCombineElement)
    Public MustOverride Sub clearUniqueNumber()
    Public MustOverride Sub setUniqueNumber(uniqueStr As String, maxCNT As Integer, ByRef cntNUM As Integer, usemeter As Double, needTon As Double, ByRef hash As Hashtable)



End Class

