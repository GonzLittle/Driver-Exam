Imports System.ComponentModel

Public Class Mainfrm


    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton1.Click
        Me.Hide()
        Start_Page.Show()
        'Dim _applicant As String = Label2.Text.Trim
        'Start_Page.MetroLabel1.Text = _applicant

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Me.Hide()
        Register.Show()
    End Sub

    Private Sub Mainfrm_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Userfrm.Show()
    End Sub
End Class
