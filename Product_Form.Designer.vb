<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Product_Form
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Product_Form))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.ElipseProductForm = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.PnlProducts = New System.Windows.Forms.Panel()
        Me.Panel_AllProduct = New System.Windows.Forms.Panel()
        Me.BtnBack = New Guna.UI2.WinForms.Guna2CircleButton()
        Me.DG_AllItems = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.TblProductsBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DB_All_Items = New Medical_Shop_Billing_System.DB_All_Items()
        Me.Lbl_AllProduct = New System.Windows.Forms.Label()
        Me.TileBtnRemove = New Guna.UI2.WinForms.Guna2GradientTileButton()
        Me.TileBtnAdd = New Guna.UI2.WinForms.Guna2GradientTileButton()
        Me.TilebtnAllproducts = New Guna.UI2.WinForms.Guna2GradientTileButton()
        Me.LblProducts = New System.Windows.Forms.Label()
        Me.TileBtnEditItem = New Guna.UI2.WinForms.Guna2GradientTileButton()
        Me.TblProductsBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DB_MedicalDataSet1 = New Medical_Shop_Billing_System.DB_MedicalDataSet()
        Me.DB_MedicalDataSet = New Medical_Shop_Billing_System.DB_MedicalDataSet()
        Me.TblProductsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_ProductsTableAdapter = New Medical_Shop_Billing_System.DB_MedicalDataSetTableAdapters.Tbl_ProductsTableAdapter()
        Me.Tbl_ProductsTableAdapter1 = New Medical_Shop_Billing_System.DB_All_ItemsTableAdapters.Tbl_ProductsTableAdapter()
        Me.ElipseGDAllItem = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.PnlProducts.SuspendLayout()
        Me.Panel_AllProduct.SuspendLayout()
        CType(Me.DG_AllItems, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblProductsBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DB_All_Items, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblProductsBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DB_MedicalDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DB_MedicalDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblProductsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ElipseProductForm
        '
        Me.ElipseProductForm.BorderRadius = 0
        Me.ElipseProductForm.TargetControl = Me
        '
        'PnlProducts
        '
        Me.PnlProducts.BackColor = System.Drawing.Color.Transparent
        Me.PnlProducts.Controls.Add(Me.Panel_AllProduct)
        Me.PnlProducts.Controls.Add(Me.TileBtnRemove)
        Me.PnlProducts.Controls.Add(Me.TileBtnAdd)
        Me.PnlProducts.Controls.Add(Me.TilebtnAllproducts)
        Me.PnlProducts.Controls.Add(Me.LblProducts)
        Me.PnlProducts.Controls.Add(Me.TileBtnEditItem)
        Me.PnlProducts.Location = New System.Drawing.Point(0, 0)
        Me.PnlProducts.Name = "PnlProducts"
        Me.PnlProducts.Size = New System.Drawing.Size(767, 547)
        Me.PnlProducts.TabIndex = 4
        '
        'Panel_AllProduct
        '
        Me.Panel_AllProduct.BackColor = System.Drawing.Color.Transparent
        Me.Panel_AllProduct.Controls.Add(Me.BtnBack)
        Me.Panel_AllProduct.Controls.Add(Me.DG_AllItems)
        Me.Panel_AllProduct.Controls.Add(Me.Lbl_AllProduct)
        Me.Panel_AllProduct.Location = New System.Drawing.Point(0, 0)
        Me.Panel_AllProduct.Name = "Panel_AllProduct"
        Me.Panel_AllProduct.Size = New System.Drawing.Size(767, 548)
        Me.Panel_AllProduct.TabIndex = 5
        Me.Panel_AllProduct.Visible = False
        '
        'BtnBack
        '
        Me.BtnBack.Animated = True
        Me.BtnBack.CheckedState.Parent = Me.BtnBack
        Me.BtnBack.CustomImages.Parent = Me.BtnBack
        Me.BtnBack.FillColor = System.Drawing.Color.Transparent
        Me.BtnBack.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BtnBack.ForeColor = System.Drawing.Color.White
        Me.BtnBack.HoverState.Parent = Me.BtnBack
        Me.BtnBack.Image = CType(resources.GetObject("BtnBack.Image"), System.Drawing.Image)
        Me.BtnBack.Location = New System.Drawing.Point(13, 13)
        Me.BtnBack.Name = "BtnBack"
        Me.BtnBack.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.BtnBack.ShadowDecoration.Parent = Me.BtnBack
        Me.BtnBack.Size = New System.Drawing.Size(30, 30)
        Me.BtnBack.TabIndex = 2
        '
        'DG_AllItems
        '
        Me.DG_AllItems.AllowUserToAddRows = False
        Me.DG_AllItems.AllowUserToDeleteRows = False
        Me.DG_AllItems.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(203, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.DG_AllItems.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DG_AllItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DG_AllItems.BackgroundColor = System.Drawing.SystemColors.Control
        Me.DG_AllItems.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DG_AllItems.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DG_AllItems.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(181, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DG_AllItems.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DG_AllItems.ColumnHeadersHeight = 40
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(239, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(205, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DG_AllItems.DefaultCellStyle = DataGridViewCellStyle3
        Me.DG_AllItems.EnableHeadersVisualStyles = False
        Me.DG_AllItems.GridColor = System.Drawing.Color.FromArgb(CType(CType(194, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.DG_AllItems.Location = New System.Drawing.Point(13, 71)
        Me.DG_AllItems.Name = "DG_AllItems"
        Me.DG_AllItems.ReadOnly = True
        Me.DG_AllItems.RowHeadersVisible = False
        Me.DG_AllItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DG_AllItems.Size = New System.Drawing.Size(728, 450)
        Me.DG_AllItems.TabIndex = 1
        Me.DG_AllItems.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Indigo
        Me.DG_AllItems.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(203, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.DG_AllItems.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.DG_AllItems.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.DG_AllItems.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.DG_AllItems.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.DG_AllItems.ThemeStyle.BackColor = System.Drawing.SystemColors.Control
        Me.DG_AllItems.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(194, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.DG_AllItems.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.DG_AllItems.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DG_AllItems.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.DG_AllItems.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.DG_AllItems.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.DG_AllItems.ThemeStyle.HeaderStyle.Height = 40
        Me.DG_AllItems.ThemeStyle.ReadOnly = True
        Me.DG_AllItems.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.DG_AllItems.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DG_AllItems.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.DG_AllItems.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.DG_AllItems.ThemeStyle.RowsStyle.Height = 22
        Me.DG_AllItems.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.DG_AllItems.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black
        '
        'TblProductsBindingSource2
        '
        Me.TblProductsBindingSource2.DataMember = "Tbl_Products"
        Me.TblProductsBindingSource2.DataSource = Me.DB_All_Items
        '
        'DB_All_Items
        '
        Me.DB_All_Items.DataSetName = "DB_All_Items"
        Me.DB_All_Items.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Lbl_AllProduct
        '
        Me.Lbl_AllProduct.AutoSize = True
        Me.Lbl_AllProduct.Font = New System.Drawing.Font("Franklin Gothic Medium", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_AllProduct.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Lbl_AllProduct.Location = New System.Drawing.Point(57, 11)
        Me.Lbl_AllProduct.Name = "Lbl_AllProduct"
        Me.Lbl_AllProduct.Size = New System.Drawing.Size(127, 34)
        Me.Lbl_AllProduct.TabIndex = 0
        Me.Lbl_AllProduct.Text = "All Items"
        '
        'TileBtnRemove
        '
        Me.TileBtnRemove.Animated = True
        Me.TileBtnRemove.BackColor = System.Drawing.Color.Transparent
        Me.TileBtnRemove.BorderRadius = 6
        Me.TileBtnRemove.CheckedState.Parent = Me.TileBtnRemove
        Me.TileBtnRemove.CustomImages.Parent = Me.TileBtnRemove
        Me.TileBtnRemove.FillColor = System.Drawing.Color.DarkGray
        Me.TileBtnRemove.FillColor2 = System.Drawing.Color.DarkGray
        Me.TileBtnRemove.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TileBtnRemove.ForeColor = System.Drawing.Color.Blue
        Me.TileBtnRemove.HoverState.Parent = Me.TileBtnRemove
        Me.TileBtnRemove.Image = CType(resources.GetObject("TileBtnRemove.Image"), System.Drawing.Image)
        Me.TileBtnRemove.ImageOffset = New System.Drawing.Point(0, 29)
        Me.TileBtnRemove.ImageSize = New System.Drawing.Size(90, 90)
        Me.TileBtnRemove.Location = New System.Drawing.Point(438, 364)
        Me.TileBtnRemove.Name = "TileBtnRemove"
        Me.TileBtnRemove.ShadowDecoration.BorderRadius = 10
        Me.TileBtnRemove.ShadowDecoration.Depth = 50
        Me.TileBtnRemove.ShadowDecoration.Enabled = True
        Me.TileBtnRemove.ShadowDecoration.Parent = Me.TileBtnRemove
        Me.TileBtnRemove.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 5, 5)
        Me.TileBtnRemove.Size = New System.Drawing.Size(154, 152)
        Me.TileBtnRemove.TabIndex = 2
        Me.TileBtnRemove.Text = "Remove Item"
        Me.TileBtnRemove.TextOffset = New System.Drawing.Point(0, 20)
        '
        'TileBtnAdd
        '
        Me.TileBtnAdd.Animated = True
        Me.TileBtnAdd.BackColor = System.Drawing.Color.Transparent
        Me.TileBtnAdd.BorderRadius = 6
        Me.TileBtnAdd.CheckedState.Parent = Me.TileBtnAdd
        Me.TileBtnAdd.CustomImages.Parent = Me.TileBtnAdd
        Me.TileBtnAdd.FillColor = System.Drawing.Color.DarkGray
        Me.TileBtnAdd.FillColor2 = System.Drawing.Color.DarkGray
        Me.TileBtnAdd.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TileBtnAdd.ForeColor = System.Drawing.Color.Blue
        Me.TileBtnAdd.HoverState.Parent = Me.TileBtnAdd
        Me.TileBtnAdd.Image = CType(resources.GetObject("TileBtnAdd.Image"), System.Drawing.Image)
        Me.TileBtnAdd.ImageOffset = New System.Drawing.Point(0, 29)
        Me.TileBtnAdd.ImageSize = New System.Drawing.Size(90, 90)
        Me.TileBtnAdd.Location = New System.Drawing.Point(145, 364)
        Me.TileBtnAdd.Name = "TileBtnAdd"
        Me.TileBtnAdd.ShadowDecoration.BorderRadius = 10
        Me.TileBtnAdd.ShadowDecoration.Depth = 50
        Me.TileBtnAdd.ShadowDecoration.Enabled = True
        Me.TileBtnAdd.ShadowDecoration.Parent = Me.TileBtnAdd
        Me.TileBtnAdd.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 5, 5)
        Me.TileBtnAdd.Size = New System.Drawing.Size(154, 152)
        Me.TileBtnAdd.TabIndex = 2
        Me.TileBtnAdd.Text = "Add Item"
        Me.TileBtnAdd.TextOffset = New System.Drawing.Point(0, 20)
        '
        'TilebtnAllproducts
        '
        Me.TilebtnAllproducts.Animated = True
        Me.TilebtnAllproducts.BackColor = System.Drawing.Color.Transparent
        Me.TilebtnAllproducts.BorderRadius = 6
        Me.TilebtnAllproducts.CheckedState.Parent = Me.TilebtnAllproducts
        Me.TilebtnAllproducts.CustomImages.Parent = Me.TilebtnAllproducts
        Me.TilebtnAllproducts.FillColor = System.Drawing.Color.DarkGray
        Me.TilebtnAllproducts.FillColor2 = System.Drawing.Color.DarkGray
        Me.TilebtnAllproducts.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TilebtnAllproducts.ForeColor = System.Drawing.Color.Blue
        Me.TilebtnAllproducts.HoverState.Parent = Me.TilebtnAllproducts
        Me.TilebtnAllproducts.Image = CType(resources.GetObject("TilebtnAllproducts.Image"), System.Drawing.Image)
        Me.TilebtnAllproducts.ImageOffset = New System.Drawing.Point(0, 29)
        Me.TilebtnAllproducts.ImageSize = New System.Drawing.Size(90, 90)
        Me.TilebtnAllproducts.Location = New System.Drawing.Point(145, 149)
        Me.TilebtnAllproducts.Name = "TilebtnAllproducts"
        Me.TilebtnAllproducts.ShadowDecoration.BorderRadius = 10
        Me.TilebtnAllproducts.ShadowDecoration.Depth = 50
        Me.TilebtnAllproducts.ShadowDecoration.Enabled = True
        Me.TilebtnAllproducts.ShadowDecoration.Parent = Me.TilebtnAllproducts
        Me.TilebtnAllproducts.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 5, 5)
        Me.TilebtnAllproducts.Size = New System.Drawing.Size(154, 152)
        Me.TilebtnAllproducts.TabIndex = 2
        Me.TilebtnAllproducts.Text = "All Items"
        Me.TilebtnAllproducts.TextOffset = New System.Drawing.Point(0, 20)
        '
        'LblProducts
        '
        Me.LblProducts.AutoSize = True
        Me.LblProducts.Font = New System.Drawing.Font("Franklin Gothic Medium", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblProducts.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LblProducts.Location = New System.Drawing.Point(41, 60)
        Me.LblProducts.Name = "LblProducts"
        Me.LblProducts.Size = New System.Drawing.Size(146, 37)
        Me.LblProducts.TabIndex = 0
        Me.LblProducts.Text = "Products"
        '
        'TileBtnEditItem
        '
        Me.TileBtnEditItem.Animated = True
        Me.TileBtnEditItem.BackColor = System.Drawing.Color.Transparent
        Me.TileBtnEditItem.BorderRadius = 6
        Me.TileBtnEditItem.CheckedState.Parent = Me.TileBtnEditItem
        Me.TileBtnEditItem.CustomImages.Parent = Me.TileBtnEditItem
        Me.TileBtnEditItem.FillColor = System.Drawing.Color.DarkGray
        Me.TileBtnEditItem.FillColor2 = System.Drawing.Color.DarkGray
        Me.TileBtnEditItem.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TileBtnEditItem.ForeColor = System.Drawing.Color.Blue
        Me.TileBtnEditItem.HoverState.Parent = Me.TileBtnEditItem
        Me.TileBtnEditItem.Image = CType(resources.GetObject("TileBtnEditItem.Image"), System.Drawing.Image)
        Me.TileBtnEditItem.ImageOffset = New System.Drawing.Point(0, 29)
        Me.TileBtnEditItem.ImageSize = New System.Drawing.Size(90, 90)
        Me.TileBtnEditItem.Location = New System.Drawing.Point(438, 149)
        Me.TileBtnEditItem.Name = "TileBtnEditItem"
        Me.TileBtnEditItem.ShadowDecoration.BorderRadius = 10
        Me.TileBtnEditItem.ShadowDecoration.Depth = 50
        Me.TileBtnEditItem.ShadowDecoration.Enabled = True
        Me.TileBtnEditItem.ShadowDecoration.Parent = Me.TileBtnEditItem
        Me.TileBtnEditItem.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 5, 5)
        Me.TileBtnEditItem.Size = New System.Drawing.Size(154, 152)
        Me.TileBtnEditItem.TabIndex = 6
        Me.TileBtnEditItem.Text = "Edit Item"
        Me.TileBtnEditItem.TextOffset = New System.Drawing.Point(0, 20)
        '
        'TblProductsBindingSource1
        '
        Me.TblProductsBindingSource1.DataMember = "Tbl_Products"
        Me.TblProductsBindingSource1.DataSource = Me.DB_MedicalDataSet1
        '
        'DB_MedicalDataSet1
        '
        Me.DB_MedicalDataSet1.DataSetName = "DB_MedicalDataSet"
        Me.DB_MedicalDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DB_MedicalDataSet
        '
        Me.DB_MedicalDataSet.DataSetName = "DB_MedicalDataSet"
        Me.DB_MedicalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblProductsBindingSource
        '
        Me.TblProductsBindingSource.DataMember = "Tbl_Products"
        Me.TblProductsBindingSource.DataSource = Me.DB_MedicalDataSet
        '
        'Tbl_ProductsTableAdapter
        '
        Me.Tbl_ProductsTableAdapter.ClearBeforeFill = True
        '
        'Tbl_ProductsTableAdapter1
        '
        Me.Tbl_ProductsTableAdapter1.ClearBeforeFill = True
        '
        'ElipseGDAllItem
        '
        Me.ElipseGDAllItem.TargetControl = Me.DG_AllItems
        '
        'Product_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(767, 548)
        Me.Controls.Add(Me.PnlProducts)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Product_Form"
        Me.Text = "Product_Form"
        Me.PnlProducts.ResumeLayout(False)
        Me.PnlProducts.PerformLayout()
        Me.Panel_AllProduct.ResumeLayout(False)
        Me.Panel_AllProduct.PerformLayout()
        CType(Me.DG_AllItems, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblProductsBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DB_All_Items, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblProductsBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DB_MedicalDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DB_MedicalDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblProductsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ElipseProductForm As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents PnlProducts As Panel
    Friend WithEvents TileBtnRemove As Guna.UI2.WinForms.Guna2GradientTileButton
    Friend WithEvents TileBtnAdd As Guna.UI2.WinForms.Guna2GradientTileButton
    Friend WithEvents TilebtnAllproducts As Guna.UI2.WinForms.Guna2GradientTileButton
    Friend WithEvents LblProducts As Label
    Friend WithEvents Panel_AllProduct As Panel
    Friend WithEvents Lbl_AllProduct As Label
    Friend WithEvents DB_MedicalDataSet As DB_MedicalDataSet
    Friend WithEvents TblProductsBindingSource As BindingSource
    Friend WithEvents Tbl_ProductsTableAdapter As DB_MedicalDataSetTableAdapters.Tbl_ProductsTableAdapter
    Friend WithEvents DG_AllItems As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents DB_MedicalDataSet1 As DB_MedicalDataSet
    Friend WithEvents TblProductsBindingSource1 As BindingSource
    Friend WithEvents BtnBack As Guna.UI2.WinForms.Guna2CircleButton
    Friend WithEvents DB_All_Items As DB_All_Items
    Friend WithEvents TblProductsBindingSource2 As BindingSource
    Friend WithEvents Tbl_ProductsTableAdapter1 As DB_All_ItemsTableAdapters.Tbl_ProductsTableAdapter
    Friend WithEvents TileBtnEditItem As Guna.UI2.WinForms.Guna2GradientTileButton
    Friend WithEvents ElipseGDAllItem As Guna.UI2.WinForms.Guna2Elipse
End Class
