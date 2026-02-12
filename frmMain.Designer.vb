<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        lblSubtitle = New Label()
        btnStart = New Button()
        lblDescription = New Label()
        lblTitle = New Label()
        lblBadge = New Label()
        SuspendLayout()
        ' 
        ' lblSubtitle
        ' 
        lblSubtitle.BackColor = Color.FromArgb(CByte(99), CByte(102), CByte(241))
        lblSubtitle.Font = New Font("Segoe UI", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblSubtitle.ForeColor = Color.FromArgb(CByte(233), CByte(213), CByte(255))
        lblSubtitle.Location = New Point(187, 140)
        lblSubtitle.Name = "lblSubtitle"
        lblSubtitle.Size = New Size(659, 30)
        lblSubtitle.TabIndex = 4
        lblSubtitle.Text = "Knowing your shadow is the beginning of self-integration"
        lblSubtitle.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' btnStart
        ' 
        btnStart.BackColor = Color.FromArgb(CByte(99), CByte(102), CByte(241))
        btnStart.FlatStyle = FlatStyle.Flat
        btnStart.Font = New Font("Segoe UI", 14.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnStart.ForeColor = Color.White
        btnStart.Location = New Point(349, 569)
        btnStart.Name = "btnStart"
        btnStart.Size = New Size(300, 50)
        btnStart.TabIndex = 3
        btnStart.Text = "Start Exploration"
        btnStart.UseVisualStyleBackColor = False
        ' 
        ' lblDescription
        ' 
        lblDescription.Font = New Font("Segoe UI", 14.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblDescription.ForeColor = Color.FromArgb(CByte(148), CByte(163), CByte(184))
        lblDescription.Location = New Point(50, 300)
        lblDescription.Name = "lblDescription"
        lblDescription.Size = New Size(900, 248)
        lblDescription.TabIndex = 2
        lblDescription.Text = resources.GetString("lblDescription.Text")
        lblDescription.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblTitle
        ' 
        lblTitle.Font = New Font("Georgia", 36.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTitle.ForeColor = Color.White
        lblTitle.Location = New Point(50, 200)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(900, 80)
        lblTitle.TabIndex = 1
        lblTitle.Text = "Light and Darkness"
        lblTitle.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblBadge
        ' 
        lblBadge.BackColor = Color.FromArgb(CByte(49), CByte(46), CByte(129))
        lblBadge.Font = New Font("Segoe UI", 11.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblBadge.ForeColor = Color.FromArgb(CByte(196), CByte(181), CByte(253))
        lblBadge.Location = New Point(187, 80)
        lblBadge.Name = "lblBadge"
        lblBadge.Size = New Size(659, 35)
        lblBadge.TabIndex = 0
        lblBadge.Text = "Self-Exploration Tool · 40-Question Deep Assessment"
        lblBadge.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' frmMain
        ' 
        AutoScaleDimensions = New SizeF(11.0F, 24.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(15), CByte(23), CByte(42))
        ClientSize = New Size(1000, 700)
        Controls.Add(lblSubtitle)
        Controls.Add(btnStart)
        Controls.Add(lblDescription)
        Controls.Add(lblTitle)
        Controls.Add(lblBadge)
        MaximumSize = New Size(1200, 900)
        MinimumSize = New Size(1000, 700)
        Name = "frmMain"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Light and Darkness - H-H & Dark Triad Scale"
        ResumeLayout(False)

    End Sub

    Friend WithEvents lblBadge As Label
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblDescription As Label
    Friend WithEvents btnStart As Button
    Friend WithEvents lblSubtitle As Label
End Class
