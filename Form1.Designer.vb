<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LoginForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LoginForm))
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.TxtUsername = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TxtPassword = New Guna.UI2.WinForms.Guna2TextBox()
        Me.BtnLogin = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.LblUserlogin = New System.Windows.Forms.Label()
        Me.Guna2ShadowForm1 = New Guna.UI2.WinForms.Guna2ShadowForm(Me.components)
        Me.Guna2AnimateWindow1 = New Guna.UI2.WinForms.Guna2AnimateWindow(Me.components)
        Me.Guna2DragControl1 = New Guna.UI2.WinForms.Guna2DragControl(Me.components)
        Me.PanelTop = New Guna.UI2.WinForms.Guna2Panel()
        Me.ControlClose = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.ContorlMinimize = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.PanelLogin = New Guna.UI2.WinForms.Guna2ShadowPanel()
        Me.Pic_Valid_Password = New Guna.UI2.WinForms.Guna2CirclePictureBox()
        Me.Pic_Valid_Username = New Guna.UI2.WinForms.Guna2CirclePictureBox()
        Me.PanelLogin.SuspendLayout()
        CType(Me.Pic_Valid_Password, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pic_Valid_Username, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.BorderRadius = 10
        Me.Guna2Elipse1.TargetControl = Me
        '
        'TxtUsername
        '
        Me.TxtUsername.Animated = True
        Me.TxtUsername.BackColor = System.Drawing.Color.Transparent
        Me.TxtUsername.BorderRadius = 8
        Me.TxtUsername.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtUsername.DefaultText = ""
        Me.TxtUsername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TxtUsername.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TxtUsername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtUsername.DisabledState.Parent = Me.TxtUsername
        Me.TxtUsername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtUsername.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtUsername.FocusedState.Parent = Me.TxtUsername
        Me.TxtUsername.Font = New System.Drawing.Font("Lucida Console", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtUsername.ForeColor = System.Drawing.Color.Black
        Me.TxtUsername.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtUsername.HoverState.Parent = Me.TxtUsername
        Me.TxtUsername.IconLeft = CType(resources.GetObject("TxtUsername.IconLeft"), System.Drawing.Image)
        Me.TxtUsername.Location = New System.Drawing.Point(26, 80)
        Me.TxtUsername.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.TxtUsername.Name = "TxtUsername"
        Me.TxtUsername.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtUsername.PlaceholderText = "Username"
        Me.TxtUsername.SelectedText = ""
        Me.TxtUsername.ShadowDecoration.Depth = 6
        Me.TxtUsername.ShadowDecoration.Enabled = True
        Me.TxtUsername.ShadowDecoration.Parent = Me.TxtUsername
        Me.TxtUsername.Size = New System.Drawing.Size(199, 32)
        Me.TxtUsername.TabIndex = 1
        '
        'TxtPassword
        '
        Me.TxtPassword.Animated = True
        Me.TxtPassword.BackColor = System.Drawing.Color.Transparent
        Me.TxtPassword.BorderRadius = 8
        Me.TxtPassword.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtPassword.DefaultText = ""
        Me.TxtPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TxtPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TxtPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtPassword.DisabledState.Parent = Me.TxtPassword
        Me.TxtPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtPassword.FocusedState.Parent = Me.TxtPassword
        Me.TxtPassword.Font = New System.Drawing.Font("Lucida Console", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPassword.ForeColor = System.Drawing.Color.Black
        Me.TxtPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtPassword.HoverState.Parent = Me.TxtPassword
        Me.TxtPassword.IconLeft = CType(resources.GetObject("TxtPassword.IconLeft"), System.Drawing.Image)
        Me.TxtPassword.Location = New System.Drawing.Point(26, 132)
        Me.TxtPassword.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtPassword.Name = "TxtPassword"
        Me.TxtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxtPassword.PlaceholderText = "Password"
        Me.TxtPassword.SelectedText = ""
        Me.TxtPassword.ShadowDecoration.Depth = 6
        Me.TxtPassword.ShadowDecoration.Enabled = True
        Me.TxtPassword.ShadowDecoration.Parent = Me.TxtPassword
        Me.TxtPassword.Size = New System.Drawing.Size(199, 32)
        Me.TxtPassword.TabIndex = 2
        '
        'BtnLogin
        '
        Me.BtnLogin.Animated = True
        Me.BtnLogin.BackColor = System.Drawing.Color.Transparent
        Me.BtnLogin.BorderRadius = 8
        Me.BtnLogin.CheckedState.Parent = Me.BtnLogin
        Me.BtnLogin.CustomImages.Parent = Me.BtnLogin
        Me.BtnLogin.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLogin.ForeColor = System.Drawing.Color.Black
        Me.BtnLogin.HoverState.Parent = Me.BtnLogin
        Me.BtnLogin.Location = New System.Drawing.Point(62, 204)
        Me.BtnLogin.Name = "BtnLogin"
        Me.BtnLogin.ShadowDecoration.Depth = 6
        Me.BtnLogin.ShadowDecoration.Enabled = True
        Me.BtnLogin.ShadowDecoration.Parent = Me.BtnLogin
        Me.BtnLogin.Size = New System.Drawing.Size(126, 38)
        Me.BtnLogin.TabIndex = 3
        Me.BtnLogin.Text = "Login"
        '
        'LblUserlogin
        '
        Me.LblUserlogin.AutoSize = True
        Me.LblUserlogin.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblUserlogin.Location = New System.Drawing.Point(57, 17)
        Me.LblUserlogin.Name = "LblUserlogin"
        Me.LblUserlogin.Size = New System.Drawing.Size(136, 30)
        Me.LblUserlogin.TabIndex = 4
        Me.LblUserlogin.Text = "USER LOGIN"
        '
        'Guna2DragControl1
        '
        Me.Guna2DragControl1.TargetControl = Me
        '
        'PanelTop
        '
        Me.PanelTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelTop.Location = New System.Drawing.Point(0, 0)
        Me.PanelTop.Name = "PanelTop"
        Me.PanelTop.ShadowDecoration.Parent = Me.PanelTop
        Me.PanelTop.Size = New System.Drawing.Size(781, 14)
        Me.PanelTop.TabIndex = 5
        '
        'ControlClose
        '
        Me.ControlClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ControlClose.BackColor = System.Drawing.Color.Transparent
        Me.ControlClose.FillColor = System.Drawing.Color.Transparent
        Me.ControlClose.HoverState.Parent = Me.ControlClose
        Me.ControlClose.IconColor = System.Drawing.Color.Black
        Me.ControlClose.Location = New System.Drawing.Point(736, 14)
        Me.ControlClose.Name = "ControlClose"
        Me.ControlClose.ShadowDecoration.Parent = Me.ControlClose
        Me.ControlClose.Size = New System.Drawing.Size(38, 29)
        Me.ControlClose.TabIndex = 6
        '
        'ContorlMinimize
        '
        Me.ContorlMinimize.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ContorlMinimize.BackColor = System.Drawing.Color.Transparent
        Me.ContorlMinimize.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox
        Me.ContorlMinimize.FillColor = System.Drawing.Color.Transparent
        Me.ContorlMinimize.HoverState.Parent = Me.ContorlMinimize
        Me.ContorlMinimize.IconColor = System.Drawing.Color.Black
        Me.ContorlMinimize.Location = New System.Drawing.Point(695, 14)
        Me.ContorlMinimize.Name = "ContorlMinimize"
        Me.ContorlMinimize.ShadowDecoration.Parent = Me.ContorlMinimize
        Me.ContorlMinimize.Size = New System.Drawing.Size(38, 29)
        Me.ContorlMinimize.TabIndex = 7
        '
        'PanelLogin
        '
        Me.PanelLogin.BackColor = System.Drawing.Color.Transparent
        Me.PanelLogin.Controls.Add(Me.Pic_Valid_Password)
        Me.PanelLogin.Controls.Add(Me.Pic_Valid_Username)
        Me.PanelLogin.Controls.Add(Me.TxtPassword)
        Me.PanelLogin.Controls.Add(Me.LblUserlogin)
        Me.PanelLogin.Controls.Add(Me.TxtUsername)
        Me.PanelLogin.Controls.Add(Me.BtnLogin)
        Me.PanelLogin.FillColor = System.Drawing.SystemColors.ActiveCaption
        Me.PanelLogin.Location = New System.Drawing.Point(235, 80)
        Me.PanelLogin.Name = "PanelLogin"
        Me.PanelLogin.Radius = 3
        Me.PanelLogin.ShadowColor = System.Drawing.Color.Black
        Me.PanelLogin.ShadowDepth = 120
        Me.PanelLogin.ShadowShift = 6
        Me.PanelLogin.Size = New System.Drawing.Size(251, 277)
        Me.PanelLogin.TabIndex = 8
        '
        'Pic_Valid_Password
        '
        Me.Pic_Valid_Password.BackColor = System.Drawing.Color.Transparent
        Me.Pic_Valid_Password.Image = CType(resources.GetObject("Pic_Valid_Password.Image"), System.Drawing.Image)
        Me.Pic_Valid_Password.Location = New System.Drawing.Point(226, 132)
        Me.Pic_Valid_Password.Name = "Pic_Valid_Password"
        Me.Pic_Valid_Password.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.Pic_Valid_Password.ShadowDecoration.Parent = Me.Pic_Valid_Password
        Me.Pic_Valid_Password.Size = New System.Drawing.Size(15, 29)
        Me.Pic_Valid_Password.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Pic_Valid_Password.TabIndex = 9
        Me.Pic_Valid_Password.TabStop = False
        Me.Pic_Valid_Password.Visible = False
        '
        'Pic_Valid_Username
        '
        Me.Pic_Valid_Username.BackColor = System.Drawing.Color.Transparent
        Me.Pic_Valid_Username.Image = CType(resources.GetObject("Pic_Valid_Username.Image"), System.Drawing.Image)
        Me.Pic_Valid_Username.Location = New System.Drawing.Point(226, 81)
        Me.Pic_Valid_Username.Name = "Pic_Valid_Username"
        Me.Pic_Valid_Username.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.Pic_Valid_Username.ShadowDecoration.Parent = Me.Pic_Valid_Username
        Me.Pic_Valid_Username.Size = New System.Drawing.Size(15, 29)
        Me.Pic_Valid_Username.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Pic_Valid_Username.TabIndex = 9
        Me.Pic_Valid_Username.TabStop = False
        Me.Pic_Valid_Username.Visible = False
        '
        'LoginForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(781, 458)
        Me.Controls.Add(Me.PanelLogin)
        Me.Controls.Add(Me.ContorlMinimize)
        Me.Controls.Add(Me.ControlClose)
        Me.Controls.Add(Me.PanelTop)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "LoginForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LoginForm"
        Me.PanelLogin.ResumeLayout(False)
        Me.PanelLogin.PerformLayout()
        CType(Me.Pic_Valid_Password, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pic_Valid_Username, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents TxtUsername As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents TxtPassword As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents BtnLogin As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents LblUserlogin As Label
    Friend WithEvents ContorlMinimize As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents ControlClose As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents PanelTop As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2ShadowForm1 As Guna.UI2.WinForms.Guna2ShadowForm
    Friend WithEvents Guna2AnimateWindow1 As Guna.UI2.WinForms.Guna2AnimateWindow
    Friend WithEvents Guna2DragControl1 As Guna.UI2.WinForms.Guna2DragControl
    Friend WithEvents PanelLogin As Guna.UI2.WinForms.Guna2ShadowPanel
    Friend WithEvents Pic_Valid_Password As Guna.UI2.WinForms.Guna2CirclePictureBox
    Friend WithEvents Pic_Valid_Username As Guna.UI2.WinForms.Guna2CirclePictureBox
End Class
