Imports SUBASHAGENCIES_BLL
Imports System.Text.RegularExpressions

Public Class frmAddBeat
    Dim oBLL As Business_Logic_Layer
    Public Sub New()
        Try
            ' This call is required by the designer.
            InitializeComponent()
            oBLL = New Business_Logic_Layer
            ' Add any initialization after the InitializeComponent() call.
        Catch ex As Exception
            MsgBox(ex.Message, vbOK, Beat + CMS)
        End Try
    End Sub
    Private Sub frmBeat_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            ResetControls()
        Catch ex As Exception
            MsgBox(ex.Message, vbOK, Beat + CMS)
        End Try
    End Sub

    Private Sub btnAddBeat_Click(sender As Object, e As EventArgs) Handles btnAddBeat.Click
        Try
            If (ValidateControls()) Then
                If (oBLL.Add_Beat(txtBeatName.Text.ToString, CInt(txtOutletCount.Text.ToString))) Then
                    MsgBox("Beat Added successfully")
                    ResetControls()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbOK, Beat + CMS)
        End Try
    End Sub

    Private Sub ResetControls()
        Try
            txtBeatName.Text = String.Empty
            txtOutletCount.Text = "0"
        Catch ex As Exception
            MsgBox(ex.Message, vbOK, Beat + CMS)
        End Try
    End Sub

    Private Function ValidateControls() As Boolean
        Try
            If Not (Regex.IsMatch(txtBeatName.Text, "^[A-za-z0-9- ]{1,200}$")) Then
                MsgBox("Beat Name can contain only Alphanumeric and (-) Special Characeter", vbOKCancel, Beat + " -  Collection Management System")
                ValidateControls = False
                Exit Function
            End If
            If (Regex.IsMatch(txtOutletCount.Text, "^[0-9]{1,9}$")) Then
            Else
                MsgBox("Outlet Count can contain only numbers", vbOKCancel, Beat + " -  Collection Management System")
                ValidateControls = False
                Exit Function
            End If
            ValidateControls = True
        Catch ex As Exception
            MsgBox(ex.Message, vbOK, Beat + CMS)
            ValidateControls = False
        End Try
    End Function

End Class