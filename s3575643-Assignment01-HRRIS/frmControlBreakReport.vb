Option Explicit On
Option Strict On

Imports System.Data.OleDb
Imports System.IO

' Name: frmReport.vb
' Description: Form for generating reports
' Author: Nguyen Anh Hoang Phuong
' Date: 02/05/2017

Public Class frmControlBreakReport

    Dim oConnection As OleDbConnection = New OleDbConnection(Controller.CONNECTION_STRING)
    Dim ds As New DataSet
    Dim da As OleDbDataAdapter
    Dim tables As DataTableCollection
    Dim oController As New ControlBreakController
    Dim monthrp As New Integer

    Private Sub cbMonth_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbMonth.SelectedIndexChanged
        monthrp = cbMonth.SelectedIndex + 1
    End Sub

    Private Sub btnCreateReport1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCreateReport1.Click
        If Not IsNumeric(txtYear.Text) And (CInt(txtYear.Text) > Now.Year Or CInt(txtYear.Text) = 0) Then
            MsgBox("Please enter a valid year.")
        Else
            oController.createBreakReport1(CStr(monthrp), txtYear.Text)
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        oController.createBreakReport2()
    End Sub

    Private Sub gbCBRp1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gbCBRp1.Enter

    End Sub
End Class