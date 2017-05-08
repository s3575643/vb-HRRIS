<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class booking
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
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.dobPicker = New System.Windows.Forms.DateTimePicker()
        Me.cbGender = New System.Windows.Forms.ComboBox()
        Me.lblBookDate = New System.Windows.Forms.Label()
        Me.lblTotalPrice = New System.Windows.Forms.Label()
        Me.lblCmt = New System.Windows.Forms.Label()
        Me.lblNum_guests = New System.Windows.Forms.Label()
        Me.lblCheckinDate = New System.Windows.Forms.Label()
        Me.lblNum_days = New System.Windows.Forms.Label()
        Me.lblCus_id = New System.Windows.Forms.Label()
        Me.lblRoom_id = New System.Windows.Forms.Label()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.txtLastname = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtFirstname = New System.Windows.Forms.TextBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(112, 415)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(145, 25)
        Me.btnCancel.TabIndex = 40
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(39, 381)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(290, 25)
        Me.btnSave.TabIndex = 39
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'dobPicker
        '
        Me.dobPicker.Location = New System.Drawing.Point(133, 219)
        Me.dobPicker.Name = "dobPicker"
        Me.dobPicker.Size = New System.Drawing.Size(196, 20)
        Me.dobPicker.TabIndex = 38
        '
        'cbGender
        '
        Me.cbGender.FormattingEnabled = True
        Me.cbGender.Items.AddRange(New Object() {"Male", "Female"})
        Me.cbGender.Location = New System.Drawing.Point(133, 73)
        Me.cbGender.Name = "cbGender"
        Me.cbGender.Size = New System.Drawing.Size(81, 21)
        Me.cbGender.TabIndex = 37
        '
        'lblBookDate
        '
        Me.lblBookDate.AutoSize = True
        Me.lblBookDate.Location = New System.Drawing.Point(36, 37)
        Me.lblBookDate.Name = "lblBookDate"
        Me.lblBookDate.Size = New System.Drawing.Size(72, 13)
        Me.lblBookDate.TabIndex = 35
        Me.lblBookDate.Text = "Booking Date"
        '
        'lblTotalPrice
        '
        Me.lblTotalPrice.AutoSize = True
        Me.lblTotalPrice.Location = New System.Drawing.Point(36, 265)
        Me.lblTotalPrice.Name = "lblTotalPrice"
        Me.lblTotalPrice.Size = New System.Drawing.Size(58, 13)
        Me.lblTotalPrice.TabIndex = 34
        Me.lblTotalPrice.Text = "Total Price"
        '
        'lblCmt
        '
        Me.lblCmt.AutoSize = True
        Me.lblCmt.Location = New System.Drawing.Point(36, 301)
        Me.lblCmt.Name = "lblCmt"
        Me.lblCmt.Size = New System.Drawing.Size(56, 13)
        Me.lblCmt.TabIndex = 33
        Me.lblCmt.Text = "Comments"
        '
        'lblNum_guests
        '
        Me.lblNum_guests.AutoSize = True
        Me.lblNum_guests.Location = New System.Drawing.Point(36, 189)
        Me.lblNum_guests.Name = "lblNum_guests"
        Me.lblNum_guests.Size = New System.Drawing.Size(92, 13)
        Me.lblNum_guests.TabIndex = 32
        Me.lblNum_guests.Text = "Number of Guests"
        '
        'lblCheckinDate
        '
        Me.lblCheckinDate.AutoSize = True
        Me.lblCheckinDate.Location = New System.Drawing.Point(36, 225)
        Me.lblCheckinDate.Name = "lblCheckinDate"
        Me.lblCheckinDate.Size = New System.Drawing.Size(72, 13)
        Me.lblCheckinDate.TabIndex = 31
        Me.lblCheckinDate.Text = "Checkin Date"
        '
        'lblNum_days
        '
        Me.lblNum_days.AutoSize = True
        Me.lblNum_days.Location = New System.Drawing.Point(36, 152)
        Me.lblNum_days.Name = "lblNum_days"
        Me.lblNum_days.Size = New System.Drawing.Size(83, 13)
        Me.lblNum_days.TabIndex = 30
        Me.lblNum_days.Text = "Number of Days"
        '
        'lblCus_id
        '
        Me.lblCus_id.AutoSize = True
        Me.lblCus_id.Location = New System.Drawing.Point(36, 115)
        Me.lblCus_id.Name = "lblCus_id"
        Me.lblCus_id.Size = New System.Drawing.Size(65, 13)
        Me.lblCus_id.TabIndex = 29
        Me.lblCus_id.Text = "Customer ID"
        '
        'lblRoom_id
        '
        Me.lblRoom_id.AutoSize = True
        Me.lblRoom_id.Location = New System.Drawing.Point(36, 76)
        Me.lblRoom_id.Name = "lblRoom_id"
        Me.lblRoom_id.Size = New System.Drawing.Size(49, 13)
        Me.lblRoom_id.TabIndex = 28
        Me.lblRoom_id.Text = "Room ID"
        '
        'txtPhone
        '
        Me.txtPhone.Location = New System.Drawing.Point(133, 186)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(81, 20)
        Me.txtPhone.TabIndex = 27
        '
        'txtLastname
        '
        Me.txtLastname.Location = New System.Drawing.Point(133, 149)
        Me.txtLastname.Name = "txtLastname"
        Me.txtLastname.Size = New System.Drawing.Size(81, 20)
        Me.txtLastname.TabIndex = 25
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(133, 262)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(196, 20)
        Me.txtEmail.TabIndex = 24
        '
        'txtFirstname
        '
        Me.txtFirstname.Location = New System.Drawing.Point(133, 112)
        Me.txtFirstname.Name = "txtFirstname"
        Me.txtFirstname.Size = New System.Drawing.Size(196, 20)
        Me.txtFirstname.TabIndex = 23
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(133, 31)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(196, 20)
        Me.DateTimePicker1.TabIndex = 41
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(133, 298)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(196, 60)
        Me.TextBox1.TabIndex = 42
        '
        'booking
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(364, 462)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.dobPicker)
        Me.Controls.Add(Me.cbGender)
        Me.Controls.Add(Me.lblBookDate)
        Me.Controls.Add(Me.lblTotalPrice)
        Me.Controls.Add(Me.lblCmt)
        Me.Controls.Add(Me.lblNum_guests)
        Me.Controls.Add(Me.lblCheckinDate)
        Me.Controls.Add(Me.lblNum_days)
        Me.Controls.Add(Me.lblCus_id)
        Me.Controls.Add(Me.lblRoom_id)
        Me.Controls.Add(Me.txtPhone)
        Me.Controls.Add(Me.txtLastname)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.txtFirstname)
        Me.Name = "booking"
        Me.Text = "booking"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents dobPicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents cbGender As System.Windows.Forms.ComboBox
    Friend WithEvents lblBookDate As System.Windows.Forms.Label
    Friend WithEvents lblTotalPrice As System.Windows.Forms.Label
    Friend WithEvents lblCmt As System.Windows.Forms.Label
    Friend WithEvents lblNum_guests As System.Windows.Forms.Label
    Friend WithEvents lblCheckinDate As System.Windows.Forms.Label
    Friend WithEvents lblNum_days As System.Windows.Forms.Label
    Friend WithEvents lblCus_id As System.Windows.Forms.Label
    Friend WithEvents lblRoom_id As System.Windows.Forms.Label
    Friend WithEvents txtPhone As System.Windows.Forms.TextBox
    Friend WithEvents txtLastname As System.Windows.Forms.TextBox
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents txtFirstname As System.Windows.Forms.TextBox
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
End Class
