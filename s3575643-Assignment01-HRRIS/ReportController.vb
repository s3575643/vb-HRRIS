Option Explicit On
Option Strict On

Imports System.Data.OleDb
Imports System.IO

' Name: Controller.vb
' Description: Class for funtions to generate reports
' Author: Nguyen Anh Hoang Phuong
' Date: 02/05/2017

Public Class ReportController

    Dim lsData As New List(Of Hashtable)
    Dim oConnection As OleDbConnection = New OleDbConnection(Controller.CONNECTION_STRING)
    Dim reportIndex As New Integer

    Public Sub createReport01(ByVal criteria As String)

        'Debug.Print("CreateReport01 ...")

        Dim lsData = findReport1(criteria)
        If CInt(lsData.Count.ToString) > 0 Then
            Dim sReportTitle = "Details of a customer's last booking"
            Dim sReportContent = generateReport(lsData, sReportTitle)
            Dim sReportFilename = "LastBooking.html"
            saveReport(sReportContent, sReportFilename)
            Dim sParam As String = """" & Application.StartupPath & "\" & sReportFilename & """"
            Debug.Print("sParam: " & sParam)
            System.Diagnostics.Process.Start(sParam)
        Else
            MsgBox("This customer has not made any bookings.")
        End If
        
    End Sub

    Public Sub createReport02(ByVal criteria As String)

        'Debug.Print("CreateReport01 ...")

        Dim lsData = findReport2(criteria)
        If CInt(lsData.Count.ToString) > 0 Then
            Dim sReportTitle = "Details of ..."
            Dim sReportContent = generateReport(lsData, sReportTitle)
            Dim sReportFilename = "LastBooked.html"
            saveReport(sReportContent, sReportFilename)
            Dim sParam As String = """" & Application.StartupPath & "\" & sReportFilename & """"
            Debug.Print("sParam: " & sParam)
            System.Diagnostics.Process.Start(sParam)
        Else
            MsgBox("This room has not been booked.")
        End If

    End Sub

    Public Sub createReport03(ByVal criteria1 As String, ByVal criteria2 As String, ByVal criteria3 As String)

        'Debug.Print("CreateReport01 ..."
        Dim lsData = findReport3(criteria1, criteria2, criteria3)
        If CInt(lsData.Count.ToString) > 0 Then
            Dim sReportTitle = "Details of ..."
            Dim sReportContent = generateReport(lsData, sReportTitle)
            Dim sReportFilename = "RoomsBookedperCustomer.html"
            saveReport(sReportContent, sReportFilename)
            Dim sParam As String = """" & Application.StartupPath & "\" & sReportFilename & """"
            Debug.Print("sParam: " & sParam)
            System.Diagnostics.Process.Start(sParam)
        Else
            MsgBox("This customer did not book any rooms in the given time period.")
        End If

    End Sub

    Public Sub createReport04(ByVal criteria1 As String, ByVal criteria2 As String)

        'Debug.Print("CreateReport01 ..."
        Dim lsData = findReport4(criteria1, criteria2)
        If CInt(lsData.Count.ToString) > 0 Then
            Dim sReportTitle = "Details of ..."
            Dim sReportContent = generateReport(lsData, sReportTitle)
            Dim sReportFilename = "NumberOfBookings.html"
            saveReport(sReportContent, sReportFilename)
            Dim sParam As String = """" & Application.StartupPath & "\" & sReportFilename & """"
            Debug.Print("sParam: " & sParam)
            System.Diagnostics.Process.Start(sParam)
        Else
            MsgBox("There were no bookings made in the given time period.")
        End If

    End Sub

    Public Sub createReport05(ByVal criteria1 As String, ByVal criteria2 As String)

        'Debug.Print("CreateReport01 ..."
        Dim lsData = findReport5(criteria1, criteria2)
        If CInt(lsData.Count.ToString) > 0 Then
            Dim sReportTitle = "Details of ..."
            Dim sReportContent = generateReport(lsData, sReportTitle)
            Dim sReportFilename = "Tobecheckedin.html"
            saveReport(sReportContent, sReportFilename)
            Dim sParam As String = """" & Application.StartupPath & "\" & sReportFilename & """"
            Debug.Print("sParam: " & sParam)
            System.Diagnostics.Process.Start(sParam)
        Else
            MsgBox("There are no check-ins in the given time period.")
        End If

    End Sub

    Public Sub createReport06(ByVal criteria1 As String, ByVal criteria2 As String, ByVal criteria3 As String)

        'Debug.Print("CreateReport01 ..."
        Dim lsData = findReport6(criteria1, criteria2, criteria3)
        If CInt(lsData.Count.ToString) > 0 Then
            Dim sReportTitle = "Details of ..."
            Dim sReportContent = generateReport(lsData, sReportTitle)
            Dim sReportFilename = "BookingsperRoom.html"
            saveReport(sReportContent, sReportFilename)
            Dim sParam As String = """" & Application.StartupPath & "\" & sReportFilename & """"
            Debug.Print("sParam: " & sParam)
            System.Diagnostics.Process.Start(sParam)
        Else
            MsgBox("This room was not booked in the given time period.")
        End If

    End Sub

    Public Function findReport1(ByVal criteria As String) As List(Of Hashtable)

        Try
            oConnection.Open()
            lsData.Clear()
            Dim oCommand As OleDbCommand = New OleDbCommand
            oCommand.Connection = oConnection
            oCommand.CommandText = _
                "SELECT booking_id, booking_date, customer_id, num_days, checkin_date FROM booking where customer_id = ? and booking_date = (select max(booking_date) from booking where customer_id = ?);"
            oCommand.Parameters.Add("customer_id1", OleDbType.Integer, 8)
            oCommand.Parameters.Add("customer_id2", OleDbType.Integer, 8)
            oCommand.Parameters("customer_id1").Value = CInt(criteria)
            oCommand.Parameters("customer_id2").Value = CInt(criteria)
            oCommand.Prepare()
            Dim oDataReader = oCommand.ExecuteReader()
            Dim htData As Hashtable

            Do While oDataReader.Read() = True
                htData = New Hashtable
                htData("BookingId") = CStr(oDataReader("booking_id"))
                htData("BookingDate") = CStr(oDataReader("booking_date"))
                htData("CustomerId") = CStr(oDataReader("customer_id"))
                htData("NumDays") = CStr(oDataReader("num_days"))
                htData("CheckinDate") = CStr(oDataReader("checkin_date"))
                lsData.Add(htData)
            Loop

            'Set report index to be used when generating table
            reportIndex = 1

        Catch ex As Exception
            MsgBox("ERROR: " & ex.Message)

        Finally
            oConnection.Close()
        End Try
        Return lsData

    End Function

    Public Function findReport2(ByVal criteria As String) As List(Of Hashtable)

        Try
            oConnection.Open()
            lsData.Clear()
            Dim oCommand As OleDbCommand = New OleDbCommand
            oCommand.Connection = oConnection
            oCommand.CommandText = _
                "SELECT top 1 room_number, total_price, booking_date from room, booking where room.room_id = booking.room_id and booking.room_id = ? order by booking_date DESC;"
            oCommand.Parameters.Add("room_id", OleDbType.Integer, 8)
            oCommand.Parameters("room_id").Value = CInt(criteria)
            oCommand.Prepare()
            Dim oDataReader = oCommand.ExecuteReader()
            Dim htData As Hashtable

            Do While oDataReader.Read() = True
                htData = New Hashtable
                htData("RoomNumber") = CStr(oDataReader("room_number"))
                htData("TotalPrice") = CStr(oDataReader("total_price"))
                htData("BookingDate") = CStr(oDataReader("booking_date"))
                lsData.Add(htData)
            Loop

            'Set report index to be used when generating table
            reportIndex = 2

        Catch ex As Exception
            MsgBox("ERROR: " & ex.Message)

        Finally
            oConnection.Close()
        End Try
        Return lsData

    End Function

    Public Function findReport3(ByVal criteria1 As String, ByVal criteria2 As String, ByVal criteria3 As String) As List(Of Hashtable)

        Try
            oConnection.Open()
            lsData.Clear()
            Dim oCommand As OleDbCommand = New OleDbCommand
            oCommand.Connection = oConnection
            oCommand.CommandText = _
                "SELECT customer_id, count(room_id) as NumberofRoom from booking where customer_id = ? and month(booking_date) = ? and year(booking_date) = ? group by customer_id;"
            oCommand.Parameters.Add("customer_id", OleDbType.Integer, 8)
            oCommand.Parameters.Add("month(booking_date)", OleDbType.Integer, 8)
            oCommand.Parameters.Add("year(booking_date)", OleDbType.Integer, 8)

            oCommand.Parameters("customer_id").Value = CInt(criteria1)
            oCommand.Parameters("month(booking_date)").Value = CInt(criteria2)
            oCommand.Parameters("year(booking_date)").Value = CInt(criteria3)
            oCommand.Prepare()
            Dim oDataReader = oCommand.ExecuteReader()
            Dim htData As Hashtable

            Do While oDataReader.Read() = True
                htData = New Hashtable
                htData("CustomerId") = CStr(oDataReader("customer_id"))
                htData("NumberofRoom") = CStr(oDataReader("NumberofRoom"))
                lsData.Add(htData)
            Loop

            'Set report index to be used when generating table
            reportIndex = 3

        Catch ex As Exception
            MsgBox("ERROR: " & ex.Message)

        Finally
            oConnection.Close()
        End Try

        Return lsData

    End Function

    Public Function findReport4(ByVal criteria1 As String, ByVal criteria2 As String) As List(Of Hashtable)

        Try
            oConnection.Open()
            lsData.Clear()
            Dim oCommand As OleDbCommand = New OleDbCommand
            oCommand.Connection = oConnection
            oCommand.CommandText = _
                "SELECT booking_id, booking_date, room_id, customer_id, num_days, num_guests, checkin_date, total_price, comments from booking where month(booking_date) = ? and year(booking_date) = ?;"

            oCommand.Parameters.Add("month(booking_date)", OleDbType.Integer, 8)
            oCommand.Parameters.Add("year(booking_date)", OleDbType.Integer, 8)

            oCommand.Parameters("month(booking_date)").Value = CInt(criteria1)
            oCommand.Parameters("year(booking_date)").Value = CInt(criteria2)
            oCommand.Prepare()
            Dim oDataReader = oCommand.ExecuteReader()
            Dim htData As Hashtable

            'Assign hash with data from db
            Do While oDataReader.Read() = True
                htData = New Hashtable
                htData("BookingId") = CStr(oDataReader("booking_id"))
                htData("BookingDate") = CStr(oDataReader("booking_date"))
                htData("RoomId") = CStr(oDataReader("room_id"))
                htData("CustomerId") = CStr(oDataReader("customer_id"))
                htData("NumDays") = CStr(oDataReader("num_days"))
                htData("NumGuests") = CStr(oDataReader("num_guests"))
                htData("CheckinDate") = CStr(oDataReader("checkin_date"))
                htData("TotalPrice") = CStr(oDataReader("total_price"))
                htData("Comments") = CStr(oDataReader("comments"))
                lsData.Add(htData)
            Loop

            'Set report index to be used when generating table
            reportIndex = 4

        Catch ex As Exception
            MsgBox("ERROR: " & ex.Message)

        Finally
            oConnection.Close()
        End Try
        Return lsData

    End Function

    Public Function findReport5(ByVal criteria1 As String, ByVal criteria2 As String) As List(Of Hashtable)

        Try
            oConnection.Open()
            lsData.Clear()
            Dim oCommand As OleDbCommand = New OleDbCommand
            oCommand.Connection = oConnection
            oCommand.CommandText = _
                "SELECT booking.customer_id, customer.title, [firstname] & ' ' & [lastname] AS FullName, phone, email, booking_id, booking.booking_date, booking.checkin_date, room_number FROM customer, booking, room where customer.customer_id = booking.customer_id and booking.room_id = room.room_id and month(checkin_date) = ? and year(checkin_date) = ? order by booking.customer_id, checkin_date;"

            oCommand.Parameters.Add("month(checkin_date)", OleDbType.Integer, 8)
            oCommand.Parameters.Add("year(checkin_date)", OleDbType.Integer, 8)

            oCommand.Parameters("month(checkin_date)").Value = CInt(criteria1)
            oCommand.Parameters("year(checkin_date)").Value = CInt(criteria2)
            oCommand.Prepare()
            Dim oDataReader = oCommand.ExecuteReader()
            Dim htData As Hashtable

            Do While oDataReader.Read() = True
                htData = New Hashtable
                htData("CutomerId") = CStr(oDataReader("customer_id"))
                htData("Title") = CStr(oDataReader("title"))
                htData("FullName") = CStr(oDataReader("FullName"))
                htData("Phone") = CStr(oDataReader("phone"))
                htData("Email") = CStr(oDataReader("email"))
                htData("BookingId") = CStr(oDataReader("booking_id"))
                htData("BookingDate") = CStr(oDataReader("booking_date"))
                htData("CheckinDate") = CStr(oDataReader("checkin_date"))
                htData("RoomNumber") = CStr(oDataReader("room_number"))
                lsData.Add(htData)
            Loop

            'Set report index to be used when generating table
            reportIndex = 5

        Catch ex As Exception
            MsgBox("ERROR: " & ex.Message)

        Finally
            oConnection.Close()
        End Try
        Return lsData

    End Function

    Public Function findReport6(ByVal criteria1 As String, ByVal criteria2 As String, ByVal criteria3 As String) As List(Of Hashtable)

        Try
            oConnection.Open()
            lsData.Clear()
            Dim oCommand As OleDbCommand = New OleDbCommand
            oCommand.Connection = oConnection
            oCommand.CommandText = _
                "SELECT room.room_number, booking.booking_id, booking.booking_date, booking.customer_id, booking.num_days, booking.num_guests, booking.checkin_date, booking.total_price FROM room, booking WHERE room.room_id = booking.room_id AND room_number = ? AND month(booking_date) = ? and year(booking_date) = ?;"

            oCommand.Parameters.Add("room_number", OleDbType.Integer, 8)
            oCommand.Parameters.Add("month(booking_date)", OleDbType.Integer, 8)
            oCommand.Parameters.Add("year(booking_date)", OleDbType.Integer, 8)

            oCommand.Parameters("room_number").Value = CInt(criteria1)
            oCommand.Parameters("month(booking_date)").Value = CInt(criteria2)
            oCommand.Parameters("year(booking_date)").Value = CInt(criteria3)
            oCommand.Prepare()
            Dim oDataReader = oCommand.ExecuteReader()
            Dim htData As Hashtable

            Do While oDataReader.Read() = True
                htData = New Hashtable
                htData("RoomNumber") = CStr(oDataReader("room_number"))
                htData("BookingId") = CStr(oDataReader("booking_id"))
                htData("BookingDate") = CStr(oDataReader("booking_date"))
                htData("CustomerId") = CStr(oDataReader("customer_id"))
                htData("NumDays") = CStr(oDataReader("num_days"))
                htData("NumGuests") = CStr(oDataReader("num_guests"))
                htData("CheckinDate") = CStr(oDataReader("checkin_date"))
                htData("TotalPrice") = CStr(oDataReader("total_price"))
                lsData.Add(htData)
            Loop

            'Set report index to be used when generating table
            reportIndex = 6

        Catch ex As Exception
            MsgBox("ERROR: " & ex.Message)

        Finally
            oConnection.Close()
        End Try
        Return lsData

    End Function

    Private Function generateReport(ByVal lsData As List(Of Hashtable), ByVal sReportTitle As String) As String

        Dim sReportContent As String

        ' 1. Generate the start of the HTML file
        Dim sDoctype As String = "<!DOCTYPE html>"
        Dim sHtmlStartTag As String = "<html lang=""en"">"
        Dim sHeadTitle As String = "<head><title>" & sReportTitle & "</title></head>"
        Dim sBodyStartTag As String = "<body>"
        Dim sReportHeading As String = "<h1>" & sReportTitle & "</h1>"
        sReportContent = sDoctype & vbCrLf & sHtmlStartTag & vbCrLf & sHeadTitle & vbCrLf & sBodyStartTag & vbCrLf & sReportHeading & vbCrLf

        '2. Generate the product table and its rows
        'Dim sTable = "<table border=""1"">" & vbCrLf
        ''TODO - Construct the rows of the table
        'sTable &= "</table>"
        'sReportContent &= sTable & vbCrLf
        Dim sTable = generateTable(lsData)
        sReportContent &= sTable & vbCrLf

        '3. Generate the end of the HTML file
        Dim sBodyEndTag As String = "</body>"
        Dim sHTMLEndTag As String = "</html>"
        sReportContent &= sBodyEndTag & vbCrLf & sHTMLEndTag

        Return sReportContent


    End Function

    Private Function generateTable(ByVal lsData As List(Of Hashtable)) As String
        'Generate the start of the table
        Dim sTable = "<table border=""1"">" & vbCrLf
        Dim htSample As Hashtable = lsData.Item(0)

        Dim lsKeys As List(Of String) = New List(Of String)
        'Generate table according to the index specified in find function
        If reportIndex = 1 Then
            lsKeys.Add("BookingId")
            lsKeys.Add("BookingDate")
            lsKeys.Add("CustomerId")
            lsKeys.Add("NumDays")
            lsKeys.Add("CheckinDate")
        ElseIf reportIndex = 2 Then
            lsKeys.Add("RoomNumber")
            lsKeys.Add("TotalPrice")
            lsKeys.Add("BookingDate")
        ElseIf reportIndex = 3 Then
            lsKeys.Add("CustomerId")
            lsKeys.Add("NumberofRoom")
        ElseIf reportIndex = 4 Then
            lsKeys.Add("BookingId")
            lsKeys.Add("BookingDate")
            lsKeys.Add("RoomId")
            lsKeys.Add("CustomerId")
            lsKeys.Add("NumDays")
            lsKeys.Add("NumGuests")
            lsKeys.Add("CheckinDate")
            lsKeys.Add("TotalPrice")
            lsKeys.Add("Comments")
        ElseIf reportIndex = 5 Then
            lsKeys.Add("CutomerId")
            lsKeys.Add("Title")
            lsKeys.Add("FullName")
            lsKeys.Add("Phone")
            lsKeys.Add("Email")
            lsKeys.Add("BookingId")
            lsKeys.Add("BookingDate")
            lsKeys.Add("CheckinDate")
            lsKeys.Add("RoomNumber")
        ElseIf reportIndex = 6 Then
            lsKeys.Add("RoomNumber")
            lsKeys.Add("BookingId")
            lsKeys.Add("BookingDate")
            lsKeys.Add("CustomerId")
            lsKeys.Add("NumDays")
            lsKeys.Add("NumGuests")
            lsKeys.Add("CheckinDate")
            lsKeys.Add("TotalPrice")
        End If

        'Generate the header row
            Dim sHeaderRow = "<tr>" & vbCrLf
            For Each key In lsKeys
                sHeaderRow &= "<th>" & CStr(key) & "</th>" & vbCrLf
            Next
            sHeaderRow &= "</tr>" & vbCrLf
            Debug.Print("sHeaderRow: " & sHeaderRow)
            sTable &= sHeaderRow

            'Generate the table rows
            For Each record In lsData
                Dim product As Hashtable = record
                Dim sTableRow = "<tr>" & vbCrLf
                For Each key In lsKeys
                    sTableRow &= "<td>" & CStr(product(key)) & "</td>" & vbCrLf
                Next
                sTableRow &= "</tr>" & vbCrLf
                Debug.Print("sTableRow: " & sTableRow)
                sTable &= sTableRow
            Next

            'Generate the end of the table
            sTable &= "</table>" & vbCrLf
        
        Return sTable

    End Function

    Private Sub saveReport(ByVal sReportContent As String, ByVal sReportFilename As String)

        Debug.Print("saveReport: " & sReportFilename)
        Dim oReportFile As StreamWriter = New StreamWriter(Application.StartupPath & "\" & sReportFilename)

        'Check if the file is open before starting to write to it
        If Not (oReportFile Is Nothing) Then
            oReportFile.Write(sReportContent)
            oReportFile.Close()

        End If

    End Sub

End Class
