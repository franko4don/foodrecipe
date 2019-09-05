Imports System.Data.OleDb
Imports System.Net
Imports System.IO

Public Class generate_recipe
    Private StrConn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Ugwu Favour\Documents\Visual Studio 2010\Projects\food_recipe\food_recipe\foodrecipe.accdb"
    Private rder As OleDbDataReader
    Private cmd As OleDbCommand
    Private myconn As OleDbConnection
    Private customGroup As CustomGroupBox

    Public Property id As String

    Private ingredientReader As OleDbDataReader

    Private Sub SplitContainer1_Panel2_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles SplitContainer1.Panel2.Paint

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox1.SelectedIndexChanged

    End Sub

    Private Sub generate_recipe_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ComboBox2.Items.Add("Kg")
        ComboBox2.Items.Add("Litres")
        ComboBox2.Items.Add("Cups")
        ComboBox2.Items.Add("Sachets")
        ComboBox2.Items.Add("Tins")
        ComboBox2.Items.Add("Teaspoon")
        ComboBox2.Items.Add("Grams")
        myconn = New OleDbConnection(StrConn)
        Dim query As String = "select * from recipes where id=" & id
        Console.WriteLine(query)
        cmd = New OleDbCommand(query, myconn)
        Try
            myconn.Open()
            rder = cmd.ExecuteReader()
            Dim count As Integer = 0

            While rder.Read()
                RichTextBox1.Text = rder.GetString(2)
                RecipeName.Text = rder.GetString(1)
                Dim tClient As WebClient = New WebClient

                Dim tImage As Bitmap = Bitmap.FromStream(New MemoryStream(tClient.DownloadData(rder.GetString(3))))

                PictureBox1.Image = tImage
            End While
            myconn.Close()
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try

        query = "select * from recipe_ingredients where recipe_id=" & id
        Console.WriteLine(query)
        cmd = New OleDbCommand(query, myconn)
        Try
            myconn.Open()
            rder = cmd.ExecuteReader()

            While rder.Read()
                ComboBox1.Items.Add(rder.GetString(1))
                ListBox1.Items.Add(rder.GetString(1) & " " & rder.GetInt32(2) & " " & rder.GetString(3))
            End While
            myconn.Close()
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try


        RecipeName.Text = "Rice and beans"

    End Sub

    Private Sub RichTextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RichTextBox1.TextChanged

    End Sub

    Private Sub createIngredient_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles createIngredient.Click

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim keyIngredient As String = ComboBox1.Text

        Dim quantity As String = TextBox2.Text
        Dim mainQuantity As Integer = 0
        If (keyIngredient.Length = 0 Or IsNumeric(quantity) = False) Then
            MessageBox.Show("Complete all fields", _
                "Error Occured")
            Return
        End If
        Try
            myconn.Open()
            rder = cmd.ExecuteReader()

            While rder.Read()
                If (rder.GetString(1) = keyIngredient) Then
                    mainQuantity = rder.GetInt32(2)
                End If
            End While
           
            myconn.Close()
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try

        Try
            myconn.Open()
            rder = cmd.ExecuteReader()
            ListBox1.Items.Clear()
            While rder.Read()
                Dim nquantity As Integer = CInt(quantity)
                Dim result As Double = (nquantity * rder.GetInt32(2)) / mainQuantity
                If (rder.GetString(1) = keyIngredient) Then
                    ListBox1.Items.Add(rder.GetString(1) & " " & nquantity & " " & rder.GetString(3))
                Else


                    ListBox1.Items.Add(rder.GetString(1) & " " & result & " " & rder.GetString(3))
                End If
                Console.WriteLine(rder.GetString(1) & result)
            End While
            myconn.Close()
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try

        
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged

    End Sub
End Class