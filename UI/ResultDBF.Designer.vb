<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ResultDBF
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ResultDBF))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BunifuImageButton1 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.kongjungBTN = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.sceneBTN = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Panel1.SuspendLayout()
        CType(Me.BunifuImageButton1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.Panel1.Controls.Add(Me.BunifuImageButton1)
        Me.Panel1.Controls.Add(Me.kongjungBTN)
        Me.Panel1.Controls.Add(Me.sceneBTN)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(289, 751)
        Me.Panel1.TabIndex = 0
        '
        'BunifuImageButton1
        '
        Me.BunifuImageButton1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuImageButton1.Image = CType(resources.GetObject("BunifuImageButton1.Image"), System.Drawing.Image)
        Me.BunifuImageButton1.ImageActive = Nothing
        Me.BunifuImageButton1.Location = New System.Drawing.Point(20, 18)
        Me.BunifuImageButton1.Name = "BunifuImageButton1"
        Me.BunifuImageButton1.Size = New System.Drawing.Size(38, 42)
        Me.BunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BunifuImageButton1.TabIndex = 2
        Me.BunifuImageButton1.TabStop = False
        Me.BunifuImageButton1.Zoom = 10
        '
        'kongjungBTN
        '
        Me.kongjungBTN.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.kongjungBTN.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.kongjungBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.kongjungBTN.BorderRadius = 0
        Me.kongjungBTN.ButtonText = "공정별 출력"
        Me.kongjungBTN.Cursor = System.Windows.Forms.Cursors.Hand
        Me.kongjungBTN.DisabledColor = System.Drawing.Color.Gray
        Me.kongjungBTN.Font = New System.Drawing.Font("굴림", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.kongjungBTN.Iconcolor = System.Drawing.Color.Transparent
        Me.kongjungBTN.Iconimage = CType(resources.GetObject("kongjungBTN.Iconimage"), System.Drawing.Image)
        Me.kongjungBTN.Iconimage_right = Nothing
        Me.kongjungBTN.Iconimage_right_Selected = Nothing
        Me.kongjungBTN.Iconimage_Selected = Nothing
        Me.kongjungBTN.IconMarginLeft = 0
        Me.kongjungBTN.IconMarginRight = 0
        Me.kongjungBTN.IconRightVisible = True
        Me.kongjungBTN.IconRightZoom = 0R
        Me.kongjungBTN.IconVisible = True
        Me.kongjungBTN.IconZoom = 90.0R
        Me.kongjungBTN.IsTab = False
        Me.kongjungBTN.Location = New System.Drawing.Point(20, 329)
        Me.kongjungBTN.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.kongjungBTN.Name = "kongjungBTN"
        Me.kongjungBTN.Normalcolor = System.Drawing.Color.DarkSeaGreen
        Me.kongjungBTN.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.kongjungBTN.OnHoverTextColor = System.Drawing.Color.White
        Me.kongjungBTN.selected = False
        Me.kongjungBTN.Size = New System.Drawing.Size(251, 66)
        Me.kongjungBTN.TabIndex = 1
        Me.kongjungBTN.Text = "공정별 출력"
        Me.kongjungBTN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.kongjungBTN.Textcolor = System.Drawing.Color.White
        Me.kongjungBTN.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'sceneBTN
        '
        Me.sceneBTN.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.sceneBTN.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.sceneBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.sceneBTN.BorderRadius = 0
        Me.sceneBTN.ButtonText = "현장별 출력"
        Me.sceneBTN.Cursor = System.Windows.Forms.Cursors.Hand
        Me.sceneBTN.DisabledColor = System.Drawing.Color.Gray
        Me.sceneBTN.Font = New System.Drawing.Font("굴림", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.sceneBTN.Iconcolor = System.Drawing.Color.Transparent
        Me.sceneBTN.Iconimage = CType(resources.GetObject("sceneBTN.Iconimage"), System.Drawing.Image)
        Me.sceneBTN.Iconimage_right = Nothing
        Me.sceneBTN.Iconimage_right_Selected = Nothing
        Me.sceneBTN.Iconimage_Selected = Nothing
        Me.sceneBTN.IconMarginLeft = 0
        Me.sceneBTN.IconMarginRight = 0
        Me.sceneBTN.IconRightVisible = True
        Me.sceneBTN.IconRightZoom = 0R
        Me.sceneBTN.IconVisible = True
        Me.sceneBTN.IconZoom = 90.0R
        Me.sceneBTN.IsTab = False
        Me.sceneBTN.Location = New System.Drawing.Point(20, 234)
        Me.sceneBTN.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.sceneBTN.Name = "sceneBTN"
        Me.sceneBTN.Normalcolor = System.Drawing.Color.DarkSlateBlue
        Me.sceneBTN.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.sceneBTN.OnHoverTextColor = System.Drawing.Color.White
        Me.sceneBTN.selected = False
        Me.sceneBTN.Size = New System.Drawing.Size(251, 66)
        Me.sceneBTN.TabIndex = 0
        Me.sceneBTN.Text = "현장별 출력"
        Me.sceneBTN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.sceneBTN.Textcolor = System.Drawing.Color.White
        Me.sceneBTN.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(289, 0)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(991, 751)
        Me.FlowLayoutPanel1.TabIndex = 1
        '
        'ResultDBF
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "ResultDBF"
        Me.Size = New System.Drawing.Size(1280, 751)
        Me.Panel1.ResumeLayout(False)
        CType(Me.BunifuImageButton1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents kongjungBTN As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents sceneBTN As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents BunifuImageButton1 As Bunifu.Framework.UI.BunifuImageButton
End Class
