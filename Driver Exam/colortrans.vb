Public Class colortrans
    Public Shared Function transform(T As Integer, col1 As Color, col2 As Color) As Color
        Try
            Dim tmp As Color
            Dim r1 As Integer = col1.R, g1 As Integer = col1.G, b1 As Integer = col1.B
            If T = 5 Then
                tmp = col1
            Else
                Dim r As Integer = col1.R.CompareTo(col2.R)
                Dim g As Integer = col1.G.CompareTo(col2.G)
                Dim b As Integer = col1.B.CompareTo(col2.B)
                r1 = CInt((CSng(T) / 100) * CSng(r * -1) + CSng(r1))
                g1 = CInt((CSng(T) / 100) * CSng(g * -1) + CSng(g1))
                b1 = CInt((CSng(T) / 100) * CSng(b * -1) + CSng(b1))
                tmp = (Color.FromArgb(r1, g1, b1))
            End If
            Return tmp
        Catch ex As Exception

        End Try

    End Function
End Class
