<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNewAcct
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
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmNewAcct))
        LabelNewIntro = New Label()
        PictureBox1 = New PictureBox()
        LabelTitle = New Label()
        lblFirst = New Label()
        txtFirst = New TextBox()
        txtLast = New TextBox()
        LabelLast = New Label()
        txtAddress1 = New TextBox()
        LabelAddress = New Label()
        txtCity = New TextBox()
        LabelCity = New Label()
        LabelZip = New Label()
        LabelState = New Label()
        LabelPhone = New Label()
        LabelOpenBal = New Label()
        txtUser = New TextBox()
        LabelUser = New Label()
        LabelPass = New Label()
        txtPhone = New MaskedTextBox()
        txtZip = New TextBox()
        txtOpenBal = New TextBox()
        txtPass = New TextBox()
        txtRePass = New TextBox()
        LabelRePass = New Label()
        btnSubmit = New Button()
        btnReturn = New Button()
        lblPassMatch = New Label()
        lblUserExist = New Label()
        cmbStates = New ComboBox()
        tipPassReq = New ToolTip(components)
        tipPasswordRules = New ToolTip(components)
        lblUpper = New Label()
        lblNum = New Label()
        lblLower = New Label()
        lbl8Char = New Label()
        txtAddress2 = New TextBox()
        LabelSuite = New Label()
        btnPassDisplay = New Button()
        Panel1 = New Panel()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' LabelNewIntro
        ' 
        LabelNewIntro.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LabelNewIntro.Location = New Point(12, 120)
        LabelNewIntro.Name = "LabelNewIntro"
        LabelNewIntro.Size = New Size(360, 57)
        LabelNewIntro.TabIndex = 25
        LabelNewIntro.Text = "Thank you for choosing to bank with Eckard Bank && Trust." & vbCrLf & vbCrLf & "Please provide the following informatiom to open your account:"
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
        ' lblFirst
        ' 
        lblFirst.AutoSize = True
        lblFirst.Location = New Point(20, 177)
        lblFirst.Name = "lblFirst"
        lblFirst.Size = New Size(67, 15)
        lblFirst.TabIndex = 0
        lblFirst.Text = "&First Name:"
        ' 
        ' txtFirst
        ' 
        txtFirst.Location = New Point(167, 174)
        txtFirst.MaxLength = 50
        txtFirst.Name = "txtFirst"
        txtFirst.Size = New Size(100, 23)
        txtFirst.TabIndex = 1
        ' 
        ' txtLast
        ' 
        txtLast.Location = New Point(167, 203)
        txtLast.MaxLength = 50
        txtLast.Name = "txtLast"
        txtLast.Size = New Size(100, 23)
        txtLast.TabIndex = 3
        ' 
        ' LabelLast
        ' 
        LabelLast.AutoSize = True
        LabelLast.Location = New Point(20, 206)
        LabelLast.Name = "LabelLast"
        LabelLast.Size = New Size(66, 15)
        LabelLast.TabIndex = 2
        LabelLast.Text = "&Last Name:"
        ' 
        ' txtAddress1
        ' 
        txtAddress1.Location = New Point(167, 232)
        txtAddress1.MaxLength = 50
        txtAddress1.Name = "txtAddress1"
        txtAddress1.Size = New Size(186, 23)
        txtAddress1.TabIndex = 5
        ' 
        ' LabelAddress
        ' 
        LabelAddress.AutoSize = True
        LabelAddress.Location = New Point(20, 235)
        LabelAddress.Name = "LabelAddress"
        LabelAddress.Size = New Size(52, 15)
        LabelAddress.TabIndex = 4
        LabelAddress.Text = "&Address:"
        ' 
        ' txtCity
        ' 
        txtCity.Location = New Point(57, 290)
        txtCity.MaxLength = 50
        txtCity.Name = "txtCity"
        txtCity.Size = New Size(83, 23)
        txtCity.TabIndex = 9
        ' 
        ' LabelCity
        ' 
        LabelCity.AutoSize = True
        LabelCity.Location = New Point(20, 293)
        LabelCity.Name = "LabelCity"
        LabelCity.Size = New Size(31, 15)
        LabelCity.TabIndex = 8
        LabelCity.Text = "&City:"
        ' 
        ' LabelZip
        ' 
        LabelZip.AutoSize = True
        LabelZip.Location = New Point(247, 293)
        LabelZip.Name = "LabelZip"
        LabelZip.Size = New Size(27, 15)
        LabelZip.TabIndex = 12
        LabelZip.Text = "&ZIP:"
        ' 
        ' LabelState
        ' 
        LabelState.AutoSize = True
        LabelState.Location = New Point(146, 293)
        LabelState.Name = "LabelState"
        LabelState.Size = New Size(36, 15)
        LabelState.TabIndex = 10
        LabelState.Text = "S&tate:"
        ' 
        ' LabelPhone
        ' 
        LabelPhone.AutoSize = True
        LabelPhone.Location = New Point(20, 322)
        LabelPhone.Name = "LabelPhone"
        LabelPhone.Size = New Size(112, 15)
        LabelPhone.TabIndex = 14
        LabelPhone.Text = "T&elephone Number:"
        ' 
        ' LabelOpenBal
        ' 
        LabelOpenBal.AutoSize = True
        LabelOpenBal.Location = New Point(20, 351)
        LabelOpenBal.Name = "LabelOpenBal"
        LabelOpenBal.Size = New Size(100, 15)
        LabelOpenBal.TabIndex = 16
        LabelOpenBal.Text = "&Opening Balance:"
        ' 
        ' txtUser
        ' 
        txtUser.Location = New Point(167, 377)
        txtUser.MaxLength = 20
        txtUser.Name = "txtUser"
        txtUser.Size = New Size(100, 23)
        txtUser.TabIndex = 19
        ' 
        ' LabelUser
        ' 
        LabelUser.AutoSize = True
        LabelUser.Location = New Point(20, 380)
        LabelUser.Name = "LabelUser"
        LabelUser.Size = New Size(63, 15)
        LabelUser.TabIndex = 18
        LabelUser.Text = "&Username:"
        ' 
        ' LabelPass
        ' 
        LabelPass.AutoSize = True
        LabelPass.Location = New Point(20, 409)
        LabelPass.Name = "LabelPass"
        LabelPass.Size = New Size(60, 15)
        LabelPass.TabIndex = 20
        LabelPass.Text = "&Password:"
        ' 
        ' txtPhone
        ' 
        txtPhone.Location = New Point(167, 319)
        txtPhone.Mask = "(999) 000-0000"
        txtPhone.Name = "txtPhone"
        txtPhone.Size = New Size(100, 23)
        txtPhone.TabIndex = 15
        ' 
        ' txtZip
        ' 
        txtZip.Location = New Point(280, 290)
        txtZip.MaxLength = 5
        txtZip.Name = "txtZip"
        txtZip.Size = New Size(69, 23)
        txtZip.TabIndex = 13
        ' 
        ' txtOpenBal
        ' 
        txtOpenBal.Location = New Point(167, 348)
        txtOpenBal.MaxLength = 10
        txtOpenBal.Name = "txtOpenBal"
        txtOpenBal.Size = New Size(100, 23)
        txtOpenBal.TabIndex = 17
        ' 
        ' txtPass
        ' 
        txtPass.Location = New Point(167, 406)
        txtPass.MaxLength = 20
        txtPass.Name = "txtPass"
        txtPass.PasswordChar = "*"c
        txtPass.Size = New Size(100, 23)
        txtPass.TabIndex = 21
        ' 
        ' txtRePass
        ' 
        txtRePass.Location = New Point(167, 435)
        txtRePass.MaxLength = 20
        txtRePass.Name = "txtRePass"
        txtRePass.PasswordChar = "*"c
        txtRePass.Size = New Size(100, 23)
        txtRePass.TabIndex = 23
        ' 
        ' LabelRePass
        ' 
        LabelRePass.AutoSize = True
        LabelRePass.Location = New Point(20, 438)
        LabelRePass.Name = "LabelRePass"
        LabelRePass.Size = New Size(108, 15)
        LabelRePass.TabIndex = 22
        LabelRePass.Text = "Re-Enter Pass&word:"
        ' 
        ' btnSubmit
        ' 
        btnSubmit.Location = New Point(81, 499)
        btnSubmit.Name = "btnSubmit"
        btnSubmit.Size = New Size(90, 25)
        btnSubmit.TabIndex = 25
        btnSubmit.Text = "&Submit"
        btnSubmit.UseVisualStyleBackColor = True
        ' 
        ' btnReturn
        ' 
        btnReturn.Location = New Point(213, 499)
        btnReturn.Name = "btnReturn"
        btnReturn.Size = New Size(90, 25)
        btnReturn.TabIndex = 26
        btnReturn.Text = "&Main Menu"
        btnReturn.UseVisualStyleBackColor = True
        ' 
        ' lblPassMatch
        ' 
        lblPassMatch.AutoSize = True
        lblPassMatch.ForeColor = Color.Red
        lblPassMatch.Location = New Point(271, 438)
        lblPassMatch.Name = "lblPassMatch"
        lblPassMatch.Size = New Size(93, 15)
        lblPassMatch.TabIndex = 28
        lblPassMatch.Text = "Does Not Match"
        ' 
        ' lblUserExist
        ' 
        lblUserExist.AutoSize = True
        lblUserExist.ForeColor = Color.Red
        lblUserExist.Location = New Point(273, 380)
        lblUserExist.Name = "lblUserExist"
        lblUserExist.Size = New Size(78, 15)
        lblUserExist.TabIndex = 29
        lblUserExist.Text = "Already Exists"
        ' 
        ' cmbStates
        ' 
        cmbStates.DropDownStyle = ComboBoxStyle.DropDownList
        cmbStates.FormattingEnabled = True
        cmbStates.Items.AddRange(New Object() {"AL", "AK", "AZ", "AR", "CA", "CO", "CT", "DE", "FL", "GA", "HI", "ID", "IL", "IN", "IA", "KS", "KY", "LA", "ME", "MD", "MA", "MI", "MN", "MS", "MO", "MT", "NE", "NV", "NH", "NJ", "NM", "NY", "NC", "ND", "OH", "OK", "OR", "PA", "RI", "SC", "SD", "TN", "TX", "UT", "VT", "VA", "WA", "WV", "WI", "WY"})
        cmbStates.Location = New Point(188, 290)
        cmbStates.Name = "cmbStates"
        cmbStates.Size = New Size(53, 23)
        cmbStates.TabIndex = 11
        ' 
        ' tipPassReq
        ' 
        tipPassReq.AutoPopDelay = 0
        tipPassReq.InitialDelay = 0
        tipPassReq.ReshowDelay = 0
        tipPassReq.ShowAlways = True
        tipPassReq.ToolTipTitle = "Password Requirements"
        ' 
        ' tipPasswordRules
        ' 
        tipPasswordRules.AutoPopDelay = 0
        tipPasswordRules.InitialDelay = 0
        tipPasswordRules.ReshowDelay = 0
        tipPasswordRules.ShowAlways = True
        tipPasswordRules.ToolTipTitle = "Missing Requirement"
        ' 
        ' lblUpper
        ' 
        lblUpper.BackColor = Color.Red
        lblUpper.Location = New Point(289, 414)
        lblUpper.Name = "lblUpper"
        lblUpper.Size = New Size(10, 10)
        lblUpper.TabIndex = 34
        ' 
        ' lblNum
        ' 
        lblNum.BackColor = Color.Red
        lblNum.Location = New Point(305, 414)
        lblNum.Name = "lblNum"
        lblNum.Size = New Size(10, 10)
        lblNum.TabIndex = 1
        ' 
        ' lblLower
        ' 
        lblLower.BackColor = Color.Red
        lblLower.Location = New Point(273, 414)
        lblLower.Name = "lblLower"
        lblLower.Size = New Size(10, 10)
        lblLower.TabIndex = 0
        ' 
        ' lbl8Char
        ' 
        lbl8Char.BackColor = Color.Red
        lbl8Char.Location = New Point(321, 414)
        lbl8Char.Name = "lbl8Char"
        lbl8Char.Size = New Size(10, 10)
        lbl8Char.TabIndex = 35
        ' 
        ' txtAddress2
        ' 
        txtAddress2.Location = New Point(167, 261)
        txtAddress2.MaxLength = 50
        txtAddress2.Name = "txtAddress2"
        txtAddress2.Size = New Size(186, 23)
        txtAddress2.TabIndex = 7
        ' 
        ' LabelSuite
        ' 
        LabelSuite.AutoSize = True
        LabelSuite.Location = New Point(20, 264)
        LabelSuite.Name = "LabelSuite"
        LabelSuite.Size = New Size(147, 15)
        LabelSuite.TabIndex = 6
        LabelSuite.Text = "Suite/Apartment/&Building:"
        ' 
        ' btnPassDisplay
        ' 
        btnPassDisplay.Location = New Point(129, 406)
        btnPassDisplay.Name = "btnPassDisplay"
        btnPassDisplay.Size = New Size(32, 23)
        btnPassDisplay.TabIndex = 24
        btnPassDisplay.UseVisualStyleBackColor = True
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(LabelTitle)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Location = New Point(10, 12)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(364, 105)
        Panel1.TabIndex = 39
        ' 
        ' frmNewAcct
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(384, 536)
        Controls.Add(Panel1)
        Controls.Add(btnPassDisplay)
        Controls.Add(LabelSuite)
        Controls.Add(txtAddress2)
        Controls.Add(lbl8Char)
        Controls.Add(cmbStates)
        Controls.Add(lblLower)
        Controls.Add(lblNum)
        Controls.Add(lblUserExist)
        Controls.Add(lblUpper)
        Controls.Add(lblPassMatch)
        Controls.Add(btnReturn)
        Controls.Add(btnSubmit)
        Controls.Add(txtRePass)
        Controls.Add(LabelRePass)
        Controls.Add(txtPass)
        Controls.Add(txtPhone)
        Controls.Add(LabelPass)
        Controls.Add(txtUser)
        Controls.Add(LabelUser)
        Controls.Add(txtOpenBal)
        Controls.Add(LabelOpenBal)
        Controls.Add(LabelPhone)
        Controls.Add(LabelState)
        Controls.Add(txtZip)
        Controls.Add(LabelZip)
        Controls.Add(txtCity)
        Controls.Add(LabelCity)
        Controls.Add(txtAddress1)
        Controls.Add(LabelAddress)
        Controls.Add(txtLast)
        Controls.Add(LabelLast)
        Controls.Add(txtFirst)
        Controls.Add(lblFirst)
        Controls.Add(LabelNewIntro)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        Name = "frmNewAcct"
        StartPosition = FormStartPosition.CenterScreen
        Text = "EBat New Customer"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents LabelNewIntro As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents LabelTitle As Label
    Friend WithEvents lblFirst As Label
    Friend WithEvents txtFirst As TextBox
    Friend WithEvents txtLast As TextBox
    Friend WithEvents LabelLast As Label
    Friend WithEvents txtAddress1 As TextBox
    Friend WithEvents LabelAddress As Label
    Friend WithEvents txtCity As TextBox
    Friend WithEvents LabelCity As Label
    Friend WithEvents LabelZip As Label
    Friend WithEvents LabelState As Label
    Friend WithEvents LabelPhone As Label
    Friend WithEvents LabelOpenBal As Label
    Friend WithEvents txtUser As TextBox
    Friend WithEvents LabelUser As Label
    Friend WithEvents LabelPass As Label
    Friend WithEvents txtPhone As MaskedTextBox
    Friend WithEvents txtZip As TextBox
    Friend WithEvents txtOpenBal As TextBox
    Friend WithEvents txtPass As TextBox
    Friend WithEvents txtRePass As TextBox
    Friend WithEvents LabelRePass As Label
    Friend WithEvents btnSubmit As Button
    Friend WithEvents btnReturn As Button
    Friend WithEvents lblPassMatch As Label
    Friend WithEvents lblUserExist As Label
    Friend WithEvents cmbStates As ComboBox
    Friend WithEvents tipPassReq As ToolTip
    Friend WithEvents tipPasswordRules As ToolTip
    Friend WithEvents lblUpper As Label
    Friend WithEvents lblNum As Label
    Friend WithEvents lblLower As Label
    Friend WithEvents lbl8Char As Label
    Friend WithEvents txtAddress2 As TextBox
    Friend WithEvents LabelSuite As Label
    Friend WithEvents btnPassDisplay As Button
    Friend WithEvents Panel1 As Panel
End Class
