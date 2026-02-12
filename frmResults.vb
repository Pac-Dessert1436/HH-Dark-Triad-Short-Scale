#Disable Warning IDE1006
Imports System.Drawing.Drawing2D

Public Class frmResults
    Private hh As Integer, mach As Integer, narc As Integer, psych As Integer

    ' Event for when user wants to retake test
    Public Event RetakeTest()

    Private Sub frmResults_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Add event handlers
        AddHandler btnRestart.Click, AddressOf RetakeTestHandler
        AddHandler btnPrint.Click, AddressOf PrintResults
        AddHandler RadarPanel.Paint, AddressOf RadarPanel_Paint

        ' Initialize print components
        PrintDialog1 = New PrintDialog()
        PrintDocument1 = New Printing.PrintDocument()
    End Sub

    Public Sub DisplayResults(answers As Dictionary(Of Integer, Integer))
        ' Calculate scores using the shared method from frmQuestions
        frmQuestions.CalculateScores(answers, hh, mach, narc, psych)

        ' Update score displays
        lblHHScore.Text = hh & "%"
        lblMachScore.Text = mach & "%"
        lblNarcScore.Text = narc & "%"
        lblPsychScore.Text = psych & "%"

        ' Update descriptions
        lblHHDesc.Text = GetDescription(Dimension.HH, hh)
        lblMachDesc.Text = GetDescription(Dimension.Mach, mach)
        lblNarcDesc.Text = GetDescription(Dimension.Narc, narc)
        lblPsychDesc.Text = GetDescription(Dimension.Psych, psych)

        ' Animate score bars
        AnimateScoreBar(HHBar, lblHHBarBg.Width, hh)
        AnimateScoreBar(MachBar, lblMachBarBg.Width, mach)
        AnimateScoreBar(NarcBar, lblNarcBarBg.Width, narc)
        AnimateScoreBar(PsychBar, lblPsychBarBg.Width, psych)

        ' Generate analysis
        GenerateAnalysis(hh, mach, narc, psych)

        ' Draw radar chart
        RadarPanel.Invalidate()
    End Sub

    Private Function GetDescription(dimension As Dimension, score As Integer) As String
        Select Case dimension
            Case Dimension.HH
                If score > 70 Then Return "You maintain a rare sincerity and simplicity, disliking hypocrisy and calculation."
                If score > 40 Then Return "You maintain a balance between honesty and utilitarianism."
                Return "You may need to be vigilant against utilitarian tendencies and return to intrinsic values."
            Case Dimension.Mach
                If score < 30 Then Return "You tend to interact directly and sincerely, disliking manipulation and control."
                If score < 60 Then Return "You have some strategic thinking, but still maintain moral boundaries."
                Return "You possess highly strategic thinking, skilled at long-term planning and manipulating people."
            Case Dimension.Narc
                If score < 30 Then Return "You are humble and unassuming, not seeking special attention."
                If score < 60 Then Return "You have healthy self-esteem and occasionally enjoy recognition."
                Return "You have a strong sense of superiority and desire for power and admiration."
            Case Dimension.Psych
                If score < 30 Then Return "You are emotionally rich, have strong empathy, and value moral constraints."
                If score < 60 Then Return "You are rational and calm, but still have emotional fluctuations at critical moments."
                Return "You are extremely rational and calm, emotionally detached, fearless and unbound by rules."
            Case Else
                Return ""
        End Select
    End Function

    Private Sub AnimateScoreBar(bar As Panel, maxWidth As Integer, targetPercentage As Integer)
        Dim timer As New Timer()
        Dim currentWidth As Integer = 0
        Dim targetWidth As Integer = CInt(maxWidth * targetPercentage / 100.0)

        timer.Interval = 15
        AddHandler timer.Tick, Sub()
                                   If currentWidth < targetWidth Then
                                       currentWidth += CInt((targetWidth - currentWidth) * 0.1 + 1)
                                       If currentWidth > targetWidth Then currentWidth = targetWidth
                                       bar.Width = currentWidth
                                   Else
                                       timer.Stop()
                                       timer.Dispose()
                                   End If
                               End Sub
        timer.Start()
    End Sub

    Private Sub GenerateAnalysis(hh As Integer, mach As Integer, narc As Integer, psych As Integer)
        Dim darkTotal As Integer = mach + narc + psych
        Dim lightScore As Integer = hh
        Dim darkAvg As Integer = CInt(Math.Round(darkTotal / 3.0))

        Dim analysis As String = "Spectrum Interpretation:" & vbCrLf & vbCrLf
        Dim profileType As String
        Dim profileDesc As String

        ' Determine profile type
        If lightScore > 60 AndAlso darkAvg < 40 Then
            profileType = "Light Guardian"
            profileDesc = "Your personality spectrum clearly leans toward the light side. High honesty-humility combined with low dark traits indicates you are a sincere, morally grounded, and empathetic person. You dislike manipulation and hypocrisy, pursuing intrinsic value rather than external power."
        ElseIf lightScore < 40 AndAlso darkAvg > 60 Then
            profileType = "Dark Strategist"
            profileDesc = "Your personality spectrum significantly leans toward the dark side. Low honesty-humility combined with high dark triad traits indicates you possess highly strategic, self-centered, and emotionally detached qualities. You are skilled at manipulation, unbound by morality, and pursue maximum personal benefit."
        ElseIf mach > narc AndAlso mach > psych Then
            profileType = "Cold Calculator"
            profileDesc = "Your dominant trait is Machiavellianism. You think like a chess player, valuing long-term planning and manipulating people, but not necessarily seeking glory in the spotlight. You are a behind-the-scenes operator, rational and patient."
        ElseIf narc > mach AndAlso narc > psych Then
            profileType = "Charismatic Leader"
            profileDesc = "Your dominant trait is narcissism. You desire admiration, believe you are special, and enjoy the pleasure of power. You may be a natural leader, but need to be vigilant against excessive self-centeredness."
        ElseIf psych > mach AndAlso psych > narc Then
            profileType = "Fearless Adventurer"
            profileDesc = "Your dominant trait is psychopathy. You are calm, fearless, unbound by rules, and possess extremely high stress tolerance. In crises, you are a calm decision-maker, but may lack emotional resonance."
        Else
            profileType = "Balanced Polymath"
            profileDesc = "Your personality traits are relatively balanced, with no obvious extreme tendencies. You can maintain basic moral boundaries while also possessing certain strategic thinking and self-assertion. This balance makes you adaptable, but you may lack a distinct personal style."
        End If

        analysis &= profileType & vbCrLf & profileDesc & vbCrLf & vbCrLf

        ' Sub-trait insights
        analysis &= "Sub-dimension Insights:" & vbCrLf
        If hh > 70 Then analysis &= "• You value sincerity and dislike greed and deception" & vbCrLf
        If mach > 60 Then analysis &= "• You excel at strategic thinking and long-term planning" & vbCrLf
        If narc > 60 Then analysis &= "• You have a strong self-improvement motivation" & vbCrLf
        If psych > 60 Then analysis &= "• You possess emotional detachment ability, not easily overwhelmed by pressure" & vbCrLf
        If hh < 40 Then analysis &= "• You may need to be vigilant against the risk of being used by others" & vbCrLf

        lblAnalysis.Text = analysis
    End Sub

    Private Sub RadarPanel_Paint(sender As Object, e As PaintEventArgs)
        Dim g As Graphics = e.Graphics
        g.SmoothingMode = SmoothingMode.AntiAlias

        Dim width As Integer = RadarPanel.Width
        Dim height As Integer = RadarPanel.Height
        Dim centerX As Integer = width \ 2
        Dim centerY As Integer = height \ 2 + 10
        Dim radius As Integer = Math.Min(width, height) \ 2 - 50

        ' Colors for each dimension
        Dim colors As Color() = {
            Color.FromArgb(52, 211, 153),  ' HH - emerald
            Color.FromArgb(239, 68, 68),   ' Mach - red
            Color.FromArgb(245, 158, 11),  ' Narc - amber
            Color.FromArgb(168, 85, 247)   ' Psych - purple
        }

        Dim labels = {"Honesty-Humility (Light)", "Machiavellianism", "Narcissism", "Psychopathy"}
        Dim scores As Integer() = {hh, mach, narc, psych}

        ' Draw grid
        Using gridPen As New Pen(Color.FromArgb(255, 255, 255, 40))
            For i As Integer = 1 To 5
                Dim gridRadius As Integer = radius * i \ 5
                g.DrawEllipse(gridPen, centerX - gridRadius, centerY - gridRadius, gridRadius * 2, gridRadius * 2)
            Next i
        End Using

        ' Draw axes
        Using axisPen As New Pen(Color.FromArgb(255, 255, 255, 60))
            For i As Integer = 0 To 3
                Dim angle As Double = (Math.PI * 2 * i) / 4 - Math.PI / 2
                Dim x As Integer = centerX + CInt(Math.Cos(angle) * radius)
                Dim y As Integer = centerY + CInt(Math.Sin(angle) * radius)
                g.DrawLine(axisPen, centerX, centerY, x, y)
            Next
        End Using

        ' Draw labels
        Dim labelFont As New Font("Segoe UI", 10.0F, FontStyle.Bold)
        For i As Integer = 0 To 3
            Dim angle As Double = (Math.PI * 2 * i) / 4 - Math.PI / 2
            Dim labelRadius As Integer = radius + 30
            Dim x As Integer = centerX + CInt(Math.Cos(angle) * labelRadius)
            Dim y As Integer = centerY + CInt(Math.Sin(angle) * labelRadius)

            Dim textSize As SizeF = g.MeasureString(labels(i), labelFont)
            g.DrawString(labels(i), labelFont, New SolidBrush(colors(i)), x - textSize.Width / 2, y - textSize.Height / 2)
        Next

        ' Draw data polygon
        Dim points As New List(Of PointF)()
        For i As Integer = 0 To 3
            Dim angle As Double = (Math.PI * 2 * i) / 4 - Math.PI / 2
            Dim value As Single = scores(i) / 100.0F
            Dim x As Single = centerX + CSng(Math.Cos(angle)) * radius * value
            Dim y As Single = centerY + CSng(Math.Sin(angle)) * radius * value
            points.Add(New PointF(x, y))
        Next

        ' Fill polygon
        Using fillBrush As New SolidBrush(Color.FromArgb(168, 85, 247, 80))
            g.FillPolygon(fillBrush, points.ToArray())
        End Using

        ' Draw polygon outline
        Using outlinePen As New Pen(Color.FromArgb(168, 85, 247), 2)
            g.DrawPolygon(outlinePen, points.ToArray())
        End Using

        ' Draw data points
        For i As Integer = 0 To 3
            Using pointBrush As New SolidBrush(colors(i))
                g.FillEllipse(pointBrush, points(i).X - 6, points(i).Y - 6, 12, 12)
            End Using
            Using outlinePen As New Pen(Color.White, 2)
                g.DrawEllipse(outlinePen, points(i).X - 6, points(i).Y - 6, 12, 12)
            End Using

            ' Draw score values
            Dim scoreFont As New Font("Segoe UI", 9.0F, FontStyle.Bold)
            Dim angle As Double = (Math.PI * 2 * i) / 4 - Math.PI / 2
            Dim valueLabelX As Single = points(i).X + CSng(Math.Cos(angle)) * 20
            Dim valueLabelY As Single = points(i).Y + CSng(Math.Sin(angle)) * 20
            g.DrawString(scores(i) & "%", scoreFont, Brushes.White, valueLabelX, valueLabelY)
        Next

        labelFont.Dispose()
    End Sub

    Private Sub RetakeTestHandler(sender As Object, e As EventArgs)
        RaiseEvent RetakeTest()
        Close()
    End Sub

    Private Sub PrintResults(sender As Object, e As EventArgs)
        PrintDialog1.Document = PrintDocument1
        If PrintDialog1.ShowDialog() = DialogResult.OK Then
            PrintDocument1.Print()
        End If
    End Sub
End Class
