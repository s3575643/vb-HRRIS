<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmControlBreakReport
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
        Me.gbCBRp1 = New System.Windows.Forms.GroupBox()
        Me.txtYear = New System.Windows.Forms.NumericUpDown()
        Me.cbMonth = New System.Windows.Forms.ComboBox()
        Me.lblDateMonth = New System.Windows.Forms.Label()
        Me.lblDateYear = New System.Windows.Forms.Label()
        Me.btnCreateReport1 = New System.Windows.Forms.Button()
        Me.gbCBRp2 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.gbCBRp1.SuspendLayout()
        CType(Me.txtYear, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbCBRp2.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbCBRp1
        '
        Me.gbCBRp1.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.gbCBRp1.Controls.Add(Me.txtYear)
        Me.gbCBRp1.Controls.Add(Me.cbMonth)
        Me.gbCBRp1.Controls.Add(Me.lblDateMonth)
        Me.gbCBRp1.Controls.Add(Me.lblDateYear)
        Me.gbCBRp1.Controls.Add(Me.btnCreateReport1)
        Me.gbCBRp1.Location = New System.Drawing.Point(12, 12)
        Me.gbCBRp1.Margin = New System.Windows.Forms.Padding(10)
        Me.gbCBRp1.Name = "gbCBRp1"
        Me.gbCBRp1.Size = New System.Drawing.Size(340, 210)
        Me.gbCBRp1.TabIndex = 0
        Me.gbCBRp1.TabStop = False
        Me.gbCBRp1.Text = "All bookings made for a given year and month according to room"
        '
        'txtYear
        '
        Me.txtYear.Location = New System.Drawing.Point(150, 98)
        Me.txtYear.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.txtYear.Minimum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.txtYear.Name = "txtYear"
        Me.txtYear.Size = New System.Drawing.Size(150, 20)
        Me.txtYear.TabIndex = 10
        Me.txtYear.Value = New Decimal(New Integer() {2017, 0, 0, 0})
        '
        'cbMonth
        '
        Me.cbMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbMonth.FormattingEnabled = True
        Me.cbMonth.Items.AddRange(New Object() {"January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"})
        Me.cbMonth.Location = New System.Drawing.Point(150, 67)
        Me.cbMonth.Name = "cbMonth"
        Me.cbMonth.Size = New System.Drawing.Size(150, 21)
        Me.cbMonth.TabIndex = 8
        '
        'lblDateMonth
        '
        Me.lblDateMonth.AutoSize = True
        Me.lblDateMonth.Location = New System.Drawing.Point(40, 70)
        Me.lblDateMonth.Name = "lblDateMonth"
        Me.lblDateMonth.Size = New System.Drawing.Size(37, 13)
        Me.lblDateMonth.TabIndex = 7
        Me.lblDateMonth.Text = "Month"
        '
        'lblDateYear
        '
        Me.lblDateYear.AutoSize = True
        Me.lblDateYear.Location = New System.Drawing.Point(40, 100)
        Me.lblDateYear.Name = "lblDateYear"
        Me.lblDateYear.Size = New System.Drawing.Size(29, 13)
        Me.lblDateYear.TabIndex = 6
        Me.lblDateYear.Text = "Year"
        '
        'btnCreateReport1
        '
        Me.btnCreateReport1.Location = New System.Drawing.Point(117, 157)
        Me.btnCreateReport1.Name = "btnCreateReport1"
        Me.btnCreateReport1.Size = New System.Drawing.Size(100, 25)
        Me.btnCreateReport1.TabIndex = 2
        Me.btnCreateReport1.Text = "Create Report"
        Me.btnCreateReport1.UseVisualStyleBackColor = True
        '
        'gbCBRp2
        '
        Me.gbCBRp2.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.gbCBRp2.Controls.Add(Me.Button1)
        Me.gbCBRp2.Location = New System.Drawing.Point(12, 240)
        Me.gbCBRp2.Margin = New System.Windows.Forms.Padding(10)
        Me.gbCBRp2.Name = "gbCBRp2"
        Me.gbCBRp2.Size = New System.Drawing.Size(340, 210)
        Me.gbCBRp2.TabIndex = 1
        Me.gbCBRp2.TabStop = False
        Me.gbCBRp2.Text = "All invoices in the current year, broken down by month."
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(117, 154)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 25)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Create Report"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'frmControlBreakReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(370, 468)
        Me.Controls.Add(Me.gbCBRp2)
        Me.Controls.Add(Me.gbCBRp1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximumSize = New System.Drawing.Size(380, 500)
        Me.MinimumSize = New System.Drawing.Size(380, 500)
        Me.Name = "frmControlBreakReport"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmControlBreakReport"
        Me.gbCBRp1.ResumeLayout(False)
        Me.gbCBRp1.PerformLayout()
        CType(Me.txtYear, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbCBRp2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbCBRp1 As System.Windows.Forms.GroupBox
    Friend WithEvents gbCBRp2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnCreateReport1 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents cbMonth As System.Windows.Forms.ComboBox
    Friend WithEvents lblDateMonth As System.Windows.Forms.Label
    Friend WithEvents lblDateYear As System.Windows.Forms.Label
    Friend WithEvents txtYear As System.Windows.Forms.NumericUpDown
End Class
