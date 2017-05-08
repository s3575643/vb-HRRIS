Option Explicit On
Option Strict On

Imports System.Data.OleDb
Imports System.IO

' Name: ControlBreakController.vb
' Description: Class for funtions to generate control break reports
' Author: Nguyen Anh Hoang Phuong
' Date: 02/05/2017

Public Class ControlBreakController

    Dim lsData As New List(Of Hashtable)
    Dim oConnection As OleDbConnection = New OleDbConnection(Controller.CONNECTION_STRING)
    Dim reportIndex As New Integer

    Public Sub createBreakReport1(ByVal criteria1 As String, ByVal criteria2 As String)
        Debug.Print("CreateBreakReport ...")

        Dim lsData = findCBReport1(criteria1, criteria2)
        If CInt(lsData.Count.ToString) > 0 Then
            Dim sReportTitle = "Product Control Break Report"
            Dim sReportContent = generateBreakReport(lsData, sReportTitle)
            Dim sReportFilename = "ControlBreakReport1.html"
            saveReport(sReportContent, sReportFilename)

            Dim sParam As String = """" & Application.StartupPath & "\" & sReportFilename & """"
            Debug.Print("sParam: " & sParam)
            System.Diagnostics.Process.Start(sParam)
        Else
            MsgBox("No bookings in the given time period.")
        End If
    End Sub

    Public Sub createBreakReport2()
        Debug.Print("CreateBreakReport ...")

        Dim lsData = findCBReport2()
        If CInt(lsData.Count.ToString) > 0 Then
            Dim sReportTitle = "Product Control Break Report"
            Dim sReportContent = generateBreakReport(lsData, sReportTitle)
            Dim sReportFilename = "ControlBreakReport2.html"
            saveReport(sReportContent, sReportFilename)

            Dim sParam As String = """" & Application.StartupPath & "\" & sReportFilename & """"
            Debug.Print("sParam: " & sParam)
            System.Diagnostics.Process.Start(sParam)
        Else
            MsgBox("No invoice generated yet this year.")
        End If
    End Sub

    Public Function findCBReport1(ByVal criteria1 As String, ByVal criteria2 As String) As List(Of Hashtable)

        Try
            oConnection.Open()
            lsData.Clear()
            Dim oCommand As OleDbCommand = New OleDbCommand
            oCommand.Connection = oConnection
            oCommand.CommandText = _
                "SELECT booking.room_id, room.room_number, booking.booking_date, booking.customer_id " & _
                "from booking, room where booking.room_id = room.room_id and month(booking_date) = ? and year(booking_date) = ?;"
            oCommand.Parameters.Add("month(booking_date)", OleDbType.Integer, 8)
            oCommand.Parameters.Add("year(booking_date)", OleDbType.Integer, 8)
            oCommand.Parameters("month(booking_date)").Value = CInt(criteria1)
            oCommand.Parameters("year(booking_date)").Value = CInt(criteria2)
            oCommand.Prepare()
            Dim oDataReader = oCommand.ExecuteReader()
            Dim htData As Hashtable

            Do While oDataReader.Read() = True
                htData = New Hashtable
                htData("RoomId") = CStr(oDataReader("room_id"))
                htData("RoomNumber") = CStr(oDataReader("room_number"))
                htData("BookingDate") = CStr(oDataReader("booking_date"))
                htData("CustomerId") = CStr(oDataReader("customer_id"))
                lsData.Add(htData)
            Loop

            reportIndex = 1

        Catch ex As Exception
            Debug.Print("ERROR: " & ex.Message)
            MsgBox("An error occured!")

        Finally
            oConnection.Close()
        End Try
        Return lsData

    End Function

    Public Function findCBReport2() As List(Of Hashtable)

        Try
            oConnection.Open()
            lsData.Clear()
            Dim oCommand As OleDbCommand = New OleDbCommand
            oCommand.Connection = oConnection
            oCommand.CommandText = _
                "select booking_id, issued_date, amount from invoice where year(issued_date) = year(now);"
            oCommand.Prepare()
            Dim oDataReader = oCommand.ExecuteReader()
            Dim htData As Hashtable

            Do While oDataReader.Read() = True
                htData = New Hashtable
                htData("BookingId") = CStr(oDataReader("booking_id"))
                htData("IssuedDate") = CStr(oDataReader("issued_date"))
                htData("Amount") = CStr(oDataReader("amount"))
                lsData.Add(htData)
            Loop

            reportIndex = 2

        Catch ex As Exception
            Debug.Print("ERROR: " & ex.Message)
            MsgBox("An error occured!")

        Finally
            oConnection.Close()
        End Try
        Return lsData

    End Function

    Private Function generateBreakReport(ByVal lsData As List(Of Hashtable), ByVal sReportTitle As String) As String
        Debug.Print("GenerateBreakReport ...")

        Dim sReportContent As String

        ' 1. Generate the start of the HTML file
        Dim sDoctype As String = "<!DOCTYPE html>"
        Dim sHtmlStartTag As String = "<html lang=""en"">"
        Dim sHeadTitle As String = "<head><title>" & sReportTitle & "</title></head>"
        Dim sBodyStartTag As String = "<body>"
        Dim sReportHeading As String = "</h1>" & sReportTitle & "</h1>"
        sReportContent = sDoctype & vbCrLf & sHtmlStartTag & vbCrLf & sHeadTitle _
         & vbCrLf & sBodyStartTag & vbCrLf & sReportHeading & vbCrLf

        ' 2. Generate the product table and its rows
        Dim sTable = generateControlBreakTable(lsData)
        sReportContent &= sTable & vbCrLf

        ' 3. Generate the end of the HTML file
        Dim sBodyEndTag As String = "</body>"
        Dim sHTMLEndTag As String = "</html>"
        sReportContent &= sBodyEndTag & vbCrLf & sHTMLEndTag

        Return sReportContent

    End Function

    Private Function generateControlBreakTable(ByVal lsData As List(Of Hashtable)) As String

        ' Generate the start of the table
        Dim sTable = "<table border=""1"">" & vbCrLf
        Dim htSample As Hashtable = lsData.Item(0)
        'Dim lsKeys = htSample.Keys
        Dim lsKeys As List(Of String) = New List(Of String)
        If reportIndex = 1 Then
            lsKeys.Add("RoomId")
            lsKeys.Add("RoomNumber")
            lsKeys.Add("BookingDate")
            lsKeys.Add("CustomerId")
        ElseIf reportIndex = 2 Then
            lsKeys.Add("BookingId")
            lsKeys.Add("IssuedDate")
            lsKeys.Add("Amount")
        End If
        ' Generate the header row
        Dim sHeaderRow = "<tr>" & vbCrLf
        For Each key In lsKeys
            sHeaderRow &= "<th>" & CStr(key) & "</th>" & vbCrLf
        Next
        sHeaderRow &= "</tr>" & vbCrLf
        Debug.Print("sHeaderRow: " & sHeaderRow)
        sTable &= sHeaderRow

        ' Generate the table rows
        If reportIndex = 1 Then
            sTable &= generateTableRows1(lsData, lsKeys)
        Else
            sTable &= generateTableRows2(lsData, lsKeys)
        End If


        ' Generate the end of the table
        sTable &= "</table>" & vbCrLf

        Return sTable

    End Function

    Private Function generateTableRows1(ByVal lsData As List(Of Hashtable), _
                                           ByVal lsKeys As List(Of String)) As String

        '1. Initialisation
        Dim sRows As String = ""
        Dim sTableRow As String
        Dim iCountRecordsPerCategory As Integer = 0
        Dim bFirstTime As Boolean = True
        Dim sCurrentControlField As String = ""
        Dim sPreviousControlField As String = ""

        '2. Loop through the list of hashtables
        For Each record In lsData

            '2a. Get a product and set the current key
            Dim booking As Hashtable = record
            sCurrentControlField = CStr(booking("RoomNumber"))

            '2b. Do not check for control break on the first iteration of the loop
            If bFirstTime Then
                bFirstTime = False
            Else
                'Output total row if change in control field
                'And reset the total
                If sCurrentControlField <> sPreviousControlField Then
                    sTableRow = "<tr><td colspan = """ & lsKeys.Count & """>" _
                        & " Total products in " & sPreviousControlField _
                        & " category: " & iCountRecordsPerCategory _
                        & "</td></tr>" _
                        & vbCrLf
                    sRows &= sTableRow
                    iCountRecordsPerCategory = 0
                End If
            End If

            ' 2c. Output a normal row for every pass thru' the list
            sTableRow = "<tr>" & vbCrLf
            For Each key In lsKeys
                sTableRow &= "<td>" & CStr(booking(key)) & "</td>" & vbCrLf
            Next
            sTableRow &= "</tr>" & vbCrLf
            Debug.Print("sTableRow: " & sTableRow)
            sRows &= sTableRow

            '2d. Update control field and increment total
            sPreviousControlField = sCurrentControlField
            iCountRecordsPerCategory += 1
        Next

        '3. After the loop, need to output the last total row
        sTableRow = "<tr><td colspan = """ & lsKeys.Count & """>" _
                        & " Total products in " & sCurrentControlField _
                        & " category: " & iCountRecordsPerCategory _
                        & "</td></tr>" _
                        & vbCrLf
        sRows &= sTableRow

        Return sRows

    End Function

    Private Function generateTableRows2(ByVal lsData As List(Of Hashtable), _
                                           ByVal lsKeys As List(Of String)) As String

        '1. Initialisation
        Dim sRows As String = ""
        Dim sTableRow As String
        Dim iCountRecordsPerCategory As Integer = 0
        Dim bFirstTime As Boolean = True
        Dim sCurrentControlField As String = ""
        Dim sPreviousControlField As String = ""

        '2. Loop through the list of hashtables
        For Each record In lsData

            '2a. Get a product and set the current key
            Dim invoice As Hashtable = record
            sCurrentControlField = CStr(Month(CDate(invoice("issueddate"))))

            '2b. Do not check for control break on the first iteration of the loop
            If bFirstTime Then
                bFirstTime = False
            Else
                'Output total row if change in control field
                'And reset the total
                If sCurrentControlField <> sPreviousControlField Then
                    sTableRow = "<tr><td colspan = """ & lsKeys.Count & """>" _
                        & " Total products in " & sPreviousControlField _
                        & " category: " & iCountRecordsPerCategory _
                        & "</td></tr>" _
                        & vbCrLf
                    sRows &= sTableRow
                    iCountRecordsPerCategory = 0
                End If
            End If

            ' 2c. Output a normal row for every pass thru' the list
            sTableRow = "<tr>" & vbCrLf
            For Each key In lsKeys
                sTableRow &= "<td>" & CStr(invoice(key)) & "</td>" & vbCrLf
            Next
            sTableRow &= "</tr>" & vbCrLf
            Debug.Print("sTableRow: " & sTableRow)
            sRows &= sTableRow

            '2d. Update control field and increment total
            sPreviousControlField = sCurrentControlField
            iCountRecordsPerCategory += 1
        Next

        '3. After the loop, need to output the last total row
        sTableRow = "<tr><td colspan = """ & lsKeys.Count & """>" _
                        & " Total products in " & sCurrentControlField _
                        & " category: " & iCountRecordsPerCategory _
                        & "</td></tr>" _
                        & vbCrLf
        sRows &= sTableRow

        Return sRows

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
