Imports MetroFramework
Imports System.Data.OleDb
Public Class Userfrm

    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles MetroButton1.Click
        Dim _privilege As String = MetroComboBox1.Text.Trim
        If _privilege = "Applicant" Then
            Me.Hide()
            Mainfrm.Show()
            Mainfrm.LinkLabel1.Enabled = True
            Mainfrm.BunifuFlatButton1.Enabled = False
            Mainfrm.Label2.Text = "Name of Examinee"

        End If
        If _privilege = "Administrator" Then
            Dim _pwd As String = MetroTextBox1.Text.Trim
            Dim _constpwd = "pgluhrext"
            If _pwd = _constpwd Then
                Me.Hide()
                Result.Show()
            Else
                MetroMessageBox.Show(Me, vbCrLf & "Password is Invalid!" & vbCrLf & vbCrLf & vbCrLf & "©(PGLU-HRMD Series of 2018)", "Road Safety Program (Drivers Exam)", MessageBoxButtons.OK, MessageBoxIcon.Error)
                'MsgBox(ex.Message)
            End If
        End If
        MetroComboBox1.SelectedIndex = -1
        MetroTextBox1.Visible = False
        MetroTextBox1.Clear()

    End Sub

    Private Sub MetroComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles MetroComboBox1.SelectedIndexChanged
        If MetroComboBox1.SelectedIndex = 0 Then
            MetroTextBox1.Visible = True
        ElseIf MetroComboBox1.SelectedIndex = 1 Then
            MetroTextBox1.Visible = False
        End If
    End Sub

    Private Sub Userfrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim NAM As Integer = 0
    End Sub
End Class