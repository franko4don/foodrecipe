<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Recipes
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
        Me.createIngredient = New System.Windows.Forms.Button()
        Me.createRecipe = New System.Windows.Forms.Button()
        Me.searchRecipe = New System.Windows.Forms.TextBox()
        Me.searchBtn = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'createIngredient
        '
        Me.createIngredient.AllowDrop = True
        Me.createIngredient.BackColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.createIngredient.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.createIngredient.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.createIngredient.ForeColor = System.Drawing.Color.White
        Me.createIngredient.Location = New System.Drawing.Point(161, 31)
        Me.createIngredient.Name = "createIngredient"
        Me.createIngredient.Size = New System.Drawing.Size(166, 29)
        Me.createIngredient.TabIndex = 2
        Me.createIngredient.Text = "CREATE INGREDIENT"
        Me.createIngredient.UseVisualStyleBackColor = False
        '
        'createRecipe
        '
        Me.createRecipe.AllowDrop = True
        Me.createRecipe.BackColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.createRecipe.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.createRecipe.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.createRecipe.ForeColor = System.Drawing.Color.White
        Me.createRecipe.Location = New System.Drawing.Point(370, 31)
        Me.createRecipe.Name = "createRecipe"
        Me.createRecipe.Size = New System.Drawing.Size(166, 29)
        Me.createRecipe.TabIndex = 5
        Me.createRecipe.Text = "CREATE RECIPE"
        Me.createRecipe.UseVisualStyleBackColor = False
        '
        'searchRecipe
        '
        Me.searchRecipe.Location = New System.Drawing.Point(469, 102)
        Me.searchRecipe.Multiline = True
        Me.searchRecipe.Name = "searchRecipe"
        Me.searchRecipe.Size = New System.Drawing.Size(171, 31)
        Me.searchRecipe.TabIndex = 10
        Me.searchRecipe.Text = "SEARCH RECIPE"
        '
        'searchBtn
        '
        Me.searchBtn.BackgroundImage = Global.food_recipe.My.Resources.Resources.icon5
        Me.searchBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.searchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.searchBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.searchBtn.Location = New System.Drawing.Point(605, 105)
        Me.searchBtn.Name = "searchBtn"
        Me.searchBtn.Size = New System.Drawing.Size(33, 28)
        Me.searchBtn.TabIndex = 9
        Me.searchBtn.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.food_recipe.My.Resources.Resources.HD_Mouth_Watering_Food_Wallpapers_for_Desktop_20_acdb3e4bb37d0e3bcc26c97591d3dd6b
        Me.PictureBox1.Location = New System.Drawing.Point(10, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(145, 101)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Recipes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(668, 553)
        Me.Controls.Add(Me.searchBtn)
        Me.Controls.Add(Me.createRecipe)
        Me.Controls.Add(Me.createIngredient)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.searchRecipe)
        Me.DoubleBuffered = True
        Me.Name = "Recipes"
        Me.Text = "Recipe"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents createIngredient As System.Windows.Forms.Button
    Friend WithEvents createRecipe As System.Windows.Forms.Button
    Friend WithEvents searchBtn As System.Windows.Forms.Button
    Friend WithEvents searchRecipe As System.Windows.Forms.TextBox

End Class
