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
        Me.createRecipe = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.addRow = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.recipeImage = New System.Windows.Forms.TextBox()
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
        Me.recipeDescription.Size = New System.Drawing.Size(310, 183)
        Me.recipeDescription.TabIndex = 2
        Me.recipeDescription.Text = ""
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
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(44, 272)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(83, 13)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "RECIPE IMAGE"
        '
        'recipeImage
        '
        Me.recipeImage.Location = New System.Drawing.Point(139, 269)
        Me.recipeImage.Name = "recipeImage"
        Me.recipeImage.Size = New System.Drawing.Size(310, 20)
        Me.recipeImage.TabIndex = 19
        '
        'create_recipe
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(566, 571)
        Me.Controls.Add(Me.recipeImage)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.addRow)
        Me.Controls.Add(Me.createRecipe)
        Me.Controls.Add(Me.recipeDescription)
        Me.Controls.Add(Me.recipeName)
        Me.Name = "create_recipe"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents recipeName As System.Windows.Forms.TextBox
    Friend WithEvents recipeDescription As System.Windows.Forms.RichTextBox
    Friend WithEvents createRecipe As System.Windows.Forms.Button
    Friend WithEvents addRow As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents recipeImage As System.Windows.Forms.TextBox
End Class
