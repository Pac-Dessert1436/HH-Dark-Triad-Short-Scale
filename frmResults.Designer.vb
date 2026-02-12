<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmResults
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        btnRestart = New Button()
        btnPrint = New Button()
        lblAnalysis = New Label()
        lblPsychDesc = New Label()
        lblPsychScore = New Label()
        lblPsychBarBg = New Panel()
        PsychBar = New Panel()
        lblNarcDesc = New Label()
        lblNarcScore = New Label()
        lblNarcBarBg = New Panel()
        NarcBar = New Panel()
        lblMachDesc = New Label()
        lblMachScore = New Label()
        lblMachBarBg = New Panel()
        MachBar = New Panel()
        lblHHDesc = New Label()
        lblHHScore = New Label()
        lblHHBarBg = New Panel()
        HHBar = New Panel()
        lblResultTitle = New Label()
        lblPsychLabel = New Label()
        lblNarcLabel = New Label()
        lblMachLabel = New Label()
        lblHHLabel = New Label()
        RadarPanel = New Panel()
        lblPsychBarBg.SuspendLayout()
        lblNarcBarBg.SuspendLayout()
        lblMachBarBg.SuspendLayout()
        lblHHBarBg.SuspendLayout()
        SuspendLayout()
        ' 
        ' btnRestart
        ' 
        btnRestart.BackColor = Color.FromArgb(CByte(51), CByte(65), CByte(85))
        btnRestart.FlatStyle = FlatStyle.Flat
        btnRestart.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnRestart.ForeColor = Color.White
        btnRestart.Location = New Point(350, 1150)
        btnRestart.Name = "btnRestart"
        btnRestart.Size = New Size(150, 45)
        btnRestart.TabIndex = 20
        btnRestart.Text = "Retake Test"
        btnRestart.UseVisualStyleBackColor = False
        ' 
        ' btnPrint
        ' 
        btnPrint.BackColor = Color.FromArgb(CByte(99), CByte(102), CByte(241))
        btnPrint.FlatStyle = FlatStyle.Flat
        btnPrint.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnPrint.ForeColor = Color.White
        btnPrint.Location = New Point(520, 1150)
        btnPrint.Name = "btnPrint"
        btnPrint.Size = New Size(150, 45)
        btnPrint.TabIndex = 19
        btnPrint.Text = "Save Results"
        btnPrint.UseVisualStyleBackColor = False
        ' 
        ' lblAnalysis
        ' 
        lblAnalysis.Font = New Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblAnalysis.ForeColor = Color.FromArgb(CByte(203), CByte(213), CByte(225))
        lblAnalysis.Location = New Point(50, 769)
        lblAnalysis.Name = "lblAnalysis"
        lblAnalysis.Size = New Size(900, 336)
        lblAnalysis.TabIndex = 18
        ' 
        ' lblPsychDesc
        ' 
        lblPsychDesc.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblPsychDesc.ForeColor = Color.FromArgb(CByte(148), CByte(163), CByte(184))
        lblPsychDesc.Location = New Point(520, 655)
        lblPsychDesc.Name = "lblPsychDesc"
        lblPsychDesc.Size = New Size(430, 100)
        lblPsychDesc.TabIndex = 17
        ' 
        ' lblPsychScore
        ' 
        lblPsychScore.Font = New Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblPsychScore.ForeColor = Color.FromArgb(CByte(168), CByte(85), CByte(247))
        lblPsychScore.Location = New Point(830, 575)
        lblPsychScore.Name = "lblPsychScore"
        lblPsychScore.Size = New Size(120, 60)
        lblPsychScore.TabIndex = 16
        lblPsychScore.Text = "0%"
        lblPsychScore.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' lblPsychBarBg
        ' 
        lblPsychBarBg.BackColor = Color.FromArgb(CByte(30), CByte(41), CByte(59))
        lblPsychBarBg.Controls.Add(PsychBar)
        lblPsychBarBg.Location = New Point(520, 635)
        lblPsychBarBg.Name = "lblPsychBarBg"
        lblPsychBarBg.Size = New Size(430, 12)
        lblPsychBarBg.TabIndex = 15
        ' 
        ' PsychBar
        ' 
        PsychBar.BackColor = Color.FromArgb(CByte(147), CByte(51), CByte(234))
        PsychBar.Location = New Point(0, 0)
        PsychBar.Name = "PsychBar"
        PsychBar.Size = New Size(0, 12)
        PsychBar.TabIndex = 0
        ' 
        ' lblNarcDesc
        ' 
        lblNarcDesc.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblNarcDesc.ForeColor = Color.FromArgb(CByte(148), CByte(163), CByte(184))
        lblNarcDesc.Location = New Point(520, 484)
        lblNarcDesc.Name = "lblNarcDesc"
        lblNarcDesc.Size = New Size(430, 80)
        lblNarcDesc.TabIndex = 14
        ' 
        ' lblNarcScore
        ' 
        lblNarcScore.Font = New Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblNarcScore.ForeColor = Color.FromArgb(CByte(245), CByte(158), CByte(11))
        lblNarcScore.Location = New Point(830, 390)
        lblNarcScore.Name = "lblNarcScore"
        lblNarcScore.Size = New Size(120, 60)
        lblNarcScore.TabIndex = 13
        lblNarcScore.Text = "0%"
        lblNarcScore.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' lblNarcBarBg
        ' 
        lblNarcBarBg.BackColor = Color.FromArgb(CByte(30), CByte(41), CByte(59))
        lblNarcBarBg.Controls.Add(NarcBar)
        lblNarcBarBg.Location = New Point(520, 453)
        lblNarcBarBg.Name = "lblNarcBarBg"
        lblNarcBarBg.Size = New Size(430, 12)
        lblNarcBarBg.TabIndex = 12
        ' 
        ' NarcBar
        ' 
        NarcBar.BackColor = Color.FromArgb(CByte(251), CByte(191), CByte(36))
        NarcBar.Location = New Point(0, 0)
        NarcBar.Name = "NarcBar"
        NarcBar.Size = New Size(0, 12)
        NarcBar.TabIndex = 0
        ' 
        ' lblMachDesc
        ' 
        lblMachDesc.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblMachDesc.ForeColor = Color.FromArgb(CByte(148), CByte(163), CByte(184))
        lblMachDesc.Location = New Point(50, 655)
        lblMachDesc.Name = "lblMachDesc"
        lblMachDesc.Size = New Size(430, 100)
        lblMachDesc.TabIndex = 11
        ' 
        ' lblMachScore
        ' 
        lblMachScore.Font = New Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblMachScore.ForeColor = Color.FromArgb(CByte(239), CByte(68), CByte(68))
        lblMachScore.Location = New Point(373, 575)
        lblMachScore.Name = "lblMachScore"
        lblMachScore.Size = New Size(120, 60)
        lblMachScore.TabIndex = 10
        lblMachScore.Text = "0%"
        lblMachScore.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' lblMachBarBg
        ' 
        lblMachBarBg.BackColor = Color.FromArgb(CByte(30), CByte(41), CByte(59))
        lblMachBarBg.Controls.Add(MachBar)
        lblMachBarBg.Location = New Point(50, 635)
        lblMachBarBg.Name = "lblMachBarBg"
        lblMachBarBg.Size = New Size(430, 12)
        lblMachBarBg.TabIndex = 9
        ' 
        ' MachBar
        ' 
        MachBar.BackColor = Color.FromArgb(CByte(220), CByte(38), CByte(38))
        MachBar.Location = New Point(0, 0)
        MachBar.Name = "MachBar"
        MachBar.Size = New Size(0, 12)
        MachBar.TabIndex = 0
        ' 
        ' lblHHDesc
        ' 
        lblHHDesc.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblHHDesc.ForeColor = Color.FromArgb(CByte(148), CByte(163), CByte(184))
        lblHHDesc.Location = New Point(50, 484)
        lblHHDesc.Name = "lblHHDesc"
        lblHHDesc.Size = New Size(430, 80)
        lblHHDesc.TabIndex = 8
        ' 
        ' lblHHScore
        ' 
        lblHHScore.Font = New Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblHHScore.ForeColor = Color.FromArgb(CByte(52), CByte(211), CByte(153))
        lblHHScore.Location = New Point(373, 390)
        lblHHScore.Name = "lblHHScore"
        lblHHScore.Size = New Size(120, 60)
        lblHHScore.TabIndex = 7
        lblHHScore.Text = "0%"
        lblHHScore.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' lblHHBarBg
        ' 
        lblHHBarBg.BackColor = Color.FromArgb(CByte(30), CByte(41), CByte(59))
        lblHHBarBg.Controls.Add(HHBar)
        lblHHBarBg.Location = New Point(50, 453)
        lblHHBarBg.Name = "lblHHBarBg"
        lblHHBarBg.Size = New Size(430, 12)
        lblHHBarBg.TabIndex = 6
        ' 
        ' HHBar
        ' 
        HHBar.BackColor = Color.FromArgb(CByte(16), CByte(185), CByte(129))
        HHBar.Location = New Point(0, 0)
        HHBar.Name = "HHBar"
        HHBar.Size = New Size(0, 12)
        HHBar.TabIndex = 0
        ' 
        ' lblResultTitle
        ' 
        lblResultTitle.Font = New Font("Georgia", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblResultTitle.ForeColor = Color.White
        lblResultTitle.Location = New Point(12, 23)
        lblResultTitle.Name = "lblResultTitle"
        lblResultTitle.Size = New Size(938, 67)
        lblResultTitle.TabIndex = 5
        lblResultTitle.Text = "Your Personality Spectrum Profile"
        lblResultTitle.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblPsychLabel
        ' 
        lblPsychLabel.Font = New Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblPsychLabel.ForeColor = Color.FromArgb(CByte(168), CByte(85), CByte(247))
        lblPsychLabel.Location = New Point(520, 590)
        lblPsychLabel.Name = "lblPsychLabel"
        lblPsychLabel.Size = New Size(430, 40)
        lblPsychLabel.TabIndex = 4
        lblPsychLabel.Text = "● Psychopathy"
        ' 
        ' lblNarcLabel
        ' 
        lblNarcLabel.Font = New Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblNarcLabel.ForeColor = Color.FromArgb(CByte(245), CByte(158), CByte(11))
        lblNarcLabel.Location = New Point(520, 400)
        lblNarcLabel.Name = "lblNarcLabel"
        lblNarcLabel.Size = New Size(430, 50)
        lblNarcLabel.TabIndex = 3
        lblNarcLabel.Text = "● Narcissism"
        ' 
        ' lblMachLabel
        ' 
        lblMachLabel.Font = New Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblMachLabel.ForeColor = Color.FromArgb(CByte(239), CByte(68), CByte(68))
        lblMachLabel.Location = New Point(50, 587)
        lblMachLabel.Name = "lblMachLabel"
        lblMachLabel.Size = New Size(430, 45)
        lblMachLabel.TabIndex = 2
        lblMachLabel.Text = "● Machiavellianism"
        ' 
        ' lblHHLabel
        ' 
        lblHHLabel.Font = New Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblHHLabel.ForeColor = Color.FromArgb(CByte(52), CByte(211), CByte(153))
        lblHHLabel.Location = New Point(50, 400)
        lblHHLabel.Name = "lblHHLabel"
        lblHHLabel.Size = New Size(430, 50)
        lblHHLabel.TabIndex = 1
        lblHHLabel.Text = "● Honesty-Humility"
        ' 
        ' RadarPanel
        ' 
        RadarPanel.BackColor = Color.FromArgb(CByte(30), CByte(41), CByte(59))
        RadarPanel.Location = New Point(221, 110)
        RadarPanel.Name = "RadarPanel"
        RadarPanel.Size = New Size(573, 270)
        RadarPanel.TabIndex = 0
        ' 
        ' frmResults
        ' 
        AutoScaleDimensions = New SizeF(11F, 24F)
        AutoScaleMode = AutoScaleMode.Font
        AutoScroll = True
        BackColor = Color.FromArgb(CByte(15), CByte(23), CByte(42))
        ClientSize = New Size(1000, 700)
        Controls.Add(btnRestart)
        Controls.Add(btnPrint)
        Controls.Add(lblAnalysis)
        Controls.Add(lblPsychDesc)
        Controls.Add(lblPsychScore)
        Controls.Add(lblPsychBarBg)
        Controls.Add(lblNarcDesc)
        Controls.Add(lblNarcScore)
        Controls.Add(lblNarcBarBg)
        Controls.Add(lblMachDesc)
        Controls.Add(lblMachScore)
        Controls.Add(lblMachBarBg)
        Controls.Add(lblHHDesc)
        Controls.Add(lblHHScore)
        Controls.Add(lblHHBarBg)
        Controls.Add(lblResultTitle)
        Controls.Add(lblPsychLabel)
        Controls.Add(lblNarcLabel)
        Controls.Add(lblMachLabel)
        Controls.Add(lblHHLabel)
        Controls.Add(RadarPanel)
        MaximumSize = New Size(1200, 900)
        MinimumSize = New Size(1000, 700)
        Name = "frmResults"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Results - Light and Darkness"
        lblPsychBarBg.ResumeLayout(False)
        lblNarcBarBg.ResumeLayout(False)
        lblMachBarBg.ResumeLayout(False)
        lblHHBarBg.ResumeLayout(False)
        ResumeLayout(False)

    End Sub

    Friend WithEvents btnRestart As Button
    Friend WithEvents btnPrint As Button
    Friend WithEvents lblAnalysis As Label
    Friend WithEvents lblPsychDesc As Label
    Friend WithEvents lblPsychScore As Label
    Friend WithEvents lblPsychBarBg As Panel
    Friend WithEvents PsychBar As Panel
    Friend WithEvents lblNarcDesc As Label
    Friend WithEvents lblNarcScore As Label
    Friend WithEvents lblNarcBarBg As Panel
    Friend WithEvents NarcBar As Panel
    Friend WithEvents lblMachDesc As Label
    Friend WithEvents lblMachScore As Label
    Friend WithEvents lblMachBarBg As Panel
    Friend WithEvents MachBar As Panel
    Friend WithEvents lblHHDesc As Label
    Friend WithEvents lblHHScore As Label
    Friend WithEvents lblHHBarBg As Panel
    Friend WithEvents HHBar As Panel
    Friend WithEvents lblResultTitle As Label
    Friend WithEvents lblPsychLabel As Label
    Friend WithEvents lblNarcLabel As Label
    Friend WithEvents lblMachLabel As Label
    Friend WithEvents lblHHLabel As Label
    Friend WithEvents RadarPanel As Panel
    Friend WithEvents PrintDialog1 As PrintDialog
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
End Class
