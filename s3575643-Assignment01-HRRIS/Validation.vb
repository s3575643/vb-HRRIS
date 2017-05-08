Option Explicit On
Option Strict On

Imports System.Text.RegularExpressions

' Name: frmCustomer.vb
' Description: Class for validation of input
' Author: Nguyen Anh Hoang Phuong
' Date: 28/03/2017

Public Class Validation

    'regex alpha
    Public Function isAlpha(ByVal valid As String) As Boolean
        Dim alphaPattern As Regex = New Regex("^[a-zA-Z]")
        If alphaPattern.IsMatch(valid) Then
            Return True
        Else : Return False
        End If
    End Function

    'regex alphanumeric
    Public Function isAlphaNumericVal(ByVal valid As String) As Boolean

        Dim pattern As Regex = New Regex("^[a-zA-Z]+[0-9 _-]")
        Dim pattern2 As Regex = New Regex("^[0-9 _-]+[a-zA-Z]")

        If pattern.IsMatch(valid) Or pattern2.IsMatch(valid) Then
            Return True
        Else : Return False
        End If
    End Function

    'regex email
    Public Function isEmail(ByVal valid As String) As Boolean
        Dim email As Regex = New Regex("^[_a-z0-9-]+(.[a-z0-9-]+)@[a-z0-9-]+(.[a-z0-9-]+)*(.[a-z]{2,4})$")
        If email.IsMatch(valid) Then
            Return True
        Else : Return False
        End If
    End Function

End Class
