<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCustomerEdit
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
        Me.NewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.newCusToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.newRoomToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.newBookingToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataCaptureToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BookingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RoomToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BookingToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GeneralReportsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ControlBreakReportsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.dobPicker = New System.Windows.Forms.DateTimePicker()
        Me.CustomerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me._s3575643_HRRIS_DbDataSetCus = New s3575643_Assignment01_HRRIS._s3575643_HRRIS_DbDataSetCus()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.txtLastname = New System.Windows.Forms.TextBox()
        Me.txtFirstname = New System.Windows.Forms.TextBox()
        Me.txtGender = New System.Windows.Forms.TextBox()
        Me.cbTitle = New System.Windows.Forms.ComboBox()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.lblDob = New System.Windows.Forms.Label()
        Me.lblPhone = New System.Windows.Forms.Label()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.lblLastName = New System.Windows.Forms.Label()
        Me.lblFirstName = New System.Windows.Forms.Label()
        Me.lblGender = New System.Windows.Forms.Label()
        Me.editCusGrid = New System.Windows.Forms.DataGridView()
        Me.CustomeridDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TitleDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GenderDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FirstnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LastnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PhoneDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AddressDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmailDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DobDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustomerTableAdapter = New s3575643_Assignment01_HRRIS._s3575643_HRRIS_DbDataSet1TableAdapters.customerTableAdapter()
        Me.CustomerTableAdapter1 = New s3575643_Assignment01_HRRIS._s3575643_HRRIS_DbDataSetCusTableAdapters.customerTableAdapter()
        Me.btnUpdateCus = New System.Windows.Forms.Button()
        Me.lblCusId = New System.Windows.Forms.Label()
        Me.txtCusId = New System.Windows.Forms.TextBox()
        Me.btnDelCus = New System.Windows.Forms.Button()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.btnPrev = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnLast = New System.Windows.Forms.Button()
        Me.btnFirst = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.CustomerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._s3575643_HRRIS_DbDataSetCus, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.editCusGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripMenuItem, Me.DataCaptureToolStripMenuItem, Me.ReportToolStripMenuItem, Me.AboutToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1184, 24)
        Me.MenuStrip1.TabIndex = 19
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'NewToolStripMenuItem
        '
        Me.NewToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.newCusToolStripMenuItem, Me.newRoomToolStripMenuItem1, Me.newBookingToolStripMenuItem1})
        Me.NewToolStripMenuItem.Name = "NewToolStripMenuItem"
        Me.NewToolStripMenuItem.Size = New System.Drawing.Size(43, 20)
        Me.NewToolStripMenuItem.Text = "New"
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
        Me.DataCaptureToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BookingToolStripMenuItem, Me.RoomToolStripMenuItem, Me.BookingToolStripMenuItem2})
        Me.DataCaptureToolStripMenuItem.Name = "DataCaptureToolStripMenuItem"
        Me.DataCaptureToolStripMenuItem.Size = New System.Drawing.Size(39, 20)
        Me.DataCaptureToolStripMenuItem.Text = "Edit"
        '
        'BookingToolStripMenuItem
        '
        Me.BookingToolStripMenuItem.Enabled = False
        Me.BookingToolStripMenuItem.Name = "BookingToolStripMenuItem"
        Me.BookingToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
        Me.BookingToolStripMenuItem.Text = "Customer"
        '
        'RoomToolStripMenuItem
        '
        Me.RoomToolStripMenuItem.Name = "RoomToolStripMenuItem"
        Me.RoomToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
        Me.RoomToolStripMenuItem.Text = "Room"
        '
        'BookingToolStripMenuItem2
        '
        Me.BookingToolStripMenuItem2.Name = "BookingToolStripMenuItem2"
        Me.BookingToolStripMenuItem2.Size = New System.Drawing.Size(126, 22)
        Me.BookingToolStripMenuItem2.Text = "Booking"
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
        'dobPicker
        '
        Me.dobPicker.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "dob", True))
        Me.dobPicker.Location = New System.Drawing.Point(139, 368)
        Me.dobPicker.MaxDate = New Date(2017, 3, 31, 0, 0, 0, 0)
        Me.dobPicker.Name = "dobPicker"
        Me.dobPicker.Size = New System.Drawing.Size(196, 20)
        Me.dobPicker.TabIndex = 47
        Me.dobPicker.Value = New Date(2017, 3, 31, 0, 0, 0, 0)
        '
        'CustomerBindingSource
        '
        Me.CustomerBindingSource.DataMember = "customer"
        Me.CustomerBindingSource.DataSource = Me._s3575643_HRRIS_DbDataSetCus
        '
        '_s3575643_HRRIS_DbDataSetCus
        '
        Me._s3575643_HRRIS_DbDataSetCus.DataSetName = "_s3575643_HRRIS_DbDataSetCus"
        Me._s3575643_HRRIS_DbDataSetCus.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'txtEmail
        '
        Me.txtEmail.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "email", True))
        Me.txtEmail.Location = New System.Drawing.Point(139, 328)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(196, 20)
        Me.txtEmail.TabIndex = 46
        '
        'txtAddress
        '
        Me.txtAddress.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "address", True))
        Me.txtAddress.Location = New System.Drawing.Point(139, 288)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(196, 20)
        Me.txtAddress.TabIndex = 45
        '
        'txtPhone
        '
        Me.txtPhone.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "phone", True))
        Me.txtPhone.Location = New System.Drawing.Point(139, 248)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(196, 20)
        Me.txtPhone.TabIndex = 44
        '
        'txtLastname
        '
        Me.txtLastname.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "lastname", True))
        Me.txtLastname.Location = New System.Drawing.Point(139, 207)
        Me.txtLastname.Name = "txtLastname"
        Me.txtLastname.Size = New System.Drawing.Size(196, 20)
        Me.txtLastname.TabIndex = 43
        '
        'txtFirstname
        '
        Me.txtFirstname.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "firstname", True))
        Me.txtFirstname.Location = New System.Drawing.Point(139, 167)
        Me.txtFirstname.Name = "txtFirstname"
        Me.txtFirstname.Size = New System.Drawing.Size(196, 20)
        Me.txtFirstname.TabIndex = 42
        '
        'txtGender
        '
        Me.txtGender.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "gender", True))
        Me.txtGender.Location = New System.Drawing.Point(139, 127)
        Me.txtGender.Name = "txtGender"
        Me.txtGender.ReadOnly = True
        Me.txtGender.Size = New System.Drawing.Size(80, 20)
        Me.txtGender.TabIndex = 41
        '
        'cbTitle
        '
        Me.cbTitle.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "title", True))
        Me.cbTitle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTitle.Enabled = False
        Me.cbTitle.FormattingEnabled = True
        Me.cbTitle.Items.AddRange(New Object() {"Mr.", "Mrs.", "Ms."})
        Me.cbTitle.Location = New System.Drawing.Point(139, 87)
        Me.cbTitle.Name = "cbTitle"
        Me.cbTitle.Size = New System.Drawing.Size(80, 21)
        Me.cbTitle.TabIndex = 40
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Location = New System.Drawing.Point(38, 90)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(27, 13)
        Me.lblTitle.TabIndex = 35
        Me.lblTitle.Text = "Title"
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Location = New System.Drawing.Point(38, 331)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(35, 13)
        Me.lblEmail.TabIndex = 34
        Me.lblEmail.Text = "E-mail"
        '
        'lblDob
        '
        Me.lblDob.AutoSize = True
        Me.lblDob.Location = New System.Drawing.Point(38, 371)
        Me.lblDob.Name = "lblDob"
        Me.lblDob.Size = New System.Drawing.Size(65, 13)
        Me.lblDob.TabIndex = 33
        Me.lblDob.Text = "Date of birth"
        '
        'lblPhone
        '
        Me.lblPhone.AutoSize = True
        Me.lblPhone.Location = New System.Drawing.Point(38, 251)
        Me.lblPhone.Name = "lblPhone"
        Me.lblPhone.Size = New System.Drawing.Size(78, 13)
        Me.lblPhone.TabIndex = 32
        Me.lblPhone.Text = "Phone Number"
        '
        'lblAddress
        '
        Me.lblAddress.AutoSize = True
        Me.lblAddress.Location = New System.Drawing.Point(38, 291)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(45, 13)
        Me.lblAddress.TabIndex = 31
        Me.lblAddress.Text = "Address"
        '
        'lblLastName
        '
        Me.lblLastName.AutoSize = True
        Me.lblLastName.Location = New System.Drawing.Point(38, 210)
        Me.lblLastName.Name = "lblLastName"
        Me.lblLastName.Size = New System.Drawing.Size(58, 13)
        Me.lblLastName.TabIndex = 30
        Me.lblLastName.Text = "Last Name"
        '
        'lblFirstName
        '
        Me.lblFirstName.AutoSize = True
        Me.lblFirstName.Location = New System.Drawing.Point(38, 170)
        Me.lblFirstName.Name = "lblFirstName"
        Me.lblFirstName.Size = New System.Drawing.Size(57, 13)
        Me.lblFirstName.TabIndex = 29
        Me.lblFirstName.Text = "First Name"
        '
        'lblGender
        '
        Me.lblGender.AutoSize = True
        Me.lblGender.Location = New System.Drawing.Point(38, 130)
        Me.lblGender.Name = "lblGender"
        Me.lblGender.Size = New System.Drawing.Size(42, 13)
        Me.lblGender.TabIndex = 28
        Me.lblGender.Text = "Gender"
        '
        'editCusGrid
        '
        Me.editCusGrid.AutoGenerateColumns = False
        Me.editCusGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.editCusGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CustomeridDataGridViewTextBoxColumn, Me.TitleDataGridViewTextBoxColumn, Me.GenderDataGridViewTextBoxColumn, Me.FirstnameDataGridViewTextBoxColumn, Me.LastnameDataGridViewTextBoxColumn, Me.PhoneDataGridViewTextBoxColumn, Me.AddressDataGridViewTextBoxColumn, Me.EmailDataGridViewTextBoxColumn, Me.DobDataGridViewTextBoxColumn})
        Me.editCusGrid.DataSource = Me.CustomerBindingSource
        Me.editCusGrid.Location = New System.Drawing.Point(381, 40)
        Me.editCusGrid.Name = "editCusGrid"
        Me.editCusGrid.ReadOnly = True
        Me.editCusGrid.Size = New System.Drawing.Size(766, 348)
        Me.editCusGrid.TabIndex = 36
        '
        'CustomeridDataGridViewTextBoxColumn
        '
        Me.CustomeridDataGridViewTextBoxColumn.DataPropertyName = "customer_id"
        Me.CustomeridDataGridViewTextBoxColumn.HeaderText = "customer_id"
        Me.CustomeridDataGridViewTextBoxColumn.Name = "CustomeridDataGridViewTextBoxColumn"
        Me.CustomeridDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TitleDataGridViewTextBoxColumn
        '
        Me.TitleDataGridViewTextBoxColumn.DataPropertyName = "title"
        Me.TitleDataGridViewTextBoxColumn.HeaderText = "title"
        Me.TitleDataGridViewTextBoxColumn.Name = "TitleDataGridViewTextBoxColumn"
        Me.TitleDataGridViewTextBoxColumn.ReadOnly = True
        '
        'GenderDataGridViewTextBoxColumn
        '
        Me.GenderDataGridViewTextBoxColumn.DataPropertyName = "gender"
        Me.GenderDataGridViewTextBoxColumn.HeaderText = "gender"
        Me.GenderDataGridViewTextBoxColumn.Name = "GenderDataGridViewTextBoxColumn"
        Me.GenderDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FirstnameDataGridViewTextBoxColumn
        '
        Me.FirstnameDataGridViewTextBoxColumn.DataPropertyName = "firstname"
        Me.FirstnameDataGridViewTextBoxColumn.HeaderText = "firstname"
        Me.FirstnameDataGridViewTextBoxColumn.Name = "FirstnameDataGridViewTextBoxColumn"
        Me.FirstnameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'LastnameDataGridViewTextBoxColumn
        '
        Me.LastnameDataGridViewTextBoxColumn.DataPropertyName = "lastname"
        Me.LastnameDataGridViewTextBoxColumn.HeaderText = "lastname"
        Me.LastnameDataGridViewTextBoxColumn.Name = "LastnameDataGridViewTextBoxColumn"
        Me.LastnameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PhoneDataGridViewTextBoxColumn
        '
        Me.PhoneDataGridViewTextBoxColumn.DataPropertyName = "phone"
        Me.PhoneDataGridViewTextBoxColumn.HeaderText = "phone"
        Me.PhoneDataGridViewTextBoxColumn.Name = "PhoneDataGridViewTextBoxColumn"
        Me.PhoneDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AddressDataGridViewTextBoxColumn
        '
        Me.AddressDataGridViewTextBoxColumn.DataPropertyName = "address"
        Me.AddressDataGridViewTextBoxColumn.HeaderText = "address"
        Me.AddressDataGridViewTextBoxColumn.Name = "AddressDataGridViewTextBoxColumn"
        Me.AddressDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EmailDataGridViewTextBoxColumn
        '
        Me.EmailDataGridViewTextBoxColumn.DataPropertyName = "email"
        Me.EmailDataGridViewTextBoxColumn.HeaderText = "email"
        Me.EmailDataGridViewTextBoxColumn.Name = "EmailDataGridViewTextBoxColumn"
        Me.EmailDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DobDataGridViewTextBoxColumn
        '
        Me.DobDataGridViewTextBoxColumn.DataPropertyName = "dob"
        Me.DobDataGridViewTextBoxColumn.HeaderText = "dob"
        Me.DobDataGridViewTextBoxColumn.Name = "DobDataGridViewTextBoxColumn"
        Me.DobDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CustomerTableAdapter
        '
        Me.CustomerTableAdapter.ClearBeforeFill = True
        '
        'CustomerTableAdapter1
        '
        Me.CustomerTableAdapter1.ClearBeforeFill = True
        '
        'btnUpdateCus
        '
        Me.btnUpdateCus.Location = New System.Drawing.Point(380, 415)
        Me.btnUpdateCus.Name = "btnUpdateCus"
        Me.btnUpdateCus.Size = New System.Drawing.Size(75, 23)
        Me.btnUpdateCus.TabIndex = 48
        Me.btnUpdateCus.Text = "Update"
        Me.btnUpdateCus.UseVisualStyleBackColor = True
        '
        'lblCusId
        '
        Me.lblCusId.AutoSize = True
        Me.lblCusId.Location = New System.Drawing.Point(38, 49)
        Me.lblCusId.Name = "lblCusId"
        Me.lblCusId.Size = New System.Drawing.Size(65, 13)
        Me.lblCusId.TabIndex = 38
        Me.lblCusId.Text = "Customer ID"
        '
        'txtCusId
        '
        Me.txtCusId.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "customer_id", True))
        Me.txtCusId.Location = New System.Drawing.Point(139, 46)
        Me.txtCusId.Name = "txtCusId"
        Me.txtCusId.ReadOnly = True
        Me.txtCusId.Size = New System.Drawing.Size(80, 20)
        Me.txtCusId.TabIndex = 39
        '
        'btnDelCus
        '
        Me.btnDelCus.Location = New System.Drawing.Point(480, 415)
        Me.btnDelCus.Name = "btnDelCus"
        Me.btnDelCus.Size = New System.Drawing.Size(75, 23)
        Me.btnDelCus.TabIndex = 49
        Me.btnDelCus.Text = "Delete"
        Me.btnDelCus.UseVisualStyleBackColor = True
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(756, 418)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(210, 20)
        Me.txtSearch.TabIndex = 50
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(982, 415)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(75, 23)
        Me.btnSearch.TabIndex = 51
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'btnRefresh
        '
        Me.btnRefresh.Location = New System.Drawing.Point(1072, 415)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(75, 23)
        Me.btnRefresh.TabIndex = 52
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'btnPrev
        '
        Me.btnPrev.Location = New System.Drawing.Point(123, 415)
        Me.btnPrev.Name = "btnPrev"
        Me.btnPrev.Size = New System.Drawing.Size(50, 23)
        Me.btnPrev.TabIndex = 2
        Me.btnPrev.Text = "<"
        Me.btnPrev.UseVisualStyleBackColor = True
        '
        'btnNext
        '
        Me.btnNext.Location = New System.Drawing.Point(202, 415)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(50, 23)
        Me.btnNext.TabIndex = 3
        Me.btnNext.Text = ">"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'btnLast
        '
        Me.btnLast.Location = New System.Drawing.Point(285, 415)
        Me.btnLast.Name = "btnLast"
        Me.btnLast.Size = New System.Drawing.Size(50, 23)
        Me.btnLast.TabIndex = 4
        Me.btnLast.Text = ">|"
        Me.btnLast.UseVisualStyleBackColor = True
        '
        'btnFirst
        '
        Me.btnFirst.Location = New System.Drawing.Point(41, 415)
        Me.btnFirst.Name = "btnFirst"
        Me.btnFirst.Size = New System.Drawing.Size(50, 23)
        Me.btnFirst.TabIndex = 1
        Me.btnFirst.Text = "|<"
        Me.btnFirst.UseVisualStyleBackColor = True
        '
        'frmCustomerEdit
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
        Me.Controls.Add(Me.btnDelCus)
        Me.Controls.Add(Me.txtCusId)
        Me.Controls.Add(Me.lblCusId)
        Me.Controls.Add(Me.btnUpdateCus)
        Me.Controls.Add(Me.editCusGrid)
        Me.Controls.Add(Me.dobPicker)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.txtAddress)
        Me.Controls.Add(Me.txtPhone)
        Me.Controls.Add(Me.txtLastname)
        Me.Controls.Add(Me.txtFirstname)
        Me.Controls.Add(Me.txtGender)
        Me.Controls.Add(Me.cbTitle)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.lblEmail)
        Me.Controls.Add(Me.lblDob)
        Me.Controls.Add(Me.lblPhone)
        Me.Controls.Add(Me.lblAddress)
        Me.Controls.Add(Me.lblLastName)
        Me.Controls.Add(Me.lblFirstName)
        Me.Controls.Add(Me.lblGender)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MaximumSize = New System.Drawing.Size(1200, 500)
        Me.MinimumSize = New System.Drawing.Size(1200, 500)
        Me.Name = "frmCustomerEdit"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmCustomerEdit"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.CustomerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._s3575643_HRRIS_DbDataSetCus, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.editCusGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents NewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents newCusToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents newRoomToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents newBookingToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DataCaptureToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BookingToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RoomToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BookingToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReportToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents dobPicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents txtAddress As System.Windows.Forms.TextBox
    Friend WithEvents txtPhone As System.Windows.Forms.TextBox
    Friend WithEvents txtLastname As System.Windows.Forms.TextBox
    Friend WithEvents txtFirstname As System.Windows.Forms.TextBox
    Friend WithEvents txtGender As System.Windows.Forms.TextBox
    Friend WithEvents cbTitle As System.Windows.Forms.ComboBox
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents lblEmail As System.Windows.Forms.Label
    Friend WithEvents lblDob As System.Windows.Forms.Label
    Friend WithEvents lblPhone As System.Windows.Forms.Label
    Friend WithEvents lblAddress As System.Windows.Forms.Label
    Friend WithEvents lblLastName As System.Windows.Forms.Label
    Friend WithEvents lblFirstName As System.Windows.Forms.Label
    Friend WithEvents lblGender As System.Windows.Forms.Label
    Friend WithEvents editCusGrid As System.Windows.Forms.DataGridView
    Friend WithEvents CustomerTableAdapter As s3575643_Assignment01_HRRIS._s3575643_HRRIS_DbDataSet1TableAdapters.customerTableAdapter
    Friend WithEvents _s3575643_HRRIS_DbDataSetCus As s3575643_Assignment01_HRRIS._s3575643_HRRIS_DbDataSetCus
    Friend WithEvents CustomerBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CustomerTableAdapter1 As s3575643_Assignment01_HRRIS._s3575643_HRRIS_DbDataSetCusTableAdapters.customerTableAdapter
    Friend WithEvents CustomeridDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TitleDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GenderDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FirstnameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LastnameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PhoneDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AddressDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EmailDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DobDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnUpdateCus As System.Windows.Forms.Button
    Friend WithEvents lblCusId As System.Windows.Forms.Label
    Friend WithEvents txtCusId As System.Windows.Forms.TextBox
    Friend WithEvents btnDelCus As System.Windows.Forms.Button
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents btnRefresh As System.Windows.Forms.Button
    Friend WithEvents btnPrev As System.Windows.Forms.Button
    Friend WithEvents btnNext As System.Windows.Forms.Button
    Friend WithEvents btnLast As System.Windows.Forms.Button
    Friend WithEvents btnFirst As System.Windows.Forms.Button
    Friend WithEvents GeneralReportsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ControlBreakReportsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
