<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogIn
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLogIn))
        LabelUser = New Label()
        txtUser = New TextBox()
        txtPass = New TextBox()
        LabelPass = New Label()
        btnReturn = New Button()
        btnLogIn = New Button()
        btnPassDisplay = New Button()
        Panel1 = New Panel()
        LabelTitle = New Label()
        PictureBox1 = New PictureBox()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' LabelUser
        ' 
        LabelUser.AutoSize = True
        LabelUser.Location = New Point(87, 135)
        LabelUser.Name = "LabelUser"
        LabelUser.Size = New Size(63, 15)
        LabelUser.TabIndex = 0
        LabelUser.Text = "&Username:"
        ' 
        ' txtUser
        ' 
        txtUser.Location = New Point(198, 135)
        txtUser.Name = "txtUser"
        txtUser.Size = New Size(100, 23)
        txtUser.TabIndex = 1
        ' 
        ' txtPass
        ' 
        txtPass.Location = New Point(198, 164)
        txtPass.Name = "txtPass"
        txtPass.PasswordChar = "*"c
        txtPass.Size = New Size(100, 23)
        txtPass.TabIndex = 3
        ' 
        ' LabelPass
        ' 
        LabelPass.AutoSize = True
        LabelPass.Location = New Point(87, 164)
        LabelPass.Name = "LabelPass"
        LabelPass.Size = New Size(60, 15)
        LabelPass.TabIndex = 2
        LabelPass.Text = "&Password:"
        ' 
        ' btnReturn
        ' 
        btnReturn.Location = New Point(147, 238)
        btnReturn.Name = "btnReturn"
        btnReturn.Size = New Size(90, 25)
        btnReturn.TabIndex = 6
        btnReturn.Text = "&Main Menu"
        btnReturn.UseVisualStyleBackColor = True
        ' 
        ' btnLogIn
        ' 
        btnLogIn.Location = New Point(147, 207)
        btnLogIn.Name = "btnLogIn"
        btnLogIn.Size = New Size(90, 25)
        btnLogIn.TabIndex = 5
        btnLogIn.Text = "&Log In"
        btnLogIn.UseVisualStyleBackColor = True
        ' 
        ' btnPassDisplay
        ' 
        btnPassDisplay.Location = New Point(160, 164)
        btnPassDisplay.Name = "btnPassDisplay"
        btnPassDisplay.Size = New Size(32, 23)
        btnPassDisplay.TabIndex = 4
        btnPassDisplay.UseVisualStyleBackColor = True
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(LabelTitle)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Location = New Point(8, 12)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(364, 105)
        Panel1.TabIndex = 40
        ' 
        ' LabelTitle
        ' 
        LabelTitle.AutoSize = True
        LabelTitle.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LabelTitle.Location = New Point(120, 13)
        LabelTitle.Name = "LabelTitle"
        LabelTitle.Size = New Size(244, 32)
        LabelTitle.TabIndex = 0
        LabelTitle.Text = "Eckard Bank && Trust"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(3, 13)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(88, 80)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 2
        PictureBox1.TabStop = False
        ' 
        ' frmLogIn
        ' 
        AcceptButton = btnLogIn
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        CancelButton = btnReturn
        ClientSize = New Size(384, 361)
        Controls.Add(Panel1)
        Controls.Add(btnPassDisplay)
        Controls.Add(btnReturn)
        Controls.Add(btnLogIn)
        Controls.Add(txtPass)
        Controls.Add(LabelPass)
        Controls.Add(txtUser)
        Controls.Add(LabelUser)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        Name = "frmLogIn"
        StartPosition = FormStartPosition.CenterScreen
        Text = "EBaT Account Log In"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents LabelUser As Label
    Friend WithEvents txtUser As TextBox
    Friend WithEvents txtPass As TextBox
    Friend WithEvents LabelPass As Label
    Friend WithEvents btnReturn As Button
    Friend WithEvents btnLogIn As Button
    Friend WithEvents btnPassDisplay As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents LabelTitle As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
