'Visual BASIC Program File
'@author: Cody Eckard
'@date: 10/9/25
'@Solution Name: EckardBankTrust.sln
'@Project Name: EBaT_Models
'@File Name: CustAcct.vb

Public Class CustAcct

    Public Property acctNumber As String
    Public Property acctBal As Decimal
    Public Property owner As CustData

    'Default Constructor
    Public Sub New()
    End Sub

    'Constructor
    Public Sub New(ByVal acctNum As String, ByVal startBal As Decimal, ByVal cust As CustData)
        acctNumber = acctNum
        acctBal = startBal
        owner = cust
    End Sub

    Public Overrides Function ToString() As String
        Return $"{owner.first} {owner.last} / {acctNumber} / {acctBal}"
    End Function

    Public Function DepositMoney(ByVal deposit As Decimal, ByVal oldBal As Decimal) As Decimal
        'Function to Deposit funds into user account. Used in frmMoveMoney
        Return oldBal + deposit
    End Function

    Public Function WithdrawMoney(ByVal withdraw As Decimal, ByVal oldBal As Decimal) As Decimal
        'Function to withdraw funds from user account. Used in frmMoveMoney
        Return oldBal - withdraw
    End Function
End Class
