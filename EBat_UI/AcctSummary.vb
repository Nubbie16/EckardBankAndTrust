'Visual BASIC Program File
'@author: Cody Eckard
'@date: 9/4/2025
'@Solution Name: EckardBankTrust.sln
'@Project Name: EBaT_UI
'@File Name: AcctSummary.vb

Imports EBaT_Audit.EBaT_Audit
Imports EBaT_Logic, EBaT_Models

Public Class frmAcctSummary

    'Sets "hidden" account number in label
    Const AcctHide As String = "*********"
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

    Private Sub frmAcctSummary_Load(sender As Object, e As EventArgs) Handles Me.Load
        'Pulls in the logged in users information and populates form with user data
        Dim filePath As String = "C:\EckardBankTrustData\RawData.txt"
        Dim updatedCust As CustData = LoadCustDataLogic(filePath, _cust.username)       'EBaT_Logic.Logic

        If updatedCust IsNot Nothing Then
            _cust = updatedCust
        End If

        lblFirst.Text = _cust.first
        lblLast.Text = _cust.last
        lblAddress.Text = _cust.FormatAddress(_cust.address1, _cust.address2, _cust.city, _cust.st, _cust.zip)      'EBaT_Models.CustData
        lblPhone.Text = _cust.FormatPhone(_cust.phone)                                                   'EBaT_Models.CustData
        lblAcctBal.Text = _cust.account.acctBal.ToString("C2")
        'Sets default account number view as hidden
        lblAcctNum.Text = AcctHide
    End Sub

    Private Sub btnShowHideAcct_Click(sender As Object, e As EventArgs) Handles btnShowHideAcct.Click
        'Button that show/hide characters for account number label and updates button text
        If lblAcctNum.Text = AcctHide Then
            lblAcctNum.Text = _cust.account.acctNumber.ToString
            btnShowHideAcct.Text = "&Hide Number"
        Else
            lblAcctNum.Text = AcctHide
            btnShowHideAcct.Text = "&Show Number"
        End If
    End Sub

    Private Sub btnExport_Click(sender As Object, e As EventArgs) Handles btnExport.Click
        'Button to create .txt file with user data to desktop
        ExportSummaryLogic(_cust)        'EBaT_Logic.Logic
        'Records user export
        Audit.LogExportSummary(_cust.username)
    End Sub

    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        'Takes user to CustMenu.vb
        Dim custMenu As New frmCustMenu(_cust)
        custMenu.Show()
        allowClose = True
        Me.Close()
    End Sub

    Private Sub ConfirmExit(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If Not allowClose Then
            If Not ExitMessage() Then            'EBaT_Logic.Logic
                e.Cancel = True
            End If
            Application.Exit()
        End If
    End Sub
End Class