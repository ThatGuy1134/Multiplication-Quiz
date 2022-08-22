Option Explicit On
Option Strict On
Option Infer Off

Public Class MainForm
    Dim maxFactor, numProbs, answer, num1, num2, score, timeElapsed, problemsShown As Int32
    Dim grade As Decimal

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Private Sub TwentyRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles TwentyRadioButton.CheckedChanged
        numProbs = 20
    End Sub

    Private Sub ThirtyRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles ThirtyRadioButton.CheckedChanged
        numProbs = 30
    End Sub

    Private Sub FortyRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles FortyRadioButton.CheckedChanged
        numProbs = 40
    End Sub

    Private Sub FiftyRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles FiftyRadioButton.CheckedChanged
        numProbs = 50
    End Sub

    Private Sub AnswerTextBox_TextChanged(sender As Object, e As EventArgs) Handles AnswerTextBox.TextChanged

    End Sub

    ' function to generate random numbers from 0 to the max factor
    Private Function RandomFactor() As Int32
        Randomize()
        Dim factor As Int32 = CInt(maxFactor * Rnd())
        Return factor
    End Function

    Private Sub QuizTimer_Tick(sender As Object, e As EventArgs) Handles QuizTimer.Tick
        timeElapsed += 1
    End Sub

    Private Sub MFTextBox_TextChanged(sender As Object, e As EventArgs) Handles MFTextBox.TextChanged
        maxFactor = CInt(MFTextBox.Text)
        StartButton.Enabled = True
    End Sub

    Private Sub StartButton_Click(sender As Object, e As EventArgs) Handles StartButton.Click
        problemsShown = 0
        score = 0
        timeElapsed = 0
        grade = 0.00D
        ScoreLabel.Text = String.Empty
        MessageLabel.Text = String.Empty
        TimeLabel.Text = String.Empty
        AnswerTextBox.Enabled = True
        AnswerTextBox.Focus()
        num1 = RandomFactor()
        num2 = RandomFactor()
        ProblemLabel.Text = "    " & num1.ToString & vbCrLf & "X " & num2.ToString & vbCrLf & "-----------"
        problemsShown += 1
        ProbShownLabel.Text = problemsShown.ToString
        QuizTimer.Enabled = True
        QuizTimer.Start()
        timeElapsed = 0
    End Sub

    Private Sub AnswerTextBox_KeyUp(sender As Object, e As KeyEventArgs) Handles AnswerTextBox.KeyUp
        If e.KeyCode = Keys.Space Then
            If problemsShown <= numProbs Then
                If Integer.TryParse(AnswerTextBox.Text.Trim, answer) Then
                    answer = CInt(AnswerTextBox.Text.Trim)
                End If
                If (answer = num1 * num2) Then
                    score += 1
                    ScoreLabel.Text = score.ToString
                End If
                AnswerTextBox.Text = String.Empty
                ProblemLabel.Text = String.Empty
                If problemsShown < numProbs Then
                    num1 = RandomFactor()
                    num2 = RandomFactor()
                    ProblemLabel.Text = "    " & num1.ToString & vbCrLf & "X " & num2.ToString & vbCrLf & "-----------"
                    problemsShown += 1
                    ProbShownLabel.Text = problemsShown.ToString
                Else
                    Results()
                End If

            End If
            e.Handled = True
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub Results()
        QuizTimer.Stop()
        TimeLabel.Text = TimeConversion()
        QuizTimer.Enabled = False
        ProbShownLabel.Text = String.Empty
        AnswerTextBox.Enabled = False
        MFTextBox.SelectAll()
        MFTextBox.Focus()
        StartButton.Enabled = False
        ScoreLabel.Text = String.Empty
        grade = CDec(score / numProbs)
        ScoreLabel.Text = grade.ToString("P0")
        MessageLabel.Text = ResultsMessage()

    End Sub

    Private Function TimeConversion() As String
        Dim mins As Int32 = 0
        While timeElapsed >= 60
            mins += 1
            timeElapsed -= 60
        End While
        Return mins.ToString("N0") & ":" & timeElapsed.ToString("N0")
    End Function

    Private Function ResultsMessage() As String
        Dim message As String
        If grade >= 0.8D Then
            message = "Good" & vbCrLf & "Job!"
        Else
            message = "Keep" & vbCrLf & "Going!"
        End If
        Return message
    End Function


End Class
