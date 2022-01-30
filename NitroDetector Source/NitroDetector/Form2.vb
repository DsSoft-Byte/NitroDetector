Public Class Form2
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'No own Legit Links file for now'
        MessageBox.Show("This is not yet implemented as i can imagine it being Abused")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'This will Download the File with the Legit Nitro Links from GIT and Place it under C:\'
        MessageBox.Show("This is not yet Implemeted due to lack of time, but will be Implemented soon")
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        'Donation show-uppy'
        Process.Start("https://paypal.me/DsSoft8")
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        'Source code was summoned'
        Process.Start("https://github.com/DsSoft-Byte/NitroDetector")
    End Sub
End Class