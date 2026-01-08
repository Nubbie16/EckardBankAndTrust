'Visual BASIC Program File
'@author: Cody Eckard
'@date: 10/21/2025
'@Solution Name: EckardBankTrust.sln
'@Project Name: EBaT_UI
'@File Name: EditConfimDia.vb - Formally IncorrectDataDia.vb

Imports EBaT_Logic, EBaT_Models

Public Class EditConfirmDia

    Private _cust As CustData
    Private _updatedFields() As String

    Public Sub New(ByVal user As CustData, ByVal UpdatedFields() As String)
        ' This call is required by the designer.
        InitializeComponent()
        _cust = user
        _updatedFields = UpdatedFields
    End Sub

    Public Sub EditConfirmDia_Load(sender As Object, e As EventArgs) Handles Me.Load
        'display what fields were updated in textbox
        txtUpdateData.Text = String.Empty
        DisplayUpdate(txtUpdateData, _updatedFields)        'EBaT_Logic.Logic
        btnExit.Focus()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'Takes user to CustMenu.vb
        Dim custMenu As New frmCustMenu(_cust)
        custMenu.Show()
        Me.Close()
    End Sub
End Class