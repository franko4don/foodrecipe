Imports System.Data.OleDb
Imports System.Net
Imports System.IO

Public Class create_recipe
    Private StrConn = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = C:\Users\Ugwu Favour\Documents\Visual Studio 2010\Projects\food_recipe\food_recipe\foodrecipe.accdb"
    Private rder As OleDbDataReader
    Private cmd As OleDbCommand
    Private myconn As OleDbConnection
    Private customGroup As CustomGroupBox
    Private recipeNameValue As String
    Private recipeDescriptionValue As String
    Private recipeImageValue As String

    Private Sub deleteIngredient_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs)
        MessageBox.Show("delete row")
    End Sub

    Private Sub Label7_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub deleteIngredient_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub deleteIngredient_MouseHover_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Label8.Text = "delete row"
    End Sub

    Private Sub deleteIngredient_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Label8.Text = " "
    End Sub

    Private Sub recipeName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles recipeName.TextChanged
        recipeNameValue = recipeName.Text
    End Sub

    Private Sub recipeDescription_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles recipeDescription.TextChanged
        recipeDescriptionValue = recipeDescription.Text
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles recipeImage.TextChanged
        recipeImageValue = recipeImage.Text
    End Sub

    Private Sub create_recipe_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Controls.Add(New SelectIngredient(0))
    End Sub

    Private Sub createRecipe_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles createRecipe.Click
        myconn = New OleDbConnection(StrConn)
        Dim query As String = "insert into recipes (recipe_name, recipe_procedure, recipe_image) values('" & recipeNameValue & "', '" & recipeDescriptionValue & "', '" & recipeImageValue & "')"
        Console.WriteLine(query)
        cmd = New OleDbCommand(query, myconn)
        Try
            myconn.Open()
            rder = cmd.ExecuteReader()
            MessageBox.Show("Recipe saved", _
                "Operation Successful")

            myconn.Close()
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
    End Sub

    Private Sub addRow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles addRow.Click
        Me.Controls.Add(New SelectIngredient(109))
    End Sub
End Class