<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddBill
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
        Me.lblBillType = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnGenerate = New System.Windows.Forms.Button()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.lblEndBill = New System.Windows.Forms.Label()
        Me.lblStartBill = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbBillType = New System.Windows.Forms.ComboBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.lblOutlet = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.lblBillNo = New System.Windows.Forms.Label()
        Me.dgvBills = New System.Windows.Forms.DataGridView()
        Me.Bill_No = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Outlet_Name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Bill_Amount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.dgvBills, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblBillType
        '
        Me.lblBillType.AutoSize = True
        Me.lblBillType.Location = New System.Drawing.Point(55, 28)
        Me.lblBillType.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblBillType.Name = "lblBillType"
        Me.lblBillType.Size = New System.Drawing.Size(44, 17)
        Me.lblBillType.TabIndex = 0
        Me.lblBillType.Text = "Type:"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnGenerate)
        Me.Panel1.Controls.Add(Me.TextBox3)
        Me.Panel1.Controls.Add(Me.TextBox2)
        Me.Panel1.Controls.Add(Me.lblEndBill)
        Me.Panel1.Controls.Add(Me.lblStartBill)
        Me.Panel1.Controls.Add(Me.TextBox1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.cmbBillType)
        Me.Panel1.Controls.Add(Me.lblBillType)
        Me.Panel1.Location = New System.Drawing.Point(84, 4)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(583, 148)
        Me.Panel1.TabIndex = 1
        '
        'btnGenerate
        '
        Me.btnGenerate.Location = New System.Drawing.Point(240, 102)
        Me.btnGenerate.Margin = New System.Windows.Forms.Padding(4)
        Me.btnGenerate.Name = "btnGenerate"
        Me.btnGenerate.Size = New System.Drawing.Size(100, 28)
        Me.btnGenerate.TabIndex = 8
        Me.btnGenerate.Text = "Generate"
        Me.btnGenerate.UseVisualStyleBackColor = True
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(382, 68)
        Me.TextBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(132, 23)
        Me.TextBox3.TabIndex = 7
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(108, 68)
        Me.TextBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(159, 23)
        Me.TextBox2.TabIndex = 6
        '
        'lblEndBill
        '
        Me.lblEndBill.AutoSize = True
        Me.lblEndBill.Location = New System.Drawing.Point(315, 71)
        Me.lblEndBill.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblEndBill.Name = "lblEndBill"
        Me.lblEndBill.Size = New System.Drawing.Size(59, 17)
        Me.lblEndBill.TabIndex = 5
        Me.lblEndBill.Text = "End Bill:"
        '
        'lblStartBill
        '
        Me.lblStartBill.AutoSize = True
        Me.lblStartBill.Location = New System.Drawing.Point(36, 71)
        Me.lblStartBill.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblStartBill.Name = "lblStartBill"
        Me.lblStartBill.Size = New System.Drawing.Size(64, 17)
        Me.lblStartBill.TabIndex = 4
        Me.lblStartBill.Text = "Start Bill:"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(382, 25)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(132, 23)
        Me.TextBox1.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(331, 28)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Date:"
        '
        'cmbBillType
        '
        Me.cmbBillType.FormattingEnabled = True
        Me.cmbBillType.Items.AddRange(New Object() {"General", "Britannia", "Marico", "Johnson"})
        Me.cmbBillType.Location = New System.Drawing.Point(107, 25)
        Me.cmbBillType.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbBillType.Name = "cmbBillType"
        Me.cmbBillType.Size = New System.Drawing.Size(160, 24)
        Me.cmbBillType.TabIndex = 2
        Me.cmbBillType.Text = "---Select---"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.TextBox5)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.btnAdd)
        Me.Panel2.Controls.Add(Me.ComboBox1)
        Me.Panel2.Controls.Add(Me.lblOutlet)
        Me.Panel2.Controls.Add(Me.TextBox4)
        Me.Panel2.Controls.Add(Me.lblBillNo)
        Me.Panel2.Location = New System.Drawing.Point(84, 192)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(583, 148)
        Me.Panel2.TabIndex = 2
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(382, 18)
        Me.TextBox5.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(132, 23)
        Me.TextBox5.TabIndex = 15
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(322, 21)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 17)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Type:"
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(240, 102)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(100, 28)
        Me.btnAdd.TabIndex = 13
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(107, 66)
        Me.ComboBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(420, 24)
        Me.ComboBox1.TabIndex = 12
        '
        'lblOutlet
        '
        Me.lblOutlet.AutoSize = True
        Me.lblOutlet.Location = New System.Drawing.Point(8, 69)
        Me.lblOutlet.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblOutlet.Name = "lblOutlet"
        Me.lblOutlet.Size = New System.Drawing.Size(91, 17)
        Me.lblOutlet.TabIndex = 11
        Me.lblOutlet.Text = "Outlet Name:"
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(108, 18)
        Me.TextBox4.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(132, 23)
        Me.TextBox4.TabIndex = 10
        '
        'lblBillNo
        '
        Me.lblBillNo.AutoSize = True
        Me.lblBillNo.Location = New System.Drawing.Point(46, 21)
        Me.lblBillNo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblBillNo.Name = "lblBillNo"
        Me.lblBillNo.Size = New System.Drawing.Size(52, 17)
        Me.lblBillNo.TabIndex = 9
        Me.lblBillNo.Text = "Bill No."
        '
        'dgvBills
        '
        Me.dgvBills.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvBills.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Bill_No, Me.Outlet_Name, Me.Bill_Amount})
        Me.dgvBills.Location = New System.Drawing.Point(32, 363)
        Me.dgvBills.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvBills.Name = "dgvBills"
        Me.dgvBills.ReadOnly = True
        Me.dgvBills.Size = New System.Drawing.Size(697, 138)
        Me.dgvBills.TabIndex = 3
        '
        'Bill_No
        '
        Me.Bill_No.DividerWidth = 1
        Me.Bill_No.HeaderText = "Bill No."
        Me.Bill_No.Name = "Bill_No"
        Me.Bill_No.ReadOnly = True
        Me.Bill_No.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Bill_No.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Bill_No.Width = 80
        '
        'Outlet_Name
        '
        Me.Outlet_Name.DividerWidth = 1
        Me.Outlet_Name.HeaderText = "Outlet Name"
        Me.Outlet_Name.Name = "Outlet_Name"
        Me.Outlet_Name.ReadOnly = True
        Me.Outlet_Name.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Outlet_Name.Width = 300
        '
        'Bill_Amount
        '
        Me.Bill_Amount.DividerWidth = 1
        Me.Bill_Amount.HeaderText = "Bill Amount"
        Me.Bill_Amount.Name = "Bill_Amount"
        Me.Bill_Amount.ReadOnly = True
        Me.Bill_Amount.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'frmAddBill
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(824, 542)
        Me.Controls.Add(Me.dgvBills)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmAddBill"
        Me.Text = "Add Bills"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.dgvBills, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblBillType As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents cmbBillType As System.Windows.Forms.ComboBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnGenerate As System.Windows.Forms.Button
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents lblEndBill As System.Windows.Forms.Label
    Friend WithEvents lblStartBill As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents lblOutlet As System.Windows.Forms.Label
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents lblBillNo As System.Windows.Forms.Label
    Friend WithEvents dgvBills As System.Windows.Forms.DataGridView
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Bill_No As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Outlet_Name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Bill_Amount As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
