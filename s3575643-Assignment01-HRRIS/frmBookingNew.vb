Option Explicit On
Option Strict On

Imports System.Data.OleDb
Imports System.IO

' Name: frmBookingNew.vb
' Description: Form for inserting booking information
' Author: Nguyen Anh Hoang Phuong
' Date: 27/03/2017

Public Class frmBookingNew
    Dim oValidation As New Validation
    Dim allvalid As Boolean = True
    Dim oConnection As OleDbConnection = New OleDbConnection(Controller.CONNECTION_STRING)
    Dim oCommand As New OleDbCommand
    Dim oController As New Controller

    Dim ds As New DataSet
    Dim da As OleDbDataAdapter
    Dim tables As DataTableCollection
    Dim totalprice As String

    Private Sub frmbooking_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        checkindatePicker.MinDate = Now

        oConnection.Open()

        tables = ds.Tables
        da = New OleDbDataAdapter("SELECT room_id, room_number from room", oConnection)
        da.Fill(ds, "room")
        Dim view As New DataView(tables(0))
        With cbRoomID
            .DataSource = ds.Tables("room")
            .DisplayMember = "room_number"
            .ValueMember = "room_id"
            .SelectedIndex = -1
        End With

        oConnection.Close()

    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        If MsgBox("Are you sure you want to close the form?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click

        'Check for empty fields
        If String.IsNullOrEmpty(cbRoomID.Text) Or String.IsNullOrEmpty(txtCusID.Text) _
                Or String.IsNullOrEmpty(txtNumDays.Text) Or String.IsNullOrEmpty(txtNumGuests.Text) Then
            MsgBox("Please do not leave any fields blank!")
            allvalid = False
        Else

            If Not IsNumeric(txtNumDays.Text) Or txtNumDays.Text = "0" Then
                allvalid = False
                txtNumDays.BackColor = Color.Red
            End If

            If Not IsNumeric(txtNumGuests.Text) Or txtNumDays.Text = "0" Then
                allvalid = False
                txtNumGuests.BackColor = Color.Red
            End If

            oConnection.Open()
            oCommand = New OleDbCommand("Select customer_id from customer where customer_id=" & txtCusID.Text.ToString & ";", oConnection)
            Dim cusidrd As OleDbDataReader = oCommand.ExecuteReader
            If Not cusidrd.HasRows Then
                txtCusID.BackColor = Color.Red
                allvalid = False
                'ttCusIDError.ToolTipTitle = "Invalid Customer ID"
            End If
            oConnection.Close()

            'validate again and insert to hash
            If allvalid = True Then
                Try
                    Debug.Print("Connection string: " & oConnection.ConnectionString)

                    oConnection.Open()
                    oCommand.Connection = oConnection

                    Dim htData As Hashtable = New Hashtable
                    htData("bookdate") = bookdatePicker.Text
                    htData("roomid") = cbRoomID.SelectedValue
                    htData("cusid") = txtCusID.Text
                    htData("numdays") = txtNumDays.Text
                    htData("numguests") = txtNumGuests.Text
                    htData("checkindate") = checkindatePicker.Text
                    htData("totalprice") = txttotalPrice.Text
                    htData("cmt") = txtCmt.Text

                    Dim oBookingController As Controller = New Controller
                    oBookingController.BookingController(htData)

                    MsgBox("Your booking has been recorded. Thank you for your reservation.")
                Catch ex As Exception
                    MsgBox(ex.Message & "Record not inserted due to invalid input! Please check again.")
                Finally
                    oConnection.Close()
                End Try

            End If
        End If


    End Sub

    Private Sub calTotalPrice()
        Try
            oConnection.Open()

            Dim roomprice As Decimal
            oCommand = New OleDbCommand("Select price from room where room_id=" & cbRoomID.SelectedValue.ToString & ";", oConnection)
            Dim rd As OleDbDataReader = oCommand.ExecuteReader
            While rd.Read
                roomprice = CDec(rd("price"))
                txttotalPrice.Text = CStr("$" & (CInt(txtNumDays.Text) * roomprice))
            End While
        Catch ex As Exception
            Debug.Print(ex.Message)
        Finally
            oConnection.Close()
        End Try
    End Sub

    Private Sub txtNumDays_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNumDays.TextChanged
        txtNumDays.BackColor = Color.White
        'calculate total price when enter num days
        If cbRoomID.SelectedIndex > -1 Then
            calTotalPrice()
        End If
    End Sub

    Private Sub cbRoomID_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbRoomID.SelectedIndexChanged
        'calculate total price when enter room
        If Not String.IsNullOrEmpty(txtNumDays.Text) Then
            calTotalPrice()
        End If
    End Sub

    Private Sub txtNumGuests_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNumGuests.TextChanged
        txtNumGuests.BackColor = Color.White
    End Sub

    Private Sub txtCusID_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCusID.TextChanged
        txtCusID.BackColor = Color.White
    End Sub

    Private Sub checkindatePicker_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles checkindatePicker.ValueChanged

    End Sub

    'Navigation

    'New Customer
    Private Sub CustomerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CustomerToolStripMenuItem.Click
        My.Forms.frmCustomerNew.Show()
    End Sub

    'New Room
    Private Sub RoomToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RoomToolStripMenuItem.Click
        My.Forms.frmRoomNew.Show()
    End Sub

    'Edit Booking
    Private Sub BookingToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BookingToolStripMenuItem.Click
        My.Forms.frmBookingEdit.Show()
    End Sub

    'Edit Customer
    Private Sub CustomerToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CustomerToolStripMenuItem1.Click
        My.Forms.frmCustomerEdit.Show()
    End Sub

    'Edit Room
    Private Sub RoomToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RoomToolStripMenuItem1.Click
        My.Forms.frmRoomEdit.Show()
    End Sub

    'Reports
    Private Sub GeneralReportsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GeneralReportsToolStripMenuItem.Click
        My.Forms.frmReport.Show()
    End Sub

    'Control Break Reports
    Private Sub ControlBreakReportsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ControlBreakReportsToolStripMenuItem.Click
        My.Forms.frmControlBreakReport.Show()
    End Sub

    'New Invoice
    Private Sub InvoiceToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InvoiceToolStripMenuItem.Click
        My.Forms.frmInvoice.Show()
    End Sub

    'Help page in browser
    Private Sub ViewHelpToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewHelpToolStripMenuItem.Click
        Dim url As String = System.IO.Path.GetFullPath("help.html")
        Process.Start("chrome", url)
    End Sub

    'About page in browser
    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        Dim url As String = System.IO.Path.GetFullPath("about.html")
        Process.Start("chrome", url)
    End Sub

End Class