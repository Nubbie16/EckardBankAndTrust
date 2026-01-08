'Visual BASIC Program File
'@author: Cody Eckard
'@date: 9/9/2025
'@Solution Name: EckardBankTrust.sln
'@Project Name: EBaT_UI
'@File Name: MoveMoney.vb

Imports EBaT_Audit.EBaT_Audit
Imports EBaT_Logic, EBaT_Models

Public Class frmMoveMoney

    Private _cust As CustData

    Public Sub New(ByVal user As CustData)
        ' This call is required by the designer.
        InitializeComponent()
        _cust = user
    End Sub

    Private Sub frmMoveMoney_Load(sender As Object, e As EventArgs) Handles Me.Load
        'Sets user account balance and displays it
        lblAcctBal.Text = _cust.account.acctBal.ToString("C2")
        lblMoveType.Text = "How much would you like to Deposit:"
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        'Adjusts user balance as requested
        If txtMoney.Text = "" Then
            MessageBox.Show("Please enter an amount", "EBaT Transaction Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Dim decMoney As Decimal
        If Not Decimal.TryParse(txtMoney.Text, decMoney) Then
            MessageBox.Show("Invalid amount entered.", "EBaT Transaction Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Dim oldBalance As Decimal = _cust.account.acctBal
        Dim decNewBal As Decimal = oldBalance
        Dim transactionType As String = ""
        Dim depositMethod As String = ""

        txtMoney.Text = String.Empty

        If radDeposit.Checked Then
            transactionType = "Deposit"

            If radCash.Checked Then
                depositMethod = "Cash"
                Dim result As DialogResult = MessageBox.Show("Please insert cash funds into slot.",
                                                         "EBaT Pending Deposit", MessageBoxButtons.OKCancel)
                If result = DialogResult.Cancel Then
                    MessageBox.Show("Transaction has been canceled.", "EBaT Transaction Canceled",
                                MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                    radDeposit.Checked = True
                    radWithdraw.Checked = False
                    radCash.Checked = False
                    radCheck.Checked = False
                    txtMoney.Text = ""
                    Exit Sub
                End If

            ElseIf radCheck.Checked Then
                depositMethod = "Check"
                Dim result As DialogResult = MessageBox.Show("Please insert signed check into slot.",
                                                         "EBaT Pending Deposit", MessageBoxButtons.OKCancel)
                If result = DialogResult.Cancel Then
                    MessageBox.Show("Transaction has been canceled.", "EBaT Transaction Canceled",
                                MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                    radDeposit.Checked = True
                    radWithdraw.Checked = False
                    radCash.Checked = False
                    radCheck.Checked = False
                    txtMoney.Text = ""
                    Exit Sub
                End If

            Else
                MessageBox.Show("Cash or Check was not selected.", "EBaT Transaction Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            'Perform deposit
            decNewBal = _cust.account.DepositMoney(decMoney, oldBalance)        'EBaT_Models.CustAcct
            MessageBox.Show($"Funds have been moved pending amount verification.{ControlChars.NewLine}{ControlChars.NewLine}Your new balance is {decNewBal:C2}",
                        "EBaT Deposit", MessageBoxButtons.OK)

        ElseIf radWithdraw.Checked Then
            transactionType = "Withdraw"

            If Not OverdraftCheck(decMoney, oldBalance) Then        'EBaT_Logic.Validation
                MessageBox.Show("Not enough funds to withdraw. Please choose a smaller amount.",
                            "EBaT Transaction Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            'Perform withdrawal
            decNewBal = _cust.account.WithdrawMoney(decMoney, oldBalance)       'EBaT_Models.CustAcct
            MessageBox.Show($"Funds have been moved. Please take cash from slot.{ControlChars.NewLine}{ControlChars.NewLine}Your new balance is {decNewBal:C2}",
                        "EBaT Withdrawal", MessageBoxButtons.OK)
        End If

        decNewBal = Math.Round(decNewBal, 2)

        'Records change of user balance
        If decNewBal <> oldBalance Then
            Audit.LogBalanceChange(_cust.username, oldBalance, decNewBal, transactionType, depositMethod, decMoney)
        End If

        'Update account balance and RawData.txt file
        _cust.account.acctBal = decNewBal
        BalanceUpdateLogic(_cust, decNewBal)        'EBaT_Logic.Logic
        lblAcctBal.Text = _cust.account.acctBal.ToString("C2")
    End Sub

    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        'Takes user to CustMenu.vb
        Dim custMenu As New frmCustMenu(_cust)
        custMenu.Show()
        allowClose = True
        Me.Close()
    End Sub

    Private Sub MoveTypeMessageUpdate(sender As Object, e As EventArgs) Handles radDeposit.CheckedChanged, radWithdraw.CheckedChanged
        'Changes message depending which radio button is checked
        If radDeposit.Checked = True Then
            lblMoveType.Text = "How much would you like to DEPOSIT:"
            grpCheckCash.Enabled = True
        Else
            lblMoveType.Text = "How much would you like to WITHDRAW:"
            grpCheckCash.Enabled = False
            radCash.Checked = False
            radCheck.Checked = False
        End If
    End Sub

    Private Sub txtMoney_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtMoney.KeyPress
        'Allow digits, decimal point, control keys in Opening Balance field
        Dim txt As String = txtMoney.Text

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

            'Count digits after decimal
            If txt.Length - index >= 3 Then
                ' Already has 2 decimals → block additional digits
                If Char.IsDigit(e.KeyChar) Then
                    e.Handled = True
                End If
            End If
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

