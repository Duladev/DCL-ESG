<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmDashboard
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDashboard))
        LabelTitle = New Label()
        PictureBoxLogo = New PictureBox()
        BtnREPORTS = New Button()
        BtnSOCIAL = New Button()
        BtnWASTE_MANAGEMENT = New Button()
        BtnINVENTORY = New Button()
        BtnEMP_Details = New Button()
        BtnCSR = New Button()
        PanelMainContent = New Panel()
        TimerDateTime = New Timer(components)
        CType(PictureBoxLogo, ComponentModel.ISupportInitialize).BeginInit()
        PanelMainContent.SuspendLayout()
        SuspendLayout()
        ' 
        ' LabelTitle
        ' 
        LabelTitle.AutoSize = True
        LabelTitle.BackColor = Color.Transparent
        LabelTitle.FlatStyle = FlatStyle.Flat
        LabelTitle.Font = New Font("Segoe UI", 24F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        LabelTitle.ForeColor = Color.Transparent
        LabelTitle.Location = New Point(229, 17)
        LabelTitle.Name = "LabelTitle"
        LabelTitle.Size = New Size(457, 45)
        LabelTitle.TabIndex = 2
        LabelTitle.Text = "ESG Management Dashboard"
        ' 
        ' PictureBoxLogo
        ' 
        PictureBoxLogo.BackColor = Color.Transparent
        PictureBoxLogo.BackgroundImage = CType(resources.GetObject("PictureBoxLogo.BackgroundImage"), Image)
        PictureBoxLogo.BackgroundImageLayout = ImageLayout.Stretch
        PictureBoxLogo.InitialImage = CType(resources.GetObject("PictureBoxLogo.InitialImage"), Image)
        PictureBoxLogo.Location = New Point(117, 9)
        PictureBoxLogo.Name = "PictureBoxLogo"
        PictureBoxLogo.Size = New Size(77, 53)
        PictureBoxLogo.SizeMode = PictureBoxSizeMode.Zoom
        PictureBoxLogo.TabIndex = 0
        PictureBoxLogo.TabStop = False
        ' 
        ' BtnREPORTS
        ' 
        BtnREPORTS.BackColor = Color.Transparent
        BtnREPORTS.FlatAppearance.BorderSize = 0
        BtnREPORTS.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(60), CByte(90), CByte(120))
        BtnREPORTS.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(50), CByte(80), CByte(110))
        BtnREPORTS.FlatStyle = FlatStyle.Flat
        BtnREPORTS.Font = New Font("Segoe UI Black", 20.25F, FontStyle.Bold Or FontStyle.Italic)
        BtnREPORTS.ForeColor = Color.White
        BtnREPORTS.Location = New Point(40, 431)
        BtnREPORTS.Name = "BtnREPORTS"
        BtnREPORTS.Size = New Size(230, 50)
        BtnREPORTS.TabIndex = 11
        BtnREPORTS.Text = "   Reports"
        BtnREPORTS.TextImageRelation = TextImageRelation.TextAboveImage
        BtnREPORTS.UseVisualStyleBackColor = False
        ' 
        ' BtnSOCIAL
        ' 
        BtnSOCIAL.BackColor = Color.Transparent
        BtnSOCIAL.FlatAppearance.BorderSize = 0
        BtnSOCIAL.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(60), CByte(90), CByte(120))
        BtnSOCIAL.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(50), CByte(80), CByte(110))
        BtnSOCIAL.FlatStyle = FlatStyle.Flat
        BtnSOCIAL.Font = New Font("Segoe UI Black", 20.25F, FontStyle.Bold Or FontStyle.Italic)
        BtnSOCIAL.ForeColor = Color.White
        BtnSOCIAL.Location = New Point(40, 361)
        BtnSOCIAL.Name = "BtnSOCIAL"
        BtnSOCIAL.Size = New Size(230, 50)
        BtnSOCIAL.TabIndex = 10
        BtnSOCIAL.Text = "   Social"
        BtnSOCIAL.TextImageRelation = TextImageRelation.TextAboveImage
        BtnSOCIAL.UseVisualStyleBackColor = False
        ' 
        ' BtnWASTE_MANAGEMENT
        ' 
        BtnWASTE_MANAGEMENT.BackColor = Color.Transparent
        BtnWASTE_MANAGEMENT.FlatAppearance.BorderSize = 0
        BtnWASTE_MANAGEMENT.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(60), CByte(90), CByte(120))
        BtnWASTE_MANAGEMENT.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(50), CByte(80), CByte(110))
        BtnWASTE_MANAGEMENT.FlatStyle = FlatStyle.Flat
        BtnWASTE_MANAGEMENT.Font = New Font("Segoe UI Black", 20.25F, FontStyle.Bold Or FontStyle.Italic)
        BtnWASTE_MANAGEMENT.ForeColor = Color.White
        BtnWASTE_MANAGEMENT.Location = New Point(-2, 305)
        BtnWASTE_MANAGEMENT.Name = "BtnWASTE_MANAGEMENT"
        BtnWASTE_MANAGEMENT.Size = New Size(325, 50)
        BtnWASTE_MANAGEMENT.TabIndex = 9
        BtnWASTE_MANAGEMENT.Text = "   Waste Management"
        BtnWASTE_MANAGEMENT.TextImageRelation = TextImageRelation.TextAboveImage
        BtnWASTE_MANAGEMENT.UseVisualStyleBackColor = False
        ' 
        ' BtnINVENTORY
        ' 
        BtnINVENTORY.BackColor = Color.Transparent
        BtnINVENTORY.FlatAppearance.BorderSize = 0
        BtnINVENTORY.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(60), CByte(90), CByte(120))
        BtnINVENTORY.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(50), CByte(80), CByte(110))
        BtnINVENTORY.FlatStyle = FlatStyle.Flat
        BtnINVENTORY.Font = New Font("Segoe UI Black", 20.25F, FontStyle.Bold Or FontStyle.Italic)
        BtnINVENTORY.ForeColor = Color.White
        BtnINVENTORY.Location = New Point(40, 241)
        BtnINVENTORY.Name = "BtnINVENTORY"
        BtnINVENTORY.Size = New Size(230, 50)
        BtnINVENTORY.TabIndex = 8
        BtnINVENTORY.Text = "   Inventory"
        BtnINVENTORY.TextImageRelation = TextImageRelation.TextAboveImage
        BtnINVENTORY.UseVisualStyleBackColor = False
        ' 
        ' BtnEMP_Details
        ' 
        BtnEMP_Details.BackColor = Color.Transparent
        BtnEMP_Details.FlatAppearance.BorderSize = 0
        BtnEMP_Details.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(60), CByte(90), CByte(120))
        BtnEMP_Details.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(50), CByte(80), CByte(110))
        BtnEMP_Details.FlatStyle = FlatStyle.Flat
        BtnEMP_Details.Font = New Font("Segoe UI Black", 20.25F, FontStyle.Bold Or FontStyle.Italic)
        BtnEMP_Details.ForeColor = Color.White
        BtnEMP_Details.Location = New Point(40, 185)
        BtnEMP_Details.Name = "BtnEMP_Details"
        BtnEMP_Details.Size = New Size(230, 50)
        BtnEMP_Details.TabIndex = 7
        BtnEMP_Details.Text = "   Employee Details"
        BtnEMP_Details.TextImageRelation = TextImageRelation.TextAboveImage
        BtnEMP_Details.UseVisualStyleBackColor = False
        ' 
        ' BtnCSR
        ' 
        BtnCSR.BackColor = Color.Transparent
        BtnCSR.FlatAppearance.BorderSize = 0
        BtnCSR.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(60), CByte(90), CByte(120))
        BtnCSR.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(50), CByte(80), CByte(110))
        BtnCSR.FlatStyle = FlatStyle.Flat
        BtnCSR.Font = New Font("Segoe UI Black", 20.25F, FontStyle.Bold Or FontStyle.Italic)
        BtnCSR.ForeColor = Color.White
        BtnCSR.Location = New Point(40, 129)
        BtnCSR.Name = "BtnCSR"
        BtnCSR.Size = New Size(230, 50)
        BtnCSR.TabIndex = 6
        BtnCSR.Text = "   CSR"
        BtnCSR.TextImageRelation = TextImageRelation.TextAboveImage
        BtnCSR.UseVisualStyleBackColor = False
        ' 
        ' PanelMainContent
        ' 
        PanelMainContent.AutoSizeMode = AutoSizeMode.GrowAndShrink
        PanelMainContent.BackColor = Color.FromArgb(CByte(245), CByte(245), CByte(250))
        PanelMainContent.BackgroundImage = CType(resources.GetObject("PanelMainContent.BackgroundImage"), Image)
        PanelMainContent.BackgroundImageLayout = ImageLayout.Stretch
        PanelMainContent.Controls.Add(PictureBoxLogo)
        PanelMainContent.Controls.Add(LabelTitle)
        PanelMainContent.Controls.Add(BtnREPORTS)
        PanelMainContent.Controls.Add(BtnSOCIAL)
        PanelMainContent.Controls.Add(BtnCSR)
        PanelMainContent.Controls.Add(BtnWASTE_MANAGEMENT)
        PanelMainContent.Controls.Add(BtnEMP_Details)
        PanelMainContent.Controls.Add(BtnINVENTORY)
        PanelMainContent.Dock = DockStyle.Fill
        PanelMainContent.Location = New Point(0, 0)
        PanelMainContent.Name = "PanelMainContent"
        PanelMainContent.Size = New Size(884, 661)
        PanelMainContent.TabIndex = 2
        ' 
        ' TimerDateTime
        ' 
        TimerDateTime.Enabled = True
        TimerDateTime.Interval = 1000
        ' 
        ' frmDashboard
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(884, 661)
        Controls.Add(PanelMainContent)
        Font = New Font("Segoe UI", 9F)
        Name = "frmDashboard"
        Text = "ESG Management System"
        CType(PictureBoxLogo, ComponentModel.ISupportInitialize).EndInit()
        PanelMainContent.ResumeLayout(False)
        PanelMainContent.PerformLayout()
        ResumeLayout(False)

    End Sub
    Friend WithEvents PanelMainContent As Panel
    Friend WithEvents LabelTitle As Label
    Friend WithEvents PictureBoxLogo As PictureBox
    Friend WithEvents TimerDateTime As Timer
    Friend WithEvents BtnCSR As Button
    Friend WithEvents BtnREPORTS As Button
    Friend WithEvents BtnSOCIAL As Button
    Friend WithEvents BtnWASTE_MANAGEMENT As Button
    Friend WithEvents BtnINVENTORY As Button
    Friend WithEvents BtnEMP_Details As Button

End Class