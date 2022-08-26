Public Class Form3
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Only Reads the Config, no write only makes sure it exists. I need to introduce a check tho'
        IO.File.ReadAllText("C:\Users\Public\Nitro_Detector\Config.txt")
        'Message, self explainatory'
        TextBox1.Text = ("Didnt Error Out? Everything is OK. Error? Files Are Missing")
    End Sub
End Class