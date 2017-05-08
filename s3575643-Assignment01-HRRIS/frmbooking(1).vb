Option Explicit On
Option Strict On

' Name: frmCustomer.vb
' Description: Form for inserting booking information
' Author: Nguyen Anh Hoang Phuong
' Date: 27/03/2017

Public Class frmbooking

    Private Sub lblTitle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblBookDate.Click

    End Sub

    Private Sub booking_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class