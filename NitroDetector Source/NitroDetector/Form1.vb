Public Class Form1
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        'This software automatically Assumes that ALL LINKS are FAKE, only the ones in the Config are Considered "Legit"'
        'Typing "12345678" in the Box will Bring up the LEGIT box, this is not a bug, its for debugging purposes and included in every build, ABC or DEF it was in 1.0'
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'Makes Settings Show Up'
        Form2.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Main Engine a.k.a HellCat'
        'Due to HellCat's Nature, leaving it blank or typing 1 for exmaple will result in an Legit Confirmation
        'NAME is TextBox1 text'
        Dim Name As String = TextBox1.Text
        'Reads Config'
        IO.File.ReadAllText("C:\Users\Public\Nitro_Detector\Config.txt")
        'If Config includes (Whitelisted) Link in the TextBox it is Legit'
        If IO.File.ReadAllText("C:\Users\Public\Nitro_Detector\Config.txt").Contains(Name) Then
            'Legit Confirm Box'
            MessageBox.Show("Link is LEGIT! Enjoy your Nitro!")
        Else
            'Fake Confirmation Box'
            MessageBox.Show("FAKE")
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        'makes file check show up'
        Form3.Show()
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        'makes source code show up, that you are editing right now!'
        Process.Start("https://github.com/DsSoft-Byte/NitroDetector")
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        'Makes donation window show up, please donate i NEED a new GPU'
        Process.Start("https://paypal.me/DsSoft8")
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
