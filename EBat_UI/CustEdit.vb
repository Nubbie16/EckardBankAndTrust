'Visual BASIC Program File
'@author: Cody Eckard
'@date: 9/4/2025
'@Solution Name: EckardBankTrust.sln
'@Project Name: EBaT_UI
'@File Name: CustEdit.vb

Imports EBaT_Audit.EBaT_Audit
Imports EBaT_Logic, EBaT_Models

Public Class frmCustEdit

    Private _cust As CustData

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()
    End Sub

    Public Sub New(ByVal user As CustData)
        ' This call is required by the designer.
        InitializeComponent()
        _cust = user
    End Sub

    Private Sub frmCustEdit_Load(sender As Object, e As EventArgs) Handles Me.Load
        'sets initial values as the form loads
        cmbStates.SelectedIndex = 0

        'Sets ToolTips
        Dim passLabels() As Label = {lblLower, lblUpper, lblNum, lbl8Char}
        PassLabelToolTips(passLabels, tipPasswordRules)         'EBaT_Validation

        'sets default "Show Password" button image
        btnPassDisplay.Image = passwordHidden
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        'Button to submit user data change
        'Gather existing customer fields
        Dim existingAcctFields() As String = {_cust.username, _cust.first, _cust.last, _cust.address1, _cust.address2,
        _cust.city, _cust.st, _cust.zip, _cust.phone, _cust.password}

        txtPhone.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals

        'Validation flags
        Dim boolPhone As Boolean = True
        Dim boolZip As Boolean = True
        Dim boolPassMatch As Boolean = True
        Dim boolValidPassword As Boolean = True

        If txtZip.Text.Trim <> "" Then
            boolZip = ValidZip(txtZip)      'EBaT_Validation
            If Not boolZip Then
                MessageBox.Show("Please enter 5-digit Zip code.", "EBaT Invalid ZIP Code", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        End If

        If txtPhone.Text.Trim <> "" Then
            boolPhone = ValidPhone(txtPhone)        'EBaT_Validation
            If Not boolPhone Then
                MessageBox.Show("Please enter 10-digit phone number.", "EBaT Invalid Phone Number", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        End If

        If txtPass.Text.Trim <> "" Then
            boolPassMatch = PassMatch(txtPass, txtRePass)       'EBaT_Validation
            If Not boolPassMatch Then
                MessageBox.Show("Passwords do not match.", "EBaT Incorrect Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If

            boolValidPassword = PassValidate(txtPass.Text)      'EBaT_Validation
            If Not boolValidPassword Then
                MessageBox.Show("Password does not meet requirements. Hover over squares for more information.",
                            "EBaT Incorrect Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        End If

        If Not (boolZip AndAlso boolPhone AndAlso boolPassMatch AndAlso boolValidPassword) Then
            Exit Sub
        End If

        'User entered fields
        Dim enteredFields() As String = {_cust.username, txtFirst.Text.ToUpper(), txtLast.Text.ToUpper(), txtAddress1.Text.ToUpper(),
            txtAddress2.Text.ToUpper(), txtCity.Text.ToUpper(), cmbStates.SelectedItem.ToString(), txtZip.Text, txtPhone.Text, txtPass.Text}

        Dim updatedFields() As String = GetUpdatedFields(existingAcctFields, enteredFields)     'EBaT_Logic

        Dim noChange As Boolean = True
        For i As Integer = 1 To updatedFields.Length - 1

            If i = 4 Then
                'Address2 special case
                '"na" = unchanged, anything else (including blank) = changed
                If updatedFields(4) <> "na" Then
                    noChange = False
                    Exit For
                End If
            Else
                'Other fields: check if not blank
                If Not String.IsNullOrWhiteSpace(updatedFields(i)) Then
                    noChange = False
                    Exit For
                End If
            End If
        Next

        If noChange Then
            MessageBox.Show("No changes were made.", "EBaT Customer Edit", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        EditCustAcctLogic(_cust, updatedFields)     'EBaT_Logic

        'Records user data changes
        Audit.LogCustomerEdit(_cust.username, existingAcctFields, enteredFields)

        'Opens EditConfirmDia.vb as a dialog box
        Dim editConfirm As New EditConfirmDia(_cust, updatedFields)
        editConfirm.ShowDialog()
        allowClose = True
        Me.Close()
    End Sub

    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        'Takes user to CustMenu.vb
        'Records user log out
        Audit.LogUserLogout(_cust.username)

        Dim custMenu As New frmCustMenu(_cust)
        custMenu.Show()
        allowClose = True
        Me.Close()
    End Sub

    Private Sub NumsOnly(sender As Object, e As KeyPressEventArgs) Handles txtZip.KeyPress, txtPhone.KeyPress
        'Allow digits only for ZIP and Telephone fields
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub

    Private Sub ShowPassRequirements(sender As Object, e As EventArgs) Handles txtPass.GotFocus, txtPass.MouseHover, txtRePass.GotFocus, txtRePass.MouseHover
        'MouseHover and GotFocus events to show password requirements for Password and RePassword fields
        Dim passFields As Control = DirectCast(sender, Control)

        tipPassReq.Show("**Must have at least 1 lowercase letter, 1 UPPERCASE letter, 1 number, and a minimum of 8 characters**",
                        passFields, 0, passFields.Height)
    End Sub

    Private Sub HidePassRequirements(sender As Object, e As EventArgs) Handles txtPass.LostFocus, txtPass.MouseLeave, txtRePass.LostFocus, txtRePass.MouseLeave
        'MouseLeave and LostFocus events to hide password requirements for Password and RePassword fields
        tipPassReq.Hide(DirectCast(sender, Control))
    End Sub

    Private Sub PasswordsMatch(sender As Object, e As EventArgs) Handles txtPass.TextChanged, txtRePass.TextChanged
        'TextChanged Event for Validation Visuals for Password and RePassword fields
        MeetPassReqs(lblLower, lblUpper, lblNum, lbl8Char, txtPass.Text)        'EBaT_Logic.Validation
        PassMatchUI(txtPass.Text, txtRePass.Text, lblPassMatch)                 'EBaT_Logic.Validation
    End Sub

    Private Sub txtPhoneCursorStart(sender As Object, e As EventArgs) Handles txtPhone.GotFocus, txtPhone.Click
        'Sets cursor to start of phone field
        If txtPhone.MaskCompleted Then
        Else
            txtPhone.SelectionStart = 0
        End If
    End Sub

    Private Sub btnPassDisplay_Click(sender As Object, e As EventArgs) Handles btnPassDisplay.Click
        'Button that show/hide characters in password and repassword fields
        If txtPass.PasswordChar = ControlChars.NullChar Then
            ' Hide password
            txtPass.PasswordChar = "*"c
            txtRePass.PasswordChar = "*"c
            btnPassDisplay.Image = passwordHidden
        Else
            ' Show password
            txtPass.PasswordChar = ControlChars.NullChar
            txtRePass.PasswordChar = ControlChars.NullChar
            btnPassDisplay.Image = passwordPreviewCorrect
        End If
    End Sub

    Private Sub ConfirmExit(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If Not allowClose Then
            If Not ExitMessage() Then       'EBaT_Logic.Logic
                e.Cancel = True
            End If
            Application.Exit()
        End If
    End Sub
End Class
