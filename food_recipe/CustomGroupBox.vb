Imports System.Windows.Forms
Imports System.Net
Imports System.IO
Imports System.Data.OleDb
Imports food_recipe


Public Class CustomGroupBox
    Inherits GroupBox
    Private StrConn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Ugwu Favour\Documents\Visual Studio 2010\Projects\food_recipe\food_recipe\foodrecipe.accdb"
    Private rder As OleDbDataReader
    Private cmd As OleDbCommand
    Private myconn As OleDbConnection
    Public Sub New(ByVal name As String, ByVal description As String, ByVal image As String, ByVal offsetHeight As Integer, ByVal id As Integer)

        Dim height As Integer = 153

        Me.SetBounds(7, height + offsetHeight, 639, 85)
        Me.BackColor = Color.White
        Dim labelName As Label = New Label
        Dim labelDescription As Label = New Label
        Dim recipeImage As PictureBox = New PictureBox
        Dim recipeDeleteButton As Button = New Button
        Dim recipeEditButton As Button = New Button

        recipeEditButton.SetBounds(604, 57, 24, 24)
        recipeDeleteButton.SetBounds(604, 15, 24, 24)
        labelName.SetBounds(108, 14, 84, 17)
        labelDescription.SetBounds(108, 35, 480, 42)
        recipeImage.SetBounds(6, 14, 82, 65)
        recipeImage.SizeMode = PictureBoxSizeMode.StretchImage

        recipeDeleteButton.BackgroundImage = My.Resources._error
        recipeDeleteButton.FlatStyle = FlatStyle.Flat
        recipeDeleteButton.UseVisualStyleBackColor = True
        recipeDeleteButton.BackgroundImageLayout = ImageLayout.Stretch
        recipeDeleteButton.BackColor = Color.White
        recipeDeleteButton.ForeColor = Color.Transparent
        recipeDeleteButton.Name = "" & id

        AddHandler recipeDeleteButton.Click, AddressOf deleteMe
        AddHandler recipeEditButton.Click, AddressOf editMe


        recipeEditButton.BackgroundImage = My.Resources.edit
        recipeEditButton.FlatStyle = FlatStyle.Flat
        recipeEditButton.UseVisualStyleBackColor = True
        recipeEditButton.BackgroundImageLayout = ImageLayout.Stretch
        recipeEditButton.BackColor = Color.White
        recipeEditButton.ForeColor = Color.Transparent
        recipeEditButton.Name = "" & id

        labelName.Font = New Drawing.Font("Microsoft San Serif", _
                               10, _
                               FontStyle.Bold)
        labelName.Text = name
        labelDescription.Text = description

        Dim tClient As WebClient = New WebClient

        Dim tImage As Bitmap = Bitmap.FromStream(New MemoryStream(tClient.DownloadData(image)))

        recipeImage.Image = tImage

        Me.Controls.Add(labelName)
        Me.Controls.Add(labelDescription)
        Me.Controls.Add(recipeImage)
        Me.Controls.Add(recipeDeleteButton)
        Me.Controls.Add(recipeEditButton)

    End Sub

    Private Sub deleteMe(ByVal sendr As Object, ByVal e As System.EventArgs)
        Dim button As Button
        myconn = New OleDbConnection(StrConn)

        button = CType(sendr, Button)


        Dim query As String = "delete from recipes where id=" & button.Name
        Console.WriteLine(query)
        cmd = New OleDbCommand(query, myconn)
        Try
            myconn.Open()
            rder = cmd.ExecuteReader()

            myconn.Close()
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
        MessageBox.Show(button.Name)
        food_recipe.Recipes.Controls.Remove(Me)
    End Sub

    Private Sub editMe(ByVal sendr As Object, ByVal e As System.EventArgs)
        Dim button As Button

        button = CType(sendr, Button)

        MessageBox.Show(button.Name)
    End Sub
End Class
