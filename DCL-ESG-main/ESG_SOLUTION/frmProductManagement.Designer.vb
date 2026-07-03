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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmProductManagement))
        grpInput = New GroupBox()
        cmbCategory = New ComboBox()
        lblCategory = New Label()
        txtWeightPerUnit = New TextBox()
        lblWeightPerUnit = New Label()
        cmbUnitType = New ComboBox()
        lblUnitType = New Label()
        txtProductTypeName = New TextBox()
        lblProductTypeName = New Label()
        cmbProductType = New ComboBox()
        lblProductType = New Label()
        grpButtons = New GroupBox()
        btnExportExcel = New Button()
        btnClear = New Button()
        btnDelete = New Button()
        btnUpdate = New Button()
        btnSave = New Button()
        grdData = New DataGridView()
        btnHome = New Button()
        grpInput.SuspendLayout()
        grpButtons.SuspendLayout()
        CType(grdData, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' grpInput
        ' 
        grpInput.Controls.Add(cmbCategory)
        grpInput.Controls.Add(lblCategory)
        grpInput.Controls.Add(txtWeightPerUnit)
        grpInput.Controls.Add(lblWeightPerUnit)
        grpInput.Controls.Add(cmbUnitType)
        grpInput.Controls.Add(lblUnitType)
        grpInput.Controls.Add(txtProductTypeName)
        grpInput.Controls.Add(lblProductTypeName)
        grpInput.Controls.Add(cmbProductType)
        grpInput.Controls.Add(lblProductType)
        grpInput.Location = New Point(10, 9)
        grpInput.Margin = New Padding(3, 2, 3, 2)
        grpInput.Name = "grpInput"
        grpInput.Padding = New Padding(3, 2, 3, 2)
        grpInput.Size = New Size(438, 217)
        grpInput.TabIndex = 0
        grpInput.TabStop = False
        grpInput.Text = "Product Information"
        ' 
        ' cmbCategory
        ' 
        cmbCategory.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        cmbCategory.AutoCompleteSource = AutoCompleteSource.ListItems
        cmbCategory.FormattingEnabled = True
        cmbCategory.Location = New Point(158, 49)
        cmbCategory.Margin = New Padding(3, 2, 3, 2)
        cmbCategory.Name = "cmbCategory"
        cmbCategory.Size = New Size(246, 23)
        cmbCategory.TabIndex = 11
        ' 
        ' lblCategory
        ' 
        lblCategory.AutoSize = True
        lblCategory.Location = New Point(18, 51)
        lblCategory.Name = "lblCategory"
        lblCategory.Size = New Size(103, 15)
        lblCategory.TabIndex = 10
        lblCategory.Text = "Product Category:"
        ' 
        ' txtWeightPerUnit
        ' 
        txtWeightPerUnit.Location = New Point(158, 146)
        txtWeightPerUnit.Margin = New Padding(3, 2, 3, 2)
        txtWeightPerUnit.Name = "txtWeightPerUnit"
        txtWeightPerUnit.Size = New Size(246, 23)
        txtWeightPerUnit.TabIndex = 9
        ' 
        ' lblWeightPerUnit
        ' 
        lblWeightPerUnit.AutoSize = True
        lblWeightPerUnit.Location = New Point(18, 148)
        lblWeightPerUnit.Name = "lblWeightPerUnit"
        lblWeightPerUnit.Size = New Size(93, 15)
        lblWeightPerUnit.TabIndex = 8
        lblWeightPerUnit.Text = "Weight Per Unit:"
        ' 
        ' cmbUnitType
        ' 
        cmbUnitType.DropDownStyle = ComboBoxStyle.DropDownList
        cmbUnitType.FormattingEnabled = True
        cmbUnitType.Items.AddRange(New Object() {"Pcs", "Pack"})
        cmbUnitType.Location = New Point(158, 120)
        cmbUnitType.Margin = New Padding(3, 2, 3, 2)
        cmbUnitType.Name = "cmbUnitType"
        cmbUnitType.Size = New Size(246, 23)
        cmbUnitType.TabIndex = 7
        ' 
        ' lblUnitType
        ' 
        lblUnitType.AutoSize = True
        lblUnitType.Location = New Point(18, 122)
        lblUnitType.Name = "lblUnitType"
        lblUnitType.Size = New Size(60, 15)
        lblUnitType.TabIndex = 6
        lblUnitType.Text = "Unit Type:"
        ' 
        ' txtProductTypeName
        ' 
        txtProductTypeName.Location = New Point(158, 94)
        txtProductTypeName.Margin = New Padding(3, 2, 3, 2)
        txtProductTypeName.Name = "txtProductTypeName"
        txtProductTypeName.Size = New Size(246, 23)
        txtProductTypeName.TabIndex = 5
        ' 
        ' lblProductTypeName
        ' 
        lblProductTypeName.AutoSize = True
        lblProductTypeName.Location = New Point(18, 96)
        lblProductTypeName.Name = "lblProductTypeName"
        lblProductTypeName.Size = New Size(115, 15)
        lblProductTypeName.TabIndex = 4
        lblProductTypeName.Text = "Product Type Name:"
        ' 
        ' cmbProductType
        ' 
        cmbProductType.DropDownStyle = ComboBoxStyle.DropDownList
        cmbProductType.FormattingEnabled = True
        cmbProductType.Location = New Point(158, 22)
        cmbProductType.Margin = New Padding(3, 2, 3, 2)
        cmbProductType.Name = "cmbProductType"
        cmbProductType.Size = New Size(246, 23)
        cmbProductType.TabIndex = 1
        ' 
        ' lblProductType
        ' 
        lblProductType.AutoSize = True
        lblProductType.Location = New Point(18, 25)
        lblProductType.Name = "lblProductType"
        lblProductType.Size = New Size(80, 15)
        lblProductType.TabIndex = 0
        lblProductType.Text = "Product Type:"
        ' 
        ' grpButtons
        ' 
        grpButtons.Controls.Add(btnHome)
        grpButtons.Controls.Add(btnExportExcel)
        grpButtons.Controls.Add(btnClear)
        grpButtons.Controls.Add(btnDelete)
        grpButtons.Controls.Add(btnUpdate)
        grpButtons.Controls.Add(btnSave)
        grpButtons.Location = New Point(453, 9)
        grpButtons.Margin = New Padding(3, 2, 3, 2)
        grpButtons.Name = "grpButtons"
        grpButtons.Padding = New Padding(3, 2, 3, 2)
        grpButtons.Size = New Size(219, 217)
        grpButtons.TabIndex = 1
        grpButtons.TabStop = False
        grpButtons.Text = "Actions"
        ' 
        ' btnExportExcel
        ' 
        btnExportExcel.BackColor = SystemColors.Control
        btnExportExcel.FlatStyle = FlatStyle.Flat
        btnExportExcel.ForeColor = Color.Black
        btnExportExcel.Location = New Point(6, 180)
        btnExportExcel.Margin = New Padding(3, 2, 3, 2)
        btnExportExcel.Name = "btnExportExcel"
        btnExportExcel.Size = New Size(131, 26)
        btnExportExcel.TabIndex = 4
        btnExportExcel.Text = "Export to Excel"
        btnExportExcel.UseVisualStyleBackColor = False
        ' 
        ' btnClear
        ' 
        btnClear.BackColor = SystemColors.Control
        btnClear.FlatStyle = FlatStyle.Flat
        btnClear.ForeColor = Color.Black
        btnClear.Location = New Point(6, 142)
        btnClear.Margin = New Padding(3, 2, 3, 2)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(131, 26)
        btnClear.TabIndex = 3
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = False
        ' 
        ' btnDelete
        ' 
        btnDelete.BackColor = SystemColors.Control
        btnDelete.Enabled = False
        btnDelete.FlatStyle = FlatStyle.Flat
        btnDelete.ForeColor = Color.Black
        btnDelete.Location = New Point(6, 105)
        btnDelete.Margin = New Padding(3, 2, 3, 2)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(131, 26)
        btnDelete.TabIndex = 2
        btnDelete.Text = "Delete"
        btnDelete.UseVisualStyleBackColor = False
        ' 
        ' btnUpdate
        ' 
        btnUpdate.BackColor = SystemColors.Control
        btnUpdate.Enabled = False
        btnUpdate.FlatStyle = FlatStyle.Flat
        btnUpdate.ForeColor = Color.Black
        btnUpdate.Location = New Point(6, 68)
        btnUpdate.Margin = New Padding(3, 2, 3, 2)
        btnUpdate.Name = "btnUpdate"
        btnUpdate.Size = New Size(131, 26)
        btnUpdate.TabIndex = 1
        btnUpdate.Text = "Update"
        btnUpdate.UseVisualStyleBackColor = False
        ' 
        ' btnSave
        ' 
        btnSave.BackColor = SystemColors.Control
        btnSave.FlatStyle = FlatStyle.Flat
        btnSave.ForeColor = Color.Black
        btnSave.Location = New Point(6, 30)
        btnSave.Margin = New Padding(3, 2, 3, 2)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(131, 26)
        btnSave.TabIndex = 0
        btnSave.Text = "Save"
        btnSave.UseVisualStyleBackColor = False
        ' 
        ' grdData
        ' 
        grdData.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        grdData.BackgroundColor = SystemColors.Window
        grdData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        grdData.Location = New Point(10, 230)
        grdData.Margin = New Padding(3, 2, 3, 2)
        grdData.Name = "grdData"
        grdData.RowHeadersWidth = 51
        grdData.RowTemplate.Height = 29
        grdData.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        grdData.Size = New Size(662, 201)
        grdData.TabIndex = 2
        ' 
        ' btnHome
        ' 
        btnHome.BackgroundImage = CType(resources.GetObject("btnHome.BackgroundImage"), Image)
        btnHome.BackgroundImageLayout = ImageLayout.Stretch
        btnHome.Location = New Point(157, 21)
        btnHome.Name = "btnHome"
        btnHome.Size = New Size(45, 38)
        btnHome.TabIndex = 13
        btnHome.UseVisualStyleBackColor = True
        ' 
        ' frmProductManagement
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(684, 446)
        Controls.Add(grdData)
        Controls.Add(grpButtons)
        Controls.Add(grpInput)
        Margin = New Padding(3, 2, 3, 2)
        MinimumSize = New Size(700, 485)
        Name = "frmProductManagement"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Product Management System"
        grpInput.ResumeLayout(False)
        grpInput.PerformLayout()
        grpButtons.ResumeLayout(False)
        CType(grdData, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)

    End Sub

    Friend WithEvents grpInput As GroupBox
    Friend WithEvents cmbProductType As ComboBox
    Friend WithEvents lblProductType As Label
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
    Friend WithEvents cmbCategory As ComboBox
    Friend WithEvents lblCategory As Label
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExportExcel As Button
    Friend WithEvents btnHome As Button

End Class