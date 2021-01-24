Imports System.IO

Public Class Form1
    Public targetFolder As String = Environment.CurrentDirectory

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtPattern.Text = "*.*"
        txtDirectory.Text = targetFolder
        txtDirectory.Focus()
    End Sub

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click

        If FolderBrowserDialog1.ShowDialog() = DialogResult.OK Then
            targetFolder = FolderBrowserDialog1.SelectedPath
        End If
        txtDirectory.Text = targetFolder
    End Sub

    Private Sub btnListFiles_Click(sender As Object, e As EventArgs) Handles btnListFiles.Click
        Dim targetPattern As String = txtPattern.Text
        Dim selectedDirectories() As String
        If targetPattern.Equals(String.Empty) Then targetPattern = "*.*"

        targetFolder = txtDirectory.Text
        If Not Directory.Exists(targetFolder) Then
            MessageBox.Show("The specified folder does not exist")
            Return
        End If

        If ChbRecursive.Checked Then
            selectedDirectories = Directory.GetFiles(targetFolder, targetPattern, SearchOption.AllDirectories)
        Else
            selectedDirectories = Directory.GetFiles(targetFolder, targetPattern, SearchOption.TopDirectoryOnly)
        End If
        lbFiles.Items.Clear()

        For Each path As String In selectedDirectories
            lbFiles.Items.Add(path)
        Next

    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim filesToDelete(-1) As String

        For Each item In lbFiles.CheckedItems
            ReDim Preserve filesToDelete(filesToDelete.Length)
            filesToDelete(filesToDelete.Length - 1) = item.ToString
        Next

        lbFiles.Items.Clear()

        For i As Integer = 0 To filesToDelete.Length - 1
            lbFiles.Items.Add(filesToDelete(i))
            lbFiles.SetItemChecked(i, True)
        Next

        Dim result As DialogResult = MessageBox.Show("Do you wish to delete the selected files? ", "File Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2)

        If result = DialogResult.Yes Then
            For Each filePath As String In filesToDelete
                File.Delete(filePath)
            Next filepath
        End If
        lbFiles.Items.Clear()
        btnBrowse.Focus()

    End Sub
End Class
