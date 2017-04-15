<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ResultStock
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ResultStock))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.BunifuImageButton2 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.noTB = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel4 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.tabPanel = New System.Windows.Forms.Panel()
        Me.BunifuSeparator1 = New Bunifu.Framework.UI.BunifuSeparator()
        Me.mTab = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.gTab = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuImageButton1 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.BunifuCustomLabel1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.waringTB = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.goodTB = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel3 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel2 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.badTB = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.detailPanel = New System.Windows.Forms.Panel()
        Me.listPanel = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.BunifuImageButton2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabPanel.SuspendLayout()
        CType(Me.BunifuImageButton1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.listPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.detailPanel)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(325, 751)
        Me.Panel1.TabIndex = 2
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Black
        Me.Panel2.Controls.Add(Me.BunifuImageButton2)
        Me.Panel2.Controls.Add(Me.noTB)
        Me.Panel2.Controls.Add(Me.BunifuCustomLabel4)
        Me.Panel2.Controls.Add(Me.tabPanel)
        Me.Panel2.Controls.Add(Me.BunifuImageButton1)
        Me.Panel2.Controls.Add(Me.BunifuCustomLabel1)
        Me.Panel2.Controls.Add(Me.waringTB)
        Me.Panel2.Controls.Add(Me.goodTB)
        Me.Panel2.Controls.Add(Me.BunifuCustomLabel3)
        Me.Panel2.Controls.Add(Me.BunifuCustomLabel2)
        Me.Panel2.Controls.Add(Me.badTB)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(325, 229)
        Me.Panel2.TabIndex = 8
        '
        'BunifuImageButton2
        '
        Me.BunifuImageButton2.BackColor = System.Drawing.Color.Black
        Me.BunifuImageButton2.Image = CType(resources.GetObject("BunifuImageButton2.Image"), System.Drawing.Image)
        Me.BunifuImageButton2.ImageActive = Nothing
        Me.BunifuImageButton2.Location = New System.Drawing.Point(281, 33)
        Me.BunifuImageButton2.Name = "BunifuImageButton2"
        Me.BunifuImageButton2.Size = New System.Drawing.Size(38, 33)
        Me.BunifuImageButton2.TabIndex = 10
        Me.BunifuImageButton2.TabStop = False
        Me.BunifuImageButton2.Zoom = 10
        '
        'noTB
        '
        Me.noTB.AutoSize = True
        Me.noTB.Cursor = System.Windows.Forms.Cursors.Hand
        Me.noTB.Font = New System.Drawing.Font("돋움", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.noTB.ForeColor = System.Drawing.Color.White
        Me.noTB.Location = New System.Drawing.Point(224, 135)
        Me.noTB.Name = "noTB"
        Me.noTB.Size = New System.Drawing.Size(20, 20)
        Me.noTB.TabIndex = 9
        Me.noTB.Text = "0"
        '
        'BunifuCustomLabel4
        '
        Me.BunifuCustomLabel4.AutoSize = True
        Me.BunifuCustomLabel4.Font = New System.Drawing.Font("돋움", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.BunifuCustomLabel4.ForeColor = System.Drawing.Color.Gray
        Me.BunifuCustomLabel4.Location = New System.Drawing.Point(108, 135)
        Me.BunifuCustomLabel4.Name = "BunifuCustomLabel4"
        Me.BunifuCustomLabel4.Size = New System.Drawing.Size(89, 20)
        Me.BunifuCustomLabel4.TabIndex = 8
        Me.BunifuCustomLabel4.Text = "재고없음"
        '
        'tabPanel
        '
        Me.tabPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.tabPanel.Controls.Add(Me.BunifuSeparator1)
        Me.tabPanel.Controls.Add(Me.mTab)
        Me.tabPanel.Controls.Add(Me.gTab)
        Me.tabPanel.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.tabPanel.Location = New System.Drawing.Point(0, 176)
        Me.tabPanel.Name = "tabPanel"
        Me.tabPanel.Size = New System.Drawing.Size(325, 53)
        Me.tabPanel.TabIndex = 7
        '
        'BunifuSeparator1
        '
        Me.BunifuSeparator1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BunifuSeparator1.LineThickness = 3
        Me.BunifuSeparator1.Location = New System.Drawing.Point(50, 33)
        Me.BunifuSeparator1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.BunifuSeparator1.Name = "BunifuSeparator1"
        Me.BunifuSeparator1.Size = New System.Drawing.Size(48, 20)
        Me.BunifuSeparator1.TabIndex = 2
        Me.BunifuSeparator1.Transparency = 255
        Me.BunifuSeparator1.Vertical = False
        '
        'mTab
        '
        Me.mTab.AutoSize = True
        Me.mTab.BackColor = System.Drawing.Color.Transparent
        Me.mTab.Font = New System.Drawing.Font("굴림", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.mTab.ForeColor = System.Drawing.Color.White
        Me.mTab.Location = New System.Drawing.Point(177, 13)
        Me.mTab.Name = "mTab"
        Me.mTab.Size = New System.Drawing.Size(98, 17)
        Me.mTab.TabIndex = 1
        Me.mTab.Text = "자세히 보기"
        '
        'gTab
        '
        Me.gTab.AutoSize = True
        Me.gTab.BackColor = System.Drawing.Color.Transparent
        Me.gTab.Font = New System.Drawing.Font("굴림", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.gTab.ForeColor = System.Drawing.Color.White
        Me.gTab.Location = New System.Drawing.Point(47, 13)
        Me.gTab.Name = "gTab"
        Me.gTab.Size = New System.Drawing.Size(59, 17)
        Me.gTab.TabIndex = 0
        Me.gTab.Text = "그래프"
        '
        'BunifuImageButton1
        '
        Me.BunifuImageButton1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuImageButton1.Image = CType(resources.GetObject("BunifuImageButton1.Image"), System.Drawing.Image)
        Me.BunifuImageButton1.ImageActive = Nothing
        Me.BunifuImageButton1.Location = New System.Drawing.Point(17, 33)
        Me.BunifuImageButton1.Name = "BunifuImageButton1"
        Me.BunifuImageButton1.Size = New System.Drawing.Size(38, 42)
        Me.BunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BunifuImageButton1.TabIndex = 6
        Me.BunifuImageButton1.TabStop = False
        Me.BunifuImageButton1.Zoom = 10
        '
        'BunifuCustomLabel1
        '
        Me.BunifuCustomLabel1.AutoSize = True
        Me.BunifuCustomLabel1.Font = New System.Drawing.Font("돋움", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.BunifuCustomLabel1.ForeColor = System.Drawing.Color.Red
        Me.BunifuCustomLabel1.Location = New System.Drawing.Point(108, 33)
        Me.BunifuCustomLabel1.Name = "BunifuCustomLabel1"
        Me.BunifuCustomLabel1.Size = New System.Drawing.Size(49, 20)
        Me.BunifuCustomLabel1.TabIndex = 0
        Me.BunifuCustomLabel1.Text = "긴급"
        '
        'waringTB
        '
        Me.waringTB.AutoSize = True
        Me.waringTB.Cursor = System.Windows.Forms.Cursors.Hand
        Me.waringTB.Font = New System.Drawing.Font("돋움", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.waringTB.ForeColor = System.Drawing.Color.White
        Me.waringTB.Location = New System.Drawing.Point(224, 67)
        Me.waringTB.Name = "waringTB"
        Me.waringTB.Size = New System.Drawing.Size(20, 20)
        Me.waringTB.TabIndex = 3
        Me.waringTB.Text = "0"
        '
        'goodTB
        '
        Me.goodTB.AutoSize = True
        Me.goodTB.Cursor = System.Windows.Forms.Cursors.Hand
        Me.goodTB.Font = New System.Drawing.Font("돋움", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.goodTB.ForeColor = System.Drawing.Color.White
        Me.goodTB.Location = New System.Drawing.Point(224, 101)
        Me.goodTB.Name = "goodTB"
        Me.goodTB.Size = New System.Drawing.Size(20, 20)
        Me.goodTB.TabIndex = 5
        Me.goodTB.Text = "0"
        '
        'BunifuCustomLabel3
        '
        Me.BunifuCustomLabel3.AutoSize = True
        Me.BunifuCustomLabel3.Font = New System.Drawing.Font("돋움", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.BunifuCustomLabel3.ForeColor = System.Drawing.Color.ForestGreen
        Me.BunifuCustomLabel3.Location = New System.Drawing.Point(108, 102)
        Me.BunifuCustomLabel3.Name = "BunifuCustomLabel3"
        Me.BunifuCustomLabel3.Size = New System.Drawing.Size(49, 20)
        Me.BunifuCustomLabel3.TabIndex = 2
        Me.BunifuCustomLabel3.Text = "적정"
        '
        'BunifuCustomLabel2
        '
        Me.BunifuCustomLabel2.AutoSize = True
        Me.BunifuCustomLabel2.Font = New System.Drawing.Font("돋움", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.BunifuCustomLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BunifuCustomLabel2.Location = New System.Drawing.Point(108, 66)
        Me.BunifuCustomLabel2.Name = "BunifuCustomLabel2"
        Me.BunifuCustomLabel2.Size = New System.Drawing.Size(49, 20)
        Me.BunifuCustomLabel2.TabIndex = 1
        Me.BunifuCustomLabel2.Text = "주의"
        '
        'badTB
        '
        Me.badTB.AutoSize = True
        Me.badTB.Cursor = System.Windows.Forms.Cursors.Hand
        Me.badTB.Font = New System.Drawing.Font("돋움", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.badTB.ForeColor = System.Drawing.Color.White
        Me.badTB.Location = New System.Drawing.Point(224, 33)
        Me.badTB.Name = "badTB"
        Me.badTB.Size = New System.Drawing.Size(20, 20)
        Me.badTB.TabIndex = 4
        Me.badTB.Text = "0"
        '
        'detailPanel
        '
        Me.detailPanel.AutoScroll = True
        Me.detailPanel.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.detailPanel.Location = New System.Drawing.Point(0, 229)
        Me.detailPanel.Name = "detailPanel"
        Me.detailPanel.Size = New System.Drawing.Size(325, 522)
        Me.detailPanel.TabIndex = 7
        '
        'listPanel
        '
        Me.listPanel.Controls.Add(Me.Panel3)
        Me.listPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.listPanel.Location = New System.Drawing.Point(325, 0)
        Me.listPanel.Name = "listPanel"
        Me.listPanel.Size = New System.Drawing.Size(1213, 751)
        Me.listPanel.TabIndex = 3
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(15, 751)
        Me.Panel3.TabIndex = 0
        '
        'ResultStock
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.listPanel)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "ResultStock"
        Me.Size = New System.Drawing.Size(1538, 751)
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.BunifuImageButton2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabPanel.ResumeLayout(False)
        Me.tabPanel.PerformLayout()
        CType(Me.BunifuImageButton1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.listPanel.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents goodTB As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents badTB As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents waringTB As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel3 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel2 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuImageButton1 As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents detailPanel As Panel
    Friend WithEvents listPanel As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents tabPanel As Panel
    Friend WithEvents mTab As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents gTab As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents noTB As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel4 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuSeparator1 As Bunifu.Framework.UI.BunifuSeparator
    Friend WithEvents BunifuImageButton2 As Bunifu.Framework.UI.BunifuImageButton
End Class
