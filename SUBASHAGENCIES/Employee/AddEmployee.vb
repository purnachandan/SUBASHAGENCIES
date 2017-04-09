Imports SUBASHAGENCIES_BLL
Imports System.Text.RegularExpressions

Public Class frmAddEmployee
    Dim oBLL As Business_Logic_Layer
    Public Sub New()
        Try
            ' This call is required by the designer.
            InitializeComponent()
            oBLL = New Business_Logic_Layer
            ' Add any initialization after the InitializeComponent() call.
        Catch ex As Exception
            MsgBox(ex.Message, vbOKCancel, Employee & " - Collection Management System")
        End Try
    End Sub
    Private Sub AddEmployee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            'dtpJoiningDate.Format = DateTimePickerFormat.Custom
            'dtpJoiningDate.CustomFormat = "dd-MMM-yyyy"
            Call LoadControls()

        Catch ex As Exception
            MsgBox(ex.Message, vbOKCancel, Employee & " - Collection Management System")
        End Try
    End Sub

    Private Sub LoadControls()
        Try
            LoadDesignations()
            LoadStatuses()

            txtSalary.Text = "0"

            txtJoiningDate.Text = dtpJoiningDate.Value.ToString("dd-MMM-yyyy")
            dtpJoiningDate.MaxDate = DateAdd("d", 1, Date.Now)
        Catch ex As Exception
            MsgBox(ex.Message, vbOKCancel, Employee & " - Collection Management System")
        End Try
    End Sub

    Private Sub dtpJoiningDate_ValueChanged(sender As Object, e As EventArgs) Handles dtpJoiningDate.ValueChanged
        Try
            txtJoiningDate.Text = dtpJoiningDate.Value.ToString("dd-MMM-yyyy")
        Catch ex As Exception
            MsgBox(ex.Message, vbOKCancel, Employee & " - Collection Management System")
        End Try
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        Try
            ResetControls()
        Catch ex As Exception
            MsgBox(ex.Message, vbOKCancel, Employee & " - Collection Management System")
        End Try
    End Sub

    Private Sub LoadDesignations()
        Dim oDesignations As New List(Of DESIGNATION)
        Try
            oDesignations = oBLL.Pull_Designation
            cmbDesignation.DataSource = oDesignations
            cmbDesignation.DisplayMember = "DesignationName"
            cmbDesignation.ValueMember = "DesignationID"
        Catch ex As Exception
            MsgBox(ex.Message, vbOKCancel, Employee & " - Collection Management System")
        End Try
    End Sub

    Private Sub LoadStatuses()
        Dim oStatuses As New List(Of STATUS)
        Try
            oStatuses = oBLL.Pull_Status
            cmbStatus.DataSource = oStatuses
            cmbStatus.DisplayMember = "StatusText"
            cmbStatus.ValueMember = "StatusID"
            cmbStatus.SelectedItem = cmbStatus.Items.Item(1)
        Catch ex As Exception
            MsgBox(ex.Message, vbOKCancel, Employee & " - Collection Management System")
        End Try
    End Sub

    Private Sub btnAddEmployee_Click(sender As Object, e As EventArgs) Handles btnAddEmployee.Click
        Try
            If (ValidateControls()) Then
                If (oBLL.Add_Employee(txtFirstName.Text.ToString, txtLastName.Text.ToString, Format(CDate(txtJoiningDate.Text.ToString), "yyyy-MM-dd"),
                                   cmbDesignation.SelectedValue.ToString, CInt(txtSalary.Text.ToString),
                                  IIf(cmbStatus.SelectedValue.ToString = "S1", True, False))) Then
                    MsgBox("Employee Added successfully")
                    ResetControls()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbOKCancel, Employee & " - Collection Management System")
        End Try
    End Sub

    Private Function ValidateControls()
        Try
            If Not (Regex.IsMatch(txtFirstName.Text, "^[A-Za-z0-9 ]{1,50}$")) Then
                MsgBox("First Name con contain only alphabets and numbers", vbOK, "Collection Mangement System")
                ValidateControls = False
                Exit Function
            End If
            If Not (Regex.IsMatch(txtLastName.Text, "^[A-Za-z0-9 ]{1,50}$")) Then
                MsgBox("Last Name con contain only alphabets and numbers", vbOK, "Collection Mangement System")
                ValidateControls = False
                Exit Function
            End If
            If (cmbDesignation.SelectedIndex = 0) Then
                MsgBox("Please select valid Designation", vbOK, "Collection Mangement System")
                ValidateControls = False
                Exit Function
            End If

            If (Regex.IsMatch(txtSalary.Text, "^[0-9]{1,6}$")) Then
                If Not ((CInt(txtSalary.Text) > 0) And (CInt(txtSalary.Text) < 1000000)) Then
                    MsgBox("Salary should be between 1 and 999999", vbOK, "Collection Management System")
                    ValidateControls = False
                    Exit Function
                End If '  
            Else
                MsgBox("Salary can accept only Numbers", vbOK, "Collection Mangement System")
                ValidateControls = False
                Exit Function
            End If
            If (cmbStatus.SelectedIndex = 0) Then
                MsgBox("Please select valid Status", vbOK, "Collection Mangement System")
                ValidateControls = False
                Exit Function
            End If
            ValidateControls = True
        Catch ex As Exception
            ValidateControls = False
            MsgBox(ex.Message, vbOKCancel, Employee & " - Collection Management System")
        End Try
    End Function

    Private Sub ResetControls()
        Try
            txtFirstName.Text = String.Empty
            txtLastName.Text = String.Empty
            dtpJoiningDate.Refresh()
            dtpJoiningDate.Value = DateTime.Now
            txtJoiningDate.Text = dtpJoiningDate.Value.ToString("dd-MMM-yyyy")
            cmbDesignation.SelectedItem = cmbDesignation.Items.Item(0)
            cmbStatus.SelectedItem = cmbStatus.Items.Item(1)
            txtSalary.Text = "0"
        Catch ex As Exception
            MsgBox(ex.Message, vbOKCancel, Employee & " - Collection Management System")
        End Try
    End Sub

End Class