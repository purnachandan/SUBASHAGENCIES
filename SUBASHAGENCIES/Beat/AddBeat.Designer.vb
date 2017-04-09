<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddBeat
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
        Me.pnlAddBeat = New System.Windows.Forms.Panel()
        Me.lblAddBeat = New System.Windows.Forms.Label()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnAddBeat = New System.Windows.Forms.Button()
        Me.txtOutletCount = New System.Windows.Forms.TextBox()
        Me.txtBeatName = New System.Windows.Forms.TextBox()
        Me.lblOutletCount = New System.Windows.Forms.Label()
        Me.lblBeatName = New System.Windows.Forms.Label()
        Me.pnlAddBeat.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlAddBeat
        '
        Me.pnlAddBeat.Controls.Add(Me.lblAddBeat)
        Me.pnlAddBeat.Controls.Add(Me.btnClear)
        Me.pnlAddBeat.Controls.Add(Me.btnAddBeat)
        Me.pnlAddBeat.Controls.Add(Me.txtOutletCount)
        Me.pnlAddBeat.Controls.Add(Me.txtBeatName)
        Me.pnlAddBeat.Controls.Add(Me.lblOutletCount)
        Me.pnlAddBeat.Controls.Add(Me.lblBeatName)
        Me.pnlAddBeat.Location = New System.Drawing.Point(0, 1)
        Me.pnlAddBeat.Margin = New System.Windows.Forms.Padding(5)
        Me.pnlAddBeat.Name = "pnlAddBeat"
        Me.pnlAddBeat.Size = New System.Drawing.Size(484, 274)
        Me.pnlAddBeat.TabIndex = 1
        '
        'lblAddBeat
        '
        Me.lblAddBeat.AutoSize = True
        Me.lblAddBeat.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.lblAddBeat.Location = New System.Drawing.Point(182, 20)
        Me.lblAddBeat.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblAddBeat.Name = "lblAddBeat"
        Me.lblAddBeat.Size = New System.Drawing.Size(102, 26)
        Me.lblAddBeat.TabIndex = 20
        Me.lblAddBeat.Text = "Add Beat"
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(252, 209)
        Me.btnClear.Margin = New System.Windows.Forms.Padding(4)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(100, 34)
        Me.btnClear.TabIndex = 15
        Me.btnClear.Text = "Reset"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnAddBeat
        '
        Me.btnAddBeat.Location = New System.Drawing.Point(88, 209)
        Me.btnAddBeat.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAddBeat.Name = "btnAddBeat"
        Me.btnAddBeat.Size = New System.Drawing.Size(100, 34)
        Me.btnAddBeat.TabIndex = 14
        Me.btnAddBeat.Text = "Add"
        Me.btnAddBeat.UseVisualStyleBackColor = True
        '
        'txtOutletCount
        '
        Me.txtOutletCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtOutletCount.Location = New System.Drawing.Point(135, 140)
        Me.txtOutletCount.Margin = New System.Windows.Forms.Padding(4)
        Me.txtOutletCount.MaxLength = 9
        Me.txtOutletCount.Multiline = True
        Me.txtOutletCount.Name = "txtOutletCount"
        Me.txtOutletCount.Size = New System.Drawing.Size(318, 33)
        Me.txtOutletCount.TabIndex = 8
        '
        'txtBeatName
        '
        Me.txtBeatName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBeatName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtBeatName.Location = New System.Drawing.Point(135, 85)
        Me.txtBeatName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtBeatName.MaxLength = 200
        Me.txtBeatName.Multiline = True
        Me.txtBeatName.Name = "txtBeatName"
        Me.txtBeatName.Size = New System.Drawing.Size(318, 33)
        Me.txtBeatName.TabIndex = 7
        '
        'lblOutletCount
        '
        Me.lblOutletCount.AutoSize = True
        Me.lblOutletCount.Location = New System.Drawing.Point(44, 144)
        Me.lblOutletCount.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblOutletCount.Name = "lblOutletCount"
        Me.lblOutletCount.Size = New System.Drawing.Size(91, 17)
        Me.lblOutletCount.TabIndex = 6
        Me.lblOutletCount.Text = "Outlet Count:"
        '
        'lblBeatName
        '
        Me.lblBeatName.AutoSize = True
        Me.lblBeatName.Location = New System.Drawing.Point(44, 89)
        Me.lblBeatName.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblBeatName.Name = "lblBeatName"
        Me.lblBeatName.Size = New System.Drawing.Size(82, 17)
        Me.lblBeatName.TabIndex = 0
        Me.lblBeatName.Text = "Beat Name:"
        '
        'frmAddBeat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(485, 276)
        Me.Controls.Add(Me.pnlAddBeat)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmAddBeat"
        Me.Text = "Add Beat"
        Me.pnlAddBeat.ResumeLayout(False)
        Me.pnlAddBeat.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlAddBeat As System.Windows.Forms.Panel
    Friend WithEvents lblAddBeat As System.Windows.Forms.Label
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnAddBeat As System.Windows.Forms.Button
    Friend WithEvents txtOutletCount As System.Windows.Forms.TextBox
    Friend WithEvents txtBeatName As System.Windows.Forms.TextBox
    Friend WithEvents lblOutletCount As System.Windows.Forms.Label
    Friend WithEvents lblBeatName As System.Windows.Forms.Label
End Class
