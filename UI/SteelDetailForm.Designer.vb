<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SteelDetailForm
    Inherits System.Windows.Forms.Form

    'Form은 Dispose를 재정의하여 구성 요소 목록을 정리합니다.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SteelDetailForm))
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.topPanel = New System.Windows.Forms.Panel()
        Me.BunifuCustomLabel1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuImageButton1 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.BunifuDragControl1 = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.sceneLB = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.placeLB = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuSeparator1 = New Bunifu.Framework.UI.BunifuSeparator()
        Me.BunifuSeparator2 = New Bunifu.Framework.UI.BunifuSeparator()
        Me.partLB = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuSeparator3 = New Bunifu.Framework.UI.BunifuSeparator()
        Me.hdmLB = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.sdLB = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.lenLB = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.rlenLB = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel6 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.qtyLB = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel8 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader10 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.BunifuCustomLabel9 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.kgLB = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel2 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.etcLB = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.topPanel.SuspendLayout()
        CType(Me.BunifuImageButton1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 5
        Me.BunifuElipse1.TargetControl = Me
        '
        'topPanel
        '
        Me.topPanel.BackColor = System.Drawing.Color.White
        Me.topPanel.Controls.Add(Me.BunifuCustomLabel1)
        Me.topPanel.Controls.Add(Me.BunifuImageButton1)
        Me.topPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.topPanel.Location = New System.Drawing.Point(0, 0)
        Me.topPanel.Name = "topPanel"
        Me.topPanel.Size = New System.Drawing.Size(366, 45)
        Me.topPanel.TabIndex = 0
        '
        'BunifuCustomLabel1
        '
        Me.BunifuCustomLabel1.AutoSize = True
        Me.BunifuCustomLabel1.Location = New System.Drawing.Point(12, 15)
        Me.BunifuCustomLabel1.Name = "BunifuCustomLabel1"
        Me.BunifuCustomLabel1.Size = New System.Drawing.Size(52, 15)
        Me.BunifuCustomLabel1.TabIndex = 1
        Me.BunifuCustomLabel1.Text = "꼬리표"
        '
        'BunifuImageButton1
        '
        Me.BunifuImageButton1.BackColor = System.Drawing.Color.Silver
        Me.BunifuImageButton1.Image = CType(resources.GetObject("BunifuImageButton1.Image"), System.Drawing.Image)
        Me.BunifuImageButton1.ImageActive = Nothing
        Me.BunifuImageButton1.Location = New System.Drawing.Point(323, 12)
        Me.BunifuImageButton1.Name = "BunifuImageButton1"
        Me.BunifuImageButton1.Size = New System.Drawing.Size(31, 29)
        Me.BunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.BunifuImageButton1.TabIndex = 0
        Me.BunifuImageButton1.TabStop = False
        Me.BunifuImageButton1.Zoom = 0
        '
        'BunifuDragControl1
        '
        Me.BunifuDragControl1.Fixed = True
        Me.BunifuDragControl1.Horizontal = True
        Me.BunifuDragControl1.TargetControl = Me.topPanel
        Me.BunifuDragControl1.Vertical = True
        '
        'sceneLB
        '
        Me.sceneLB.AutoSize = True
        Me.sceneLB.Font = New System.Drawing.Font("굴림", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.sceneLB.Location = New System.Drawing.Point(12, 60)
        Me.sceneLB.Name = "sceneLB"
        Me.sceneLB.Size = New System.Drawing.Size(44, 17)
        Me.sceneLB.TabIndex = 1
        Me.sceneLB.Text = "현장"
        '
        'placeLB
        '
        Me.placeLB.AutoSize = True
        Me.placeLB.Font = New System.Drawing.Font("굴림", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.placeLB.Location = New System.Drawing.Point(12, 94)
        Me.placeLB.Name = "placeLB"
        Me.placeLB.Size = New System.Drawing.Size(62, 17)
        Me.placeLB.TabIndex = 2
        Me.placeLB.Text = "공정명"
        '
        'BunifuSeparator1
        '
        Me.BunifuSeparator1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.BunifuSeparator1.LineThickness = 1
        Me.BunifuSeparator1.Location = New System.Drawing.Point(13, 60)
        Me.BunifuSeparator1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.BunifuSeparator1.Name = "BunifuSeparator1"
        Me.BunifuSeparator1.Size = New System.Drawing.Size(341, 40)
        Me.BunifuSeparator1.TabIndex = 3
        Me.BunifuSeparator1.Transparency = 255
        Me.BunifuSeparator1.Vertical = False
        '
        'BunifuSeparator2
        '
        Me.BunifuSeparator2.BackColor = System.Drawing.Color.Transparent
        Me.BunifuSeparator2.LineColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.BunifuSeparator2.LineThickness = 1
        Me.BunifuSeparator2.Location = New System.Drawing.Point(12, 97)
        Me.BunifuSeparator2.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.BunifuSeparator2.Name = "BunifuSeparator2"
        Me.BunifuSeparator2.Size = New System.Drawing.Size(341, 40)
        Me.BunifuSeparator2.TabIndex = 4
        Me.BunifuSeparator2.Transparency = 255
        Me.BunifuSeparator2.Vertical = False
        '
        'partLB
        '
        Me.partLB.AutoSize = True
        Me.partLB.Font = New System.Drawing.Font("굴림", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.partLB.Location = New System.Drawing.Point(12, 130)
        Me.partLB.Name = "partLB"
        Me.partLB.Size = New System.Drawing.Size(44, 17)
        Me.partLB.TabIndex = 5
        Me.partLB.Text = "부위"
        '
        'BunifuSeparator3
        '
        Me.BunifuSeparator3.BackColor = System.Drawing.Color.Transparent
        Me.BunifuSeparator3.LineColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.BunifuSeparator3.LineThickness = 1
        Me.BunifuSeparator3.Location = New System.Drawing.Point(12, 133)
        Me.BunifuSeparator3.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.BunifuSeparator3.Name = "BunifuSeparator3"
        Me.BunifuSeparator3.Size = New System.Drawing.Size(341, 40)
        Me.BunifuSeparator3.TabIndex = 6
        Me.BunifuSeparator3.Transparency = 255
        Me.BunifuSeparator3.Vertical = False
        '
        'hdmLB
        '
        Me.hdmLB.AutoSize = True
        Me.hdmLB.Font = New System.Drawing.Font("굴림", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.hdmLB.Location = New System.Drawing.Point(11, 170)
        Me.hdmLB.Name = "hdmLB"
        Me.hdmLB.Size = New System.Drawing.Size(74, 20)
        Me.hdmLB.TabIndex = 7
        Me.hdmLB.Text = "SHD10"
        '
        'sdLB
        '
        Me.sdLB.AutoSize = True
        Me.sdLB.Location = New System.Drawing.Point(13, 205)
        Me.sdLB.Name = "sdLB"
        Me.sdLB.Size = New System.Drawing.Size(51, 15)
        Me.sdLB.TabIndex = 8
        Me.sdLB.Text = "SD500"
        '
        'lenLB
        '
        Me.lenLB.AutoSize = True
        Me.lenLB.Font = New System.Drawing.Font("굴림", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.lenLB.Location = New System.Drawing.Point(151, 170)
        Me.lenLB.Name = "lenLB"
        Me.lenLB.Size = New System.Drawing.Size(57, 20)
        Me.lenLB.TabIndex = 9
        Me.lenLB.Text = "7000"
        '
        'rlenLB
        '
        Me.rlenLB.AutoSize = True
        Me.rlenLB.Location = New System.Drawing.Point(202, 205)
        Me.rlenLB.Name = "rlenLB"
        Me.rlenLB.Size = New System.Drawing.Size(39, 15)
        Me.rlenLB.TabIndex = 10
        Me.rlenLB.Text = "7000"
        '
        'BunifuCustomLabel6
        '
        Me.BunifuCustomLabel6.AutoSize = True
        Me.BunifuCustomLabel6.Location = New System.Drawing.Point(176, 205)
        Me.BunifuCustomLabel6.Name = "BunifuCustomLabel6"
        Me.BunifuCustomLabel6.Size = New System.Drawing.Size(28, 15)
        Me.BunifuCustomLabel6.TabIndex = 11
        Me.BunifuCustomLabel6.Text = "L'="
        '
        'qtyLB
        '
        Me.qtyLB.AutoSize = True
        Me.qtyLB.Font = New System.Drawing.Font("굴림", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.qtyLB.Location = New System.Drawing.Point(309, 171)
        Me.qtyLB.Name = "qtyLB"
        Me.qtyLB.Size = New System.Drawing.Size(33, 20)
        Me.qtyLB.TabIndex = 12
        Me.qtyLB.Text = "50"
        '
        'BunifuCustomLabel8
        '
        Me.BunifuCustomLabel8.AutoSize = True
        Me.BunifuCustomLabel8.Location = New System.Drawing.Point(317, 205)
        Me.BunifuCustomLabel8.Name = "BunifuCustomLabel8"
        Me.BunifuCustomLabel8.Size = New System.Drawing.Size(25, 15)
        Me.BunifuCustomLabel8.TabIndex = 13
        Me.BunifuCustomLabel8.Text = "EA"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox1.Location = New System.Drawing.Point(61, 260)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(260, 90)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 14
        Me.PictureBox1.TabStop = False
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader8, Me.ColumnHeader9, Me.ColumnHeader10})
        Me.ListView1.Location = New System.Drawing.Point(16, 383)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(330, 127)
        Me.ListView1.TabIndex = 15
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "A"
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "B"
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "C"
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "D"
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "E"
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "F"
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "G"
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "R1"
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "R2"
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "R3"
        '
        'BunifuCustomLabel9
        '
        Me.BunifuCustomLabel9.AutoSize = True
        Me.BunifuCustomLabel9.Location = New System.Drawing.Point(212, 176)
        Me.BunifuCustomLabel9.Name = "BunifuCustomLabel9"
        Me.BunifuCustomLabel9.Size = New System.Drawing.Size(29, 15)
        Me.BunifuCustomLabel9.TabIndex = 16
        Me.BunifuCustomLabel9.Text = "mm"
        '
        'kgLB
        '
        Me.kgLB.AutoSize = True
        Me.kgLB.Location = New System.Drawing.Point(280, 546)
        Me.kgLB.Name = "kgLB"
        Me.kgLB.Size = New System.Drawing.Size(23, 15)
        Me.kgLB.TabIndex = 17
        Me.kgLB.Text = "19"
        '
        'BunifuCustomLabel2
        '
        Me.BunifuCustomLabel2.AutoSize = True
        Me.BunifuCustomLabel2.Location = New System.Drawing.Point(320, 546)
        Me.BunifuCustomLabel2.Name = "BunifuCustomLabel2"
        Me.BunifuCustomLabel2.Size = New System.Drawing.Size(22, 15)
        Me.BunifuCustomLabel2.TabIndex = 18
        Me.BunifuCustomLabel2.Text = "kg"
        '
        'etcLB
        '
        Me.etcLB.AutoSize = True
        Me.etcLB.Location = New System.Drawing.Point(13, 546)
        Me.etcLB.Name = "etcLB"
        Me.etcLB.Size = New System.Drawing.Size(28, 15)
        Me.etcLB.TabIndex = 19
        Me.etcLB.Text = "Etc"
        '
        'SteelDetailForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(366, 584)
        Me.Controls.Add(Me.etcLB)
        Me.Controls.Add(Me.BunifuCustomLabel2)
        Me.Controls.Add(Me.kgLB)
        Me.Controls.Add(Me.BunifuCustomLabel9)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.BunifuCustomLabel8)
        Me.Controls.Add(Me.qtyLB)
        Me.Controls.Add(Me.BunifuCustomLabel6)
        Me.Controls.Add(Me.rlenLB)
        Me.Controls.Add(Me.lenLB)
        Me.Controls.Add(Me.sdLB)
        Me.Controls.Add(Me.hdmLB)
        Me.Controls.Add(Me.partLB)
        Me.Controls.Add(Me.placeLB)
        Me.Controls.Add(Me.sceneLB)
        Me.Controls.Add(Me.topPanel)
        Me.Controls.Add(Me.BunifuSeparator1)
        Me.Controls.Add(Me.BunifuSeparator2)
        Me.Controls.Add(Me.BunifuSeparator3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "SteelDetailForm"
        Me.Text = "SteelDetailForm"
        Me.topPanel.ResumeLayout(False)
        Me.topPanel.PerformLayout()
        CType(Me.BunifuImageButton1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents topPanel As Panel
    Friend WithEvents BunifuDragControl1 As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents BunifuCustomLabel9 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents ListView1 As ListView
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BunifuCustomLabel8 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents qtyLB As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel6 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents rlenLB As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents lenLB As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents sdLB As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents hdmLB As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents partLB As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents placeLB As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents sceneLB As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuImageButton1 As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents BunifuSeparator1 As Bunifu.Framework.UI.BunifuSeparator
    Friend WithEvents BunifuSeparator2 As Bunifu.Framework.UI.BunifuSeparator
    Friend WithEvents BunifuSeparator3 As Bunifu.Framework.UI.BunifuSeparator
    Friend WithEvents BunifuCustomLabel2 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents kgLB As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents ColumnHeader7 As ColumnHeader
    Friend WithEvents ColumnHeader8 As ColumnHeader
    Friend WithEvents ColumnHeader9 As ColumnHeader
    Friend WithEvents ColumnHeader10 As ColumnHeader
    Friend WithEvents etcLB As Bunifu.Framework.UI.BunifuCustomLabel
End Class
