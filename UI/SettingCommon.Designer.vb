<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SettingCommon
    Inherits System.Windows.Forms.UserControl

    'UserControl은 Dispose를 재정의하여 구성 요소 목록을 정리합니다.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SettingCommon))
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.BunifuCustomLabel1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.swStock = New Bunifu.Framework.UI.BunifuiOSSwitch()
        Me.BunifuCustomLabel2 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.tbError = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.BunifuCustomLabel3 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel4 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.swCoil = New Bunifu.Framework.UI.BunifuiOSSwitch()
        Me.BunifuImageButton1 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.BunifuCustomLabel5 = New Bunifu.Framework.UI.BunifuCustomLabel()
        CType(Me.BunifuImageButton1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 5
        Me.BunifuElipse1.TargetControl = Me
        '
        'BunifuCustomLabel1
        '
        Me.BunifuCustomLabel1.AutoSize = True
        Me.BunifuCustomLabel1.Location = New System.Drawing.Point(63, 135)
        Me.BunifuCustomLabel1.Name = "BunifuCustomLabel1"
        Me.BunifuCustomLabel1.Size = New System.Drawing.Size(122, 15)
        Me.BunifuCustomLabel1.TabIndex = 0
        Me.BunifuCustomLabel1.Text = "재고 미터만 연동"
        '
        'swStock
        '
        Me.swStock.BackColor = System.Drawing.Color.Transparent
        Me.swStock.BackgroundImage = CType(resources.GetObject("swStock.BackgroundImage"), System.Drawing.Image)
        Me.swStock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.swStock.Cursor = System.Windows.Forms.Cursors.Hand
        Me.swStock.Location = New System.Drawing.Point(246, 135)
        Me.swStock.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.swStock.Name = "swStock"
        Me.swStock.OffColor = System.Drawing.Color.Gray
        Me.swStock.OnColor = System.Drawing.Color.DarkGoldenrod
        Me.swStock.Size = New System.Drawing.Size(43, 25)
        Me.swStock.TabIndex = 1
        Me.swStock.Value = True
        '
        'BunifuCustomLabel2
        '
        Me.BunifuCustomLabel2.AutoSize = True
        Me.BunifuCustomLabel2.Location = New System.Drawing.Point(63, 272)
        Me.BunifuCustomLabel2.Name = "BunifuCustomLabel2"
        Me.BunifuCustomLabel2.Size = New System.Drawing.Size(107, 15)
        Me.BunifuCustomLabel2.TabIndex = 2
        Me.BunifuCustomLabel2.Text = "허용 오차 길이"
        '
        'tbError
        '
        Me.tbError.BorderColor = System.Drawing.Color.SeaGreen
        Me.tbError.Location = New System.Drawing.Point(204, 272)
        Me.tbError.Name = "tbError"
        Me.tbError.Size = New System.Drawing.Size(125, 25)
        Me.tbError.TabIndex = 4
        '
        'BunifuCustomLabel3
        '
        Me.BunifuCustomLabel3.AutoSize = True
        Me.BunifuCustomLabel3.Location = New System.Drawing.Point(335, 282)
        Me.BunifuCustomLabel3.Name = "BunifuCustomLabel3"
        Me.BunifuCustomLabel3.Size = New System.Drawing.Size(29, 15)
        Me.BunifuCustomLabel3.TabIndex = 5
        Me.BunifuCustomLabel3.Text = "mm"
        '
        'BunifuCustomLabel4
        '
        Me.BunifuCustomLabel4.AutoSize = True
        Me.BunifuCustomLabel4.Location = New System.Drawing.Point(63, 200)
        Me.BunifuCustomLabel4.Name = "BunifuCustomLabel4"
        Me.BunifuCustomLabel4.Size = New System.Drawing.Size(72, 15)
        Me.BunifuCustomLabel4.TabIndex = 6
        Me.BunifuCustomLabel4.Text = "코일 제외"
        '
        'swCoil
        '
        Me.swCoil.BackColor = System.Drawing.Color.Transparent
        Me.swCoil.BackgroundImage = CType(resources.GetObject("swCoil.BackgroundImage"), System.Drawing.Image)
        Me.swCoil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.swCoil.Cursor = System.Windows.Forms.Cursors.Hand
        Me.swCoil.Location = New System.Drawing.Point(246, 200)
        Me.swCoil.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.swCoil.Name = "swCoil"
        Me.swCoil.OffColor = System.Drawing.Color.Gray
        Me.swCoil.OnColor = System.Drawing.Color.DarkGoldenrod
        Me.swCoil.Size = New System.Drawing.Size(43, 25)
        Me.swCoil.TabIndex = 7
        Me.swCoil.Value = True
        '
        'BunifuImageButton1
        '
        Me.BunifuImageButton1.BackColor = System.Drawing.Color.SeaGreen
        Me.BunifuImageButton1.Image = CType(resources.GetObject("BunifuImageButton1.Image"), System.Drawing.Image)
        Me.BunifuImageButton1.ImageActive = Nothing
        Me.BunifuImageButton1.Location = New System.Drawing.Point(742, 424)
        Me.BunifuImageButton1.Name = "BunifuImageButton1"
        Me.BunifuImageButton1.Size = New System.Drawing.Size(73, 60)
        Me.BunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BunifuImageButton1.TabIndex = 8
        Me.BunifuImageButton1.TabStop = False
        Me.BunifuImageButton1.Zoom = 10
        '
        'BunifuCustomLabel5
        '
        Me.BunifuCustomLabel5.AutoSize = True
        Me.BunifuCustomLabel5.Font = New System.Drawing.Font("돋움", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.BunifuCustomLabel5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BunifuCustomLabel5.Location = New System.Drawing.Point(62, 29)
        Me.BunifuCustomLabel5.Name = "BunifuCustomLabel5"
        Me.BunifuCustomLabel5.Size = New System.Drawing.Size(178, 24)
        Me.BunifuCustomLabel5.TabIndex = 9
        Me.BunifuCustomLabel5.Text = "공통 옵션 설정"
        '
        'SettingCommon
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.Controls.Add(Me.BunifuCustomLabel5)
        Me.Controls.Add(Me.BunifuImageButton1)
        Me.Controls.Add(Me.swCoil)
        Me.Controls.Add(Me.BunifuCustomLabel4)
        Me.Controls.Add(Me.BunifuCustomLabel3)
        Me.Controls.Add(Me.tbError)
        Me.Controls.Add(Me.BunifuCustomLabel2)
        Me.Controls.Add(Me.swStock)
        Me.Controls.Add(Me.BunifuCustomLabel1)
        Me.Name = "SettingCommon"
        Me.Size = New System.Drawing.Size(850, 524)
        CType(Me.BunifuImageButton1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents swCoil As Bunifu.Framework.UI.BunifuiOSSwitch
    Friend WithEvents BunifuCustomLabel4 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel3 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents tbError As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents BunifuCustomLabel2 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents swStock As Bunifu.Framework.UI.BunifuiOSSwitch
    Friend WithEvents BunifuCustomLabel1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuImageButton1 As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents BunifuCustomLabel5 As Bunifu.Framework.UI.BunifuCustomLabel
End Class
