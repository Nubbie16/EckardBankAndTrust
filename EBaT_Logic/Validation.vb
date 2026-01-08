'Visual BASIC Program File
'@author: Cody Eckard
'@date: 9/18/25
'@Solution Name: EckardBankTrust.sln
'@Project Name: EBaT_Logic
'@File Name: Validation.vb

Imports System.Drawing
Imports System.Windows.Forms
Imports EBaT_DataAccess, EBaT_Models

Public Module Validation

    'Boolean to allow forms to close without completely terminating the program
    Public allowClose As Boolean = False

    ''FUNCTIONS
    Public Function ValidateLogIn(ByVal username As String, ByVal password As String) As CustData
        'Checks log in credentials
        Return ValidateLogInDataAccess(username, password)      'EBaT_DataAccess.DataAccess
    End Function

    Public Function NewAcctFieldsFilled(newAcctFields() As Control) As Boolean()
        'Function to validate all fields are filled for frmNewAcct
        Dim fieldsFilled(newAcctFields.Length - 1) As Boolean
        For index As Integer = 0 To newAcctFields.Length - 1
            fieldsFilled(index) = newAcctFields(index).Text.Trim <> ""
        Next index
        Return fieldsFilled
    End Function

    Public Function ValidZip(ByVal txtZip As TextBox) As Boolean
        'Function that validates 5-digit Zip. Used in frmNewAcct And frmCustEdit
        Dim boolZip As Boolean = True

        txtZip.BackColor = Color.White       'Reset field color
        If txtZip.Text.Length <> 5 Then
            txtZip.BackColor = Color.Wheat      'highlights when ZIP not valid
            boolZip = False
        End If
        Return boolZip
    End Function

    Public Function ValidPhone(ByVal maskPhone As MaskedTextBox) As Boolean
        'Function that validates 10-digit phone number. Used in frmNewAcct and frmCustEdit
        Dim originalFormat As MaskFormat = maskPhone.TextMaskFormat
        maskPhone.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals

        maskPhone.BackColor = Color.White       'Reset field color
        Dim phoneText As String = maskPhone.Text
        Dim isValid As Boolean = phoneText.Length = 10
        If isValid = False Then
            maskPhone.BackColor = Color.Wheat       'highlights when phone number not valid
        End If
        Return isValid
    End Function

    Public Function PassValidate(ByVal strPass As String) As Boolean
        'Function that validates password. Used in frmNewAcct And frmCustEdit
        Dim passed As Boolean = False
        Dim hasLower As Boolean = False
        Dim hasUpper As Boolean = False
        Dim hasNum As Boolean = False
        Dim has8Char As Boolean = False

        For intChar As Integer = 0 To strPass.Length - 1
            If strPass(intChar) Like "[a-z]" Then hasLower = True
            If strPass(intChar) Like "[A-Z]" Then hasUpper = True
            If strPass(intChar) Like "[0-9]" Then hasNum = True
        Next
        If strPass.Length >= 8 Then
            has8Char = True
        End If
        If hasLower AndAlso hasUpper AndAlso hasNum AndAlso has8Char Then
            passed = True
        End If
        Return passed
    End Function

    Public Function PassMatch(ByVal pass As TextBox, ByVal rePass As TextBox) As Boolean
        'Function that validated password and retyped password matches. Used in frmNewAcct And frmCustEdit
        pass.BackColor = Color.White       'Reset field color
        If pass.Text <> rePass.Text Then
            pass.BackColor = Color.Wheat        'highlights when password fields do not match
            rePass.BackColor = Color.Wheat
            Return False
        Else
            Return True
        End If
    End Function

    Public Function UniqueUsernameLogic(ByVal username As String) As Boolean
        'Function for Unique Username visual in frmNewAcct
        Dim unique As Boolean = True

        unique = UniqueUsernameDataAccess(username)         'EBaT_DataAccess.DataAccess
        Return unique
    End Function

    Public Function OverdraftCheck(ByVal withdraw As Double, ByVal CurrBal As Double) As Boolean
        'Function to confirm user has funds to withdraw from account. Used in frmMoveyMoney.
        Return CurrBal - withdraw >= 0
    End Function

    Public Sub PassMatchUI(ByVal txtPass As String, ByVal txtRePass As String, ByRef lblPassMatch As Label)
        'Sub for password match that displays on UI. Used in frmNewAcct and frmCustEdit
        If txtPass <> txtRePass And Not (txtPass = String.Empty AndAlso txtRePass = String.Empty) Then
            lblPassMatch.Text = "Does Not Match"
            lblPassMatch.ForeColor = Color.Red
        ElseIf txtPass.Trim = String.Empty AndAlso txtRePass.Trim = String.Empty Then
            lblPassMatch.Text = "Password Needed"       'Displays when both txtPass and txtRePass is empty
            lblPassMatch.ForeColor = Color.Red
        Else
            lblPassMatch.Text = "Match"
            lblPassMatch.ForeColor = Color.Green
        End If
    End Sub

    Public Sub MeetPassReqs(ByRef lblLower As Label, ByRef lblUpper As Label, ByRef lblNum As Label,
                            ByRef lbl8Char As Label, ByVal txtPass As String)
        'Sub for password requirements that colors UI box labels. Used in frmNewAcct and frmCustEdit
        Dim passed As Boolean = True
        Dim password As String = txtPass

        lblLower.BackColor = Color.Red
        lblUpper.BackColor = Color.Red
        lblNum.BackColor = Color.Red
        lbl8Char.BackColor = Color.Red

        Dim hasLower As Boolean = False
        Dim hasUpper As Boolean = False
        Dim hasNum As Boolean = False

        For intChar As Integer = 0 To password.Length - 1           'Looks at each character entered
            If password(intChar) Like "[a-z]" Then hasLower = True
            If password(intChar) Like "[A-Z]" Then hasUpper = True
            If password(intChar) Like "[0-9]" Then hasNum = True
        Next

        If hasLower Then
            lblLower.BackColor = Color.Green
        End If
        If hasUpper Then
            lblUpper.BackColor = Color.Green
        End If
        If hasNum Then
            lblNum.BackColor = Color.Green
        End If
        If password.Length >= 8 Then
            lbl8Char.BackColor = Color.Green
        End If

        Dim PassReqs() As Label = {lblLower, lblUpper, lblNum, lbl8Char}
        For Each reqLabel As Label In PassReqs
            If reqLabel.BackColor = Color.Red Then
                passed = False
                Exit For
            End If
        Next
    End Sub

    Public Sub PassLabelToolTips(ByVal labels As Label(), ByVal tipRules As ToolTip)
        'Sub for tooltips to display over password req red labels when missing
        Dim passMessages() As String = {"**Lowercase letter required**", "**Uppercase letter required**",
            "**Number required**", "**8 Characters required**"}

        For i As Integer = 0 To labels.Length - 1           'shows needed requirement when mouse hover for each label
            tipRules.SetToolTip(labels(i), passMessages(i))
        Next
    End Sub
End Module
