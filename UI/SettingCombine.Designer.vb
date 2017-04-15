<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SettingCombine
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SettingCombine))
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.BunifuImageButton1 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.BunifuCustomLabel1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel3 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel2 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.swShape = New Bunifu.Framework.UI.BunifuiOSSwitch()
        Me.swScene = New Bunifu.Framework.UI.BunifuiOSSwitch()
        Me.swKongjung = New Bunifu.Framework.UI.BunifuiOSSwitch()
        Me.BunifuCustomLabel4 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.kireSW = New Bunifu.Framework.UI.BunifuiOSSwitch()
        Me.BunifuCustomLabel5 = New Bunifu.Framework.UI.BunifuCustomLabel()
        CType(Me.BunifuImageButton1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 5
        Me.BunifuElipse1.TargetControl = Me
        '
        'BunifuImageButton1
        '
        Me.BunifuImageButton1.BackColor = System.Drawing.Color.SeaGreen
        Me.BunifuImageButton1.Image = CType(resources.GetObject("BunifuImageButton1.Image"), System.Drawing.Image)
        Me.BunifuImageButton1.ImageActive = Nothing
        Me.BunifuImageButton1.Location = New System.Drawing.Point(817, 301)
        Me.BunifuImageButton1.Name = "BunifuImageButton1"
        Me.BunifuImageButton1.Size = New System.Drawing.Size(71, 71)
        Me.BunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BunifuImageButton1.TabIndex = 6
        Me.BunifuImageButton1.TabStop = False
        Me.BunifuImageButton1.Zoom = 10
        '
        'BunifuCustomLabel1
        '
        Me.BunifuCustomLabel1.AutoSize = True
        Me.BunifuCustomLabel1.Location = New System.Drawing.Point(74, 110)
        Me.BunifuCustomLabel1.Name = "BunifuCustomLabel1"
        Me.BunifuCustomLabel1.Size = New System.Drawing.Size(122, 15)
        Me.BunifuCustomLabel1.TabIndex = 0
        Me.BunifuCustomLabel1.Text = "같은 형상만 조합"
        '
        'BunifuCustomLabel3
        '
        Me.BunifuCustomLabel3.AutoSize = True
        Me.BunifuCustomLabel3.Location = New System.Drawing.Point(74, 242)
        Me.BunifuCustomLabel3.Name = "BunifuCustomLabel3"
        Me.BunifuCustomLabel3.Size = New System.Drawing.Size(137, 15)
        Me.BunifuCustomLabel3.TabIndex = 2
        Me.BunifuCustomLabel3.Text = "같은 공정명만 조합"
        '
        'BunifuCustomLabel2
        '
        Me.BunifuCustomLabel2.AutoSize = True
        Me.BunifuCustomLabel2.Location = New System.Drawing.Point(74, 191)
        Me.BunifuCustomLabel2.Name = "BunifuCustomLabel2"
        Me.BunifuCustomLabel2.Size = New System.Drawing.Size(122, 15)
        Me.BunifuCustomLabel2.TabIndex = 1
        Me.BunifuCustomLabel2.Text = "같은 현장만 조합"
        '
        'swShape
        '
        Me.swShape.BackColor = System.Drawing.Color.Transparent
        Me.swShape.BackgroundImage = CType(resources.GetObject("swShape.BackgroundImage"), System.Drawing.Image)
        Me.swShape.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.swShape.Cursor = System.Windows.Forms.Cursors.Hand
        Me.swShape.Location = New System.Drawing.Point(269, 110)
        Me.swShape.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.swShape.Name = "swShape"
        Me.swShape.OffColor = System.Drawing.Color.Gray
        Me.swShape.OnColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.swShape.Size = New System.Drawing.Size(43, 25)
        Me.swShape.TabIndex = 3
        Me.swShape.Value = True
        '
        'swScene
        '
        Me.swScene.BackColor = System.Drawing.Color.Transparent
        Me.swScene.BackgroundImage = CType(resources.GetObject("swScene.BackgroundImage"), System.Drawing.Image)
        Me.swScene.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.swScene.Cursor = System.Windows.Forms.Cursors.Hand
        Me.swScene.Location = New System.Drawing.Point(269, 191)
        Me.swScene.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.swScene.Name = "swScene"
        Me.swScene.OffColor = System.Drawing.Color.Gray
        Me.swScene.OnColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.swScene.Size = New System.Drawing.Size(43, 25)
        Me.swScene.TabIndex = 4
        Me.swScene.Value = True
        '
        'swKongjung
        '
        Me.swKongjung.BackColor = System.Drawing.Color.Transparent
        Me.swKongjung.BackgroundImage = CType(resources.GetObject("swKongjung.BackgroundImage"), System.Drawing.Image)
        Me.swKongjung.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.swKongjung.Cursor = System.Windows.Forms.Cursors.Hand
        Me.swKongjung.Location = New System.Drawing.Point(269, 242)
        Me.swKongjung.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.swKongjung.Name = "swKongjung"
        Me.swKongjung.OffColor = System.Drawing.Color.Gray
        Me.swKongjung.OnColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.swKongjung.Size = New System.Drawing.Size(43, 25)
        Me.swKongjung.TabIndex = 5
        Me.swKongjung.Value = True
        '
        'BunifuCustomLabel4
        '
        Me.BunifuCustomLabel4.AutoSize = True
        Me.BunifuCustomLabel4.Font = New System.Drawing.Font("돋움", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.BunifuCustomLabel4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BunifuCustomLabel4.Location = New System.Drawing.Point(73, 41)
        Me.BunifuCustomLabel4.Name = "BunifuCustomLabel4"
        Me.BunifuCustomLabel4.Size = New System.Drawing.Size(178, 24)
        Me.BunifuCustomLabel4.TabIndex = 8
        Me.BunifuCustomLabel4.Text = "조합 옵션 설정"
        '
        'kireSW
        '
        Me.kireSW.BackColor = System.Drawing.Color.Transparent
        Me.kireSW.BackgroundImage = CType(resources.GetObject("kireSW.BackgroundImage"), System.Drawing.Image)
        Me.kireSW.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.kireSW.Cursor = System.Windows.Forms.Cursors.Hand
        Me.kireSW.Location = New System.Drawing.Point(583, 110)
        Me.kireSW.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.kireSW.Name = "kireSW"
        Me.kireSW.OffColor = System.Drawing.Color.Gray
        Me.kireSW.OnColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.kireSW.Size = New System.Drawing.Size(43, 25)
        Me.kireSW.TabIndex = 10
        Me.kireSW.Value = True
        '
        'BunifuCustomLabel5
        '
        Me.BunifuCustomLabel5.AutoSize = True
        Me.BunifuCustomLabel5.Location = New System.Drawing.Point(420, 110)
        Me.BunifuCustomLabel5.Name = "BunifuCustomLabel5"
        Me.BunifuCustomLabel5.Size = New System.Drawing.Size(137, 15)
        Me.BunifuCustomLabel5.TabIndex = 9
        Me.BunifuCustomLabel5.Text = "부분 로스까지 적용"
        '
        'SettingCombine
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.kireSW)
        Me.Controls.Add(Me.BunifuCustomLabel5)
        Me.Controls.Add(Me.BunifuImageButton1)
        Me.Controls.Add(Me.BunifuCustomLabel4)
        Me.Controls.Add(Me.BunifuCustomLabel1)
        Me.Controls.Add(Me.swKongjung)
        Me.Controls.Add(Me.BunifuCustomLabel3)
        Me.Controls.Add(Me.swScene)
        Me.Controls.Add(Me.BunifuCustomLabel2)
        Me.Controls.Add(Me.swShape)
        Me.Name = "SettingCombine"
        Me.Size = New System.Drawing.Size(928, 403)
        CType(Me.BunifuImageButton1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents BunifuImageButton1 As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents BunifuCustomLabel4 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents swKongjung As Bunifu.Framework.UI.BunifuiOSSwitch
    Friend WithEvents BunifuCustomLabel3 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents swScene As Bunifu.Framework.UI.BunifuiOSSwitch
    Friend WithEvents BunifuCustomLabel2 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents swShape As Bunifu.Framework.UI.BunifuiOSSwitch
    Friend WithEvents kireSW As Bunifu.Framework.UI.BunifuiOSSwitch
    Friend WithEvents BunifuCustomLabel5 As Bunifu.Framework.UI.BunifuCustomLabel
End Class
