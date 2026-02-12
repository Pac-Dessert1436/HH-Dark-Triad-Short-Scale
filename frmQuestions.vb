#Disable Warning IDE1006
Public Enum Dimension
    HH = 0
    Mach = 1
    Narc = 2
    Psych = 3
End Enum

Public Class frmQuestions
    ' Question data structure
    Public Structure Question
        Public id As Integer
        Public dimension As Dimension
        Public text As String
        Public reverse As Boolean
    End Structure

    ' Questions database (40 questions)
    Public Shared ReadOnly questions As Question() = {
        New Question With {.id = 1, .dimension = Dimension.HH, .text = "If I knew I wouldn't get caught, I might steal without feeling guilty.", .reverse = True},
        New Question With {.id = 2, .dimension = Dimension.HH, .text = "Owning expensive luxury items makes me feel valuable.", .reverse = True},
        New Question With {.id = 3, .dimension = Dimension.HH, .text = "I don't feel more important or special than the people around me.", .reverse = False},
        New Question With {.id = 4, .dimension = Dimension.HH, .text = "Exaggerating the truth is acceptable to get what I want.", .reverse = True},
        New Question With {.id = 5, .dimension = Dimension.HH, .text = "I would rather be an ordinary person than become successful through deception.", .reverse = False},
        New Question With {.id = 6, .dimension = Dimension.HH, .text = "I sometimes secretly feel happy when others misfortune.", .reverse = True},
        New Question With {.id = 7, .dimension = Dimension.HH, .text = "I think showing off wealth is a vulgar behavior.", .reverse = False},
        New Question With {.id = 8, .dimension = Dimension.HH, .text = "If rules get in my way, I will break them without hesitation.", .reverse = True},
        New Question With {.id = 9, .dimension = Dimension.HH, .text = "I keep my promises even when no one is watching.", .reverse = False},
        New Question With {.id = 10, .dimension = Dimension.HH, .text = "Using others' trust to achieve my goals is a smart strategy.", .reverse = True},
        New Question With {.id = 11, .dimension = Dimension.Mach, .text = "The best way is to tell people what they want to hear, not the truth.", .reverse = False},
        New Question With {.id = 12, .dimension = Dimension.Mach, .text = "I believe human nature is inherently evil, and I must always be vigilant with others.", .reverse = False},
        New Question With {.id = 13, .dimension = Dimension.Mach, .text = "Temporary deception is worth it for long-term benefits.", .reverse = False},
        New Question With {.id = 14, .dimension = Dimension.Mach, .text = "I am good at making others do what I want without them realizing it.", .reverse = False},
        New Question With {.id = 15, .dimension = Dimension.Mach, .text = "Being emotional is a sign of weakness; only rational calculation leads to success.", .reverse = False},
        New Question With {.id = 16, .dimension = Dimension.Mach, .text = "I tend to hide my true intentions until the time is right.", .reverse = False},
        New Question With {.id = 17, .dimension = Dimension.Mach, .text = "Morality is just a tool to constrain ordinary people; smart people know how to be flexible.", .reverse = False},
        New Question With {.id = 18, .dimension = Dimension.Mach, .text = "I often think about how to make others work for me.", .reverse = False},
        New Question With {.id = 19, .dimension = Dimension.Mach, .text = "In competition, letting others underestimate me is a wise strategy.", .reverse = False},
        New Question With {.id = 20, .dimension = Dimension.Mach, .text = "If betraying allies can bring greater benefits, I will seriously consider it.", .reverse = False},
        New Question With {.id = 21, .dimension = Dimension.Narc, .text = "I consider myself an extraordinary person destined for great things.", .reverse = False},
        New Question With {.id = 22, .dimension = Dimension.Narc, .text = "I like to be the center of attention.", .reverse = False},
        New Question With {.id = 23, .dimension = Dimension.Narc, .text = "My abilities and talents are underestimated by most people.", .reverse = False},
        New Question With {.id = 24, .dimension = Dimension.Narc, .text = "I expect special treatment and respect.", .reverse = False},
        New Question With {.id = 25, .dimension = Dimension.Narc, .text = "I deserve special treatment because I am different from most people.", .reverse = False},
        New Question With {.id = 26, .dimension = Dimension.Narc, .text = "I find it hard to understand why some people don't admire me.", .reverse = False},
        New Question With {.id = 27, .dimension = Dimension.Narc, .text = "Success is what I deserve because I am better than others.", .reverse = False},
        New Question With {.id = 28, .dimension = Dimension.Narc, .text = "I like to command others and make them obey me.", .reverse = False},
        New Question With {.id = 29, .dimension = Dimension.Narc, .text = "I feel uncomfortable when someone is better than me.", .reverse = False},
        New Question With {.id = 30, .dimension = Dimension.Narc, .text = "I enjoy the pleasure and sense of control that power brings.", .reverse = False},
        New Question With {.id = 31, .dimension = Dimension.Psych, .text = "I rarely feel guilty for hurting others' feelings.", .reverse = False},
        New Question With {.id = 32, .dimension = Dimension.Psych, .text = "Risk and excitement make me feel alive.", .reverse = False},
        New Question With {.id = 33, .dimension = Dimension.Psych, .text = "I am good at mimicking emotional responses even though I feel nothing inside.", .reverse = False},
        New Question With {.id = 34, .dimension = Dimension.Psych, .text = "Rules and laws feel more like suggestions than constraints to me.", .reverse = False},
        New Question With {.id = 35, .dimension = Dimension.Psych, .text = "I can easily cut off emotional ties with others.", .reverse = False},
        New Question With {.id = 36, .dimension = Dimension.Psych, .text = "Others' suffering rarely truly touches my heart.", .reverse = False},
        New Question With {.id = 37, .dimension = Dimension.Psych, .text = "I like to do dangerous things to test my limits.", .reverse = False},
        New Question With {.id = 38, .dimension = Dimension.Psych, .text = "Deceiving others for fun is acceptable.", .reverse = False},
        New Question With {.id = 39, .dimension = Dimension.Psych, .text = "I rarely feel fear or anxiety.", .reverse = False},
        New Question With {.id = 40, .dimension = Dimension.Psych, .text = "Breaking the law doesn't matter if I can get away with it.", .reverse = False}
    }

    ' Response options
    Private Structure OptionItem
        Public value As Integer
        Public label As String
        Public desc As String
    End Structure

    Private options As OptionItem() = {
        New OptionItem With {.value = 1, .label = "Not at all", .desc = "Completely not applicable"},
        New OptionItem With {.value = 2, .label = "Slightly", .desc = "Not very applicable"},
        New OptionItem With {.value = 3, .label = "Moderately", .desc = "Uncertain"},
        New OptionItem With {.value = 4, .label = "Quite well", .desc = "Somewhat applicable"},
        New OptionItem With {.value = 5, .label = "Perfectly", .desc = "Completely applicable"}
    }

    Public currentQuestion As Integer = 0
    Public answers As New Dictionary(Of Integer, Integer)
    Private isTransitioning As Boolean = False

    ' Event for when test is completed
    Public Event TestCompleted(answers As Dictionary(Of Integer, Integer))
    Public Event BackToMain()

    Private Sub frmQuestions_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddHandler btnPrev.Click, AddressOf PrevQuestion
        Controls.Add(DebugButton)
    End Sub

#Region "Uncomment this region to enable debug button"
    Private WithEvents DebugButton As New Button With {
        .BackColor = Color.Transparent,
        .FlatStyle = FlatStyle.Flat,
        .Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point, 0),
        .ForeColor = Color.FromArgb(148, 163, 184),
        .Location = New Point(756, 580),
        .Name = "DebugButton",
        .Size = New Size(194, 40),
        .TabIndex = 7,
        .Text = "Skip for Debug",
        .UseVisualStyleBackColor = False
    }

    Private Sub SkipToResult() Handles DebugButton.Click
        Dim rnd As New Random
        ' Generate random answers for demo
        For Each q As Question In questions
            answers(q.id) = rnd.Next(1, 6)
        Next q
        RaiseEvent TestCompleted(answers)
    End Sub
#End Region

    Public Sub StartTest()
        currentQuestion = 0
        answers.Clear()
        RenderQuestion()
    End Sub

    Private Sub RenderQuestion()
        If currentQuestion >= questions.Length Then
            RaiseEvent TestCompleted(answers)
            Exit Sub
        End If

        Dim q As Question = questions(currentQuestion)

        ' Update question display
        lblQuestionNumber.Text = (currentQuestion + 1).ToString("00")
        lblQuestionText.Text = q.text
        lblProgressText.Text = $"Question {currentQuestion + 1} / 40"

        ' Update progress bar
        Dim progress As Single = (currentQuestion + 1) / 40.0F * ProgressPanel.Width
        ProgressBar.Width = CInt(progress)

        ' Update dimension indicator
        Dim dimIndicator As String = ""
        Select Case q.dimension
            Case Dimension.HH
                dimIndicator = "Honesty-Humility Dimension (1-10)"
            Case Dimension.Mach
                dimIndicator = "Machiavellianism Dimension (11-20)"
            Case Dimension.Narc
                dimIndicator = "Narcissism Dimension (21-30)"
            Case Dimension.Psych
                dimIndicator = "Psychopathy Dimension (31-40)"
        End Select
        lblDimensionIndicator.Text = dimIndicator

        ' Update previous button state
        btnPrev.Enabled = (currentQuestion > 0)

        ' Generate option buttons
        OptionsPanel.Controls.Clear()
        For Each opt As OptionItem In options
            Dim btn As New Button With {
                .Text = $"{opt.value}. {opt.label} - {opt.desc}",
                .Width = 880,
                .Height = 45,
                .Margin = New Padding(0, 3, 0, 3),
                .Tag = opt.value,
                .FlatStyle = FlatStyle.Flat,
                .Font = New Font("Segoe UI", 11.0F),
                .BackColor = Color.FromArgb(30, 41, 59),
                .ForeColor = Color.FromArgb(203, 213, 225),
                .Cursor = Cursors.Hand
            }

            Dim value As Integer = Nothing
            ' Check if this option was already selected
            If answers.TryGetValue(q.id, value) AndAlso value = opt.value Then
                btn.BackColor = Color.FromArgb(99, 102, 241)
                btn.ForeColor = Color.White
            End If

            AddHandler btn.Click, AddressOf SelectOption
            OptionsPanel.Controls.Add(btn)
        Next opt
    End Sub

    Private Sub SelectOption(sender As Object, e As EventArgs)
        If isTransitioning Then Exit Sub

        Dim btn As Button = DirectCast(sender, Button)
        Dim value As Integer = CInt(btn.Tag)
        Dim q As Question = questions(currentQuestion)

        ' Store answer
        answers(q.id) = value

        ' Update button appearance
        For Each ctrl As Control In OptionsPanel.Controls
            If TypeOf ctrl Is Button Then
                Dim b As Button = DirectCast(ctrl, Button)
                b.BackColor = Color.FromArgb(30, 41, 59)
                b.ForeColor = Color.FromArgb(203, 213, 225)
            End If
        Next
        btn.BackColor = Color.FromArgb(99, 102, 241)
        btn.ForeColor = Color.White

        isTransitioning = True

        ' Move to next question after a short delay
        Dim timer As New Timer With {
            .Interval = 300
        }
        AddHandler timer.Tick, Sub()
                                   timer.Stop()
                                   timer.Dispose()
                                   currentQuestion += 1
                                   isTransitioning = False
                                   RenderQuestion()
                               End Sub
        timer.Start()
    End Sub

    Private Sub PrevQuestion(sender As Object, e As EventArgs)
        If currentQuestion > 0 Then
            currentQuestion -= 1
            RenderQuestion()
        Else
            RaiseEvent BackToMain()
        End If
    End Sub

    ' Method to calculate scores (shared with results form)
    Public Shared Sub CalculateScores(answers As Dictionary(Of Integer, Integer), ByRef hh As Integer, ByRef mach As Integer, ByRef narc As Integer, ByRef psych As Integer)
        Dim scores As New Dictionary(Of Dimension, Integer) From {
            {Dimension.HH, 0},
            {Dimension.Mach, 0},
            {Dimension.Narc, 0},
            {Dimension.Psych, 0}
        }

        For Each q As Question In questions
            Dim value As Integer = answers.GetValueOrDefault(q.id, 3)

            ' Reverse scoring for HH questions with Reverse flag
            If q.dimension = Dimension.HH AndAlso q.reverse Then value = 6 - value

            scores(q.dimension) += value
        Next q

        ' Convert to percentage (scale 1-5, total 10-50 per dimension)
        hh = CInt(Math.Round((scores(Dimension.HH) - 10) / 40.0 * 100))
        mach = CInt(Math.Round((scores(Dimension.Mach) - 10) / 40.0 * 100))
        narc = CInt(Math.Round((scores(Dimension.Narc) - 10) / 40.0 * 100))
        psych = CInt(Math.Round((scores(Dimension.Psych) - 10) / 40.0 * 100))

        ' Clamp values to 0-100 range
        hh = Math.Max(0, Math.Min(100, hh))
        mach = Math.Max(0, Math.Min(100, mach))
        narc = Math.Max(0, Math.Min(100, narc))
        psych = Math.Max(0, Math.Min(100, psych))
    End Sub
End Class
