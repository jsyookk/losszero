<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ResultMatch
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ResultMatch))
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.errTonLB = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel6 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.errProgressbar = New Bunifu.Framework.UI.BunifuCircleProgressbar()
        Me.resultTotalTonLB = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.combineTonLB = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.zumTonLB = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.cutTonLB = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.zangdaeTonLB = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel4 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.combineProgress = New Bunifu.Framework.UI.BunifuCircleProgressbar()
        Me.BunifuImageButton1 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.BunifuCustomLabel3 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel2 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.zumProgress = New Bunifu.Framework.UI.BunifuCircleProgressbar()
        Me.cutProgress = New Bunifu.Framework.UI.BunifuCircleProgressbar()
        Me.zzangdaeProgress = New Bunifu.Framework.UI.BunifuCircleProgressbar()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.tab5 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.tab4 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.tab3 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.tab2 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuSeparator1 = New Bunifu.Framework.UI.BunifuSeparator()
        Me.tab1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.listviewPanel = New System.Windows.Forms.Panel()
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
        Me.Panel1.Controls.Add(Me.errTonLB)
        Me.Panel1.Controls.Add(Me.BunifuCustomLabel6)
        Me.Panel1.Controls.Add(Me.errProgressbar)
        Me.Panel1.Controls.Add(Me.resultTotalTonLB)
        Me.Panel1.Controls.Add(Me.combineTonLB)
        Me.Panel1.Controls.Add(Me.zumTonLB)
        Me.Panel1.Controls.Add(Me.cutTonLB)
        Me.Panel1.Controls.Add(Me.zangdaeTonLB)
        Me.Panel1.Controls.Add(Me.BunifuCustomLabel4)
        Me.Panel1.Controls.Add(Me.combineProgress)
        Me.Panel1.Controls.Add(Me.BunifuImageButton1)
        Me.Panel1.Controls.Add(Me.BunifuCustomLabel3)
        Me.Panel1.Controls.Add(Me.BunifuCustomLabel2)
        Me.Panel1.Controls.Add(Me.BunifuCustomLabel1)
        Me.Panel1.Controls.Add(Me.zumProgress)
        Me.Panel1.Controls.Add(Me.cutProgress)
        Me.Panel1.Controls.Add(Me.zzangdaeProgress)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1538, 161)
        Me.Panel1.TabIndex = 0
        '
        'errTonLB
        '
        Me.errTonLB.AutoSize = True
        Me.errTonLB.ForeColor = System.Drawing.Color.White
        Me.errTonLB.Location = New System.Drawing.Point(894, 43)
        Me.errTonLB.Name = "errTonLB"
        Me.errTonLB.Size = New System.Drawing.Size(28, 15)
        Me.errTonLB.TabIndex = 16
        Me.errTonLB.Text = "0.0"
        '
        'BunifuCustomLabel6
        '
        Me.BunifuCustomLabel6.AutoSize = True
        Me.BunifuCustomLabel6.ForeColor = System.Drawing.Color.DimGray
        Me.BunifuCustomLabel6.Location = New System.Drawing.Point(885, 16)
        Me.BunifuCustomLabel6.Name = "BunifuCustomLabel6"
        Me.BunifuCustomLabel6.Size = New System.Drawing.Size(37, 15)
        Me.BunifuCustomLabel6.TabIndex = 15
        Me.BunifuCustomLabel6.Text = "오차"
        '
        'errProgressbar
        '
        Me.errProgressbar.animated = False
        Me.errProgressbar.animationIterval = 5
        Me.errProgressbar.animationSpeed = 300
        Me.errProgressbar.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.errProgressbar.BackgroundImage = CType(resources.GetObject("errProgressbar.BackgroundImage"), System.Drawing.Image)
        Me.errProgressbar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.errProgressbar.ForeColor = System.Drawing.Color.White
        Me.errProgressbar.LabelVisible = True
        Me.errProgressbar.LineProgressThickness = 8
        Me.errProgressbar.LineThickness = 3
        Me.errProgressbar.Location = New System.Drawing.Point(774, 16)
        Me.errProgressbar.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.errProgressbar.MaxValue = 100
        Me.errProgressbar.Name = "errProgressbar"
        Me.errProgressbar.ProgressBackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.errProgressbar.ProgressColor = System.Drawing.Color.DarkGoldenrod
        Me.errProgressbar.Size = New System.Drawing.Size(111, 111)
        Me.errProgressbar.TabIndex = 14
        Me.errProgressbar.Value = 0
        '
        'resultTotalTonLB
        '
        Me.resultTotalTonLB.AutoSize = True
        Me.resultTotalTonLB.Font = New System.Drawing.Font("돋움", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.resultTotalTonLB.ForeColor = System.Drawing.Color.White
        Me.resultTotalTonLB.Location = New System.Drawing.Point(130, 62)
        Me.resultTotalTonLB.Name = "resultTotalTonLB"
        Me.resultTotalTonLB.Size = New System.Drawing.Size(35, 19)
        Me.resultTotalTonLB.TabIndex = 13
        Me.resultTotalTonLB.Text = "0.0"
        '
        'combineTonLB
        '
        Me.combineTonLB.AutoSize = True
        Me.combineTonLB.ForeColor = System.Drawing.Color.White
        Me.combineTonLB.Location = New System.Drawing.Point(1077, 43)
        Me.combineTonLB.Name = "combineTonLB"
        Me.combineTonLB.Size = New System.Drawing.Size(28, 15)
        Me.combineTonLB.TabIndex = 12
        Me.combineTonLB.Text = "0.0"
        '
        'zumTonLB
        '
        Me.zumTonLB.AutoSize = True
        Me.zumTonLB.ForeColor = System.Drawing.Color.White
        Me.zumTonLB.Location = New System.Drawing.Point(714, 43)
        Me.zumTonLB.Name = "zumTonLB"
        Me.zumTonLB.Size = New System.Drawing.Size(28, 15)
        Me.zumTonLB.TabIndex = 11
        Me.zumTonLB.Text = "0.0"
        '
        'cutTonLB
        '
        Me.cutTonLB.AutoSize = True
        Me.cutTonLB.ForeColor = System.Drawing.Color.White
        Me.cutTonLB.Location = New System.Drawing.Point(539, 43)
        Me.cutTonLB.Name = "cutTonLB"
        Me.cutTonLB.Size = New System.Drawing.Size(28, 15)
        Me.cutTonLB.TabIndex = 10
        Me.cutTonLB.Text = "0.0"
        '
        'zangdaeTonLB
        '
        Me.zangdaeTonLB.AutoSize = True
        Me.zangdaeTonLB.ForeColor = System.Drawing.Color.White
        Me.zangdaeTonLB.Location = New System.Drawing.Point(365, 43)
        Me.zangdaeTonLB.Name = "zangdaeTonLB"
        Me.zangdaeTonLB.Size = New System.Drawing.Size(28, 15)
        Me.zangdaeTonLB.TabIndex = 9
        Me.zangdaeTonLB.Text = "0.0"
        '
        'BunifuCustomLabel4
        '
        Me.BunifuCustomLabel4.AutoSize = True
        Me.BunifuCustomLabel4.ForeColor = System.Drawing.Color.DimGray
        Me.BunifuCustomLabel4.Location = New System.Drawing.Point(1068, 16)
        Me.BunifuCustomLabel4.Name = "BunifuCustomLabel4"
        Me.BunifuCustomLabel4.Size = New System.Drawing.Size(37, 15)
        Me.BunifuCustomLabel4.TabIndex = 8
        Me.BunifuCustomLabel4.Text = "조합"
        '
        'combineProgress
        '
        Me.combineProgress.animated = False
        Me.combineProgress.animationIterval = 5
        Me.combineProgress.animationSpeed = 300
        Me.combineProgress.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.combineProgress.BackgroundImage = CType(resources.GetObject("combineProgress.BackgroundImage"), System.Drawing.Image)
        Me.combineProgress.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.combineProgress.ForeColor = System.Drawing.Color.White
        Me.combineProgress.LabelVisible = True
        Me.combineProgress.LineProgressThickness = 8
        Me.combineProgress.LineThickness = 3
        Me.combineProgress.Location = New System.Drawing.Point(957, 16)
        Me.combineProgress.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.combineProgress.MaxValue = 100
        Me.combineProgress.Name = "combineProgress"
        Me.combineProgress.ProgressBackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.combineProgress.ProgressColor = System.Drawing.Color.Yellow
        Me.combineProgress.Size = New System.Drawing.Size(111, 111)
        Me.combineProgress.TabIndex = 7
        Me.combineProgress.Value = 0
        '
        'BunifuImageButton1
        '
        Me.BunifuImageButton1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuImageButton1.Image = CType(resources.GetObject("BunifuImageButton1.Image"), System.Drawing.Image)
        Me.BunifuImageButton1.ImageActive = Nothing
        Me.BunifuImageButton1.Location = New System.Drawing.Point(15, 16)
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
        Me.BunifuCustomLabel3.Location = New System.Drawing.Point(695, 16)
        Me.BunifuCustomLabel3.Name = "BunifuCustomLabel3"
        Me.BunifuCustomLabel3.Size = New System.Drawing.Size(37, 15)
        Me.BunifuCustomLabel3.TabIndex = 5
        Me.BunifuCustomLabel3.Text = "점철"
        '
        'BunifuCustomLabel2
        '
        Me.BunifuCustomLabel2.AutoSize = True
        Me.BunifuCustomLabel2.ForeColor = System.Drawing.Color.DimGray
        Me.BunifuCustomLabel2.Location = New System.Drawing.Point(518, 16)
        Me.BunifuCustomLabel2.Name = "BunifuCustomLabel2"
        Me.BunifuCustomLabel2.Size = New System.Drawing.Size(37, 15)
        Me.BunifuCustomLabel2.TabIndex = 4
        Me.BunifuCustomLabel2.Text = "컷팅"
        '
        'BunifuCustomLabel1
        '
        Me.BunifuCustomLabel1.AutoSize = True
        Me.BunifuCustomLabel1.ForeColor = System.Drawing.Color.DimGray
        Me.BunifuCustomLabel1.Location = New System.Drawing.Point(359, 16)
        Me.BunifuCustomLabel1.Name = "BunifuCustomLabel1"
        Me.BunifuCustomLabel1.Size = New System.Drawing.Size(37, 15)
        Me.BunifuCustomLabel1.TabIndex = 3
        Me.BunifuCustomLabel1.Text = "장대"
        '
        'zumProgress
        '
        Me.zumProgress.animated = False
        Me.zumProgress.animationIterval = 5
        Me.zumProgress.animationSpeed = 300
        Me.zumProgress.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.zumProgress.BackgroundImage = CType(resources.GetObject("zumProgress.BackgroundImage"), System.Drawing.Image)
        Me.zumProgress.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.zumProgress.ForeColor = System.Drawing.Color.White
        Me.zumProgress.LabelVisible = True
        Me.zumProgress.LineProgressThickness = 8
        Me.zumProgress.LineThickness = 3
        Me.zumProgress.Location = New System.Drawing.Point(584, 16)
        Me.zumProgress.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.zumProgress.MaxValue = 100
        Me.zumProgress.Name = "zumProgress"
        Me.zumProgress.ProgressBackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.zumProgress.ProgressColor = System.Drawing.Color.Red
        Me.zumProgress.Size = New System.Drawing.Size(111, 111)
        Me.zumProgress.TabIndex = 2
        Me.zumProgress.Value = 0
        '
        'cutProgress
        '
        Me.cutProgress.animated = False
        Me.cutProgress.animationIterval = 5
        Me.cutProgress.animationSpeed = 300
        Me.cutProgress.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.cutProgress.BackgroundImage = CType(resources.GetObject("cutProgress.BackgroundImage"), System.Drawing.Image)
        Me.cutProgress.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cutProgress.ForeColor = System.Drawing.Color.White
        Me.cutProgress.LabelVisible = True
        Me.cutProgress.LineProgressThickness = 8
        Me.cutProgress.LineThickness = 3
        Me.cutProgress.Location = New System.Drawing.Point(419, 16)
        Me.cutProgress.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.cutProgress.MaxValue = 100
        Me.cutProgress.Name = "cutProgress"
        Me.cutProgress.ProgressBackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.cutProgress.ProgressColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.cutProgress.Size = New System.Drawing.Size(111, 111)
        Me.cutProgress.TabIndex = 1
        Me.cutProgress.Value = 0
        '
        'zzangdaeProgress
        '
        Me.zzangdaeProgress.animated = False
        Me.zzangdaeProgress.animationIterval = 5
        Me.zzangdaeProgress.animationSpeed = 300
        Me.zzangdaeProgress.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.zzangdaeProgress.BackgroundImage = CType(resources.GetObject("zzangdaeProgress.BackgroundImage"), System.Drawing.Image)
        Me.zzangdaeProgress.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.zzangdaeProgress.ForeColor = System.Drawing.Color.White
        Me.zzangdaeProgress.LabelVisible = True
        Me.zzangdaeProgress.LineProgressThickness = 8
        Me.zzangdaeProgress.LineThickness = 3
        Me.zzangdaeProgress.Location = New System.Drawing.Point(251, 16)
        Me.zzangdaeProgress.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.zzangdaeProgress.MaxValue = 100
        Me.zzangdaeProgress.Name = "zzangdaeProgress"
        Me.zzangdaeProgress.ProgressBackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.zzangdaeProgress.ProgressColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.zzangdaeProgress.Size = New System.Drawing.Size(111, 111)
        Me.zzangdaeProgress.TabIndex = 0
        Me.zzangdaeProgress.Value = 0
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.SlateGray
        Me.Panel2.Controls.Add(Me.tab5)
        Me.Panel2.Controls.Add(Me.tab4)
        Me.Panel2.Controls.Add(Me.tab3)
        Me.Panel2.Controls.Add(Me.tab2)
        Me.Panel2.Controls.Add(Me.BunifuSeparator1)
        Me.Panel2.Controls.Add(Me.tab1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 161)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1538, 62)
        Me.Panel2.TabIndex = 1
        '
        'tab5
        '
        Me.tab5.AutoSize = True
        Me.tab5.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.tab5.Location = New System.Drawing.Point(282, 21)
        Me.tab5.Name = "tab5"
        Me.tab5.Size = New System.Drawing.Size(37, 15)
        Me.tab5.TabIndex = 5
        Me.tab5.Text = "오차"
        '
        'tab4
        '
        Me.tab4.AutoSize = True
        Me.tab4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.tab4.Location = New System.Drawing.Point(39, 21)
        Me.tab4.Name = "tab4"
        Me.tab4.Size = New System.Drawing.Size(37, 15)
        Me.tab4.TabIndex = 4
        Me.tab4.Text = "장대"
        '
        'tab3
        '
        Me.tab3.AutoSize = True
        Me.tab3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.tab3.Location = New System.Drawing.Point(360, 21)
        Me.tab3.Name = "tab3"
        Me.tab3.Size = New System.Drawing.Size(37, 15)
        Me.tab3.TabIndex = 3
        Me.tab3.Text = "조합"
        '
        'tab2
        '
        Me.tab2.AutoSize = True
        Me.tab2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.tab2.Location = New System.Drawing.Point(202, 21)
        Me.tab2.Name = "tab2"
        Me.tab2.Size = New System.Drawing.Size(37, 15)
        Me.tab2.TabIndex = 2
        Me.tab2.Text = "점철"
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
        'tab1
        '
        Me.tab1.AutoSize = True
        Me.tab1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.tab1.Location = New System.Drawing.Point(118, 21)
        Me.tab1.Name = "tab1"
        Me.tab1.Size = New System.Drawing.Size(37, 15)
        Me.tab1.TabIndex = 0
        Me.tab1.Text = "컷팅"
        '
        'listviewPanel
        '
        Me.listviewPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.listviewPanel.Location = New System.Drawing.Point(0, 223)
        Me.listviewPanel.Name = "listviewPanel"
        Me.listviewPanel.Size = New System.Drawing.Size(1538, 528)
        Me.listviewPanel.TabIndex = 2
        '
        'ResultMatch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.listviewPanel)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "ResultMatch"
        Me.Size = New System.Drawing.Size(1538, 751)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.BunifuImageButton1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents zzangdaeProgress As Bunifu.Framework.UI.BunifuCircleProgressbar
    Friend WithEvents BunifuCustomLabel3 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel2 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents zumProgress As Bunifu.Framework.UI.BunifuCircleProgressbar
    Friend WithEvents cutProgress As Bunifu.Framework.UI.BunifuCircleProgressbar
    Friend WithEvents BunifuImageButton1 As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents listviewPanel As Panel
    Friend WithEvents tab2 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuSeparator1 As Bunifu.Framework.UI.BunifuSeparator
    Friend WithEvents tab1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents tab3 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents tab4 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents combineTonLB As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents zumTonLB As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents cutTonLB As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents zangdaeTonLB As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel4 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents combineProgress As Bunifu.Framework.UI.BunifuCircleProgressbar
    Friend WithEvents resultTotalTonLB As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents tab5 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents errTonLB As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel6 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents errProgressbar As Bunifu.Framework.UI.BunifuCircleProgressbar
End Class
