<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEmployeeBeat
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
        Me.pnlAssignBeat = New System.Windows.Forms.Panel()
        Me.lstBeats = New System.Windows.Forms.ListBox()
        Me.cmbEmployees = New System.Windows.Forms.ComboBox()
        Me.lblAssignBeat = New System.Windows.Forms.Label()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnAssignBeats = New System.Windows.Forms.Button()
        Me.lblBeats = New System.Windows.Forms.Label()
        Me.lblEmployeeName = New System.Windows.Forms.Label()
        Me.txtEmp_Tmp = New System.Windows.Forms.TextBox()
        Me.pnlAssignBeat.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlAssignBeat
        '
        Me.pnlAssignBeat.Controls.Add(Me.lstBeats)
        Me.pnlAssignBeat.Controls.Add(Me.cmbEmployees)
        Me.pnlAssignBeat.Controls.Add(Me.lblAssignBeat)
        Me.pnlAssignBeat.Controls.Add(Me.btnClear)
        Me.pnlAssignBeat.Controls.Add(Me.btnAssignBeats)
        Me.pnlAssignBeat.Controls.Add(Me.txtEmp_Tmp)
        Me.pnlAssignBeat.Controls.Add(Me.lblBeats)
        Me.pnlAssignBeat.Controls.Add(Me.lblEmployeeName)
        Me.pnlAssignBeat.Location = New System.Drawing.Point(0, 0)
        Me.pnlAssignBeat.Margin = New System.Windows.Forms.Padding(5)
        Me.pnlAssignBeat.Name = "pnlAssignBeat"
        Me.pnlAssignBeat.Size = New System.Drawing.Size(559, 409)
        Me.pnlAssignBeat.TabIndex = 2
        '
        'lstBeats
        '
        Me.lstBeats.FormattingEnabled = True
        Me.lstBeats.ItemHeight = 16
        Me.lstBeats.Location = New System.Drawing.Point(160, 144)
        Me.lstBeats.Name = "lstBeats"
        Me.lstBeats.Size = New System.Drawing.Size(318, 180)
        Me.lstBeats.TabIndex = 22
        '
        'cmbEmployees
        '
        Me.cmbEmployees.FormattingEnabled = True
        Me.cmbEmployees.Location = New System.Drawing.Point(161, 88)
        Me.cmbEmployees.Name = "cmbEmployees"
        Me.cmbEmployees.Size = New System.Drawing.Size(316, 24)
        Me.cmbEmployees.TabIndex = 21
        '
        'lblAssignBeat
        '
        Me.lblAssignBeat.AutoSize = True
        Me.lblAssignBeat.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.lblAssignBeat.Location = New System.Drawing.Point(116, 20)
        Me.lblAssignBeat.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblAssignBeat.Name = "lblAssignBeat"
        Me.lblAssignBeat.Size = New System.Drawing.Size(257, 26)
        Me.lblAssignBeat.TabIndex = 20
        Me.lblAssignBeat.Text = "Assign Beat to Employee"
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(325, 352)
        Me.btnClear.Margin = New System.Windows.Forms.Padding(4)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(100, 34)
        Me.btnClear.TabIndex = 15
        Me.btnClear.Text = "Reset"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnAssignBeats
        '
        Me.btnAssignBeats.Location = New System.Drawing.Point(161, 352)
        Me.btnAssignBeats.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAssignBeats.Name = "btnAssignBeats"
        Me.btnAssignBeats.Size = New System.Drawing.Size(100, 34)
        Me.btnAssignBeats.TabIndex = 14
        Me.btnAssignBeats.Text = "Add"
        Me.btnAssignBeats.UseVisualStyleBackColor = True
        '
        'lblBeats
        '
        Me.lblBeats.AutoSize = True
        Me.lblBeats.Location = New System.Drawing.Point(44, 144)
        Me.lblBeats.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblBeats.Name = "lblBeats"
        Me.lblBeats.Size = New System.Drawing.Size(67, 17)
        Me.lblBeats.TabIndex = 6
        Me.lblBeats.Text = "Beat List:"
        '
        'lblEmployeeName
        '
        Me.lblEmployeeName.AutoSize = True
        Me.lblEmployeeName.Location = New System.Drawing.Point(44, 89)
        Me.lblEmployeeName.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblEmployeeName.Name = "lblEmployeeName"
        Me.lblEmployeeName.Size = New System.Drawing.Size(115, 17)
        Me.lblEmployeeName.TabIndex = 0
        Me.lblEmployeeName.Text = "Employee Name:"
        '
        'txtEmp_Tmp
        '
        Me.txtEmp_Tmp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtEmp_Tmp.Location = New System.Drawing.Point(160, 87)
        Me.txtEmp_Tmp.Margin = New System.Windows.Forms.Padding(4)
        Me.txtEmp_Tmp.MaxLength = 9
        Me.txtEmp_Tmp.Multiline = True
        Me.txtEmp_Tmp.Name = "txtEmp_Tmp"
        Me.txtEmp_Tmp.Size = New System.Drawing.Size(318, 27)
        Me.txtEmp_Tmp.TabIndex = 8
        '
        'frmEmployeeBeat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(560, 411)
        Me.Controls.Add(Me.pnlAssignBeat)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmEmployeeBeat"
        Me.Text = "Assign Beats to Employees"
        Me.pnlAssignBeat.ResumeLayout(False)
        Me.pnlAssignBeat.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlAssignBeat As System.Windows.Forms.Panel
    Friend WithEvents lblAssignBeat As System.Windows.Forms.Label
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnAssignBeats As System.Windows.Forms.Button
    Friend WithEvents lblBeats As System.Windows.Forms.Label
    Friend WithEvents lblEmployeeName As System.Windows.Forms.Label
    Friend WithEvents cmbEmployees As System.Windows.Forms.ComboBox
    Friend WithEvents lstBeats As System.Windows.Forms.ListBox
    Friend WithEvents txtEmp_Tmp As System.Windows.Forms.TextBox
End Class
