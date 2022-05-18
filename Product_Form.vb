Imports System.Data.SqlClient
Imports System.Data
Public Class Product_Form


    Dim con As New SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("constr").ConnectionString)
    Dim cmd As SqlCommand
    Dim str As String
    Dim ds As SqlDataAdapter
    Dim dr As SqlDataReader
    Dim tbl As DataTable



    Private Sub TilebtnAllproducts_Click(sender As Object, e As EventArgs) Handles TilebtnAllproducts.Click
        FillRecord()
        Panel_AllProduct.Visible = True
    End Sub

    Private Sub TileBtnAdd_Click(sender As Object, e As EventArgs) Handles TileBtnAdd.Click
        InstanceNewForm(MDIForm, AddProduct_Form)
    End Sub

    Private Sub TileBtnRemove_Click(sender As Object, e As EventArgs) Handles TileBtnRemove.Click
        InstanceNewForm(MDIForm, DeleteItemForm)

    End Sub
    Public Sub FillRecord()
        str = "select * from Tbl_Products"
        cmd = New SqlCommand(str, con)
        Dim da = New SqlDataAdapter(cmd)
        Dim dt As New DataTable
        da.Fill(dt)
        DG_AllItems.DataSource = dt
        EditItemForm.DG_EditItems.DataSource = dt
        DeleteItemForm.DG_DeleteItems.DataSource = dt
    End Sub
    Private Sub Product_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DB_All_Items.Tbl_Products' table. You can move, or remove it, as needed.
        ' Me.Tbl_ProductsTableAdapter1.Fill(Me.DB_All_Items.Tbl_Products)


        Panel_AllProduct.Location = New Point(0, 0)
    End Sub



    Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles BtnBack.Click
        PnlProducts.Visible = True
        Panel_AllProduct.Visible = False
    End Sub

    Private Sub TileBtnEditItem_Click(sender As Object, e As EventArgs) Handles TileBtnEditItem.Click
        InstanceNewForm(MDIForm, EditItemForm)
    End Sub
End Class