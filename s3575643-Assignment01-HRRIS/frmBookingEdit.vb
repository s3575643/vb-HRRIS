Option Explicit On
Option Strict On

Imports System.Data.OleDb
Imports System.IO

' Name: frmBookingEdit.vb
' Description: Form for editing booking information
' Author: Nguyen Anh Hoang Phuong
' Date: 21/04/2017

Public Class frmBookingEdit

    'Dim ds As New DataTable
    'Dim da As OleDbDataAdapter
    'Dim tables As DataTableCollection
    Dim oConnection As OleDbConnection = New OleDbConnection(Controller.CONNECTION_STRING)
    Dim oController As New Controller
    Dim oCommand As OleDbCommand

    Private Sub frmBookingEdit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the '_s3575643_HRRIS_DbDataSetBook.booking' table. You can move, or remove it, as needed.
        Me.BookingTableAdapter.Fill(Me._s3575643_HRRIS_DbDataSetBook.booking)
        'TODO: This line of code loads data into the '_s3575643_HRRIS_DbDataSetBook.booking' table. You can move, or remove it, as needed.
        Me.BookingTableAdapter.Fill(Me._s3575643_HRRIS_DbDataSetBook.booking)
        'Try

        '    'oConnection.Open()
        '    'ds.Tables.Add(dt)
        '    'da = New OleDbDataAdapter _
        '    '    ("SELECT booking_id, booking_date, room_id, customer_id, num_days, num_guests, checkin_date, total_price, comments from booking;", oConnection)
        '    'da.Fill(dt)
        '    'editBookGrid.DataSource = dt.DefaultView
        '    'oConnection.Close()

        '    oConnection.Open()

        '    'tables = ds.Tables
        '    da = New OleDbDataAdapter("SELECT booking_id, booking_date, room_id, customer_id, num_days, num_guests, checkin_date, total_price, comments from booking;", oConnection)
        '    da.Fill(ds)
        '    'Dim view As New DataView(tables(0))
        '    editBookGrid.DataSource = ds

        'Catch ex As Exception
        '    MsgBox(ex.Message)
        'Finally
        '    oConnection.Close()
        'End Try
        

    End Sub

    'Private Sub FillToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Try
    '        Me.BookingTableAdapter.Fill(Me._s3575643_HRRIS_DbDataSet.booking)
    '    Catch ex As System.Exception
    '        System.Windows.Forms.MessageBox.Show(ex.Message)
    '    End Try

    'End Sub

    Private Sub btnUpdateBooking_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdateBooking.Click
        Try
            oConnection.Open()
            Dim oCmd As New OleDbCommand _
                ("Update booking Set booking_date = '" & CDate(bookdatePicker.Text) & "', room_id = '" & cbRoomID.Text & _
                 "', customer_id ='" & txtCusID.Text & "' , num_days ='" & txtNumDays.Text & _
                 "' , num_guests = '" & txtNumGuests.Text & "' , checkin_date = '" & CDate(checkindatePicker.Text) & _
                 "' , total_price = '" & txttotalPrice.Text & "' , comments = '" & txtCmt.Text & _
                 "' where booking_id =" & txtBookingId.Text & ";", oConnection)
            oCmd.ExecuteNonQuery()
            MsgBox("Record updated.")
            Me.BookingTableAdapter.Fill(Me._s3575643_HRRIS_DbDataSetBook.booking)
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            oConnection.Close()
        End Try
    End Sub

    Private Sub btnDelCus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelCus.Click
        Try
            If MsgBox("Are you sure you want to delete the record? All data related to Booking " & txtBookingId.Text & " will be deleted as well.", MsgBoxStyle.YesNo) = MsgBoxResult.Yes _
                Then
                oConnection.Open()
                Dim oCmd As New OleDbCommand _
                    ("Delete from booking where booking_id =" & txtBookingId.Text & ";", oConnection)
                oCmd.ExecuteNonQuery()
                MsgBox("Record deleted.")
                Me.BookingTableAdapter.Fill(Me._s3575643_HRRIS_DbDataSetBook.booking)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            oConnection.Close()
        End Try
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        Try
            oConnection.Open()
            Dim oCmd As String = "Select * from booking where booking_id like '%" & txtSearch.Text & "%' or booking_date like '%" & txtSearch.Text & _
                 "%' or room_id like '%" & txtSearch.Text & "%' or customer_id like '%" & txtSearch.Text & _
                 "%' or num_days like '%" & txtSearch.Text & "%' or num_guests like '%" & txtSearch.Text & _
                 "%' or checkin_date like '%" & txtSearch.Text & "%'or total_price like '%" & txtSearch.Text & _
                 "%' or comments like '%" & txtSearch.Text & "%';"
            Dim ds As New DataSet
            Dim da As OleDbDataAdapter
            Dim dt As New DataTable
            da = New OleDbDataAdapter(oCmd, oConnection)
            da.Fill(dt)
            editBookGrid.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            oConnection.Close()
        End Try
    End Sub

    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
        Try
            'Me.CustomerTableAdapter1.Fill(Me._s3575643_HRRIS_DbDataSetCus.customer)
            editBookGrid.DataSource = BookingBindingSource
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            oConnection.Close()
        End Try
    End Sub

    Private Sub calTotalPrice()
        Try
            oConnection.Open()

            Dim roomprice As Decimal
            oCommand = New OleDbCommand("Select price from room where room_id=" & cbRoomID.SelectedValue.ToString & ";", oConnection)
            Dim rd As OleDbDataReader = oCommand.ExecuteReader
            While rd.Read
                roomprice = CDec(rd("price"))
                txttotalPrice.Text = CStr((CInt(txtNumDays.Text) * roomprice))
            End While
        Catch ex As Exception
            Debug.Print(ex.Message)
        Finally
            oConnection.Close()
        End Try
    End Sub

    Private Sub cbRoomID_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbRoomID.SelectedIndexChanged
        'calculate total price when enter room
        If Not String.IsNullOrEmpty(txtNumDays.Text) Then
            calTotalPrice()
        End If
    End Sub

    Private Sub txtNumDays_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNumDays.TextChanged
        'calculate total price when enter num days
        If cbRoomID.SelectedIndex > -1 Then
            calTotalPrice()
        End If
    End Sub

    Private Sub btnFirst_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFirst.Click
        Me.BookingBindingSource.MoveFirst()
    End Sub

    Private Sub btnPrev_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrev.Click
        Me.BookingBindingSource.MovePrevious()
    End Sub

    Private Sub btnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNext.Click
        Me.BookingBindingSource.MoveNext()
    End Sub

    Private Sub btnLast_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLast.Click
        Me.BookingBindingSource.MoveLast()
    End Sub


    'Navigation

    'New Customer
    Private Sub CustomerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles newCustomerToolStripMenuItem.Click
        My.Forms.frmCustomerNew.Show()
        Me.Hide()
    End Sub

    'New Room
    Private Sub RoomToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles newRoomToolStripMenuItem.Click
        My.Forms.frmRoomNew.Show()
        Me.Hide()
    End Sub

    'New Booking
    Private Sub BookingToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles newBookingToolStripMenuItem.Click
        My.Forms.frmBookingNew.Show()
        Me.Hide()
    End Sub

    'New Invoice
    Private Sub InvoiceToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InvoiceToolStripMenuItem.Click
        My.Forms.frmInvoice.Show()
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
        Process.Start(url)
    End Sub

    'About page in browser
    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        Dim url As String = System.IO.Path.GetFullPath("about.html")
        Process.Start(url)
    End Sub
End Class