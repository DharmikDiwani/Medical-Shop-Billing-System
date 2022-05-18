Imports System.Data.SqlClient
Imports System.Data

Public Class LoginForm
    Dim flag As Integer

    Dim con As New SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("constr").ConnectionString)
    Dim cmd As SqlCommand
    Dim str As String
    Dim ds As SqlDataAdapter
    Dim dr As SqlDataReader
    Dim tbl As DataTable
    Private Sub conn()
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
    End Sub
    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click
        If TxtUsername.Text = "" Or TxtPassword.Text = "" Then
            Return
        End If
        str = "select * from Tbl_Login where Username=@uname and Password=@password"
        cmd = New SqlCommand(str, con)
        With cmd.Parameters
            .AddWithValue("@uname", TxtUsername.Text)
            .AddWithValue("@password", TxtPassword.Text)
        End With
        Conn()
        dr = cmd.ExecuteReader

        If dr.HasRows Then
            MDIForm.Show()
            Me.Hide()
            dr.Close()
        Else
            MsgBox("Inalid Username or Password")
            dr.Close()
        End If
    End Sub

    Private Sub TxtUsername_Leave(sender As Object, e As EventArgs) Handles TxtUsername.Leave
        If TxtUsername.Text = "" Then
            Pic_Valid_Username.Visible = True
        Else
            Pic_Valid_Username.Visible = False
        End If
    End Sub

    Private Sub TxtPassword_Leave(sender As Object, e As EventArgs) Handles TxtPassword.Leave
        If TxtPassword.Text = "" Then
            Pic_Valid_Password.Visible = True
        Else
            Pic_Valid_Password.Visible = False
        End If
    End Sub

    Private Sub TxtPassword_Enter(sender As Object, e As EventArgs) Handles TxtPassword.Enter
        Pic_Valid_Password.Visible = False
    End Sub

    Private Sub TxtUsername_Enter(sender As Object, e As EventArgs) Handles TxtUsername.Enter
        Pic_Valid_Username.Visible = False
    End Sub
End Class
