<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Main
    Inherits System.Windows.Forms.Form

    'Form은 Dispose를 재정의하여 구성 요소 목록을 정리합니다.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim Animation2 As BunifuAnimatorNS.Animation = New BunifuAnimatorNS.Animation()
        Dim Animation1 As BunifuAnimatorNS.Animation = New BunifuAnimatorNS.Animation()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.sidePanel = New System.Windows.Forms.Panel()
        Me.BunifuFlatButton4 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.menuChangeBTN = New Bunifu.Framework.UI.BunifuImageButton()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.BunifuCircleProgressbar1 = New Bunifu.Framework.UI.BunifuCircleProgressbar()
        Me.mainStatusLB = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.userPanel = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BunifuCustomLabel1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.DateLB = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.nameLB = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BunifuFlatButton3 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BunifuFlatButton2 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BunifuFlatButton1 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.header = New System.Windows.Forms.Panel()
        Me.exitBTN = New Bunifu.Framework.UI.BunifuImageButton()
        Me.BunifuDragControl1 = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.mainPanel = New System.Windows.Forms.Panel()
        Me.userAni = New BunifuAnimatorNS.BunifuTransition(Me.components)
        Me.menuAni = New BunifuAnimatorNS.BunifuTransition(Me.components)
        Me.sidePanel.SuspendLayout()
        CType(Me.menuChangeBTN, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.userPanel.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.header.SuspendLayout()
        CType(Me.exitBTN, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 5
        Me.BunifuElipse1.TargetControl = Me
        '
        'sidePanel
        '
        Me.sidePanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.sidePanel.Controls.Add(Me.BunifuFlatButton4)
        Me.sidePanel.Controls.Add(Me.menuChangeBTN)
        Me.sidePanel.Controls.Add(Me.Panel3)
        Me.sidePanel.Controls.Add(Me.userPanel)
        Me.sidePanel.Controls.Add(Me.BunifuFlatButton3)
        Me.sidePanel.Controls.Add(Me.BunifuFlatButton2)
        Me.sidePanel.Controls.Add(Me.BunifuFlatButton1)
        Me.menuAni.SetDecoration(Me.sidePanel, BunifuAnimatorNS.DecorationType.None)
        Me.userAni.SetDecoration(Me.sidePanel, BunifuAnimatorNS.DecorationType.None)
        Me.sidePanel.Dock = System.Windows.Forms.DockStyle.Left
        Me.sidePanel.Location = New System.Drawing.Point(0, 49)
        Me.sidePanel.Name = "sidePanel"
        Me.sidePanel.Size = New System.Drawing.Size(282, 951)
        Me.sidePanel.TabIndex = 0
        '
        'BunifuFlatButton4
        '
        Me.BunifuFlatButton4.Activecolor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.BunifuFlatButton4.BackColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.BunifuFlatButton4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton4.BorderRadius = 0
        Me.BunifuFlatButton4.ButtonText = "Data"
        Me.BunifuFlatButton4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.menuAni.SetDecoration(Me.BunifuFlatButton4, BunifuAnimatorNS.DecorationType.None)
        Me.userAni.SetDecoration(Me.BunifuFlatButton4, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuFlatButton4.DisabledColor = System.Drawing.Color.Gray
        Me.BunifuFlatButton4.Iconcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton4.Iconimage = CType(resources.GetObject("BunifuFlatButton4.Iconimage"), System.Drawing.Image)
        Me.BunifuFlatButton4.Iconimage_right = Nothing
        Me.BunifuFlatButton4.Iconimage_right_Selected = Nothing
        Me.BunifuFlatButton4.Iconimage_Selected = Nothing
        Me.BunifuFlatButton4.IconMarginLeft = 0
        Me.BunifuFlatButton4.IconMarginRight = 0
        Me.BunifuFlatButton4.IconRightVisible = True
        Me.BunifuFlatButton4.IconRightZoom = 0R
        Me.BunifuFlatButton4.IconVisible = True
        Me.BunifuFlatButton4.IconZoom = 60.0R
        Me.BunifuFlatButton4.IsTab = True
        Me.BunifuFlatButton4.Location = New System.Drawing.Point(3, 427)
        Me.BunifuFlatButton4.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.BunifuFlatButton4.Name = "BunifuFlatButton4"
        Me.BunifuFlatButton4.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.BunifuFlatButton4.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.BunifuFlatButton4.OnHoverTextColor = System.Drawing.Color.Gray
        Me.BunifuFlatButton4.selected = True
        Me.BunifuFlatButton4.Size = New System.Drawing.Size(280, 50)
        Me.BunifuFlatButton4.TabIndex = 7
        Me.BunifuFlatButton4.Text = "Data"
        Me.BunifuFlatButton4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BunifuFlatButton4.Textcolor = System.Drawing.Color.White
        Me.BunifuFlatButton4.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'menuChangeBTN
        '
        Me.menuChangeBTN.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.menuAni.SetDecoration(Me.menuChangeBTN, BunifuAnimatorNS.DecorationType.None)
        Me.userAni.SetDecoration(Me.menuChangeBTN, BunifuAnimatorNS.DecorationType.None)
        Me.menuChangeBTN.Dock = System.Windows.Forms.DockStyle.Top
        Me.menuChangeBTN.Image = CType(resources.GetObject("menuChangeBTN.Image"), System.Drawing.Image)
        Me.menuChangeBTN.ImageActive = Nothing
        Me.menuChangeBTN.Location = New System.Drawing.Point(0, 0)
        Me.menuChangeBTN.Name = "menuChangeBTN"
        Me.menuChangeBTN.Size = New System.Drawing.Size(282, 32)
        Me.menuChangeBTN.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.menuChangeBTN.TabIndex = 6
        Me.menuChangeBTN.TabStop = False
        Me.menuChangeBTN.Zoom = 10
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Gainsboro
        Me.Panel3.Controls.Add(Me.BunifuCircleProgressbar1)
        Me.Panel3.Controls.Add(Me.mainStatusLB)
        Me.menuAni.SetDecoration(Me.Panel3, BunifuAnimatorNS.DecorationType.None)
        Me.userAni.SetDecoration(Me.Panel3, BunifuAnimatorNS.DecorationType.None)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 918)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(282, 33)
        Me.Panel3.TabIndex = 5
        '
        'BunifuCircleProgressbar1
        '
        Me.BunifuCircleProgressbar1.animated = True
        Me.BunifuCircleProgressbar1.animationIterval = 1
        Me.BunifuCircleProgressbar1.animationSpeed = 1
        Me.BunifuCircleProgressbar1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuCircleProgressbar1.BackgroundImage = CType(resources.GetObject("BunifuCircleProgressbar1.BackgroundImage"), System.Drawing.Image)
        Me.menuAni.SetDecoration(Me.BunifuCircleProgressbar1, BunifuAnimatorNS.DecorationType.None)
        Me.userAni.SetDecoration(Me.BunifuCircleProgressbar1, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuCircleProgressbar1.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!)
        Me.BunifuCircleProgressbar1.ForeColor = System.Drawing.Color.Red
        Me.BunifuCircleProgressbar1.LabelVisible = False
        Me.BunifuCircleProgressbar1.LineProgressThickness = 3
        Me.BunifuCircleProgressbar1.LineThickness = 2
        Me.BunifuCircleProgressbar1.Location = New System.Drawing.Point(243, 2)
        Me.BunifuCircleProgressbar1.Margin = New System.Windows.Forms.Padding(10, 9, 10, 9)
        Me.BunifuCircleProgressbar1.MaxValue = 100
        Me.BunifuCircleProgressbar1.Name = "BunifuCircleProgressbar1"
        Me.BunifuCircleProgressbar1.ProgressBackColor = System.Drawing.Color.White
        Me.BunifuCircleProgressbar1.ProgressColor = System.Drawing.Color.Red
        Me.BunifuCircleProgressbar1.Size = New System.Drawing.Size(33, 33)
        Me.BunifuCircleProgressbar1.TabIndex = 1
        Me.BunifuCircleProgressbar1.Value = 25
        '
        'mainStatusLB
        '
        Me.mainStatusLB.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.mainStatusLB.AutoSize = True
        Me.userAni.SetDecoration(Me.mainStatusLB, BunifuAnimatorNS.DecorationType.None)
        Me.menuAni.SetDecoration(Me.mainStatusLB, BunifuAnimatorNS.DecorationType.None)
        Me.mainStatusLB.Location = New System.Drawing.Point(12, 9)
        Me.mainStatusLB.Name = "mainStatusLB"
        Me.mainStatusLB.Size = New System.Drawing.Size(0, 15)
        Me.mainStatusLB.TabIndex = 0
        Me.mainStatusLB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'userPanel
        '
        Me.userPanel.Controls.Add(Me.Panel1)
        Me.userPanel.Controls.Add(Me.nameLB)
        Me.userPanel.Controls.Add(Me.PictureBox1)
        Me.menuAni.SetDecoration(Me.userPanel, BunifuAnimatorNS.DecorationType.None)
        Me.userAni.SetDecoration(Me.userPanel, BunifuAnimatorNS.DecorationType.None)
        Me.userPanel.Location = New System.Drawing.Point(0, 55)
        Me.userPanel.Name = "userPanel"
        Me.userPanel.Size = New System.Drawing.Size(276, 222)
        Me.userPanel.TabIndex = 4
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.BunifuCustomLabel1)
        Me.Panel1.Controls.Add(Me.DateLB)
        Me.menuAni.SetDecoration(Me.Panel1, BunifuAnimatorNS.DecorationType.None)
        Me.userAni.SetDecoration(Me.Panel1, BunifuAnimatorNS.DecorationType.None)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 183)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(276, 39)
        Me.Panel1.TabIndex = 6
        '
        'BunifuCustomLabel1
        '
        Me.BunifuCustomLabel1.AutoSize = True
        Me.userAni.SetDecoration(Me.BunifuCustomLabel1, BunifuAnimatorNS.DecorationType.None)
        Me.menuAni.SetDecoration(Me.BunifuCustomLabel1, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuCustomLabel1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.BunifuCustomLabel1.Location = New System.Drawing.Point(16, 10)
        Me.BunifuCustomLabel1.Name = "BunifuCustomLabel1"
        Me.BunifuCustomLabel1.Size = New System.Drawing.Size(77, 15)
        Me.BunifuCustomLabel1.TabIndex = 0
        Me.BunifuCustomLabel1.Text = "만료날짜 :"
        '
        'DateLB
        '
        Me.DateLB.AutoSize = True
        Me.userAni.SetDecoration(Me.DateLB, BunifuAnimatorNS.DecorationType.None)
        Me.menuAni.SetDecoration(Me.DateLB, BunifuAnimatorNS.DecorationType.None)
        Me.DateLB.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.DateLB.Location = New System.Drawing.Point(125, 10)
        Me.DateLB.Name = "DateLB"
        Me.DateLB.Size = New System.Drawing.Size(0, 15)
        Me.DateLB.TabIndex = 4
        Me.DateLB.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'nameLB
        '
        Me.nameLB.AutoSize = True
        Me.nameLB.BackColor = System.Drawing.Color.White
        Me.userAni.SetDecoration(Me.nameLB, BunifuAnimatorNS.DecorationType.None)
        Me.menuAni.SetDecoration(Me.nameLB, BunifuAnimatorNS.DecorationType.None)
        Me.nameLB.Font = New System.Drawing.Font("돋움", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.nameLB.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.nameLB.Location = New System.Drawing.Point(108, 75)
        Me.nameLB.Name = "nameLB"
        Me.nameLB.Size = New System.Drawing.Size(0, 15)
        Me.nameLB.TabIndex = 3
        '
        'PictureBox1
        '
        Me.userAni.SetDecoration(Me.PictureBox1, BunifuAnimatorNS.DecorationType.None)
        Me.menuAni.SetDecoration(Me.PictureBox1, BunifuAnimatorNS.DecorationType.None)
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(80, 17)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(128, 128)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'BunifuFlatButton3
        '
        Me.BunifuFlatButton3.Activecolor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.BunifuFlatButton3.BackColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.BunifuFlatButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton3.BorderRadius = 0
        Me.BunifuFlatButton3.ButtonText = "Dashboard"
        Me.BunifuFlatButton3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.menuAni.SetDecoration(Me.BunifuFlatButton3, BunifuAnimatorNS.DecorationType.None)
        Me.userAni.SetDecoration(Me.BunifuFlatButton3, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuFlatButton3.DisabledColor = System.Drawing.Color.Gray
        Me.BunifuFlatButton3.Iconcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton3.Iconimage = CType(resources.GetObject("BunifuFlatButton3.Iconimage"), System.Drawing.Image)
        Me.BunifuFlatButton3.Iconimage_right = Nothing
        Me.BunifuFlatButton3.Iconimage_right_Selected = Nothing
        Me.BunifuFlatButton3.Iconimage_Selected = Nothing
        Me.BunifuFlatButton3.IconMarginLeft = 0
        Me.BunifuFlatButton3.IconMarginRight = 0
        Me.BunifuFlatButton3.IconRightVisible = True
        Me.BunifuFlatButton3.IconRightZoom = 0R
        Me.BunifuFlatButton3.IconVisible = True
        Me.BunifuFlatButton3.IconZoom = 60.0R
        Me.BunifuFlatButton3.IsTab = True
        Me.BunifuFlatButton3.Location = New System.Drawing.Point(3, 500)
        Me.BunifuFlatButton3.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.BunifuFlatButton3.Name = "BunifuFlatButton3"
        Me.BunifuFlatButton3.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.BunifuFlatButton3.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.BunifuFlatButton3.OnHoverTextColor = System.Drawing.Color.Gray
        Me.BunifuFlatButton3.selected = True
        Me.BunifuFlatButton3.Size = New System.Drawing.Size(280, 50)
        Me.BunifuFlatButton3.TabIndex = 3
        Me.BunifuFlatButton3.Text = "Dashboard"
        Me.BunifuFlatButton3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BunifuFlatButton3.Textcolor = System.Drawing.Color.White
        Me.BunifuFlatButton3.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'BunifuFlatButton2
        '
        Me.BunifuFlatButton2.Activecolor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.BunifuFlatButton2.BackColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.BunifuFlatButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton2.BorderRadius = 0
        Me.BunifuFlatButton2.ButtonText = "Setting"
        Me.BunifuFlatButton2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.menuAni.SetDecoration(Me.BunifuFlatButton2, BunifuAnimatorNS.DecorationType.None)
        Me.userAni.SetDecoration(Me.BunifuFlatButton2, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuFlatButton2.DisabledColor = System.Drawing.Color.Gray
        Me.BunifuFlatButton2.Iconcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton2.Iconimage = CType(resources.GetObject("BunifuFlatButton2.Iconimage"), System.Drawing.Image)
        Me.BunifuFlatButton2.Iconimage_right = Nothing
        Me.BunifuFlatButton2.Iconimage_right_Selected = Nothing
        Me.BunifuFlatButton2.Iconimage_Selected = Nothing
        Me.BunifuFlatButton2.IconMarginLeft = 0
        Me.BunifuFlatButton2.IconMarginRight = 0
        Me.BunifuFlatButton2.IconRightVisible = True
        Me.BunifuFlatButton2.IconRightZoom = 0R
        Me.BunifuFlatButton2.IconVisible = True
        Me.BunifuFlatButton2.IconZoom = 60.0R
        Me.BunifuFlatButton2.IsTab = True
        Me.BunifuFlatButton2.Location = New System.Drawing.Point(3, 354)
        Me.BunifuFlatButton2.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.BunifuFlatButton2.Name = "BunifuFlatButton2"
        Me.BunifuFlatButton2.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.BunifuFlatButton2.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.BunifuFlatButton2.OnHoverTextColor = System.Drawing.Color.Gray
        Me.BunifuFlatButton2.selected = True
        Me.BunifuFlatButton2.Size = New System.Drawing.Size(280, 50)
        Me.BunifuFlatButton2.TabIndex = 2
        Me.BunifuFlatButton2.Text = "Setting"
        Me.BunifuFlatButton2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BunifuFlatButton2.Textcolor = System.Drawing.Color.White
        Me.BunifuFlatButton2.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'BunifuFlatButton1
        '
        Me.BunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.BunifuFlatButton1.BackColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.BunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton1.BorderRadius = 0
        Me.BunifuFlatButton1.ButtonText = "Load"
        Me.BunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.menuAni.SetDecoration(Me.BunifuFlatButton1, BunifuAnimatorNS.DecorationType.None)
        Me.userAni.SetDecoration(Me.BunifuFlatButton1, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray
        Me.BunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton1.Iconimage = CType(resources.GetObject("BunifuFlatButton1.Iconimage"), System.Drawing.Image)
        Me.BunifuFlatButton1.Iconimage_right = Nothing
        Me.BunifuFlatButton1.Iconimage_right_Selected = Nothing
        Me.BunifuFlatButton1.Iconimage_Selected = Nothing
        Me.BunifuFlatButton1.IconMarginLeft = 0
        Me.BunifuFlatButton1.IconMarginRight = 0
        Me.BunifuFlatButton1.IconRightVisible = True
        Me.BunifuFlatButton1.IconRightZoom = 0R
        Me.BunifuFlatButton1.IconVisible = True
        Me.BunifuFlatButton1.IconZoom = 60.0R
        Me.BunifuFlatButton1.IsTab = True
        Me.BunifuFlatButton1.Location = New System.Drawing.Point(2, 283)
        Me.BunifuFlatButton1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.BunifuFlatButton1.Name = "BunifuFlatButton1"
        Me.BunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.BunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.BunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.Gray
        Me.BunifuFlatButton1.selected = True
        Me.BunifuFlatButton1.Size = New System.Drawing.Size(280, 50)
        Me.BunifuFlatButton1.TabIndex = 1
        Me.BunifuFlatButton1.Text = "Load"
        Me.BunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BunifuFlatButton1.Textcolor = System.Drawing.Color.White
        Me.BunifuFlatButton1.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'header
        '
        Me.header.BackColor = System.Drawing.Color.LightGray
        Me.header.Controls.Add(Me.exitBTN)
        Me.menuAni.SetDecoration(Me.header, BunifuAnimatorNS.DecorationType.None)
        Me.userAni.SetDecoration(Me.header, BunifuAnimatorNS.DecorationType.None)
        Me.header.Dock = System.Windows.Forms.DockStyle.Top
        Me.header.Location = New System.Drawing.Point(0, 0)
        Me.header.Name = "header"
        Me.header.Size = New System.Drawing.Size(1800, 49)
        Me.header.TabIndex = 1
        '
        'exitBTN
        '
        Me.exitBTN.BackColor = System.Drawing.Color.DimGray
        Me.menuAni.SetDecoration(Me.exitBTN, BunifuAnimatorNS.DecorationType.None)
        Me.userAni.SetDecoration(Me.exitBTN, BunifuAnimatorNS.DecorationType.None)
        Me.exitBTN.Dock = System.Windows.Forms.DockStyle.Right
        Me.exitBTN.Image = CType(resources.GetObject("exitBTN.Image"), System.Drawing.Image)
        Me.exitBTN.ImageActive = Nothing
        Me.exitBTN.Location = New System.Drawing.Point(1768, 0)
        Me.exitBTN.Name = "exitBTN"
        Me.exitBTN.Size = New System.Drawing.Size(32, 49)
        Me.exitBTN.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.exitBTN.TabIndex = 0
        Me.exitBTN.TabStop = False
        Me.exitBTN.Zoom = 0
        '
        'BunifuDragControl1
        '
        Me.BunifuDragControl1.Fixed = True
        Me.BunifuDragControl1.Horizontal = True
        Me.BunifuDragControl1.TargetControl = Me.header
        Me.BunifuDragControl1.Vertical = True
        '
        'mainPanel
        '
        Me.mainPanel.BackColor = System.Drawing.Color.Transparent
        Me.menuAni.SetDecoration(Me.mainPanel, BunifuAnimatorNS.DecorationType.None)
        Me.userAni.SetDecoration(Me.mainPanel, BunifuAnimatorNS.DecorationType.None)
        Me.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.mainPanel.Location = New System.Drawing.Point(282, 49)
        Me.mainPanel.Name = "mainPanel"
        Me.mainPanel.Size = New System.Drawing.Size(1518, 951)
        Me.mainPanel.TabIndex = 2
        '
        'userAni
        '
        Me.userAni.AnimationType = BunifuAnimatorNS.AnimationType.ScaleAndRotate
        Me.userAni.Cursor = Nothing
        Animation2.AnimateOnlyDifferences = True
        Animation2.BlindCoeff = CType(resources.GetObject("Animation2.BlindCoeff"), System.Drawing.PointF)
        Animation2.LeafCoeff = 0!
        Animation2.MaxTime = 1.0!
        Animation2.MinTime = 0!
        Animation2.MosaicCoeff = CType(resources.GetObject("Animation2.MosaicCoeff"), System.Drawing.PointF)
        Animation2.MosaicShift = CType(resources.GetObject("Animation2.MosaicShift"), System.Drawing.PointF)
        Animation2.MosaicSize = 0
        Animation2.Padding = New System.Windows.Forms.Padding(30)
        Animation2.RotateCoeff = 0.5!
        Animation2.RotateLimit = 0.2!
        Animation2.ScaleCoeff = CType(resources.GetObject("Animation2.ScaleCoeff"), System.Drawing.PointF)
        Animation2.SlideCoeff = CType(resources.GetObject("Animation2.SlideCoeff"), System.Drawing.PointF)
        Animation2.TimeCoeff = 0!
        Animation2.TransparencyCoeff = 0!
        Me.userAni.DefaultAnimation = Animation2
        '
        'menuAni
        '
        Me.menuAni.AnimationType = BunifuAnimatorNS.AnimationType.VertBlind
        Me.menuAni.Cursor = Nothing
        Animation1.AnimateOnlyDifferences = True
        Animation1.BlindCoeff = CType(resources.GetObject("Animation1.BlindCoeff"), System.Drawing.PointF)
        Animation1.LeafCoeff = 0!
        Animation1.MaxTime = 1.0!
        Animation1.MinTime = 0!
        Animation1.MosaicCoeff = CType(resources.GetObject("Animation1.MosaicCoeff"), System.Drawing.PointF)
        Animation1.MosaicShift = CType(resources.GetObject("Animation1.MosaicShift"), System.Drawing.PointF)
        Animation1.MosaicSize = 0
        Animation1.Padding = New System.Windows.Forms.Padding(0)
        Animation1.RotateCoeff = 0!
        Animation1.RotateLimit = 0!
        Animation1.ScaleCoeff = CType(resources.GetObject("Animation1.ScaleCoeff"), System.Drawing.PointF)
        Animation1.SlideCoeff = CType(resources.GetObject("Animation1.SlideCoeff"), System.Drawing.PointF)
        Animation1.TimeCoeff = 0!
        Animation1.TransparencyCoeff = 0!
        Me.menuAni.DefaultAnimation = Animation1
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1800, 1000)
        Me.Controls.Add(Me.mainPanel)
        Me.Controls.Add(Me.sidePanel)
        Me.Controls.Add(Me.header)
        Me.userAni.SetDecoration(Me, BunifuAnimatorNS.DecorationType.None)
        Me.menuAni.SetDecoration(Me, BunifuAnimatorNS.DecorationType.None)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Main"
        Me.Text = "Main"
        Me.sidePanel.ResumeLayout(False)
        CType(Me.menuChangeBTN, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.userPanel.ResumeLayout(False)
        Me.userPanel.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.header.ResumeLayout(False)
        CType(Me.exitBTN, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents sidePanel As Panel
    Friend WithEvents header As Panel
    Friend WithEvents BunifuDragControl1 As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents BunifuFlatButton1 As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents exitBTN As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents BunifuFlatButton3 As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BunifuFlatButton2 As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents userPanel As Panel
    Friend WithEvents DateLB As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents nameLB As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents mainPanel As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents mainStatusLB As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents menuAni As BunifuAnimatorNS.BunifuTransition
    Friend WithEvents userAni As BunifuAnimatorNS.BunifuTransition
    Friend WithEvents menuChangeBTN As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BunifuFlatButton4 As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BunifuCircleProgressbar1 As Bunifu.Framework.UI.BunifuCircleProgressbar
End Class
