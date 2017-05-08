Option Explicit On
Option Strict On

' Name: frmCustomer.vb
' Description: Form for inserting room information
' Author: Nguyen Anh Hoang Phuong
' Date: 27/03/2017

Public Class frmroom

    Private Sub title_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblRoom_Num.Click

    End Sub

    Private Sub gender_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblRoomType.Click

    End Sub

    Private Sub address_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblFloor.Click

    End Sub

    Private Sub room_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class