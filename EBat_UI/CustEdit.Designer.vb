<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCustEdit
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCustEdit))
        LabelEditMess = New Label()
        lblPassMatch = New Label()
        txtRePass = New TextBox()
        LabelRePass = New Label()
        txtPass = New TextBox()
        txtPhone = New MaskedTextBox()
        LabelPass = New Label()
        LabelPhone = New Label()
        LabelState = New Label()
        txtZip = New TextBox()
        LabelZip = New Label()
        txtCity = New TextBox()
        LabelCity = New Label()
        txtAddress1 = New TextBox()
        LabelAddress = New Label()
        txtLast = New TextBox()
        LabelLast = New Label()
        txtFirst = New TextBox()
        lblFirst = New Label()
        btnReturn = New Button()
        btnSubmit = New Button()
        lbl8Char = New Label()
        lblLower = New Label()
        lblNum = New Label()
        lblUpper = New Label()
        cmbStates = New ComboBox()
        tipPassReq = New ToolTip(components)
        tipPasswordRules = New ToolTip(components)
        LabelSuite = New Label()
        txtAddress2 = New TextBox()
        btnPassDisplay = New Button()
        Panel1 = New Panel()
        LabelTitle = New Label()
        PictureBox1 = New PictureBox()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' LabelEditMess
        ' 
        LabelEditMess.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LabelEditMess.Location = New Point(12, 124)
        LabelEditMess.Name = "LabelEditMess"
        LabelEditMess.Size = New Size(360, 24)
        LabelEditMess.TabIndex = 27
        LabelEditMess.Text = "Please provide any updated information below:"
        ' 
        ' lblPassMatch
        ' 
        lblPassMatch.AutoSize = True
        lblPassMatch.ForeColor = Color.Red
        lblPassMatch.Location = New Point(273, 381)
        lblPassMatch.Name = "lblPassMatch"
        lblPassMatch.Size = New Size(93, 15)
        lblPassMatch.TabIndex = 53
        lblPassMatch.Text = "Does Not Match"
        ' 
        ' txtRePass
        ' 
        txtRePass.Location = New Point(167, 378)
        txtRePass.MaxLength = 20
        txtRePass.Name = "txtRePass"
        txtRePass.PasswordChar = "*"c
        txtRePass.Size = New Size(100, 23)
        txtRePass.TabIndex = 19
        ' 
        ' LabelRePass
        ' 
        LabelRePass.AutoSize = True
        LabelRePass.Location = New Point(20, 381)
        LabelRePass.Name = "LabelRePass"
        LabelRePass.Size = New Size(108, 15)
        LabelRePass.TabIndex = 18
        LabelRePass.Text = "Re-Enter Pass&word:"
        ' 
        ' txtPass
        ' 
        txtPass.Location = New Point(167, 349)
        txtPass.MaxLength = 20
        txtPass.Name = "txtPass"
        txtPass.PasswordChar = "*"c
        txtPass.Size = New Size(100, 23)
        txtPass.TabIndex = 17
        ' 
        ' txtPhone
        ' 
        txtPhone.Location = New Point(167, 320)
        txtPhone.Mask = "(999) 000-0000"
        txtPhone.Name = "txtPhone"
        txtPhone.Size = New Size(100, 23)
        txtPhone.TabIndex = 15
        ' 
        ' LabelPass
        ' 
        LabelPass.AutoSize = True
        LabelPass.Location = New Point(20, 352)
        LabelPass.Name = "LabelPass"
        LabelPass.Size = New Size(60, 15)
        LabelPass.TabIndex = 16
        LabelPass.Text = "&Password:"
        ' 
        ' LabelPhone
        ' 
        LabelPhone.AutoSize = True
        LabelPhone.Location = New Point(20, 323)
        LabelPhone.Name = "LabelPhone"
        LabelPhone.Size = New Size(112, 15)
        LabelPhone.TabIndex = 14
        LabelPhone.Text = "T&elephone Number:"
        ' 
        ' LabelState
        ' 
        LabelState.AutoSize = True
        LabelState.Location = New Point(146, 295)
        LabelState.Name = "LabelState"
        LabelState.Size = New Size(36, 15)
        LabelState.TabIndex = 10
        LabelState.Text = "S&tate:"
        ' 
        ' txtZip
        ' 
        txtZip.Location = New Point(284, 292)
        txtZip.MaxLength = 5
        txtZip.Name = "txtZip"
        txtZip.Size = New Size(69, 23)
        txtZip.TabIndex = 13
        ' 
        ' LabelZip
        ' 
        LabelZip.AutoSize = True
        LabelZip.Location = New Point(247, 295)
        LabelZip.Name = "LabelZip"
        LabelZip.Size = New Size(27, 15)
        LabelZip.TabIndex = 12
        LabelZip.Text = "&ZIP:"
        ' 
        ' txtCity
        ' 
        txtCity.Location = New Point(57, 292)
        txtCity.MaxLength = 50
        txtCity.Name = "txtCity"
        txtCity.Size = New Size(83, 23)
        txtCity.TabIndex = 9
        ' 
        ' LabelCity
        ' 
        LabelCity.AutoSize = True
        LabelCity.Location = New Point(20, 295)
        LabelCity.Name = "LabelCity"
        LabelCity.Size = New Size(31, 15)
        LabelCity.TabIndex = 8
        LabelCity.Text = "&City:"
        ' 
        ' txtAddress1
        ' 
        txtAddress1.Location = New Point(165, 234)
        txtAddress1.MaxLength = 50
        txtAddress1.Name = "txtAddress1"
        txtAddress1.Size = New Size(186, 23)
        txtAddress1.TabIndex = 5
        ' 
        ' LabelAddress
        ' 
        LabelAddress.AutoSize = True
        LabelAddress.Location = New Point(18, 237)
        LabelAddress.Name = "LabelAddress"
        LabelAddress.Size = New Size(52, 15)
        LabelAddress.TabIndex = 4
        LabelAddress.Text = "&Address:"
        ' 
        ' txtLast
        ' 
        txtLast.Location = New Point(165, 205)
        txtLast.MaxLength = 50
        txtLast.Name = "txtLast"
        txtLast.Size = New Size(100, 23)
        txtLast.TabIndex = 3
        ' 
        ' LabelLast
        ' 
        LabelLast.AutoSize = True
        LabelLast.Location = New Point(18, 208)
        LabelLast.Name = "LabelLast"
        LabelLast.Size = New Size(66, 15)
        LabelLast.TabIndex = 2
        LabelLast.Text = "&Last Name:"
        ' 
        ' txtFirst
        ' 
        txtFirst.Location = New Point(165, 175)
        txtFirst.MaxLength = 50
        txtFirst.Name = "txtFirst"
        txtFirst.Size = New Size(100, 23)
        txtFirst.TabIndex = 1
        ' 
        ' lblFirst
        ' 
        lblFirst.AutoSize = True
        lblFirst.Location = New Point(18, 178)
        lblFirst.Name = "lblFirst"
        lblFirst.Size = New Size(67, 15)
        lblFirst.TabIndex = 0
        lblFirst.Text = "&First Name:"
        ' 
        ' btnReturn
        ' 
        btnReturn.Location = New Point(215, 501)
        btnReturn.Name = "btnReturn"
        btnReturn.Size = New Size(90, 25)
        btnReturn.TabIndex = 22
        btnReturn.Text = "&Return"
        btnReturn.UseVisualStyleBackColor = True
        ' 
        ' btnSubmit
        ' 
        btnSubmit.Location = New Point(83, 501)
        btnSubmit.Name = "btnSubmit"
        btnSubmit.Size = New Size(90, 25)
        btnSubmit.TabIndex = 21
        btnSubmit.Text = "&Submit"
        btnSubmit.UseVisualStyleBackColor = True
        ' 
        ' lbl8Char
        ' 
        lbl8Char.BackColor = Color.Red
        lbl8Char.Location = New Point(324, 357)
        lbl8Char.Name = "lbl8Char"
        lbl8Char.Size = New Size(10, 10)
        lbl8Char.TabIndex = 26
        ' 
        ' lblLower
        ' 
        lblLower.BackColor = Color.Red
        lblLower.Location = New Point(276, 357)
        lblLower.Name = "lblLower"
        lblLower.Size = New Size(10, 10)
        lblLower.TabIndex = 23
        ' 
        ' lblNum
        ' 
        lblNum.BackColor = Color.Red
        lblNum.Location = New Point(308, 357)
        lblNum.Name = "lblNum"
        lblNum.Size = New Size(10, 10)
        lblNum.TabIndex = 25
        ' 
        ' lblUpper
        ' 
        lblUpper.BackColor = Color.Red
        lblUpper.Location = New Point(292, 357)
        lblUpper.Name = "lblUpper"
        lblUpper.Size = New Size(10, 10)
        lblUpper.TabIndex = 24
        ' 
        ' cmbStates
        ' 
        cmbStates.DropDownStyle = ComboBoxStyle.DropDownList
        cmbStates.FormattingEnabled = True
        cmbStates.Items.AddRange(New Object() {"", "AL", "AK", "AZ", "AR", "CA", "CO", "CT", "DE", "FL", "GA", "HI", "ID", "IL", "IN", "IA", "KS", "KY", "LA", "ME", "MD", "MA", "MI", "MN", "MS", "MO", "MT", "NE", "NV", "NH", "NJ", "NM", "NY", "NC", "ND", "OH", "OK", "OR", "PA", "RI", "SC", "SD", "TN", "TX", "UT", "VT", "VA", "WA", "WV", "WI", "WY"})
        cmbStates.Location = New Point(188, 291)
        cmbStates.Name = "cmbStates"
        cmbStates.Size = New Size(53, 23)
        cmbStates.TabIndex = 11
        ' 
        ' tipPassReq
        ' 
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
        ' LabelSuite
        ' 
        LabelSuite.AutoSize = True
        LabelSuite.Location = New Point(20, 266)
        LabelSuite.Name = "LabelSuite"
        LabelSuite.Size = New Size(147, 15)
        LabelSuite.TabIndex = 6
        LabelSuite.Text = "Suite/Apartment/&Building:"
        ' 
        ' txtAddress2
        ' 
        txtAddress2.Location = New Point(167, 263)
        txtAddress2.MaxLength = 50
        txtAddress2.Name = "txtAddress2"
        txtAddress2.Size = New Size(186, 23)
        txtAddress2.TabIndex = 7
        ' 
        ' btnPassDisplay
        ' 
        btnPassDisplay.Location = New Point(129, 349)
        btnPassDisplay.Name = "btnPassDisplay"
        btnPassDisplay.Size = New Size(32, 23)
        btnPassDisplay.TabIndex = 20
        btnPassDisplay.UseVisualStyleBackColor = True
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(LabelTitle)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Location = New Point(8, 12)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(364, 105)
        Panel1.TabIndex = 57
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
        ' frmCustEdit
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        CancelButton = btnReturn
        ClientSize = New Size(384, 536)
        Controls.Add(Panel1)
        Controls.Add(btnPassDisplay)
        Controls.Add(LabelSuite)
        Controls.Add(txtAddress2)
        Controls.Add(lbl8Char)
        Controls.Add(cmbStates)
        Controls.Add(lblLower)
        Controls.Add(lblNum)
        Controls.Add(lblUpper)
        Controls.Add(btnReturn)
        Controls.Add(btnSubmit)
        Controls.Add(lblPassMatch)
        Controls.Add(txtRePass)
        Controls.Add(LabelRePass)
        Controls.Add(txtPass)
        Controls.Add(txtPhone)
        Controls.Add(LabelPass)
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
        Controls.Add(LabelEditMess)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        Name = "frmCustEdit"
        StartPosition = FormStartPosition.CenterScreen
        Text = "EBaT Edit Customer Info"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents LabelEditMess As Label
    Friend WithEvents lblPassMatch As Label
    Friend WithEvents txtRePass As TextBox
    Friend WithEvents LabelRePass As Label
    Friend WithEvents txtPass As TextBox
    Friend WithEvents txtPhone As MaskedTextBox
    Friend WithEvents LabelPass As Label
    Friend WithEvents LabelPhone As Label
    Friend WithEvents LabelState As Label
    Friend WithEvents txtZip As TextBox
    Friend WithEvents LabelZip As Label
    Friend WithEvents txtCity As TextBox
    Friend WithEvents LabelCity As Label
    Friend WithEvents txtAddress1 As TextBox
    Friend WithEvents LabelAddress As Label
    Friend WithEvents txtLast As TextBox
    Friend WithEvents LabelLast As Label
    Friend WithEvents txtFirst As TextBox
    Friend WithEvents lblFirst As Label
    Friend WithEvents btnReturn As Button
    Friend WithEvents btnSubmit As Button
    Friend WithEvents lbl8Char As Label
    Friend WithEvents lblLower As Label
    Friend WithEvents lblNum As Label
    Friend WithEvents lblUpper As Label
    Friend WithEvents cmbStates As ComboBox
    Friend WithEvents tipPassReq As ToolTip
    Friend WithEvents tipPasswordRules As ToolTip
    Friend WithEvents LabelSuite As Label
    Friend WithEvents txtAddress2 As TextBox
    Friend WithEvents btnPassDisplay As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents LabelTitle As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
