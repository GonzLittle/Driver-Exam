Option Strict On
Option Explicit On
Imports Microsoft.Win32
Public Class Result
    Private Sub Result_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CrystalReportViewer1.Refresh()
    End Sub
End Class