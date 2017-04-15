Public Class InputDataControl
    Public Shared frmShape As ShapeListForm
    Public Shared frmCoil As CoilListForm
    Public Shared frmStock As StockForm

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

        'If Application.OpenForms().OfType(Of ShapeListForm).Any Then
        '    ShapeListForm.Activate()
        'Else
        '    ShapeListForm.Show()
        'End If

        If InputDataControl.frmShape Is Nothing Then
            InputDataControl.frmShape = New ShapeListForm()
        End If

        InputDataControl.frmShape.Show()
        InputDataControl.frmShape.Activate()


    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        'If Application.OpenForms().OfType(Of CoilListForm).Any Then
        '    CoilListForm.Activate()
        'Else
        '    CoilListForm.Show()
        'End If

        If InputDataControl.frmCoil Is Nothing Then
            InputDataControl.frmCoil = New CoilListForm()
        End If

        InputDataControl.frmCoil.Show()
        InputDataControl.frmCoil.Activate()

    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        'If Application.OpenForms().OfType(Of StockForm).Any Then
        '    StockForm.Activate()
        'Else
        '    StockForm.Show()
        'End If


        If InputDataControl.frmStock Is Nothing Then
            InputDataControl.frmStock = New StockForm()
        End If

        InputDataControl.frmStock.Show()
        InputDataControl.frmStock.Activate()

    End Sub
End Class
