<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TestHarnessForm
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
        cmbForms = New ComboBox()
        btnOpen = New Button()
        SuspendLayout()
        ' 
        ' cmbForms
        ' 
        cmbForms.FormattingEnabled = True
        cmbForms.Location = New Point(63, 16)
        cmbForms.Name = "cmbForms"
        cmbForms.Size = New Size(121, 23)
        cmbForms.TabIndex = 0
        ' 
        ' btnOpen
        ' 
        btnOpen.Location = New Point(82, 45)
        btnOpen.Name = "btnOpen"
        btnOpen.Size = New Size(75, 23)
        btnOpen.TabIndex = 1
        btnOpen.Text = "Run"
        btnOpen.UseVisualStyleBackColor = True
        ' 
        ' TestHarnessForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(246, 85)
        Controls.Add(btnOpen)
        Controls.Add(cmbForms)
        Name = "TestHarnessForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "TestHarnessForm"
        ResumeLayout(False)
    End Sub

    Friend WithEvents cmbForms As ComboBox
    Friend WithEvents btnOpen As Button
End Class
