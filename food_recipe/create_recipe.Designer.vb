<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class create_recipe
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.recipeName = New System.Windows.Forms.TextBox()
        Me.recipeDescription = New System.Windows.Forms.RichTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.createRecipe = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.display = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.addRow = New System.Windows.Forms.Button()
        Me.deleteIngredient = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'recipeName
        '
        Me.recipeName.Location = New System.Drawing.Point(139, 12)
        Me.recipeName.Name = "recipeName"
        Me.recipeName.Size = New System.Drawing.Size(310, 20)
        Me.recipeName.TabIndex = 1
        '
        'recipeDescription
        '
        Me.recipeDescription.Location = New System.Drawing.Point(139, 63)
        Me.recipeDescription.Name = "recipeDescription"
        Me.recipeDescription.Size = New System.Drawing.Size(310, 232)
        Me.recipeDescription.TabIndex = 2
        Me.recipeDescription.Text = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "INGREDIENT"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(338, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(33, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "UNIT"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(209, 19)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "QUANTITY"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"RICE", "BEANS", "SALT", "SEASONING", "CRAYFISH", "OIL", "FLOUR", "BAKING POWDER", "MAGRINE", "EGG", "Chicken", "Milk", "Garlic", "Black pepper", "Oultry seasoning "})
        Me.ComboBox1.Location = New System.Drawing.Point(6, 49)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(178, 21)
        Me.ComboBox1.TabIndex = 7
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"Kg", "Litres", "Cups", "Pieces", "Cubes", "Sachets", "Tins", "Teaspoon", "grams"})
        Me.ComboBox2.Location = New System.Drawing.Point(341, 49)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(96, 21)
        Me.ComboBox2.TabIndex = 8
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(212, 49)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(73, 20)
        Me.TextBox2.TabIndex = 9
        '
        'createRecipe
        '
        Me.createRecipe.BackColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.createRecipe.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.createRecipe.ForeColor = System.Drawing.Color.White
        Me.createRecipe.Location = New System.Drawing.Point(12, 483)
        Me.createRecipe.Name = "createRecipe"
        Me.createRecipe.Size = New System.Drawing.Size(112, 31)
        Me.createRecipe.TabIndex = 10
        Me.createRecipe.Text = "CREATE"
        Me.createRecipe.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(317, 313)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(89, 13)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "ADD NEW ROW"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.display)
        Me.GroupBox1.Controls.Add(Me.deleteIngredient)
        Me.GroupBox1.Controls.Add(Me.TextBox2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.ComboBox2)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 344)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(492, 99)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(44, 15)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 13)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "RECIPE NAME"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(44, 63)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(75, 13)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "PROCEDURE"
        '
        'display
        '
        Me.display.AutoSize = True
        Me.display.Location = New System.Drawing.Point(436, 23)
        Me.display.Name = "display"
        Me.display.Size = New System.Drawing.Size(0, 13)
        Me.display.TabIndex = 15
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.White
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(454, 367)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(0, 13)
        Me.Label8.TabIndex = 16
        '
        'addRow
        '
        Me.addRow.BackColor = System.Drawing.Color.White
        Me.addRow.BackgroundImage = Global.food_recipe.My.Resources.Resources.plus
        Me.addRow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.addRow.FlatAppearance.BorderSize = 0
        Me.addRow.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.addRow.ForeColor = System.Drawing.Color.White
        Me.addRow.Location = New System.Drawing.Point(412, 301)
        Me.addRow.Name = "addRow"
        Me.addRow.Size = New System.Drawing.Size(37, 37)
        Me.addRow.TabIndex = 11
        Me.addRow.UseVisualStyleBackColor = False
        '
        'deleteIngredient
        '
        Me.deleteIngredient.BackgroundImage = Global.food_recipe.My.Resources.Resources._error
        Me.deleteIngredient.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.deleteIngredient.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.deleteIngredient.ForeColor = System.Drawing.Color.White
        Me.deleteIngredient.Location = New System.Drawing.Point(446, 45)
        Me.deleteIngredient.Name = "deleteIngredient"
        Me.deleteIngredient.Size = New System.Drawing.Size(24, 24)
        Me.deleteIngredient.TabIndex = 13
        Me.deleteIngredient.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(171, 483)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(112, 31)
        Me.Button1.TabIndex = 17
        Me.Button1.Text = "BACK"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'create_recipe
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(566, 571)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.addRow)
        Me.Controls.Add(Me.createRecipe)
        Me.Controls.Add(Me.recipeDescription)
        Me.Controls.Add(Me.recipeName)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "create_recipe"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents recipeName As System.Windows.Forms.TextBox
    Friend WithEvents recipeDescription As System.Windows.Forms.RichTextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents createRecipe As System.Windows.Forms.Button
    Friend WithEvents addRow As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents deleteIngredient As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents display As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
