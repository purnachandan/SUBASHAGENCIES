Imports SUBASHAGENCIES_DAL
Imports System.Data.SqlClient

Public Class Business_Logic_Layer
    Public oDAL As Data_Access_Layer
    Public sQuery As String
    Public sDesignation_Query As String = "SELECT DESIGNATION_ID, DESIGNATION_NAME FROM DESIGNATION_MASTER ORDER BY DESIGNATION_ID ASC"
    Public sStatus_Query As String = "SELECT STATUS_ID, STATUS_TEXT FROM STATUS_MASTER ORDER BY STATUS_ID ASC"
    Public Sub New()
        Try
            oDAL = New Data_Access_Layer
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub
    Public Function Add_Employee(sFirstName As String, sLastName As String, dJoiningDate As Date,
                                 sDesignationId As String, iSalary As Integer, bStatus As Boolean)
        Dim oCmd As New SqlCommand
        Dim oParam1 As SqlParameter
        Dim oParam2 As SqlParameter
        Dim oParam3 As SqlParameter
        Dim oParam4 As SqlParameter
        Dim oParam5 As SqlParameter
        Dim oParam6 As SqlParameter
        Try
            oCmd.CommandType = CommandType.StoredProcedure
            oCmd.CommandText = "ADD_EMPLOYEE"
            
            oParam1 = New SqlParameter("@FIRST_NAME", SqlDbType.VarChar)
            oParam1.Value = sFirstName
            oCmd.Parameters.Add(oParam1)

            oParam2 = New SqlParameter("@LAST_NAME", SqlDbType.VarChar)
            oParam2.Value = sLastName
            oCmd.Parameters.Add(oParam2)

            oParam3 = New SqlParameter("@JOINING_DATE", SqlDbType.Date)
            oParam3.Value = dJoiningDate
            oCmd.Parameters.Add(oParam3)

            oParam4 = New SqlParameter("@DESIGNATION_ID", SqlDbType.VarChar)
            oParam4.Value = sDesignationId
            oCmd.Parameters.Add(oParam4)

            oParam5 = New SqlParameter("@SALARY", SqlDbType.Int)
            oParam5.Value = iSalary
            oCmd.Parameters.Add(oParam5)

            oParam6 = New SqlParameter("@STATUS_ID", SqlDbType.Bit)
            oParam6.Value = bStatus
            oCmd.Parameters.Add(oParam6)

            If (oDAL.Add_Record_With_Proc(oCmd)) Then
                Add_Employee = True
            Else
                Add_Employee = False
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            Add_Employee = False
        End Try
    End Function
    Public Function Pull_Designation()
        Dim oDesignations_Table As DataTable
        Dim oDesginations As New List(Of DESIGNATION)
        Try
            oDesignations_Table = oDAL.Pull_Records(sDesignation_Query)
            For Each dr As DataRow In oDesignations_Table.Rows
                Dim oDesgination As DESIGNATION
                oDesgination = New DESIGNATION(dr("DESIGNATION_ID").ToString,
                                               dr("DESIGNATION_NAME").ToString)
                oDesginations.Add(oDesgination)
            Next
            Pull_Designation = oDesginations
        Catch ex As Exception
            MsgBox(ex.Message)
            Pull_Designation = Nothing
        End Try

    End Function

    Public Function Pull_Status()
        Dim oStatus_Table As DataTable
        Dim oStatuses As New List(Of STATUS)
        Try
            oStatus_Table = oDAL.Pull_Records(sStatus_Query)
            For Each dr As DataRow In oStatus_Table.Rows
                Dim oStatus As STATUS
                oStatus = New STATUS(dr("STATUS_ID").ToString,
                                           dr("STATUS_TEXT").ToString)
                oStatuses.Add(oStatus)
            Next
            Pull_Status = oStatuses
        Catch ex As Exception
            MsgBox(ex.Message)
            Pull_Status = Nothing
        End Try

    End Function
End Class
