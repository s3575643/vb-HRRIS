<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRoomEdit
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.newCusToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.newRoomToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.newBookingToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataCaptureToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.editCusBookingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RoomToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.editBookingToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.editRoomGrid = New System.Windows.Forms.DataGridView()
        Me.RoomidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RoomnumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NumbedsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AvailabilityDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.FloorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescriptionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RoomBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me._s3575643_HRRIS_DbDataSetRoom = New s3575643_Assignment01_HRRIS._s3575643_HRRIS_DbDataSetRoom()
        Me.RoomTableAdapter = New s3575643_Assignment01_HRRIS._s3575643_HRRIS_DbDataSetRoomTableAdapters.roomTableAdapter()
        Me.btnUpdateRoom = New System.Windows.Forms.Button()
        Me.lblRoomId = New System.Windows.Forms.Label()
        Me.txtRoomId = New System.Windows.Forms.TextBox()
        Me.chkAvail = New System.Windows.Forms.CheckBox()
        Me.txtRoomNum = New System.Windows.Forms.TextBox()
        Me.cbType = New System.Windows.Forms.ComboBox()
        Me.lblRoom_Num = New System.Windows.Forms.Label()
        Me.lblRoomDescript = New System.Windows.Forms.Label()
        Me.lblAvail = New System.Windows.Forms.Label()
        Me.lblFloor = New System.Windows.Forms.Label()
        Me.lblNumBeds = New System.Windows.Forms.Label()
        Me.lblRoomPrice = New System.Windows.Forms.Label()
        Me.lblRoomType = New System.Windows.Forms.Label()
        Me.txtFloor = New System.Windows.Forms.TextBox()
        Me.txtNumBeds = New System.Windows.Forms.TextBox()
        Me.txtDescript = New System.Windows.Forms.TextBox()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.btnDelRoom = New System.Windows.Forms.Button()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.btnPrev = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnLast = New System.Windows.Forms.Button()
        Me.btnFirst = New System.Windows.Forms.Button()
        Me.GeneralReportsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ControlBreakReportsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.editRoomGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RoomBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._s3575643_HRRIS_DbDataSetRoom, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.DataCaptureToolStripMenuItem, Me.ReportToolStripMenuItem, Me.AboutToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1184, 24)
        Me.MenuStrip1.TabIndex = 36
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.newCusToolStripMenuItem, Me.newRoomToolStripMenuItem1, Me.newBookingToolStripMenuItem1})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(43, 20)
        Me.FileToolStripMenuItem.Text = "New"
        '
        'newCusToolStripMenuItem
        '
        Me.newCusToolStripMenuItem.Name = "newCusToolStripMenuItem"
        Me.newCusToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
        Me.newCusToolStripMenuItem.Text = "Customer"
        '
        'newRoomToolStripMenuItem1
        '
        Me.newRoomToolStripMenuItem1.Name = "newRoomToolStripMenuItem1"
        Me.newRoomToolStripMenuItem1.Size = New System.Drawing.Size(126, 22)
        Me.newRoomToolStripMenuItem1.Text = "Room"
        '
        'newBookingToolStripMenuItem1
        '
        Me.newBookingToolStripMenuItem1.Name = "newBookingToolStripMenuItem1"
        Me.newBookingToolStripMenuItem1.Size = New System.Drawing.Size(126, 22)
        Me.newBookingToolStripMenuItem1.Text = "Booking"
        '
        'DataCaptureToolStripMenuItem
        '
        Me.DataCaptureToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.editCusBookingToolStripMenuItem, Me.RoomToolStripMenuItem, Me.editBookingToolStripMenuItem2})
        Me.DataCaptureToolStripMenuItem.Name = "DataCaptureToolStripMenuItem"
        Me.DataCaptureToolStripMenuItem.Size = New System.Drawing.Size(39, 20)
        Me.DataCaptureToolStripMenuItem.Text = "Edit"
        '
        'editCusBookingToolStripMenuItem
        '
        Me.editCusBookingToolStripMenuItem.Name = "editCusBookingToolStripMenuItem"
        Me.editCusBookingToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
        Me.editCusBookingToolStripMenuItem.Text = "Customer"
        '
        'RoomToolStripMenuItem
        '
        Me.RoomToolStripMenuItem.Enabled = False
        Me.RoomToolStripMenuItem.Name = "RoomToolStripMenuItem"
        Me.RoomToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
        Me.RoomToolStripMenuItem.Text = "Room"
        '
        'editBookingToolStripMenuItem2
        '
        Me.editBookingToolStripMenuItem2.Name = "editBookingToolStripMenuItem2"
        Me.editBookingToolStripMenuItem2.Size = New System.Drawing.Size(126, 22)
        Me.editBookingToolStripMenuItem2.Text = "Booking"
        '
        'ReportToolStripMenuItem
        '
        Me.ReportToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GeneralReportsToolStripMenuItem, Me.ControlBreakReportsToolStripMenuItem})
        Me.ReportToolStripMenuItem.Name = "ReportToolStripMenuItem"
        Me.ReportToolStripMenuItem.Size = New System.Drawing.Size(54, 20)
        Me.ReportToolStripMenuItem.Text = "Report"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HelpToolStripMenuItem, Me.AboutToolStripMenuItem1})
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.AboutToolStripMenuItem.Text = "Help"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(127, 22)
        Me.HelpToolStripMenuItem.Text = "View Help"
        '
        'AboutToolStripMenuItem1
        '
        Me.AboutToolStripMenuItem1.Name = "AboutToolStripMenuItem1"
        Me.AboutToolStripMenuItem1.Size = New System.Drawing.Size(127, 22)
        Me.AboutToolStripMenuItem1.Text = "About"
        '
        'editRoomGrid
        '
        Me.editRoomGrid.AutoGenerateColumns = False
        Me.editRoomGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.editRoomGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.RoomidDataGridViewTextBoxColumn, Me.RoomnumberDataGridViewTextBoxColumn, Me.TypeDataGridViewTextBoxColumn, Me.PriceDataGridViewTextBoxColumn, Me.NumbedsDataGridViewTextBoxColumn, Me.AvailabilityDataGridViewCheckBoxColumn, Me.FloorDataGridViewTextBoxColumn, Me.DescriptionDataGridViewTextBoxColumn})
        Me.editRoomGrid.DataSource = Me.RoomBindingSource
        Me.editRoomGrid.Location = New System.Drawing.Point(380, 39)
        Me.editRoomGrid.Name = "editRoomGrid"
        Me.editRoomGrid.Size = New System.Drawing.Size(765, 325)
        Me.editRoomGrid.TabIndex = 53
        '
        'RoomidDataGridViewTextBoxColumn
        '
        Me.RoomidDataGridViewTextBoxColumn.DataPropertyName = "room_id"
        Me.RoomidDataGridViewTextBoxColumn.HeaderText = "room_id"
        Me.RoomidDataGridViewTextBoxColumn.Name = "RoomidDataGridViewTextBoxColumn"
        '
        'RoomnumberDataGridViewTextBoxColumn
        '
        Me.RoomnumberDataGridViewTextBoxColumn.DataPropertyName = "room_number"
        Me.RoomnumberDataGridViewTextBoxColumn.HeaderText = "room_number"
        Me.RoomnumberDataGridViewTextBoxColumn.Name = "RoomnumberDataGridViewTextBoxColumn"
        '
        'TypeDataGridViewTextBoxColumn
        '
        Me.TypeDataGridViewTextBoxColumn.DataPropertyName = "type"
        Me.TypeDataGridViewTextBoxColumn.HeaderText = "type"
        Me.TypeDataGridViewTextBoxColumn.Name = "TypeDataGridViewTextBoxColumn"
        '
        'PriceDataGridViewTextBoxColumn
        '
        Me.PriceDataGridViewTextBoxColumn.DataPropertyName = "price"
        Me.PriceDataGridViewTextBoxColumn.HeaderText = "price"
        Me.PriceDataGridViewTextBoxColumn.Name = "PriceDataGridViewTextBoxColumn"
        '
        'NumbedsDataGridViewTextBoxColumn
        '
        Me.NumbedsDataGridViewTextBoxColumn.DataPropertyName = "num_beds"
        Me.NumbedsDataGridViewTextBoxColumn.HeaderText = "num_beds"
        Me.NumbedsDataGridViewTextBoxColumn.Name = "NumbedsDataGridViewTextBoxColumn"
        '
        'AvailabilityDataGridViewCheckBoxColumn
        '
        Me.AvailabilityDataGridViewCheckBoxColumn.DataPropertyName = "availability"
        Me.AvailabilityDataGridViewCheckBoxColumn.HeaderText = "availability"
        Me.AvailabilityDataGridViewCheckBoxColumn.Name = "AvailabilityDataGridViewCheckBoxColumn"
        '
        'FloorDataGridViewTextBoxColumn
        '
        Me.FloorDataGridViewTextBoxColumn.DataPropertyName = "floor"
        Me.FloorDataGridViewTextBoxColumn.HeaderText = "floor"
        Me.FloorDataGridViewTextBoxColumn.Name = "FloorDataGridViewTextBoxColumn"
        '
        'DescriptionDataGridViewTextBoxColumn
        '
        Me.DescriptionDataGridViewTextBoxColumn.DataPropertyName = "description"
        Me.DescriptionDataGridViewTextBoxColumn.HeaderText = "description"
        Me.DescriptionDataGridViewTextBoxColumn.Name = "DescriptionDataGridViewTextBoxColumn"
        '
        'RoomBindingSource
        '
        Me.RoomBindingSource.DataMember = "room"
        Me.RoomBindingSource.DataSource = Me._s3575643_HRRIS_DbDataSetRoom
        '
        '_s3575643_HRRIS_DbDataSetRoom
        '
        Me._s3575643_HRRIS_DbDataSetRoom.DataSetName = "_s3575643_HRRIS_DbDataSetRoom"
        Me._s3575643_HRRIS_DbDataSetRoom.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RoomTableAdapter
        '
        Me.RoomTableAdapter.ClearBeforeFill = True
        '
        'btnUpdateRoom
        '
        Me.btnUpdateRoom.Location = New System.Drawing.Point(380, 400)
        Me.btnUpdateRoom.Name = "btnUpdateRoom"
        Me.btnUpdateRoom.Size = New System.Drawing.Size(75, 23)
        Me.btnUpdateRoom.TabIndex = 54
        Me.btnUpdateRoom.Text = "Update"
        Me.btnUpdateRoom.UseVisualStyleBackColor = True
        '
        'lblRoomId
        '
        Me.lblRoomId.AutoSize = True
        Me.lblRoomId.Location = New System.Drawing.Point(39, 39)
        Me.lblRoomId.Name = "lblRoomId"
        Me.lblRoomId.Size = New System.Drawing.Size(49, 13)
        Me.lblRoomId.TabIndex = 55
        Me.lblRoomId.Text = "Room ID"
        '
        'txtRoomId
        '
        Me.txtRoomId.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RoomBindingSource, "room_id", True))
        Me.txtRoomId.Location = New System.Drawing.Point(140, 36)
        Me.txtRoomId.Name = "txtRoomId"
        Me.txtRoomId.ReadOnly = True
        Me.txtRoomId.Size = New System.Drawing.Size(80, 20)
        Me.txtRoomId.TabIndex = 56
        '
        'chkAvail
        '
        Me.chkAvail.AutoSize = True
        Me.chkAvail.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.RoomBindingSource, "availability", True))
        Me.chkAvail.Location = New System.Drawing.Point(140, 231)
        Me.chkAvail.Name = "chkAvail"
        Me.chkAvail.Size = New System.Drawing.Size(15, 14)
        Me.chkAvail.TabIndex = 61
        Me.chkAvail.UseVisualStyleBackColor = True
        '
        'txtRoomNum
        '
        Me.txtRoomNum.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RoomBindingSource, "room_number", True))
        Me.txtRoomNum.Location = New System.Drawing.Point(140, 76)
        Me.txtRoomNum.Name = "txtRoomNum"
        Me.txtRoomNum.Size = New System.Drawing.Size(81, 20)
        Me.txtRoomNum.TabIndex = 57
        '
        'cbType
        '
        Me.cbType.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RoomBindingSource, "type", True))
        Me.cbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbType.FormattingEnabled = True
        Me.cbType.Items.AddRange(New Object() {"Standard", "Deluxe", "Suite", "Family"})
        Me.cbType.Location = New System.Drawing.Point(140, 115)
        Me.cbType.Name = "cbType"
        Me.cbType.Size = New System.Drawing.Size(81, 21)
        Me.cbType.TabIndex = 58
        '
        'lblRoom_Num
        '
        Me.lblRoom_Num.AutoSize = True
        Me.lblRoom_Num.Location = New System.Drawing.Point(39, 79)
        Me.lblRoom_Num.Name = "lblRoom_Num"
        Me.lblRoom_Num.Size = New System.Drawing.Size(75, 13)
        Me.lblRoom_Num.TabIndex = 70
        Me.lblRoom_Num.Text = "Room Number"
        '
        'lblRoomDescript
        '
        Me.lblRoomDescript.AutoSize = True
        Me.lblRoomDescript.Location = New System.Drawing.Point(39, 307)
        Me.lblRoomDescript.Name = "lblRoomDescript"
        Me.lblRoomDescript.Size = New System.Drawing.Size(60, 13)
        Me.lblRoomDescript.TabIndex = 69
        Me.lblRoomDescript.Text = "Description"
        '
        'lblAvail
        '
        Me.lblAvail.AutoSize = True
        Me.lblAvail.Location = New System.Drawing.Point(39, 231)
        Me.lblAvail.Name = "lblAvail"
        Me.lblAvail.Size = New System.Drawing.Size(56, 13)
        Me.lblAvail.TabIndex = 68
        Me.lblAvail.Text = "Availability"
        '
        'lblFloor
        '
        Me.lblFloor.AutoSize = True
        Me.lblFloor.Location = New System.Drawing.Point(39, 267)
        Me.lblFloor.Name = "lblFloor"
        Me.lblFloor.Size = New System.Drawing.Size(30, 13)
        Me.lblFloor.TabIndex = 67
        Me.lblFloor.Text = "Floor"
        '
        'lblNumBeds
        '
        Me.lblNumBeds.AutoSize = True
        Me.lblNumBeds.Location = New System.Drawing.Point(39, 194)
        Me.lblNumBeds.Name = "lblNumBeds"
        Me.lblNumBeds.Size = New System.Drawing.Size(82, 13)
        Me.lblNumBeds.TabIndex = 66
        Me.lblNumBeds.Text = "Number of beds"
        '
        'lblRoomPrice
        '
        Me.lblRoomPrice.AutoSize = True
        Me.lblRoomPrice.Location = New System.Drawing.Point(39, 157)
        Me.lblRoomPrice.Name = "lblRoomPrice"
        Me.lblRoomPrice.Size = New System.Drawing.Size(31, 13)
        Me.lblRoomPrice.TabIndex = 65
        Me.lblRoomPrice.Text = "Price"
        '
        'lblRoomType
        '
        Me.lblRoomType.AutoSize = True
        Me.lblRoomType.Location = New System.Drawing.Point(39, 118)
        Me.lblRoomType.Name = "lblRoomType"
        Me.lblRoomType.Size = New System.Drawing.Size(31, 13)
        Me.lblRoomType.TabIndex = 64
        Me.lblRoomType.Text = "Type"
        '
        'txtFloor
        '
        Me.txtFloor.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RoomBindingSource, "floor", True))
        Me.txtFloor.Location = New System.Drawing.Point(140, 264)
        Me.txtFloor.Name = "txtFloor"
        Me.txtFloor.Size = New System.Drawing.Size(81, 20)
        Me.txtFloor.TabIndex = 62
        '
        'txtNumBeds
        '
        Me.txtNumBeds.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RoomBindingSource, "num_beds", True))
        Me.txtNumBeds.Location = New System.Drawing.Point(140, 191)
        Me.txtNumBeds.Name = "txtNumBeds"
        Me.txtNumBeds.Size = New System.Drawing.Size(81, 20)
        Me.txtNumBeds.TabIndex = 60
        '
        'txtDescript
        '
        Me.txtDescript.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RoomBindingSource, "description", True))
        Me.txtDescript.Location = New System.Drawing.Point(140, 304)
        Me.txtDescript.Multiline = True
        Me.txtDescript.Name = "txtDescript"
        Me.txtDescript.Size = New System.Drawing.Size(196, 60)
        Me.txtDescript.TabIndex = 63
        '
        'txtPrice
        '
        Me.txtPrice.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RoomBindingSource, "price", True))
        Me.txtPrice.Location = New System.Drawing.Point(140, 154)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(196, 20)
        Me.txtPrice.TabIndex = 59
        '
        'btnDelRoom
        '
        Me.btnDelRoom.Location = New System.Drawing.Point(480, 400)
        Me.btnDelRoom.Name = "btnDelRoom"
        Me.btnDelRoom.Size = New System.Drawing.Size(75, 23)
        Me.btnDelRoom.TabIndex = 71
        Me.btnDelRoom.Text = "Delete"
        Me.btnDelRoom.UseVisualStyleBackColor = True
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(976, 400)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(75, 23)
        Me.btnSearch.TabIndex = 73
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(748, 400)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(210, 20)
        Me.txtSearch.TabIndex = 72
        '
        'btnRefresh
        '
        Me.btnRefresh.Location = New System.Drawing.Point(1069, 400)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(75, 23)
        Me.btnRefresh.TabIndex = 74
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'btnPrev
        '
        Me.btnPrev.Location = New System.Drawing.Point(121, 400)
        Me.btnPrev.Name = "btnPrev"
        Me.btnPrev.Size = New System.Drawing.Size(50, 23)
        Me.btnPrev.TabIndex = 78
        Me.btnPrev.Text = "<"
        Me.btnPrev.UseVisualStyleBackColor = True
        '
        'btnNext
        '
        Me.btnNext.Location = New System.Drawing.Point(201, 400)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(50, 23)
        Me.btnNext.TabIndex = 77
        Me.btnNext.Text = ">"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'btnLast
        '
        Me.btnLast.Location = New System.Drawing.Point(282, 400)
        Me.btnLast.Name = "btnLast"
        Me.btnLast.Size = New System.Drawing.Size(50, 23)
        Me.btnLast.TabIndex = 76
        Me.btnLast.Text = ">|"
        Me.btnLast.UseVisualStyleBackColor = True
        '
        'btnFirst
        '
        Me.btnFirst.Location = New System.Drawing.Point(42, 400)
        Me.btnFirst.Name = "btnFirst"
        Me.btnFirst.Size = New System.Drawing.Size(50, 23)
        Me.btnFirst.TabIndex = 75
        Me.btnFirst.Text = "|<"
        Me.btnFirst.UseVisualStyleBackColor = True
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
        'frmRoomEdit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1184, 462)
        Me.Controls.Add(Me.btnPrev)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.btnLast)
        Me.Controls.Add(Me.btnFirst)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.btnDelRoom)
        Me.Controls.Add(Me.chkAvail)
        Me.Controls.Add(Me.txtRoomNum)
        Me.Controls.Add(Me.cbType)
        Me.Controls.Add(Me.lblRoom_Num)
        Me.Controls.Add(Me.lblRoomDescript)
        Me.Controls.Add(Me.lblAvail)
        Me.Controls.Add(Me.lblFloor)
        Me.Controls.Add(Me.lblNumBeds)
        Me.Controls.Add(Me.lblRoomPrice)
        Me.Controls.Add(Me.lblRoomType)
        Me.Controls.Add(Me.txtFloor)
        Me.Controls.Add(Me.txtNumBeds)
        Me.Controls.Add(Me.txtDescript)
        Me.Controls.Add(Me.txtPrice)
        Me.Controls.Add(Me.txtRoomId)
        Me.Controls.Add(Me.lblRoomId)
        Me.Controls.Add(Me.btnUpdateRoom)
        Me.Controls.Add(Me.editRoomGrid)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MaximumSize = New System.Drawing.Size(1200, 500)
        Me.MinimumSize = New System.Drawing.Size(1200, 500)
        Me.Name = "frmRoomEdit"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmRoomEdit"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.editRoomGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RoomBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._s3575643_HRRIS_DbDataSetRoom, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents newCusToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents newRoomToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents newBookingToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DataCaptureToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents editCusBookingToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RoomToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents editBookingToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReportToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents editRoomGrid As System.Windows.Forms.DataGridView
    Friend WithEvents _s3575643_HRRIS_DbDataSetRoom As s3575643_Assignment01_HRRIS._s3575643_HRRIS_DbDataSetRoom
    Friend WithEvents RoomBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents RoomTableAdapter As s3575643_Assignment01_HRRIS._s3575643_HRRIS_DbDataSetRoomTableAdapters.roomTableAdapter
    Friend WithEvents RoomidDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RoomnumberDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TypeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PriceDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NumbedsDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AvailabilityDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents FloorDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DescriptionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnUpdateRoom As System.Windows.Forms.Button
    Friend WithEvents lblRoomId As System.Windows.Forms.Label
    Friend WithEvents txtRoomId As System.Windows.Forms.TextBox
    Friend WithEvents chkAvail As System.Windows.Forms.CheckBox
    Friend WithEvents txtRoomNum As System.Windows.Forms.TextBox
    Friend WithEvents cbType As System.Windows.Forms.ComboBox
    Friend WithEvents lblRoom_Num As System.Windows.Forms.Label
    Friend WithEvents lblRoomDescript As System.Windows.Forms.Label
    Friend WithEvents lblAvail As System.Windows.Forms.Label
    Friend WithEvents lblFloor As System.Windows.Forms.Label
    Friend WithEvents lblNumBeds As System.Windows.Forms.Label
    Friend WithEvents lblRoomPrice As System.Windows.Forms.Label
    Friend WithEvents lblRoomType As System.Windows.Forms.Label
    Friend WithEvents txtFloor As System.Windows.Forms.TextBox
    Friend WithEvents txtNumBeds As System.Windows.Forms.TextBox
    Friend WithEvents txtDescript As System.Windows.Forms.TextBox
    Friend WithEvents txtPrice As System.Windows.Forms.TextBox
    Friend WithEvents btnDelRoom As System.Windows.Forms.Button
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents btnRefresh As System.Windows.Forms.Button
    Friend WithEvents btnPrev As System.Windows.Forms.Button
    Friend WithEvents btnNext As System.Windows.Forms.Button
    Friend WithEvents btnLast As System.Windows.Forms.Button
    Friend WithEvents btnFirst As System.Windows.Forms.Button
    Friend WithEvents GeneralReportsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ControlBreakReportsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
