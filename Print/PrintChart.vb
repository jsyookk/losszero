Imports System.Drawing.Printing
Imports System.Windows.Forms.DataVisualization.Charting

Public Class PrintChart : Inherits Print
    Dim print_document As New PrintDocument
    Private mschart As Chart
    Public Sub New(ch_ As Chart)
        mschart = ch_
    End Sub
    Public Overrides Sub close()



    End Sub

    Public Overrides Sub show()


    End Sub

    Private Function PreparePrintDocument() As PrintDocument

        AddHandler print_document.PrintPage, AddressOf printDetails

        Return print_document

    End Function
    Public Overrides Sub open()

        Dim dlgPrintPreview As PrintPreviewDialog = New PrintPreviewDialog()
        dlgPrintPreview.Document = PreparePrintDocument()
        dlgPrintPreview.WindowState = FormWindowState.Maximized
        'dlgPrintPreview.Document.DefaultPageSettings.Landscape = True

        dlgPrintPreview.ShowDialog()

    End Sub

    Private Sub printDetails(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs)


        Dim b As New Bitmap(mschart.Width, mschart.Height)
        mschart.DrawToBitmap(b, mschart.ClientRectangle)

        Dim ImgX As Integer
        Dim ImgY As Integer
        Dim PSizeX As Integer
        Dim PSizeY As Integer
        Dim ScaleX As Double
        Dim ScaleY As Double
        Dim RecX As Integer
        Dim RecY As Integer
        Dim ScaleM As Double

        ImgX = b.Height
        ImgY = b.Width

        If print_document.DefaultPageSettings.Landscape = False Then
            PSizeX = print_document.DefaultPageSettings.PaperSize.Height
            PSizeY = print_document.DefaultPageSettings.PaperSize.Width
        Else
            PSizeX = print_document.DefaultPageSettings.PaperSize.Width
            PSizeY = print_document.DefaultPageSettings.PaperSize.Height
        End If

        ScaleX = PSizeX / ImgX
        ScaleY = PSizeY / ImgY

        If ScaleX < ScaleY Then
            ScaleM = ScaleX
        Else
            ScaleM = ScaleY
        End If

        RecY = ImgY * ScaleM
        RecX = ImgX * ScaleM

        Dim startx As Integer = (PSizeY - RecY) / 2

        e.Graphics.DrawImage(b, startx, 0, RecY, RecX)

    End Sub


End Class
