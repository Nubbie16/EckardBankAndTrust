<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCustMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCustMenu))
        lblWelMess = New Label()
        btnEdit = New Button()
        btnMoney = New Button()
        btnSummary = New Button()
        btnLogOut = New Button()
        Panel1 = New Panel()
        LabelTitle = New Label()
        PictureBox1 = New PictureBox()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblWelMess
        ' 
        lblWelMess.AutoSize = True
        lblWelMess.Location = New Point(12, 120)
        lblWelMess.Name = "lblWelMess"
        lblWelMess.Size = New Size(151, 45)
        lblWelMess.TabIndex = 26
        lblWelMess.Text = "Welcome back, [strFirst]." & vbCrLf & vbCrLf & "What would you like to do?"
        ' 
        ' btnEdit
        ' 
        btnEdit.AutoSize = True
        btnEdit.Location = New Point(141, 195)
        btnEdit.Name = "btnEdit"
        btnEdit.Size = New Size(103, 25)
        btnEdit.TabIndex = 0
        btnEdit.Text = "&Edit Information"
        btnEdit.UseVisualStyleBackColor = True
        ' 
        ' btnMoney
        ' 
        btnMoney.Location = New Point(147, 226)
        btnMoney.Name = "btnMoney"
        btnMoney.Size = New Size(90, 25)
        btnMoney.TabIndex = 1
        btnMoney.Text = "&Move Money"
        btnMoney.UseVisualStyleBackColor = True
        ' 
        ' btnSummary
        ' 
        btnSummary.Location = New Point(147, 255)
        btnSummary.Name = "btnSummary"
        btnSummary.Size = New Size(90, 25)
        btnSummary.TabIndex = 2
        btnSummary.Text = "&Summary"
        btnSummary.UseVisualStyleBackColor = True
        ' 
        ' btnLogOut
        ' 
        btnLogOut.Location = New Point(147, 326)
        btnLogOut.Name = "btnLogOut"
        btnLogOut.Size = New Size(90, 25)
        btnLogOut.TabIndex = 3
        btnLogOut.Text = "&Log Out"
        btnLogOut.UseVisualStyleBackColor = True
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(LabelTitle)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Location = New Point(8, 12)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(364, 105)
        Panel1.TabIndex = 41
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
        ' frmCustMenu
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        CancelButton = btnLogOut
        ClientSize = New Size(384, 361)
        Controls.Add(Panel1)
        Controls.Add(btnLogOut)
        Controls.Add(btnMoney)
        Controls.Add(btnSummary)
        Controls.Add(btnEdit)
        Controls.Add(lblWelMess)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        Name = "frmCustMenu"
        StartPosition = FormStartPosition.CenterScreen
        Text = "EBat Customer Menu"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents lblWelMess As Label
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnMoney As Button
    Friend WithEvents btnSummary As Button
    Friend WithEvents btnLogOut As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents LabelTitle As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
