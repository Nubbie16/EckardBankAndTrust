Imports System.Reflection

Public Class TestHarnessForm

    Private Sub TestHarnessForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Populate ComboBox with form names dynamically
        cmbForms.Items.Clear()

        Dim asm As Assembly = Assembly.GetExecutingAssembly()
        For Each t As Type In asm.GetTypes()
            If t.BaseType IsNot Nothing AndAlso t.BaseType.Equals(GetType(Form)) Then
                cmbForms.Items.Add(t.Name)
            End If
        Next

        If cmbForms.Items.Count > 0 Then
            cmbForms.SelectedIndex = 0
        End If
    End Sub

    Private Sub btnOpen_Click(sender As Object, e As EventArgs) Handles btnOpen.Click
        If cmbForms.SelectedItem Is Nothing Then
            MessageBox.Show("Select a form to open.")
            Return
        End If

        Dim formName As String = cmbForms.SelectedItem.ToString()
        Dim asm As Assembly = Assembly.GetExecutingAssembly()
        Dim t As Type = asm.GetTypes().FirstOrDefault(Function(tp) tp.Name = formName)

        If t IsNot Nothing Then
            Dim f As Form = CType(Activator.CreateInstance(t), Form)
            f.ShowDialog()
        Else
            MessageBox.Show("Form not found: " & formName)
        End If
    End Sub

End Class
