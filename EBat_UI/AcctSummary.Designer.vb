<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAcctSummary
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAcctSummary))
        LabelAcctBal = New Label()
        LabelPhone = New Label()
        LabelAddress = New Label()
        LabelLast = New Label()
        LabelNewIntro = New Label()
        lblFirst = New Label()
        lblPhone = New Label()
        lblAcctBal = New Label()
        btnReturn = New Button()
        btnExport = New Button()
        LabelFirst = New Label()
        lblLast = New Label()
        lblAddress = New Label()
        lblAcctNum = New Label()
        LabelAcctNum = New Label()
        btnShowHideAcct = New Button()
        Panel1 = New Panel()
        LabelTitle = New Label()
        PictureBox1 = New PictureBox()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' LabelAcctBal
        ' 
        LabelAcctBal.AutoSize = True
        LabelAcctBal.Location = New Point(27, 343)
        LabelAcctBal.Name = "LabelAcctBal"
        LabelAcctBal.Size = New Size(94, 15)
        LabelAcctBal.TabIndex = 42
        LabelAcctBal.Text = "Current Balance:"
        ' 
        ' LabelPhone
        ' 
        LabelPhone.AutoSize = True
        LabelPhone.Location = New Point(27, 313)
        LabelPhone.Name = "LabelPhone"
        LabelPhone.Size = New Size(112, 15)
        LabelPhone.TabIndex = 40
        LabelPhone.Text = "Telephone Number:"
        ' 
        ' LabelAddress
        ' 
        LabelAddress.AutoSize = True
        LabelAddress.Location = New Point(27, 249)
        LabelAddress.Name = "LabelAddress"
        LabelAddress.Size = New Size(52, 15)
        LabelAddress.TabIndex = 32
        LabelAddress.Text = "Address:"
        ' 
        ' LabelLast
        ' 
        LabelLast.AutoSize = True
        LabelLast.Location = New Point(27, 220)
        LabelLast.Name = "LabelLast"
        LabelLast.Size = New Size(66, 15)
        LabelLast.TabIndex = 30
        LabelLast.Text = "Last Name:"
        ' 
        ' LabelNewIntro
        ' 
        LabelNewIntro.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LabelNewIntro.Location = New Point(12, 120)
        LabelNewIntro.Name = "LabelNewIntro"
        LabelNewIntro.Size = New Size(361, 57)
        LabelNewIntro.TabIndex = 45
        LabelNewIntro.Text = "Below is your account summary." & vbCrLf & vbCrLf & "You can export your information to a text file by clicking ""Export""."
        ' 
        ' lblFirst
        ' 
        lblFirst.BackColor = SystemColors.ButtonHighlight
        lblFirst.Location = New Point(174, 190)
        lblFirst.Name = "lblFirst"
        lblFirst.Size = New Size(100, 23)
        lblFirst.TabIndex = 46
        ' 
        ' lblPhone
        ' 
        lblPhone.BackColor = SystemColors.ButtonHighlight
        lblPhone.Location = New Point(174, 313)
        lblPhone.Name = "lblPhone"
        lblPhone.Size = New Size(100, 23)
        lblPhone.TabIndex = 50
        ' 
        ' lblAcctBal
        ' 
        lblAcctBal.BackColor = SystemColors.ButtonHighlight
        lblAcctBal.Location = New Point(174, 343)
        lblAcctBal.Name = "lblAcctBal"
        lblAcctBal.Size = New Size(183, 23)
        lblAcctBal.TabIndex = 51
        ' 
        ' btnReturn
        ' 
        btnReturn.Location = New Point(213, 499)
        btnReturn.Name = "btnReturn"
        btnReturn.Size = New Size(90, 25)
        btnReturn.TabIndex = 2
        btnReturn.Text = "&Return"
        btnReturn.UseVisualStyleBackColor = True
        ' 
        ' btnExport
        ' 
        btnExport.Location = New Point(81, 499)
        btnExport.Name = "btnExport"
        btnExport.Size = New Size(90, 25)
        btnExport.TabIndex = 1
        btnExport.Text = "&Export"
        btnExport.UseVisualStyleBackColor = True
        ' 
        ' LabelFirst
        ' 
        LabelFirst.AutoSize = True
        LabelFirst.Location = New Point(27, 190)
        LabelFirst.Name = "LabelFirst"
        LabelFirst.Size = New Size(67, 15)
        LabelFirst.TabIndex = 54
        LabelFirst.Text = "First Name:"
        ' 
        ' lblLast
        ' 
        lblLast.BackColor = SystemColors.ButtonHighlight
        lblLast.Location = New Point(174, 220)
        lblLast.Name = "lblLast"
        lblLast.Size = New Size(100, 23)
        lblLast.TabIndex = 55
        ' 
        ' lblAddress
        ' 
        lblAddress.BackColor = SystemColors.ButtonHighlight
        lblAddress.Location = New Point(174, 249)
        lblAddress.Name = "lblAddress"
        lblAddress.Size = New Size(183, 56)
        lblAddress.TabIndex = 56
        ' 
        ' lblAcctNum
        ' 
        lblAcctNum.BackColor = SystemColors.ButtonHighlight
        lblAcctNum.Location = New Point(174, 373)
        lblAcctNum.Name = "lblAcctNum"
        lblAcctNum.Size = New Size(77, 23)
        lblAcctNum.TabIndex = 58
        ' 
        ' LabelAcctNum
        ' 
        LabelAcctNum.AutoSize = True
        LabelAcctNum.Location = New Point(27, 373)
        LabelAcctNum.Name = "LabelAcctNum"
        LabelAcctNum.Size = New Size(102, 15)
        LabelAcctNum.TabIndex = 57
        LabelAcctNum.Text = "Account Number:"
        ' 
        ' btnShowHideAcct
        ' 
        btnShowHideAcct.Location = New Point(257, 373)
        btnShowHideAcct.Name = "btnShowHideAcct"
        btnShowHideAcct.Size = New Size(100, 23)
        btnShowHideAcct.TabIndex = 0
        btnShowHideAcct.TabStop = False
        btnShowHideAcct.Text = "&Show Number"
        btnShowHideAcct.UseVisualStyleBackColor = True
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(LabelTitle)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Location = New Point(8, 11)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(364, 105)
        Panel1.TabIndex = 63
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
        ' frmAcctSummary
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        CancelButton = btnReturn
        ClientSize = New Size(384, 536)
        Controls.Add(Panel1)
        Controls.Add(btnShowHideAcct)
        Controls.Add(lblAcctNum)
        Controls.Add(LabelAcctNum)
        Controls.Add(lblAddress)
        Controls.Add(lblLast)
        Controls.Add(LabelFirst)
        Controls.Add(btnReturn)
        Controls.Add(btnExport)
        Controls.Add(lblAcctBal)
        Controls.Add(lblPhone)
        Controls.Add(lblFirst)
        Controls.Add(LabelAcctBal)
        Controls.Add(LabelPhone)
        Controls.Add(LabelAddress)
        Controls.Add(LabelLast)
        Controls.Add(LabelNewIntro)
        MaximizeBox = False
        Name = "frmAcctSummary"
        StartPosition = FormStartPosition.CenterScreen
        Text = "EBaT Customer Account Summary"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents txtOpenBal As TextBox
    Friend WithEvents LabelAcctBal As Label
    Friend WithEvents LabelPhone As Label
    Friend WithEvents LabelAddress As Label
    Friend WithEvents LabelLast As Label
    Friend WithEvents lblFirst As Label
    Friend WithEvents LabelNewIntro As Label
    Friend WithEvents lblAcctNum As Label
    Friend WithEvents LabelAcctNum As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblPhone As Label
    Friend WithEvents lblAcctBal As Label
    Friend WithEvents btnReturn As Button
    Friend WithEvents btnExport As Button
    Friend WithEvents LabelFirst As Label
    Friend WithEvents lblLast As Label
    Friend WithEvents lblAddress As Label
    Friend WithEvents btnShowHideAcct As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents LabelTitle As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
