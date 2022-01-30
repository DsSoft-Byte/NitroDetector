Public Class Form3
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        IO.File.ReadAllText("C:\LEGIT.txt")
        TextBox1.Text = ("Didnt Error Out? Everything is OK. Error? Files Are Missing")
    End Sub
End Class