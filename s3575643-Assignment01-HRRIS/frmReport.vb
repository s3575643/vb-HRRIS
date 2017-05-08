Option Explicit On
Option Strict On

Imports System.Data.OleDb
Imports System.IO

' Name: frmReport.vb
' Description: Form for generating reports
' Author: Nguyen Anh Hoang Phuong
' Date: 02/05/2017

Public Class frmReport

    Dim oConnection As OleDbConnection = New OleDbConnection(Controller.CONNECTION_STRING)
    Dim ds As New DataSet
    Dim da As OleDbDataAdapter
    Dim tables As DataTableCollection
    Dim oController As New ReportController
    Dim monthrp As New Integer

    Private Sub frmReport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        oConnection.Open()

        tables = ds.Tables
        da = New OleDbDataAdapter("SELECT customer_id from customer", oConnection)
        da.Fill(ds, "customer")
        Dim view As New DataView(tables(0))
        With cbCusIdRp1
            .DataSource = ds.Tables("customer")
            .ValueMember = "customer_id"
            .SelectedIndex = -1
        End With

        tables.Clear()
        tables = ds.Tables
        da = New OleDbDataAdapter("SELECT customer_id from customer", oConnection)
        da.Fill(ds, "customer")
        view = New DataView(tables(0))
        With cbCusidRp3
            .DataSource = ds.Tables("customer")
            .ValueMember = "customer_id"
            .SelectedIndex = -1
        End With

        tables.Clear()
        tables = ds.Tables
        da = New OleDbDataAdapter("SELECT room_id, room_number from room order by room_number", oConnection)
        da.Fill(ds, "room")
        view = New DataView(tables(0))
        With cbRoomNumRp2
            .DataSource = ds.Tables("room")
            .DisplayMember = "room_number"
            .ValueMember = "room_id"
            .SelectedIndex = -1
        End With

        tables.Clear()
        tables = ds.Tables
        da = New OleDbDataAdapter("SELECT distinct room_number FROM room;", oConnection)
        da.Fill(ds, "room")
        view = New DataView(tables(0))
        With cbRoomNumRp6
            .DataSource = ds.Tables("room")
            .ValueMember = "room_number"
            .SelectedIndex = -1
        End With

        oConnection.Close()

        txtYearRp3.Text = CStr(Year(Now))
        txtYearRp4.Text = CStr(Year(Now))
        txtYearRp5.Text = CStr(Year(Now))
        txtYearRp6.Text = CStr(Year(Now))
    End Sub

    Private Sub cbMonth_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbMonthRp3.SelectedIndexChanged
        monthrp = cbMonthRp3.SelectedIndex + 1
    End Sub
    Private Sub cbMonthRp4_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbMonthRp4.SelectedIndexChanged
        monthrp = cbMonthRp4.SelectedIndex + 1
    End Sub
    Private Sub cbMonthRp5_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbMonthRp5.SelectedIndexChanged
        monthrp = cbMonthRp5.SelectedIndex + 1
    End Sub
    Private Sub cbMonthRp6_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbMonthRp6.SelectedIndexChanged
        monthrp = cbMonthRp6.SelectedIndex + 1
    End Sub

    Private Sub btnCreateReport1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCreateReport1.Click
        If cbCusIdRp1.SelectedIndex = -1 Then
            MsgBox("Please choose a Customer ID to generate the report on.")
        Else
            oController.createReport01(cbCusIdRp1.Text)
        End If
    End Sub

    Private Sub btnCreateReport2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCreateReport2.Click
        If cbCusIdRp1.SelectedIndex = -1 Then
            MsgBox("Please choose a Customer ID to generate the report on.")
        Else
            oController.createReport02(CStr(cbRoomNumRp2.SelectedValue))
        End If
    End Sub

    Private Sub btnCreateReport3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCreateReport3.Click
        If cbCusidRp3.SelectedIndex = -1 Or cbMonthRp3.SelectedIndex = -1 Then
            MsgBox("Please do not leave any fields blank.")
        ElseIf Not IsNumeric(txtYearRp3.Text) Then
            MsgBox("Please enter a valid year in numbers.")
        ElseIf CInt(txtYearRp3.Text) > Now.Year Or CInt(txtYearRp3.Text) < 1000 Then
            MsgBox("Please enter a valid year in the past. The format is YYYY. E.g.: 2017")
        Else
            oController.createReport03(cbCusidRp3.Text, CStr(monthrp), txtYearRp3.Text)
        End If
    End Sub

    Private Sub btnCreateReport4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCreateReport4.Click
        If cbMonthRp4.SelectedIndex = -1 Then
            MsgBox("Please choose a month.")
        ElseIf Not IsNumeric(txtYearRp4.Text) Then
            MsgBox("Please enter a valid year in numbers.")
        ElseIf CInt(txtYearRp4.Text) > Now.Year Or CInt(txtYearRp3.Text) < 1000 Then
            MsgBox("Please enter a valid year in the past. The format is YYYY. E.g.: 2017")
        Else
            oController.createReport04(CStr(monthrp), txtYearRp4.Text)
        End If
    End Sub

    Private Sub btnCreateReport5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCreateReport5.Click
        If cbMonthRp5.SelectedIndex = -1 Then
            MsgBox("Please choose a month.")
        ElseIf Not IsNumeric(txtYearRp5.Text) Then
            MsgBox("Please enter a valid year in numbers.")
        ElseIf CInt(txtYearRp5.Text) < 1000 Then
            MsgBox("Please enter a valid year. The format is YYYY. E.g.: 2017")
        Else
            oController.createReport05(CStr(monthrp), txtYearRp5.Text)
        End If
    End Sub

    Private Sub btnCreateReport6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCreateReport6.Click
        If cbRoomNumRp6.SelectedIndex = -1 Or cbMonthRp6.SelectedIndex = -1 Then
            MsgBox("Please do not leave any fields blank.")
        ElseIf Not IsNumeric(txtYearRp6.Text) Then
            MsgBox("Please enter a valid year in numbers.")
        ElseIf CInt(txtYearRp6.Text) > Now.Year Or CInt(txtYearRp6.Text) = 0 Then
            MsgBox("Please enter a valid year in the past. The format is YYYY. E.g.: 2017")
        Else
            oController.createReport06(cbRoomNumRp6.Text, CStr(monthrp), txtYearRp6.Text)
        End If
    End Sub
End Class