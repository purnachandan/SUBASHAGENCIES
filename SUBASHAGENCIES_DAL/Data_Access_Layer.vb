Imports System.Configuration.ConfigurationManager
Imports System.Data
Imports System.Data.SqlClient
Public Class Data_Access_Layer

    'Private oConnection As OleDbConnection
    'Private oCommand As OleDbCommand
    'Private oDataAdapter As OleDbDataAdapter
    'Private oDataTable As DataTable
    'Private oDataSet As DataSet

    Private sDataProvider As String
    Private ReadOnly Property DataProvider() As String
        Get
            Return sDataProvider
        End Get
        'Set(ByVal value As String)
        '    sDataProvider = value
        'End Set
    End Property

    Private sUserID As String
    Private ReadOnly Property UserID() As String
        Get
            Return sUserID
        End Get
        'Set(ByVal value As String)
        '    sUserID = value
        'End Set
    End Property

    Private sPassword As String
    Private ReadOnly Property Password() As String
        Get
            Return sPassword
        End Get
        'Set(ByVal value As String)
        '    sPassword = value
        'End Set
    End Property

    Private sConnectionString As String
    Private Property ConnectionString() As String
        Get
            Return sConnectionString
        End Get
        Set(ByVal value As String)
            sConnectionString = value
        End Set
    End Property

    Public Sub New()
        Try
            Call GlobalVariables()
            'Call SetProperties()
            Call LoadConnectionString()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub GlobalVariables()
        Try
            sDataProvider = Configuration.ConfigurationManager.AppSettings("ConnectionString")
            sUserID = Configuration.ConfigurationManager.AppSettings("UserID")
            sPassword = Configuration.ConfigurationManager.AppSettings("Password")
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try
    End Sub

    'Private Sub SetProperties()
    '    Try
    '        DataProvider = sDataProvider
    '        UserID = sUserID
    '        Password = sPassword
    '    Catch ex As Exception
    '        MsgBox(ex.Message.ToString())
    '    End Try
    'End Sub

    Private Sub LoadConnectionString()
        Dim sConnectionString As String
        Try

            sConnectionString = DataProvider + "User ID=" + UserID + "Password=" + Password
            ConnectionString = sConnectionString
        Catch ex As Exception

        End Try
    End Sub
    Public Function Add_Record(sCommandText As String)
        Dim iRecordsAdded As Short = 0
        Try
            Using oConnection As New SqlConnection(ConnectionString)
                oConnection.Open()
                Using oCommand As New SqlCommand(sCommandText, oConnection)
                    iRecordsAdded = oCommand.ExecuteNonQuery
                    Add_Record = iRecordsAdded
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
            Add_Record = -1
        End Try
    End Function

    Public Function Add_Records(sCommandText As String)
        Dim iRecordsAdded As Integer = 0
        Try
            Using oConnection As New SqlConnection(ConnectionString)
                oConnection.Open()
                Using oCommand As New SqlCommand(sCommandText, oConnection)
                    iRecordsAdded = oCommand.ExecuteNonQuery
                    Add_Records = iRecordsAdded
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
            Add_Records = -1
        End Try
    End Function

    Public Function Update_Records(sCommandText As String)
        Dim iRecordsUpdated As Integer = 0
        Try
            Using oConnection As New SqlConnection(ConnectionString)
                oConnection.Open()
                Using oCommand As New SqlCommand(sCommandText, oConnection)
                    iRecordsUpdated = oCommand.ExecuteNonQuery
                    Update_Records = iRecordsUpdated
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
            Update_Records = -1
        End Try
    End Function

    Public Function Pull_Records(sCommandText As String)
        Try
            Using oConnection As New SqlConnection(ConnectionString)
                oConnection.Open()
                Using oCommand As New SqlCommand(sCommandText, oConnection)
                    Using oDataAdapter As New SqlDataAdapter(oCommand)
                        Using oDataTable As New DataTable()
                            oDataAdapter.Fill(oDataTable)
                            Pull_Records = oDataTable
                        End Using
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
            Pull_Records = Nothing
        End Try
    End Function

    Public Function Pull_Multiple_RecordSet(sCommandText As String)
        Try
            Using oConnection As New SqlConnection(ConnectionString)
                oConnection.Open()
                Using oCommand As New SqlCommand(sCommandText, oConnection)
                    Using oDataAdapter As New SqlDataAdapter(oCommand)
                        Using oDataSet As New DataTable()
                            oDataAdapter.Fill(oDataSet)
                            Pull_Multiple_RecordSet = oDataSet
                        End Using
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
            Pull_Multiple_RecordSet = Nothing
        End Try
    End Function

    Public Function Pull_Single_Value(sCommandText As String)
        Try
            Using oConnection As New SqlConnection(ConnectionString)
                oConnection.Open()
                Using oCommand As New SqlCommand(sCommandText, oConnection)
                    Pull_Single_Value = oCommand.ExecuteScalar
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
            Pull_Single_Value = Nothing
        End Try
    End Function

    Public Function Add_Record_With_Proc(oCmd As SqlCommand)
        Try
            Using oConnection As New SqlConnection(ConnectionString)
                oConnection.Open()
                Using oCmd
                    oCmd.Connection = oConnection
                    oCmd.ExecuteNonQuery()
                    Add_Record_With_Proc = True
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
            Add_Record_With_Proc = False
        End Try
    End Function
End Class

