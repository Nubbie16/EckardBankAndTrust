'Visual BASIC Program File
'@author: Cody Eckard
'@date: 9/4/2025
'@Solution Name: EckardBankTrust.sln
'@Project Name: EBaT_UI
'@File Name: CustMenu.vb

Imports EBaT_Audit.EBaT_Audit
Imports EBaT_Logic, EBaT_Models

Public Class frmCustMenu

    Private _cust As CustData

    Public Sub New(ByVal user As CustData)
        ' This call is required by the designer.
        InitializeComponent()
        _cust = user
    End Sub

    Private Sub frmCustMenu_Load(sender As Object, e As EventArgs) Handles Me.Load
        'sets welcome message and pulls in the logged in users information
        Dim filePath As String = "C:\EckardBankTrustData\RawData.txt"
        Dim updatedCust As CustData = LoadCustDataLogic(filePath, _cust.username)       'EBaT_Logic.Logic

        If updatedCust IsNot Nothing Then
            _cust = updatedCust
        End If

        lblWelMess.Text = "Welcome back, " & _cust.first & "." & ControlChars.NewLine &
            ControlChars.NewLine & "What would you like to do?"
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        'Takes user to CustEdit.vb
        Dim custEdit As New frmCustEdit(_cust)
        custEdit.Show()
        Me.Hide()
    End Sub

    Private Sub btnMoney_Click(sender As Object, e As EventArgs) Handles btnMoney.Click
        'Takes user to MoveMoney.vb
        Dim moveMoney As New frmMoveMoney(_cust)
        moveMoney.Show()
        Me.Hide()
    End Sub

    Private Sub btnSummary_Click(sender As Object, e As EventArgs) Handles btnSummary.Click
        'Takes user to frmAcctSummary.vb
        Dim acctSummary As New frmAcctSummary(_cust)
        acctSummary.Show()
        Me.Hide()
    End Sub

    Private Sub btnLogOut_Click(sender As Object, e As EventArgs) Handles btnLogOut.Click
        'Takes user to MainMenu.vb
        Dim result As DialogResult

        result = MessageBox.Show("Are you sure you want to Log Out?", "EBaT Confirm Log Out",
                                 MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            'Records user log out
            Audit.LogUserLogout(_cust.username)

            Dim mainMenu As New frmMainMenu()
            mainMenu.Show()
            allowClose = True
            Me.Close()
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