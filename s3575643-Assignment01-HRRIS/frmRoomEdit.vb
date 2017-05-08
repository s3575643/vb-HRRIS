Option Explicit On
Option Strict On

Imports System.Data.OleDb
Imports System.IO

' Name: frmRoomEdit.vb
' Description: Form for editing room information
' Author: Nguyen Anh Hoang Phuong
' Date: 29/04/2017

Public Class frmRoomEdit

    Dim oConnection As New OleDbConnection(Controller.CONNECTION_STRING)

    Private Sub frmRoomEdit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the '_s3575643_HRRIS_DbDataSetRoom.room' table. You can move, or remove it, as needed.
        Me.RoomTableAdapter.Fill(Me._s3575643_HRRIS_DbDataSetRoom.room)

    End Sub

    Private Sub btnUpdateRoom_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdateRoom.Click

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

                Try
                    oConnection.Open()
                    Dim oCmd As New OleDbCommand _
                        ("Update room Set room_number = '" & txtRoomNum.Text & "', type = '" & cbType.Text & _
                         "', availability ='" & chkAvail.CheckState & "' , floor ='" & txtFloor.Text & _
                         "' , description = '" & txtDescript.Text & "' where room_id =" & txtRoomId.Text & ";", oConnection)
                    oCmd.ExecuteNonQuery()
                    MsgBox("Record updated.")
                    Me.RoomTableAdapter.Fill(Me._s3575643_HRRIS_DbDataSetRoom.room)
                Catch ex As Exception
                    MsgBox(ex.Message)
                Finally
                    oConnection.Close()
                End Try
            End If
        End If
    End Sub

    Private Sub btnDelRoom_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelRoom.Click
        Try
            If MsgBox("Are you sure you want to delete the record? All data related to Room " & txtRoomNum.Text & " will be deleted as well.", MsgBoxStyle.YesNo) = MsgBoxResult.Yes _
                Then
                oConnection.Open()
                Dim oCmd As New OleDbCommand _
                    ("Delete from room where room_id =" & txtRoomId.Text & ";", oConnection)
                oCmd.ExecuteNonQuery()
                MsgBox("Record deleted.")
                Me.RoomTableAdapter.Fill(Me._s3575643_HRRIS_DbDataSetRoom.room)
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
            Dim oCmd As String = "Select * from room where room_id like '%" & txtSearch.Text & "%' or room_number like '%" & txtSearch.Text & _
                 "%' or type like '%" & txtSearch.Text & "%' or price like '%" & txtSearch.Text & _
                 "%' or num_beds like '%" & txtSearch.Text & "%' or floor like '%" & txtSearch.Text & _
                 "%' or description like '%" & txtSearch.Text & "%';"
            Dim ds As New DataSet
            Dim da As OleDbDataAdapter
            Dim dt As New DataTable
            da = New OleDbDataAdapter(oCmd, oConnection)
            da.Fill(dt)
            editRoomGrid.DataSource = dt
            'Me.CustomerTableAdapter1.Fill(Me._s3575643_HRRIS_DbDataSetCus.customer)
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            oConnection.Close()
        End Try
    End Sub

    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
        Try
            'Me.CustomerTableAdapter1.Fill(Me._s3575643_HRRIS_DbDataSetCus.customer)
            editRoomGrid.DataSource = RoomBindingSource
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            oConnection.Close()
        End Try
    End Sub

    Private Sub btnFirst_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFirst.Click
        Me.RoomBindingSource.MoveFirst()
    End Sub

    Private Sub btnPrev_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrev.Click
        Me.RoomBindingSource.MovePrevious()
    End Sub

    Private Sub btnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNext.Click
        Me.RoomBindingSource.MoveNext()
    End Sub

    Private Sub btnLast_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLast.Click
        Me.RoomBindingSource.MoveLast()
    End Sub

    'Navigation

    'New Customer
    Private Sub newCusToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles newCusToolStripMenuItem.Click
        My.Forms.frmCustomerNew.Show()
        Me.Hide()
    End Sub

    'New Room
    Private Sub newRoomToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles newRoomToolStripMenuItem1.Click
        My.Forms.frmRoomNew.Show()
        Me.Hide()
    End Sub

    'New Booking
    Private Sub newBookingToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles newBookingToolStripMenuItem1.Click
        My.Forms.frmBookingNew.Show()
        Me.Hide()
    End Sub

    'Edit Customer
    Private Sub editCusBookingToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles editCusBookingToolStripMenuItem.Click
        My.Forms.frmCustomerEdit.Show()
        Me.Hide()
    End Sub

    'Edit Booking
    Private Sub editBookingToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles editBookingToolStripMenuItem2.Click
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