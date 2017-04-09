Public Class EMPLOYEE
    Private sEmployee_ID As String
    Public ReadOnly Property EmployeeID() As String
        Get
            Return sEmployee_ID
        End Get
    End Property

    Private sEmployee_Name As String
    Public ReadOnly Property EmployeeName() As String
        Get
            Return sEmployee_Name
        End Get
    End Property

    Private iSalary As String
    Public ReadOnly Property Salary() As String
        Get
            Return iSalary
        End Get
    End Property

    Public Sub New(sEmployeeID As String, sEmployeeName As String, iSal As Integer)
        Try
            sEmployee_ID = sEmployeeID
            sEmployee_Name = sEmployeeName
            iSalary = iSal
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class
