Option Explicit On
Option Strict On

Imports System.Data.OleDb
Imports System.IO

' Name: Controller.vb
' Description: Class for data controller
' Author: Nguyen Anh Hoang Phuong
' Date: 29/03/2017

Public Class Controller

    Public Const CONNECTION_STRING As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=s3575643-HRRIS_Db.accdb"
    Dim oValidation As New Validation
    Dim oConnection As OleDbConnection = New OleDbConnection(Controller.CONNECTION_STRING)
    Dim oCommand As OleDbCommand = New OleDbCommand

    'insert customer info to db
    Public Sub CusController(ByVal htData As Hashtable)
        oConnection.Open()

        oCommand.Connection = oConnection
        oCommand.CommandText = _
                       "INSERT INTO customer (title, gender, firstname, lastname, phone, address, email, dob) VALUES (?, ?, ?, ?, ?, ?, ?, ?);"

        oCommand.Parameters.Add("title", OleDbType.VarChar, 255)
        oCommand.Parameters.Add("gender", OleDbType.Char, 1)
        oCommand.Parameters.Add("firstname", OleDbType.VarChar, 255)
        oCommand.Parameters.Add("lastname", OleDbType.VarChar, 255)
        oCommand.Parameters.Add("phone", OleDbType.VarChar, 50)
        oCommand.Parameters.Add("address", OleDbType.VarChar, 255)
        oCommand.Parameters.Add("email", OleDbType.VarChar, 50)
        oCommand.Parameters.Add("dob", OleDbType.Date, 255)

        oCommand.Parameters("title").Value = CStr(htData("title"))
        oCommand.Parameters("gender").Value = CStr(htData("gender"))
        oCommand.Parameters("firstname").Value = CStr(htData("firstname"))
        oCommand.Parameters("lastname").Value = CStr(htData("lastname"))
        oCommand.Parameters("phone").Value = CStr(htData("phone"))
        oCommand.Parameters("address").Value = CStr(htData("address"))
        oCommand.Parameters("email").Value = CStr(htData("email"))
        oCommand.Parameters("dob").Value = CDate(htData("dob"))

        oCommand.Prepare()

        Debug.Print("SQL: " & oCommand.CommandText)

        oCommand.ExecuteNonQuery()

        oConnection.Close()
    End Sub

    'insert room info to db
    Public Sub RoomController(ByVal htData As Hashtable)
        oConnection.Open()
        oCommand.Connection = oConnection

        oCommand.CommandText = _
                   "INSERT INTO room (room_number, type, price, num_beds, availability, floor, description) VALUES (?, ?, ?, ?, ?, ?, ?);"

        oCommand.Parameters.Add("room_number", OleDbType.VarChar, 50)
        oCommand.Parameters.Add("type", OleDbType.VarChar, 50)
        oCommand.Parameters.Add("price", OleDbType.Integer, 5)
        oCommand.Parameters.Add("num_beds", OleDbType.Integer, 5)
        oCommand.Parameters.Add("availability", OleDbType.Integer, 1)
        oCommand.Parameters.Add("floor", OleDbType.Integer, 5)
        oCommand.Parameters.Add("description", OleDbType.VarChar, 255)

        oCommand.Parameters("room_number").Value = CStr(htData("roomnum"))
        oCommand.Parameters("type").Value = CStr(htData("type"))
        oCommand.Parameters("price").Value = CInt(htData("price"))
        oCommand.Parameters("num_beds").Value = CInt(htData("numbeds"))
        oCommand.Parameters("availability").Value = CInt(htData("avail"))
        oCommand.Parameters("floor").Value = CInt(htData("floor"))
        oCommand.Parameters("description").Value = CStr(htData("descript"))

        oCommand.Prepare()

        Debug.Print("SQL: " & oCommand.CommandText)

        oCommand.ExecuteNonQuery()

        oConnection.Close()
    End Sub

    'insert booking info to db
    Public Sub BookingController(ByVal htData As Hashtable)
        oConnection.Open()
        oCommand.Connection = oConnection

        oCommand.CommandText = _
                   "INSERT INTO booking (booking_date, room_id, customer_id, num_days, num_guests, checkin_date, total_price, comments) VALUES (?, ?, ?, ?, ?, ?, ?, ?);"

        oCommand.Parameters.Add("booking_date", OleDbType.Date, 255)
        oCommand.Parameters.Add("room_id", OleDbType.Integer, 255)
        oCommand.Parameters.Add("customer_id", OleDbType.Integer, 255)
        oCommand.Parameters.Add("num_days", OleDbType.Integer, 255)
        oCommand.Parameters.Add("num_guests", OleDbType.Integer, 255)
        oCommand.Parameters.Add("checkin_date", OleDbType.Date, 255)
        oCommand.Parameters.Add("total_price", OleDbType.VarChar, 255)
        oCommand.Parameters.Add("comments", OleDbType.VarChar, 255)

        oCommand.Parameters("booking_date").Value = CDate(htData("bookdate"))
        oCommand.Parameters("room_id").Value = CInt(htData("roomid"))
        oCommand.Parameters("customer_id").Value = CInt(htData("cusid"))
        oCommand.Parameters("num_days").Value = CInt(htData("numdays"))
        oCommand.Parameters("num_guests").Value = CInt(htData("numguests"))
        oCommand.Parameters("checkin_date").Value = CDate(htData("checkindate"))
        oCommand.Parameters("total_price").Value = CStr(htData("totalprice"))
        oCommand.Parameters("comments").Value = CStr(htData("cmt"))

        oCommand.Prepare()

        Debug.Print("SQL: " & oCommand.CommandText)

        oCommand.ExecuteNonQuery()

        oConnection.Close()
    End Sub

    'insert invoice info to db
    Public Sub InvoiceController(ByVal htData As Hashtable)
        Try
            oConnection.Open()
            oCommand.Connection = oConnection
            oCommand.CommandText = _
                       "INSERT INTO invoice (booking_id, issued_date, amount) VALUES (?, ?, ?);"

            oCommand.Parameters.Add("booking_id", OleDbType.Integer, 255)
            oCommand.Parameters.Add("issued_date", OleDbType.Date, 255)
            oCommand.Parameters.Add("amount", OleDbType.VarChar, 255)

            oCommand.Parameters("booking_id").Value = CInt(htData("bookid"))
            oCommand.Parameters("issued_date").Value = CDate(htData("issueddate"))
            oCommand.Parameters("amount").Value = CStr(htData("amount"))

            oCommand.Prepare()

            Debug.Print("SQL: " & oCommand.CommandText)

            oCommand.ExecuteNonQuery()
            MsgBox("Your invoice has been recorded. Thank you.")
        Catch ex As Exception
            MsgBox("Invoice for this booking has already been generated.")
        Finally
            oConnection.Close()
        End Try

    End Sub

    'Public Function calTotalPrice(ByVal RoomId As Integer, ByVal NumDays As Integer, ByVal totalPrice As String) As String
    '    Try
    '        oConnection.Open()
    '        Dim roomprice As Decimal
    '        oCommand = New OleDbCommand("Select price from room where room_id=" & RoomId & ";", oConnection)
    '        Dim rd As OleDbDataReader = oCommand.ExecuteReader
    '        While rd.Read
    '            roomprice = CDec(rd("price"))
    '            totalPrice = CStr("$" & (CInt(NumDays) * roomprice))
    '        End While
    '    Catch ex As Exception
    '        Debug.Print(ex.Message)
    '    Finally
    '        oConnection.Close()
    '    End Try
    '    Return totalPrice
    'End Function
End Class
