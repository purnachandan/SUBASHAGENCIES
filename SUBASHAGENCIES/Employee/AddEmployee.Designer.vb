<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddEmployee
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
        Me.pnlAddEmployee = New System.Windows.Forms.Panel()
        Me.lblAddEmployee = New System.Windows.Forms.Label()
        Me.dtpReleasingDate = New System.Windows.Forms.DateTimePicker()
        Me.dtpJoiningDate = New System.Windows.Forms.DateTimePicker()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnAddEmployee = New System.Windows.Forms.Button()
        Me.txtSalary = New System.Windows.Forms.TextBox()
        Me.txtReleasingDate = New System.Windows.Forms.TextBox()
        Me.txtJoiningDate = New System.Windows.Forms.TextBox()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.lblLastName = New System.Windows.Forms.Label()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.lblSalary = New System.Windows.Forms.Label()
        Me.lblDesignation = New System.Windows.Forms.Label()
        Me.lblReleasingDate = New System.Windows.Forms.Label()
        Me.lblJoinngDate = New System.Windows.Forms.Label()
        Me.lblFirstName = New System.Windows.Forms.Label()
        Me.cmbDesignation = New System.Windows.Forms.ComboBox()
        Me.cmbStatus = New System.Windows.Forms.ComboBox()
        Me.txtStatus_Emp = New System.Windows.Forms.TextBox()
        Me.txtDesignation_Emp = New System.Windows.Forms.TextBox()
        Me.pnlAddEmployee.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlAddEmployee
        '
        Me.pnlAddEmployee.Controls.Add(Me.lblAddEmployee)
        Me.pnlAddEmployee.Controls.Add(Me.dtpReleasingDate)
        Me.pnlAddEmployee.Controls.Add(Me.dtpJoiningDate)
        Me.pnlAddEmployee.Controls.Add(Me.btnClear)
        Me.pnlAddEmployee.Controls.Add(Me.btnAddEmployee)
        Me.pnlAddEmployee.Controls.Add(Me.txtSalary)
        Me.pnlAddEmployee.Controls.Add(Me.txtReleasingDate)
        Me.pnlAddEmployee.Controls.Add(Me.txtJoiningDate)
        Me.pnlAddEmployee.Controls.Add(Me.txtLastName)
        Me.pnlAddEmployee.Controls.Add(Me.txtFirstName)
        Me.pnlAddEmployee.Controls.Add(Me.lblLastName)
        Me.pnlAddEmployee.Controls.Add(Me.lblStatus)
        Me.pnlAddEmployee.Controls.Add(Me.lblSalary)
        Me.pnlAddEmployee.Controls.Add(Me.lblDesignation)
        Me.pnlAddEmployee.Controls.Add(Me.lblReleasingDate)
        Me.pnlAddEmployee.Controls.Add(Me.lblJoinngDate)
        Me.pnlAddEmployee.Controls.Add(Me.lblFirstName)
        Me.pnlAddEmployee.Controls.Add(Me.cmbDesignation)
        Me.pnlAddEmployee.Controls.Add(Me.cmbStatus)
        Me.pnlAddEmployee.Controls.Add(Me.txtStatus_Emp)
        Me.pnlAddEmployee.Controls.Add(Me.txtDesignation_Emp)
        Me.pnlAddEmployee.Location = New System.Drawing.Point(2, 2)
        Me.pnlAddEmployee.Margin = New System.Windows.Forms.Padding(4)
        Me.pnlAddEmployee.Name = "pnlAddEmployee"
        Me.pnlAddEmployee.Size = New System.Drawing.Size(414, 442)
        Me.pnlAddEmployee.TabIndex = 0
        '
        'lblAddEmployee
        '
        Me.lblAddEmployee.AutoSize = True
        Me.lblAddEmployee.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.lblAddEmployee.Location = New System.Drawing.Point(131, 18)
        Me.lblAddEmployee.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblAddEmployee.Name = "lblAddEmployee"
        Me.lblAddEmployee.Size = New System.Drawing.Size(155, 26)
        Me.lblAddEmployee.TabIndex = 20
        Me.lblAddEmployee.Text = "Add Employee"
        '
        'dtpReleasingDate
        '
        Me.dtpReleasingDate.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.dtpReleasingDate.Enabled = False
        Me.dtpReleasingDate.Location = New System.Drawing.Point(350, 203)
        Me.dtpReleasingDate.Name = "dtpReleasingDate"
        Me.dtpReleasingDate.Size = New System.Drawing.Size(17, 23)
        Me.dtpReleasingDate.TabIndex = 19
        '
        'dtpJoiningDate
        '
        Me.dtpJoiningDate.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.dtpJoiningDate.Location = New System.Drawing.Point(350, 159)
        Me.dtpJoiningDate.Name = "dtpJoiningDate"
        Me.dtpJoiningDate.Size = New System.Drawing.Size(17, 23)
        Me.dtpJoiningDate.TabIndex = 18
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(271, 394)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 28)
        Me.btnClear.TabIndex = 15
        Me.btnClear.Text = "Reset"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnAddEmployee
        '
        Me.btnAddEmployee.Location = New System.Drawing.Point(148, 394)
        Me.btnAddEmployee.Name = "btnAddEmployee"
        Me.btnAddEmployee.Size = New System.Drawing.Size(75, 28)
        Me.btnAddEmployee.TabIndex = 14
        Me.btnAddEmployee.Text = "Add"
        Me.btnAddEmployee.UseVisualStyleBackColor = True
        '
        'txtSalary
        '
        Me.txtSalary.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSalary.Location = New System.Drawing.Point(149, 291)
        Me.txtSalary.MaxLength = 6
        Me.txtSalary.Multiline = True
        Me.txtSalary.Name = "txtSalary"
        Me.txtSalary.Size = New System.Drawing.Size(220, 27)
        Me.txtSalary.TabIndex = 12
        '
        'txtReleasingDate
        '
        Me.txtReleasingDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtReleasingDate.Enabled = False
        Me.txtReleasingDate.Location = New System.Drawing.Point(149, 201)
        Me.txtReleasingDate.Multiline = True
        Me.txtReleasingDate.Name = "txtReleasingDate"
        Me.txtReleasingDate.ReadOnly = True
        Me.txtReleasingDate.Size = New System.Drawing.Size(220, 27)
        Me.txtReleasingDate.TabIndex = 10
        '
        'txtJoiningDate
        '
        Me.txtJoiningDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtJoiningDate.Location = New System.Drawing.Point(149, 157)
        Me.txtJoiningDate.Multiline = True
        Me.txtJoiningDate.Name = "txtJoiningDate"
        Me.txtJoiningDate.ReadOnly = True
        Me.txtJoiningDate.Size = New System.Drawing.Size(220, 27)
        Me.txtJoiningDate.TabIndex = 9
        '
        'txtLastName
        '
        Me.txtLastName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtLastName.Location = New System.Drawing.Point(149, 114)
        Me.txtLastName.MaxLength = 50
        Me.txtLastName.Multiline = True
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(220, 27)
        Me.txtLastName.TabIndex = 8
        '
        'txtFirstName
        '
        Me.txtFirstName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFirstName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtFirstName.Location = New System.Drawing.Point(149, 69)
        Me.txtFirstName.MaxLength = 50
        Me.txtFirstName.Multiline = True
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(220, 27)
        Me.txtFirstName.TabIndex = 7
        '
        'lblLastName
        '
        Me.lblLastName.AutoSize = True
        Me.lblLastName.Location = New System.Drawing.Point(62, 117)
        Me.lblLastName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblLastName.Name = "lblLastName"
        Me.lblLastName.Size = New System.Drawing.Size(80, 17)
        Me.lblLastName.TabIndex = 6
        Me.lblLastName.Text = "Last Name:"
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Location = New System.Drawing.Point(90, 339)
        Me.lblStatus.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(52, 17)
        Me.lblStatus.TabIndex = 5
        Me.lblStatus.Text = "Status:"
        '
        'lblSalary
        '
        Me.lblSalary.AutoSize = True
        Me.lblSalary.Location = New System.Drawing.Point(90, 294)
        Me.lblSalary.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSalary.Name = "lblSalary"
        Me.lblSalary.Size = New System.Drawing.Size(52, 17)
        Me.lblSalary.TabIndex = 4
        Me.lblSalary.Text = "Salary:"
        '
        'lblDesignation
        '
        Me.lblDesignation.AutoSize = True
        Me.lblDesignation.Location = New System.Drawing.Point(55, 249)
        Me.lblDesignation.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDesignation.Name = "lblDesignation"
        Me.lblDesignation.Size = New System.Drawing.Size(87, 17)
        Me.lblDesignation.TabIndex = 3
        Me.lblDesignation.Text = "Designation:"
        '
        'lblReleasingDate
        '
        Me.lblReleasingDate.AutoSize = True
        Me.lblReleasingDate.Location = New System.Drawing.Point(33, 204)
        Me.lblReleasingDate.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblReleasingDate.Name = "lblReleasingDate"
        Me.lblReleasingDate.Size = New System.Drawing.Size(109, 17)
        Me.lblReleasingDate.TabIndex = 2
        Me.lblReleasingDate.Text = "Releasing Date:"
        '
        'lblJoinngDate
        '
        Me.lblJoinngDate.AutoSize = True
        Me.lblJoinngDate.Location = New System.Drawing.Point(51, 160)
        Me.lblJoinngDate.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblJoinngDate.Name = "lblJoinngDate"
        Me.lblJoinngDate.Size = New System.Drawing.Size(91, 17)
        Me.lblJoinngDate.TabIndex = 1
        Me.lblJoinngDate.Text = "Joining Date:"
        '
        'lblFirstName
        '
        Me.lblFirstName.AutoSize = True
        Me.lblFirstName.Location = New System.Drawing.Point(62, 72)
        Me.lblFirstName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFirstName.Name = "lblFirstName"
        Me.lblFirstName.Size = New System.Drawing.Size(80, 17)
        Me.lblFirstName.TabIndex = 0
        Me.lblFirstName.Text = "First Name:"
        '
        'cmbDesignation
        '
        Me.cmbDesignation.DisplayMember = "DESIGNATION_ID"
        Me.cmbDesignation.FormattingEnabled = True
        Me.cmbDesignation.Location = New System.Drawing.Point(149, 247)
        Me.cmbDesignation.Name = "cmbDesignation"
        Me.cmbDesignation.Size = New System.Drawing.Size(218, 24)
        Me.cmbDesignation.TabIndex = 11
        Me.cmbDesignation.ValueMember = "DESIGNATION_ID"
        '
        'cmbStatus
        '
        Me.cmbStatus.DisplayMember = "STATUS_ID"
        Me.cmbStatus.FormattingEnabled = True
        Me.cmbStatus.Location = New System.Drawing.Point(149, 335)
        Me.cmbStatus.Name = "cmbStatus"
        Me.cmbStatus.Size = New System.Drawing.Size(219, 24)
        Me.cmbStatus.TabIndex = 13
        Me.cmbStatus.ValueMember = "STATUS_ID"
        '
        'txtStatus_Emp
        '
        Me.txtStatus_Emp.BackColor = System.Drawing.Color.White
        Me.txtStatus_Emp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtStatus_Emp.Location = New System.Drawing.Point(148, 334)
        Me.txtStatus_Emp.Multiline = True
        Me.txtStatus_Emp.Name = "txtStatus_Emp"
        Me.txtStatus_Emp.Size = New System.Drawing.Size(221, 27)
        Me.txtStatus_Emp.TabIndex = 16
        '
        'txtDesignation_Emp
        '
        Me.txtDesignation_Emp.BackColor = System.Drawing.Color.White
        Me.txtDesignation_Emp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDesignation_Emp.Location = New System.Drawing.Point(148, 246)
        Me.txtDesignation_Emp.Multiline = True
        Me.txtDesignation_Emp.Name = "txtDesignation_Emp"
        Me.txtDesignation_Emp.Size = New System.Drawing.Size(220, 27)
        Me.txtDesignation_Emp.TabIndex = 17
        '
        'frmAddEmployee
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(418, 444)
        Me.Controls.Add(Me.pnlAddEmployee)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmAddEmployee"
        Me.Text = "Add Employee"
        Me.pnlAddEmployee.ResumeLayout(False)
        Me.pnlAddEmployee.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlAddEmployee As System.Windows.Forms.Panel
    Friend WithEvents lblJoinngDate As System.Windows.Forms.Label
    Friend WithEvents lblFirstName As System.Windows.Forms.Label
    Friend WithEvents lblStatus As System.Windows.Forms.Label
    Friend WithEvents lblSalary As System.Windows.Forms.Label
    Friend WithEvents lblDesignation As System.Windows.Forms.Label
    Friend WithEvents lblReleasingDate As System.Windows.Forms.Label
    Friend WithEvents lblLastName As System.Windows.Forms.Label
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnAddEmployee As System.Windows.Forms.Button
    Friend WithEvents cmbStatus As System.Windows.Forms.ComboBox
    Friend WithEvents txtSalary As System.Windows.Forms.TextBox
    Friend WithEvents cmbDesignation As System.Windows.Forms.ComboBox
    Friend WithEvents txtReleasingDate As System.Windows.Forms.TextBox
    Friend WithEvents txtJoiningDate As System.Windows.Forms.TextBox
    Friend WithEvents txtLastName As System.Windows.Forms.TextBox
    Friend WithEvents txtFirstName As System.Windows.Forms.TextBox
    Friend WithEvents txtStatus_Emp As System.Windows.Forms.TextBox
    Friend WithEvents txtDesignation_Emp As System.Windows.Forms.TextBox
    Friend WithEvents dtpJoiningDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpReleasingDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblAddEmployee As System.Windows.Forms.Label
End Class
