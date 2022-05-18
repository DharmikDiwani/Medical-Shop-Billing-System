Public Class MDIForm
    Private Sub PanelLeftMDI_Paint(sender As Object, e As PaintEventArgs) Handles PanelLeftMDI.Paint

    End Sub
    Public Function InstanceNewForm(ByRef ParentForm As Form, ByRef Childform As Form) As Boolean

        Dim bOpen As Boolean = False
        Dim frm As Form

        For Each frm In ParentForm.MdiChildren
            If Childform.Name = frm.Name Then
                Childform.Focus()
                bOpen = True
                Exit For
            End If
        Next

        If Not bOpen Then
            With Childform
                .StartPosition = FormStartPosition.CenterScreen
                .MdiParent = ParentForm
                .Show()
            End With
        End If

        frm = Nothing

        Return bOpen

    End Function
    Private Sub BtnProducts_Click(sender As Object, e As EventArgs) Handles BtnProducts.Click
        PnlProducts.Visible = True
        PnlBilling.Visible = False
        PnlCredit.Visible = False
        PnlSettings.Visible = False
        PnlReports.Visible = False
        PnlAbout.Visible = False


        InstanceNewForm(Me, Product_Form)
        Product_Form.PnlProducts.Visible = True
        Product_Form.Panel_AllProduct.Visible = False
    End Sub

    Private Sub BtnSetting_Click(sender As Object, e As EventArgs) Handles BtnSetting.Click
        PnlProducts.Visible = False
        PnlBilling.Visible = False
        PnlCredit.Visible = False
        PnlSettings.Visible = True
        PnlReports.Visible = False
        PnlAbout.Visible = False

        InstanceNewForm(Me, Settings)
    End Sub

    Private Sub BtnAbout_Click(sender As Object, e As EventArgs) Handles BtnAbout.Click
        PnlProducts.Visible = False
        PnlBilling.Visible = False
        PnlCredit.Visible = False
        PnlSettings.Visible = False
        PnlReports.Visible = False
        PnlAbout.Visible = True

        InstanceNewForm(Me, AboutForm)
    End Sub
End Class