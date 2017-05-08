Option Explicit On
Option Strict On

Imports System.Data.OleDb
Imports System.IO

' Name: frmCustomer.vb
' Description: Form for inserting customer information
' Author: Nguyen Anh Hoang Phuong
' Date: 27/03/2017

Public Class frmCustomerNew

    Dim oValidation As New Validation
    Dim oConnection As OleDbConnection = New OleDbConnection(Controller.CONNECTION_STRING)
    Dim allvalid As Boolean = True


    Private Sub frmcustomer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dobPicker.MaxDate = Now
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        If MsgBox("Are you sure you want to close the form?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        'Check for empty fields
        If String.IsNullOrEmpty(cbTitle.Text) Or String.IsNullOrEmpty(txtGender.Text) _
                Or String.IsNullOrEmpty(txtFirstname.Text) Or String.IsNullOrEmpty(txtLastname.Text) _
                Or String.IsNullOrEmpty(txtPhone.Text) Or String.IsNullOrEmpty(txtAddress.Text) _
                Or String.IsNullOrEmpty(txtEmail.Text) _
                Then
            MsgBox("Please do not leave any fields blank!")
            allvalid = False
        Else
            'use funtion in validation.vb to check fields
            If oValidation.isAlpha(txtFirstname.Text) = False Then
                allvalid = False
                txtFirstname.BackColor = Color.Red
            End If

            If oValidation.isAlpha(txtLastname.Text) = False Then
                allvalid = False
                txtLastname.BackColor = Color.Red
            End If

            If Not IsNumeric(txtPhone.Text) Then
                allvalid = False
                txtPhone.BackColor = Color.Red
            End If

            If oValidation.isAlphaNumericVal(txtAddress.Text) = False Then
                allvalid = False
                txtAddress.BackColor = Color.Red
            End If

            If oValidation.isEmail(txtEmail.Text) = False Then
                allvalid = False
                txtEmail.BackColor = Color.Red
            End If

            'validate again and insert to hash
            If allvalid = True Then

                Debug.Print("Connection string: " & oConnection.ConnectionString)

                Dim htData As Hashtable = New Hashtable
                htData("title") = cbTitle.Text
                htData("gender") = txtGender.Text
                htData("firstname") = txtFirstname.Text
                htData("lastname") = txtLastname.Text
                htData("phone") = txtPhone.Text
                htData("address") = txtAddress.Text
                htData("email") = txtEmail.Text
                htData("dob") = dobPicker.Text

                Dim oCusController As Controller = New Controller
                oCusController.CusController(htData)
                MsgBox("Your information was recorded. Thank you for your registration.")

            Else : MsgBox("Record not inserted due to invalid input! Please check again.")
            End If
        End If
    End Sub

    Private Sub txtFirstname_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        txtFirstname.BackColor = Color.White
    End Sub

    Private Sub txtLastname_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        txtLastname.BackColor = Color.White
    End Sub

    Private Sub txtPhone_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        txtPhone.BackColor = Color.White
    End Sub

    Private Sub txtAddress_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        txtAddress.BackColor = Color.White
    End Sub

    Private Sub txtEmail_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        txtEmail.BackColor = Color.White
    End Sub

    Private Sub cbTitle_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbTitle.SelectedIndexChanged
        If cbTitle.Text.ToString = "Mr." Then
            txtGender.Text = "M"
        Else : txtGender.Text = "F"
        End If
    End Sub

    'Navigation

    'New Room
    Private Sub RoomToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RoomToolStripMenuItem1.Click
        My.Forms.frmRoomNew.Show()
        Me.Hide()
    End Sub

    'New Booking
    Private Sub BookingToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BookingToolStripMenuItem1.Click
        My.Forms.frmBookingNew.Show()
        Me.Hide()
    End Sub

    'Edit Customer
    Private Sub CustomerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CustomerToolStripMenuItem.Click
        My.Forms.frmCustomerEdit.Show()
        Me.Hide()
    End Sub

    'Edit Room
    Private Sub RoomToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RoomToolStripMenuItem.Click
        My.Forms.frmRoomEdit.Show()
        Me.Hide()
    End Sub

    'Edit Booking
    Private Sub BookingToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BookingToolStripMenuItem2.Click
        My.Forms.frmBookingEdit.Show()
        Me.Hide()
    End Sub

    'Reports
    Private Sub GeneralReportsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GeneralReportsToolStripMenuItem.Click
        My.Forms.frmReport.Show()
        Me.Hide()
    End Sub

    'Control Break Reports
    Private Sub ControlBreakReportsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ControlBreakReportsToolStripMenuItem.Click
        My.Forms.frmControlBreakReport.Show()
        Me.Hide()
    End Sub

    'Help page in browser
    Private Sub ViewHelpToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HelpToolStripMenuItem.Click
        Dim url As String = System.IO.Path.GetFullPath("help.html")
        Process.Start(url)
    End Sub

    'About page in browser
    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        Dim url As String = System.IO.Path.GetFullPath("about.html")
        Process.Start(url)
    End Sub
End Class

