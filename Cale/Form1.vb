﻿Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a As Double
        Dim b As Double
        a = TextBox1.Text
        b = TextBox2.Text
        TextBox3.Text = a + b
    End Sub
End Class
