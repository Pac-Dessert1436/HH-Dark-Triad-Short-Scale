<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmQuestions
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
        lblDimensionIndicator = New Label()
        btnPrev = New Button()
        lblProgressText = New Label()
        ProgressPanel = New Panel()
        ProgressBar = New Panel()
        lblQuestionNumber = New Label()
        lblQuestionText = New Label()
        OptionsPanel = New FlowLayoutPanel()
        ProgressPanel.SuspendLayout()
        SuspendLayout()
        ' 
        ' lblDimensionIndicator
        ' 
        lblDimensionIndicator.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblDimensionIndicator.ForeColor = Color.FromArgb(CByte(196), CByte(181), CByte(253))
        lblDimensionIndicator.Location = New Point(499, 19)
        lblDimensionIndicator.Name = "lblDimensionIndicator"
        lblDimensionIndicator.Size = New Size(451, 30)
        lblDimensionIndicator.TabIndex = 6
        lblDimensionIndicator.Text = "Honesty-Humility Dimension"
        lblDimensionIndicator.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' btnPrev
        ' 
        btnPrev.BackColor = Color.Transparent
        btnPrev.FlatStyle = FlatStyle.Flat
        btnPrev.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnPrev.ForeColor = Color.FromArgb(CByte(148), CByte(163), CByte(184))
        btnPrev.Location = New Point(50, 580)
        btnPrev.Name = "btnPrev"
        btnPrev.Size = New Size(150, 40)
        btnPrev.TabIndex = 5
        btnPrev.Text = "← Previous"
        btnPrev.UseVisualStyleBackColor = False
        ' 
        ' lblProgressText
        ' 
        lblProgressText.Font = New Font("Segoe UI", 11.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblProgressText.ForeColor = Color.FromArgb(CByte(148), CByte(163), CByte(184))
        lblProgressText.Location = New Point(50, 20)
        lblProgressText.Name = "lblProgressText"
        lblProgressText.Size = New Size(200, 30)
        lblProgressText.TabIndex = 4
        lblProgressText.Text = "Question 1 / 40"
        ' 
        ' ProgressPanel
        ' 
        ProgressPanel.BackColor = Color.FromArgb(CByte(30), CByte(41), CByte(59))
        ProgressPanel.Controls.Add(ProgressBar)
        ProgressPanel.Location = New Point(50, 55)
        ProgressPanel.Name = "ProgressPanel"
        ProgressPanel.Size = New Size(900, 10)
        ProgressPanel.TabIndex = 3
        ' 
        ' ProgressBar
        ' 
        ProgressBar.BackColor = Color.Transparent
        ProgressBar.Location = New Point(0, 0)
        ProgressBar.Name = "ProgressBar"
        ProgressBar.Size = New Size(25, 10)
        ProgressBar.TabIndex = 0
        ' 
        ' lblQuestionNumber
        ' 
        lblQuestionNumber.Font = New Font("Segoe UI", 48.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblQuestionNumber.ForeColor = Color.FromArgb(CByte(30), CByte(41), CByte(59))
        lblQuestionNumber.Location = New Point(0, 120)
        lblQuestionNumber.Name = "lblQuestionNumber"
        lblQuestionNumber.Size = New Size(174, 122)
        lblQuestionNumber.TabIndex = 2
        lblQuestionNumber.Text = "01"
        ' 
        ' lblQuestionText
        ' 
        lblQuestionText.Font = New Font("Georgia", 22.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblQuestionText.ForeColor = Color.White
        lblQuestionText.Location = New Point(180, 120)
        lblQuestionText.Name = "lblQuestionText"
        lblQuestionText.Size = New Size(770, 143)
        lblQuestionText.TabIndex = 1
        lblQuestionText.Text = "Loading..."
        ' 
        ' OptionsPanel
        ' 
        OptionsPanel.FlowDirection = FlowDirection.TopDown
        OptionsPanel.Location = New Point(50, 266)
        OptionsPanel.Name = "OptionsPanel"
        OptionsPanel.Size = New Size(900, 301)
        OptionsPanel.TabIndex = 0
        ' 
        ' frmQuestions
        ' 
        AutoScaleDimensions = New SizeF(11.0F, 24.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(15), CByte(23), CByte(42))
        ClientSize = New Size(1000, 700)
        Controls.Add(lblDimensionIndicator)
        Controls.Add(btnPrev)
        Controls.Add(lblProgressText)
        Controls.Add(ProgressPanel)
        Controls.Add(lblQuestionNumber)
        Controls.Add(lblQuestionText)
        Controls.Add(OptionsPanel)
        MaximumSize = New Size(1200, 900)
        MinimumSize = New Size(1000, 700)
        Name = "frmQuestions"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Questions - Light and Darkness"
        ProgressPanel.ResumeLayout(False)
        ResumeLayout(False)

    End Sub

    Friend WithEvents lblDimensionIndicator As Label
    Friend WithEvents btnPrev As Button
    Friend WithEvents lblProgressText As Label
    Friend WithEvents ProgressPanel As Panel
    Friend WithEvents ProgressBar As Panel
    Friend WithEvents lblQuestionNumber As Label
    Friend WithEvents lblQuestionText As Label
    Friend WithEvents OptionsPanel As FlowLayoutPanel
End Class
