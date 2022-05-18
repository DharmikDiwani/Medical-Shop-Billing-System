Imports System.Data.SqlClient
Imports System.Data

Public Class DeleteItemForm
    Dim id As Integer
    Dim con As New SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("constr").ConnectionString)
    Dim cmd As SqlCommand
    Dim str As String
    Dim ds As SqlDataAdapter
    Dim dr As SqlDataReader
    Dim tbl As DataTable
    Private Sub DeleteItemForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Product_Form.FillRecord()

    End Sub

    Private Sub DG_DeleteItems_MouseClick(sender As Object, e As MouseEventArgs) Handles DG_DeleteItems.MouseClick
        Dim i As Integer
        i = DG_DeleteItems.CurrentRow.Index
        id = DG_DeleteItems.Item(0, i).Value
        TxtItemName.Text = DG_DeleteItems.Item(1, i).Value
        ComboItemType.Text = DG_DeleteItems.Item(2, i).Value
        TxtDisease.Text = DG_DeleteItems.Item(3, i).Value
        TxtPurchasePrice.Text = DG_DeleteItems.Item(4, i).Value
        TxtSellingPrice.Text = DG_DeleteItems.Item(5, i).Value
        Try
            TxtDescription.Text = DG_DeleteItems.Item(6, i).Value
        Catch ex As Exception
            TxtDescription.Text = ""
        End Try
    End Sub

    Public Function checkform()
        If TxtItemName.Text = "" Or TxtDisease.Text = "" Or ComboItemType.Text = "" Or TxtPurchasePrice.Text = "" Or TxtSellingPrice.Text = "" Then
            Return False
        Else
            Return True
        End If
    End Function
    Private Sub BtnEditItem_Click(sender As Object, e As EventArgs) Handles BtnEditItem.Click
        If checkform() = False Then
            Return
        End If

        str = "delete from Tbl_Products where Id=@id"
        cmd = New SqlCommand(str, con)
        With cmd.Parameters
            .AddWithValue("@Id", id)
        End With

        conn(con)
        cmd.ExecuteNonQuery()
        MsgBox("Item Deleted Succesfully !")
        TxtItemName.Text = ""
        ComboItemType.Text = ""
        TxtDisease.Text = ""
        TxtPurchasePrice.Text = ""
        TxtSellingPrice.Text = ""
        TxtDescription.Text = ""
        con.Close()
        Product_Form.FillRecord()
    End Sub

    Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles BtnBack.Click
        InstanceNewForm(MDIForm, Product_Form)

    End Sub
End Class