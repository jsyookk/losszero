<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StockForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(StockForm))
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.BunifuCustomLabel3 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel2 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.addBTN = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.editBTN = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.tonTB = New System.Windows.Forms.TextBox()
        Me.lenTB = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.BunifuImageButton1 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.topPanel = New System.Windows.Forms.Panel()
        Me.BunifuDragControl1 = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.delBTN = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.Panel1.SuspendLayout()
        CType(Me.BunifuImageButton1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.topPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 5
        Me.BunifuElipse1.TargetControl = Me
        '
        'BunifuCustomLabel3
        '
        Me.BunifuCustomLabel3.AutoSize = True
        Me.BunifuCustomLabel3.Location = New System.Drawing.Point(536, 70)
        Me.BunifuCustomLabel3.Name = "BunifuCustomLabel3"
        Me.BunifuCustomLabel3.Size = New System.Drawing.Size(72, 15)
        Me.BunifuCustomLabel3.TabIndex = 7
        Me.BunifuCustomLabel3.Text = "철근 정보"
        '
        'BunifuCustomLabel2
        '
        Me.BunifuCustomLabel2.AutoSize = True
        Me.BunifuCustomLabel2.Location = New System.Drawing.Point(536, 161)
        Me.BunifuCustomLabel2.Name = "BunifuCustomLabel2"
        Me.BunifuCustomLabel2.Size = New System.Drawing.Size(53, 15)
        Me.BunifuCustomLabel2.TabIndex = 6
        Me.BunifuCustomLabel2.Text = "톤수(t)"
        '
        'BunifuCustomLabel1
        '
        Me.BunifuCustomLabel1.AutoSize = True
        Me.BunifuCustomLabel1.Location = New System.Drawing.Point(536, 115)
        Me.BunifuCustomLabel1.Name = "BunifuCustomLabel1"
        Me.BunifuCustomLabel1.Size = New System.Drawing.Size(61, 15)
        Me.BunifuCustomLabel1.TabIndex = 5
        Me.BunifuCustomLabel1.Text = "길이(M)"
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
        Me.addBTN.Location = New System.Drawing.Point(514, 422)
        Me.addBTN.Margin = New System.Windows.Forms.Padding(5)
        Me.addBTN.Name = "addBTN"
        Me.addBTN.Size = New System.Drawing.Size(382, 69)
        Me.addBTN.TabIndex = 4
        Me.addBTN.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.editBTN.Location = New System.Drawing.Point(701, 264)
        Me.editBTN.Margin = New System.Windows.Forms.Padding(5)
        Me.editBTN.Name = "editBTN"
        Me.editBTN.Size = New System.Drawing.Size(181, 64)
        Me.editBTN.TabIndex = 2
        Me.editBTN.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tonTB
        '
        Me.tonTB.Location = New System.Drawing.Point(678, 161)
        Me.tonTB.Name = "tonTB"
        Me.tonTB.Size = New System.Drawing.Size(204, 25)
        Me.tonTB.TabIndex = 1
        '
        'lenTB
        '
        Me.lenTB.Location = New System.Drawing.Point(678, 115)
        Me.lenTB.Name = "lenTB"
        Me.lenTB.Size = New System.Drawing.Size(204, 25)
        Me.lenTB.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.delBTN)
        Me.Panel1.Controls.Add(Me.BunifuCustomLabel3)
        Me.Panel1.Controls.Add(Me.BunifuCustomLabel1)
        Me.Panel1.Controls.Add(Me.BunifuCustomLabel2)
        Me.Panel1.Controls.Add(Me.topPanel)
        Me.Panel1.Controls.Add(Me.ListView1)
        Me.Panel1.Controls.Add(Me.addBTN)
        Me.Panel1.Controls.Add(Me.lenTB)
        Me.Panel1.Controls.Add(Me.tonTB)
        Me.Panel1.Controls.Add(Me.editBTN)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(943, 635)
        Me.Panel1.TabIndex = 3
        '
        'ListView1
        '
        Me.ListView1.BackColor = System.Drawing.Color.White
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2})
        Me.ListView1.ForeColor = System.Drawing.Color.Black
        Me.ListView1.Location = New System.Drawing.Point(12, 42)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(459, 570)
        Me.ListView1.TabIndex = 0
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "길이(M)"
        Me.ColumnHeader1.Width = 233
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "톤 수(t)"
        Me.ColumnHeader2.Width = 214
        '
        'BunifuImageButton1
        '
        Me.BunifuImageButton1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BunifuImageButton1.Image = CType(resources.GetObject("BunifuImageButton1.Image"), System.Drawing.Image)
        Me.BunifuImageButton1.ImageActive = Nothing
        Me.BunifuImageButton1.Location = New System.Drawing.Point(904, -1)
        Me.BunifuImageButton1.Name = "BunifuImageButton1"
        Me.BunifuImageButton1.Size = New System.Drawing.Size(36, 34)
        Me.BunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.BunifuImageButton1.TabIndex = 0
        Me.BunifuImageButton1.TabStop = False
        Me.BunifuImageButton1.Zoom = 10
        '
        'topPanel
        '
        Me.topPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.topPanel.Controls.Add(Me.BunifuImageButton1)
        Me.topPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.topPanel.Location = New System.Drawing.Point(0, 0)
        Me.topPanel.Name = "topPanel"
        Me.topPanel.Size = New System.Drawing.Size(943, 36)
        Me.topPanel.TabIndex = 8
        '
        'BunifuDragControl1
        '
        Me.BunifuDragControl1.Fixed = True
        Me.BunifuDragControl1.Horizontal = True
        Me.BunifuDragControl1.TargetControl = Me.topPanel
        Me.BunifuDragControl1.Vertical = True
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
        Me.delBTN.Location = New System.Drawing.Point(510, 264)
        Me.delBTN.Margin = New System.Windows.Forms.Padding(5)
        Me.delBTN.Name = "delBTN"
        Me.delBTN.Size = New System.Drawing.Size(181, 64)
        Me.delBTN.TabIndex = 9
        Me.delBTN.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'StockForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(943, 635)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "StockForm"
        Me.Text = "StockForm"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.BunifuImageButton1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.topPanel.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents Panel1 As Panel
    Friend WithEvents ListView1 As ListView
    Friend WithEvents addBTN As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents editBTN As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents tonTB As TextBox
    Friend WithEvents lenTB As TextBox
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents BunifuCustomLabel3 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel2 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuImageButton1 As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents topPanel As Panel
    Friend WithEvents BunifuDragControl1 As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents delBTN As Bunifu.Framework.UI.BunifuThinButton2
End Class
