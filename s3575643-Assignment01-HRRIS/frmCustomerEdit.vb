Option Explicit On
Option Strict On

Imports System.Data.OleDb
Imports System.IO

' Name: frmCustomerEdit.vb
' Description: Form for editing customer information
' Author: Nguyen Anh Hoang Phuong
' Date: 27/04/2017

Public Class frmCustomerEdit

    Dim oConnection As New OleDbConnection(Controller.CONNECTION_STRING)

    Private Sub frmCustomerEdit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the '_s3575643_HRRIS_DbDataSetCus.customer' table. You can move, or remove it, as needed.
        Me.CustomerTableAdapter1.Fill(Me._s3575643_HRRIS_DbDataSetCus.customer)

    End Sub

    Private Sub cbTitle_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbTitle.SelectedIndexChanged
        If cbTitle.Text.ToString = "Mr." Then
            txtGender.Text = "M"
        Else : txtGender.Text = "F"
        End If
    End Sub

    Private Sub btnUpdateCus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdateCus.Click

        'Try
        '    Dim ds As New DataSet
        '    Dim da As New OleDbDataAdapter

        '    ds.Tables("customer").AcceptChanges()
        '    da.Update(ds, "customer")
        '    Dim item As New DataGridViewRow
        '    editCusGrid.AllowUserToAddRows = True
        '    item.CreateCells(editCusGrid)
        '    MsgBox("Record updated successfully")
        'Catch ex As Exception
        '    MsgBox(ex.Message)
        'End Try

        Try
            oConnection.Open()
            Dim oCmd As New OleDbCommand _
                ("Update customer Set title = '" & cbTitle.Text & "', gender = '" & txtGender.Text & _
                 "', firstname ='" & txtFirstname.Text & "' , lastname ='" & txtLastname.Text & _
                 "' , phone = '" & txtPhone.Text & "' , address = '" & txtAddress.Text & "' , email = '" & txtEmail.Text & _
                 "' , dob = '" & CDate(dobPicker.Text) & "' where customer_id=" & txtCusId.Text & ";", oConnection)
            oCmd.ExecuteNonQuery()
            MsgBox("Record updated.")
            Me.CustomerTableAdapter1.Fill(Me._s3575643_HRRIS_DbDataSetCus.customer)
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            oConnection.Close()
        End Try
    End Sub

    Private Sub btnDelCus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelCus.Click
        Try
            If MsgBox("Are you sure you want to delete the record? All data related to Customer " & txtCusId.Text & " will be deleted as well.", MsgBoxStyle.YesNo) = MsgBoxResult.Yes _
                Then
                oConnection.Open()
                Dim oCmd As New OleDbCommand _
                    ("Delete from customer where customer_id=" & txtCusId.Text & ";", oConnection)
                oCmd.ExecuteNonQuery()
                MsgBox("Record deleted.")
                Me.CustomerTableAdapter1.Fill(Me._s3575643_HRRIS_DbDataSetCus.customer)
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
            Dim oCmd As String = "Select * from customer where customer_id like '%" & txtSearch.Text & "%' or firstname like '%" & txtSearch.Text & _
                 "%' or lastname like '%" & txtSearch.Text & "%' or phone like '%" & txtSearch.Text & _
                 "%' or address like '%" & txtSearch.Text & "%' or email like '%" & txtSearch.Text & _
                 "%' or dob like '%" & txtSearch.Text & "%';"
            Dim ds As New DataSet
            Dim da As OleDbDataAdapter
            Dim dt As New DataTable
            da = New OleDbDataAdapter(oCmd, oConnection)
            da.Fill(dt)
            editCusGrid.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            oConnection.Close()
        End Try
    End Sub

    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
        Try
            'Me.CustomerTableAdapter1.Fill(Me._s3575643_HRRIS_DbDataSetCus.customer)
            editCusGrid.DataSource = CustomerBindingSource
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            oConnection.Close()
        End Try
    End Sub

    Private Sub btnFirst_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFirst.Click
        Me.CustomerBindingSource.MoveFirst()
    End Sub

    Private Sub btnPrev_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrev.Click
        Me.CustomerBindingSource.MovePrevious()
    End Sub

    Private Sub btnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNext.Click
        Me.CustomerBindingSource.MoveNext()
    End Sub

    Private Sub btnLast_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLast.Click
        Me.CustomerBindingSource.MoveLast()
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