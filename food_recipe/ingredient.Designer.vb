<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ingredient
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
        Me.ingredientName = New System.Windows.Forms.TextBox()
        Me.ingredientDescription = New System.Windows.Forms.RichTextBox()
        Me.createIngredient = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ingredientPicture = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.ingredientPicture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ingredientName
        '
        Me.ingredientName.Location = New System.Drawing.Point(168, 62)
        Me.ingredientName.Name = "ingredientName"
        Me.ingredientName.Size = New System.Drawing.Size(208, 20)
        Me.ingredientName.TabIndex = 0
        '
        'ingredientDescription
        '
        Me.ingredientDescription.Location = New System.Drawing.Point(168, 98)
        Me.ingredientDescription.Name = "ingredientDescription"
        Me.ingredientDescription.Size = New System.Drawing.Size(208, 70)
        Me.ingredientDescription.TabIndex = 1
        Me.ingredientDescription.Text = ""
        '
        'createIngredient
        '
        Me.createIngredient.BackColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.createIngredient.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.createIngredient.FlatAppearance.BorderSize = 0
        Me.createIngredient.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.createIngredient.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.createIngredient.Location = New System.Drawing.Point(15, 303)
        Me.createIngredient.Name = "createIngredient"
        Me.createIngredient.Size = New System.Drawing.Size(155, 32)
        Me.createIngredient.TabIndex = 3
        Me.createIngredient.Text = "CREATE INGREDIENT"
        Me.createIngredient.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(32, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "CREATE INGREDIENT"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(108, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "INGREDIENT NAME"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 112)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(150, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "INGREDIENT DESCRIPTION"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 228)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(124, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "INGREDIENT PICTURE"
        '
        'ingredientPicture
        '
        Me.ingredientPicture.Image = Global.food_recipe.My.Resources.Resources.img15
        Me.ingredientPicture.Location = New System.Drawing.Point(168, 195)
        Me.ingredientPicture.Name = "ingredientPicture"
        Me.ingredientPicture.Size = New System.Drawing.Size(95, 86)
        Me.ingredientPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ingredientPicture.TabIndex = 2
        Me.ingredientPicture.TabStop = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(192, 303)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(155, 32)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "BACK"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'ingredient
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(397, 352)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.createIngredient)
        Me.Controls.Add(Me.ingredientPicture)
        Me.Controls.Add(Me.ingredientDescription)
        Me.Controls.Add(Me.ingredientName)
        Me.Name = "ingredient"
        Me.Text = "ingredient"
        CType(Me.ingredientPicture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ingredientName As System.Windows.Forms.TextBox
    Friend WithEvents ingredientDescription As System.Windows.Forms.RichTextBox
    Friend WithEvents ingredientPicture As System.Windows.Forms.PictureBox
    Friend WithEvents createIngredient As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
