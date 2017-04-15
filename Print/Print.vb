Public MustInherit Class Print

    Public MustOverride Sub open()
    Public MustOverride Sub show()
    Public MustOverride Sub close()

    Public Sub display()

        open()

        show()

        close()

    End Sub

End Class

