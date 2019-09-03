Imports System.Data.OleDb
Imports System.Net
Imports System.IO

Public Class create_recipe
    Private StrConn = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = C:\Users\Ugwu Favour\Documents\Visual Studio 2010\Projects\food_recipe\food_recipe\foodrecipe.accdb"
    Private rder As OleDbDataReader
    Private cmd As OleDbCommand
    Private myconn As OleDbConnection
    Private customGroup As CustomGroupBox
    Private recipeNameValue As String = ""
    Private recipeDescriptionValue As String = ""
    Private recipeImageValue As String = ""
    Dim ingredients As New List(Of String)
    Dim count As Integer = 0

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
        myconn = New OleDbConnection(StrConn)
        Dim query As String = "select * from ingredients"

        Console.WriteLine(query)
        cmd = New OleDbCommand(query, myconn)
        Try
            myconn.Open()
            rder = cmd.ExecuteReader()

            While rder.Read()
                ingredients.Add(rder.GetString(2))
                
            End While
            myconn.Close()
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try

        Me.Controls.Add(New SelectIngredient(0, ingredients))
    End Sub

    Private Sub createRecipe_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles createRecipe.Click
        Dim c As Control
        Dim isComplete As Boolean = True

        For Each c In Me.Controls
            Dim count As Integer = 0
            If (TypeOf c Is SelectIngredient) Then
                Dim morec As Control
                For Each morec In c.Controls
                    If (TypeOf morec Is ComboBox) Then
                        If (morec.Text.Length = 0) Then
                            count += 1
                        End If
                        Console.WriteLine(morec.Text)
                    End If

                    If (TypeOf morec Is TextBox) Then
                        If (morec.Text.Length = 0) Then
                            count += 1
                        End If
                        Console.WriteLine(morec.Text)
                    End If
                Next
                If (count > 0) Then
                    isComplete = False
                End If
                Console.WriteLine(c)
            End If
        Next
        If (recipeDescriptionValue.Length = 0 Or recipeNameValue.Length = 0 Or recipeImageValue.Length = 0 Or isComplete = False) Then
            MessageBox.Show("Values cannot be empty", _
                "Error Occured")
            Return
        End If
        
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
        query = "select top 1 * from recipes order by id desc"
        cmd = New OleDbCommand(query, myconn)
        Dim lastId As Integer
        Try
            myconn.Open()
            rder = cmd.ExecuteReader()
            While rder.Read()
                lastId = rder.GetInt32(0)

            End While
            myconn.Close()
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try


        For Each c In Me.Controls
            Dim count As Integer = 0
            If (TypeOf c Is SelectIngredient) Then
                Dim morec As Control
                Dim ingredientNameValue As String = ""
                Dim ingredientQuantity As Integer
                Dim ingredientUnit As String = ""

                For Each morec In c.Controls
                    If (TypeOf morec Is ComboBox) Then
                        If (count = 0) Then
                            ingredientNameValue = morec.Text

                        Else
                            ingredientUnit = morec.Text
                        End If
                    End If

                    If (TypeOf morec Is TextBox) Then
                        ingredientQuantity = morec.Text
                        Console.WriteLine(morec.Text)
                    End If
                    count += 1
                Next
                query = "insert into recipe_ingredients (ingredient_name, quantity, unit, recipe_id) values('" & ingredientNameValue & "', '" & ingredientQuantity & "', '" & ingredientUnit & "', " & lastId & ")"
                Console.WriteLine(query)
                cmd = New OleDbCommand(query, myconn)
                Try
                    myconn.Open()
                    rder = cmd.ExecuteReader()
                    
                    myconn.Close()
                Catch ex As Exception
                    Console.WriteLine(ex.Message)
                End Try

                Console.WriteLine(c)
            End If
        Next

        

    End Sub

    Private Sub addRow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles addRow.Click
        count += 109
        Me.Controls.Add(New SelectIngredient(count, ingredients))


    End Sub

    Private Sub FlowLayoutPanel2_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs)

    End Sub
End Class