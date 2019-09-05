Imports System.Data.OleDb
Imports System.Net
Imports System.IO

Public Class Recipes
    Private StrConn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Ugwu Favour\Documents\Visual Studio 2010\Projects\food_recipe\food_recipe\foodrecipe.accdb"
    Private rder As OleDbDataReader
    Private cmd As OleDbCommand
    Private myconn As OleDbConnection
    Private customGroup As CustomGroupBox

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
       
    End Sub



    Public Sub Initialize()
        Refresh()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles createIngredient.Click
        Console.WriteLine("hello")
        Me.Hide()
        ingredient.Show()
    End Sub

    Private Sub Recipes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Dim description As String = "Dice onions and green bell pepper and set aside Blend the pepper, tomatoes and crayfish seperately and set aside steam meat with the poultry seasoning, onions, salt, thyme,............"
        'Dim link As String = "https://urban945.com/news/img/1560783761_super_eagles.jpg"
        myconn = New OleDbConnection(StrConn)
        Dim query As String = "select * from recipes"
        Console.WriteLine(query)
        cmd = New OleDbCommand(query, myconn)
        Try
            myconn.Open()
            rder = cmd.ExecuteReader()
            Dim count As Integer = 0
            While rder.Read()

                Dim another As New CustomGroupBox(rder.GetString(1), rder.GetString(2), rder.GetString(3), count, rder.GetInt32(0))
                Me.Controls.Add(another)
                count += 90

            End While
            myconn.Close()
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
        
    End Sub

    Private Sub GroupBox1_Click(ByVal sender As Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Label1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)

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

   
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub



    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub GroupBox3_Enter_1(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Label10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub createRecipe_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles createRecipe.Click
        Me.Hide()
        create_recipe.Show()
    End Sub
End Class
