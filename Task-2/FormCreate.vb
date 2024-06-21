Imports System.IO
Imports Newtonsoft.Json
Imports System.Diagnostics

Public Class FormCreate

    Private stopwatchRunning As Boolean = False
    Private stopwatch As New Stopwatch()
    Private WithEvents updateTimer As New Timer()
    Private submissions As List(Of Submission)

    Private Sub FormCreate_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadSubmissions()
        ToggleStopwatch()
    End Sub

    Private Sub LoadSubmissions()
        ' Load submissions from JSON file
        Dim json As String = File.ReadAllText("C:\Users\hardik\source\repos\Task-2\form-backend\src\db.json")
        submissions = JsonConvert.DeserializeObject(Of List(Of Submission))(json)
        If submissions Is Nothing Then
            submissions = New List(Of Submission)()
        End If
    End Sub

    Private Sub btnToggleStopwatch_Click(sender As Object, e As EventArgs) Handles btnToggleStopwatch.Click
        ToggleStopwatch()
    End Sub

    Private Sub ToggleStopwatch()
        If stopwatchRunning Then
            stopwatch.Stop()
            updateTimer.Stop()
        Else
            stopwatch.Start()
            updateTimer.Start()
        End If
        stopwatchRunning = Not stopwatchRunning
    End Sub

    Private Sub UpdateStopwatchLabel()
        lblStopwatch.Text = stopwatch.Elapsed.ToString("hh\:mm\:ss")
    End Sub

    Private Sub UpdateTimer_Tick(sender As Object, e As EventArgs) Handles updateTimer.Tick
        UpdateStopwatchLabel()
    End Sub



    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        ' Collect data
        Dim submission As New Submission() With {
            .Name = txtName.Text,
            .Email = txtEmail.Text,
            .Phone = txtPhone.Text,
            .GitHubLink = txtGitHub.Text,
            .StopwatchTime = lblStopwatch.Text
        }

        ' Add to list and save to file
        submissions.Add(submission)
        SaveSubmissions()
        MessageBox.Show("Submission saved!")
    End Sub

    Private Sub SaveSubmissions()
        ' Save submissions to JSON file
        Dim json As String = JsonConvert.SerializeObject(submissions, Formatting.Indented)
        File.WriteAllText("C:\Users\hardik\source\repos\Task-2\form-backend\src\db.json", json)
    End Sub


    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, keyData As Keys) As Boolean
        If keyData = (Keys.Control Or Keys.T) Then
            ToggleStopwatch()
            Return True
        ElseIf keyData = (Keys.Control Or Keys.S) Then
            btnSubmit.PerformClick()
            Return True
        End If
        Return MyBase.ProcessCmdKey(msg, keyData)
    End Function

End Class
