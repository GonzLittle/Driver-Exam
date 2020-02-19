Imports MetroFramework
Imports System.Data.OleDb
Public Class _1_10
    Private Sub Test_Page_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'MetroTextBox1.Text = 1
        'gb1.BringToFront()
        'gb1.Dock = DockStyle.Fill
    End Sub
    Private Sub BunifuImageButton2_Click(sender As Object, e As EventArgs) Handles BunifuImageButton2.Click
        '------------------------next button----------------------------
        Dim _number As Integer = MetroTextBox1.Text
        If _number >= 10 Then
            Me.Hide()
            _11_20.Show()
            _11_20.MetroTextBox1.Text = 11
        Else
            _number = _number + 1
            Select Case _number
                Case 1
                    gb1.Dock = DockStyle.Fill
                    gb1.BringToFront()
                Case 2
                    gb2.Dock = DockStyle.Fill
                    gb2.BringToFront()
                Case 3
                    gb3.Dock = DockStyle.Fill
                    gb3.BringToFront()
                Case 4
                    gb4.Dock = DockStyle.Fill
                    gb4.BringToFront()
                Case 5
                    gb5.Dock = DockStyle.Fill
                    gb5.BringToFront()
                Case 6
                    gb6.Dock = DockStyle.Fill
                    gb6.BringToFront()
                Case 7
                    gb7.Dock = DockStyle.Fill
                    gb7.BringToFront()
                Case 8
                    gb8.Dock = DockStyle.Fill
                    gb8.BringToFront()
                Case 9
                    gb9.Dock = DockStyle.Fill
                    gb9.BringToFront()
                Case 10
                    gb10.Dock = DockStyle.Fill
                    gb10.BringToFront()
            End Select
            MetroTextBox1.Text = _number
        End If
    End Sub

    Private Sub BunifuImageButton1_Click(sender As Object, e As EventArgs) Handles BunifuImageButton1.Click

        '---------------------------Previous button-------------------

        Dim _number As Integer = MetroTextBox1.Text
        If _number <= 1 Then
            MetroMessageBox.Show(Me, vbCrLf & "First Record Reached!" & vbCrLf & vbCrLf & vbCrLf & "©(PGLU-HRMD Series of 2018)", "Road Safety Program (Drivers Exam)", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            _number = _number - 1
            MetroTextBox1.Text = _number
            Select Case _number
                Case 1
                    gb1.BringToFront()
                    gb1.Dock = DockStyle.Fill

                Case 2
                    gb2.BringToFront()
                    gb2.Dock = DockStyle.Fill
                Case 3
                    gb3.BringToFront()
                    gb3.Dock = DockStyle.Fill
                Case 4
                    gb4.BringToFront()
                    gb4.Dock = DockStyle.Fill
                Case 5
                    gb5.BringToFront()
                    gb5.Dock = DockStyle.Fill
                Case 6
                    gb6.BringToFront()
                    gb6.Dock = DockStyle.Fill
                Case 7
                    gb7.BringToFront()
                    gb7.Dock = DockStyle.Fill
                Case 8
                    gb8.BringToFront()
                    gb8.Dock = DockStyle.Fill
                Case 9
                    gb9.BringToFront()
                    gb9.Dock = DockStyle.Fill
                Case 10
                    gb10.BringToFront()
                    gb10.Dock = DockStyle.Fill
            End Select
        End If
    End Sub
    '==============================================Radio Buttons Ticked========================================
#Region "Radiobuttons"
    '--------gb1------
    Private Sub rbtn1a_CheckedChanged(sender As Object, e As EventArgs) Handles rbtn1a.CheckedChanged
        If rbtn1a.Checked = True Then
            Label11.Text = "A"
        End If
    End Sub
    Private Sub rbtn1b_CheckedChanged(sender As Object, e As EventArgs) Handles rbtn1b.CheckedChanged
        If rbtn1b.Checked = True Then
            Label11.Text = "B"
        End If
    End Sub
    Private Sub rbtn1c_CheckedChanged(sender As Object, e As EventArgs) Handles rbtn1c.CheckedChanged
        If rbtn1c.Checked = True Then
            Label11.Text = "C"
        End If
    End Sub
    '--------gb2------
    Private Sub rbtn2a_CheckedChanged(sender As Object, e As EventArgs) Handles rbtn2a.CheckedChanged
        If rbtn2a.Checked = True Then
            Label12.Text = "A"
        End If
    End Sub
    Private Sub rbtn2b_CheckedChanged(sender As Object, e As EventArgs) Handles rbtn2b.CheckedChanged
        If rbtn2b.Checked = True Then
            Label12.Text = "B"
        End If
    End Sub
    Private Sub rbtn2c_CheckedChanged(sender As Object, e As EventArgs) Handles rbtn2c.CheckedChanged
        If rbtn2c.Checked = True Then
            Label12.Text = "C"
        End If
    End Sub
    '--------gb3------
    Private Sub rbtn3a_CheckedChanged(sender As Object, e As EventArgs) Handles rbtn3a.CheckedChanged
        If rbtn3a.Checked = True Then
            Label13.Text = "A"
        End If
    End Sub
    Private Sub rbtn3b_CheckedChanged(sender As Object, e As EventArgs) Handles rbtn3b.CheckedChanged
        If rbtn3b.Checked = True Then
            Label13.Text = "B"
        End If
    End Sub
    Private Sub rbtn3c_CheckedChanged(sender As Object, e As EventArgs) Handles rbtn3c.CheckedChanged
        If rbtn3c.Checked = True Then
            Label13.Text = "C"
        End If
    End Sub
    '--------gb4------
    Private Sub rbt4a_CheckedChanged(sender As Object, e As EventArgs) Handles rbtn4a.CheckedChanged
        If rbtn4a.Checked = True Then
            Label14.Text = "A"
        End If
    End Sub
    Private Sub rbtn4b_CheckedChanged(sender As Object, e As EventArgs) Handles rbtn4b.CheckedChanged
        If rbtn4b.Checked = True Then
            Label14.Text = "B"
        End If
    End Sub
    Private Sub rbtn4c_CheckedChanged(sender As Object, e As EventArgs) Handles rbtn4c.CheckedChanged
        If rbtn4c.Checked = True Then
            Label14.Text = "C"
        End If
    End Sub
    '--------gb5------
    Private Sub rbtn5a_CheckedChanged(sender As Object, e As EventArgs) Handles rbtn5a.CheckedChanged
        If rbtn5a.Checked = True Then
            Label15.Text = "A"
        End If
    End Sub
    Private Sub rbtn5b_CheckedChanged(sender As Object, e As EventArgs) Handles rbtn5b.CheckedChanged
        If rbtn5b.Checked = True Then
            Label15.Text = "B"
        End If
    End Sub
    Private Sub rbtn5c_CheckedChanged(sender As Object, e As EventArgs) Handles rbtn5c.CheckedChanged
        If rbtn5c.Checked = True Then
            Label15.Text = "C"
        End If
    End Sub
    '--------gb6------
    Private Sub rbtn6a_CheckedChanged(sender As Object, e As EventArgs) Handles rbtn6a.CheckedChanged
        If rbtn6a.Checked = True Then
            Label16.Text = "A"
        End If
    End Sub
    Private Sub rbtn6b_CheckedChanged(sender As Object, e As EventArgs) Handles rbtn6b.CheckedChanged
        If rbtn6b.Checked = True Then
            Label16.Text = "B"
        End If
    End Sub
    Private Sub rbtn6c_CheckedChanged(sender As Object, e As EventArgs) Handles rbtn6c.CheckedChanged
        If rbtn6c.Checked = True Then
            Label16.Text = "C"
        End If
    End Sub
    '--------gb7------
    Private Sub rbtn7a_CheckedChanged(sender As Object, e As EventArgs) Handles rbtn7a.CheckedChanged
        If rbtn7a.Checked = True Then
            Label17.Text = "A"
        End If
    End Sub
    Private Sub rbtn7b_CheckedChanged(sender As Object, e As EventArgs) Handles rbtn7b.CheckedChanged
        If rbtn7b.Checked = True Then
            Label17.Text = "B"
        End If
    End Sub
    Private Sub rbtn7c_CheckedChanged(sender As Object, e As EventArgs) Handles rbtn7c.CheckedChanged
        If rbtn7c.Checked = True Then
            Label17.Text = "C"
        End If
    End Sub
    '--------gb8------
    Private Sub rbtn8a_CheckedChanged(sender As Object, e As EventArgs) Handles rbtn8a.CheckedChanged
        If rbtn8a.Checked = True Then
            Label18.Text = "A"
        End If
    End Sub
    Private Sub rbtn8b_CheckedChanged(sender As Object, e As EventArgs) Handles rbtn8b.CheckedChanged
        If rbtn8b.Checked = True Then
            Label18.Text = "B"
        End If
    End Sub
    Private Sub rbtn8c_CheckedChanged(sender As Object, e As EventArgs) Handles rbtn8c.CheckedChanged
        If rbtn8c.Checked = True Then
            Label18.Text = "C"
        End If
    End Sub

    '--------gb9------
    Private Sub rbtn9a_CheckedChanged(sender As Object, e As EventArgs) Handles rbtn9a.CheckedChanged
        If rbtn9a.Checked = True Then
            Label19.Text = "A"
        End If
    End Sub
    Private Sub rbtn9b_CheckedChanged(sender As Object, e As EventArgs) Handles rbtn9b.CheckedChanged
        If rbtn9b.Checked = True Then
            Label19.Text = "B"
        End If
    End Sub
    Private Sub rbtn9c_CheckedChanged(sender As Object, e As EventArgs) Handles rbtn9c.CheckedChanged
        If rbtn9c.Checked = True Then
            Label19.Text = "C"
        End If
    End Sub
    '--------gb10------
    Private Sub rbtn10a_CheckedChanged(sender As Object, e As EventArgs) Handles rbtn10a.CheckedChanged
        If rbtn10a.Checked = True Then
            Label20.Text = "A"
        End If
    End Sub
    Private Sub rbtn10b_CheckedChanged(sender As Object, e As EventArgs) Handles rbtn10b.CheckedChanged
        If rbtn10b.Checked = True Then
            Label20.Text = "B"
        End If
    End Sub
    Private Sub rbtn10c_CheckedChanged(sender As Object, e As EventArgs) Handles rbtn10c.CheckedChanged
        If rbtn10c.Checked = True Then
            Label20.Text = "C"
        End If
    End Sub




#End Region
    ''==================================================Navigational Pane first 10====================================================================
    Private Sub MetroTextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles MetroTextBox1.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                Try
                    Dim _number = MetroTextBox1.Text
                    '=======================================1-10==========================================
                    If _number <= 10 And _number > 0 Then
                        Select Case _number
                            Case 1
                                gb1.BringToFront()
                                gb1.Dock = DockStyle.Fill
                            Case 2
                                gb2.BringToFront()
                                gb2.Dock = DockStyle.Fill
                            Case 3
                                gb3.BringToFront()
                                gb3.Dock = DockStyle.Fill
                            Case 4
                                gb4.BringToFront()
                                gb4.Dock = DockStyle.Fill
                            Case 5
                                gb5.BringToFront()
                                gb5.Dock = DockStyle.Fill
                            Case 6
                                gb6.BringToFront()
                                gb6.Dock = DockStyle.Fill
                            Case 7
                                gb7.BringToFront()
                                gb7.Dock = DockStyle.Fill
                            Case 8
                                gb8.BringToFront()
                                gb8.Dock = DockStyle.Fill
                            Case 9
                                gb9.BringToFront()
                                gb9.Dock = DockStyle.Fill
                            Case 10
                                gb10.BringToFront()
                                gb10.Dock = DockStyle.Fill
                        End Select
                        '=============================================11-20========================================================
                    ElseIf _number > 10 And _number <= 20 Then
                        Me.Hide()
                        _11_20.Show()
                        _11_20.MetroTextBox1.Text = _number
                        Select Case _number
                            Case 11
                                _11_20.gb1.BringToFront()
                                _11_20.gb1.Dock = DockStyle.Fill
                            Case 12
                                _11_20.gb2.BringToFront()
                                _11_20.gb2.Dock = DockStyle.Fill
                            Case 13
                                _11_20.gb3.BringToFront()
                                _11_20.gb3.Dock = DockStyle.Fill
                            Case 14
                                _11_20.gb4.BringToFront()
                                _11_20.gb4.Dock = DockStyle.Fill
                            Case 15
                                _11_20.gb5.BringToFront()
                                _11_20.gb5.Dock = DockStyle.Fill
                            Case 16
                                _11_20.gb6.BringToFront()
                                _11_20.gb6.Dock = DockStyle.Fill
                            Case 17
                                _11_20.gb7.BringToFront()
                                _11_20.gb7.Dock = DockStyle.Fill
                            Case 18
                                _11_20.gb8.BringToFront()
                                _11_20.gb8.Dock = DockStyle.Fill
                            Case 19
                                _11_20.gb9.BringToFront()
                                _11_20.gb9.Dock = DockStyle.Fill
                            Case 20
                                _11_20.gb10.BringToFront()
                                _11_20.gb10.Dock = DockStyle.Fill
                        End Select
                        '=================================21-30=========================================================
                    ElseIf _number > 20 And _number <= 30 Then
                        Me.Hide()
                        _21_30.Show()
                        _21_30.MetroTextBox1.Text = _number
                        Select Case _number
                            Case 21
                                _21_30.gb1.BringToFront()
                                _21_30.gb1.Dock = DockStyle.Fill
                            Case 22
                                _21_30.gb2.BringToFront()
                                _21_30.gb2.Dock = DockStyle.Fill
                            Case 23
                                _21_30.gb3.BringToFront()
                                _21_30.gb3.Dock = DockStyle.Fill
                            Case 24
                                _21_30.gb4.BringToFront()
                                _21_30.gb4.Dock = DockStyle.Fill
                            Case 25
                                _21_30.gb5.BringToFront()
                                _21_30.gb5.Dock = DockStyle.Fill
                            Case 26
                                _21_30.gb6.BringToFront()
                                _21_30.gb6.Dock = DockStyle.Fill
                            Case 27
                                _21_30.gb7.BringToFront()
                                _21_30.gb7.Dock = DockStyle.Fill
                            Case 28
                                _21_30.gb8.BringToFront()
                                _21_30.gb8.Dock = DockStyle.Fill
                            Case 29
                                _21_30.gb9.BringToFront()
                                _21_30.gb9.Dock = DockStyle.Fill
                            Case 30
                                _21_30.gb10.BringToFront()
                                _21_30.gb10.Dock = DockStyle.Fill
                        End Select
                        '=================================31-40=========================================================
                    ElseIf _number > 30 And _number <= 40 Then
                        Me.Hide()
                        _31_40.Show()
                        _31_40.MetroTextBox1.Text = _number
                        Select Case _number
                            Case 31
                                _31_40.gb1.BringToFront()
                                _31_40.gb1.Dock = DockStyle.Fill
                            Case 32
                                _31_40.gb2.BringToFront()
                                _31_40.gb2.Dock = DockStyle.Fill
                            Case 33
                                _31_40.gb3.BringToFront()
                                _31_40.gb3.Dock = DockStyle.Fill
                            Case 34
                                _31_40.gb4.BringToFront()
                                _31_40.gb4.Dock = DockStyle.Fill
                            Case 35
                                _31_40.gb5.BringToFront()
                                _31_40.gb5.Dock = DockStyle.Fill
                            Case 36
                                _31_40.gb6.BringToFront()
                                _31_40.gb6.Dock = DockStyle.Fill
                            Case 37
                                _31_40.gb7.BringToFront()
                                _31_40.gb7.Dock = DockStyle.Fill
                            Case 38
                                _31_40.gb8.BringToFront()
                                _31_40.gb8.Dock = DockStyle.Fill
                            Case 39
                                _31_40.gb9.BringToFront()
                                _31_40.gb9.Dock = DockStyle.Fill
                            Case 40
                                _31_40.gb10.BringToFront()
                                _31_40.gb10.Dock = DockStyle.Fill
                        End Select
                        '=================================41-50=========================================================
                    ElseIf _number > 40 And _number <= 50 Then
                        Me.Hide()
                        _41_50.Show()
                        _41_50.MetroTextBox1.Text = _number
                        Select Case _number
                            Case 41
                                _41_50.gb1.BringToFront()
                                _41_50.gb1.Dock = DockStyle.Fill
                            Case 42
                                _41_50.gb2.BringToFront()
                                _41_50.gb2.Dock = DockStyle.Fill
                            Case 43
                                _41_50.gb3.BringToFront()
                                _41_50.gb3.Dock = DockStyle.Fill
                            Case 44
                                _41_50.gb4.BringToFront()
                                _41_50.gb4.Dock = DockStyle.Fill
                            Case 45
                                _41_50.gb5.BringToFront()
                                _41_50.gb5.Dock = DockStyle.Fill
                            Case 46
                                _41_50.gb6.BringToFront()
                                _41_50.gb6.Dock = DockStyle.Fill
                            Case 47
                                _41_50.gb7.BringToFront()
                                _41_50.gb7.Dock = DockStyle.Fill
                            Case 48
                                _41_50.gb8.BringToFront()
                                _41_50.gb8.Dock = DockStyle.Fill
                            Case 49
                                _41_50.gb9.BringToFront()
                                _41_50.gb9.Dock = DockStyle.Fill
                            Case 50
                                _41_50.gb10.BringToFront()
                                _41_50.gb10.Dock = DockStyle.Fill
                        End Select
                        '=================================51-60=========================================================
                    ElseIf _number > 50 And _number <= 60 Then
                        Me.Hide()
                        _51_60.Show()
                        _51_60.MetroTextBox1.Text = _number
                        Select Case _number
                            Case 51
                                _51_60.gb1.BringToFront()
                                _51_60.gb1.Dock = DockStyle.Fill
                            Case 52
                                _51_60.gb2.BringToFront()
                                _51_60.gb2.Dock = DockStyle.Fill
                            Case 53
                                _51_60.gb3.BringToFront()
                                _51_60.gb3.Dock = DockStyle.Fill
                            Case 54
                                _51_60.gb4.BringToFront()
                                _51_60.gb4.Dock = DockStyle.Fill
                            Case 55
                                _51_60.gb5.BringToFront()
                                _51_60.gb5.Dock = DockStyle.Fill
                            Case 56
                                _51_60.gb6.BringToFront()
                                _51_60.gb6.Dock = DockStyle.Fill
                            Case 57
                                _51_60.gb7.BringToFront()
                                _51_60.gb7.Dock = DockStyle.Fill
                            Case 58
                                _51_60.gb8.BringToFront()
                                _51_60.gb8.Dock = DockStyle.Fill
                            Case 59
                                _51_60.gb9.BringToFront()
                                _51_60.gb9.Dock = DockStyle.Fill
                            Case 60
                                _51_60.gb10.BringToFront()
                                _51_60.gb10.Dock = DockStyle.Fill
                        End Select
                    ElseIf _number < 1 Then
                        MetroMessageBox.Show(Me, vbCrLf & "Number is out of range. Choose between 1 to 60 only." & vbCrLf & vbCrLf & vbCrLf & "©(PGLU-HRMD Series of 2018)", "Road Safety Program (Drivers Exam)", MessageBoxButtons.OK, MessageBoxIcon.Question)
                    ElseIf _number > 60 Then
                        MetroMessageBox.Show(Me, vbCrLf & "Number is out of range. Choose between 1 to 60 only." & vbCrLf & vbCrLf & vbCrLf & "©(PGLU-HRMD Series of 2018)", "Road Safety Program (Drivers Exam)", MessageBoxButtons.OK, MessageBoxIcon.Question)
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub _1_10_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        MetroMessageBox.Show(Me, vbCrLf & "Exit Function is Prohibited. Continue with the exam!" & vbCrLf & vbCrLf & vbCrLf & "©(PGLU-HRMD Series of 2018)", "Road Safety Program (Drivers Exam)", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        e.Cancel = True
    End Sub
End Class