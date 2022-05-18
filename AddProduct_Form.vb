Imports System.Data.SqlClient
Imports System.Data


Public Class AddProduct_Form

    Dim con As New SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("constr").ConnectionString)
    Dim cmd As SqlCommand
    Dim str As String
    Dim ds As SqlDataAdapter
    Dim dr As SqlDataReader
    Dim tbl As DataTable

    Public Function checkform()
        If TxtItemName.Text = "" Or TxtDisease.Text = "" Or ComboItemType.Text = "" Or TxtPurchasePrice.Text = "" Or TxtSellingPrice.Text = "" Then
            Return False
        Else
            Return True
        End If
    End Function
    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click

        InstanceNewForm(MDIForm, Product_Form)

    End Sub

    Private Sub TxtItemName_Enter(sender As Object, e As EventArgs) Handles TxtItemName.Enter
        Valid_ItemName.Visible = False
    End Sub

    Private Sub TxtDisease_Enter(sender As Object, e As EventArgs) Handles TxtDisease.Enter
        Valid_Disease.Visible = False
    End Sub

    Private Sub TxtPurchasePrice_Enter(sender As Object, e As EventArgs) Handles TxtPurchasePrice.Enter
        ValidPurchasePrice.Visible = False
    End Sub

    Private Sub TxtSellingPrice_Enter(sender As Object, e As EventArgs) Handles TxtSellingPrice.Enter
        ValidSellingPrice.Visible = False
    End Sub

    Private Sub TxtItemName_Leave(sender As Object, e As EventArgs) Handles TxtItemName.Leave
        If TxtItemName.Text = "" Then
            Valid_ItemName.Visible = True
        Else
            Valid_ItemName.Visible = False
        End If

    End Sub

    Private Sub TxtDisease_Leave(sender As Object, e As EventArgs) Handles TxtDisease.Leave
        If TxtDisease.Text = "" Then
            Valid_Disease.Visible = True
        Else
            Valid_Disease.Visible = False
        End If
    End Sub

    Private Sub TxtPurchasePrice_Leave(sender As Object, e As EventArgs) Handles TxtPurchasePrice.Leave
        If TxtPurchasePrice.Text = "" Then
            ValidPurchasePrice.Visible = True
        Else
            ValidPurchasePrice.Visible = False
        End If
    End Sub

    Private Sub TxtSellingPrice_Leave(sender As Object, e As EventArgs) Handles TxtSellingPrice.Leave
        If TxtSellingPrice.Text = "" Then
            ValidSellingPrice.Visible = True
        Else
            ValidSellingPrice.Visible = False
        End If
    End Sub



    Private Sub ComboItemType_Enter(sender As Object, e As EventArgs) Handles ComboItemType.Enter
        Valid_ItemType.Visible = False
    End Sub

    Private Sub ComboItemType_Leave(sender As Object, e As EventArgs) Handles ComboItemType.Leave
        If ComboItemType.Text = "" Then
            Valid_ItemType.Visible = True
        Else
            Valid_ItemType.Visible = False
        End If
    End Sub

    Private Sub BtnAddItem_Click(sender As Object, e As EventArgs) Handles BtnAddItem.Click

        If checkform() = False Then
            Return
        End If

        str = "insert into Tbl_Products values (@Itemname,@Itemtype,@Disease,@Pprice,@Sprice,@Desc)"
        cmd = New SqlCommand(str, con)
        With cmd.Parameters
            .AddWithValue("@Itemname", TxtItemName.Text)
            .AddWithValue("@Itemtype", ComboItemType.Text)
            .AddWithValue("@Disease", TxtDisease.Text)
            .AddWithValue("@Pprice", TxtPurchasePrice.Text)
            .AddWithValue("@Sprice", TxtSellingPrice.Text)
            .AddWithValue("@Desc", TxtDescription.Text)
        End With

        conn(con)
        cmd.ExecuteNonQuery()
        MsgBox("Item Added Succesfully !")
        con.Close()
        Product_Form.FillRecord()

    End Sub



    Private Sub TxtPurchasePrice_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtPurchasePrice.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Or Asc(e.KeyChar) = 46 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub TxtSellingPrice_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtSellingPrice.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Or Asc(e.KeyChar) = 46 Then
                e.Handled = True
            End If
        End If
    End Sub
End Class