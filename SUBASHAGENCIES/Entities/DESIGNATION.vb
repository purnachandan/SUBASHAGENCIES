Public Class DESIGNATION
    Private sDesignation_ID As String
    Public ReadOnly Property DesignationID() As String
        Get
            Return sDesignation_ID
        End Get
        'Private Set(ByVal value As String)
        '    sDesignation_ID = value
        'End Set
    End Property

    Private sDesignation_Name As String
    Public ReadOnly Property DesignationName() As String
        Get
            Return sDesignation_Name
        End Get
        'Private Set(ByVal value As String)
        '    sDesignation_Name = value
        'End Set
    End Property

    Public Sub New(ByVal sDesignationID As String, ByVal sDesignationName As String)
        Try
            sDesignation_ID = sDesignationID
            sDesignation_Name = sDesignationName
            'Call SetValues()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'Private Sub SetValues()
    '    Try
    '        DesignationID = sDesignation_ID
    '        DesignationName = sDesignation_Name
    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '    End Try
    'End Sub
End Class
