Imports MetroFramework
Public Class Start_Page
    Private Sub Start_Page_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Try
            MetroMessageBox.Show(Me, vbCrLf & "Coded by :" & vbCrLf & vbCrLf & "Jerald G. Sanchez" & vbCrLf & "(PGLU-HRMD Series of 2017)", "Driver's Exam System", MessageBoxButtons.OK, MessageBoxIcon.Question)
        Catch ex As Exception
        End Try

    End Sub

    Private Sub MetroButton1_Click(sender As Object, e As EventArgs)
        Try
            Me.Hide()
            Page110.Show()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub MetroButton2_Click(sender As Object, e As EventArgs) Handles MetroButton2.Click
        Me.Hide()
        Page110.Show()
    End Sub
End Class