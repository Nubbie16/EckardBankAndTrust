'Visual BASIC Program File
'@author: Cody Eckard
'@date: 10/9/25
'@Solution Name: EckardBankTrust.sln
'@Project Name: EBaT_Models
'@File Name: CustData.vb

Public Class CustData

    Public Property username As String
    Public Property first As String
    Public Property last As String
    Public Property address1 As String
    Public Property address2 As String
    Public Property city As String
    Public Property st As String
    Public Property zip As String
    Public Property phone As String
    Public Property password As String
    Public Property account As CustAcct

    'Default Constructor
    Public Sub New()
    End Sub

    'Constructor
    Public Sub New(ByVal user As String, ByVal firstN As String, ByVal lastN As String, ByVal add1 As String, ByVal add2 As String,
                   ByVal cty As String, ByVal state As String, ByVal zipCode As String, ByVal phoneNum As String,
                    ByVal pass As String, ByVal acct As CustAcct)

        username = user
        first = firstN
        last = lastN
        address1 = add1
        address2 = add2
        city = cty
        st = state
        zip = zipCode
        phone = phoneNum
        password = pass
        account = acct
    End Sub

    Public Overrides Function ToString() As String
        Return $"{first} {last} / {username} / {account.acctNumber}"
    End Function

    Public Function FormatPhone(ByVal phone As String) As String
        'Function to Format Phone Number. Used in frmAcctSummary.
        Dim formattedPhone As String = phone

        formattedPhone = formattedPhone.Insert(6, "-")
        formattedPhone = formattedPhone.Insert(3, ") ")
        formattedPhone = formattedPhone.Insert(0, "(")

        Return formattedPhone
    End Function

    Public Function FormatAddress(ByVal add1 As String, ByVal add2 As String, ByVal city As String, ByVal state As String, ByVal zip As String) As String
        'Function to Format Full Address. Used in frmNAcctSummary.
        Dim fullAdd As String

        If add2 <> "" Then
            fullAdd = add1.ToUpper() & ControlChars.NewLine & add2.ToUpper() &
                ControlChars.NewLine & city.ToUpper() & ", " & state & " " & zip
        Else
            fullAdd = add1.ToUpper() & ControlChars.NewLine & city.ToUpper() & ", " & state & " " & zip
        End If
        Return fullAdd
    End Function
End Class
