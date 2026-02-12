#Disable Warning IDE1006

Public Class frmMain
    Private questForm As frmQuestions, resultsForm As frmResults

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set form properties
        StartPosition = FormStartPosition.CenterScreen
        MinimumSize = New Size(1000, 700)
        MaximumSize = New Size(1200, 900)

        ' Set description label text
        lblDescription.Text = "Explore the Honesty-Humility and Dark Triad traits in your personality spectrum

This assessment contains 40 questions divided into four dimensions:
* Honesty-Humility (Light Trait)
* Machiavellianism, Narcissism, Psychopathy (Dark Triad)"
    End Sub

    Private Sub StartTest(sender As Object, e As EventArgs) Handles btnStart.Click
        ' Create and show questions form
        If questForm Is Nothing OrElse questForm.IsDisposed Then
            questForm = New frmQuestions()
            AddHandler questForm.TestCompleted, AddressOf OnTestCompleted
            AddHandler questForm.BackToMain, AddressOf OnBackToMain
        End If

        questForm.StartTest()
        Hide()
        questForm.Show()
    End Sub

    Private Sub OnTestCompleted(answers As Dictionary(Of Integer, Integer))
        ' Create and show results form
        If resultsForm Is Nothing OrElse resultsForm.IsDisposed Then
            resultsForm = New frmResults
            AddHandler resultsForm.RetakeTest, AddressOf OnRetakeTest
        End If

        resultsForm.DisplayResults(answers)
        questForm.Hide()
        resultsForm.Show()
    End Sub

    Private Sub OnBackToMain()
        ' Return to main form
        If questForm IsNot Nothing AndAlso Not questForm.IsDisposed Then questForm.Hide()
        Show()
    End Sub

    Private Sub OnRetakeTest()
        ' Restart the test
        If resultsForm IsNot Nothing AndAlso Not resultsForm.IsDisposed Then resultsForm.Hide()

        If questForm IsNot Nothing AndAlso Not questForm.IsDisposed Then
            questForm.StartTest()
            questForm.Show()
        Else
            questForm = New frmQuestions
            AddHandler questForm.TestCompleted, AddressOf OnTestCompleted
            AddHandler questForm.BackToMain, AddressOf OnBackToMain
            questForm.StartTest()
            questForm.Show()
        End If
    End Sub

    Protected Overrides Sub OnFormClosing(e As FormClosingEventArgs)
        If questForm IsNot Nothing Then
            RemoveHandler questForm.TestCompleted, AddressOf OnTestCompleted
            RemoveHandler questForm.BackToMain, AddressOf OnBackToMain
        End If
        If resultsForm IsNot Nothing Then
            RemoveHandler resultsForm.RetakeTest, AddressOf OnRetakeTest
        End If
        MyBase.OnFormClosing(e)
    End Sub

    Friend Shared Sub Main()
        Application.SetHighDpiMode(HighDpiMode.SystemAware)
        Application.EnableVisualStyles()
        Application.SetCompatibleTextRenderingDefault(False)
        Application.Run(New frmMain)
    End Sub
End Class