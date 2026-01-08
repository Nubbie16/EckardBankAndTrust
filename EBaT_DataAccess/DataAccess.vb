'Visual BASIC Program File
'@author: Cody Eckard
'@date: 9/18/25
'@Solution Name: EckardBankTrust.sln
'@Project Name: EBaT_DataAccess
'@File Name: DataAccess.vb

Imports System.IO
Imports EBaT_Models
Imports System.Windows.Forms

Public Module DataAccess

    Public Function UniqueUsernameDataAccess(ByVal user As String) As Boolean
        'Function for Unique Username visual in frmNewAcct
        Dim filePath As String = "C:\EckardBankTrustData\RawData.txt"

        Dim lines() As String = File.ReadAllLines(filePath)

        For Each line As String In lines
            Dim parts() As String = line.Split("|"c)
            If parts.Length > 0 Then
                If parts(0).Trim().Equals(user.Trim(), StringComparison.OrdinalIgnoreCase) Then
                    Return False        'Username already exists
                End If
            End If
        Next
        Return True     'username not found(unique)
    End Function

    Public Function ValidateLogInDataAccess(username As String, password As String) As CustData
        'Function to confirm log in creditionals match. Used in LogIn.vb from EBaT_Logic.validation.vb
        Dim filePath As String = "C:\EckardBankTrustData\RawData.txt"

        For Each line In File.ReadLines(filePath)
            If String.IsNullOrWhiteSpace(line) Then
                Continue For
            End If

            Dim parts = line.Split("|"c).Select(Function(p) p.Trim()).ToArray()

            If parts.Length < 13 Then Continue For

            'Match username (case-insensitive) and password (case-sensitive)
            If parts(0).Equals(username.Trim(), StringComparison.OrdinalIgnoreCase) AndAlso
           parts(9) = password Then

                Dim acctBal As Double
                Double.TryParse(parts(11), acctBal)

                Dim acct As New CustAcct(parts(10), acctBal, Nothing)
                Dim cust As New CustData(parts(0), parts(1), parts(2), parts(3), parts(4),
                parts(5), parts(6), parts(7), parts(8), parts(9), acct)

                acct.owner = cust
                Return cust
            End If
        Next
        Return Nothing      'log in fail
    End Function

    Public Function LoadCustDataDataAccess(filePath As String, username As String) As CustData
        'Function to return CustData from RawData.txt.
        For Each line As String In File.ReadLines(filePath)
            If String.IsNullOrWhiteSpace(line) Then
                Continue For
            End If

            Dim parts() As String = line.Split("|"c)

            If parts(0).Trim().Equals(username, StringComparison.OrdinalIgnoreCase) Then
                Dim acctBal As Double
                Double.TryParse(parts(11).Trim(), acctBal)

                Dim acct As New CustAcct(parts(10).Trim(), acctBal, Nothing)
                Dim cust As New CustData(parts(0).Trim(), parts(1).Trim(), parts(2).Trim(),
                                        parts(3).Trim(), parts(4).Trim(), parts(5).Trim(),
                                        parts(6).Trim(), parts(7).Trim(), parts(8).Trim(),
                                        parts(9).Trim(), acct)
                acct.owner = cust
                Return cust     'user found
            End If
        Next
        Return Nothing      'user not found
    End Function

    Public Sub EditCustAcctDataAccess(cust As CustData, newData As String())
        'Sub for existing data change access. Used in EditCustAcctLogic() sub in EBaT_Logic.Logic
        Dim filePath As String = "C:\EckardBankTrustData\RawData.txt"
        Dim tempFilePath As String = filePath & ".tmp"

        Dim lines = File.ReadAllLines(filePath)
        Dim updated As Boolean = False

        Using writer As New StreamWriter(tempFilePath, False)               'Write updated lines to temp file
            For Each line As String In lines
                If String.IsNullOrWhiteSpace(line) Then
                    writer.WriteLine(line)
                    Continue For
                End If

                Dim parts As String() = line.Split("|"c)

                'Match username and update fields
                If Not updated AndAlso parts(0).Trim().Equals(cust.username.Trim(), StringComparison.OrdinalIgnoreCase) Then
                    For i As Integer = 1 To 9
                        ' Address2 special case
                        If i = 4 Then
                            If newData(4) = "na" Then               'skip updating Address2 entirely
                                Continue For
                            End If
                            parts(4) = newData(4)
                            Continue For
                        End If

                        'Normal updates (other fields): only update when not blank
                        If Not String.IsNullOrWhiteSpace(newData(i)) Then
                            parts(i) = newData(i)
                        End If

                    Next

                    If cust.account IsNot Nothing AndAlso Not String.IsNullOrWhiteSpace(cust.account.acctNumber) Then
                        parts(10) = cust.account.acctNumber
                        parts(11) = cust.account.acctBal.ToString("F2")
                    End If

                    'Timestamp update
                    parts(12) = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")
                    updated = True
                End If

                writer.WriteLine(String.Join("|", parts))
            Next
        End Using

        'Replace original file
        If updated Then
            File.Delete(filePath)              'Delete the old file
            File.Move(tempFilePath, filePath)  'Move temp file into place
        Else
            File.Delete(tempFilePath)          'No changes, delete temp
        End If
    End Sub

    Public Sub CreateNewAcctDataAccess(ByVal newCust As CustData)
        'Sub for New Data input access. Used in CreateNewAcctLogic() sub in EBaT_Logic.Logic
        Dim folderPath As String = "C:\EckardBankTrustData"
        Dim filePath As String = Path.Combine(folderPath, "RawData.txt")

        If Not Directory.Exists(folderPath) Then
            Directory.CreateDirectory(folderPath)
        End If

        Using fs As New FileStream(filePath, FileMode.Append, FileAccess.Write,
                                   FileShare.ReadWrite)
            Using writer As New StreamWriter(fs)

                Dim acctNum As String = If(newCust.account?.acctNumber, "")
                Dim acctBal As String = If(newCust.account?.acctBal.ToString(), "")
                Dim timeStamp As String = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")

                Dim record As String = String.Join("|", {newCust.username, newCust.first, newCust.last,
                             newCust.address1, newCust.address2, newCust.city, newCust.st, newCust.zip,
                             newCust.phone, newCust.password, acctNum, acctBal, timeStamp})

                writer.WriteLine(record)
            End Using
        End Using
    End Sub

    Public Sub BalanceUpdateDataAccess(ByVal cust As CustData, ByVal newBal As Double)
        'Sub that updates user balance
        Dim filePath As String = "C:\EckardBankTrustData\RawData.txt"
        Dim tempPath As String = filePath & ".tmp"
        Dim lines = File.ReadAllLines(filePath)
        Dim updated As Boolean = False

        Using writer As New StreamWriter(tempPath, False)

            For Each line As String In lines
                If String.IsNullOrWhiteSpace(line) Then
                    writer.WriteLine(line)
                    Continue For
                End If

                Dim parts As String() = line.Split("|"c)

                If parts.Length < 12 Then
                    writer.WriteLine(line)
                    Continue For
                End If

                Dim usernameInFile As String = parts(0).Trim()

                If Not updated AndAlso usernameInFile.Equals(cust.username.Trim(), StringComparison.OrdinalIgnoreCase) Then

                    parts(11) = newBal
                    writer.WriteLine(String.Join("|", parts))
                    updated = True
                    Continue For
                End If
                writer.WriteLine(line)
            Next
        End Using
        'Replace original file with updated file
        File.Delete(filePath)
        File.Move(tempPath, filePath)
    End Sub

    Public Sub ExportSummaryDataAccess(cust As CustData)
        'Exports user data as .txt file to user desktop
        Try
            Dim desktopPath As String = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
            Dim safeLastName As String = MakeSafeFileName(cust.last)
            Dim safeFirstName As String = MakeSafeFileName(cust.first)
            Dim fileName As String = $"{safeLastName}_{safeFirstName}.txt"
            Dim filePath As String = Path.Combine(desktopPath, fileName)

            Dim lines As New List(Of String)
            lines.Add($"Username: {cust.username}")
            lines.Add($"First Name: {cust.first}")
            lines.Add($"Last Name: {cust.last}")
            lines.Add("Address:")
            lines.Add(cust.FormatAddress(cust.address1, cust.address2, cust.city, cust.st, cust.zip))
            lines.Add($"Phone: {cust.FormatPhone(cust.phone)}")

            If cust.account IsNot Nothing Then
                lines.Add($"Account Number: {cust.account.acctNumber}")
                lines.Add($"Account Balance: {cust.account.acctBal:C}")
            Else
                lines.Add("Account: None")
            End If

            lines.Add($"Exported on: {DateTime.Now:yyyy-MM-dd HH:mm:ss}")

            File.WriteAllLines(filePath, lines)

            MessageBox.Show($"Data successfully exported to: {filePath}", "EBaT Export Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show($"Failed to export data. Error: {ex.Message}", "EBaT Export Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Function MakeSafeFileName(name As String) As String
        'ensures created file does not have any unallowed characters in name
        Dim invalidChars = Path.GetInvalidFileNameChars()
        Dim safeName As String = String.Concat(name.Where(Function(ch) Not invalidChars.Contains(ch)))
        Return If(String.IsNullOrWhiteSpace(safeName), "Unknown", safeName)
    End Function
End Module