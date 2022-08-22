<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.MFactorLabel = New System.Windows.Forms.Label()
        Me.ProblemsLabel = New System.Windows.Forms.Label()
        Me.MFTextBox = New System.Windows.Forms.TextBox()
        Me.TwentyRadioButton = New System.Windows.Forms.RadioButton()
        Me.ThirtyRadioButton = New System.Windows.Forms.RadioButton()
        Me.FortyRadioButton = New System.Windows.Forms.RadioButton()
        Me.FiftyRadioButton = New System.Windows.Forms.RadioButton()
        Me.StartButton = New System.Windows.Forms.Button()
        Me.ProblemLabel = New System.Windows.Forms.Label()
        Me.AnswerLabel = New System.Windows.Forms.Label()
        Me.TimerLabel = New System.Windows.Forms.Label()
        Me.AnswerTextBox = New System.Windows.Forms.TextBox()
        Me.TimeLabel = New System.Windows.Forms.Label()
        Me.ScLabel = New System.Windows.Forms.Label()
        Me.ScoreLabel = New System.Windows.Forms.Label()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.ProbShownLabel = New System.Windows.Forms.Label()
        Me.QuizTimer = New System.Windows.Forms.Timer(Me.components)
        Me.PBShownLabel = New System.Windows.Forms.Label()
        Me.MessageLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'MFactorLabel
        '
        Me.MFactorLabel.AutoSize = True
        Me.MFactorLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MFactorLabel.Location = New System.Drawing.Point(13, 13)
        Me.MFactorLabel.Name = "MFactorLabel"
        Me.MFactorLabel.Size = New System.Drawing.Size(170, 25)
        Me.MFactorLabel.TabIndex = 0
        Me.MFactorLabel.Text = "Maximum factor:"
        '
        'ProblemsLabel
        '
        Me.ProblemsLabel.AutoSize = True
        Me.ProblemsLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProblemsLabel.Location = New System.Drawing.Point(13, 49)
        Me.ProblemsLabel.Name = "ProblemsLabel"
        Me.ProblemsLabel.Size = New System.Drawing.Size(211, 25)
        Me.ProblemsLabel.TabIndex = 0
        Me.ProblemsLabel.Text = "Number of problems:"
        '
        'MFTextBox
        '
        Me.MFTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MFTextBox.Location = New System.Drawing.Point(190, 13)
        Me.MFTextBox.Name = "MFTextBox"
        Me.MFTextBox.Size = New System.Drawing.Size(219, 31)
        Me.MFTextBox.TabIndex = 1
        '
        'TwentyRadioButton
        '
        Me.TwentyRadioButton.AutoSize = True
        Me.TwentyRadioButton.Checked = True
        Me.TwentyRadioButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TwentyRadioButton.Location = New System.Drawing.Point(231, 56)
        Me.TwentyRadioButton.Name = "TwentyRadioButton"
        Me.TwentyRadioButton.Size = New System.Drawing.Size(40, 20)
        Me.TwentyRadioButton.TabIndex = 2
        Me.TwentyRadioButton.TabStop = True
        Me.TwentyRadioButton.Text = "20"
        Me.TwentyRadioButton.UseVisualStyleBackColor = True
        '
        'ThirtyRadioButton
        '
        Me.ThirtyRadioButton.AutoSize = True
        Me.ThirtyRadioButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ThirtyRadioButton.Location = New System.Drawing.Point(277, 56)
        Me.ThirtyRadioButton.Name = "ThirtyRadioButton"
        Me.ThirtyRadioButton.Size = New System.Drawing.Size(40, 20)
        Me.ThirtyRadioButton.TabIndex = 3
        Me.ThirtyRadioButton.TabStop = True
        Me.ThirtyRadioButton.Text = "30"
        Me.ThirtyRadioButton.UseVisualStyleBackColor = True
        '
        'FortyRadioButton
        '
        Me.FortyRadioButton.AutoSize = True
        Me.FortyRadioButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FortyRadioButton.Location = New System.Drawing.Point(323, 56)
        Me.FortyRadioButton.Name = "FortyRadioButton"
        Me.FortyRadioButton.Size = New System.Drawing.Size(40, 20)
        Me.FortyRadioButton.TabIndex = 4
        Me.FortyRadioButton.TabStop = True
        Me.FortyRadioButton.Text = "40"
        Me.FortyRadioButton.UseVisualStyleBackColor = True
        '
        'FiftyRadioButton
        '
        Me.FiftyRadioButton.AutoSize = True
        Me.FiftyRadioButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FiftyRadioButton.Location = New System.Drawing.Point(369, 56)
        Me.FiftyRadioButton.Name = "FiftyRadioButton"
        Me.FiftyRadioButton.Size = New System.Drawing.Size(40, 20)
        Me.FiftyRadioButton.TabIndex = 5
        Me.FiftyRadioButton.TabStop = True
        Me.FiftyRadioButton.Text = "50"
        Me.FiftyRadioButton.UseVisualStyleBackColor = True
        '
        'StartButton
        '
        Me.StartButton.Enabled = False
        Me.StartButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StartButton.Location = New System.Drawing.Point(431, 13)
        Me.StartButton.Name = "StartButton"
        Me.StartButton.Size = New System.Drawing.Size(83, 31)
        Me.StartButton.TabIndex = 6
        Me.StartButton.Text = "Start"
        Me.StartButton.UseVisualStyleBackColor = True
        '
        'ProblemLabel
        '
        Me.ProblemLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.ProblemLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProblemLabel.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.ProblemLabel.Location = New System.Drawing.Point(18, 90)
        Me.ProblemLabel.Name = "ProblemLabel"
        Me.ProblemLabel.Size = New System.Drawing.Size(190, 190)
        Me.ProblemLabel.TabIndex = 4
        Me.ProblemLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'AnswerLabel
        '
        Me.AnswerLabel.AutoSize = True
        Me.AnswerLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AnswerLabel.Location = New System.Drawing.Point(234, 90)
        Me.AnswerLabel.Name = "AnswerLabel"
        Me.AnswerLabel.Size = New System.Drawing.Size(120, 31)
        Me.AnswerLabel.TabIndex = 5
        Me.AnswerLabel.Text = "Answer:"
        '
        'TimerLabel
        '
        Me.TimerLabel.AutoSize = True
        Me.TimerLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TimerLabel.Location = New System.Drawing.Point(222, 209)
        Me.TimerLabel.Name = "TimerLabel"
        Me.TimerLabel.Size = New System.Drawing.Size(66, 25)
        Me.TimerLabel.TabIndex = 0
        Me.TimerLabel.Text = "Timer"
        '
        'AnswerTextBox
        '
        Me.AnswerTextBox.AcceptsReturn = True
        Me.AnswerTextBox.Enabled = False
        Me.AnswerTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AnswerTextBox.Location = New System.Drawing.Point(231, 124)
        Me.AnswerTextBox.Name = "AnswerTextBox"
        Me.AnswerTextBox.Size = New System.Drawing.Size(178, 44)
        Me.AnswerTextBox.TabIndex = 7
        '
        'TimeLabel
        '
        Me.TimeLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TimeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TimeLabel.Location = New System.Drawing.Point(231, 236)
        Me.TimeLabel.Name = "TimeLabel"
        Me.TimeLabel.Size = New System.Drawing.Size(178, 44)
        Me.TimeLabel.TabIndex = 4
        '
        'ScLabel
        '
        Me.ScLabel.AutoSize = True
        Me.ScLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ScLabel.Location = New System.Drawing.Point(437, 80)
        Me.ScLabel.Name = "ScLabel"
        Me.ScLabel.Size = New System.Drawing.Size(68, 25)
        Me.ScLabel.TabIndex = 0
        Me.ScLabel.Text = "Score"
        '
        'ScoreLabel
        '
        Me.ScoreLabel.AutoSize = True
        Me.ScoreLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ScoreLabel.Location = New System.Drawing.Point(431, 105)
        Me.ScoreLabel.Name = "ScoreLabel"
        Me.ScoreLabel.Size = New System.Drawing.Size(0, 37)
        Me.ScoreLabel.TabIndex = 7
        '
        'ExitButton
        '
        Me.ExitButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExitButton.Location = New System.Drawing.Point(431, 236)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(83, 44)
        Me.ExitButton.TabIndex = 8
        Me.ExitButton.Text = "Exit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'ProbShownLabel
        '
        Me.ProbShownLabel.AutoSize = True
        Me.ProbShownLabel.Location = New System.Drawing.Point(104, 290)
        Me.ProbShownLabel.Name = "ProbShownLabel"
        Me.ProbShownLabel.Size = New System.Drawing.Size(0, 13)
        Me.ProbShownLabel.TabIndex = 8
        '
        'QuizTimer
        '
        Me.QuizTimer.Interval = 1000
        '
        'PBShownLabel
        '
        Me.PBShownLabel.AutoSize = True
        Me.PBShownLabel.Location = New System.Drawing.Point(12, 290)
        Me.PBShownLabel.Name = "PBShownLabel"
        Me.PBShownLabel.Size = New System.Drawing.Size(89, 13)
        Me.PBShownLabel.TabIndex = 9
        Me.PBShownLabel.Text = "Problems Shown:"
        '
        'MessageLabel
        '
        Me.MessageLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MessageLabel.Location = New System.Drawing.Point(430, 149)
        Me.MessageLabel.Name = "MessageLabel"
        Me.MessageLabel.Size = New System.Drawing.Size(85, 75)
        Me.MessageLabel.TabIndex = 10
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(534, 311)
        Me.Controls.Add(Me.MessageLabel)
        Me.Controls.Add(Me.PBShownLabel)
        Me.Controls.Add(Me.ProbShownLabel)
        Me.Controls.Add(Me.ScoreLabel)
        Me.Controls.Add(Me.AnswerTextBox)
        Me.Controls.Add(Me.AnswerLabel)
        Me.Controls.Add(Me.TimeLabel)
        Me.Controls.Add(Me.ProblemLabel)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.StartButton)
        Me.Controls.Add(Me.FiftyRadioButton)
        Me.Controls.Add(Me.FortyRadioButton)
        Me.Controls.Add(Me.ThirtyRadioButton)
        Me.Controls.Add(Me.TwentyRadioButton)
        Me.Controls.Add(Me.MFTextBox)
        Me.Controls.Add(Me.TimerLabel)
        Me.Controls.Add(Me.ProblemsLabel)
        Me.Controls.Add(Me.ScLabel)
        Me.Controls.Add(Me.MFactorLabel)
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Multiplication Practice"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MFactorLabel As Label
    Friend WithEvents ProblemsLabel As Label
    Friend WithEvents MFTextBox As TextBox
    Friend WithEvents TwentyRadioButton As RadioButton
    Friend WithEvents ThirtyRadioButton As RadioButton
    Friend WithEvents FortyRadioButton As RadioButton
    Friend WithEvents FiftyRadioButton As RadioButton
    Friend WithEvents StartButton As Button
    Friend WithEvents ProblemLabel As Label
    Friend WithEvents AnswerLabel As Label
    Friend WithEvents TimerLabel As Label
    Friend WithEvents AnswerTextBox As TextBox
    Friend WithEvents TimeLabel As Label
    Friend WithEvents ScLabel As Label
    Friend WithEvents ScoreLabel As Label
    Friend WithEvents ExitButton As Button
    Friend WithEvents ProbShownLabel As Label
    Friend WithEvents QuizTimer As Timer
    Friend WithEvents PBShownLabel As Label
    Friend WithEvents MessageLabel As Label
End Class
