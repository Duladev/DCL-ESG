<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
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
        TabControl1 = New TabControl()
        TabPageElectricity = New TabPage()
        TabPageOwnElectricity = New TabPage()
        TabPageGas = New TabPage()
        TabPageWater = New TabPage()
        TabPagePlastic = New TabPage()
        TabPagePaper = New TabPage()
        TabPageProduct = New TabPage()
        btnExit = New Button()
        TabControl1.SuspendLayout()
        SuspendLayout()
        ' 
        ' TabControl1
        ' 
        TabControl1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        TabControl1.Controls.Add(TabPageElectricity)
        TabControl1.Controls.Add(TabPageOwnElectricity)
        TabControl1.Controls.Add(TabPageGas)
        TabControl1.Controls.Add(TabPageWater)
        TabControl1.Controls.Add(TabPagePlastic)
        TabControl1.Controls.Add(TabPagePaper)
        TabControl1.Controls.Add(TabPageProduct)
        TabControl1.Location = New Point(10, 9)
        TabControl1.Margin = New Padding(3, 2, 3, 2)
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(934, 527)
        TabControl1.TabIndex = 0
        ' 
        ' TabPageElectricity
        ' 
        TabPageElectricity.Location = New Point(4, 24)
        TabPageElectricity.Margin = New Padding(3, 2, 3, 2)
        TabPageElectricity.Name = "TabPageElectricity"
        TabPageElectricity.Padding = New Padding(3, 2, 3, 2)
        TabPageElectricity.Size = New Size(926, 499)
        TabPageElectricity.TabIndex = 0
        TabPageElectricity.Text = "Electricity Purchase"
        TabPageElectricity.UseVisualStyleBackColor = True
        ' 
        ' TabPageOwnElectricity
        ' 
        TabPageOwnElectricity.Location = New Point(4, 24)
        TabPageOwnElectricity.Margin = New Padding(3, 2, 3, 2)
        TabPageOwnElectricity.Name = "TabPageOwnElectricity"
        TabPageOwnElectricity.Padding = New Padding(3, 2, 3, 2)
        TabPageOwnElectricity.Size = New Size(926, 499)
        TabPageOwnElectricity.TabIndex = 1
        TabPageOwnElectricity.Text = "Own Generated Electricity"
        TabPageOwnElectricity.UseVisualStyleBackColor = True
        ' 
        ' TabPageGas
        ' 
        TabPageGas.Location = New Point(4, 24)
        TabPageGas.Margin = New Padding(3, 2, 3, 2)
        TabPageGas.Name = "TabPageGas"
        TabPageGas.Padding = New Padding(3, 2, 3, 2)
        TabPageGas.Size = New Size(926, 499)
        TabPageGas.TabIndex = 2
        TabPageGas.Text = "Gas"
        TabPageGas.UseVisualStyleBackColor = True
        ' 
        ' TabPageWater
        ' 
        TabPageWater.Location = New Point(4, 24)
        TabPageWater.Margin = New Padding(3, 2, 3, 2)
        TabPageWater.Name = "TabPageWater"
        TabPageWater.Padding = New Padding(3, 2, 3, 2)
        TabPageWater.Size = New Size(926, 499)
        TabPageWater.TabIndex = 3
        TabPageWater.Text = "Water"
        TabPageWater.UseVisualStyleBackColor = True
        ' 
        ' TabPagePlastic
        ' 
        TabPagePlastic.Location = New Point(4, 24)
        TabPagePlastic.Margin = New Padding(3, 2, 3, 2)
        TabPagePlastic.Name = "TabPagePlastic"
        TabPagePlastic.Padding = New Padding(3, 2, 3, 2)
        TabPagePlastic.Size = New Size(926, 499)
        TabPagePlastic.TabIndex = 4
        TabPagePlastic.Text = "Plastic"
        TabPagePlastic.UseVisualStyleBackColor = True
        ' 
        ' TabPagePaper
        ' 
        TabPagePaper.Location = New Point(4, 24)
        TabPagePaper.Margin = New Padding(3, 2, 3, 2)
        TabPagePaper.Name = "TabPagePaper"
        TabPagePaper.Padding = New Padding(3, 2, 3, 2)
        TabPagePaper.Size = New Size(926, 499)
        TabPagePaper.TabIndex = 5
        TabPagePaper.Text = "Paper"
        TabPagePaper.UseVisualStyleBackColor = True
        ' 
        ' TabPageProduct
        ' 
        TabPageProduct.Location = New Point(4, 24)
        TabPageProduct.Margin = New Padding(3, 2, 3, 2)
        TabPageProduct.Name = "TabPageProduct"
        TabPageProduct.Padding = New Padding(3, 2, 3, 2)
        TabPageProduct.Size = New Size(926, 499)
        TabPageProduct.TabIndex = 6
        TabPageProduct.Text = "Product Management"
        TabPageProduct.UseVisualStyleBackColor = True
        ' 
        ' btnExit
        ' 
        btnExit.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        btnExit.BackColor = SystemColors.Control
        btnExit.FlatStyle = FlatStyle.Flat
        btnExit.Font = New Font("Microsoft Sans Serif", 10F, FontStyle.Bold)
        btnExit.ForeColor = Color.Black
        btnExit.Location = New Point(854, 540)
        btnExit.Margin = New Padding(3, 2, 3, 2)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(86, 29)
        btnExit.TabIndex = 1
        btnExit.Text = "Logout"
        btnExit.UseVisualStyleBackColor = False
        ' 
        ' frmMain
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(952, 576)
        Controls.Add(btnExit)
        Controls.Add(TabControl1)
        Margin = New Padding(3, 2, 3, 2)
        Name = "frmMain"
        StartPosition = FormStartPosition.CenterScreen
        Text = "ESG Inventory Management System"
        TabControl1.ResumeLayout(False)
        ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPageElectricity As TabPage
    Friend WithEvents TabPageOwnElectricity As TabPage
    Friend WithEvents TabPageGas As TabPage
    Friend WithEvents TabPageWater As TabPage
    Friend WithEvents TabPagePlastic As TabPage
    Friend WithEvents TabPagePaper As TabPage
    Friend WithEvents TabPageProduct As TabPage
    Friend WithEvents btnExit As Button
End Class