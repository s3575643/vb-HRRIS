Option Explicit On
Option Strict On

Imports System.Data.OleDb
Imports System.IO

' Name: frmInvoice.vb
' Description: Form for generating invoice
' Author: Nguyen Anh Hoang Phuong
' Date: 03/05/2017

Public Class frmInvoice

    Dim oConnection As OleDbConnection = New OleDbConnection(Controller.CONNECTION_STRING)
    Dim ds As New DataSet
    Dim da As OleDbDataAdapter
    Dim tables As DataTableCollection
    Dim oCommand As New OleDbCommand
    Dim allvalid As Boolean = True

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        If MsgBox("Are you sure you want to close the form?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub frmInvoice_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        issuedatePicker.Value = Now

        oConnection.Open()

        tables = ds.Tables
        da = New OleDbDataAdapter("SELECT booking_id from booking", oConnection)
        da.Fill(ds, "booking")
        Dim view As New DataView(tables(0))
        With cbBookingID
            .DataSource = ds.Tables("booking")
            .DisplayMember = "booking_id"
            .ValueMember = "booking_id"
            .SelectedIndex = -1
        End With

        oConnection.Close()
    End Sub

    Private Sub CalAmount()
        'calculate total price when enter room
        Try
            oConnection.Open()

            Dim total As Decimal
            oCommand = New OleDbCommand("Select total_price from booking where booking_id =" & cbBookingID.SelectedValue.ToString & ";", oConnection)
            Dim rd As OleDbDataReader = oCommand.ExecuteReader
            While rd.Read
                total = CDec(rd("total_price"))
                txtAmount.Text = CStr("$" & (CInt(txtAdditional.Text) + total))
            End While

        Catch ex As Exception
            Debug.Print(ex.Message)
        Finally
            oConnection.Close()
        End Try
    End Sub

    Private Sub cbBookingID_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbBookingID.SelectedIndexChanged
        CalAmount()
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAdditional.TextChanged
        CalAmount()
        txtAdditional.BackColor = Color.White
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        'Check for empty fields
        If String.IsNullOrEmpty(cbBookingID.Text) Or String.IsNullOrEmpty(txtAmount.Text) Then
            MsgBox("Please choose a booking to generate invoice!")
            allvalid = False
        Else

            If Not IsNumeric(txtAdditional.Text) Then
                allvalid = False
                txtAdditional.BackColor = Color.Red
            End If

            'validate again and insert to hash
            If allvalid = True Then
                Debug.Print("Connection string: " & oConnection.ConnectionString)

                oConnection.Open()
                oCommand.Connection = oConnection

                Dim htData As Hashtable = New Hashtable
                htData("bookid") = cbBookingID.SelectedValue
                htData("issueddate") = issuedatePicker.Text
                htData("amount") = txtAmount.Text

                Dim oInvoiceController As Controller = New Controller
                oInvoiceController.InvoiceController(htData)


            Else : MsgBox("Invoice not recorded due to invalid input! Please check again.")
            End If
        End If
    End Sub

    'Navigation

    'New Customer
    Private Sub CustomerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CustomerToolStripMenuItem.Click
        My.Forms.frmCustomerNew.Show()
        Me.Hide()
    End Sub

    'New Room
    Private Sub RoomToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RoomToolStripMenuItem.Click
        My.Forms.frmRoomNew.Show()
        Me.Hide()
    End Sub

    'New Booking
    Private Sub BookingToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BookingToolStripMenuItem1.Click
        My.Forms.frmBookingNew.Show()
        Me.Hide()
    End Sub

    'Edit Booking
    Private Sub BookingToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BookingToolStripMenuItem.Click
        My.Forms.frmBookingEdit.Show()
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
    Private Sub ViewHelpToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewHelpToolStripMenuItem.Click
        Dim url As String = System.IO.Path.GetFullPath("help.html")
        Process.Start("Chrome", url)
    End Sub

    'About page in browser
    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        Dim url As String = System.IO.Path.GetFullPath("about.html")
        Process.Start("Chrome", url)
    End Sub

End Class