Imports System.Threading.Tasks
Imports System.Windows.Forms
Imports System.Drawing

Public Class splash_screen
    Dim Colors As New List(Of Color)()
    Dim currentcolor As Integer = 0
    Dim _loop As Integer = 0
    Public Sub New()
        ' This call Is required by the designer.
        Colors.Add(Color.FromArgb(0, 158, 71))
        Colors.Add(Color.FromArgb(112, 191, 83))
        Colors.Add(Color.FromArgb(216, 155, 40))
        Colors.Add(Color.FromArgb(217, 102, 41))
        Colors.Add(Color.FromArgb(235, 83, 101))
        Colors.Add(Color.FromArgb(223, 128, 255))
        Colors.Add(Color.FromArgb(112, 48, 100))
        Colors.Add(Color.FromArgb(107, 122, 187))
        Colors.Add(Color.FromArgb(95, 136, 176))
        Colors.Add(Color.FromArgb(78, 175, 227))
        Colors.Add(Color.FromArgb(0, 158, 71))

        Colors.Add(Color.FromArgb(0, 158, 71))
        Colors.Add(Color.FromArgb(112, 191, 83))
        Colors.Add(Color.FromArgb(216, 155, 40))
        Colors.Add(Color.FromArgb(217, 102, 41))
        Colors.Add(Color.FromArgb(235, 83, 101))
        Colors.Add(Color.FromArgb(153, 221, 204))
        Colors.Add(Color.FromArgb(112, 48, 100))
        Colors.Add(Color.FromArgb(82, 76, 132))
        Colors.Add(Color.FromArgb(83, 82, 56))
        Colors.Add(Color.FromArgb(109, 218, 190))
        Colors.Add(Color.FromArgb(75, 187, 139))

        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
    End Sub
    Private Sub splash_screen_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        fader.Interval = 50
        fader.Enabled = True
    End Sub
    Private Sub fader_Tick(sender As Object, e As EventArgs) Handles fader.Tick
        fader.Enabled = False
        If currentcolor < Colors.Count - 1 Then
            Me.BackColor = colortrans.transform(_loop, Colors(currentcolor), Colors(currentcolor + 1))
            If _loop < 100 Then
                _loop += _loop + 1
            Else
                _loop = 0
                currentcolor += 1
                BunifuCustomLabel1.Text = "Loading"
            End If
            If _loop Mod 2 = 1 Then
                BunifuCustomLabel1.Text = BunifuCustomLabel1.Text + "."
            End If
            fader.Enabled = True
        Else
            Me.Hide()
            Userfrm.Show()
        End If
    End Sub
End Class