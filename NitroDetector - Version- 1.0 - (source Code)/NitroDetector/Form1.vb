Public Class Form1
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'Makes Settings Show Up'
        Form2.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Main Engine a.k.a HellCat'
        Dim Name As String = TextBox1.Text
        IO.File.ReadAllText("C:\LEGIT.txt")
        If IO.File.ReadAllText("C:\LEGIT.txt").Contains(Name) Then
            MessageBox.Show("Link is LEGIT! Enjoy your Nitro!")
        Else
            MessageBox.Show("FAKE")
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form3.Show()
    End Sub
End Class
