'Visual BASIC Program File
'@author: Cody Eckard
'@date: 12/11/2025
'@Solution Name: EckardBankTrust.sln
'@Project Name: EBaT_Logic
'@File Name: Audit.vb

Imports System.IO
Imports System.Text
Namespace EBaT_Audit

    Public Class Audit

        Private Shared ReadOnly DataFolder As String = "C:\EckardBankTrustData"     'Folder path

        Private Shared ReadOnly LogPath As String = Path.Combine(DataFolder, "AuditLog.txt")        'path to audit log file

        Public Shared Sub Log(eventType As String, details As String)
            'Writes a time-stamped audit entry to C:\EckardBankTrustData\AuditLog.txt

            Dim entry As String = $"{DateTime.Now:yyyy-MM-dd HH:mm:ss} | {eventType,-20} | {details}"

            If Not Directory.Exists(DataFolder) Then            'Ensure the folder exists
                Directory.CreateDirectory(DataFolder)
            End If

            SyncLock GetType(Audit)     'ensures file is accessed safely
                File.AppendAllText(LogPath, entry & Environment.NewLine)
            End SyncLock

        End Sub

        Public Shared Sub LogNewAccount(username As String, accountNumber As String)
            'audit entry for new account creation.
            Dim entry As String = $"{DateTime.Now:yyyy-MM-dd HH:mm:ss} | New Account | Username: {username} | Account Number: {accountNumber}"
            File.AppendAllText(LogPath, entry & Environment.NewLine)
        End Sub

        Public Shared Sub LogCustomerEdit(username As String, oldFields() As String, newFields() As String)
            'audit entry for user data edit.
            Dim logBuilder As New StringBuilder()
            logBuilder.Append($"{DateTime.Now:yyyy-MM-dd HH:mm:ss} | User Edited: {username} | Changes:")

            'Labels for reference
            Dim fieldLabels() As String = {"Username", "First Name", "Last Name", "Address1", "Address2",
                                   "City", "State", "ZIP", "Phone", "Password"}

            For i As Integer = 0 To Math.Min(oldFields.Length - 1, newFields.Length - 1)
                Dim oldVal As String = If(oldFields(i) IsNot Nothing, oldFields(i).Trim(), "")
                Dim newVal As String = If(newFields(i) IsNot Nothing, newFields(i).Trim(), "")

                'Skip unchanged fields
                Dim isChanged As Boolean = False

                If fieldLabels(i) = "Address2" Then
                    'Special case: allow logging only if old value had data and new value is different (even blank)
                    If oldVal <> newVal Then
                        isChanged = True
                    End If
                Else
                    If newVal <> "" AndAlso oldVal <> newVal Then
                        isChanged = True
                    End If
                End If

                If isChanged Then
                    'Mask password field
                    Dim displayOld As String = If(fieldLabels(i) = "Password", "****", oldVal)
                    Dim displayNew As String = If(fieldLabels(i) = "Password", "****", newVal)
                    logBuilder.Append($" [{fieldLabels(i)}: '{displayOld}' -> '{displayNew}']")
                End If
            Next

            Dim auditFile As String = "C:\EckardBankTrustData\AuditLog.txt"
            Using writer As New StreamWriter(auditFile, True)
                writer.WriteLine(logBuilder.ToString())
            End Using
        End Sub

        Public Shared Sub LogBalanceChange(username As String, oldBalance As Decimal, newBalance As Decimal, transactionType As String, method As String, amountEntered As Decimal)
            'audit entry for user balance transaction.
            Dim logEntry As String
            Dim timestamp As String = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")

            If transactionType.Equals("Deposit", StringComparison.OrdinalIgnoreCase) Then
                logEntry = $"User: {username} | Deposit via {method} | {amountEntered:C2} | Old Balance: {oldBalance:C2} -> New Balance: {newBalance:C2}"
            Else
                logEntry = $"User: {username} | Withdrawal | {amountEntered:C2} | Old Balance: {oldBalance:C2} -> New Balance: {newBalance:C2}"
            End If

            Log("Balance Change", logEntry)
        End Sub

        Public Shared Sub LogExportSummary(username As String)
            'audit entry for user export action.
            Dim timestamp As String = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")
            Dim logEntry As String = $"User: {username} | Exported Account Summary"
            Log("Customer Action", logEntry)
        End Sub

        Public Shared Sub LogUserLogout(username As String)
            'audit entry for user log out.
            Dim entry As String = $"{DateTime.Now:yyyy-MM-dd HH:mm:ss} | User Logout | Username: {username}"
            File.AppendAllText(LogPath, entry & Environment.NewLine)
        End Sub

        Public Shared Sub LogUserExit(username As String)
            'audit entry for when user closes program.
            Dim entry As String = $"{DateTime.Now:yyyy-MM-dd HH:mm:ss} | Program Closed | Username: {username}"
            File.AppendAllText(LogPath, entry & Environment.NewLine)
        End Sub
    End Class
End Namespace
