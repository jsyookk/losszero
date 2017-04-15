<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MatchCard
    Inherits System.Windows.Forms.UserControl

    'UserControl은 Dispose를 재정의하여 구성 요소 목록을 정리합니다.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows Form 디자이너에 필요합니다.
    Private components As System.ComponentModel.IContainer

    '참고: 다음 프로시저는 Windows Form 디자이너에 필요합니다.
    '수정하려면 Windows Form 디자이너를 사용하십시오.  
    '코드 편집기에서는 수정하지 마세요.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MatchCard))
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.BunifuCards1 = New Bunifu.Framework.UI.BunifuCards()
        Me.uniqueChk = New Bunifu.Framework.UI.BunifuCheckbox()
        Me.BunifuSeparator2 = New Bunifu.Framework.UI.BunifuSeparator()
        Me.BunifuSeparator1 = New Bunifu.Framework.UI.BunifuSeparator()
        Me.BunifuCustomLabel6 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.uniqueLB = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.titleLB = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomDataGrid1 = New Bunifu.Framework.UI.BunifuCustomDataGrid()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.saveMoneyLB = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.lossLB = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.graphBTN = New Bunifu.Framework.UI.BunifuImageButton()
        Me.BunifuCards1.SuspendLayout()
        CType(Me.BunifuCustomDataGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.graphBTN, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 5
        Me.BunifuElipse1.TargetControl = Me
        '
        'BunifuCards1
        '
        Me.BunifuCards1.BackColor = System.Drawing.Color.White
        Me.BunifuCards1.BorderRadius = 20
        Me.BunifuCards1.BottomSahddow = True
        Me.BunifuCards1.color = System.Drawing.Color.Orange
        Me.BunifuCards1.Controls.Add(Me.uniqueChk)
        Me.BunifuCards1.Controls.Add(Me.BunifuSeparator2)
        Me.BunifuCards1.Controls.Add(Me.BunifuSeparator1)
        Me.BunifuCards1.Controls.Add(Me.BunifuCustomLabel6)
        Me.BunifuCards1.Controls.Add(Me.BunifuCustomLabel1)
        Me.BunifuCards1.Controls.Add(Me.uniqueLB)
        Me.BunifuCards1.Controls.Add(Me.titleLB)
        Me.BunifuCards1.Controls.Add(Me.BunifuCustomDataGrid1)
        Me.BunifuCards1.Controls.Add(Me.saveMoneyLB)
        Me.BunifuCards1.Controls.Add(Me.lossLB)
        Me.BunifuCards1.Controls.Add(Me.graphBTN)
        Me.BunifuCards1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BunifuCards1.LeftSahddow = False
        Me.BunifuCards1.Location = New System.Drawing.Point(0, 0)
        Me.BunifuCards1.Name = "BunifuCards1"
        Me.BunifuCards1.RightSahddow = True
        Me.BunifuCards1.ShadowDepth = 20
        Me.BunifuCards1.Size = New System.Drawing.Size(612, 444)
        Me.BunifuCards1.TabIndex = 0
        '
        'uniqueChk
        '
        Me.uniqueChk.BackColor = System.Drawing.Color.Black
        Me.uniqueChk.ChechedOffColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.uniqueChk.Checked = True
        Me.uniqueChk.CheckedOnColor = System.Drawing.Color.Black
        Me.uniqueChk.ForeColor = System.Drawing.Color.White
        Me.uniqueChk.Location = New System.Drawing.Point(106, 48)
        Me.uniqueChk.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.uniqueChk.Name = "uniqueChk"
        Me.uniqueChk.Size = New System.Drawing.Size(20, 20)
        Me.uniqueChk.TabIndex = 12
        '
        'BunifuSeparator2
        '
        Me.BunifuSeparator2.BackColor = System.Drawing.Color.Transparent
        Me.BunifuSeparator2.LineColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.BunifuSeparator2.LineThickness = 1
        Me.BunifuSeparator2.Location = New System.Drawing.Point(442, 66)
        Me.BunifuSeparator2.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.BunifuSeparator2.Name = "BunifuSeparator2"
        Me.BunifuSeparator2.Size = New System.Drawing.Size(167, 10)
        Me.BunifuSeparator2.TabIndex = 11
        Me.BunifuSeparator2.Transparency = 255
        Me.BunifuSeparator2.Vertical = False
        '
        'BunifuSeparator1
        '
        Me.BunifuSeparator1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.BunifuSeparator1.LineThickness = 1
        Me.BunifuSeparator1.Location = New System.Drawing.Point(856, 95)
        Me.BunifuSeparator1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.BunifuSeparator1.Name = "BunifuSeparator1"
        Me.BunifuSeparator1.Size = New System.Drawing.Size(426, 40)
        Me.BunifuSeparator1.TabIndex = 10
        Me.BunifuSeparator1.Transparency = 255
        Me.BunifuSeparator1.Vertical = False
        '
        'BunifuCustomLabel6
        '
        Me.BunifuCustomLabel6.AutoSize = True
        Me.BunifuCustomLabel6.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.BunifuCustomLabel6.Location = New System.Drawing.Point(528, 48)
        Me.BunifuCustomLabel6.Name = "BunifuCustomLabel6"
        Me.BunifuCustomLabel6.Size = New System.Drawing.Size(67, 15)
        Me.BunifuCustomLabel6.TabIndex = 9
        Me.BunifuCustomLabel6.Text = "절약금액"
        '
        'BunifuCustomLabel1
        '
        Me.BunifuCustomLabel1.AutoSize = True
        Me.BunifuCustomLabel1.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.BunifuCustomLabel1.Location = New System.Drawing.Point(449, 48)
        Me.BunifuCustomLabel1.Name = "BunifuCustomLabel1"
        Me.BunifuCustomLabel1.Size = New System.Drawing.Size(37, 15)
        Me.BunifuCustomLabel1.TabIndex = 8
        Me.BunifuCustomLabel1.Text = "로스"
        '
        'uniqueLB
        '
        Me.uniqueLB.AutoSize = True
        Me.uniqueLB.BackColor = System.Drawing.Color.Silver
        Me.uniqueLB.Font = New System.Drawing.Font("굴림", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.uniqueLB.ForeColor = System.Drawing.Color.Red
        Me.uniqueLB.Location = New System.Drawing.Point(374, 65)
        Me.uniqueLB.Name = "uniqueLB"
        Me.uniqueLB.Size = New System.Drawing.Size(57, 28)
        Me.uniqueLB.TabIndex = 7
        Me.uniqueLB.Text = "MD"
        '
        'titleLB
        '
        Me.titleLB.AutoSize = True
        Me.titleLB.Font = New System.Drawing.Font("굴림", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.titleLB.Location = New System.Drawing.Point(133, 48)
        Me.titleLB.Name = "titleLB"
        Me.titleLB.Size = New System.Drawing.Size(204, 24)
        Me.titleLB.TabIndex = 6
        Me.titleLB.Text = "UHD16 * 8M * 3t"
        '
        'BunifuCustomDataGrid1
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.BunifuCustomDataGrid1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.BunifuCustomDataGrid1.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.BunifuCustomDataGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.BunifuCustomDataGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.SeaGreen
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.BunifuCustomDataGrid1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.BunifuCustomDataGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.BunifuCustomDataGrid1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7})
        Me.BunifuCustomDataGrid1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BunifuCustomDataGrid1.DoubleBuffered = True
        Me.BunifuCustomDataGrid1.EnableHeadersVisualStyles = False
        Me.BunifuCustomDataGrid1.HeaderBgColor = System.Drawing.Color.SeaGreen
        Me.BunifuCustomDataGrid1.HeaderForeColor = System.Drawing.Color.White
        Me.BunifuCustomDataGrid1.Location = New System.Drawing.Point(0, 133)
        Me.BunifuCustomDataGrid1.Name = "BunifuCustomDataGrid1"
        Me.BunifuCustomDataGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.BunifuCustomDataGrid1.RowTemplate.Height = 27
        Me.BunifuCustomDataGrid1.Size = New System.Drawing.Size(612, 311)
        Me.BunifuCustomDataGrid1.TabIndex = 5
        '
        'Column1
        '
        Me.Column1.HeaderText = "그룹"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "식별자"
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.HeaderText = "현장"
        Me.Column3.Name = "Column3"
        '
        'Column4
        '
        Me.Column4.HeaderText = "공사명"
        Me.Column4.Name = "Column4"
        '
        'Column5
        '
        Me.Column5.HeaderText = "부위"
        Me.Column5.Name = "Column5"
        '
        'Column6
        '
        Me.Column6.HeaderText = "길이"
        Me.Column6.Name = "Column6"
        '
        'Column7
        '
        Me.Column7.HeaderText = "컷팅"
        Me.Column7.Name = "Column7"
        '
        'saveMoneyLB
        '
        Me.saveMoneyLB.AutoSize = True
        Me.saveMoneyLB.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.saveMoneyLB.Location = New System.Drawing.Point(537, 78)
        Me.saveMoneyLB.Name = "saveMoneyLB"
        Me.saveMoneyLB.Size = New System.Drawing.Size(47, 15)
        Me.saveMoneyLB.TabIndex = 4
        Me.saveMoneyLB.Text = "35000"
        '
        'lossLB
        '
        Me.lossLB.AutoSize = True
        Me.lossLB.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.lossLB.Location = New System.Drawing.Point(447, 78)
        Me.lossLB.Name = "lossLB"
        Me.lossLB.Size = New System.Drawing.Size(39, 15)
        Me.lossLB.TabIndex = 3
        Me.lossLB.Text = "1.2%"
        '
        'graphBTN
        '
        Me.graphBTN.BackColor = System.Drawing.Color.Transparent
        Me.graphBTN.Image = CType(resources.GetObject("graphBTN.Image"), System.Drawing.Image)
        Me.graphBTN.ImageActive = Nothing
        Me.graphBTN.Location = New System.Drawing.Point(20, 30)
        Me.graphBTN.Name = "graphBTN"
        Me.graphBTN.Size = New System.Drawing.Size(35, 42)
        Me.graphBTN.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.graphBTN.TabIndex = 1
        Me.graphBTN.TabStop = False
        Me.graphBTN.Zoom = 10
        '
        'MatchCard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.BunifuCards1)
        Me.Name = "MatchCard"
        Me.Size = New System.Drawing.Size(612, 444)
        Me.BunifuCards1.ResumeLayout(False)
        Me.BunifuCards1.PerformLayout()
        CType(Me.BunifuCustomDataGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.graphBTN, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents BunifuCards1 As Bunifu.Framework.UI.BunifuCards
    Friend WithEvents uniqueLB As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents titleLB As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomDataGrid1 As Bunifu.Framework.UI.BunifuCustomDataGrid
    Friend WithEvents saveMoneyLB As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents lossLB As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents graphBTN As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents BunifuSeparator2 As Bunifu.Framework.UI.BunifuSeparator
    Friend WithEvents BunifuSeparator1 As Bunifu.Framework.UI.BunifuSeparator
    Friend WithEvents BunifuCustomLabel6 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents uniqueChk As Bunifu.Framework.UI.BunifuCheckbox
End Class
