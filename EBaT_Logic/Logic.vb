'Visual BASIC Program File
'@author: Cody Eckard
'@date: 9/18/25
'@Solution Name: EckardBankTrust.sln
'@Project Name: EBaT_Logic
'@File Name: Logic.vb

Imports System.IO
Imports System.Windows.Forms
Imports EBaT_DataAccess, EBaT_Models

Public Module Logic

    'Variable used in ExitMessage()
    Public exitConfirmed As Boolean = False

    Public Function GenAcctNum() As Integer
        'Generate random account number
        Dim randGen As New Random
        Dim acctNum As Integer = randGen.Next(100000000, 999999999)

        Return acctNum
    End Function

    Public Function GetUpdatedFields(ByVal existingFields() As String, ByVal enteredFields() As String) As String()
        'determine what fields are to be updated in frmCustEdit
        Dim updatedFields(existingFields.Length - 1) As String

        If enteredFields(4).Trim() <> existingFields(4).Trim() Then     'Updates Address2 field if user does not have an unit number anymore
            updatedFields(4) = enteredFields(4).Trim()
        Else
            For i As Integer = 1 To existingFields.Length - 1
                If i = 4 Then
                    updatedFields(i) = "na"
                    Continue For
                Else
                    If enteredFields(i).Trim() <> existingFields(i).Trim() Then
                        updatedFields(i) = enteredFields(i).Trim()
                    Else
                        updatedFields(i) = ""
                    End If
                End If
            Next
        End If

        Return updatedFields
    End Function

    Public Function LoadCustDataLogic(filePath As String, username As String) As CustData
        'pulls in customer data
        Return LoadCustDataDataAccess(filePath, username)       'EBaT_DataAccess.DataAccess
    End Function

    Public Function ExitMessage() As Boolean
        'Confirmation MessageBox to confirm program exit when Close(x) is clicked. Used in all UI forms (except EditConfirmDia.vb)
        If exitConfirmed Then Return True

        Dim result As DialogResult = MessageBox.Show("Are you sure you want to quit?", "EBaT Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            exitConfirmed = True
            Application.Exit()
            Return True
        Else
            Return False
        End If
    End Function

    Public Sub DisplayUpdate(UpdateData As TextBox, updatedFields() As String)
        'input updated data in EditConfirmDia.vb textbox.
        Dim fieldLabels() As String = {"First Name: ", "Last Name: ", "Address: ", "Suite/Apartment/Building: ",
            "City: ", "State: ", "ZIP: ", "Telephone Number: ", "Password: "}

        For index As Integer = 1 To updatedFields.Length - 1

            Dim fieldValue As String = updatedFields(index)
            Dim labelIndex As Integer = index - 1

            'Handle Address2 ("na")
            If index = 4 Then                  'this is Address2
                If fieldValue = "na" Then
                    Continue For               'skip showing Address2 if "na"
                End If
            Else
                'All other fields skipped if unchanged
                If String.IsNullOrWhiteSpace(fieldValue) Then
                    Continue For
                End If
            End If

            'Always displays password as asterisks
            If index = 9 Then
                fieldValue = New String("*"c, 8)
            End If

            'Adds updated field to textbox
            UpdateData.AppendText(fieldLabels(labelIndex) & fieldValue & ControlChars.NewLine)
        Next
    End Sub

    Public Sub CreateNewAcctLogic(ByVal data As CustData)
        'Sub to add user data.
        CreateNewAcctDataAccess(data)           'EBaT_DataAccess.DataAccess

        MessageBox.Show("Your account has been created." & ControlChars.NewLine & ControlChars.NewLine & "Your account number is: " &
          data.account.acctNumber & ControlChars.NewLine & ControlChars.NewLine & "Please insert the opening balance of " &
          data.account.acctBal.ToString("C2") & " into the slot.", "Welcome to EBaT!",
                      MessageBoxButtons.OK)
    End Sub

    Public Sub EditCustAcctLogic(ByVal cust As CustData, ByVal updated As String())
        'Sub to update user data. Used in frmCustEdit.
        EditCustAcctDataAccess(cust, updated)           'EBaT_DataAccess.DataAccess
    End Sub

    Public Sub BalanceUpdateLogic(ByVal cust As CustData, ByVal newBal As Double)
        'Sub to call BalanceUpdateDataAccess() to update customer account balance.
        BalanceUpdateDataAccess(cust, newBal)           'EBaT_DataAccess.DataAccess
    End Sub

    Public Sub ExportSummaryLogic(ByVal cust As CustData)
        'Sub to call ExportSummaryDataAccess() to export user data to text file.
        ExportSummaryDataAccess(cust)           'EBaT_DataAccess.DataAccess
    End Sub

    Public Sub EnsureRawDataExists()
        'ensure RawData.txt exists. If not, file is created with test data
        Try
            Dim folderPath As String = "C:\EckardBankTrustData"
            Dim filePath As String = Path.Combine(folderPath, "RawData.txt")

            'Create folder if missing
            If Not Directory.Exists(folderPath) Then
                Directory.CreateDirectory(folderPath)
            End If

            If File.Exists(filePath) Then
                Exit Sub
            End If

            'TEST DATA
            Dim testLines As New List(Of String)
            testLines.Add("USERNAME1|JOHN|SMITH|123 MAIN ST||GREENVILLE|NC|27834|2525551234|Passw0rd|100000001|250.00|" &
                          DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"))
            testLines.Add("USERNAME2|JANE|DOE|456 ELM ST|APT 2A|RALEIGH|NC|27601|9194447788|Passw0rd!|100000002|500.00|" &
                          DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"))
            testLines.Add("USERNAME3|STEVEN|WILLIAMS|789 SPRUCE ST|STE 2|HICKORY|NC|28601|9194447788|Passw0rd!|100000003|1000.00|" &
                          DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"))
            'Creates file
            File.WriteAllLines(filePath, testLines)

        Catch ex As Exception
            MessageBox.Show($"Error initializing RawData.txt: {ex.Message}", "EBaT Startup Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Module
