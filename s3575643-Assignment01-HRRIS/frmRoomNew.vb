Option Explicit On
Option Strict On

Imports System.Data.OleDb
Imports System.IO

' Name: frmCustomer.vb
' Description: Form for inserting room information
' Author: Nguyen Anh Hoang Phuong
' Date: 27/03/2017

Public Class frmRoomNew

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        If MsgBox("Are you sure you want to close the form?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click

        Dim allvalid As Boolean = True

        'Check for empty fields
        If String.IsNullOrEmpty(txtRoomNum.Text) Or String.IsNullOrEmpty(cbType.Text) _
                Or String.IsNullOrEmpty(txtPrice.Text) Or String.IsNullOrEmpty(txtNumBeds.Text) _
                Or String.IsNullOrEmpty(txtFloor.Text) Then
            MsgBox("Please do not leave any fields blank!")
            allvalid = False
        Else
            'Check fields that must be numbers
            'Assume only single beds
            If Not IsNumeric(txtNumBeds.Text) Then
                allvalid = False
                txtNumBeds.BackColor = Color.Red
            End If

            If Not IsNumeric(txtFloor.Text) Then
                allvalid = False
                txtFloor.BackColor = Color.Red
            End If

            If IsNumeric(txtRoomNum.Text) = False Then
                allvalid = False
                txtRoomNum.BackColor = Color.Red
            End If

            If Not IsNumeric(txtPrice.Text) Then
                allvalid = False
                txtPrice.BackColor = Color.Red
            End If

            'validate again and insert to hash
            If allvalid = True Then

                Dim htData As Hashtable = New Hashtable
                htData("roomnum") = txtRoomNum.Text
                htData("type") = cbType.Text
                htData("price") = txtPrice.Text
                htData("numbeds") = txtNumBeds.Text
                If chkAvail.Checked = True Then
                    htData("avail") = 1
                Else
                    htData("avail") = 0
                End If
                htData("floor") = txtFloor.Text
                htData("descript") = txtDescript.Text

                Dim oRoomController As Controller = New Controller
                oRoomController.RoomController(htData)

                MsgBox("Your record was inserted.")
            Else : MsgBox("Record not inserted due to invalid input! Please check again.")
            End If
        End If
    End Sub


    Private Sub frmroom_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txtRoomNum_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtRoomNum.TextChanged
        txtRoomNum.BackColor = Color.White
    End Sub

    Private Sub txtPrice_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPrice.TextChanged
        txtPrice.BackColor = Color.White
    End Sub

    Private Sub txtNumBeds_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNumBeds.TextChanged
        txtNumBeds.BackColor = Color.White
    End Sub

    Private Sub txtFloor_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFloor.TextChanged
        txtFloor.BackColor = Color.White
    End Sub

    'Navigation

    'New Customer
    Private Sub CustomerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CustomerToolStripMenuItem.Click
        My.Forms.frmCustomerNew.Show()
        Me.Hide()
    End Sub

    'New Booking
    Private Sub BookingToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BookingToolStripMenuItem.Click
        My.Forms.frmBookingNew.Show()
        Me.Hide()
    End Sub

    'Edit Customer
    Private Sub CustomerToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CustomerToolStripMenuItem1.Click
        My.Forms.frmCustomerEdit.Show()
        Me.Hide()
    End Sub

    'Edit Room
    Private Sub RoomToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RoomToolStripMenuItem1.Click
        My.Forms.frmRoomEdit.Show()
        Me.Hide()
    End Sub

    'Edit Booking
    Private Sub BookingToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BookingToolStripMenuItem1.Click
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