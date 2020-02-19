Imports MetroFramework
Imports System.Data.OleDb

Module Functions

    '=================================================For Validation===============================================================
    Public Sub checklabels()
        Dim _label
        For Each _label In _1_10.Controls
            If TypeOf _label Is Label Then
                If _label.Text = "" Then
                    MetroMessageBox.Show(_1_10, vbCrLf & "Check your answers between 1-10!" & vbCrLf & vbCrLf & vbCrLf & "©(PGLU-HRMD Series of 2018)", "Road Safety Program (Drivers Exam)", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
                    Exit For
                End If
            End If
        Next

        For Each _label In _11_20.Controls
            If TypeOf _label Is Label Then
                If _label.Text = "" Then
                    MetroMessageBox.Show(_11_20, vbCrLf & "Check your answers between 11-20!" & vbCrLf & vbCrLf & vbCrLf & "©(PGLU-HRMD Series of 2018)", "Road Safety Program (Drivers Exam)", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
                    Exit For
                End If
            End If
        Next
        For Each _label In _21_30.Controls
            If TypeOf _label Is Label Then
                If _label.Text = "" Then
                    MetroMessageBox.Show(_21_30, vbCrLf & "Check your answers between 21-30!" & vbCrLf & vbCrLf & vbCrLf & "©(PGLU-HRMD Series of 2018)", "Road Safety Program (Drivers Exam)", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
                    Exit For
                End If
            End If
        Next
        For Each _label In _31_40.Controls
            If TypeOf _label Is Label Then
                If _label.Text = "" Then
                    MetroMessageBox.Show(_31_40, vbCrLf & "Check your answers between 31-40!" & vbCrLf & vbCrLf & vbCrLf & "©(PGLU-HRMD Series of 2018)", "Road Safety Program (Drivers Exam)", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
                    Exit For
                End If
            End If
        Next
        For Each _label In _41_50.Controls
            If TypeOf _label Is Label Then
                If _label.Text = "" Then
                    MetroMessageBox.Show(_41_50, vbCrLf & "Check your answers between 41-50!" & vbCrLf & vbCrLf & vbCrLf & "©(PGLU-HRMD Series of 2018)", "Road Safety Program (Drivers Exam)", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
                    Exit For
                End If
            End If
        Next
        For Each _label In _51_60.Controls
            If TypeOf _label Is Label Then
                If _label.Text = "" Then
                    MetroMessageBox.Show(_51_60, vbCrLf & "Check your answers between 51-60!" & vbCrLf & vbCrLf & vbCrLf & "©(PGLU-HRMD Series of 2018)", "Road Safety Program (Drivers Exam)", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
                    Exit For
                End If
            End If
        Next
        validateans()
        saveanswers()
        _51_60.Hide()
        Userfrm.Show()
    End Sub

    '============================================================Saving data===============================================================
    Public Sub saveanswers()

        Try
            driverexamcon = New OleDbConnection(_driverexam)
            Dim InsertQuery As String
            If driverexamcon.State = ConnectionState.Open Then
                driverexamcon.Close()
            Else
                driverexamcon.Open()
                'InsertQuery = ("insert into employee (idnumber, fullname, gender, birthdate, address, [position], office, app_status, emp_status) values (@t1, @t2, @t3, @t1, @t4, @t5, @t6, @t7, @t8, @t9")
                InsertQuery = ("insert into app_answers (totalscore, totalrating, applicantname,  ans1, ans2, ans3, ans4, ans5, ans6, ans7, ans8, ans9, ans10, ans11, ans12, ans13, ans14, ans15, ans16, ans17, ans18, ans19, ans20, ans21, ans22, ans23, ans24, ans25, ans26, ans27, ans28, ans29, ans30, ans31, ans32, ans33, ans34, ans35, ans36, ans37, ans38, ans39, ans40, ans41, ans42, ans43, ans44, ans45, ans46, ans47, ans48, ans49, ans50, ans51, ans52, ans53, ans54, ans55, ans56, ans57, ans58, ans59, ans60) values (@t61, @t62, @t0, @t1, @t2, @t3, @t4, @t5, @t6, @t7, @t8, @t9, @t10, @t11, @t12, @t13, @t14, @t15, @t16, @t17, @t18, @t19, @t20, @t21, @t22, @t23, @t24, @t25, @t26, @t27, @t28, @t29, @t30, @t31, @t32, @t33, @t34, @t35, @t36, @t37, @t38, @t39, @t40, @t41, @t42, @t43, @t44, @t45, @t46, @t47, @t48, @t49, @t50, @t51, @t52, @t53, @t54, @t55, @t56, @t57, @t58, @t59, @t60)")
                Dim cmd As OleDbCommand = New OleDbCommand(InsertQuery, driverexamcon)
                cmd.Parameters.Add(New OleDbParameter("@t61", OleDbType.VarChar, 100, "totalscore"))
                cmd.Parameters.Add(New OleDbParameter("@t62", OleDbType.VarChar, 100, "totalrating"))
                cmd.Parameters.Add(New OleDbParameter("@t0", OleDbType.VarChar, 100, "applicantname"))
                cmd.Parameters.Add(New OleDbParameter("@t1", OleDbType.VarChar, 1, "ans1"))
                cmd.Parameters.Add(New OleDbParameter("@t2", OleDbType.VarChar, 1, "ans2"))
                cmd.Parameters.Add(New OleDbParameter("@t3", OleDbType.VarChar, 1, "ans3"))
                cmd.Parameters.Add(New OleDbParameter("@t4", OleDbType.VarChar, 1, "ans4"))
                cmd.Parameters.Add(New OleDbParameter("@t5", OleDbType.VarChar, 1, "ans5"))
                cmd.Parameters.Add(New OleDbParameter("@t6", OleDbType.VarChar, 1, "ans6"))
                cmd.Parameters.Add(New OleDbParameter("@t7", OleDbType.VarChar, 1, "ans7"))
                cmd.Parameters.Add(New OleDbParameter("@t8", OleDbType.VarChar, 1, "ans8"))
                cmd.Parameters.Add(New OleDbParameter("@t9", OleDbType.VarChar, 1, "ans9"))
                cmd.Parameters.Add(New OleDbParameter("@t10", OleDbType.VarChar, 1, "ans10"))
                cmd.Parameters.Add(New OleDbParameter("@t11", OleDbType.VarChar, 1, "ans11"))
                cmd.Parameters.Add(New OleDbParameter("@t12", OleDbType.VarChar, 1, "ans12"))
                cmd.Parameters.Add(New OleDbParameter("@t13", OleDbType.VarChar, 1, "ans13"))
                cmd.Parameters.Add(New OleDbParameter("@t14", OleDbType.VarChar, 1, "ans14"))
                cmd.Parameters.Add(New OleDbParameter("@t15", OleDbType.VarChar, 1, "ans15"))
                cmd.Parameters.Add(New OleDbParameter("@t16", OleDbType.VarChar, 1, "ans16"))
                cmd.Parameters.Add(New OleDbParameter("@t17", OleDbType.VarChar, 1, "ans17"))
                cmd.Parameters.Add(New OleDbParameter("@t18", OleDbType.VarChar, 1, "ans18"))
                cmd.Parameters.Add(New OleDbParameter("@t19", OleDbType.VarChar, 1, "ans19"))
                cmd.Parameters.Add(New OleDbParameter("@t20", OleDbType.VarChar, 1, "ans20"))
                cmd.Parameters.Add(New OleDbParameter("@t21", OleDbType.VarChar, 1, "ans21"))
                cmd.Parameters.Add(New OleDbParameter("@t22", OleDbType.VarChar, 1, "ans22"))
                cmd.Parameters.Add(New OleDbParameter("@t23", OleDbType.VarChar, 1, "ans23"))
                cmd.Parameters.Add(New OleDbParameter("@t24", OleDbType.VarChar, 1, "ans24"))
                cmd.Parameters.Add(New OleDbParameter("@t25", OleDbType.VarChar, 1, "ans25"))
                cmd.Parameters.Add(New OleDbParameter("@t26", OleDbType.VarChar, 1, "ans26"))
                cmd.Parameters.Add(New OleDbParameter("@t27", OleDbType.VarChar, 1, "ans27"))
                cmd.Parameters.Add(New OleDbParameter("@t28", OleDbType.VarChar, 1, "ans28"))
                cmd.Parameters.Add(New OleDbParameter("@t29", OleDbType.VarChar, 1, "ans29"))
                cmd.Parameters.Add(New OleDbParameter("@t30", OleDbType.VarChar, 1, "ans30"))
                cmd.Parameters.Add(New OleDbParameter("@t31", OleDbType.VarChar, 1, "ans31"))
                cmd.Parameters.Add(New OleDbParameter("@t32", OleDbType.VarChar, 1, "ans32"))
                cmd.Parameters.Add(New OleDbParameter("@t33", OleDbType.VarChar, 1, "ans33"))
                cmd.Parameters.Add(New OleDbParameter("@t34", OleDbType.VarChar, 1, "ans34"))
                cmd.Parameters.Add(New OleDbParameter("@t35", OleDbType.VarChar, 1, "ans35"))
                cmd.Parameters.Add(New OleDbParameter("@t36", OleDbType.VarChar, 1, "ans36"))
                cmd.Parameters.Add(New OleDbParameter("@t37", OleDbType.VarChar, 1, "ans37"))
                cmd.Parameters.Add(New OleDbParameter("@t38", OleDbType.VarChar, 1, "ans38"))
                cmd.Parameters.Add(New OleDbParameter("@t39", OleDbType.VarChar, 1, "ans39"))
                cmd.Parameters.Add(New OleDbParameter("@t40", OleDbType.VarChar, 1, "ans40"))
                cmd.Parameters.Add(New OleDbParameter("@t41", OleDbType.VarChar, 1, "ans41"))
                cmd.Parameters.Add(New OleDbParameter("@t42", OleDbType.VarChar, 1, "ans42"))
                cmd.Parameters.Add(New OleDbParameter("@t43", OleDbType.VarChar, 1, "ans43"))
                cmd.Parameters.Add(New OleDbParameter("@t44", OleDbType.VarChar, 1, "ans44"))
                cmd.Parameters.Add(New OleDbParameter("@t45", OleDbType.VarChar, 1, "ans45"))
                cmd.Parameters.Add(New OleDbParameter("@t46", OleDbType.VarChar, 1, "ans46"))
                cmd.Parameters.Add(New OleDbParameter("@t47", OleDbType.VarChar, 1, "ans47"))
                cmd.Parameters.Add(New OleDbParameter("@t48", OleDbType.VarChar, 1, "ans48"))
                cmd.Parameters.Add(New OleDbParameter("@t49", OleDbType.VarChar, 1, "ans49"))
                cmd.Parameters.Add(New OleDbParameter("@t50", OleDbType.VarChar, 1, "ans50"))
                cmd.Parameters.Add(New OleDbParameter("@t51", OleDbType.VarChar, 1, "ans51"))
                cmd.Parameters.Add(New OleDbParameter("@t52", OleDbType.VarChar, 1, "ans52"))
                cmd.Parameters.Add(New OleDbParameter("@t53", OleDbType.VarChar, 1, "ans53"))
                cmd.Parameters.Add(New OleDbParameter("@t54", OleDbType.VarChar, 1, "ans54"))
                cmd.Parameters.Add(New OleDbParameter("@t55", OleDbType.VarChar, 1, "ans55"))
                cmd.Parameters.Add(New OleDbParameter("@t56", OleDbType.VarChar, 1, "ans56"))
                cmd.Parameters.Add(New OleDbParameter("@t57", OleDbType.VarChar, 1, "ans57"))
                cmd.Parameters.Add(New OleDbParameter("@t58", OleDbType.VarChar, 1, "ans58"))
                cmd.Parameters.Add(New OleDbParameter("@t59", OleDbType.VarChar, 1, "ans59"))
                cmd.Parameters.Add(New OleDbParameter("@t60", OleDbType.VarChar, 1, "ans60"))



                '-------1-10------------
                cmd.Parameters("@t61").Value = _51_60.totalscore.Text.Trim
                cmd.Parameters("@t62").Value = _51_60.totalrating.Text.Trim

                cmd.Parameters("@t0").Value = _51_60.applicantname.Text.Trim
                cmd.Parameters("@t1").Value = _1_10.Label11.Text.Trim
                cmd.Parameters("@t1").Value = _1_10.Label11.Text.Trim
                cmd.Parameters("@t2").Value = _1_10.Label12.Text.Trim
                cmd.Parameters("@t3").Value = _1_10.Label13.Text.Trim
                cmd.Parameters("@t4").Value = _1_10.Label14.Text.Trim
                cmd.Parameters("@t5").Value = _1_10.Label15.Text.Trim
                cmd.Parameters("@t6").Value = _1_10.Label16.Text.Trim
                cmd.Parameters("@t7").Value = _1_10.Label17.Text.Trim
                cmd.Parameters("@t8").Value = _1_10.Label18.Text.Trim
                cmd.Parameters("@t9").Value = _1_10.Label19.Text.Trim
                cmd.Parameters("@t10").Value = _1_10.Label20.Text.Trim

                '-------11-20------------
                cmd.Parameters("@t11").Value = _11_20.Label11.Text.Trim
                cmd.Parameters("@t12").Value = _11_20.Label12.Text.Trim
                cmd.Parameters("@t13").Value = _11_20.Label13.Text.Trim
                cmd.Parameters("@t14").Value = _11_20.Label14.Text.Trim
                cmd.Parameters("@t15").Value = _11_20.Label15.Text.Trim
                cmd.Parameters("@t16").Value = _11_20.Label16.Text.Trim
                cmd.Parameters("@t17").Value = _11_20.Label17.Text.Trim
                cmd.Parameters("@t18").Value = _11_20.Label18.Text.Trim
                cmd.Parameters("@t19").Value = _11_20.Label19.Text.Trim
                cmd.Parameters("@t20").Value = _11_20.Label20.Text.Trim

                '-------21-30------------
                cmd.Parameters("@t21").Value = _21_30.Label11.Text.Trim
                cmd.Parameters("@t22").Value = _21_30.Label12.Text.Trim
                cmd.Parameters("@t23").Value = _21_30.Label13.Text.Trim
                cmd.Parameters("@t24").Value = _21_30.Label14.Text.Trim
                cmd.Parameters("@t25").Value = _21_30.Label15.Text.Trim
                cmd.Parameters("@t26").Value = _21_30.Label16.Text.Trim
                cmd.Parameters("@t27").Value = _21_30.Label17.Text.Trim
                cmd.Parameters("@t28").Value = _21_30.Label18.Text.Trim
                cmd.Parameters("@t29").Value = _21_30.Label19.Text.Trim
                cmd.Parameters("@t30").Value = _21_30.Label20.Text.Trim

                '-------31-40------------
                cmd.Parameters("@t31").Value = _31_40.Label11.Text.Trim
                cmd.Parameters("@t32").Value = _31_40.Label12.Text.Trim
                cmd.Parameters("@t33").Value = _31_40.Label13.Text.Trim
                cmd.Parameters("@t34").Value = _31_40.Label14.Text.Trim
                cmd.Parameters("@t35").Value = _31_40.Label15.Text.Trim
                cmd.Parameters("@t36").Value = _31_40.Label16.Text.Trim
                cmd.Parameters("@t37").Value = _31_40.Label17.Text.Trim
                cmd.Parameters("@t38").Value = _31_40.Label18.Text.Trim
                cmd.Parameters("@t39").Value = _31_40.Label19.Text.Trim
                cmd.Parameters("@t40").Value = _31_40.Label20.Text.Trim

                '-------41-50------------
                cmd.Parameters("@t41").Value = _41_50.Label11.Text.Trim
                cmd.Parameters("@t42").Value = _41_50.Label12.Text.Trim
                cmd.Parameters("@t43").Value = _41_50.Label13.Text.Trim
                cmd.Parameters("@t44").Value = _41_50.Label14.Text.Trim
                cmd.Parameters("@t45").Value = _41_50.Label15.Text.Trim
                cmd.Parameters("@t46").Value = _41_50.Label16.Text.Trim
                cmd.Parameters("@t47").Value = _41_50.Label17.Text.Trim
                cmd.Parameters("@t48").Value = _41_50.Label18.Text.Trim
                cmd.Parameters("@t49").Value = _41_50.Label19.Text.Trim
                cmd.Parameters("@t50").Value = _41_50.Label20.Text.Trim

                '-------51-60------------
                cmd.Parameters("@t51").Value = _51_60.Label11.Text.Trim
                cmd.Parameters("@t52").Value = _51_60.Label12.Text.Trim
                cmd.Parameters("@t53").Value = _51_60.Label13.Text.Trim
                cmd.Parameters("@t54").Value = _51_60.Label14.Text.Trim
                cmd.Parameters("@t55").Value = _51_60.Label15.Text.Trim
                cmd.Parameters("@t56").Value = _51_60.Label16.Text.Trim
                cmd.Parameters("@t57").Value = _51_60.Label17.Text.Trim
                cmd.Parameters("@t58").Value = _51_60.Label18.Text.Trim
                cmd.Parameters("@t59").Value = _51_60.Label19.Text.Trim
                cmd.Parameters("@t60").Value = _51_60.Label20.Text.Trim

                cmd.ExecuteReader()
                MetroMessageBox.Show(_51_60, vbCrLf & "Record Saved." & vbCrLf & vbCrLf & vbCrLf & "©(PGLU-HRMD Series of 2018)", "Road Safety Program (Drivers Exam)", MessageBoxButtons.OK, MessageBoxIcon.Question)

            End If
            driverexamcon.Close()
        Catch ex As Exception
            MetroMessageBox.Show(_51_60, vbCrLf & ex.Message & vbCrLf & vbCrLf & vbCrLf & "©(PGLU-HRMD Series of 2018)", "Road Safety Program (Drivers Exam)", MessageBoxButtons.OK, MessageBoxIcon.Error)
            'MsgBox(ex.Message)
        End Try
    End Sub

    Sub validateans()
        Try
            Dim _Counter As Integer
            _Counter = 0
            '=====1-10========
            If _1_10.rbtn1a.Checked = True Then _Counter += 1
            If _1_10.rbtn2b.Checked = True Then _Counter += 1
            If _1_10.rbtn3a.Checked = True Then _Counter += 1
            If _1_10.rbtn4a.Checked = True Then _Counter += 1
            If _1_10.rbtn5a.Checked = True Then _Counter += 1
            If _1_10.rbtn6c.Checked = True Then _Counter += 1
            If _1_10.rbtn7b.Checked = True Then _Counter += 1
            If _1_10.rbtn8c.Checked = True Then _Counter += 1
            If _1_10.rbtn9a.Checked = True Then _Counter += 1
            If _1_10.rbtn10a.Checked = True Then _Counter += 1

            '=====11-20========
            If _11_20.rbtn1b.Checked = True Then _Counter += 1
            If _11_20.rbtn2c.Checked = True Then _Counter += 1
            If _11_20.rbtn3c.Checked = True Then _Counter += 1
            If _11_20.rbtn4a.Checked = True Then _Counter += 1
            If _11_20.rbtn5c.Checked = True Then _Counter += 1
            If _11_20.rbtn6a.Checked = True Then _Counter += 1
            If _11_20.rbtn7b.Checked = True Then _Counter += 1
            If _11_20.rbtn8a.Checked = True Then _Counter += 1
            If _11_20.rbtn9b.Checked = True Then _Counter += 1
            If _11_20.rbtn10a.Checked = True Then _Counter += 1

            '=====21-30========
            If _21_30.rbtn1a.Checked = True Then _Counter += 1
            If _21_30.rbtn2a.Checked = True Then _Counter += 1
            If _21_30.rbtn3a.Checked = True Then _Counter += 1
            If _21_30.rbtn4a.Checked = True Then _Counter += 1
            If _21_30.rbtn5a.Checked = True Then _Counter += 1
            If _21_30.rbtn6a.Checked = True Then _Counter += 1
            If _21_30.rbtn7c.Checked = True Then _Counter += 1
            If _21_30.rbtn8a.Checked = True Then _Counter += 1
            If _21_30.rbtn9b.Checked = True Then _Counter += 1
            If _21_30.rbtn10c.Checked = True Then _Counter += 1

            '=====31-40========
            If _31_40.rbtn1c.Checked = True Then _Counter += 1
            If _31_40.rbtn2b.Checked = True Then _Counter += 1
            If _31_40.rbtn3a.Checked = True Then _Counter += 1
            If _31_40.rbtn4a.Checked = True Then _Counter += 1
            If _31_40.rbtn5b.Checked = True Then _Counter += 1
            If _31_40.rbtn6a.Checked = True Then _Counter += 1
            If _31_40.rbtn7d.Checked = True Then _Counter += 1
            If _31_40.rbtn8a.Checked = True Then _Counter += 1
            If _31_40.rbtn9b.Checked = True Then _Counter += 1
            If _31_40.rbtn10a.Checked = True Then _Counter += 1

            '=====41-50========
            If _41_50.rbtn1c.Checked = True Then _Counter += 1
            If _41_50.rbtn2c.Checked = True Then _Counter += 1
            If _41_50.rbtn3a.Checked = True Then _Counter += 1
            If _41_50.rbtn4c.Checked = True Then _Counter += 1
            If _41_50.rbtn5a.Checked = True Then _Counter += 1
            If _41_50.rbtn6c.Checked = True Then _Counter += 1
            If _41_50.rbtn7a.Checked = True Then _Counter += 1
            If _41_50.rbtn8a.Checked = True Then _Counter += 1
            If _41_50.rbtn9a.Checked = True Then _Counter += 1
            If _41_50.rbtn10b.Checked = True Then _Counter += 1

            '=====51-60========
            If _51_60.rbtn1a.Checked = True Then _Counter += 1
            If _51_60.rbtn2c.Checked = True Then _Counter += 1
            If _51_60.rbtn3b.Checked = True Then _Counter += 1
            If _51_60.rbtn4a.Checked = True Then _Counter += 1
            If _51_60.rbtn5b.Checked = True Then _Counter += 1
            If _51_60.rbtn6c.Checked = True Then _Counter += 1
            If _51_60.rbtn7c.Checked = True Then _Counter += 1
            If _51_60.rbtn8c.Checked = True Then _Counter += 1
            If _51_60.rbtn9c.Checked = True Then _Counter += 1
            If _51_60.rbtn10c.Checked = True Then _Counter += 1

            _51_60.totalscore.Text = _Counter
            Dim _score As Integer
            Dim _total As Double
            _score = _51_60.totalscore.Text
            _total = (_score / 60) * 100
            If _Counter <= 39 Then
                _51_60.totalrating.Text = "Failed!"
            ElseIf _Counter >= 40 Then
                _51_60.totalrating.Text = "Passed!"
            End If

        Catch ex As Exception
        End Try
    End Sub

End Module
