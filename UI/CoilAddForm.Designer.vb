<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CoilAddForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CoilAddForm))
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.topPanel = New System.Windows.Forms.Panel()
        Me.BunifuImageButton1 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.onesideLENTB = New System.Windows.Forms.TextBox()
        Me.BunifuCustomLabel1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.addBTN = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.BunifuDragControl1 = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
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
        Me.topPanel.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.topPanel.Controls.Add(Me.BunifuImageButton1)
        Me.topPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.topPanel.Location = New System.Drawing.Point(0, 0)
        Me.topPanel.Name = "topPanel"
        Me.topPanel.Size = New System.Drawing.Size(957, 54)
        Me.topPanel.TabIndex = 0
        '
        'BunifuImageButton1
        '
        Me.BunifuImageButton1.BackColor = System.Drawing.Color.DimGray
        Me.BunifuImageButton1.Dock = System.Windows.Forms.DockStyle.Right
        Me.BunifuImageButton1.Image = CType(resources.GetObject("BunifuImageButton1.Image"), System.Drawing.Image)
        Me.BunifuImageButton1.ImageActive = Nothing
        Me.BunifuImageButton1.Location = New System.Drawing.Point(923, 0)
        Me.BunifuImageButton1.Name = "BunifuImageButton1"
        Me.BunifuImageButton1.Size = New System.Drawing.Size(34, 54)
        Me.BunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.BunifuImageButton1.TabIndex = 0
        Me.BunifuImageButton1.TabStop = False
        Me.BunifuImageButton1.Zoom = 0
        '
        'ListView1
        '
        Me.ListView1.Dock = System.Windows.Forms.DockStyle.Left
        Me.ListView1.Location = New System.Drawing.Point(0, 54)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(641, 432)
        Me.ListView1.TabIndex = 1
        Me.ListView1.UseCompatibleStateImageBehavior = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox1.Location = New System.Drawing.Point(675, 86)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(250, 125)
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'onesideLENTB
        '
        Me.onesideLENTB.Location = New System.Drawing.Point(675, 296)
        Me.onesideLENTB.Name = "onesideLENTB"
        Me.onesideLENTB.Size = New System.Drawing.Size(250, 25)
        Me.onesideLENTB.TabIndex = 3
        '
        'BunifuCustomLabel1
        '
        Me.BunifuCustomLabel1.AutoSize = True
        Me.BunifuCustomLabel1.Location = New System.Drawing.Point(672, 261)
        Me.BunifuCustomLabel1.Name = "BunifuCustomLabel1"
        Me.BunifuCustomLabel1.Size = New System.Drawing.Size(92, 15)
        Me.BunifuCustomLabel1.TabIndex = 4
        Me.BunifuCustomLabel1.Text = "한 변의 길이"
        '
        'addBTN
        '
        Me.addBTN.ActiveBorderThickness = 1
        Me.addBTN.ActiveCornerRadius = 20
        Me.addBTN.ActiveFillColor = System.Drawing.Color.SeaGreen
        Me.addBTN.ActiveForecolor = System.Drawing.Color.White
        Me.addBTN.ActiveLineColor = System.Drawing.Color.SeaGreen
        Me.addBTN.BackColor = System.Drawing.SystemColors.Control
        Me.addBTN.BackgroundImage = CType(resources.GetObject("addBTN.BackgroundImage"), System.Drawing.Image)
        Me.addBTN.ButtonText = "ADD"
        Me.addBTN.Cursor = System.Windows.Forms.Cursors.Hand
        Me.addBTN.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addBTN.ForeColor = System.Drawing.Color.SeaGreen
        Me.addBTN.IdleBorderThickness = 1
        Me.addBTN.IdleCornerRadius = 20
        Me.addBTN.IdleFillColor = System.Drawing.Color.White
        Me.addBTN.IdleForecolor = System.Drawing.Color.SeaGreen
        Me.addBTN.IdleLineColor = System.Drawing.Color.SeaGreen
        Me.addBTN.Location = New System.Drawing.Point(675, 368)
        Me.addBTN.Margin = New System.Windows.Forms.Padding(5)
        Me.addBTN.Name = "addBTN"
        Me.addBTN.Size = New System.Drawing.Size(250, 41)
        Me.addBTN.TabIndex = 5
        Me.addBTN.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BunifuDragControl1
        '
        Me.BunifuDragControl1.Fixed = True
        Me.BunifuDragControl1.Horizontal = True
        Me.BunifuDragControl1.TargetControl = Me.topPanel
        Me.BunifuDragControl1.Vertical = True
        '
        'CoilAddForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(957, 486)
        Me.Controls.Add(Me.addBTN)
        Me.Controls.Add(Me.BunifuCustomLabel1)
        Me.Controls.Add(Me.onesideLENTB)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.topPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "CoilAddForm"
        Me.Text = "CoilAddForm"
        Me.topPanel.ResumeLayout(False)
        CType(Me.BunifuImageButton1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents BunifuCustomLabel1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents onesideLENTB As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ListView1 As ListView
    Friend WithEvents topPanel As Panel
    Friend WithEvents addBTN As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents BunifuImageButton1 As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents BunifuDragControl1 As Bunifu.Framework.UI.BunifuDragControl
End Class
