<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HomeControl
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
        Me.LoadBTN = New System.Windows.Forms.Button()
        Me.TreeView1 = New System.Windows.Forms.TreeView()
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.optimalBTN = New System.Windows.Forms.Button()
        Me.gp400 = New System.Windows.Forms.Panel()
        Me.gp500 = New System.Windows.Forms.Panel()
        Me.gp600 = New System.Windows.Forms.Panel()
        Me.SuspendLayout()
        '
        'LoadBTN
        '
        Me.LoadBTN.Location = New System.Drawing.Point(1015, 22)
        Me.LoadBTN.Name = "LoadBTN"
        Me.LoadBTN.Size = New System.Drawing.Size(221, 96)
        Me.LoadBTN.TabIndex = 0
        Me.LoadBTN.Text = "LOAD"
        Me.LoadBTN.UseVisualStyleBackColor = True
        '
        'TreeView1
        '
        Me.TreeView1.Location = New System.Drawing.Point(15, 22)
        Me.TreeView1.Name = "TreeView1"
        Me.TreeView1.Size = New System.Drawing.Size(449, 715)
        Me.TreeView1.TabIndex = 1
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 5
        Me.BunifuElipse1.TargetControl = Me
        '
        'optimalBTN
        '
        Me.optimalBTN.Location = New System.Drawing.Point(1015, 153)
        Me.optimalBTN.Name = "optimalBTN"
        Me.optimalBTN.Size = New System.Drawing.Size(221, 96)
        Me.optimalBTN.TabIndex = 2
        Me.optimalBTN.Text = "최적화"
        Me.optimalBTN.UseVisualStyleBackColor = True
        '
        'gp400
        '
        Me.gp400.BackColor = System.Drawing.Color.Transparent
        Me.gp400.Location = New System.Drawing.Point(505, 22)
        Me.gp400.Name = "gp400"
        Me.gp400.Size = New System.Drawing.Size(479, 227)
        Me.gp400.TabIndex = 3
        '
        'gp500
        '
        Me.gp500.BackColor = System.Drawing.Color.Transparent
        Me.gp500.Location = New System.Drawing.Point(505, 265)
        Me.gp500.Name = "gp500"
        Me.gp500.Size = New System.Drawing.Size(479, 227)
        Me.gp500.TabIndex = 4
        '
        'gp600
        '
        Me.gp600.BackColor = System.Drawing.Color.Transparent
        Me.gp600.Location = New System.Drawing.Point(505, 510)
        Me.gp600.Name = "gp600"
        Me.gp600.Size = New System.Drawing.Size(479, 227)
        Me.gp600.TabIndex = 4
        '
        'HomeControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.gp600)
        Me.Controls.Add(Me.gp500)
        Me.Controls.Add(Me.gp400)
        Me.Controls.Add(Me.optimalBTN)
        Me.Controls.Add(Me.TreeView1)
        Me.Controls.Add(Me.LoadBTN)
        Me.Name = "HomeControl"
        Me.Size = New System.Drawing.Size(1307, 751)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LoadBTN As Button
    Friend WithEvents TreeView1 As TreeView
    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents optimalBTN As Button
    Friend WithEvents gp600 As Panel
    Friend WithEvents gp500 As Panel
    Friend WithEvents gp400 As Panel
End Class
