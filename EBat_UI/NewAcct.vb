'Visual BASIC Program File
'@author: Cody Eckard
'@date: 9/4/2025
'@Solution Name: EckardBankTrust.sln
'@Project Name: EBaT_UI
'@File Name: NewAcct.vb

Imports EBaT_Audit.EBaT_Audit
Imports EBaT_Logic, EBaT_Models

Public Class frmNewAcct

    Private Sub frmNewAcct_Load(sender As Object, e As EventArgs) Handles Me.Load
        'sets initial values as the form loads
        'Sets ToolTips
        Dim passLabels() As Label = {lblLower, lblUpper, lblNum, lbl8Char}
        PassLabelToolTips(passLabels, tipPasswordRules)         'EBaT_Validation

        'sets default visual validation 
        lblPassMatch.Text = "Password Needed"
        lblPassMatch.ForeColor = Color.Red
        lblUserExist.Text = "Username Needed"
        lblUserExist.ForeColor = Color.Red

        'sets default "Show Password" button image
        btnPassDisplay.Image = passwordHidden
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        'Button to create new account
        Dim newAcctFields() As Control = {txtFirst, txtLast, txtAddress1, txtCity,
        txtZip, txtOpenBal, txtUser, txtPass, txtRePass}

        Dim fieldsFilled() As Boolean = NewAcctFieldsFilled(newAcctFields)      'EBaT_Validation
        Dim boolPassMatch As Boolean

        ' Resets BackColor
        For Each ctrl As Control In newAcctFields
            ctrl.BackColor = Color.White
        Next
        cmbStates.BackColor = Color.White

        'Highlights empty fields
        Dim index As Integer = 0
        Dim boolFilled As Boolean = True
        For Each field As Boolean In fieldsFilled
            If field = False Then
                newAcctFields(index).BackColor = Color.Wheat
                boolFilled = False
            End If
            index += 1
        Next
        If txtPhone.MaskCompleted = False Then
            txtPhone.BackColor = Color.Wheat
            boolFilled = False
        End If
        Dim boolState As Boolean = True
        If cmbStates.SelectedItem Is Nothing OrElse cmbStates.SelectedItem.ToString().Trim() = "" Then
            boolState = False
            cmbStates.BackColor = Color.Wheat
        End If

        boolPassMatch = PassMatch(txtPass, txtRePass)        'EBaT_Logic.Validation

        Dim decOpenBal As Decimal
        Decimal.TryParse(txtOpenBal.Text, decOpenBal)

        'Validation flags
        Dim randGen As New Random
        Dim boolPhone As Boolean
        Dim boolZip As Boolean
        Dim boolValidPassword As Boolean

        boolZip = ValidZip(txtZip)        'EBaT_Logic.Validation
        boolPhone = ValidPhone(txtPhone)        'EBaT_Logic.Validation

        Dim strPass As String = txtPass.Text
        boolValidPassword = PassValidate(strPass)        'EBaT_Logic.Validation

        'MessageBoxes for incorrect or missing data
        If boolFilled = False Then
            MessageBox.Show("Please provide information for the highlighted fields.", "EBaT Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
        If boolState = False Then
            MessageBox.Show("Please select a state for your address.", "EBaT Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
        If txtZip.Text <> "" Then
            If boolZip = False Then
                MessageBox.Show("Please enter 5-digit Zip code.", "EBaT Invalid ZIP Code", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        End If
        If txtPhone.Text <> "" Then
            If boolPhone = False Then
                MessageBox.Show("Please enter 10-digit phone number.", "EBaT Invalid Phone Number", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        End If
        If boolValidPassword = False Then
            MessageBox.Show("Password does not meet requirements. Hover over squares for more information",
                            "EBaT Incorrect Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
        If boolPassMatch = False Then
            MessageBox.Show("Passwords do not match.", "EBaT Incorrect Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
        If UniqueUsernameLogic(txtUser.Text) = False Then       'EBaT_Logic.Validation
            MessageBox.Show("Username already Exists. Please choose something else.", "EBaT Incorrect Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If

        'Final validation before creating customer object
        If boolFilled AndAlso boolState AndAlso boolZip AndAlso boolPhone AndAlso boolValidPassword AndAlso boolPassMatch AndAlso UniqueUsernameLogic(txtUser.Text) Then    'EBaT_Logic.Validation

            Dim newCust As CustData = New CustData()
            Dim newAcct As CustAcct = New CustAcct()
            newCust.account = newAcct

            newCust.username = txtUser.Text.ToUpper()
            newCust.first = txtFirst.Text.ToUpper()
            newCust.last = txtLast.Text.ToUpper()
            newCust.address1 = txtAddress1.Text.ToUpper()
            newCust.address2 = txtAddress2.Text.ToUpper()
            newCust.city = txtCity.Text.ToUpper()
            newCust.st = cmbStates.SelectedItem.ToString()
            newCust.zip = txtZip.Text
            newCust.phone = txtPhone.Text
            newCust.password = txtPass.Text
            newCust.account.acctBal = decOpenBal
            'Creates random 9-digit account number
            newCust.account.acctNumber = GenAcctNum().ToString    'EBaT_Logic.Logic
            'Adds data to RawData.txt file
            CreateNewAcctLogic(newCust)     'EBaT_Logic.Logic
            'Records Account Creation
            Audit.LogNewAccount(newCust.username, newCust.account.acctNumber)
            'Takes user to LogIn.vb
            Dim logIn As New frmLogIn()
            logIn.Show()
            allowClose = True
            Me.Close()
        Else
            Exit Sub
        End If
    End Sub

    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        'Takes user to MainMenu.vb
        Dim mainMenu As New frmMainMenu()

        mainMenu.Show()
        allowClose = True
        Me.Close()
    End Sub

    Private Sub txtOpenBal_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtOpenBal.KeyPress
        'Allow digits, decimal point, control keys in Opening Balance field
        Dim txt As String = txtOpenBal.Text

        If Char.IsControl(e.KeyChar) Then
            Exit Sub
        End If

        If Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = "."c) Then
            e.Handled = True
            Exit Sub
        End If

        'Prevent multiple decimal points
        If e.KeyChar = "."c AndAlso txt.Contains("."c) Then
            e.Handled = True
            Exit Sub
        End If

        'If decimal exists, enforce two-digit limit
        If txt.Contains("."c) Then
            Dim index As Integer = txt.IndexOf("."c)
            If txt.Length - index >= 3 Then
                If Char.IsDigit(e.KeyChar) Then
                    e.Handled = True
                End If
            End If
        End If
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

    Public Sub PasswordsMatch(sender As Object, e As EventArgs) Handles txtPass.TextChanged, txtRePass.TextChanged
        'TextChanged Event for Validation Visuals for Password and RePassword fields
        MeetPassReqs(lblLower, lblUpper, lblNum, lbl8Char, txtPass.Text)        'EBaT_Logic.Validation
        PassMatchUI(txtPass.Text, txtRePass.Text, lblPassMatch)                 'EBaT_Logic.Validation
    End Sub

    Public Sub UniqueUsernameVisual(sender As Object, e As EventArgs) Handles txtUser.TextChanged
        'TextChanged Event for Validation Visuals for Username field
        Dim unique As Boolean = UniqueUsernameLogic(txtUser.Text)       'EBaT_Logic.Validation

        If txtUser.Text.Trim <> "" Then
            If unique Then
                lblUserExist.Text = "Valid"
                lblUserExist.ForeColor = Color.Green
            Else
                lblUserExist.Text = "Already Exists"
                lblUserExist.ForeColor = Color.Red
            End If
        Else
            lblUserExist.Text = "Username Needed"
            lblUserExist.ForeColor = Color.Red
        End If
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