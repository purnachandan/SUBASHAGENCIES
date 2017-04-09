
Public Class BEAT
    Private sBeat_ID As String
    Public ReadOnly Property BeatID() As String
        Get
            Return sBeat_ID
        End Get
    End Property

    Private sBeat_Name As String
    Public ReadOnly Property BeatName() As String
        Get
            Return sBeat_Name
        End Get
    End Property

    Public Sub New(ByVal sBeatID As String, ByVal sBeatName As String)
        Try
            sBeat_ID = sBeatID
            sBeat_Name = sBeatName
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class
