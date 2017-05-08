<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBookingEdit
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.txtCmt = New System.Windows.Forms.TextBox()
        Me.BookingBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me._s3575643_HRRIS_DbDataSetBook = New s3575643_Assignment01_HRRIS._s3575643_HRRIS_DbDataSetBook()
        Me.bookdatePicker = New System.Windows.Forms.DateTimePicker()
        Me.checkindatePicker = New System.Windows.Forms.DateTimePicker()
        Me.lblBookDate = New System.Windows.Forms.Label()
        Me.lblTotalPrice = New System.Windows.Forms.Label()
        Me.lblCmt = New System.Windows.Forms.Label()
        Me.lblNum_guests = New System.Windows.Forms.Label()
        Me.lblCheckinDate = New System.Windows.Forms.Label()
        Me.lblNum_days = New System.Windows.Forms.Label()
        Me.lblCus_id = New System.Windows.Forms.Label()
        Me.lblRoom_id = New System.Windows.Forms.Label()
        Me.txtNumGuests = New System.Windows.Forms.TextBox()
        Me.txtNumDays = New System.Windows.Forms.TextBox()
        Me.txttotalPrice = New System.Windows.Forms.TextBox()
        Me.txtCusID = New System.Windows.Forms.TextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.NewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.newCustomerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.newRoomToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.newBookingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InvoiceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CustomerToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.RoomToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.BookingToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GeneralReportsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ControlBreakReportsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewHelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnUpdateBooking = New System.Windows.Forms.Button()
        Me.editBookGrid = New System.Windows.Forms.DataGridView()
        Me.BookingidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BookingdateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RoomidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustomeridDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NumdaysDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NumguestsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CheckindateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalpriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CommentsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cbRoomID = New System.Windows.Forms.ComboBox()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.btnDelCus = New System.Windows.Forms.Button()
        Me.lblBookingId = New System.Windows.Forms.Label()
        Me.txtBookingId = New System.Windows.Forms.TextBox()
        Me.btnFirst = New System.Windows.Forms.Button()
        Me.btnLast = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnPrev = New System.Windows.Forms.Button()
        Me.BookingTableAdapter = New s3575643_Assignment01_HRRIS._s3575643_HRRIS_DbDataSetBookTableAdapters.bookingTableAdapter()
        CType(Me.BookingBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._s3575643_HRRIS_DbDataSetBook, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.editBookGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtCmt
        '
        Me.txtCmt.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BookingBindingSource, "comments", True))
        Me.txtCmt.Location = New System.Drawing.Point(135, 343)
        Me.txtCmt.Multiline = True
        Me.txtCmt.Name = "txtCmt"
        Me.txtCmt.Size = New System.Drawing.Size(196, 60)
        Me.txtCmt.TabIndex = 9
        '
        'BookingBindingSource
        '
        Me.BookingBindingSource.DataMember = "booking"
        Me.BookingBindingSource.DataSource = Me._s3575643_HRRIS_DbDataSetBook
        '
        '_s3575643_HRRIS_DbDataSetBook
        '
        Me._s3575643_HRRIS_DbDataSetBook.DataSetName = "_s3575643_HRRIS_DbDataSetBook"
        Me._s3575643_HRRIS_DbDataSetBook.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'bookdatePicker
        '
        Me.bookdatePicker.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BookingBindingSource, "booking_date", True))
        Me.bookdatePicker.Location = New System.Drawing.Point(135, 76)
        Me.bookdatePicker.Name = "bookdatePicker"
        Me.bookdatePicker.Size = New System.Drawing.Size(196, 20)
        Me.bookdatePicker.TabIndex = 2
        '
        'checkindatePicker
        '
        Me.checkindatePicker.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BookingBindingSource, "checkin_date", True))
        Me.checkindatePicker.Location = New System.Drawing.Point(135, 264)
        Me.checkindatePicker.MinDate = New Date(2017, 3, 31, 0, 0, 0, 0)
        Me.checkindatePicker.Name = "checkindatePicker"
        Me.checkindatePicker.Size = New System.Drawing.Size(196, 20)
        Me.checkindatePicker.TabIndex = 7
        '
        'lblBookDate
        '
        Me.lblBookDate.AutoSize = True
        Me.lblBookDate.Location = New System.Drawing.Point(38, 82)
        Me.lblBookDate.Name = "lblBookDate"
        Me.lblBookDate.Size = New System.Drawing.Size(72, 13)
        Me.lblBookDate.TabIndex = 51
        Me.lblBookDate.Text = "Booking Date"
        '
        'lblTotalPrice
        '
        Me.lblTotalPrice.AutoSize = True
        Me.lblTotalPrice.Location = New System.Drawing.Point(38, 310)
        Me.lblTotalPrice.Name = "lblTotalPrice"
        Me.lblTotalPrice.Size = New System.Drawing.Size(58, 13)
        Me.lblTotalPrice.TabIndex = 50
        Me.lblTotalPrice.Text = "Total Price"
        '
        'lblCmt
        '
        Me.lblCmt.AutoSize = True
        Me.lblCmt.Location = New System.Drawing.Point(38, 346)
        Me.lblCmt.Name = "lblCmt"
        Me.lblCmt.Size = New System.Drawing.Size(56, 13)
        Me.lblCmt.TabIndex = 49
        Me.lblCmt.Text = "Comments"
        '
        'lblNum_guests
        '
        Me.lblNum_guests.AutoSize = True
        Me.lblNum_guests.Location = New System.Drawing.Point(38, 234)
        Me.lblNum_guests.Name = "lblNum_guests"
        Me.lblNum_guests.Size = New System.Drawing.Size(92, 13)
        Me.lblNum_guests.TabIndex = 48
        Me.lblNum_guests.Text = "Number of Guests"
        '
        'lblCheckinDate
        '
        Me.lblCheckinDate.AutoSize = True
        Me.lblCheckinDate.Location = New System.Drawing.Point(38, 270)
        Me.lblCheckinDate.Name = "lblCheckinDate"
        Me.lblCheckinDate.Size = New System.Drawing.Size(72, 13)
        Me.lblCheckinDate.TabIndex = 47
        Me.lblCheckinDate.Text = "Checkin Date"
        '
        'lblNum_days
        '
        Me.lblNum_days.AutoSize = True
        Me.lblNum_days.Location = New System.Drawing.Point(38, 197)
        Me.lblNum_days.Name = "lblNum_days"
        Me.lblNum_days.Size = New System.Drawing.Size(83, 13)
        Me.lblNum_days.TabIndex = 46
        Me.lblNum_days.Text = "Number of Days"
        '
        'lblCus_id
        '
        Me.lblCus_id.AutoSize = True
        Me.lblCus_id.Location = New System.Drawing.Point(38, 160)
        Me.lblCus_id.Name = "lblCus_id"
        Me.lblCus_id.Size = New System.Drawing.Size(65, 13)
        Me.lblCus_id.TabIndex = 45
        Me.lblCus_id.Text = "Customer ID"
        '
        'lblRoom_id
        '
        Me.lblRoom_id.AutoSize = True
        Me.lblRoom_id.Location = New System.Drawing.Point(38, 121)
        Me.lblRoom_id.Name = "lblRoom_id"
        Me.lblRoom_id.Size = New System.Drawing.Size(49, 13)
        Me.lblRoom_id.TabIndex = 44
        Me.lblRoom_id.Text = "Room ID"
        '
        'txtNumGuests
        '
        Me.txtNumGuests.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BookingBindingSource, "num_guests", True))
        Me.txtNumGuests.Location = New System.Drawing.Point(135, 231)
        Me.txtNumGuests.Name = "txtNumGuests"
        Me.txtNumGuests.Size = New System.Drawing.Size(81, 20)
        Me.txtNumGuests.TabIndex = 6
        '
        'txtNumDays
        '
        Me.txtNumDays.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BookingBindingSource, "num_days", True))
        Me.txtNumDays.Location = New System.Drawing.Point(135, 194)
        Me.txtNumDays.Name = "txtNumDays"
        Me.txtNumDays.Size = New System.Drawing.Size(81, 20)
        Me.txtNumDays.TabIndex = 5
        '
        'txttotalPrice
        '
        Me.txttotalPrice.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BookingBindingSource, "total_price", True))
        Me.txttotalPrice.Location = New System.Drawing.Point(135, 307)
        Me.txttotalPrice.Name = "txttotalPrice"
        Me.txttotalPrice.ReadOnly = True
        Me.txttotalPrice.Size = New System.Drawing.Size(196, 20)
        Me.txttotalPrice.TabIndex = 8
        '
        'txtCusID
        '
        Me.txtCusID.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BookingBindingSource, "customer_id", True))
        Me.txtCusID.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtCusID.Location = New System.Drawing.Point(135, 157)
        Me.txtCusID.Name = "txtCusID"
        Me.txtCusID.Size = New System.Drawing.Size(196, 20)
        Me.txtCusID.TabIndex = 4
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripMenuItem, Me.EditToolStripMenuItem, Me.ReportToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1184, 24)
        Me.MenuStrip1.TabIndex = 52
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'NewToolStripMenuItem
        '
        Me.NewToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.newCustomerToolStripMenuItem, Me.newRoomToolStripMenuItem, Me.newBookingToolStripMenuItem, Me.InvoiceToolStripMenuItem})
        Me.NewToolStripMenuItem.Name = "NewToolStripMenuItem"
        Me.NewToolStripMenuItem.Size = New System.Drawing.Size(43, 20)
        Me.NewToolStripMenuItem.Text = "New"
        '
        'newCustomerToolStripMenuItem
        '
        Me.newCustomerToolStripMenuItem.Name = "newCustomerToolStripMenuItem"
        Me.newCustomerToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
        Me.newCustomerToolStripMenuItem.Text = "Customer"
        '
        'newRoomToolStripMenuItem
        '
        Me.newRoomToolStripMenuItem.Name = "newRoomToolStripMenuItem"
        Me.newRoomToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
        Me.newRoomToolStripMenuItem.Text = "Room"
        '
        'newBookingToolStripMenuItem
        '
        Me.newBookingToolStripMenuItem.Name = "newBookingToolStripMenuItem"
        Me.newBookingToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
        Me.newBookingToolStripMenuItem.Text = "Booking"
        '
        'InvoiceToolStripMenuItem
        '
        Me.InvoiceToolStripMenuItem.Name = "InvoiceToolStripMenuItem"
        Me.InvoiceToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
        Me.InvoiceToolStripMenuItem.Text = "Invoice"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CustomerToolStripMenuItem1, Me.RoomToolStripMenuItem1, Me.BookingToolStripMenuItem1})
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(39, 20)
        Me.EditToolStripMenuItem.Text = "Edit"
        '
        'CustomerToolStripMenuItem1
        '
        Me.CustomerToolStripMenuItem1.Name = "CustomerToolStripMenuItem1"
        Me.CustomerToolStripMenuItem1.Size = New System.Drawing.Size(126, 22)
        Me.CustomerToolStripMenuItem1.Text = "Customer"
        '
        'RoomToolStripMenuItem1
        '
        Me.RoomToolStripMenuItem1.Name = "RoomToolStripMenuItem1"
        Me.RoomToolStripMenuItem1.Size = New System.Drawing.Size(126, 22)
        Me.RoomToolStripMenuItem1.Text = "Room"
        '
        'BookingToolStripMenuItem1
        '
        Me.BookingToolStripMenuItem1.Enabled = False
        Me.BookingToolStripMenuItem1.Name = "BookingToolStripMenuItem1"
        Me.BookingToolStripMenuItem1.Size = New System.Drawing.Size(126, 22)
        Me.BookingToolStripMenuItem1.Text = "Booking"
        '
        'ReportToolStripMenuItem
        '
        Me.ReportToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GeneralReportsToolStripMenuItem, Me.ControlBreakReportsToolStripMenuItem})
        Me.ReportToolStripMenuItem.Name = "ReportToolStripMenuItem"
        Me.ReportToolStripMenuItem.Size = New System.Drawing.Size(54, 20)
        Me.ReportToolStripMenuItem.Text = "Report"
        '
        'GeneralReportsToolStripMenuItem
        '
        Me.GeneralReportsToolStripMenuItem.Name = "GeneralReportsToolStripMenuItem"
        Me.GeneralReportsToolStripMenuItem.Size = New System.Drawing.Size(179, 22)
        Me.GeneralReportsToolStripMenuItem.Text = "Operational Reports"
        '
        'ControlBreakReportsToolStripMenuItem
        '
        Me.ControlBreakReportsToolStripMenuItem.Name = "ControlBreakReportsToolStripMenuItem"
        Me.ControlBreakReportsToolStripMenuItem.Size = New System.Drawing.Size(179, 22)
        Me.ControlBreakReportsToolStripMenuItem.Text = "Summary Reports"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ViewHelpToolStripMenuItem, Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'ViewHelpToolStripMenuItem
        '
        Me.ViewHelpToolStripMenuItem.Name = "ViewHelpToolStripMenuItem"
        Me.ViewHelpToolStripMenuItem.Size = New System.Drawing.Size(127, 22)
        Me.ViewHelpToolStripMenuItem.Text = "View Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(127, 22)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'btnUpdateBooking
        '
        Me.btnUpdateBooking.Location = New System.Drawing.Point(380, 419)
        Me.btnUpdateBooking.Name = "btnUpdateBooking"
        Me.btnUpdateBooking.Size = New System.Drawing.Size(75, 23)
        Me.btnUpdateBooking.TabIndex = 10
        Me.btnUpdateBooking.Text = "Update"
        Me.btnUpdateBooking.UseVisualStyleBackColor = True
        '
        'editBookGrid
        '
        Me.editBookGrid.AutoGenerateColumns = False
        Me.editBookGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.editBookGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.BookingidDataGridViewTextBoxColumn, Me.BookingdateDataGridViewTextBoxColumn, Me.RoomidDataGridViewTextBoxColumn, Me.CustomeridDataGridViewTextBoxColumn, Me.NumdaysDataGridViewTextBoxColumn, Me.NumguestsDataGridViewTextBoxColumn, Me.CheckindateDataGridViewTextBoxColumn, Me.TotalpriceDataGridViewTextBoxColumn, Me.CommentsDataGridViewTextBoxColumn})
        Me.editBookGrid.DataSource = Me.BookingBindingSource
        Me.editBookGrid.Location = New System.Drawing.Point(380, 42)
        Me.editBookGrid.Name = "editBookGrid"
        Me.editBookGrid.ReadOnly = True
        Me.editBookGrid.Size = New System.Drawing.Size(764, 361)
        Me.editBookGrid.TabIndex = 44
        '
        'BookingidDataGridViewTextBoxColumn
        '
        Me.BookingidDataGridViewTextBoxColumn.DataPropertyName = "booking_id"
        Me.BookingidDataGridViewTextBoxColumn.HeaderText = "booking_id"
        Me.BookingidDataGridViewTextBoxColumn.Name = "BookingidDataGridViewTextBoxColumn"
        Me.BookingidDataGridViewTextBoxColumn.ReadOnly = True
        '
        'BookingdateDataGridViewTextBoxColumn
        '
        Me.BookingdateDataGridViewTextBoxColumn.DataPropertyName = "booking_date"
        Me.BookingdateDataGridViewTextBoxColumn.HeaderText = "booking_date"
        Me.BookingdateDataGridViewTextBoxColumn.Name = "BookingdateDataGridViewTextBoxColumn"
        Me.BookingdateDataGridViewTextBoxColumn.ReadOnly = True
        '
        'RoomidDataGridViewTextBoxColumn
        '
        Me.RoomidDataGridViewTextBoxColumn.DataPropertyName = "room_id"
        Me.RoomidDataGridViewTextBoxColumn.HeaderText = "room_id"
        Me.RoomidDataGridViewTextBoxColumn.Name = "RoomidDataGridViewTextBoxColumn"
        Me.RoomidDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CustomeridDataGridViewTextBoxColumn
        '
        Me.CustomeridDataGridViewTextBoxColumn.DataPropertyName = "customer_id"
        Me.CustomeridDataGridViewTextBoxColumn.HeaderText = "customer_id"
        Me.CustomeridDataGridViewTextBoxColumn.Name = "CustomeridDataGridViewTextBoxColumn"
        Me.CustomeridDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NumdaysDataGridViewTextBoxColumn
        '
        Me.NumdaysDataGridViewTextBoxColumn.DataPropertyName = "num_days"
        Me.NumdaysDataGridViewTextBoxColumn.HeaderText = "num_days"
        Me.NumdaysDataGridViewTextBoxColumn.Name = "NumdaysDataGridViewTextBoxColumn"
        Me.NumdaysDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NumguestsDataGridViewTextBoxColumn
        '
        Me.NumguestsDataGridViewTextBoxColumn.DataPropertyName = "num_guests"
        Me.NumguestsDataGridViewTextBoxColumn.HeaderText = "num_guests"
        Me.NumguestsDataGridViewTextBoxColumn.Name = "NumguestsDataGridViewTextBoxColumn"
        Me.NumguestsDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CheckindateDataGridViewTextBoxColumn
        '
        Me.CheckindateDataGridViewTextBoxColumn.DataPropertyName = "checkin_date"
        Me.CheckindateDataGridViewTextBoxColumn.HeaderText = "checkin_date"
        Me.CheckindateDataGridViewTextBoxColumn.Name = "CheckindateDataGridViewTextBoxColumn"
        Me.CheckindateDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TotalpriceDataGridViewTextBoxColumn
        '
        Me.TotalpriceDataGridViewTextBoxColumn.DataPropertyName = "total_price"
        Me.TotalpriceDataGridViewTextBoxColumn.HeaderText = "total_price"
        Me.TotalpriceDataGridViewTextBoxColumn.Name = "TotalpriceDataGridViewTextBoxColumn"
        Me.TotalpriceDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CommentsDataGridViewTextBoxColumn
        '
        Me.CommentsDataGridViewTextBoxColumn.DataPropertyName = "comments"
        Me.CommentsDataGridViewTextBoxColumn.HeaderText = "comments"
        Me.CommentsDataGridViewTextBoxColumn.Name = "CommentsDataGridViewTextBoxColumn"
        Me.CommentsDataGridViewTextBoxColumn.ReadOnly = True
        '
        'cbRoomID
        '
        Me.cbRoomID.DataSource = Me.BookingBindingSource
        Me.cbRoomID.DisplayMember = "room_id"
        Me.cbRoomID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbRoomID.FormattingEnabled = True
        Me.cbRoomID.Location = New System.Drawing.Point(135, 113)
        Me.cbRoomID.Name = "cbRoomID"
        Me.cbRoomID.Size = New System.Drawing.Size(196, 21)
        Me.cbRoomID.TabIndex = 3
        Me.cbRoomID.ValueMember = "room_id"
        '
        'btnRefresh
        '
        Me.btnRefresh.Location = New System.Drawing.Point(1071, 419)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(75, 23)
        Me.btnRefresh.TabIndex = 14
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(976, 419)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(75, 23)
        Me.btnSearch.TabIndex = 13
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(734, 421)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(220, 20)
        Me.txtSearch.TabIndex = 12
        '
        'btnDelCus
        '
        Me.btnDelCus.Location = New System.Drawing.Point(480, 419)
        Me.btnDelCus.Name = "btnDelCus"
        Me.btnDelCus.Size = New System.Drawing.Size(75, 23)
        Me.btnDelCus.TabIndex = 11
        Me.btnDelCus.Text = "Delete"
        Me.btnDelCus.UseVisualStyleBackColor = True
        '
        'lblBookingId
        '
        Me.lblBookingId.AutoSize = True
        Me.lblBookingId.Location = New System.Drawing.Point(38, 45)
        Me.lblBookingId.Name = "lblBookingId"
        Me.lblBookingId.Size = New System.Drawing.Size(60, 13)
        Me.lblBookingId.TabIndex = 61
        Me.lblBookingId.Text = "Booking ID"
        '
        'txtBookingId
        '
        Me.txtBookingId.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BookingBindingSource, "booking_id", True))
        Me.txtBookingId.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtBookingId.Location = New System.Drawing.Point(135, 42)
        Me.txtBookingId.Name = "txtBookingId"
        Me.txtBookingId.ReadOnly = True
        Me.txtBookingId.Size = New System.Drawing.Size(196, 20)
        Me.txtBookingId.TabIndex = 1
        '
        'btnFirst
        '
        Me.btnFirst.Location = New System.Drawing.Point(41, 419)
        Me.btnFirst.Name = "btnFirst"
        Me.btnFirst.Size = New System.Drawing.Size(50, 23)
        Me.btnFirst.TabIndex = 1
        Me.btnFirst.Text = "|<"
        Me.btnFirst.UseVisualStyleBackColor = True
        '
        'btnLast
        '
        Me.btnLast.Location = New System.Drawing.Point(281, 419)
        Me.btnLast.Name = "btnLast"
        Me.btnLast.Size = New System.Drawing.Size(50, 23)
        Me.btnLast.TabIndex = 14
        Me.btnLast.Text = ">|"
        Me.btnLast.UseVisualStyleBackColor = True
        '
        'btnNext
        '
        Me.btnNext.Location = New System.Drawing.Point(202, 419)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(50, 23)
        Me.btnNext.TabIndex = 13
        Me.btnNext.Text = ">"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'btnPrev
        '
        Me.btnPrev.Location = New System.Drawing.Point(123, 419)
        Me.btnPrev.Name = "btnPrev"
        Me.btnPrev.Size = New System.Drawing.Size(50, 23)
        Me.btnPrev.TabIndex = 2
        Me.btnPrev.Text = "<"
        Me.btnPrev.UseVisualStyleBackColor = True
        '
        'BookingTableAdapter
        '
        Me.BookingTableAdapter.ClearBeforeFill = True
        '
        'frmBookingEdit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1184, 462)
        Me.Controls.Add(Me.btnPrev)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.btnLast)
        Me.Controls.Add(Me.btnFirst)
        Me.Controls.Add(Me.lblBookingId)
        Me.Controls.Add(Me.txtBookingId)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.btnDelCus)
        Me.Controls.Add(Me.cbRoomID)
        Me.Controls.Add(Me.btnUpdateBooking)
        Me.Controls.Add(Me.editBookGrid)
        Me.Controls.Add(Me.txtCmt)
        Me.Controls.Add(Me.bookdatePicker)
        Me.Controls.Add(Me.checkindatePicker)
        Me.Controls.Add(Me.lblBookDate)
        Me.Controls.Add(Me.lblTotalPrice)
        Me.Controls.Add(Me.lblCmt)
        Me.Controls.Add(Me.lblNum_guests)
        Me.Controls.Add(Me.lblCheckinDate)
        Me.Controls.Add(Me.lblNum_days)
        Me.Controls.Add(Me.lblCus_id)
        Me.Controls.Add(Me.lblRoom_id)
        Me.Controls.Add(Me.txtNumGuests)
        Me.Controls.Add(Me.txtNumDays)
        Me.Controls.Add(Me.txttotalPrice)
        Me.Controls.Add(Me.txtCusID)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximumSize = New System.Drawing.Size(1200, 500)
        Me.MinimumSize = New System.Drawing.Size(1200, 500)
        Me.Name = "frmBookingEdit"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmBookingEdit"
        CType(Me.BookingBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._s3575643_HRRIS_DbDataSetBook, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.editBookGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtCmt As System.Windows.Forms.TextBox
    Friend WithEvents bookdatePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents checkindatePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblBookDate As System.Windows.Forms.Label
    Friend WithEvents lblTotalPrice As System.Windows.Forms.Label
    Friend WithEvents lblCmt As System.Windows.Forms.Label
    Friend WithEvents lblNum_guests As System.Windows.Forms.Label
    Friend WithEvents lblCheckinDate As System.Windows.Forms.Label
    Friend WithEvents lblNum_days As System.Windows.Forms.Label
    Friend WithEvents lblCus_id As System.Windows.Forms.Label
    Friend WithEvents lblRoom_id As System.Windows.Forms.Label
    Friend WithEvents txtNumGuests As System.Windows.Forms.TextBox
    Friend WithEvents txtNumDays As System.Windows.Forms.TextBox
    Friend WithEvents txttotalPrice As System.Windows.Forms.TextBox
    Friend WithEvents txtCusID As System.Windows.Forms.TextBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents NewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents newCustomerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents newRoomToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents newBookingToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CustomerToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RoomToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BookingToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReportToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewHelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnUpdateBooking As System.Windows.Forms.Button
    Friend WithEvents editBookGrid As System.Windows.Forms.DataGridView
    Friend WithEvents InvoiceToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cbRoomID As System.Windows.Forms.ComboBox
    Friend WithEvents btnRefresh As System.Windows.Forms.Button
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents btnDelCus As System.Windows.Forms.Button
    Friend WithEvents lblBookingId As System.Windows.Forms.Label
    Friend WithEvents txtBookingId As System.Windows.Forms.TextBox
    Friend WithEvents btnFirst As System.Windows.Forms.Button
    Friend WithEvents btnLast As System.Windows.Forms.Button
    Friend WithEvents btnNext As System.Windows.Forms.Button
    Friend WithEvents btnPrev As System.Windows.Forms.Button
    Friend WithEvents _s3575643_HRRIS_DbDataSetBook As s3575643_Assignment01_HRRIS._s3575643_HRRIS_DbDataSetBook
    Friend WithEvents BookingBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BookingTableAdapter As s3575643_Assignment01_HRRIS._s3575643_HRRIS_DbDataSetBookTableAdapters.bookingTableAdapter
    Friend WithEvents BookingidDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BookingdateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RoomidDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CustomeridDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NumdaysDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NumguestsDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CheckindateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TotalpriceDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CommentsDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GeneralReportsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ControlBreakReportsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
