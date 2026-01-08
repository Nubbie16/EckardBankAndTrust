'Visual BASIC Program File
'@author: Cody Eckard
'@date: 9/2/2025
'@Solution Name: EckardBankTrust.sln
'@Project Name: EBaT_UI
'@File Name: MainMenu.vb

Imports EBaT_Logic

Public Class frmMainMenu

    Private Sub frmMainMenu_Load(sender As Object, e As EventArgs) Handles Me.Load
        'Looks for RawData.txt file and creates a sample file if not found. 
        EnsureRawDataExists()
    End Sub

    Private Sub btnCurrentAcct_Click(sender As Object, e As EventArgs) Handles btnCurrentAcct.Click
        'Takes user to LogIn.vb
        Dim logIn As New frmLogIn()
        logIn.Show()
        Me.Hide()
    End Sub

    Private Sub btnNewAcct_Click(sender As Object, e As EventArgs) Handles btnNewAcct.Click
        'Takes user to NewAcct.vb
        Dim NewAcct As New frmNewAcct()
        NewAcct.Show()
        Me.Hide()
    End Sub

    Private Sub ButtonExit(sender As Object, e As EventArgs) Handles btnExit.Click
        'Triggers CloseExit event
        Me.Close()
    End Sub

    Private Sub CloseExit(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        'Triggers TerminateProgram event
        If Not ExitMessage() Then
            e.Cancel = True
        End If
    End Sub

    Private Sub TerminateProgram(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        'Ensures program terminates when form closes
        Application.Exit()
    End Sub
End Class