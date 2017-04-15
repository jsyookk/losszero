<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ResultNomatch
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ResultNomatch))
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.totalNomatchLB = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.noBaseTonLB = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.nomatchTonLB = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.coilTonLB = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuImageButton1 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.BunifuCustomLabel3 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel2 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.nobaseProgressBar = New Bunifu.Framework.UI.BunifuCircleProgressbar()
        Me.nomatchProgressBar = New Bunifu.Framework.UI.BunifuCircleProgressbar()
        Me.coilProgressBar = New Bunifu.Framework.UI.BunifuCircleProgressbar()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.tab3 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.tab2 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.tab1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuSeparator1 = New Bunifu.Framework.UI.BunifuSeparator()
        Me.lstPanel = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        CType(Me.BunifuImageButton1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 5
        Me.BunifuElipse1.TargetControl = Me
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.Panel1.Controls.Add(Me.totalNomatchLB)
        Me.Panel1.Controls.Add(Me.noBaseTonLB)
        Me.Panel1.Controls.Add(Me.nomatchTonLB)
        Me.Panel1.Controls.Add(Me.coilTonLB)
        Me.Panel1.Controls.Add(Me.BunifuImageButton1)
        Me.Panel1.Controls.Add(Me.BunifuCustomLabel3)
        Me.Panel1.Controls.Add(Me.BunifuCustomLabel2)
        Me.Panel1.Controls.Add(Me.BunifuCustomLabel1)
        Me.Panel1.Controls.Add(Me.nobaseProgressBar)
        Me.Panel1.Controls.Add(Me.nomatchProgressBar)
        Me.Panel1.Controls.Add(Me.coilProgressBar)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1538, 161)
        Me.Panel1.TabIndex = 1
        '
        'totalNomatchLB
        '
        Me.totalNomatchLB.AutoSize = True
        Me.totalNomatchLB.Font = New System.Drawing.Font("굴림", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.totalNomatchLB.ForeColor = System.Drawing.Color.White
        Me.totalNomatchLB.Location = New System.Drawing.Point(169, 43)
        Me.totalNomatchLB.Name = "totalNomatchLB"
        Me.totalNomatchLB.Size = New System.Drawing.Size(47, 24)
        Me.totalNomatchLB.TabIndex = 10
        Me.totalNomatchLB.Text = "0.0"
        '
        'noBaseTonLB
        '
        Me.noBaseTonLB.AutoSize = True
        Me.noBaseTonLB.ForeColor = System.Drawing.Color.White
        Me.noBaseTonLB.Location = New System.Drawing.Point(842, 43)
        Me.noBaseTonLB.Name = "noBaseTonLB"
        Me.noBaseTonLB.Size = New System.Drawing.Size(28, 15)
        Me.noBaseTonLB.TabIndex = 9
        Me.noBaseTonLB.Text = "0.0"
        '
        'nomatchTonLB
        '
        Me.nomatchTonLB.AutoSize = True
        Me.nomatchTonLB.ForeColor = System.Drawing.Color.White
        Me.nomatchTonLB.Location = New System.Drawing.Point(676, 43)
        Me.nomatchTonLB.Name = "nomatchTonLB"
        Me.nomatchTonLB.Size = New System.Drawing.Size(28, 15)
        Me.nomatchTonLB.TabIndex = 8
        Me.nomatchTonLB.Text = "0.0"
        '
        'coilTonLB
        '
        Me.coilTonLB.AutoSize = True
        Me.coilTonLB.ForeColor = System.Drawing.Color.White
        Me.coilTonLB.Location = New System.Drawing.Point(500, 43)
        Me.coilTonLB.Name = "coilTonLB"
        Me.coilTonLB.Size = New System.Drawing.Size(28, 15)
        Me.coilTonLB.TabIndex = 7
        Me.coilTonLB.Text = "0.0"
        '
        'BunifuImageButton1
        '
        Me.BunifuImageButton1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuImageButton1.Image = CType(resources.GetObject("BunifuImageButton1.Image"), System.Drawing.Image)
        Me.BunifuImageButton1.ImageActive = Nothing
        Me.BunifuImageButton1.Location = New System.Drawing.Point(23, 22)
        Me.BunifuImageButton1.Name = "BunifuImageButton1"
        Me.BunifuImageButton1.Size = New System.Drawing.Size(38, 42)
        Me.BunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BunifuImageButton1.TabIndex = 6
        Me.BunifuImageButton1.TabStop = False
        Me.BunifuImageButton1.Zoom = 10
        '
        'BunifuCustomLabel3
        '
        Me.BunifuCustomLabel3.AutoSize = True
        Me.BunifuCustomLabel3.ForeColor = System.Drawing.Color.DimGray
        Me.BunifuCustomLabel3.Location = New System.Drawing.Point(812, 16)
        Me.BunifuCustomLabel3.Name = "BunifuCustomLabel3"
        Me.BunifuCustomLabel3.Size = New System.Drawing.Size(67, 15)
        Me.BunifuCustomLabel3.TabIndex = 5
        Me.BunifuCustomLabel3.Text = "노베이스"
        '
        'BunifuCustomLabel2
        '
        Me.BunifuCustomLabel2.AutoSize = True
        Me.BunifuCustomLabel2.ForeColor = System.Drawing.Color.DimGray
        Me.BunifuCustomLabel2.Location = New System.Drawing.Point(647, 16)
        Me.BunifuCustomLabel2.Name = "BunifuCustomLabel2"
        Me.BunifuCustomLabel2.Size = New System.Drawing.Size(52, 15)
        Me.BunifuCustomLabel2.TabIndex = 4
        Me.BunifuCustomLabel2.Text = "노매치"
        '
        'BunifuCustomLabel1
        '
        Me.BunifuCustomLabel1.AutoSize = True
        Me.BunifuCustomLabel1.ForeColor = System.Drawing.Color.DimGray
        Me.BunifuCustomLabel1.Location = New System.Drawing.Point(485, 16)
        Me.BunifuCustomLabel1.Name = "BunifuCustomLabel1"
        Me.BunifuCustomLabel1.Size = New System.Drawing.Size(37, 15)
        Me.BunifuCustomLabel1.TabIndex = 3
        Me.BunifuCustomLabel1.Text = "코일"
        '
        'nobaseProgressBar
        '
        Me.nobaseProgressBar.animated = False
        Me.nobaseProgressBar.animationIterval = 5
        Me.nobaseProgressBar.animationSpeed = 300
        Me.nobaseProgressBar.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.nobaseProgressBar.BackgroundImage = CType(resources.GetObject("nobaseProgressBar.BackgroundImage"), System.Drawing.Image)
        Me.nobaseProgressBar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nobaseProgressBar.ForeColor = System.Drawing.Color.White
        Me.nobaseProgressBar.LabelVisible = True
        Me.nobaseProgressBar.LineProgressThickness = 8
        Me.nobaseProgressBar.LineThickness = 3
        Me.nobaseProgressBar.Location = New System.Drawing.Point(713, 16)
        Me.nobaseProgressBar.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.nobaseProgressBar.MaxValue = 100
        Me.nobaseProgressBar.Name = "nobaseProgressBar"
        Me.nobaseProgressBar.ProgressBackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.nobaseProgressBar.ProgressColor = System.Drawing.Color.Red
        Me.nobaseProgressBar.Size = New System.Drawing.Size(111, 111)
        Me.nobaseProgressBar.TabIndex = 2
        Me.nobaseProgressBar.Value = 60
        '
        'nomatchProgressBar
        '
        Me.nomatchProgressBar.animated = False
        Me.nomatchProgressBar.animationIterval = 5
        Me.nomatchProgressBar.animationSpeed = 300
        Me.nomatchProgressBar.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.nomatchProgressBar.BackgroundImage = CType(resources.GetObject("nomatchProgressBar.BackgroundImage"), System.Drawing.Image)
        Me.nomatchProgressBar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nomatchProgressBar.ForeColor = System.Drawing.Color.White
        Me.nomatchProgressBar.LabelVisible = True
        Me.nomatchProgressBar.LineProgressThickness = 8
        Me.nomatchProgressBar.LineThickness = 3
        Me.nomatchProgressBar.Location = New System.Drawing.Point(548, 16)
        Me.nomatchProgressBar.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.nomatchProgressBar.MaxValue = 100
        Me.nomatchProgressBar.Name = "nomatchProgressBar"
        Me.nomatchProgressBar.ProgressBackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.nomatchProgressBar.ProgressColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.nomatchProgressBar.Size = New System.Drawing.Size(111, 111)
        Me.nomatchProgressBar.TabIndex = 1
        Me.nomatchProgressBar.Value = 60
        '
        'coilProgressBar
        '
        Me.coilProgressBar.animated = False
        Me.coilProgressBar.animationIterval = 5
        Me.coilProgressBar.animationSpeed = 300
        Me.coilProgressBar.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.coilProgressBar.BackgroundImage = CType(resources.GetObject("coilProgressBar.BackgroundImage"), System.Drawing.Image)
        Me.coilProgressBar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.coilProgressBar.ForeColor = System.Drawing.Color.White
        Me.coilProgressBar.LabelVisible = True
        Me.coilProgressBar.LineProgressThickness = 8
        Me.coilProgressBar.LineThickness = 3
        Me.coilProgressBar.Location = New System.Drawing.Point(380, 16)
        Me.coilProgressBar.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.coilProgressBar.MaxValue = 100
        Me.coilProgressBar.Name = "coilProgressBar"
        Me.coilProgressBar.ProgressBackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.coilProgressBar.ProgressColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.coilProgressBar.Size = New System.Drawing.Size(111, 111)
        Me.coilProgressBar.TabIndex = 0
        Me.coilProgressBar.Value = 60
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.SlateGray
        Me.Panel2.Controls.Add(Me.tab3)
        Me.Panel2.Controls.Add(Me.tab2)
        Me.Panel2.Controls.Add(Me.tab1)
        Me.Panel2.Controls.Add(Me.BunifuSeparator1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 161)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1538, 62)
        Me.Panel2.TabIndex = 2
        '
        'tab3
        '
        Me.tab3.AutoSize = True
        Me.tab3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.tab3.Location = New System.Drawing.Point(244, 21)
        Me.tab3.Name = "tab3"
        Me.tab3.Size = New System.Drawing.Size(67, 15)
        Me.tab3.TabIndex = 6
        Me.tab3.Text = "노베이스"
        '
        'tab2
        '
        Me.tab2.AutoSize = True
        Me.tab2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.tab2.Location = New System.Drawing.Point(141, 21)
        Me.tab2.Name = "tab2"
        Me.tab2.Size = New System.Drawing.Size(52, 15)
        Me.tab2.TabIndex = 5
        Me.tab2.Text = "노매치"
        '
        'tab1
        '
        Me.tab1.AutoSize = True
        Me.tab1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.tab1.Location = New System.Drawing.Point(39, 21)
        Me.tab1.Name = "tab1"
        Me.tab1.Size = New System.Drawing.Size(37, 15)
        Me.tab1.TabIndex = 4
        Me.tab1.Text = "코일"
        '
        'BunifuSeparator1
        '
        Me.BunifuSeparator1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BunifuSeparator1.LineThickness = 5
        Me.BunifuSeparator1.Location = New System.Drawing.Point(28, 41)
        Me.BunifuSeparator1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.BunifuSeparator1.Name = "BunifuSeparator1"
        Me.BunifuSeparator1.Size = New System.Drawing.Size(48, 18)
        Me.BunifuSeparator1.TabIndex = 1
        Me.BunifuSeparator1.Transparency = 255
        Me.BunifuSeparator1.Vertical = False
        '
        'lstPanel
        '
        Me.lstPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lstPanel.Location = New System.Drawing.Point(0, 223)
        Me.lstPanel.Name = "lstPanel"
        Me.lstPanel.Size = New System.Drawing.Size(1538, 415)
        Me.lstPanel.TabIndex = 3
        '
        'ResultNomatch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.lstPanel)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "ResultNomatch"
        Me.Size = New System.Drawing.Size(1538, 638)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.BunifuImageButton1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BunifuImageButton1 As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents BunifuCustomLabel3 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel2 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents nobaseProgressBar As Bunifu.Framework.UI.BunifuCircleProgressbar
    Friend WithEvents nomatchProgressBar As Bunifu.Framework.UI.BunifuCircleProgressbar
    Friend WithEvents coilProgressBar As Bunifu.Framework.UI.BunifuCircleProgressbar
    Friend WithEvents Panel2 As Panel
    Friend WithEvents tab1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuSeparator1 As Bunifu.Framework.UI.BunifuSeparator
    Friend WithEvents tab3 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents tab2 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents lstPanel As Panel
    Friend WithEvents noBaseTonLB As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents nomatchTonLB As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents coilTonLB As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents totalNomatchLB As Bunifu.Framework.UI.BunifuCustomLabel
End Class
