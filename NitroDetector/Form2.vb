Imports System.Windows

Public Class Form2
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'No own Legit Links file for now'
        MessageBox.Show("This is not yet implemented as i can imagine it being Abused")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'This will Download the File with the Legit Nitro Links from GIT and Place it under C:\'
        MessageBox.Show("The NitroDetector will as of now download only official, verified updates from DsSoft")
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

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Form3.Show()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim request As System.Net.HttpWebRequest = System.Net.HttpWebRequest.Create("https://github.com/DsSoft-Byte/NitroDetector/blob/main/version.txt")
        Dim response As System.Net.HttpWebResponse = request.GetResponse
        Dim sr As IO.StreamReader = New System.IO.StreamReader(response.GetResponseStream)

        Dim newestversions As String = sr.ReadToEnd
        Dim currentversion As String = Application.ProductVersion

        If newestversions.Contains(currentversion) Then
            MsgBox("You are up to date!")
        Else
            Form4.Show()
        End If
    End Sub
End Class