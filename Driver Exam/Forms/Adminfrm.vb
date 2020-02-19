Imports System.Data.OleDb
Public Class Adminfrm
    Private Sub Adminfrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Showrecord()
        Cursor.Current = Cursors.Default
    End Sub

    Private Sub BunifuFlatButton2_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton2.Click
        'Cursor.Current = Cursors.WaitCursor
        Result.Show()
    End Sub

    Private Sub BunifuImageButton1_Click(sender As Object, e As EventArgs) Handles BunifuImageButton1.Click
        Me.Close()
        Userfrm.Show()
    End Sub

    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton1.Click

    End Sub
    Public Sub Showrecord()
        Try
            Dim dba As New OleDbDataAdapter("SELECT applicantname, totalscore FROM app_answers order by applicantname asc", _driverexam)
            Dim dbset As New DataSet
            dba.Fill(dbset)
            Me.MetroGrid1.DataSource = dbset.Tables(0).DefaultView

            'Label20.Text = DataGridView1.Rows.Count
            bcltotal.Text = CType(MetroGrid1.Rows.Count, String)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
End Class