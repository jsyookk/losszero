<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LoginControl
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LoginControl))
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.pwTB = New System.Windows.Forms.TextBox()
        Me.idTB = New System.Windows.Forms.TextBox()
        Me.LogInBTN = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BunifuCustomLabel1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuElipse2 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.BunifuElipse3 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 5
        Me.BunifuElipse1.TargetControl = Me
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.pwTB)
        Me.Panel1.Controls.Add(Me.idTB)
        Me.Panel1.Controls.Add(Me.LogInBTN)
        Me.Panel1.Controls.Add(Me.BunifuCustomLabel1)
        Me.Panel1.Location = New System.Drawing.Point(325, 47)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(569, 581)
        Me.Panel1.TabIndex = 5
        '
        'pwTB
        '
        Me.pwTB.BackColor = System.Drawing.Color.LightGray
        Me.pwTB.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.pwTB.Font = New System.Drawing.Font("굴림", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.pwTB.ForeColor = System.Drawing.Color.DimGray
        Me.pwTB.Location = New System.Drawing.Point(118, 239)
        Me.pwTB.Name = "pwTB"
        Me.pwTB.Size = New System.Drawing.Size(351, 23)
        Me.pwTB.TabIndex = 10
        Me.pwTB.Text = "password"
        Me.pwTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'idTB
        '
        Me.idTB.BackColor = System.Drawing.Color.LightGray
        Me.idTB.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.idTB.Font = New System.Drawing.Font("굴림", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.idTB.ForeColor = System.Drawing.Color.DimGray
        Me.idTB.Location = New System.Drawing.Point(118, 172)
        Me.idTB.Name = "idTB"
        Me.idTB.Size = New System.Drawing.Size(351, 23)
        Me.idTB.TabIndex = 9
        Me.idTB.Text = "username"
        Me.idTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LogInBTN
        '
        Me.LogInBTN.Activecolor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.LogInBTN.BackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.LogInBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.LogInBTN.BorderRadius = 0
        Me.LogInBTN.ButtonText = "Login"
        Me.LogInBTN.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LogInBTN.DisabledColor = System.Drawing.Color.Gray
        Me.LogInBTN.Iconcolor = System.Drawing.Color.Transparent
        Me.LogInBTN.Iconimage = CType(resources.GetObject("LogInBTN.Iconimage"), System.Drawing.Image)
        Me.LogInBTN.Iconimage_right = Nothing
        Me.LogInBTN.Iconimage_right_Selected = Nothing
        Me.LogInBTN.Iconimage_Selected = Nothing
        Me.LogInBTN.IconMarginLeft = 0
        Me.LogInBTN.IconMarginRight = 0
        Me.LogInBTN.IconRightVisible = True
        Me.LogInBTN.IconRightZoom = 0R
        Me.LogInBTN.IconVisible = False
        Me.LogInBTN.IconZoom = 90.0R
        Me.LogInBTN.IsTab = False
        Me.LogInBTN.Location = New System.Drawing.Point(118, 376)
        Me.LogInBTN.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.LogInBTN.Name = "LogInBTN"
        Me.LogInBTN.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.LogInBTN.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.LogInBTN.OnHoverTextColor = System.Drawing.Color.White
        Me.LogInBTN.selected = False
        Me.LogInBTN.Size = New System.Drawing.Size(351, 65)
        Me.LogInBTN.TabIndex = 8
        Me.LogInBTN.Text = "Login"
        Me.LogInBTN.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.LogInBTN.Textcolor = System.Drawing.Color.White
        Me.LogInBTN.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'BunifuCustomLabel1
        '
        Me.BunifuCustomLabel1.AutoSize = True
        Me.BunifuCustomLabel1.Font = New System.Drawing.Font("굴림", 25.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.BunifuCustomLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.BunifuCustomLabel1.Location = New System.Drawing.Point(230, 59)
        Me.BunifuCustomLabel1.Name = "BunifuCustomLabel1"
        Me.BunifuCustomLabel1.Size = New System.Drawing.Size(134, 43)
        Me.BunifuCustomLabel1.TabIndex = 5
        Me.BunifuCustomLabel1.Text = "Login"
        '
        'BunifuElipse2
        '
        Me.BunifuElipse2.ElipseRadius = 5
        Me.BunifuElipse2.TargetControl = Me.Panel1
        '
        'BunifuElipse3
        '
        Me.BunifuElipse3.ElipseRadius = 5
        Me.BunifuElipse3.TargetControl = Me.LogInBTN
        '
        'LoginControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.Controls.Add(Me.Panel1)
        Me.Name = "LoginControl"
        Me.Size = New System.Drawing.Size(1538, 751)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BunifuCustomLabel1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuElipse2 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents LogInBTN As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BunifuElipse3 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents pwTB As TextBox
    Friend WithEvents idTB As TextBox
End Class
