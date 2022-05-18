<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MDIForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MDIForm))
        Me.ElipseMDI = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.PanelTop = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.ContorlMinimize = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.ControlClose = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.Lbl_MedicalName = New System.Windows.Forms.Label()
        Me.BtnBilling = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.BtnProducts = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.BtnCredit = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.BtnReports = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.BtnSetting = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.BtnAbout = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.PanelLeftMDI = New Guna.UI2.WinForms.Guna2Panel()
        Me.PnlAbout = New Guna.UI2.WinForms.Guna2Panel()
        Me.PnlReports = New Guna.UI2.WinForms.Guna2Panel()
        Me.PnlSettings = New Guna.UI2.WinForms.Guna2Panel()
        Me.PnlCredit = New Guna.UI2.WinForms.Guna2Panel()
        Me.PnlBilling = New Guna.UI2.WinForms.Guna2Panel()
        Me.PnlProducts = New Guna.UI2.WinForms.Guna2Panel()
        Me.DragMDI = New Guna.UI2.WinForms.Guna2DragControl(Me.components)
        Me.PanelTop.SuspendLayout()
        Me.PanelLeftMDI.SuspendLayout()
        Me.SuspendLayout()
        '
        'ElipseMDI
        '
        Me.ElipseMDI.BorderRadius = 10
        Me.ElipseMDI.TargetControl = Me
        '
        'PanelTop
        '
        Me.PanelTop.Controls.Add(Me.ContorlMinimize)
        Me.PanelTop.Controls.Add(Me.ControlClose)
        Me.PanelTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelTop.FillColor = System.Drawing.Color.DarkGray
        Me.PanelTop.FillColor2 = System.Drawing.Color.Silver
        Me.PanelTop.Location = New System.Drawing.Point(0, 0)
        Me.PanelTop.Name = "PanelTop"
        Me.PanelTop.ShadowDecoration.Parent = Me.PanelTop
        Me.PanelTop.Size = New System.Drawing.Size(950, 22)
        Me.PanelTop.TabIndex = 2
        '
        'ContorlMinimize
        '
        Me.ContorlMinimize.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ContorlMinimize.BackColor = System.Drawing.Color.Transparent
        Me.ContorlMinimize.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox
        Me.ContorlMinimize.FillColor = System.Drawing.Color.Transparent
        Me.ContorlMinimize.HoverState.Parent = Me.ContorlMinimize
        Me.ContorlMinimize.IconColor = System.Drawing.Color.Black
        Me.ContorlMinimize.Location = New System.Drawing.Point(876, 1)
        Me.ContorlMinimize.Name = "ContorlMinimize"
        Me.ContorlMinimize.ShadowDecoration.Parent = Me.ContorlMinimize
        Me.ContorlMinimize.Size = New System.Drawing.Size(33, 19)
        Me.ContorlMinimize.TabIndex = 9
        '
        'ControlClose
        '
        Me.ControlClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ControlClose.BackColor = System.Drawing.Color.Transparent
        Me.ControlClose.FillColor = System.Drawing.Color.Transparent
        Me.ControlClose.HoverState.Parent = Me.ControlClose
        Me.ControlClose.IconColor = System.Drawing.Color.Black
        Me.ControlClose.Location = New System.Drawing.Point(912, 1)
        Me.ControlClose.Name = "ControlClose"
        Me.ControlClose.ShadowDecoration.Parent = Me.ControlClose
        Me.ControlClose.Size = New System.Drawing.Size(33, 19)
        Me.ControlClose.TabIndex = 8
        '
        'Lbl_MedicalName
        '
        Me.Lbl_MedicalName.AutoSize = True
        Me.Lbl_MedicalName.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_MedicalName.ForeColor = System.Drawing.Color.Snow
        Me.Lbl_MedicalName.Location = New System.Drawing.Point(-1, 43)
        Me.Lbl_MedicalName.Name = "Lbl_MedicalName"
        Me.Lbl_MedicalName.Size = New System.Drawing.Size(179, 21)
        Me.Lbl_MedicalName.TabIndex = 0
        Me.Lbl_MedicalName.Text = "Gujarat Medical Cornar"
        '
        'BtnBilling
        '
        Me.BtnBilling.Animated = True
        Me.BtnBilling.BorderColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(135, Byte), Integer))
        Me.BtnBilling.BorderThickness = 1
        Me.BtnBilling.CheckedState.Parent = Me.BtnBilling
        Me.BtnBilling.CustomImages.Parent = Me.BtnBilling
        Me.BtnBilling.FillColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(121, Byte), Integer))
        Me.BtnBilling.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.BtnBilling.Font = New System.Drawing.Font("Lucida Sans Unicode", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBilling.ForeColor = System.Drawing.Color.White
        Me.BtnBilling.HoverState.Parent = Me.BtnBilling
        Me.BtnBilling.Image = CType(resources.GetObject("BtnBilling.Image"), System.Drawing.Image)
        Me.BtnBilling.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.BtnBilling.ImageOffset = New System.Drawing.Point(12, 0)
        Me.BtnBilling.Location = New System.Drawing.Point(0, 181)
        Me.BtnBilling.Name = "BtnBilling"
        Me.BtnBilling.ShadowDecoration.Parent = Me.BtnBilling
        Me.BtnBilling.Size = New System.Drawing.Size(178, 53)
        Me.BtnBilling.TabIndex = 1
        Me.BtnBilling.Text = "Billing"
        '
        'BtnProducts
        '
        Me.BtnProducts.Animated = True
        Me.BtnProducts.BorderColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(135, Byte), Integer))
        Me.BtnProducts.BorderThickness = 1
        Me.BtnProducts.CheckedState.Parent = Me.BtnProducts
        Me.BtnProducts.CustomImages.Parent = Me.BtnProducts
        Me.BtnProducts.FillColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(121, Byte), Integer))
        Me.BtnProducts.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.BtnProducts.Font = New System.Drawing.Font("Lucida Sans Unicode", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnProducts.ForeColor = System.Drawing.Color.White
        Me.BtnProducts.HoverState.Parent = Me.BtnProducts
        Me.BtnProducts.Image = CType(resources.GetObject("BtnProducts.Image"), System.Drawing.Image)
        Me.BtnProducts.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.BtnProducts.ImageOffset = New System.Drawing.Point(12, 0)
        Me.BtnProducts.Location = New System.Drawing.Point(0, 129)
        Me.BtnProducts.Name = "BtnProducts"
        Me.BtnProducts.ShadowDecoration.Parent = Me.BtnProducts
        Me.BtnProducts.Size = New System.Drawing.Size(178, 53)
        Me.BtnProducts.TabIndex = 1
        Me.BtnProducts.Text = "Products"
        '
        'BtnCredit
        '
        Me.BtnCredit.Animated = True
        Me.BtnCredit.BorderColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(135, Byte), Integer))
        Me.BtnCredit.BorderThickness = 1
        Me.BtnCredit.CheckedState.Parent = Me.BtnCredit
        Me.BtnCredit.CustomImages.Parent = Me.BtnCredit
        Me.BtnCredit.FillColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(121, Byte), Integer))
        Me.BtnCredit.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.BtnCredit.Font = New System.Drawing.Font("Lucida Sans Unicode", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCredit.ForeColor = System.Drawing.Color.White
        Me.BtnCredit.HoverState.Parent = Me.BtnCredit
        Me.BtnCredit.Image = CType(resources.GetObject("BtnCredit.Image"), System.Drawing.Image)
        Me.BtnCredit.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.BtnCredit.ImageOffset = New System.Drawing.Point(12, 0)
        Me.BtnCredit.Location = New System.Drawing.Point(0, 233)
        Me.BtnCredit.Name = "BtnCredit"
        Me.BtnCredit.ShadowDecoration.Parent = Me.BtnCredit
        Me.BtnCredit.Size = New System.Drawing.Size(178, 53)
        Me.BtnCredit.TabIndex = 1
        Me.BtnCredit.Text = "Credit"
        '
        'BtnReports
        '
        Me.BtnReports.Animated = True
        Me.BtnReports.BorderColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(135, Byte), Integer))
        Me.BtnReports.BorderThickness = 1
        Me.BtnReports.CheckedState.Parent = Me.BtnReports
        Me.BtnReports.CustomImages.Parent = Me.BtnReports
        Me.BtnReports.FillColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(121, Byte), Integer))
        Me.BtnReports.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.BtnReports.Font = New System.Drawing.Font("Lucida Sans Unicode", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnReports.ForeColor = System.Drawing.Color.White
        Me.BtnReports.HoverState.Parent = Me.BtnReports
        Me.BtnReports.Image = CType(resources.GetObject("BtnReports.Image"), System.Drawing.Image)
        Me.BtnReports.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.BtnReports.ImageOffset = New System.Drawing.Point(12, 0)
        Me.BtnReports.Location = New System.Drawing.Point(0, 337)
        Me.BtnReports.Name = "BtnReports"
        Me.BtnReports.ShadowDecoration.Parent = Me.BtnReports
        Me.BtnReports.Size = New System.Drawing.Size(178, 53)
        Me.BtnReports.TabIndex = 4
        Me.BtnReports.Text = "Reports"
        '
        'BtnSetting
        '
        Me.BtnSetting.Animated = True
        Me.BtnSetting.BorderColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(135, Byte), Integer))
        Me.BtnSetting.BorderThickness = 1
        Me.BtnSetting.CheckedState.Parent = Me.BtnSetting
        Me.BtnSetting.CustomImages.Parent = Me.BtnSetting
        Me.BtnSetting.FillColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(121, Byte), Integer))
        Me.BtnSetting.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.BtnSetting.Font = New System.Drawing.Font("Lucida Sans Unicode", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSetting.ForeColor = System.Drawing.Color.White
        Me.BtnSetting.HoverState.Parent = Me.BtnSetting
        Me.BtnSetting.Image = CType(resources.GetObject("BtnSetting.Image"), System.Drawing.Image)
        Me.BtnSetting.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.BtnSetting.ImageOffset = New System.Drawing.Point(12, 0)
        Me.BtnSetting.Location = New System.Drawing.Point(0, 285)
        Me.BtnSetting.Name = "BtnSetting"
        Me.BtnSetting.ShadowDecoration.Parent = Me.BtnSetting
        Me.BtnSetting.Size = New System.Drawing.Size(178, 53)
        Me.BtnSetting.TabIndex = 3
        Me.BtnSetting.Text = "Settings"
        '
        'BtnAbout
        '
        Me.BtnAbout.Animated = True
        Me.BtnAbout.BorderColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(135, Byte), Integer))
        Me.BtnAbout.BorderThickness = 1
        Me.BtnAbout.CheckedState.Parent = Me.BtnAbout
        Me.BtnAbout.CustomImages.Parent = Me.BtnAbout
        Me.BtnAbout.FillColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(121, Byte), Integer))
        Me.BtnAbout.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.BtnAbout.Font = New System.Drawing.Font("Lucida Sans Unicode", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAbout.ForeColor = System.Drawing.Color.White
        Me.BtnAbout.HoverState.Parent = Me.BtnAbout
        Me.BtnAbout.Image = CType(resources.GetObject("BtnAbout.Image"), System.Drawing.Image)
        Me.BtnAbout.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.BtnAbout.ImageOffset = New System.Drawing.Point(12, 0)
        Me.BtnAbout.Location = New System.Drawing.Point(0, 389)
        Me.BtnAbout.Name = "BtnAbout"
        Me.BtnAbout.ShadowDecoration.Parent = Me.BtnAbout
        Me.BtnAbout.Size = New System.Drawing.Size(178, 53)
        Me.BtnAbout.TabIndex = 2
        Me.BtnAbout.Text = "About"
        '
        'PanelLeftMDI
        '
        Me.PanelLeftMDI.BackColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(121, Byte), Integer))
        Me.PanelLeftMDI.Controls.Add(Me.PnlAbout)
        Me.PanelLeftMDI.Controls.Add(Me.PnlReports)
        Me.PanelLeftMDI.Controls.Add(Me.PnlSettings)
        Me.PanelLeftMDI.Controls.Add(Me.PnlCredit)
        Me.PanelLeftMDI.Controls.Add(Me.PnlBilling)
        Me.PanelLeftMDI.Controls.Add(Me.PnlProducts)
        Me.PanelLeftMDI.Controls.Add(Me.BtnAbout)
        Me.PanelLeftMDI.Controls.Add(Me.BtnSetting)
        Me.PanelLeftMDI.Controls.Add(Me.BtnReports)
        Me.PanelLeftMDI.Controls.Add(Me.BtnCredit)
        Me.PanelLeftMDI.Controls.Add(Me.BtnProducts)
        Me.PanelLeftMDI.Controls.Add(Me.BtnBilling)
        Me.PanelLeftMDI.Controls.Add(Me.Lbl_MedicalName)
        Me.PanelLeftMDI.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelLeftMDI.Location = New System.Drawing.Point(0, 22)
        Me.PanelLeftMDI.Name = "PanelLeftMDI"
        Me.PanelLeftMDI.ShadowDecoration.Parent = Me.PanelLeftMDI
        Me.PanelLeftMDI.Size = New System.Drawing.Size(178, 553)
        Me.PanelLeftMDI.TabIndex = 3
        '
        'PnlAbout
        '
        Me.PnlAbout.FillColor = System.Drawing.Color.White
        Me.PnlAbout.Location = New System.Drawing.Point(0, 389)
        Me.PnlAbout.Name = "PnlAbout"
        Me.PnlAbout.ShadowDecoration.Parent = Me.PnlAbout
        Me.PnlAbout.Size = New System.Drawing.Size(3, 53)
        Me.PnlAbout.TabIndex = 5
        '
        'PnlReports
        '
        Me.PnlReports.FillColor = System.Drawing.Color.White
        Me.PnlReports.Location = New System.Drawing.Point(0, 337)
        Me.PnlReports.Name = "PnlReports"
        Me.PnlReports.ShadowDecoration.Parent = Me.PnlReports
        Me.PnlReports.Size = New System.Drawing.Size(3, 53)
        Me.PnlReports.TabIndex = 5
        '
        'PnlSettings
        '
        Me.PnlSettings.FillColor = System.Drawing.Color.White
        Me.PnlSettings.Location = New System.Drawing.Point(0, 285)
        Me.PnlSettings.Name = "PnlSettings"
        Me.PnlSettings.ShadowDecoration.Parent = Me.PnlSettings
        Me.PnlSettings.Size = New System.Drawing.Size(3, 53)
        Me.PnlSettings.TabIndex = 5
        '
        'PnlCredit
        '
        Me.PnlCredit.FillColor = System.Drawing.Color.White
        Me.PnlCredit.Location = New System.Drawing.Point(0, 233)
        Me.PnlCredit.Name = "PnlCredit"
        Me.PnlCredit.ShadowDecoration.Parent = Me.PnlCredit
        Me.PnlCredit.Size = New System.Drawing.Size(3, 53)
        Me.PnlCredit.TabIndex = 5
        '
        'PnlBilling
        '
        Me.PnlBilling.FillColor = System.Drawing.Color.White
        Me.PnlBilling.Location = New System.Drawing.Point(0, 181)
        Me.PnlBilling.Name = "PnlBilling"
        Me.PnlBilling.ShadowDecoration.Parent = Me.PnlBilling
        Me.PnlBilling.Size = New System.Drawing.Size(3, 53)
        Me.PnlBilling.TabIndex = 5
        '
        'PnlProducts
        '
        Me.PnlProducts.FillColor = System.Drawing.Color.White
        Me.PnlProducts.Location = New System.Drawing.Point(0, 129)
        Me.PnlProducts.Name = "PnlProducts"
        Me.PnlProducts.ShadowDecoration.Parent = Me.PnlProducts
        Me.PnlProducts.Size = New System.Drawing.Size(3, 53)
        Me.PnlProducts.TabIndex = 5
        '
        'DragMDI
        '
        Me.DragMDI.TargetControl = Me.PanelTop
        '
        'MDIForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(950, 575)
        Me.Controls.Add(Me.PanelLeftMDI)
        Me.Controls.Add(Me.PanelTop)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.IsMdiContainer = True
        Me.Name = "MDIForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MDIForm"
        Me.PanelTop.ResumeLayout(False)
        Me.PanelLeftMDI.ResumeLayout(False)
        Me.PanelLeftMDI.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ElipseMDI As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents PanelTop As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents ContorlMinimize As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents ControlClose As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents PanelLeftMDI As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents BtnAbout As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents BtnSetting As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents BtnReports As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents BtnCredit As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents BtnProducts As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents BtnBilling As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents Lbl_MedicalName As Label
    Friend WithEvents DragMDI As Guna.UI2.WinForms.Guna2DragControl
    Friend WithEvents PnlAbout As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents PnlReports As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents PnlSettings As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents PnlCredit As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents PnlBilling As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents PnlProducts As Guna.UI2.WinForms.Guna2Panel
End Class
