<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StockAddForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(StockAddForm))
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.sdDropMnu = New Bunifu.Framework.UI.BunifuDropdown()
        Me.mmDropMnu = New Bunifu.Framework.UI.BunifuDropdown()
        Me.meterLB = New System.Windows.Forms.TextBox()
        Me.BunifuCustomLabel1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel2 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel3 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel4 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.tonTB = New System.Windows.Forms.TextBox()
        Me.addBTN = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.BunifuImageButton1 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.BunifuDragControl1 = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.TopPanel = New System.Windows.Forms.Panel()
        CType(Me.BunifuImageButton1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TopPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 5
        Me.BunifuElipse1.TargetControl = Me
        '
        'sdDropMnu
        '
        Me.sdDropMnu.BackColor = System.Drawing.Color.Transparent
        Me.sdDropMnu.BorderRadius = 3
        Me.sdDropMnu.ForeColor = System.Drawing.Color.White
        Me.sdDropMnu.Items = New String() {"SD400", "SD500", "SD600"}
        Me.sdDropMnu.Location = New System.Drawing.Point(158, 52)
        Me.sdDropMnu.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.sdDropMnu.Name = "sdDropMnu"
        Me.sdDropMnu.NomalColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.sdDropMnu.onHoverColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.sdDropMnu.selectedIndex = 0
        Me.sdDropMnu.Size = New System.Drawing.Size(289, 46)
        Me.sdDropMnu.TabIndex = 0
        '
        'mmDropMnu
        '
        Me.mmDropMnu.BackColor = System.Drawing.Color.Transparent
        Me.mmDropMnu.BorderRadius = 3
        Me.mmDropMnu.ForeColor = System.Drawing.Color.White
        Me.mmDropMnu.Items = New String() {"10mm", "13mm", "16mm", "19mm", "22mm", "25mm", "29mm", "32mm", "35mm"}
        Me.mmDropMnu.Location = New System.Drawing.Point(158, 115)
        Me.mmDropMnu.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.mmDropMnu.Name = "mmDropMnu"
        Me.mmDropMnu.NomalColor = System.Drawing.Color.DarkBlue
        Me.mmDropMnu.onHoverColor = System.Drawing.Color.DarkBlue
        Me.mmDropMnu.selectedIndex = 0
        Me.mmDropMnu.Size = New System.Drawing.Size(289, 45)
        Me.mmDropMnu.TabIndex = 1
        '
        'meterLB
        '
        Me.meterLB.Location = New System.Drawing.Point(158, 184)
        Me.meterLB.Name = "meterLB"
        Me.meterLB.Size = New System.Drawing.Size(289, 25)
        Me.meterLB.TabIndex = 2
        '
        'BunifuCustomLabel1
        '
        Me.BunifuCustomLabel1.AutoSize = True
        Me.BunifuCustomLabel1.Location = New System.Drawing.Point(61, 67)
        Me.BunifuCustomLabel1.Name = "BunifuCustomLabel1"
        Me.BunifuCustomLabel1.Size = New System.Drawing.Size(37, 15)
        Me.BunifuCustomLabel1.TabIndex = 3
        Me.BunifuCustomLabel1.Text = "강종"
        '
        'BunifuCustomLabel2
        '
        Me.BunifuCustomLabel2.AutoSize = True
        Me.BunifuCustomLabel2.Location = New System.Drawing.Point(62, 124)
        Me.BunifuCustomLabel2.Name = "BunifuCustomLabel2"
        Me.BunifuCustomLabel2.Size = New System.Drawing.Size(37, 15)
        Me.BunifuCustomLabel2.TabIndex = 4
        Me.BunifuCustomLabel2.Text = "미리"
        '
        'BunifuCustomLabel3
        '
        Me.BunifuCustomLabel3.AutoSize = True
        Me.BunifuCustomLabel3.Location = New System.Drawing.Point(61, 184)
        Me.BunifuCustomLabel3.Name = "BunifuCustomLabel3"
        Me.BunifuCustomLabel3.Size = New System.Drawing.Size(61, 15)
        Me.BunifuCustomLabel3.TabIndex = 5
        Me.BunifuCustomLabel3.Text = "길이(M)"
        '
        'BunifuCustomLabel4
        '
        Me.BunifuCustomLabel4.AutoSize = True
        Me.BunifuCustomLabel4.Location = New System.Drawing.Point(61, 241)
        Me.BunifuCustomLabel4.Name = "BunifuCustomLabel4"
        Me.BunifuCustomLabel4.Size = New System.Drawing.Size(38, 15)
        Me.BunifuCustomLabel4.TabIndex = 7
        Me.BunifuCustomLabel4.Text = "톤(t)"
        '
        'tonTB
        '
        Me.tonTB.Location = New System.Drawing.Point(158, 241)
        Me.tonTB.Name = "tonTB"
        Me.tonTB.Size = New System.Drawing.Size(289, 25)
        Me.tonTB.TabIndex = 6
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
        Me.addBTN.ButtonText = "추가"
        Me.addBTN.Cursor = System.Windows.Forms.Cursors.Hand
        Me.addBTN.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addBTN.ForeColor = System.Drawing.Color.SeaGreen
        Me.addBTN.IdleBorderThickness = 1
        Me.addBTN.IdleCornerRadius = 20
        Me.addBTN.IdleFillColor = System.Drawing.Color.White
        Me.addBTN.IdleForecolor = System.Drawing.Color.SeaGreen
        Me.addBTN.IdleLineColor = System.Drawing.Color.SeaGreen
        Me.addBTN.Location = New System.Drawing.Point(64, 292)
        Me.addBTN.Margin = New System.Windows.Forms.Padding(5)
        Me.addBTN.Name = "addBTN"
        Me.addBTN.Size = New System.Drawing.Size(383, 41)
        Me.addBTN.TabIndex = 8
        Me.addBTN.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BunifuImageButton1
        '
        Me.BunifuImageButton1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BunifuImageButton1.Image = CType(resources.GetObject("BunifuImageButton1.Image"), System.Drawing.Image)
        Me.BunifuImageButton1.ImageActive = Nothing
        Me.BunifuImageButton1.Location = New System.Drawing.Point(477, -2)
        Me.BunifuImageButton1.Name = "BunifuImageButton1"
        Me.BunifuImageButton1.Size = New System.Drawing.Size(46, 35)
        Me.BunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.BunifuImageButton1.TabIndex = 0
        Me.BunifuImageButton1.TabStop = False
        Me.BunifuImageButton1.Zoom = 0
        '
        'BunifuDragControl1
        '
        Me.BunifuDragControl1.Fixed = True
        Me.BunifuDragControl1.Horizontal = True
        Me.BunifuDragControl1.TargetControl = Me.TopPanel
        Me.BunifuDragControl1.Vertical = True
        '
        'TopPanel
        '
        Me.TopPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TopPanel.Controls.Add(Me.BunifuImageButton1)
        Me.TopPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.TopPanel.Location = New System.Drawing.Point(0, 0)
        Me.TopPanel.Name = "TopPanel"
        Me.TopPanel.Size = New System.Drawing.Size(523, 33)
        Me.TopPanel.TabIndex = 9
        '
        'StockAddForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(523, 366)
        Me.Controls.Add(Me.TopPanel)
        Me.Controls.Add(Me.addBTN)
        Me.Controls.Add(Me.BunifuCustomLabel4)
        Me.Controls.Add(Me.tonTB)
        Me.Controls.Add(Me.BunifuCustomLabel3)
        Me.Controls.Add(Me.BunifuCustomLabel2)
        Me.Controls.Add(Me.BunifuCustomLabel1)
        Me.Controls.Add(Me.meterLB)
        Me.Controls.Add(Me.mmDropMnu)
        Me.Controls.Add(Me.sdDropMnu)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "StockAddForm"
        Me.Text = "StockAddForm"
        CType(Me.BunifuImageButton1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TopPanel.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents sdDropMnu As Bunifu.Framework.UI.BunifuDropdown
    Friend WithEvents BunifuCustomLabel4 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents tonTB As TextBox
    Friend WithEvents BunifuCustomLabel3 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel2 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents meterLB As TextBox
    Friend WithEvents mmDropMnu As Bunifu.Framework.UI.BunifuDropdown
    Friend WithEvents BunifuImageButton1 As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents addBTN As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents BunifuDragControl1 As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents TopPanel As Panel
End Class
