<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ResultStock_list
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ResultStock_list))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.diffTonLB = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel6 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel5 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel4 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel3 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.stockTonLB = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.totalTonTB = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.cbTonLB = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.cutTonLB = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.lable = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel2 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.combineProgress = New Bunifu.Framework.UI.BunifuCircleProgressbar()
        Me.cutProgress = New Bunifu.Framework.UI.BunifuCircleProgressbar()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.BunifuSeparator1 = New Bunifu.Framework.UI.BunifuSeparator()
        Me.tab1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.tab2 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.listmain = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.Panel1.Controls.Add(Me.diffTonLB)
        Me.Panel1.Controls.Add(Me.BunifuCustomLabel6)
        Me.Panel1.Controls.Add(Me.BunifuCustomLabel5)
        Me.Panel1.Controls.Add(Me.BunifuCustomLabel4)
        Me.Panel1.Controls.Add(Me.BunifuCustomLabel3)
        Me.Panel1.Controls.Add(Me.BunifuCustomLabel1)
        Me.Panel1.Controls.Add(Me.stockTonLB)
        Me.Panel1.Controls.Add(Me.totalTonTB)
        Me.Panel1.Controls.Add(Me.cbTonLB)
        Me.Panel1.Controls.Add(Me.cutTonLB)
        Me.Panel1.Controls.Add(Me.lable)
        Me.Panel1.Controls.Add(Me.BunifuCustomLabel2)
        Me.Panel1.Controls.Add(Me.combineProgress)
        Me.Panel1.Controls.Add(Me.cutProgress)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1213, 178)
        Me.Panel1.TabIndex = 0
        '
        'diffTonLB
        '
        Me.diffTonLB.AutoSize = True
        Me.diffTonLB.Font = New System.Drawing.Font("굴림", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.diffTonLB.ForeColor = System.Drawing.Color.White
        Me.diffTonLB.Location = New System.Drawing.Point(370, 62)
        Me.diffTonLB.Name = "diffTonLB"
        Me.diffTonLB.Size = New System.Drawing.Size(47, 24)
        Me.diffTonLB.TabIndex = 25
        Me.diffTonLB.Text = "0.0"
        '
        'BunifuCustomLabel6
        '
        Me.BunifuCustomLabel6.AutoSize = True
        Me.BunifuCustomLabel6.Font = New System.Drawing.Font("굴림", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.BunifuCustomLabel6.ForeColor = System.Drawing.Color.White
        Me.BunifuCustomLabel6.Location = New System.Drawing.Point(311, 62)
        Me.BunifuCustomLabel6.Name = "BunifuCustomLabel6"
        Me.BunifuCustomLabel6.Size = New System.Drawing.Size(24, 24)
        Me.BunifuCustomLabel6.TabIndex = 24
        Me.BunifuCustomLabel6.Text = "="
        '
        'BunifuCustomLabel5
        '
        Me.BunifuCustomLabel5.AutoSize = True
        Me.BunifuCustomLabel5.Font = New System.Drawing.Font("굴림", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.BunifuCustomLabel5.ForeColor = System.Drawing.Color.DarkGray
        Me.BunifuCustomLabel5.Location = New System.Drawing.Point(353, 24)
        Me.BunifuCustomLabel5.Name = "BunifuCustomLabel5"
        Me.BunifuCustomLabel5.Size = New System.Drawing.Size(76, 20)
        Me.BunifuCustomLabel5.TabIndex = 23
        Me.BunifuCustomLabel5.Text = "톤수 차"
        '
        'BunifuCustomLabel4
        '
        Me.BunifuCustomLabel4.AutoSize = True
        Me.BunifuCustomLabel4.Font = New System.Drawing.Font("굴림", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.BunifuCustomLabel4.ForeColor = System.Drawing.Color.White
        Me.BunifuCustomLabel4.Location = New System.Drawing.Point(163, 62)
        Me.BunifuCustomLabel4.Name = "BunifuCustomLabel4"
        Me.BunifuCustomLabel4.Size = New System.Drawing.Size(24, 24)
        Me.BunifuCustomLabel4.TabIndex = 22
        Me.BunifuCustomLabel4.Text = "-"
        '
        'BunifuCustomLabel3
        '
        Me.BunifuCustomLabel3.AutoSize = True
        Me.BunifuCustomLabel3.Font = New System.Drawing.Font("굴림", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.BunifuCustomLabel3.ForeColor = System.Drawing.Color.DarkGray
        Me.BunifuCustomLabel3.Location = New System.Drawing.Point(200, 24)
        Me.BunifuCustomLabel3.Name = "BunifuCustomLabel3"
        Me.BunifuCustomLabel3.Size = New System.Drawing.Size(103, 20)
        Me.BunifuCustomLabel3.TabIndex = 21
        Me.BunifuCustomLabel3.Text = "필요 톤 수"
        '
        'BunifuCustomLabel1
        '
        Me.BunifuCustomLabel1.AutoSize = True
        Me.BunifuCustomLabel1.Font = New System.Drawing.Font("굴림", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.BunifuCustomLabel1.ForeColor = System.Drawing.Color.DarkGray
        Me.BunifuCustomLabel1.Location = New System.Drawing.Point(47, 24)
        Me.BunifuCustomLabel1.Name = "BunifuCustomLabel1"
        Me.BunifuCustomLabel1.Size = New System.Drawing.Size(103, 20)
        Me.BunifuCustomLabel1.TabIndex = 20
        Me.BunifuCustomLabel1.Text = "재고 톤 수"
        '
        'stockTonLB
        '
        Me.stockTonLB.AutoSize = True
        Me.stockTonLB.Font = New System.Drawing.Font("굴림", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.stockTonLB.ForeColor = System.Drawing.Color.White
        Me.stockTonLB.Location = New System.Drawing.Point(76, 62)
        Me.stockTonLB.Name = "stockTonLB"
        Me.stockTonLB.Size = New System.Drawing.Size(47, 24)
        Me.stockTonLB.TabIndex = 19
        Me.stockTonLB.Text = "0.0"
        '
        'totalTonTB
        '
        Me.totalTonTB.AutoSize = True
        Me.totalTonTB.Font = New System.Drawing.Font("굴림", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.totalTonTB.ForeColor = System.Drawing.Color.White
        Me.totalTonTB.Location = New System.Drawing.Point(222, 62)
        Me.totalTonTB.Name = "totalTonTB"
        Me.totalTonTB.Size = New System.Drawing.Size(47, 24)
        Me.totalTonTB.TabIndex = 18
        Me.totalTonTB.Text = "0.0"
        '
        'cbTonLB
        '
        Me.cbTonLB.AutoSize = True
        Me.cbTonLB.ForeColor = System.Drawing.Color.White
        Me.cbTonLB.Location = New System.Drawing.Point(795, 33)
        Me.cbTonLB.Name = "cbTonLB"
        Me.cbTonLB.Size = New System.Drawing.Size(28, 15)
        Me.cbTonLB.TabIndex = 17
        Me.cbTonLB.Text = "0.0"
        '
        'cutTonLB
        '
        Me.cutTonLB.AutoSize = True
        Me.cutTonLB.ForeColor = System.Drawing.Color.White
        Me.cutTonLB.Location = New System.Drawing.Point(620, 33)
        Me.cutTonLB.Name = "cutTonLB"
        Me.cutTonLB.Size = New System.Drawing.Size(28, 15)
        Me.cutTonLB.TabIndex = 16
        Me.cutTonLB.Text = "0.0"
        '
        'lable
        '
        Me.lable.AutoSize = True
        Me.lable.ForeColor = System.Drawing.Color.DimGray
        Me.lable.Location = New System.Drawing.Point(776, 6)
        Me.lable.Name = "lable"
        Me.lable.Size = New System.Drawing.Size(37, 15)
        Me.lable.TabIndex = 15
        Me.lable.Text = "조합"
        '
        'BunifuCustomLabel2
        '
        Me.BunifuCustomLabel2.AutoSize = True
        Me.BunifuCustomLabel2.ForeColor = System.Drawing.Color.DimGray
        Me.BunifuCustomLabel2.Location = New System.Drawing.Point(599, 6)
        Me.BunifuCustomLabel2.Name = "BunifuCustomLabel2"
        Me.BunifuCustomLabel2.Size = New System.Drawing.Size(37, 15)
        Me.BunifuCustomLabel2.TabIndex = 14
        Me.BunifuCustomLabel2.Text = "컷팅"
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
        Me.combineProgress.Location = New System.Drawing.Point(665, 6)
        Me.combineProgress.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.combineProgress.MaxValue = 100
        Me.combineProgress.Name = "combineProgress"
        Me.combineProgress.ProgressBackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.combineProgress.ProgressColor = System.Drawing.Color.Red
        Me.combineProgress.Size = New System.Drawing.Size(111, 111)
        Me.combineProgress.TabIndex = 13
        Me.combineProgress.Value = 0
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
        Me.cutProgress.Location = New System.Drawing.Point(500, 6)
        Me.cutProgress.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.cutProgress.MaxValue = 100
        Me.cutProgress.Name = "cutProgress"
        Me.cutProgress.ProgressBackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.cutProgress.ProgressColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.cutProgress.Size = New System.Drawing.Size(111, 111)
        Me.cutProgress.TabIndex = 12
        Me.cutProgress.Value = 0
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DimGray
        Me.Panel2.Controls.Add(Me.BunifuSeparator1)
        Me.Panel2.Controls.Add(Me.tab1)
        Me.Panel2.Controls.Add(Me.tab2)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 125)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1213, 53)
        Me.Panel2.TabIndex = 2
        '
        'BunifuSeparator1
        '
        Me.BunifuSeparator1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BunifuSeparator1.LineThickness = 3
        Me.BunifuSeparator1.Location = New System.Drawing.Point(30, 34)
        Me.BunifuSeparator1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.BunifuSeparator1.Name = "BunifuSeparator1"
        Me.BunifuSeparator1.Size = New System.Drawing.Size(27, 10)
        Me.BunifuSeparator1.TabIndex = 2
        Me.BunifuSeparator1.Transparency = 255
        Me.BunifuSeparator1.Vertical = False
        '
        'tab1
        '
        Me.tab1.AutoSize = True
        Me.tab1.ForeColor = System.Drawing.Color.White
        Me.tab1.Location = New System.Drawing.Point(27, 16)
        Me.tab1.Name = "tab1"
        Me.tab1.Size = New System.Drawing.Size(37, 15)
        Me.tab1.TabIndex = 0
        Me.tab1.Text = "컷팅"
        '
        'tab2
        '
        Me.tab2.AutoSize = True
        Me.tab2.ForeColor = System.Drawing.Color.White
        Me.tab2.Location = New System.Drawing.Point(132, 16)
        Me.tab2.Name = "tab2"
        Me.tab2.Size = New System.Drawing.Size(37, 15)
        Me.tab2.TabIndex = 1
        Me.tab2.Text = "조합"
        '
        'listmain
        '
        Me.listmain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.listmain.Location = New System.Drawing.Point(0, 178)
        Me.listmain.Name = "listmain"
        Me.listmain.Size = New System.Drawing.Size(1213, 573)
        Me.listmain.TabIndex = 1
        '
        'ResultStock_list
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.listmain)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "ResultStock_list"
        Me.Size = New System.Drawing.Size(1213, 751)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents tab2 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents tab1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents listmain As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents cbTonLB As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents cutTonLB As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents lable As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel2 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents combineProgress As Bunifu.Framework.UI.BunifuCircleProgressbar
    Friend WithEvents cutProgress As Bunifu.Framework.UI.BunifuCircleProgressbar
    Friend WithEvents totalTonTB As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel3 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents stockTonLB As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents diffTonLB As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel6 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel5 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel4 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuSeparator1 As Bunifu.Framework.UI.BunifuSeparator
End Class
