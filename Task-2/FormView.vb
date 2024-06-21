Imports System.IO
Imports Newtonsoft.Json

Public Class FormView
    Private submissions As List(Of Submission)
    Private currentIndex As Integer
    Private Sub FormView_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadSubmissions()
        DisplaySubmission()
    End Sub
    Private Sub LoadSubmissions()
        ' Load submissions from JSON file
        Dim json As String = File.ReadAllText("C:\Users\hardik\source\repos\Task-2\form-backend\src\db.json")
        submissions = JsonConvert.DeserializeObject(Of List(Of Submission))(json)
        If submissions Is Nothing Then
            submissions = New List(Of Submission)()
        End If
    End Sub

    Private Sub DisplaySubmission()
        If submissions.Count = 0 Then
            txtName.Text = ""
            txtEmail.Text = ""
            txtPhone.Text = ""
            txtGitHub.Text = ""
            txtStopwatch.Text = ""
            btnPrevious.Enabled = False
            btnNext.Enabled = False
        Else
            Dim submission As Submission = submissions(currentIndex)
            txtName.Text = submission.Name
            txtEmail.Text = submission.Email
            txtPhone.Text = submission.Phone
            txtGitHub.Text = submission.GitHubLink
            txtStopwatch.Text = submission.StopwatchTime
            btnPrevious.Enabled = currentIndex > 0
            btnNext.Enabled = currentIndex < submissions.Count - 1
        End If
    End Sub




    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        If currentIndex > 0 Then
            currentIndex -= 1
            DisplaySubmission()
        End If
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        If currentIndex < submissions.Count - 1 Then
            currentIndex += 1
            DisplaySubmission()
        End If
    End Sub

    Private Sub FormView_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.Control AndAlso e.KeyCode = Keys.P Then
            btnPrevious.PerformClick()
        ElseIf e.Control AndAlso e.KeyCode = Keys.N Then
            btnNext.PerformClick()
        End If
    End Sub
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, keyData As Keys) As Boolean
        If keyData = (Keys.Control Or Keys.P) Then
            btnPrevious.PerformClick()
            Return True
        ElseIf keyData = (Keys.Control Or Keys.N) Then
            btnNext.PerformClick()
            Return True
        End If
        Return MyBase.ProcessCmdKey(msg, keyData)
    End Function

End Class

Public Class Submission
    Public Property Name As String
    Public Property Email As String
    Public Property Phone As String
    Public Property GitHubLink As String
    Public Property StopwatchTime As String
End Class