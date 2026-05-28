<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmProductManagement
    Inherits System.Windows.Forms.Form

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

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        grpInput = New GroupBox()
        txtWeightPerUnit = New TextBox()
        lblWeightPerUnit = New Label()
        cmbUnitType = New ComboBox()
        lblUnitType = New Label()
        txtProductTypeName = New TextBox()
        lblProductTypeName = New Label()
        txtCategory = New TextBox()
        lblCategory = New Label()
        cmbProductType = New ComboBox()
        lblProductType = New Label()
        grpButtons = New GroupBox()
        btnDelete = New Button()
        btnUpdate = New Button()
        btnSave = New Button()
        grdData = New DataGridView()
        grpInput.SuspendLayout()
        grpButtons.SuspendLayout()
        CType(grdData, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' grpInput
        ' 
        grpInput.Controls.Add(txtWeightPerUnit)
        grpInput.Controls.Add(lblWeightPerUnit)
        grpInput.Controls.Add(cmbUnitType)
        grpInput.Controls.Add(lblUnitType)
        grpInput.Controls.Add(txtProductTypeName)
        grpInput.Controls.Add(lblProductTypeName)
        grpInput.Controls.Add(txtCategory)
        grpInput.Controls.Add(lblCategory)
        grpInput.Controls.Add(cmbProductType)
        grpInput.Controls.Add(lblProductType)
        grpInput.Location = New Point(10, 9)
        grpInput.Margin = New Padding(3, 2, 3, 2)
        grpInput.Name = "grpInput"
        grpInput.Padding = New Padding(3, 2, 3, 2)
        grpInput.Size = New Size(466, 188)
        grpInput.TabIndex = 0
        grpInput.TabStop = False
        grpInput.Text = "Product Management"
        ' 
        ' txtWeightPerUnit
        ' 
        txtWeightPerUnit.Location = New Point(156, 150)
        txtWeightPerUnit.Margin = New Padding(3, 2, 3, 2)
        txtWeightPerUnit.Name = "txtWeightPerUnit"
        txtWeightPerUnit.Size = New Size(118, 23)
        txtWeightPerUnit.TabIndex = 9
        ' 
        ' lblWeightPerUnit
        ' 
        lblWeightPerUnit.AutoSize = True
        lblWeightPerUnit.Location = New Point(24, 152)
        lblWeightPerUnit.Name = "lblWeightPerUnit"
        lblWeightPerUnit.Size = New Size(93, 15)
        lblWeightPerUnit.TabIndex = 8
        lblWeightPerUnit.Text = "Weight Per Unit:"
        ' 
        ' cmbUnitType
        ' 
        cmbUnitType.DropDownStyle = ComboBoxStyle.DropDownList
        cmbUnitType.FormattingEnabled = True
        cmbUnitType.Items.AddRange(New Object() {"Pieces", "Kilograms", "Meters", "Reams", "Boxes", "Bottles", "Containers"})
        cmbUnitType.Location = New Point(156, 120)
        cmbUnitType.Margin = New Padding(3, 2, 3, 2)
        cmbUnitType.Name = "cmbUnitType"
        cmbUnitType.Size = New Size(156, 23)
        cmbUnitType.TabIndex = 7
        ' 
        ' lblUnitType
        ' 
        lblUnitType.AutoSize = True
        lblUnitType.Location = New Point(24, 122)
        lblUnitType.Name = "lblUnitType"
        lblUnitType.Size = New Size(60, 15)
        lblUnitType.TabIndex = 6
        lblUnitType.Text = "Unit Type:"
        ' 
        ' txtProductTypeName
        ' 
        txtProductTypeName.Location = New Point(156, 90)
        txtProductTypeName.Margin = New Padding(3, 2, 3, 2)
        txtProductTypeName.Name = "txtProductTypeName"
        txtProductTypeName.Size = New Size(234, 23)
        txtProductTypeName.TabIndex = 5
        ' 
        ' lblProductTypeName
        ' 
        lblProductTypeName.AutoSize = True
        lblProductTypeName.Location = New Point(24, 92)
        lblProductTypeName.Name = "lblProductTypeName"
        lblProductTypeName.Size = New Size(115, 15)
        lblProductTypeName.TabIndex = 4
        lblProductTypeName.Text = "Product Type Name:"
        ' 
        ' txtCategory
        ' 
        txtCategory.Location = New Point(156, 60)
        txtCategory.Margin = New Padding(3, 2, 3, 2)
        txtCategory.Name = "txtCategory"
        txtCategory.Size = New Size(234, 23)
        txtCategory.TabIndex = 3
        ' 
        ' lblCategory
        ' 
        lblCategory.AutoSize = True
        lblCategory.Location = New Point(24, 62)
        lblCategory.Name = "lblCategory"
        lblCategory.Size = New Size(103, 15)
        lblCategory.TabIndex = 2
        lblCategory.Text = "Product Category:"
        ' 
        ' cmbProductType
        ' 
        cmbProductType.DropDownStyle = ComboBoxStyle.DropDownList
        cmbProductType.FormattingEnabled = True
        cmbProductType.Items.AddRange(New Object() {"Plastic", "Paper"})
        cmbProductType.Location = New Point(156, 30)
        cmbProductType.Margin = New Padding(3, 2, 3, 2)
        cmbProductType.Name = "cmbProductType"
        cmbProductType.Size = New Size(118, 23)
        cmbProductType.TabIndex = 1
        ' 
        ' lblProductType
        ' 
        lblProductType.AutoSize = True
        lblProductType.Location = New Point(24, 32)
        lblProductType.Name = "lblProductType"
        lblProductType.Size = New Size(80, 15)
        lblProductType.TabIndex = 0
        lblProductType.Text = "Product Type:"
        ' 
        ' grpButtons
        ' 
        grpButtons.Controls.Add(btnDelete)
        grpButtons.Controls.Add(btnUpdate)
        grpButtons.Controls.Add(btnSave)
        grpButtons.Location = New Point(490, 9)
        grpButtons.Margin = New Padding(3, 2, 3, 2)
        grpButtons.Name = "grpButtons"
        grpButtons.Padding = New Padding(3, 2, 3, 2)
        grpButtons.Size = New Size(428, 188)
        grpButtons.TabIndex = 1
        grpButtons.TabStop = False
        grpButtons.Text = "Actions"
        ' 
        ' btnDelete
        ' 
        btnDelete.BackColor = SystemColors.AppWorkspace
        btnDelete.Enabled = False
        btnDelete.FlatStyle = FlatStyle.Flat
        btnDelete.ForeColor = Color.White
        btnDelete.Location = New Point(61, 101)
        btnDelete.Margin = New Padding(3, 2, 3, 2)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(116, 30)
        btnDelete.TabIndex = 2
        btnDelete.Text = "Delete"
        btnDelete.UseVisualStyleBackColor = False
        ' 
        ' btnUpdate
        ' 
        btnUpdate.BackColor = SystemColors.AppWorkspace
        btnUpdate.Enabled = False
        btnUpdate.FlatStyle = FlatStyle.Flat
        btnUpdate.ForeColor = Color.White
        btnUpdate.Location = New Point(61, 64)
        btnUpdate.Margin = New Padding(3, 2, 3, 2)
        btnUpdate.Name = "btnUpdate"
        btnUpdate.Size = New Size(116, 30)
        btnUpdate.TabIndex = 1
        btnUpdate.Text = "Update"
        btnUpdate.UseVisualStyleBackColor = False
        ' 
        ' btnSave
        ' 
        btnSave.BackColor = SystemColors.AppWorkspace
        btnSave.FlatStyle = FlatStyle.Flat
        btnSave.ForeColor = Color.White
        btnSave.Location = New Point(61, 30)
        btnSave.Margin = New Padding(3, 2, 3, 2)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(116, 30)
        btnSave.TabIndex = 0
        btnSave.Text = "Save"
        btnSave.UseVisualStyleBackColor = False
        ' 
        ' grdData
        ' 
        grdData.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        grdData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        grdData.Location = New Point(10, 202)
        grdData.Margin = New Padding(3, 2, 3, 2)
        grdData.Name = "grdData"
        grdData.RowHeadersWidth = 62
        grdData.RowTemplate.Height = 28
        grdData.Size = New Size(908, 289)
        grdData.TabIndex = 2
        ' 
        ' frmProductManagement
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(928, 501)
        Controls.Add(grdData)
        Controls.Add(grpButtons)
        Controls.Add(grpInput)
        Margin = New Padding(3, 2, 3, 2)
        Name = "frmProductManagement"
        Text = "Product Management"
        grpInput.ResumeLayout(False)
        grpInput.PerformLayout()
        grpButtons.ResumeLayout(False)
        CType(grdData, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)

    End Sub

    Friend WithEvents grpInput As GroupBox
    Friend WithEvents cmbProductType As ComboBox
    Friend WithEvents lblProductType As Label
    Friend WithEvents txtCategory As TextBox
    Friend WithEvents lblCategory As Label
    Friend WithEvents txtProductTypeName As TextBox
    Friend WithEvents lblProductTypeName As Label
    Friend WithEvents cmbUnitType As ComboBox
    Friend WithEvents lblUnitType As Label
    Friend WithEvents txtWeightPerUnit As TextBox
    Friend WithEvents lblWeightPerUnit As Label
    Friend WithEvents grpButtons As GroupBox
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents grdData As DataGridView
End Class