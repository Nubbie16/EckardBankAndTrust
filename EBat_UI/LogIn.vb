'Visual BASIC Program File
'@author: Cody Eckard
'@date: 9/9/2025
'@Solution Name: EckardBankTrust.sln
'@Project Name: EBaT_UI
'@File Name: LogIn.vb

Imports EBaT_Audit.EBaT_Audit
Imports EBaT_Logic, EBaT_Models

Public Class frmLogIn

    Dim _cust As CustData
    Dim _acct As CustAcct

    Private Sub frmLogIn_Load(sender As Object, e As EventArgs) Handles Me.Load
        'sets default "Show Password" button image
        btnPassDisplay.Image = passwordHidden
    End Sub

    Private Sub btnLogIn_Click(sender As Object, e As EventArgs) Handles btnLogIn.Click
        'Logs user into their account
        Dim strUsername As String = txtUser.Text.Trim()
        Dim strPassword As String = txtPass.Text.Trim()

        'Check for empty input
        If strUsername = "" OrElse strPassword = "" Then
            MessageBox.Show("Username or Password is Missing. Please Try Again",
                        "EBat Log In Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

            'Records attempt as failed login
            Audit.Log("Login Failed", $"Empty username or password attempt.")
            Exit Sub
        End If

        _cust = ValidateLogIn(strUsername, strPassword)     'EBaT_Logic.Validation

        If _cust Is Nothing Then
            MessageBox.Show("Username or Password is Incorrect. Please Try Again",
                        "EBat Log In Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtPass.Clear()

            'Records attempt as failed login
            Audit.Log("Login Failed", $"Username='{strUsername}'")
            Exit Sub
        End If

        'Records attempt as successful login
        Audit.Log("Login Success", $"Username='{strUsername}'")

        'Takes user to CustMenu.vb
        Dim custMenu As New frmCustMenu(_cust)
        custMenu.Show()
        allowClose = True
        Me.Close()
    End Sub

    Private Sub btnPassDisplay_Click(sender As Object, e As EventArgs) Handles btnPassDisplay.Click
        'Button that show/hide characters in password and repassword fields
        If txtPass.PasswordChar = ControlChars.NullChar Then
            ' Hide password
            txtPass.PasswordChar = "*"c
            btnPassDisplay.Image = My.Resources.passwordHidden
        Else
            ' Show password
            txtPass.PasswordChar = ControlChars.NullChar
            btnPassDisplay.Image = My.Resources.passwordPreviewCorrect
        End If
    End Sub

    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        'Takes user to MainMenu.vb
        Dim mainMenu As New frmMainMenu()
        mainMenu.Show()
        allowClose = True
        Me.Close()
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