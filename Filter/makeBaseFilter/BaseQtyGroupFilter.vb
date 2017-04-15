
Public Class BaseQtyGroupFilter : Inherits BaseFilter

    Protected Overrides Function check(ste As Steel) As Boolean

        ste.QtyGroup = Fix(ste.Qty / 100)

        Return True

    End Function


End Class
