Imports System.Windows.Forms
Imports System.Net

Public Class SelectIngredient
    Inherits GroupBox
    Dim IngredientDropDown As ComboBox = New ComboBox
    Dim QuantityTextBox As TextBox = New TextBox
    Dim UnitDropDown As ComboBox = New ComboBox

    Public Sub New(ByVal offsetHeight As Integer, ByVal ingredients As List(Of String))

        Dim height As Integer = 99

        Me.SetBounds(12, 344 + offsetHeight, 492, height)
        Me.BackColor = Color.White

        Dim ingredientName As Label = New Label
        Dim ingredientQuantity As Label = New Label
        Dim ingredientUnit As Label = New Label

        Dim recipeImage As PictureBox = New PictureBox
        Dim recipeDeleteButton As Button = New Button
        

        Dim ingredient As String
        For Each ingredient In ingredients
            IngredientDropDown.Items.Add(ingredient)

        Next

        UnitDropDown.Items.Add("Kg")
        UnitDropDown.Items.Add("Litres")
        UnitDropDown.Items.Add("Cups")
        UnitDropDown.Items.Add("Sachets")
        UnitDropDown.Items.Add("Tins")
        UnitDropDown.Items.Add("Teaspoon")
        UnitDropDown.Items.Add("Grams")


        IngredientDropDown.SetBounds(6, 49, 178, 21)
        QuantityTextBox.SetBounds(212, 49, 73, 20)
        UnitDropDown.SetBounds(341, 49, 96, 21)

        recipeDeleteButton.SetBounds(446, 45, 24, 24)
        ingredientName.SetBounds(6, 19, 74, 13)
        ingredientQuantity.SetBounds(209, 19, 62, 13)
        ingredientUnit.SetBounds(338, 19, 33, 13)

        ingredientName.Text = "INGREDIENT"
        ingredientQuantity.Text = "QUANTITY"
        ingredientUnit.Text = "UNIT"
        recipeImage.SetBounds(6, 14, 82, 65)
        recipeImage.SizeMode = PictureBoxSizeMode.StretchImage

        recipeDeleteButton.BackgroundImage = My.Resources._error
        recipeDeleteButton.FlatStyle = FlatStyle.Flat
        recipeDeleteButton.UseVisualStyleBackColor = True
        recipeDeleteButton.BackgroundImageLayout = ImageLayout.Stretch
        recipeDeleteButton.BackColor = Color.White
        recipeDeleteButton.ForeColor = Color.Transparent

        AddHandler recipeDeleteButton.Click, AddressOf deleteMe


        Me.Controls.Add(IngredientDropDown)
        Me.Controls.Add(QuantityTextBox)
        Me.Controls.Add(recipeDeleteButton)
        Me.Controls.Add(UnitDropDown)
        Me.Controls.Add(ingredientName)
        Me.Controls.Add(ingredientQuantity)
    End Sub

    Private Sub deleteMe(ByVal sendr As Object, ByVal e As System.EventArgs)
        Dim button As Button
        food_recipe.create_recipe.Controls.Remove(Me)
        button = CType(sendr, Button)

        MessageBox.Show(button.Name)
    End Sub

    Public Function getValues() As List(Of String)
        Dim result As New List(Of String)
        result.Add(IngredientDropDown.SelectedText)
        result.Add(QuantityTextBox.Text)
        result.Add(UnitDropDown.SelectedText)
        Return result
    End Function
End Class
