Public Class STATUS
    Private sStatus_ID As String
    Public ReadOnly Property StatusID() As String
        Get
            Return sStatus_ID
        End Get
    End Property

    Private sStatus_Text As String
    Public ReadOnly Property StatusText() As String
        Get
            Return sStatus_Text
        End Get
    End Property

    Public Sub New(ByVal sStatusID As String, ByVal sStatusText As String)
        Try
            sStatus_ID = sStatusID
            sStatus_Text = sStatusText
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class
