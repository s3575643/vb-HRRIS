<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBookingNew
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
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.checkindatePicker = New System.Windows.Forms.DateTimePicker()
        Me.cbRoomID = New System.Windows.Forms.ComboBox()
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
        Me.bookdatePicker = New System.Windows.Forms.DateTimePicker()
        Me.txtCmt = New System.Windows.Forms.TextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.NewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CustomerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RoomToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BookingToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.InvoiceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CustomerToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.RoomToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.BookingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GeneralReportsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ControlBreakReportsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewHelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ttInfo = New System.Windows.Forms.ToolTip(Me.components)
        Me.ttCusIDError = New System.Windows.Forms.ToolTip(Me.components)
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(111, 417)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(145, 25)
        Me.btnCancel.TabIndex = 9
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(39, 386)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(290, 25)
        Me.btnSave.TabIndex = 8
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'checkindatePicker
        '
        Me.checkindatePicker.Location = New System.Drawing.Point(133, 224)
        Me.checkindatePicker.MinDate = New Date(2017, 3, 31, 0, 0, 0, 0)
        Me.checkindatePicker.Name = "checkindatePicker"
        Me.checkindatePicker.Size = New System.Drawing.Size(196, 20)
        Me.checkindatePicker.TabIndex = 6
        '
        'cbRoomID
        '
        Me.cbRoomID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbRoomID.FormattingEnabled = True
        Me.cbRoomID.Items.AddRange(New Object() {"Male", "Female"})
        Me.cbRoomID.Location = New System.Drawing.Point(133, 78)
        Me.cbRoomID.Name = "cbRoomID"
        Me.cbRoomID.Size = New System.Drawing.Size(196, 21)
        Me.cbRoomID.TabIndex = 2
        '
        'lblBookDate
        '
        Me.lblBookDate.AutoSize = True
        Me.lblBookDate.Location = New System.Drawing.Point(36, 42)
        Me.lblBookDate.Name = "lblBookDate"
        Me.lblBookDate.Size = New System.Drawing.Size(72, 13)
        Me.lblBookDate.TabIndex = 35
        Me.lblBookDate.Text = "Booking Date"
        '
        'lblTotalPrice
        '
        Me.lblTotalPrice.AutoSize = True
        Me.lblTotalPrice.Location = New System.Drawing.Point(36, 270)
        Me.lblTotalPrice.Name = "lblTotalPrice"
        Me.lblTotalPrice.Size = New System.Drawing.Size(58, 13)
        Me.lblTotalPrice.TabIndex = 34
        Me.lblTotalPrice.Text = "Total Price"
        '
        'lblCmt
        '
        Me.lblCmt.AutoSize = True
        Me.lblCmt.Location = New System.Drawing.Point(36, 306)
        Me.lblCmt.Name = "lblCmt"
        Me.lblCmt.Size = New System.Drawing.Size(56, 13)
        Me.lblCmt.TabIndex = 33
        Me.lblCmt.Text = "Comments"
        '
        'lblNum_guests
        '
        Me.lblNum_guests.AutoSize = True
        Me.lblNum_guests.Location = New System.Drawing.Point(36, 194)
        Me.lblNum_guests.Name = "lblNum_guests"
        Me.lblNum_guests.Size = New System.Drawing.Size(92, 13)
        Me.lblNum_guests.TabIndex = 32
        Me.lblNum_guests.Text = "Number of Guests"
        '
        'lblCheckinDate
        '
        Me.lblCheckinDate.AutoSize = True
        Me.lblCheckinDate.Location = New System.Drawing.Point(36, 230)
        Me.lblCheckinDate.Name = "lblCheckinDate"
        Me.lblCheckinDate.Size = New System.Drawing.Size(72, 13)
        Me.lblCheckinDate.TabIndex = 31
        Me.lblCheckinDate.Text = "Checkin Date"
        '
        'lblNum_days
        '
        Me.lblNum_days.AutoSize = True
        Me.lblNum_days.Location = New System.Drawing.Point(36, 157)
        Me.lblNum_days.Name = "lblNum_days"
        Me.lblNum_days.Size = New System.Drawing.Size(83, 13)
        Me.lblNum_days.TabIndex = 30
        Me.lblNum_days.Text = "Number of Days"
        '
        'lblCus_id
        '
        Me.lblCus_id.AutoSize = True
        Me.lblCus_id.Location = New System.Drawing.Point(36, 120)
        Me.lblCus_id.Name = "lblCus_id"
        Me.lblCus_id.Size = New System.Drawing.Size(65, 13)
        Me.lblCus_id.TabIndex = 29
        Me.lblCus_id.Text = "Customer ID"
        '
        'lblRoom_id
        '
        Me.lblRoom_id.AutoSize = True
        Me.lblRoom_id.Location = New System.Drawing.Point(36, 81)
        Me.lblRoom_id.Name = "lblRoom_id"
        Me.lblRoom_id.Size = New System.Drawing.Size(75, 13)
        Me.lblRoom_id.TabIndex = 28
        Me.lblRoom_id.Text = "Room Number"
        '
        'txtNumGuests
        '
        Me.txtNumGuests.Location = New System.Drawing.Point(133, 191)
        Me.txtNumGuests.Name = "txtNumGuests"
        Me.txtNumGuests.Size = New System.Drawing.Size(81, 20)
        Me.txtNumGuests.TabIndex = 5
        Me.ttInfo.SetToolTip(Me.txtNumGuests, "Number of Guests must be numeric and cannot be less than 1")
        '
        'txtNumDays
        '
        Me.txtNumDays.Location = New System.Drawing.Point(133, 154)
        Me.txtNumDays.Name = "txtNumDays"
        Me.txtNumDays.Size = New System.Drawing.Size(81, 20)
        Me.txtNumDays.TabIndex = 4
        Me.ttInfo.SetToolTip(Me.txtNumDays, "Number of Days must be numeric and cannot be less than 1" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10))
        '
        'txttotalPrice
        '
        Me.txttotalPrice.Location = New System.Drawing.Point(133, 267)
        Me.txttotalPrice.Name = "txttotalPrice"
        Me.txttotalPrice.ReadOnly = True
        Me.txttotalPrice.Size = New System.Drawing.Size(196, 20)
        Me.txttotalPrice.TabIndex = 24
        '
        'txtCusID
        '
        Me.txtCusID.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtCusID.Location = New System.Drawing.Point(133, 117)
        Me.txtCusID.Name = "txtCusID"
        Me.txtCusID.Size = New System.Drawing.Size(196, 20)
        Me.txtCusID.TabIndex = 3
        Me.ttCusIDError.SetToolTip(Me.txtCusID, " ")
        '
        'bookdatePicker
        '
        Me.bookdatePicker.Enabled = False
        Me.bookdatePicker.Location = New System.Drawing.Point(133, 36)
        Me.bookdatePicker.Name = "bookdatePicker"
        Me.bookdatePicker.Size = New System.Drawing.Size(196, 20)
        Me.bookdatePicker.TabIndex = 1
        '
        'txtCmt
        '
        Me.txtCmt.Location = New System.Drawing.Point(133, 303)
        Me.txtCmt.Multiline = True
        Me.txtCmt.Name = "txtCmt"
        Me.txtCmt.Size = New System.Drawing.Size(196, 60)
        Me.txtCmt.TabIndex = 7
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripMenuItem, Me.EditToolStripMenuItem, Me.ReportToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(370, 24)
        Me.MenuStrip1.TabIndex = 36
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'NewToolStripMenuItem
        '
        Me.NewToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CustomerToolStripMenuItem, Me.RoomToolStripMenuItem, Me.BookingToolStripMenuItem1, Me.InvoiceToolStripMenuItem})
        Me.NewToolStripMenuItem.Name = "NewToolStripMenuItem"
        Me.NewToolStripMenuItem.Size = New System.Drawing.Size(43, 20)
        Me.NewToolStripMenuItem.Text = "New"
        '
        'CustomerToolStripMenuItem
        '
        Me.CustomerToolStripMenuItem.Name = "CustomerToolStripMenuItem"
        Me.CustomerToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
        Me.CustomerToolStripMenuItem.Text = "Customer"
        '
        'RoomToolStripMenuItem
        '
        Me.RoomToolStripMenuItem.Name = "RoomToolStripMenuItem"
        Me.RoomToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
        Me.RoomToolStripMenuItem.Text = "Room"
        '
        'BookingToolStripMenuItem1
        '
        Me.BookingToolStripMenuItem1.Enabled = False
        Me.BookingToolStripMenuItem1.Name = "BookingToolStripMenuItem1"
        Me.BookingToolStripMenuItem1.Size = New System.Drawing.Size(126, 22)
        Me.BookingToolStripMenuItem1.Text = "Booking"
        '
        'InvoiceToolStripMenuItem
        '
        Me.InvoiceToolStripMenuItem.Name = "InvoiceToolStripMenuItem"
        Me.InvoiceToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
        Me.InvoiceToolStripMenuItem.Text = "Invoice"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CustomerToolStripMenuItem1, Me.RoomToolStripMenuItem1, Me.BookingToolStripMenuItem})
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
        'BookingToolStripMenuItem
        '
        Me.BookingToolStripMenuItem.Name = "BookingToolStripMenuItem"
        Me.BookingToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
        Me.BookingToolStripMenuItem.Text = "Booking"
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
        Me.GeneralReportsToolStripMenuItem.Size = New System.Drawing.Size(189, 22)
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
        'ttInfo
        '
        Me.ttInfo.AutomaticDelay = 50
        Me.ttInfo.AutoPopDelay = 5000
        Me.ttInfo.InitialDelay = 50
        Me.ttInfo.ReshowDelay = 10
        Me.ttInfo.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.ttInfo.ToolTipTitle = "Attention"
        '
        'ttCusIDError
        '
        Me.ttCusIDError.ToolTipIcon = System.Windows.Forms.ToolTipIcon.[Error]
        Me.ttCusIDError.ToolTipTitle = "Customer ID do not exist."
        '
        'frmBookingNew
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(370, 468)
        Me.Controls.Add(Me.txtCmt)
        Me.Controls.Add(Me.bookdatePicker)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.checkindatePicker)
        Me.Controls.Add(Me.cbRoomID)
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
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximumSize = New System.Drawing.Size(380, 500)
        Me.MinimumSize = New System.Drawing.Size(380, 500)
        Me.Name = "frmBookingNew"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "booking"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents checkindatePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents cbRoomID As System.Windows.Forms.ComboBox
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
    Friend WithEvents bookdatePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtCmt As System.Windows.Forms.TextBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents NewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CustomerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RoomToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BookingToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CustomerToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RoomToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BookingToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewHelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReportToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ttInfo As System.Windows.Forms.ToolTip
    Friend WithEvents ttCusIDError As System.Windows.Forms.ToolTip
    Friend WithEvents InvoiceToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GeneralReportsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ControlBreakReportsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
