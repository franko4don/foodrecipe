Imports System.Data.OleDb

Public Class ingredient
    Private ingredientNameValue As String
    Private ingredientDescriptionValue As String
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
        myconn = New OleDbConnection(StrConn)
        image = "favour"
        Dim query As String = "insert into ingredients (ingredient_name, ingredient_description, ingredient_image) values('hrehre', 'erfverve', 'ergwe')"
        Console.WriteLine(query)
        cmd = New OleDbCommand(query, myconn)
        Try
            myconn.Open()
            rder = cmd.ExecuteReader()
            Console.WriteLine("hello")
            'Console.WriteLine(rder.FieldCount())

            myconn.Close()
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
    End Sub

    Private Sub ingredient_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class