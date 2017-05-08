<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class room
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
        Me.comboBoxGender = New System.Windows.Forms.ComboBox()
        Me.lblRoomDescript = New System.Windows.Forms.Label()
        Me.lblAvail = New System.Windows.Forms.Label()
        Me.lblFloor = New System.Windows.Forms.Label()
        Me.lblNumBeds = New System.Windows.Forms.Label()
        Me.lblRoomPrice = New System.Windows.Forms.Label()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.txtLastname = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtBoxFirstname = New System.Windows.Forms.TextBox()
        Me.lblRoomType = New System.Windows.Forms.Label()
        Me.lblRoom_Num = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'comboBoxGender
        '
        Me.comboBoxGender.FormattingEnabled = True
        Me.comboBoxGender.Items.AddRange(New Object() {"Male", "Female"})
        Me.comboBoxGender.Location = New System.Drawing.Point(128, 66)
        Me.comboBoxGender.Name = "comboBoxGender"
        Me.comboBoxGender.Size = New System.Drawing.Size(81, 21)
        Me.comboBoxGender.TabIndex = 33
        '
        'lblRoomDescript
        '
        Me.lblRoomDescript.AutoSize = True
        Me.lblRoomDescript.Location = New System.Drawing.Point(31, 258)
        Me.lblRoomDescript.Name = "lblRoomDescript"
        Me.lblRoomDescript.Size = New System.Drawing.Size(60, 13)
        Me.lblRoomDescript.TabIndex = 30
        Me.lblRoomDescript.Text = "Description"
        '
        'lblAvail
        '
        Me.lblAvail.AutoSize = True
        Me.lblAvail.Location = New System.Drawing.Point(31, 182)
        Me.lblAvail.Name = "lblAvail"
        Me.lblAvail.Size = New System.Drawing.Size(56, 13)
        Me.lblAvail.TabIndex = 29
        Me.lblAvail.Text = "Availability"
        '
        'lblFloor
        '
        Me.lblFloor.AutoSize = True
        Me.lblFloor.Location = New System.Drawing.Point(31, 218)
        Me.lblFloor.Name = "lblFloor"
        Me.lblFloor.Size = New System.Drawing.Size(30, 13)
        Me.lblFloor.TabIndex = 28
        Me.lblFloor.Text = "Floor"
        '
        'lblNumBeds
        '
        Me.lblNumBeds.AutoSize = True
        Me.lblNumBeds.Location = New System.Drawing.Point(31, 145)
        Me.lblNumBeds.Name = "lblNumBeds"
        Me.lblNumBeds.Size = New System.Drawing.Size(82, 13)
        Me.lblNumBeds.TabIndex = 27
        Me.lblNumBeds.Text = "Number of beds"
        '
        'lblRoomPrice
        '
        Me.lblRoomPrice.AutoSize = True
        Me.lblRoomPrice.Location = New System.Drawing.Point(31, 108)
        Me.lblRoomPrice.Name = "lblRoomPrice"
        Me.lblRoomPrice.Size = New System.Drawing.Size(31, 13)
        Me.lblRoomPrice.TabIndex = 26
        Me.lblRoomPrice.Text = "Price"
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(128, 215)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(81, 20)
        Me.txtAddress.TabIndex = 23
        '
        'txtLastname
        '
        Me.txtLastname.Location = New System.Drawing.Point(128, 142)
        Me.txtLastname.Name = "txtLastname"
        Me.txtLastname.Size = New System.Drawing.Size(81, 20)
        Me.txtLastname.TabIndex = 22
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(128, 255)
        Me.txtEmail.Multiline = True
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(196, 60)
        Me.txtEmail.TabIndex = 21
        '
        'txtBoxFirstname
        '
        Me.txtBoxFirstname.Location = New System.Drawing.Point(128, 105)
        Me.txtBoxFirstname.Name = "txtBoxFirstname"
        Me.txtBoxFirstname.Size = New System.Drawing.Size(196, 20)
        Me.txtBoxFirstname.TabIndex = 20
        '
        'lblRoomType
        '
        Me.lblRoomType.AutoSize = True
        Me.lblRoomType.Location = New System.Drawing.Point(31, 69)
        Me.lblRoomType.Name = "lblRoomType"
        Me.lblRoomType.Size = New System.Drawing.Size(31, 13)
        Me.lblRoomType.TabIndex = 25
        Me.lblRoomType.Text = "Type"
        '
        'lblRoom_Num
        '
        Me.lblRoom_Num.AutoSize = True
        Me.lblRoom_Num.Location = New System.Drawing.Point(31, 30)
        Me.lblRoom_Num.Name = "lblRoom_Num"
        Me.lblRoom_Num.Size = New System.Drawing.Size(75, 13)
        Me.lblRoom_Num.TabIndex = 31
        Me.lblRoom_Num.Text = "Room Number"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(128, 27)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(81, 20)
        Me.TextBox1.TabIndex = 34
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(34, 343)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(290, 25)
        Me.btnSave.TabIndex = 35
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(107, 374)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(145, 25)
        Me.btnCancel.TabIndex = 36
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Yes", "No"})
        Me.ComboBox1.Location = New System.Drawing.Point(128, 179)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(81, 21)
        Me.ComboBox1.TabIndex = 37
        '
        'room
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(364, 462)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.comboBoxGender)
        Me.Controls.Add(Me.lblRoom_Num)
        Me.Controls.Add(Me.lblRoomDescript)
        Me.Controls.Add(Me.lblAvail)
        Me.Controls.Add(Me.lblFloor)
        Me.Controls.Add(Me.lblNumBeds)
        Me.Controls.Add(Me.lblRoomPrice)
        Me.Controls.Add(Me.lblRoomType)
        Me.Controls.Add(Me.txtAddress)
        Me.Controls.Add(Me.txtLastname)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.txtBoxFirstname)
        Me.Name = "room"
        Me.Text = "room"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents comboBoxGender As System.Windows.Forms.ComboBox
    Friend WithEvents lblRoomDescript As System.Windows.Forms.Label
    Friend WithEvents lblAvail As System.Windows.Forms.Label
    Friend WithEvents lblFloor As System.Windows.Forms.Label
    Friend WithEvents lblNumBeds As System.Windows.Forms.Label
    Friend WithEvents lblRoomPrice As System.Windows.Forms.Label
    Friend WithEvents txtAddress As System.Windows.Forms.TextBox
    Friend WithEvents txtLastname As System.Windows.Forms.TextBox
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents txtBoxFirstname As System.Windows.Forms.TextBox
    Friend WithEvents lblRoomType As System.Windows.Forms.Label
    Friend WithEvents lblRoom_Num As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
End Class
