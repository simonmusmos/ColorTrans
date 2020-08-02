Public Class Form1
    Dim r, g, b, gr, gb, gg, rn, gr1, gg1, gb1, r1, g1, b1

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If r1 < gr1 Then
            r1 += 1
        ElseIf r1 > gr1
            r1 -= 1
        End If
        If g1 < gg1 Then
            g1 += 1
        ElseIf g1 > gg1
            g1 -= 1
        End If
        If b1 < gb1 Then
            b1 += 1
        ElseIf b1 > gb1
            b1 -= 1
        End If
        lbl1.ForeColor = Color.FromArgb(r1, g1, b1)
        If r1 = gr1 And g1 = gg1 And b1 = gb1 Then
            ran1()
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If r < gr Then
            r += 1
        ElseIf r > gr
            r -= 1
        End If
        If g < gg Then
            g += 1
        ElseIf g > gg
            g -= 1
        End If
        If b < gb Then
            b += 1
        ElseIf b > gb
            b -= 1
        End If
        Me.BackColor = Color.FromArgb(r, g, b)
        If r = gr And g = gg And b = gb Then
            ran()
        End If

    End Sub
    Public Sub ran()
        Randomize()
        gr = CInt(Int((255 * Rnd()) + 0))
        gg = CInt(Int((255 * Rnd()) + 0))
        gb = CInt(Int((255 * Rnd()) + 0))
    End Sub
    Public Sub ran1()
        Randomize()
        gr1 = CInt(Int((255 * Rnd()) + 0))
        gg1 = CInt(Int((255 * Rnd()) + 0))
        gb1 = CInt(Int((255 * Rnd()) + 0))
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        r = 63
        g = 63
        b = 70
        r1 = 255
        g1 = 255
        b1 = 155
        ' lbl1.ForeColor = Color.FromArgb(r1, g1, b1)
        ran1()
        Me.BackColor = Color.FromArgb(r, g, b)
        ran()
        'Timer2.Start()
        Timer1.Start()
    End Sub

    Private Sub Form1_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles Me.MouseDoubleClick
        End
    End Sub
End Class
