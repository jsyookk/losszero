<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CoilListForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CoilListForm))
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.topPanel = New System.Windows.Forms.Panel()
        Me.BunifuImageButton1 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.BunifuDragControl1 = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.coilShpListview = New System.Windows.Forms.ListView()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.allChkBox = New Bunifu.Framework.UI.BunifuCheckbox()
        Me.BunifuCustomLabel1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel2 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.oneSideLenTB = New System.Windows.Forms.TextBox()
        Me.editBTN = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.delBTN = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.addBTN = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.topPanel.SuspendLayout()
        CType(Me.BunifuImageButton1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
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
        Me.topPanel.Size = New System.Drawing.Size(941, 44)
        Me.topPanel.TabIndex = 0
        '
        'BunifuImageButton1
        '
        Me.BunifuImageButton1.BackColor = System.Drawing.Color.DimGray
        Me.BunifuImageButton1.Dock = System.Windows.Forms.DockStyle.Right
        Me.BunifuImageButton1.Image = CType(resources.GetObject("BunifuImageButton1.Image"), System.Drawing.Image)
        Me.BunifuImageButton1.ImageActive = Nothing
        Me.BunifuImageButton1.Location = New System.Drawing.Point(908, 0)
        Me.BunifuImageButton1.Name = "BunifuImageButton1"
        Me.BunifuImageButton1.Size = New System.Drawing.Size(33, 44)
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
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.coilShpListview)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 44)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(481, 693)
        Me.Panel1.TabIndex = 1
        '
        'coilShpListview
        '
        Me.coilShpListview.Dock = System.Windows.Forms.DockStyle.Fill
        Me.coilShpListview.Location = New System.Drawing.Point(0, 0)
        Me.coilShpListview.Name = "coilShpListview"
        Me.coilShpListview.Size = New System.Drawing.Size(481, 693)
        Me.coilShpListview.TabIndex = 0
        Me.coilShpListview.UseCompatibleStateImageBehavior = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox1.Location = New System.Drawing.Point(582, 123)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(256, 153)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'allChkBox
        '
        Me.allChkBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.allChkBox.ChechedOffColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.allChkBox.Checked = True
        Me.allChkBox.CheckedOnColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.allChkBox.ForeColor = System.Drawing.Color.White
        Me.allChkBox.Location = New System.Drawing.Point(582, 332)
        Me.allChkBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.allChkBox.Name = "allChkBox"
        Me.allChkBox.Size = New System.Drawing.Size(20, 20)
        Me.allChkBox.TabIndex = 4
        '
        'BunifuCustomLabel1
        '
        Me.BunifuCustomLabel1.AutoSize = True
        Me.BunifuCustomLabel1.Location = New System.Drawing.Point(609, 337)
        Me.BunifuCustomLabel1.Name = "BunifuCustomLabel1"
        Me.BunifuCustomLabel1.Size = New System.Drawing.Size(107, 15)
        Me.BunifuCustomLabel1.TabIndex = 5
        Me.BunifuCustomLabel1.Text = "길이 일괄 변경"
        '
        'BunifuCustomLabel2
        '
        Me.BunifuCustomLabel2.AutoSize = True
        Me.BunifuCustomLabel2.Location = New System.Drawing.Point(579, 384)
        Me.BunifuCustomLabel2.Name = "BunifuCustomLabel2"
        Me.BunifuCustomLabel2.Size = New System.Drawing.Size(92, 15)
        Me.BunifuCustomLabel2.TabIndex = 6
        Me.BunifuCustomLabel2.Text = "한 변의 길이"
        '
        'oneSideLenTB
        '
        Me.oneSideLenTB.Location = New System.Drawing.Point(582, 422)
        Me.oneSideLenTB.Name = "oneSideLenTB"
        Me.oneSideLenTB.Size = New System.Drawing.Size(256, 25)
        Me.oneSideLenTB.TabIndex = 7
        '
        'editBTN
        '
        Me.editBTN.ActiveBorderThickness = 1
        Me.editBTN.ActiveCornerRadius = 20
        Me.editBTN.ActiveFillColor = System.Drawing.Color.SeaGreen
        Me.editBTN.ActiveForecolor = System.Drawing.Color.White
        Me.editBTN.ActiveLineColor = System.Drawing.Color.SeaGreen
        Me.editBTN.BackColor = System.Drawing.SystemColors.Control
        Me.editBTN.BackgroundImage = CType(resources.GetObject("editBTN.BackgroundImage"), System.Drawing.Image)
        Me.editBTN.ButtonText = "수정"
        Me.editBTN.Cursor = System.Windows.Forms.Cursors.Hand
        Me.editBTN.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.editBTN.ForeColor = System.Drawing.Color.SeaGreen
        Me.editBTN.IdleBorderThickness = 1
        Me.editBTN.IdleCornerRadius = 20
        Me.editBTN.IdleFillColor = System.Drawing.Color.White
        Me.editBTN.IdleForecolor = System.Drawing.Color.SeaGreen
        Me.editBTN.IdleLineColor = System.Drawing.Color.SeaGreen
        Me.editBTN.Location = New System.Drawing.Point(582, 497)
        Me.editBTN.Margin = New System.Windows.Forms.Padding(5)
        Me.editBTN.Name = "editBTN"
        Me.editBTN.Size = New System.Drawing.Size(123, 41)
        Me.editBTN.TabIndex = 8
        Me.editBTN.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'delBTN
        '
        Me.delBTN.ActiveBorderThickness = 1
        Me.delBTN.ActiveCornerRadius = 20
        Me.delBTN.ActiveFillColor = System.Drawing.Color.SeaGreen
        Me.delBTN.ActiveForecolor = System.Drawing.Color.White
        Me.delBTN.ActiveLineColor = System.Drawing.Color.SeaGreen
        Me.delBTN.BackColor = System.Drawing.SystemColors.Control
        Me.delBTN.BackgroundImage = CType(resources.GetObject("delBTN.BackgroundImage"), System.Drawing.Image)
        Me.delBTN.ButtonText = "삭제"
        Me.delBTN.Cursor = System.Windows.Forms.Cursors.Hand
        Me.delBTN.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.delBTN.ForeColor = System.Drawing.Color.SeaGreen
        Me.delBTN.IdleBorderThickness = 1
        Me.delBTN.IdleCornerRadius = 20
        Me.delBTN.IdleFillColor = System.Drawing.Color.White
        Me.delBTN.IdleForecolor = System.Drawing.Color.SeaGreen
        Me.delBTN.IdleLineColor = System.Drawing.Color.SeaGreen
        Me.delBTN.Location = New System.Drawing.Point(730, 497)
        Me.delBTN.Margin = New System.Windows.Forms.Padding(5)
        Me.delBTN.Name = "delBTN"
        Me.delBTN.Size = New System.Drawing.Size(123, 41)
        Me.delBTN.TabIndex = 9
        Me.delBTN.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.addBTN.Location = New System.Drawing.Point(582, 563)
        Me.addBTN.Margin = New System.Windows.Forms.Padding(5)
        Me.addBTN.Name = "addBTN"
        Me.addBTN.Size = New System.Drawing.Size(271, 41)
        Me.addBTN.TabIndex = 10
        Me.addBTN.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CoilListForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(941, 737)
        Me.Controls.Add(Me.addBTN)
        Me.Controls.Add(Me.delBTN)
        Me.Controls.Add(Me.editBTN)
        Me.Controls.Add(Me.oneSideLenTB)
        Me.Controls.Add(Me.BunifuCustomLabel2)
        Me.Controls.Add(Me.BunifuCustomLabel1)
        Me.Controls.Add(Me.allChkBox)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.topPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "CoilListForm"
        Me.Text = "CoilListForm"
        Me.topPanel.ResumeLayout(False)
        CType(Me.BunifuImageButton1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents topPanel As Panel
    Friend WithEvents BunifuImageButton1 As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents BunifuDragControl1 As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents addBTN As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents delBTN As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents editBTN As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents oneSideLenTB As TextBox
    Friend WithEvents BunifuCustomLabel2 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents allChkBox As Bunifu.Framework.UI.BunifuCheckbox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents coilShpListview As ListView
End Class
