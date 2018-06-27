Imports System.Data.OleDb
Imports MetroFramework
Public Class Register
    Private Sub BunifuCustomLabel1_Click(sender As Object, e As EventArgs) Handles BunifuCustomLabel1.Click, BunifuCustomLabel3.Click, BunifuCustomLabel2.Click

    End Sub


    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles MetroButton1.Click
        Try
            Dim _lastname As String = MaterialSingleLineTextField1.Text.Trim()
            Dim _firstname As String = MaterialSingleLineTextField2.Text.Trim()
            Dim _mi As String = MaterialSingleLineTextField3.Text.Trim()
            Dim _age As String = MetroDateTime1.Text.Trim()
            Dim _address As String = MaterialSingleLineTextField5.Text.Trim()

            If _lastname = Nothing Or _firstname = Nothing Or _mi = Nothing Or _age = Nothing Or _address = Nothing Then
                MetroMessageBox.Show(Me, vbCrLf & "Information!" & vbCrLf & "Do not leave empty boxes unattended." & vbCrLf & vbCrLf & vbCrLf & "(PGLU-HRMD Series of 2018)", "Driver's Exam System", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                driverexamcon = New OleDbConnection(_driverexam)
                Dim InsertQuery As String
                If driverexamcon.State = ConnectionState.Open Then
                    driverexamcon.Close()
                Else
                    driverexamcon.Open()
                    'InsertQuery = ("insert into employee (idnumber, fullname, gender, birthdate, address, [position], office, app_status, emp_status) values (@t1, @t2, @t3, @t1, @t4, @t5, @t6, @t7, @t8, @t9")
                    InsertQuery = ("insert into applicant (lastname, firstname, mi, birthdate, address, regdate, regtime) values (@t1, @t2, @t3, @t4, @t5, @t6, @t7)")
                    Dim cmd As OleDbCommand = New OleDbCommand(InsertQuery, driverexamcon)
                    cmd.Parameters.Add(New OleDbParameter("@t1", OleDbType.VarChar, 50, "lastname"))
                    cmd.Parameters.Add(New OleDbParameter("@t2", OleDbType.VarChar, 100, "firstname"))
                    cmd.Parameters.Add(New OleDbParameter("@t3", OleDbType.VarChar, 10, "mi"))
                    cmd.Parameters.Add(New OleDbParameter("@t4", OleDbType.VarChar, 50, "birthdate"))
                    cmd.Parameters.Add(New OleDbParameter("@t5", OleDbType.VarChar, 100, "address"))
                    cmd.Parameters.Add(New OleDbParameter("@t6", OleDbType.VarChar, 50, "regdate"))
                    cmd.Parameters.Add(New OleDbParameter("@t7", OleDbType.VarChar, 50, "regtime"))


                    cmd.Parameters("@t1").Value = MaterialSingleLineTextField1.Text.ToUpper
                    cmd.Parameters("@t2").Value = MaterialSingleLineTextField2.Text.ToUpper
                    cmd.Parameters("@t3").Value = MaterialSingleLineTextField3.Text.ToUpper
                    cmd.Parameters("@t4").Value = MetroDateTime1.Text.ToUpper
                    cmd.Parameters("@t5").Value = MaterialSingleLineTextField5.Text.ToUpper
                    cmd.Parameters("@t5").Value = MaterialSingleLineTextField5.Text.ToUpper
                    cmd.Parameters("@t6").Value = Today.ToShortDateString
                    cmd.Parameters("@t7").Value = TimeOfDay.ToShortTimeString

                    cmd.ExecuteReader()
                    MetroMessageBox.Show(Me, vbCrLf & "Record Saved." & vbCrLf & vbCrLf & vbCrLf & "©(PGLU-HRMD Series of 2017)", "Driver's Exam System", MessageBoxButtons.OK, MessageBoxIcon.Question)
                    Me.Close()
                    Mainfrm.Show()
                    Mainfrm.Label4.Visible = False
                    Mainfrm.BunifuFlatButton1.Enabled = True
                    Mainfrm.PictureBox1.Visible = False
                    Mainfrm.LinkLabel1.Enabled = False

                    Dim _applicant As String = _lastname.ToUpper + ", " + _firstname.ToUpper + " " + _mi.ToUpper
                    Mainfrm.Label2.Text = _applicant
                    Start_Page.MetroLabel11.Text = _applicant
                    Page110.applicantname.Text = _applicant
                    _11_20.applicantname.Text = _applicant
                    _21_30.applicantname.Text = _applicant
                    _31_40.applicantname.Text = _applicant
                    _41_50.applicantname.Text = _applicant
                    _51_60.applicantname.Text = _applicant

                End If
                driverexamcon.Close()
            End If
        Catch ex As Exception
            '----------Default Messagebox--------------------------------------------
            MetroMessageBox.Show(Me, vbCrLf & "Error inserting record!" & vbCrLf & vbCrLf & vbCrLf & "©(PGLU-HRMD Series of 2017)", "Driver's Exam System", MessageBoxButtons.OK, MessageBoxIcon.Error)
            'MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub registerapplicant()

    End Sub

    Private Sub Register_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Mainfrm.Show()
    End Sub
End Class