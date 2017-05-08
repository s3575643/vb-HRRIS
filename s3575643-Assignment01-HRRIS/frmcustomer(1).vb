Option Explicit On
Option Strict On

Imports System.Data.OleDb
Imports System.IO

' Name: frmCustomer.vb
' Description: Form for inserting customer information
' Author: Nguyen Anh Hoang Phuong
' Date: 27/03/2017

Public Class frmcustomer

    Public Const CONNECTION_STRING As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=HRRIS.accdb"

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Label6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblDob.Click

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbTitle.SelectedIndexChanged

    End Sub

    Private Sub Label1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub customer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Dim oConnection As OleDbConnection = New OleDbConnection(CONNECTION_STRING)

        Try
            Debug.Print("Connection string: " & oConnection.ConnectionString)

            oConnection.Open()
            Dim oCommand As OleDbCommand = New OleDbCommand
            oCommand.Connection = oConnection

            Dim htData As Hashtable = New Hashtable
            htData("ProductName") = "Folder"
            htData("ProductDescription") = "50 pack of manila folders"
            htData("Category") = "Stationery"
            htData("ReorderLevel") = 5
            htData("LeadTime") = 1
            htData("Discontinued") = 0
            htData("UnitPrice") = 4.95

            oCommand.CommandText = _
               "INSERT INTO customer (product_name, product_description, category, reorder_level, lead_time, discontinued, unit_price) VALUES (?, ?, ?, ?, ?, ?, ?);"

            oCommand.Parameters.Add("ProductName", OleDbType.VarChar, 255)
            oCommand.Parameters.Add("ProductDescription", OleDbType.VarChar, 255)
            oCommand.Parameters.Add("Category", OleDbType.VarChar, 255)
            oCommand.Parameters.Add("ReorderLevel", OleDbType.Integer, 4)
            oCommand.Parameters.Add("LeadTime", OleDbType.VarChar, 255)
            oCommand.Parameters.Add("Discontinued", OleDbType.Integer, 1)
            oCommand.Parameters.Add("UnitPrice", OleDbType.Double, 8)

            oCommand.Parameters("ProductName").Value = CStr(htData("ProductName"))
            oCommand.Parameters("ProductDescription").Value = CStr(htData("ProductDescription"))
            oCommand.Parameters("Category").Value = CStr(htData("Category"))
            oCommand.Parameters("ReorderLevel").Value = CInt(htData("ReorderLevel"))
            oCommand.Parameters("LeadTime").Value = CStr(htData("LeadTime"))
            oCommand.Parameters("Discontinued").Value = CInt(htData("Discontinued"))
            oCommand.Parameters("UnitPrice").Value = CDbl(htData("UnitPrice"))

            oCommand.Prepare()

            Debug.Print("SQL: " & oCommand.CommandText)

            oCommand.ExecuteNonQuery()

            Debug.Print("The record was inserted.")

        Catch ex As Exception
            Debug.Print("ERROR: " & ex.Message)
            MsgBox("An error occured. The record wasn't inserted.")
        Finally
            oConnection.Close()
        End Try

    End Sub
End Class
