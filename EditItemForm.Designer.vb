<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class EditItemForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EditItemForm))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.ElipseEditItemForm = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Panel_AllProduct = New System.Windows.Forms.Panel()
        Me.PanelLogin = New Guna.UI2.WinForms.Guna2ShadowPanel()
        Me.ComboItemType = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.LblDescription = New System.Windows.Forms.Label()
        Me.TxtDescription = New Guna.UI2.WinForms.Guna2TextBox()
        Me.LblSellingPrice = New System.Windows.Forms.Label()
        Me.ValidSellingPrice = New Guna.UI2.WinForms.Guna2CirclePictureBox()
        Me.TxtSellingPrice = New Guna.UI2.WinForms.Guna2TextBox()
        Me.LblPurchasePrice = New System.Windows.Forms.Label()
        Me.ValidPurchasePrice = New Guna.UI2.WinForms.Guna2CirclePictureBox()
        Me.TxtPurchasePrice = New Guna.UI2.WinForms.Guna2TextBox()
        Me.LblDisease = New System.Windows.Forms.Label()
        Me.Valid_ItemType = New Guna.UI2.WinForms.Guna2CirclePictureBox()
        Me.Valid_Disease = New Guna.UI2.WinForms.Guna2CirclePictureBox()
        Me.TxtDisease = New Guna.UI2.WinForms.Guna2TextBox()
        Me.LblType = New System.Windows.Forms.Label()
        Me.LblName = New System.Windows.Forms.Label()
        Me.Valid_ItemName = New Guna.UI2.WinForms.Guna2CirclePictureBox()
        Me.LblEditDetails = New System.Windows.Forms.Label()
        Me.TxtItemName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.BtnEditItem = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.BtnBack = New Guna.UI2.WinForms.Guna2CircleButton()
        Me.DG_EditItems = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.Lbl_EditProduct = New System.Windows.Forms.Label()
        Me.Panel_AllProduct.SuspendLayout()
        Me.PanelLogin.SuspendLayout()
        CType(Me.ValidSellingPrice, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ValidPurchasePrice, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Valid_ItemType, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Valid_Disease, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Valid_ItemName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DG_EditItems, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ElipseEditItemForm
        '
        Me.ElipseEditItemForm.TargetControl = Me
        '
        'Panel_AllProduct
        '
        Me.Panel_AllProduct.BackColor = System.Drawing.Color.Transparent
        Me.Panel_AllProduct.Controls.Add(Me.PanelLogin)
        Me.Panel_AllProduct.Controls.Add(Me.BtnBack)
        Me.Panel_AllProduct.Controls.Add(Me.DG_EditItems)
        Me.Panel_AllProduct.Controls.Add(Me.Lbl_EditProduct)
        Me.Panel_AllProduct.Location = New System.Drawing.Point(0, 0)
        Me.Panel_AllProduct.Name = "Panel_AllProduct"
        Me.Panel_AllProduct.Size = New System.Drawing.Size(767, 548)
        Me.Panel_AllProduct.TabIndex = 6
        '
        'PanelLogin
        '
        Me.PanelLogin.BackColor = System.Drawing.Color.Transparent
        Me.PanelLogin.Controls.Add(Me.ComboItemType)
        Me.PanelLogin.Controls.Add(Me.LblDescription)
        Me.PanelLogin.Controls.Add(Me.TxtDescription)
        Me.PanelLogin.Controls.Add(Me.LblSellingPrice)
        Me.PanelLogin.Controls.Add(Me.ValidSellingPrice)
        Me.PanelLogin.Controls.Add(Me.TxtSellingPrice)
        Me.PanelLogin.Controls.Add(Me.LblPurchasePrice)
        Me.PanelLogin.Controls.Add(Me.ValidPurchasePrice)
        Me.PanelLogin.Controls.Add(Me.TxtPurchasePrice)
        Me.PanelLogin.Controls.Add(Me.LblDisease)
        Me.PanelLogin.Controls.Add(Me.Valid_ItemType)
        Me.PanelLogin.Controls.Add(Me.Valid_Disease)
        Me.PanelLogin.Controls.Add(Me.TxtDisease)
        Me.PanelLogin.Controls.Add(Me.LblType)
        Me.PanelLogin.Controls.Add(Me.LblName)
        Me.PanelLogin.Controls.Add(Me.Valid_ItemName)
        Me.PanelLogin.Controls.Add(Me.LblEditDetails)
        Me.PanelLogin.Controls.Add(Me.TxtItemName)
        Me.PanelLogin.Controls.Add(Me.BtnEditItem)
        Me.PanelLogin.FillColor = System.Drawing.SystemColors.ActiveCaption
        Me.PanelLogin.Location = New System.Drawing.Point(12, 289)
        Me.PanelLogin.Name = "PanelLogin"
        Me.PanelLogin.Radius = 3
        Me.PanelLogin.ShadowColor = System.Drawing.Color.Black
        Me.PanelLogin.ShadowDepth = 120
        Me.PanelLogin.ShadowShift = 6
        Me.PanelLogin.Size = New System.Drawing.Size(743, 252)
        Me.PanelLogin.TabIndex = 10
        '
        'ComboItemType
        '
        Me.ComboItemType.Animated = True
        Me.ComboItemType.BackColor = System.Drawing.Color.Transparent
        Me.ComboItemType.BorderRadius = 6
        Me.ComboItemType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.ComboItemType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboItemType.FocusedColor = System.Drawing.Color.Empty
        Me.ComboItemType.FocusedState.Parent = Me.ComboItemType
        Me.ComboItemType.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.ComboItemType.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.ComboItemType.FormattingEnabled = True
        Me.ComboItemType.HoverState.Parent = Me.ComboItemType
        Me.ComboItemType.ItemHeight = 25
        Me.ComboItemType.Items.AddRange(New Object() {"Tablet", "Capsules", "Syrup", "Drops", "Injection"})
        Me.ComboItemType.ItemsAppearance.Parent = Me.ComboItemType
        Me.ComboItemType.Location = New System.Drawing.Point(167, 105)
        Me.ComboItemType.Name = "ComboItemType"
        Me.ComboItemType.ShadowDecoration.Parent = Me.ComboItemType
        Me.ComboItemType.Size = New System.Drawing.Size(156, 31)
        Me.ComboItemType.TabIndex = 24
        '
        'LblDescription
        '
        Me.LblDescription.AutoSize = True
        Me.LblDescription.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDescription.Location = New System.Drawing.Point(373, 151)
        Me.LblDescription.Name = "LblDescription"
        Me.LblDescription.Size = New System.Drawing.Size(120, 25)
        Me.LblDescription.TabIndex = 23
        Me.LblDescription.Text = "Description :"
        '
        'TxtDescription
        '
        Me.TxtDescription.Animated = True
        Me.TxtDescription.BackColor = System.Drawing.Color.Transparent
        Me.TxtDescription.BorderRadius = 8
        Me.TxtDescription.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtDescription.DefaultText = ""
        Me.TxtDescription.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TxtDescription.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TxtDescription.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtDescription.DisabledState.Parent = Me.TxtDescription
        Me.TxtDescription.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtDescription.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtDescription.FocusedState.Parent = Me.TxtDescription
        Me.TxtDescription.Font = New System.Drawing.Font("Lucida Console", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDescription.ForeColor = System.Drawing.Color.Black
        Me.TxtDescription.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtDescription.HoverState.Parent = Me.TxtDescription
        Me.TxtDescription.Location = New System.Drawing.Point(517, 151)
        Me.TxtDescription.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.TxtDescription.Multiline = True
        Me.TxtDescription.Name = "TxtDescription"
        Me.TxtDescription.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtDescription.PlaceholderText = ""
        Me.TxtDescription.SelectedText = ""
        Me.TxtDescription.ShadowDecoration.Depth = 6
        Me.TxtDescription.ShadowDecoration.Enabled = True
        Me.TxtDescription.ShadowDecoration.Parent = Me.TxtDescription
        Me.TxtDescription.Size = New System.Drawing.Size(198, 48)
        Me.TxtDescription.TabIndex = 21
        '
        'LblSellingPrice
        '
        Me.LblSellingPrice.AutoSize = True
        Me.LblSellingPrice.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSellingPrice.Location = New System.Drawing.Point(373, 106)
        Me.LblSellingPrice.Name = "LblSellingPrice"
        Me.LblSellingPrice.Size = New System.Drawing.Size(131, 25)
        Me.LblSellingPrice.TabIndex = 20
        Me.LblSellingPrice.Text = "Sellling Price :"
        '
        'ValidSellingPrice
        '
        Me.ValidSellingPrice.BackColor = System.Drawing.Color.Transparent
        Me.ValidSellingPrice.Image = CType(resources.GetObject("ValidSellingPrice.Image"), System.Drawing.Image)
        Me.ValidSellingPrice.Location = New System.Drawing.Point(677, 106)
        Me.ValidSellingPrice.Name = "ValidSellingPrice"
        Me.ValidSellingPrice.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.ValidSellingPrice.ShadowDecoration.Parent = Me.ValidSellingPrice
        Me.ValidSellingPrice.Size = New System.Drawing.Size(15, 29)
        Me.ValidSellingPrice.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ValidSellingPrice.TabIndex = 19
        Me.ValidSellingPrice.TabStop = False
        Me.ValidSellingPrice.Visible = False
        '
        'TxtSellingPrice
        '
        Me.TxtSellingPrice.Animated = True
        Me.TxtSellingPrice.BackColor = System.Drawing.Color.Transparent
        Me.TxtSellingPrice.BorderRadius = 8
        Me.TxtSellingPrice.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtSellingPrice.DefaultText = ""
        Me.TxtSellingPrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TxtSellingPrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TxtSellingPrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtSellingPrice.DisabledState.Parent = Me.TxtSellingPrice
        Me.TxtSellingPrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtSellingPrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtSellingPrice.FocusedState.Parent = Me.TxtSellingPrice
        Me.TxtSellingPrice.Font = New System.Drawing.Font("Lucida Console", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSellingPrice.ForeColor = System.Drawing.Color.Black
        Me.TxtSellingPrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtSellingPrice.HoverState.Parent = Me.TxtSellingPrice
        Me.TxtSellingPrice.Location = New System.Drawing.Point(517, 106)
        Me.TxtSellingPrice.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.TxtSellingPrice.Name = "TxtSellingPrice"
        Me.TxtSellingPrice.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtSellingPrice.PlaceholderText = ""
        Me.TxtSellingPrice.SelectedText = ""
        Me.TxtSellingPrice.ShadowDecoration.Depth = 6
        Me.TxtSellingPrice.ShadowDecoration.Enabled = True
        Me.TxtSellingPrice.ShadowDecoration.Parent = Me.TxtSellingPrice
        Me.TxtSellingPrice.Size = New System.Drawing.Size(156, 30)
        Me.TxtSellingPrice.TabIndex = 18
        '
        'LblPurchasePrice
        '
        Me.LblPurchasePrice.AutoSize = True
        Me.LblPurchasePrice.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPurchasePrice.Location = New System.Drawing.Point(373, 61)
        Me.LblPurchasePrice.Name = "LblPurchasePrice"
        Me.LblPurchasePrice.Size = New System.Drawing.Size(146, 25)
        Me.LblPurchasePrice.TabIndex = 17
        Me.LblPurchasePrice.Text = "Purchase Price :"
        '
        'ValidPurchasePrice
        '
        Me.ValidPurchasePrice.BackColor = System.Drawing.Color.Transparent
        Me.ValidPurchasePrice.Image = CType(resources.GetObject("ValidPurchasePrice.Image"), System.Drawing.Image)
        Me.ValidPurchasePrice.Location = New System.Drawing.Point(677, 61)
        Me.ValidPurchasePrice.Name = "ValidPurchasePrice"
        Me.ValidPurchasePrice.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.ValidPurchasePrice.ShadowDecoration.Parent = Me.ValidPurchasePrice
        Me.ValidPurchasePrice.Size = New System.Drawing.Size(15, 29)
        Me.ValidPurchasePrice.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ValidPurchasePrice.TabIndex = 16
        Me.ValidPurchasePrice.TabStop = False
        Me.ValidPurchasePrice.Visible = False
        '
        'TxtPurchasePrice
        '
        Me.TxtPurchasePrice.Animated = True
        Me.TxtPurchasePrice.BackColor = System.Drawing.Color.Transparent
        Me.TxtPurchasePrice.BorderRadius = 8
        Me.TxtPurchasePrice.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtPurchasePrice.DefaultText = ""
        Me.TxtPurchasePrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TxtPurchasePrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TxtPurchasePrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtPurchasePrice.DisabledState.Parent = Me.TxtPurchasePrice
        Me.TxtPurchasePrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtPurchasePrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtPurchasePrice.FocusedState.Parent = Me.TxtPurchasePrice
        Me.TxtPurchasePrice.Font = New System.Drawing.Font("Lucida Console", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPurchasePrice.ForeColor = System.Drawing.Color.Black
        Me.TxtPurchasePrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtPurchasePrice.HoverState.Parent = Me.TxtPurchasePrice
        Me.TxtPurchasePrice.Location = New System.Drawing.Point(517, 61)
        Me.TxtPurchasePrice.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.TxtPurchasePrice.Name = "TxtPurchasePrice"
        Me.TxtPurchasePrice.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtPurchasePrice.PlaceholderText = ""
        Me.TxtPurchasePrice.SelectedText = ""
        Me.TxtPurchasePrice.ShadowDecoration.Depth = 6
        Me.TxtPurchasePrice.ShadowDecoration.Enabled = True
        Me.TxtPurchasePrice.ShadowDecoration.Parent = Me.TxtPurchasePrice
        Me.TxtPurchasePrice.Size = New System.Drawing.Size(156, 30)
        Me.TxtPurchasePrice.TabIndex = 15
        '
        'LblDisease
        '
        Me.LblDisease.AutoSize = True
        Me.LblDisease.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDisease.Location = New System.Drawing.Point(12, 151)
        Me.LblDisease.Name = "LblDisease"
        Me.LblDisease.Size = New System.Drawing.Size(156, 25)
        Me.LblDisease.TabIndex = 14
        Me.LblDisease.Text = "Related Disease :"
        '
        'Valid_ItemType
        '
        Me.Valid_ItemType.BackColor = System.Drawing.Color.Transparent
        Me.Valid_ItemType.Image = CType(resources.GetObject("Valid_ItemType.Image"), System.Drawing.Image)
        Me.Valid_ItemType.Location = New System.Drawing.Point(325, 105)
        Me.Valid_ItemType.Name = "Valid_ItemType"
        Me.Valid_ItemType.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.Valid_ItemType.ShadowDecoration.Parent = Me.Valid_ItemType
        Me.Valid_ItemType.Size = New System.Drawing.Size(15, 29)
        Me.Valid_ItemType.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Valid_ItemType.TabIndex = 13
        Me.Valid_ItemType.TabStop = False
        Me.Valid_ItemType.Visible = False
        '
        'Valid_Disease
        '
        Me.Valid_Disease.BackColor = System.Drawing.Color.Transparent
        Me.Valid_Disease.Image = CType(resources.GetObject("Valid_Disease.Image"), System.Drawing.Image)
        Me.Valid_Disease.Location = New System.Drawing.Point(325, 151)
        Me.Valid_Disease.Name = "Valid_Disease"
        Me.Valid_Disease.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.Valid_Disease.ShadowDecoration.Parent = Me.Valid_Disease
        Me.Valid_Disease.Size = New System.Drawing.Size(15, 29)
        Me.Valid_Disease.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Valid_Disease.TabIndex = 13
        Me.Valid_Disease.TabStop = False
        Me.Valid_Disease.Visible = False
        '
        'TxtDisease
        '
        Me.TxtDisease.Animated = True
        Me.TxtDisease.BackColor = System.Drawing.Color.Transparent
        Me.TxtDisease.BorderRadius = 8
        Me.TxtDisease.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtDisease.DefaultText = ""
        Me.TxtDisease.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TxtDisease.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TxtDisease.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtDisease.DisabledState.Parent = Me.TxtDisease
        Me.TxtDisease.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtDisease.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtDisease.FocusedState.Parent = Me.TxtDisease
        Me.TxtDisease.Font = New System.Drawing.Font("Lucida Console", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDisease.ForeColor = System.Drawing.Color.Black
        Me.TxtDisease.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtDisease.HoverState.Parent = Me.TxtDisease
        Me.TxtDisease.Location = New System.Drawing.Point(167, 151)
        Me.TxtDisease.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.TxtDisease.Name = "TxtDisease"
        Me.TxtDisease.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtDisease.PlaceholderText = ""
        Me.TxtDisease.SelectedText = ""
        Me.TxtDisease.ShadowDecoration.Depth = 6
        Me.TxtDisease.ShadowDecoration.Enabled = True
        Me.TxtDisease.ShadowDecoration.Parent = Me.TxtDisease
        Me.TxtDisease.Size = New System.Drawing.Size(156, 30)
        Me.TxtDisease.TabIndex = 12
        '
        'LblType
        '
        Me.LblType.AutoSize = True
        Me.LblType.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblType.Location = New System.Drawing.Point(12, 105)
        Me.LblType.Name = "LblType"
        Me.LblType.Size = New System.Drawing.Size(107, 25)
        Me.LblType.TabIndex = 11
        Me.LblType.Text = "Item Type :"
        '
        'LblName
        '
        Me.LblName.AutoSize = True
        Me.LblName.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblName.Location = New System.Drawing.Point(12, 61)
        Me.LblName.Name = "LblName"
        Me.LblName.Size = New System.Drawing.Size(119, 25)
        Me.LblName.TabIndex = 10
        Me.LblName.Text = "Item Name :"
        '
        'Valid_ItemName
        '
        Me.Valid_ItemName.BackColor = System.Drawing.Color.Transparent
        Me.Valid_ItemName.Image = CType(resources.GetObject("Valid_ItemName.Image"), System.Drawing.Image)
        Me.Valid_ItemName.Location = New System.Drawing.Point(325, 61)
        Me.Valid_ItemName.Name = "Valid_ItemName"
        Me.Valid_ItemName.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.Valid_ItemName.ShadowDecoration.Parent = Me.Valid_ItemName
        Me.Valid_ItemName.Size = New System.Drawing.Size(15, 29)
        Me.Valid_ItemName.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Valid_ItemName.TabIndex = 9
        Me.Valid_ItemName.TabStop = False
        Me.Valid_ItemName.Visible = False
        '
        'LblEditDetails
        '
        Me.LblEditDetails.AutoSize = True
        Me.LblEditDetails.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblEditDetails.Location = New System.Drawing.Point(12, 10)
        Me.LblEditDetails.Name = "LblEditDetails"
        Me.LblEditDetails.Size = New System.Drawing.Size(309, 30)
        Me.LblEditDetails.TabIndex = 4
        Me.LblEditDetails.Text = "Select item from Above to Edit"
        '
        'TxtItemName
        '
        Me.TxtItemName.Animated = True
        Me.TxtItemName.BackColor = System.Drawing.Color.Transparent
        Me.TxtItemName.BorderRadius = 8
        Me.TxtItemName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtItemName.DefaultText = ""
        Me.TxtItemName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TxtItemName.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TxtItemName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtItemName.DisabledState.Parent = Me.TxtItemName
        Me.TxtItemName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtItemName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtItemName.FocusedState.Parent = Me.TxtItemName
        Me.TxtItemName.Font = New System.Drawing.Font("Lucida Console", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtItemName.ForeColor = System.Drawing.Color.Black
        Me.TxtItemName.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtItemName.HoverState.Parent = Me.TxtItemName
        Me.TxtItemName.Location = New System.Drawing.Point(167, 61)
        Me.TxtItemName.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.TxtItemName.Name = "TxtItemName"
        Me.TxtItemName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtItemName.PlaceholderText = ""
        Me.TxtItemName.SelectedText = ""
        Me.TxtItemName.ShadowDecoration.Depth = 6
        Me.TxtItemName.ShadowDecoration.Enabled = True
        Me.TxtItemName.ShadowDecoration.Parent = Me.TxtItemName
        Me.TxtItemName.Size = New System.Drawing.Size(156, 30)
        Me.TxtItemName.TabIndex = 1
        '
        'BtnEditItem
        '
        Me.BtnEditItem.Animated = True
        Me.BtnEditItem.BackColor = System.Drawing.Color.Transparent
        Me.BtnEditItem.BorderRadius = 8
        Me.BtnEditItem.CheckedState.Parent = Me.BtnEditItem
        Me.BtnEditItem.CustomImages.Parent = Me.BtnEditItem
        Me.BtnEditItem.FillColor = System.Drawing.Color.PowderBlue
        Me.BtnEditItem.FillColor2 = System.Drawing.Color.LightBlue
        Me.BtnEditItem.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEditItem.ForeColor = System.Drawing.Color.Black
        Me.BtnEditItem.HoverState.Parent = Me.BtnEditItem
        Me.BtnEditItem.Location = New System.Drawing.Point(593, 207)
        Me.BtnEditItem.Name = "BtnEditItem"
        Me.BtnEditItem.ShadowDecoration.Depth = 6
        Me.BtnEditItem.ShadowDecoration.Enabled = True
        Me.BtnEditItem.ShadowDecoration.Parent = Me.BtnEditItem
        Me.BtnEditItem.Size = New System.Drawing.Size(122, 34)
        Me.BtnEditItem.TabIndex = 3
        Me.BtnEditItem.Text = "Update Item"
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
        'DG_EditItems
        '
        Me.DG_EditItems.AllowUserToAddRows = False
        Me.DG_EditItems.AllowUserToDeleteRows = False
        Me.DG_EditItems.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(203, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.DG_EditItems.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DG_EditItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DG_EditItems.BackgroundColor = System.Drawing.SystemColors.Control
        Me.DG_EditItems.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DG_EditItems.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DG_EditItems.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(181, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DG_EditItems.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DG_EditItems.ColumnHeadersHeight = 40
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(239, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(205, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DG_EditItems.DefaultCellStyle = DataGridViewCellStyle3
        Me.DG_EditItems.EnableHeadersVisualStyles = False
        Me.DG_EditItems.GridColor = System.Drawing.Color.FromArgb(CType(CType(194, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.DG_EditItems.Location = New System.Drawing.Point(17, 58)
        Me.DG_EditItems.Name = "DG_EditItems"
        Me.DG_EditItems.ReadOnly = True
        Me.DG_EditItems.RowHeadersVisible = False
        Me.DG_EditItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DG_EditItems.Size = New System.Drawing.Size(728, 220)
        Me.DG_EditItems.TabIndex = 1
        Me.DG_EditItems.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Indigo
        Me.DG_EditItems.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(203, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.DG_EditItems.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.DG_EditItems.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.DG_EditItems.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.DG_EditItems.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.DG_EditItems.ThemeStyle.BackColor = System.Drawing.SystemColors.Control
        Me.DG_EditItems.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(194, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.DG_EditItems.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.DG_EditItems.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DG_EditItems.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.DG_EditItems.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.DG_EditItems.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.DG_EditItems.ThemeStyle.HeaderStyle.Height = 40
        Me.DG_EditItems.ThemeStyle.ReadOnly = True
        Me.DG_EditItems.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.DG_EditItems.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DG_EditItems.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.DG_EditItems.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.DG_EditItems.ThemeStyle.RowsStyle.Height = 22
        Me.DG_EditItems.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.DG_EditItems.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black
        '
        'Lbl_EditProduct
        '
        Me.Lbl_EditProduct.AutoSize = True
        Me.Lbl_EditProduct.Font = New System.Drawing.Font("Franklin Gothic Medium", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_EditProduct.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Lbl_EditProduct.Location = New System.Drawing.Point(57, 11)
        Me.Lbl_EditProduct.Name = "Lbl_EditProduct"
        Me.Lbl_EditProduct.Size = New System.Drawing.Size(143, 34)
        Me.Lbl_EditProduct.TabIndex = 0
        Me.Lbl_EditProduct.Text = "Edit Items"
        '
        'EditItemForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(767, 548)
        Me.Controls.Add(Me.Panel_AllProduct)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "EditItemForm"
        Me.Text = "EditItemForm"
        Me.Panel_AllProduct.ResumeLayout(False)
        Me.Panel_AllProduct.PerformLayout()
        Me.PanelLogin.ResumeLayout(False)
        Me.PanelLogin.PerformLayout()
        CType(Me.ValidSellingPrice, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ValidPurchasePrice, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Valid_ItemType, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Valid_Disease, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Valid_ItemName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DG_EditItems, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ElipseEditItemForm As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Panel_AllProduct As Panel
    Friend WithEvents BtnBack As Guna.UI2.WinForms.Guna2CircleButton
    Friend WithEvents DG_EditItems As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents Lbl_EditProduct As Label
    Friend WithEvents PanelLogin As Guna.UI2.WinForms.Guna2ShadowPanel
    Friend WithEvents ComboItemType As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents LblDescription As Label
    Friend WithEvents TxtDescription As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents LblSellingPrice As Label
    Friend WithEvents ValidSellingPrice As Guna.UI2.WinForms.Guna2CirclePictureBox
    Friend WithEvents TxtSellingPrice As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents LblPurchasePrice As Label
    Friend WithEvents ValidPurchasePrice As Guna.UI2.WinForms.Guna2CirclePictureBox
    Friend WithEvents TxtPurchasePrice As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents LblDisease As Label
    Friend WithEvents Valid_ItemType As Guna.UI2.WinForms.Guna2CirclePictureBox
    Friend WithEvents Valid_Disease As Guna.UI2.WinForms.Guna2CirclePictureBox
    Friend WithEvents TxtDisease As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents LblType As Label
    Friend WithEvents LblName As Label
    Friend WithEvents Valid_ItemName As Guna.UI2.WinForms.Guna2CirclePictureBox
    Friend WithEvents LblEditDetails As Label
    Friend WithEvents TxtItemName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents BtnEditItem As Guna.UI2.WinForms.Guna2GradientButton
End Class
