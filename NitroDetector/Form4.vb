Imports System.IO.Compression
Imports System.Windows

Public Class Form4
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If My.Computer.FileSystem.FileExists("C:\Users\Public\Downloads\File\NitroUpdate.zip") Then
            MsgBox("The Update file has been downloaded, or is obsolete but present. ERROR Code 01")
        Else
            My.Computer.Network.DownloadFile(
        "https://raw.githubusercontent.com/DsSoft-Byte/NitroDetctor",
        "C:\Users\Public\Downloads\File\NitroUpdate.zip")
            Module1.Main()
            Process.Start("C:\Users\Public\Downloads\Updater\NitroUpdate\Updater\Nitropdate.exe")
            Me.Close()
            Form1.Close()
        End If
    End Sub
End Class
Module Module1

    Sub Main()
        Dim startPath As String = "C:\Users\Public\Downloads"
        Dim zipPath As String = "C:\Users\Public\Downloads\File\NitroUpdate.zip"
        Dim extractPath As String = "C:\Users\Public\Downloads\Updater"

        ZipFile.ExtractToDirectory(zipPath, extractPath)
    End Sub

End Module

