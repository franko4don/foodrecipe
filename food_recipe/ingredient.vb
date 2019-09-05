Imports System.Data.OleDb

Public Class ingredient
    Private ingredientNameValue As String = ""
    Private ingredientDescriptionValue As String = ""
    Private ingredientImageValue As String = ""
    Private image As String
    Private StrConn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Ugwu Favour\Documents\Visual Studio 2010\Projects\food_recipe\food_recipe\foodrecipe.accdb"
    Private rder As OleDbDataReader
    Private cmd As OleDbCommand
    Private myconn As OleDbConnection

    Private Sub RichTextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ingredientDescription.TextChanged
        ingredientDescriptionValue = ingredientDescription.Text
    End Sub

    Private Sub ingredientName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ingredientName.TextChanged
        ingredientNameValue = ingredientName.Text

    End Sub

    Private Sub createIngredient_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles createIngredient.Click

        If (ingredientDescriptionValue.Length = 0 Or ingredientNameValue.Length = 0 Or ingredientImageValue.Length = 0) Then
            MessageBox.Show("Values cannot be empty", _
                "Error Occured")
            Return
        End If

        myconn = New OleDbConnection(StrConn)
        Dim query As String = "insert into ingredients (ingredient_name, ingredient_description, ingredient_image) values('" & ingredientNameValue & "', '" & ingredientDescriptionValue & "', '" & ingredientImageValue & "')"
        Console.WriteLine(query)
        cmd = New OleDbCommand(query, myconn)
        Try
            myconn.Open()
            rder = cmd.ExecuteReader()
            MessageBox.Show("Ingredient saved", _
                "Operation Successful")
            ingredientDescriptionValue = ""
            ingredientImageValue = ""
            ingredientNameValue = ""
            myconn.Close()
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
    End Sub

    Private Sub ingredient_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ingredientImage_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ingredientImage.TextChanged
        ingredientImageValue = ingredientImage.Text
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Hide()
        Recipes.Show()
    End Sub
End Class