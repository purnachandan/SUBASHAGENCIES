Imports SUBASHAGENCIES_BLL

Public Class frmEmployeeBeat
    Dim oBLL As Business_Logic_Layer
    Public Sub New()
        Try
            ' This call is required by the designer.
            InitializeComponent()
            oBLL = New Business_Logic_Layer
            ' Add any initialization after the InitializeComponent() call.
        Catch ex As Exception
            MsgBox(ex.Message, vbOKCancel, EmpBeat + CMS)
        End Try
    End Sub
    Private Sub frmEmployeeBeat_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            LoadControls()
        Catch ex As Exception
            MsgBox(ex.Message, vbOKCancel, EmpBeat + CMS)
        End Try
    End Sub

    Private Sub LoadControls()
        Try
            LoadEmployees()
            LoadBeats()
        Catch ex As Exception
            MsgBox(ex.Message, vbOKCancel, EmpBeat + CMS)
        End Try
    End Sub

    Private Sub LoadEmployees()
        Dim oEmployees As List(Of EMPLOYEE)
        Try
            oEmployees = oBLL.Pull_Employees
            cmbEmployees.DataSource = oEmployees
            cmbEmployees.DisplayMember = "EMPLOYEENAME"
            cmbEmployees.ValueMember = "EMPLOYEEID"
        Catch ex As Exception
            MsgBox(ex.Message, vbOKCancel, EmpBeat + CMS)
        End Try
    End Sub

    Private Sub LoadBeats()
        Dim oBeats As List(Of BEAT)
        Try
            oBeats = oBLL.Pull_Beats
            lstBeats.DataSource = oBeats
            lstBeats.DisplayMember = "BEATNAME"
            lstBeats.ValueMember = "BEATID"
        Catch ex As Exception
            MsgBox(ex.Message, vbOKCancel, EmpBeat + CMS)
        End Try
    End Sub
End Class