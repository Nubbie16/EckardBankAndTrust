<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditConfirmDia
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EditConfirmDia))
        LabelIncorrectData = New Label()
        txtUpdateData = New TextBox()
        btnExit = New Button()
        SuspendLayout()
        ' 
        ' LabelIncorrectData
        ' 
        LabelIncorrectData.Location = New Point(52, 9)
        LabelIncorrectData.Name = "LabelIncorrectData"
        LabelIncorrectData.Size = New Size(280, 71)
        LabelIncorrectData.TabIndex = 0
        LabelIncorrectData.Text = "Update Successful." & vbCrLf & vbCrLf & "The following has been updated:"
        LabelIncorrectData.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' txtUpdateData
        ' 
        txtUpdateData.HideSelection = False
        txtUpdateData.Location = New Point(52, 83)
        txtUpdateData.Multiline = True
        txtUpdateData.Name = "txtUpdateData"
        txtUpdateData.ReadOnly = True
        txtUpdateData.ScrollBars = ScrollBars.Horizontal
        txtUpdateData.Size = New Size(280, 181)
        txtUpdateData.TabIndex = 1
        txtUpdateData.TabStop = False
        txtUpdateData.Text = "- Lorem" & vbCrLf & "- ipsum" & vbCrLf & "- dolor" & vbCrLf & "- Lorem" & vbCrLf & "- ipsum" & vbCrLf & "- dolor" & vbCrLf & "- Lorem" & vbCrLf & "- ipsum" & vbCrLf & "- dolor" & vbCrLf & "- Lorem"
        ' 
        ' btnExit
        ' 
        btnExit.Location = New Point(147, 271)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(90, 25)
        btnExit.TabIndex = 2
        btnExit.Text = "&Close"
        btnExit.UseVisualStyleBackColor = True
        ' 
        ' EditConfimDia
        ' 
        AcceptButton = btnExit
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        CancelButton = btnExit
        ClientSize = New Size(384, 306)
        Controls.Add(btnExit)
        Controls.Add(txtUpdateData)
        Controls.Add(LabelIncorrectData)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        MinimizeBox = False
        Name = "EditConfimDia"
        StartPosition = FormStartPosition.CenterScreen
        Text = "EBaT Information Updated"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents LabelIncorrectData As Label
    Friend WithEvents txtUpdateData As TextBox
    Friend WithEvents btnExit As Button
End Class
