Imports System.Data.OleDb
Imports System.Net
Imports System.IO

Public Class Recipes
    Private StrConn = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = food_recipeDb.accdb"
    Private rder As OleDbDataReader
    Private cmd As OleDbCommand
    Private myconn As OleDbConnection
    Private customGroup As CustomGroupBox

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles createIngredient.Click
        Console.WriteLine("hello")
    End Sub

    Private Sub Recipes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        customGroup = New CustomGroupBox("name", "hello well", "trying")
        Me.Controls.Add(customGroup)
        Dim tClient As WebClient = New WebClient

        Dim tImage As Bitmap = Bitmap.FromStream(New MemoryStream(tClient.DownloadData("https://urban945.com/news/img/1560783761_super_eagles.jpg")))

        Me.PictureBox1.Image = tImage

    End Sub

    Private Sub GroupBox1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles FoodGroup.Click

    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FoodGroup.Enter

    End Sub

    Private Sub Label1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub BindingSource1_CurrentChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Recipes_LocationChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.LocationChanged

    End Sub

    Private Sub Recipes_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.MouseEnter

    End Sub

    Private Sub TextBox1_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles searchRecipe.MouseClick
        searchRecipe.Text = " "
    End Sub

    Private Sub GroupBox3_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub GroupBox2_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button1_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.MouseHover
        Label7.Text = "Delete Recipe"
    End Sub

    Private Sub Button1_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.MouseLeave
        Label7.Text = " "
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

    End Sub

    Private Sub Button3_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.MouseHover
        Label8.Text = "Edit recipe"
    End Sub

    Private Sub Button3_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.MouseLeave
        Label8.Text = " "
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click

    End Sub

    Private Sub GroupBox3_Enter_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox3.Enter

    End Sub
End Class
