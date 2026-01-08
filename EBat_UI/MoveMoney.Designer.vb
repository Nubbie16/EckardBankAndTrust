<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMoveMoney
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMoveMoney))
        LabelAcctBal = New Label()
        lblAcctBal = New Label()
        radDeposit = New RadioButton()
        radWithdraw = New RadioButton()
        txtMoney = New TextBox()
        lblMoveType = New Label()
        btnReturn = New Button()
        btnSubmit = New Button()
        Panel1 = New Panel()
        LabelTitle = New Label()
        PictureBox1 = New PictureBox()
        Panel2 = New Panel()
        grpCheckCash = New Panel()
        radCheck = New RadioButton()
        radCash = New RadioButton()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        grpCheckCash.SuspendLayout()
        SuspendLayout()
        ' 
        ' LabelAcctBal
        ' 
        LabelAcctBal.AutoSize = True
        LabelAcctBal.Location = New Point(33, 131)
        LabelAcctBal.Name = "LabelAcctBal"
        LabelAcctBal.Size = New Size(99, 15)
        LabelAcctBal.TabIndex = 0
        LabelAcctBal.Text = "Account Balance:"
        ' 
        ' lblAcctBal
        ' 
        lblAcctBal.BackColor = SystemColors.ButtonHighlight
        lblAcctBal.Location = New Point(183, 123)
        lblAcctBal.Name = "lblAcctBal"
        lblAcctBal.Size = New Size(169, 23)
        lblAcctBal.TabIndex = 1
        ' 
        ' radDeposit
        ' 
        radDeposit.AutoSize = True
        radDeposit.Checked = True
        radDeposit.Location = New Point(3, 3)
        radDeposit.Name = "radDeposit"
        radDeposit.Size = New Size(71, 19)
        radDeposit.TabIndex = 0
        radDeposit.TabStop = True
        radDeposit.Text = "&DEPOSIT"
        radDeposit.UseVisualStyleBackColor = True
        ' 
        ' radWithdraw
        ' 
        radWithdraw.AutoSize = True
        radWithdraw.Location = New Point(3, 28)
        radWithdraw.Name = "radWithdraw"
        radWithdraw.Size = New Size(88, 19)
        radWithdraw.TabIndex = 1
        radWithdraw.Text = "&WITHDRAW"
        radWithdraw.UseVisualStyleBackColor = True
        ' 
        ' txtMoney
        ' 
        txtMoney.Location = New Point(264, 221)
        txtMoney.MaxLength = 15
        txtMoney.Name = "txtMoney"
        txtMoney.Size = New Size(88, 23)
        txtMoney.TabIndex = 5
        ' 
        ' lblMoveType
        ' 
        lblMoveType.AutoSize = True
        lblMoveType.Location = New Point(33, 229)
        lblMoveType.Name = "lblMoveType"
        lblMoveType.Size = New Size(225, 15)
        lblMoveType.TabIndex = 4
        lblMoveType.Text = "How much would you like to [Dep/With]:"
        ' 
        ' btnReturn
        ' 
        btnReturn.Location = New Point(147, 294)
        btnReturn.Name = "btnReturn"
        btnReturn.Size = New Size(90, 25)
        btnReturn.TabIndex = 7
        btnReturn.Text = "&Return"
        btnReturn.UseVisualStyleBackColor = True
        ' 
        ' btnSubmit
        ' 
        btnSubmit.Location = New Point(147, 263)
        btnSubmit.Name = "btnSubmit"
        btnSubmit.Size = New Size(90, 25)
        btnSubmit.TabIndex = 6
        btnSubmit.Text = "&Submit"
        btnSubmit.UseVisualStyleBackColor = True
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(LabelTitle)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Location = New Point(8, 12)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(364, 105)
        Panel1.TabIndex = 62
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
        ' Panel2
        ' 
        Panel2.Controls.Add(radWithdraw)
        Panel2.Controls.Add(radDeposit)
        Panel2.Location = New Point(33, 161)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(99, 53)
        Panel2.TabIndex = 2
        ' 
        ' grpCheckCash
        ' 
        grpCheckCash.Controls.Add(radCheck)
        grpCheckCash.Controls.Add(radCash)
        grpCheckCash.Location = New Point(183, 161)
        grpCheckCash.Name = "grpCheckCash"
        grpCheckCash.Size = New Size(130, 27)
        grpCheckCash.TabIndex = 3
        ' 
        ' radCheck
        ' 
        radCheck.AutoSize = True
        radCheck.Location = New Point(65, 3)
        radCheck.Name = "radCheck"
        radCheck.Size = New Size(63, 19)
        radCheck.TabIndex = 1
        radCheck.Text = "C&HECK"
        radCheck.UseVisualStyleBackColor = True
        ' 
        ' radCash
        ' 
        radCash.AutoSize = True
        radCash.Location = New Point(3, 3)
        radCash.Name = "radCash"
        radCash.Size = New Size(56, 19)
        radCash.TabIndex = 0
        radCash.Text = "C&ASH"
        radCash.UseVisualStyleBackColor = True
        ' 
        ' frmMoveMoney
        ' 
        AcceptButton = btnSubmit
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        CancelButton = btnReturn
        ClientSize = New Size(384, 361)
        Controls.Add(grpCheckCash)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Controls.Add(btnReturn)
        Controls.Add(btnSubmit)
        Controls.Add(lblMoveType)
        Controls.Add(txtMoney)
        Controls.Add(lblAcctBal)
        Controls.Add(LabelAcctBal)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        Name = "frmMoveMoney"
        StartPosition = FormStartPosition.CenterScreen
        Text = "EBaT Withdraw/Deposit"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        grpCheckCash.ResumeLayout(False)
        grpCheckCash.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents LabelAcctBal As Label
    Friend WithEvents lblAcctBal As Label
    Friend WithEvents radDeposit As RadioButton
    Friend WithEvents radWithdraw As RadioButton
    Friend WithEvents txtMoney As TextBox
    Friend WithEvents lblMoveType As Label
    Friend WithEvents btnReturn As Button
    Friend WithEvents btnSubmit As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents LabelTitle As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents grpCheckCash As Panel
    Friend WithEvents radCheck As RadioButton
    Friend WithEvents radCash As RadioButton
End Class
