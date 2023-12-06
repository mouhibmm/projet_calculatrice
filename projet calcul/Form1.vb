Public Class Form1
    Dim old As Integer
    Dim res As Integer
    Dim op As String
    Private Sub Button10_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        txt_a.Text = txt_a.Text + "1"

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        txt_a.Text = txt_a.Text + "2"

    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        txt_a.Text = txt_a.Text + "3"

    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        txt_a.Text = txt_a.Text + "0"

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        txt_a.Text = txt_a.Text + "4"

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        txt_a.Text = txt_a.Text + "5"

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        txt_a.Text = txt_a.Text + "6"

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        txt_a.Text = txt_a.Text + "7"

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        txt_a.Text = txt_a.Text + "8"

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        txt_a.Text = txt_a.Text + "9"

    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        txt_a.Clear()

        txt_rsl.Clear()
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        op = "*"
        old = txt_a.Text
        txt_a.Clear()
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        op = "-"
        old = txt_a.Text
        txt_a.Clear()
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        op = "+"
        old = txt_a.Text
        txt_a.Clear()
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        op = "/"
        old = txt_a.Text
        txt_a.Clear()
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        If op = "+" Then
            txt_rsl.Text = old + txt_a.Text
        ElseIf op = "*" Then
            txt_rsl.Text = old * txt_a.Text
        ElseIf op = "-" Then
            txt_rsl.Text = old - txt_a.Text
        ElseIf op = "/" Then
            txt_rsl.Text = old / txt_a.Text
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
