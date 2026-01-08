<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMainMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMainMenu))
        btnExit = New Button()
        btnCurrentAcct = New Button()
        btnNewAcct = New Button()
        PictureBox1 = New PictureBox()
        LabelTitle = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnExit
        ' 
        btnExit.Location = New Point(147, 324)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(90, 25)
        btnExit.TabIndex = 2
        btnExit.Text = "E&xit"
        btnExit.UseVisualStyleBackColor = True
        ' 
        ' btnCurrentAcct
        ' 
        btnCurrentAcct.Location = New Point(147, 207)
        btnCurrentAcct.Name = "btnCurrentAcct"
        btnCurrentAcct.Size = New Size(90, 25)
        btnCurrentAcct.TabIndex = 0
        btnCurrentAcct.Text = "&Log In"
        btnCurrentAcct.UseVisualStyleBackColor = True
        ' 
        ' btnNewAcct
        ' 
        btnNewAcct.Location = New Point(147, 239)
        btnNewAcct.Name = "btnNewAcct"
        btnNewAcct.Size = New Size(90, 25)
        btnNewAcct.TabIndex = 1
        btnNewAcct.Text = "&New Account"
        btnNewAcct.UseVisualStyleBackColor = True
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(129, 12)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(126, 120)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 6
        PictureBox1.TabStop = False
        ' 
        ' LabelTitle
        ' 
        LabelTitle.AutoSize = True
        LabelTitle.BackColor = Color.Transparent
        LabelTitle.Font = New Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LabelTitle.ForeColor = SystemColors.ControlText
        LabelTitle.Location = New Point(30, 147)
        LabelTitle.Name = "LabelTitle"
        LabelTitle.Size = New Size(324, 45)
        LabelTitle.TabIndex = 8
        LabelTitle.Text = "Eckard Bank && Trust"
        ' 
        ' frmMainMenu
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        CancelButton = btnExit
        ClientSize = New Size(384, 361)
        Controls.Add(btnExit)
        Controls.Add(btnCurrentAcct)
        Controls.Add(btnNewAcct)
        Controls.Add(PictureBox1)
        Controls.Add(LabelTitle)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        Name = "frmMainMenu"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Welcome to Eckard Bank & Trust"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnExit As Button
    Friend WithEvents btnCurrentAcct As Button
    Friend WithEvents btnNewAcct As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents LabelTitle As Label
End Class
