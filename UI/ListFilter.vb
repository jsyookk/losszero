Public Class ListFilter

    Enum LIST_TYPE
        RENTRY
        BASEDATA
    End Enum

    Dim type As LIST_TYPE
    Dim originList As ArrayList
    Dim filterlist As New ArrayList

    Public Sub New(type As LIST_TYPE, list As ArrayList)

        ' 디자이너에서 이 호출이 필요합니다.
        InitializeComponent()
        Me.type = type
        originList = list
        ' InitializeComponent() 호출 뒤에 초기화 코드를 추가하세요.

    End Sub

    Public Function filterdList() As ArrayList


        Dim selectHard As Integer
        Dim selectDimen As Integer
        Dim ton As Double


        Select Case BunifuDropdown1.selectedIndex
            Case 0
                selectHard = 0
            Case 1
                selectHard = 400
            Case 2
                selectHard = 500
            Case 3
                selectHard = 600
        End Select

        Select Case BunifuDropdown2.selectedIndex
            Case 0
                selectDimen = 0
            Case 1
                selectDimen = 10
            Case 2
                selectDimen = 13
            Case 3
                selectDimen = 16
            Case 4
                selectDimen = 19
            Case 5
                selectDimen = 22
            Case 6
                selectDimen = 25
            Case 7
                selectDimen = 29
            Case 8
                selectDimen = 32

        End Select

        If TextBox1.Text Is Nothing Then
            ton = 0
        Else
            ton = CDbl(TextBox1.Text)
        End If

        If type = LIST_TYPE.RENTRY Then

            Dim rnofilter As New REntryNofilter()
            Dim rdimenfilter As New REntryDimen(selectDimen)
            Dim rhardfilter As New REntryHard(selectHard)
            Dim rtonfilter As New REntryTon(ton)

            rnofilter.setNext(rdimenfilter).setNext(rhardfilter).setNext(rtonfilter)

            For Each rb As RRebar In originList


                If rnofilter.filtering(rb) = True Then
                    filterlist.Add(rb)
                End If

            Next

            Return filterlist
        ElseIf type = LIST_TYPE.BASEDATA Then

            Dim nofilter As New BaseChkNoFilter()
            Dim dimenfilter As New BaseDimenSearh(selectDimen)
            Dim hardfilter As New BaseHardSearch(selectHard)
            Dim tonfilter As New BaseTonSearch(ton)

            nofilter.setNext(dimenfilter).setNext(hardfilter).setNext(tonfilter)

            For Each rbase As BaseData In originList


                If nofilter.filtering(rbase) = True Then
                    filterlist.Add(rbase)
                End If

            Next


            Return filterlist

        End If





    End Function

    Private Sub BunifuImageButton1_Click(sender As Object, e As EventArgs) Handles BunifuImageButton1.Click
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub

    Private Sub BunifuImageButton2_Click(sender As Object, e As EventArgs) Handles BunifuImageButton2.Click

        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Dispose()

    End Sub
End Class